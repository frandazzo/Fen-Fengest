Public Class ControlPrepareRptIscrittiDTO

    Private WithEvents Controller As New WIN.APPLICATION.REPORTING.ReportIscritti
    Dim controllersettori As New ControllerSettori
    Dim controllerContratti As New ControllerTipoContratto
    Dim controllerSegreteria As New ControllerSegreteria
    'Dim controllerReparti As New ControllerReparti
    Dim frm As FrmElaborazioneInCorso
    Dim list As IList = New ArrayList





    Public Sub New()
        InitializeComponent()

        Me.m_IdShowedObject = 0
        DoLoad()

        controllerSegreteria.LoadById(1)

        If controllerSegreteria.ProvinciaLegale = "BOLZANO" Then
            SimpleButton1.Visible = True
        Else
            SimpleButton1.Visible = False

        End If


    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report iscritti"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report iscritti "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report iscritti ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report iscritti"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.lblDescrizioneAzienda.Text = ""

        InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, True)
        ' InterfaceMediator.LoadCombo(cboReparto, controllerReparti.GetListaCausali, True)
        InterfaceMediator.LoadCombo(Me.cboNazione, GeoLocationFacade.Instance.GetListaNazioni, True)
        Me.cboNazione.Text = My.Settings.NazioneDefault



        LoadComboComuni(GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault))
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault

        cboEnte.SelectedIndex = 0
        cboEnte.Enabled = False
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

    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
        If cboSettori.Text = "" Then
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        Else
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContrattiByIdSettore(controllersettori.GetIdSettoreByDescrizione(cboSettori.Text)), True)
        End If

        If cboSettori.Text = "EDILE" Then
            cboEnte.Enabled = True
        Else
            cboEnte.Enabled = False
        End If
    End Sub

    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        Dim cont As New AZIENDE.ControllerAziende
        InterfaceMediator.GetSimpleDescription(cont, "Descrizione", Me.lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
    End Sub

    Public Sub SetSearchConditions()

        Controller.SetVerificaDelega(Me.chkVer.Checked)
        Me.ControlSelPeriodiMensili1.CalcolaDate()
        Controller.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        Controller.SetSettore(cboSettori.Text)
        Controller.SetEnte(cboEnte.Text)
        Controller.SetContratto(cboContratti.Text)
        Controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        Controller.SetReferente(Me.IdReferenteTextBox1.TextValue)
        Controller.SetQuoteInps(rptQuotaInps.Checked)
        Controller.SetQuotePrevisionali(rptQuotaPrevisionale.Checked)
        If rptQuotaInps.Checked Then
            Controller.SetSettore("")
            Controller.SetEnte("")
            Controller.SetContratto("")
            Controller.SetAzienda("")
            Controller.SetReferente("")
        End If
        Controller.SetComune(cboComune.Text)
        Controller.SetProvincia(cboProvincia.Text)
        Controller.SetNazione(cboNazione.Text)

        If rptQuotaAssociative.Checked Then
            Controller.SetExportSector(cboSettori.Text)
        ElseIf rptQuotaInps.Checked Then
            Controller.SetExportSector("INPS")
        Else
            Controller.SetExportSector("")
        End If


        'Controller.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
    End Sub
    Private Sub CmdRpt_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdRpt.DoClik
        Try
            'frm = New FrmElaborazioneInCorso
            'frm.Show()
            SetGUIPreProcessReport()
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)
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
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        Catch ex As Exception
            SetGUIPostProcessReport()
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try

    End Sub
    Private Sub FillSearchList()
        Try
            list = Controller.SearchDTOs
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try


    End Sub

    Private Sub FillSearchListForBolzano()
        Try
            list = Controller.SearchDTOsForBolzano
        Catch ex As Exception
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

    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
        InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblRef, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub rptQuotaAssociative_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptQuotaAssociative.CheckedChanged
        If rptQuotaAssociative.Checked Then
            Panel1.Enabled = True
        Else
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub rptQuotaInps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptQuotaInps.CheckedChanged
        If rptQuotaInps.Checked Then
            Panel1.Enabled = False
        Else
            Panel1.Enabled = True
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

    Private Sub rptQuotaPrevisionale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptQuotaPrevisionale.CheckedChanged
        If rptQuotaPrevisionale.Checked Then
            Panel1.Enabled = True
        Else
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            'frm = New FrmElaborazioneInCorso
            'frm.Show()
            SetGUIPreProcessReport()
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)
            System.Windows.Forms.Application.DoEvents()


            Dim thread As New System.Threading.Thread(AddressOf FillSearchListForBolzano)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop




            'frm.Dispose()
            SetGUIPostProcessReport()
            System.Windows.Forms.Application.DoEvents()

            If list.Count > 0 Then
                WIN.GUI.UTILITY.Helper.HideWaitBox()
                Dim forr As New FormBolzano(list)
                forr.Show()

            Else
                WIN.GUI.UTILITY.Helper.HideWaitBox()
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            End If
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        Catch ex As Exception
            SetGUIPostProcessReport()
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try

    End Sub
End Class
