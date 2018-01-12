Public Class IdReferenteTextBox
   Protected Overrides Sub DoClick()
      'MsgBox("Ricerca Referenti")
      Try
         Dim frm As New SearchReferenti
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
   Protected Overrides Sub DoLostFocus()
      'MsgBox("Lost focus")
   End Sub
End Class
