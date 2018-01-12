Public Class FrmAllegaFile
   Private m_Destination As String = ""
   Private m_fileName As String = ""
   Private m_fileMovedOrCopied As Boolean = False
   Private m_FileRegistry As String


   Public Sub New(Optional ByVal optionTool As Boolean = False)

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      If optionTool Then
         optMove.Checked = True
         optNoAction.Enabled = False
      End If
      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
   End Sub

 

   Public WriteOnly Property Destination() As String
      Set(ByVal value As String)
         m_Destination = value
         LinkLabel1.Text = m_Destination
         If LinkLabel1.Text = "" Then
            LinkLabel1.Text = "-- Impostare un percorso di default --"
         End If
      End Set
   End Property

   Public ReadOnly Property FileName() As String
      Get
         Return m_fileName
      End Get
   End Property


   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

      'Verifico che ci sia un file da importare
      If txtFile.Text = "" Then
         MsgBox("Inserire un nome file corretto", MsgBoxStyle.Information, "FenealGest")
         Return
      End If

      'Prendo la directory del file da importare
      Dim path As String = My.Computer.FileSystem.GetFileInfo(txtFile.Text).DirectoryName
      'Isolo il nome del file
      Dim filename As String = My.Computer.FileSystem.GetFileInfo(txtFile.Text).Name
      ''Ricopio il nome del file in un registro (mi servirà per eventuali sovrascrittture)
      'Dim fileRegistry As String = filename





      Try
         'imposto a livello interno il nome del file da importare
         m_fileName = filename

         'Se non c'è nessuna azione da eseguire prendo il nome del file allegato e ritorno
         If optNoAction.Checked Then
            m_fileName = txtFile.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Return
         End If

         'Poichè devo copiare il file o spostarlo verifico il percorso di destinazione
         If m_Destination = "" Then
            MsgBox("Impostare un percorso di destinazione", MsgBoxStyle.Information, "FenealGest")
            Return
         End If

       
         'Verifico se l'operazione è andata a buon fine
         If IsFileMovedOrCopied() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
         Else
            Me.DialogResult = Windows.Forms.DialogResult.Abort
         End If

         'Chiudo il form
         Me.Close()
         Return

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

   Private Function IsFileMovedOrCopied() As Boolean

      'Ricopio il nome del file in un registro (mi servirà per eventuali sovrascrittture)
      m_FileRegistry = m_fileName

      'Costruisco il file di arrivo
      m_fileName = System.IO.Path.Combine(m_Destination, m_fileName)
      'If m_Destination.EndsWith("\") Then
      '   m_fileName = m_Destination & m_fileName
      'Else
      '   m_fileName = m_Destination & "\" & m_fileName
      'End If

      'Se muovo il file eseguo questa azione
      If optMove.Checked Then
         MoveFile(True, CheckBox1.Checked)
      Else
         MoveFile(False, CheckBox1.Checked)
      End If

      'se l'operazione move ha effettuato uno spostamento o una copia
      'allora lo  notifico
      If m_fileMovedOrCopied Then
         Return True
      End If

      Return False

   End Function
 



   Private Sub MoveFile(ByVal move As Boolean, ByVal overwrite As Boolean)
      'Se il file di destinazione non esiste eseguo l'azione ed esco
      If Not My.Computer.FileSystem.FileExists(m_fileName) Then
         DoMove(move, False)
         m_fileMovedOrCopied = True
         Return
      End If

      'se il file di destinazione esiste ed ho impostato il flag di sovrascrittura
      'chiedo nnotifica all'utente
      If overwrite Then
         If MsgBox("Si sta per sovrascrivere un file esistente. Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Domanda") = MsgBoxResult.Yes Then
            DoMove(move, True)
            m_fileMovedOrCopied = True
            Return
         Else
            m_fileMovedOrCopied = False
            Return
         End If
      End If

      'se il file di destinazione esiste e non ho impostato il flag di sovrascrittura
      'chiedo nnotifica all'utente di rinominare il file di destinazione
      If MsgBox("Il file selezionato è gia esistente nella cartella di destinazione. Il sistema rinominerà il file selezionato per copiarlo o spostarlo nella cartella prescelta. Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Domanda") = MsgBoxResult.Yes Then
         m_FileRegistry = CostruisciNuovoNomeFile()
         m_fileName = m_FileRegistry
         DoMove(move, False)
         m_fileMovedOrCopied = True
         Return
      End If

      m_fileMovedOrCopied = False
   End Sub

   Private Function CostruisciNuovoNomeFile() As String
      Dim i As Int32 = 1
      Dim temp As String = System.IO.Path.Combine(m_Destination, m_FileRegistry)
      Do While My.Computer.FileSystem.FileExists(temp)
         temp = ""
         temp = i.ToString & "-" & m_FileRegistry
         temp = My.Computer.FileSystem.CombinePath(m_Destination, temp)
         i = i + 1
      Loop
      Return temp
   End Function



   Private Sub DoMove(ByVal move As Boolean, ByVal overwrite As Boolean)
      If move Then
         My.Computer.FileSystem.MoveFile(txtFile.Text, m_fileName, overwrite)
      Else
         My.Computer.FileSystem.CopyFile(txtFile.Text, m_fileName, overwrite)
      End If
   End Sub


   Private Sub cmdSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSel.Click
      OpenFileDialog1.CheckFileExists = True
      OpenFileDialog1.ShowDialog()
      txtFile.Text = OpenFileDialog1.FileName
   End Sub

   Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
      FolderBrowserDialog1.ShowNewFolderButton = True
      FolderBrowserDialog1.Description = "Seleziona nuova cartella di destinazione"
      If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
         Destination = FolderBrowserDialog1.SelectedPath
      End If
   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub
End Class