Public Class LazyLoadPosizioniConto
   Inherits VirtualLazyList

   Private ListLoader As MapperItemDocumentoContabile = PersistenceMapperRegistry.Instance.GetMapperByName("MapperItemDocumentoContabile")
   Private m_Conto As Conto

   Public Sub New(ByVal Conto As Conto)
      m_Conto = Conto
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindItemsByConto(m_Conto)
      End If
      Return Source
   End Function
End Class
