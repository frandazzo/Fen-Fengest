Imports System.Windows.Forms

Public Class FrmConfrontoListeLavoro
    Dim controller As New ControllerListaUtenti
    Private m_Confornto As ConfrontoListeUtenti
    Private WithEvents exporter As ExcelExporterConfronto
    Private frm1 As FrmElaborazioneInCorso
    Private Controller1 = New WIN.APPLICATION.REPORTING.ReportIncassiQuote

    Public Sub New(ByVal confronto As ConfrontoListeUtenti)

        InitializeComponent()

        m_Confornto = confronto

        cmbAnno.Text = DateTime.Now.Year



    End Sub


    Private Sub LoadConfronto()

        GroupBox1.Title = m_Confornto.DescrizioneLista1 & " - Numero elementi: " & m_Confornto.ListaLavoro1.ListaUtenti.Count

        GroupBox2.Title = m_Confornto.DescrizioneLista2 & " - Numero elementi: " & m_Confornto.ListaLavoro2.ListaUtenti.Count

        GroupBox3.Title = m_Confornto.DescrizioneElementiComuni & " - Numero elementi: " & m_Confornto.ListaConfronto.ListaUtenti.Count

        Label1.Text += " " & m_Confornto.ElementiTotali.ToString


        BindGrids()



    End Sub



    Private Sub BindGrids()

        Dim loader1 As New GridLoaderListaLavoro(GridLista1, False)
        loader1.LoadGrid(m_Confornto.ListaLavoro1.ListaUtenti)


        Dim loader2 As New GridLoaderListaLavoro(GridLista2, False)
        loader2.LoadGrid(m_Confornto.ListaLavoro2.ListaUtenti)


        Dim loader3 As New GridLoaderListaLavoro(GridLista3, False)
        loader3.LoadGrid(m_Confornto.ListaConfronto.ListaUtenti)



    End Sub

  

    Private Sub FrmConfrontoListeLavoro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LoadConfronto()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub GridLista1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridLista1.CellFormatting
        If GridLista1.Columns(e.ColumnIndex).Name.Equals("Comunicazione") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Cellulare1 & " - " & e.Value.Cellulare2
            End If
        End If

        If GridLista1.Columns(e.ColumnIndex).Name.Equals("Residenza") Then
            If Not e.Value Is Nothing Then
                'GridUtenti.Rows(e.RowIndex).Cells("Indirizzo").Value = e.Value.Via.ToString & " " & e.Value.Cap
                e.Value = e.Value.Comune.ToString

            End If
        End If
    End Sub

    Private Sub GridLista2_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridLista2.CellFormatting
        If GridLista2.Columns(e.ColumnIndex).Name.Equals("Comunicazione") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Cellulare1 & " - " & e.Value.Cellulare2
            End If
        End If

        If GridLista2.Columns(e.ColumnIndex).Name.Equals("Residenza") Then
            If Not e.Value Is Nothing Then
                'GridUtenti.Rows(e.RowIndex).Cells("Indirizzo").Value = e.Value.Via.ToString & " " & e.Value.Cap
                e.Value = e.Value.Comune.ToString

            End If
        End If
    End Sub

    Private Sub GridLista3_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridLista3.CellFormatting
        If GridLista3.Columns(e.ColumnIndex).Name.Equals("Comunicazione") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Cellulare1 & " - " & e.Value.Cellulare2
            End If
        End If

        If GridLista3.Columns(e.ColumnIndex).Name.Equals("Residenza") Then
            If Not e.Value Is Nothing Then
                'GridUtenti.Rows(e.RowIndex).Cells("Indirizzo").Value = e.Value.Via.ToString & " " & e.Value.Cap
                e.Value = e.Value.Comune.ToString

            End If
        End If
    End Sub


    Private Sub GridLista_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridLista1.ColumnHeaderMouseClick

        Try


            'tolgo il glifo da tutte le colonne non selezionate
            For Each elem As DataGridViewColumn In GridLista1.Columns
                If e.ColumnIndex <> elem.Index Then
                    elem.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Next

            'SelectToolStripImage nella colonna non c'è glifo
            If GridLista1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridLista1.Columns(e.ColumnIndex).Name, GridLista1, m_Confornto.ListaLavoro1)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo ascending
            If GridLista1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridLista1.Columns(e.ColumnIndex).Name, GridLista1, m_Confornto.ListaLavoro1)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo descending
            If GridLista1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
                ' m_selectedColumnName = 
                OrderDown(GridLista1.Columns(e.ColumnIndex).Name, GridLista1, m_Confornto.ListaLavoro1)
                Return
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub OrderUp(ByVal colonna As String, ByVal grid As DataGridView, ByVal lista As ListaLavoroUtenti)
        Try
            controller.SetCurrent(lista)
            controller.SortItems(colonna)
            'grid.DataSource = lista
            grid.Refresh()
            grid.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub OrderDown(ByVal colonna As String, ByVal grid As DataGridView, ByVal lista As ListaLavoroUtenti)
        Try
            controller.SetCurrent(lista)
            controller.SortItems(colonna, True)
            'grid.DataSource = lista
          
            grid.Refresh()
            grid.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub







    Private Sub GridLista2_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridLista2.ColumnHeaderMouseClick
        Try


            'tolgo il glifo da tutte le colonne non selezionate
            For Each elem As DataGridViewColumn In GridLista2.Columns
                If e.ColumnIndex <> elem.Index Then
                    elem.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Next

            'SelectToolStripImage nella colonna non c'è glifo
            If GridLista2.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridLista2.Columns(e.ColumnIndex).Name, GridLista2, m_Confornto.ListaLavoro2)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo ascending
            If GridLista2.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridLista2.Columns(e.ColumnIndex).Name, GridLista2, m_Confornto.ListaLavoro2)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo descending
            If GridLista2.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
                ' m_selectedColumnName = 
                OrderDown(GridLista2.Columns(e.ColumnIndex).Name, GridLista2, m_Confornto.ListaLavoro2)
                Return
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridLista3_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridLista3.ColumnHeaderMouseClick
        Try


            'tolgo il glifo da tutte le colonne non selezionate
            For Each elem As DataGridViewColumn In GridLista3.Columns
                If e.ColumnIndex <> elem.Index Then
                    elem.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Next

            'SelectToolStripImage nella colonna non c'è glifo
            If GridLista3.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridLista3.Columns(e.ColumnIndex).Name, GridLista3, m_Confornto.ListaConfronto)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo ascending
            If GridLista3.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridLista3.Columns(e.ColumnIndex).Name, GridLista3, m_Confornto.ListaConfronto)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo descending
            If GridLista3.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
                ' m_selectedColumnName = 
                OrderDown(GridLista3.Columns(e.ColumnIndex).Name, GridLista3, m_Confornto.ListaConfronto)
                Return
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CalculateAziende(anno As String, executeCalulation As Boolean)
        If Not executeCalulation Then
            Return
        End If

        Controller1.IsIQAIncluded(True)
        Controller1.IsIQIIncluded(False)
        Controller1.IsIQVIncluded(False)
        Controller1.IsIQPIncluded(False)

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", False)
        parameterMap.Add("IntervalloDocumento", False)
        parameterMap.Add("ListaSoggetti", False)

        parameterMap.Add("CompetenzaQuote", True)

        Controller1.SetCompetenzaIncassiQuote(New DateTime(Convert.ToInt32(anno) - 1, 10, 1), New DateTime(Convert.ToInt32(anno), 9, 30))


        Controller1.SetSettore("EDILE")

        Controller1.SetNewSerchConditions(parameterMap)


        Dim SearchList As IList = Controller1.Search

        Dim h As New Hashtable
        'ottenuta la lista delle quote metto in una hash table per id lavoratore
        For Each elem As Quota In SearchList
            If Not h.ContainsKey(elem.IdUtente) Then
                If Not String.IsNullOrEmpty(elem.AziendaImpiego) Then
                    h.Add(elem.IdUtente, elem.AziendaImpiego)
                End If
            End If
        Next

        'adesso per ogni utente della lista inserisco nelle note lazienda se cè
        For Each elem As Utente In m_Confornto.ListaLavoro1.ListaUtenti
            If h.ContainsKey(elem.Id.ToString) Then
                elem.Note = h(elem.Id.ToString)
            Else
                elem.Note = ""
            End If
        Next
        For Each elem As Utente In m_Confornto.ListaLavoro2.ListaUtenti
            If h.ContainsKey(elem.Id.ToString) Then
                elem.Note = h(elem.Id.ToString)
            Else
                elem.Note = ""
            End If
        Next

        For Each elem As Utente In m_Confornto.ListaConfronto.ListaUtenti
            If h.ContainsKey(elem.Id.ToString) Then
                elem.Note = h(elem.Id.ToString)
            Else
                elem.Note = ""
            End If
        Next


    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            CalculateAziende(cmbAnno.Text, CheckBox3.Checked)

            exporter = m_Confornto.GetExporter()

            frm1 = New FrmElaborazioneInCorso

            frm1.EnableCancel(True)

            frm1.TopLevel = True


            frm1.Show()

            exporter.Export()


            frm1.Dispose()

            'salvo il file
            Dim savePath As String = ""
            SaveFileDialog1.Title = "Inserire il percorso per salvare il file"


            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                savePath = SaveFileDialog1.FileName
                If savePath.EndsWith("\") Then
                    savePath = savePath & "Confronto_" & Format(DateTime.Now, "dd-MM-yyyy_hh-mm-ss")
                End If
                savePath = savePath & ".xls"
                exporter.SaveAs(savePath)
            End If

            'chiudo i processi excel
            exporter.CloseExporter()


            'se ho salvato il file lo apro
            If My.Computer.FileSystem.FileExists(savePath) Then
                Process.Start(savePath)
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub exporter_BeginExport() Handles exporter.BeginExport
        frm1.SetPercentageValue(0)
        frm1.SetActivity("Inizio esportazione su excel")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub exporter_BeginExportLista1() Handles exporter.BeginExportLista1
        frm1.SetPercentageValue(0)
        frm1.SetActivity("Inizio esportazione lista iniziale")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub exporter_BeginExportLista2() Handles exporter.BeginExportLista2
        frm1.SetPercentageValue(0)
        frm1.SetActivity("Inizio esportazione lista di confronto")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub exporter_BeginExportListaComune() Handles exporter.BeginExportListaComune
        frm1.SetPercentageValue(0)
        frm1.SetActivity("Inizio esportazione lista elementi comuni")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub exporter_EndExport() Handles exporter.EndExport
        MessageBox.Show("Esportazione completa!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exporter_ExportingRow(ByVal rowPercentage As Integer, ByRef cancel As Boolean) Handles exporter.ExportingRow
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



    Private Sub cmdSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave1.Click
        Try

            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.SetCurrent(m_Confornto.ListaLavoro1)
                controllerListe.Descrizione = descr


                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave2.Click
        Try

            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.SetCurrent(m_Confornto.ListaLavoro2)
                controllerListe.Descrizione = descr


                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdSave3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave3.Click
        Try

            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.SetCurrent(m_Confornto.ListaConfronto)
                controllerListe.Descrizione = descr


                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class