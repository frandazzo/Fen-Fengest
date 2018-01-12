Public Class SmsHandler
    Private m_controllerTipoComunicazioni As New ControllerTipoComunicazione
    Private m_controllerCausaleComunicazioni As New ControllerCausaleComunicazione
    Private m_controllerComunicazioni As New ControllerComunicazioni


    Public Function SendSms(utente As Utente, text As String, saveComunicazione As Boolean) As SmsSendResult

        Dim providerData As SmsProviderData = getProvider()

        Dim facade As New SmsFacade(providerData)

        Dim recipient As SmsRecipient = New SmsRecipient(utente)
        Dim result As SmsSendResult = facade.SendSingleSms(recipient, text)

        If Not result.HasErrors Then

            If saveComunicazione Then
                CheckPrerequisites()
                SaveComunicazioneToDb(recipient, text, "SMS SINGOLO")

            End If

        End If

        Return result
    End Function

    Public Function GetCredit() As SmsSendResult

        Dim providerData As SmsProviderData = getProvider()

        Dim facade As New SmsFacade(providerData)


        Dim result As SmsSendResult = facade.GetCredit

     
        Return result

    End Function


    Public Function SendSms(utenti As IList, text As String, saveComunicazioni As Boolean, nomeCampagna As String) As SmsSendResult

        Dim providerData As SmsProviderData = getProvider()

        Dim facade As New SmsFacade(providerData)

        Dim sms As MultipleSms = New MultipleSms(utenti, text)
        Dim result As SmsSendResult = facade.SendMultipleSms(sms, text)

        If Not result.HasErrors Then

            If saveComunicazioni Then

                SaveComunicazioniToDb(sms.SmsCorrectRecipients, text, nomeCampagna)

            End If

        End If

        Return result

    End Function

    Private Function getProvider() As SmsProviderData
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        Dim l As IList = ps.GetAllObjects("SmsProviderData")

        If l.Count = 0 Then
            Throw New Exception("Dati di connessione al provider degli sms non impostata")
        End If

        Return l.Item(0)
    End Function

    Private Sub SaveComunicazioneToDb(recipient As SmsRecipient, text As String, nomeCausale As String)


        m_controllerComunicazioni.CreateNew()
        m_controllerComunicazioni.Data = DateTime.Now
        m_controllerComunicazioni.SetUtente(recipient.Utente.Id.ToString)
        m_controllerComunicazioni.SetTipo("SMS")
        m_controllerComunicazioni.SetCausale(nomeCausale.ToUpper)
        m_controllerComunicazioni.Note = "(" + recipient.RecipientNumber + ") - " + text
        m_controllerComunicazioni.Save()


    End Sub

    Private Sub SaveComunicazioniToDb(iList As IList(Of SmsRecipient), text As String, nomeCampagna As String)
        CheckPrerequisites()

        If String.IsNullOrEmpty(nomeCampagna) Then
            nomeCampagna = String.Format("Sms del {0}", DateTime.Now.ToLongDateString)
        End If
        m_controllerCausaleComunicazioni.CheckIfExistCampagnaCreateIt(nomeCampagna)
        For Each elem As SmsRecipient In iList
            SaveComunicazioneToDb(elem, text, nomeCampagna)
        Next
    End Sub

    Private Sub CheckPrerequisites()
        'verifico che esista il tipo comunicazione SMS
        m_controllerTipoComunicazioni.CheckIfExistSmsTipoOrCreateIt()
        m_controllerCausaleComunicazioni.CheckIfExistSmsSingolaOrCreateIt()
    End Sub

End Class
