Public Class DTODelega


   Private m_Utente As String
   Private m_CausaleSottoscrizione As String
   Private m_Referente As String
   Private m_EnteInoltro As String
   Protected m_StatoDelega As String
   Private m_Id As Int32 = 0
   Private m_DataInoltro As DateTime
   Private m_DataRegistrazione As DateTime
   Private m_DataDocumento As DateTime
   Private m_DataAccettazioneDelega As DateTime
   Private m_DataDecorrenzaDelega As DateTime
   Private m_DataAnnullamentoDelega As DateTime
   Private m_settore As String
   Private m_NomeContratto As String
   Private m_CausaleFineCiclo As String

   Private m_DataRevoca As DateTime
   Private m_PeriodoValidita As String
   Private m_reparto As String
   Private m_Responsabile As String
   Private m_SedeOperativa As String
   Private m_DataImportazione As DateTime

   Public Property DataImportazione() As DateTime
      Get
         Return m_DataImportazione
      End Get
      Set(ByVal value As DateTime)
         m_DataImportazione = value
      End Set
   End Property

   Public Property NomeContratto() As String
      Get
         Return m_NomeContratto
      End Get
      Set(ByVal value As String)
         m_NomeContratto = value
      End Set
   End Property
 
   Public Property CausaleSottoscrizione() As String
      Get
         Return m_CausaleSottoscrizione
      End Get
      Set(ByVal value As String)
         m_CausaleSottoscrizione = value
      End Set
   End Property
   Public Property Reparto() As String
      Get
         Return m_reparto
      End Get
      Set(ByVal value As String)
         m_reparto = value
      End Set
   End Property


   Public Property CausaleFineCiclo() As String
      Get
         Return m_CausaleFineCiclo
      End Get
      Set(ByVal value As String)
         m_CausaleFineCiclo = value
      End Set
   End Property


   Public Property EnteInoltro() As String
      Get
         Return m_EnteInoltro
      End Get
      Set(ByVal value As String)
         m_EnteInoltro = value
      End Set
   End Property

   Public Property Settore() As String
      Get
         Return m_settore
      End Get
      Set(ByVal value As String)
         m_settore = value
      End Set
   End Property

   Public Property DataRegistrazione() As DateTime
      Get
         Return m_DataRegistrazione
      End Get
      Set(ByVal value As DateTime)
         m_DataRegistrazione = value
      End Set
   End Property

   Public Property DataDocumento() As DateTime
      Get
         Return m_DataDocumento
      End Get
      Set(ByVal value As DateTime)
         m_DataDocumento = value
      End Set
   End Property
   Public Property Utente() As String
      Get
         Return m_Utente
      End Get
      Set(ByVal value As String)
         m_Utente = value
      End Set
   End Property

   Public Property StatoDelega() As String
      Get
         Return m_StatoDelega
      End Get
      Set(ByVal value As String)
         m_StatoDelega = value
      End Set
   End Property
   Public Property IdDelega() As Int32
      Get
         Return m_Id
      End Get
      Set(ByVal value As Int32)
         m_Id = value
      End Set
   End Property

   Public Property Referente() As String
      Get
         Return m_Referente
      End Get
      Set(ByVal value As String)
         m_Referente = value
      End Set
   End Property

   Public Property DataInoltro() As DateTime
      Get
         Return m_DataInoltro
      End Get
      Set(ByVal value As DateTime)
         m_DataInoltro = value
      End Set
   End Property
   Public Property DataAccettazioneDelega() As DateTime
      Get
         Return m_DataAccettazioneDelega
      End Get
      Set(ByVal value As DateTime)
         m_DataAccettazioneDelega = value
      End Set
   End Property
   Public Property DataDecorrenzaDelega() As DateTime
      Get
         Return m_DataDecorrenzaDelega
      End Get
      Set(ByVal value As DateTime)
         m_DataDecorrenzaDelega = value
      End Set
   End Property
   Public Property DataAnnullamentoDelega() As DateTime
      Get
         Return m_DataAnnullamentoDelega
      End Get
      Set(ByVal value As DateTime)
         m_DataAnnullamentoDelega = value
      End Set
   End Property

   Public Property DataRevocaDelega() As DateTime
      Get
         Return m_DataRevoca
      End Get
      Set(ByVal value As DateTime)
         'If m_dataDocumento > value Then Throw New Exception("Non si può impostare una data  revoca delega inferiore alla data documento. La data revoca di una delega deve essere successiva alla data documento della stessa")
         m_DataRevoca = value
      End Set
   End Property


   Public Property Responsabile() As String
      Get
         Return m_Responsabile
      End Get
      Set(ByVal value As String)
         m_Responsabile = value
      End Set
   End Property
End Class
