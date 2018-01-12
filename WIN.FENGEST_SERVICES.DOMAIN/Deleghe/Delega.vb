Public Class Delega
   Inherits AbstractDocumento
   Implements IDelega

   'Private m_DataRegistrazione As DateTime = Date.MinValue
   ' Private m_EnteInoltro2 As AbstractAzienda = New AziendaNonSpecificata
   'Private m_EnteAccettante1 As AbstractAzienda = New AziendaNonSpecificata
   'Private m_EnteAccettante2 As AbstractAzienda = New AziendaNonSpecificata
   'Private m_InEntrambiEntiBilaterali As Boolean = False
   'Private m_AccettataDaEntrambiEntiBilaterali As Boolean = False
   Private m_Utente As Utente = New UtenteNonSpecificato
   Private m_CausaleSottoscrizione As CausaleSottoscrizioneDelega = New CausaleSottoscrizioneNulla
   Private m_Referente As Referente = New ReferenteNullo
   Private m_EnteInoltro As AbstractAzienda = New AziendaNonSpecificata
   Protected m_StatoDelega As IStatusDelega
   Private m_PagamentoAttivazione As IDocumento = DomainFactory.GetDocumentoNullo
   Private m_DataInoltro As DateTime = Date.MinValue
   Private m_DataAccettazioneDelega As DateTime = Date.MinValue
   Private m_DataDecorrenzaDelega As DateTime = Date.MinValue
   Private m_DataAnnullamentoDelega As DateTime = Date.MinValue
   Private m_settore As Settore = New SettoreNullo
   Protected m_DelegaAnnullamento As Delega = Nothing
   Protected m_StatoPrecedente As IStatusDelega = New StNull
   Private m_CausaleFineCiclo As CausaleRevocaDelega = New CausaleNulla
   Private m_IdDelegaAnnullamento As Int32 = -1
   Private m_DataRevoca As DateTime = DateTime.MinValue
   Private m_PeriodoValidita As DataRange = DataRange.Empty
   Private m_reparto As RepartoAzienda = New RepartoNullo
   Private m_Responsabile As Referente = New ReferenteNullo
   Private m_SedeOperativa As SedeOperativa = New SedeOperativaNulla
   Private m_DataImportazione As DateTime

   Private m_Selected As Boolean

   Public Property selected() As Boolean
      Get
         Return m_Selected
      End Get
      Set(ByVal value As Boolean)
         m_Selected = value
      End Set
   End Property

   Public ReadOnly Property Cellulare1Utente() As String
      Get
         Return m_Utente.Comunicazione.Cellulare1
      End Get
   End Property

   Public ReadOnly Property Cellulare2Utente() As String
      Get
         Return m_Utente.Comunicazione.Cellulare2
      End Get
   End Property


   Public Property DataImportazione() As DateTime
      Get
         Return m_DataImportazione
      End Get
      Set(ByVal value As DateTime)
         m_DataImportazione = value
      End Set
   End Property


   Public Overrides Function ToString() As String
      If Me.GetId = -1 Then
         Return ""
      End If
      Return Me.GetId
   End Function
   Public Property CausaleSottoscrizione() As CausaleSottoscrizioneDelega
      Get
         Return m_CausaleSottoscrizione
      End Get
      Set(ByVal value As CausaleSottoscrizioneDelega)
         If value Is Nothing Then Throw New NullReferenceException("Impossibile impostare una causale sottoscrizione nulla")
         If value.Id = -1 Then Throw New ArgumentException("Impossibile impostare una causale sottoscrizione di tipo nullo")
         m_CausaleSottoscrizione = value
      End Set
   End Property
   Public Property Reparto() As RepartoAzienda
      Get
         Return m_reparto
      End Get
      Set(ByVal value As RepartoAzienda)
         If value Is Nothing Then Throw New NullReferenceException("Impossibile impostare un  reparto nullo")
         m_reparto = value
      End Set
   End Property
   ''' <summary>
   ''' Funzione che restituisca l'intervallo di validità della delega come intervallo 
   ''' tra la data di accettazione 
   ''' e la data di annullamento o la data della revoca della delega se la delega è altermine del suo ciclo di vita.
   ''' Se la delega è attiva o accettata restituisce un intervallo aperto con data inizio uguale
   ''' alla data di  dieci mesi antecedente di inoltro  della delega.
   ''' Un intervallo nullo negli antri casi
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function GetPeriodoValidita() As DataRange Implements IDelega.GetPeriodoValidita
      If m_DataAccettazioneDelega = DateTime.MinValue Then Return DataRange.Empty
      If m_StatoDelega.StatusName = "Annullata" Then
            Return New DataRange(m_DataInoltro.AddMonths(-10), m_DataAnnullamentoDelega)
      ElseIf m_StatoDelega.StatusName = "Revocata" Then
            Return New DataRange(m_DataInoltro.AddMonths(-10), m_DataRevoca)
      ElseIf m_StatoDelega.StatusName = "Attivata" Or m_StatoDelega.StatusName = "Accettata" Then
            Return New DataRange(m_DataInoltro.AddMonths(-10), CDate("01/01/3000"))
      End If
      Return DataRange.Empty
   End Function



   ''' <summary>
   ''' Delega che ha annullato la delega corrente.
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property DelegaDiAnnullamento() As IDelega Implements IDelega.DelegaDiAnnullamento
      Get
         If m_DelegaAnnullamento Is Nothing Then m_DelegaAnnullamento = New DelegaNulla
         If m_DelegaAnnullamento.Id = -1 Then m_DelegaAnnullamento = m_Utente.GetDelegaById(m_IdDelegaAnnullamento)
         Return m_DelegaAnnullamento
      End Get
      Set(ByVal value As IDelega)
         m_DelegaAnnullamento = value
      End Set
   End Property
   ''' <summary>
   ''' Metodo usato solamente del mapper delega
   ''' </summary>
   ''' <param name="Id"></param>
   ''' <remarks></remarks>
   Public Sub SetIdDelegaAnnullamento(ByVal Id As Int32)
      m_IdDelegaAnnullamento = Id
   End Sub
   Public ReadOnly Property IsForSettoreEdile() As Boolean Implements IDelega.IsForSettoreEdile
      Get
         If m_settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
            Return True
         End If
         Return False
      End Get
   End Property
   Public Property StatoPrecedente() As IStatusDelega
      Get
         Return m_StatoPrecedente
      End Get
      Set(ByVal value As IStatusDelega)
         m_StatoPrecedente = value
      End Set
   End Property
   ''' <summary>
   ''' In principio era "Causale Revoca". Con la necessità di avere una causale 
   ''' anche per l'annullamento si può benissimo riciclare il campo e renderlo
   ''' più generico in virtù del fatto che una delega può essere annullata o revocata
   ''' e la concatenazione degli eventi non è mai diretta.
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property CausaleFineCiclo() As CausaleRevocaDelega
      Get
         Return m_CausaleFineCiclo
      End Get
      Set(ByVal value As CausaleRevocaDelega)
         If value Is Nothing Then m_CausaleFineCiclo = New CausaleNulla
         m_CausaleFineCiclo = value
      End Set
   End Property

#Region "Costruttori"
   Public Sub New()
      MyBase.m_TipoDocumento = "DEL"

   End Sub
   Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                     ByVal Note As String, ByVal Utente As Utente, _
                     ByVal Referente As Referente, ByVal EnteInoltro1 As AbstractAzienda, _
                     ByVal StatoDelega As IStatusDelega, ByVal Settore As Settore, ByVal CausaleSott As CausaleSottoscrizioneDelega, ByVal RepartoIF As RepartoAzienda, _
                     Optional ByVal PersistentObject As Boolean = False, Optional ByVal Responsabile As Referente = Nothing, Optional ByVal NomeSedeOperativa As String = "")

      'Modifica del 07/10/2007
      'Non esiste più il concetto di inoltro per entrambi gli enti bilaterali. La delega è unica ed ha un
      'ciclo di vita relativo ad un solo ente o ad una sola azienda
      'Dalla firma del metodo viene tolto il parametro "ByVal EnteInoltro2 As AbstractAzienda"



      MyBase.New(DataDocumento, DataRegistrazione, Note)


      If CausaleSott Is Nothing Then Throw New NullReferenceException("Impossibile impostare una causale sottoscrizione nulla")
      If CausaleSott.Id = -1 Then Throw New ArgumentException("Impossibile impostare una causale sottoscrizione di tipo nullo")
      If RepartoIF Is Nothing Then Throw New NullReferenceException("Impossibile impostare un  reparto nullo")
      If Utente Is Nothing Then Throw New Exception("Non è possibile costruire una delega con un utente nullo")
      If TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Non è possibile costruire una delega senza specificare un utente")
      If Referente Is Nothing Then Throw New Exception("Non è possibile costruire una delega con un referente nullo")
      'If TypeOf (Referente) Is ReferenteNullo Then Throw New Exception("Non è possibile costruire una delega senza specificare un referente")
      If EnteInoltro1 Is Nothing Then Throw New Exception("Non è possibile costruire una delega con un ente di inoltro nullo")
      If TypeOf (EnteInoltro1) Is AziendaNonSpecificata Then Throw New Exception("Non è possibile costruire una delega senza specificare un ente di inoltro")
      'If EnteInoltro2 Is Nothing Then Throw New Exception("Non è possibile costruire una delega con un ente di inoltro 2 nullo")
      'If EnteInoltro1.Id = EnteInoltro2.Id Then Throw New Exception("Impossibile creare un oggetto delega con entrambi gli enti di inoltro uguali.")
      If Settore Is Nothing Then Throw New Exception("Non è possibile costruire una delega con un settore nullo")
      If Settore.Id = -1 Then Throw New Exception("Impossibile creare un oggetto delega con un tipo settore nullo.")
      If Not Settore.EnteCoerenteConSettore(EnteInoltro1) Then Throw New Exception("Impossibile creare un nuovo oggetto delega. Mancata coerenza tra ente inoltro 1 e settore")

      m_CausaleSottoscrizione = CausaleSott
      m_reparto = RepartoIF
      MyBase.m_TipoDocumento = "DEL"
      m_Utente = Utente
      m_Referente = Referente
      m_settore = Settore
      m_EnteInoltro = EnteInoltro1
      If m_Responsabile Is Nothing Then m_Responsabile = New ReferenteNullo
      m_Responsabile = Responsabile
      If m_settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
         m_SedeOperativa = DirectCast(m_EnteInoltro, Azienda).GetSedeOperativaByDescrizione(NomeSedeOperativa)
         If m_SedeOperativa Is Nothing Then m_SedeOperativa = New SedeOperativaNulla
      End If

      'If Settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
      '   If EnteInoltro2.Id <> -1 Then
      '      m_InEntrambiEntiBilaterali = True
      '      m_EnteInoltro2 = EnteInoltro2
      '      If Not m_settore.EnteCoerenteConSettore(EnteInoltro2) Then Throw New Exception("Impossibile creare un nuovo oggetto delega. Il settore in cui è stata sottoscritta la delega non è coerente con il tipo di azienda immesso")
      '   End If
      'End If
      m_StatoDelega = StatoDelega
      If Not PersistentObject Then
         Utente.AddDelega(Me)
      End If
   End Sub
#End Region



#Region "Proprietà dell'oggetto delega"
   Public Property EnteInoltro() As AbstractAzienda Implements IDelega.EnteInoltro
      Get
         Return m_EnteInoltro
      End Get
      Set(ByVal value As AbstractAzienda)
         If value Is Nothing Then Throw New Exception("Impossibile impostare un ente d'inoltro nullo  per una delega")
         If TypeOf (value) Is AziendaNonSpecificata Then Throw New Exception("Impossibile impostare un ente d'inoltro  non specificato per una delega")
         If Not m_settore.EnteCoerenteConSettore(value) Then Throw New Exception("Impossibile creare un nuovo oggetto delega. Mancata coerenza tra ente inoltro 1 e settore")
         m_EnteInoltro = value
      End Set
   End Property
   'Public Property EnteInoltro2() As AbstractAzienda
   '   Get
   '      Return Me.m_EnteInoltro2
   '   End Get
   '   Set(ByVal value As AbstractAzienda)
   '      If value Is Nothing Then Throw New Exception("Impossibile impostare un ente d'inoltro nullo  per una delega")
   '      If TypeOf (value) Is AziendaNonSpecificata Then
   '         m_InEntrambiEntiBilaterali = False
   '      Else
   '         If Not m_settore.EnteCoerenteConSettore(value) Then Throw New Exception("Impossibile creare un nuovo oggetto delega. Mancata coerenza tra ente inoltro 2 e settore")
   '         m_InEntrambiEntiBilaterali = True
   '      End If
   '      m_EnteInoltro2 = value
   '   End Set
   'End Property
   ''' <summary>
   ''' Questa proprietà imposta o restituisce il settore di sottoscrizione della delega.
   ''' Essa influenza le altra proprietà  relative agli enti di inoltro ed accettazione
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property Settore() As Settore
      Get
         Return m_settore
      End Get
      Set(ByVal value As Settore)
         If value Is Nothing Then Throw New Exception("Non è possibile costruire una delega con un settore nullo")
         If value.Id = -1 Then Throw New Exception("Impossibile creare un oggetto delega con un tipo settore nullo.")
         m_settore = value
      End Set
   End Property
   'Public ReadOnly Property InoltrataEntrambiEntiBilaterali() As Boolean
   '   Get
   '      Return m_InEntrambiEntiBilaterali
   '   End Get
   'End Property
   'Public ReadOnly Property AccettataDaEntrambiEntiBilaterali() As Boolean
   '   Get
   '      Return m_AccettataDaEntrambiEntiBilaterali
   '   End Get
   'End Property
   Public ReadOnly Property GetDataRegistrazione() As DateTime
      Get
         Return m_dataRegistrazione
      End Get
   End Property
   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         If value Is Nothing Then Throw New ArgumentNullException("Utente")
         If value.Id = -1 Then Throw New ArgumentNullException("Utente")
         m_Utente = value
      End Set
   End Property
   ''' <summary>
   ''' Questo metodo deve essere usato solamente dal mapper delega per ripristinare il riferimento
   ''' circolare con le deleghe!!!!
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <remarks></remarks>
   Public Sub SetDoubleRefUtente(ByVal Utente As Utente)
      m_Utente = Utente
   End Sub
   Public ReadOnly Property NomeStato() As String Implements IDelega.NomeStato
      Get
         Return m_StatoDelega.StatusName
      End Get
   End Property
   Public ReadOnly Property IdDelega() As Int32 Implements IDelega.IdDelega
      Get
         Return MyBase.Key.LongValue
      End Get
   End Property
   Public Property StatoDelega() As IStatusDelega
      Get
         Return m_StatoDelega
      End Get
      Set(ByVal value As IStatusDelega)
         m_StatoDelega = value
      End Set
   End Property
   Public Property Referente() As AbstractPersona Implements IDelega.Referente
      Get
         Return m_Referente
      End Get
      Set(ByVal value As AbstractPersona)
         If value Is Nothing Then Throw New Exception("Impossibile impostare un referente  nullo  per una delega")
         'If TypeOf (value) Is ReferenteNullo Then Throw New Exception("Impossibile impostare un referente  non specificato per una delega")
         m_Referente = value
      End Set
   End Property
   
   Public Property DataInoltro() As DateTime Implements IDelega.DataInoltro
      Get
         Return m_DataInoltro
      End Get
      Set(ByVal value As DateTime)
         m_DataInoltro = value
      End Set
   End Property
   Public Property DataAccettazioneDelega() As DateTime Implements IDelega.DataAccettazioneDelega
      Get
         Return m_DataAccettazioneDelega
      End Get
      Set(ByVal value As DateTime)
         m_DataAccettazioneDelega = value
      End Set
   End Property
   Public Property DataDecorrenzaDelega() As DateTime Implements IDelega.DataDecorrenzaDelega
      Get
         Return m_DataDecorrenzaDelega
      End Get
      Set(ByVal value As DateTime)
         m_DataDecorrenzaDelega = value
      End Set
   End Property
   Public Property DataAnnullamentoDelega() As DateTime Implements IDelega.DataAnnullamentoDelega
      Get
         Return m_DataAnnullamentoDelega
      End Get
      Set(ByVal value As DateTime)
         m_DataAnnullamentoDelega = value
      End Set
   End Property
   Public Property PagamentoAttivazione() As IDocumento Implements IDelega.PagamentoAttivazione
      Get
         Return m_PagamentoAttivazione
      End Get
      Set(ByVal value As IDocumento)
         If value Is Nothing Then Throw New Exception("Impossibile impostare l'incasso di attivazione.  Incasso nullo.")
         m_PagamentoAttivazione = value
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
   '''' <summary>
   '''' Imposta un nuovo ente accettante previa verifica di uguaglianza con uno degli enti di inoltro.
   '''' </summary>
   '''' <value></value>
   '''' <returns></returns>
   '''' <remarks></remarks>
   'Public Property EnteAccettante1() As AbstractAzienda Implements IDelega.EnteAccettante1
   '   Get
   '      Return m_EnteAccettante1
   '   End Get
   '   Set(ByVal value As AbstractAzienda)
   '      If value Is Nothing Then Throw New Exception("Impossibile impostare l'ente accettante 1 nullo  per una delega")
   '      If value.Id = -1 Then
   '         m_EnteAccettante1 = value
   '      Else
   '         If value.Id = Me.m_EnteInoltro.Id Or value.Id = Me.m_EnteInoltro2.Id Then
   '            If Not m_settore.EnteCoerenteConSettore(value) Then Throw New Exception("Impossibile impostare l'ente accettante. L'ente di inoltro e l'ente accettante appartengono a settori diversi")
   '            m_EnteAccettante1 = value
   '         Else
   '            Throw New Exception("Impossibile assegnare il valore per l'ente accettante 1 poichè non corrisponde a nessuno degli enti di inoltro specificati")
   '         End If
   '      End If
   '   End Set
   'End Property
   '''' <summary>
   '''' Imposta un nuovo ente accettante previa verifica di uguaglianza con uno degli enti di inoltro.
   '''' </summary>
   '''' <value></value>
   '''' <returns></returns>
   '''' <remarks></remarks>
   'Public Property EnteAccettante2() As AbstractAzienda Implements IDelega.EnteAccettante2
   '   Get
   '      Return m_EnteAccettante2
   '   End Get
   '   Set(ByVal value As AbstractAzienda)
   '      If value Is Nothing Then Throw New Exception("Impossibile impostare l'ente accettante 2 nullo  per una delega")
   '      If value.Id = -1 Then
   '         m_AccettataDaEntrambiEntiBilaterali = False
   '         m_EnteAccettante2 = value
   '      Else
   '         If value.Id = Me.m_EnteInoltro.Id Or value.Id = Me.m_EnteInoltro2.Id Then
   '            If Not m_settore.EnteCoerenteConSettore(value) Then Throw New Exception("Impossibile creare un nuovo oggetto delega. Mancata coerenza tra ente inoltro 1 e settore")
   '            m_EnteAccettante2 = value
   '            m_AccettataDaEntrambiEntiBilaterali = True
   '         Else
   '            Throw New Exception("Impossibile assegnare il valore per l'ente accettante 1 poichè non corrisponde a nessuno degli enti di inoltro specificati")
   '         End If
   '      End If
   '   End Set
   'End Property
#End Region



#Region "Metodi d'interrogazione dello stato"
   Public Function IsActive() As Boolean Implements IDelega.IsActive
      If m_StatoDelega.ReadyForPayment Then
         Return True
      Else
         Return False
      End If
   End Function
   Public Function IsAccepted() As Boolean Implements IDelega.IsAccepted
      If m_StatoDelega.IsAccepted Then
         Return True
      Else
         Return False
      End If
   End Function
   Public Function IsRevocata() As Boolean Implements IDelega.IsRevocata
      If m_StatoDelega.StatusName = "Revocata" Then
         Return True
      Else
         Return False
      End If
   End Function
   Public Function IsAnnullata() As Boolean Implements IDelega.IsAnnullata
      If m_StatoDelega.StatusName = "Annullata" Then
         Return True
      Else
         Return False
      End If
   End Function
#End Region


#Region "Metodi per le transizioni di stato"
   Public Sub Inoltra(ByVal Delega As IDelega, ByVal DataInoltro As DateTime) Implements IDelega.Inoltra
      m_StatoDelega.Inoltra(DataInoltro, Me)
   End Sub
   Public Sub Accetta(ByVal Delega As IDelega, ByVal DataAccettazione As DateTime) Implements IDelega.Accetta
      'qui posso usare degli strategy per il calcolo della decorrenza della delega
      'a seconda dell'ente accettante
      'Qui sarà necessario calcolare la data di decorrenza. Per ora setto la data di decorrenza 
      'uguale alla data di accettazione.
      m_StatoDelega.Accetta(DataAccettazione, Me)
   End Sub
   Public Sub Rifiuta(ByVal Delega As IDelega) Implements IDelega.Rifiuta
      m_StatoDelega.Rifiuta(Me)
   End Sub
   Public Sub Revoca(ByVal Delega As IDelega, ByVal DataRevoca As DateTime, ByVal Causale As AbstractPersistenceObject, ByVal Note As String) Implements IDelega.Revoca
      m_StatoDelega.Revoca(Me, Causale, DataRevoca, Note)
   End Sub
   Public Sub Attiva(ByVal Delega As IDelega, ByVal ConPagamento As IDocumento) Implements IDelega.Attiva
      m_StatoDelega.Attiva(ConPagamento, Me)
   End Sub
   Public Overloads Sub Annulla(ByVal Delega As IDelega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As IDelega) Implements IDelega.Annulla
      m_StatoDelega.Annulla(Me, DataAnnullamento, DirectCast(DelegaAccettata, Delega))
   End Sub
   Public Overloads Sub Annulla(ByVal Delega As IDelega, ByVal DataAnnullamento As DateTime, ByVal Causale As AbstractPersistenceObject) Implements IDelega.Annulla
      m_StatoDelega.Annulla(Me, DataAnnullamento, Causale)
   End Sub
   Public Sub RipristinaStatoPrecedente() Implements IDelega.RipristinaStatoPrecedente
      m_StatoDelega.RipristinaStatoPrecedente(Me)
   End Sub
#End Region

   Public Function VerificaEnteAccettazione(ByVal Ente1 As Azienda, ByVal Delega As Delega)
      'Qui verifico se l'ente di accettazione è uno degli enti di inoltro
      If Ente1 Is Nothing Then Throw New Exception("Impossibile verificare per l'accettazione l'ente bilaterale 1. Oggetto nullo")
      If Ente1.Id = -1 Then Throw New Exception("Impossibile verificare per l'accettazione l'ente bilaterale 1. Tipo oggetto nullo")
      'If Ente2 Is Nothing Then Throw New Exception("Impossibile verificare per l'accettazione l'ente bilaterale 2. Oggetto nullo")

      Dim found1 As Boolean = False
      If Delega.EnteInoltro.Key.LongValue = Ente1.IdAzienda Then found1 = True

      'Dim found2 As Boolean = False
      'If Delega.InoltrataEntrambiEntiBilaterali Then
      '   'If Not Ente2.Id = -1 Then 'Si tratta di un'accettazione ad entrambi gli enti bilaterali
      '   '   'verifico che l'ente1 sia uno dei due enti di inoltro
      '   '   Dim uguale1 As Boolean = IIf(Delega.EnteInoltro1.Key.LongValue = Ente1.IdAzienda, True, False)
      '   '   Dim uguale2 As Boolean = IIf(Delega.EnteInoltro2.Key.LongValue = Ente1.IdAzienda, True, False)
      '   '   found1 = IIf(uguale1 Or uguale2, True, False)
      '   '   'verifico che l'ente2 sia uno dei due enti di inoltro
      '   '   Dim uguale3 As Boolean = IIf(Delega.EnteInoltro1.Key.LongValue = Ente2.IdAzienda, True, False)
      '   '   Dim uguale4 As Boolean = IIf(Delega.EnteInoltro2.Key.LongValue = Ente2.IdAzienda, True, False)
      '   '   found2 = IIf(uguale3 Or uguale4, True, False)
      '   '   found1 = IIf(found1 And found2, True, False)
      '   'Else
      '   '   'verifico che l'ente1 sia uno dei due enti di inoltro
      '   '   Dim uguale1 As Boolean = IIf(Delega.EnteInoltro1.Key.LongValue = Ente1.IdAzienda, True, False)
      '   '   Dim uguale2 As Boolean = IIf(Delega.EnteInoltro2.Key.LongValue = Ente1.IdAzienda, True, False)
      '   '   found1 = IIf(uguale1 Or uguale2, True, False)
      '   'End If
      'Else
      'If Delega.EnteInoltro1.Key.LongValue = Ente1.IdAzienda Then found1 = True
      'End If
      Return found1
   End Function
   Protected Overrides Sub DoValidation()
      'If Not MyBase.IsValid() Then
      '   ValidationErrors.Add("Errori nella validazione del documento")
      'End If
      If m_CausaleSottoscrizione.Id = -1 Then
         ValidationErrors.Add("Impossibile validare l'oggetto. Causale sottoscrizione di tipo nullo")
      End If

      If Not m_EnteInoltro.Id = -1 Then
         If Not m_settore.EnteCoerenteConSettore(m_EnteInoltro) Then
            ValidationErrors.Add("Impossibile Validare l'oggetto delega. Mancata coerenza tra ente inoltro 1 e settore")
         End If
      End If
      'If Not m_EnteInoltro2.Id = -1 Then
      '   If Not m_settore.EnteCoerenteConSettore(m_EnteInoltro2) Then
      '      Throw New Exception("Impossibile Validare l'oggetto delega. Mancata coerenza tra ente inoltro 2 e settore")
      '   End If
      'End If
      'If Not m_EnteAccettante1.Id = -1 Then
      '   If Not m_settore.EnteCoerenteConSettore(m_EnteAccettante1) Then
      '      Throw New Exception("Impossibile Validare l'oggetto delega. Mancata coerenza tra ente accettante 1 e settore")
      '   End If
      'End If
      'If Not m_EnteAccettante2.Id = -1 Then
      '   If Not m_settore.EnteCoerenteConSettore(m_EnteAccettante2) Then
      '      Throw New Exception("Impossibile Validare l'oggetto delega. Mancata coerenza tra ente accettante 2 e settore")
      '   End If
      'End If
      
   End Sub

   Public Property SedeOperativa() As INTERFACES.ISedeOperativa Implements INTERFACES.IDelega.SedeOperativa
      Get
         Return m_SedeOperativa
      End Get
      Set(ByVal value As INTERFACES.ISedeOperativa)
         If value Is Nothing Then Throw New ArgumentNullException("Sede operativa nulla")
         If m_settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
            If DirectCast(m_EnteInoltro, Azienda).ExistSedeOperativa(value.Descrizione) Then
               m_SedeOperativa = value
            Else
               m_SedeOperativa = New SedeOperativaNulla
            End If
         End If
      End Set
   End Property
   Public Property Responsabile() As AbstractPersona Implements IDelega.Responsabile
      Get
         Return m_Responsabile
      End Get
      Set(ByVal value As AbstractPersona)
         If value Is Nothing Then Throw New Exception("Impossibile impostare un responsabile  nullo  per una delega")
         m_Responsabile = value
      End Set
   End Property


   Public Function ToDTO() As DTODelega
      Try

    
         Dim dto As New DTODelega
         dto.CausaleFineCiclo = Me.CausaleFineCiclo.Descrizione
         dto.CausaleSottoscrizione = Me.CausaleSottoscrizione.Descrizione
         dto.DataAccettazioneDelega = Me.DataAccettazioneDelega
         dto.DataAnnullamentoDelega = Me.DataAnnullamentoDelega
         dto.DataDecorrenzaDelega = Me.DataDecorrenzaDelega
         dto.DataDocumento = Me.DataDocumento
         dto.DataImportazione = Me.DataImportazione
         dto.DataInoltro = Me.DataInoltro
         dto.DataRegistrazione = Me.DataRegistrazione
         dto.DataRevocaDelega = Me.DataRevocaDelega
         dto.EnteInoltro = Me.EnteInoltro.Descrizione
         dto.IdDelega = Me.Id
         If Not Me.IsForSettoreEdile Then
            dto.NomeContratto = DirectCast(Me.EnteInoltro, Azienda).ContrattoApplicato.Descrizione
         End If
         dto.Referente = Me.Referente.CompleteName
         dto.Reparto = Me.Reparto.Descrizione
         dto.Responsabile = Me.Responsabile.Descrizione
         dto.Settore = Me.Settore.Descrizione
         dto.StatoDelega = Me.StatoDelega.StatusName
         dto.Utente = Me.Utente.CompleteName

         Return dto
      Catch ex As Exception
         Throw New Exception("Impossibile creare il dto della delega")
      End Try
   End Function
End Class
