Public Class ControlPrepareRptIQ
    Private Controller As WIN.APPLICATION.REPORTING.ReportIncassiQuote
    Private controllersettori As ControllerSettori
    Private controllerContratti As ControllerTipoContratto
    Private m_listaUtenti As ArrayList
    Private controllerEnti As AZIENDE.ControllerEntiBilaterali
    Public SearchList As IList

  
   






    Public Sub New()
        InitializeComponent()

        Controller = New WIN.APPLICATION.REPORTING.ReportIncassiQuote
        controllersettori = New ControllerSettori
        controllerContratti = New ControllerTipoContratto
        m_listaUtenti = New ArrayList
        controllerEnti = New AZIENDE.ControllerEntiBilaterali

        Me.m_IdShowedObject = 0
        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report incassi quote"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report incassi quote "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report incassi quote ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report incassi quote"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Public Sub SetSearchConditions()

        Controller.IsIQAIncluded(Me.chkIQA.Checked)
        Controller.IsIQIIncluded(Me.chkIQI.Checked)
        Controller.IsIQVIncluded(Me.chkIQV.Checked)
        Controller.IsIQPIncluded(Me.chkIQP.Checked)

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
        parameterMap.Add("IntervalloDocumento", chkDoc.Checked)
        parameterMap.Add("ListaSoggetti", chkSogg.Checked)
        If Not Me.chkComp.Enabled Then
            parameterMap.Add("CompetenzaQuote", False)
        Else
            parameterMap.Add("CompetenzaQuote", chkComp.Checked)
        End If


        Me.ControlSelPeriodiMensili1.CalcolaDate()
        Controller.SetCompetenzaIncassiQuote(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        Controller.SetDataDocumentoRange(dtpDocDa.Value.Date, dtpDocA.Value.Date)
        Controller.SetDataRegistrazioneRange(dtpRegDa.Value.Date, dtpRegA.Value.Date)
        Controller.SetListaUtenti(m_listaUtenti)
        Controller.SetSettore(cboSettori.Text)
        Controller.SetContratto(cboContratti.Text)
        Controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        Controller.SetEnte(cboEnti.Text)
        Controller.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
        If Me.optAll.Checked Then
            Controller.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)
        ElseIf Me.optNo.Checked Then
            Controller.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.NonRistornate)
        Else
            Controller.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Ristornate)
        End If


        Controller.SetAziendaImpiego(IdAziendaTextBox2.TextValue)


        Controller.SetNewSerchConditions(parameterMap)
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

    Private Sub chkDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
        If chkDoc.Checked = True Then
            dtpDocDa.Enabled = True
            dtpDocA.Enabled = True
        Else
            dtpDocDa.Enabled = False
            dtpDocA.Enabled = False
        End If
    End Sub

    Private Sub chkComp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkComp.CheckedChanged
        If chkComp.Checked = True Then
            'dtpCompDa.Enabled = True
            'dtpCompA.Enabled = True
            Me.ControlSelPeriodiMensili1.Enabled = True
        Else
            'dtpCompDa.Enabled = False
            'dtpCompA.Enabled = False
            Me.ControlSelPeriodiMensili1.Enabled = False
        End If
    End Sub

    Private Sub chkSogg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSogg.CheckedChanged
        If chkSogg.Checked Then
            Me.cmdUt.Enabled = True
        Else
            Me.cmdUt.Enabled = False
        End If
    End Sub

    Private Sub cmdSogg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUt.Click
        Dim frm As New FrmSelezionaId
        frm.SetTipoRicerca(ControlloListeIDs.SearchType.Utenti, m_listaUtenti)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            m_listaUtenti = frm.ControlloListeIDs1.GetListId
            If m_listaUtenti.Count = 0 Then
                lblSogg.Text = ""
            Else
                lblSogg.Text = "Lista utenti impostata"
            End If
        End If
        frm.Dispose()
    End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.lblDescrizioneAzienda.Text = ""
        Me.lblDescrizioneReferente.Text = ""
        chkReg.Checked = True
        chkDoc.Checked = True
        chkComp.Checked = False
        chkSogg.Checked = False
        dtpRegDa.Enabled = True
        dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True
        dtpDocDa.Enabled = True
        dtpDocDa.Value = dtpDocDa.Value.AddYears(-1)
        dtpDocA.Enabled = True
        'dtpCompDa.Enabled = False
        'dtpCompA.Enabled = False
        Me.ControlSelPeriodiMensili1.Enabled = False
        Me.cmdUt.Enabled = False
        InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, True)
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, True)
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera

    End Sub


#End Region

    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged

        If cboSettori.Text = "" Then
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        Else
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContrattiByIdSettore(controllersettori.GetIdSettoreByDescrizione(cboSettori.Text)), True)
        End If
        SetVisualizzazioneDelega()
    End Sub

    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        Dim cont As New AZIENDE.ControllerAziende
        InterfaceMediator.GetSimpleDescription(cont, "Descrizione", Me.lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
    End Sub

    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
        InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub chkIQA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQA.CheckedChanged
        If Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub

    Private Sub chkIQV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQV.CheckedChanged
        If Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub

    Private Sub chkIQI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQI.CheckedChanged
        If Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub



    Private Sub SetVisualizzazioneDelega()
        lblDescrizioneAzienda.Visible = False
        IdAziendaTextBox1.Visible = False
        cboEnti.Visible = False
        If cboSettori.Text = "" Then
            lblDescrizioneAzienda.Visible = True
            IdAziendaTextBox1.Visible = True
            Exit Sub
        End If
        If controllersettori.IsSettoreEdile(cboSettori.Text) Then
            cboEnti.Visible = True
        Else
            lblDescrizioneAzienda.Visible = True
            IdAziendaTextBox1.Visible = True
        End If
    End Sub

    Private Sub CmdRpt_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdRpt.DoClik
        SearchAndShowResult()
    End Sub



    Private Sub SearchAndShowResult()
        Try
            If chkIQA.Checked = False And chkIQI.Checked = False And chkIQP.Checked = False And chkIQV.Checked = False Then
                MessageBox.Show("Selezionare almeno un tipo documento!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

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

            If SearchList.Count = 0 Then
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            Else

                NavigateToReport()

            End If




        Catch ex As Exception
            SetGUIPostProcessReport()
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try
    End Sub


    Private Sub FillSearchList()
        SearchList = Controller.Search

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
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report incassi quote"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report incassi quote "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report incassi quote ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub


    Private Sub chkIQP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQP.CheckedChanged
        If Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub

    Private Sub CmdRpt_Load(sender As Object, e As EventArgs) Handles CmdRpt.Load

    End Sub
End Class
