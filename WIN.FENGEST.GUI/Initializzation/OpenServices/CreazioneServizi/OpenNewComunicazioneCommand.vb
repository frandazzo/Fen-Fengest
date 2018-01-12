Public Class OpenNewComunicazioneCommand
   Inherits OpenCommand
   Private m_IdUtente As Int32

   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewComunicazione", New OpenComunicazioneCommand)
      Control.AddLinkCommand("CreateComunicazione", New OpenNewComunicazioneCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlComunicazione
        control.StartCreateOperation()
        Return control
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Dim control As BrowserControl = New ControlComunicazione(m_IdUtente, False)
        control.StartCreateOperation()
        Return control
    End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Comunicazione"
   End Function
   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto

      Try
         m_IdUtente = WithParameter.Item("IdUtente")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(m_IdUtente)
   End Sub


   Protected Overloads Overrides Function CreateTargetControl(ByVal Id As Int32) As BrowserControl


      Dim control As BrowserControl = DoCreateTargetControl(m_IdUtente)
      SetTargetControlReceviers(control)
      Return control


   End Function
End Class
