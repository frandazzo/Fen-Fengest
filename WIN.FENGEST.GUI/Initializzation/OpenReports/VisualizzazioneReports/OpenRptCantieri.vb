
Public Class OpenRptCantieri
    Inherits OpenCommand
    Private ReportingService As Object = Nothing

    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Return New ReportCantieri(ReportingService)
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Throw New Exception("Not implemented metod")
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Report cantieri"
    End Function

    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        'Il controllo creato dal comando non è linkato a nessu altro controllo

        Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)


    End Sub

    Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
        Try
            ReportingService = WithParameter.Item("ReportingService")
        Catch ex As Exception
            Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
        End Try
        Open()
    End Sub
End Class
