
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenCompilazioneModelliCommand
   Inherits OpenCommand


    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl

        Return New ControlCompilazioneModelli1
    End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlCompilazioneModelli1
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Compilazione modelli"
   End Function

   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo

      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewSegreteria", New OpenSegreteriaCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)



   End Sub


End Class
