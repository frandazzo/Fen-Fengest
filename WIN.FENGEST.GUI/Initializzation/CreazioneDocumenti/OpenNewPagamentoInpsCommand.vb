Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY


<SecureContext()> _
Public Class OpenNewPagamentoInpsCommand
   Inherits OpenCommand
   <Secure(Area:="Pagamenti quote Inps", Alias:="Creazione", Macroarea:="Amministrazione")> _
  Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non � linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non � linkato a nessu altro controllo
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlPagamentoQuoteInps
        control.StartCreateOperation()
      Return control
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Metodo non implementato del comando di apertura " & ObjectToOpenName())
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Pagamento nuovo"
   End Function
End Class
