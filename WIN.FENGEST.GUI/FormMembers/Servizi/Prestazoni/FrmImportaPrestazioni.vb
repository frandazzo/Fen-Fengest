Imports System.Windows.Forms
Public Class FrmImportaPrestazioni
   Private controllerUtente As New UTENTI.ControllerUtenti
   Private controllerPrestazioni As New ADMINISTRATION.ControllerPrestazioni
   Private controllerTipiPrestazioni As New ADMINISTRATION.ControllerTipoPrestazione


   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub


   Public Sub New(ByVal IdUtente As Int32)
      InitializeComponent()
      txtUtente.Text = IdUtente
      controllerUtente.LoadById(IdUtente)
      lblUtente.Text = controllerUtente.CompleteName
      If Not My.Computer.FileSystem.DirectoryExists(controllerUtente.CartellaPreferenziale) Then
         Throw New Exception("La cartella preferenziale dell'utnente non esiste. Crearla!")
      Else
         lblPath.Text = controllerUtente.CartellaPreferenziale
      End If
      Dim col As DataGridViewComboBoxColumn = DataGridView1.Columns("Tipo")

      col.DataSource = controllerTipiPrestazioni.GetAll
      col.DisplayMember = "Descrizione"
      col.ValueMember = "Id"


   End Sub


   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      If MsgBox("Saranno create nuove prestazioni nella cartella  preferenziale dell'utente. La data di ogni prestazione sarà quella di creazione del file selezionato. Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Domanda") = MsgBoxResult.Yes Then
         Try
           

            CheckInputs()
            ImportaPrestazioni()



         Catch ex As Exception
            ErrorHandler.ShowError(ex)
         End Try
      End If

   End Sub

   Private Sub ImportaPrestazioni()

      Dim erroreString As String = ""
      Dim elaborazioneEseguita As Boolean = False

      For Each elem As DataGridViewRow In DataGridView1.Rows
         If elem.Cells("Sel").Value = True Then
            If elem.Cells("Tipo").Value IsNot Nothing Then
               If elem.Cells("File").Value IsNot Nothing Then

                  Try
                     controllerPrestazioni.CreateNew(txtUtente.Text, elem.Cells("Tipo").Value.ToString, elem.Cells("File").Value.ToString, optSposta.Checked)
                  Catch ex As Exception
                     erroreString += ex.Message & Environment.NewLine
                  End Try
                  elaborazioneEseguita = True
               End If
            End If
         End If
      Next

      If erroreString <> "" Then
         My.Computer.FileSystem.WriteAllText(lblPathLog.Text & "\" & "ImportazionePrestazioniLog.txt", erroreString, False)
         MsgBox("Importazione terminata con errori. Visualizzare il file di log!", MsgBoxStyle.Exclamation, "Errore")
         Me.cmdOk.Enabled = False
      Else
         If elaborazioneEseguita Then
            MsgBox("Importazione terminata con successo!", MsgBoxStyle.Information, "Informazione")
            Me.cmdOk.Enabled = False
         End If

      End If


   End Sub


   Private Sub cmdSelectPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectPath.Click
      FolderBrowserDialog1.ShowNewFolderButton = True
      If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
         lblPath.Text = FolderBrowserDialog1.SelectedPath
      End If
   End Sub

   Private Sub cmdSelectPathLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectPathLog.Click
      If Not My.Computer.FileSystem.DirectoryExists(lblPath.Text) Then
         MsgBox("Inserire un percorso di ricerca dei file", MsgBoxStyle.Information, "Informazione")
         Return
      End If
      FolderBrowserDialog1.ShowNewFolderButton = True
      If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
         lblPathLog.Text = FolderBrowserDialog1.SelectedPath
      End If
   End Sub


   Private Sub CheckInputs()
      If Not My.Computer.FileSystem.DirectoryExists(lblPath.Text) Then
         MsgBox("Inserire un percorso di ricerca dei file", MsgBoxStyle.Information, "Informazione")
         Return
      End If
      If Not My.Computer.FileSystem.DirectoryExists(lblPathLog.Text) Then
         MsgBox("Inserire un percorso per il file di log", MsgBoxStyle.Information, "Informazione")
         Return
      End If
      If cboExt.Text = "" Then
         MsgBox("Inserire una estensione di file da ricercare", MsgBoxStyle.Information, "Informazione")
         Return
      End If
   End Sub
   Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.Click
      CheckInputs()

      DataGridView1.Rows.Clear()
      For Each foundFile As String In My.Computer.FileSystem.GetFiles(lblPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*." & cboExt.Text)

         DataGridView1.Rows.Add(False, foundFile)

      Next
     

      If DataGridView1.Rows.Count > 0 Then
         cmdOk.Enabled = True
      End If


   End Sub



End Class
