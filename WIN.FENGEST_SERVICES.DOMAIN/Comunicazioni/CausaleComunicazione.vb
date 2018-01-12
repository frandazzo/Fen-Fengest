Public Class CausaleComunicazione
   Inherits AbstractPersistenceObject
   Public Overrides Property Descrizione() As String
      Get
         Return MyBase.Descrizione
      End Get
      Set(ByVal value As String)
         If value = "" Then Throw New Exception("Impossibile creare una causale comunicazione. Descrizione nulla.")
         MyBase.Descrizione = UCase(value)
      End Set
   End Property
   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function
End Class
