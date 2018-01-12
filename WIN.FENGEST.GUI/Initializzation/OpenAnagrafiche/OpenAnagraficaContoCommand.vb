Public Class OpenAnagraficaContoCommand
   Inherits OpenCommand
   Private IdConto As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAnagraficaConto
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlAnagraficaConto(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Conto"
   End Function
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
   End Sub
End Class
