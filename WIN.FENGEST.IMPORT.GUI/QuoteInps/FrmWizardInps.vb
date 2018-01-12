Imports WIN.GUI.APPLICATION.PRESENTATION
Imports System.Windows.Forms
Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES.FenealgestImportExport
Imports System.Text
Imports System.IO

Public Class FrmWizardInps

    Private m_selectedFile As String = ""
    Private m_selectedPath As String = ""
    Private m_selectedPathComuni As String = ""
    Private m_data As IList
    Private m_dataStep2 As IList
    Private m_dataResult As IList
    Private m_dataExceptionsResult As IList

    Dim WithEvents merger As New InpsTraceInformationMerger()

    Private m_newDataSelected As Boolean
    Private m_newDataSelectedStep2 As Boolean
    Dim importedAll As Boolean


    Protected m_CorrectedAnalyzedFiles As New List(Of String)
    Protected m_UncorrectedAnalyzedFiles As New List(Of String)


    Protected m_CorrectedAnalyzedFilesStep2 As New List(Of String)
    Protected m_UncorrectedAnalyzedFilesStep2 As New List(Of String)


    Private Sub optFile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optFile.CheckedChanged
        If optFile.Checked Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False

        Else
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        End If
        m_selectedFile = ""
        m_selectedPath = ""
        lblPercorso.Text = "nessun file selezionato"
        lblPath.Text = "nessun percorso selezionato"
    End Sub

    Private Sub optPath_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPath.CheckedChanged
        If optFile.Checked Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        Else
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        End If
        m_selectedFile = ""
        m_selectedPath = ""
        lblPercorso.Text = "nessun file selezionato"
        lblPath.Text = "nessun percorso selezionato"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_selectedFile = Me.OpenFileDialog1.FileName
            m_selectedPath = ""
            m_newDataSelected = True
            lblPercorso.Text = m_selectedFile
            lblPath.Text = "nessun percorso selezionato"
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_selectedPath = Me.FolderBrowserDialog1.SelectedPath
            m_selectedFile = ""
            m_newDataSelected = True
            lblPath.Text = m_selectedPath
            lblPercorso.Text = "nessun file selezionato"
        End If

    End Sub

    Private Sub cmdModello_Click(sender As System.Object, e As System.EventArgs) Handles cmdModello.Click
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_selectedPathComuni = Me.FolderBrowserDialog1.SelectedPath
            m_newDataSelectedStep2 = True
            lblPathComuni.Text = m_selectedPath
        End If

    End Sub



    Private Sub ListPage_CloseFromNext(sender As Object, e As Wizard.PageEventArgs) Handles ListPage.CloseFromNext

        Try

      

            If String.IsNullOrEmpty(m_selectedFile) And String.IsNullOrEmpty(m_selectedPath) Then
                MsgBox("Selezionare un file o un percorso adeguato", MsgBoxStyle.Critical, "Errore")
                e.Page = ListPage
                Return
            End If

            If Not m_newDataSelected Then
                Return
            End If



            'qui recupero tutti i dati dal file o dal path
            If String.IsNullOrEmpty(m_selectedFile) Then ' ho selezionato un path
                'creo il dataretriever multiplo
                Dim ret As New WIN.APPLICATION.IMPORT_EXPORT_SERVICES.MultipleFileDataRetriever(m_selectedPath, APPLICATION.IMPORT_EXPORT_SERVICES.DataInfoRetrieverFactory.RetrieverType.Inps)
                Dim frm As New FrmNotify(ret, False)
                frm.ShowDialog()
                m_data = frm.Data
                frm.Dispose()
                m_newDataSelected = False
                m_CorrectedAnalyzedFiles = ret.CorrectedAnalyzedFiles
                m_UncorrectedAnalyzedFiles = ret.UncorrectedAnalyzedFiles
            Else
                Dim ret As New WIN.APPLICATION.IMPORT_EXPORT_SERVICES.DataRetrieverIQI(m_selectedFile)
                Dim frm As New FrmNotify(ret)
                frm.ShowDialog()
                m_data = frm.Data
                frm.Dispose()
                m_newDataSelected = False

                m_CorrectedAnalyzedFiles = New List(Of String)
                m_UncorrectedAnalyzedFiles = New List(Of String)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try

    End Sub

    Private Sub CreateResultData()
        Dim inpsTraceMain As New InpsTrace
        Dim inpsTraceSub As New InpsTrace
        inpsTraceMain.FromDetailsHashList(m_data)

        If Not m_dataStep2 Is Nothing Then
            inpsTraceSub.FromDetailsHashList(m_dataStep2)
        Else
            inpsTraceSub.FromDetailsHashList(New ArrayList)
        End If

        'a questo punto posso generare il risultato dell'incorcio
        merger = New InpsTraceInformationMerger()
        Dim inpsTrace As InpsTrace = merger.CreateTrace(inpsTraceMain, inpsTraceSub)

        Dim exceptionResult As InpsTrace = merger.CreateTraceWithExceptions(inpsTraceMain, inpsTraceSub)

        m_dataResult = inpsTrace.ToDetailsHashArrayList
        m_dataExceptionsResult = exceptionResult.ToDetailsHashArrayList
    End Sub
    Private Sub ModelPage_CloseFromNext(sender As System.Object, e As Wizard.PageEventArgs) Handles ModelPage.CloseFromNext
        If Not m_newDataSelectedStep2 Then
            Return
        End If

        Try
            'qui recupero tutti i dati dal file o dal path
            If Not String.IsNullOrEmpty(m_selectedPathComuni) Then ' ho selezionato un path
                'creo il dataretriever multiplo
                Dim ret As New WIN.APPLICATION.IMPORT_EXPORT_SERVICES.MultipleFileDataRetriever(m_selectedPathComuni, APPLICATION.IMPORT_EXPORT_SERVICES.DataInfoRetrieverFactory.RetrieverType.IQI)
                Dim frm As New FrmNotify(ret, True)
                frm.ShowDialog()
                m_dataStep2 = frm.Data
                frm.Dispose()
                m_newDataSelectedStep2 = False
                m_CorrectedAnalyzedFilesStep2 = ret.CorrectedAnalyzedFiles
                m_UncorrectedAnalyzedFilesStep2 = ret.UncorrectedAnalyzedFiles
            Else
                m_CorrectedAnalyzedFilesStep2 = New List(Of String)
                m_UncorrectedAnalyzedFilesStep2 = New List(Of String)
            End If

            'eseguo  il merge delle informazioni e le rendo disponibile per l'eventuale visualizzazione
            '....TODO domani
            'per prima cosa trasformo il primo dato in una inpsTrace

            CreateResultData()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try

       

    End Sub

    Private Sub ComunicationPage_CloseFromNext(sender As System.Object, e As Wizard.PageEventArgs) Handles ComunicationPage.CloseFromNext
        'in questo passaggio segno il flag se importare o no i dati

        Try

            If chkSave.Checked Then
                Dim trace As New InpsTrace

                If m_dataResult Is Nothing Then
                    m_dataResult = m_data
                End If
                Dim frm As New FrmNotify(New ImportIQIScheduler, m_dataResult)
                frm.ShowDialog()

                frm.Dispose()

                importedAll = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
        '
    End Sub

    Private Sub EndPage_CloseFromNext(sender As System.Object, e As Wizard.PageEventArgs) Handles EndPage.CloseFromNext
        'qui avvio l'importazione dei dati.....


        Try
            Wizard1.CancelEnabled = False
            Wizard1.NextEnabled = False
            Wizard1.BackEnabled = False
            MessageBox.Show("Procedura terminata")
            Wizard1.CancelEnabled = True
            Wizard1.NextEnabled = True

            If importedAll Then
                Wizard1.BackEnabled = True
            Else
                Wizard1.BackEnabled = False
            End If





        Catch ex As Exception
            Wizard1.CancelEnabled = True
            Wizard1.NextEnabled = True
            If importedAll Then
                Wizard1.BackEnabled = True
            Else
                Wizard1.BackEnabled = False
            End If


            ErrorHandler.ShowError(ex)

            e.Page = EndPage
        End Try

    End Sub

    Private Sub Wizard1_CloseFromCancel(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CloseFromCancel
        If MessageBox.Show("Sicuro di voler uscire dalla procedura guidata?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lblPathComuni.Text = ""
        m_selectedPathComuni = ""
        m_dataStep2 = Nothing
        m_newDataSelectedStep2 = False

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Try
            Dim inpsTraceMain As New InpsTrace

            If m_dataResult Is Nothing Then
                m_dataResult = m_data
            End If

            inpsTraceMain.FromDetailsHashList(m_dataResult)

            Dim frm As New FrmViewTemplate(inpsTraceMain.InpsTraceDetails)
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
       

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Try
            Dim inpsTraceMain As New InpsTrace

            inpsTraceMain.FromDetailsHashList(m_dataExceptionsResult)

            Dim frm As New FrmViewTemplate(inpsTraceMain.InpsTraceDetails)
            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        If m_CorrectedAnalyzedFiles.Count = 0 And m_UncorrectedAnalyzedFiles.Count = 0 Then
            Return

        End If

        Dim fname As String = Path.GetTempPath + "/aaa.txt"
        Dim builder As New StringBuilder

        builder.AppendLine("**************************")
        builder.AppendLine("File analizzati con successo:")
        If m_CorrectedAnalyzedFiles.Count = 0 Then
            builder.AppendLine("Nessun file è stato analizzato!")
        Else
            builder.AppendLine(String.Format("Sono stati analizzati i seguenti {0} files:", m_CorrectedAnalyzedFiles.Count))
            For Each elem As String In m_CorrectedAnalyzedFiles
                builder.AppendLine("-- " + elem)
            Next
        End If
        builder.AppendLine("**************************")
        builder.AppendLine("**************************")
        builder.AppendLine("File non analizzati per problemi nel formato:")
        If m_UncorrectedAnalyzedFiles.Count = 0 Then
            builder.AppendLine("Nessun file ha generato problemi!")
        Else
            builder.AppendLine(String.Format("Sono stati analizzati con errori i seguenti {0} files:", m_UncorrectedAnalyzedFiles.Count))
            For Each elem As String In m_UncorrectedAnalyzedFiles
                builder.AppendLine("-- " + elem)
            Next
        End If

        File.Delete(fname)
        File.AppendAllText(fname, builder.ToString)
        Process.Start(fname)

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        If m_CorrectedAnalyzedFilesStep2.Count = 0 And m_UncorrectedAnalyzedFilesStep2.Count = 0 Then
            Return

        End If

        Dim fname As String = Path.GetTempPath + "/aaa.txt"
        Dim builder As New StringBuilder

        builder.AppendLine("**************************")
        builder.AppendLine("File analizzati con successo:")
        If m_CorrectedAnalyzedFilesStep2.Count = 0 Then
            builder.AppendLine("Nessun file è stato analizzato!")
        Else
            builder.AppendLine(String.Format("Sono stati analizzati i seguenti {0} files:", m_CorrectedAnalyzedFilesStep2.Count))
            For Each elem As String In m_CorrectedAnalyzedFilesStep2
                builder.AppendLine("-- " + elem)
            Next
        End If
        builder.AppendLine("**************************")
        builder.AppendLine("**************************")
        builder.AppendLine("File non analizzati per problemi nel formato:")
        If m_UncorrectedAnalyzedFilesStep2.Count = 0 Then
            builder.AppendLine("Nessun file ha generato problemi!")
        Else
            builder.AppendLine(String.Format("Sono stati analizzati con errori i seguenti {0} files:", m_UncorrectedAnalyzedFilesStep2.Count))
            For Each elem As String In m_UncorrectedAnalyzedFilesStep2
                builder.AppendLine("-- " + elem)
            Next
        End If

        File.Delete(fname)
        File.AppendAllText(fname, builder.ToString)
        Process.Start(fname)
    End Sub

    Private Sub merger_CountProgress(totalCycles As Integer, cycles As Integer) Handles merger.CountProgress
        lblAnal.Text = String.Format("Incrocio dati in corso. Alisi record {0} di {1}", cycles, totalCycles)
        System.Windows.Forms.Application.DoEvents()
    End Sub
End Class