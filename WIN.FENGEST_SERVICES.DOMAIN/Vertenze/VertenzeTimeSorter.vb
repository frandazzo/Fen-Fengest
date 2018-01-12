Public Class VertenzeTimeSorter
   Inherits ServicesTimeSorter

   Public Sub New(ByVal lista As IList)
      MyBase.New(lista)
      comparer = New VertenzeComparer("DataDocumento", False)
   End Sub

End Class
