Public Class KnowHow
   Inherits AbstractPersistenceObject
   Private m_Abilita As Abilita
   Private m_Utente As Utente = New UtenteNonSpecificato
   Private m_Livello As LivelloAbilita
   Private m_Note As String = ""
   Public Property Note() As String
      Get
         Return m_Note
      End Get
      Set(ByVal value As String)
         m_Note = value
      End Set
   End Property

   Public Sub New()

   End Sub
   Public Sub New(ByVal Utente As Utente, ByVal Abilita As Abilita, ByVal Livello As LivelloAbilita)
      Me.Utente = Utente
      Me.Abilita = Abilita
      m_Livello = Livello
   End Sub
   Public Property Livello() As LivelloAbilita
      Get
         Return m_Livello
      End Get
      Set(ByVal value As LivelloAbilita)
         m_Livello = value
      End Set
   End Property


   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         If value Is Nothing Then Throw New ArgumentNullException("Attitudine: Utente")
         m_Utente = value
      End Set
   End Property

   Public Property Abilita() As Abilita
      Get
         Return m_Abilita
      End Get
      Set(ByVal value As Abilita)
         If value Is Nothing Then Throw New ArgumentNullException("Attitudine: Abilità")
         m_Abilita = value
      End Set
   End Property

End Class
