
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenPrepareRptLiberiDTO




   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlPrepareRptLibDTO
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlPrepareRptLibDTO
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Prepara report liberi"
   End Function
   <Secure(Area:="Reportistica", Alias:="Lavoratori liberi", Macroarea:="Reportistica")> _
  Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewReport", New OpenRptLiberiDTO)
   End Sub
End Class
