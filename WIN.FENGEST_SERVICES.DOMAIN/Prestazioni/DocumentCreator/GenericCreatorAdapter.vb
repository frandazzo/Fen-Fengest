Public Class GenericCreatorAdapter
   Implements IDocumentCreatorAdapter


   Public Sub CreateDocument(ByVal Prestazione As Prestazione) Implements IDocumentCreatorAdapter.CreateDocument
      Dim m_TipoPrestazione As TipoPrestazione = CType(Prestazione.TipoPrestazione, TipoPrestazione)

      With m_TipoPrestazione
         If .FileModelloExist Then
            Prestazione.SetFileOutput(.GetFileOutputName(Prestazione.Utente))
            My.Computer.FileSystem.CopyFile(.NomeFileModello, Prestazione.FileOutPut)
         End If
      End With
   End Sub
End Class
