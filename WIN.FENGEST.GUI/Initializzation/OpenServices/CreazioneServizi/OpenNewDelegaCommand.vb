'<SecureContext()> _
Public Class OpenNewDelegaCommand
   Inherits OpenCommand

   Private m_IdUtente As Int32

   ' <Secure(Area:="Deleghe", Alias:="Creazione", Macroarea:="Deleghe")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      'SecurityManager.Instance.Check()

      Control.AddLinkCommand("ViewDelega", New OpenDelegaCommand)
      Control.AddLinkCommand("CreateDelega", New OpenNewDelegaCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
      Control.AddLinkCommand("ViewSettore", New OpenSettoreCommand)
      Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      DelegheMediator.CheDelegaForCreation()
      Dim control As BrowserControl = New ControlDelega()
        control.StartCreateOperation()
        Return control
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Dim control As BrowserControl = New ControlDelega(m_IdUtente)
        control.StartCreateOperation()
        Return control
    End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Delega nuova"
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

      DelegheMediator.CheDelegaForCreation()
      Dim control As BrowserControl = DoCreateTargetControl(m_IdUtente)
      SetTargetControlReceviers(control)
      Return control


   End Function
End Class
