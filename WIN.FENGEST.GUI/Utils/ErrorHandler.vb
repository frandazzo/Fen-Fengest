Public Class ErrorHandler
   Shared Sub ShowError(ByVal Ex As Exception)
      Dim s As String = Ex.Message

      If Ex.GetBaseException IsNot Nothing Then
         If s <> Ex.GetBaseException.Message Then
            s += Environment.NewLine + Ex.GetBaseException.Message
         End If

      End If
      System.Windows.Forms.MessageBox.Show(s, "Errore", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    End Sub
    Shared Sub ShowError(ByVal Ex As String)
        
        System.Windows.Forms.MessageBox.Show(Ex, "Errore", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    End Sub
End Class
