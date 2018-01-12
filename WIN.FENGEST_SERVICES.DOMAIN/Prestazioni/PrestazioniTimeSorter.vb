Public Class PrestazioniTimeSorter
   Inherits ServicesTimeSorter

   Public Sub New(ByVal lista As IList)
      MyBase.New(lista)
      comparer = New PrestazioniComparer("DataDocumento", False)
   End Sub
End Class
