Imports WIN.BASEREUSE

Public Class Referente
   Inherits AbstractPersona
    Implements IReferente, IComparable

    Private m_Conto As IConto = DomainFactory.GetContoNullo
    Private m_PercRistornoDel As Double = 0.0
    Private m_PercRistornoDelIF As Double = 0.0
    Private m_PercRistornoVer As Double = 0.0
    Private m_PercRistornoInps As Double = 0.0
    Private m_ComponenteStruttura As Boolean = False
    Private m_UltimoRistorno As IDocumento = DomainFactory.GetDocumentoNullo

    Protected m_Responsable As String = ""
    Private m_IsCameraComunale As Boolean
    Protected m_IndirizzoSedeLegale As Indirizzo = New Indirizzo
    Protected m_ComunicazioneSedeLegale As Comunicazioni = New Comunicazioni




    Public Property ComunicazioneSedeLegale() As Comunicazioni
        Get
            Return m_Comunicazione
        End Get
        Set(ByVal value As Comunicazioni)
            m_Comunicazione = value
        End Set
    End Property


    Public Property IndirizzoSedeLegale() As Indirizzo
        Get
            Return m_IndirizzoSedeLegale
        End Get
        Set(ByVal value As Indirizzo)
            m_IndirizzoSedeLegale = value
        End Set
    End Property
    Public Property IsCameraComunale() As Boolean
        Get
            Return m_IsCameraComunale
        End Get
        Set(ByVal value As Boolean)
            m_IsCameraComunale = value
        End Set
    End Property


    Public Property Responsable() As String
        Get
            Return m_Responsable
        End Get
        Set(ByVal value As String)
            m_Responsable = value
        End Set
    End Property



    Public Overrides Function ToString() As String
        Return Me.CompleteName
    End Function
#Region "Costruttori"
    Public Sub New()

    End Sub
    Public Sub New(ByVal Nome As String, ByVal Cognome As String, ByVal Conto As IConto)
        MyBase.New(Nome, Cognome)
        If Conto Is Nothing Then Throw New Exception("Impossibile creare un referente con un conto nullo.")
        If Conto.Descrizione = "" Then Throw New Exception("Impossibile creare un referente con un tipo conto nullo.")
        m_Conto = Conto
    End Sub
    Public Sub New(ByVal Nome As String, ByVal Cognome As String, ByVal Conto As IConto, ByVal PercRistornoDeleghe As Double, ByVal ComponenteStruttura As Boolean, ByVal PercRistornoDelegheInps As Double, ByVal PercRistornoDelegheVertenza As Double, ByVal PercRistornoDelegheImpFissi As Double)
        MyBase.New(Nome, Cognome)
        If Conto Is Nothing Then Throw New Exception("Impossibile creare un referente con un conto nullo.")
        If Conto.Descrizione = "" Then Throw New Exception("Impossibile creare un referente con un tipo conto nullo.")
        If Not IsPerCent(PercRistornoDeleghe) Then Throw New Exception("Impossibile impostare la percentuale di ristorno per le deleghe di adesione. Non è un valore percentuale.")
        m_ComponenteStruttura = ComponenteStruttura
        m_PercRistornoDel = CDbl(Format(PercRistornoDeleghe, "##0.00"))
        m_PercRistornoDelIF = CDbl(Format(PercRistornoDelegheImpFissi, "##0.00"))
        m_PercRistornoVer = CDbl(Format(PercRistornoDelegheVertenza, "##0.00"))
        m_PercRistornoInps = CDbl(Format(PercRistornoDelegheInps, "##0.00"))
        m_Conto = Conto
    End Sub
#End Region
    ''' <summary>
    ''' Calcola l'importo di ristorno secondo la percetuale di ristorno associata al tipo documento
    ''' </summary>
    ''' <param name="Importo"></param>
    ''' <param name="TipoDocumento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function CalcolaImportoRistorno(ByVal Importo As Moneta, ByVal TipoDocumento As String, ByVal Settore As Settore.TipoSettore) As Moneta
        Select Case TipoDocumento
            Case "IQA"
                If Settore = FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
                    Return Moneta.GetPercOf(Importo, PercRistornoDeleghe)
                Else
                    Return Moneta.GetPercOf(Importo, Me.PercRistornoDelegheImpFissi)
                End If
            Case "IQI"
                Return Moneta.GetPercOf(Importo, Me.PercRistornoInps)
            Case "IQV"
                Return Moneta.GetPercOf(Importo, Me.PercRistornoVertenze)
            Case Else
                Throw New Exception("Impossibile calcolare l'importo di ristorno. tipo documento sconosciuto")
        End Select
    End Function

    Public Overloads Function CalcolaImportoRistorno(ByVal Importo As Moneta, ByVal TipoDocumento As String, ByVal Settore As Settore.TipoSettore, noteInps As String) As Moneta
        Select Case TipoDocumento
            Case "IQA"
                If Settore = FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
                    Return Moneta.GetPercOf(Importo, PercRistornoDeleghe)
                Else
                    Return Moneta.GetPercOf(Importo, Me.PercRistornoDelegheImpFissi)
                End If
            Case "IQI"
                If Not String.IsNullOrEmpty(noteInps) Then
                    If noteInps.Contains("EDILE") Then
                        Return Moneta.GetPercOf(Importo, 50)
                    Else
                        Return Moneta.GetPercOf(Importo, Me.PercRistornoInps)
                    End If
                Else
                    Return Moneta.GetPercOf(Importo, Me.PercRistornoInps)
                End If

            Case "IQV"
                Return Moneta.GetPercOf(Importo, Me.PercRistornoVertenze)
            Case Else
                Throw New Exception("Impossibile calcolare l'importo di ristorno. tipo documento sconosciuto")
        End Select
    End Function

#Region "Proprietà dell'oggetto"
    Public Property ComponenteStruttura() As Boolean
        Get
            Return m_ComponenteStruttura
        End Get
        Set(ByVal value As Boolean)
            m_ComponenteStruttura = value
        End Set
    End Property
    Public ReadOnly Property IdReferente() As Int32 Implements IReferente.IdReferente
        Get
            Return MyBase.Key.LongValue
        End Get
    End Property
    Public Property Conto() As IConto Implements IReferente.Conto
        Get
            Return m_Conto
        End Get
        Set(ByVal value As IConto)
            If value Is Nothing Then Throw New Exception("Impossibile creare un referente con un conto nullo.")
            If value.Descrizione = "" Then Throw New Exception("Impossibile creare un referente con un tipo conto nullo.")
            m_Conto = value
        End Set
    End Property
    Public Property PercRistornoDeleghe() As Double
        Get
            Return m_PercRistornoDel
        End Get
        Set(ByVal value As Double)
            If Not IsPerCent(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno per le deleghe di adesione per il settore edile. Non è un valore percentuale.")
            m_PercRistornoDel = CDbl(Format(value, "##0.00"))
        End Set
    End Property
    Public Property PercRistornoDelegheImpFissi() As Double
        Get
            Return m_PercRistornoDelIF
        End Get
        Set(ByVal value As Double)
            If Not IsPerCent(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno per le deleghe di adesione per il settore edile. Non è un valore percentuale.")
            m_PercRistornoDelIF = CDbl(Format(value, "##0.00"))
        End Set
    End Property
    Public Property PercRistornoInps() As Double
        Get
            Return m_PercRistornoInps
        End Get
        Set(ByVal value As Double)
            If Not IsPerCent(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno per le deleghe Inps. Non è un valore percentuale.")
            m_PercRistornoInps = CDbl(Format(value, "##0.00"))
        End Set
    End Property
    Public Property PercRistornoVertenze() As Double
        Get
            Return m_PercRistornoVer
        End Get
        Set(ByVal value As Double)
            If Not IsPerCent(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno per le vertenze. Non è un valore percentuale.")
            m_PercRistornoVer = CDbl(Format(value, "##0.00"))
        End Set
    End Property



    Private Function IsPerCent(ByVal Perc As Double) As Boolean
        If Perc < 0 Or Perc > 100 Then Return False
        Return True
    End Function
    Protected Overrides Sub DoValidation()
        If m_Conto Is Nothing Then ValidationErrors.Add("L'oggetto referente non è stato validato. Il conto è nullo")
        If m_Conto.Descrizione = "" Then ValidationErrors.Add("L'oggetto referente non è stato validato. Il tipo conto è nullo")
    End Sub
    Public Property UltimoRistorno() As IDocumento Implements IReferente.UltimoRistorno
        Get
            Return m_UltimoRistorno
        End Get
        Set(ByVal value As IDocumento)
            If value Is Nothing Then Throw New Exception("Impossibile impostare il ristorno per il referente. Ristorno nullo.")
            If Not value.DataDocumento = DateTime.MinValue Then
                m_UltimoRistorno = IIf(m_UltimoRistorno.DataDocumento > value.DataDocumento, m_UltimoRistorno, value)
            End If
        End Set
    End Property
#End Region

    Public Function CompareTo(obj As Object) As Integer Implements System.IComparable.CompareTo
        Dim c As Referente

        Try
            c = DirectCast(obj, Referente)
        Catch ex As Exception
            c = Nothing
        End Try

        If (Not c Is Nothing) Then

            Return String.Compare(Me.CompleteName, c.CompleteName)
        Else
            Return String.Compare(Me.CompleteName, "")

        End If

        
    End Function
End Class
