Public Class FenealgestSorftwareInfoHandler
    Inherits AbstractController


    Public Overrides Sub CreateNew()
        Throw New NotImplementedException
    End Sub


    Public Overrides Function GetCategoryObject() As String
        Return "FenealgestSoftwareInfo"
    End Function


    Private Function Current() As FenealgestSoftwareInfo
        Return DirectCast(MyBase.m_current, FenealgestSoftwareInfo)
    End Function





    Public Property DBUpgradePath() As String
        Get
            Return Current.DBUpgradePath
        End Get
        Set(ByVal value As String)
            Current.DBUpgradePath = value
        End Set
    End Property

    Public Property SoftwareUpgratePath() As String
        Get
            Return Current.SoftwareUpgratePath
        End Get
        Set(ByVal value As String)
            Current.SoftwareUpgratePath = value
        End Set
    End Property


    Public Property DBVersion() As Version
        Get
            Return Current.DBVersion
        End Get
        Set(ByVal value As Version)
            Current.DBVersion = value
        End Set
    End Property


    Public Property SoftwareVersion() As Version
        Get
            Return Current.SoftwareVersion
        End Get
        Set(ByVal value As Version)
            Current.SoftwareVersion = value
        End Set
    End Property
  



    Public Property LastUpdate() As DateTime
        Get
            Return Current.LastUpdate
        End Get
        Set(ByVal value As DateTime)
            Current.LastUpdate = value
        End Set
    End Property

End Class
