Public Class OpenNewPraticaCommand
    Inherits OpenCommand
    Private m_IdUtente As Int32
    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        'Il controllo creato dal comando non è linkato a nessu altro controllo
        Control.AddLinkCommand("ViewPratica", New OpenPraticaCommand)
        Control.AddLinkCommand("CreatePratica", New OpenNewPraticaCommand)
        Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
        'Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
        'Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
        'Control.AddLinkCommand("ViewAvvocato", New OpenAnagraficaAvvocatoCommand)
    End Sub
    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Dim control As BrowserControl = New ControlPratica
        control.StartCreateOperation()
        Return control
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Dim control As BrowserControl = New ControlPratica(m_IdUtente, False, False)
        control.StartCreateOperation()
        Return control
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Pratica"
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
