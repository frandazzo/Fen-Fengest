Public Class LazyLoadEventi
   Inherits VirtualLazyList

   'Private ListLoader As MapperItemDocumentoContabile = PersistenceMapperRegistry.Instance.GetMapperByName("MapperItemDocumentoContabile")
   Private m_Vertenza As Vertenza
   Private query As Query

   Public Sub New(ByVal Vertenza As Vertenza)
      m_Vertenza = Vertenza
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         PrepareQuery()
         Source = query.Execute(DataAccessServices.Instance.PersistenceFacade)
      End If
      Return Source
   End Function

   Private Sub PrepareQuery()
      query = DataAccessServices.Instance.PersistenceFacade.CreateNewQuery("MapperEvento")
      Dim subCriteria As AbstractBoolCriteria = Criteria.Equal("ID", m_Vertenza.Id)
      Dim SubQry As SubQueryCriteria = New SubQueryCriteria("DB_VERTENZA", "ID")
      SubQry.AddCriteria(subCriteria)
      Dim MainCriteria As Criteria = Criteria.INClause("ID_VERTENZA", SubQry)
      query.AddWhereClause(MainCriteria)
   End Sub
End Class
