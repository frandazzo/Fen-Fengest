Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.IO
Imports System.Reflection
Imports WIN.APPLICATION.UTENTI

<SecureContext()> _
Public Class ReportIscrittiDTO
    Private controllerReferenti As New ControllerReferenti
    Private controllerUtenti As New ControllerUtenti
    Private controller As REPORTING.ReportIscritti
    Private controllerAziende As New ControllerAziende
    'Private m_selectedColumnName As String = ""
    Private fullview As Boolean = True

    Private WithEvents m_excelExporter As ExcelExporterListaAziende

    Private frm1 As FrmElaborazioneInCorso

    Private fileLayout As String = ""
    Private Sub RestoreReportLayoutPath()
        fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        Dim f As FileInfo = New FileInfo(fileLayout)


        fileLayout = f.DirectoryName

        fileLayout += "\\LayoutSavings\\reportIscritti.xml"

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


    Private Function GetListaAziende() As Collections.IList
        Dim l As IList = GetVisuibleRecords()

        Dim result As IList = New ArrayList
        'definisco una hashtable con il valore dell'ente di inoltro
        Dim h As New Hashtable

        For Each elem As IscrittoDTO In l


            'inserisco l'id dell'ente di inoltro nella hashtable se non è stato gia inserito
            If Not h.ContainsKey(elem.Id_Azienda_Impiego) Then
                h.Add(elem.Id_Azienda_Impiego, "") ' aggiungo un valore fittizio
                'recupero il valore dellazienda e aggiungo alla lista di ritprno
                If elem.Id_Azienda_Impiego > 0 Then
                    Try
                        controllerAziende.LoadById(elem.Id_Azienda_Impiego)
                        result.Add(controllerAziende.Current)
                    Catch ex As Exception

                    End Try
                End If
            End If


        Next

        Return result

    End Function

    Private Sub SpecialButton1_DoClik_1(Sender As System.Object, e As System.EventArgs)


    End Sub

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        RestoreReportLayoutPath()
    End Sub
    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, REPORTING.ReportIscritti)
        If controller.ExportType <> "" And controller.NomeEnte <> "" Then
            spExport.Visible = True
        End If
        If controller.ExportType = "IMPIANTI FISSI" Then
            spExport.Visible = True
        End If

        If controller.OnlyQuoteInps Then
            spExport.Visible = True
        End If
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub




    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report iscritti"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report iscritti"
        Me.lblCurrentFunction.Text = UCase("Report  iscritti")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report iscritti"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
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
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.Id_Utente, "ViewUtente")
    '            Case "AziendaImpiego"
    '                Navigate(GridPosizioni.Rows(e.RowIndex).DataBoundItem.Id_Azienda_Impiego, "ViewAzienda")

    '        End Select

    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub









    Protected Overrides Sub Nested_PrepareLoading()
        'Dim gridLoader As New GridLoaderRptIscrittiDTO(Me.GridPosizioni)
        'gridLoader.LoadGrid(controller.SearchResult)
        'numIsc.Text = controller.NumeroPosizioniIQA
        'numRev.Text = controller.NumeroPosizioniIQI
        'numNew.Text = controller.NumeroPosizioniIQV

        GridPosizioni.DataSource = controller.SearchResult


        lblEnte.Text = controller.NomeEnte
        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")
        lblCompetenza.Text = controller.CompetenzaRange
        lblSettore.Text = controller.NomeSettore
        lblContratto.Text = controller.NomeContratto
        lblSogg.Text = controller.NomeAzienda
        lblVerifica.Text = controller.VerificaDelega
        lblReferente.Text = controller.NomeReferente
        Me.numIsc.Text = controller.NumeroIscritti
        Me.numNew.Text = controller.NumeroIscrittiNuovi
        Me.numRevCGL.Text = controller.NumeroIscrittiConRevocaCGL
        Me.NumRevCisl.Text = controller.NumeroIscrittiConRevocaCISL

        ''lblReferente.Text = controller.NomeReferente

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
                Dim a As IscrittoDTO = DirectCast(GridView1.GetRow(handle), IscrittoDTO)
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

                For Each elem As IscrittoDTO In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.Id_Utente)
                Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdPrintCard_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrintCard.DoClik
        Try
            Dim ll As IList = GetVisuibleRecords()
            If ll.Count = 0 Then
                Return
            End If
            Dim frm As New FrmOptStampaTessere
            If frm.ShowDialog = DialogResult.OK Then
                controller.SetDTOPrintCardsTable(frm.WithoutTesseraAnnuale, frm.OnlyAddressOK, ll)
                PrintCards()
            End If


        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    <Secure(Area:="Stampe", Alias:="Stampa tessere", Macroarea:="Reportistica")> _
    Private Sub PrintCards()
        SecurityManager.Instance.Check()
        GoToPrintCards()
    End Sub

    Public Sub GoToPrintCards()

        Dim provinceName As String = GetProvince()



        Dim path As String = GetAppPrintCardPathWithParameter(New String() {"""" & PersistenceInfo.ConnectionString & """", PersistenceInfo.ServiceName, provinceName})
        Shell(path, AppWinStyle.NormalFocus)
    End Sub

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
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GridPosizioni.Location = New System.Drawing.Point(GridPosizioni.Location.X, 78)
        GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 554))
        'Panel1.Location = New Point(Panel1.Location.X, 78)
        fullview = False
    End Sub

    Private Sub ViewAllData()
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GridPosizioni.Location = New System.Drawing.Point(15, 286)
        GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 350))
        'Panel1.Location = New Point(592, 286)
        fullview = True
    End Sub

    Private Sub spExport_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles spExport.DoClik
        Try
            Dim frmExp As New FrmExportData(controller.ExportType, controller.NomeEnte, GetVisuibleRecords)


            If frmExp.ShowDialog = DialogResult.OK Then

                If frmExp.IscrittidaEsportare Is Nothing Then
                    Return
                End If

                'a questo punto richiamo il programma di export
                SendToExportProgram(frmExp.IscrittidaEsportare)

            End If

            frmExp.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub SendToExportProgram(ByVal export As ExportTrace)
        'in questa funzione preparo i parametri per l'avvio del programma

        'per prima cosa salvo la traccia su un fiule xml

        Dim tempDir As String = IO.Path.GetTempPath

        Dim fileName As String = IO.Path.Combine(tempDir, "export.xml")

        'salvo il file che farò riprendere all'altro programma
        WIN.TECHNICAL.MIDDLEWARE.XmlSerializzation.ObjectXMLSerializer(Of ExportTrace).Save(export, fileName)


        'recupero il percorso del programma di export
        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
        'Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
        'Dim f As New IO.FileInfo(path)
        'path = f.DirectoryName + exportProgram
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
        args.Arguments = ConstuctArguments(fileName)

        'passo il nome del programma da avviare
        args.FileName = path

        'avvio il programma
        Process.Start(args)

    End Sub

    Private Function ConstuctArguments(ByVal traceFile As String) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"

        Dim fil As String = """fil:" + traceFile + """"
        Dim com As String = """com:1"""

        result = usn + " " + usp + " " + pro + " " + fil + " " + com


        Return result
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
            Dim s As IscrittoDTO = DirectCast(view.GetRow(view.FocusedRowHandle), IscrittoDTO)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal IscrittoDTO As IscrittoDTO)
        Select Case colName

            Case "colUtente"
                Navigate(IscrittoDTO.Id_Utente, "ViewUtente")

            Case "colAziendaImpiego"
                Navigate(IscrittoDTO.Id_Azienda_Impiego, "ViewAzienda")

        End Select
    End Sub


    Private Sub SpecialButton1_DoClik_2(Sender As System.Object, e As System.EventArgs) Handles SpecialButton1.DoClik
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

    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.HideCustomizationForm
        Try
            GridPosizioni.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub

    Private Function FindReferente(listaReferenti As ArrayList, id As Int32) As String
        For Each elem As Referente In listaReferenti
            If (elem.Id = id) Then
                Return elem.CompleteName
            End If
        Next
        Return ""
    End Function

    Private Sub spReportCompleto_DoClik(Sender As Object, e As EventArgs) Handles spReportCompleto.DoClik

        Dim listReferetni As ArrayList = controllerReferenti.GetAll
        Dim listOfIscritti As New List(Of IscrittoNonIscrittoDTO)
        Dim aziende As New Hashtable

        'ciclo su tutti gli iscitti per ceare la lista dei nuovi oggetti iscrittononiscitto
        For Each elem As IscrittoDTO In controller.SearchResult

            Dim iscrittoNonIscritto As New IscrittoNonIscrittoDTO

            iscrittoNonIscritto.Settore = elem.Settore
            iscrittoNonIscritto.NomeEnte = elem.NomeEnte
            iscrittoNonIscritto.AziendaImpiego = elem.AziendaImpiego
            iscrittoNonIscritto.Competenza = elem.Competenza
            iscrittoNonIscritto.Contratto = elem.Contratto
            iscrittoNonIscritto.Livello = elem.Livello
            iscrittoNonIscritto.TipoDoc = elem.TipoDoc
            iscrittoNonIscritto.Referente = FindReferente(listReferetni, elem.Id_Referente)


            iscrittoNonIscritto.Nome = elem.Nome
            iscrittoNonIscritto.Cognome = elem.Cognome
            iscrittoNonIscritto.DataNascita = elem.DataNascita
            iscrittoNonIscritto.Codice_Fiscale = elem.Codice_Fiscale
            iscrittoNonIscritto.Nome_Nazione = elem.Nome_Nazione
            iscrittoNonIscritto.Nome_Comune_Nascita = elem.Nome_Comune_Nascita
            iscrittoNonIscritto.Nome_Provincia_Nascita = elem.Nome_Provincia_Nascita
            iscrittoNonIscritto.Nome_Comune = elem.Nome_Comune
            iscrittoNonIscritto.Nome_Provincia = elem.Nome_Provincia
            iscrittoNonIscritto.Indirizzo = elem.Indirizzo
            iscrittoNonIscritto.Cap = elem.Cap
            iscrittoNonIscritto.Cell1 = elem.Cell1
            iscrittoNonIscritto.Cell2 = elem.Cell2


            iscrittoNonIscritto.IscittoA = "FENEAL"
            iscrittoNonIscritto.DataNonIscritto = Nothing

            ''aggiungo l'azienda alla lista delle aziende disponibilki
            If (Not String.IsNullOrEmpty(elem.AziendaImpiego)) Then
                If (Not aziende.Contains(elem.AziendaImpiego)) Then
                    aziende.Add(elem.AziendaImpiego, "")
                End If
            End If

            listOfIscritti.Add(iscrittoNonIscritto)
        Next



        Dim listaNonIscritti As IList
        Try
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)

            listaNonIscritti = RetrieveNonIscritti()

            WIN.GUI.UTILITY.Helper.HideWaitBox()

        Catch ex As Exception
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
            Return
        End Try






        For Each elem As NonIscrittoDTO In listaNonIscritti

            'prima di inserirlo nel calderone devo verificare se cè l'azienda
            If (aziende.Contains(elem.Nome_Azienda)) Then


                Dim iscrittoNonIscritto As New IscrittoNonIscrittoDTO

                iscrittoNonIscritto.Settore = ""
                iscrittoNonIscritto.NomeEnte = elem.Nome_Ente
                iscrittoNonIscritto.AziendaImpiego = elem.Nome_Azienda
                iscrittoNonIscritto.Competenza = ""
                iscrittoNonIscritto.Contratto = ""
                iscrittoNonIscritto.Livello = elem.Livello
                iscrittoNonIscritto.TipoDoc = ""
                iscrittoNonIscritto.Referente = ""

                controllerUtenti.LoadById(elem.Id_Utente)
                iscrittoNonIscritto.Nome = controllerUtenti.Nome
                iscrittoNonIscritto.Cognome = controllerUtenti.Cognome
                iscrittoNonIscritto.DataNascita = controllerUtenti.DataNascita
                iscrittoNonIscritto.Codice_Fiscale = elem.Codice_Fiscale
                iscrittoNonIscritto.Nome_Nazione = elem.Nome_Nazione
                iscrittoNonIscritto.Nome_Comune_Nascita = controllerUtenti.ComuneNascita
                iscrittoNonIscritto.Nome_Provincia_Nascita = controllerUtenti.ProvinciaNascita
                iscrittoNonIscritto.Nome_Comune = elem.Nome_Comune
                iscrittoNonIscritto.Nome_Provincia = elem.Nome_Provincia
                iscrittoNonIscritto.Indirizzo = controllerUtenti.ViaResidenza
                iscrittoNonIscritto.Cap = controllerUtenti.CapResidenza
                iscrittoNonIscritto.Cell1 = elem.Cell1
                iscrittoNonIscritto.Cell2 = elem.Cell2


                iscrittoNonIscritto.IscittoA = elem.IscrittoA
                iscrittoNonIscritto.DataNonIscritto = elem.Libero_Al



                listOfIscritti.Add(iscrittoNonIscritto)


            End If
            
        Next




        Dim frm As New FrmIscrittoNonIscitto(listOfIscritti)
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Function RetrieveNonIscritti() As IList
        'devo recuperare la lista dei non iscritti

        Dim p As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        Dim data As Object = p.ExecuteScalar("select Max(LIBERO_AL) from db_infos")

        If (data Is Nothing) Then
            Return New ArrayList
        End If

        Dim d As DateTime = DateTime.Parse(data.ToString)




        Dim ControllerNonIscitti As New WIN.APPLICATION.REPORTING.ReportLiberi

        ControllerNonIscitti.SetEnte("")
        ControllerNonIscitti.SetCompetenza(d.AddDays(-1), d.AddDays(1))
        ControllerNonIscitti.SetAzienda("")
        ControllerNonIscitti.SetRicercaErrori(False)
        ControllerNonIscitti.SetComune("")
        ControllerNonIscitti.SetProvincia("")
        ControllerNonIscitti.SetNazione("")
        ControllerNonIscitti.SetValidazioneLiberi(False)

        ControllerNonIscitti.SetIscrittoA("-")

        Return ControllerNonIscitti.SearchDTOs
       

    End Function

End Class
