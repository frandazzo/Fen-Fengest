Public Class PropostaLavoro
   Inherits AbstractPersistenceObject
   Implements IDocumento
   Private m_Dataregistrazione As DateTime
   Private m_DataDocumento As DateTime
   Private m_Note As String
   Private m_Abilita As Abilita
   Private m_Offerta As OffertaLavoro
   Private m_Utente As Utente


   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         m_Utente = value
      End Set
   End Property

   Public Property Offerta() As OffertaLavoro
      Get
         Return m_Offerta
      End Get
      Set(ByVal value As OffertaLavoro)
         If value Is Nothing Then Throw New ArgumentNullException("Offerta")
         m_Offerta = value
      End Set
   End Property
   'Public Property Preferenza() As Preferenza
   '   Get
   '      Return m_Preferenza
   '   End Get
   '   Set(ByVal value As Preferenza)
   '      If value Is Nothing Then Throw New ArgumentNullException("Preferenza")
   '      m_Preferenza = value
   '   End Set
   'End Property

   Public Property Abilita() As Abilita
      Get
         Return m_Abilita
      End Get
      Set(ByVal value As Abilita)
         m_Abilita = value
      End Set
   End Property

   Public Property DataDocumento() As Date Implements BASEREUSE.IDocumento.DataDocumento
      Get
         Return m_DataDocumento
      End Get
      Set(ByVal value As Date)
         m_DataDocumento = value
      End Set
   End Property

   Public Property DataRegistrazione() As Date Implements BASEREUSE.IDocumento.DataRegistrazione
      Get
         Return m_Dataregistrazione
      End Get
      Set(ByVal value As Date)
         m_Dataregistrazione = value
      End Set
   End Property

   Public Function GetId() As Integer Implements BASEREUSE.IDocumento.GetId
      Return MyBase.Id
   End Function

   Public Property Note() As String Implements BASEREUSE.IDocumento.Note
      Get
         Return m_Note
      End Get
      Set(ByVal value As String)
         m_Note = value
      End Set
   End Property

   Public ReadOnly Property TipoDocumento() As String Implements BASEREUSE.IDocumento.TipoDocumento
      Get
         Return "OFL"
      End Get
   End Property

   Public Overrides Function ToString() As String Implements BASEREUSE.IDocumento.ToString
      Return MyBase.Id
   End Function

   Protected Overrides Sub DoValidation()
      If m_Abilita Is Nothing Then
         ValidationErrors.Add("Skill nullo per la proposta di lavoro")
      End If
      If m_Utente Is Nothing Then
         ValidationErrors.Add("Utente nullo per la proposta di lavoro")
      End If
      If m_Offerta Is Nothing Then
         ValidationErrors.Add("Offerta nulla per la proposta di lavoro")
      End If

      Dim trovato As Boolean = False
      If Not m_Utente Is Nothing Then
         For Each elem As Abilita In m_Utente.AbilitaPreferite
            If Not m_Abilita Is Nothing Then
               If m_Abilita.Key.LongValue = elem.Key.LongValue Then
                  trovato = True
                  Exit For
               End If
            End If
         Next
      End If
      If trovato = False Then
         ValidationErrors.Add("Abilita non compresa tra le preferenze dell'utente")
      End If

      If Not m_Offerta Is Nothing Then
         If Not m_Abilita Is Nothing Then
            If Not m_Offerta.ContainsSkill(m_Abilita) Then
               ValidationErrors.Add("Lo skill non è richiesto dall'offerta di lavoro")
            End If
         End If
      End If




   End Sub


End Class
