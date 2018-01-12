Imports WIN.TECHNICAL.PERSISTENCE

Public Class DelegheEdiliCounterRetriever

    Public Shared Function GetNumeroDelegheEdili(ByVal idUtente As Int32) As Int32

        If idUtente = -1 Then
            Return 0
        End If

        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        Dim number As Object = ps.ExecuteScalar(String.Format("select count(*) from db_delega where id_utente = {0} and id_settore = 2", idUtente))

        Try
            Return Convert.ToInt32(number)
        Catch ex As Exception
            Return 0
        End Try



    End Function
End Class
