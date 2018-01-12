'<SecureContext()> _
Public Class OpenNewAnagraficaAziendaCommand
   Inherits OpenCommand


   '<Secure(Area:="Aziende", Alias:="Creazione", Macroarea:="Anagrafiche")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      'SecurityManager.Instance.Check())
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("CreateAzienda", New OpenNewAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
      Control.AddLinkCommand("ViewOfferte", New OpenOfferteCommand)
   End Sub


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlAnagraficaAzienda
        control.StartCreateOperation()
      Return control
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Metodo non implementato del comando di apertura " & ObjectToOpenName())
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Azienda nuova"
   End Function
End Class
