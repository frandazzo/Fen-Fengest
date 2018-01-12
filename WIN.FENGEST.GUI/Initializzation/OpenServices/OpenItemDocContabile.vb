Public Class OpenItemDocContabile
   Inherits OpenCommand
   Private IdDoc As Int32 = -1
   Private IdPos As Int32 = -1
   Private Tipo As String = ""


   'Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
   '   Throw New Exception("Not implemented method")
   'End Function
   'Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
   '   Throw New Exception("Not implemented method")
   'End Function
   'Protected Overloads Function CreateTargetControl(ByVal Obj As Object) As BrowserControl
   '   Dim control As BrowserControl = DoCreateTargetControl(Obj)
   '   SetTargetControlReceviers(control)
   '   Return control
   'End Function
   'Protected Overloads Function DoCreateTargetControl(ByVal Obj As Object) As PRESENTATION.BrowserControl
   '   Return New ControlItemContabile(Obj)
   'End Function

   'Protected Overrides Function ObjectToOpenName() As String
   '   Return "Posizione Documento"
   'End Function
   'Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
   '   Control.AddLinkCommand("ViewPosizioneDocumento", New OpenItemDocContabile)
   'End Sub

   'Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
   '   'Se richiamo questo metodo di questo comando vuol dire che  ho un id
   '   'e che deve essere presentato l'offetto
   '   Dim controller As Object
   '   Try
   '      controller = WithParameter.Item("Controller")

   '   Catch ex As Exception
   '      Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
   '   End Try
   '   Open(controller)
   'End Sub
   'Public Overloads Sub Open(ByVal Obj As Object)
   '   Dim control As BrowserControl = CreateTargetControl(Obj)
   '   Forward(control)
   'End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlItemContabile(IdDoc, IdPos, Tipo)
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlItemContabile(IdDoc, IdPos, Tipo)
   End Function
   Protected Overrides Function ObjectToOpenName() As String
      Return "Posizione documento"
   End Function
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewPosizioneDocumento", New OpenItemDocContabile)
   End Sub
   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto

      Try
         IdDoc = WithParameter.Item("IdDocumento")
         IdPos = WithParameter.Item("IdPosizione")
         Tipo = WithParameter.Item("TipoDocumento")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open()
   End Sub

   'Protected Overrides Function CreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
   '   MyBase.m_IdObjectToOpen = Id
   '   Dim control As BrowserControl = DoCreateTargetControl()
   '   SetTargetControlReceviers(control)
   '   Return control
   'End Function
End Class
