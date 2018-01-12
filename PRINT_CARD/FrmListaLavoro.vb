Public Class FrmDescrListaLavoro

   Public Descrizione As String

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Descrizione = txtDescr.Text
      Me.Close()
   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub
End Class