Public Class DataInfoRetrieverFactory
    Public Shared Function GetDataInfoRetriever(type As RetrieverType, filename As String) As DataInfoRetriever
        If type = RetrieverType.Inps Then
            Return New DataRetireverInps(filename)
        ElseIf type = RetrieverType.IQI Then
            Return New DataRetrieverIQI(filename)
        End If
        Throw New ArgumentException("Tipo di retriever non definito")

    End Function


    Public Enum RetrieverType
        Inps
        IQI
    End Enum


End Class
