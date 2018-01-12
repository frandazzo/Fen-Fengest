Public Class IncassoQuotaAssociativa
   Inherits DocumentoContabile
   Protected m_SoggEsecutore As Azienda = New AziendaNonSpecificata
   Protected m_competenza As AbstractPeriodo = New PeriodoNullo
   Protected m_competenzaUltimoPagamento As AbstractPeriodo = New PeriodoNullo
   Protected m_importo As Moneta = New Moneta(0, Moneta.Valuta.Euro)
    Protected m_settore As Settore = New SettoreNullo
   '***********************************************************************
   '***********************************************************************
   'Modifica del 19/08/2007
   'Completamento regole dii business Modificabilità dei documenti
   'Con questa modifica cambia la prospettiva di questi documenti:
   'Si passa da una visione contabile e chiusa del documento che doveva consentire 
   'la tracciabilità totale delle transazioni attraverso la non modificabilità dei documenti
   'e il concetto di ristorno dei documenti ad una visione aperta e più adatta al mondo sindacale
   'dove il documento è un promemoria che può essere modificato. Il concetto di errore
   'di compilazione quindi non è più irreversibile.

   'Pertanto come primo passo saranno tolti tutti i flag "IsPosted"
   '***********************************************************************
   '***********************************************************************
   Public Overrides Function ToString() As String
      If Not Me.Key Is Nothing Then
         Return Me.Key.Value(0).ToString()
      Else
         Return ""
      End If

   End Function

#Region "Proprieta  testata del documento"

   '***************************
   'Non Modificabili
   '***************************

   ''' <summary>
   ''' Proprietà che restituisce il soggetto esecutore del pagamento. Non modificabile.
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property SoggettoEsecutore() As Azienda
      Get
         Return m_SoggEsecutore
      End Get
   End Property
   ''' <summary>
   ''' Proprietà che indica la valuta dell'incasso. Non modificabile
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property Valuta() As Moneta.Valuta
      Get
         Return m_Valuta
      End Get
   End Property
   ''' <summary>
   ''' Proprietà che definisce il settore di competenza dell'incasso. Non modificabile
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property Settore() As Settore
      Get
         Return m_settore
      End Get
   End Property
   ''' <summary>
   ''' Proprietà che definisce la competenza dell'ultimo incasso. Non Modificabile
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property CompetenzaUltimoIncasso() As AbstractPeriodo
      Get
         Return m_competenzaUltimoPagamento
      End Get

   End Property


   '***************************
   'Modificabili
   '***************************
   ''' <summary>
   ''' Proprietà che specifica l'importo dell'incasso. Essa può essere variata direttamente 
   ''' durante la creazione dell'incasso. Una volta creato il documento di incasso questa proprietà viene variata solo
   ''' da un variazione degli importi delle posizioni dell'incasso. 
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property Importo() As Moneta
      Get
         Return m_importo
      End Get
      Set(ByVal value As Moneta)
         m_importo = value
         ' If Not m_IsPosted Then
         Me.GetItemWithSoggEsecutore.Importo = Importo
         ' End If
      End Set
   End Property
   ''' <summary>
   ''' Proprietà che definisce la competenza dell'incasso. Modificabile
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property Competenza() As AbstractPeriodo
      Get
         Return m_competenza
      End Get
      Set(ByVal value As AbstractPeriodo)
         If value.GetDataRange.IsEmpty Then Throw New Exception("Impossibile impostare la competenza dell'incasso quota. Competenza negativa.")
         m_competenza = value
      End Set
   End Property
   

#End Region



#Region "Proprieta  per il mapper del documento"
   ''' <summary>
   ''' NON UTILIZZARE. SOLO IL MAPPER COSTRUISCE L'OGGETTO CON QUESTO METODO
   ''' </summary>
   ''' <param name="Settore"></param>
   ''' <remarks></remarks>
   Public Sub SetSettore(ByVal Settore As Settore)
      If Settore Is Nothing Then Throw New Exception("Impossibile impostare il settore per l'incasso delle quote associative. Settore nullo")
      If Settore.Id = -1 Then Throw New Exception("Impossibile impostare il settore per l'incasso delle quote associative. Tipo settore nullo")
      m_settore = Settore
   End Sub
   ''' <summary>
   ''' NON UTILIZZARE. SOLO IL MAPPER COSTRUISCE L'OGGETTO CON QUESTO METODO
   ''' </summary>
   ''' <param name="Valuta"></param>
   ''' <remarks></remarks>
   Public Sub SetValuta(ByVal Valuta As Moneta.Valuta)
      m_Valuta = Valuta
   End Sub
   ''' <summary>
   ''' NON UTILIZZARE. SOLO IL MAPPER COSTRUISCE L'OGGETTO CON QUESTO METODO
   ''' </summary>
   ''' <param name="Soggetto"></param>
   ''' <remarks></remarks>
   Public Sub SetSoggettoEsecutore(ByVal Soggetto As Azienda)
      If Soggetto Is Nothing Then Throw New Exception("Impossibile impostare un oggetto incasso quota con un soggetto esecutore nullo!")
      If TypeOf (Soggetto) Is AziendaNonSpecificata Then Throw New Exception("Impossibile impostarere un oggetto incasso quota con un soggetto esecutore di tipo nullo!")
      m_SoggEsecutore = Soggetto
      m_competenzaUltimoPagamento = m_SoggEsecutore.CompetenzaUltimoPagamento
   End Sub
   ''' <summary>
   ''' NON UTILIZZARE. SOLO IL MAPPER COSTRUISCE L'OGGETTO CON QUESTO METODO
   ''' </summary>
   ''' <param name="Importo"></param>
   ''' <remarks></remarks>
   Public Sub SetImporto(ByVal Importo As Moneta)
      m_importo = Importo
   End Sub
#End Region



#Region "Costruttori"

   Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, ByVal SoggettoEsecutore As Azienda, _
                   ByVal PeriodoCompetenza As AbstractPeriodo, ByVal Note As String, _
                   ByVal Valuta As Moneta.Valuta, ByVal Importo As Double, ByVal Settore As Settore, _
                   Optional ByVal AddDefaultItem As Boolean = False)

      MyBase.New(DataRegistrazione, DataDocumento, Note)

      If SoggettoEsecutore Is Nothing Then Throw New Exception("Impossibile costruire un oggetto pagamento con un soggetto esecutore nullo!")
      If TypeOf (SoggettoEsecutore) Is AziendaNonSpecificata Then Throw New Exception("Impossibile costruire un oggetto pagamento con un soggetto esecutore di tipo nullo!")
      If PeriodoCompetenza Is Nothing Then Throw New Exception("Impossibile costruire un oggetto pagamento con un periodo di competenza nullo!")
      If PeriodoCompetenza.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare un pagamento con una competenza negativa o vuota")
      If Settore Is Nothing Then Throw New Exception("Impossibile crearee l'incasso delle quote associative. Settore nullo")
      If Settore.Id = -1 Then Throw New Exception("Impossibile creare l'incasso delle quote associative. Tipo settore nullo")
      m_settore = Settore

      MyBase.m_TipoDocumento = "IQA"
      m_Valuta = Valuta
      m_importo = New Moneta(Importo, m_Valuta)
      If m_settore.EnteCoerenteConSettore(SoggettoEsecutore) Then
         m_SoggEsecutore = SoggettoEsecutore
      Else
         Throw New Exception("Impossibile creare un incasso quota associativa. Soggetto esecutore non appartenete al settore specifico.")
      End If

      m_competenzaUltimoPagamento = SoggettoEsecutore.CompetenzaUltimoPagamento
      m_competenza = PeriodoCompetenza

      If Not AddDefaultItem Then
         m_Items.Add(New ItemIncassoQuotaAssociativa(Me, New Moneta(Importo, m_Valuta), m_competenza, m_SoggEsecutore, False, False, Note))
      End If
   End Sub
   Public Sub New()
      MyBase.New()
      MyBase.m_TipoDocumento = "IQA"
   End Sub

#End Region



#Region "Funzioni per la gestione privata e pubblica della lista delle posizioni"
   Public Function GetItemWithSoggEsecutore() As ItemIncassoQuotaAssociativa
      Dim i As Integer = GetIndexItemBySoggEsecutore()
      Return m_Items.Item(i)
   End Function
   Public Overloads Function GetItem(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo) As ItemIncassoQuotaAssociativa
      Try
         Dim i As Integer = Me.GetIndexItemByUtente(Utente, Competenza)
         Return m_Items.Item(i)
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione del pagamento relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Function ExistSimilarItemsForUtente(ByVal Utente As IUtente, ByVal Item As ItemIncassoQuotaAssociativa, ByVal Competenza As AbstractPeriodo) As Boolean
      If Utente.IdUtente = -1 Then Return False
      Return ExistSimilarItemTo(GetItemListByUtente(Utente), Item, Competenza)
   End Function
   ''' <summary>
   ''' Metodo che aggiunge una posizione all'incasso e contestualmente ne aggiorna l'importo.
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Importo"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="Referente"></param>
   ''' <param name="Note"></param>
   ''' <remarks></remarks>
    Public Overridable Overloads Sub AddItem(ByVal Utente As IUtente, ByVal Importo As Double, ByVal Competenza As AbstractPeriodo, ByVal Referente As Referente, ByVal Note As String, Optional ByVal NotCheckPaybility As Boolean = False)
        If Not ExistSimilarItemTo(GetItemListByUtente(Utente), Competenza) Then
            m_Items.Add(New ItemIncassoQuotaAssociativa(Utente, Me, New Moneta(Importo, m_Valuta).Negate, Referente, SoggettoEsecutore, Note, Competenza, False, False, NotCheckPaybility))
        Else
            Throw New Exception("Non è possibile aggiungere una nuova posizione al documento perchè la competenza si sovrappone a quella di un'altra posizione per lo stesso utente ")
        End If
        'Se  aggiungo una posizione cambio il totale .
        ' l'importo è necessario per pareggiare è il totale.
        'uso la proprietà importo per paggiornare la posizione di contropartita
        'If m_IsPosted Then

        Me.Importo = Me.Importo.Add(New Moneta(Importo, m_Valuta))
    End Sub
   Public Overloads Sub RemoveItem(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo)

      Dim posizione As Integer = Me.GetIndexItemByUtente(Utente, Competenza)
      If posizione > 0 Then m_Items.RemoveAt(posizione)
      'Se ho registrato il documento rimuovo una posizione cambio il totale che deve essere 0.
      ' l'importo è necessario per pareggiare è il totale.
      'uso la proprietà importo per paggiornare la posizione di contropartita
      If m_IsPosted Then Importo = Importo.Subtract(Me.GetTotal)


   End Sub
   Public Function GetIndexItemBySoggEsecutore() As Integer
      For Each elem As ItemIncassoQuotaAssociativa In m_Items
         If Not elem.PosizioneUtente Then Return m_Items.IndexOf(elem)
      Next
      Return -1
   End Function
   Protected Overloads Function ExistSimilarItemTo(ByVal InItemList As ArrayList, ByVal WithCompetenza As AbstractPeriodo) As Boolean
      For Each elem As ItemIncassoQuotaAssociativa In InItemList
         If elem.Competenza.Overlaps(WithCompetenza) Then Return True
      Next
   End Function
   Protected Overloads Function ExistSimilarItemTo(ByVal InItemList As ArrayList, ByVal AsItem As ItemIncassoQuotaAssociativa, ByVal WithCompetenza As AbstractPeriodo) As Boolean
      For Each elem As ItemIncassoQuotaAssociativa In InItemList
         If Not elem Is AsItem Then
            If elem.Competenza.Overlaps(WithCompetenza) Then Return True
         End If
      Next
   End Function
   Protected Overloads Function GetIndexItemByUtente(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo) As Integer
      For Each elem As ItemIncassoQuotaAssociativa In m_Items
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.Utente.IdUtente = Utente.IdUtente And Competenza.Equals(elem.Competenza) Then Return m_Items.IndexOf(elem)
         End If
      Next
      Return -1
   End Function
   Public Function GetItemListByUtente(ByVal Utente As IUtente) As ArrayList
      Dim list As New ArrayList
      For Each elem As ItemContabile In m_Items
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.Utente.IdUtente = Utente.IdUtente Then list.Add(elem)
         End If
      Next
      Return list
   End Function
   Private Overloads Sub RemoveItemWithUtente(ByVal Utente As IUtente)
      Dim i As Integer
      i = GetIndexItemByUtente(Utente)
      If i >= 0 Then
         m_Items.RemoveAt(i)
      End If
   End Sub
   Private Overloads Function GetIndexItemByUtente(ByVal Utente As IUtente) As Integer
      For Each elem As ItemIncassoQuotaAssociativa In m_Items
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.Utente.IdUtente = Utente.IdUtente Then Return m_Items.IndexOf(elem)
         End If
      Next
      Return -1
   End Function
   ''' <summary>
   ''' Metodo che restituisce True nel caso almeno una delle posizioni utente dell'incasso
   ''' siano state ristornate
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function HaItemRistornate() As Boolean
      For Each elem As ItemIncassoQuotaAssociativa In m_Items
         If elem.IsRistornata And elem.PosizioneUtente Then Return True
      Next
      Return False
   End Function

#End Region


#Region "Metodi per postare il documento"
   Protected Overrides Function CanPost() As Boolean
      If MyBase.CanPost() Then
         If Not m_importo.IsGreaterThan(New Moneta(0, m_importo.GetValuta)) Then
            Throw New Exception("Non si può registrare un documento di incasso con importo nullo")
         End If
      Else
         Return False
      End If
      Return True
   End Function
   Protected Overrides Sub DoValidation()
      'If Not MyBase.IsValid() Then
      '   ValidationErrors.Add("Errori nella validazione")
      'End If
      If Not CanPost() Then
            ValidationErrors.Add("Impossibile eseguire il post del documento: totale diverso da 0")
      End If
   End Sub
#End Region


End Class
