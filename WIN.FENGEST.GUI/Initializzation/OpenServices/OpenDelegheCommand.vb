Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenDelegheCommand
   Inherits OpenCommand



   Protected Overloads Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlVisualizzatoreDeleghe
   End Function
   Protected Overloads Overrides Function DoCreateTargetControl(ByVal IdDelega As Int32) As PRESENTATION.BrowserControl
      Try
         Return New ControlVisualizzatoreDeleghe(Me.m_IdObjectToOpen)
      Catch ex As Exception
         Return New ControlAnagraficaUtente(Me.m_IdObjectToOpen)
      End Try
   End Function


   Protected Overrides Function ObjectToOpenName() As String
      Return "Deleghe"
   End Function

   <Secure(Area:="Deleghe", Alias:="Visualizzazione lista deleghe utente", Macroarea:="Deleghe")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewDeleghe", New OpenDelegheCommand)
      Control.AddLinkCommand("ViewDelega", New OpenDelegaCommand)
      Control.AddLinkCommand("CreateDelega", New OpenNewDelegaCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("CreateUtente", New OpenNewAnagraficaUtenteCommand)
   End Sub


   Protected Overrides Function CreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      MyBase.m_IdObjectToOpen = Id
      Dim control As BrowserControl = DoCreateTargetControl(Id)
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
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id)
   End Sub




End Class
