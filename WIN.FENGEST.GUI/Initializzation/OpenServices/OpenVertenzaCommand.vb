Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenVertenzaCommand
   Inherits OpenCommand
   'Private Id As Int32 = -1


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlVertenza(-1)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlVertenza(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Vertenza"
   End Function
   <Secure(Area:="Vertenze", Alias:="Visualizzazione", Macroarea:="Servizi")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewVertenza", New OpenVertenzaCommand)
      Control.AddLinkCommand("CreateVertenza", New OpenNewVertenzaCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewAvvocato", New OpenAnagraficaAvvocatoCommand)

   End Sub

   'Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
   '   'Se richiamo questo metodo di questo comando vuol dire che  ho un id
   '   'e che deve essere presentato l'offetto
   '   Dim id As Int32
   '   Try
   '      id = WithParameter.Item("Id")
   '      'm_IdUtente = WithParameter.Item("IdUtente")
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
   '   End Try
   '   Open(id)
   'End Sub



   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Dim clearCache As Boolean = False
      Try
         id = WithParameter.Item("Id")
         If WithParameter.ContainsKey("ClearCache") Then
            clearCache = WithParameter.Item("ClearCache")
         End If
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id, clearCache)
   End Sub


   Protected Overloads Sub Open(ByVal Id As Int32, ByVal ClearCache As Boolean)
      Dim control As BrowserControl = CreateTargetControl(Id, ClearCache)
      Forward(control)
   End Sub


   Protected Overloads Function CreateTargetControl(ByVal Id As Int32, ByVal ClearCache As Boolean) As BrowserControl

      MyBase.m_IdObjectToOpen = Id
      Dim control As BrowserControl = DoCreateTargetControl(Id, ClearCache)
      SetTargetControlReceviers(control)
      Return control


   End Function

   Protected Overloads Function DoCreateTargetControl(ByVal Id As Int32, ByVal ClearCache As Boolean) As PRESENTATION.BrowserControl
      Return New ControlVertenza(Id, ClearCache)
   End Function



End Class
