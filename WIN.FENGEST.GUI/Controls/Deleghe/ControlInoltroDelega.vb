Imports WIN.SECURITY.Exceptions
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting




Public Class ControlInoltroDelega
    Private Controller As New WIN.APPLICATION.REPORTING.ReportDeleghe
    Private m_selectedColumnName As String = ""
    Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
    Dim SearchList As IList
    Public Sub New()
        InitializeComponent()

        Me.m_IdShowedObject = 0
        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri inoltro massivo deleghe"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri inoltro massivo deleghe "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri inoltro massivo deleghe ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri inoltro massivo deleghe"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Public Sub SetSearchConditions()

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
        parameterMap.Add("IntervalloDocumento", chkDoc.Checked)

        parameterMap.Add("IntervalloInoltro", False)
        parameterMap.Add("IntervalloAccettazione", False)
        parameterMap.Add("IntervalloAttivazione", False)
        parameterMap.Add("IntervalloAnnullamento", False)
        parameterMap.Add("IntervalloRevoca", False)
        parameterMap.Add("ListaAziende", False)

        Controller.SetDataDocumentoRange(dtpDocDa.Value.Date, dtpDocA.Value.Date)
        Controller.SetDataRegistrazioneRange(dtpRegDa.Value.Date, dtpRegA.Value.Date)

        Controller.SetDelegheSottoscritte(True)
        Controller.SetDelegheInoltrate(False)
        Controller.SetDelegheAccettate(False)
        Controller.SetDelegheAttivate(False)
        Controller.SetDelegheAnnullate(False)
        Controller.SetDelegheRevocate(False)

        Controller.SetSettore("EDILE")
        Controller.SetEnte(cboEnti.Text)

        Controller.SetNewSerchConditions(parameterMap)
    End Sub



    Private Sub chkReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReg.CheckedChanged
        If chkReg.Checked = True Then
            dtpRegDa.Enabled = True
            dtpRegA.Enabled = True
        Else
            dtpRegDa.Enabled = False
            dtpRegA.Enabled = False
        End If
    End Sub

    Private Sub chkDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
        If chkDoc.Checked = True Then
            dtpDocDa.Enabled = True
            dtpDocA.Enabled = True
        Else
            dtpDocDa.Enabled = False
            dtpDocA.Enabled = False
        End If
    End Sub










#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()

        chkReg.Checked = False
        chkDoc.Checked = False

        dtpRegDa.Enabled = False
        dtpRegA.Enabled = False
        dtpDocDa.Enabled = False
        dtpDocA.Enabled = False

        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)

    End Sub



#End Region



    Private Sub CmdRpt_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdRpt.DoClik
        Try
            SetGUIPreProcessReport()


            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop


            SetGUIPostProcessReport()
            System.Windows.Forms.Application.DoEvents()
            If SearchList.Count > 0 Then
                lblNum.Text = SearchList.Count
                'Dim gridLoader As New GridLoaderElaborazioniMassiveDeleghe(Me.GridPosizioni)
                'gridLoader.LoadGrid(SearchList)
                GridPosizioni.DataSource = SearchList
            Else
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
                GridPosizioni.DataSource = Nothing
            End If

        Catch ex As Exception
            SetGUIPostProcessReport()
            ErrorHandler.ShowError(ex)
        End Try

    End Sub


    Private Sub FillSearchList()

        SearchList = Controller.Search
    End Sub

    Private Sub NavigateToReport()
        Dim map As New Hashtable
        map.Add("ReportingService", Controller)
        Me.NavigateTo("ViewReport", map)
    End Sub
    Private Sub SetGUIPreProcessReport()
        MasterControl.Instance.ParentForm.Text = "Attendere l'elaborazione del report "
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere l'elaborazione del report "
        Me.lblCurrentFunction.Text = UCase("Attendere   l'elaborazione   del   report ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
    End Sub

    Private Sub SetGUIPostProcessReport()
        Me.Cursor = Windows.Forms.Cursors.Default
        MasterControl.Instance.ParentForm.Text = "Selezione criteri inoltro massivo deleghe"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri inoltro massivo deleghe "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri inoltro massivo deleghe ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub




    Private Sub cmdSelectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdSelectAll.DoClik
        For Each elem As DelegadTO In Controller.SearchResult
            elem.Selected = True
        Next

        RefreshGrid()

    End Sub

    Private Sub RefreshGrid()
        GridPosizioni.DataSource = Nothing
        GridPosizioni.DataSource = Controller.SearchResult
    End Sub

    Private Sub CmdDeselectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdDeselectAll.DoClik
        For Each elem As Object In Controller.SearchResult
            elem.Selected = False
        Next

        RefreshGrid()

    End Sub




    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As DelegadTO = DirectCast(GridView1.GetRow(handle), DelegadTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function


    Private Sub CmdInoltra_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdInoltra.DoClik
        If Controller.SearchResult.Count = 0 Then
            Return
        End If
        Try

            Dim i As Int32 = 0
            For Each elem As DelegadTO In GetVisuibleRecords()
                If elem.Selected Then
                    i = i + 1
                End If
            Next

            If i = 0 Then
                MessageBox.Show("Selezionare almeno un elemento", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If



            Dim frm As New FrmTransioniDeleghe
            Dim controllerDeleghe As New ADMINISTRATION.ControllerDeleghe
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim path As String = frm.PathOutput
                If My.Computer.FileSystem.DirectoryExists(path) Then

                    WIN.GUI.UTILITY.Helper.ShowWaitBox("Elaborazione in corso...", My.Resources.Waiting3)
                    controllerDeleghe.InoltraDeleghe(frm.DataTransazione, GetVisuibleRecords)

                    If controllerDeleghe.ErrorMessage <> "" Then
                        My.Computer.FileSystem.WriteAllText(path & "\LogInoltroDeleghe.txt", controllerDeleghe.ErrorMessage, False)
                        MsgBox("Elaborazione terminata con errori! Guardare il file di log per ulteriori dettagli", MsgBoxStyle.Exclamation, "Informazione")
                    End If
                Else
                    Throw New Exception("Percorso di output inesistente")
                End If
            Else
                Return
            End If
            frm.Dispose()
            If controllerDeleghe.ErrorMessage = "" Then
                MsgBox("Elaborazione terminata con successo!", MsgBoxStyle.Information, "Informazione")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)

        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try
    End Sub


    'Private Sub GridPosizioni_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    '    If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
    '        Return
    '    End If
    '    If GridPosizioni.SelectedCells.Count = 0 Then Return
    '    If GridPosizioni.SelectedCells.Count > 1 Then Return
    '    Try
    '        Select Case GridPosizioni.Columns(e.ColumnIndex).Name

    '            Case "Utente"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdUtente, "ViewUtente")
    '            Case "EnteInoltro"
    '                If Controller.NomeSettore = "EDILE" Then
    '                    Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdEnteInoltro, "ViewEnte")
    '                Else
    '                    Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdEnteInoltro, "ViewAzienda")
    '                End If
    '            Case "Id"
    '                Dim idDelega As Int32 = DirectCast(GridPosizioni.SelectedCells(0).Value, Int32)
    '                Dim StatusDelega As String = GridPosizioni.Rows(e.RowIndex).Cells("StatoDelega").Value
    '                Dim idUtente As Int32 = Convert.ToInt32(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdUtente)
    '                Me.Navigate(idDelega, StatusDelega, idUtente, "ViewDelega")
    '        End Select



    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

    End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Status As String, ByVal IdUtente As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        ParameterList.Add("Status", Status)
        ParameterList.Add("IdUtente", IdUtente)
        NavigateTo(Link, ParameterList)

    End Sub

    'Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
    '    If Me.GridPosizioni.Columns(e.ColumnIndex).Name = "Selected" Then
    '        If e.Value IsNot Nothing Then
    '            Dim c As DataGridViewCheckBoxCell = GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '            c.Value = Me.GridPosizioni.Rows(e.RowIndex).DataBoundItem.Selected
    '        End If
    '    End If


    'End Sub

    'Private Sub GridPosizioni_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If Me.GridPosizioni.Columns(e.ColumnIndex).Name = "Selected" Then
    '        If e.RowIndex <> -1 Then
    '            'SetCurrentCellValue(e);
    '            If GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is Nothing Then
    '                GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
    '            Else
    '                GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not DirectCast(GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Boolean)
    '            End If

    '            GridPosizioni.Rows(e.RowIndex).DataBoundItem.Selected = GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '            ' SetAgentAbilitations(dataGridView1.Rows[e.RowIndex]);
    '        End If
    '    End If
    'End Sub

    Private Sub cmdPrint_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            'Dim print As PrintFacade = New PrintFacade()
            'print.PrintReportDeleghe(m_Lista)
            'GridPosizioni.ShowPrintPreview()
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridPosizioni
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    'Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    '    'qui seleziono tutta la colonna
    '    GridPosizioni.ClearSelection()
    '    For Each elem As DataGridViewColumn In GridPosizioni.Columns
    '        elem.HeaderCell.SortGlyphDirection = SortOrder.None
    '    Next
    '    Try
    '        GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '        m_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '    Catch ex As Exception
    '        m_selectedColumnName = ""
    '    End Try
    'End Sub

    'Private Sub cmdUp_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Controller.SortItems(m_selectedColumnName)
    '        ' Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

    'Private Sub CmdDown_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Controller.SortItems(m_selectedColumnName, True)
    '        Me.GridPosizioni.DataSource = New ArrayList
    '        Me.GridPosizioni.DataSource = Controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try

    'End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub




    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As DelegadTO = DirectCast(view.GetRow(view.FocusedRowHandle), DelegadTO)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal DelegaDTO As DelegadTO)
        Select Case colName

            Case "colUtente"
                Navigate(DelegaDTO.IdUtente, "ViewUtente")

            Case "colEnteInoltro"
                If Controller.NomeSettore = "EDILE" Then
                    Navigate(DelegaDTO.IdEnteInoltro, "ViewEnte")
                Else
                    Navigate(DelegaDTO.IdEnteInoltro, "ViewAzienda")
                End If
            Case "colReferente"
                Navigate(DelegaDTO.IdReferente, "ViewReferente")
            Case "colResponsabile"
                Navigate(DelegaDTO.IdResponsabile, "ViewReferente")
            Case "colId"
                Dim idDelega As Int32 = DelegaDTO.Id
                Dim StatusDelega As String = DelegaDTO.StatoDelega
                Dim idUtente As Int32 = Convert.ToInt32(DelegaDTO.IdUtente)
                Me.Navigate(idDelega, StatusDelega, idUtente, "ViewDelega")

        End Select
    End Sub

    Private Sub SpecialButton1_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles SpecialButton1.DoClik

        Dim hash As New Hashtable

        'seleziono tutto
        For Each elem As DelegadTO In Controller.SearchResult
            SelectElement(elem, hash)
        Next





        RefreshGrid()
    End Sub

    Private Sub SelectElement(ByVal elemento As DelegadTO, ByVal hash As Hashtable)
        Try
            If Not hash.ContainsKey(elemento.IdUtente) Then
                hash.Add(elemento.IdUtente, "")
                elemento.Selected = True
            Else
                elemento.Selected = False
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)

        End Try
    End Sub
End Class
