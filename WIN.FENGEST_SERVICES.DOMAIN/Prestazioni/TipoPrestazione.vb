Public Class TipoPrestazione
   Inherits AbstractPersistenceObject
    ' Implements ITipoPrestazione

   Private m_CodicePrestazione As String = ""
   Private m_NomeFileModello As String = ""
   Private m_PathOutPut As String = "C:\"

   Public Sub New()
      '
   End Sub
   Public Sub New(ByVal Descrizione As String, ByVal CodicePrestazione As String, _
                     ByVal NomeFileModello As String, ByVal PathOutPut As String)
      If Descrizione = "" Then Throw New Exception("Impossibile creare un tipo prestazione. Descrizione nulla")
      If CodicePrestazione = "" Then Throw New Exception("Impossibile creare un tipo prestazione. Codice prestazione nullo")
      'If TestFileExistence(NomeFileModello) Then
      m_CodicePrestazione = CodicePrestazione
      MyBase.Descrizione = Descrizione
      m_NomeFileModello = NomeFileModello
      m_PathOutPut = PathOutPut
      CreateDir(m_PathOutPut)
      ' End If
   End Sub

   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function
    'Public Overrides ReadOnly Property Id() As Integer Implements ITipoPrestazione.Id
    '    Get
    '        Return MyBase.Id
    '    End Get
    'End Property
   Public Property CodicePrestazione() As String
      Get
         Return m_CodicePrestazione
      End Get
      Set(ByVal value As String)
         If value = "" Then Throw New Exception("Impossibile impostare il codice prestazione. Codice nullo")
         m_CodicePrestazione = value
      End Set
   End Property
    Public Overrides Property Descrizione() As String
        Get
            Return MyBase.Descrizione
        End Get
        Set(ByVal value As String)
            If value = "" Then Throw New Exception("Impossibile impostare la descrizione per il tipo prestazione. Descrizione nulla")
            MyBase.Descrizione = value
        End Set
    End Property
   Public Property PathOutPut() As String
      Get
         If PathOutputExist() Then Return m_PathOutPut
         Return GetDefaultOutPutPath()
      End Get
      Set(ByVal value As String)
         m_PathOutPut = value
         CreateDir(value)
      End Set
   End Property
   Public Property NomeFileModello() As String
      Get
         Return m_NomeFileModello
      End Get
      Set(ByVal value As String)
         'Try
         'If TestFileExistence(value) Then
         m_NomeFileModello = value
         'Else
         ' Throw New Exception("File inesistente")
         ' End If
         'Catch ex As Exception
         '   Throw New Exception("Impossibile impostare il file modello per il tipo prestazione." & vbCrLf & ex.Message)
         'End Try
      End Set
   End Property

   Public Overridable Function FileModelloExist() As Boolean
      If My.Computer.FileSystem.FileExists(m_NomeFileModello) Then Return True
      Return False
   End Function
   Public Overridable Function PathOutputExist() As Boolean
      If My.Computer.FileSystem.DirectoryExists(m_PathOutPut) Then Return True
      Return False
   End Function
   'Public Function GetFileOutputName(ByVal Criteria As String) As String
   '   If Me.FileModelloExist Then
   '      Return BuildFileOutputName(Criteria)
   '   Else
   '      Throw New Exception("Impossibile ottenere il nome del file di output. File modello inesistente.")
   '   End If
   'End Function

   Public Function GetFileOutputName(ByVal Utente As Utente) As String
      If Me.FileModelloExist Then
         Return BuildFileOutputName(Utente)
      Else
         Throw New Exception("Impossibile ottenere il nome del file di output. File modello inesistente.")
      End If
   End Function

   Private Function BuildFileOutputName(ByVal Utente As Utente) As String
      Dim outputFile As String = ""
      Dim i As Int32 = 1
      'Dim ext As String = My.Computer.FileSystem.GetFileInfo(m_NomeFileModello).Extension
      Dim name As String = m_CodicePrestazione & "-" & Utente.CompleteName & "-" & My.Computer.FileSystem.GetFileInfo(m_NomeFileModello).Name
      Dim path As String
      If My.Computer.FileSystem.DirectoryExists(Utente.DirectoryPreferenziale) Then
         path = Utente.DirectoryPreferenziale
      ElseIf Utente.Segreteria IsNot Nothing Then
         path = Utente.Segreteria.DirectoryPreferenzialeUtenti
      Else
         path = PathOutPut
      End If
      outputFile = My.Computer.FileSystem.CombinePath(path, name)
      Do While My.Computer.FileSystem.FileExists(outputFile)
         Dim temp As String = i.ToString & "-" & name
         outputFile = My.Computer.FileSystem.CombinePath(path, temp)
         i = i + 1
         temp = ""
      Loop
      Return outputFile
   End Function



   'Private Function BuildFileOutputName(ByVal criteria As String) As String
   '   Dim outputFile As String = ""
   '   Dim i As Int32 = 1
   '   'Dim ext As String = My.Computer.FileSystem.GetFileInfo(m_NomeFileModello).Extension
   '   Dim name As String = m_CodicePrestazione & "-" & criteria & "-" & My.Computer.FileSystem.GetFileInfo(m_NomeFileModello).Name
   '   outputFile = My.Computer.FileSystem.CombinePath(PathOutPut, name)
   '   Do While My.Computer.FileSystem.FileExists(outputFile)
   '      Dim temp As String = i.ToString & "-" & name
   '      outputFile = My.Computer.FileSystem.CombinePath(PathOutPut, temp)
   '      i = i + 1
   '      temp = ""
   '   Loop
   '   Return outputFile
   'End Function
   Private Function GetDefaultOutPutPath() As String
      Return "C:\"
   End Function
   Private Sub CreateDir(ByVal NomeDir As String)
      Try
         If NomeDir = "" Then Exit Sub
         If Not My.Computer.FileSystem.DirectoryExists(NomeDir) Then
            Try
               My.Computer.FileSystem.CreateDirectory(NomeDir)
            Catch ex As Exception

            End Try

         End If
      Catch ex As System.IO.DirectoryNotFoundException

      End Try
   End Sub
   Private Function TestFileExistence(ByVal NomeFile As String) As Boolean
      If NomeFile = "" Then Return True
      Return My.Computer.FileSystem.FileExists(NomeFile)
   End Function

    Public ReadOnly Property TipoDocumento() As String
        Get
            Return Me.m_CodicePrestazione
        End Get
    End Property





End Class
