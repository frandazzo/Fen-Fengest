Public Class ControllerOfferteLavoro
   Inherits AbstractController

   Private ControllerAziende As New AZIENDE.ControllerAziende
   Private controllerAbilita As New ControllerAbilita
   Private controllerLivelloAbilita As New ControllerLivelloAbilita

   Private m_CurrentItem As OffertaLavoroItem


   Public Sub New()

   End Sub


   Public Sub New(ByVal OpenTransaction As Boolean)
      If OpenTransaction Then
         Ps.BeginTransaction()
      End If
   End Sub


   Private Function Current() As OffertaLavoro
      Return DirectCast(m_current, OffertaLavoro)
   End Function

#Region "Proprietà oggetto"
   Public ReadOnly Property DataInizioValidita() As DateTime
      Get
         Return Current.Validita.Start
      End Get
   End Property
   Public ReadOnly Property DataFineValidita() As DateTime
      Get
         Return Current.Validita.Finish
      End Get
   End Property
   Public Property Note() As String
      Get
         Return Current.Note
      End Get
      Set(ByVal value As String)
         Current.Note = value
         Ps.MarkDirty(m_current)
      End Set
   End Property
  
   Public Property Data() As DateTime
      Get
         Return Current.Data
      End Get
      Set(ByVal value As DateTime)
         Current.Data = value
         Ps.MarkDirty(m_current)
      End Set
   End Property


   Public ReadOnly Property IdOfferta() As String
      Get
         Return Current.Id
      End Get
   End Property

 

 
   Public ReadOnly Property DescrizioneAzienda() As String
      Get
         Return Current.AziendaRichiedente.Descrizione
      End Get
   End Property
   Public ReadOnly Property IdAzienda() As Int32
      Get
         Return Current.AziendaRichiedente.Id
      End Get
   End Property
   Public Sub SetAzienda(ByVal IdAzienda As String)
      If Not IsNumeric(IdAzienda) Then Throw New Exception("Id azienda errato.")
      Current.AziendaRichiedente = ControllerAziende.GetAziendaById(IdAzienda)
      Ps.MarkDirty(m_current)
   End Sub




   Public Sub SetValidita(ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
      Dim datar As New DataRange(DataInizio, DataFine)
      Current.Validita = datar
      Ps.MarkDirty(m_current)
   End Sub

#End Region



#Region "Metodi per la gestione degli items"


   Public Sub SelectItem(ByVal DescrizioneAbilita As String, ByVal DescrizioneLivelloAbilita As String)

      Dim abilita As Abilita = controllerAbilita.GetAbilita(DescrizioneAbilita)
      Dim LivelloAbilita As LivelloAbilita = controllerLivelloAbilita.GetLivelloAbilita(DescrizioneLivelloAbilita)

      m_CurrentItem = Current.GetItem(abilita, LivelloAbilita)
      If m_CurrentItem Is Nothing Then
         Throw New Exception("Non è stato selezionato nessun item")
      End If

   End Sub

   Public Sub AddItem(ByVal DescrizioneAbilita As String, ByVal DescrizioneLivelloAbilita As String, ByVal NumeroPosti As String)
      Dim temp As Int32 = TryCastToInt32(NumeroPosti)
      Dim abilita As Abilita = controllerAbilita.GetAbilita(DescrizioneAbilita)
      Dim LivelloAbilita As LivelloAbilita = controllerLivelloAbilita.GetLivelloAbilita(DescrizioneLivelloAbilita)

      Current.AddItem(abilita, LivelloAbilita, temp)
      Dim item As OffertaLavoroItem = Current.GetItem(abilita, LivelloAbilita)

      Ps.MarkNew(item)
   End Sub

   Public Function TryCastToInt32(ByVal elem As String) As Int32
      Try
         Return CType(elem, Int32)
      Catch ex As OverflowException
         Throw New Exception("Inserire il numero posti nel formato corretto")
      Catch ex As InvalidCastException
         Throw New Exception("Inserire il numero posti nel formato corretto")
      End Try
   End Function


   Public Sub RemoveItem(ByVal DescrizioneAbilita As String, ByVal DescrizioneLivelloAbilita As String)
      Dim abilita As Abilita = controllerAbilita.GetAbilita(DescrizioneAbilita)
      Dim LivelloAbilita As LivelloAbilita = controllerLivelloAbilita.GetLivelloAbilita(DescrizioneLivelloAbilita)

      Dim item As OffertaLavoroItem = Current.GetItem(abilita, LivelloAbilita)

      Current.RemoveItem(abilita, LivelloAbilita)
      Ps.MarkRemoved(item)
   End Sub
   Public Function GetItems() As IList
      Return Current.Items
   End Function
#End Region

   Public Function GetListaDettagliOfferta() As IList
      Dim result As IList = New ArrayList
      For Each elem As OffertaLavoroItem In Current.Items
         Dim temp As String = elem.Abilita.ToString & " - " & elem.NumeroPosti.ToString & " posti - Livello " & elem.Livello.ToString
         result.Add(temp)
      Next
      Return result
   End Function

   Public Function GetListaSkill() As IList
      Dim result As IList = New ArrayList
      For Each elem As OffertaLavoroItem In Current.Items
         Dim temp As Abilita = elem.Abilita
         If Not ExistInList(temp, result) Then
            result.Add(temp)
         End If
      Next
      Return result
   End Function

   Private Function ExistInList(ByVal Abilita As Abilita, ByVal lista As IList) As Boolean
      For Each elem As Abilita In lista
         If Abilita.Id = elem.Id Then
            Return True
         End If
      Next
      Return False
   End Function

#Region "Proprietà item corrente"
   Public Property NumeroPosti() As Int32
      Get
         Return m_CurrentItem.NumeroPosti
      End Get
      Set(ByVal value As Int32)
         m_CurrentItem.NumeroPosti = value
         Ps.MarkDirty(m_CurrentItem)
      End Set
   End Property


   Public ReadOnly Property DescrizioneAbilita() As String
      Get
         Return m_CurrentItem.Abilita.Descrizione
      End Get
   End Property
   Public Sub SetAbilita(ByVal DescrizioneAbilita As String)


      Dim abilita As Abilita = controllerAbilita.GetAbilita(DescrizioneAbilita)

      m_CurrentItem.Abilita = abilita
      Ps.MarkDirty(m_CurrentItem)
   End Sub



   Public ReadOnly Property DescrizioneLivelloAbilita() As String
      Get
         Return m_CurrentItem.Livello.Descrizione
      End Get
   End Property
   Public Sub SetLivelloAbilita(ByVal DescrizioneLivelloAbilita As String)


      Dim LivelloAbilita As LivelloAbilita = controllerLivelloAbilita.GetLivelloAbilita(DescrizioneLivelloAbilita)

      m_CurrentItem.Livello = LivelloAbilita
      Ps.MarkDirty(m_CurrentItem)
   End Sub



#End Region


   Public Overrides Function GetCategoryObject() As String
      Return "OffertaLavoro"
   End Function


   Friend Function GetOffertaById(ByVal Id As String) As OffertaLavoro
      If Id = -1 Then Return Nothing
      Me.LoadById(Id)
      Return Current()
   End Function


   Public Sub LoadAllByAzienda(ByVal IdAzienda As String)
      If Not IsNumeric(IdAzienda) Then Throw New Exception("Id azienda errato.")
      Dim query As Query = Ps.CreateNewQuery("MapperOffertaLavoro")
      Dim mainCriteria As Criteria = Criteria.Equal("ID_AZIENDA", IdAzienda)
      query.AddWhereClause(mainCriteria)
      DomainObjectList = query.Execute(Ps)
   End Sub
   Public Function GetOfferteByAzienda(ByVal IdAzienda As String) As IList
      LoadAllByAzienda(IdAzienda)
      Return DomainObjectList
   End Function
   Public Overrides Sub CreateNew()
      m_current = New OffertaLavoro
      Ps.MarkNew(m_current)
   End Sub

   
   Protected Overrides Sub DoSave()

      'la transazione è stata aperta alla creazione del controller

      Ps.CommitTransaction()
      Ps.BeginTransaction()

      'Ps.InsertObject(Me.GetCategoryObject, m_current)

   End Sub
   Protected Overrides Sub DoUpdate()

      'la transazione è stata aperta alla creazione del controller

      Ps.CommitTransaction()
      Ps.BeginTransaction()

      'Ps.InsertObject(Me.GetCategoryObject, m_current)

   End Sub

End Class
