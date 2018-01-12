Public Class SkebbySmsSender
    Implements ISmsSender


    Dim m_smsProviderData As SmsProviderData

    Public Sub New(smsProviderData As SmsProviderData)
        m_smsProviderData = smsProviderData
    End Sub

    Private m_errorCodes As New SkebbyErrorCodeSummary

    Public Function SendMultipleSms(recipients() As String, text As String) As SmsSendResult Implements ISmsSender.SendMultipleSms
        Try
            Dim skebby As New SkebbySmsProvider

            Dim smsType As SkebbySmsType = [Enum].Parse(GetType(SkebbySmsType), m_smsProviderData.SmsOption1)

            Dim result_data As IDictionary(Of String, String) = skebby.skebbyGatewaySendSMS(m_smsProviderData.Username, m_smsProviderData.Password, recipients, text, smsType, m_smsProviderData.SenderNumber, m_smsProviderData.SenderAlias, "", "")


            If result_data("status") = "success" Then

                Dim resultMessage As String = String.Format("Messaggi/o inviati/o con successo! Rimangono ancora {0} Sms disponibili. ", result_data("remaining_sms"))
                If (result_data.ContainsKey("id")) Then
                    resultMessage = resultMessage + "(Identificativo della spedizione:" + result_data("id") + ")"
                End If

                Dim res As New SmsSendResult
                res.HasErrors = False
                res.Message = resultMessage
                Return res

            End If

            Dim result As New SmsSendResult
            result.HasErrors = True
            result.Message = result_data("message")
            Try
                Dim code As Int32 = result_data("code")
                result.ErrorMessage = m_errorCodes.GetError(code)
            Catch ex As Exception
                result.Message = result_data("message")
            End Try

            Return result



        Catch ex As Exception
            Dim s As New SmsSendResult
            s.HasErrors = True
            s.ErrorMessage = ex.Message
            If Not ex.InnerException Is Nothing Then
                s.Message = ex.InnerException.Message
            End If
            Return s
        End Try
    End Function

    Public Function SendSingleSms(recipient As String, text As String) As SmsSendResult Implements ISmsSender.SendSingleSms


        Dim recipients() As String = New String() {recipient}
        Return SendMultipleSms(recipients, text)



    End Function

    Public Function GetCredit() As SmsSendResult Implements ISmsSender.GetCredit
        Try
            Dim skebby As New SkebbySmsProvider
            Dim credit_result As IDictionary(Of String, String) = skebby.skebbyGatewayGetCredit(m_smsProviderData.Username, m_smsProviderData.Password, "")


            If credit_result("status") = "success" Then

                Dim skebbyEnum As SkebbySmsType = [Enum].Parse(GetType(SkebbySmsType), m_smsProviderData.SmsOption1)
                Dim resultMessage As String = ""
                Select Case skebbyEnum

                    Case SkebbySmsType.classic
                        resultMessage = String.Format("Il credito residuo è {0} Euro; Rimangono ancora {1} Sms!", credit_result("credit_left"), credit_result("classic_sms"))
                    Case SkebbySmsType.classic_plus
                        resultMessage = String.Format("Il credito residuo è {0} Euro; Rimangono ancora {1} Sms!", credit_result("credit_left"), credit_result("classic_sms"))
                    Case SkebbySmsType.basic
                        resultMessage = String.Format("Il credito residuo è {0} Euro; Rimangono ancora {1} Sms!", credit_result("credit_left"), credit_result("basic_sms"))
                    Case SkebbySmsType.test_classic
                        resultMessage = "Questo è un test: Classic"
                    Case SkebbySmsType.test_classic_plus
                        resultMessage = "Questo è un test: Classic_Plus"
                    Case SkebbySmsType.test_basic
                        resultMessage = "Questo è un test: Basic"
                    Case Else
                        resultMessage = "No type test"
                End Select

                Dim res As New SmsSendResult
                res.HasErrors = False
                res.Message = resultMessage
                Return res
            End If



            ' If credit_result("status") = "failed" Then
            Dim result As New SmsSendResult
            result.HasErrors = True
            result.ErrorMessage = "Errore nell'invio della richiesta"
            Return result
            'End If



        Catch ex As Exception
            Dim s As New SmsSendResult
            s.HasErrors = True
            s.ErrorMessage = ex.Message
            If Not ex.InnerException Is Nothing Then
                s.Message = ex.InnerException.Message
            End If
            Return s
        End Try
    End Function
End Class
