Public Class frmCompetenza

   
   Private Sub cmdSeleziona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleziona.Click
      If ControlloSelezioneCompetenza1.ErrorText = "" Then
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox(ControlloSelezioneCompetenza1.ErrorText, MsgBoxStyle.Exclamation, "Messaggio")
      End If

   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub
End Class