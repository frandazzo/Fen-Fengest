Public Class ComunicazioniTimeSorter
   Inherits ServicesTimeSorter

   Public Sub New(ByVal lista As IList)
      MyBase.New(lista)
      comparer = New ComunicazioniComparer("DataDocumento", False)
   End Sub
End Class
