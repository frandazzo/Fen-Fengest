Public Class IscrittoDTO
    Inherits AbstractPersistenceObject

    Private m_Utente As String
    'Private m_DataIn As DateTime
    'Private m_DataFin As DateTime
    Private m_Competenza As String = ""
    Private m_Settore As String = ""
    Private m_AziendaImpiego As String = ""
    Private m_Contratto As String = ""
    Private m_Livello As String = ""
    Private m_TipoDoc As String = ""
    Private m_TipoPrestazione As String = ""
    Private m_Causale As String = ""
    Private m_Id_Utente As Int32

    Private m_Id_Azienda_Impiego As Int32

    Private m_Nome_Ente As String = ""
    Private m_Nome_Nazione As String = ""
    Private m_Nome_Comune As String = ""
    Private m_Nome_Provincia As String = ""
    Private m_Nome_Comune_Nascita As String = ""
    Private m_Nome_Provincia_Nascita As String = ""
    Private m_Cell1 As String = ""
    Private m_Cell2 As String = ""
    Private m_Indirizzo As String = ""

    Private m_Importo As Double = 0

    Private m_CodiceFiscale As String = ""
    Private m_Id_Referente As Int32


    Private m_Nome As String = ""
    Private m_Cognome As String = ""
    Private m_DataNascita As DateTime = DateTime.Now

    Private m_Cap As String = ""
    Public Property DataNascita() As DateTime
        Get
            Return m_DataNascita
        End Get
        Set(ByVal value As DateTime)
            m_DataNascita = value
        End Set
    End Property

    Public Property NomeEnte() As String
        Get
            Return m_Nome_Ente
        End Get
        Set(ByVal value As String)
            m_Nome_Ente = value
        End Set
    End Property

    Public Property Importo() As Double
        Get
            Return m_Importo
        End Get
        Set(ByVal value As Double)
            m_Importo = value
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


    Public Property Id_Referente() As Int32
        Get
            Return m_Id_Referente
        End Get
        Set(ByVal value As Int32)
            m_Id_Referente = value
        End Set
    End Property

    Public Property Id_Azienda_Impiego() As Int32
        Get
            Return m_Id_Azienda_Impiego
        End Get
        Set(ByVal value As Int32)
            m_Id_Azienda_Impiego = value
        End Set
    End Property


    Public Property Id_Utente() As Int32
        Get
            Return m_Id_Utente
        End Get
        Set(ByVal value As Int32)
            m_Id_Utente = value
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

    Public Property Causale() As String
        Get
            Return m_Causale
        End Get
        Set(ByVal value As String)
            m_Causale = value
        End Set
    End Property



    Public Property TipoPrestazione() As String
        Get
            Return m_TipoPrestazione
        End Get
        Set(ByVal value As String)
            m_TipoPrestazione = value
        End Set
    End Property


    Public Property TipoDoc() As String
        Get
            Return m_TipoDoc
        End Get
        Set(ByVal value As String)
            m_TipoDoc = value
        End Set
    End Property


    Public Property Livello() As String
        Get
            Return m_Livello
        End Get
        Set(ByVal value As String)
            m_Livello = value
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


    Public Property AziendaImpiego() As String
        Get
            Return m_AziendaImpiego
        End Get
        Set(ByVal value As String)
            m_AziendaImpiego = value
        End Set
    End Property


    Public Property Settore() As String
        Get
            Return m_Settore
        End Get
        Set(ByVal value As String)
            If value = "" Then
                m_Settore = "INPS"
                Return
            End If
            m_Settore = value
        End Set
    End Property


    Public Property Competenza() As String
        Get
            Return m_Competenza
        End Get
        Set(ByVal value As String)
            m_Competenza = value
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


    Public Property Nome_Comune() As String
        Get
            Return m_Nome_Comune
        End Get
        Set(ByVal value As String)
            m_Nome_Comune = value
        End Set
    End Property

    Public Property Nome_Comune_Nascita() As String
        Get
            Return m_Nome_Comune_Nascita
        End Get
        Set(ByVal value As String)
            m_Nome_Comune_Nascita = value
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
    Public Property Nome_Provincia_Nascita() As String
        Get
            Return m_Nome_Provincia_Nascita
        End Get
        Set(ByVal value As String)
            m_Nome_Provincia_Nascita = value
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



    Public Property Cell1() As String
        Get
            Return m_Cell1
        End Get
        Set(ByVal value As String)
            m_Cell1 = value
        End Set
    End Property

    Public Property Cell2() As String
        Get
            Return m_Cell2
        End Get
        Set(ByVal value As String)
            m_Cell2 = value
        End Set
    End Property

End Class
