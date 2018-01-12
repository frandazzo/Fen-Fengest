Public Class OpenCommandFactory
    ' Implements IOpenCommandFactory


    Public Function GetOpenGetcommand(ByVal LinkCommandName As String) As IOpenCommand 'Implements IOpenCommandFactory.GetOpenCommand
        Select Case LinkCommandName
            Case "Home"
                Return New OpenHomePageCommand
            Case "OpenNewPagamento"
                Return New OpenNewPagamentoCommand
            Case "OpenNewRistorno"
                Return New OpenNewRistorno
            Case "OpenDocumento"
                Return New OpenDocumentoCommand
            Case "OpenAnagraficaConto"
                Return New OpenAnagraficaContoCommand
            Case "OpenNewAnagraficaConto"
                Return New OpenNewAnagraficaContoCommand
            Case "OpenNewAnagraficaUtente"
                Return New OpenNewAnagraficaUtenteCommand
            Case "OpenAnagraficaUtente"
                Return New OpenAnagraficaUtenteCommand
            Case "OpenNewAnagraficaReferente"
                Return New OpenNewAnagraficaReferenteCommand
            Case "OpenAnagraficaReferente"
                Return New OpenAnagraficaReferenteCommand
            Case "OpenNewAnagraficaAzienda"
                Return New OpenNewAnagraficaAziendaCommand
            Case "OpenAnagraficaAzienda"
                Return New OpenAnagraficaAziendaCommand
            Case "OpenNewDelega"
                Return New OpenNewDelegaCommand
            Case "OpenDelega"
                Return New OpenDelegaCommand
            Case "OpenSaldo"
                Return New OpenReportSaldiContoCommand
            Case "OpenCausaliRevoca"
                Return New OpenCausaliRevocaCommand
            Case "OpenTipoContratto"
                Return New OpenTipoContrattoCommand
            Case "OpenSettore"
                Return New OpenSettoreCommand
            Case "OpenEnte"
                Return New OpenEnteCommand
            Case "OpenInps"
                Return New OpenInpsCommand
            Case Else
                Throw New Exception("Impossibile ottenere il  comando di apertura richiesto. Tipo comando sconosciuto.")
        End Select
    End Function


 
End Class
