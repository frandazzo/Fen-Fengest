Public Class LazyLoadInfos
   Inherits VirtualLazyList

   Private ListLoader As MapperInfo = PersistenceMapperRegistry.Instance.GetMapperByName("MapperInfo")
   Private m_Utente As Utente

   Public Sub New(ByVal Utente As Utente)
      m_Utente = Utente
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindInfoByUtente(m_Utente)
      End If
      Return Source
   End Function

End Class
