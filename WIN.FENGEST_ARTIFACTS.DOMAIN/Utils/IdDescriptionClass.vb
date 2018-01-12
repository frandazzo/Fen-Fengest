Public Class IdDescriptionClass

    Private m_id As Int32
    Private m_Description As String = ""

    Public Overrides Function ToString() As String
        Return m_Description
    End Function


    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(ByVal value As String)
            m_Description = value
        End Set
    End Property

    Public Property Id() As Int32
        Get
            Return m_id
        End Get
        Set(ByVal value As Int32)
            m_id = value
        End Set
    End Property

End Class
