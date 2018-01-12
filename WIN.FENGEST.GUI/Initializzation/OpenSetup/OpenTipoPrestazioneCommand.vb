Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenTipoPrestazioneCommand
   Inherits OpenCommand
   Private Id As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlTipoPrestazioni(-1)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlTipoPrestazioni(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Tipo prestazione"
   End Function

   <Secure(Area:="TipiPrestazioni", Alias:="Visualizzazione", Macroarea:="Setup")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewTipoPrestazione", New OpenTipoPrestazioneCommand)
      Control.AddLinkCommand("CreateTipoPrestazione", New OpenNewTipoPrestazioneCommand)
   End Sub
End Class
