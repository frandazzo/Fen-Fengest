Public Class ControlPrepareRptLibDTO
    Private WithEvents Controller As New WIN.APPLICATION.REPORTING.ReportLiberi
    Dim controllersettori As New ControllerSettori
    Dim controllerContratti As New ControllerTipoContratto
    'Dim controllerReparti As New ControllerReparti
    Dim frm As FrmElaborazioneInCorso
    Dim list As IList = New ArrayList

    Private Const NoSelection As String = "Nessuna selezione"
    Private Const ZeroCodes As String = "Codici 0"

    Public Sub New()
        InitializeComponent()

        Me.m_IdShowedObject = 0
        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report lavoratori liberi"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report lavoratori liberi "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report lavoratori liberi ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report  lavoratori liberi"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()


        ControlSelPeriodiMensili1.SetDefaultToLastMonth()

        Me.lblDescrizioneAzienda.Text = ""
        Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)
        ' InterfaceMediator.LoadCombo(cboReparto, controllerReparti.GetListaCausali, True)



        InterfaceMediator.LoadCombo(Me.cboNazione, GeoLocationFacade.Instance.GetListaNazioni, True)
        Me.cboNazione.Text = My.Settings.NazioneDefault



        LoadComboComuni(GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault))
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault


        LoadComboIscritti()

    End Sub

    Private Sub LoadComboIscritti()
        cboIscrittoA.Items.Add(NoSelection)
        cboIscrittoA.Items.Add(ZeroCodes)
        cboIscrittoA.Items.Add("FILCA")
        cboIscrittoA.Items.Add("FILLEA")
        cboIscrittoA.SelectedIndex = 0
    End Sub


    Private Sub LoadComboProvincie(ByVal Lista As ArrayList)

        cboProvincia.Items.Clear()
        For Each elem As String In Lista
            cboProvincia.Items.Add(elem)
        Next
        cboProvincia.Sorted = True
        cboProvincia.Items.Add("")
    End Sub

    Private Sub LoadComboComuni(ByVal Lista As ArrayList)

        cboComune.Items.Clear()
        For Each elem As String In Lista
            cboComune.Items.Add(elem)
        Next
        cboComune.Sorted = True
        cboComune.Items.Add("")

    End Sub


#End Region



    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        Dim cont As New AZIENDE.ControllerAziende
        InterfaceMediator.GetSimpleDescription(cont, "Descrizione", Me.lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
    End Sub

    Public Sub SetSearchConditions()

        Me.ControlSelPeriodiMensili1.CalcolaDate()
        Controller.SetEnte(cboEnti.Text)
        Controller.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        Controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        Controller.SetRicercaErrori(chkErr.Checked)
        Controller.SetComune(cboComune.Text)
        Controller.SetProvincia(cboProvincia.Text)
        Controller.SetNazione(cboNazione.Text)
        Controller.SetValidazioneLiberi(chkValidation.Checked)

        If cboIscrittoA.Text = ZeroCodes Then
            Controller.SetIscrittoA("")
        ElseIf cboIscrittoA.Text = NoSelection Then
            Controller.SetIscrittoA("-")
        Else
            Controller.SetIscrittoA(cboIscrittoA.Text)
        End If


    End Sub


    Private Sub CmdRpt_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdRpt.DoClik
        Try
            'frm = New FrmElaborazioneInCorso
            'frm.Show()
            SetGUIPreProcessReport()

            System.Windows.Forms.Application.DoEvents()

            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop




            'frm.Dispose()
            SetGUIPostProcessReport()
            System.Windows.Forms.Application.DoEvents()

            If list.Count > 0 Then
                NavigateToReport()
            Else
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            End If

        Catch ex As Exception
            SetGUIPostProcessReport()

            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub FillSearchList()
        Try
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)
            list = Controller.SearchDTOs
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        Catch ex As Exception
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try
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
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report iscritti"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report iscritti "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report iscritti ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    'Private Sub Controller_ElaborationIncremented(ByVal Percentage As Integer, ByRef Cancel As Boolean) Handles Controller.ElaborationIncremented
    '   frm.SetPercentage(Percentage)
    '   If frm.Annulla Then Cancel = True
    'End Sub

    Private Sub chkErr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkErr.CheckedChanged
        If chkErr.Checked Then
            cboEnti.Enabled = False
        Else
            cboEnti.Enabled = True
        End If
    End Sub

    Private Sub cboNazione_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNazione.SelectedIndexChanged
        'If Me.cboNazione.Text <> "ITALIA" Then
        '    Me.cboComune.Enabled = False
        '    Me.cboProvincia.Enabled = False
        'Else
        '    Me.cboComune.Enabled = True
        '    Me.cboProvincia.Enabled = True
        'End If
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
    End Sub
End Class
