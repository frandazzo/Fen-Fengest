Public Class AsyncNotifier

    Dim WithEvents svc As FenealgestServices.FenealgestwebServices
    Dim result As String

    Public Sub New()
        svc = New FenealgestServices.FenealgestwebServices()


    End Sub


    Public Sub NotifyUsage(provincia As String, regione As String)
        If String.IsNullOrEmpty(provincia) Then
            Return
        End If
        If String.IsNullOrEmpty(regione) Then
            Return
        End If
        svc.TraceUsageAsync(provincia, "FENEALGEST", regione)
    End Sub

    


    Private Sub svc_TraceUsageCompleted(sender As Object, e As FenealgestServices.TraceUsageCompletedEventArgs) Handles svc.TraceUsageCompleted
        If Not e.Error Is Nothing Then
            result = e.Error.Message
        Else
            result = e.Result
        End If


        '        File.AppendAllText("c://aaaa.txt", result);
    End Sub
End Class
