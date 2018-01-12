Public Class LazyLoadArchivioDocumentale
   Inherits VirtualLazyList

   Private ListLoader As MapperElectronicDocument '""= PersistenceMapperRegistry.Instance.GetMapperByName("MapperElectronicDocument")
   Private m_Target As AbstractPersistenceObject


   Public Sub New(ByVal Target As AbstractPersistenceObject)

      m_Target = Target

      Select Case m_Target.GetType.Name
         Case "Utente"
            'ListLoader.SetTable("DB_DOCUMENTI_UTENTE")
            'ListLoader.SetTargetKey("ID_UTENTE")
            ListLoader = PersistenceMapperRegistry.Instance.GetMapperByName("MapperElectronicDocumentUtente")
         Case "Azienda"
            'ListLoader.SetTable("DB_DOCUMENTI_AZIENDA")
            'ListLoader.SetTargetKey("ID_AZIENDA")
            ListLoader = PersistenceMapperRegistry.Instance.GetMapperByName("MapperElectronicDocumentAzienda")
         Case "Segreteria"
            'ListLoader.SetTable("DB_DOCUMENTI_SEGRETERIA")
            'ListLoader.SetTargetKey("ID_SEGRETERIA")
            ListLoader = PersistenceMapperRegistry.Instance.GetMapperByName("MapperElectronicDocumentSegreteria")
      End Select

   End Sub



   Protected Overrides Function GetList() As System.Collections.ArrayList
      If Source Is Nothing Then
         Source = ListLoader.FindDocumentsByTarget(m_Target)
      End If
      Return Source
   End Function
End Class
