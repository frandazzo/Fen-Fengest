
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenNewPagamentoCommand
   Inherits OpenCommand


   <Secure(Area:="Pagamenti quote associative", Alias:="Creazione", Macroarea:="Amministrazione")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlPagamentoQuoteAssociative
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
