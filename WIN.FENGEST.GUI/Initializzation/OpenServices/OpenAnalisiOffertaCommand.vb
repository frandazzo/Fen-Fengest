Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenAnalisiOffertaCommand
   Inherits OpenCommand
   'Private ReportingService As Object = Nothing

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAnalisiOffertaLavoro()
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Not implemented metod")
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Analisi offerta lavoro"
   End Function

   <Secure(Area:="Analisi domande lavoro", Alias:="Visualizzazione", Macroarea:="Servizi")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non � linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewOfferta", New OpenOffertaCommand)
   End Sub

   'Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
   '   'Se richiamo questo metodo di questo comando vuol dire che  ho un id
   '   'e che deve essere presentato l'offetto

   '   Try
   '      ReportingService = WithParameter.Item("ReportingService")
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poich� non esiste un identificativo.")
   '   End Try
   '   Open()
   'End Sub
End Class
