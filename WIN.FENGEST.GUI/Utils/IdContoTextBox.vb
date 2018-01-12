Public Class IdContoTextBox

   Protected Overrides Sub DoClick()
      'MsgBox("Ricerca Conti")
      Try
         Dim frm As New SearchConti
         frm.ShowDialog()
         If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.TextValue = frm.SelectedId
         End If
         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Protected Overrides Sub DoLostFocus()
      ' MsgBox("Lost focus")
   End Sub
End Class
