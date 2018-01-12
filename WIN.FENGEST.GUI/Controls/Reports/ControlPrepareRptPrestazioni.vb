Public Class ControlPrepareRptPrestazioni
   Private WithEvents Controller As New ADMINISTRATION.ControllerricerchePrestazioniInps

   Private m_listaSoggetti As New ArrayList

   Private controllerTP As New WIN.APPLICATION.ADMINISTRATION.ControllerTipoPrestazione



   'Dim controllerReparti As New ControllerReparti
   Dim frm As FrmElaborazioneInCorso
   Dim list As IList = New ArrayList
   Public Sub New()
      InitializeComponent()

      Me.m_IdShowedObject = 0
      DoLoad()

   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report prestazioni"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report prestazioni "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report prestazioni ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report prestazioni"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        'chkReg.Checked = False
        'chkDoc.Checked = False
        chkUt.Checked = False
        'dtpRegDa.Enabled = False
        'dtpRegA.Enabled = False
        'dtpDocDa.Enabled = False
        'dtpDocA.Enabled = False
        chkReg.Checked = True
        chkDoc.Checked = True
        'dtpRegDa.Enabled = True
        'dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True
        dtpDocDa.Enabled = True
        dtpDocDa.Value = dtpDocDa.Value.AddYears(+1)
        'dtpDocA.Enabled = True



        Me.chkRes.Checked = False
        Me.cboProvincia.Enabled = False
        Me.cboComune.Enabled = False
        Me.cmdUt.Enabled = False
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault
        InterfaceMediator.LoadCombo(Me.cboTipo, controllerTP.GetListaTipiPrestazioni, True)

    End Sub



#End Region





    Public Sub SetSearchConditions()
        Controller.SetComune(Me.cboComune.Text)
        Controller.SetTipoPrestazione(Me.cboTipo.Text)
        Controller.SetDataDocumentoRange(dtpDocDa.Value)
        Controller.SetDataRegistrazioneRange(dtpRegA.Value)
        Controller.SetListaUtenti(m_listaSoggetti)
        Controller.SetReferenteId(IdReferenteTextBox1.TextValue)

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
        parameterMap.Add("IntervalloDocumento", chkDoc.Checked)
        parameterMap.Add("ListaUtenti", chkUt.Checked)
        parameterMap.Add("Residenza", chkRes.Checked)
        Controller.SetNewSerchConditions(parameterMap)

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
        list = Controller.SearchDTOs
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

    Private Sub chkReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReg.CheckedChanged
        If chkReg.Checked = True Then
            ' dtpRegDa.Enabled = True
            dtpRegA.Enabled = True
        Else
            'dtpRegDa.Enabled = False
            dtpRegA.Enabled = False
        End If
    End Sub

    Private Sub chkDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
        If chkDoc.Checked = True Then
            dtpDocDa.Enabled = True
            'dtpDocA.Enabled = True
        Else
            dtpDocDa.Enabled = False
            'ì dtpDocA.Enabled = False
        End If
    End Sub

    Private Sub cmdUt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUt.Click
        Dim frm As New FrmSelezionaId
        frm.SetTipoRicerca(ControlloListeIDs.SearchType.Utenti, m_listaSoggetti)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            m_listaSoggetti = frm.ControlloListeIDs1.GetListId
            If m_listaSoggetti.Count = 0 Then
                lblSogg.Text = ""
            Else
                lblSogg.Text = "Lista utenti impostata"
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

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
    End Sub



   Private Sub chkRes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRes.CheckedChanged
      If chkRes.Checked = True Then
         Me.cboProvincia.Enabled = True
         Me.cboComune.Enabled = True
      Else
         Me.cboProvincia.Enabled = False
         Me.cboComune.Enabled = False
      End If
   End Sub

   Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
      InterfaceMediator.GetSimpleDescription(New FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneReferente, IdReferenteTextBox1.TextValue)
   End Sub
End Class
