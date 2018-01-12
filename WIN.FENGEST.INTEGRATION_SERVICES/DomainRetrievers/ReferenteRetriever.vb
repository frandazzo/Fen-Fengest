Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS

Public Class ReferenteRetriever
    Private Shared ControllerReferente As New ControllerReferenti


    Public Shared Function GetIdReferente(ByVal nome As String, ByVal cognome As String) As Int32



        Dim id As String = -1


        Return ControllerReferente.GetIdReferente(nome, cognome)







    End Function

End Class
