Imports System.IO

Public Class PraticaDetail
    Inherits AbstractPersistenceObject


    Private m_Notes As String
    Private m_FilePath As String
    Private m_Data As DateTime
    Public Property Data() As DateTime
        Get
            Return m_Data
        End Get
        Set(ByVal value As DateTime)
            m_Data = value
        End Set
    End Property



    Public ReadOnly Property Filename() As String
        Get
            If m_FilePath Is Nothing Then
                Return ""
            End If

            Dim fi As New FileInfo(m_FilePath)
            If (fi.Exists) Then
                Return fi.Name
            End If
            Return String.Format("File non trovato: {0}", m_FilePath)
        End Get

    End Property



    Public Property FilePath() As String
        Get
            Return m_FilePath
        End Get
        Set(ByVal value As String)
            m_FilePath = value
        End Set
    End Property


    Public Property Notes() As String
        Get
            Return m_Notes
        End Get
        Set(ByVal value As String)
            m_Notes = value
        End Set
    End Property

    Protected Overloads Sub DoValidation()

        If String.IsNullOrEmpty(m_FilePath) Then
            Me.m_ValidationErrors.Add("Documento elettronico non specificato")
        End If



    End Sub


End Class
