Imports System.Windows.Forms

Public Class FrmExportLista

    Private m_exportAll As Boolean = True
    Private m_lista As ListaLavoroUtenti
    Private WithEvents m_excelExporter As ExcelExporterListaLavoro

    Private frm1 As FrmElaborazioneInCorso
    Private m_close As Boolean = False


    Public Sub New(ByVal Lista As ListaLavoroUtenti, ByVal close As Boolean)

        InitializeComponent()


        If Lista Is Nothing Then
            Throw New Exception("Lista lavoro nulla!")
        End If

        m_close = close
        m_lista = Lista

    End Sub



    Public Sub New(ByVal Lista As ListaLavoroUtenti)

        InitializeComponent()


        If Lista Is Nothing Then
            Throw New Exception("Lista lavoro nulla!")
        End If

        m_lista = Lista

    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            cmdOk.Enabled = False
            cmdAnnulla.Enabled = False


            If m_exportAll Then
                ExportOnExcel()
                If m_close Then
                    Me.Close()
                End If
                Return
            End If

            If optLabelExcel.Checked Then
                ExportOnExcel()
            Else
                ExportOnWord()
            End If
            If m_close Then
                Me.Close()
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            cmdOk.Enabled = True
            cmdAnnulla.Enabled = True
        End Try
    End Sub

    Private Sub optExportAsLabel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExportAsLabel.CheckedChanged
        If optExportAsLabel.Checked Then
            GroupBox2.Enabled = True
            m_exportAll = False
        Else
            GroupBox2.Enabled = False
            m_exportAll = True
        End If
    End Sub


    Private Sub ExportOnExcel()
        m_excelExporter = m_lista.GetExcelExporter(chkOnlyAddressOK.Checked, optExportAsLabel.Checked)

        frm1 = New FrmElaborazioneInCorso

        frm1.EnableCancel(True)

        frm1.TopLevel = True



        frm1.Show()

        m_excelExporter.Export()


        frm1.Dispose()

        'salvo il file
        Dim savePath As String = ""
        SaveFileDialog1.Title = "Inserire il percorso per salvare il file"


        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            savePath = SaveFileDialog1.FileName
            If savePath.EndsWith("\") Then
                savePath = savePath & "Lista_" & Format(DateTime.Now, "dd-MM-yyyy_hh-mm-ss")
            End If
            savePath = savePath & ".xls"
            m_excelExporter.SaveAs(savePath)
        End If

        'chiudo i processi excel
        m_excelExporter.CloseExporter()


        'se ho salvato il file lo apro
        If My.Computer.FileSystem.FileExists(savePath) Then
            Process.Start(savePath)
        End If






    End Sub

    Private Sub ExportOnWord()
        
        Try

            Dim frm As New FrmExportEtichette(m_lista.ToMetadataForEtichette)

            frm.ShowDialog()

            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub




    Private Sub m_excelExporter_BeginExportLista() Handles m_excelExporter.BeginExportLista
        frm1.SetPercentageValue(0)
        frm1.SetActivity("Inizio esportazione su excel")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_excelExporter_EndExportLista() Handles m_excelExporter.EndExportLista
        MessageBox.Show("Esportazione completa!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub m_excelExporter_ExportingRow(ByVal rowPercentage As Integer, ByRef cancel As Boolean) Handles m_excelExporter.ExportingRow
        If frm1.Annulla Then
            If MessageBox.Show("Sicuro di voler annullare l'esportazione dei dati?", "Messaggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Operazione annullata dall'utente", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cancel = True
            Else
                frm1.Annulla = False
            End If
        End If

        frm1.SetPercentageValue(rowPercentage)
        frm1.SetActivity("Percentuale di esportazione: " & rowPercentage.ToString)
        Windows.Forms.Application.DoEvents()
    End Sub

   
End Class