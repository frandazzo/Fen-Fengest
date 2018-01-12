Imports WIN.SECURITY.Core

Public Class ControlPrepareRptPratiche


    Private Controller As New WIN.APPLICATION.ReportPratiche
    Private controllerTipoPratica As New ControllerTipoPratica
    Private securityData As New SecureDataManager
    Dim frm As FrmElaborazioneInCorso
    Dim list As IList = New ArrayList
    Private m_listaSoggetti As New ArrayList



    Public Sub New()
        InitializeComponent()

        Me.m_IdShowedObject = 0
        DoLoad()

    End Sub


    Public Sub New(idUser As Int32)
        InitializeComponent()

        Me.m_IdShowedObject = idUser
        DoLoad()

    End Sub

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report Pratiche"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report Pratiche "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report Pratiche ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report  Pratiche"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub

    Protected Overrides Sub Nested_PrepareLoading()


        dtpRegDa.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpRegA.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))

        LoadComboUser(cboUser)
        LoadComboUser(cboProp)
        ' LoadComboUser(cboTipoPratica)
        Dim tipi As IList = controllerTipoPratica.GetAll
        tipi.Insert(0, New TipoPratica)

        For Each elem As TipoPratica In tipi
            cboTipoPratica.Items.Add(elem)
        Next
        cboTipoPratica.SelectedIndex = 0


    End Sub

  

    Private Sub LoadComboUser(comboBox As ComboBox)

        Dim controllerUtente As New SecureDataManager
        Dim users As IList(Of IdDescriptionClass) = controllerUtente.GetUsersList()

        users.Insert(0, New IdDescriptionClass)


        comboBox.Items.Clear()

        For Each elem As IdDescriptionClass In users
            comboBox.Items.Add(elem)
        Next
        comboBox.SelectedIndex = 0

        If Me.IdShowedObject > 0 Then
            comboBox.SelectedItem = findUserById(IdShowedObject, users)
        End If

    End Sub

    Private Function findUserById(id As Int32, users As IList(Of IdDescriptionClass)) As IdDescriptionClass
        For Each elem As IdDescriptionClass In users
            If elem.Id = id Then
                Return elem
            End If
        Next
        Return Nothing
    End Function

    'Private Sub LoadComboTipoPratica(comboBox As ComboBox)

    '    Dim controllerTipo As New ControllerTipoPratica

    '    comboBox.Items.Add(New TipoPratica)

    '    Dim users As IList = controllerTipo.GetAll

    '    For Each elem As TipoPratica In users
    '        comboBox.Items.Add(elem)
    '    Next
    '    comboBox.SelectedIndex = 0
    'End Sub


    Public Sub SetSearchConditions()

        If chkReg.Checked Then
            Controller.SetDataRangeSelected(True)
            Controller.SetDataRange(dtpRegDa.Value, dtpRegA.Value)
        End If

        If cboUser.SelectedItem.Description <> "" Then
            Controller.SetInCaricoA(cboUser.SelectedItem.Id)
        End If

        If cboProp.SelectedItem.Description <> "" Then
            Controller.SetProprietario(cboProp.SelectedItem.Id)
        End If

        If cboTipoPratica.SelectedItem.Descrizione <> "" Then
            Controller.SetTipoPratica(cboTipoPratica.SelectedItem.Id)
        End If

        Controller.SetAperteSelected(chkSottoscritta.Checked)
        Controller.SetControlloSelected(chkInoltrata.Checked)
        Controller.SetConfermaSelected(chkAccettata.Checked)
        Controller.SetIntegraSelected(chkAttivata.Checked)
        Controller.SetChiuseSelected(chkRevocata.Checked)
        Controller.SetRigettateSelected(chkAnnullata.Checked)

        Controller.SetListUtentiSelected(chkUt.Checked)
        Controller.SetListaUtenti(m_listaSoggetti)


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
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub FillSearchList()
        list = Controller.Search
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
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report prestazioni"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report prestazioni "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report prestazioni ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dim map As New Hashtable
        map.Add("ReportingService", 1)
        Me.NavigateTo("ViewReport", map)
    End Sub

    Private Sub cmdUt_Click(sender As Object, e As EventArgs) Handles cmdUt.Click
        Dim frm As New FrmSelezionaId
        frm.SetTipoRicerca(ControlloListeIDs.SearchType.Utenti, m_listaSoggetti)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            m_listaSoggetti = frm.ControlloListeIDs1.GetListId
            If m_listaSoggetti.Count = 0 Then
                'lblSogg.Text = ""
            Else
                ' lblSogg.Text = "Lista utenti impostata"
            End If
        End If
        frm.Dispose()
    End Sub

    Private Sub chkUt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUt.CheckedChanged
        If chkUt.Checked Then
            Me.cmdUt.Enabled = True
        Else
            Me.cmdUt.Enabled = False
        End If
    End Sub

    Private Sub chkReg_CheckedChanged(sender As Object, e As EventArgs) Handles chkReg.CheckedChanged
        If chkReg.Checked Then
            dtpRegDa.Enabled = True
            dtpRegA.Enabled = True
        Else
            dtpRegDa.Enabled = False
            dtpRegA.Enabled = False
        End If
    End Sub
End Class
