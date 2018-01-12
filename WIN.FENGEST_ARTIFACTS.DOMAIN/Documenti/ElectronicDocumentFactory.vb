Public Class ElectronicDocumentFactory
   Public Shared Function CreateElectronicDocument(ByVal Target As AbstractPersistenceObject) As ElectronicDocument

      If Target.GetType.Name = "Utente" Then
         Dim doc As New ElectronicDocumentUtente
         doc.Target = Target
         Return doc
      ElseIf Target.GetType.Name = "Azienda" Then
         Dim doc As New ElectronicDocumentAzienda
         doc.Target = Target
         Return doc
      ElseIf Target.GetType.Name = "Segreteria" Then
         Dim doc As New ElectronicDocumentSegreteria
         doc.Target = Target
         Return doc
      Else
         Throw New Exception("Target documento elettronico sconosciuto")
      End If




   End Function

End Class
