Public Class IscrittoNonIscrittoDTO


    Private m_Settore As String = ""
    Private m_Nome_Ente As String = ""
    Private m_AziendaImpiego As String = ""
    Private m_Competenza As String = ""
    Private m_Contratto As String = ""
    Private m_Livello As String = ""
    Private m_TipoDoc As String = ""
    Private m_Referente As String


    Private m_Nome As String = ""
    Private m_Cognome As String = ""
    Private m_DataNascita As DateTime = DateTime.Now
    Private m_CodiceFiscale As String = ""
    Private m_Nome_Nazione As String = ""
    Private m_Nome_Comune_Nascita As String = ""
    Private m_Nome_Provincia_Nascita As String = ""
    Private m_Nome_Comune As String = ""
    Private m_Nome_Provincia As String = ""
    Private m_Indirizzo As String = ""
    Private m_Cap As String = ""
    Private m_Cell1 As String = ""
    Private m_Cell2 As String = ""


    Private m_IscrittoA As String
    Private m_dataNonIscrizione As DateTime

    Public Property DataNonIscritto() As DateTime
        Get
            Return m_dataNonIscrizione
        End Get
        Set(ByVal value As DateTime)
            m_dataNonIscrizione = value
        End Set
    End Property

    Public Property IscittoA() As String
        Get
            Return m_IscrittoA
        End Get
        Set(ByVal value As String)
            m_IscrittoA = value
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

    Public Property NomeEnte() As String
        Get
            Return m_Nome_Ente
        End Get
        Set(ByVal value As String)
            m_Nome_Ente = value
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


    Public Property Referente() As String
        Get
            Return m_Referente
        End Get
        Set(ByVal value As String)
            m_Referente = value
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
