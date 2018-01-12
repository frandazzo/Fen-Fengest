Public Class OpenSettoreCommand
   Inherits OpenCommand
   Private Id As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Throw New Exception("Metodo non implementato")
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw (New Exception("Not implemented method"))
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Settore"
   End Function
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewSettore", New OpenSettoreCommand)
      Control.AddLinkCommand("ViewTipoContratto", New OpenTipoContrattoCommand)
   End Sub
End Class
