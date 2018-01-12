Public Class IdOffertaTextBox
   Protected Overrides Sub DoClick()
      Try
         Dim frm As New SearchOfferte
         frm.ShowDialog()
         If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.TextValue = frm.SelectedId
            Me.DescriptionOfText = frm.SelectedDescription
         End If
         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class
