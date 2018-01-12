Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web

Public Class SkebbySmsProvider


    Function skebbyGatewayGetCredit(username As String, password As String, Optional charset As String = "UTF-8") As Dictionary(Of String, String)
        Dim parameters, method As String
        Dim URL As String
        Dim result As New Dictionary(Of String, String)
        Dim values() As String
        Dim temp

        URL = "http://gateway.skebby.it/api/send/smseasy/advanced/http.php"
        method = "get_credit"

        parameters = "method=" + HttpUtility.UrlEncode(method) + "&" _
                   + "username=" + HttpUtility.UrlEncode(username) + "&" _
                   + "password=" + HttpUtility.UrlEncode(password)

        Select Case charset
            Case "UTF-8"
                parameters = parameters + "&charset=" + HttpUtility.UrlEncode("UTF-8")
            Case Else
        End Select

        ' Create POST
        Dim request As WebRequest = WebRequest.Create(URL)
        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(parameters)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As WebResponse
        Try
            'Trying to get the response.
            response = request.GetResponse()
        Catch ex As System.Net.WebException
            'result.Add("status", "failed")
            'result.Add("code", "0")
            'result.Add("message", "Network error, unable to send the message")
            'Return result
            Throw New Exception("Problema di rete! Inpossibile inviare il messaggio di richiesta del credito residuo.")
        End Try

        dataStream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Clean up the streams.
        reader.Close()
        dataStream.Close()
        response.Close()

        ' Return result to calling function
        If responseFromServer.Length > 0 Then
            values = responseFromServer.Split(New Char() {"&"c})
            For Each value As String In values
                temp = value.Split(New Char() {"="c})
                result.Add(temp(0), temp(1))
            Next
            Return result
        Else
            Throw New Exception("Nessuna risposta dal server")
        End If

    End Function




    Public Function skebbyGatewaySendSMS(
                         ByVal username As String, _
                         ByVal password As String, _
                         ByVal recipients() As String, _
                         ByVal text As String, _
                         Optional ByVal sms_type As SkebbySmsType = SkebbySmsType.classic, _
                         Optional ByVal sender_number As String = "", _
                         Optional ByVal sender_string As String = "", _
                         Optional ByVal user_reference As String = "", _
                         Optional ByVal charset As String = "UTF-8" _
                     ) As Dictionary(Of String, String)
        Dim parameters, method As String
        Dim URL As String
        Dim result As New Dictionary(Of String, String)
        Dim values() As String
        Dim temp

        URL = "http://gateway.skebby.it/api/send/smseasy/advanced/http.php"

        method = "send_sms_classic"

        Select Case sms_type

            Case SkebbySmsType.classic
                method = "send_sms_classic"
            Case SkebbySmsType.classic_plus
                method = "send_sms_classic_report"
            Case SkebbySmsType.basic
                method = "send_sms_basic"
            Case SkebbySmsType.test_classic
                method = "test_send_sms_classic"
            Case SkebbySmsType.test_classic_plus
                method = "test_send_sms_classic_report"
            Case SkebbySmsType.test_basic
                method = "test_send_sms_basic"
            Case Else
                method = "send_sms_classic"
        End Select

        parameters = "method=" + HttpUtility.UrlEncode(method) + "&" _
                    + "username=" + HttpUtility.UrlEncode(username) + "&" _
                    + "password=" + HttpUtility.UrlEncode(password) + "&" _
                    + "text=" + HttpUtility.UrlEncode(text) + "&" _
                    + "recipients[]=" + String.Join("&recipients[]=", recipients)

        If (sender_number <> "") And (sender_string <> "") Then
            'result.Add("status", "failed")
            'result.Add("code", "0")
            'result.Add("message", "You can specify only one type of sender, numeric or alphanumeric")
            'Return result
            Throw New Exception("Devi specificare un solo tipo di Sender: o quello numerico o quello alfanumerico!")
        End If

        If sender_number <> "" Then parameters = parameters + "&sender_number=" + HttpUtility.UrlEncode(sender_number)
        If sender_string <> "" Then parameters = parameters + "&sender_string=" + HttpUtility.UrlEncode(sender_string)
        If user_reference <> "" Then parameters = parameters + "&user_reference=" + HttpUtility.UrlEncode(user_reference)

        Select Case charset
            Case "UTF-8"
                parameters = parameters + "&charset=" + HttpUtility.UrlEncode("UTF-8")
            Case Else
        End Select

        ' Create POST
        Dim request As WebRequest = WebRequest.Create(URL)
        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(parameters)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As WebResponse
        Try
            'Trying to get the response.
            response = request.GetResponse()
        Catch ex As System.Net.WebException
            'result.Add("status", "failed")
            'result.Add("code", "0")
            'result.Add("message", "Network error, unable to send the message")
            'Return result
            Throw New Exception("Problema di rete! Inpossibile inviare il messagggio.")
        End Try

        dataStream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Clean up the streams.
        reader.Close()
        dataStream.Close()
        response.Close()

        ' Return result to calling function
        If responseFromServer.Length > 0 Then
            values = responseFromServer.Split(New Char() {"&"c})
            For Each value As String In values
                temp = value.Split(New Char() {"="c})
                result.Add(temp(0), temp(1))
            Next
            Return result


        Else
            Throw New Exception("Nessuna risposta dal server")
        End If


    End Function



End Class
