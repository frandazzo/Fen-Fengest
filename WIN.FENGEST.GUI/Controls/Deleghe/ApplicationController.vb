Public Class ApplicationController
    Public Shared Function GetControlForDelegaStatus(ByVal IdDelega As Int32, ByVal IdUtente As Int32) As BrowserControl
        Dim controller As New ADMINISTRATION.ControllerDeleghe
        Try
            controller.LoadById(IdUtente, IdDelega)
            Dim Status As String = controller.StatusDelega
            Select Case Status
                Case "Sottoscritta"
                    Return New ControlDelega(IdDelega, IdUtente)
                Case "Inoltrata"
                    Return New ControlDelegaInoltrata(IdDelega, IdUtente)
                Case "Accettata"
                    Return New ControlDelegaAccettata(IdDelega, IdUtente)
                Case "Attivata"
                    Return New ControlDelegaAttiva(IdDelega, IdUtente)
                Case "Annullata"
                    Return New ControlDelegaAnnullata(IdDelega, IdUtente)
                Case "Revocata"
                    Return New ControlDelegaRevocata(IdDelega, IdUtente)
                Case "Nullo"
                    Return New ControlHomePage
                Case Else
                    Throw New Exception("Impossibile creare un controllo delega. Tipo stato sconosciuto.")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function



    Public Shared Function GetDocumentController(ByVal TipoDocumento As String) As FINANCIAL_ARTIFACTS.AbstractDocumentController
        Return WIN.APPLICATION.FINANCIAL_ARTIFACTS.AbstractDocumentController.GetDocumentController(TipoDocumento)
    End Function
    Public Shared Function GetNewDocumentCommand(ByVal TipoDocumento As String) As String

        Select Case TipoDocumento
            Case "IQA"
                Return "CreateNewPagamento"
            Case "IQP"
                Return "CreateNewPagamentoPrevisionale"
            Case "IQI"
                Return "CreateNewPagamentoInps"
            Case "IQV"
                Return "CreateNewPagamentoVertenza"
            Case "PGR"
                Return "CreateNewRistorno"
            Case Else
                Throw New Exception("Impossibile ottenere un comando stringa. Tipo documento sconosciuto.")
        End Select

    End Function
End Class
