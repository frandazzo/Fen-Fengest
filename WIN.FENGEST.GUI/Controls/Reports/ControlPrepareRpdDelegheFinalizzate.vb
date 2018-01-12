Public Class ControlPrepareRpdDelegheFinalizzate
    Private Controller As New WIN.APPLICATION.REPORTING.ReportDeleghe
    Private ControllerIncassiQuote As New WIN.APPLICATION.REPORTING.ReportIncassiQuote
    Dim controllersettori As New ControllerSettori
    Dim controllerReparti As New ControllerReparti
    Dim controllerContratti As New ControllerTipoContratto
    Dim controllerCausali As New ControllerCausaliSottoscrizione
    Private m_listaAziende As New ArrayList
    Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
    Dim SearchList As IList
    Dim SearchListQuote As IList
    Public Sub New()
        InitializeComponent()

        Me.m_IdShowedObject = 0
        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report confronto deleghe quote"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report confronto deleghe quote "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report confronto deleghe quote ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report confronto deleghe quote"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Public Sub SetSearchConditions()
        'parametri ricerca deleghe
        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
        parameterMap.Add("IntervalloDocumento", False)
        parameterMap.Add("IntervalloInoltro", chkSelDataInoltro.Checked)
        parameterMap.Add("IntervalloAccettazione", chkSelDataAcc.Checked)
        parameterMap.Add("IntervalloAttivazione", chkSelDataAtt.Checked)
        parameterMap.Add("IntervalloAnnullamento", chkSelDataAnn.Checked)
        parameterMap.Add("IntervalloRevoca", chkSelDataRev.Checked)
        parameterMap.Add("ListaAziende", False)

        Controller.SetDataRegistrazioneRange(dtpRegDa.Value.Date, dtpRegA.Value.Date)
        Controller.SetDataInoltroRange(dtpInDa.Value.Date, dtpInA.Value.Date)
        Controller.SetDataAccettazioneRange(dtpAccDa.Value.Date, dtpAccA.Value.Date)
        Controller.SetDataAttivazioneRange(dtpAttDa.Value.Date, dtpAttA.Value.Date)
        Controller.SetDataAnnullamentoRange(dtpAnnDa.Value.Date, dtpAnnA.Value.Date)
        Controller.SetDataRevocaRange(dtpRevDa.Value.Date, dtpRevA.Value.Date)
        Controller.SetDelegheSottoscritte(chkSottoscritta.Checked)
        Controller.SetDelegheInoltrate(chkInoltrata.Checked)
        Controller.SetDelegheAccettate(chkAccettata.Checked)
        Controller.SetDelegheAttivate(chkAttivata.Checked)
        Controller.SetDelegheAnnullate(chkAnnullata.Checked)
        Controller.SetDelegheRevocate(chkRevocata.Checked)
        Controller.SetSettore("EDILE")
        Controller.SetListaAziende(m_listaAziende)
        Controller.SetCausaleSottoscrizione(cboCaus.Text)
        Controller.SetEnte(cboEnti.Text)
        Controller.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
        Controller.SetNewSerchConditions(parameterMap)

        'parametri ricerca quote
        ControllerIncassiQuote.IsIQAIncluded(True)
        ControllerIncassiQuote.IsIQIIncluded(False)
        ControllerIncassiQuote.IsIQVIncluded(False)
        ControllerIncassiQuote.IsIQPIncluded(False)

        Dim parameterMap1 As New Hashtable
        parameterMap1.Add("IntervalloRegistrazione", False)
        parameterMap1.Add("IntervalloDocumento", False)
        parameterMap1.Add("ListaSoggetti", False)
        parameterMap1.Add("CompetenzaQuote", True)



        Me.ControlSelPeriodiMensili1.CalcolaDate()
        ControllerIncassiQuote.SetCompetenzaIncassiQuote(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        ControllerIncassiQuote.SetSettore("EDILE")
        ControllerIncassiQuote.SetEnte(cboEnti.Text)
        ' ControllerIncassiQuote.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
        ControllerIncassiQuote.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)
        ControllerIncassiQuote.SetNewSerchConditions(parameterMap1)

    End Sub



    Private Sub chkReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReg.CheckedChanged
        If chkReg.Checked = True Then
            dtpRegDa.Enabled = True
            dtpRegA.Enabled = True
        Else
            dtpRegDa.Enabled = False
            dtpRegA.Enabled = False
        End If
    End Sub



    Private Sub chkSelDataInoltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataInoltro.CheckedChanged
        If chkSelDataInoltro.Checked = True Then
            dtpInA.Enabled = True
            dtpInDa.Enabled = True
        Else
            dtpInA.Enabled = False
            dtpInDa.Enabled = False
        End If
    End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()

        Me.lblDescrizioneReferente.Text = ""

        chkReg.Checked = True

        dtpRegDa.Enabled = True
        dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True

        dtpInDa.Enabled = False
        dtpInA.Enabled = False
        dtpAccDa.Enabled = False
        dtpAccA.Enabled = False
        dtpAttDa.Enabled = False
        dtpAttA.Enabled = False
        dtpAnnDa.Enabled = False
        dtpAnnA.Enabled = False
        dtpRevDa.Enabled = False
        dtpRevA.Enabled = False

        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)
        InterfaceMediator.LoadCombo(cboCaus, controllerCausali.GetListaCausali, True)
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera

    End Sub


#End Region


    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
        InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub CmdRpt_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdRpt.DoClik
        Try
            SetGUIPreProcessReport()
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)


            'Dim start As DateTime = Now
            'System.Diagnostics.Debug.WriteLine("Inizio ricerca a " & start.ToString)
            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop

            'Dim finish As DateTime = Now
            'System.Diagnostics.Debug.WriteLine("Fine ricerca a " & finish.ToString & " della durata di " & Now.Subtract(start).TotalMilliseconds)

            'start = Now
            SetGUIPostProcessReport()
            System.Windows.Forms.Application.DoEvents()
            If SearchList.Count = 0 And SearchListQuote.Count = 0 Then
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            Else
                NavigateToReport()
            End If
            'finish = Now
            'System.Diagnostics.Debug.WriteLine("Fine impostazione layout a " & finish.ToString & " della durata di " & Now.Subtract(start).TotalMilliseconds)
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        Catch ex As Exception
            SetGUIPostProcessReport()
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try

    End Sub


    Private Sub FillSearchList()

        SearchList = Controller.Search
        SearchListQuote = ControllerIncassiQuote.Search
    End Sub

    Private Sub NavigateToReport()
        Dim map As New Hashtable
        map.Add("ReportingService", Controller)
         map.Add("ReportingServiceIQ", ControllerIncassiQuote)
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
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report confronto deleghe quote"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report confronto deleghe quote "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report confronto deleghe quote ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub



    Private Sub chkSelDataAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataAcc.CheckedChanged
        If chkSelDataAcc.Checked = True Then
            dtpAccA.Enabled = True
            dtpAccDa.Enabled = True
        Else
            dtpAccA.Enabled = False
            dtpAccDa.Enabled = False
        End If
    End Sub

    Private Sub chkSelDataAtt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataAtt.CheckedChanged
        If chkSelDataAtt.Checked = True Then
            dtpAttA.Enabled = True
            dtpAttDa.Enabled = True
        Else
            dtpAttA.Enabled = False
            dtpAttDa.Enabled = False
        End If
    End Sub

    Private Sub chkSelDataAnn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataAnn.CheckedChanged
        If chkSelDataAnn.Checked = True Then
            dtpAnnA.Enabled = True
            dtpAnnDa.Enabled = True
        Else
            dtpAnnA.Enabled = False
            dtpAnnDa.Enabled = False
        End If
    End Sub

    Private Sub chkSelDataRev_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataRev.CheckedChanged
        If chkSelDataRev.Checked = True Then
            dtpRevA.Enabled = True
            dtpRevDa.Enabled = True
        Else
            dtpRevA.Enabled = False
            dtpRevDa.Enabled = False
        End If
    End Sub


End Class
