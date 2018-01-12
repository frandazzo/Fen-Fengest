Public Class ContrattoNullo
   Inherits Contratto
   Public Sub New()
      MyBase.Descrizione = ""
      MyBase.Key = New Key(-1, -1)
   End Sub
End Class
