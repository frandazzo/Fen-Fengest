Public Class LazyLoadAttitudini
   Inherits VirtualLazyList

   Private ListLoader As MapperKnowHow = PersistenceMapperRegistry.Instance.GetMapperByName("MapperKnowHow")
   Private m_Utente As Utente
   Private query As Query

   Public Sub New(ByVal Utente As Utente)
      m_Utente = Utente
   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindAttitudiniByUtente(m_Utente)
      End If
      Return Source
   End Function

 
End Class
