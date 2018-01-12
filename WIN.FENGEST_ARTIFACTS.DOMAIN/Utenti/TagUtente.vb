Public Class TagUtente


    Private m_Tag1 As String = ""

    Public Property Tag1() As String
        Get
            Return m_Tag1
        End Get
        Set(ByVal value As String)
            m_Tag1 = value
        End Set
    End Property


    Private m_Tag2 As String = ""

    Public Property Tag2() As String
        Get
            Return m_Tag2
        End Get
        Set(ByVal value As String)
            m_Tag2 = value
        End Set
    End Property


    Private m_Tag3 As String = ""

    Public Property Tag3() As String
        Get
            Return m_Tag3
        End Get
        Set(ByVal value As String)
            m_Tag3 = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return ""
    End Function
End Class
