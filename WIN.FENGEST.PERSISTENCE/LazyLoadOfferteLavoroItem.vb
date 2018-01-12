Public Class LazyLoadOfferteLavoroItem
   Inherits VirtualLazyList

   Private ListLoader As MapperOffertaLavoroItem = PersistenceMapperRegistry.Instance.GetMapperByName("MapperOffertaLavoroItem")
   Private m_Offerta As OffertaLavoro

   Public Sub New(ByVal Offerta As OffertaLavoro)
      m_Offerta = Offerta
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindItemsByOfferta(m_Offerta)
      End If
      Return Source
   End Function
End Class
