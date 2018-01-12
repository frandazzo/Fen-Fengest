
Public Class OpenRptPrestazioni
   Inherits OpenCommand
   Private ReportingService As Object = Nothing

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ReportPrestazioni(ReportingService)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Throw New Exception("Not implemented metod")
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Report prestazioni"
   End Function

   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)  
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewPrestazione", New OpenPrestazioneCommand)

   End Sub

   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto

      Try
         ReportingService = WithParameter.Item("ReportingService")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open()
   End Sub
End Class
