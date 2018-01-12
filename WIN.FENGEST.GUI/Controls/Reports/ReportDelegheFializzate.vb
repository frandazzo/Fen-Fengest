Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports WIN.APPLICATION.REPORTING
Imports System.Reflection
Imports System.IO
Public Class ReportDelegheFializzate
    Private controller As REPORTING.ReportDeleghe
    Private controllerIncassiQuote As REPORTING.ReportIncassiQuote
    Private controllerAziende As New ControllerAziende

    Private fullview As Boolean = True

    Private fileLayout As String = ""
    Private m_Lista As IList


    Private WithEvents m_excelExporter As ExcelExporterListaAziende

    Private frm1 As FrmElaborazioneInCorso

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

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        RestoreReportLayoutPath()
    End Sub
    Public Sub New(ByVal ReportingService As Object, ByVal ReportingServiceQuote As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, REPORTING.ReportDeleghe)
        controllerIncassiQuote = DirectCast(ReportingServiceQuote, REPORTING.ReportIncassiQuote)
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub

    Private Sub RestoreReportLayoutPath()
        'fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        'Dim f As FileInfo = New FileInfo(fileLayout)


        'fileLayout = f.DirectoryName

        'fileLayout += "\\LayoutSavings\\reportDelegheQ.xml"

        'Dim d As DirectoryInfo = New DirectoryInfo(f.DirectoryName + "\\LayoutSavings")
        'If Not d.Exists Then
        '    Try
        '        Directory.CreateDirectory(f.DirectoryName + "\\LayoutSavings")
        '    Catch ex As Exception
        '        'se cè qualche problema soprassiedo
        '    End Try


        'End If

        ''verifico la presenza del file
        'f = New FileInfo(fileLayout)

        'Try

        '    If (f.Exists) Then
        '        GridDeleghe.ForceInitialize()
        '        'Restore the previously saved layout
        '        GridDeleghe.MainView.RestoreLayoutFromXml(fileLayout)
        '    End If




        'Catch ex As Exception
        '    'non fa nulla
        'End Try
    End Sub



    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report confronto deleghe quote"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report confronto deleghe quote"
        Me.lblCurrentFunction.Text = UCase("Report  confronto deleghe quote")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report confronto deleghe quote"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        m_Lista = controller.SearchResult

        GridDeleghe.DataSource = m_Lista
        GridQuote.DataSource = controllerIncassiQuote.SearchResult

        CalculateDataForOtherGrids()



        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")
        'lblCompetenza.Text = controller.CompetenzaRange
        lblSettore.Text = controller.NomeSettore
        lblNum.Text = controller.NumeroPosizioni


        lblSott.Text = controller.DelegheSottoscritte
        lblInol.Text = controller.DelegheInoltrate
        lblAcc.Text = controller.DelegheAccettate
        lblAtt.Text = controller.DelegheAttivate
        lblAnn.Text = controller.DelegheAnnullate
        lblRev.Text = controller.DelegheRevocate



        lblRegRange.Text = controller.DataRegistrazioneRange

        lblInRange.Text = controller.DataInoltroRange
        lblAccRange.Text = controller.DataAccettazioneRange
        lblAttRange.Text = controller.DataAttivazioneRange
        lblAnnRange.Text = controller.DataAnnullamentoRange
        lblRevRange.Text = controller.DataRevocaRange


        lblReferente.Text = controller.NomeReferente

        lblEnte.Text = controller.NomeEnte

        lblCausaleSott.Text = controller.NomeCausaleSottoscrizione

    End Sub





    Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            Dim i As Integer = GetVisibleTabIndex()
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            If (i = 0) Then ' deleghe tutte
                link.Component = GridDeleghe
            ElseIf (i = 1) Then ' quote tutte
                link.Component = GridQuote

            ElseIf (i = 2) Then ' deleghe senza quota
                link.Component = GridDelegheSenzaQuote
            ElseIf (i = 3) Then ' quote con delega


                link.Component = GridQuoteConDelega
            Else ' quote senza dleega

                link.Component = GridQuoteSenzaDelega
            End If

            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Function GetVisuibleRecords(GridDelegheView As GridView) As IList
        Dim l As New ArrayList()
        If GridDelegheView.RowCount > 0 Then
            GridDelegheView.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridDelegheView.RowCount
            Dim handle As Int32 = GridDelegheView.GetVisibleRowHandle(i)
            If (Not GridDelegheView.IsGroupRow(handle)) Then
                Dim a As DelegadTO = DirectCast(GridDelegheView.GetRow(handle), DelegadTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function
    Private Function GetQuoteVisuibleRecords(GridQuoteView As GridView) As IList
        Dim l As New ArrayList()
        If GridQuoteView.RowCount > 0 Then
            GridQuoteView.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridQuoteView.RowCount
            Dim handle As Int32 = GridQuoteView.GetVisibleRowHandle(i)
            If (Not GridQuoteView.IsGroupRow(handle)) Then
                Dim a As Quota = DirectCast(GridQuoteView.GetRow(handle), Quota)
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

                Dim i As Integer = GetVisibleTabIndex()
                If (i = 0) Then ' deleghe tutte
                    For Each elem As DelegadTO In GetVisuibleRecords(GridDelegheView)
                        controllerListe.AddUtente(elem.IdUtente)
                    Next
                ElseIf (i = 1) Then ' quote tutte
                    For Each elem As Quota In GetQuoteVisuibleRecords(GridQuoteView)
                        controllerListe.AddUtente(elem.IdUtente)
                    Next

                ElseIf (i = 2) Then ' deleghe senza quota
                    For Each elem As DelegadTO In GetVisuibleRecords(GridDelegheSenzaQuoteView)
                        controllerListe.AddUtente(elem.IdUtente)
                    Next
                ElseIf (i = 3) Then ' quote con delega


                    For Each elem As Quota In GetQuoteVisuibleRecords(GridQuoteConDelegaView)
                        controllerListe.AddUtente(elem.IdUtente)
                    Next
                Else ' quote senza dleega

                    For Each elem As Quota In GetQuoteVisuibleRecords(GridQuoteSenzaDelegaView)
                        controllerListe.AddUtente(elem.IdUtente)
                    Next
                End If

                'For Each elem As DelegadTO In GetVisuibleRecords()
                '    controllerListe.AddUtente(elem.IdUtente)
                'Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Private Sub spview_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles spview.DoClik
        Try
            SetupView()
        Catch ex As Exception
            WIN.GUI.APPLICATION.PRESENTATION.ErrorHandler.ShowError(ex)
        End Try

    End Sub


    Private Sub SetupView()
        If fullview Then
            ViewFullGrid()

        Else
            ViewAllData()
        End If
    End Sub

    Private Sub ViewFullGrid()

        GroupBox2.Visible = False
        TabControl1.Location = New System.Drawing.Point(TabControl1.Location.X, 78)
        TabControl1.Size = New Size(New Point(TabControl1.Size.Width, 554))
        'Panel1.Location = New Point(Panel1.Location.X, 78)
        fullview = False
    End Sub

    Private Sub ViewAllData()

        GroupBox2.Visible = True
        TabControl1.Location = New System.Drawing.Point(15, 352)
        TabControl1.Size = New Size(New Point(TabControl1.Size.Width, 279))
        'Panel1.Location = New Point(617, 352)
        fullview = True
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDelegheView.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub GridView2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridQuoteView.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub GridView3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridQuoteConDelegaView.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub GridView4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridQuoteSenzaDelegaView.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub GridView5_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDelegheSenzaQuoteView.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub


    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Try
                Dim s As DelegadTO = DirectCast(view.GetRow(view.FocusedRowHandle), DelegadTO)
                GotoView(colName, s)
            Catch ex As Exception
                Dim s As Quota = DirectCast(view.GetRow(view.FocusedRowHandle), Quota)
                GotoViewQuote(colName, s)
            End Try

            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoViewQuote(ByVal colName As String, ByVal DelegaDTO As Quota)
        Select Case colName

            Case "colUtente", "GridColumn1", "GridColumn47", "GridColumn13"
                Navigate(DelegaDTO.IdUtente, "ViewUtente")

            Case "colAziendaImpiego", "GridColumn68", "GridColumn34"

                Navigate(DelegaDTO.IdAziendaImpiego, "ViewAzienda")

            Case "colReferente"
                Navigate(DelegaDTO.IdReferente, "ViewReferente")

           

        End Select
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal DelegaDTO As DelegadTO)
        Select Case colName

            Case "colUtente", "GridColumn81"
                Navigate(DelegaDTO.IdUtente, "ViewUtente")

            Case "colEnteInoltro"
                If controller.NomeSettore = "EDILE" Then
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













    Private Function TransformDTOs(listadeleghe As Collections.IList) As Collections.IList



        Dim ll As IList = New ArrayList

        For Each item As DelegadTO In listadeleghe
            ll.Add(CreateIscrittoDTOHelper(item))
        Next


        Return ll

    End Function

    Private Function GetProvince() As String
        Dim c As New ControllerSegreteria
        c.LoadById("1")

        If c.ProvinciaLegale = "" Then
            Return "(Vuoto)"
        End If
        Return c.ProvinciaLegale


    End Function



    Private Function CreateIscrittoDTOHelper(item As DelegadTO) As IscrittoDTO

        Dim d As IscrittoDTO = New IscrittoDTO
        d.Id_Utente = item.IdUtente
        d.Cognome = item.Cognome
        d.Nome = item.Nome
        d.TipoDoc = "IQA"
        d.AziendaImpiego = item.EnteInoltro
        d.Nome_Provincia = item.Nome_Provincia
        d.Nome_Comune = item.Nome_Comune
        d.Indirizzo = item.Indirizzo
        d.Cap = item.Cap




        Return d
    End Function



    'Private Function GetListaAziende() As Collections.IList
    '    Dim l As IList = GetVisuibleRecords()

    '    Dim result As IList = New ArrayList
    '    'definisco una hashtable con il valore dell'ente di inoltro
    '    Dim h As New Hashtable

    '    For Each elem As DelegadTO In l

    '        If Not String.IsNullOrEmpty(elem.IdEnteInoltro) Then
    '            'inserisco l'id dell'ente di inoltro nella hashtable se non è stato gia inserito
    '            If Not h.ContainsKey(elem.IdEnteInoltro) Then
    '                h.Add(elem.IdEnteInoltro, "") ' aggiungo un valore fittizio
    '                'recupero il valore dellazienda e aggiungo alla lista di ritprno
    '                If IsNumeric(elem.IdEnteInoltro) Then
    '                    Try
    '                        controllerAziende.LoadById(elem.IdEnteInoltro)
    '                        result.Add(controllerAziende.Current)
    '                    Catch ex As Exception

    '                    End Try
    '                End If
    '            End If
    '        End If

    '    Next

    '    Return result

    'End Function


    Private Sub GridView1_ShowCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridDelegheView.ShowCustomizationForm

    End Sub

    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridDelegheView.HideCustomizationForm
        Try
            GridDeleghe.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetVisibleTabIndex() As Integer
        Return TabControl1.SelectedIndex
    End Function

    Private Sub CalculateDataForOtherGrids()

        'devo calcolare le dleghe che non hanno una quota
        GridDelegheSenzaQuote.DataSource = CalculateDelegheSenzaQuota
        GridQuoteSenzaDelega.DataSource = CalculateQuoteSenzaDelega()

        GridQuoteConDelega.DataSource = CalculateQuoteconDelega

    End Sub
    Private Function QuoteContainsWorker(quote As IList, idUtente As Integer) As Boolean
        For Each elem As Quota In quote
            If (elem.IdUtente = idUtente) Then
                Return True
            End If
        Next

        Return False
    End Function
    Private Function CalculateDelegheSenzaQuota() As ArrayList
        Dim deleghe As IList = controller.SearchResult
        Dim quote As IList = controllerIncassiQuote.SearchResult


        Dim result As New ArrayList
        For Each elem As DelegadTO In deleghe
            Dim idUt As Integer = elem.IdUtente

            'se non trovo l'id utente nella lista delle quote aggiungo la dleega
            If Not QuoteContainsWorker(quote, idUt) Then
                result.Add(elem)
            End If
        Next

        Return result

    End Function

    Private Function CalculateQuoteSenzaDelega() As ArrayList
        Dim deleghe As IList = controller.SearchResult
        Dim quote As IList = controllerIncassiQuote.SearchResult


        Dim result As New ArrayList
        For Each elem As Quota In quote
            Dim idUt As Integer = elem.IdUtente

            'se non trovo l'id utente nella lista delle quote aggiungo la dleega
            If Not DelegheContainsWorker(deleghe, idUt) Then
                result.Add(elem)
            End If
        Next

        Return result

    End Function

    Private Function DelegheContainsWorker(quote As IList, idUtente As Integer) As Boolean
        For Each elem As DelegadTO In quote
            If (elem.IdUtente = idUtente) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function CalculateQuoteconDelega() As Object
        Dim deleghe As IList = controller.SearchResult
        Dim quote As IList = controllerIncassiQuote.SearchResult


        Dim result As New ArrayList
        For Each elem As Quota In quote
            Dim idUt As Integer = elem.IdUtente

            'se non trovo l'id utente nella lista delle quote aggiungo la dleega
            If DelegheContainsWorker(deleghe, idUt) Then
                result.Add(elem)
            End If
        Next

        Return result
    End Function

End Class
