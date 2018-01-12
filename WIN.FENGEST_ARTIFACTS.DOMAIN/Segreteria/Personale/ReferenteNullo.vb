Public Class ReferenteNullo
   Inherits Referente
   Public Sub New()
      MyBase.PercRistornoDeleghe = 0
      MyBase.Key = New Key(-1)
   End Sub
End Class
