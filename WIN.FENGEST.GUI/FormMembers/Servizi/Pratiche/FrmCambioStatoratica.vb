Public Class FrmCambioStatoratica

    Private m_current As Pratica
    Private m_newState As PracticeEnum

    Public Sub New(newStatelabel As String, pratica As Pratica, newState As PracticeEnum)
        InitializeComponent()

        lblState.Text = newStatelabel
        m_newState = newState
        m_current = pratica
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim s As New StateData
            s.Cause = TextBox1.Text
            s.Data = DateTime.Now

            Select Case m_newState
                Case PracticeEnum.Chiusa
                    m_current.State.ClosePractice(s, m_current)
                Case PracticeEnum.Controllo
                    m_current.State.ControlDocumentation(s, m_current)
                Case PracticeEnum.Confermata
                    m_current.State.ConfirmDocumentation(s, m_current)
                Case PracticeEnum.Integrazione
                    m_current.State.IntegrateDocumentation(s, m_current)
                Case PracticeEnum.Rigettata
                    m_current.State.RejectPractice(s, m_current)
            End Select

            Dim cc As New ControllerPratiche
            cc.SaveOrUpdatePratica(m_current)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class