Public Class SmsFacade
    Private m_providerData As SmsProviderData
    Private m_SmsSender As ISmsSender


    Public Sub New(smsProviderData As SmsProviderData)
        m_providerData = smsProviderData
        m_SmsSender = New SkebbySmsSender(m_providerData)
    End Sub


    Public Function SendSingleSms(sms As SmsRecipient, text As String) As SmsSendResult
        If Not sms.IsValid Then
            Dim res As New SmsSendResult
            res.HasErrors = True
            res.ErrorMessage = "Numero del destinatario non corretto"
            Return res
        End If
        Return m_SmsSender.SendSingleSms(sms.RecipientNumber, text)
    End Function
    Public Function SendMultipleSms(sms As MultipleSms, text As String) As SmsSendResult

        If sms.SmsCorrectRecipients.Count = 0 Then
            Dim res As New SmsSendResult
            res.HasErrors = True
            res.ErrorMessage = "Nessun destinatario ha un numero corretto"
            Return res
        End If


        Return m_SmsSender.SendMultipleSms(sms.ToStringArray, text)
    End Function
    Public Function GetCredit() As SmsSendResult
        Return m_SmsSender.GetCredit
    End Function


End Class
