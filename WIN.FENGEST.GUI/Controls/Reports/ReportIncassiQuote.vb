Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.Reflection
Imports System.IO

Public Class ReportIncassiQuote
    Private controller As REPORTING.ReportIncassiQuote
    'Private m_selectedColumnName As String = ""
    'Private m_ListaParziale As IList = New ArrayList
    Private m_Lista As IList
    'Private contatore As Int32 = 0 
    'Delegate Sub GridRefresh()
    'Dim deleg As GridRefresh
    Private fullview As Boolean = False

    Private fileLayout As String = ""
    Private Sub RestoreReportLayoutPath()
        fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        Dim f As FileInfo = New FileInfo(fileLayout)


        fileLayout = f.DirectoryName

        fileLayout += "\\LayoutSavings\\reportUncassiQuote.xml"

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


    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        RestoreReportLayoutPath()
    End Sub
    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, REPORTING.ReportIncassiQuote)
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report incassi quote"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report incassi quote"
        Me.lblCurrentFunction.Text = UCase("Report  incassi    quote")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report incassi quote"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()

        m_Lista = controller.SearchResult
        'AddFirstItemsToPartialList()
        'Dim gridLoader As New GridLoaderRptIQ(Me.GridPosizioni)
        'gridLoader.LoadGrid(m_ListaParziale)
        GridPosizioni.DataSource = m_Lista



        'numIQA.Text = controller.NumeroPosizioniIQA
        'numIqi.Text = controller.NumeroPosizioniIQI
        'numIqv.Text = controller.NumeroPosizioniIQV
        'numIqp.Text = controller.NumeroPosizioniIQP
        'num.Text = controller.NumeroPosizioni

        'totIqa.Text = controller.ImportoIQA
        'totIqi.Text = controller.ImportoIQI
        'totIqv.Text = controller.ImportoIQV
        'totIqp.Text = controller.ImportoIQP
        'tot.Text = controller.ImportoTotale

        'totRIqa.Text = controller.ImportoRistornoIQA
        'totRIqi.Text = controller.ImportoRistornoIQI
        'totRIqv.Text = controller.ImportoRistornoIQV
        'totR.Text = controller.ImportoRistornoTotale

        'totM.Text = controller.NumOreMalattia
        'totL.Text = controller.NumOreLavorate

        System.Windows.Forms.Application.DoEvents()


        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")
        lblTipo.Text = controller.TipiDocInclusi
        lblRegRange.Text = controller.DataRegistrazioneRange
        lblDocRange.Text = controller.DataDocumentoRange
        lblCompetenza.Text = controller.CompetenzaRange
        lblSettore.Text = controller.NomeSettore
        lblContratto.Text = controller.NomeContratto
        If controller.IsSettoreEdile Then
            lblSogg.Text = controller.NomeEnte
        Else
            lblSogg.Text = controller.NomeAzienda
        End If
        lblTipoRistorno.Text = controller.TipoRistorno
        lblReferente.Text = controller.NomeReferente
        'Me.txtIncPond.Text = controller.IncassoPonderato
        'Me.txtIncRistPond.Text = controller.IncassoRistornoPonderato
        'Me.txtLavPond.Text = controller.OreLavoratePonderate
        'Me.txtMalPond.Text = controller.OreMalattiaPonderate




    End Sub
    ''Qui scrivo l'algoritmo per caricare la lista con 40 elementi la volta
    'Private Sub AddItemsToPartialList()
    '    If contatore = 0 Then Exit Sub
    '    For i As Int32 = contatore To m_Lista.Count - 1
    '        m_ListaParziale.Add(m_Lista.Item(i))
    '        contatore = contatore + 1
    '    Next
    '    deleg = New GridRefresh(AddressOf GridRefresher)
    '    Me.GridPosizioni.Invoke(deleg)
    '    contatore = 0
    'End Sub


    'Private Sub AddFirstItemsToPartialList()
    '    For i As Int32 = contatore To contatore + 40
    '        If contatore > m_Lista.Count - 1 Then
    '            contatore = 0
    '            Exit Sub
    '        End If
    '        m_ListaParziale.Add(m_Lista.Item(i))
    '        contatore = contatore + 1
    '    Next
    '    'deleg = New GridRefresh(AddressOf GridRefresher)
    '    'Me.GridPosizioni.Invoke(deleg)
    '    GridRefresher()
    '    System.Windows.Forms.Application.DoEvents()
    'End Sub


    'Private Sub GridRefresher()
    '    Me.GridPosizioni.DataSource = New ArrayList
    '    Me.GridPosizioni.DataSource = m_ListaParziale
    '    'Me.GridPosizioni.Refresh()
    'End Sub


    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal TipoDocumento As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        ParameterList.Add("TipoDocumento", TipoDocumento)
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
    '            Case "IdPrestazione"
    '                Navigate(GridPosizioni.SelectedCells(0).Value, "ViewPrestazione")
    '            Case "IdVertenza"
    '                Navigate(GridPosizioni.SelectedCells(0).Value, "ViewVertenza")
    '            Case "SoggettoEsecutore"
    '                If GridPosizioni.Rows(e.RowIndex).Cells("TipoDocumento").Value = "IQI" Then
    '                    Me.NavigateTo("ViewInps")
    '                    Return
    '                End If

    '                If GridPosizioni.Rows(e.RowIndex).Cells("Settore").Value = "EDILE" Then
    '                    Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdSoggettoEsecutore, "ViewEnte")
    '                Else
    '                    Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdSoggettoEsecutore, "ViewAzienda")
    '                End If
    '            Case "AziendaImpiego"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdAziendaImpiego, "ViewAzienda")
    '            Case "Referente"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.IdReferente, "ViewReferente")
    '            Case "DocumentoPadre"
    '                Dim TipoDoc As String = GridPosizioni.Rows(e.RowIndex).Cells("TipoDocumento").Value
    '                Navigate(GridPosizioni.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
    '            Case "PagamentoReferente"
    '                Dim TipoDoc As String = "PGR"
    '                Navigate(GridPosizioni.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
    '        End Select

    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Function GetImage(ByVal ImageType As String) As System.Drawing.Image
    '    If ImageType = "0" Then
    '        Return My.Resources.OK
    '    Else
    '        Return My.Resources.WarningHS
    '    End If
    'End Function




    Private Sub cmdDett_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdDett.DoClik
        Dim frm As New FrmLista(controller.ListaNomiUtenti, "Lista utenti")
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    'Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    '    Try


    '        'tolgo il glifo da tutte le colonne non selezionate
    '        For Each elem As DataGridViewColumn In GridPosizioni.Columns
    '            If e.ColumnIndex <> elem.Index Then
    '                elem.HeaderCell.SortGlyphDirection = SortOrder.None
    '            End If
    '        Next

    '        'SelectToolStripImage nella colonna non c'è glifo
    '        If GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
    '            'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '            OrderUp(GridPosizioni.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If


    '        'SelectToolStripImage nella colonna c'è glifo ascending
    '        If GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
    '            'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '            OrderUp(GridPosizioni.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If


    '        'SelectToolStripImage nella colonna c'è glifo descending
    '        If GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
    '            ' m_selectedColumnName = 
    '            OrderDown(GridPosizioni.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If

    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try

    'End Sub


    'Private Sub OrderUp(ByVal colonna As String)
    '    Try
    '        controller.SortItems(colonna)
    '        Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub OrderDown(ByVal colonna As String)
    '    Try
    '        controller.SortItems(colonna, True)
    '        Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub GridPosizioni_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
    '    Dim thread As New System.Threading.Thread(AddressOf AddItemsToPartialList)
    '    thread.Start()
    'End Sub

    Private Sub cmdPrint_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            'Dim print As PrintFacade = New PrintFacade
            'print.PrintReportIncassiQuote(controller)
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
                Dim a As Quota = DirectCast(GridView1.GetRow(handle), Quota)
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

                For Each elem As Quota In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.IdUtente)
                Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    'Private Sub spview_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles spview.DoClik
    '    Try
    '        SetupView()
    '    Catch ex As Exception
    '        WIN.GUI.APPLICATION.PRESENTATION.ErrorHandler.ShowError(ex)
    '    End Try

    'End Sub


    'Private Sub SetupView()
    '    If fullview Then
    '        ViewFullGrid()

    '    Else
    '        ViewAllData()
    '    End If
    'End Sub

    'Private Sub ViewFullGrid()
    '    GroupBox1.Visible = False
    '    GroupBox2.Visible = False
    '    GridPosizioni.Location = New System.Drawing.Point(GridPosizioni.Location.X, 78)
    '    GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 580))
    '    ' Panel1.Location = New Point(Panel1.Location.X, 78)
    '    fullview = False
    'End Sub

    'Private Sub ViewAllData()
    '    GroupBox1.Visible = True
    '    GroupBox2.Visible = True
    '    GridPosizioni.Location = New System.Drawing.Point(15, 390)
    '    GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 279))
    '    'Panel1.Location = New Point(596, 352)
    '    fullview = True
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
            Dim s As Quota = DirectCast(view.GetRow(view.FocusedRowHandle), Quota)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal quota As Quota)
        Select Case colName

            Case "colUtente"
                Navigate(quota.IdUtente, "ViewUtente")
            Case "colIdPrestazione"
                Navigate(quota.IdPrestazione, "ViewPrestazione")
            Case "colIdVertenza"
                Navigate(quota.IdVertenza, "ViewVertenza")
            Case "colAziendaImpiego"
                Navigate(quota.IdAziendaImpiego, "ViewAzienda")
            Case "colReferente"
                Navigate(quota.IdReferente, "ViewReferente")
            Case "colDocumentoPadre"
                Dim TipoDoc As String = quota.TipoDocumento
                Navigate(quota.DocumentoPadre, TipoDoc, "ViewDocumento")
            Case "colPagamentoReferente"
                Dim TipoDoc As String = "PGR"
                Navigate(quota.PagamentoReferente, TipoDoc, "ViewDocumento")
        End Select
    End Sub



    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.HideCustomizationForm
        Try
            GridPosizioni.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub
End Class
