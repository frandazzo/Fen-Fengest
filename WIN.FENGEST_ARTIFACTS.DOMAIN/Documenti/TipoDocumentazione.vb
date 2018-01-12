Public Class TipoDocumentazione
   Inherits AbstractPersistenceObject
   Implements IComparable

   Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
      If obj Is Nothing Then
         Return 1
      End If
      


      Dim other As TipoDocumentazione = CType(obj, TipoDocumentazione)

      If other.Descrizione Is Nothing Then
         Return 1
      End If

      Return StrComp(Descrizione, other.Descrizione)

   End Function



   Protected Overrides Sub DoValidation()
      If MyBase.Descrizione = "" Then
         ValidationErrors.Add("Descrizione nulla")
      End If
   End Sub

   Public Overrides Function ToString() As String
      Return MyBase.Descrizione
   End Function


   Public Shared Function CreaTipoPrestazione() As TipoDocumentazione
      Dim tipo As New TipoDocumentazione
      tipo.Key = New Key(-2)
      tipo.Descrizione = "PRESTAZIONI"
      Return tipo
   End Function



   Public Shared Function CreaTipoComunicazione() As TipoDocumentazione
      Dim tipo As New TipoDocumentazione
      tipo.Key = New Key(-1)
      tipo.Descrizione = "COMUNICAZIONI"
      Return tipo
   End Function




   Public Shared Function CreaTipoVertenza() As TipoDocumentazione
      Dim tipo As New TipoDocumentazione
      tipo.Key = New Key(-3)
      tipo.Descrizione = "VERTENZE"
      Return tipo
   End Function

End Class
