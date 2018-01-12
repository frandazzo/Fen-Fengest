Public Class ControlRicrcheIQV
   Private Controller As New WIN.APPLICATION.ADMINISTRATION.ControllerRicercheVertenze

   Public Sub SetSearchConditions()

      Controller.SetDataDocumentoRange(dtpDocDa.Value, dtpDocA.Value)
      Controller.SetDataRegistrazioneRange(dtpRegDa.Value, dtpRegA.Value)
      Controller.SetUtente(Me.IdUtenteTextBox1.TextValue)

      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
      parameterMap.Add("IntervalloDocumento", chkDoc.Checked)
      parameterMap.Add("Utente", chkUt.Checked)
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
   Public ReadOnly Property GetControllerRicerche() As WIN.APPLICATION.ADMINISTRATION.ControllerRicercheVertenze
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


   Private Sub ControlRicercheIQV_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      chkReg.Checked = False
      chkDoc.Checked = False
      chkUt.Checked = False
      dtpRegDa.Enabled = False
      dtpRegA.Enabled = False
      dtpDocDa.Enabled = False
      dtpDocA.Enabled = False
      Me.chkUt.Checked = False
      Me.IdUtenteTextBox1.Enabled = False
   End Sub

   Private Sub chkUt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUt.CheckedChanged
      If chkUt.Checked Then
         Me.IdUtenteTextBox1.Enabled = True
      Else
         Me.IdUtenteTextBox1.Enabled = False
      End If
   End Sub

End Class
