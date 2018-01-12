Public Class FrmCambiaPassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SecurityManager.Instance.CurrentUser.Password.ToLower <> TextBox1.Text Then
            MessageBox.Show("La password di admin non è corretta!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("I campi della nuova password non possono essere nulli", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (TextBox2.Text.Length < 5 Or TextBox3.Text.Length < 5) Then
            MessageBox.Show("I campi della nuova password non possono contenere meno di cinque caratteri!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If TextBox2.Text <> TextBox3.Text Then
            MessageBox.Show("Ridigitare correttamente la nuova password", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            DataAccessServices.Instance.PersistenceFacade.ExecuteNonQuery(String.Format("Update Users set Password='{0}' where id=1", TextBox2.Text.ToLower))


            MessageBox.Show("Password modificata con successo. Riavviare l'applicazione per rendere effettive le modifiche", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try


    End Sub
End Class