Public Class ControlPrepareRptVertenze
   Private Controller As New WIN.APPLICATION.ADMINISTRATION.ControllerRicercheVertenze
   Private ControllerVert As New WIN.APPLICATION.ADMINISTRATION.ControllerVertenze

   Private m_listaAziende As New ArrayList
   Private m_listaUtenti As New ArrayList


   Dim SearchList As IList
   Public Sub New()
      InitializeComponent()

      Me.m_IdShowedObject = 0
      DoLoad()

   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report vertenze"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report vertenze "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report vertenze ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report vertenze"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
   Public Sub SetSearchConditions()



      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
      parameterMap.Add("IntervalloDocumento", chkDoc.Checked)

      parameterMap.Add("IntervalloEvento", chkDataEv.Checked)
      parameterMap.Add("IntervalloValidita", chkVal.Checked)

      parameterMap.Add("Utente", False)
      parameterMap.Add("ListaAziende", chkSogg.Checked)
      parameterMap.Add("ListaUtenti", chkUtenti.Checked)





        If ComboBox1.SelectedIndex = 0 Then
            Controller.SetVertenzaChiusa(VertenzaSearchType.All)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Controller.SetVertenzaChiusa(VertenzaSearchType.Closed)
        Else
            Controller.SetVertenzaChiusa(VertenzaSearchType.Opened)

        End If


      Controller.SetDataDocumentoRange(dtpDocDa.Value.Date, dtpDocA.Value.Date)
      Controller.SetDataRegistrazioneRange(dtpRegDa.Value.Date, dtpRegA.Value.Date)
      Controller.SetDataEventoRange(dtpEvDa.Value.Date, dtpEvA.Value.Date)
      Controller.SetValiditaRange(dtpValDa.Value.Date, dtpValA.Value.Date)



      Controller.SetTipoEvento(cboTipo.Text)
      Controller.SetIntervento(txtIntervento.Text)
      Controller.SetIdAvvocato(IdAvvocatoTextbox1.TextValue)
      Controller.SetEnteInoltro(txtEnte.Text)

      
      Controller.SetListaUtenti(m_listaUtenti)
      Controller.SetListaAziende(m_listaAziende)

     

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


   Private Sub chkVal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVal.CheckedChanged
      If chkVal.Checked = True Then
         dtpValDa.Enabled = True
         dtpValA.Enabled = True
      Else
         dtpValDa.Enabled = False
         dtpValA.Enabled = False
      End If
   End Sub

   Private Sub chkDataEv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDataEv.CheckedChanged
      If chkDataEv.Checked = True Then
         dtpEvDa.Enabled = True
         dtpEvA.Enabled = True
      Else
         dtpEvDa.Enabled = False
         dtpEvA.Enabled = False
      End If
   End Sub


   Private Sub chkSogg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSogg.CheckedChanged
      If chkSogg.Checked Then
         Me.cmdAz.Enabled = True
      Else
         Me.cmdAz.Enabled = False
      End If
   End Sub

   Private Sub cmdSogg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAz.Click
      Dim frm As New FrmSelezionaId
      frm.SetTipoRicerca(ControlloListeIDs.SearchType.Aziende, m_listaAziende)
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         m_listaAziende = frm.ControlloListeIDs1.GetListId
         If m_listaAziende.Count = 0 Then
            'lblSogg.Text = ""
         Else
            'lblSogg.Text = "Lista aziende impostata"
         End If
      End If
      frm.Dispose()
   End Sub

   Private Sub cmdUt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUt.Click
      Dim frm As New FrmSelezionaId
      frm.SetTipoRicerca(ControlloListeIDs.SearchType.Utenti, m_listaUtenti)
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         m_listaUtenti = frm.ControlloListeIDs1.GetListId
         If m_listaUtenti.Count = 0 Then
            'lblUt.Text = ""
         Else
            'lblUt.Text = "Lista utenti impostata"
         End If
      End If
      frm.Dispose()
   End Sub

   Private Sub chkUtenti_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUtenti.CheckedChanged
      If chkUtenti.Checked Then
         Me.cmdUt.Enabled = True
      Else
         Me.cmdUt.Enabled = False
      End If
   End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.lblCons.Text = ""
        Me.lblDescrizioneReferente.Text = ""


        chkReg.Checked = True
        chkDoc.Checked = True
        dtpRegDa.Enabled = True
        dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True
        dtpDocDa.Enabled = True
        dtpDocDa.Value = dtpDocDa.Value.AddYears(-1)
        dtpDocA.Enabled = True




        'chkReg.Checked = False
        'chkDoc.Checked = False
        chkVal.Checked = False
        chkDataEv.Checked = False
        chkSogg.Checked = False
        chkUtenti.Checked = False
        'dtpRegDa.Enabled = False
        'dtpRegA.Enabled = False
        'dtpDocDa.Enabled = False
        'dtpDocA.Enabled = False
        dtpValDa.Enabled = False
        dtpValA.Enabled = False
        dtpEvDa.Enabled = False
        dtpEvA.Enabled = False

        Me.cmdAz.Enabled = False
        Me.cmdUt.Enabled = False

        'InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        InterfaceMediator.LoadCombo(cboTipo, ControllerVert.GetListaTipiEvento, True)

        ComboBox1.SelectedIndex = 0
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera

    End Sub


#End Region

   

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

      SearchList = Controller.SearchDTOs
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
      MasterControl.Instance.ParentForm.Text = "Selezione criteri report vertenze"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report vertenze"
      Me.lblCurrentFunction.Text = UCase("Selezione criteri report vertenze ")
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
   End Sub



   Private Sub IdAvvocatoTextbox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdAvvocatoTextbox1.Leave
      InterfaceMediator.GetSimpleDescription(New ControllerAvvocati, "Descrizione", Me.lblDescrizioneAvvocato, Me.IdAvvocatoTextbox1.TextValue)
   End Sub
End Class