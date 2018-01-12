Namespace FINANCIAL_ARTIFACTS
   Public Class ControllerIncassiQuote
      Inherits AbstractDocumentController
      Protected m_PagamentoCreato As Boolean = False
      Protected controllerUtenti As New UTENTI.ControllerUtenti
      Protected controllerAziende As New AZIENDE.ControllerAziende
      Private controllerEnti As New AZIENDE.ControllerEntiBilaterali
      Protected controllerReferenti As New FINANCIAL_ARTIFACTS.ControllerReferenti
        Private ControllerSettori As New ControllerSettori
        Private ControllerTipoContratto As New ControllerTipoContratto
      Protected ControllerInps As New AZIENDE.ControllerInps
      Public Sub New()
         Ps.BeginTransaction()
      End Sub
      Private Function Current() As IncassoQuotaAssociativa
         Return DirectCast(MyBase.m_current, IncassoQuotaAssociativa)
      End Function

#Region "Proprietà Pagamento Testata"
      Public ReadOnly Property IdSettore() As Int32
         Get
            Return Current.Settore.Id
         End Get
      End Property
      Public ReadOnly Property DescrizioneSettore() As String
         Get
            Return Current.Settore.Descrizione
         End Get
      End Property
      Public Overridable ReadOnly Property Importo() As Double
         Get
            Return Current.Importo.Importo
         End Get
      End Property
      Public Overridable Sub SetImporto(ByVal value As String)
         If Current.IsPosted Then Throw New Exception("Impossibile impostare l'importo dell'incasso. Documento già registrato.")
         If Not IsNumeric(value) Then Throw New Exception("Il formato dell'importo non è corretto. Inserire un importo corretto.")
         Dim val As Double = CDbl(value)
         If val < 0 Then
            val = val * -1
         End If
         Dim importo As Moneta = New Moneta(val, Current.Importo.GetValuta)
         Current.Importo = importo
      End Sub
      Public Overrides ReadOnly Property IdSoggettoEsecutore() As String
         Get
            Return Current.SoggettoEsecutore.Key.LongValue
         End Get
      End Property
      Public ReadOnly Property CompetenzaUltimoPagamento() As String
         Get
            Return Current.SoggettoEsecutore.CompetenzaUltimoPagamento.ToString
         End Get
      End Property
      Public ReadOnly Property Valuta() As String
         Get
            Return Moneta.GetTipoValutaToString(Current.GetItemWithSoggEsecutore.Importo.GetValuta)
         End Get
      End Property
      Public ReadOnly Property DataInizioCompetenza() As DateTime
         Get
            Return Current.Competenza.GetDataRange.Start
         End Get
      End Property
      Public ReadOnly Property DataFineCompetenza() As DateTime
         Get
            Return Current.Competenza.GetDataRange.Finish
         End Get
      End Property
      Public Overridable ReadOnly Property ListaPosizioniUtenti() As IList
         Get
            Try
               Dim list As IList = Current.ItemList.Clone
               list.RemoveAt(Current.GetIndexItemBySoggEsecutore)
               Return list
            Catch ex As Exception
               Return New ArrayList
            End Try
         End Get
      End Property
      Public ReadOnly Property IsForSettoreEdile() As Boolean
         Get
            Return IIf(Current.Settore.TipologiaSettore = Settore.TipoSettore.Edili, True, False)
         End Get
      End Property
      Public ReadOnly Property DescrizioneSoggettoEsecutore() As String
         Get
            Return Current.SoggettoEsecutore.Descrizione
         End Get
      End Property
      Public Overridable ReadOnly Property TotaleAttribuito() As Double
         Get
            Return Current.Importo.Importo - Current.GetTotal.Importo
         End Get
      End Property
      Public ReadOnly Property ListaSediForSoggetto() As ArrayList
         Get
            If Current.Settore.TipologiaSettore = Settore.TipoSettore.ImpiantiFissi Then
               Dim lista As ArrayList = New ArrayList
               For Each elem As SedeOperativa In Current.SoggettoEsecutore.SediOperative
                  lista.Add(elem.Descrizione)
               Next
               Return lista
            End If
            Return New ArrayList
         End Get
      End Property
  
#Region "Lettura e scrittura della proprietà competenza per il pagamento"
      Public ReadOnly Property Competenza() As String
         Get
            Return Current.Competenza.ToString
         End Get
         'per cambiare la competenza è necessario un vero e proprio calcolo
      End Property
      Public Overloads Sub SetCompetenza(ByVal PeriodoInizio As Integer, ByVal AnnoInizio As Integer, ByVal PeriodoFine As Integer, ByVal AnnoFine As Integer)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Current.SoggettoEsecutore.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = New CompositePeriodo(PeriodoInizio, AnnoInizio, PeriodoFine, AnnoFine, unita)
         Current.Competenza = competenza
      End Sub
      Public Overloads Sub SetCompetenza(ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Current.SoggettoEsecutore.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), unita)
         Current.Competenza = competenza
      End Sub
      Public Overloads Sub SetCompetenza(ByVal Data As DateTime)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Current.SoggettoEsecutore.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = IIf(unita = IConfrontoPeriodi.UnitaDiCompetenza.Mensile, New PeriodoMensile(Data), New PeriodoGiornaliero(Data))
         Current.Competenza = competenza
      End Sub
      Public Overloads Sub SetCompetenza(ByVal PeriodoInizio As Integer, ByVal AnnoInizio As Integer)
         Dim competenza As AbstractPeriodo = New PeriodoMensile(PeriodoInizio, AnnoInizio)
         Current.Competenza = competenza
      End Sub
#End Region

#End Region

#Region "Proprietà Item di pagamento"

#Region "Lettura e scrittura della proprietà competenza per la posizione di pagamento"

      Public Overloads Sub SetCompetenzaItem(ByVal PeriodoInizio As Integer, ByVal AnnoInizio As Integer, ByVal PeriodoFine As Integer, ByVal AnnoFine As Integer)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Current.SoggettoEsecutore.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = New CompositePeriodo(PeriodoInizio, AnnoInizio, PeriodoFine, AnnoFine, unita)
         m_currentItem.Competenza = competenza
      End Sub
      Public Overloads Sub SetCompetenzaItem(ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Current.SoggettoEsecutore.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), unita)
         m_currentItem.Competenza = competenza
      End Sub
      Public Overloads Sub SetCompetenzaItem(ByVal Data As DateTime)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Current.SoggettoEsecutore.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = IIf(unita = IConfrontoPeriodi.UnitaDiCompetenza.Mensile, New PeriodoMensile(Data), New PeriodoGiornaliero(Data))
         m_currentItem.Competenza = competenza
      End Sub
      Public Overloads Sub SetCompetenzaItem(ByVal PeriodoInizio As Integer, ByVal AnnoInizio As Integer)
         Dim competenza As AbstractPeriodo = New PeriodoMensile(PeriodoInizio, AnnoInizio)
         m_currentItem.Competenza = competenza
      End Sub
#End Region

      Public ReadOnly Property IsCreated() As Boolean
         Get
            Return Me.m_PagamentoCreato
         End Get
      End Property
      Public ReadOnly Property DescrizioneSoggettoEsecutoreItem() As String
         Get
            Return m_currentItem.SoggettoEsecutore.Descrizione
         End Get
      End Property
      Public Sub SetReferenteItem(ByVal IdReferente As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdReferente) Then Throw New Exception("L'id del referente  non ha un formato corretto. Inserire un id corretto.")
            m_currentItem.Referente = controllerReferenti.GetReferenteById(IdReferente)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Sub SetSedeOperativaItem(ByVal NomeSede As String)
         If Current.Settore.TipologiaSettore = Settore.TipoSettore.ImpiantiFissi Then
            Dim sede As SedeOperativa = m_currentItem.SoggettoEsecutore.GetSedeOperativaByDescrizione(NomeSede)
            If sede Is Nothing Then sede = New SedeOperativaNulla
            m_currentItem.SetSedeOperativa(sede)
         End If
      End Sub
      Public Sub SetImportoItem(ByVal value As String)
         If value = "" Then value = 0
         If Not IsNumeric(value) Then Throw New Exception("Il formato dell'importo di ristorno della posizione  non è corretto. Inserire un importo corretto.")
         Dim moneta As Moneta = New Moneta(value, m_currentItem.Importo.GetValuta)
         If m_currentItem.Importo.Equals(moneta.Negate) Then Exit Sub
         m_currentItem.Importo = moneta.Negate
      End Sub


#End Region

#Region "Metodi per la gestione del documento"
      ''' <summary>
      ''' Seleziona un item nella lista delle posizioni
      ''' </summary>
      ''' <param name="IdUtente"></param>
      ''' <param name="DataInizio"></param>
      ''' <param name="datafine"></param>
      ''' <remarks></remarks>
      Public Overloads Sub SelectItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
         If Not IsNumeric(IdUtente) Then Throw New Exception("L'item selezionato non ha un Id utente corretto!")
         m_currentItem = Current.GetItem(GetUtenteById(IdUtente), New CompositePeriodo(New DataRange(DataInizio, DataFine), Current.SoggettoEsecutore.UnitaDiCompetenza))
      End Sub
      ''' <summary>
      ''' Old non usare
      ''' </summary>
      ''' <remarks></remarks>
      Public Sub CreateDefaultPosition()
         Dim Lista As ArrayList = GetListaUtentiAttivi(Current.Competenza)
         For Each elem As Utente In Lista
            Current.AddItem(elem, 0.0, Current.Competenza, elem.GetActiveDelegaFor(Current.SoggettoEsecutore).Referente, "")
         Next
      End Sub

   
      Private Overloads Function CreateCompetenza(ByVal Soggetto As Azienda, ByVal PeriodoInizio As Integer, ByVal AnnoInizio As Integer, ByVal PeriodoFine As Integer, ByVal AnnoFine As Integer)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Soggetto.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = New CompositePeriodo(PeriodoInizio, AnnoInizio, PeriodoFine, AnnoFine, unita)
         Return competenza
      End Function
      Protected Overloads Function CreateCompetenza(ByVal Soggetto As Azienda, ByVal DataInizio As DateTime, ByVal Datafine As DateTime)
         Dim unita As IConfrontoPeriodi.UnitaDiCompetenza = Soggetto.UnitaDiCompetenza
         Dim competenza As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, Datafine), unita)
         Return competenza
      End Function
      Public Overridable Function EsistonoIncassiSovrapposti() As Boolean

         Dim pagamenti As ArrayList = GetIncassiForSoggetto(Current.SoggettoEsecutore)
         'For Each elem As IncassoQuotaAssociativa In pagamenti
         '   If elem.Competenza.Overlaps(Current.Competenza) Then Return True
         'Next
         If pagamenti.Count = 0 Then Return False
         Return True

      End Function
      'Public Overrides Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

      'End Sub


      Public Overloads Sub AddItem(ByVal IdUtente As String, ByVal Importo As String, ByVal IdReferente As String, ByVal Note As String, ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, ByVal PeriodoInizio As Integer, ByVal AnnoInizio As Integer, ByVal PeriodoFine As Integer, ByVal AnnoFine As Integer, Optional ByVal NotCheckPaybility As Boolean = False)

         If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         Dim utente As Utente = GetUtenteById(IdUtente)
         Dim referente As Referente = GetReferenteById(IdReferente)
         Dim competenza As AbstractPeriodo = Me.CreateCompetenza(Current.SoggettoEsecutore, PeriodoInizio, AnnoInizio, PeriodoFine, AnnoFine)
         Current.AddItem(utente, Importo, competenza, referente, Note, NotCheckPaybility)
         If Current.IsPosted Then
            Ps.MarkNew(Current.GetItem(utente, competenza))
         End If

      End Sub
      Public Overloads Sub AddItem(ByVal IdUtente As String, ByVal Importo As String, ByVal IdReferente As String, ByVal Note As String, ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, Optional ByVal NotCheckPaybility As Boolean = False)

         If IdReferente = "" Then IdReferente = -1
         If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         Dim utente As Utente = GetUtenteById(IdUtente)
         Dim referente As Referente = New ReferenteNullo
         If CInt(IdReferente) > 0 Then
            referente = GetReferenteById(IdReferente)
         End If
         Dim competenza As AbstractPeriodo = Me.CreateCompetenza(Current.SoggettoEsecutore, DataInizio, DataFine)
         Current.AddItem(utente, Importo, competenza, referente, Note, NotCheckPaybility)
         If Current.IsPosted Then
            Ps.MarkNew(Current.GetItem(utente, competenza))
         End If

      End Sub
      Public Overloads Sub RemoveItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, Optional ByVal NotCheckPaybility As Boolean = False)

         If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
         Dim utente As Utente = GetUtenteById(IdUtente)
         Dim competenza As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), Current.SoggettoEsecutore.UnitaDiCompetenza)
         If Not Current.GetItem(utente, competenza).PagamentoReferente.Id = -1 Then
            Throw New Exception("Impossibile rimuovere l'item selezionato. Esiste un pagamento referenti cui la posizione è stata ristornata")
         End If
         If Current.IsPosted Then
            Ps.MarkRemoved(Current.GetItem(utente, competenza))
         End If
         Current.RemoveItem(utente, competenza)

      End Sub


#End Region


#Region "Metodi di ricerca dal database"
      Protected Overridable Function GetIncassiForSoggetto(ByVal Soggetto As Azienda) As ArrayList

         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperIncassoQuotaAssociativa")
         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
         mainCriteria.AddCriteria(New AndExp(Criteria.Equal("TIPO_DOCUMENTO", "'IQA'"), Criteria.Equal("ID_AZIENDA", Soggetto.IdAzienda)))
         mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", Current.Competenza.GetDataRange.Start, Current.Competenza.GetDataRange.Finish, ps.DBType))
         mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", IIf(Current.Settore.TipologiaSettore = Settore.TipoSettore.Edili, 2, 1)))
         query.AddWhereClause(mainCriteria)
         Return query.Execute(ps)

      End Function
      Private Function GetListaUtentiAttivi(ByVal Competenza As AbstractPeriodo) As ArrayList

         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperUtente")
         Dim subCriteria As AbstractBoolCriteria = New OrExp(Criteria.Equal("STATO_DELEGA", "'Attivata'"), Criteria.Equal("STATO_DELEGA", "'Accettata'"))
         subCriteria = New AndExp(subCriteria, Criteria.Equal("ID_SETTORE", IIf(Current.Settore.TipologiaSettore = Settore.TipoSettore.Edili, APPLICATION.ControllerSettori.GetSettoreByTipo("Edile").Id, APPLICATION.ControllerSettori.GetSettoreByTipo("ImpiantiFissi").Id)))
         Dim SubQry As SubQueryCriteria = New SubQueryCriteria("DB_DELEGA", "ID_UTENTE")
         SubQry.AddCriteria(subCriteria)
         subCriteria = Criteria.Equal("ID_AZIENDA", Current.SoggettoEsecutore.IdAzienda)
         SubQry.AddCriteria(subCriteria)
         Dim compCriteria As AbstractBoolCriteria = New OrExp(Criteria.DateContained("DATA_ACCETTAZIONE", New DateTime(1800, 1, 1), Competenza.GetDataRange.Finish, ps.DBType), Criteria.DateContained("DATA_ATTIVAZIONE", New DateTime(1800, 1, 1), Competenza.GetDataRange.Finish, ps.DBType))
         SubQry.AddCriteria(compCriteria)

         Dim MainCriteria As Criteria = Criteria.INClause("ID", SubQry)
         query.AddWhereClause(MainCriteria)
         Return query.Execute(ps)

      End Function
      Protected Function GetUtenteById(ByVal IdUtente As Int32) As Utente
         Try
            Return controllerUtenti.GetUtenteById(IdUtente)
         Catch ex As Exception
            Throw New Exception("Impossibile recuperare l'utente" & vbCrLf & ex.Message)
         End Try
      End Function
      Protected Function GetReferenteById(ByVal IdReferente As Int32) As Referente
         Try
            Return controllerReferenti.GetReferenteById(IdReferente)
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere il referente con id " & IdReferente & vbCrLf & ex.Message)
         End Try
      End Function
      Private Function GetSoggettoEsecutoreById(ByVal IdSoggettoEsecutore As Int32, ByVal Settore As Settore) As Azienda
         Try
            If Settore.TipologiaSettore = Settore.TipoSettore.Edili Then
               Return controllerEnti.GetEnteById(IdSoggettoEsecutore)
            Else
               Return controllerAziende.GetAziendaById(IdSoggettoEsecutore)
            End If
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
#End Region

#Region "Metodi CRUD"
      Protected Overrides Sub LoadAll()

         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperIncassoQuotaAssociativa")
         Dim mainCriteria As Criteria = Criteria.Equal("TIPO_DOCUMENTO", "'IQA'")
         query.AddWhereClause(mainCriteria)
         DomainObjectList = query.Execute(ps)

      End Sub
      Public Sub PreAcquisisciDocumento()
         'in questo metodo serializzo l'oggetto pagamento e lo salvo così com'è nel
         'database
      End Sub
      ''' <summary>
      ''' Metodo non implementato
      ''' </summary>
      ''' <remarks></remarks>
      Public Overrides Sub CreateNew()
         Throw New Exception("Metodo non implementato")
      End Sub
      ''' <summary>
      ''' NON USARE. Crea un'istanza completa dell'oggetto incasso con le relative posizioni di default senza salvare
      ''' </summary>
      ''' <param name="DataRegistrazione"></param>
      ''' <param name="IdSoggettoEsecutore"></param>
      ''' <param name="Importo"></param>
      ''' <param name="Note"></param>
      ''' <param name="PeriodoInizio"></param>
      ''' <param name="AnnoInizio"></param>
      ''' <param name="PeriodoFine"></param>
      ''' <param name="AnnoFine"></param>
      ''' <param name="Tredicesima"></param>
      ''' <param name="Quattordicesima"></param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                                     ByVal IdSoggettoEsecutore As String, ByVal Importo As String, _
                                     ByVal Note As String, ByVal IdSettoreDocumento As String, ByVal PeriodoInizio As Integer, _
                                     ByVal AnnoInizio As Integer, ByVal PeriodoFine As Integer, _
                                     ByVal AnnoFine As Integer, Optional ByVal Tredicesima As Boolean = False, _
                                     Optional ByVal Quattordicesima As Boolean = False)

         If Not IsNumeric(IdSoggettoEsecutore) Then Throw New Exception("L'id del soggetto esecutore  non ha un formato corretto. Inserire un id corretto.")
         If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un id corretto.")


         If Not IsNumeric(IdSettoreDocumento) Then Throw New Exception("Il valore dell'id del settore immesso non ha un formato corretto. Inserire un id valido")
         Dim settore As Settore = ControllerSettori.GetSettoreById(IdSettoreDocumento)

         ''''COMPLETARE


         Dim soggetto As Azienda = GetSoggettoEsecutoreById(IdSoggettoEsecutore, settore)
         Dim competenza As AbstractPeriodo = CreateCompetenza(soggetto, PeriodoInizio, AnnoInizio, PeriodoFine, AnnoFine)
         'una volta impostata la competenza posso creare il pagamento
         m_current = New IncassoQuotaAssociativa(DataRegistrazione, DataDocumento, soggetto, competenza, Note, soggetto.Conto.Valuta, Importo, settore)


         CreateDefaultPosition()
         Me.m_PagamentoCreato = True

      End Sub
      Public Overloads Sub CreateNew(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                                     ByVal IdSoggettoEsecutore As String, ByVal Importo As String, _
                                     ByVal Note As String, ByVal IdSettoreDocumento As String, _
                                     ByVal DataInizio As DateTime, _
                                     ByVal DataFine As DateTime, _
                                     Optional ByVal Tredicesima As Boolean = False, _
                                     Optional ByVal Quattordicesima As Boolean = False, Optional ByVal CreateDefaultPositions As Boolean = False)

         If Not IsNumeric(IdSoggettoEsecutore) Then Throw New Exception("L'id del soggetto esecutore  non ha un formato corretto. Inserire un id corretto.")
         If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un importo corretto.")


         If Not IsNumeric(IdSettoreDocumento) Then Throw New Exception("Il valore dell'id del settore immesso non ha un formato corretto. Inserire un id valido")
         Dim settore As Settore = ControllerSettori.GetSettoreById(IdSettoreDocumento)

         Dim soggetto As Azienda = GetSoggettoEsecutoreById(IdSoggettoEsecutore, settore)
         If DataInizio = DateTime.MinValue Or DataInizio = DateTime.MaxValue Then Throw New Exception("Inserire una competenza corretta per l'incasso.")
         If DataFine = DateTime.MinValue Or DataFine = DateTime.MaxValue Then Throw New Exception("Inserire una competenza corretta per l'incasso.")
         Dim competenza As AbstractPeriodo = CreateCompetenza(soggetto, DataInizio, DataFine)
         'una volta impostata la competenza posso creare il pagamento
         m_current = New IncassoQuotaAssociativa(DataRegistrazione, DataDocumento, soggetto, competenza, Note, soggetto.Conto.Valuta, Importo, settore)

         If CreateDefaultPositions Then
            CreateDefaultPosition()
         End If
         Me.m_PagamentoCreato = True

      End Sub
      Protected Overrides Sub CommitTransaction()
         Try
            Ps.BeginTransaction()
            Ps.MarkNew(Current)
            Dim listaPosizioni As IList = Current.ItemList
            For Each elem As ItemIncassoQuotaAssociativa In listaPosizioni
               Ps.MarkNew(elem)
            Next
            'Aggiorno l'azienda
            Ps.MarkDirty(Current.GetItemWithSoggEsecutore.SoggettoEsecutore)
            'Aggiorno per adesso solo le deleghe degli utenti per cui è stata attivata la delega
            'e tutte le altre sono state annullate
            For Each elem As ItemIncassoQuotaAssociativa In listaPosizioni
               If elem.PosizioneUtente Then
                  If elem.Utente.HaAttivatoDelega Or elem.Utente.HaCambiatoSede Then
                            'posso aggiornare la delega attivata
                            Dim delega As IDelega = elem.Utente.GetActiveDelegaFor(elem.SoggettoEsecutore, elem.DataDocumento)
                            If delega.GetId > -1 Then
                                Ps.MarkDirty(delega) ', elem.Competenza.GetDataRange.Finish))
                            Else
                                Throw New Exception("Attivazione delega non riuscita per l'utente: " + elem.Utente.CompleteName + ". Delega da attivare nulla!")
                            End If

                  End If
               End If
            Next
            Ps.CommitTransaction()
            Ps.BeginTransaction()
         Catch ex As Exception
                Ps.RollBackTRansaction()
                Throw ex
         End Try
      End Sub
      Public Overrides Function GetCategoryObject() As String
         Return "IncassoQuotaAssociativa"
      End Function

      Public Sub MarkDirtyCurrentPosition()
         Ps.MarkDirty(m_currentItem)
      End Sub

      Protected Overrides Sub DoUpdate()

         Current.Post()
         'Ps.BeginTransaction()
         Ps.MarkDirty(Current)
         'Dim listaPosizioni As IList = Current.ItemList
         'For Each elem As ItemIncassoQuotaAssociativa In listaPosizioni
         '   Ps.MarkDirty(elem)
         'Next
         Ps.MarkDirty(Current.GetItemWithSoggEsecutore)
         Ps.MarkDirty(Current.GetItemWithSoggEsecutore.SoggettoEsecutore)
         Ps.CommitTransaction()
         Ps.BeginTransaction()


      End Sub
#End Region

      ''' <summary>
      ''' Metodo che elimina l'incasso previa verifica di posizioni ristornate. Se non ci sono posizioni ristornate
      ''' allora l'incasso può essere eliminato
      ''' </summary>
      ''' <remarks></remarks>
      Public Overrides Sub Delete()
         Try
            If Not Current.HaItemRistornate Then
               Ps.DeleteObject(GetCategoryObject, m_current)
            Else
               Throw New Exception("L'incasso quote ha delle posizioni ristornate da uno o più documenti di pagamento referente.")
            End If
         Catch ex As Exception
            Throw New Exception("Impossibile eliminare l'incasso." & vbCrLf & ex.Message)
         End Try
      End Sub

        Sub SetContrattoApplicatoItem(contratto As String)
            Try
                If contratto = "" Then Return
                'If Not IsNumeric(IdReferente) Then Throw New Exception("L'id del referente  non ha un formato corretto. Inserire un id corretto.")
                Dim id As Int32 = ControllerTipoContratto.GetIdTipoContrattoByDescrizione(contratto)
                If id = -1 Then
                    Return
                End If
                m_currentItem.ContrattoApplicato = ControllerTipoContratto.GetTipoContrattoById(id.ToString)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub



   End Class
End Namespace