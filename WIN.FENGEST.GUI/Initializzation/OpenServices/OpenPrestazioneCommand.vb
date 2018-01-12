Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenPrestazioneCommand
   Inherits OpenCommand
   Private Id As Int32 = -1


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl

      Return New ControlPrestazioni(-1)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlPrestazioni(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Prestazione"
   End Function
   Public Overrides Sub SetCommandParameters(ByVal WitParameter1 As System.Collections.Hashtable)
      MyBase.SetCommandParameters(WitParameter1)
   End Sub
   <Secure(Area:="Prestazioni", Alias:="Visualizzazione", Macroarea:="Servizi")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewPrestazione", New OpenPrestazioneCommand)
      Control.AddLinkCommand("CreatePrestazione", New OpenNewPrestazioneCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewTipoPrestazione", New OpenTipoPrestazioneCommand)
   End Sub

   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Try
         id = WithParameter.Item("Id")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id)
   End Sub
End Class
