Public Class FrmOptStampaTessere

    Public WithoutTesseraAnnuale As Boolean
    Public OnlyAddressOK As Boolean = False


    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If optTutti.Checked Then
            WithoutTesseraAnnuale = False
        Else
            WithoutTesseraAnnuale = True
        End If
        OnlyAddressOK = chkAddressOK.Checked
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class