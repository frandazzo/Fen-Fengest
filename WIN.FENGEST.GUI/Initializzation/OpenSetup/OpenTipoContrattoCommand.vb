Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenTipoContrattoCommand
   Inherits OpenCommand
   Private Id As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlTipoContratto(-1)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlTipoContratto(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Tipo contratto"
   End Function
   <Secure(Area:="Contratti", Alias:="Visualizzione", Macroarea:="Setup")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewTipoContratto", New OpenTipoContrattoCommand)
      Control.AddLinkCommand("CreateTipoContratto", New OpenNewTipoContrattoCommand)
   End Sub

End Class
