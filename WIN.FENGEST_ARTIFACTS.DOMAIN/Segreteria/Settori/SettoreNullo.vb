Public Class SettoreNullo
   Inherits Settore
   Public Sub New()
      MyBase.Key = New Key(-1)
      MyBase.Descrizione = "Settore nullo"
   End Sub
End Class
