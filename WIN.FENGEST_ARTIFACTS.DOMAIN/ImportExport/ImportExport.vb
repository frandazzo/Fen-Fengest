Public Class ImportExport
    Inherits AbstractPersistenceObject


    Public Enum ResultType
        FileRenamedWithoutHasBeenProcessed
        FileRenamed
        FileNotRenamed
    End Enum


    Private m_selected As Boolean

    Public Property Selected() As Boolean

        Get
            Return m_selected
        End Get
        Set(ByVal value As Boolean)
            m_selected = value
        End Set
    End Property



    Private m_result As ResultType
    Public Property Result() As ResultType
        Get
            Return m_result
        End Get
        Set(ByVal value As ResultType)
            m_result = value
        End Set
    End Property


    Private m_Subject As String
    Public Property Subject() As String
        Get
            Return m_Subject
        End Get
        Set(ByVal value As String)
            m_Subject = value
        End Set
    End Property


    Private m_LiberiImportedData As String
    Public Property LiberiImportedData() As String
        Get
            Return m_LiberiImportedData
        End Get
        Set(ByVal value As String)
            m_LiberiImportedData = value
        End Set
    End Property

    Private m_logFilePath As String
    Public Property LogFilePath() As String
        Get
            Return m_logFilePath
        End Get
        Set(ByVal value As String)
            m_logFilePath = value
        End Set
    End Property

    Private m_ImportedFile As String
    Public Property ImportedFile() As String
        Get
            Return m_ImportedFile
        End Get
        Set(ByVal value As String)
            m_ImportedFile = value
        End Set
    End Property

    Public Enum ElaborationType
        IQA
        Liberi
        Inps
    End Enum

    Private m_type As ElaborationType = ElaborationType.IQA
    Public Property Type() As ElaborationType
        Get
            Return m_type
        End Get
        Set(ByVal value As ElaborationType)
            m_type = value
        End Set
    End Property

    Private m_Data As DateTime = DateTime.Now
    Public Property ElaborationData() As DateTime
        Get
            Return m_Data
        End Get
        Set(ByVal value As DateTime)
            m_Data = value
        End Set
    End Property




    Private m_createdDocumentId As Int32
    Public Property CreatedDocumentId() As Int32
        Get
            Return m_createdDocumentId
        End Get
        Set(ByVal value As Int32)
            m_createdDocumentId = value
        End Set
    End Property



    Protected Overrides Sub DoValidation()
        'If Not IO.File.Exists(m_logFilePath) Then
        '    ValidationErrors.Add("File di log non esistente per l'oggetto ImportExport")
        'End If

        'If Not IO.File.Exists(m_ImportedFile) Then
        '    ValidationErrors.Add("File importato non esistente per l'oggetto ImportExport")
        'End If
    End Sub



End Class
