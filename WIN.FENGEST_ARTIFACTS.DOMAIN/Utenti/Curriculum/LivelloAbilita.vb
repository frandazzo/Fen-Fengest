Public Class LivelloAbilita
   Inherits AbstractPersistenceObject
   



   Public Overrides Property Descrizione() As String
      Get
         Return MyBase.Descrizione
      End Get
      Set(ByVal value As String)
         If value Is Nothing Then Throw New ArgumentNullException("Descrizione livello abilità")
         MyBase.Descrizione = value
      End Set
   End Property
   Public Overrides Function ToString() As String
      Return MyBase.Descrizione
   End Function
End Class
