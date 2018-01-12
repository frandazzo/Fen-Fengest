Public Class OpenNewOffertaCommand
   Inherits OpenCommand
   Private m_IdAzienda As Int32
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      Control.AddLinkCommand("ViewOfferta", New OpenOffertaCommand)
      Control.AddLinkCommand("CreateOfferta", New OpenNewOffertaCommand)
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
   End Sub
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Dim control As BrowserControl = New ControlOffertaLavoro
        control.StartCreateOperation()
        Return control
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Dim control As BrowserControl = New ControlOffertaLavoro(m_IdAzienda, False, False)
        control.StartCreateOperation()
        Return control
    End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Offerta"
   End Function
   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto

      Try
         m_IdAzienda = WithParameter.Item("IdAzienda")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(m_IdAzienda)
   End Sub


   Protected Overloads Overrides Function CreateTargetControl(ByVal Id As Int32) As BrowserControl


      Dim control As BrowserControl = DoCreateTargetControl(m_IdAzienda)
      SetTargetControlReceviers(control)
      Return control


   End Function

End Class
