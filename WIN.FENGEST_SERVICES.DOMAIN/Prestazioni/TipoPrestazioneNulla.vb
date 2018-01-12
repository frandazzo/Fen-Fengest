Public Class TipoPrestazioneNulla
   Inherits TipoPrestazione
   Public Sub New()
      MyBase.Key = New Key(-1)
      MyBase.PathOutPut = ""
   End Sub
   Public Overrides Function FileModelloExist() As Boolean
      Throw New Exception("Impossibile verificare l'esistenza del file di modello. Tipo prestazione nulla")
   End Function
   Public Overrides Function PathOutputExist() As Boolean
      Throw New Exception("Impossibile verificare l'esistenza del percorso di output. Tipo prestazione nulla")
   End Function
End Class
