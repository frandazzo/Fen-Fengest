Public Class Prestazione
   Inherits AbstractDocumento
   Private m_Utente As Utente = New UtenteNonSpecificato
   Private m_Referente As Referente = New ReferenteNullo
   Private m_TipoPrestazione As TipoPrestazione = New TipoPrestazioneNulla
   Private m_FileOutput As String = ""
   Public Sub New(ByVal DataDocumento As DateTime, ByVal DataRegistrazione As DateTime, _
                     ByVal Note As String, ByVal Utente As Utente, ByVal Referente As Referente, _
                     ByVal TipoPrestazione As TipoPrestazione)
      MyBase.New(DataDocumento, DataRegistrazione, Note)
      If TipoPrestazione Is Nothing Then Throw New Exception("Impossibile impostare il tipo prestazione per la prestazione richiesta. Tipo prestazione nullo")
      If TipoPrestazione.Id = -1 Then Throw New Exception("Impossibile impostare il tipo prestazione per la prestazione richiesta. Tipo tipo prestazione nullo")
      If Utente Is Nothing Then Throw New Exception("Impossibile impostare l'utente per la prestazione richiesta. Utente nullo")
      If Utente.Id = -1 Then Throw New Exception("Impossibile impostare l'utente per la prestazione richiesta. Tipo utente nullo")
      If Referente Is Nothing Then Throw New Exception("Impossibile impostare il referente per la prestazione richiesta. Referente nullo")
      m_Referente = Referente
      m_Utente = Utente
      m_TipoPrestazione = TipoPrestazione
      MyBase.m_TipoDocumento = TipoPrestazione.CodicePrestazione
   End Sub
   Public Sub New()

   End Sub

   Public Overrides Function ToString() As String
      If Me.Id = -1 Then
         Return ""
      End If
      Return Me.Id.ToString
   End Function

 
    Public Property TipoPrestazione() As TipoPrestazione
        Get
            Return m_TipoPrestazione
        End Get
        Set(ByVal value As TipoPrestazione)
            If value Is Nothing Then Throw New Exception("Impossibile impostare il tipo prestazione per la prestazione richiesta. Tipo prestazione nullo")
            If value.Id = -1 Then Throw New Exception("Impossibile impostare il tipo prestazione per la prestazione richiesta. Tipo tipo prestazione nullo")
            m_TipoPrestazione = value
            MyBase.m_TipoDocumento = DirectCast(value, TipoPrestazione).CodicePrestazione
        End Set
    End Property
   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         If value Is Nothing Then Throw New Exception("Impossibile impostare l'utente per la prestazione richiesta. Utente nullo")
         If value.Id = -1 Then Throw New Exception("Impossibile impostare l'utente per la prestazione richiesta. Tipo utente nullo")
         m_Utente = value
      End Set
   End Property
   Public Property Referente() As Referente
      Get
         Return m_Referente
      End Get
      Set(ByVal value As Referente)
         If value Is Nothing Then Throw New Exception("Impossibile impostare il referente per la prestazione richiesta. Referente nullo")
         m_Referente = value
      End Set
   End Property




#Region "Metodi per la gestione del file di output"
   Public ReadOnly Property FileOutPut() As String
      Get
         Return m_FileOutput
      End Get
   End Property
   ''' <summary>
   ''' Imposta il riferimento al file di output . Il percorso viene preso
   ''' dalla directory di output del tipo di prestazione riferita.
   ''' </summary>
   ''' <param name="FileName"></param>
   ''' <remarks></remarks>
   Public Overloads Sub SetFileOutput(ByVal FileName As String)
      m_FileOutput = FileName

      'If My.Computer.FileSystem.FileExists(FileName) Then
      '   m_FileOutput = FileName
      'Else
      '   If FileName = "" Then
      '      Exit Sub
      '   End If
      '   m_FileOutput = TryWithTipoPrestazionePath(My.Computer.FileSystem.GetFileInfo(FileName).Name)
      'End If
   End Sub
   'Private Function TryWithTipoPrestazionePath(ByVal FileName As String) As String
   '   If Not m_TipoPrestazione Is Nothing OrElse TypeOf (m_TipoPrestazione) Is TipoPrestazioneNulla Then
   '      Dim newFileName As String = My.Computer.FileSystem.CombinePath(m_TipoPrestazione.PathOutPut, FileName)
   '      If System.IO.File.Exists(newFileName) Then
   '         Return newFileName
   '      Else
   '         Return ""
   '      End If
   '   Else
   '      Return ""
   '   End If
   'End Function
   ''' <summary>
   ''' Rimuove il file il riferimento al file di output e cancella il  file se esiste
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub RemoveOutputFile()
      'If My.Computer.FileSystem.FileExists(m_FileOutput) Then
      '   My.Computer.FileSystem.DeleteFile(m_FileOutput)
      'End If
      SimpleFileSystemManager.RemoveFile(m_FileOutput)
      m_FileOutput = ""
   End Sub
   ''' <summary>
   ''' Rimuove il riferimento del documento di prestazione dal file di output
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub RemoveReferenceToOutputFile()
      m_FileOutput = ""
   End Sub
   ''' <summary>
   ''' Crea il file di output.
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub CreaFileOutPut()
      Try
         'With m_TipoPrestazione
         '   If .FileModelloExist Then
         '      m_FileOutput = .GetFileOutputName(m_Utente)
         '      My.Computer.FileSystem.CopyFile(.NomeFileModello, m_FileOutput)
         '   End If
         'End With
         Dim c As IDocumentCreatorAdapter = DocumentCreatorFactory.GetAdapter(m_TipoPrestazione.NomeFileModello)
         c.CreateDocument(Me)
      Catch ex As Exception
         Throw New Exception("Impossibile creare il file di output." & vbCrLf & ex.Message)
      End Try
   End Sub
   Public Function OutputFileExist() As Boolean
      Return My.Computer.FileSystem.FileExists(m_FileOutput)
   End Function
   ''' <summary>
   ''' Rinomina il file di output
   ''' </summary>
   ''' <param name="NewName">Parametro che definisce il solo nome del file senza estensione e senza percorso</param>
   ''' <remarks></remarks>
   Public Sub RenameFileOutPut(ByVal NewName As String)
      If NewName = "" Then Throw New Exception("Impossibile rinominare il file di output. Nome file nullo.")
      If m_FileOutput = "" Then Throw New Exception("Impossibile rinominare il file. Riferimento inesistente.")
      If Not My.Computer.FileSystem.FileExists(m_FileOutput) Then Throw New Exception("Impossibile rinominare il file. File inesistente.")
      NewName = BuildNewFileName(NewName)
      If Not My.Computer.FileSystem.FileExists(NewName) Then
         My.Computer.FileSystem.RenameFile(m_FileOutput, NewName)
         m_FileOutput = My.Computer.FileSystem.CombinePath(m_TipoPrestazione.PathOutPut, NewName)
      Else
         Throw New Exception("Impossibile rinominare il file di output. Esiste già un file con lo stesso nome.")
      End If

   End Sub

   Private Function BuildNewFileName(ByVal NewName As String) As String
      Return NewName & My.Computer.FileSystem.GetFileInfo(Me.FileOutPut).Extension
   End Function

#End Region
End Class
