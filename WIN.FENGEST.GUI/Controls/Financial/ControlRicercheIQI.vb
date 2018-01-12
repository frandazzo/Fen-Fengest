Public Class ControlRicercheIQI
   Private m_FoundList As New ArrayList
   Private m_listaSoggetti As New ArrayList
   Private Controller As New WIN.APPLICATION.ADMINISTRATION.ControllerricerchePrestazioniInps
   Private controllerTP As New WIN.APPLICATION.ADMINISTRATION.ControllerTipoPrestazione



   Public Sub SetSearchConditions()
      Controller.SetComune(Me.cboComune.Text)
      Controller.SetTipoPrestazione(Me.cboTipo.Text)
        Controller.SetDataDocumentoRange(dtpDocDa.Value)
        Controller.SetDataRegistrazioneRange(dtpRegDa.Value)
      Controller.SetListaUtenti(m_listaSoggetti)

      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
      parameterMap.Add("IntervalloDocumento", chkDoc.Checked)
      parameterMap.Add("ListaUtenti", chkUt.Checked)
      parameterMap.Add("Residenza", chkRes.Checked)
      Controller.SetNewSerchConditions(parameterMap)
   End Sub
   ''' <summary>
   ''' Metodo che restituisce il controller impostato con le
   ''' condizioni per la ricerca. Eseguire dopo aver impostato
   ''' le condizioni di ricerca con il metodo SetSearchConditions
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property GetControllerRicerche() As WIN.APPLICATION.ADMINISTRATION.ControllerricerchePrestazioniInps
      Get
         Return Controller
      End Get
   End Property


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

    Private Sub ControlRicercheIQI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkReg.Checked = False
        chkDoc.Checked = False
        chkUt.Checked = False
        dtpRegDa.Enabled = False
        dtpRegA.Enabled = False
        dtpDocDa.Enabled = False
        dtpDocA.Enabled = False
        Me.chkRes.Checked = False
        Me.cboProvincia.Enabled = False
        Me.cboComune.Enabled = False
        Me.cmdUt.Enabled = False
        'LoadChoises()
        'Me.cboTipo.SelectedIndex = 0
    End Sub

    Public Sub LoadChoises()
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault
        InterfaceMediator.LoadCombo(Me.cboTipo, controllerTP.GetListaTipiPrestazioni, False)
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

End Class
