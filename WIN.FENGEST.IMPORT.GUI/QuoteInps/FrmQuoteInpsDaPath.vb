﻿Imports System.IO

Public Class FrmQuoteInpsDaPath
    Private WithEvents scheduler As ImportIQIInpsScheduler
    Private numberoOfFilesFound As Int32

    Private Sub cmdImport_Click(sender As System.Object, e As System.EventArgs) Handles cmdImport.Click
        Try
            cmdImport.Enabled = False
            If txtLog.Text = "" Then
                MsgBox("Inserire un percorso per il file di log", MsgBoxStyle.Information)
                Exit Sub
            End If
            If txtFile.Text = "" Then
                MsgBox("Inserire un  percorso di importazione", MsgBoxStyle.Information)
                Exit Sub
            End If





            scheduler = New ImportIQIInpsScheduler(txtFile.Text, txtLog.Text)

            scheduler.StartImport()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        Finally
            cmdImport.Enabled = True
        End Try


    End Sub

    Private Sub cmdFile_Click(sender As System.Object, e As System.EventArgs) Handles cmdFile.Click
        Me.FolderBrowserDialog2.ShowDialog()
        txtFile.Text = Me.FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub cmdLog_Click(sender As System.Object, e As System.EventArgs) Handles cmdLog.Click
        Me.FolderBrowserDialog1.ShowDialog()
        txtLog.Text = Me.FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub FrmQuoteInpsDaPath_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text += "  -   Utente connesso: " & SecurityManager.Instance.CurrentUser.Username
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

    Private Sub scheduler_BeginParseFile(filename As String, number As Integer) Handles scheduler.BeginParseFile

        Dim filei As New FileInfo(filename)


        Me.lstActivity.Items.Add("Importazione file " + number.ToString + " di " + numberoOfFilesFound.ToString + "; file: " + filei.Name)
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginParsePath() Handles scheduler.BeginParsePath
        Me.lstActivity.Items.Add("Iniziata analisi del percorso indicato")
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
        Me.lstActivity.Items.Add("Sono stati trovati  " & NumberOfDocuments.ToString & " documenti")
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

    Private Sub scheduler_EndParseFile(filename As String, exception As System.Exception) Handles scheduler.EndParseFile
        Dim filei As New FileInfo(filename)

        If (exception Is Nothing) Then
            Me.lstActivity.Items.Add("Importazione terminata con successo del file " + filei.Name)

        Else
            Me.lstActivity.Items.Add("Errore nell'importazione del file " + filei.Name)
            Me.lstActivity.Items.Add("Errore: " + exception.Message)
        End If
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndParsePath(NumberOfFilesFound As Integer) Handles scheduler.EndParsePath
        numberoOfFilesFound = NumberOfFilesFound
        Me.lstActivity.Items.Add("Sono stati trovati " & NumberOfFilesFound & " file da importare")
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
End Class