Namespace FINANCIAL_ARTIFACTS
   Public Class ControllerReferenti
      Inherits AbstractController
      Private m_ControllerConti As New CONTI.ControllerConti
      Private Function Current() As Referente
         Return DirectCast(MyBase.m_current, Referente)
      End Function

#Region "Proprietà oggetto"
      Public ReadOnly Property IdReferente() As Int32
         Get
            Return m_current.Key.LongValue
         End Get
      End Property

      Public Property Nome() As String
         Get
            Return Current.Nome
         End Get
         Set(ByVal value As String)
            Current.Nome = value
         End Set
      End Property
      Public Property Cognome() As String
         Get
            Return Current.Cognome
         End Get
         Set(ByVal value As String)
            Current.Cognome = value
         End Set
      End Property
      Public ReadOnly Property CompleteName() As String
         Get
            Return Current.CompleteName
         End Get
      End Property
      Public Property ComponenteStruttura() As Boolean
         Get
            Return Current.ComponenteStruttura
         End Get
         Set(ByVal value As Boolean)
            Current.ComponenteStruttura = value
         End Set
      End Property
      Public Property PercRistornoDeleghe() As String
         Get
            Return Current.PercRistornoDeleghe
         End Get
         Set(ByVal value As String)
            If Not IsNumeric(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno delle deleghe di adesione. Valore immesso nullo o formato non corretto.")
            Current.PercRistornoDeleghe = CDbl(value)
         End Set
      End Property

      Public Property PercRistornoDelegheImpFissi() As String
         Get
            Return Current.PercRistornoDelegheImpFissi
         End Get
         Set(ByVal value As String)
            If Not IsNumeric(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno delle deleghe di adesione per gli impianti fissi. Valore immesso nullo o formato non corretto.")
            Current.PercRistornoDelegheImpFissi = CDbl(value)
         End Set
      End Property

      Public Property PercRistornoDelegheVertenza() As String
         Get
            Return Current.PercRistornoVertenze
         End Get
         Set(ByVal value As String)
            If Not IsNumeric(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno delle deleghe vertenza. Valore immesso nullo o formato non corretto.")
            Current.PercRistornoVertenze = CDbl(value)
         End Set
      End Property

      Public Property PercRistornoDelegheInps() As String
         Get
            Return Current.PercRistornoInps
         End Get
         Set(ByVal value As String)
            If Not IsNumeric(value) Then Throw New Exception("Impossibile impostare la percentuale di ristorno delle deleghe Inps. Valore immesso nullo o formato non corretto.")
            Current.PercRistornoInps = CDbl(value)
         End Set
      End Property
      Public ReadOnly Property IdConto() As Int32
         Get
            Return Current.Conto.IdConto
         End Get
      End Property
      Public ReadOnly Property DescrizioneConto() As String
         Get
            Return Current.Conto.Descrizione
         End Get
      End Property
      Public Sub SetConto(ByVal IdConto As String)

         If IsNumeric(IdConto) Then
            Dim conto As Conto = GetContoById(IdConto)
            If conto.TipologiaConto = DOMAIN.FINANCIAL.Conto.TipoConto.Referenti Then
               Current.Conto = conto
            Else
               Throw New Exception("impossibile impostare il conto per il referente. Tipo conto diverso.")
            End If
         Else
            Throw New Exception("L'Id del conto specificato non è di tipo numerico. Inserire un id nel formato corretto.")
         End If

      End Sub
      Private Function GetContoById(ByVal IdConto As Int32) As Conto
         Try
            Return m_ControllerConti.GetContoById(IdConto)
         Catch ex As Exception
            Throw New Exception("Impossibile recuperare il conto con l'id selezionato")
         End Try
      End Function

      Public ReadOnly Property IdUltimoRistorno() As String
         Get
            If Current.UltimoRistorno.GetId = -1 Then
               Return ""
            Else
               Return Current.UltimoRistorno.GetId
            End If
         End Get
      End Property
#End Region

      Public ReadOnly Property ComuneLegale() As String
         Get
            Return UCase(Current.IndirizzoSedeLegale.Comune.Descrizione)
         End Get
      End Property
      Public ReadOnly Property ProvinciaLegale() As String
         Get
            Return UCase(Current.IndirizzoSedeLegale.Provincia.Descrizione)
         End Get
      End Property
      Public ReadOnly Property ViaLegale() As String
         Get
            Return UCase(Current.IndirizzoSedeLegale.Via)
         End Get
      End Property
      Public ReadOnly Property CapLegale() As String
         Get
            Return Current.IndirizzoSedeLegale.Comune.CAP
         End Get
      End Property
      Public Sub SetIndirizzoSedeLegale(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
         Dim indirizzo As New Indirizzo
         indirizzo.Via = Via
         indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
         indirizzo.Comune = geo.GetComuneByName(NomeComune)
         Current.IndirizzoSedeLegale = indirizzo

      End Sub

      Public Property IsCameraComunale() As Boolean
         Get
            Return Current.IsCameraComunale
         End Get
         Set(ByVal value As Boolean)
            Current.IsCameraComunale = value
         End Set
      End Property


      Public ReadOnly Property TelefonoUfficio() As String
         Get
            Return Current.ComunicazioneSedeLegale.TelefonoUfficio
         End Get
      End Property
      Public ReadOnly Property Fax() As String
         Get
            Return Current.ComunicazioneSedeLegale.Fax
         End Get
      End Property
      Public ReadOnly Property Cellulare1() As String
         Get
            Return Current.ComunicazioneSedeLegale.Cellulare1
         End Get
      End Property
      Public ReadOnly Property Cellulare2() As String
         Get
            Return Current.ComunicazioneSedeLegale.Cellulare2
         End Get
      End Property
      Public ReadOnly Property Mail() As String
         Get
            Return Current.ComunicazioneSedeLegale.Mail
         End Get
      End Property
      Public Sub SetComunicazione(ByVal TelefonoUfficio As String, ByVal Fax As String, ByVal Mail As String, ByVal Cellulare1 As String, ByVal Cellulare2 As String)
         Current.Comunicazione.Mail = Mail
         Current.Comunicazione.Cellulare2 = Cellulare2
         Current.Comunicazione.Cellulare1 = Cellulare1
         Current.Comunicazione.TelefonoUfficio = TelefonoUfficio
         Current.Comunicazione.Fax = Fax
         Current.Comunicazione.TelefonoCasa = ""
      End Sub

      Public Property Responsabile() As String
         Get
            Return Current.Responsable
         End Get
         Set(ByVal value As String)
            Current.Responsable = value
         End Set
      End Property




#Region "Metodi CRUD"
      Public Overrides Function GetCategoryObject() As String
         Return "Referente"
      End Function
      ''' <summary>
      ''' Crea un'istanza vuota dell'oggetto
      ''' </summary>
      ''' <remarks></remarks>
      Public Overrides Sub CreateNew()
         'questo costruttore è utile se voglio che il client crei e salvi
         'l'oggetto in 3 passaggi distinti.
         'Client.CreateNew
         'Client.SetProperties
         'Client.Save
         MyBase.m_current = New Referente
         Current.Conto = CONTI.ControllerConti.GetContoByType("Referenti")
      End Sub
      ''' <summary>
      ''' Crea e salva l'istanza dell'oggetto complato con i parametri necessari
      ''' </summary>
      ''' <param name="Nome"></param>
      ''' <param name="Cognome"></param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal Nome As String, ByVal Cognome As String)
         'questo costruttore è utile se voglio che il client crei e salvi
         'l'oggetto in un unico passaggio.
         'Client.CreateNew(Parameters)
         Try
            MyBase.m_current = New Referente(Nome, Cognome, CONTI.ControllerConti.GetContoByType("Referenti"))
            Save()
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Friend Function GetReferenteById(ByVal IdReferente As Int32) As Referente
         Try

            LoadById(IdReferente)
         Catch ex As Exception
            Return New ReferenteNullo
         End Try
         Return Current()

      End Function
      Public Function GetIdReferente(ByVal Nome As String, ByVal Cognome As String) As Int32
         Return SearchReferente(Nome, Cognome).Id
      End Function

      Private Function SearchReferente(ByVal Nome As String, ByVal Cognome As String) As Referente
         Dim nomeref As String = Replace(Nome, "'", "''")
         Dim Cognomeref As String = Replace(Cognome, "'", "''")

         Dim qry As Query = Ps.CreateNewQuery("MapperReferente")
         Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
         main.AddCriteria(Criteria.Equal("NOME", "'" & UCase(Nomeref) & "'"))
         main.AddCriteria(Criteria.Equal("COGNOME", "'" & UCase(Cognomeref) & "'"))
         qry.AddWhereClause(main)
         Dim list As IList = qry.Execute(Ps)
         If list.Count > 0 Then Return list.Item(0)
         Return New ReferenteNullo
      End Function

#End Region



   End Class
End Namespace

