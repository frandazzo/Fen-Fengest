Public Class FrmElaborazioneInCorso

    Public Sub SetPercentageValue(ByVal Perc As Int32)
        ' Me.lblPerc.Text = Perc.ToString & "% completato"
        If Perc > 100 Then
            Perc = 100
        End If
        Me.ProgressBar1.Value = Perc
        Windows.Forms.Application.DoEvents()
    End Sub


    Public Sub SetActivity(ByVal text As String)
        lblAttivita.Text = text
    End Sub

    Public Annulla As Boolean = False


    Public Sub EnableCancel(ByVal enable As Boolean)
        Me.cmdAnnulla.Enabled = enable
    End Sub

    Private Sub txtAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Annulla = True
        Me.ControlBox = True
    End Sub


    Private Sub FrmElaborazioneInCorso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub FrmElaborazioneInCorso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = Windows.Forms.CloseReason.UserClosing Then
            Annulla = True
        End If
    End Sub

    Private Sub FrmElaborazioneInCorso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Application.DoEvents()

    End Sub
End Class