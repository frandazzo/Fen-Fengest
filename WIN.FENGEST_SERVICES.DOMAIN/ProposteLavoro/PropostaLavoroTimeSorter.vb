Public Class PropostaLavoroTimeSorter
   Inherits ServicesTimeSorter

   Public Sub New(ByVal lista As IList)
      MyBase.New(lista)
      comparer = New PropostaLavoroComparer("DataDocumento", False)
   End Sub
End Class
