Public Class SituazioneFamiliare

   Private m_DataIntervista As DateTime
   Private m_Referente As Referente = New ReferenteNullo
   Private m_StatoCivile As String
   Private m_CasaProprieta As Boolean

   Private m_ConiugeACarico As Boolean

   Private m_Figli As IList = New ArrayList

   Private m_Coniuge As Coniuge


   Public Property Coniuge() As Coniuge
      Get
         If m_Coniuge Is Nothing Then
            m_Coniuge = New Coniuge
         End If
         Return m_Coniuge
      End Get
      Set(ByVal value As Coniuge)
         m_Coniuge = value
      End Set
   End Property




   Public Property Figli() As IList
      Get
         Return m_Figli
      End Get
      Set(ByVal value As IList)
         m_Figli = value
      End Set
   End Property

   Public Property ConiugeACarico() As Boolean
      Get
         Return m_ConiugeACarico
      End Get
      Set(ByVal value As Boolean)
         m_ConiugeACarico = value
      End Set
   End Property



   Public Property CasaProprieta() As Boolean
      Get
         Return m_CasaProprieta
      End Get
      Set(ByVal value As Boolean)
         m_CasaProprieta = value
      End Set
   End Property


   Public Property StatoCivile() As String
      Get
         Return m_StatoCivile
      End Get
      Set(ByVal value As String)
         m_StatoCivile = value
      End Set
   End Property


   Public Property Referente() As Referente
      Get
         Return m_Referente
      End Get
      Set(ByVal value As Referente)
         m_Referente = value
      End Set
   End Property

   Public Property DataIntervista() As DateTime
      Get
         If m_DataIntervista = DateTime.MinValue Then Return DateTime.Now
         Return m_DataIntervista
      End Get
      Set(ByVal value As DateTime)
         m_DataIntervista = value
      End Set
   End Property


End Class
