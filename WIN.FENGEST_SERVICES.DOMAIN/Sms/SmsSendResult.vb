Public Class SmsSendResult
    Private m_HasError As Boolean
    Private m_Error As String
    Private m_Message As String

    Public Property Message() As String
        Get
            Return m_Message
        End Get
        Set(ByVal value As String)
            m_Message = value
        End Set
    End Property

    Public Property ErrorMessage() As String
        Get
            Return m_Error
        End Get
        Set(ByVal value As String)
            m_Error = value
        End Set
    End Property

    Public Property HasErrors() As Boolean
        Get
            Return m_HasError
        End Get
        Set(ByVal value As Boolean)
            m_HasError = value
        End Set
    End Property

End Class
