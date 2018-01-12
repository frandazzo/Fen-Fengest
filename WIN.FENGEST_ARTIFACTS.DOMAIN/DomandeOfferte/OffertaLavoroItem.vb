Public Class OffertaLavoroItem
   Inherits AbstractPersistenceObject
   Private m_NumeroPosti As Int32 = 1
   Private m_Livello As LivelloAbilita
   Private m_Abilita As Abilita
   Private m_Offerta As OffertaLavoro

   Public Sub New(ByVal Offerta As OffertaLavoro, ByVal Livello As LivelloAbilita, ByVal Abilita As Abilita, ByVal NumeroPosti As Int32)
      Me.Offerta = Offerta
      Me.Abilita = Abilita
      m_NumeroPosti = NumeroPosti
      m_Livello = Livello
   End Sub

   Public Sub New()

   End Sub
   Public Property Offerta() As OffertaLavoro
      Get
         Return m_Offerta
      End Get
      Set(ByVal value As OffertaLavoro)
         If value Is Nothing Then Throw New ArgumentNullException("Offerta")
         m_Offerta = value
      End Set
   End Property

   Public Property NumeroPosti() As Int32
      Get
         Return m_NumeroPosti
      End Get
      Set(ByVal value As Int32)
         m_NumeroPosti = value
      End Set
   End Property

   Public Property Livello() As LivelloAbilita
      Get
         Return m_Livello
      End Get
      Set(ByVal value As LivelloAbilita)
         m_Livello = value
      End Set
   End Property

   Public Property Abilita() As Abilita
      Get
         Return m_Abilita
      End Get
      Set(ByVal value As Abilita)
         If value Is Nothing Then Throw New ArgumentNullException("Skill")
         m_Abilita = value
      End Set
   End Property

End Class
