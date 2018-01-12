Public Class ContoNullo
   Inherits Conto
   Public Sub New()
      MyBase.Key = New Key(-1)
   End Sub
   Friend Overrides Sub AddItem(ByVal Item As ItemContabile)
      Throw New Exception("Impossibile aggiungere una nuova posizione contabile ad un tipo conto nullo. ")
   End Sub
End Class
