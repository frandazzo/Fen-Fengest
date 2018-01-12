Imports System.Windows.Forms
Imports WIN.GUI.PRINT
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports System.IO

<SecureContext()> _
Public Class ControlAnagraficaAzienda
    Private controller As New AZIENDE.ControllerAziende(True)
    Dim controllersettori As New ControllerSettori
    Dim controllerContratti As New ControllerTipoContratto
    Private WithEvents frm As FrmSediOperative
    Dim m_ClearCache As Boolean = False
    Private ControllerSegreteria As New ControllerSegreteria

    Public Sub New(ByVal IdAz As Int32, ByVal ClearCache As Boolean)
        InitializeComponent()
        Me.m_IdShowedObject = IdAz
        m_ClearCache = ClearCache

        DoLoad()

    End Sub
    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Aziende", Alias:="Creazione", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Aziende", Alias:="Aggiornamento", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub



    <Secure(Area:="Aziende", Alias:="Cancellazione", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub


    Private Sub GetDatiAzienda(azienda As String)


        Try

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


            args.Arguments = ConstuctArguments(azienda)



            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try


    End Sub

    Private Function ConstuctArguments(ByVal azienda As String) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"
        Dim chk As String = """chk:no"""

        Dim fil As String = """azi:" + azienda + """"
        Dim com As String = """com:7"""

        result = usn + " " + usp + " " + pro + " " + fil + " " + com + " " + chk


        Return result
    End Function


    Public Sub New()
        InitializeComponent()
        Try
            DoLoad()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Public Sub New(ByVal IdAz As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdAz

        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " azienda"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " azienda "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " azienda")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  azienda"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  azienda"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))

            SpNew.Visible = False

            NiceGroupBox1.Visible = False
        Catch ex As Exception
            Nested_NotifyParent()
        End Try
    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()

        grpRag.Visible = False
        'GrpPagamenti.Visible = False
        GrpSed.Visible = False
        'GrpCont.Visible = False
        NiceGroupBox1.Visible = False
        Me.IdAziendaTextBox1.TextValue = ""
        Me.IdAziendaTextBox1.Visible = True
        Me.IdAziendaTextBox1.Enabled = True
        Me.lblId.Visible = True
        CustomBar1.Visible = False
        MasterControl.Instance.ParentForm.Text = "Ricerca azienda"
        Me.lblCurrentFunction.Text = UCase("Ricerca azienda ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca azienda"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        '  Me.PictureBox1.Visible = True


        Me.BackColor = Color.Transparent
        SpNew.Visible = True
        LoadCboContratti(-1)
        ' GrpQ.Visible = False
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        grpRag.Visible = True
        NiceGroupBox1.Visible = True
        'GrpQ.Visible = True
        'GrpPagamenti.Visible = True
        GrpSed.Visible = True
        'GrpCont.Visible = True
        Me.IdAziendaTextBox1.TextValue = ""
        Me.IdAziendaTextBox1.Enabled = False

        Me.IdAziendaTextBox1.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione Azienda"
        ' Me.PictureBox1.Visible = False
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)

        'Me.txtCartella.Text = ""
        If Me.GridSedi.DataSource IsNot Nothing Then
            Me.GridSedi.DataSource = New ArrayList
        End If

        'SetUpComboSettori()
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, True)
        LoadDefaultData()
        SpNew.Visible = False
    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtVia.Text = ""
        cboProvincia.Text = ""
        cboComune.Text = ""
        txtNome.Text = ""
        'txtCartella.Text = ""
        txtPIva.Text = ""

        txtResp.Text = ""
        txtMail.Text = ""
        txtCell1.Text = ""
        txtCell2.Text = ""
        txtFax.Text = ""
        txtTelUf.Text = ""
        txtCE.TextValue = ""
        txtEC.TextValue = ""
        txtNote.TextValue = ""
        txtCap.Text = ""

        If Me.GridSedi.DataSource IsNot Nothing Then
            Me.GridSedi.DataSource = New ArrayList
        End If
        Me.IdAziendaTextBox1.TextValue = ""
        Me.lblUltimaCompetenza.Text = "Non è stato effettuato alcun pagamento!"
        'txtScarto.Text = ""
        cboContratti.Text = ""
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        If m_ClearCache Then
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            m_ClearCache = False
        Else
            controller.LoadById(Me.m_IdShowedObject)
        End If
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome.Text = controller.Descrizione
        txtCap.Text = controller.CapLegale
        Me.IdAziendaTextBox1.TextValue = controller.IdAzienda
        Me.lblUltimaCompetenza.Text = controller.CompetenzaUltimoPagamento
        'txtScarto.Text = controller.Scarto
        txtPIva.Text = controller.PartitaIva
        Dim idSettore As Int32 = controller.IdSettoreContratto
        If idSettore = 1 Or idSettore = 2 Then
            cboSettori.Text = controllersettori.GetDescrizioneSettoreById(idSettore)
        Else
            cboSettori.Text = ""
        End If
        LoadCboContratti(idSettore)
        cboContratti.Text = controller.DescrizioneContratto
        txtVia.Text = controller.ViaLegale
        cboProvincia.Text = controller.ProvinciaLegale
        cboComune.Text = controller.ComuneLegale
        'txtCartella.Text = controller.DirectoryPreferenziale

        txtCE.TextValue = controller.CodiceCE
        txtEC.TextValue = controller.CodiceEC
        txtNote.TextValue = controller.Note


        Me.txtFax.Text = controller.Fax
        Me.txtCell1.Text = controller.Cellulare1
        Me.txtCell2.Text = controller.Cellulare2
        Me.txtTelUf.Text = controller.TelefonoUfficio
        Me.txtMail.Text = controller.Mail
        Me.txtResp.Text = controller.Responsabile


        LoadGrid(controller.GetListaSediOperative)
        GridSedi.Refresh()
    End Sub

    Private Sub LoadGrid(ByVal Lista As IList)
        With GridSedi
            If Lista.Count > 0 Then
                If Not .Columns.Contains("Provincia") Then
                    .Columns.Add("Provincia", "Provincia")
                End If
                If Not .Columns.Contains("Via") Then
                    .Columns.Add("Via", "Via")
                End If
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("IdAziendaPadre").Visible = False


                .Columns("Descrizione").Visible = True
                .Columns("Descrizione").ReadOnly = True
                .Columns("Descrizione").DisplayIndex = 0

                .Columns("Provincia").Visible = True
                .Columns("Provincia").ReadOnly = True
                .Columns("Provincia").DisplayIndex = 1

                .Columns("Indirizzo").Visible = True
                .Columns("Indirizzo").HeaderText = "Comune"
                .Columns("Indirizzo").ReadOnly = True
                .Columns("Indirizzo").DisplayIndex = 2

                .Columns("Via").Visible = True
                .Columns("Via").ReadOnly = True
                .Columns("Via").DisplayIndex = 3

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub
    Private Sub LoadCboContratti(ByVal IdSettore As String)
        cboContratti.Items.Clear()
        Select Case IdSettore
            Case 1 To 2 ' edili
                'LoadCombo(IdSettore)
                InterfaceMediator.LoadCombo(cboContratti, controller.GetListaContrattiForSettore(IdSettore), True)
        End Select
    End Sub
    'Private Sub LoadCombo(ByVal IdSettore As Int32)
    '   cboContratti.Items.Clear()
    '   Dim list As ArrayList = controller.GetListaContrattiFiorSettore(IdSettore)
    '   For Each elem As String In list
    '      cboContratti.Items.Add(elem)
    '   Next
    '   cboContratti.Items.Add("")
    '   cboContratti.Sorted = True
    '   cboContratti.Text = ""
    'End Sub

#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdAziendaTextBox1.Enabled = False
        Me.IdAziendaTextBox1.Visible = False
        NiceGroupBox1.Visible = False
        SpNew.Visible = False
        Me.lblId.Visible = False
        grpRag.Visible = True
        GrpSed.Visible = True
        '  Me.PictureBox1.Visible = False
        Me.CustomBar1.SetTargetControl(Me)
        CustomBar1.Visible = True
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, True)
        LoadCboContratti(-1)
        LoadDefaultData()
        controller.CreateNew()
        'SpAddFile.Disabled = True
        'SpCreateDir.Disabled = True
    End Sub
#End Region




#Region "Metodi per il salvataggio"
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewAzienda", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.IdAziendaTextBox1.Enabled = False
        Me.IdAziendaTextBox1.Visible = True
        Me.lblId.Visible = True
        NiceGroupBox1.Visible = True


        SpNew.Visible = False

        'SpAddFile.Disabled = False
        'SpCreateDir.Disabled = False
    End Sub

    Protected Overrides Sub Nested_PostUpdateActions()

        NiceGroupBox1.Visible = True


    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewAzienda", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Protected Overloads Sub Navigate(ByVal ToId As String, Optional ByVal ClearCache As Boolean = False)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("ClearCache", ClearCache)
            Me.NavigateTo("ViewAzienda", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub




    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Public Overrides Sub Nested_InsertData()


        controller.CodiceCE = txtCE.TextValue
        controller.CodiceEC = txtEC.TextValue
        controller.Note = txtNote.TextValue
        controller.Descrizione = txtNome.Text
        controller.PartitaIva = Me.txtPIva.Text
        controller.Scarto = "" 'txtScarto.Text
        controller.SetContrattoApplicato(controller.GetIdContrattoByDescrizione(cboContratti.Text))
        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text, txtCap.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text
        controller.Save()
        MyBase.m_IdShowedObject = controller.IdAzienda

    End Sub
#End Region

#Region "Metodi per l'aggiornamneto"
    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub IdContoTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub

    Private Sub txtScarto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub txtScarto_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_UpdateData()
        controller.Descrizione = txtNome.Text
        controller.Scarto = "" 'Me.txtScarto.Text
        controller.PartitaIva = Me.txtPIva.Text


        controller.CodiceCE = txtCE.TextValue
        controller.CodiceEC = txtEC.TextValue
        controller.Note = txtNote.TextValue

        controller.SetContrattoApplicato(controller.GetIdContrattoByDescrizione(cboContratti.Text))
        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text, txtCap.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text


        If controller.DirectoryPreferenziale = "" Then
            ControllerSegreteria.LoadById(1)
            controller.DirectoryPreferenziale = ControllerSegreteria.DirectoryPreferenzialeAziende
        End If


        controller.Save()
    End Sub

#End Region






    Private Sub cboContratti_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboContratti.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
        If cboSettori.Text = "EDILE" Or cboSettori.Text = "IMPIANTI FISSI" Then
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContrattiByIdSettore(controllersettori.GetIdSettoreByDescrizione(cboSettori.Text)), True)
        Else
            InterfaceMediator.LoadCombo(cboContratti, controller.GetListaContrattiForSettore(-1), True)
        End If
        Me.StartChangeOperation()
    End Sub


    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        Try
            Navigate(Me.IdAziendaTextBox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try

            If Me.State.StateName = "Creazione" Then
                MasterControl.Instance.GoPrevious()
            Else
                'Me.Cancel()
                Navigate(Me.IdAziendaTextBox1.TextValue, True)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintAzienda(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("L'azienda sarà eliminata solamente se nel sistema non ci sono altri riferimenti all'azienda. Sicuro di voler cancellare l'azienda selezionata? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                Navigate(-1)
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Createnew()

    End Sub

    Private Sub Createnew()
        Try
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            StartSaveOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub







    Private Sub txtVia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVia.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCap.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        Me.StartChangeOperation()
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
    End Sub

    Private Sub cboComune_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboComune.SelectedIndexChanged
        Me.StartChangeOperation()
        'If Me.txtCap.Text = "" Then
        '    Me.txtCap.Text = GeoLocationController.Instance.GetCapForComune(Me.cboComune.Text)
        'End If

    End Sub
    Private Sub LoadDefaultData()
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia("MATERA"), True)
        Me.cboComune.Text = My.Settings.ComuneDefault
    End Sub

    Private Sub txtPIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPIva.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub GridSedi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridSedi.CellFormatting
        If GridSedi.Columns(e.ColumnIndex).Name.Equals("Indirizzo") Then
            If Not e.Value Is Nothing Then
                GridSedi.Rows(e.RowIndex).Cells("Provincia").Value = e.Value.Provincia.Descrizione
                GridSedi.Rows(e.RowIndex).Cells("Via").Value = e.Value.Via
                e.Value = e.Value.Comune.Descrizione
            End If
        End If
    End Sub

    Private Sub CmdAdd_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdAdd.DoClik
        Try
            frm = New FrmSediOperative("Add", controller)
            frm.ShowDialog()
            frm.Dispose()
            If GridSedi.DataSource Is Nothing Then
                LoadGrid(controller.GetListaSediOperative)
            Else
                GridSedi.DataSource = New ArrayList
                GridSedi.DataSource = controller.GetListaSediOperative
                '
                'LoadGrid(controller.GetListaSediOperative)
                GridSedi.Refresh()
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CmdDel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdDel.DoClik
        Try
            If Me.GridSedi.SelectedRows.Count = 0 Then Throw New Exception("Nessuna sede è stata selezionata. Selezionare una sede.")
            controller.RemoveSedeOperativa(GridSedi.SelectedRows(0).Cells("Descrizione").Value)
            Me.StartChangeOperation()
            GridSedi.DataSource = New ArrayList
            GridSedi.DataSource = controller.GetListaSediOperative
            '
            'LoadGrid(controller.GetListaSediOperative)
            GridSedi.Refresh()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
        Try
            If Me.GridSedi.SelectedRows.Count = 0 Then Throw New Exception("Nessuna sede operativa è stata selezionata. Selezionare una sede.")
            controller.SelectSedeOperativa(GridSedi.SelectedRows(0).Cells("Descrizione").Value)
            frm = New FrmSediOperative("View", controller)
            frm.ShowDialog()
            frm.Dispose()
            'GridEventi.Refresh()
            LoadGrid(controller.GetListaSediOperative)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub frm_SedeAdded() Handles frm.SedeAdded
        Me.StartChangeOperation()
    End Sub

    Private Sub frm_SedeUpdated() Handles frm.SedeUpdated
        Me.StartChangeOperation()
    End Sub

    Private Sub GridSedi_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridSedi.DataError
        ' If DirectCast(sender, DataGridView).Columns(e.ColumnIndex).Name = "Id" Then Return
    End Sub

    Private Sub View()
        Try
            Navigate(Me.IdAziendaTextBox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub PictureBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        View()
    End Sub



    Private Sub CmdAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Load

    End Sub

    'Private Sub cmdSeleziona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   If My.Settings.PathDefaultCartelleAziende <> "" Then
    '      FolderBrowserDialog1.SelectedPath = My.Settings.PathDefaultCartelleAziende
    '   End If
    '   If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
    '      Return
    '   End If

    '   txtCartella.Text = FolderBrowserDialog1.SelectedPath
    'End Sub

    'Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
    '   Try
    '      If txtCartella.Text <> "" Then
    '         Dim process As New Process
    '         Dim info As New ProcessStartInfo
    '         info.FileName = txtCartella.Text
    '         Diagnostics.Process.Start(info)
    '         process.Dispose()
    '      End If
    '   Catch ex As Exception
    '      MsgBox(ex.Message)
    '   End Try
    'End Sub

    'Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
    '   If Me.txtCartella.Text <> "" Then
    '      Dim frm As New FrmSpostaFile
    '      frm.Destination = txtCartella.Text
    '      frm.ShowDialog()
    '      frm.Dispose()
    '   Else
    '      MsgBox("Non è stata impostata alcuna cartella", MsgBoxStyle.Information, "Informazione")
    '   End If
    'End Sub

    Private Sub txtCartella_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    'Private Sub spDelPath_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs)
    '   txtCartella.Text = ""

    'End Sub

    'Private Sub SpCreateDir_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs)
    '   Dim pathDefault As String = ""

    '   If MsgBox("Sarà creata una cartella Aziende nel percorso predefinito dalle opzioni. Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Creazione cartella di default") = MsgBoxResult.Yes Then

    '      Dim NomeCartella As String = controller.Descrizione

    '      pathDefault = My.Settings.PathDefaultCartelleAziende

    '      If pathDefault = "" Then
    '         MsgBox("Non esiste un percorso di default per le cartelle Aziende", MsgBoxStyle.Information, "Informazione")
    '         Return
    '      End If

    '      pathDefault = pathDefault & "\" & NomeCartella

    '      If Not My.Computer.FileSystem.DirectoryExists(pathDefault) Then
    '         My.Computer.FileSystem.CreateDirectory(pathDefault)
    '         MsgBox("Directory creata con successo", MsgBoxStyle.Information, "Informazione")
    '         txtCartella.Text = pathDefault
    '      End If

    '   End If
    'End Sub


    Private Sub txtResp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResp.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtTelUf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelUf.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell1.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell2.TextChanged
        Me.StartChangeOperation()
    End Sub



    Private Sub SpNew_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
        Createnew()
    End Sub



    Private Sub txtCE_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCE.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtEC_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEC.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtNote_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub cmdCAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCAP.Click
        Me.txtCap.Text = GeoLocationFacade.Instance.GetCapForComune(Me.cboComune.Text)
    End Sub

    Private Sub cmdGoToOfferte1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoToOfferte1.Click
        Try
            Navigate(Me.IdAziendaTextBox1.TextValue, "ViewOfferte")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spIscritti1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spIscritti1.Click
        Try
            Dim frm As New FrmIscritti(controller.IdAzienda, controller.IdSettoreContratto)
            If frm.ShowDialog() = DialogResult.OK Then

                Me.Navigate(frm.Id, frm.Link)
            End If

            frm.Dispose()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spArchivio1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spArchivio1.Click
        Try
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            Dim frm As New FrmArchivioDocumentale(New ControllerArchivioDocumentale(controller.Current), FrmArchivioDocumentale.TypeOfTargetArchivio.Aziende)

            frm.ShowDialog()

            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spDoc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spDoc1.Click
        'Try
        '    NavigateTo("ViewCompilazioneModelli")
        'Catch ex As Exception
        '    ErrorHandler.ShowError(ex)
        'End Try
        Try
            ' NavigateTo("ViewCompilazioneModelli")
            Dim frm As New FrmCompilazioneModello()
            frm.Show()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub IdAziendaTextBox1_ReturnPressed() Handles IdAziendaTextBox1.ReturnPressed
        View()
    End Sub

    Private Sub ControlAnagraficaAzienda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If txtPIva.Visible Then
            txtNome.Focus()
        Else
            IdAziendaTextBox1.SetFocus()
        End If
    End Sub

    Private Sub cmdCantieri_Click(sender As Object, e As EventArgs) Handles cmdCantieri.Click

        If Me.State.StateName = "Visualizzazione" Then

            Dim frm As New FormCantieri(Me.IdShowedObject, txtNome.Text)
            frm.ShowDialog()

            frm.Dispose()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetDatiAzienda(txtNome.Text)
    End Sub
End Class











