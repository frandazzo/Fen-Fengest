Public Class LazyLoadPosizioniQuoteVertenza
   Inherits VirtualLazyList

   'Private ListLoader As MapperItemDocumentoContabile = PersistenceMapperRegistry.Instance.GetMapperByName("MapperItemDocumentoContabile")
   Private m_Pagamento As IncassoQuotaVertenza
   Private query As Query

   Public Sub New(ByVal Pagamento As IncassoQuotaVertenza)
      m_Pagamento = Pagamento
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         PrepareQuery()
         Source = query.Execute(DataAccessServices.Instance.PersistenceFacade)
      End If
      Return Source
   End Function

   Private Sub PrepareQuery()
      query = DataAccessServices.Instance.PersistenceFacade.CreateNewQuery("MapperItemDocumentoContabile")
      Dim maincriteria As AndExp = New AndExp(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQV'"), Criteria.Equal("ID_DOCUMENTO_CONTABILE", m_Pagamento.Key.Value(0)))
      query.AddWhereClause(maincriteria)
   End Sub
End Class
