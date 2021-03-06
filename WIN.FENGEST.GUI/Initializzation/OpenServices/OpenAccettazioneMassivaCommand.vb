
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenAccettazioneMassivaCommand
   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAccettazioneDelega
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlAccettazioneDelega
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Accettazione massiva deleghe"
   End Function
   <Secure(Area:="Elaborazioni massive", Alias:="Accettazione", Macroarea:="Deleghe")> _
  Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewDelega", New OpenDelegaCommand)
      'Il controllo creato dal comando non � linkato a nessu altro controllo
   End Sub
End Class
