Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenSkillCommand
   Inherits OpenCommand

   <Secure(Area:="Skill", Alias:="Visualizzazione", Macroarea:="Setup")> _
     Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      SecurityManager.Instance.Check()
      Return New ControlAbilita
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Not implemented method")
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Skills"
   End Function
End Class
