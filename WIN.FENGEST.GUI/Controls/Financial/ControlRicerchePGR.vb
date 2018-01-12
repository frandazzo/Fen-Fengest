Public Class ControlRicerchePGR
   'Private m_FoundList As New ArrayList
   Private Controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerRicercheItems
   Private m_listaSoggetti As New ArrayList
   Private m_IdReferente As String = "-1"
   Private m_tipoDoc As String = "IQA"

   Public Sub SetSearchConditions()
      Controller.SetReferenteId(m_IdReferente)
      Controller.SetCompetenzaIncassiQuote(dtpCompDa.Value, dtpCompA.Value)
      Controller.SetDataDocumentoRange(dtpDocDa.Value, dtpDocA.Value)
      Controller.SetDataRegistrazioneRange(dtpRegDa.Value, dtpRegA.Value)
      Controller.SetListaSoggettiEsecutori(m_listaSoggetti)
      Controller.SetTipoDocumento(m_tipoDoc)
      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
      parameterMap.Add("IntervalloDocumento", chkDoc.Checked)
      parameterMap.Add("ListaSoggetti", chkSogg.Checked)
      parameterMap.Add("CompetenzaQuote", chkComp.Checked)
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
   Public ReadOnly Property GetControllerRicerche() As WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerRicercheItems
      Get
         Return Controller
      End Get
   End Property

   Public Sub SetInitialSearchConditions(ByVal IdReferente As String)
      m_IdReferente = IdReferente
   End Sub





   Private Sub ControlRicerchePGR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Me.cboTipo.SelectedIndex = 0
      chkReg.Checked = False
      chkDoc.Checked = False
      chkComp.Checked = False
      chkSogg.Checked = False
      dtpRegDa.Enabled = False
      dtpRegA.Enabled = False
      dtpDocDa.Enabled = False
      dtpDocA.Enabled = False
      dtpCompDa.Enabled = False
      dtpCompA.Enabled = False
      Me.cmdSogg.Enabled = False
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
         dtpCompDa.Enabled = True
         dtpCompA.Enabled = True
      Else
         dtpCompDa.Enabled = False
         dtpCompA.Enabled = False
      End If
   End Sub

   Private Sub chkSogg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSogg.CheckedChanged
      If chkSogg.Checked Then
         Me.cmdSogg.Enabled = True
      Else
         Me.cmdSogg.Enabled = False
      End If
   End Sub

   Private Sub cmdSogg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSogg.Click
      Dim frm As New FrmSelezionaId
      frm.SetTipoRicerca(ControlloListeIDs.SearchType.Aziende, m_listaSoggetti)
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         m_listaSoggetti = frm.ControlloListeIDs1.GetListId
         If m_listaSoggetti.Count = 0 Then
            lblSogg.Text = ""
         Else
            lblSogg.Text = "Lista soggetti esecutori impostata"
         End If
      End If
      frm.Dispose()
   End Sub



   Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
      Select Case cboTipo.Text
         Case "IQA - Incasso quota associativa"
            m_tipoDoc = "IQA"
         Case "IQI - Incasso quota Inps"
            m_tipoDoc = "IQI"
         Case "IQV - Incasso quota vertenza"
            m_tipoDoc = "IQV"
      End Select



   End Sub
End Class
