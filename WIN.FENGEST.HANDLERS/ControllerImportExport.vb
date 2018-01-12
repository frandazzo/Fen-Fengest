Public Class ControllerImportExport


    Dim ps As IPersistenceFacade = DataAccessServices.Instance().PersistenceFacade

    Public Function GetAllImportExports() As IList


        Return ps.GetAllObjects("ImportExport")

    End Function


    Public Sub SaveOrUpdateImportExport(importExport As ImportExport)
        If importExport.Key Is Nothing Then
            ps.InsertObject("ImportExport", importExport)
        Else
            ps.UpdateObject("ImportExport", importExport)

        End If
    End Sub

End Class
