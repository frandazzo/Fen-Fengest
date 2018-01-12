Public Class ElectronicDocument
    Inherits AbstractPersistenceObject
    Implements IComparable


    Protected m_Data As DateTime
    Protected m_FileName As String = ""
    Protected m_Notes As String = ""
    Protected m_TipoDocumento As TipoDocumentazione
    Protected m_DefaultPath As String = ""
    Protected m_Referente As Referente

 
    Public Property Referente() As Referente
        Get
            Return m_Referente
        End Get
        Set(ByVal value As Referente)
            m_Referente = value
        End Set
    End Property



    Public ReadOnly Property DefaultPath()
        Get
            Return m_DefaultPath
        End Get
    End Property

    Public Sub New()

    End Sub


    Public Property TipoDocumentazione() As TipoDocumentazione
        Get
            Return m_TipoDocumento
        End Get
        Set(ByVal value As TipoDocumentazione)
            m_TipoDocumento = value
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

    Public Property FullFileName() As String
        Get
            Return m_FileName
        End Get
        Set(ByVal value As String)
            m_FileName = value
        End Set
    End Property


    Public ReadOnly Property DirectoryName() As String
        Get
            If ExistFile() Then
                Return My.Computer.FileSystem.GetFileInfo(m_FileName).DirectoryName
            End If
            Return ""
        End Get
    End Property


    Public Property Data() As DateTime
        Get
            Return m_Data
        End Get
        Set(ByVal value As DateTime)
            m_Data = value
        End Set
    End Property




    Public Function ExistFile() As Boolean
        Return My.Computer.FileSystem.FileExists(m_FileName)
    End Function

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        If obj Is Nothing Then
            Return 1
        End If
        If m_TipoDocumento Is Nothing Then
            Return -1
        End If


        Dim other As ElectronicDocument = CType(obj, ElectronicDocument)

        If other.TipoDocumentazione Is Nothing Then
            Return 1
        End If

        Return StrComp(m_TipoDocumento.ToString, other.TipoDocumentazione.ToString)

    End Function

    Public Sub ViewFile()
        If ExistFile() Then
            Dim pInfo As New ProcessStartInfo()
            pInfo.FileName = m_FileName
            pInfo.UseShellExecute = True
            Dim p As Process = Process.Start(pInfo)
        Else
            Throw New IO.FileNotFoundException
        End If

    End Sub


    Public Sub RenameFile(ByVal NewName As String)
        If ExistFile() Then
            Dim temp As String = ContructNewFileName(NewName)
            My.Computer.FileSystem.RenameFile(m_FileName, NewName & My.Computer.FileSystem.GetFileInfo(m_FileName).Extension)
            m_FileName = temp
        Else
            Throw New IO.FileNotFoundException
        End If
    End Sub
    Private Function ContructNewFileName(ByVal NewName As String) As String

        Dim path As String = My.Computer.FileSystem.GetFileInfo(m_FileName).DirectoryName
        Dim ext As String = My.Computer.FileSystem.GetFileInfo(m_FileName).Extension

        Return SimpleFileSystemManager.GenerateConsistentFileName(path, NewName + ext)

    End Function






    Public Sub CopyFile(ByVal destination As String, ByVal Sovrascrivi As Boolean, ByVal ChangeReference As Boolean)
        My.Computer.FileSystem.MoveFile(m_FileName, destination, True)
        If ChangeReference Then
            m_FileName = destination
        End If
    End Sub

    Public Sub MoveFile(ByVal destination As String, ByVal Sovrascrivi As Boolean)
        My.Computer.FileSystem.MoveFile(m_FileName, destination, Sovrascrivi)
        m_FileName = destination
    End Sub


    Public Sub RemoveFile()
        If ExistFile() Then
            IO.File.Delete(m_FileName)
        End If

    End Sub

    Public Sub ViewPath()
        If ExistFile() Then
            Dim pInfo As New ProcessStartInfo()
            pInfo.FileName = DirectoryName
            pInfo.UseShellExecute = True
            Dim p As Process = Process.Start(pInfo)
        Else
            Throw New IO.FileNotFoundException
        End If

    End Sub


    Public ReadOnly Property FileNameWithoutPath() As String
        Get
            If ExistFile() Then
                Return My.Computer.FileSystem.GetFileInfo(m_FileName).Name
            End If
            Return ""
        End Get
    End Property





    Public Function GetFileProperties() As String
        If Not My.Computer.FileSystem.FileExists(m_FileName) Then
            Throw New IO.FileNotFoundException
        End If
        Dim prop As New Text.StringBuilder
        Dim info As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(m_FileName)

        prop.Append("Nome file: " & info.Name & vbCrLf)
        prop.Append("Nome directory: " & info.DirectoryName & vbCrLf & vbCrLf & vbCrLf)


        prop.Append("Data creazione: " & info.CreationTime & vbCrLf)
        prop.Append("Data ultimo accesso: " & info.LastAccessTime & vbCrLf)
        prop.Append("Data ultima modifica: " & info.LastWriteTime & vbCrLf)
        prop.Append("Sola lettura: " & info.IsReadOnly & vbCrLf)
        prop.Append("Spazio occupato: " & info.Length & " bytes" & vbCrLf)



        Return prop.ToString
    End Function











End Class
