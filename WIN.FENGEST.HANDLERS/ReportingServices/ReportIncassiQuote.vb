Namespace REPORTING
    Public Class ReportIncassiQuote
        Inherits AbstractControllerRicerche
        Public Event ElaborationIncremented(ByVal Percentage As Int32, ByRef Cancel As Boolean)
        'Variabili per l'abilitazione alla ricerca
        'Protected m_IncludiQuoteAssociative As Boolean
        Protected m_DataRegistrazioneRangeSelected As Boolean = False
        Protected m_DataDocumentoRangeSelected As Boolean = False
        Protected m_ListaUtentiSelected As Boolean = False
        Protected m_CompetenzaQuoteSelected As Boolean = False
        Private m_PeriodiMensili As AbstractPeriodo = New PeriodoNullo
        Private m_PeriodiGiornalieri As AbstractPeriodo = New PeriodoNullo

        Protected m_CompetenzaIncassiQuote As DataRange = DataRange.Empty
        Protected m_DataRegistrazioneRange As DataRange = DataRange.Empty
        Protected m_DataDocumentoRange As DataRange = DataRange.Empty
        Protected m_ListaUtenti As New ArrayList
        Protected m_IdReferente As Int32 = -1
        Protected m_IdSettore As Int32 = -1
        Protected m_NomeSettore As String = ""
        Protected m_IdReparto As Int32 = -1
        Protected m_NomeReparto As String = ""
        Protected m_IdContratto As Int32 = -1
        Protected m_NomeContratto As String = ""
        Protected m_IdEnte As Int32 = -1
        Protected m_NomeEnte As String = ""
        Protected m_IdAzienda As Int32 = -1

        Protected m_IdAzienda_Impiego As Int32 = -1
        Protected m_IdDocumento As Int32 = -1
        Protected m_IdDocumentoRistorno As Int32 = -1
        Protected m_NomeAzienda As String = ""
        Protected m_NomeReferente As String = ""
        Protected m_TipoDocIQA As Boolean = False
        Protected m_TipoDocIQI As Boolean = False
        Protected m_TipoDocIQV As Boolean = False
        Protected m_TipoDocIQP As Boolean = False
        Protected m_TipoDocPGR As Boolean = False
        Protected m_TipoInclusione As TipoInclusioneItemRistornate = TipoInclusioneItemRistornate.Tutto
        Protected m_SearchResult As New ArrayList
        Private m_IsSettoreEdile As Boolean = False
        Private m_listaNomiUtenti As New ArrayList



        Private m_NumeroPosizioniIQA As Int32 = 0
        Private m_NumeroPosizioniIQI As Int32 = 0
        Private m_NumeroPosizioniIQV As Int32 = 0
        Private m_NumeroPosizioniIQP As Int32 = 0


        Private m_ImportoIQA As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Private m_ImportoIQI As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Private m_ImportoIQV As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Private m_ImportoIQP As Moneta = New Moneta(0, Moneta.Valuta.Euro)



        Private m_ImportoRistornoIQA As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Private m_ImportoRistornoIQI As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Private m_ImportoRistornoIQV As Moneta = New Moneta(0, Moneta.Valuta.Euro)

        Private m_NumOreLavorate As Double = 0
        Private m_NumOreMalattia As Double = 0

        Protected m_IncassoPonderato As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Protected m_IncassoRistornoPonderato As Moneta = New Moneta(0, Moneta.Valuta.Euro)
        Protected m_OreMalattiaPonderate As Double = 0
        Protected m_OreLavoratePonderate As Double = 0


        'Public Sub SetIdDocumento(ByVal idDocumento As String)

        'End Sub


#Region "Proprietà risultati report"
        Public ReadOnly Property IncassoPonderato() As String
            Get
                Return Me.m_IncassoPonderato.Negate.Importo.ToString
            End Get
        End Property
        Public ReadOnly Property IncassoRistornoPonderato() As String
            Get
                Return Me.m_IncassoRistornoPonderato.Importo.ToString
            End Get
        End Property
        Public ReadOnly Property OreMalattiaPonderate() As String
            Get
                Return Me.m_OreMalattiaPonderate.ToString
            End Get
        End Property
        Public ReadOnly Property OreLavoratePonderate() As String
            Get
                Return Me.m_OreLavoratePonderate.ToString
            End Get
        End Property
        Public ReadOnly Property ImportoRistornoIQV() As String
            Get
                Return m_ImportoRistornoIQV.Importo
            End Get
        End Property
        Public ReadOnly Property ImportoRistornoIQI() As String
            Get
                Return m_ImportoRistornoIQI.Importo
            End Get
        End Property
        Public ReadOnly Property ImportoRistornoIQA() As String
            Get
                Return m_ImportoRistornoIQA.Importo
            End Get
        End Property



        Public ReadOnly Property ImportoIQP() As String
            Get
                Return m_ImportoIQP.Importo
            End Get
        End Property

        Public ReadOnly Property ImportoIQV() As String
            Get
                Return m_ImportoIQV.Importo
            End Get
        End Property
        Public ReadOnly Property ImportoIQI() As String
            Get
                Return m_ImportoIQI.Importo
            End Get
        End Property
        Public ReadOnly Property ImportoIQA() As String
            Get
                Return m_ImportoIQA.Importo
            End Get
        End Property

        Public ReadOnly Property ImportoRistornoTotale() As String
            Get
                Return m_ImportoRistornoIQA.Add(m_ImportoRistornoIQI.Add(m_ImportoRistornoIQV)).Importo
            End Get
        End Property
        Public ReadOnly Property ImportoTotale() As String
            Get
                Return m_ImportoIQA.Add(m_ImportoIQI.Add(m_ImportoIQV.Add(m_ImportoIQP))).Importo
            End Get
        End Property

        Public ReadOnly Property NumOreMalattia() As String
            Get
                Return m_NumOreMalattia
            End Get
        End Property
        Public ReadOnly Property NumOreLavorate() As String
            Get
                Return m_NumOreLavorate
            End Get
        End Property
        Public ReadOnly Property NumeroPosizioni() As String
            Get
                Dim numero As Int32 = m_NumeroPosizioniIQA + m_NumeroPosizioniIQI + m_NumeroPosizioniIQV + m_NumeroPosizioniIQP
                Return numero
            End Get
        End Property
        Public ReadOnly Property NumeroPosizioniIQV() As String
            Get
                Return m_NumeroPosizioniIQV
            End Get
        End Property
        Public ReadOnly Property NumeroPosizioniIQI() As String
            Get
                Return m_NumeroPosizioniIQI
            End Get
        End Property
        Public ReadOnly Property NumeroPosizioniIQP() As String
            Get
                Return m_NumeroPosizioniIQP
            End Get
        End Property


        Public ReadOnly Property NumeroPosizioniIQA() As String
            Get
                Return m_NumeroPosizioniIQA
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
            m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "QuotaDTOComparer"))

        End Sub

#Region "Metodi per impostare i criteri di ricerca"

        Public Sub SetInclusioneItemRistornate(ByVal TipoInclusione As TipoInclusioneItemRistornate)
            m_TipoInclusione = TipoInclusione
        End Sub
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

        Public Sub SetDocumento(ByVal Id As String)
            Try
                If Not IsNumeric(Id) Then Id = -1
                m_IdDocumento = Id
            Catch ex As Exception
                m_IdDocumento = -1
            End Try

        End Sub

        Public Sub SetDocumentoRistorno(ByVal Id As String)
            Try
                If Not IsNumeric(Id) Then Id = -1
                m_IdDocumentoRistorno = Id
            Catch ex As Exception
                m_IdDocumentoRistorno = -1
            End Try

        End Sub

        Public Sub SetAzienda(ByVal Id As String)
            Try
                If Not IsNumeric(Id) Then Id = -1
                m_IdAzienda = Id
                If Id = -1 Then
                    m_NomeAzienda = ""
                    Exit Sub
                End If
                Dim cont As New WIN.APPLICATION.AZIENDE.ControllerAziende
                cont.LoadById(Id)
                m_NomeAzienda = cont.Descrizione
                cont = Nothing
            Catch ex As Exception
                m_NomeAzienda = ""
            End Try

        End Sub

        Public Sub SetAziendaImpiego(ByVal Id As String)

            If Not IsNumeric(Id) Then Id = -1
            m_IdAzienda_Impiego = Id

        End Sub



        Public Sub SetListaUtenti(ByVal Lista As ArrayList)
            m_ListaUtenti = Lista
            Me.m_listaNomiUtenti = New ArrayList
            Dim cont As New WIN.APPLICATION.UTENTI.ControllerUtenti
            For Each elem As Int32 In m_ListaUtenti
                Try
                    cont.LoadById(elem)
                    m_listaNomiUtenti.Add(cont.CompleteName)
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

        Public Sub SetCompetenzaIncassiQuote(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            Dim range As DataRange = New DataRange(Inizio, Fine)
            m_CompetenzaIncassiQuote = range
            Me.m_PeriodiMensili = New CompositePeriodo(range, IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
            Me.m_PeriodiGiornalieri = New CompositePeriodo(range, IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera)
        End Sub

        Public Sub IsIQPIncluded(ByVal Included As Boolean)
            m_TipoDocIQP = Included
        End Sub
        Public Sub IsIQAIncluded(ByVal Included As Boolean)
            m_TipoDocIQA = Included
        End Sub
        Public Sub IsIQIIncluded(ByVal Included As Boolean)
            m_TipoDocIQI = Included
        End Sub
        Public Sub IsIQVIncluded(ByVal Included As Boolean)
            m_TipoDocIQV = Included
        End Sub

        Public Sub IsPGRIncluded(ByVal Included As Boolean)
            m_TipoDocPGR = Included
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

#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"
        Public ReadOnly Property TipoRistorno() As String
            Get
                Select Case Me.m_TipoInclusione
                    Case TipoInclusioneItemRistornate.NonRistornate
                        Return "Non ristornate"
                    Case TipoInclusioneItemRistornate.Ristornate
                        Return "Ristornate"
                    Case TipoInclusioneItemRistornate.Tutto
                        Return "Tutto"
                    Case Else
                        Throw New InvalidOperationException
                End Select
            End Get
        End Property
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
        Public ReadOnly Property NomeAzienda() As String
            Get
                Return m_NomeAzienda
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
        Public ReadOnly Property CompetenzaRange() As String
            Get
                If Me.m_CompetenzaQuoteSelected Then
                    Return Me.m_CompetenzaIncassiQuote.ToString
                Else
                    Return ""
                End If
            End Get
        End Property
        Public ReadOnly Property NomeReferente() As String
            Get
                Return m_NomeReferente
            End Get
        End Property
        Public ReadOnly Property TipiDocInclusi() As String
            Get
                Dim tipi As String = ""
                If Me.m_TipoDocIQA Then
                    tipi = "IQA; "
                End If
                If Me.m_TipoDocIQI Then
                    tipi = tipi & " IQI; "
                End If
                If Me.m_TipoDocIQV Then
                    tipi = tipi & " IQV; "
                End If
                If Me.m_TipoDocIQP Then
                    tipi = tipi & " IQP;"
                End If
                If Me.m_TipoDocPGR Then
                    tipi = tipi & " PGR;"
                End If
                Return tipi
            End Get
        End Property
        Public ReadOnly Property ListaNomiUtenti() As ArrayList
            Get
                Return m_listaNomiUtenti
            End Get
        End Property
        Public ReadOnly Property IsSettoreEdile() As Boolean
            Get
                Return m_IsSettoreEdile
            End Get
        End Property
#End Region






#Region "Metodi per l'elaborazione dekl report"

        ''' <summary>
        ''' Metodo che imposta i criteri di ricerca per le posizioni di incasso
        ''' </summary>
        ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
        ''' ----"IntervalloRegistrazione" (Per includere la ricerca ai documenti del tipo selezionato con data registrazione compresa in un intervallo specificato)
        ''' ----"IntervalloDocumento" (Per includere la ricerca ai documenti del tipo selezionato con data documento compresa in un intervallo specificato)
        ''' ----"ListaUtenti" (Per includere la ricerca ai documenti del tipo selezionato per i soggettiesecutori con gli id indicati)
        ''' ----"CompetenzeQuote" (Per includere la ricerca ai documenti del tipo selezionato con le competenze sovrapposte a quella indicata)</param>
        ''' <remarks></remarks>
        Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
            'm_IncludiQuoteAssociative = IIf(ParameterMap("QuoteAssociative") Is Nothing, False, ParameterMap("QuoteAssociative"))
            m_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
            m_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
            m_ListaUtentiSelected = IIf(ParameterMap("ListaSoggetti") Is Nothing, False, ParameterMap("ListaSoggetti"))
            m_CompetenzaQuoteSelected = IIf(ParameterMap("CompetenzaQuote") Is Nothing, False, ParameterMap("CompetenzaQuote"))
        End Sub
        'Public Overrides Function Search() As IList
        '   'qui creo ed eseguo la query
        '   Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        '   Dim query As Query = ps.CreateNewQuery("MapperItemDocumentoContabile")
        '   Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
        '   mainCriteria.AddCriteria(Criteria.Equal("ID_CONTO", 2))

        '   'aggiungo le clausole per il tipo documento
        '   Dim subCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)

        '   If m_TipoDocIQA Then
        '      subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQA'"))
        '   End If
        '   If m_TipoDocIQI Then
        '      subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQI'"))
        '   End If
        '   If m_TipoDocIQV Then
        '      subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQV'"))
        '   End If

        '   If m_TipoDocIQA = False And m_TipoDocIQI = False And m_TipoDocIQV = False Then
        '      Throw New InvalidOperationException("Selezionare almeno un tipo di documento")
        '   End If
        '   mainCriteria.AddCriteria(subCriteria)


        '   'aggiungo le clausole per il ristorno

        '   Select Case m_TipoInclusione
        '      Case TipoInclusioneItemRistornate.NonRistornate
        '         mainCriteria.AddCriteria(Criteria.IsNull("ID_PAGAMENTO_REFERENTE"))
        '      Case TipoInclusioneItemRistornate.Ristornate
        '         mainCriteria.AddCriteria(Criteria.NotIsNull("ID_PAGAMENTO_REFERENTE"))
        '   End Select
        '   If m_IdReferente <> -1 Then
        '      mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
        '   End If



        '   'aggiungo le clausole per ildocumento

        '   'Dim CompositeCriteria As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
        '   If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
        '      'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Finish, "MM/dd/yyyy") & "#")))
        '      'mainCriteria.AddCriteria(CompositeCriteria)
        '      mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
        '   End If

        '   If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
        '      'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Finish, "MM/dd/yyyy") & "#")))
        '      'mainCriteria.AddCriteria(CompositeCriteria)
        '      mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
        '   End If

        '   If m_ListaUtentiSelected Then
        '      Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
        '      If m_ListaUtenti.Count > 0 Then
        '         For Each elem As String In m_ListaUtenti
        '            CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
        '         Next
        '         mainCriteria.AddCriteria(CompositeListaSoggetti)
        '      End If
        '   End If
        '   'End If

        '   If m_CompetenzaQuoteSelected And Not m_CompetenzaIncassiQuote.IsEmpty Then
        '      mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", m_CompetenzaIncassiQuote.Start, m_CompetenzaIncassiQuote.Finish, ps.DBType))
        '   End If

        '   If m_IdSettore <> -1 Then
        '      mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", m_IdSettore))
        '   End If

        '   If m_IdContratto <> -1 Then
        '      mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto))
        '   End If

        '   If m_IdSettore = -1 Then
        '      If m_IdAzienda <> -1 Then
        '         mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", 1))
        '         mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
        '      End If
        '   Else
        '      If Not m_IsSettoreEdile Then
        '         If m_IdAzienda <> -1 Then
        '            mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
        '         End If
        '      Else
        '         If m_IdEnte <> -1 Then
        '            mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdEnte))
        '         End If
        '      End If
        '   End If


        '   query.AddWhereClause(mainCriteria)


        '   'Dim start As DateTime = Now
        '   'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
        '   Dim list As IList = query.Execute(ps)

        '   'System.Diagnostics.Debug.WriteLine("Fine query a " & Now & " della durata di " & Now.Subtract(start).TotalMilliseconds)



        '   'start = Now
        '   'System.Diagnostics.Debug.WriteLine("Inizio creazione DTO a " & start.ToString)
        '   Dim list1 As IList = GetDtoListFromItems(list)
        '   'System.Diagnostics.Debug.WriteLine("Fine creazione DTO a " & Now & " della durata di " & Now.Subtract(start).TotalMilliseconds)
        '   m_Results = list1
        '   m_SearchResult = list1
        '   Return list1
        'End Function



        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperQuota")
            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            'aggiungo le clausole per il tipo documento
            Dim subCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
            Dim sub1 As Boolean
            If m_TipoDocIQP Then
                subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQP'"))
                sub1 = True
            End If

            If m_TipoDocIQA Then
                subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQA'"))
                sub1 = True
            End If
            If m_TipoDocIQI Then
                subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQI'"))
                sub1 = True
            End If
            If m_TipoDocIQV Then
                subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQV'"))
                sub1 = True
            End If

            If m_TipoDocPGR Then
                subCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'PGR'"))
                sub1 = True
            End If

            If m_IdDocumentoRistorno = -1 Then
                If m_TipoDocIQA = False And m_TipoDocIQI = False And m_TipoDocIQV = False And m_TipoDocIQP = False And m_TipoDocPGR = False Then
                    Throw New InvalidOperationException("Selezionare almeno un tipo di documento")
                End If
            End If
            If sub1 = True Then
                mainCriteria.AddCriteria(subCriteria)
            End If



            'aggiungo le clausole per il ristorno

            Select Case m_TipoInclusione
                Case TipoInclusioneItemRistornate.NonRistornate
                    mainCriteria.AddCriteria(Criteria.IsNull("ID_PAGAMENTO_REFERENTE"))
                Case TipoInclusioneItemRistornate.Ristornate
                    mainCriteria.AddCriteria(Criteria.NotIsNull("ID_PAGAMENTO_REFERENTE"))
            End Select
            If m_IdReferente <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
            End If



            'aggiungo le clausole per ildocumento

            'Dim CompositeCriteria As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
                'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Finish, "MM/dd/yyyy") & "#")))
                'mainCriteria.AddCriteria(CompositeCriteria)
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
            End If

            If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
                'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Finish, "MM/dd/yyyy") & "#")))
                'mainCriteria.AddCriteria(CompositeCriteria)
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
            End If

            If m_ListaUtentiSelected Then
                Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                If m_ListaUtenti.Count > 0 Then
                    For Each elem As String In m_ListaUtenti
                        CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
                    Next
                    mainCriteria.AddCriteria(CompositeListaSoggetti)
                End If
            End If
            'End If

            If m_CompetenzaQuoteSelected And Not m_CompetenzaIncassiQuote.IsEmpty Then
                mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", m_CompetenzaIncassiQuote.Start, m_CompetenzaIncassiQuote.Finish, ps.DBType))
            End If

            If m_IdSettore <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", m_IdSettore))
            End If

            If m_IdDocumento <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_DOCUMENTO_CONTABILE", m_IdDocumento))
            End If


            If m_IdAzienda_Impiego <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA_IMPIEGO", m_IdAzienda_Impiego))
            End If

            If m_IdDocumentoRistorno <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_PAGAMENTO_REFERENTE", m_IdDocumentoRistorno))
            End If

            If m_IdContratto <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto))
            End If

            If m_IdSettore = -1 Then
                If m_IdAzienda <> -1 Then
                    mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", 1))
                    mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
                End If
            Else
                If Not m_IsSettoreEdile Then
                    If m_IdAzienda <> -1 Then
                        mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
                    End If
                Else
                    If m_IdEnte <> -1 Then
                        mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdEnte))
                    End If
                End If
            End If


            query.AddWhereClause(mainCriteria)


            'Dim start As DateTime = Now
            'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
            Dim list As IList = query.Execute(ps)

            'System.Diagnostics.Debug.WriteLine("Fine query a " & Now & " della durata di " & Now.Subtract(start).TotalMilliseconds)



            'start = Now
            'System.Diagnostics.Debug.WriteLine("Inizio creazione DTO a " & start.ToString)
            Dim list1 As IList = GetDtoListFromItems(list)
            'System.Diagnostics.Debug.WriteLine("Fine creazione DTO a " & Now & " della durata di " & Now.Subtract(start).TotalMilliseconds)
            m_Results = list1
            m_SearchResult = list1
            Return list
        End Function


        Private Function GetDtoListFromItems(ByVal Items As IList) As IList
            Dim cancel As Boolean = False
            m_SearchResult = New ArrayList
            Dim i As Int32 = 0
            For Each elem As Quota In Items
                'If cancel Then Throw New Exception("Elaborazione terminata dall'utente")
                ''Dim dto As DTOItemContabile = elem.ToDto
                'm_SearchResult.Add(dto)
                'UpdateReportResults(dto)
                m_SearchResult.Add(elem)
                UpdateReportResults(elem)
                'i = i + 1
                'RaiseEvent ElaborationIncremented(CInt(i / Items.Count * 100), cancel)
            Next
            Return m_SearchResult
        End Function
        Private Sub UpdateReportResults(ByVal Dto As Quota)
            'Select Case Dto.TipoDocumento
            '    Case "IQA"
            '        Me.m_NumeroPosizioniIQA = Me.m_NumeroPosizioniIQA + 1
            '        m_NumOreLavorate = m_NumOreLavorate + Dto.OreLavorate
            '        m_NumOreMalattia = m_NumOreMalattia + Dto.OreMalattia
            '        Me.m_ImportoIQA = Me.m_ImportoIQA.Add(New Moneta(Dto.Importo, Moneta.Valuta.Euro).Negate)
            '        Me.m_ImportoRistornoIQA = Me.m_ImportoRistornoIQA.Add(New Moneta(Dto.ImportoRistorno, Moneta.Valuta.Euro))
            '        If Me.m_CompetenzaQuoteSelected Then
            '            Dim peso As Double = CalcolaPesoPeriodo(Dto.Competenza, Me.m_PeriodiMensili)
            '            Me.m_IncassoPonderato = Me.m_IncassoPonderato.Add(CalcolaPesoImportoForItem(New Moneta(Dto.Importo, Moneta.Valuta.Euro), peso))
            '            Me.m_IncassoRistornoPonderato = Me.m_IncassoRistornoPonderato.Add(CalcolaPesoImportoForItem(New Moneta(Dto.ImportoRistorno, Moneta.Valuta.Euro), peso))
            '            Me.m_OreLavoratePonderate = Me.m_OreLavoratePonderate + CalcolaPesoOreForItem(Dto.OreLavorate, peso)
            '            Me.m_OreMalattiaPonderate = Me.m_OreMalattiaPonderate + CalcolaPesoOreForItem(Dto.OreMalattia, peso)
            '        End If
            '    Case "IQP"
            '        Me.m_NumeroPosizioniIQP = Me.m_NumeroPosizioniIQP + 1
            '        Me.m_ImportoIQP = Me.m_ImportoIQP.Add(New Moneta(Dto.Importo, Moneta.Valuta.Euro).Negate)
            '        If Me.m_CompetenzaQuoteSelected Then
            '            Dim peso As Double = CalcolaPesoPeriodo(Dto.Competenza, Me.m_PeriodiMensili)
            '            Me.m_IncassoPonderato = Me.m_IncassoPonderato.Add(CalcolaPesoImportoForItem(New Moneta(Dto.Importo, Moneta.Valuta.Euro), peso))
            '        End If
            '    Case "IQI"
            '        Me.m_NumeroPosizioniIQI = Me.m_NumeroPosizioniIQI + 1
            '        Me.m_ImportoIQI = Me.m_ImportoIQI.Add(New Moneta(Dto.Importo, Moneta.Valuta.Euro).Negate)
            '        Me.m_ImportoRistornoIQI = Me.m_ImportoRistornoIQI.Add(New Moneta(Dto.ImportoRistorno, Moneta.Valuta.Euro))
            '        If Me.m_CompetenzaQuoteSelected Then
            '            Dim peso As Double = CalcolaPesoPeriodo(Dto.Competenza, Me.m_PeriodiGiornalieri)
            '            Me.m_IncassoPonderato = Me.m_IncassoPonderato.Add(CalcolaPesoImportoForItem(New Moneta(Dto.Importo, Moneta.Valuta.Euro), peso))
            '            Me.m_IncassoRistornoPonderato = Me.m_IncassoRistornoPonderato.Add(CalcolaPesoImportoForItem(New Moneta(Dto.ImportoRistorno, Moneta.Valuta.Euro), peso))
            '        End If
            '    Case "IQV"
            '        Me.m_NumeroPosizioniIQV = Me.m_NumeroPosizioniIQV + 1
            '        Me.m_ImportoIQV = Me.m_ImportoIQV.Add(New Moneta(Dto.Importo, Moneta.Valuta.Euro).Negate)
            '        Me.m_ImportoRistornoIQV = Me.m_ImportoRistornoIQV.Add(New Moneta(Dto.ImportoRistorno, Moneta.Valuta.Euro))
            'End Select
            If Dto.Importo < 0 Then
                Dto.Importo = Dto.Importo * -1
            End If

        End Sub

      


        Public Enum TipoInclusioneItemRistornate
            Tutto
            Ristornate
            NonRistornate
        End Enum
        '''' <summary>
        '''' Metodo che calcola il rapporto tra il numero di periodi comuni tra due intervalli temporali
        '''' (entranbi gli intervalli temporali dovranno avere una modalità di confronto o giornaliera o mensile)
        '''' e il numero di periodi all'interno dell'intervallo di competenza della posizione
        '''' </summary>
        '''' <param name="Periodo"> Il periodo di competenza dell'item contabile</param>
        '''' <param name="PeriodoConfronto">Il  periodo nel quale eseguo il report</param>
        '''' <returns>Numero compreso tra 0 e 1 che indica il grado di sovrapposizione dei due periodi</returns>
        '''' <remarks></remarks>
        'Private Function CalcolaPesoPeriodo(ByVal Periodo As AbstractPeriodo, ByVal PeriodoConfronto As AbstractPeriodo) As Double
        '    Dim numCom As Double = PeriodoConfronto.GetNumberOfCommonPeriods(Periodo)
        '    'Dim peso As Double = CDbl(Format(numCom / Periodo.GetNumberOfPeriods, "###0.00"))
        '    Dim peso As Double = numCom / Periodo.GetNumberOfPeriods
        '    Return peso
        'End Function
        'Private Function CalcolaPesoImportoForItem(ByVal Importo As Moneta, ByVal Peso As Double) As Moneta
        '    Dim imp As Double = Importo.Importo
        '    imp = CDbl(Format(imp * Peso, "###0.00"))
        '    Return New Moneta(imp, Moneta.Valuta.Euro)
        'End Function
        'Private Function CalcolaPesoOreForItem(ByVal Ore As Double, ByVal Peso As Double) As Double
        '    Dim imp As Double = Ore
        '    imp = CDbl(Format(Ore * Peso, "###0.00"))
        '    Return imp
        'End Function

#End Region
    End Class



End Namespace