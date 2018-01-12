Public Class SingleSms

    Private m_utente As Utente
    Private m_text As String
    Public Sub New(utente As Utente, text As String)
        If String.IsNullOrEmpty(text) Then
            Throw New ArgumentException("Testo del messaggio nullo")
        End If
        If utente Is Nothing Then
            Throw New ArgumentException("Utente nullo")
        End If

        m_utente = utente
        m_text = text

    End Sub

    Public ReadOnly Property SmsRecipient As SmsRecipient
        Get
            Return New SmsRecipient(m_utente)
        End Get
    End Property


    Private ReadOnly Property SmsText As String
        Get
            Return m_text
        End Get
    End Property




End Class
