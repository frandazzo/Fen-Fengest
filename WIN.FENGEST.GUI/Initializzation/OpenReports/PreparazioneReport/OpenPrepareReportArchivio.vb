
<SecureContext()> _
Public Class OpenPrepareReportArchivio
    Inherits OpenCommand


    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Return New ControlPrepareRptdocumenti
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Return New ControlPrepareRptdocumenti
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Prepara report archivio documenti"
    End Function
    <Secure(Area:="Reportistica", Alias:="Archivio documenti", Macroarea:="Reportistica")> _
    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        SecurityManager.Instance.Check()
        'Il controllo creato dal comando non è linkato a nessu altro controllo
        Control.AddLinkCommand("ViewReport", New OpenReportArchivio)
    End Sub
End Class

