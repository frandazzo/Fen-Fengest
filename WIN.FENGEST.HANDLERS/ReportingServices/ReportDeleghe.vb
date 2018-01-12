
Namespace REPORTING
   Public Class ReportDeleghe
      Inherits AbstractControllerRicerche
      Public Event ElaborationIncremented(ByVal Percentage As Int32, ByRef Cancel As Boolean)
      Protected m_SearchResult As New ArrayList


      'Variabili per l'abilitazione alla ricerca

      Protected m_DataRegistrazioneRangeSelected As Boolean = False
      Protected m_DataDocumentoRangeSelected As Boolean = False
      Protected m_DataInoltroRangeSelected As Boolean = False
      Protected m_DataAccettazioneRangeSelected As Boolean = False
      Protected m_DataAttivazioneRangeSelected As Boolean = False
      Protected m_DataAnnullamentoRangeSelected As Boolean = False
      Protected m_DataRevocaRangeSelected As Boolean = False


      Protected m_DelegheSottoscritteSelected As Boolean = False
      Protected m_DelegheInoltrateSelected As Boolean = False
      Protected m_DelegheAccettateSelected As Boolean = False
      Protected m_DelegheAttivateSelected As Boolean = False
      Protected m_DelegheAnnullateSelected As Boolean = False
      Protected m_DelegheRevocateSelected As Boolean = False


      Protected m_DataRegistrazioneRange As DataRange = DataRange.Empty
      Protected m_DataDocumentoRange As DataRange = DataRange.Empty
      Protected m_DataInoltroRange As DataRange = DataRange.Empty
      Protected m_DataAccettazioneRange As DataRange = DataRange.Empty
      Protected m_DataAttivazioneRange As DataRange = DataRange.Empty
      Protected m_DataAnnullamentoRange As DataRange = DataRange.Empty
      Protected m_DataRevocaRange As DataRange = DataRange.Empty



      Protected m_ListaAziendeSelected As Boolean = False
      Protected m_ListaAziende As New ArrayList
      Private m_listaNomiAziende As New ArrayList


      Protected m_IdReferente As Int32 = -1
      Protected m_NomeReferente As String = ""

      Protected m_IdCausale As Int32 = -1
      Protected m_NomeCausale As String = ""

      Protected m_IdResponsabile As Int32 = -1
      Protected m_NomeResponsabile As String = ""

      Protected m_IdSettore As Int32 = -1
      Protected m_NomeSettore As String = ""
      Private m_IsSettoreEdile As Boolean = False


      Protected m_IdReparto As Int32 = -1
      Protected m_NomeReparto As String = ""

      Protected m_IdContratto As Int32 = -1
      Protected m_NomeContratto As String = ""

      Protected m_IdEnte As Int32 = -1
      Protected m_NomeEnte As String = ""


      Private m_NumeroRecord As Int32 = 0




#Region "Proprietà risultati report"

      Public ReadOnly Property NumeroPosizioni() As String
         Get
            Return m_NumeroRecord
         End Get
      End Property

      ''' <summary>
      ''' Risultati della ricerca
      ''' </summary>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public ReadOnly Property SearchResult() As IList
         Get
            Return m_SearchResult
         End Get
      End Property
#End Region

      Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

         If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
         m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "DelegheDTO"))

      End Sub

#Region "Metodi per impostare i criteri di ricerca"


      Public Sub SetSettore(ByVal Descrizione As String)
         If Descrizione = "" Then
            m_IdSettore = -1
            m_NomeSettore = ""
            Exit Sub
         End If
         Dim cont As New ControllerSettori
         m_IdSettore = cont.GetIdSettoreByDescrizione(Descrizione)
         m_NomeSettore = Descrizione
         Me.m_IsSettoreEdile = cont.IsSettoreEdile
      End Sub
      Public Sub SetContratto(ByVal Descrizione As String)
         If Descrizione = "" Then
            m_IdContratto = -1
            m_NomeContratto = ""
            Exit Sub
         End If
         Dim cont As New ControllerTipoContratto
         m_NomeContratto = Descrizione
         m_IdContratto = cont.GetIdTipoContrattoByDescrizione(Descrizione)
      End Sub
      Public Sub SetReparto(ByVal Descrizione As String)
         If Descrizione = "" Then
            m_IdReparto = -1
            m_NomeReparto = Descrizione
            Exit Sub
         End If
         Dim cont As New ControllerReparti
         m_NomeReparto = Descrizione
         m_IdReparto = cont.GetIdByDescrizione(Descrizione)
      End Sub

      Public Sub SetCausaleSottoscrizione(ByVal Descrizione As String)
         If Descrizione = "" Then
            m_IdCausale = -1
            m_NomeCausale = Descrizione
            Exit Sub
         End If
         Dim cont As New ControllerCausaliSottoscrizione
         m_NomeCausale = Descrizione
         m_IdCausale = cont.GetIdByDescrizione(Descrizione)
      End Sub





      Public Sub SetEnte(ByVal Descrizione As String)
         If Descrizione = "" Then
            m_IdEnte = -1
            m_NomeEnte = ""
            Exit Sub
         End If
         Dim cont As New AZIENDE.ControllerEntiBilaterali
         m_NomeEnte = Descrizione
         m_IdEnte = cont.GetIdEnteByDescrizione(Descrizione)
      End Sub

      Public Sub SetListaAziende(ByVal Lista As ArrayList)
         m_ListaAziende = Lista
         Me.m_listaNomiAziende = New ArrayList
         Dim cont As New WIN.APPLICATION.AZIENDE.ControllerAziende
         For Each elem As Int32 In m_ListaAziende
            Try
               cont.LoadById(elem)
               m_listaNomiAziende.Add(cont.Descrizione)
            Catch ex As Exception
               '
            End Try
         Next
         cont = Nothing
      End Sub


      Public Sub SetDataRegistrazioneRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataRegistrazioneRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataDocumentoRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataDocumentoRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataInoltroRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataInoltroRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataAccettazioneRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataAccettazioneRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataAttivazioneRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataAttivazioneRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataAnnullamentoRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataAnnullamentoRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataRevocaRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataRevocaRange = New DataRange(Inizio, Fine)
      End Sub

      Public Sub SetDelegheSottoscritte(ByVal include As Boolean)
         m_DelegheSottoscritteSelected = include
      End Sub
      Public Sub SetDelegheInoltrate(ByVal include As Boolean)
         m_DelegheInoltrateSelected = include
      End Sub
      Public Sub SetDelegheAccettate(ByVal include As Boolean)
         m_DelegheAccettateSelected = include
      End Sub
      Public Sub SetDelegheAttivate(ByVal include As Boolean)
         m_DelegheAttivateSelected = include
      End Sub
      Public Sub SetDelegheAnnullate(ByVal include As Boolean)
         m_DelegheAnnullateSelected = include
      End Sub
      Public Sub SetDelegheRevocate(ByVal include As Boolean)
         m_DelegheRevocateSelected = include
      End Sub


      Public Sub SetReferenteId(ByVal Id As String)
         If Not IsNumeric(Id) Then Id = -1
         m_IdReferente = Id
         If Id = -1 Then
            m_NomeReferente = ""
            Exit Sub
         End If
         Dim cont As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
         cont.LoadById(Id)
         m_NomeReferente = cont.CompleteName
         cont = Nothing
      End Sub
      Public Sub SetResponsabileId(ByVal Id As String)
         If Not IsNumeric(Id) Then Id = -1
         m_IdResponsabile = Id
         If Id = -1 Then
            m_NomeResponsabile = ""
            Exit Sub
         End If
         Dim cont As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
         cont.LoadById(Id)
         m_NomeResponsabile = cont.CompleteName
         cont = Nothing
      End Sub

#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"

      Public ReadOnly Property NomeSettore() As String
         Get
            Return m_NomeSettore
         End Get
      End Property
      Public ReadOnly Property NomeContratto() As String
         Get
            Return m_NomeContratto
         End Get
      End Property
      Public ReadOnly Property NomeReparto() As String
         Get
            Return m_NomeReparto
         End Get
      End Property
      Public ReadOnly Property NomeEnte() As String
         Get
            Return m_NomeEnte
         End Get
      End Property

      Public ReadOnly Property DataRegistrazioneRange() As String
         Get
            If Me.m_DataRegistrazioneRangeSelected Then
               Return Me.m_DataRegistrazioneRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property
      Public ReadOnly Property DataDocumentoRange() As String
         Get
            If Me.m_DataDocumentoRangeSelected Then
               Return Me.m_DataDocumentoRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property

      Public ReadOnly Property NomeCausaleSottoscrizione() As String
         Get
            Return m_NomeCausale
         End Get
      End Property

      Public ReadOnly Property DataInoltroRange() As String
         Get
            If Me.m_DataInoltroRangeSelected Then
               Return Me.m_DataInoltroRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property
      Public ReadOnly Property DataAccettazioneRange() As String
         Get
            If Me.m_DataAccettazioneRangeSelected Then
               Return Me.m_DataAccettazioneRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property
      Public ReadOnly Property DataAttivazioneRange() As String
         Get
            If Me.m_DataAttivazioneRangeSelected Then
               Return Me.m_DataAttivazioneRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property
      Public ReadOnly Property DataAnnullamentoRange() As String
         Get
            If Me.m_DataAnnullamentoRangeSelected Then
               Return Me.m_DataAnnullamentoRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property
      Public ReadOnly Property DataRevocaRange() As String
         Get
            If Me.m_DataRevocaRangeSelected Then
               Return Me.m_DataRevocaRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property
      Public ReadOnly Property DelegheSottoscritte() As Boolean
         Get
            Return m_DelegheSottoscritteSelected
         End Get
      End Property


      Public ReadOnly Property DelegheInoltrate() As Boolean
         Get
            Return m_DelegheInoltrateSelected
         End Get
      End Property
      Public ReadOnly Property DelegheAccettate() As Boolean
         Get
            Return m_DelegheAccettateSelected
         End Get
      End Property
      Public ReadOnly Property DelegheAttivate() As Boolean
         Get
            Return m_DelegheAttivateSelected
         End Get
      End Property
      Public ReadOnly Property DelegheAnnullate() As Boolean
         Get
            Return m_DelegheAnnullateSelected
         End Get
      End Property
      Public ReadOnly Property DelegheRevocate() As Boolean
         Get
            Return m_DelegheRevocateSelected
         End Get
      End Property

      Public ReadOnly Property NomeReferente() As String
         Get
            Return m_NomeReferente
         End Get
      End Property
      Public ReadOnly Property NomeResponsabile() As String
         Get
            Return m_NomeResponsabile
         End Get
      End Property
      Public ReadOnly Property ListaNomiAziende() As ArrayList
         Get
            Return m_listaNomiAziende
         End Get
      End Property
      Public ReadOnly Property IsSettoreEdile() As Boolean
         Get
            Return m_IsSettoreEdile
         End Get
      End Property
#End Region






#Region "Metodi per l'elaborazione del report"

      ''' <summary>
      ''' Metodo che imposta i criteri di ricerca per le posizioni di incasso
      ''' </summary>
      ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
      ''' ----"IntervalloRegistrazione" (Per includere la ricerca alle deleghe  con data  compresa in un intervallo specificato)
      ''' ----"IntervalloDocumento" (Per includere la ricerca aille deleghe con data  compresa in un intervallo specificato)
      ''' ----"IntervalloInoltro" (Per includere la ricerca aille deleghe con data  compresa in un intervallo specificato)
      ''' ----"IntervalloAccettazione" (Per includere la ricerca aille deleghe con data  compresa in un intervallo specificato)
      ''' ----"IntervalloAttivazione" (Per includere la ricerca aille deleghe con data  compresa in un intervallo specificato)
      ''' ----"IntervalloAnnullamento" (Per includere la ricerca aille deleghe con data  compresa in un intervallo specificato)
      ''' ----"IntervalloRevoca" (Per includere la ricerca aille deleghe con data  compresa in un intervallo specificato)
      ''' ----"ListaAziende" (Per includere la ricerca alle deleghe per i soggetti esecutori con gli id indicati)</param>
      ''' <remarks></remarks>
      Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)

         m_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
         m_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
         m_DataInoltroRangeSelected = IIf(ParameterMap("IntervalloInoltro") Is Nothing, False, ParameterMap("IntervalloInoltro"))
         m_DataAccettazioneRangeSelected = IIf(ParameterMap("IntervalloAccettazione") Is Nothing, False, ParameterMap("IntervalloAccettazione"))
         m_DataAttivazioneRangeSelected = IIf(ParameterMap("IntervalloAttivazione") Is Nothing, False, ParameterMap("IntervalloAttivazione"))
         m_DataAnnullamentoRangeSelected = IIf(ParameterMap("IntervalloAnnullamento") Is Nothing, False, ParameterMap("IntervalloAnnullamento"))
         m_DataRevocaRangeSelected = IIf(ParameterMap("IntervalloRevoca") Is Nothing, False, ParameterMap("IntervalloRevoca"))


         'm_DelegheSottoscritteSelected = IIf(ParameterMap("IncludiDelegheSottoscritte") Is Nothing, False, ParameterMap("IncludiDelegheSottoscritte"))
         'm_DelegheInoltrateSelected = IIf(ParameterMap("IncludiDelegheInoltrate") Is Nothing, False, ParameterMap("IncludiDelegheInoltrate"))
         'm_DelegheAccettateSelected = IIf(ParameterMap("IncludiDelegheAccettate") Is Nothing, False, ParameterMap("IncludiDelegheAccettate"))
         'm_DelegheAttivateSelected = IIf(ParameterMap("IncludiDelegheAttivate") Is Nothing, False, ParameterMap("IncludiDelegheAttivate"))
         'm_DelegheAnnullateSelected = IIf(ParameterMap("IncludiDelegheAnnullate") Is Nothing, False, ParameterMap("IncludiDelegheAnnullate"))
         'm_DelegheRevocateSelected = IIf(ParameterMap("IncludiDelegheRevocate") Is Nothing, False, ParameterMap("IncludiDelegheRevocate"))
         
         m_ListaAziendeSelected = IIf(ParameterMap("ListaAziende") Is Nothing, False, ParameterMap("ListaAziende"))


         '   ''' 
         '  ''' ----"IncludiDelegheSottoscritte" (Per includere la ricerca aille deleghe sottoscritte)
         '  ''' ----"IncludiDelegheInoltrate" (Per includere la ricerca aille deleghe inoltrate)
         '  ''' ----"IncludiDelegheAccettate" (Per includere la ricerca aille deleghe accettate)
         '  ''' ----"IncludiDelegheAttivate" (Per includere la ricerca aille deleghe attivate)
         '  ''' ----"IncludiDelegheAnnullate" (Per includere la ricerca aille deleghe annullate)
         '  ''' ----"IncludiDelegheREvocate" (Per includere la ricerca aille deleghe revocate)
         '   '''

      End Sub







      'Public Overrides Function Search() As IList
      '   'qui creo ed eseguo la query
      '   Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      '   Dim query As Query = ps.CreateNewQuery("MapperDelega")
      '   Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
      '   Dim subDataRangeCriteriaAdded As Boolean = False
      '   Dim subStateDelegaCriteriaAdded As Boolean = False





      '   If m_IdSettore = -1 Then Throw New InvalidOperationException("Selezionare un settore")

      '   Dim subDataRangeCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
      '   Dim subStateDelegaCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)

      '   If m_DelegheAccettateSelected Then
      '      subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Accettata", ps.DBType))
      '      subStateDelegaCriteriaAdded = True
      '   End If

      '   If m_DelegheAttivateSelected Then
      '      subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Attivata", ps.DBType))
      '      subStateDelegaCriteriaAdded = True
      '   End If

      '   If m_DelegheAnnullateSelected Then
      '      subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Annullata", ps.DBType))
      '      subStateDelegaCriteriaAdded = True
      '   End If

      '   If m_DelegheSottoscritteSelected Then
      '      subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Sottoscritta", ps.DBType))
      '      subStateDelegaCriteriaAdded = True
      '   End If

      '   If m_DelegheInoltrateSelected Then
      '      subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Inoltrata", ps.DBType))
      '      subStateDelegaCriteriaAdded = True
      '   End If

      '   If m_DelegheRevocateSelected Then
      '      subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Revocata", ps.DBType))
      '      subStateDelegaCriteriaAdded = True
      '   End If


      '   If subStateDelegaCriteriaAdded Then
      '      mainCriteria.AddCriteria(subStateDelegaCriteria)
      '   End If




      '   mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", m_IdSettore))


      '   If m_IdReferente <> -1 Then
      '      mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
      '   End If


      '   If m_IdResponsabile <> -1 Then
      '      mainCriteria.AddCriteria(Criteria.Equal("ID_RESPONSABILE", m_IdResponsabile))
      '   End If



      '   If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
      '      mainCriteria.AddCriteria(New DateContainedCriteria("DATA_SOTTOSCRIZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
      '   End If

      '   If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
      '      mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
      '   End If







      '   If m_DataInoltroRangeSelected And Not m_DataInoltroRange.IsEmpty Then
      '      subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_INOLTRO", m_DataInoltroRange.Start, m_DataInoltroRange.Finish, ps.DBType))
      '      subDataRangeCriteriaAdded = True
      '   End If

      '   If m_DataAccettazioneRangeSelected And Not m_DataAccettazioneRange.IsEmpty Then
      '      subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_ACCETTAZIONE", m_DataAccettazioneRange.Start, m_DataAccettazioneRange.Finish, ps.DBType))
      '      subDataRangeCriteriaAdded = True
      '   End If

      '   If m_DataAttivazioneRangeSelected And Not m_DataAttivazioneRange.IsEmpty Then
      '      subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_ATTIVAZIONE", m_DataAttivazioneRange.Start, m_DataAttivazioneRange.Finish, ps.DBType))
      '      subDataRangeCriteriaAdded = True
      '   End If


      '   If m_DataAnnullamentoRangeSelected And Not m_DataAnnullamentoRange.IsEmpty Then
      '      subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_ANNULLAMENTO", m_DataAnnullamentoRange.Start, m_DataAnnullamentoRange.Finish, ps.DBType))
      '      subDataRangeCriteriaAdded = True
      '   End If

      '   If m_DataRevocaRangeSelected And Not m_DataRevocaRange.IsEmpty Then
      '      subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_REVOCA", m_DataRevocaRange.Start, m_DataRevocaRange.Finish, ps.DBType))
      '      subDataRangeCriteriaAdded = True
      '   End If

      '   If subDataRangeCriteriaAdded = True Then
      '      'Aggiungo i criteri delle date
      '      mainCriteria.AddCriteria(subDataRangeCriteria)
      '   End If



      '   If Not m_IsSettoreEdile Then
      '      If m_ListaAziendeSelected Then
      '         Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
      '         If m_ListaAziende.Count > 0 Then
      '            For Each elem As String In m_ListaAziende
      '               CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_AZIENDA", elem))
      '            Next
      '            mainCriteria.AddCriteria(CompositeListaSoggetti)
      '         End If
      '      End If
      '   Else
      '      If m_IdEnte <> -1 Then
      '         mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdEnte))
      '      End If
      '   End If

      '   'End If





      '   'If m_IdContratto <> -1 Then
      '   '   mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto))
      '   'End If


      '   If m_IdCausale <> -1 Then
      '      mainCriteria.AddCriteria(Criteria.Equal("ID_CAUSALE_SOTT", m_IdCausale))
      '   End If

      '   If m_IdReparto <> -1 Then
      '      mainCriteria.AddCriteria(Criteria.Equal("ID_REPARTO", m_IdReparto))
      '   End If


      '   If Not m_IsSettoreEdile Then
      '      If m_IdContratto <> -1 Then
      '         Dim subCriteria As AbstractBoolCriteria = Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto)

      '         Dim subqry As New SubQueryCriteria("DB_AZIENDA", "ID")
      '         subqry.AddCriteria(subCriteria)

      '         mainCriteria.AddCriteria(Criteria.INClause("ID_AZIENDA", subqry))
      '      End If
      '   End If


      '   Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
      '   orderCriteria.AddCriteria(Criteria.SortCriteria("ID_UTENTE", True))



      '   query.AddWhereClause(mainCriteria)

      '   query.AddOrderByClause(orderCriteria)



      '   'Dim start As DateTime = Now
      '   'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
      '   Dim list As IList = query.Execute(ps)

      '   m_Results = list
      '   m_SearchResult = list
      '   m_IsSettoreEdile = False
      '   m_NumeroRecord = list.Count
      '   Return list
      'End Function
      Public Overrides Function Search() As IList
         'qui creo ed eseguo la query
         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperDelegaDTO")
         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
         Dim subDataRangeCriteriaAdded As Boolean = False
         Dim subStateDelegaCriteriaAdded As Boolean = False





         If m_IdSettore = -1 Then Throw New InvalidOperationException("Selezionare un settore")

         Dim subDataRangeCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
         Dim subStateDelegaCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)

         If m_DelegheAccettateSelected Then
            subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Accettata", ps.DBType))
            subStateDelegaCriteriaAdded = True
         End If

         If m_DelegheAttivateSelected Then
            subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Attivata", ps.DBType))
            subStateDelegaCriteriaAdded = True
         End If

         If m_DelegheAnnullateSelected Then
            subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Annullata", ps.DBType))
            subStateDelegaCriteriaAdded = True
         End If

         If m_DelegheSottoscritteSelected Then
            subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Sottoscritta", ps.DBType))
            subStateDelegaCriteriaAdded = True
         End If

         If m_DelegheInoltrateSelected Then
            subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Inoltrata", ps.DBType))
            subStateDelegaCriteriaAdded = True
         End If

         If m_DelegheRevocateSelected Then
            subStateDelegaCriteria.AddCriteria(Criteria.Matches("STATO_DELEGA", "Revocata", ps.DBType))
            subStateDelegaCriteriaAdded = True
         End If


         If subStateDelegaCriteriaAdded Then
            mainCriteria.AddCriteria(subStateDelegaCriteria)
         End If




         mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", m_IdSettore))


         If m_IdReferente <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
         End If


         If m_IdResponsabile <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_RESPONSABILE", m_IdResponsabile))
         End If



         If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
            mainCriteria.AddCriteria(New DateContainedCriteria("DATA_SOTTOSCRIZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
         End If

         If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
            mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
         End If







         If m_DataInoltroRangeSelected And Not m_DataInoltroRange.IsEmpty Then
            subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_INOLTRO", m_DataInoltroRange.Start, m_DataInoltroRange.Finish, ps.DBType))
            subDataRangeCriteriaAdded = True
         End If

         If m_DataAccettazioneRangeSelected And Not m_DataAccettazioneRange.IsEmpty Then
            subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_ACCETTAZIONE", m_DataAccettazioneRange.Start, m_DataAccettazioneRange.Finish, ps.DBType))
            subDataRangeCriteriaAdded = True
         End If

         If m_DataAttivazioneRangeSelected And Not m_DataAttivazioneRange.IsEmpty Then
            subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_ATTIVAZIONE", m_DataAttivazioneRange.Start, m_DataAttivazioneRange.Finish, ps.DBType))
            subDataRangeCriteriaAdded = True
         End If


         If m_DataAnnullamentoRangeSelected And Not m_DataAnnullamentoRange.IsEmpty Then
            subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_ANNULLAMENTO", m_DataAnnullamentoRange.Start, m_DataAnnullamentoRange.Finish, ps.DBType))
            subDataRangeCriteriaAdded = True
         End If

         If m_DataRevocaRangeSelected And Not m_DataRevocaRange.IsEmpty Then
            subDataRangeCriteria.AddCriteria(New DateContainedCriteria("DATA_REVOCA", m_DataRevocaRange.Start, m_DataRevocaRange.Finish, ps.DBType))
            subDataRangeCriteriaAdded = True
         End If

         If subDataRangeCriteriaAdded = True Then
            'Aggiungo i criteri delle date
            mainCriteria.AddCriteria(subDataRangeCriteria)
         End If



         If Not m_IsSettoreEdile Then
            If m_ListaAziendeSelected Then
               Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
               If m_ListaAziende.Count > 0 Then
                  For Each elem As String In m_ListaAziende
                     CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_AZIENDA", elem))
                  Next
                  mainCriteria.AddCriteria(CompositeListaSoggetti)
               End If
            End If
         Else
            If m_IdEnte <> -1 Then
               mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdEnte))
            End If
         End If

         'End If





         'If m_IdContratto <> -1 Then
         '   mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto))
         'End If


         If m_IdCausale <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_CAUSALE_SOTT", m_IdCausale))
         End If

         If m_IdReparto <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_REPARTO", m_IdReparto))
         End If


         If Not m_IsSettoreEdile Then
            If m_IdContratto <> -1 Then
               'Dim subCriteria As AbstractBoolCriteria = Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto)

               'Dim subqry As New SubQueryCriteria("DB_AZIENDA", "ID")
               'subqry.AddCriteria(subCriteria)

               'mainCriteria.AddCriteria(Criteria.INClause("ID_AZIENDA", subqry))
               mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto))
            End If
         End If


         Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
         orderCriteria.AddCriteria(Criteria.SortCriteria("ID_UTENTE", True))



         query.AddWhereClause(mainCriteria)

         query.AddOrderByClause(orderCriteria)



         'Dim start As DateTime = Now
         'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
         Dim list As IList = query.Execute(ps)

         m_Results = list
         m_SearchResult = list
         m_IsSettoreEdile = False
         m_NumeroRecord = list.Count
         Return list
      End Function

      Private Function CreateDTOList(ByVal lista As IList) As IList
         Dim list As New ArrayList
         For Each elem As Delega In lista
            list.Add(elem)
         Next
         Return list
      End Function
     
#End Region
   End Class



End Namespace
