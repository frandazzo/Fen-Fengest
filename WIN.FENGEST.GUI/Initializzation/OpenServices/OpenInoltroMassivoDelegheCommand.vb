
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenInoltroMassivoDelegheCommand
   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlInoltroDelega()
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlInoltroDelega
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Inoltro massivo deleghe"
   End Function
   <Secure(Area:="Elaborazioni massive", Alias:="Inoltro", Macroarea:="Deleghe")> _
  Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewDelega", New OpenDelegaCommand)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
   End Sub
End Class

