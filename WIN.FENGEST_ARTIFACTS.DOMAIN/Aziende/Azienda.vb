Public Class Azienda
   Inherits AbstractAzienda
   Protected m_CompetenzaUltimoPagamento As AbstractPeriodo = New PeriodoNullo
   Protected m_Conto As IConto = DomainFactory.GetContoNullo
   Protected m_UnitaCompetenza As IConfrontoPeriodi.UnitaDiCompetenza = IConfrontoPeriodi.UnitaDiCompetenza.Mensile
   Protected m_CongruityCalculator As AbstractCalculator = New CONGRUITY_CALCULATORS.LinearCalculator
   Protected m_Scarto As Double = 0.0
   Protected m_TipoCalcolatore As AbstractCalculator.TipoCalcolatore = AbstractCalculator.TipoCalcolatore.Lineare
   Protected m_TipoAzienda As TipoAzienda = TipoAzienda.AziendaPrivata
   Protected m_Contratto As TipoContratto = New TipoContrattoNullo
   Protected m_PartitaIva As String = ""
   Private m_SediOperative As IList = New VirtualLazyList

   Private m_DirectoryPreferenziale As String
   Private m_ArchivioDocumenti As New ArchivioDocumenti
   Private m_Segreteria As Segreteria
   Private m_Codifica As CodificaEnti


   Public Property Codifica() As CodificaEnti
      Get
         If m_Codifica Is Nothing Then
            m_Codifica = New CodificaEnti
         End If
         Return m_Codifica
      End Get
      Set(ByVal value As CodificaEnti)
         m_Codifica = value
      End Set
   End Property

   Public Property Segreteria() As Segreteria
      Get
         Return m_Segreteria
      End Get
      Set(ByVal value As Segreteria)
         m_Segreteria = value
      End Set
   End Property


   Public Property ArchivioDocumenti() As ArchivioDocumenti
      Get
         If m_ArchivioDocumenti Is Nothing Then
            m_ArchivioDocumenti = New ArchivioDocumenti
         End If
         Return m_ArchivioDocumenti
      End Get
      Set(ByVal value As ArchivioDocumenti)
         m_ArchivioDocumenti = value
      End Set
   End Property

   Public Property DirectoryPreferenziale() As String
      Get
         Return m_DirectoryPreferenziale
      End Get
      Set(ByVal value As String)
         m_DirectoryPreferenziale = value
      End Set
   End Property




   ''' <summary>
   ''' ATTENZIONE. Metodo utilizzato solamente dal mapper per valorizzare le sedi operative
   ''' NON UTILIZZARE
   ''' </summary>
   ''' <param name="Lista"></param>
   ''' <remarks></remarks>
   Public Sub SetSediOperative(ByVal Lista As IList)
      m_SediOperative = Lista
   End Sub
   Public Property PartitaIva() As String
      Get
         Return m_PartitaIva
      End Get
      Set(ByVal value As String)
         m_PartitaIva = value
      End Set
   End Property
   Public Enum TipoAzienda
      AziendaPrivata
      Inps
      EnteBilateraleEdili
   End Enum

   Protected Overrides Sub DoValidation()
      If MyBase.Descrizione = "" Then
         ValidationErrors.Add("Impossibile registrare i dati della segreteria con una ragione sociale nulla")
      End If
      If m_Conto Is Nothing Then
         ValidationErrors.Add("Conto nullo")
      End If
      If Me.DirectoryPreferenziale = "" Then
         If Me.Segreteria IsNot Nothing Then
            Me.DirectoryPreferenziale = Segreteria.DirectoryPreferenzialeAziende
         Else
            Me.DirectoryPreferenziale = "C:/"

         End If

      End If
   End Sub

#Region "Gestione sedi operative"

   Public ReadOnly Property SediOperative() As IList
      Get
         Return m_SediOperative
      End Get
   End Property
   Public Function GetNumeroSediOperative() As Int32
      Return m_SediOperative.Count
   End Function
   Public Sub AddSedeOperativa(ByVal SedeOperativa As SedeOperativa)
      If SedeOperativa Is Nothing Then Throw New ArgumentNullException("SedeOperativa")
      If GetSedeOperativaByDescrizione(SedeOperativa.Descrizione) Is Nothing Then
         SedeOperativa.SetAziendaPadre(Me)
         m_SediOperative.Add(SedeOperativa)
      Else
         Throw New InvalidOperationException("Sede operativa esistente")
      End If
   End Sub
   Public Function GetSedeOperativaByDescrizione(ByVal Descrizione As String) As SedeOperativa
      For Each elem As SedeOperativa In m_SediOperative
         If elem.Descrizione = UCase(Descrizione) Then
            Return elem
         End If
      Next
      Return Nothing
   End Function
   Public Function ExistSedeOperativa(ByVal Descrizione As String) As Boolean
      For Each elem As SedeOperativa In m_SediOperative
         If elem.Descrizione = UCase(Descrizione) Then
            Return True
         End If
      Next
      Return False
   End Function

   Public Overloads Sub RemoveSedeOperativa(ByVal SedeOperativa As SedeOperativa)
      If SedeOperativa Is Nothing Then Throw New ArgumentNullException("SedeOperativa")
      Dim sede As SedeOperativa = GetSedeOperativaByDescrizione(SedeOperativa.Descrizione)
      If Not sede Is Nothing Then
         m_SediOperative.Remove(sede)
      End If
   End Sub

   Public Overloads Sub RemoveSedeOperativa(ByVal DescrizioneSedeOperativa As String)
      Dim sede As SedeOperativa = GetSedeOperativaByDescrizione(DescrizioneSedeOperativa)
      If Not sede Is Nothing Then
         m_SediOperative.Remove(sede)
      End If
   End Sub

   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function

#End Region



#Region "Attività di collaborazione con il pagamento"
   Public Function CalcolaCompetenza(ByVal NumPeriodi As Integer) As AbstractPeriodo
      If m_CompetenzaUltimoPagamento.GetDataRange.IsEmpty Then Throw New Exception("Il periodo di competenza dell'ultimo pagamento del soggetto esecutore è nullo. Inserire un intervallo temporale anzichè il numero di quote mensili pagate!")
      Return m_CompetenzaUltimoPagamento.GetNextPeriod(NumPeriodi)
   End Function
   Public Sub CheckCongruity(ByVal PosizioneDiPagamento As IValuableForCongruity)
      PosizioneDiPagamento.SetCongruitaPosizione(CalcolaCongruita(PosizioneDiPagamento))
   End Sub
   Private Function CalcolaCongruita(ByVal PosizioneDiIncasso As IValuableForCongruity) As IValuableForCongruity.Congruita
      'qui posso fare uso di vari strategy per eseguire il calcolo. Lo strategy può essere 
      'una variabile dell'utente impostata in anagrafica.
      Return m_CongruityCalculator.CalaculateCongruity(PosizioneDiIncasso)
   End Function
#End Region

#Region "Costruttori"
   Public Sub New(ByVal Descrizione As String, ByVal CompetenzaUltimoPagamento As AbstractPeriodo, _
                  ByVal Conto As IConto, _
                  ByVal UnitaComptenzaPagamenti As IConfrontoPeriodi.UnitaDiCompetenza, _
                  ByVal RegolaCalcoloCongruita As AbstractCalculator.TipoCalcolatore, _
                  ByVal PercentualeScarto As Double, ByVal ContrattoApplicato As TipoContratto)
      If Conto Is Nothing Then Throw New Exception("Non è possibile creare un oggetto Azienda senza un oggetto conto valido. Inserire un identificativo corretto.")
      If Conto.IdConto = -1 Then Throw New Exception("Non è possibile creare un oggetto azienda senza un oggetto conto valido. Tipo conto nullo.")
      If Descrizione = "" Then Throw New Exception("Non è possibile creare un oggetto Azienda con una descrizione vuota. Inserire una descrizione corretta.")
      If CompetenzaUltimoPagamento Is Nothing Then Throw New Exception("Non è possibile creare un oggetto Azienda con un oggetto Competenza Ultimo Pagamento nullo.")
      If ContrattoApplicato Is Nothing Then Throw New Exception("Impossibile creare il contratto applicato. Contratto nullo")
      m_Conto = Conto
      m_Contratto = ContrattoApplicato
      MyBase.Descrizione = UCase(Descrizione)
      m_CompetenzaUltimoPagamento = CompetenzaUltimoPagamento
      m_UnitaCompetenza = UnitaComptenzaPagamenti
      If PercentualeScarto <= 100.0 And PercentualeScarto >= 0.0 Then
         m_CongruityCalculator = FactoryCongruityCalc.GetCongruityCalculator(RegolaCalcoloCongruita)
         m_Scarto = CDbl(Format(PercentualeScarto, "###0.00"))
         m_TipoCalcolatore = RegolaCalcoloCongruita
      Else
         Throw New Exception("Impossibile creare un'azienda con una regola di calcolo della congruità con scarto non compreso tra 0 e 100!")
      End If
   End Sub
   Public Sub New()
   End Sub
#End Region

#Region "Proprietà azienda"
   Public Property ContrattoApplicato() As TipoContratto
      Get
         Return m_Contratto
      End Get
      Set(ByVal value As TipoContratto)
         If value Is Nothing Then Throw New Exception("Impossibile impostare il contratto applicato. Contratto nullo")
         m_Contratto = value
      End Set
   End Property
   Public ReadOnly Property TipologiaAzienda() As TipoAzienda
      Get
         Return m_TipoAzienda
      End Get
   End Property
   Public Sub SetCongruityRules(ByVal CongruityRule As AbstractCalculator.TipoCalcolatore, ByVal PercScarto As Double)
      If PercScarto <= 100.0 And PercScarto >= 0.0 Then
         m_CongruityCalculator = FactoryCongruityCalc.GetCongruityCalculator(CongruityRule)
         m_Scarto = CDbl(Format(PercScarto, "###0.00"))
         m_TipoCalcolatore = CongruityRule
      Else
         Throw New Exception("Impossibile impostare le regole di congruità per l'azienda con una regola di calcolo della congruità con scarto non compreso tra 0 e 100!")
      End If
   End Sub
   Public Property CalcolatoreCongruita() As AbstractCalculator.TipoCalcolatore
      Get
         Return m_TipoCalcolatore
      End Get
      Set(ByVal value As AbstractCalculator.TipoCalcolatore)
         m_CongruityCalculator = FactoryCongruityCalc.GetCongruityCalculator(value)
         m_TipoCalcolatore = value
      End Set
   End Property
   Public Property Scarto() As Double
      Get
         Return m_Scarto
      End Get
      Set(ByVal value As Double)
         m_Scarto = CDbl(Format(value, "###0.00"))
      End Set
   End Property
   ''' <summary>
   ''' Questa proprietà è impostata dal post dell'ultimo pagamento effettuato nel caso in cui 
   ''' la competenza dell'ultimo pagamento abbia una data fine posteriore all'attuale periodo di competenza.
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property CompetenzaUltimoPagamento() As AbstractPeriodo
      Get
         Return m_CompetenzaUltimoPagamento
      End Get
      Set(ByVal value As AbstractPeriodo)
         If value Is Nothing Then Throw New Exception("Non è possibile assegnare un periodo di ultimo pagamento nullo")
         If m_CompetenzaUltimoPagamento.GetDataRange.IsEmpty Then
            m_CompetenzaUltimoPagamento = value
            Return
         End If
         If value.GetDataRange.Finish > m_CompetenzaUltimoPagamento.GetDataRange.Finish Then
            m_CompetenzaUltimoPagamento = value
         End If
      End Set
   End Property
   Public Property Conto() As IConto
      Get
         Return m_Conto
      End Get
      Set(ByVal value As IConto)
         If value Is Nothing Then Throw New Exception("Non è possibile impostare un conto di riferimento nullo per un'azienda.")
         ' If value.IdConto = -1 Then Throw New Exception("Non è possibile creare un oggetto azienda senza un oggetto conto valido. Tipo conto nullo.")
         m_Conto = value
      End Set
   End Property
   Public Property UnitaDiCompetenza() As IConfrontoPeriodi.UnitaDiCompetenza
      Get
         Return m_UnitaCompetenza
      End Get
      Set(ByVal value As IConfrontoPeriodi.UnitaDiCompetenza)
         m_UnitaCompetenza = value
      End Set
   End Property
   Public ReadOnly Property IdAzienda() As Int32
      Get
         Return MyBase.Key.LongValue
      End Get
   End Property
#End Region

End Class
