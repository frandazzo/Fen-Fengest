Public Class LazyLoadPosizioniRistornate
   Inherits VirtualLazyList

   Private ListLoader As MapperItemDocumentoContabile = PersistenceMapperRegistry.Instance.GetMapperByName("MapperItemDocumentoContabile")
   Private m_Pagamento As PagamentoReferenti

   Public Sub New(ByVal Pagamento As PagamentoReferenti)
      m_Pagamento = Pagamento
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindItemsRistornateByPagamentoReferente(m_Pagamento)
      End If
      Return Source
   End Function
End Class
