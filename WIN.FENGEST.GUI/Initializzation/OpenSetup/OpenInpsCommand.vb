Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenInpsCommand
   Inherits OpenCommand
   Private Id As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlInps
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlInps
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Inps"
   End Function
   <Secure(Area:="Inps", Alias:="Visualizzazione", Macroarea:="Anagrafiche")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewInps", New OpenInpsCommand)
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
   End Sub
End Class
