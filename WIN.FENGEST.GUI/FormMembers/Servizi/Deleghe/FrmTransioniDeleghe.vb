Public Class FrmTransioniDeleghe

   Public PathOutput As String
    Public DataTransazione As DateTime

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      PathOutput = ""
      FolderBrowserDialog1.ShowNewFolderButton = True
      If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
         lblPath.Text = FolderBrowserDialog1.SelectedPath
         PathOutput = lblPath.Text
      End If
   End Sub


   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        DataTransazione = DateTimePicker1.Value.Date
      Me.Close()
      Me.DialogResult = Windows.Forms.DialogResult.OK

   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.Close()
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
   End Sub
End Class