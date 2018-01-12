Public Class StateData

    Private m_Data As DateTime
    Private m_Cause As String
    Public Property Cause() As String
        Get
            Return m_Cause
        End Get
        Set(ByVal value As String)
            m_Cause = value
        End Set
    End Property

    Public Property Data() As DateTime
        Get
            Return m_Data
        End Get
        Set(ByVal value As DateTime)
            m_Data = value
        End Set
    End Property

End Class
