Public Class DelegadTO
    Inherits AbstractPersistenceObject

    Private m_Utente As String = ""
    Private m_IdUtente As String = ""
    Private m_Cellulare1 As String = ""
    Private m_Cellulare2 As String = ""

    Private m_Referente As String = ""
    Private m_IdReferente As String = ""
    Private m_Responsabile As String = ""
    Private m_IdResponsabile As String = ""

    Private m_dataRegistrazione As DateTime
    Private m_dataDocumento As DateTime
    Private m_DataInoltro As DateTime
    Private m_DataAccettazioneDelega As DateTime
    Private m_DataDecorrenzaDelega As DateTime
    Private m_DataAnnullamentoDelega As DateTime
    Private m_DataRevoca As DateTime

    Private m_CausaleSottoscrizione As String = ""
    Private m_CausaleFineCiclo As String = ""
    Protected m_StatoDelega As String = ""
    Private m_note As String = ""

    Private m_settore As String = ""
    Private m_Idsettore As String = ""
    Private m_EnteInoltro As String = ""
    Private m_IdEnteInoltro As String = ""
    Private m_SedeOperativa As String = ""
    Private m_reparto As String = ""
    Private m_IdContratto As String = ""
    Private m_Contratto As String = ""


    Private m_Indirizzo As String = ""
    Private m_Cap As String = ""
    Private m_Nome As String = ""
    Private m_Cognome As String = ""
    Private m_DataNascita As DateTime = DateTime.Now
    Private m_CodiceFiscale As String = ""
    Private m_Nome_Nazione As String = ""
    Private m_Nome_Comune As String = ""
    Private m_Nome_Provincia As String = ""





    Private m_capAzienda As String = ""
    Private m_IndirizzoAzienda As String = ""
    Private m_comuneAzienda As String = ""
    Private m_ProvinciaAzienda As String = ""
    Private m_mailAzienda As String = ""
    Public Property MailAzienda() As String
        Get
            Return m_mailAzienda
        End Get
        Set(ByVal value As String)
            m_mailAzienda = value
        End Set
    End Property


    Public Property ProvinciaAzienda() As String
        Get
            Return m_ProvinciaAzienda
        End Get
        Set(ByVal value As String)
            m_ProvinciaAzienda = value
        End Set
    End Property

    Public Property ComuneAzienda() As String
        Get
            Return m_comuneAzienda
        End Get
        Set(ByVal value As String)
            m_comuneAzienda = value
        End Set
    End Property

    Public Property IndirizzoAzienda() As String
        Get
            Return m_IndirizzoAzienda
        End Get
        Set(ByVal value As String)
            m_IndirizzoAzienda = value
        End Set
    End Property



    Public Property CapAzienda() As String
        Get
            Return m_capAzienda
        End Get
        Set(ByVal value As String)
            m_capAzienda = value
        End Set
    End Property



    Private m_nomeProvinciaNascita As String
    Public Property Nome_Provincia_Nascita() As String
        Get
            Return m_nomeProvinciaNascita
        End Get
        Set(ByVal value As String)
            m_nomeProvinciaNascita = value
        End Set
    End Property


    Private m_nomeComuneNascita As String
    Public Property Nome_Comune_Nascita() As String
        Get
            Return m_nomeComuneNascita
        End Get
        Set(ByVal value As String)
            m_nomeComuneNascita = value
        End Set
    End Property



    Private m_Selected As Boolean
    Public Property Nome_Comune() As String
        Get
            Return m_Nome_Comune
        End Get
        Set(ByVal value As String)
            m_Nome_Comune = value
        End Set
    End Property


    Public Property Indirizzo() As String
        Get
            Return m_Indirizzo
        End Get
        Set(ByVal value As String)
            m_Indirizzo = value
        End Set
    End Property


    Public Property Nome_Nazione() As String
        Get
            Return m_Nome_Nazione
        End Get
        Set(ByVal value As String)
            m_Nome_Nazione = value
        End Set
    End Property

    Public Property Nome_Provincia() As String
        Get
            Return m_Nome_Provincia
        End Get
        Set(ByVal value As String)
            m_Nome_Provincia = value
        End Set
    End Property


    Public Property Cap() As String
        Get
            Return m_Cap
        End Get
        Set(ByVal value As String)
            m_Cap = value
        End Set
    End Property
    Public Property Codice_Fiscale() As String
        Get
            Return m_CodiceFiscale
        End Get
        Set(ByVal value As String)
            m_CodiceFiscale = value
        End Set
    End Property

    Public Property DataNascita() As DateTime
        Get
            Return m_DataNascita
        End Get
        Set(ByVal value As DateTime)
            m_DataNascita = value
        End Set
    End Property
    Public Property Cognome() As String
        Get
            Return m_Cognome
        End Get
        Set(ByVal value As String)
            m_Cognome = value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return m_Nome
        End Get
        Set(ByVal value As String)
            m_Nome = value
        End Set
    End Property

    Public Property Selected() As Boolean
        Get
            Return m_Selected
        End Get
        Set(ByVal value As Boolean)
            m_Selected = value
        End Set
    End Property



    Public Property Contratto() As String
        Get
            Return m_Contratto
        End Get
        Set(ByVal value As String)
            m_Contratto = value
        End Set
    End Property

    Public Property IdContratto() As String
        Get
            Return m_IdContratto
        End Get
        Set(ByVal value As String)
            m_IdContratto = value
        End Set
    End Property

    Public Property Cellulare1() As String
        Get
            Return m_Cellulare1
        End Get
        Set(ByVal value As String)
            m_Cellulare1 = value
        End Set
    End Property

    Public Property Cellulare2() As String
        Get
            Return m_Cellulare2
        End Get
        Set(ByVal value As String)
            m_Cellulare2 = value
        End Set
    End Property




    Public Property CausaleSottoscrizione() As String
        Get
            Return m_CausaleSottoscrizione
        End Get
        Set(ByVal value As String)
            m_CausaleSottoscrizione = value
        End Set
    End Property
    Public Property Reparto() As String
        Get
            Return m_reparto
        End Get
        Set(ByVal value As String)
            m_reparto = value
        End Set
    End Property

    Public Property CausaleFineCiclo() As String
        Get
            Return m_CausaleFineCiclo
        End Get
        Set(ByVal value As String)
            m_CausaleFineCiclo = value
        End Set
    End Property


    Public Property EnteInoltro() As String
        Get
            Return m_EnteInoltro
        End Get
        Set(ByVal value As String)
            m_EnteInoltro = value
        End Set
    End Property

    Public Property IdEnteInoltro() As String
        Get
            Return m_IdEnteInoltro
        End Get
        Set(ByVal value As String)
            m_IdEnteInoltro = value
        End Set
    End Property

    Public Property Settore() As String
        Get
            Return m_settore
        End Get
        Set(ByVal value As String)
            m_settore = value
        End Set
    End Property

    Public Property IdSettore() As String
        Get
            Return m_Idsettore
        End Get
        Set(ByVal value As String)
            m_Idsettore = value
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

    Public Property DataDocumento() As DateTime
        Get
            Return m_dataDocumento
        End Get
        Set(ByVal value As DateTime)
            m_dataDocumento = value
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
    Public Property Utente() As String
        Get
            Return m_Utente
        End Get
        Set(ByVal value As String)
            m_Utente = value
        End Set
    End Property

    Public Property IdUtente() As String
        Get
            Return m_IdUtente
        End Get
        Set(ByVal value As String)
            m_IdUtente = value
        End Set
    End Property



    Public Property StatoDelega() As String
        Get
            Return m_StatoDelega
        End Get
        Set(ByVal value As String)
            m_StatoDelega = value
        End Set
    End Property
    Public Property Referente() As String
        Get
            Return m_Referente
        End Get
        Set(ByVal value As String)
            m_Referente = value
        End Set
    End Property

    Public Property IdReferente() As String
        Get
            Return m_IdReferente
        End Get
        Set(ByVal value As String)
            m_IdReferente = value
        End Set
    End Property

    Public Property DataInoltro() As DateTime
        Get
            Return m_DataInoltro
        End Get
        Set(ByVal value As DateTime)
            m_DataInoltro = value
        End Set
    End Property
    Public Property DataAccettazioneDelega() As DateTime
        Get
            Return m_DataAccettazioneDelega
        End Get
        Set(ByVal value As DateTime)
            m_DataAccettazioneDelega = value
        End Set
    End Property
    Public Property DataDecorrenzaDelega() As DateTime
        Get
            Return m_DataDecorrenzaDelega
        End Get
        Set(ByVal value As DateTime)
            m_DataDecorrenzaDelega = value
        End Set
    End Property
    Public Property DataAnnullamentoDelega() As DateTime
        Get
            Return m_DataAnnullamentoDelega
        End Get
        Set(ByVal value As DateTime)
            m_DataAnnullamentoDelega = value
        End Set
    End Property

    Public Property DataRevocaDelega() As DateTime
        Get
            Return m_DataRevoca
        End Get
        Set(ByVal value As DateTime)
            m_DataRevoca = value
        End Set
    End Property



    Public Property SedeOperativa() As String
        Get
            Return m_SedeOperativa
        End Get
        Set(ByVal value As String)
            m_SedeOperativa = value
        End Set
    End Property
    Public Property Responsabile() As String
        Get
            Return m_Responsabile
        End Get
        Set(ByVal value As String)
            m_Responsabile = value
        End Set
    End Property

    Public Property IdResponsabile() As String
        Get
            Return m_IdResponsabile
        End Get
        Set(ByVal value As String)
            m_IdResponsabile = value
        End Set
    End Property
End Class
