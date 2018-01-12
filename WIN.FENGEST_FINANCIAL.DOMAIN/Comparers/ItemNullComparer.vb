Public Class ItemNullComparer
   Implements IComparer

   Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
      Return 0
   End Function
End Class
