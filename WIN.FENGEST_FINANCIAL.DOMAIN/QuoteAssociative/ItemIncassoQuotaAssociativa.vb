Public Class ItemIncassoQuotaAssociativa
   Inherits ItemContabile
   Implements IValuableForCongruity
   Implements IPayble
   ' variabile impostata dall'oggetto utente per dire che c'è una delega per cui il pagamento può avvenire
    Protected m_PosizionePagabile As Boolean
   Protected m_PosizioneUtente As Boolean




#Region "Metodi dell'interfaccia IPayble"
   ''' <summary>
   ''' Metodo utilizzato in fase di verifica della pagabilità della posizione. Esso implementa l'interfaccia IPayble
   ''' </summary>
   ''' <param name="PuoAccettarePagamento"></param>
   ''' <param name="Errore"></param>
   ''' <remarks></remarks>
   Public Sub SetPosizionePagabile(ByVal PuoAccettarePagamento As Boolean, ByVal Errore As String) Implements IPayble.SetPosizionePagabile
      m_PosizionePagabile = PuoAccettarePagamento
      If Not m_PosizionePagabile Then Throw New Exception(Errore)
   End Sub
#End Region

#Region "Metodi dell'interfaccia IValuableForCongruity"
   ''' <summary>
   ''' Metodo che imposta la congruità della posizione. e' richiamato dal package dei congruity calculators
   ''' </summary>
   ''' <param name="Congrua"></param>
   ''' <remarks></remarks>
   Public Sub SetCongruitaPosizione(ByVal Congrua As IValuableForCongruity.Congruita) Implements IValuableForCongruity.SetCongruitaPosizione
      m_Congruita = Congrua
   End Sub
   ''' <summary>
   ''' Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property GetCompetenza() As AbstractPeriodo Implements IValuableForCongruity.Competenza, IPayble.Competenza
      Get
         Return m_Competenza
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property GetImporto() As Moneta Implements IValuableForCongruity.Importo
      Get
         Return m_Importo
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property QuattordicesimaInclusa() As Boolean Implements IValuableForCongruity.QuattordicesimaInclusa
      Get
         Return m_QuattordicesimaInclusa
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property TredicesimaInclusa() As Boolean Implements IValuableForCongruity.TredicesimaInclusa
      Get
         Return m_TredicesimaInclusa
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property GetCongruita() As IValuableForCongruity.Congruita
      Get
         Return m_Congruita
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property TipoConfrontoCompetenze() As IConfrontoPeriodi.UnitaDiCompetenza Implements IValuableForCongruity.TipoConfrontoCompetenze
      Get
         Return m_SoggettoEsecutore.UnitaDiCompetenza
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property QuotaMensileUtente() As Moneta Implements IValuableForCongruity.QuotaMensileUtente
      Get
         Return m_Utente.QuotaMensile
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property PercentualeScarto() As Double Implements IValuableForCongruity.PercentualeScarto
      Get
         Return m_SoggettoEsecutore.Scarto
      End Get
   End Property
   ''' <summary>
   '''  Metodo dell'interfaccia IValuableForCongruity utilizzato dal package dei congruity calculators
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property QuotaMedia() As Moneta Implements IValuableForCongruity.QuotaMedia
      Get
         'If m_QuotaMedia Is Nothing Then Return New Moneta(0.0, m_Importo.GetValuta)
         Return m_QuotaMedia
      End Get
      Set(ByVal value As Moneta)
         m_QuotaMedia = value
      End Set
   End Property
#End Region

   
#Region "Costruttori"""
   Public Sub New()

   End Sub
   ''' <summary>
   ''' Il costruttore dell'item del pagamento potrà essere usato solo dalla classe documento contabile e 
   ''' specificamente dal metodo AddItem per 
   ''' mantenere la sincronizzazione a causa del riferimento circolare. Il metodo è public per
   ''' consentire ad un mapper di poter instanziare l'oggetto 
   ''' </summary>
   ''' <param name="IncassoQuote"></param>
   ''' <param name="Importo"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="SoggettoEsecutore"></param>
   ''' <param name="Quattordicesima"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal IncassoQuote As DocumentoContabile, ByVal Importo As Moneta, _
                  ByVal Competenza As AbstractPeriodo, ByVal SoggettoEsecutore As Azienda, _
                  ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, ByVal Note As String)

      MyBase.New(IncassoQuote, Note, Importo, SoggettoEsecutore.Conto)

      If Competenza Is Nothing Then Throw New Exception("Impossibile creare una nuova posizione documento con una competenza nulla")

      MyBase.m_TipoDocumento = IncassoQuote.TipoDocumento
      MyBase.m_settore = DirectCast(IncassoQuote, IncassoQuotaAssociativa).Settore
      m_SoggettoEsecutore = SoggettoEsecutore
      m_Competenza = Competenza
      m_PosizioneUtente = False
      m_TredicesimaInclusa = Tredicesima
      m_QuattordicesimaInclusa = Quattordicesima
    End Sub


    Protected Sub New(ByVal Documento As AbstractDocumento, ByVal Note As String, ByVal Importo As Moneta, ByVal Conto As Conto)
        MyBase.New(Documento, Note, Importo, Conto)
    End Sub

   ''' <summary>
   ''' Il costruttore dell'item del pagamento potrà essere usato solo dalla classe pagamento e 
   ''' specificamente dal metodo AddItem per 
   ''' mantenere la sincronizzazione a causa del riferimento circolare. Il metodo è public per
   ''' consentire ad un mapper di poter instanziare l'oggetto
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="IncassoQuote"></param>
   ''' <param name="Importo"></param>
   ''' <param name="Referente"></param>
   ''' <param name="Note"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="Tredicesima"></param>
   ''' <param name="Quattordicesima"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Utente As IUtente, ByVal IncassoQuote As DocumentoContabile, _
                  ByVal Importo As Moneta, ByVal Referente As Referente, ByVal SoggettoEsecutore As Azienda, _
                  ByVal Note As String, ByVal Competenza As AbstractPeriodo, _
                  ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, Optional ByVal NotCheckPaybility As Boolean = False, Optional ByVal SedeOperativa As SedeOperativa = Nothing)

      MyBase.New(IncassoQuote, Note, Importo, Utente.Conto)

      If Utente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa con un utente nullo")
      If TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un utente")
      If Referente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativaa con un referente nullo")
      'If TypeOf (Referente) Is ReferenteNullo Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un referente")
      If SoggettoEsecutore Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativaa con un Soggetto Esecutore nullo")
      If TypeOf (SoggettoEsecutore) Is AziendaNonSpecificata Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un Soggetto Esecutore")



      MyBase.m_TipoDocumento = IncassoQuote.TipoDocumento
      MyBase.m_settore = DirectCast(IncassoQuote, IncassoQuotaAssociativa).Settore
      m_Utente = Utente
      If Competenza.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare una posizione di pagamento con una competenza negativa o vuota")
      m_Competenza = Competenza
      m_PosizioneUtente = True
      m_Referente = Referente
      m_TredicesimaInclusa = Tredicesima
      m_QuattordicesimaInclusa = Quattordicesima
      m_SoggettoEsecutore = SoggettoEsecutore
      If MyBase.m_settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
         MyBase.AziendaImpiego = SoggettoEsecutore
         If SedeOperativa Is Nothing Then
            MyBase.SetSedeOperativa(Utente.GetActiveDelegaFor(SoggettoEsecutore, Competenza.GetDataRange.Finish).SedeOperativa)
         Else
            MyBase.SetSedeOperativa(SedeOperativa)
         End If
         'MyBase.ContrattoApplicato = SoggettoEsecutore.ContrattoApplicato
      End If
      If Not NotCheckPaybility Then
         Utente.CheckPaybility(Me, m_SoggettoEsecutore)
         m_Referente = Utente.GetActiveDelegaFor(m_SoggettoEsecutore, Competenza.GetDataRange.Start).Referente
      End If
      m_SoggettoEsecutore.CheckCongruity(Me)
   End Sub
#End Region

#Region "Proprietà del Item del documento contabile che provocano un ricalcolo della congruità"
   '*************************************
   '*************************************
   'Metodi e proprietà èer la variazione dell'importo

   ''' <summary>
   ''' Proprieta che esegue l'override della proprietà Importo della classe base per 
   ''' permetterne la valutazione della congruità, della quota media versata e il ricalcolo 
   ''' dell'importo nel documento padre nel caso il 
   ''' documento sia gia registrato
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overrides Property Importo() As Moneta
      Get
         Return m_Importo
      End Get
      Set(ByVal value As Moneta)
         If Me.m_DocumentoRistorno.Id = -1 Then
            m_Importo = value
            If MyBase.m_DocumentoPadre.IsPosted And m_PosizioneUtente Then
               'Modifico l'importo del documento padre per fare in modo che il totale faccia 0
               Dim docPadre As IncassoQuotaAssociativa = DirectCast(MyBase.m_DocumentoPadre, IncassoQuotaAssociativa)
               DirectCast(MyBase.m_DocumentoPadre, IncassoQuotaAssociativa).Importo = CalculateNewImporto(value, docPadre)
            End If
            CheckCongruity()
         Else
            Throw New Exception("Impossibile impostare l'importo della posizione. Posizione già ristornata")
         End If
      End Set
   End Property
    Protected Function CalculateNewImporto(ByVal ImportoItem As Moneta, ByVal DocPadre As IncassoQuotaAssociativa) As Moneta
        Dim total As Moneta = DocPadre.GetTotal
        Dim importoIncasso As Moneta = DocPadre.Importo
        Return importoIncasso.Subtract(total)
    End Function
   Protected Overridable Sub CheckCongruity()
      If m_PosizioneUtente Then
         m_SoggettoEsecutore.CheckCongruity(Me)
      End If
   End Sub
   '*************************************
   '*************************************

   '*************************************
   '*************************************
   'Metodi e proprietà per la variazione della competenza

   ''' <summary>
   ''' Proprietà che imposta la competenza per la posizione, Verifica che la competenza non è nulla e
   ''' e che non esistano posizioni sovrapposte per lo stesso utente
   ''' all'interno dell'incasso. Ricalcola la congruità e la quota media versata. Riverifica la pagabilita della posizione
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overrides Property Competenza() As AbstractPeriodo
      Get
         Return m_Competenza
      End Get
      Set(ByVal value As AbstractPeriodo)
         'aggiungere il criterio di pagabilità
         If value.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare o impostare un pagamento con una competenza negativa o vuota")
         CheckExistenceSimilar(value)
         CheckCongruity()
      End Set
   End Property
   Protected Overridable Sub CheckExistenceSimilar(ByVal Value As AbstractPeriodo)
      If Not DirectCast(DocumentoPadre, IncassoQuotaAssociativa).ExistSimilarItemsForUtente(MyBase.m_Utente, Me, Value) Then
         m_Competenza = Value
      Else
         Throw New Exception("Impossibile impostare il nuovo valore per la competenza. Essa interseca la competenza di una posizione già esistente per lo stesso utente.")
      End If
   End Sub
   '*************************************
   '*************************************

   ''' <summary>
   ''' Proprietà che restituisce ed imposta il referente. L'impostazione del referente avviene solo se 
   ''' non esiste un ristorno al referente
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overrides Property Referente() As Referente
      Get
         Return m_Referente
      End Get
      Set(ByVal value As Referente)
         If value Is Nothing Then Throw New Exception("Impossibile impostare il referente per la posiizone incasso quota. Referente Nullo")
         If value.Id = m_Referente.Id Then Exit Property
         If Me.PagamentoReferente.Id = -1 Then
            m_Referente = value
         Else
            Throw New Exception("Impossibile impostare il referente per laposizione. Esiste un ristorno referente associato.")
         End If
      End Set
   End Property

   Public Overrides Property Tredicesima() As Boolean
      Get
         Return m_TredicesimaInclusa
      End Get
      Set(ByVal value As Boolean)
         m_TredicesimaInclusa = value
         CheckCongruity()
      End Set
   End Property
   Public Overrides Property Quattordicesima() As Boolean
      Get
         Return m_QuattordicesimaInclusa
      End Get
      Set(ByVal value As Boolean)
         m_QuattordicesimaInclusa = value
         CheckCongruity()
      End Set
   End Property

   Public ReadOnly Property IsRistornata() As Boolean
      Get
         Return Me.PagamentoReferente.Id <> -1
      End Get
   End Property
#End Region

   Public Function PosizioneUtente() As Boolean
      Return m_PosizioneUtente
   End Function



#Region "Metodo per la gestione della transazione relativa alla registraiozne della posizione"

   ''' <summary>
   ''' Metodo che esegue le operazioni necessarie alla registrazione della posizione di incasso quota associativa.
   ''' Se si tratta di una posizione utente attiva la delega per 
   ''' l'utente considerato (ammesso che la delega non sia già attiva), mentre se si tratta di una posizione azienda
   ''' registra la competenza dell'ultimo pagamento effettuato sull'oggetto azienda.
   ''' </summary>
   ''' <remarks></remarks>
   Protected Overrides Sub DoPost()
      If m_PosizioneUtente Then
         m_Utente.ActivateDelega(Me.SoggettoEsecutore, MyBase.m_DocumentoPadre)
         m_Utente.ChangeSedeOperativa(Me.SoggettoEsecutore, Me.Competenza.GetDataRange.Finish, Me.SedeOperativaAzienda)
      Else
         m_SoggettoEsecutore.CompetenzaUltimoPagamento = m_Competenza
      End If
   End Sub

#End Region
End Class
