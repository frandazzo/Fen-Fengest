
Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.IO
Imports System.Reflection

Public Class ReportLiberiDTO
    Private controller As REPORTING.ReportLiberi
    'Private m_selectedColumnName As String = ""
    Private fullview As Boolean = True
    Private fileLayout As String = ""
    Private Sub RestoreReportLayoutPath()
        fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        Dim f As FileInfo = New FileInfo(fileLayout)


        fileLayout = f.DirectoryName

        fileLayout += "\\LayoutSavings\\reportNonIscritti.xml"

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
        controller = DirectCast(ReportingService, REPORTING.ReportLiberi)
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub




    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report lavoratori liberi"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report lavoratori liberi"
        Me.lblCurrentFunction.Text = UCase("Report  lavoratori liberi")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report lavoratori liberi"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        'Dim gridLoader As New GridLoaderRptLiberiDTO(Me.GridPosizioni)
        '' gridLoader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'gridLoader.LoadGrid(controller.SearchResult)
        'numIsc.Text = controller.NumeroPosizioniIQA
        'numRev.Text = controller.NumeroPosizioniIQI
        'numNew.Text = controller.NumeroPosizioniIQV

        GridPosizioni.DataSource = controller.SearchResult



        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")
        lblCompetenza.Text = controller.CompetenzaRange

        lblEnte.Text = controller.NomeEnte
        lblSogg.Text = controller.NomeAzienda


        Me.numIsc.Text = controller.NumeroLiberi


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

    '            Case "Nome_Utente"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.Id_Utente, "ViewUtente")
    '            Case "Nome_Azienda"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.Id_Azienda_Impiego, "ViewAzienda")
    '        End Select

    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

    ' Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
    '     'Try
    '     'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
    '     '   If Not e.Value Is Nothing Then
    '     '      e.Value = e.Value.ToString
    '     '   End If
    '     'End If

    ' End Sub
    'Private Function GetImage(ByVal ImageType As String) As System.Drawing.Image
    '   If ImageType = "0" Then
    '      Return My.Resources.OK
    '   Else
    '      Return My.Resources.WarningHS
    '   End If
    'End Function






    'Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
    '   'qui seleziono tutta la colonna
    '   GridPosizioni.ClearSelection()
    '   For Each elem As DataGridViewColumn In GridPosizioni.Columns
    '      elem.HeaderCell.SortGlyphDirection = SortOrder.None
    '   Next
    '   Try
    '      GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '      m_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '   Catch ex As Exception
    '      m_selectedColumnName = ""
    '   End Try

    'End Sub




    'Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
    '   Try
    '      controller.SortDTOItems(m_selectedColumnName)
    '      ' Me.GridPosizioni.DataSource = controller.SearchResult
    '      Me.GridPosizioni.Refresh()
    '      GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try
    'End Sub
    'Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
    '   Try
    '      controller.SortDTOItems(m_selectedColumnName, True)
    '      ' Me.GridPosizioni.DataSource = controller.SearchResult
    '      Me.GridPosizioni.Refresh()
    '      GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try
    'End Sub
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
    '        controller.SortDTOItems(colonna)
    '        Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub OrderDown(ByVal colonna As String)
    '    Try
    '        controller.SortDTOItems(colonna, True)
    '        Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            'Dim print As PrintFacade = New PrintFacade
            'print.PrintReportNonIscrittiDTO(controller.SearchResult)
            'GridPosizioni.ShowPrintPreview()
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridPosizioni
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub cmdListaLavoro_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdListaLavoro.DoClik
        Try


            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.CreateNew()
                controllerListe.Descrizione = descr

                For Each elem As NonIscrittoDTO In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.Id_Utente)
                Next
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
        GridPosizioni.Location = New System.Drawing.Point(GridPosizioni.Location.X, 78)
        GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 550))
        'Panel1.Location = New Point(Panel1.Location.X, 78)
        fullview = False
    End Sub

    Private Sub ViewAllData()

        GroupBox2.Visible = True
        GridPosizioni.Location = New System.Drawing.Point(15, 197)
        GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 430))
        'Panel1.Location = New Point(562, 197)
        fullview = True
    End Sub

    Private Sub spImport_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles spImport.DoClik


        'Dim frm As New FrmExportIndex(GetVisuibleRecords().Count)
        'Dim min As Int32 = 0
        'Dim max As Int32 = 0

        'If frm.ShowDialog = DialogResult.OK Then

        '    max = frm.Max
        '    min = frm.Min

        '    frm.Dispose()
        'Else
        '    frm.Dispose()
        '    Return

        'End If


        Try


            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere costruzione report...", My.Resources.Waiting3)

            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")


            Dim exportProgram As String = "\FenealConnector\WIN.WEBCONNECTOR.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.Parent.FullName + exportProgram

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalità non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If



            'definisco i parametri di apertura del programma
            Dim args As New ProcessStartInfo
            args.Arguments = ConstuctArguments(0, 25000)

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)



        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try




    End Sub



    Private Function ConstuctArguments(ByVal startIndex As Int32, ByVal endIndex As Int32) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"


        Dim chk As String = """chk:no"""
        Dim com As String = """com:3"""




        'creo la stringa dei codici fiscali
        Dim cf As String = CreateFiscalCodesFile(startIndex, endIndex)

        Dim flc As String = """flc:" + cf + """"


        result = usn + " " + usp + " " + pro + " " + chk + " " + com + " " + flc


        Return result
    End Function


    Private Function CreateFiscalCodesFile(ByVal index As Int32, ByVal endIndex As Int32) As String


        Dim file As String = System.IO.Path.GetTempPath + "temp.txt"



        Dim res As String = ""

        Dim i As Int32 = 0

        For Each elem As NonIscrittoDTO In GetVisuibleRecords()

            If i >= index And i <= endIndex Then
                Dim cf As String = elem.Codice_Fiscale.Trim

                'tolgo eventuali spazi
                cf.Replace(" ", "")

                If Not String.IsNullOrEmpty(cf) Then
                    res = res + " " + cf
                End If
            End If


            i = i + 1
        Next

        IO.File.Delete(file)
        IO.File.AppendAllText(file, res)


        Return file
    End Function


    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As NonIscrittoDTO = DirectCast(GridView1.GetRow(handle), NonIscrittoDTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub









    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As NonIscrittoDTO = DirectCast(view.GetRow(view.FocusedRowHandle), NonIscrittoDTO)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal nonIscrittoDTO As NonIscrittoDTO)
        Select Case colName

            Case "colUtente"
                Navigate(nonIscrittoDTO.Id_Utente, "ViewUtente")

            Case "colAziendaImpiego"
                Navigate(nonIscrittoDTO.Id_Azienda_Impiego, "ViewAzienda")

        End Select
    End Sub

    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.HideCustomizationForm
        Try
            GridPosizioni.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub
End Class

