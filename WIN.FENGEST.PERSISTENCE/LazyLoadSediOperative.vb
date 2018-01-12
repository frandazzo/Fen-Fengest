Public Class LazyLoadSediOperative
   Inherits VirtualLazyList

   'Private ListLoader As MapperItemDocumentoContabile = PersistenceMapperRegistry.Instance.GetMapperByName("MapperItemDocumentoContabile")
   Private m_Azienda As Azienda
   Private query As Query

   Public Sub New(ByVal Azienda As Azienda)
      m_Azienda = Azienda
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         PrepareQuery()
         Source = query.Execute(DataAccessServices.Instance.PersistenceFacade)
      End If
      Return Source
   End Function

   Private Sub PrepareQuery()
      query = DataAccessServices.Instance.PersistenceFacade.CreateNewQuery("MapperSedeOperativa")
      Dim subCriteria As AbstractBoolCriteria = Criteria.Equal("ID", m_Azienda.Id)
      Dim SubQry As SubQueryCriteria = New SubQueryCriteria("DB_AZIENDA", "ID")
      SubQry.AddCriteria(subCriteria)
      Dim MainCriteria As Criteria = Criteria.INClause("ID_AZIENDA", SubQry)
      query.AddWhereClause(MainCriteria)
   End Sub
End Class
