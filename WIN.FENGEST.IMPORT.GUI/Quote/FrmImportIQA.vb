Imports WIN.SECURITY

Public Class FrmImportIQA
    Private WithEvents scheduler As ImportIQAScheduler
    Private WithEvents schedulerIQP As ImportIQPScheduler

   Private Sub cmdLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLog.Click
      Me.FolderBrowserDialog1.ShowDialog()
      txtLog.Text = Me.FolderBrowserDialog1.SelectedPath
   End Sub

   Private Sub cmdFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFile.Click
      Me.OpenFileDialog1.ShowDialog()
      Me.txtFile.Text = Me.OpenFileDialog1.FileName
   End Sub

   Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
      Try
         cmdImport.Enabled = False
         If txtLog.Text = "" Then
            MsgBox("Inserire un percorso per il file di log", MsgBoxStyle.Information)
            Exit Sub
         End If
         If txtFile.Text = "" Then
            MsgBox("Inserire un  file di importazione", MsgBoxStyle.Information)
            Exit Sub
         End If
            If Not (My.Computer.FileSystem.GetFileInfo(txtFile.Text).Extension.ToLower = ".xls" Or My.Computer.FileSystem.GetFileInfo(txtFile.Text).Extension.ToLower = ".xlsx") Then
                MsgBox("Inserire un file di importazione di tipo Excel", MsgBoxStyle.Information)
                Exit Sub
            End If



            If optIQA.Checked Then
                scheduler = New ImportIQAScheduler(txtFile.Text, txtLog.Text, chkUpdate.Checked, chkUpdateAz.Checked, chkAddDelega.Checked)
                scheduler.CheckPaybility = chkCheck.Checked
                scheduler.StartImport()
            Else
                schedulerIQP = New ImportIQPScheduler(txtFile.Text, txtLog.Text, chkUpdate.Checked, chkUpdateAz.Checked, chkAddDelega.Checked)
                schedulerIQP.CheckPaybility = chkCheck.Checked
                schedulerIQP.StartImport()
            End If

      Catch ex As Exception

         MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
      Finally
         cmdImport.Enabled = True
      End Try




   End Sub

   Private Sub scheduler_AddingRecord(ByVal IdRecord As Integer) Handles scheduler.AddingRecord
      Me.txtTask.Text = "Inserimento dell'item " & IdRecord.ToString
      System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginDocumentWriting() Handles scheduler.BeginDocumentWriting
        Me.txtTask.Text = "Preparazione scrittura documento"
        System.Windows.Forms.Application.DoEvents()
    End Sub


   Private Sub scheduler_BeginParse() Handles scheduler.BeginParse
      Me.lstActivity.Items.Add("Iniziata analisi formato file")
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub scheduler_BeginRetrieving() Handles scheduler.BeginRetrieving
      Me.lstActivity.Items.Add("Iniziato recupero dati dal file")
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub scheduler_BeginWriting() Handles scheduler.BeginWriting
        Me.lstActivity.Items.Add("Scrittura iniziata")
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub scheduler_BeginWritingIQA() Handles scheduler.BeginWritingIQA
        Me.lstActivity.Items.Add("Salvataggio documento in corso...")
      System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_DocumentsFound(NumberOfDocuments As Integer) Handles scheduler.DocumentsFound
        Me.lstActivity.Items.Add("Sono stati trovati  " & NumberOfDocuments & " documenti")
        Me.lstActivity.Items.Add("******************************************")
        Me.lstActivity.Items.Add("******************************************")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndImport(Errors As Integer, Inserted As Integer) Handles scheduler.EndImport
        Me.lstActivity.Items.Add("Importazione elaborata con " & Errors & " errori totali e " & Inserted & " posizioni totali correttamente inserite")
        System.Windows.Forms.Application.DoEvents()
    End Sub

   Private Sub scheduler_EndParse(ByVal NumberOfRecords As Integer) Handles scheduler.EndParse
      Me.lstActivity.Items.Add("Termine analisi formato file. Trovati " & NumberOfRecords & " records")
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub scheduler_EndRetrieving(ByVal NumberOfRecords As Integer) Handles scheduler.EndRetrieving
      Me.lstActivity.Items.Add("Termine recupero dati file.")
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub scheduler_EndWriting(ByVal Errors As Integer, ByVal Inserted As Integer) Handles scheduler.EndWriting
        'Me.lstActivity.Items.Add("Terminata attività di scrittura dei prerequisiti")
        Me.lstActivity.Items.Add("Documento elaborato con " & Errors & " errori e " & Inserted & " posizioni correttamente inserite")
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub scheduler_EndWritingIQA() Handles scheduler.EndWritingIQA
        Me.lstActivity.Items.Add("Salvataggio effettuato!")
      System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_NotifyDocumentError(errorData As String) Handles scheduler.NotifyDocumentError
        Me.lstActivity.Items.Add(errorData)
        Me.lstActivity.Items.Add("******************************************")
    End Sub

   Private Sub scheduler_RetrievingRecord(ByVal IdRecord As Integer) Handles scheduler.RetrievingRecord
      Me.txtTask.Text = "Recupero del record " & IdRecord.ToString
      System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_WritingDocument(idDocument As Integer) Handles scheduler.WritingDocument
        Me.lstActivity.Items.Add("Terminata scrittura del documento  " & idDocument.ToString)
        Me.lstActivity.Items.Add("******************************************")
        System.Windows.Forms.Application.DoEvents()
    End Sub

   Private Sub scheduler_WritingRecord(ByVal IdRecord As Integer) Handles scheduler.WritingRecord
        Me.txtTask.Text = "Scrittura dei prerequisiti per il record  " & IdRecord.ToString
      System.Windows.Forms.Application.DoEvents()
   End Sub

   Private Sub FrmImportIQA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Me.Text += "  -   Utente connesso: " & SecurityManager.Instance.CurrentUser.Username
   End Sub

    Private Sub optIQA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIQA.CheckedChanged
        If optIQA.Checked Then
            Me.Text = "Importazione incasso quote associative"
        Else
            Me.Text = "Importazione incasso quote previsionali"
        End If
    End Sub

    Private Sub schedulerIQP_AddingRecord(ByVal IdRecord As Integer) Handles schedulerIQP.AddingRecord
        Me.txtTask.Text = "Inserimento dell'item " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub


    Private Sub schedulerIQP_BeginParse() Handles schedulerIQP.BeginParse
        Me.lstActivity.Items.Add("Iniziata analisi formato file")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_BeginRetrieving() Handles schedulerIQP.BeginRetrieving
        Me.lstActivity.Items.Add("Iniziato recupero dati dal file")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_BeginWriting() Handles schedulerIQP.BeginWriting
        Me.lstActivity.Items.Add("Iniziata attività di scrittura prerequisiti")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_BeginWritingIQA() Handles schedulerIQP.BeginWritingIQA
        Me.lstActivity.Items.Add("Iniziata attività di scrittura documento")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_EndParse(ByVal NumberOfRecords As Integer) Handles schedulerIQP.EndParse
        Me.lstActivity.Items.Add("Termine analisi formato file. Trovati " & NumberOfRecords & " records")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_EndRetrieving(ByVal NumberOfRecords As Integer) Handles schedulerIQP.EndRetrieving
        Me.lstActivity.Items.Add("Termine recupero dati file.")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_EndWriting(ByVal Errors As Integer, ByVal Inserted As Integer) Handles schedulerIQP.EndWriting
        Me.lstActivity.Items.Add("Terminata attività di scrittura dei prerequisiti")
        Me.lstActivity.Items.Add("Importazione terminata con " & Errors & " errori e con " & Inserted & " items correttamente inseriti")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_EndWritingIQA() Handles schedulerIQP.EndWritingIQA
        Me.lstActivity.Items.Add("Terminata attività di scrittura documento")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_RetrievingRecord(ByVal IdRecord As Integer) Handles schedulerIQP.RetrievingRecord
        Me.txtTask.Text = "Recupero del record " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub schedulerIQP_WritingRecord(ByVal IdRecord As Integer) Handles schedulerIQP.WritingRecord
        Me.txtTask.Text = "Scrittura dei prerequisiti per il record  " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub

  
    Private Sub optIQP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIQP.CheckedChanged
        If optIQA.Checked Then
            Me.Text = "Importazione incasso quote associative"
        Else
            Me.Text = "Importazione incasso quote previsionali"
        End If
    End Sub
End Class