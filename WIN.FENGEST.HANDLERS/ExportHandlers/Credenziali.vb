Public Class Credenziali

    Private m_userName As String


    Private m_Password As String


    Private m_provincia As String
    Public Property Provincia() As String
        Get
            Return m_provincia
        End Get
        Set(ByVal value As String)
            m_provincia = value
        End Set
    End Property



    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(ByVal value As String)
            m_Password = value
        End Set
    End Property



    Public Property UserName() As String
        Get
            Return m_userName
        End Get
        Set(ByVal value As String)
            m_userName = value
        End Set
    End Property

End Class
