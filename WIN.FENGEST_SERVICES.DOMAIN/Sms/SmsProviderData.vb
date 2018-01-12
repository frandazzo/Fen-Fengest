Public Class SmsProviderData
    Inherits AbstractPersistenceObject


    Private m_username As String
    Private m_password As String
    Private m_provider As String
    Private m_smsOption1 As String
    Private m_senderAlias As String
    Private m_senderNumber As String

    Public Property SenderNumber() As String
        Get
            Return m_senderNumber
        End Get
        Set(ByVal value As String)
            m_senderNumber = value
        End Set
    End Property

    Public Property SenderAlias() As String
        Get
            Return m_senderAlias
        End Get
        Set(ByVal value As String)
            m_senderAlias = value
        End Set
    End Property


    Public Property SmsOption1() As String
        Get
            Return m_smsOption1
        End Get
        Set(ByVal value As String)
            m_smsOption1 = value
        End Set
    End Property

    Public Property Provicer() As String
        Get
            Return m_provider
        End Get
        Set(ByVal value As String)
            m_provider = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_password
        End Get
        Set(ByVal value As String)
            m_password = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return m_username
        End Get
        Set(ByVal value As String)
            m_username = value
        End Set
    End Property

End Class
