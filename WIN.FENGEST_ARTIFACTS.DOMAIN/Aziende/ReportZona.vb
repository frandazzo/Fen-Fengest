Public Class ReportZona

    Private m_idAzienda As Int32
    Private m_NomeAzienda As String
    Private m_numIscritti As Int32
    Private m_numLiberi As Int32
    Private m_zona As String
    Private m_provincia As String
    Private m_citta As String


    Public Property Citta() As String
        Get
            Return m_citta
        End Get
        Set(ByVal value As String)
            m_citta = value
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return m_provincia
        End Get
        Set(ByVal value As String)
            m_provincia = value
        End Set
    End Property

    Public Property Zona() As String
        Get
            Return m_zona
        End Get
        Set(ByVal value As String)
            m_zona = value
        End Set
    End Property

    Public Property NumLiberi() As Int32
        Get
            Return m_numLiberi
        End Get
        Set(ByVal value As Int32)
            m_numLiberi = value
        End Set
    End Property

    Public Property NumIscritti() As Int32
        Get
            Return m_numIscritti
        End Get
        Set(ByVal value As Int32)
            m_numIscritti = value
        End Set
    End Property

    Public Property NomeAzienda() As String
        Get
            Return m_NomeAzienda
        End Get
        Set(ByVal value As String)
            m_NomeAzienda = value
        End Set
    End Property

    Public Property IdAzienda() As Int32
        Get
            Return m_idAzienda
        End Get
        Set(ByVal value As Int32)
            m_idAzienda = value
        End Set
    End Property

End Class
