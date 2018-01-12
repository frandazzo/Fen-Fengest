Namespace ADMINISTRATION
   Public Class ControllerPrestazioni
      Inherits AbstractController
      Private ControllerUtenti As New UTENTI.ControllerUtenti
      Private controllerReferenti As New FINANCIAL_ARTIFACTS.ControllerReferenti
      Private controllerTipo As New ADMINISTRATION.ControllerTipoPrestazione

      Private Function Current() As Prestazione
         Return DirectCast(m_current, Prestazione)
      End Function

#Region "Proprietà oggetto"
      Public Property DataRegistrazione() As DateTime
         Get
            Return Current.DataRegistrazione
         End Get
         Set(ByVal value As DateTime)
            Current.DataRegistrazione = value
         End Set
      End Property
      Public Property DataDocumento() As DateTime
         Get
            Return Current.DataDocumento
         End Get
         Set(ByVal value As DateTime)
            Current.DataDocumento = value
         End Set
      End Property
      Public Property Note() As String
         Get
            Return Current.Note
         End Get
         Set(ByVal value As String)
            Current.Note = value
         End Set
      End Property
      Public ReadOnly Property IdUtente() As Int32
         Get
            Return Current.Utente.Id
         End Get
      End Property
      Public Sub SetUtente(ByVal IdUtente As String)
         Try
            If Not IsNumeric(IdUtente) Then Throw New Exception("Id utente errato.")
            Current.Utente = ControllerUtenti.GetUtenteById(IdUtente)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare l'utente per la prestazione" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IdReferente() As String
         Get
            If Current.Referente.Id = -1 Then Return ""
            Return Current.Referente.Id
         End Get
      End Property
      Public Sub SetReferente(ByVal IdReferente As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdReferente) Then Throw New Exception("Id referente errato.")
            Current.Referente = controllerReferenti.GetReferenteById(IdReferente)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare il referente per la prestazione" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IdPrestazione() As String
         Get
            Return Current.Id
         End Get
      End Property
      Public ReadOnly Property CodiceTipoPrestazione() As String
         Get
            Return Current.TipoDocumento
         End Get
      End Property
      Public Sub SetTipoPrestazione(ByVal IdTipoPrestazione As String)
         Try
            If Not IsNumeric(IdTipoPrestazione) Then Throw New Exception("Id tipo prestazione errato")
            Current.TipoPrestazione = controllerTipo.GetTipoPrestazioneById(IdTipoPrestazione)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare il tipo prestazione" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IdTipoPrestazione() As Int32
         Get
            Return Current.TipoPrestazione.Id
         End Get
      End Property
      Public ReadOnly Property DescrizioneUtente() As String
         Get
            Return Current.Utente.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneReferente() As String
         Get
            Return Current.Referente.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneTipoPrestazione() As String
         Get
            Return Current.TipoPrestazione.Descrizione
         End Get
      End Property
      Public Property NomeFileOutput() As String
         Get
            Return Current.FileOutPut
         End Get
         Set(ByVal value As String)
            Current.SetFileOutput(value)
         End Set
      End Property
#End Region
      Public Sub OpenFile(ByVal FileName As String)
         'Try
         '   If FileName = "" Then Throw New ArgumentException("Nome file vuoto")
         '   If Not System.IO.File.Exists(FileName) Then Throw New ArgumentException("File inesistente")
         '   Dim pInfo As New ProcessStartInfo()
         '   pInfo.FileName = FileName
         '   pInfo.UseShellExecute = True
         '   Dim p As Process = Process.Start(pInfo)
         'Catch ex As Exception
         '   Throw New ArgumentException("Impossibile aprire il file specificato" & vbCrLf & ex.Message, "Filename")
         'End Try
         SimpleFileSystemManager.ViewFile(FileName)
      End Sub
      Public Sub CreaFileOutput()
         Try
            Current.CreaFileOutPut()
            Save()
         Catch ex As Exception
            Throw New Exception("Impossibile creare il file di output" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Sub RenameFileOutput(ByVal NewName As String)
         Try
            Current.RenameFileOutPut(NewName)
            Save()
         Catch ex As Exception
            Throw New Exception("Impossibile rinominare il file di output" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Sub SetFileOutput(ByVal FileName As String)
         Try
            Current.SetFileOutput(FileName)
            Save()
         Catch ex As Exception
            Throw New Exception("Impossibile impostare il file di output" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Sub RemoveReferenceToOutputFile()
         Try
            Current.RemoveReferenceToOutputFile()
            Save()
         Catch ex As Exception
            Throw New Exception("Impossibile rimuovere il riferimento al file di output" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Sub RemoveOutputFile()
         Try
            Current.RemoveOutputFile()
            Save()
         Catch ex As Exception
            Throw New Exception("Impossibile eliminare il file di output" & vbCrLf & ex.Message)
         End Try
      End Sub

      Public Overrides Function GetCategoryObject() As String
         Return "Prestazione"
      End Function
      Friend Function GetPrestazioneById(ByVal Id As String) As Prestazione
         Try
            If Id = -1 Then Return New PrestazioneNulla
            Me.LoadById(Id)
            Return Current()
         Catch ex As Exception
            Return New PrestazioneNulla
         End Try
      End Function
      Public Sub LoadAllByUtente(ByVal IdUtente As String)
         Try
            If Not IsNumeric(IdUtente) Then Throw New Exception("Id Utente errato.")
            Dim query As Query = Ps.CreateNewQuery("MapperPrestazione")
            Dim mainCriteria As Criteria = Criteria.Equal("ID_UTENTE", IdUtente)
            query.AddWhereClause(mainCriteria)
            DomainObjectList = query.Execute(ps)
         Catch ex As Exception
            Throw New Exception("Impossibile caricare tutte le prestazioni per l'utente selezionato" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Function GetPrestazioniByUtente(ByVal IdUtente As String) As IList
         Try
            LoadAllByUtente(IdUtente)
            Return DomainObjectList
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere tutte le prestazioni per l'utente selezionato" & vbCrLf & ex.Message)
         End Try
        End Function


        Public Function GetIdPrestazioniUtentePatternNote(ByVal IdUtente As String, nota As String) As Int32
            Try
                LoadAllByUtente(IdUtente)
                For Each elem As Prestazione In DomainObjectList
                    If elem.Note.Contains(nota) Then
                        Return elem.Id
                    End If
                Next
                Return -1
            Catch ex As Exception
                Throw New Exception("Impossibile ottenere tutte le prestazioni per l'utente selezionato" & vbCrLf & ex.Message)
            End Try
        End Function

      Public Overrides Sub CreateNew()
         m_current = New Prestazione
      End Sub
      Public Overloads Sub CreateNew(ByVal DataDocumento As DateTime, ByVal DataRegistrazione As DateTime, ByVal Note As String, ByVal IdUtente As String, ByVal IdReferente As String, ByVal IdTipoPrestazione As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente  non ha un formato corretto!")
            If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente non ha un formato corretto!")
            If Not IsNumeric(IdTipoPrestazione) Then Throw New Exception("L'id tipo prestazione non ha un formato corretto!")
            Dim referente As Referente = controllerReferenti.GetReferenteById(IdReferente)
            If referente Is Nothing Then referente = New ReferenteNullo
            Dim Prestazione As Prestazione = New Prestazione(DataDocumento.Date, DataRegistrazione.Date, Note, ControllerUtenti.GetUtenteById(IdUtente), Referente, controllerTipo.GetTipoPrestazioneById(IdTipoPrestazione))
            m_current = Prestazione
            Save()
         Catch ex As Exception
            Throw New Exception("Impossibile creare una nuova prestazione." & vbCrLf & ex.Message)
         End Try
      End Sub

      Public Sub DuplicaPrestazione(ByVal idPrestazione As Int32)
         Dim prestazione As Prestazione = SearchPrestazione(idPrestazione)

         Dim idReferente As String = ""
         If prestazione.Referente.Id = -1 Then
            idReferente = ""
         Else
            idReferente = prestazione.Referente.Id
         End If

         CreateNew(DateTime.Now.Date, DateTime.Now.Date, prestazione.Note, prestazione.Utente.Id, idReferente, prestazione.TipoPrestazione.Id)

         If My.Computer.FileSystem.FileExists(prestazione.FileOutPut) Then
            Dim filename As String = My.Computer.FileSystem.GetFileInfo(prestazione.FileOutPut).Name
            filename = Format(Now, "dd-MM-yy_hh-mm-ss") & "_" & filename
            My.Computer.FileSystem.CopyFile(prestazione.FileOutPut, My.Computer.FileSystem.GetFileInfo(prestazione.FileOutPut).DirectoryName & "\" & filename)
            Me.SetFileOutput(My.Computer.FileSystem.GetFileInfo(prestazione.FileOutPut).DirectoryName & "\" & filename)

         End If

      End Sub


      Public Overloads Sub CreateNew(ByVal idUtente As String, ByVal tipoPrestazioneId As String, ByVal filePrestazione As String, ByVal moveFile As Boolean)

         If Not IsNumeric(idUtente) Then Throw New Exception("L'id utente  non ha un formato corretto!")
         Dim utente As Utente = ControllerUtenti.GetUtenteById(idUtente)
         If utente Is Nothing Then
            Throw New Exception("Utente non trovato")
         End If

         If Not My.Computer.FileSystem.DirectoryExists(utente.DirectoryPreferenziale) Then
            Throw New Exception("Cartella preferenziale non impostata per l'utente " & utente.CompleteName)
         End If

         If Not My.Computer.FileSystem.FileExists(filePrestazione) Then
            Throw New IO.FileNotFoundException("Il file non è stato trovato", filePrestazione)
         End If

         Dim fileName As String = My.Computer.FileSystem.GetFileInfo(filePrestazione).Name

         Dim dataCreazioneFile As Date = My.Computer.FileSystem.GetFileInfo(filePrestazione).CreationTime
         CreateNew(dataCreazioneFile, dataCreazioneFile, "", idUtente, "-1", tipoPrestazioneId)

         'A questo punto ho creato la prestazione e devo solo associargli il file
         CopyOrMoveFile(fileName, utente, moveFile, filePrestazione)
         Me.SetFileOutput(utente.DirectoryPreferenziale & "\" & fileName)


      End Sub



      Public Sub CopyOrMoveFile(ByVal fileName As String, ByVal utente As Utente, ByVal moveFile As Boolean, ByVal filePrestazione As String)
         If filePrestazione.ToUpper = (utente.DirectoryPreferenziale & "\" & fileName).ToUpper Then
            Return
         End If
         Try
            If moveFile Then
               My.Computer.FileSystem.MoveFile(filePrestazione, utente.DirectoryPreferenziale & "\" & fileName)
            Else
               My.Computer.FileSystem.CopyFile(filePrestazione, utente.DirectoryPreferenziale & "\" & fileName)
            End If
         Catch ex As Exception
            Throw New Exception("Impossibile copiare il file " & filePrestazione & "! " & Environment.NewLine & " La prestazione per l'utente " & utente.CompleteName & " è stata creata ma non è stato possibile copiare o spsstare il file nella cartella utente." & Environment.NewLine & ex.Message)
         End Try
      End Sub



      Private Function SearchPrestazione(ByVal idPrestazione) As Prestazione
         For Each elem As Prestazione In Me.DomainObjectList
            If elem.Id = idPrestazione Then
               Return elem
            End If
         Next
         Throw New Exception("Non esiste la prestazione selezionata per l'utente")
      End Function


   End Class
End Namespace