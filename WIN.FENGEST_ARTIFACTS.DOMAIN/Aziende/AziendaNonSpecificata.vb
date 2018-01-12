Public Class AziendaNonSpecificata
   Inherits Azienda
   Public Sub New()
      MyBase.Descrizione = ""
      MyBase.Key = New Key(-1)
   End Sub
End Class
