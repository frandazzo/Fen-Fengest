Public Interface ISmsSender
    Function SendSingleSms(recipient As String, text As String) As SmsSendResult
    Function SendMultipleSms(recipients As String(), text As String) As SmsSendResult
    Function GetCredit() As SmsSendResult
End Interface
