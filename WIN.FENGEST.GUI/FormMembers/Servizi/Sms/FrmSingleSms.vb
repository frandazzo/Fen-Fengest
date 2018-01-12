Public Class FrmSingleSms
    Private m_utente As Utente

    Public Sub New(utente As Utente)
        InitializeComponent()
        m_utente = utente
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Dim Controller As New WIN.APPLICATION.ReportComunicazioni
        Dim tipo As TipoComunicazione = GetTipoSMS()

        If tipo Is Nothing Then
            MessageBox.Show("Nessun sms trovato")
            Return
        End If


        Dim l As New ArrayList
        l.Add(m_utente.Id)

        Controller.SetListaUtenti(l)
        Controller.SetListUtentiSelected(True)
        Controller.SetTipo(tipo.Id)

        Dim result As IList = Controller.Search
        If result.Count = 0 Then

            MessageBox.Show("Nessun sms trovato")
            Return

        End If


        Dim frm As New FrmUserMessages(result)
        frm.ShowDialog()
        frm.Dispose()


    End Sub

    Private Function GetTipoSMS() As TipoComunicazione
        Dim controllerTipo As New ControllerTipoComunicazione

        Dim list As IList = controllerTipo.GetAll
        For Each elem As TipoComunicazione In list
            If elem.Descrizione = "SMS" Then
                Return elem
            End If
        Next

        Return Nothing

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(TextBox1.Text) Then
                MessageBox.Show("Il  testo del messaggio è nullo!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim cont As New SmsHandler
            Dim result As SmsSendResult = cont.SendSms(m_utente, TextBox1.Text, CheckBox1.Checked)

            If result.HasErrors Then

                Dim errorM As String = String.Format("Errore: {0}; ({1})", result.ErrorMessage, result.Message)
                MessageBox.Show(errorM, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            MessageBox.Show(result.Message, "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim cont As New SmsHandler
            Dim result As SmsSendResult = cont.GetCredit

            If result.HasErrors Then

                Dim errorM As String = String.Format("Errore: {0}; ({1})", result.ErrorMessage, result.Message)
                MessageBox.Show(errorM, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            MessageBox.Show(result.Message, "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class