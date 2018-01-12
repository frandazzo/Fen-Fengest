Imports System.IO

Public Class Rendiconto
    Inherits AbstractPersistenceObject

    Private m_anno As Int32
    Public Property Anno() As Int32
        Get
            Return m_anno
        End Get
        Set(ByVal value As Int32)
            m_anno = value
        End Set
    End Property



    Public Shared Function NewRendicontoName() As String
        Return Guid.NewGuid().ToString + ".xml"
    End Function

    Public Sub New()
        Me.DataCreazione = DateTime.Now
    End Sub


    Private m_Tipo As RendicontoType = RendicontoType.Provinciale
    Public Property Tipo() As RendicontoType
        Get
            Return m_Tipo
        End Get
        Set(ByVal value As RendicontoType)
            m_Tipo = value
        End Set
    End Property

    Private m_FilePath As String
    Public Property FilePath() As String
        Get
            Return m_FilePath
        End Get
        Set(ByVal value As String)
            m_FilePath = value

        End Set
    End Property


    Protected Overrides Sub DoValidation()
        If String.IsNullOrEmpty(Me.Descrizione) Then
            ValidationErrors.Add("Descrizione rendiconto non specificata")
        End If

        If String.IsNullOrEmpty(m_FilePath) Then
            ValidationErrors.Add("File rendiconto non specificato")
        End If

    End Sub


End Class

Public Enum RendicontoType
    Provinciale
    Regionale
    RLST

End Enum
