<SecureContext()> _
Public Class OpenPrepareReportCantieri
    Inherits OpenCommand


    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Return New ControlPrepareRptCantiere
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Return New ControlPrepareRptCantiere
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Prepara report cantieri"
    End Function
    <Secure(Area:="Reportistica", Alias:="Cantieri", Macroarea:="Reportistica")> _
    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        SecurityManager.Instance.Check()
        'Il controllo creato dal comando non è linkato a nessu altro controllo
        Control.AddLinkCommand("ViewReport", New OpenRptCantieri)
    End Sub
End Class



