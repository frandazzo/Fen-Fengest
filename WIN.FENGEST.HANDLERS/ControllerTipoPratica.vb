Public Class ControllerTipoPratica

    Public Function GetTipoPraticaById(id As Int32) As TipoPratica
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        Return ps.GetObject("TipoPratica", id)

    End Function

    Public Function GetAll() As IList
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        Dim query As Query = ps.CreateNewQuery("MapperTipoPratica")

        Return query.Execute(ps)
    End Function

    Public Sub SaveOrUpdateTipoPratica(tipoPratica As TipoPratica)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        If tipoPratica.Key Is Nothing Then
            'nuova pratica
            ps.InsertObject("TipoPratica", tipoPratica)

        Else

            ps.UpdateObject("TipoPratica", tipoPratica)


        End If



    End Sub


    
    Public Sub DeletePratica(pratica As TipoPratica)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        ps.DeleteObject("TipoPratica", pratica)


    End Sub

End Class

