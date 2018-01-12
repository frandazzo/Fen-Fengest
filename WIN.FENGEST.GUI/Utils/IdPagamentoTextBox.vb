Public Class IdDocumentoTextBox
   Public TipoDoc As String
   Protected Overrides Sub DoClick()
      'MsgBox("Ricerca Referenti")
      Try
         Dim frm As New SearchDocumenti
         frm.ShowDialog()
         If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.TextValue = frm.SelectedId
            Me.DescriptionOfText = frm.SelectedDescription
            Me.TipoDoc = frm.TipoDoc
         End If
         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class
