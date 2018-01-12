
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenAnagraficaAvvocatoCommand
   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAnagraficaAvvocato
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      'Try
      Return New ControlAnagraficaAvvocato(Id)
      'Catch ex As Exception
      '   Throw New Exception(ex.Message)
      'End Try

   End Function


   <Secure(Area:="Collaboratori", Alias:="Visualizzazione", Macroarea:="Avvocati")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewAvvocato", New OpenAnagraficaAvvocatoCommand)
      Control.AddLinkCommand("CreateAvvocato", New OpenNewAnagraficaAvvocatoCommand)


   End Sub
   Protected Overrides Function ObjectToOpenName() As String
      Return "Avvocato"
   End Function
   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Dim clearCache As Boolean = False
      Try
         id = WithParameter.Item("Id")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id)
   End Sub










End Class
