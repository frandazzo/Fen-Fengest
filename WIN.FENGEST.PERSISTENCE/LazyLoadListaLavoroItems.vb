Public Class LazyLoadListaLavoroItems
   Inherits VirtualLazyList

   Private ListLoader As MapperListaLavoroUtenti = PersistenceMapperRegistry.Instance.GetMapperByName("MapperListaLavoroUtenti")
   Private m_lista As ListaLavoroUtenti
   Private query As Query

   Public Sub New(ByVal lista As ListaLavoroUtenti)
      m_lista = lista
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindListaUtenti(m_lista)
      End If
      Return Source
   End Function
End Class
