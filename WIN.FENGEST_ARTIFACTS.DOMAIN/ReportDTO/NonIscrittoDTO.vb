Public Class NonIscrittoDTO
    Inherits AbstractPersistenceObject

    Private m_Nome_Utente As String = ""
    Private m_Nome_Ente As String = ""
    Private m_Libero_Al As DateTime
    Private m_Nome_Azienda As String = ""
    Private m_Livello As String = ""
    Private m_Id_Utente As Int32
    Private m_Id_Azienda_Impiego As String = ""
    Private m_Id_Ente As Int32
    Private m_Ha_Delega_Precedente As String = ""
    Private m_Nome_Nazione As String = ""
    Private m_Nome_Comune As String = ""
    Private m_Nome_Provincia As String = ""
    Private m_Cell1 As String = ""
    Private m_Cell2 As String = ""

    Private m_Codice_Fiscale As String = ""
    Private m_IscrittoA As String = ""


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

    Public Property IscrittoA() As String
        Get
            Return m_IscrittoA
        End Get
        Set(ByVal value As String)
            m_IscrittoA = value
        End Set
    End Property


    Public Property Codice_Fiscale() As String
        Get
            Return m_Codice_Fiscale
        End Get
        Set(ByVal value As String)
            m_Codice_Fiscale = value
        End Set
    End Property




    Public Property Ha_Delega_Precedente() As String
        Get
            Return m_Ha_Delega_Precedente
        End Get
        Set(ByVal value As String)
            m_Ha_Delega_Precedente = value
        End Set
    End Property


    Public Property Id_Ente() As Int32
        Get
            Return m_Id_Ente
        End Get
        Set(ByVal value As Int32)
            m_Id_Ente = value
        End Set
    End Property


    Public Property Id_Azienda_Impiego() As String
        Get
            Return m_Id_Azienda_Impiego
        End Get
        Set(ByVal value As String)
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




    Public Property Livello() As String
        Get
            Return m_Livello
        End Get
        Set(ByVal value As String)
            m_Livello = value
        End Set
    End Property


    Public Property Nome_Azienda() As String
        Get
            Return m_Nome_Azienda
        End Get
        Set(ByVal value As String)
            m_Nome_Azienda = value
        End Set
    End Property


    Public Property Libero_Al() As String
        Get
            Return m_Libero_Al
        End Get
        Set(ByVal value As String)
            m_Libero_Al = value
        End Set
    End Property





    Public Property Nome_Ente() As String
        Get
            Return m_Nome_Ente
        End Get
        Set(ByVal value As String)
            m_Nome_Ente = value
        End Set
    End Property




    Public Property Nome_Utente() As String
        Get
            Return m_Nome_Utente
        End Get
        Set(ByVal value As String)
            m_Nome_Utente = value
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
End Class
