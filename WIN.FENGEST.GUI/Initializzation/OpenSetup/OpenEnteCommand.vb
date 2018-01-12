Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenEnteCommand
   Inherits OpenCommand
   Private Id As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlEnteBilaterale(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Ente bilaterale"
   End Function
   <Secure(Area:="Enti bilaterali", Alias:="Visualizzazione", Macroarea:="Anagrafiche")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
   End Sub
End Class
