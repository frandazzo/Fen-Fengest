
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenComunicazioneCommand
   Inherits OpenCommand
   'Private Id As Int32 = -1
   Private m_IdUtente As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlComunicazione(-1)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlComunicazione(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Comunicazione"
   End Function



   <Secure(Area:="Comunicazioni", Alias:="Visualizzazione", Macroarea:="Comunicazioni")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewComunicazione", New OpenComunicazioneCommand)
      Control.AddLinkCommand("CreateComunicazione", New OpenNewComunicazioneCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)



   End Sub

   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Try
         id = WithParameter.Item("Id")
         'm_IdUtente = WithParameter.Item("IdUtente")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id)
   End Sub

End Class
