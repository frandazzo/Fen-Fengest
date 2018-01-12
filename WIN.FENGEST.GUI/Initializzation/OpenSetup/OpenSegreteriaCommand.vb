Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
   Public Class OpenSegreteriaCommand
   Inherits OpenCommand
   Private Id As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlSegreteria
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlSegreteria
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Segreteria"
   End Function
   <Secure(Area:="Segreteria", Alias:="Visualizzazione", Macroarea:="Anagrafiche")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewSegreteria", New OpenSegreteriaCommand)
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
      Control.AddLinkCommand("ViewCompilazioneModelli", New OpenCompilazioneModelliCommand)


   End Sub
End Class
