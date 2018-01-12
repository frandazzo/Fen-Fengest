Public Class FrmMessaggiMultipli
    Private m_lista As IList

    Public Sub New(listaUtente As IList)
        InitializeComponent()

        m_lista = listaUtente


        'inizializzo la griglia
        Dim sms As MultipleSms = New MultipleSms(m_lista, "")
        GridControl1.DataSource = sms.SmsCompleteRecipients

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(TextBox1.Text) Then
                MessageBox.Show("Il  testo del messaggio è nullo!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'verifico il numero di utenti a cui sarà inviato il messaggio
            Dim utenti As New ArrayList
            For Each elem As SmsRecipient In GetVisuibleRecords()
                utenti.Add(elem.Utente)
            Next

            If utenti.Count = 0 Then
                MessageBox.Show("Nessun utente selezinato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sms As MultipleSms = New MultipleSms(utenti, TextBox1.Text)
            If sms.SmsCorrectRecipients.Count = 0 Then
                MessageBox.Show("Nessun utente ha un numero valido!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If sms.SmsCompleteRecipients.Count <> sms.SmsCorrectRecipients.Count Then
                If MessageBox.Show("Non tutti gli utenti hanno un numero di telefono corretto. L'Sms sarà inviato solo agli utenti con un numero valido. Continuare?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Return
                End If
            End If

           

            Dim cont As New SmsHandler
            Dim result As SmsSendResult = cont.SendSms(utenti, TextBox1.Text, CheckBox1.Checked, TextBox2.Text)

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

    'Private Function CreateListaLavoroWithFilteredResults() As ListaLavoroUtenti
    '    Dim l As New ListaLavoroUtenti

    '    Dim records As IList = GetVisuibleRecords()

    '    For Each elem As SmsRecipient In records
    '        l.AddUtente(elem.Utente)
    '    Next

    '    Return l
    'End Function

    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As SmsRecipient = DirectCast(GridView1.GetRow(handle), SmsRecipient)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function
End Class