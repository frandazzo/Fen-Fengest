Public Class GridLoaderDocumentFactory
    Public Shared Function GetGridDocumentLoader(ByVal TipoDocumento As String, ByVal Grid As System.Windows.Forms.DataGridView) As AbstractGridLoader
        Select Case TipoDocumento
            Case "IQA"
                Return New GridLoaderViewIQA(Grid)
            Case "IQP"
                Return New GridLoaderViewIQP(Grid)
            Case "IQV"
                Return New GridLoaderViewIQV(Grid)
            Case "IQI"
                Return New GridLoaderViewIQI(Grid)
            Case "PGR"
                Return New GridLoaderViewPGR(Grid)
            Case Else
                Throw New Exception("Impossibile recuperare il caricatore della grigla. Tipo documento sconosciuto")
        End Select
    End Function
End Class
