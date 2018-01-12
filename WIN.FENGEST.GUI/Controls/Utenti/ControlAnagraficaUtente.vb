Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports WIN.APPLICATION
Imports WIN.GUI.PRINT
Imports WIN.DOMAIN.FEDERATIONARTIFACTS
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports System.IO
Imports WIN.APPLICATION.UTENTI
Imports System.Text
Imports System

<SecureContext()> _
Public Class ControlAnagraficaUtente
    Private controller As New UTENTI.ControllerUtenti(True)
    Dim WithEvents frmPreferenza As FrmPreferenza
    Dim WithEvents frmKnowHow As FrmAttitudine
    Dim WithEvents frminfo As FrmInfos
    Dim WithEvents frmIncarichi As FrmIncarichi
    Dim WithEvents frmfiglio As FrmFiglio
    Dim m_ClearCache As Boolean = False
    Private controllerSegreteria As New ControllerSegreteria

    Dim idAziendaImpiego As String
    Dim IdSoggetto As String





    Private Sub frmfiglio_InfoAdded() Handles frmfiglio.InfoAdded
        StartChangeOperation()
    End Sub

    Private Sub frmfiglio_InfoUpdate() Handles frmfiglio.InfoUpdate
        Me.StartChangeOperation()
    End Sub

    Private Sub LoadCboSex()
        cboSesso1.ComboBox1.Items.Add("MASCHIO")
        cboSesso1.ComboBox1.Items.Add("FEMMINA")
    End Sub

    Public Sub New()
        InitializeComponent()
        LoadCboSex()
        DoLoad()
        ToolTip1.SetToolTip(PictureBox1, lblFoto.Text)

      
        'ToolTip1.ShowAlways = True
    End Sub
    Public Sub New(ByVal IdUtente As Int32)
        InitializeComponent()
        LoadCboSex()
        Me.m_IdShowedObject = IdUtente

        DoLoad()
        ToolTip1.SetToolTip(PictureBox1, lblFoto.Text)
        'ToolTip1.ShowAlways = True

        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        End If
    End Sub
    <Secure(Area:="Utenti", Alias:="Creazione", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Utenti", Alias:="Aggiornamento", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Utenti", Alias:="Cancellazione", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub
    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Public Sub New(ByVal IdUtente As Int32, ByVal ClearCache As Boolean)
        InitializeComponent()
        LoadCboSex()
        Me.m_IdShowedObject = IdUtente
        m_ClearCache = ClearCache

        DoLoad()
        ToolTip1.SetToolTip(PictureBox1, lblFoto.Text)
        ' ToolTip1.ShowAlways = True

        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        End If
    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.CompleteName))
            cmdGoToDeleghe1.Visible = True
            cmdGoToDeleghe1.Enabled = False

            cmdGoToPrestazioni1.Visible = True
            cmdGoToPrestazioni1.Enabled = False

            cmdWeb.Visible = True
            cmdWeb.Enabled = False


            cmdSearchWeb.Visible = True
            cmdSearchWeb.Enabled = False

            cmdGoToVertenze1.Visible = True
            cmdGoToVertenze1.Enabled = False

            cmdTessera.Visible = True
            cmdTessera.Enabled = False

            cmdGoToComunicazioni1.Visible = True
            cmdGoToComunicazioni1.Enabled = False

            cmdGoToProposte1.Visible = True
            cmdGoToProposte1.Enabled = False


            spArchivio1.Visible = True
            spArchivio1.Enabled = False
            spQuoteUtente1.Visible = True
            spQuoteUtente1.Enabled = False

            spRiepilogoAttivita1.Enabled = False
            spRiepilogoAttivita1.Visible = True
            Me.spDoc1.Visible = True
            Me.spDoc1.Enabled = False

            cmdSms.Visible = False
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

    Protected Overrides Sub Nested_PostUpdateActions()
        cmdGoToDeleghe1.Visible = True
        cmdGoToDeleghe1.Enabled = True

        cmdTessera.Visible = True
        cmdTessera.Enabled = True

        cmdGoToPrestazioni1.Visible = True
        cmdGoToPrestazioni1.Enabled = True

        cmdWeb.Visible = True
        cmdWeb.Enabled = True

        cmdSearchWeb.Visible = True
        cmdSearchWeb.Enabled = True


        cmdGoToVertenze1.Visible = True
        cmdGoToVertenze1.Enabled = True

        cmdGoToComunicazioni1.Visible = True
        cmdGoToComunicazioni1.Enabled = True

        cmdGoToProposte1.Visible = True
        cmdGoToProposte1.Enabled = True

        spRiepilogoAttivita1.Enabled = True
        spRiepilogoAttivita1.Visible = True


        spArchivio1.Visible = True
        spArchivio1.Enabled = True
        spQuoteUtente1.Visible = True
        spQuoteUtente1.Enabled = True
        Me.spDoc1.Visible = True
        Me.spDoc1.Enabled = True


        cmdVerifica.Visible = True
        cmdVerifica.Enabled = True

        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        Else
            cmdSms.Visible = True
        End If
    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        GrpAnag.Visible = False
        NiceGroupBox1.Visible = False

        GrpQ.Visible = False
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Visible = True
        Me.IdUtenteTextBox1.Enabled = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        '   Me.CmdVis.Visible = True
        Me.CustomBar1.Visible = False
        Me.lblCurrentFunction.Text = UCase("Ricerca utente ")
        Me.cmdGoToDeleghe1.Visible = False
        cmdTessera.Visible = False
        cmdGoToPrestazioni1.Visible = False
        cmdGoToVertenze1.Visible = False
        Me.cmdGoToProposte1.Visible = False
        Me.cmdGoToComunicazioni1.Visible = False
        spQuoteUtente1.Visible = False

        spRiepilogoAttivita1.Visible = False
        SpNew.Visible = True
        'NiceGroupBox1.Visible = False
        Me.spDoc1.Visible = False
        spAddFoto1.Visible = False
        spViewFoto1.Visible = False
        spArchivio1.Visible = False
        SpDelFoto1.Visible = False
        PictureBox1.Visible = False
        'NiceFoto.Visible = False


    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        GrpAnag.Visible = True
        NiceGroupBox1.Visible = True
        GrpQ.Visible = True
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()
        ' Me.CmdVis.Visible = False
        Me.cmdGoToDeleghe1.Visible = False
        Me.CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)
        LoadDefaultData()
        Me.cmdGoToDeleghe1.Visible = True
        cmdGoToPrestazioni1.Visible = True
        cmdGoToVertenze1.Visible = True
        cmdTessera.Visible = True
        Me.cmdGoToProposte1.Visible = True
        Me.cmdGoToComunicazioni1.Visible = True
        GrpQ.Visible = True
        spQuoteUtente1.Visible = True
        ' NiceGroupBox1.Visible = True
        spAddFoto1.Visible = True
        SpNew.Visible = False
        spArchivio1.Visible = True
        spViewFoto1.Visible = True
        SpDelFoto1.Visible = True
        spRiepilogoAttivita1.Visible = True
        PictureBox1.Visible = True
        cmdVerifica.Visible = True
        cmdVerifica.Enabled = True
        'NiceFoto.Visible = True


        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        Else
            cmdSms.Visible = True
        End If
    End Sub
    Private Sub LoadDefaultData()
        InterfaceMediator.LoadUsabilityCombo(Me.cboNazionalita1, GeoLocationFacade.Instance.GetListaNazioni, False)
        Me.cboNazionalita1.TextValue = My.Settings.NazioneDefault


        Dim controllerFondi As New ControllerFondi
        InterfaceMediator.LoadCombo(cboFondo.ComboBox1, controllerFondi.GetListaCausali, True)

        LoadComboComuni(GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault))
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        Me.cboProvincia1.TextValue = My.Settings.ProvinciaDefault
        Me.cboComune1.TextValue = My.Settings.ComuneDefault
        Me.cboProvinciaResidenza1.TextValue = My.Settings.ProvinciaDefault
        Me.cboComuneResidenza1.TextValue = My.Settings.ComuneDefault
        Me.cboSesso1.ComboBox1.SelectedIndex = 0
        'InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationController.Instance.GetListaProvincie, True)
        'InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationController.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
        'InterfaceMediator.LoadCombo(Me.cboProvinciaResidenza, GeoLocationController.Instance.GetListaProvincie, True)
        'InterfaceMediator.LoadCombo(Me.cboComuneResidenza, GeoLocationController.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
    End Sub

    Private Sub LoadComboComuni(ByVal Lista As ArrayList)
        cboComuneResidenza1.ComboBox1.Items.Clear()
        cboComune1.ComboBox1.Items.Clear()
        For Each elem As String In Lista
            cboComuneResidenza1.ComboBox1.Items.Add(elem)
            cboComune1.ComboBox1.Items.Add(elem)
        Next
        cboComune1.ComboBox1.Sorted = True
        cboComuneResidenza1.ComboBox1.Sorted = True
        cboComuneResidenza1.ComboBox1.Items.Add("")
        cboComune1.ComboBox1.Items.Add("")

    End Sub
    Private Sub LoadComboProvincie(ByVal Lista As ArrayList)
        cboProvinciaResidenza1.ComboBox1.Items.Clear()
        cboProvincia1.ComboBox1.Items.Clear()
        For Each elem As String In Lista
            cboProvinciaResidenza1.ComboBox1.Items.Add(elem)
            cboProvincia1.ComboBox1.Items.Add(elem)
        Next
        cboProvinciaResidenza1.ComboBox1.Sorted = True
        cboProvincia1.ComboBox1.Sorted = True
        cboProvinciaResidenza1.ComboBox1.Items.Add("")
        cboProvincia1.ComboBox1.Items.Add("")
    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        lblSoggetto.Text = "---"
        lblSettore.Text = "---"
        lblPeriodo.Text = "---"
        lblAziendaImpiego.Text = "---"
        'Qui pulisco tutti i campi della maschera
        lblTessera.Text = "Tessera non stampata nell'anno in corso"
        PictureBox2.BackgroundImage = My.Resources.cal1
        dtpData1.DateTimePicker1.Value = Today
        cboSesso1.ComboBox1.Text = "MASCHIO"
        cboNazionalita1.ComboBox1.Text = "ITALIA"
        cboProvincia1.ComboBox1.Text = ""
        cboComune1.ComboBox1.Text = ""
        Me.txtCF1.TextValue = ""
        txtVia1.TextValue = ""
        txtCap1.TextValue = ""
        cboProvinciaResidenza1.ComboBox1.Text = ""
        cboComuneResidenza1.ComboBox1.Text = ""
        Me.txtFax1.TextValue = ""
        Me.txtCell11.TextValue = ""
        Me.txtCell21.TextValue = ""
        Me.txtTelAb1.TextValue = ""
        Me.txtTelUf1.TextValue = ""
        Me.txtMail1.TextValue = ""
        txtNome1.TextValue = ""
        txtCognome1.TextValue = ""
        Me.IdUtenteTextBox1.TextValue = ""
        ' Me.txtCartella.Text = ""
        Me.dtpData1.DateTimePicker1.Value = New DateTime(1900, 1, 1)

        If Me.GridAttitudini.DataSource IsNot Nothing Then
            Me.GridAttitudini.DataSource = New ArrayList
        End If
        If Me.GridInfo.DataSource IsNot Nothing Then
            Me.GridInfo.DataSource = New ArrayList
        End If
        If Me.GridPreferenze.DataSource IsNot Nothing Then
            Me.GridPreferenze.DataSource = New ArrayList
        End If
        If Me.GridFigli.DataSource IsNot Nothing Then
            Me.GridFigli.DataSource = New ArrayList
        End If
        If Me.GridTessere.DataSource IsNot Nothing Then
            Me.GridTessere.DataSource = New ArrayList
        End If

        cboFondo.Text = ""
        dtpIntervista.DataValue = DateTime.Now
        cboStatus.Text = ""
        IdReferenteTextBox1.TextValue = ""
        chkACarico.Checked = False
        chkCasa.Checked = False
        PictureBox1.BackgroundImage = My.Resources.kuser
        lblFoto.Text = ""
        txtNomeConiuge.TextValue = ""
        txtCognConiuge.TextValue = ""
        txtFiscaleConiuge.TextValue = ""
        txtNote.TextValue = ""
        txtCE.TextValue = ""
        txtEC.TextValue = ""
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        'If m_ClearCache Then
        controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
        '   m_ClearCache = False
        'Else
        '   controller.LoadById(Me.m_IdShowedObject)
        'End If




    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome1.TextValue = controller.Nome
        txtCognome1.TextValue = controller.Cognome
        dtpData1.DataValue = controller.DataNascita
        cboSesso1.TextValue = controller.Sesso
        txtCap1.TextValue = controller.CapResidenza
        '  txtCartella.vText = controller.CartellaPreferenziale
        cboNazionalita1.TextValue = controller.Nazionalita
        cboProvincia1.TextValue = controller.ProvinciaNascita
        cboComune1.TextValue = controller.ComuneNascita

        Me.txtCF1.TextValue = controller.CodiceFiscale
        txtVia1.TextValue = controller.ViaResidenza
        cboProvinciaResidenza1.TextValue = controller.ProvinciaResidenza
        cboComuneResidenza1.TextValue = controller.ComuneResidenza
        Me.txtFax1.TextValue = controller.Fax
        Me.txtCell11.TextValue = controller.Cellulare1
        Me.txtCell21.TextValue = controller.Cellulare2
        Me.txtTelAb1.TextValue = controller.TelefonoCasa
        Me.txtTelUf1.TextValue = controller.TelefonoUfficio
        Me.txtMail1.TextValue = controller.Mail
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente



        cboFondo.TextValue = controller.Fondo
        dtpIntervista.DataValue = controller.DataIntervista
        cboStatus.Text = controller.StatoCivile
        IdReferenteTextBox1.TextValue = controller.IdReferente
        chkACarico.Checked = controller.ConiugeACarico
        chkCasa.Checked = controller.CasaProprieta


        txtNomeConiuge.TextValue = controller.NomeConiuge
        txtCognConiuge.TextValue = controller.CognomeConiuge
        txtFiscaleConiuge.TextValue = controller.CoodiceFiscaleConiuge
        txtNote.TextValue = controller.Note
        txtCE.TextValue = controller.CodificaCE
        txtEC.TextValue = controller.CodificaEC



        If controller.HaStampatoTessera Then
            lblTessera.Text = "Tessera stampata nell'anno in corso"
            PictureBox2.BackgroundImage = My.Resources.cal
        Else
            lblTessera.Text = "Tessera non stampata nell'anno in corso"
            PictureBox2.BackgroundImage = My.Resources.cal1

        End If




        LoadGridPreferenze(controller.GetListaPreferenze)
        LoadGridCurriculum(controller.GetListaAttitudini)
        LoadGridInfos(controller.GetListaInfo)
        LoadGridIncarichi(controller.GetListaIcarichi)
        LoadGridFigli(controller.GetListaFigli)
        LoadGridTessere(controller.GetListaTessere)


        Dim controllerRef As New FINANCIAL_ARTIFACTS.ControllerReferenti

        InterfaceMediator.GetSimpleDescription(controllerRef, "CompleteName", IdReferenteTextBox1.DescriptionText, IdReferenteTextBox1.TextValue)


        LoadFoto(controller.PathFoto)

    End Sub
#End Region

    Private Sub LoadFoto(ByVal PathFoto As String)
        lblFoto.Text = PathFoto
        If My.Computer.FileSystem.FileExists(PathFoto) Then
            Try
                PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(PathFoto)
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
                PictureBox1.Invalidate()

            Catch ex As Exception
                MsgBox("Errore nel caricamento dell'immagine. " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Errore")
                PictureBox1.BackgroundImage = My.Resources.kuser
            End Try
        Else
            PictureBox1.BackgroundImage = My.Resources.kuser
        End If
    End Sub



#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = False
        NiceGroupBox1.Visible = False
        Me.lblId.Visible = False
        LoadDefaultData()
        'Me.CmdVis.Visible = False
        Me.CustomBar1.SetTargetControl(Me)
        Me.CustomBar1.Visible = True
        GrpAnag.Visible = True

        GrpQ.Visible = True
        Me.cmdGoToDeleghe1.Visible = False
        cmdGoToPrestazioni1.Visible = False
        cmdGoToVertenze1.Visible = False
        cmdTessera.Visible = False
        Me.cmdGoToComunicazioni1.Visible = False
        Me.cmdGoToProposte1.Visible = False
        GrpQ.Visible = True
        controller.CreateNew()
        spQuoteUtente1.Visible = False
        spArchivio1.Enabled = False
        spArchivio1.Visible = False
        SpNew.Visible = False
        spRiepilogoAttivita1.Enabled = False
        spRiepilogoAttivita1.Visible = False
        'SpAddFile.Disabled = True
        'SpCreateDir.Disabled = True

        spAddFoto1.Visible = True
        spViewFoto1.Visible = True
        SpDelFoto1.Visible = True
        PictureBox1.Visible = True
        'NiceFoto.Visible = True
        Me.spDoc1.Visible = False

        cmdVerifica.Visible = False
        cmdVerifica.Enabled = False


        cmdSms.Visible = False


    End Sub
#End Region




#Region "Metodi per il salvataggio"

    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewUtente", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, Optional ByVal ClearCache As Boolean = False)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("ClearCache", ClearCache)
            Me.NavigateTo("ViewUtente", ParameterList, True)
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
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Status As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("Status", Status)
            ParameterList.Add("IdUtente", Me.m_IdShowedObject)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub
    Public Overrides Sub Nested_InsertData()


        controller.Cognome = Me.txtCognome1.TextValue
        controller.Nome = Me.txtNome1.TextValue
        controller.SetQuotaMensile(0, controller.Valuta)
        controller.DataNascita = dtpData1.DateTimePicker1.Value
        controller.Sesso = cboSesso1.TextValue
        controller.SetNazionalita(cboNazionalita1.TextValue)
        controller.SetProvinciaNascita(cboProvincia1.TextValue)
        controller.SetComuneNascita(cboComune1.TextValue)
        controller.CodiceFiscale = Me.txtCF1.TextValue

        controller.SetResidenza(txtVia1.TextValue, cboProvinciaResidenza1.TextValue, cboComuneResidenza1.TextValue, txtCap1.TextValue)
        controller.SetComunicazione(Me.txtTelAb1.TextValue, Me.txtTelUf1.TextValue, Me.txtFax1.TextValue, Me.txtMail1.TextValue, Me.txtCell11.TextValue, Me.txtCell21.TextValue)
        controller.SetFondo(cboFondo.Text)
        controller.DataIntervista = dtpIntervista.DataValue
        controller.StatoCivile = cboStatus.Text
        controller.SetReferente(IdReferenteTextBox1.TextValue)
        controller.ConiugeACarico = chkACarico.Checked
        controller.CasaProprieta = chkCasa.Checked
        controller.PathFoto = lblFoto.Text

        controller.NomeConiuge = txtNomeConiuge.TextValue
        controller.CognomeConiuge = txtCognConiuge.TextValue
        controller.CoodiceFiscaleConiuge = txtFiscaleConiuge.TextValue
        controller.Note = txtNote.TextValue
        controller.CodificaCE = txtCE.TextValue
        controller.CodificaEC = txtEC.TextValue


        controller.Save()
        MyBase.m_IdShowedObject = controller.IdUtente

    End Sub
#End Region


#Region "Metodi per l'aggiornamento dell'utente"







    Public Overrides Sub Nested_UpdateData()
        controller.Cognome = Me.txtCognome1.TextValue
        controller.Nome = Me.txtNome1.TextValue
        controller.SetQuotaMensile(0, controller.Valuta)
        controller.DataNascita = dtpData1.DataValue
        controller.Sesso = cboSesso1.TextValue
        controller.SetNazionalita(cboNazionalita1.TextValue)
        controller.SetProvinciaNascita(cboProvincia1.TextValue)

        controller.SetComuneNascita(cboComune1.TextValue)
        controller.CodiceFiscale = Me.txtCF1.TextValue
        controller.SetResidenza(txtVia1.TextValue, cboProvinciaResidenza1.TextValue, cboComuneResidenza1.TextValue, txtCap1.TextValue)
        controller.SetComunicazione(Me.txtTelAb1.TextValue, Me.txtTelUf1.TextValue, Me.txtFax1.TextValue, Me.txtMail1.TextValue, Me.txtCell11.TextValue, Me.txtCell21.TextValue)

        controller.PathFoto = lblFoto.Text
        controller.SetFondo(cboFondo.Text)
        controller.DataIntervista = dtpIntervista.DataValue
        controller.StatoCivile = cboStatus.TextValue
        controller.SetReferente(IdReferenteTextBox1.TextValue)
        controller.ConiugeACarico = chkACarico.Checked
        controller.CasaProprieta = chkCasa.Checked

        controller.NomeConiuge = txtNomeConiuge.TextValue
        controller.CognomeConiuge = txtCognConiuge.TextValue
        controller.CoodiceFiscaleConiuge = txtFiscaleConiuge.TextValue
        controller.Note = txtNote.TextValue
        controller.CodificaCE = txtCE.TextValue
        controller.CodificaEC = txtEC.TextValue


        If controller.CartellaPreferenziale = "" Then
            controllerSegreteria.LoadById(1)
            controller.CartellaPreferenziale = controllerSegreteria.DirectoryPreferenzialeUtenti
        End If

        controller.Save()
    End Sub
#End Region




    Private Sub ViewSelectedElement()
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        ViewSelectedElement()
    End Sub

    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        DoDelete()
    End Sub

    Public Overrides Sub DoDelete()
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("L'utente sarà eliminato solamente se nel sistema non ci sono altri riferimenti all'utente. Sicuro di voler cancellare l'utente selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                Navigate(-1)
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick

        GetInfo()

    End Sub

    Public Overrides Sub GetInfo()
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        CreateObject()
    End Sub
    Public Sub CreateObject()
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
                Navigate(Me.IdUtenteTextBox1.TextValue, True)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintUtente(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewUtente", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        NiceGroupBox1.Visible = True
        Me.AddCommandToHistory()
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
        Me.lblId.Visible = True
        cmdGoToDeleghe1.Visible = True
        cmdGoToDeleghe1.Enabled = True

        cmdGoToPrestazioni1.Visible = True
        cmdGoToPrestazioni1.Enabled = True

        cmdWeb.Visible = True
        cmdWeb.Enabled = True

        cmdSearchWeb.Visible = True
        cmdSearchWeb.Enabled = True


        cmdGoToVertenze1.Visible = True
        cmdGoToVertenze1.Enabled = True

        cmdTessera.Visible = True
        cmdTessera.Enabled = True

        cmdGoToComunicazioni1.Visible = True
        cmdGoToComunicazioni1.Enabled = True

        cmdGoToProposte1.Visible = True
        cmdGoToProposte1.Enabled = True
        spArchivio1.Visible = True
        spArchivio1.Enabled = True
        spQuoteUtente1.Visible = True
        spQuoteUtente1.Enabled = True
        SpNew.Visible = False
        spRiepilogoAttivita1.Enabled = True
        spRiepilogoAttivita1.Visible = True

        Me.spDoc1.Visible = True
        Me.spDoc1.Enabled = True

        cmdVerifica.Visible = True
        cmdVerifica.Enabled = True
        'SpAddFile.Disabled = False
        'SpCreateDir.Disabled = False
        'NiceGroupBox1.Visible = True

        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        Else
            cmdSms.Visible = True
        End If
    End Sub





    'Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
    '   Try
    '      If txtCartella.Text <> "" Then
    '         'Dim process As New Process
    '         'Dim info As New ProcessStartInfo
    '         'info.FileName = txtCartella.Text
    '         'Diagnostics.Process.Start(info)
    '         'process.Dispose()
    '         ElectronicDocument.ViewPath(txtCartella.Text)

    '      End If
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try

    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   If My.Settings.PathDefaultCartelleUtenti <> "" Then
    '      FolderBrowserDialog1.SelectedPath = My.Settings.PathDefaultCartelleUtenti
    '   End If
    '   If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
    '      Return
    '   End If

    '   txtCartella.Text = FolderBrowserDialog1.SelectedPath
    'End Sub

    'Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpAddFile.DoClik
    '   If Me.txtCartella.Text <> "" Then
    '      Dim frm As New FrmSpostaFile
    '      frm.Destination = txtCartella.Text
    '      frm.ShowDialog()
    '      frm.Dispose()
    '   Else
    '      MsgBox("Non è stata impostata alcuna cartella personale", MsgBoxStyle.Information, "Informazione")
    '   End If
    'End Sub




    Private Sub txtCartella_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub


    Private Sub SelectOfferte()
        Try

            If Me.GridPreferenze.SelectedRows.Count = 0 Then Throw New Exception("Nessuna preferenza è stata selezionata. Selezionare una preferenza.")
            controller.SelectPreferenza(GridPreferenze.SelectedRows(0).Cells("Abilita").Value.Descrizione, DirectCast(GridPreferenze.SelectedRows(0).Cells("Data").Value, DateTime))
            frmPreferenza = New FrmPreferenza("View", controller) '
            frmPreferenza.ShowDialog()
            frmPreferenza.Dispose()
            LoadGridPreferenze(controller.GetListaPreferenze)

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SelectProfessioni()
        Try
            If Me.GridAttitudini.SelectedRows.Count = 0 Then Throw New Exception("Nessun know how è stata selezionato. Selezionare un know how.")
            controller.SelectAttitudine(GridAttitudini.SelectedRows(0).Cells("Abilita").Value.Descrizione)
            frmKnowHow = New FrmAttitudine("View", controller) '
            frmKnowHow.ShowDialog()
            frmKnowHow.Dispose()
            LoadGridCurriculum(controller.GetListaAttitudini)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub SelectLiberi()
        Try
            If Me.GridInfo.SelectedRows.Count = 0 Then Throw New Exception("Nessuna info è stata selezionata. Selezionare una info.")
            controller.SelectInfo(GridInfo.SelectedRows(0).Cells("AziendaImpiego").Value.Id, GridInfo.SelectedRows(0).Cells("Ente").Value.Id, GridInfo.SelectedRows(0).Cells("DataImportazione").Value, GridInfo.SelectedRows(0).Cells("LiberoAl").Value)
            frminfo = New FrmInfos("View", controller) '
            frminfo.ShowDialog()
            frminfo.Dispose()
            LoadGridInfos(controller.GetListaInfo)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub SelectSituazione()
        Try
            If Me.GridFigli.SelectedRows.Count = 0 Then Throw New Exception("Nessuna riga è stata selezionata. Selezionare una riga.")
            controller.SelectFiglio(GridFigli.SelectedRows(0).DataBoundItem.GetHashCode)
            frmfiglio = New FrmFiglio("View", controller) '
            frmfiglio.ShowDialog()
            frmfiglio.Dispose()
            LoadGridFigli(controller.GetListaFigli)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub frmPreferenza_PreferenzaAdded() Handles frmPreferenza.PreferenzaAdded
        Me.StartChangeOperation()
    End Sub

    Private Sub frmPreferenza_PreferenzaUpdated() Handles frmPreferenza.PreferenzaUpdated
        Me.StartChangeOperation()
    End Sub
    Public Sub LoadGridFigli(ByVal Lista As IList)
        With GridFigli
            If Lista.Count > 0 Then
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Utente").Visible = False
                .Columns("NonCancellabile").Visible = False


                .Columns("Nome").DisplayIndex = 0
                .Columns("Nome").ReadOnly = True

                .Columns("Cognome").DisplayIndex = 1
                .Columns("Cognome").ReadOnly = True

                .Columns("DataNascita").DisplayIndex = 2
                .Columns("DataNascita").ReadOnly = True


                .Columns("CodiceFiscale").DisplayIndex = 3
                .Columns("CodiceFiscale").ReadOnly = True

                .Columns("Scuola").DisplayIndex = 4
                .Columns("Scuola").ReadOnly = True


                .Columns("AnnoFrequenza").DisplayIndex = 5
                .Columns("AnnoFrequenza").HeaderText = "Anno frequenazione"
                .Columns("AnnoFrequenza").ReadOnly = True


                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub



    Public Sub LoadGridTessere(ByVal Lista As IList)
        With GridTessere
            If Lista.Count > 0 Then
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Utente").Visible = False
                .Columns("NonCancellabile").Visible = False
                .Columns("DataTesseramento").DisplayIndex = 0
                .Columns("DataTesseramento").HeaderText = "Data tesseramento"
                .Columns("DataTesseramento").ReadOnly = True

                .Columns("StampataDa").DisplayIndex = 1
                .Columns("StampataDa").HeaderText = "Stampata da"
                .Columns("StampataDa").ReadOnly = True



                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub





    Public Sub LoadGridPreferenze(ByVal Lista As IList)
        With GridPreferenze
            If Lista.Count > 0 Then
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Utente").Visible = False
                .Columns("NonCancellabile").Visible = False
                .Columns("Data").DisplayIndex = 0
                .Columns("Data").ReadOnly = True

                .Columns("Abilita").DisplayIndex = 1
                .Columns("Abilita").HeaderText = "Skill"
                .Columns("Abilita").ReadOnly = True


                .Columns("Priorita").DisplayIndex = 2
                .Columns("Priorita").ReadOnly = True

                .Columns("Note").DisplayIndex = 3
                .Columns("Note").ReadOnly = True



                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub
    Public Sub LoadGridInfos(ByVal Lista As IList)
        With GridInfo
            If Lista.Count > 0 Then
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Utente").Visible = False
                .Columns("NonCancellabile").Visible = False


                .Columns("LiberoAl").DisplayIndex = 0
                .Columns("LiberoAl").HeaderText = "Libero al"
                .Columns("LiberoAl").ReadOnly = True


                .Columns("AziendaImpiego").DisplayIndex = 1
                .Columns("AziendaImpiego").HeaderText = "Azienda impiego"
                .Columns("AziendaImpiego").CellTemplate.Style.Font = New Font(.Columns("AziendaImpiego").DataGridView.Font, FontStyle.Underline)
                .Columns("AziendaImpiego").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
                .Columns("AziendaImpiego").ReadOnly = True

                .Columns("LivelloInquadramento").DisplayIndex = 2
                .Columns("LivelloInquadramento").HeaderText = "Livello inquadramento"
                .Columns("LivelloInquadramento").ReadOnly = True

                .Columns("Ente").DisplayIndex = 3
                .Columns("Ente").HeaderText = "Ente bilaterale"
                .Columns("Ente").ReadOnly = True


                .Columns("DataImportazione").DisplayIndex = 3
                .Columns("DataImportazione").HeaderText = "Data importazione"
                .Columns("DataImportazione").ReadOnly = True



                '.Columns("Livello").DisplayIndex = 2
                '.Columns("Livello").ReadOnly = True


                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub

    Public Sub LoadGridCurriculum(ByVal Lista As IList)
        With GridAttitudini
            If Lista.Count > 0 Then
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Utente").Visible = False

                .Columns("NonCancellabile").Visible = False

                .Columns("Abilita").DisplayIndex = 1
                .Columns("Abilita").HeaderText = "Skill"
                .Columns("Abilita").ReadOnly = True


                .Columns("Livello").DisplayIndex = 2
                .Columns("Livello").ReadOnly = True

                .Columns("Note").DisplayIndex = 3
                .Columns("Note").ReadOnly = True


                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub


    Private Sub GridPreferenze_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPreferenze.CellMouseDoubleClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If

            SelectOfferte()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridPreferenze_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridPreferenze.DataError
        If TypeOf (e.Exception) Is IndexOutOfRangeException Then
            '
        End If
    End Sub

    Private Sub frmKnowHow_KmowHowUpdated() Handles frmKnowHow.KmowHowUpdated
        Me.StartChangeOperation()
    End Sub

    Private Sub frmKnowHow_KnowHowAdded() Handles frmKnowHow.KnowHowAdded
        Me.StartChangeOperation()
    End Sub

    Private Sub GridAttitudini_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridAttitudini.CellMouseDoubleClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If



            SelectProfessioni()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridAttitudini_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridAttitudini.DataError
        If TypeOf (e.Exception) Is IndexOutOfRangeException Then
            '
        End If
    End Sub






    Private Sub frminfo_InfoAdded() Handles frminfo.InfoAdded
        StartChangeOperation()
    End Sub

    Private Sub frminfo_InfoUpdate() Handles frminfo.InfoUpdate
        Me.StartChangeOperation()
    End Sub

    Private Sub GridInfo_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridInfo.CellMouseDoubleClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If

            If e.ColumnIndex = 3 Then
                Navigate(GridInfo.Rows(e.RowIndex).DataBoundItem.AziendaImpiego.Id, "ViewAzienda")
                Return
            End If

            SelectLiberi()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridInfo_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridInfo.DataError
        If TypeOf (e.Exception) Is ArgumentOutOfRangeException Then
            '
        End If
    End Sub

    'Private Sub spDelPath_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles spDelPath.DoClik
    '   txtCartella.Text = ""
    'End Sub

    'Private Sub SpCreateDir_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs)
    '   Try


    '      Dim pathDefault As String = ""


    '      If MsgBox("Sarà creata una cartella utente nel percorso predefinito dalle opzioni. Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Creazione cartella di default") = MsgBoxResult.Yes Then

    '         pathDefault = My.Settings.PathDefaultCartelleUtenti

    '         Dim NomeCartella As String = controller.CreaNomeCartellaUtente()


    '         If Not My.Computer.FileSystem.DirectoryExists(pathDefault & "\" & NomeCartella) Then
    '            controller.CreaDirectoryUtente(pathDefault)
    '            MsgBox("Directory creata con successo", MsgBoxStyle.Information, "Informazione")
    '            txtCartella.Text = pathDefault & "\" & NomeCartella
    '         Else
    '            If MsgBox("Esiste una cartella per l'utente. Impostarla come cartella preferenziale?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Informazione") = MsgBoxResult.Yes Then
    '               txtCartella.Text = pathDefault & "\" & NomeCartella
    '            End If
    '         End If


    '      End If
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try
    'End Sub







    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal TipoDocumento As String, ByVal Link As String, ByVal Dummy As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        ParameterList.Add("TipoDocumento", TipoDocumento)
        Me.NavigateTo(Link, ParameterList)

    End Sub




    Private Sub cboFondo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub



    Private Sub chkCasa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCasa.CheckedChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub chkACarico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkACarico.CheckedChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub GridFigli_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridFigli.CellMouseDoubleClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If


            SelectSituazione()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridFigli_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        If TypeOf (e.Exception) Is IndexOutOfRangeException Then
            '
        End If
    End Sub


    'Private Sub cboFondo_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFondo.SelectedIndexChanged
    '   Me.Change()
    'End Sub


    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        ToolTip1.AutomaticDelay = 200

        ToolTip1.AutoPopDelay = 15000
        ToolTip1.Active = True
        ToolTip1.ShowAlways = True
        ToolTip1.Show(Text, lblFoto)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave

        ToolTip1.RemoveAll()

    End Sub


    Private Sub SpNew_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
        CreateObject()

    End Sub

    Private Sub IdUtenteTextBox1_SearchDataRequired() Handles IdUtenteTextBox1.SearchDataRequired
        IdUtenteTextBox1.SearchData()
    End Sub

    Private Sub ControlAnagraficaUtente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If txtCognome1.Visible Then
            txtCognome1.Focus()
        Else
            IdUtenteTextBox1.SetFocus()
        End If

        'IdReferenteTextBox1.DescriptionTextWidth = 147
        'IdReferenteTextBox1.IsDescriptionVisible = True
        cboStatus.ComboBox1.Items.Add("")
        cboStatus.ComboBox1.Items.Add("Celibe-Nubile")
        cboStatus.ComboBox1.Items.Add("Coniugato")
        cboStatus.ComboBox1.Items.Add("Separato")
        'cboStatus.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        'cboFondo.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        'txtNote.TextBox1.Multiline = True
        'txtNote.TextBox1.Size = New Size(txtNote.TextBox1.Width, 60)

    End Sub


    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Try

            Select Case GeneralTab.SelectedTab.Name
                Case "TabIncarichi"
                    'Agguinta preferenza 
                    frmIncarichi = New FrmIncarichi("Add", controller)
                    frmIncarichi.ShowDialog()
                    frmIncarichi.Dispose()
                    If gridIncarichi.DataSource Is Nothing Then
                        LoadGridIncarichi(controller.GetListaIcarichi)
                    Else
                        gridIncarichi.DataSource = New ArrayList
                        gridIncarichi.DataSource = controller.GetListaIcarichi
                        gridIncarichi.Refresh()
                    End If
                Case "TabOfferte"
                    'Agguinta preferenza 
                    frmPreferenza = New FrmPreferenza("Add", controller)
                    frmPreferenza.ShowDialog()
                    frmPreferenza.Dispose()
                    If GridPreferenze.DataSource Is Nothing Then
                        LoadGridPreferenze(controller.GetListaPreferenze)
                    Else
                        GridPreferenze.DataSource = New ArrayList
                        GridPreferenze.DataSource = controller.GetListaPreferenze
                        GridPreferenze.Refresh()
                    End If

                Case "TabProfessioni"
                    'aggiunta attitudine
                    frmKnowHow = New FrmAttitudine("Add", controller)
                    frmKnowHow.ShowDialog()
                    frmKnowHow.Dispose()
                    If GridAttitudini.DataSource Is Nothing Then
                        LoadGridCurriculum(controller.GetListaAttitudini)
                    Else
                        GridAttitudini.DataSource = New ArrayList
                        GridAttitudini.DataSource = controller.GetListaAttitudini
                        GridAttitudini.Refresh()
                    End If
                Case "TabLiberi"
                    'Agguinta info
                    frminfo = New FrmInfos("Add", controller)
                    frminfo.ShowDialog()
                    frminfo.Dispose()
                    If GridInfo.DataSource Is Nothing Then
                        LoadGridInfos(controller.GetListaInfo)
                    Else
                        GridInfo.DataSource = New ArrayList
                        GridInfo.DataSource = controller.GetListaInfo
                        GridInfo.Refresh()
                    End If

            End Select

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDel.Click
        Try
            Select Case GeneralTab.SelectedTab.Name
                Case "TabIncarichi"
                    'Rimozione preferenza 


                    If Me.gridIncarichi.SelectedRows.Count = 0 Then Throw New Exception("Nessun incarico è stato selezionato. Selezionare un incarico.")
                    controller.RemoveIncarico(gridIncarichi.SelectedRows(0).Cells("TipoIncarico").Value.Descrizione)
                    Me.StartChangeOperation()
                    gridIncarichi.DataSource = New ArrayList
                    gridIncarichi.DataSource = controller.GetListaIcarichi
                    gridIncarichi.Refresh()
                Case "TabOfferte"
                    'Rimozione preferenza 


                    If Me.GridPreferenze.SelectedRows.Count = 0 Then Throw New Exception("Nessuna preferenza è stata selezionata. Selezionare una preferenza.")
                    controller.RemovePreferenza(GridPreferenze.SelectedRows(0).Cells("Abilita").Value.Descrizione, DirectCast(GridPreferenze.SelectedRows(0).Cells("Data").Value, DateTime))
                    Me.StartChangeOperation()
                    GridPreferenze.DataSource = New ArrayList
                    GridPreferenze.DataSource = controller.GetListaPreferenze
                    GridPreferenze.Refresh()

                Case "TabProfessioni"
                    'rimozione attitudine
                    If Me.GridAttitudini.SelectedRows.Count = 0 Then Throw New Exception("Nessun know how è  stata selezionata. Selezionare un know how.")
                    controller.RemoveAttitudine(GridAttitudini.SelectedRows(0).Cells("Abilita").Value.Descrizione)
                    Me.StartChangeOperation()
                    GridAttitudini.DataSource = New ArrayList
                    GridAttitudini.DataSource = controller.GetListaAttitudini
                    GridAttitudini.Refresh()

                Case "TabLiberi"
                    If Me.GridInfo.SelectedRows.Count = 0 Then Throw New Exception("Nessuna info è stata selezionata. Selezionare una info.")
                    controller.RemoveInfo(GridInfo.SelectedRows(0).Cells("AziendaImpiego").Value.Id, GridInfo.SelectedRows(0).Cells("Ente").Value.Id, GridInfo.SelectedRows(0).Cells("DataImportazione").Value, GridInfo.SelectedRows(0).Cells("LiberoAl").Value)
                    Me.StartChangeOperation()
                    GridInfo.DataSource = New ArrayList
                    GridInfo.DataSource = controller.GetListaInfo
                    GridInfo.Refresh()

                Case "TabSituazione"

                    If Me.GridFigli.SelectedRows.Count = 0 Then Throw New Exception("Nessuna riga è stata selezionata. Selezionare una riga.")
                    controller.RemoveFiglio(GridFigli.SelectedRows(0).DataBoundItem.GetHashCode)
                    Me.StartChangeOperation()
                    GridFigli.DataSource = New ArrayList
                    GridFigli.DataSource = controller.GetListaFigli


            End Select
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub cmdGoToDeleghe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoToDeleghe1.Click
        Me.Navigate(Me.IdShowedObject, "OpenDeleghe")
    End Sub

    Private Sub cmdGoToPrestazioni1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoToPrestazioni1.Click
        Try
            Dim hash As New Hashtable
            hash.Add("Id", Me.m_IdShowedObject)

            Me.NavigateTo("OpenPrestazioni", hash, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub cmdGoToVertenze1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoToVertenze1.Click
        Me.Navigate(Me.IdShowedObject, "OpenVertenze")
    End Sub

    Private Sub cmdGoToComunicazioni1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoToComunicazioni1.Click
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewComunicazioni")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdGoToProposte1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoToProposte1.Click
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewProposte")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spArchivio1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spArchivio1.Click
        Try
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            Dim frm As New FrmArchivioDocumentale(New ControllerArchivioDocumentale(controller.Current), FrmArchivioDocumentale.TypeOfTargetArchivio.Utenti)

            frm.ShowDialog()

            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spRiepilogoAttivita1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spRiepilogoAttivita1.Click
        Try

            Me.Navigate(Me.IdShowedObject, "OpenPratiche")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spQuoteUtente1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spQuoteUtente1.Click
        Try
            Dim frm As New FrmQuoteUtente(Me.m_IdShowedObject)
            If frm.ShowDialog() = DialogResult.OK Then
                If frm.TipoDoc <> "" Then
                    Navigate(frm.Id, frm.TipoDoc, frm.Link, "")
                Else
                    Me.Navigate(frm.Id, frm.Link)
                End If

            End If
            frm.Dispose()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub spDoc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spDoc1.Click
        Try
            ' NavigateTo("ViewCompilazioneModelli")
            Dim frm As New FrmCompilazioneModello(IdShowedObject)
            frm.Show()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try



    End Sub

    Private Sub spAddFoto1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spAddFoto1.Click
        Try
            Dim frm As New FrmAllegaFile()
            frm.Destination = controller.CartellaPreferenziale
            Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog

            If dialog = Windows.Forms.DialogResult.OK Then
                LoadFoto(frm.FileName)
                Me.StartChangeOperation()
            End If
            frm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub SpDelFoto1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpDelFoto1.Click
        lblFoto.Text = ""
        PictureBox1.BackgroundImage = My.Resources.kuser
        Me.StartChangeOperation()
    End Sub

    Private Sub spViewFoto1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spViewFoto1.Click
        Try
            If lblFoto.Text = "" Then Throw New ArgumentException("Nome file vuoto")
            If Not System.IO.File.Exists(lblFoto.Text) Then Throw New ArgumentException("File inesistente")
            Dim pInfo As New ProcessStartInfo()
            pInfo.FileName = lblFoto.Text
            pInfo.UseShellExecute = True
            Dim p As Process = Process.Start(pInfo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub


    Private Sub txtCognome1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCognome1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtNome1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCF1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCF1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtVia1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVia1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCap1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCap1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell11_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCell11.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell21_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCell21.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtFax1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFax1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtMail1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMail1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtTelAb1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelAb1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtTelUf1_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelUf1.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub cboSesso1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboSesso1.SelectedIndexChange
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpData1_ValueChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpData1.ValueChange
        Me.StartChangeOperation()
    End Sub

    Private Sub cboNazionalita1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboNazionalita1.SelectedIndexChange
        Me.StartChangeOperation()
        If Me.cboNazionalita1.ComboBox1.Text <> "ITALIA" Then
            Me.cboComune1.OverridedEnable = False
            Me.cboProvincia1.OverridedEnable = False
        Else
            Me.cboComune1.OverridedEnable = True
            Me.cboProvincia1.OverridedEnable = True
        End If
    End Sub

    Private Sub cboProvincia1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboProvincia1.SelectedIndexChange
        Me.StartChangeOperation()
        InterfaceMediator.LoadUsabilityCombo(Me.cboComune1, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia1.ComboBox1.Text), True)
        cboComune1.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub cboProvinciaResidenza1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboProvinciaResidenza1.SelectedIndexChange
        Me.StartChangeOperation()
        InterfaceMediator.LoadUsabilityCombo(Me.cboComuneResidenza1, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvinciaResidenza1.ComboBox1.Text), True)
        cboComuneResidenza1.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub cboComuneResidenza1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboComuneResidenza1.SelectedIndexChange
        Me.StartChangeOperation()
        'If Me.txtCap1.TextValue = "" Then
        '    Me.txtCap1.TextValue = GeoLocationController.Instance.GetCapForComune(Me.cboComuneResidenza1.ComboBox1.Text)
        'End If

    End Sub

    Private Sub cboComune1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboComune1.SelectedIndexChange
        Me.StartChangeOperation()
    End Sub

    Private Sub SpCf_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpCf.Click
        Try
            Me.txtCF1.TextValue = GeoLocationFacade.Instance.CalcolaCodiceFiscale(txtNome1.TextValue, txtCognome1.TextValue, cboSesso1.ComboBox1.Text, Me.dtpData1.DateTimePicker1.Value, cboComune1.ComboBox1.Text, Me.cboNazionalita1.ComboBox1.Text)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim tc As TabControl = DirectCast(sender, TabControl)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        sf.HotkeyPrefix = Drawing.Text.HotkeyPrefix.Show
        If tc.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(SystemBrushes.Control, e.Bounds)
        End If
        e.Graphics.DrawString(tc.TabPages(e.Index).Text, tc.Font, SystemBrushes.ControlText, RectangleF.op_Implicit(e.Bounds), sf)
        sf.Dispose()

    End Sub


    Private Sub IdReferenteTextBox1_TextBoxChanged_1() Handles IdReferenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub



    Private Sub txtCognConiuge_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCognConiuge.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtNomeConiuge_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomeConiuge.TextChange
        Me.StartChangeOperation()
    End Sub

    Private Sub txtFiscaleConiuge_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiscaleConiuge.TextChange
        Me.StartChangeOperation()
    End Sub


    Private Sub dtpIntervista_ValueChange_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpIntervista.ValueChange
        Me.StartChangeOperation()
    End Sub

    Private Sub cboStatus_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChange
        Me.StartChangeOperation()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            frmfiglio = New FrmFiglio("Add", controller)
            frmfiglio.ShowDialog()
            frmfiglio.Dispose()
            If GridFigli.DataSource Is Nothing Then
                LoadGridFigli(controller.GetListaFigli)
            Else
                GridFigli.DataSource = New ArrayList
                GridFigli.DataSource = controller.GetListaFigli
                GridFigli.Refresh()
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If Me.GridFigli.SelectedRows.Count = 0 Then Throw New Exception("Nessuna riga è stata selezionata. Selezionare una riga.")
            controller.RemoveFiglio(GridFigli.SelectedRows(0).DataBoundItem.GetHashCode)
            Me.StartChangeOperation()
            GridFigli.DataSource = New ArrayList
            GridFigli.DataSource = controller.GetListaFigli

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridFigli_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridFigli.DataError
        If TypeOf (e.Exception) Is IndexOutOfRangeException Then
            '
        End If
    End Sub



    Private Sub GridFigli_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridFigli.KeyDown
        If e.KeyCode = Keys.Return Then
            SelectSituazione()
        End If
    End Sub

    Private Sub GridInfo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridInfo.KeyDown
        If e.KeyCode = Keys.Return Then
            SelectLiberi()
        End If
    End Sub

    Private Sub GridAttitudini_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridAttitudini.KeyDown
        If e.KeyCode = Keys.Return Then
            SelectProfessioni()
        End If
    End Sub

    Private Sub GridPreferenze_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridPreferenze.KeyDown
        If e.KeyCode = Keys.Return Then
            SelectOfferte()
        End If
    End Sub


    Private Sub cmdTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab1.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub cmdTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab2.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub cmdTab3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab3.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub cmdTab4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab4.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub cboFondo_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboFondo.SelectedIndexChange
        Me.StartChangeOperation()
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

    Private Sub cmdTab5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab5.Click
        TabControl1.SelectedIndex = 4
    End Sub

    Private Sub cmdTab6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab6.Click
        GeneralTab.SelectedIndex = 0
    End Sub

    Private Sub cmdTab7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab7.Click
        GeneralTab.SelectedIndex = 1
    End Sub

    Private Sub cmdTab8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab8.Click
        GeneralTab.SelectedIndex = 2
    End Sub

    Private Sub cmdTab9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab9.Click
        GeneralTab.SelectedIndex = 3
    End Sub

    Private Sub cmdTab10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTab10.Click
        GeneralTab.SelectedIndex = 4
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim datoFiscale As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(txtCF1.TextValue)
            Dim frm As New FrmDatiFiscali(datoFiscale)
            If frm.ShowDialog() = DialogResult.OK Then

                cboNazionalita1.TextValue = frm.DatiFiscali.Nazione.Descrizione
                cboProvincia1.TextValue = frm.DatiFiscali.Provincia.Descrizione
                cboComune1.TextValue = frm.DatiFiscali.Comune.Descrizione
                cboSesso1.TextValue = frm.txtSesso.Text
                If frm.DatiFiscali.DataNascita <> DateTime.MinValue Then
                    dtpData1.DataValue = frm.DatiFiscali.DataNascita
                End If
            End If

            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdVerifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerifica.Click

        Try
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere costruzione riepilogo...", My.Resources.Waiting3)

            Dim reportStato As New ReportRiepilogativoUtente
            reportStato.SetEticheteRiepiloghi(lblAziendaImpiego, lblSettore, lblPeriodo, lblSoggetto, controller.IdUtente)

            reportStato.SetEticheteIscrizione(lblIscrizione, PictureBox3, controller.IdUtente)

            idAziendaImpiego = reportStato.IdAziendaImpiego
            IdSoggetto = reportStato.IdSoggetto

            cmdVerifica.Visible = False

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try
    End Sub

    Private Sub lblAziendaImpiego_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblAziendaImpiego.MouseDoubleClick
        Try
            Navigate(idAziendaImpiego, "ViewAzienda")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lblSoggetto_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblSoggetto.MouseDoubleClick
        Try
            If lblSettore.Text = "EDILE" Then
                Navigate(IdSoggetto, "ViewEnte")
            Else
                Navigate(IdSoggetto, "ViewAzienda")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub cmdCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCap.Click
        Me.txtCap1.TextValue = GeoLocationFacade.Instance.GetCapForComune(Me.cboComuneResidenza1.ComboBox1.Text)
    End Sub

    Private Sub cmdFiscCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiscCon.Click
        Try
            Dim frmcalc As New FrmCacolatoreCF(txtCognConiuge.TextValue, txtNomeConiuge.TextValue, DateTime.Now)

            If frmcalc.ShowDialog = DialogResult.OK Then
                If Not String.IsNullOrEmpty(frmcalc.CodiceFiscale) Then
                    txtFiscaleConiuge.TextValue = frmcalc.CodiceFiscale
                End If
            End If

            frmcalc.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub IdUtenteTextBox1_ReturnPressed() Handles IdUtenteTextBox1.ReturnPressed
        ViewSelectedElement()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTessera.Click
        Try

            'verifico l'iscrizione del lavoratore

            WIN.GUI.UTILITY.Helper.ShowWaitBox("Verifica iscrizione in corso...", My.Resources.Waiting3)

            Dim reportStato As New ReportRiepilogativoUtente
            reportStato.SetEticheteRiepiloghi(lblAziendaImpiego, lblSettore, lblPeriodo, lblSoggetto, controller.IdUtente)

            reportStato.SetEticheteIscrizione(lblIscrizione, PictureBox3, controller.IdUtente)


            idAziendaImpiego = reportStato.IdAziendaImpiego
            IdSoggetto = reportStato.IdSoggetto

            cmdVerifica.Visible = False

            WIN.GUI.UTILITY.Helper.HideWaitBox()

            If Not reportStato.Iscritto Then

                If MessageBox.Show("Il lavoratore non risulta iscritto. Procedere comunque?", "Messaggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    StampaTessera(reportStato.AziendaImpiego)

                End If

            Else


                StampaTessera(reportStato.AziendaImpiego)

            End If



        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try




    End Sub


    Private Sub StampaTessera(ByVal azienda As String)
        'riempio la tabella per la stampa
        controller.StampaTesseraUtente(azienda)




        'Apro il centro stampa tessere

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

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWeb.Click
        Try



            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
            'Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
            'Dim f As New IO.FileInfo(path)
            'path = f.DirectoryName + exportProgram

            Dim exportProgram As String = "\WIN.SCHEDULING_APPLICATION.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.FullName + exportProgram

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalità non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If



            'definisco i parametri di apertura del programma
            Dim args As New ProcessStartInfo
            args.Arguments = SecurityManager.Instance.CurrentUser.Username & " " & SecurityManager.Instance.CurrentUser.Password & " " & Me.m_IdShowedObject.ToString

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)







        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try


    End Sub

    Private Function ConstuctArguments(ByVal fiscalCode As String) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"
        Dim chk As String = """chk:no"""

        Dim fil As String = """fis:" + fiscalCode + """"
        Dim com As String = """com:2"""

        result = usn + " " + usp + " " + pro + " " + fil + " " + com + " " + chk


        Return result
    End Function



    Private Sub cmdSearchWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchWeb.Click
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
            If String.IsNullOrEmpty(txtCF1.TextValue) Then
                args.Arguments = ConstuctArguments()
            Else

                args.Arguments = ConstuctArguments(txtCF1.TextValue)
            End If


            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)







        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Function ConstuctArguments() As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"
        Dim chk As String = """chk:no"""

        Dim com As String = """com:4"""

        result = usn + " " + usp + " " + pro + " " + com + " " + chk


        Return result
    End Function

    Private Sub gridIncarichi_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridIncarichi.CellMouseDoubleClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If

            If gridIncarichi.Columns(e.ColumnIndex).HeaderText = "Azienda" Then
                If Not gridIncarichi.Rows(e.RowIndex).DataBoundItem.Azienda Is Nothing Then
                    Navigate(gridIncarichi.Rows(e.RowIndex).DataBoundItem.Azienda.Id, "ViewAzienda")
                End If

                Return
            End If

            SelectIncarichi()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub gridIncarichi_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles gridIncarichi.DataError
        If TypeOf (e.Exception) Is ArgumentOutOfRangeException Then
            '
        End If
    End Sub

    Private Sub gridIncarichi_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridIncarichi.KeyDown
        If e.KeyCode = Keys.Return Then
            SelectIncarichi()
        End If
    End Sub

    Private Sub SelectIncarichi()
        Try
            If Me.gridIncarichi.SelectedRows.Count = 0 Then Throw New Exception("Nessun incaricoo è stato selezionato. Selezionare un incarico.")
            controller.SelectIncaricoo(gridIncarichi.SelectedRows(0).Cells("TipoIncarico").Value.Descrizione)
            frmIncarichi = New FrmIncarichi("View", controller) '
            frmIncarichi.ShowDialog()
            frmIncarichi.Dispose()
            LoadGridIncarichi(controller.GetListaIcarichi)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Public Sub LoadGridIncarichi(ByVal Lista As IList)
        With gridIncarichi
            If Lista.Count > 0 Then
                .DataSource = Lista


                .AutoGenerateColumns = False
                .Columns("Key").Visible = False
                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Utente").Visible = False
                .Columns("NonCancellabile").Visible = False




                .Columns("TipoIncarico").DisplayIndex = 0
                .Columns("TipoIncarico").HeaderText = "Tipo Incarico"
                .Columns("TipoIncarico").ReadOnly = True

                .Columns("Azienda").DisplayIndex = 1
                .Columns("Azienda").HeaderText = "Azienda"
                .Columns("Azienda").CellTemplate.Style.Font = New Font(.Columns("Azienda").DataGridView.Font, FontStyle.Underline)
                .Columns("Azienda").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
                .Columns("Azienda").ReadOnly = True

                .Columns("Notes").DisplayIndex = 2
                .Columns("Notes").HeaderText = "Note"
                .Columns("Notes").ReadOnly = True







                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With

    End Sub

    Private Sub frmIncarichi_IncaricoAdded() Handles frmIncarichi.IncaricoAdded
        StartChangeOperation()
    End Sub

    Private Sub frmIncarichi_IncaricoUpdate() Handles frmIncarichi.IncaricoUpdate
        StartChangeOperation()
    End Sub

    Private Sub cmdOtherFiscal_Click(sender As System.Object, e As System.EventArgs) Handles cmdOtherFiscal.Click
        If String.IsNullOrEmpty(txtCF1.TextValue) Then
            Return
        End If

        If Me.IdShowedObject <= 0 Then
            Return
        End If

        Try

            Dim cont As New ControllerRicercheUtenti
            Dim list As IList = cont.SearchByFiscalCodes(txtCF1.TextValue)

            If list.Count = 0 Then
                MessageBox.Show("Non ci sono altri utenti con lo stesso codice fiscale", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If list.Count = 1 Then
                Dim utente As Utente = list.Item(0)
                If utente.Id = Me.IdShowedObject Then
                    MessageBox.Show("Solo l'utente corrente possiede questo codice fiscale", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show(String.Format("L'utente {0} con id {1} possiede questo codice fiscale", utente.CompleteName, utente.Id), "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                Return
            End If

            If list.Count > 1 Then

                Dim sb As New StringBuilder
                sb.AppendLine("Gli utenti seguenti hanno tutti lo stesso codice fiscale: ")

                For Each elem As Utente In list
                    sb.AppendLine(String.Format("{0} con id {1} ", elem.CompleteName, elem.Id))

                Next
                MessageBox.Show(sb.ToString, "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub cmdSms_Click(sender As Object, e As EventArgs) Handles cmdSms.Click
        Try
            'verifico i numeri di telefono
            Dim rec As New SmsRecipient(controller.Current)
            If Not rec.IsValid Then
                MessageBox.Show("Nessuno dei due cellulari è orretto. Inserire un numero di cellulare corretto!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SendSingleSms(rec.RecipientNumber)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub


    <Secure(Area:="Sms", Alias:="Invio singolo", Macroarea:="Invio SMS")> _
    Private Sub SendSingleSms(number As String)


        SecurityManager.Instance.Check()

        If controller.Current Is Nothing Then
            MessageBox.Show("Utente non creato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim frm As New FrmSingleSms(controller.Current)
        frm.Text = "Invio Sms al numero : " + number.Substring(2)
        frm.ShowDialog()
        frm.Dispose()
    End Sub

End Class
