Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.IO
Imports System.Reflection

Public Class ReportPrestazioni
    Private controller As ADMINISTRATION.ControllerricerchePrestazioniInps
    'Private m_selectedColumnName As String = ""
    'Private fullview As Boolean = True
    Private fileLayout As String = ""
    Private Sub RestoreReportLayoutPath()
        fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        Dim f As FileInfo = New FileInfo(fileLayout)


        fileLayout = f.DirectoryName

        fileLayout += "\\LayoutSavings\\reportPrestazioni.xml"

        Dim d As DirectoryInfo = New DirectoryInfo(f.DirectoryName + "\\LayoutSavings")
        If Not d.Exists Then
            Try
                Directory.CreateDirectory(f.DirectoryName + "\\LayoutSavings")
            Catch ex As Exception
                'se cè qualche problema soprassiedo
            End Try


        End If

        'verifico la presenza del file
        f = New FileInfo(fileLayout)

        Try

            If (f.Exists) Then
                GridPosizioni.ForceInitialize()
                'Restore the previously saved layout
                GridPosizioni.MainView.RestoreLayoutFromXml(fileLayout)
            End If




        Catch ex As Exception
            'non fa nulla
        End Try
    End Sub

    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, ADMINISTRATION.ControllerricerchePrestazioniInps)
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub





    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report prestazioni"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report prestazioni"
        Me.lblCurrentFunction.Text = UCase("Report  prestazioni")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report prestazioni"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        'Dim gridLoader As New GridLoaderRptPrestazioni(Me.GridPosizioni)
        'gridLoader.LoadGrid(controller.Results)
        'numIsc.Text = controller.NumeroPosizioniIQA
        'numRev.Text = controller.NumeroPosizioniIQI
        'numNew.Text = controller.NumeroPosizioniIQV

        GridPosizioni.DataSource = controller.Results



        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")

        lblReferente.Text = controller.NomeReferente
        Me.lblNum.Text = controller.NumeroPosizioni
        Me.lblResidenza.Text = controller.NomeComune
        Me.lblDocRange.Text = controller.DataDocumentoRange
        Me.lblRegRange.Text = controller.DataRegistrazioneRange
        Me.lblTipo.Text = controller.NomeTipoPrestazione
        ''lblReferente.Text = controller.NomeReferente

    End Sub


    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

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
    '            Case "Id"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.Id, "ViewPrestazione")

    '            Case "Referente"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdReferente, "ViewReferente")
    '        End Select

    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub



    'Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
    '    'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
    '    '   If Not e.Value Is Nothing Then
    '    '      e.Value = e.Value.ToString
    '    '   End If
    '    'End If
    '    If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
    '        If Not e.Value Is Nothing Then
    '            e.Value = e.Value.ToString
    '        End If
    '    End If
    'End Sub



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




    'Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        controller.SortItems(m_selectedColumnName)
    '        ' Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub
    'Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        controller.SortItems(m_selectedColumnName, True)
    '        ' Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub



    Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            'Dim print As PrintFacade = New PrintFacade()
            'print.PrintReportPrestazioni(controller.Results)
            'GridPosizioni.ShowPrintPreview()
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridPosizioni
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As PrestazioneDTO = DirectCast(GridView1.GetRow(handle), PrestazioneDTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub cmdListaLavoro_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdListaLavoro.DoClik
        Try


            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.CreateNew()
                controllerListe.Descrizione = descr

                For Each elem As PrestazioneDTO In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.IdUtente)
                Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdDett_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdDett.DoClik
        Dim frm As New FrmLista(controller.ListaNomiUtenti, "Lista utenti")
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub




    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As PrestazioneDTO = DirectCast(view.GetRow(view.FocusedRowHandle), PrestazioneDTO)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal PrestazioneDTO As PrestazioneDTO)
        Select Case colName

            Case "colUtente"
                Navigate(PrestazioneDTO.IdUtente, "ViewUtente")
            Case "colReferente"
                Navigate(PrestazioneDTO.IdReferente, "ViewReferente")
            Case "colId"
                Navigate(PrestazioneDTO.Id, "ViewPrestazione")


        End Select
    End Sub

    'Private Sub spview_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        SetupView()
    '    Catch ex As Exception
    '        WIN.GUI.APPLICATION.PRESENTATION.ErrorHandler.ShowError(ex)
    '    End Try

    'End Sub


    'Private Sub SetupView()
    '   If fullview Then
    '      ViewFullGrid()

    '   Else
    '      ViewAllData()
    '   End If
    'End Sub

    'Private Sub ViewFullGrid()

    '   GroupBox2.Visible = False
    '   GridPosizioni.Location = New System.Drawing.Point(GridPosizioni.Location.X, 78)
    '   GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 554))
    '   Panel1.Location = New Point(Panel1.Location.X, 78)
    '   fullview = False
    'End Sub

    'Private Sub ViewAllData()

    '   GroupBox2.Visible = True
    '   GridPosizioni.Location = New System.Drawing.Point(15, 201)
    '   GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 431))
    '   Panel1.Location = New Point(637, 201)
    '   fullview = True
    'End Sub


    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.HideCustomizationForm
        Try
            GridPosizioni.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub
End Class
