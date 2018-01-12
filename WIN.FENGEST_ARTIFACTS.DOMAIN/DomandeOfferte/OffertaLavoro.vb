Public Class OffertaLavoro
   Inherits AbstractPersistenceObject
   Private m_Validita As DataRange
   Private m_Data As DateTime
   Private m_Note As String
   Private m_Items As IList = New ArrayList
   Private m_aziendaRichiedente As Azienda

   Private m_Selected As Boolean = False
   Public Property Selected() As Boolean
      Get
         Return m_Selected
      End Get
      Set(ByVal value As Boolean)
         m_Selected = value
      End Set
   End Property


   Public Property Items() As IList
      Get
         Return m_Items
      End Get
      Set(ByVal value As IList)
         m_Items = value
      End Set
   End Property
   Public Sub New()

   End Sub

   Public Property AziendaRichiedente() As Azienda
      Get
         Return m_aziendaRichiedente
      End Get
      Set(ByVal value As Azienda)
         If value Is Nothing Then Throw New ArgumentNullException("Azienda richiedente")
         m_aziendaRichiedente = value
      End Set
   End Property

   Public Property Validita() As DataRange
      Get
         Return m_Validita
      End Get
      Set(ByVal value As DataRange)
         m_Validita = value
      End Set
   End Property
   Public Property Note() As String
      Get
         Return m_Note
      End Get
      Set(ByVal value As String)
         m_Note = value
      End Set
   End Property



   Public Property Data() As DateTime
      Get
         Return m_Data
      End Get
      Set(ByVal value As DateTime)
         m_Data = value
      End Set
   End Property

   Public Sub New(ByVal AziendaRichiedente As Azienda, ByVal Validita As DataRange, ByVal Data As DateTime, ByVal Note As String)
      Me.AziendaRichiedente = AziendaRichiedente
      m_Validita = Validita
      m_Note = Note
      m_Data = Data
   End Sub

   Public Sub AddItem(ByVal Abilita As Abilita, ByVal Livello As LivelloAbilita, ByVal NumeroPosti As Int32)
      If Me.GetItem(Abilita, Livello) Is Nothing Then
         m_Items.Add(New OffertaLavoroItem(Me, Livello, Abilita, NumeroPosti))
         Return
      End If
      Throw New InvalidOperationException("Impossibilie aggiungere un nuovo item per lo skill e il livello selezionato. Posizione simile esistente")
   End Sub

   Public Function GetItem(ByVal Abilita As Abilita, ByVal Livello As LivelloAbilita) As OffertaLavoroItem
      For Each elem As OffertaLavoroItem In m_Items
         If elem.Abilita.Id = Abilita.Id And Livello.Id = elem.Livello.Id Then
            Return elem
         End If
      Next
      Return Nothing
   End Function


   Public Sub RemoveItem(ByVal Abilita As Abilita, ByVal Livello As LivelloAbilita)
      Dim temp As OffertaLavoroItem = Me.GetItem(Abilita, Livello)
      If temp IsNot Nothing Then
         m_Items.Remove(temp)
      End If
   End Sub


   Public ReadOnly Property ContainsSkill(ByVal Abilita As Abilita) As Boolean
      Get
         For Each elem As OffertaLavoroItem In m_Items
            If elem.Abilita.Key.LongValue = Abilita.Key.LongValue Then
               Return True
            End If
         Next
         Return False
      End Get
   End Property


   Public ReadOnly Property ListaSkill() As IList
      Get
         Dim result As IList = New ArrayList
         For Each elem As OffertaLavoroItem In m_Items
            result.Add(elem.Abilita)
         Next
         Return result
      End Get
   End Property

   Public ReadOnly Property GetNumeroTotalePosti() As Int32
      Get
         Dim total As Int32 = 0
         For Each elem As OffertaLavoroItem In m_Items
            total = total + elem.NumeroPosti
         Next
         Return total
      End Get
   End Property

End Class
