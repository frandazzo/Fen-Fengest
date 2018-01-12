Imports WIN.DOMAIN.FED_SERVICES

Public Class ItemContabile
    Inherits AbstractDocumento
    Implements IItemDescriptors






#Region "Costruttori"

    Public Sub New()

    End Sub
    ''' <summary>
    ''' Costruttore che imposta per ogni posizione la data di registrazione e la data documento cosi come il documento padre
    ''' </summary>
    ''' <param name="Documento"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Documento As AbstractDocumento, ByVal Note As String, ByVal Importo As Moneta, ByVal Conto As Conto)
        If Importo Is Nothing Then Throw New Exception("Impossibile creare una nuova posizione documento. L'importo è nullo")
        If Documento Is Nothing Then Throw New Exception("Impossibile creare una nuova posizione documento. Il Documento cui attribuire la nuova posizione è nullo")
        If Conto Is Nothing Then Throw New Exception("Impossibile creare una nuova posizione documento. Il conto è nullo")
        MyBase.DataDocumento = Documento.DataDocumento
        MyBase.DataRegistrazione = Documento.DataRegistrazione
        m_DocumentoPadre = Documento
        m_note = Note
        m_Conto = Conto
        m_Importo = Importo
    End Sub

#End Region



#Region "Variabili protette Descrittori"


    'Variabili presenti nell'interfaccia descrittore
    '***************************************************
    '***************************************************
    Protected m_SoggettoEsecutore As Azienda = New AziendaNonSpecificata
    Protected m_Utente As IUtente = New UtenteNonSpecificato
    ' variabile impostata dall'oggetto utente per dire che c'è un la posizione è congrua o no
    Protected m_Congruita As IValuableForCongruity.Congruita = IValuableForCongruity.Congruita.NonCongrua
    Protected m_QuotaMedia As Moneta = New Moneta(0.0, Moneta.Valuta.Euro)
    Protected m_Conto As Conto = New ContoNullo
    Protected m_Importo As Moneta = New Moneta(0.0, Moneta.Valuta.Euro)
    Protected m_ImportoRistorno As Moneta = New Moneta(0.0, Moneta.Valuta.Euro)
    Protected m_DocumentoPadre As DocumentoContabile = New DocumentoNullo
    Protected m_Referente As Referente = New ReferenteNullo
    Protected m_Competenza As AbstractPeriodo = New PeriodoNullo
    Protected m_TredicesimaInclusa As Boolean = False
    Protected m_QuattordicesimaInclusa As Boolean = False
    Protected m_DocumentoRistorno As DocumentoContabile = New DocumentoNullo
    Protected m_settore As Settore = New SettoreNullo
    Protected m_AziendaImpiego As Azienda = New AziendaNonSpecificata
    Protected m_ContrattoApplicato As TipoContratto = New TipoContrattoNullo
    Protected m_LivelloInquadramento As String = ""
    Protected m_OreLavorate As Double = 0
    Protected m_OreMalattia As Double = 0
    Protected m_prestazione As Prestazione = New PrestazioneNulla
    Protected m_Vertenza As IDocumento = New VertenzaNulla
    Protected m_SedeOperativa As SedeOperativa = New SedeOperativaNulla
    Protected m_NomeTipoPrestazione As String
    Protected m_Selected As Boolean = False
    Protected m_TipoPrestazione As ITipoPrestazione





    Public Property Selezione() As Boolean Implements IItemDescriptors.Selezione
        Get
            Return m_Selected
        End Get
        Set(ByVal value As Boolean)
            m_Selected = value
        End Set
    End Property
    '***************************************************
    '***************************************************
#End Region



#Region "Proprietà Descrittori"

    Public ReadOnly Property SoggettoEsecutore() As Azienda Implements IItemDescriptors.SoggettoEsecutore
        Get
            Return m_SoggettoEsecutore
        End Get
        'Set(ByVal value As AbstractAzienda)
        '   If value Is Nothing Then Throw New Exception("Impossibile settare un soggetto esecutore nullo per la posizione del documento.")
        '   m_SoggettoEsecutore = value
        '   m_SoggettoEsecutore.CheckCongruity(Me)
        'End Set
    End Property
    Public ReadOnly Property Utente() As IUtente Implements IItemDescriptors.Utente
        Get
            Return m_Utente
        End Get
    End Property
    Public ReadOnly Property GetCongruitaToString() As String Implements IItemDescriptors.GetCongruitaToString
        Get
            Select Case m_Congruita

                Case IValuableForCongruity.Congruita.Congrua
                    Return "Quota congrua"
                Case IValuableForCongruity.Congruita.NonCongrua
                    Return "Quota non congrua"
                Case Else
                    Throw New Exception("Impossibile ottenere il valore di congruità. Tipo congruità sconosciuto.")
            End Select
        End Get
    End Property
    Public ReadOnly Property DocumentoPadre() As DocumentoContabile Implements IItemDescriptors.DocumentoPadre
        Get
            Return m_DocumentoPadre
        End Get
    End Property
    Public ReadOnly Property Conto() As Conto Implements IItemDescriptors.Conto
        Get
            Return m_Conto
        End Get
    End Property
    Public ReadOnly Property GetQuotaMedia() As Moneta Implements IItemDescriptors.GetQuotaMedia
        Get
            Return m_QuotaMedia
        End Get
    End Property
    Public ReadOnly Property Settore() As Settore Implements IItemDescriptors.Settore
        Get
            Return m_settore
        End Get
    End Property
    Public ReadOnly Property Prestazione() As Prestazione Implements IItemDescriptors.Prestazione
        Get
            Return m_prestazione
        End Get
    End Property
    Public ReadOnly Property Vertenza() As BASEREUSE.IDocumento Implements IItemDescriptors.Vertenza
        Get
            Return m_Vertenza
        End Get
    End Property



    Public Property ImportoRistorno() As Moneta Implements IItemDescriptors.ImportoRistorno
        Get
            Return m_ImportoRistorno
        End Get
        Set(ByVal value As Moneta)
            If value Is Nothing Then Throw New Exception("Impossibile impostare un importo di ristorno. Tipo importo nullo")
            If value.Importo < 0 Then Throw New Exception("Non è possibile effettuare un ristorno negativo")
            m_ImportoRistorno = value
        End Set
    End Property
    Public Property PagamentoReferente() As DocumentoContabile Implements IItemDescriptors.PagamentoReferente
        Get
            Return m_DocumentoRistorno
        End Get
        Set(ByVal value As DocumentoContabile)
            If value Is Nothing Then Throw New Exception("Impossibile impostare il documento di ristorno. Documento nulllo")
            m_DocumentoRistorno = value
        End Set
    End Property
    ''' <summary>
    ''' Proprieta che imposta e restituisce l'azienda di impiego del lavoratore. Essa non può essere modificata se si tratta di 
    ''' di un incasso quota per il settore impianti fissi.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AziendaImpiego() As FEDERATIONARTIFACTS.Azienda Implements IItemDescriptors.AziendaImpiego
        Get
            Return m_AziendaImpiego
        End Get
        Set(ByVal value As FEDERATIONARTIFACTS.Azienda)
            If value Is Nothing Then Throw New Exception("Impossibile impostare l'azienda di impiego. Azienda nulla")
            m_AziendaImpiego = value
            m_ContrattoApplicato = value.ContrattoApplicato
        End Set
    End Property
    Public Property ContrattoApplicato() As FEDERATIONARTIFACTS.TipoContratto Implements IItemDescriptors.ContrattoApplicato
        Get
            Return m_ContrattoApplicato
        End Get
        Set(ByVal value As FEDERATIONARTIFACTS.TipoContratto)
            If value Is Nothing Then
                m_ContrattoApplicato = New TipoContrattoNullo
                Return
            End If
            m_ContrattoApplicato = value
        End Set
    End Property
    Public Property LivelloInquadramento() As String Implements IItemDescriptors.LivelloInquadramento
        Get
            Return m_LivelloInquadramento
        End Get
        Set(ByVal value As String)
            m_LivelloInquadramento = value
        End Set
    End Property
    Public Property OreLavorate() As Double Implements IItemDescriptors.OreLavorate
        Get
            Return m_OreLavorate
        End Get
        Set(ByVal value As Double)
            If Not IsNumeric(value) Then Throw New Exception("Impossibile impostare il numero di ore lavorate. Input non valido.")
            m_OreLavorate = value
        End Set
    End Property
    Public Property OreMalattia() As Double Implements IItemDescriptors.OreMalattia
        Get
            Return m_OreMalattia
        End Get
        Set(ByVal value As Double)
            If Not IsNumeric(value) Then Throw New Exception("Impossibile impostare il numero di ore malattia/infortunio. Input non valido.")
            m_OreMalattia = value
        End Set
    End Property

    Public Overridable Property Referente() As Referente Implements IItemDescriptors.Referente
        Get
            Return m_Referente
        End Get
        Set(ByVal value As Referente)
            'If Not m_DocumentoPadre.IsPosted Then
            m_Referente = value
            'Else
            '   Throw New Exception("Il documento è gia registrato e non è possibile variarne l'attributo referente. Se si è commesso un errore stornare il documento di pagamento!")
            'End If
        End Set
    End Property
    Public Overridable Property Competenza() As AbstractPeriodo Implements IItemDescriptors.Competenza
        Get
            Return m_Competenza
        End Get
        Set(ByVal value As AbstractPeriodo)
            'If Not m_DocumentoPadre.IsPosted Then
            m_Competenza = value
            'Else
            '   Throw New Exception("Il documento è gia registrato e non è possibile variarne l'attributo competenza. Se si è commesso un errore stornare il documento di pagamento!")
            'End If
        End Set
    End Property
    Public Overridable Property Tredicesima() As Boolean Implements IItemDescriptors.Tredicesima
        Get
            Return m_TredicesimaInclusa
        End Get
        Set(ByVal value As Boolean)
            'If Not m_DocumentoPadre.IsPosted Then
            m_TredicesimaInclusa = value
            'Else
            '   Throw New Exception("Il documento è gia registrato e non è possibile variarne l'attributo tredicesima. Se si è commesso un errore stornare il documento di pagamento!")
            'End If
        End Set
    End Property
    Public Overridable Property Quattordicesima() As Boolean Implements IItemDescriptors.Quattordicesima
        Get
            Return m_QuattordicesimaInclusa
        End Get
        Set(ByVal value As Boolean)
            'If Not m_DocumentoPadre.IsPosted Then
            m_QuattordicesimaInclusa = value
            'Else
            '   Throw New Exception("Il documento è gia registrato e non è possibile variarne l'attributo quattordicesima. Se si è commesso un errore stornare il documento di pagamento!")
            'End If
        End Set
    End Property
    Public Overridable Property Importo() As Moneta Implements IItemDescriptors.Importo
        Get
            Return m_Importo
        End Get
        Set(ByVal value As Moneta)
            'If Not m_DocumentoPadre.IsPosted Then
            m_Importo = value
            'Else
            '   Throw New Exception("Il documento è gia registrato e non è possibile variarne l'attributo importo. Se si è commesso un errore stornare il documento di pagamento!")
            'End If
        End Set
    End Property

    Protected Overrides Sub DoValidation()

        If Me.TipoDocumento = "IQA" Then
            If Me.AziendaImpiego.Id <> -1 And _
               Me.Settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi And _
               Me.AziendaImpiego.Id <> DirectCast(Me.DocumentoPadre, IncassoQuotaAssociativa).SoggettoEsecutore.Id Then
                ValidationErrors.Add("Non è possibile che nel settore Impianti Fissi il soggetto esecutore del pagamento della quota associativa sia diverso dall'azienda di impiego")
            End If
        End If
    End Sub

#End Region

    Public Function ToDto() As DTOItemContabile
        Dim dto As New DTOItemContabile
        dto.AziendaImpiego = Me.AziendaImpiego
        dto.Competenza = Me.Competenza
        dto.Conto = Me.Conto
        dto.DocumentoPadre = Me.DocumentoPadre
        dto.GetQuotaMedia = Me.GetQuotaMedia
        dto.Importo = Me.Importo
        If Me.ImportoRistorno.Importo < 0 Then
            dto.ImportoRistorno = Me.ImportoRistorno.Negate
        Else
            dto.ImportoRistorno = Me.ImportoRistorno
        End If
        dto.LivelloInquadramento = Me.LivelloInquadramento
        dto.OreLavorate = Me.OreLavorate
        dto.OreMalattia = Me.OreMalattia
        dto.PagamentoReferente = Me.PagamentoReferente
        dto.Prestazione = Me.Prestazione
        dto.Quattordicesima = Me.Quattordicesima
        dto.Referente = Me.Referente
        dto.Settore = Me.Settore
        dto.SoggettoEsecutore = Me.SoggettoEsecutore
        dto.TipoDocumento = Me.TipoDocumento
        dto.Tredicesima = Me.Tredicesima
        dto.Utente = Me.Utente
        dto.Vertenza = Me.Vertenza
        dto.Note = Me.Note
        dto.DataDocumento = Me.DataDocumento
        dto.DataRegistrazione = Me.DataRegistrazione
        dto.PercentualeRistornoDeleghe = Me.PercentualeRistornoDeleghe
        dto.SedeOperativa = Me.SedeOperativaAzienda
        dto.Descrizione = Me.Descrizione
        dto.Key = Me.Key
        dto.CreatoDa = Me.CreatoDa
        dto.DataCreazione = Me.DataCreazione
        dto.ModificatoDa = Me.ModificatoDa
        dto.DataModifica = Me.DataModifica
        dto.Versione = Me.Versione
        Return dto
    End Function



    Public Function ToNativeDto() As NativeDTOItemContabile
        Dim dto As New NativeDTOItemContabile
        dto.AziendaImpiego = Me.AziendaImpiego.Descrizione
        dto.Competenza = Me.Competenza
        dto.Conto = Me.Conto.Descrizione
        dto.DocumentoPadre = Me.DocumentoPadre.Key.ToString
        dto.GetQuotaMedia = Me.GetQuotaMedia.Importo
        dto.Importo = Me.Importo.Importo
        dto.ImportoRistorno = Me.ImportoRistorno.Importo
        dto.LivelloInquadramento = Me.LivelloInquadramento
        dto.OreLavorate = Me.OreLavorate
        dto.OreMalattia = Me.OreMalattia
        dto.PagamentoReferente = Me.PagamentoReferente.Key.ToString
        dto.Prestazione = Me.Prestazione.GetId.ToString
        dto.Quattordicesima = Me.Quattordicesima
        dto.Referente = Me.Referente.CompleteName
        dto.Settore = Me.Settore.Descrizione
        dto.SoggettoEsecutore = Me.SoggettoEsecutore.Descrizione
        dto.TipoDocumento = Me.TipoDocumento
        dto.Tredicesima = Me.Tredicesima
        dto.Utente = Me.Utente.CompleteName
        dto.Vertenza = Me.Vertenza.GetId.ToString
        dto.Note = Me.Note
        dto.DataDocumento = Me.DataDocumento
        dto.DataRegistrazione = Me.DataRegistrazione
        dto.PercentualeRistornoDeleghe = Me.PercentualeRistornoDeleghe
        dto.SedeOperativa = Me.SedeOperativaAzienda.Descrizione
        dto.Descrizione = Me.Descrizione
        dto.Key = Me.Key.ToString
        dto.CreatoDa = Me.CreatoDa
        dto.DataCreazione = Me.DataCreazione
        dto.ModificatoDa = Me.ModificatoDa
        dto.DataModifica = Me.DataModifica
        dto.Versione = Me.Versione
        dto.ContrattoApplicato = Me.AziendaImpiego.ContrattoApplicato.Descrizione
        Return dto
    End Function





    '#Region "Metodi utilizzati dai mapper"

    '   '''' <summary>
    '   '''' NON UTILIZZARE QUESTO METODO. UTILIZZATO SOLO DAI MAPPER. Metodo per settare il conto in cui confluisce l'importo della posizione. 
    '   '''' </summary>
    '   '''' <param name="Conto"></param>
    '   '''' <remarks></remarks>
    '   'Public Sub SetConto(ByVal Conto As Conto)
    '   '   m_Conto = Conto
    '   'End Sub

    '#End Region

#Region "Metodi per l'esecuzione di transazioni legate alla registrazione della posizione"
    ''' <summary>
    ''' Metodo sovrascrivibile. Qui si possono gestire le transazioni legate ad un particolare tipo di documento
    ''' Di default la posizione si registra sul relativo conto
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Post()

        'm_Conto.AddItem(Me)
        DoPost()

    End Sub
    Protected Overridable Sub DoPost()
        '
    End Sub
#End Region

#Region "Metodi per la collaborazione con il pagamento referenti"
    ''' <summary>
    ''' Metodo che imposta la posizione come non ristornata. Esso può essere 
    ''' usato solo dal metodo removeItem della classe PagamentoReferenti o da remove all del controllerPagamentoReferenti
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearRistorno()
        Me.m_ImportoRistorno = New Moneta(0, Moneta.Valuta.Euro)
        Me.m_DocumentoRistorno = New DocumentoNullo
    End Sub


    ''' <summary>
    ''' Proprietà che recupera la percentuale di ristorno deleghe del referente per la posizione
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PercentualeRistornoDeleghe() As Double
        Get
            Select Case MyBase.TipoDocumento
                Case "IQA"
                    If Me.m_settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
                        Return m_Referente.PercRistornoDeleghe
                    Else
                        Return m_Referente.PercRistornoDelegheImpFissi
                    End If
                Case "IQI"


                    If Not String.IsNullOrEmpty(Me.Note) Then
                        If Me.Note.Contains("EDILE") Then
                            Return 50
                        Else
                            Return m_Referente.PercRistornoInps
                        End If
                    Else
                        Return m_Referente.PercRistornoInps
                    End If





                Case "IQV"
                    Return m_Referente.PercRistornoVertenze
            End Select
            Return 0
        End Get
    End Property
    ''' <summary>
    ''' Metodo che imposta il documento di ristorno per la posizione e ne aggiunge gli importi
    ''' </summary>
    ''' <param name="Pagamento"></param>
    ''' <remarks></remarks>
    Public Sub SetPagamentoReferente(ByVal Pagamento As PagamentoReferenti)
        If Pagamento Is Nothing Then Throw New Exception("Impossibile impostare il documento di ristorno. Documento nulllo")
        m_DocumentoRistorno = Pagamento
        'SetImportiItemRistornoFor(m_DocumentoRistorno)
    End Sub
    '''' <summary>
    '''' Metodo che ricalcola gli importi delle posizioni del documento di ristorno
    '''' </summary>
    '''' <param name="Pagamento"></param>
    '''' <remarks></remarks>
    'Private Sub SetImportiItemRistornoFor(ByVal Pagamento As PagamentoReferenti)
    '   'setto l'importo della posizione sul conto referente
    '   Dim ItemPag As ItemPagamentoReferenti = Pagamento.GetItemByIdConto(m_Referente.Conto.IdConto)
    '   ItemPag.Importo = Me.ImportoRistorno.Add(ItemPag.Importo)
    '   'setto l'importo della posizione sul conto cassa
    '   ItemPag = Pagamento.GetItemByIdConto(m_SoggettoEsecutore.Conto.IdConto)
    '   ItemPag.Importo = Me.ImportoRistorno.Negate.Add(ItemPag.Importo)
    'End Sub

    ''' <summary>
    ''' Metodo che imposta l'importo di ristorno per la posizione calcolandolo 
    ''' in base alla percentuale ristorno del referente. Aggiorna l'importo per il pagamento
    ''' referente
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub SetImportoRistorno(ByVal PagamentoReferente As PagamentoReferenti) 'As BUSINESS_INFRASTRUCTURE.ADMINISTRATIVE_ARTIFACTS.Moneta
        If TypeOf (m_Referente) Is ReferenteNullo Then Throw New Exception("Impossibile calcolare la percentuale di ristorno per il referente. Tipo referente nullo")
        m_ImportoRistorno = m_Referente.CalcolaImportoRistorno(m_Importo, MyBase.m_TipoDocumento, m_settore.TipologiaSettore, Me.Note).Negate
        PagamentoReferente.CalculateImporto()
    End Sub
    ''' <summary>
    ''' Metodo che imposta l'importo di ristorno per la posizione. Aggiorna l'importo per il pagamento
    ''' referente
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Overloads Sub SetImportoRistorno(ByVal Value As Moneta, ByVal PagamentoReferente As PagamentoReferenti) 'As BUSINESS_INFRASTRUCTURE.ADMINISTRATIVE_ARTIFACTS.Moneta
        If TypeOf (m_Referente) Is ReferenteNullo Then Throw New Exception("Impossibile calcolare la percentuale di ristorno per il referente. Tipo referente nullo")
        m_ImportoRistorno = Value
        PagamentoReferente.CalculateImporto()
    End Sub

    ''' <summary>
    ''' Metodo che verifica che la quota di ristorno sia minore o uguale la quota della posizione
    ''' </summary>
    ''' <param name="ImportoRistorno"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RistornoIsLessEqualThanImporto(ByVal ImportoRistorno As Moneta)
        Return ImportoRistorno.IsSmallerEqualThan(Me.Importo.Negate)
    End Function
#End Region

    Public ReadOnly Property SedeOperativaAzienda() As FEDERATIONARTIFACTS.SedeOperativa Implements IItemDescriptors.SedeOperativaAzienda
        Get
            Return m_SedeOperativa
        End Get
    End Property
    Public Sub SetSedeOperativa(ByVal SedeOperativa As SedeOperativa)
        If Not SedeOperativa Is Nothing Then
            m_SedeOperativa = SedeOperativa
        End If
    End Sub

    'Public Property NomeTipoPrestazione() As String Implements IItemDescriptors.NomeTipoPrestazione
    '   Get
    '      Return m_NomeTipoPrestazione
    '   End Get
    '   Set(ByVal value As String)
    '      m_NomeTipoPrestazione = value
    '   End Set
    'End Property

    Public ReadOnly Property TipoPrestazione() As INTERFACES.ITipoPrestazione Implements IItemDescriptors.TipoPrestazione
        Get
            Return Prestazione.TipoPrestazione
        End Get
    End Property
End Class
