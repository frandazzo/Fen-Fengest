Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenDelegaCommand
   Inherits OpenCommand
   Private m_IdUtente As Int32 = -1


   Protected Overloads Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlDelega
   End Function
   Protected Overloads Overrides Function DoCreateTargetControl(ByVal IdDelega As Int32) As PRESENTATION.BrowserControl
      Return New ControlDelega(IdDelega, m_IdUtente)
   End Function


   Protected Overrides Function ObjectToOpenName() As String
      Return "Delega"
   End Function
   <Secure(Area:="Deleghe", Alias:="Visualizzazione", Macroarea:="Deleghe")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewDelega", New OpenDelegaCommand)
      Control.AddLinkCommand("CreateDelega", New OpenNewDelegaCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
      Control.AddLinkCommand("ViewSettore", New OpenSettoreCommand)
      Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
   End Sub


   Protected Overrides Function CreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      MyBase.m_IdObjectToOpen = Id
      Dim control As BrowserControl = ControlDelegaFactory.GetControlDelega(Id, m_IdUtente)
      SetTargetControlReceviers(control)
      Return control
   End Function

   'Public Overloads Overrides Sub Execute()
   '   If MyBase.m_IdObjectToOpen = -1 Then
   '      'apri per la ricerca 
   '      Open()
   '   Else
   '      'Apri in visualizzazione
   '      Open(MyBase.m_IdObjectToOpen)
   '   End If
   'End Sub
   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Try
         id = WithParameter.Item("Id")
         m_IdUtente = WithParameter.Item("IdUtente")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id)
   End Sub




   Public Class ControlDelegaFactory
      Shared Function GetControlDelega(ByVal IdDelega As Int32, ByVal IdUtente As Int32) As BrowserControl
         Return ApplicationController.GetControlForDelegaStatus(IdDelega, IdUtente)
      End Function
   End Class


End Class
