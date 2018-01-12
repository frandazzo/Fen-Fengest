Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenAnalisiDomandaCommand
   Inherits OpenCommand
   'Private ReportingService As Object = Nothing

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAnalisiDomandaLavoro()
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Not implemented metod")
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Analisi domanda lavoro"
   End Function

   <Secure(Area:="Analisi offerte lavoro", Alias:="Visualizzazione", Macroarea:="Servizi")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
   End Sub
End Class
