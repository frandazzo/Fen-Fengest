Imports WIN.DOMAIN.FED_SERVICES

Public Class DTOItemContabile
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
    Protected m_Vertenza As IDocumento = DomainFactory.GetVertenzaNulla
    Protected m_dataRegistrazione As DateTime = Date.MinValue
    Protected m_dataDocumento As DateTime = Date.MinValue
    Protected m_note As String = ""
    Protected m_TipoDocumento As String = ""
    Protected m_PercentualeRistornoDeleghe As Double = 0
    Protected m_sedeoperativa As SedeOperativa = New SedeOperativaNulla


    '***************************************************
    '***************************************************
#End Region

    Public ReadOnly Property TipoPrestazione() As ITipoPrestazione
        Get
            Return m_prestazione.TipoPrestazione
        End Get
    End Property


    Public Property SoggettoEsecutore() As Azienda
        Get
            Return m_SoggettoEsecutore
        End Get
        Set(ByVal value As Azienda)
            m_SoggettoEsecutore = value
        End Set
    End Property
    Public Property Utente() As IUtente
        Get
            Return m_Utente
        End Get
        Set(ByVal value As IUtente)
            m_Utente = value
        End Set
    End Property
    Public ReadOnly Property GetCongruitaToString() As String
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
    Public Property DocumentoPadre() As DocumentoContabile
        Get
            Return m_DocumentoPadre
        End Get
        Set(ByVal value As DocumentoContabile)
            m_DocumentoPadre = value
        End Set
    End Property
    Public Property Conto() As Conto
        Get
            Return m_Conto
        End Get
        Set(ByVal value As Conto)
            m_Conto = value
        End Set
    End Property
    Public Property GetQuotaMedia() As Moneta
        Get
            Return m_QuotaMedia
        End Get
        Set(ByVal value As Moneta)
            m_QuotaMedia = value
        End Set
    End Property
    Public Property Settore() As Settore
        Get
            Return m_settore
        End Get
        Set(ByVal value As Settore)
            m_settore = value
        End Set
    End Property
    Public Property Prestazione() As Prestazione
        Get
            Return m_prestazione
        End Get
        Set(ByVal value As Prestazione)
            m_prestazione = value
        End Set
    End Property
    Public Property Vertenza() As BASEREUSE.IDocumento
        Get
            Return m_Vertenza
        End Get
        Set(ByVal value As BASEREUSE.IDocumento)
            m_Vertenza = value
        End Set
    End Property
    Public Property ImportoRistorno() As Moneta
        Get
            Return m_ImportoRistorno
        End Get
        Set(ByVal value As Moneta)
            m_ImportoRistorno = value
        End Set
    End Property
    Public Property PagamentoReferente() As DocumentoContabile
        Get
            Return m_DocumentoRistorno
        End Get
        Set(ByVal value As DocumentoContabile)
            m_DocumentoRistorno = value
        End Set
    End Property
    Public Property AziendaImpiego() As FEDERATIONARTIFACTS.Azienda
        Get
            Return m_AziendaImpiego
        End Get
        Set(ByVal value As FEDERATIONARTIFACTS.Azienda)
            m_AziendaImpiego = value
            m_ContrattoApplicato = value.ContrattoApplicato
        End Set
    End Property
    Public ReadOnly Property ContrattoApplicato() As FEDERATIONARTIFACTS.TipoContratto
        Get
            Return m_ContrattoApplicato
        End Get
    End Property
    Public Property LivelloInquadramento() As String
        Get
            Return m_LivelloInquadramento
        End Get
        Set(ByVal value As String)
            m_LivelloInquadramento = value
        End Set
    End Property
    Public Property OreLavorate() As Double
        Get
            Return m_OreLavorate
        End Get
        Set(ByVal value As Double)
            m_OreLavorate = value
        End Set
    End Property
    Public Property OreMalattia() As Double
        Get
            Return m_OreMalattia
        End Get
        Set(ByVal value As Double)
            m_OreMalattia = value
        End Set
    End Property
    Public Property Referente() As Referente
        Get
            Return m_Referente
        End Get
        Set(ByVal value As Referente)
            m_Referente = value
        End Set
    End Property
    Public Property Competenza() As AbstractPeriodo
        Get
            Return m_Competenza
        End Get
        Set(ByVal value As AbstractPeriodo)
            m_Competenza = value
        End Set
    End Property
    Public Property Tredicesima() As Boolean
        Get
            Return m_TredicesimaInclusa
        End Get
        Set(ByVal value As Boolean)
            m_TredicesimaInclusa = value
        End Set
    End Property
    Public Property Quattordicesima() As Boolean
        Get
            Return m_QuattordicesimaInclusa
        End Get
        Set(ByVal value As Boolean)
            m_QuattordicesimaInclusa = value
        End Set
    End Property
    Public Property Importo() As Moneta
        Get
            Return m_Importo
        End Get
        Set(ByVal value As Moneta)
            m_Importo = value
        End Set
    End Property
    Public Property DataRegistrazione() As DateTime
        Get
            Return m_dataRegistrazione
        End Get
        Set(ByVal value As DateTime)
            m_dataRegistrazione = value
        End Set
    End Property
    Public Property DataDocumento() As DateTime
        Get
            Return m_dataDocumento
        End Get
        Set(ByVal value As DateTime)
            m_dataDocumento = value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return m_note
        End Get
        Set(ByVal value As String)
            m_note = value
        End Set
    End Property
    Public Property TipoDocumento() As String
        Get
            Return m_TipoDocumento
        End Get
        Set(ByVal value As String)
            m_TipoDocumento = value
        End Set
    End Property
    Public Property PercentualeRistornoDeleghe() As Double
        Get
            Return m_PercentualeRistornoDeleghe
        End Get
        Set(ByVal value As Double)
            m_PercentualeRistornoDeleghe = value
        End Set
    End Property
    Public Property SedeOperativa() As SedeOperativa
        Get
            Return m_sedeoperativa
        End Get
        Set(ByVal value As SedeOperativa)
            m_sedeoperativa = value
        End Set
    End Property





    Private m_Key As Key = Nothing
    Private m_Descrizione = ""
    Private m_versione As Int32 = -1
    Private m_ModificatoDa As String = ""
    Private m_CreatoDa As String = ""
    Private m_DataCreazione As DateTime = DateTime.MinValue
    Private m_DataModifica As DateTime = DateTime.MinValue

    Property DataCreazione() As DateTime
        Get
            Return m_DataCreazione
        End Get
        Set(ByVal value As DateTime)
            m_DataCreazione = value
        End Set
    End Property
    Property DataModifica() As DateTime
        Get
            Return m_DataModifica
        End Get
        Set(ByVal value As DateTime)
            m_DataModifica = value
        End Set
    End Property
    Property CreatoDa() As String

        Get
            Return m_CreatoDa
        End Get
        Set(ByVal value As String)
            m_CreatoDa = value
        End Set
    End Property
    Property ModificatoDa() As String
        Get
            Return m_ModificatoDa
        End Get
        Set(ByVal value As String)
            m_ModificatoDa = value
        End Set
    End Property
    Property Versione() As Int32
        Get
            Return (m_versione)
        End Get
        Set(ByVal value As Int32)
            m_versione = value
        End Set
    End Property
    Public ReadOnly Property Id() As Int32
        Get
            m_Key.Value(0)
        End Get
    End Property
    Property Key() As Key
        Get
            Return m_Key
        End Get
        Set(ByVal value As Key)
            m_Key = value
        End Set
    End Property


    Overridable Property Descrizione() As String
        Get
            Return m_Descrizione
        End Get
        Set(ByVal value As String)
            m_Descrizione = UCase(value)
        End Set
    End Property
End Class
