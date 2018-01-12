Public Class DelegheTimeSorter
   Inherits ServicesTimeSorter


   Public Sub New(ByVal lista As IList)
      MyBase.New(lista)
      comparer = New DelegheComparer("DataDocumento", False)
   End Sub

End Class
