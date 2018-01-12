Public Class UtenteBolzano
    Private m_codice_fiscale As String
    Public Property Codice_Fiscale() As String
        Get
            Return m_codice_fiscale
        End Get
        Set(ByVal value As String)
            m_codice_fiscale = value
        End Set
    End Property

    Private m_nome As String
    Public Property Nome() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property

    Private m_cognome As String
    Public Property Cognome() As String
        Get
            Return m_cognome
        End Get
        Set(ByVal value As String)
            m_cognome = value
        End Set
    End Property

    Private m_indirizzo As String
    Public Property Indirizzo() As String
        Get
            Return m_indirizzo
        End Get
        Set(ByVal value As String)
            m_indirizzo = value
        End Set
    End Property

    Private m_cap As String
    Public Property Cap() As String
        Get
            Return m_cap
        End Get
        Set(ByVal value As String)
            m_cap = value
        End Set
    End Property


    Private m_nome_comune As String
    Public Property Nome_Comune() As String
        Get
            Return m_nome_comune
        End Get
        Set(ByVal value As String)
            m_nome_comune = value
        End Set
    End Property




End Class
