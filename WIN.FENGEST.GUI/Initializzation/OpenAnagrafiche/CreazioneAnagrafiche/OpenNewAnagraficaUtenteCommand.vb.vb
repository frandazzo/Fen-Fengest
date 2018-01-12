Public Class OpenNewAnagraficaUtenteCommand
   Inherits OpenCommand


   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("CreateUtente", New OpenNewAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
      Control.AddLinkCommand("ViewDelega", New OpenDelegaCommand)
      Control.AddLinkCommand("OpenDeleghe", New OpenDelegheCommand)
      Control.AddLinkCommand("OpenPrestazioni", New OpenPrestazioniCommand)
      Control.AddLinkCommand("OpenVertenze", New OpenVertenzeCommand)
      Control.AddLinkCommand("ViewProposte", New OpenProposteCommand)
      Control.AddLinkCommand("ViewComunicazioni", New OpenComunicazioniCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlAnagraficaUtente
        control.StartCreateOperation()
      Return Control
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Metodo non implementato del comando di apertura " & ObjectToOpenName())
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Utente nuovo"
   End Function
End Class
