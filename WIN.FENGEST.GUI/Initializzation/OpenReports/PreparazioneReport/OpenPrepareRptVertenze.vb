Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenPrepareRptVertenze
   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlPrepareRptVertenze
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlPrepareRptVertenze
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Prepara report vertenze"
   End Function
   <Secure(Area:="Reportistica", Alias:="Vertenze", Macroarea:="Reportistica")> _
    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewReport", New OpenRptVertenze)
   End Sub
End Class
