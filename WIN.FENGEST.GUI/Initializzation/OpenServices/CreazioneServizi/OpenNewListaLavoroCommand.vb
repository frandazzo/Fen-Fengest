Public Class OpenNewListaLavoroCommand
   Inherits OpenCommand


   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewLista", New OpenListaLivoroCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlListaLavoro
        control.StartCreateOperation()
      Return Control
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Metodo non implementato del comando di apertura " & ObjectToOpenName())
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Lista lavoro utenti"
   End Function
End Class
