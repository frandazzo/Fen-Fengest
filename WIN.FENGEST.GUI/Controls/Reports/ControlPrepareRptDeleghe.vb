Public Class ControlPrepareRptDeleghe
   Private Controller As New WIN.APPLICATION.REPORTING.ReportDeleghe
   Dim controllersettori As New ControllerSettori
   Dim controllerReparti As New ControllerReparti
   Dim controllerContratti As New ControllerTipoContratto
   Dim controllerCausali As New ControllerCausaliSottoscrizione
   Private m_listaAziende As New ArrayList
   Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
   Dim SearchList As IList
   Public Sub New()
      InitializeComponent()

      Me.m_IdShowedObject = 0
      DoLoad()

   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report deleghe"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report deleghe "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report deleghe ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report deleghe"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
   Public Sub SetSearchConditions()



      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
      parameterMap.Add("IntervalloDocumento", chkDoc.Checked)

      parameterMap.Add("IntervalloInoltro", chkSelDataInoltro.Checked)
      parameterMap.Add("IntervalloAccettazione", chkSelDataAcc.Checked)
      parameterMap.Add("IntervalloAttivazione", chkSelDataAtt.Checked)
      parameterMap.Add("IntervalloAnnullamento", chkSelDataAnn.Checked)
      parameterMap.Add("IntervalloRevoca", chkSelDataRev.Checked)
      parameterMap.Add("ListaAziende", chkSogg.Checked)






      
        Controller.SetDataDocumentoRange(dtpDocDa.Value.Date, dtpDocA.Value.Date)
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

      Controller.SetSettore(cboSettori.Text)
      Controller.SetListaAziende(m_listaAziende)

      Controller.SetContratto(cboContratti.Text)
      Controller.SetCausaleSottoscrizione(cboCaus.Text)
      Controller.SetReparto(cboReparto.Text)
      Controller.SetEnte(cboEnti.Text)

      Controller.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
      Controller.SetResponsabileId(Me.IdReferenteTextBox2.TextValue)
      

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

   Private Sub chkSelDataInoltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataInoltro.CheckedChanged
      If chkSelDataInoltro.Checked = True Then
         dtpInA.Enabled = True
         dtpInDa.Enabled = True
      Else
         dtpInA.Enabled = False
         dtpInDa.Enabled = False
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
      frm.SetTipoRicerca(ControlloListeIDs.SearchType.Aziende, m_listaAziende)
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         m_listaAziende = frm.ControlloListeIDs1.GetListId
         If m_listaAziende.Count = 0 Then
            lblSogg.Text = ""
         Else
            lblSogg.Text = "Lista aziende impostata"
         End If
      End If
      frm.Dispose()
   End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.lblCons.Text = ""
        Me.lblDescrizioneReferente.Text = ""
        'chkReg.Checked = False
        'chkDoc.Checked = False
        chkSogg.Checked = False
        'dtpRegDa.Enabled = False
        'dtpRegA.Enabled = False
        'dtpDocDa.Enabled = False
        'dtpDocA.Enabled = False
        chkReg.Checked = True
        chkDoc.Checked = True
        dtpRegDa.Enabled = True
        dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True
        dtpDocDa.Enabled = True
        dtpDocDa.Value = dtpDocDa.Value.AddYears(-1)
        dtpDocA.Enabled = True


        'chkSelDataInoltro.Enabled = False
        'chkSelDataAcc.Enabled = False
        'chkSelDataAnn.Enabled = False
        'chkSelDataAtt.Enabled = False
        'chkSelDataRev.Enabled = False

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



        'dtpCompDa.Enabled = False
        'dtpCompA.Enabled = False

        Me.cmdUt.Enabled = False
        'InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContrattiByIdSettore(1), True)
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, False)
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)
        InterfaceMediator.LoadCombo(cboReparto, controllerReparti.GetListaCausali, True)
        InterfaceMediator.LoadCombo(cboCaus, controllerCausali.GetListaCausali, True)
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera

    End Sub


#End Region

   Private Sub cboSettori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
      If cboSettori.Text <> "EDILE" Then
         cboReparto.Enabled = True
         cboContratti.Enabled = True
         chkSogg.Enabled = True
         If chkSogg.Checked Then
            cmdUt.Enabled = True
         Else
            cmdUt.Enabled = False
         End If
         cboEnti.Text = ""
         cboEnti.Enabled = False
      Else
         cboContratti.Text = ""
         cboReparto.Text = ""
         cboReparto.Enabled = False
         cboContratti.Enabled = False
         chkSogg.Enabled = False
         cmdUt.Enabled = False
         cboEnti.Text = ""
         cboEnti.Enabled = True
      End If
  



   End Sub

   Private Sub IdReferenteTextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox2.Leave
      Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
      InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblCons, Me.IdReferenteTextBox2.TextValue)
   End Sub

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
         If SearchList.Count > 0 Then
            NavigateToReport()
         Else
            MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
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
      MasterControl.Instance.ParentForm.Text = "Selezione criteri report deleghe"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report deleghe "
      Me.lblCurrentFunction.Text = UCase("Selezione criteri report deleghe ")
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

   Private Sub chkInoltrata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInoltrata.CheckedChanged
        'If chkInoltrata.Checked = True Then
        '   chkSelDataInoltro.Enabled = True
        'Else
        '   chkSelDataInoltro.Enabled = False
        'End If
   End Sub

   Private Sub chkAccettata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAccettata.CheckedChanged
        'If chkAccettata.Checked = True Then
        '   chkSelDataAcc.Enabled = True
        'Else
        '   chkSelDataAcc.Enabled = False
        'End If
   End Sub

   Private Sub chkAttivata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAttivata.CheckedChanged
        'If chkAttivata.Checked = True Then
        '   chkSelDataAtt.Enabled = True
        'Else
        '   chkSelDataAtt.Enabled = False
        'End If
   End Sub

   Private Sub chkAnnullata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnnullata.CheckedChanged
        'If chkAnnullata.Checked = True Then
        '   chkSelDataAnn.Enabled = True
        'Else
        '   chkSelDataAnn.Enabled = False
        'End If
   End Sub

   Private Sub chkRevocata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRevocata.CheckedChanged
        'If chkRevocata.Checked = True Then
        '   chkSelDataRev.Enabled = True
        'Else
        '   chkSelDataRev.Enabled = False
        'End If
   End Sub

 
    Private Sub CmdRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRpt.Load

    End Sub
End Class
