Public Class LazyLoadFigli
   Inherits VirtualLazyList

   Private ListLoader As MapperFiglio = PersistenceMapperRegistry.Instance.GetMapperByName("MapperFiglio")
   Private m_Utente As Utente

   Public Sub New(ByVal Utente As Utente)
      m_Utente = Utente
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindFigliByUtente(m_Utente)
      End If
      Return Source
   End Function
End Class
