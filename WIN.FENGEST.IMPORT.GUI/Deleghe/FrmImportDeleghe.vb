Imports WIN.SECURITY

Public Class FrmImportDeleghe
    Private WithEvents scheduler As ImportDelegheScheduler

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

            scheduler = New ImportDelegheScheduler(txtFile.Text, txtLog.Text, chkUpdate.Checked, chkUpdateAz.Checked)
            scheduler.StartImport()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        Finally
            cmdImport.Enabled = True
        End Try




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
        Me.lstActivity.Items.Add("Iniziata attività di scrittura")
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
        Me.lstActivity.Items.Add("Terminata attività di scrittura")
        Me.lstActivity.Items.Add("Importazione terminata con " & Errors & " errori e con " & Inserted & " deleghe correttamente inserite")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_RetrievingRecord(ByVal IdRecord As Integer) Handles scheduler.RetrievingRecord
        Me.txtTask.Text = "Recupero del record " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_WritingRecord(ByVal IdRecord As Integer) Handles scheduler.WritingRecord
        Me.txtTask.Text = "Scrittura del record " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub


    Private Sub FrmImportDeleghe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text += "  -  Utente connesso: " & SecurityManager.Instance.CurrentUser.Username
    End Sub
End Class
