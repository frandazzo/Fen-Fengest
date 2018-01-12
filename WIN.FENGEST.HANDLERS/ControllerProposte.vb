Public Class ControllerProposte
   Inherits AbstractController

   Private ControllerAziende As New AZIENDE.ControllerAziende
   Private controllerAbilita As New ControllerAbilita
   Private controllerLivelloAbilita As New ControllerLivelloAbilita
   Private controllerUtente As New UTENTI.ControllerUtenti
   Private controllerOfferte As New ControllerOfferteLavoro
   'Private m_CurrentItem As OffertaLavoroItem


   Public Sub New()

   End Sub





   Private Function Current() As PropostaLavoro
      Return DirectCast(m_current, PropostaLavoro)
   End Function

#Region "Proprietà oggetto"

   Public Property Note() As String
      Get
         Return Current.Note
      End Get
      Set(ByVal value As String)
         Current.Note = value
      End Set
   End Property
   Public Property DataDocumento() As DateTime
      Get
         Return Current.DataDocumento
      End Get
      Set(ByVal value As DateTime)
         Current.DataDocumento = value
      End Set
   End Property
   Public Property DataRegistrazione() As DateTime
      Get
         Return Current.DataRegistrazione
      End Get
      Set(ByVal value As DateTime)
         Current.DataRegistrazione = value
      End Set
   End Property

   Public ReadOnly Property IdProposta() As String
      Get
         Return Current.Id
      End Get
   End Property
   Public ReadOnly Property IdOfferta() As Int32
      Get
         Return Current.Offerta.Id
      End Get
   End Property

   Public Sub SetOfferta(ByVal IdOfferta As String)
      If Not IsNumeric(IdOfferta) Then Throw New Exception("Id offerta errato")
      Dim temp As Int32 = CType(IdOfferta, Int32)
      Current.Offerta = controllerOfferte.GetOffertaById(temp)
   End Sub

   Public ReadOnly Property GetListaSkill() As IList
      Get
         Return Current.Offerta.ListaSkill
      End Get
   End Property
   Public ReadOnly Property DescrizioneAbilita() As String
      Get
         Return Current.Abilita.Descrizione
      End Get
   End Property
   Public Sub SetAbilita(ByVal DescrizioneAbilita As String)
      If DescrizioneAbilita = "" Then
         Throw New ArgumentNullException("Offerta")
      End If
      Current.Abilita = controllerAbilita.GetAbilita(DescrizioneAbilita)
   End Sub

   Public ReadOnly Property IdUtente() As String
      Get
         Return Current.Utente.Id
      End Get
   End Property
   Public ReadOnly Property NomeUtente() As String
      Get
         Return Current.Utente.CompleteName
      End Get
   End Property
   Public Sub SetUtente(ByVal IdUtente As String)
      If Not IsNumeric(IdUtente) Then Throw New Exception("Id utente errato")
      Dim id As Int32 = CType(IdUtente, Int32)
      Current.Utente = controllerUtente.GetUtenteById(id)
   End Sub


   Public ReadOnly Property DescrizioneAziendaRichiedente() As String
      Get
         Return Current.Offerta.AziendaRichiedente.Descrizione
      End Get
   End Property




#End Region










   Public Overrides Function GetCategoryObject() As String
      Return "PropostaLavoro"
   End Function


   Friend Function GetPropostaById(ByVal Id As String) As PropostaLavoro
      If Id = -1 Then Return Nothing
      Me.LoadById(Id)
      Return Current()
   End Function


   Public Sub LoadAllByUtente(ByVal IdUtente As String)
      If Not IsNumeric(IdUtente) Then Throw New Exception("Id utente errato.")
      Dim query As Query = Ps.CreateNewQuery("MapperPropostaLavoro")
      Dim mainCriteria As Criteria = Criteria.Equal("ID_UTENTE", IdUtente)
      query.AddWhereClause(mainCriteria)
      DomainObjectList = query.Execute(Ps)
   End Sub
   Public Function GetProposteByUtente(ByVal IdUtente As String) As IList
      LoadAllByUtente(IdUtente)
      Return DomainObjectList
   End Function
   Public Overrides Sub CreateNew()
      m_current = New PropostaLavoro()
   End Sub





End Class

