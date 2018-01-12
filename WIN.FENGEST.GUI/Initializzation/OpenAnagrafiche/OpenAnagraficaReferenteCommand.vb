Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY

<SecureContext()> _
Public Class OpenAnagraficaReferenteCommand
   Inherits OpenCommand

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAnagraficaReferente
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlAnagraficaReferente(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Referente"
   End Function

   <Secure(Area:="Referenti", Alias:="Visualizzazione", Macroarea:="Anagrafiche")> _
  Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
   End Sub

End Class
