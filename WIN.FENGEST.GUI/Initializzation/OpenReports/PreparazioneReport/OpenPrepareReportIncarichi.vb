<SecureContext()> _
Public Class OpenPrepareReportIncarichi
    Inherits OpenCommand


    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Return New ControlPrepareReportIncarichi
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Return New ControlPrepareReportIncarichi
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Prepara report incarichi"
    End Function
    <Secure(Area:="Reportistica", Alias:="Incarichi", Macroarea:="Reportistica")> _
    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        SecurityManager.Instance.Check()
        'Il controllo creato dal comando non è linkato a nessu altro controllo
        Control.AddLinkCommand("ViewReport", New OpenRptIncarichi)
    End Sub
End Class


