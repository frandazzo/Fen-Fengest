Imports System.Windows.Forms
Imports WIN.GUI.UTILITY

Public Class FrmIscritti
    Private m_IdAzienda As Int32
    Private m_IdSettore As Int32

    Private WithEvents ControllerIscritti As New WIN.APPLICATION.REPORTING.ReportIscritti
    Private WithEvents ControllerNonIscrittiCassaEdile As New WIN.APPLICATION.REPORTING.ReportLiberi
    Private WithEvents ControllerNonIscrittiEdilCassa As New WIN.APPLICATION.REPORTING.ReportLiberi

    Dim controllersettori As New ControllerSettori

    Dim listaIscritti As IList = New ArrayList
    Dim listaNonIscrittiCassaEdile As IList = New ArrayList
    Dim listaNonIscrittiEdilCassa As IList = New ArrayList

    Dim WithEvents exporter As LavoratoriAziendaExcelExporter
    Private frm1 As FrmElaborazioneInCorso
    Private m_Link As String = ""
    Private m_Id As String = ""
    Private m_TipoDoc As String = ""


    Public ReadOnly Property Id() As String
        Get
            Return m_Id
        End Get
    End Property


    Public ReadOnly Property Link() As String
        Get
            Return m_Link
        End Get

    End Property

    Public ReadOnly Property TipoDoc() As String
        Get
            Return m_TipoDoc
        End Get
    End Property


    Public Sub New(ByVal IdAzienda As Int32, ByVal IdSettore As Int32)
        InitializeComponent()
        m_IdAzienda = IdAzienda
        m_IdSettore = IdSettore
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, False)
        If IdSettore <> -1 Then
            cboSettori.Text = controllersettori.GetDescrizioneSettoreById(IdSettore)
        End If

        Dim iniGrid As New GridInitializerRptIscritti


        Dim iniGrid1 As New GridInitializerRptLiberiDTO
        ' Dim iniGrid2 As New GridLoaderRptLiberiDTO(Me.GridNonIscrittiEdilcassa)
        iniGrid.InitializeGrid(Me.GridIscritti)
        iniGrid1.InitializeGrid(Me.GridNonIscrittiCassaEdile)
        iniGrid1.InitializeGrid(Me.GridNonIscrittiEdilcassa)
    End Sub


    Private Sub SetSearchConditionsIscritti()

        ControllerIscritti.SetVerificaDelega(Me.chkVer.Checked)
        Me.ControlSelPeriodiMensili1.CalcolaDate()
        ControllerIscritti.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        ControllerIscritti.SetSettore(cboSettori.Text)
        ControllerIscritti.SetContratto("")
        ControllerIscritti.SetAzienda(m_IdAzienda)
        ControllerIscritti.SetReferente("")
        ControllerIscritti.SetQuotePrevisionali(rptIQP.Checked)


    End Sub


    Private Sub SetSearchConditionsNonIscrittiCassaEdile()

        Me.ControlSelPeriodiMensili1.CalcolaDate()
        ControllerNonIscrittiCassaEdile.SetEnte("CASSA EDILE")
        ControllerNonIscrittiCassaEdile.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        ControllerNonIscrittiCassaEdile.SetAzienda(m_IdAzienda)
        ControllerNonIscrittiCassaEdile.SetRicercaErrori(False)


    End Sub

    Private Sub SetSearchConditionsNonIscrittiEdilCassa()

        Me.ControlSelPeriodiMensili1.CalcolaDate()
        ControllerNonIscrittiEdilCassa.SetEnte("EDILCASSA")
        ControllerNonIscrittiEdilCassa.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        ControllerNonIscrittiEdilCassa.SetAzienda(m_IdAzienda)
        ControllerNonIscrittiEdilCassa.SetRicercaErrori(False)


    End Sub

    Private Sub GridIscritti_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIscritti.CellDoubleClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return
        End If
        If GridIscritti.SelectedCells.Count = 0 Then Return
        If GridIscritti.SelectedCells.Count > 1 Then Return
        Try
            Select Case GridIscritti.Columns(e.ColumnIndex).Name

                Case "Utente"
                    Navigate(GridIscritti.Rows(e.RowIndex).DataBoundItem.Id_Utente, "ViewUtente")


                Case "AziendaImpiego"
                    Navigate(GridIscritti.Rows(e.RowIndex).DataBoundItem.Id_Azienda_Impiego, "ViewAzienda")


            End Select


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub GridNonIscrittiCassaEdile_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridNonIscrittiCassaEdile.CellDoubleClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return
        End If
        If GridNonIscrittiCassaEdile.SelectedCells.Count = 0 Then Return
        If GridNonIscrittiCassaEdile.SelectedCells.Count > 1 Then Return
        Try
            Select Case GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).Name

                Case "Utente"
                    Navigate(GridNonIscrittiCassaEdile.Rows(e.RowIndex).DataBoundItem.Id_Utente, "ViewUtente")


                Case "AziendaImpiego"
                    Navigate(GridNonIscrittiCassaEdile.Rows(e.RowIndex).DataBoundItem.Id_Azienda_Impiego, "ViewAzienda")

            End Select


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridNonIscrittiEdilcassa_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridNonIscrittiEdilcassa.CellDoubleClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return
        End If
        If GridNonIscrittiEdilcassa.SelectedCells.Count = 0 Then Return
        If GridNonIscrittiEdilcassa.SelectedCells.Count > 1 Then Return
        Try
            Select Case GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).Name
                Case "Utente"
                    Navigate(GridNonIscrittiEdilcassa.Rows(e.RowIndex).DataBoundItem.Id_Utente, "ViewUtente")


                Case "AziendaImpiego"
                    Navigate(GridNonIscrittiEdilcassa.Rows(e.RowIndex).DataBoundItem.Id_Azienda_Impiego, "ViewAzienda")

            End Select


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Overloads Sub Navigate(ByVal id As String, ByVal link As String)
        m_Id = id
        m_Link = link
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub




    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            'per prima cosa cerco la lista degli iscritti

            Helper.ShowWaitBox("Attendere...", My.Resources.Waiting3)
            SetSearchConditionsIscritti()
            ControllerIscritti.SearchDTOs()
            ControllerIscritti.SortDTOItems("Utente", False)


            ''Verifica che il settore sia edile altrimenti esco
            If controllersettori.IsSettoreEdile(cboSettori.Text) Then
                SetSearchConditionsNonIscrittiCassaEdile()
                ControllerNonIscrittiCassaEdile.SearchDTOs()
                ControllerNonIscrittiCassaEdile.SortDTOItems("Utente", False)


                SetSearchConditionsNonIscrittiEdilCassa()
                ControllerNonIscrittiEdilCassa.SearchDTOs()
                ControllerNonIscrittiEdilCassa.SortDTOItems("Utente", False)
            End If

            LoadGrids()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub

    Private Sub LoadGrid(ByVal Grid As DataGridView, ByVal dataSource As IList)
        If Grid.DataSource Is Nothing Then
            Grid.DataSource = dataSource
            Return
        End If

        Grid.DataSource = Nothing
        Grid.DataSource = dataSource
    End Sub


    Private Sub LoadGrids()
        'Dim gridLoaderIs As New GridLoaderRptIscritti(Me.GridIscritti)
        'gridLoaderIs.LoadGrid(ControllerIscritti.SearchResult)

        'Dim gridLoaderCE As New GridLoaderRptLiberi(Me.GridNonIscrittiCassaEdile)
        'gridLoaderCE.LoadGrid(ControllerNonIscrittiCassaEdile.SearchResult)

        'Dim gridLoaderEC As New GridLoaderRptLiberi(Me.GridNonIscrittiEdilcassa)
        'gridLoaderEC.LoadGrid(ControllerNonIscrittiEdilCassa.SearchResult)


        LoadGrid(Me.GridIscritti, ControllerIscritti.SearchResult)
        LoadGrid(Me.GridNonIscrittiCassaEdile, ControllerNonIscrittiCassaEdile.SearchResult)
        LoadGrid(Me.GridNonIscrittiEdilcassa, ControllerNonIscrittiEdilCassa.SearchResult)
    End Sub


    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
        If controllersettori.IsSettoreEdile(cboSettori.Text) Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If
    End Sub

    Private Sub GridIscritti_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridIscritti.CellFormatting
        If GridIscritti.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If
    End Sub


    Private Sub GridIscritti_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridIscritti.DataError
        '
    End Sub

    Private Sub GridNonIscrittiCassaEdile_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridNonIscrittiCassaEdile.DataError
        '
    End Sub

    Private Sub GridNonIscrittiEdilcassa_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridNonIscrittiEdilcassa.DataError
        '
    End Sub

    Private Sub GridIscritti_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridIscritti.ColumnHeaderMouseClick
        Try
            'tolgo il glifo da tutte le colonne non selezionate
            For Each elem As DataGridViewColumn In GridIscritti.Columns
                If e.ColumnIndex <> elem.Index Then
                    elem.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Next

            'SelectToolStripImage nella colonna non c'è glifo
            If GridIscritti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridIscritti.Columns(e.ColumnIndex).Name)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo ascending
            If GridIscritti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUp(GridIscritti.Columns(e.ColumnIndex).Name)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo descending
            If GridIscritti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
                ' m_selectedColumnName = 
                OrderDown(GridIscritti.Columns(e.ColumnIndex).Name)
                Return
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub OrderUp(ByVal colonna As String)
        Try
            ControllerIscritti.SortDTOItems(colonna, False)
            ' Me.GridPosizioni.DataSource = controller.SearchResult
            Me.GridIscritti.Refresh()
            GridIscritti.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub OrderDown(ByVal colonna As String)
        Try
            ControllerIscritti.SortDTOItems(colonna, True)
            ' Me.GridPosizioni.DataSource = controller.SearchResult
            Me.GridIscritti.Refresh()
            GridIscritti.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub OrderUpLiberiCassa(ByVal colonna As String)
        Try
            ControllerNonIscrittiCassaEdile.SortDTOItems(colonna, False)
            ' Me.GridPosizioni.DataSource = controller.SearchResult
            Me.GridNonIscrittiCassaEdile.Refresh()
            GridNonIscrittiCassaEdile.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub OrderDownLiberiCassa(ByVal colonna As String)
        Try
            ControllerNonIscrittiCassaEdile.SortDTOItems(colonna, True)
            ' Me.GridPosizioni.DataSource = controller.SearchResult
            Me.GridNonIscrittiCassaEdile.Refresh()
            GridNonIscrittiCassaEdile.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub OrderUpLiberiEdilCassa(ByVal colonna As String)
        Try
            ControllerNonIscrittiEdilCassa.SortDTOItems(colonna, False)
            ' Me.GridPosizioni.DataSource = controller.SearchResult
            Me.GridNonIscrittiEdilcassa.Refresh()
            GridNonIscrittiEdilcassa.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub OrderDownLiberiEdilCassa(ByVal colonna As String)
        Try
            ControllerNonIscrittiEdilCassa.SortDTOItems(colonna, True)
            ' Me.GridPosizioni.DataSource = controller.SearchResult
            Me.GridNonIscrittiEdilcassa.Refresh()
            GridNonIscrittiEdilcassa.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridNonIscrittiCassaEdile_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridNonIscrittiCassaEdile.ColumnHeaderMouseClick
        Try
            'tolgo il glifo da tutte le colonne non selezionate
            For Each elem As DataGridViewColumn In GridNonIscrittiCassaEdile.Columns
                If e.ColumnIndex <> elem.Index Then
                    elem.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Next

            'SelectToolStripImage nella colonna non c'è glifo
            If GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUpLiberiCassa(GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).Name)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo ascending
            If GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUpLiberiCassa(GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).Name)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo descending
            If GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
                ' m_selectedColumnName = 
                OrderDownLiberiCassa(GridNonIscrittiCassaEdile.Columns(e.ColumnIndex).Name)
                Return
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridNonIscrittiEdilcassa_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridNonIscrittiEdilcassa.ColumnHeaderMouseClick
        Try
            'tolgo il glifo da tutte le colonne non selezionate
            For Each elem As DataGridViewColumn In GridNonIscrittiEdilcassa.Columns
                If e.ColumnIndex <> elem.Index Then
                    elem.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Next

            'SelectToolStripImage nella colonna non c'è glifo
            If GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderDownLiberiEdilCassa(GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).Name)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo ascending
            If GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
                OrderUpLiberiEdilCassa(GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).Name)
                Return
            End If


            'SelectToolStripImage nella colonna c'è glifo descending
            If GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
                ' m_selectedColumnName = 
                OrderDownLiberiEdilCassa(GridNonIscrittiEdilcassa.Columns(e.ColumnIndex).Name)
                Return
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            exporter = New LavoratoriAziendaExcelExporter(ControllerIscritti.SearchResult, ControllerNonIscrittiCassaEdile.SearchResult, ControllerNonIscrittiEdilCassa.SearchResult)



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
End Class