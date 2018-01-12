Public Class FrmCambiaAziende


    Private m_Testo As String = ""


    Public ReadOnly Property Testo() As String
        Get
            Return m_Testo
        End Get
    End Property


    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()


    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click



        m_Testo = txttesto.Text

        Me.DialogResult = Windows.Forms.DialogResult.OK


        Me.Close()

    End Sub
End Class