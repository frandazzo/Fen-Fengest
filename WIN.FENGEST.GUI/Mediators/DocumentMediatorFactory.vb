Public Class DocumentMediatorFactory
   Public Shared Function GetDocumentMediator(ByVal ForDocumentType As String) As IDocumentViewMediator
        Select Case ForDocumentType
            Case "IQA"
                Return New DocumentIQAMediator
            Case "IQP"
                Return New DocumentIQPMediator
            Case "IQV"
                Return New DocumentIQVMediator
            Case "IQI"
                Return New DocumentIQIMediator
            Case "PGR"
                Return New DocumentPGRMediator
            Case Else
                Throw New Exception("Impossibile ottenere il mediator del documento. Tipo documento sconosciuto.")
        End Select
   End Function

End Class
