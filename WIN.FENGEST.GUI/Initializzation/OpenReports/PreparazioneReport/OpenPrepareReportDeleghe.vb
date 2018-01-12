Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY

<SecureContext()> _
Public Class OpenPrepareReportDeleghe
   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlPrepareRptDeleghe
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlPrepareRptDeleghe
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Prepara report deleghe"
   End Function
   <Secure(Area:="Reportistica", Alias:="Deleghe", Macroarea:="Reportistica")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewReport", New OpenRptDeleghe)
   End Sub
End Class
