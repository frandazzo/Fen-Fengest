<System.Serializable()> Public Class IstitutoContrattuale
   Inherits AbstractPersistenceObject
   Public Sub New()

   End Sub
   Public Sub New(ByVal Descrizione As String)
      If Descrizione = "" Then Throw New Exception("Impossibile creare un nuovo istituto contrattuale. Descrizione nulla")
      MyBase.Descrizione = Descrizione
   End Sub
End Class
