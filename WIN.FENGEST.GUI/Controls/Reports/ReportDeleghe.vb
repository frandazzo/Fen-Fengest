Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports WIN.APPLICATION.REPORTING
Imports System.Reflection
Imports System.IO

Public Class ReportDeleghe
    Private controller As REPORTING.ReportDeleghe
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
    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, REPORTING.ReportDeleghe)
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub

    Private Sub RestoreReportLayoutPath()
        fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        Dim f As FileInfo = New FileInfo(fileLayout)


        fileLayout = f.DirectoryName

        fileLayout += "\\LayoutSavings\\reportDeleghe.xml"

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



    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report deleghe"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report deleghe"
        Me.lblCurrentFunction.Text = UCase("Report  deleghe")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report deleghe"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        m_Lista = controller.SearchResult

        GridPosizioni.DataSource = m_Lista


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
        lblDocRange.Text = controller.DataDocumentoRange
        lblInRange.Text = controller.DataInoltroRange
        lblAccRange.Text = controller.DataAccettazioneRange
        lblAttRange.Text = controller.DataAttivazioneRange
        lblAnnRange.Text = controller.DataAnnullamentoRange
        lblRevRange.Text = controller.DataRevocaRange


        lblReferente.Text = controller.NomeReferente
        lblConsegnata.Text = controller.NomeResponsabile
        lblEnte.Text = controller.NomeEnte
        lblContratto.Text = controller.NomeContratto
        lblCausaleSott.Text = controller.NomeCausaleSottoscrizione
        lblReparto.Text = controller.NomeReparto
    End Sub





    Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
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
                Dim a As DelegadTO = DirectCast(GridView1.GetRow(handle), DelegadTO)
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

                For Each elem As DelegadTO In GetVisuibleRecords()
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
        Dim frm As New FrmLista(controller.ListaNomiAziende, "Lista aziende")
        frm.ShowDialog()
        frm.Dispose()
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
        GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 554))
        'Panel1.Location = New Point(Panel1.Location.X, 78)
        fullview = False
    End Sub

    Private Sub ViewAllData()

        GroupBox2.Visible = True
        GridPosizioni.Location = New System.Drawing.Point(15, 352)
        GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 279))
        'Panel1.Location = New Point(617, 352)
        fullview = True
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





    Private Sub cmdStampaTessere_DoClik(Sender As System.Object, e As System.EventArgs) Handles cmdStampaTessere.DoClik
        Try
            Dim ll As IList = GetVisuibleRecords()
            Dim ll1 As IList = TransformDTOs(ll)


            If ll1.Count = 0 Then
                Return
            End If
            Dim frm As New FrmOptStampaTessere
            If frm.ShowDialog = DialogResult.OK Then
                Dim controller = New REPORTING.ReportIscritti
                controller.SetDTOPrintCardsTable(frm.WithoutTesseraAnnuale, frm.OnlyAddressOK, ll1)
                PrintCards()
            End If


        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    <Secure(Area:="Stampe", Alias:="Stampa tessere da report deleghe", Macroarea:="Reportistica")> _
    Private Sub PrintCards()
        SecurityManager.Instance.Check()
        GoToPrintCards()
    End Sub


    Public Sub GoToPrintCards()

        Dim provinceName As String = GetProvince()



        Dim path As String = GetAppPrintCardPathWithParameter(New String() {"""" & PersistenceInfo.ConnectionString & """", PersistenceInfo.ServiceName, provinceName})
        Shell(path, AppWinStyle.NormalFocus)
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

    Public Overloads Function GetAppPrintCardPathWithParameter(ByVal Parameter() As String) As String
        Dim path As String = My.Application.Info.DirectoryPath & "\WIN.FENGEST_PRINT_CARDS.GUI.exe" '& FileShortName
        If Parameter.Length > 0 Then
            For argNum As Integer = 0 To UBound(Parameter, 1)
                path = path & " " & Parameter(argNum)
            Next argNum
        End If
        Return path
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

    Private Sub SpecialButton1_Click(sender As System.Object, e As System.EventArgs) Handles SpecialButton1.Click




    End Sub

    Private Function GetListaAziende() As Collections.IList
        Dim l As IList = GetVisuibleRecords()

        Dim result As IList = New ArrayList
        'definisco una hashtable con il valore dell'ente di inoltro
        Dim h As New Hashtable

        For Each elem As DelegadTO In l

            If Not String.IsNullOrEmpty(elem.IdEnteInoltro) Then
                'inserisco l'id dell'ente di inoltro nella hashtable se non è stato gia inserito
                If Not h.ContainsKey(elem.IdEnteInoltro) Then
                    h.Add(elem.IdEnteInoltro, "") ' aggiungo un valore fittizio
                    'recupero il valore dellazienda e aggiungo alla lista di ritprno
                    If IsNumeric(elem.IdEnteInoltro) Then
                        Try
                            controllerAziende.LoadById(elem.IdEnteInoltro)
                            result.Add(controllerAziende.Current)
                        Catch ex As Exception

                        End Try
                    End If
                End If
            End If

        Next

        Return result

    End Function

    Private Sub SpecialButton1_DoClik_1(Sender As System.Object, e As System.EventArgs) Handles SpecialButton1.DoClik
        If lblSettore.Text = "EDILE" Then
            MessageBox.Show("Il report è disponibile solo per gli impianti fissi")
            Return

        End If

        'devo recuperare la lista delle aziende
        Dim az As IList = GetListaAziende()


        If az.Count = 0 Then
            MessageBox.Show("Nessuna azienda da esportare")
            Return
        End If



        m_excelExporter = New ExcelExporterListaAziende(az, False)


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

    Private Sub GridView1_ShowCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.ShowCustomizationForm

    End Sub

    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.HideCustomizationForm
        Try
            GridPosizioni.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub
End Class
