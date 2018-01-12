Public Class FrmDeleteElectronicDocument


   Private m_DeleteFile As Boolean

   Public ReadOnly Property DeleteFile() As String
      Get
         Return m_DeleteFile
      End Get
   End Property


   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Me.DialogResult = Windows.Forms.DialogResult.OK
      If chkDel.Checked Then
         If System.Windows.Forms.MessageBox.Show("Il file sarà eliminato dal computer. Proseguire?", "Domanda", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            m_DeleteFile = True
            Me.Close()
         Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
         End If
      End If
      Me.Close()
   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub
End Class