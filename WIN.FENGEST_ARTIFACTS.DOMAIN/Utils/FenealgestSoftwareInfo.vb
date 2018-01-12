Public Class FenealgestSoftwareInfo
    Inherits AbstractPersistenceObject



    Private m_LastUpdate As DateTime



    Private m_SoftwareUpgradePath As String = ""
    Private m_DBUpgradePath As String = ""
    Private m_SoftwareVersion As Version
    Private m_DBVersion As Version

    Public Property DBUpgradePath() As String
        Get
            Return m_DBUpgradePath
        End Get
        Set(ByVal value As String)
            m_DBUpgradePath = value
        End Set
    End Property

    Public Property SoftwareUpgratePath() As String
        Get
            Return m_SoftwareUpgradePath
        End Get
        Set(ByVal value As String)
            m_SoftwareUpgradePath = value
        End Set
    End Property


    Public Property DBVersion() As Version
        Get
            Return m_DBVersion
        End Get
        Set(ByVal value As Version)
            m_DBVersion = value
        End Set
    End Property



    Public Property SoftwareVersion() As Version
        Get
            Return m_SoftwareVersion
        End Get
        Set(ByVal value As Version)
            m_SoftwareVersion = value
        End Set
    End Property



    Public Property LastUpdate() As DateTime
        Get
            Return m_LastUpdate
        End Get
        Set(ByVal value As DateTime)
            m_LastUpdate = value
        End Set
    End Property

End Class
