Public Class ElectronicDocumentDTO
    Inherits AbstractPersistenceObject



    Private m_Fiscal As String
    Public Property Fiscal() As String
        Get
            Return m_Fiscal
        End Get
        Set(ByVal value As String)
            m_Fiscal = value
        End Set
    End Property

    Private m_DocumentType As String
    Public Property DocumentType() As String
        Get
            Return m_DocumentType
        End Get
        Set(ByVal value As String)
            m_DocumentType = value
        End Set
    End Property

    Private m_data As DateTime
    Public Property Data() As DateTime
        Get
            Return m_data
        End Get
        Set(ByVal value As DateTime)
            m_data = value
        End Set
    End Property


    Private m_ExecutedBy As String
    Public Property ExecutedBy() As String
        Get
            Return m_ExecutedBy
        End Get
        Set(ByVal value As String)
            m_ExecutedBy = value
        End Set
    End Property

    Private m_FileName As String
    Public Property FileName() As String
        Get
            Return m_FileName
        End Get
        Set(ByVal value As String)
            m_FileName = value
        End Set
    End Property

    Private m_Notes As String
    Public Property Notes() As String
        Get
            Return m_Notes
        End Get
        Set(ByVal value As String)
            m_Notes = value
        End Set
    End Property


    Private m_OwnerId As Int32
    Public Property OwnerId() As String
        Get
            Return m_OwnerId
        End Get
        Set(value As String)
            m_OwnerId = value
        End Set
    End Property



    Private m_DocumentId As Int32
    Public Property DocumentId() As Int32
        Get
            Return m_DocumentId
        End Get
        Set(ByVal value As Int32)
            m_DocumentId = value
        End Set
    End Property

    Private m_ExecutorId As Int32
    Public Property ExecutorId() As Int32
        Get
            Return m_ExecutorId
        End Get
        Set(ByVal value As Int32)
            m_ExecutorId = value
        End Set
    End Property







End Class
