Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenOffertaCommand
   Inherits OpenCommand
   'Private Id As Int32 = -1
   Private m_IdAzienda As Int32 = -1

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlOffertaLavoro(-1)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlOffertaLavoro(Id)
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Offerta"
   End Function
   <Secure(Area:="Domande lavoro", Alias:="Visualizzazione", Macroarea:="Servizi")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      SecurityManager.Instance.Check()
      'Il controllo creato dal comando non � linkato a nessu altro controllo
      Control.AddLinkCommand("ViewOfferta", New OpenOffertaCommand)
      Control.AddLinkCommand("CreateOfferta", New OpenNewOffertaCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)

   End Sub

   'Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
   '   'Se richiamo questo metodo di questo comando vuol dire che  ho un id
   '   'e che deve essere presentato l'offetto
   '   Dim id As Int32
   '   Try
   '      id = WithParameter.Item("Id")
   '      'm_IdUtente = WithParameter.Item("IdUtente")
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poich� non esiste un identificativo.")
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
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poich� non esiste un identificativo.")
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
      Return New ControlOffertaLavoro(Id, ClearCache)
   End Function

End Class
