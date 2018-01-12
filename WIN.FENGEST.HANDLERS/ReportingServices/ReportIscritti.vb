Imports WIN.SECURITY

Namespace REPORTING
    Public Class ReportIscritti
        Inherits AbstractControllerRicerche
        Public Event ElaborationIncremented(ByVal Percentage As Int32, ByRef Cancel As Boolean)
        'Variabili per l'abilitazione alla ricerca

        'Protected m_DataRegistrazioneRangeSelected As Boolean = False
        'Protected m_DataDocumentoRangeSelected As Boolean = False
        'Protected m_ListaUtentiSelected As Boolean = False
        'Protected m_CompetenzaQuoteSelected As Boolean = False
        'Private m_PeriodiMensili As AbstractPeriodo = New PeriodoNullo
        'Private m_PeriodiGiornalieri As AbstractPeriodo = New PeriodoNullo
        Protected m_ListaUtentiSelected As Boolean = False
        Protected m_QuoteInps As Boolean = False
        Protected m_QuotePrevisionali As Boolean = False
        Protected m_IncludiVerificaDelega As Boolean = False
        Protected m_Competenza As DataRange = DataRange.Empty
        Protected m_NomeSettore As String = ""
        Protected m_IdSettore As Int32 = -1
        Protected m_IdReparto As Int32 = -1
        Protected m_IdReferente As Int32 = -1
        Protected m_NomeReparto As String = ""
        Protected m_IdContratto As Int32 = -1
        Protected m_NomeContratto As String = ""
        Protected m_IdAzienda As Int32 = -1
        Protected m_NomeAzienda As String = ""
        Protected m_NomeReferente As String = ""
        Protected m_SearchResult As New ArrayList
        Protected m_ListaUtenti As New ArrayList
        Private m_listaNomiUtenti As New ArrayList

        Protected m_IdEnte As Int32 = -1
        Protected m_NomeEnte As String = ""

        Private m_ExportSector As String = ""

        Protected m_Provincia As String = "-1"
        Protected m_Comune As String = "-1"
        Protected m_Nazione As String = "-1"



        'Protected m_DataRegistrazioneRange As DataRange = DataRange.Empty
        'Protected m_DataDocumentoRange As DataRange = DataRange.Empty
        'Protected m_ListaUtenti As New ArrayList
        'Protected m_IdReferente As Int32 = -1

        'Protected m_IdEnte As Int32 = -1
        'Protected m_NomeEnte As String = ""
        'Protected m_NomeReferente As String = ""
        'Protected m_TipoDocIQA As Boolean = False
        'Protected m_TipoDocIQI As Boolean = False
        'Protected m_TipoDocIQV As Boolean = False
        'Protected m_TipoInclusione As TipoInclusioneItemRistornate = TipoInclusioneItemRistornate.Tutto
        'Private m_IsSettoreEdile As Boolean = False
        'Private m_listaNomiUtenti As New ArrayList


        Private m_NumeroIscritti As Int32 = 0
        Private m_NumeroIscrittiConRevocaCGL As Int32 = 0
        Private m_NumeroIscrittiConRevocaCISL As Int32 = 0
        Private m_NumeroIscrittiNuovi As Int32 = 0

#Region "Proprietà risultati report"


        Public ReadOnly Property NomeEnte() As String
            Get
                Return m_NomeEnte
            End Get
        End Property

        Public Sub SetEnte(ByVal nomeEnte As String)
            If nomeEnte = "CASSA EDILE" Then
                m_NomeEnte = nomeEnte
                m_IdEnte = 1

            ElseIf nomeEnte = "EDILCASSA" Then
                m_NomeEnte = nomeEnte
                m_IdEnte = 2

            Else
                m_NomeEnte = nomeEnte
                m_IdEnte = -1

            End If


        End Sub

        'Public ReadOnly Property NumeroPosizioni() As String
        '   Get
        '      Dim numero As Int32 = m_NumeroPosizioniIQA + m_NumeroPosizioniIQI + m_NumeroPosizioniIQV
        '      Return numero
        '   End Get
        'End Property

        Public ReadOnly Property NumeroIscrittiNuovi() As String
            Get
                Return m_NumeroIscrittiNuovi
            End Get
        End Property
        Public ReadOnly Property ListaNomiUtenti() As ArrayList
            Get
                Return m_listaNomiUtenti
            End Get
        End Property
        Public ReadOnly Property NumeroIscrittiConRevocaCGL() As String
            Get
                Return m_NumeroIscrittiConRevocaCGL
            End Get
        End Property
        Public ReadOnly Property NumeroIscrittiConRevocaCISL() As String
            Get
                Return m_NumeroIscrittiConRevocaCISL
            End Get
        End Property
        Public ReadOnly Property NumeroIscritti() As String
            Get
                Return m_NumeroIscritti
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

        Public ReadOnly Property ExportType() As String
            Get
                Return m_ExportSector
            End Get

        End Property
        Public Sub SetExportSector(ByVal sector As String)
            m_ExportSector = sector
        End Sub

        Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)
            Try
                If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
                m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "DtoItemContabile"))
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Public Sub SortDTOItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)
            Try
                If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
                m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "IscrittiDTO"))
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#Region "Metodi per impostare i criteri di ricerca"


        Public Sub SetProvincia(ByVal NomeProvincia As String)
            Dim Provincia As Provincia = GeoLocationFacade.Instance.GetGeoHandler.GetProvinciaByName(NomeProvincia)
            m_Provincia = Provincia.Id
        End Sub

        Public Sub SetComune(ByVal NomeComune As String)
            Dim Comune As Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
            m_Comune = Comune.Id
        End Sub
        Public Sub SetNazione(ByVal NomeNazione As String)
            Dim nazione As Nazione = GeoLocationFacade.Instance.GetGeoHandler.GetNazioneByName(NomeNazione)
            m_Nazione = nazione.Id
        End Sub


        Public Sub SetQuotePrevisionali(ByVal SoloQuotePrevisionali As Boolean)
            m_QuotePrevisionali = SoloQuotePrevisionali
        End Sub

        Public ReadOnly Property OnlyQuoteInps() As Boolean
            Get
                Return m_QuoteInps
            End Get
        End Property

        Public Sub SetQuoteInps(ByVal SoloQuoteInps As Boolean)
            m_QuoteInps = SoloQuoteInps
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

        Public Sub SetVerificaDelega(ByVal Verifica As Boolean)
            m_IncludiVerificaDelega = Verifica
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
        'Public Sub SetReparto(ByVal Descrizione As String)
        '   If Descrizione = "" Then
        '      m_IdReparto = -1
        '      m_NomeReparto = Descrizione
        '      Exit Sub
        '   End If
        '   Dim cont As New ControllerReparti
        '   m_NomeReparto = Descrizione
        '   m_IdReparto = cont.GetIdByDescrizione(Descrizione)
        'End Sub
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


        Public Sub SetReferente(ByVal Id As String)
            Try
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
            Catch ex As Exception
                m_NomeReferente = ""
            End Try

        End Sub



        Public Sub SetCompetenza(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            Dim range As DataRange = New DataRange(Inizio, Fine)
            m_Competenza = range
            'Me.m_PeriodiMensili = New CompositePeriodo(range, IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
            'Me.m_PeriodiGiornalieri = New CompositePeriodo(range, IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera)
        End Sub

#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"
        Public ReadOnly Property NomeSettore() As String
            Get
                Return m_NomeSettore
            End Get
        End Property
        Public ReadOnly Property NomeReferente() As String
            Get
                Return m_NomeReferente
            End Get
        End Property
        Public ReadOnly Property NomeContratto() As String
            Get
                Return m_NomeContratto
            End Get
        End Property
        Public ReadOnly Property VerificaDelega() As String
            Get
                If m_IncludiVerificaDelega Then
                    Return "Si"
                Else
                    Return "No"
                End If
            End Get
        End Property
        'Public ReadOnly Property NomeReparto() As String
        '   Get
        '      Return m_NomeReparto
        '   End Get
        'End Property
        Public ReadOnly Property NomeAzienda() As String
            Get
                Return m_NomeAzienda
            End Get
        End Property
        Public ReadOnly Property CompetenzaRange() As String
            Get
                Return Me.m_Competenza.ToString
            End Get
        End Property
        'Public ReadOnly Property NomeReferente() As String
        '   Get
        '      Return m_NomeReferente
        '   End Get
        'End Property
#End Region


        Private Function CreateTable() As String
            Dim s As String = ""

            If m_QuoteInps Then
                s = "fn_Iscritti_Quote1( "
                s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "',"
                s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "',"
                s += "'IQI',''," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdAzienda.ToString + "," + m_IdReferente.ToString + "," + m_IdContratto.ToString + "," + m_IdEnte.ToString + ")"

                Return s
            End If

            If m_QuotePrevisionali Then
                If m_IncludiVerificaDelega Then
                    s = "fn_Iscritti_QuoteConVerificaDelega1( "
                    s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "',"
                    s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "', '" & m_NomeSettore + "'," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdAzienda.ToString + "," + m_IdReferente.ToString + "," + m_IdContratto.ToString + ",'IQP'," + m_IdEnte.ToString + ")"
                Else
                    s = "fn_Iscritti_Quote1( "
                    s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "',"
                    s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "',"
                    s += "'IQP', '" & m_NomeSettore + "'," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdAzienda.ToString + "," + m_IdReferente.ToString + "," + m_IdContratto.ToString + "," + m_IdEnte.ToString + ")"
                End If

                Return s
            End If





            If m_IncludiVerificaDelega Then
                s = "fn_Iscritti_QuoteConVerificaDelega1( "
                s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "',"
                s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "', '" & m_NomeSettore + "'," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdAzienda.ToString + "," + m_IdReferente.ToString + "," + m_IdContratto.ToString + ",'IQA'" + "," + m_IdEnte.ToString + ")"
            Else
                s = "fn_Iscritti_Quote1( "
                s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "',"
                s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "',"
                s += "'IQA', '" & m_NomeSettore + "'," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdAzienda.ToString + "," + m_IdReferente.ToString + "," + m_IdContratto.ToString + "," + m_IdEnte.ToString + ")"

            End If




            Return s
        End Function


        Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)

            'm_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
            'm_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
            m_ListaUtentiSelected = IIf(ParameterMap("ListaSoggetti") Is Nothing, False, ParameterMap("ListaSoggetti"))
            'm_CompetenzaQuoteSelected = IIf(ParameterMap("CompetenzaQuote") Is Nothing, False, ParameterMap("CompetenzaQuote"))
        End Sub




#Region "Metodi per l'elaborazione del report"

        Public Overrides Function Search() As IList
            '    'qui creo ed eseguo la query
            '    Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            '    Dim query As Query = ps.CreateNewQuery("MapperItemDocumentoContabile")
            '    Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            '    mainCriteria.AddCriteria(Criteria.Equal("ID_CONTO", 2))
            '    mainCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQA'"))

            '    'If m_IdReferente <> -1 Then
            '    '   mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
            '    'End If



            '    'aggiungo le clausole per ildocumento


            '    If Not m_Competenza.IsEmpty Then
            '        mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", m_Competenza.Start, m_Competenza.Finish, ps.DBType))
            '    End If

            '    If m_IdSettore <> -1 Then
            '        mainCriteria.AddCriteria(Criteria.Equal("ID_SETTORE", m_IdSettore))
            '    End If

            '    If m_IdContratto <> -1 Then
            '        mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_IdContratto))
            '    End If

            '    If m_IdReferente <> -1 Then
            '        mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
            '    End If

            '    If m_IdAzienda <> -1 Then
            '        mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA_IMPIEGO", m_IdAzienda))
            '    End If


            '    query.AddWhereClause(mainCriteria)

            '    Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
            '    orderCriteria.AddCriteria(Criteria.SortCriteria("ID_UTENTE", True))
            '    orderCriteria.AddCriteria(Criteria.SortCriteria("DATA_FINE_COMP", False))

            '    query.AddOrderByClause(orderCriteria)

            '    m_Results = GetDtoListFromItems(query.Execute(ps))
            '    m_SearchResult = m_Results
            '    Return m_Results

            Throw New NotImplementedException
        End Function


        Public Function SearchDTOsForBolzano() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperIscrittoDTO")
            Dim table As String = CreateTableForBolzanoPrevisionali()
            query.SetTable(table)

          
            Dim s As String = query.CreateQuery(ps)
            'ottengo la lista delle quote previsionali
            Dim prev As ArrayList = query.Execute(ps)

            'ottengo adesso la lista per gli impianti fissi dellanno



            Dim query1 As Query = ps.CreateNewQuery("MapperIscrittoDTO")
            Dim table1 As String = CreateTableForBolzanoIF()
            query1.SetTable(table1)


            Dim s1 As String = query1.CreateQuery(ps)
            'ottengo la lista delle quote previsionali
            Dim ifissi As ArrayList = query1.Execute(ps)



            'ottengo la lista per gli iscitti inps
            Dim query2 As Query = ps.CreateNewQuery("MapperIscrittoDTO")
            Dim table2 As String = CreateTableForBolzanoInps()
            query2.SetTable(table2)


            Dim s2 As String = query2.CreateQuery(ps)
            'ottengo la lista delle quote previsionali
            Dim inps As ArrayList = query2.Execute(ps)




            Dim result As New ArrayList

            For Each elem As IscrittoDTO In prev
                Dim a As New UtenteBolzano
                a.Cap = elem.Cap
                a.Codice_Fiscale = elem.Codice_Fiscale
                a.Nome = elem.Nome
                a.Cognome = elem.Cognome
                a.Nome_Comune = elem.Nome_Comune
                a.Indirizzo = elem.Indirizzo


                result.Add(a)
            Next
            For Each elem As IscrittoDTO In ifissi
                Dim a As New UtenteBolzano
                a.Cap = elem.Cap
                a.Codice_Fiscale = elem.Codice_Fiscale
                a.Nome = elem.Nome
                a.Cognome = elem.Cognome
                a.Nome_Comune = elem.Nome_Comune
                a.Indirizzo = elem.Indirizzo


                result.Add(a)
            Next

            For Each elem As IscrittoDTO In inps
                Dim a As New UtenteBolzano
                a.Cap = elem.Cap
                a.Codice_Fiscale = elem.Codice_Fiscale
                a.Nome = elem.Nome
                a.Cognome = elem.Cognome
                a.Nome_Comune = elem.Nome_Comune
                a.Indirizzo = elem.Indirizzo

                If (Not ListContainsFiscalCode(result, a.Codice_Fiscale)) Then
                    result.Add(a)
                End If


            Next


            Return result
        End Function

        Public Function ListContainsFiscalCode(result As ArrayList, fiscalCode As String) As Boolean
            For Each elem As UtenteBolzano In result
                If elem.Codice_Fiscale.Equals(fiscalCode) Then
                    Return True
                End If
            Next

            Return False
        End Function

        Private Function CreateTableForBolzanoPrevisionali() As String
            Dim s As String = ""

            Dim annoAttuale As Int32 = DateTime.Now.Date.Year

            Dim dateStart, dateEnd As DateTime

            'devo capire a partire dalla data odierna 
            'se la data è compresa tra il 01/05/2014 e il 30/09/2014
            'allora devo recuperare il semestre precedente ossia il periodo
            'tra il 01/10/2013 e il 30/04/2014

            'alla stessa maniera se la data è compresa tra il 01/10/2014 e il 31/12/2014
            'allora devo recuperare il semestre precedente ossia il periodo
            'tra il 01/05/2014 e il 30/09/2014

            'altrimenti se la data è compresa tra il 01/01/2014 e il 30/04/2014
            'allora devo recuperare il semestre precedente ossia primo semestre dell'anno precedente e quindi il periodo
            'tra il 01/05/2013 e il 30/09/2013


            If (DateTime.Now >= New DateTime(annoAttuale, 5, 1) And DateTime.Now <= New DateTime(annoAttuale, 9, 30)) Then
                dateStart = New DateTime(annoAttuale - 1, 10, 1)
                dateEnd = New DateTime(annoAttuale, 4, 30)
            ElseIf (DateTime.Now >= New DateTime(annoAttuale, 10, 1) And DateTime.Now <= New DateTime(annoAttuale, 12, 31)) Then
                dateStart = New DateTime(annoAttuale, 5, 1)
                dateEnd = New DateTime(annoAttuale, 9, 30)
            Else
                dateStart = New DateTime(annoAttuale - 1, 5, 1)
                dateEnd = New DateTime(annoAttuale - 1, 9, 30)
            End If



            s = "fn_Iscritti_Quote1( "
            s += "'" + Format(dateStart, "dd/MM/yyyy") + "',"
            s += "'" + Format(dateEnd, "dd/MM/yyyy") + "',"
            s += "'IQP', 'EDILE','-1','-1','-1','-1','-1','-1','-1')"


            Return s











            Return s
        End Function








        Public Function SearchDTOs() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperIscrittoDTO")
            Dim table As String = CreateTable()
            query.SetTable(table)

            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            'mainCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'IQA'"))


            If Not m_QuoteInps Then
                If m_ListaUtentiSelected Then
                    Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                    If m_ListaUtenti.Count > 0 Then
                        For Each elem As String In m_ListaUtenti
                            CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
                        Next
                        mainCriteria.AddCriteria(CompositeListaSoggetti)
                    End If
                End If
            End If


            ''aggiungo le clausole per ildocumento





            query.AddWhereClause(mainCriteria)
            Dim s As String = query.CreateQuery(ps)
            'Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
            'orderCriteria.AddCriteria(Criteria.SortCriteria("ID_UTENTE", True))
            'orderCriteria.AddCriteria(Criteria.SortCriteria("DATA_FINE_COMP", False))

            'query.AddOrderByClause(orderCriteria)

            m_Results = query.Execute(ps)
            m_SearchResult = m_Results
            m_NumeroIscritti = m_Results.Count

            If m_IncludiVerificaDelega Then
                For Each elem As IscrittoDTO In m_Results
                    If elem.Causale.Contains("FILCA") Then
                        m_NumeroIscrittiConRevocaCISL = m_NumeroIscrittiConRevocaCISL + 1
                    ElseIf elem.Causale.Contains("FILLEA") Then
                        m_NumeroIscrittiConRevocaCGL = m_NumeroIscrittiConRevocaCGL + 1
                    ElseIf elem.Causale.Contains("NUOVA") Then
                        m_NumeroIscrittiNuovi = m_NumeroIscrittiNuovi + 1
                    End If
                Next

            End If
            Return m_Results
        End Function
        Public Sub SetDTOPrintCardsTable(ByVal SoloUtenteNonTesserati As Boolean, ByVal AddressOk As Boolean)
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            'ps.ExecuteNonQuery("Begin transaction PrintCards")

            ps.ExecuteNonQuery("Delete from db_tesseramento")

            For Each elem As IscrittoDTOHelper In FilterDTOResultList(SoloUtenteNonTesserati)

                If AddressOk Then
                    If elem.IsAddressValid Then
                        InsertCard(elem, ps)
                    End If
                Else
                    InsertCard(elem, ps)
                End If

            Next

        End Sub

        Public Sub SetDTOPrintCardsTable(ByVal SoloUtenteNonTesserati As Boolean, ByVal AddressOk As Boolean, ByVal lista As IList)
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            'ps.ExecuteNonQuery("Begin transaction PrintCards")

            ps.ExecuteNonQuery("Delete from db_tesseramento")

            For Each elem As IscrittoDTOHelper In FilterDTOResultList(SoloUtenteNonTesserati, lista)

                If AddressOk Then
                    If elem.IsAddressValid Then
                        InsertCard(elem, ps)
                    End If
                Else
                    InsertCard(elem, ps)
                End If

            Next

        End Sub

        Private Sub InsertCard(ByVal elem As IscrittoDTOHelper, ByVal ps As IPersistenceFacade)

            If elem.IscrittoDTO.TipoDoc = "IQI" Then
                ps.ExecuteNonQuery(String.Format("Insert into db_tesseramento " & _
                                                 "(Cognome, Nome, Impresa, STAMPATA_DA,IdUtente, PROVINCIA, COMUNE, VIA, CAP,AZIENDA_OLD) " & _
                                                  "values " & _
                                                  "('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}')", _
                                                  Replace(elem.Cognome, "'", "''"), _
                                                  Replace(elem.Nome, "'", "''"), _
                                                  "INPS", _
                                                  Replace(SecurityManager.Instance.CurrentUser.Username, "'", "''"), _
                                                  elem.IscrittoDTO.Id_Utente, _
                                                  GeoLocationFacade.Instance.GetSiglaProvinciaByNomeProvincia(elem.IscrittoDTO.Nome_Provincia), _
                                                  Replace(elem.IscrittoDTO.Nome_Comune, "'", "''"), _
                                                  Replace(elem.IscrittoDTO.Indirizzo, "'", "''"), _
                                                  Replace(elem.IscrittoDTO.Cap, "'", "''"), _
                                                  "INPS"))
            Else
                ps.ExecuteNonQuery(String.Format("Insert into db_tesseramento " & _
                                                 "(Cognome, Nome, Impresa, STAMPATA_DA,IdUtente, PROVINCIA, COMUNE, VIA, CAP,AZIENDA_OLD) " & _
                                                 "values " & _
                                                 "('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}' )", _
                                                 Replace(elem.Cognome, "'", "''"), _
                                                 Replace(elem.Nome, "'", "''"), _
                                                 Replace(elem.IscrittoDTO.AziendaImpiego, "'", "''"), _
                                                 Replace(SecurityManager.Instance.CurrentUser.Username, "'", "''"), _
                                                 elem.IscrittoDTO.Id_Utente, _
                                                 GeoLocationFacade.Instance.GetSiglaProvinciaByNomeProvincia(elem.IscrittoDTO.Nome_Provincia), _
                                                 Replace(elem.IscrittoDTO.Nome_Comune, "'", "''"), _
                                                 Replace(elem.IscrittoDTO.Indirizzo, "'", "''"), _
                                                 Replace(elem.IscrittoDTO.Cap, "'", "''"), _
                                                 Replace(elem.IscrittoDTO.AziendaImpiego, "'", "''")))
            End If
        End Sub


        'Public Sub SetPrintCardsTable(ByVal SoloUtenteNonTesserati As Boolean)
        '    Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        '    'ps.ExecuteNonQuery("Begin transaction PrintCards")

        '    ps.ExecuteNonQuery("Delete from db_tesseramento")

        '    For Each elem As DTOItemContabile In FilterResultList(SoloUtenteNonTesserati)
        '        If elem.AziendaImpiego IsNot Nothing Then
        '            ps.ExecuteNonQuery(String.Format("Insert into db_tesseramento (Cognome, Nome, Impresa, STAMPATA_DA,IdUtente) values ('{0}', '{1}', '{2}', '{3}', {4} )", Replace(elem.Utente.Cognome, "'", "''"), Replace(elem.Utente.Nome, "'", "''"), Replace(elem.AziendaImpiego.Descrizione, "'", "''"), Replace(SecurityManager.Instance.CurrentUser.Username, "'", "''"), elem.Utente.IdUtente))
        '        End If
        '    Next




        'End Sub


        Private Function FilterResultList(ByVal SoloUtentiNonTesserati As Boolean) As IList
            Dim result As IList = New ArrayList
            If SoloUtentiNonTesserati Then
                For Each elem As DTOItemContabile In m_SearchResult
                    If Not elem.Utente.PossiedeTessera(DateTime.Now.Year) Then
                        result.Add(elem)
                    End If
                Next
            Else
                result = m_SearchResult
            End If


            Return result
        End Function

        Private Function FilterDTOResultList(ByVal SoloUtentiNonTesserati As Boolean, ByVal lista As IList) As IList
            Dim result As IList = New ArrayList
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            If SoloUtentiNonTesserati Then
                For Each elem As IscrittoDTO In lista
                    Dim utente As Utente = ps.GetObject("Utente", elem.Id_Utente)
                    If utente IsNot Nothing Then
                        If Not utente.PossiedeTessera(DateTime.Now.Year) Then
                            Dim i As New IscrittoDTOHelper
                            i.IscrittoDTO = elem
                            i.Nome = utente.Nome
                            i.Cognome = utente.Cognome
                            result.Add(i)
                        End If
                    End If

                Next
            Else
                For Each elem As IscrittoDTO In lista
                    Dim utente As Utente = ps.GetObject("Utente", elem.Id_Utente)
                    If utente IsNot Nothing Then
                        Dim i As New IscrittoDTOHelper
                        i.IscrittoDTO = elem
                        i.Nome = utente.Nome
                        i.Cognome = utente.Cognome
                        result.Add(i)
                    End If

                Next


            End If


            Return result
        End Function

        Private Function FilterDTOResultList(ByVal SoloUtentiNonTesserati As Boolean) As IList
            Dim result As IList = New ArrayList
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            If SoloUtentiNonTesserati Then
                For Each elem As IscrittoDTO In m_SearchResult
                    Dim utente As Utente = ps.GetObject("Utente", elem.Id_Utente)
                    If utente IsNot Nothing Then
                        If Not utente.PossiedeTessera(DateTime.Now.Year) Then
                            Dim i As New IscrittoDTOHelper
                            i.IscrittoDTO = elem
                            i.Nome = utente.Nome
                            i.Cognome = utente.Cognome
                            result.Add(i)
                        End If
                    End If

                Next
            Else
                For Each elem As IscrittoDTO In m_SearchResult
                    Dim utente As Utente = ps.GetObject("Utente", elem.Id_Utente)
                    If utente IsNot Nothing Then
                        Dim i As New IscrittoDTOHelper
                        i.IscrittoDTO = elem
                        i.Nome = utente.Nome
                        i.Cognome = utente.Cognome
                        result.Add(i)
                    End If

                Next


            End If


            Return result
        End Function



        Private Function GetDtoListFromItems(ByVal Items As IList) As IList
            Dim cancel As Boolean = False
            m_SearchResult = New ArrayList
            Dim i As Int32 = 0
            Dim map As New Hashtable
            For Each elem As ItemContabile In Items
                If cancel Then Throw New Exception("Elaborazione terminata dall'utente")
                Dim dto As DTOItemContabile = elem.ToDto
                ' m_SearchResult.Add(dto)
                FilterSearchResults(dto, map)
                i = i + 1
                RaiseEvent ElaborationIncremented(CInt(i / Items.Count * 100), cancel)
            Next
            map = Nothing
            Return m_SearchResult
        End Function

        ''' <summary>
        ''' Metodo che filtra i risultati ottenuti dalla query: Per semplificare la query
        ''' si sono prese tutte le posizioni di incasso quota associativa che soddisfano
        ''' i requisiti immessi. Si filtrerà per utente in modo che ci sia una sola posizione per 
        ''' utente. 
        ''' </summary>
        ''' <param name="Dto"></param>
        ''' <remarks></remarks>
        Private Sub FilterSearchResults(ByVal Dto As DTOItemContabile, ByVal Map As Hashtable)
            ' Dim map As New Hashtable
            Dim id As Int32 = Dto.Utente.IdUtente
            If Not Map.Contains(id.ToString) Then
                AddToSearchResult(Dto)
                Map.Add(id.ToString, "")
            End If
        End Sub

        Private Sub AddToSearchResult(ByVal Dto As DTOItemContabile)
            If Me.m_IncludiVerificaDelega Then
                Dim delega As Delega = Dto.Utente.GetActiveDelegaFor(Dto.SoggettoEsecutore, Me.m_Competenza.Finish)
                Dim causaleSottoscrizione As Int32 = delega.CausaleSottoscrizione.Id
                If causaleSottoscrizione <> -1 Then
                    Select Case causaleSottoscrizione
                        Case 1
                            Me.m_NumeroIscrittiNuovi = Me.m_NumeroIscrittiNuovi + 1
                        Case 2
                            Me.m_NumeroIscrittiConRevocaCGL = Me.m_NumeroIscrittiConRevocaCGL + 1
                        Case 3
                            Me.m_NumeroIscrittiConRevocaCISL = Me.m_NumeroIscrittiConRevocaCISL + 1
                    End Select
                    Me.m_NumeroIscritti = Me.m_NumeroIscritti + 1
                    m_SearchResult.Add(Dto)
                End If
            Else
                Me.m_NumeroIscritti = Me.m_NumeroIscritti + 1
                m_SearchResult.Add(Dto)
            End If

        End Sub



#End Region

        Private Function CreateTableForBolzanoIF() As String
            Dim s As String = ""

           
            Dim dateStart As DateTime = New DateTime(DateTime.Now.Year, 1, 1)
            Dim dateEnd As DateTime = New DateTime(DateTime.Now.Year, 12, 31)


            s = "fn_Iscritti_Quote1( "
            s += "'" + Format(dateStart, "dd/MM/yyyy") + "',"
            s += "'" + Format(dateEnd, "dd/MM/yyyy") + "',"
            s += "'IQA', 'IMPIANTI FISSI','-1','-1','-1','-1','-1','-1','-1')"





            Return s
        End Function


        Private Function CreateTableForBolzanoInps() As String
            Dim s As String = ""


            Dim dateStart As DateTime = New DateTime(DateTime.Now.Year, 1, 1)
            Dim dateEnd As DateTime = New DateTime(DateTime.Now.Year, 12, 31)


            s = "fn_Iscritti_Quote1( "
            s += "'" + Format(dateStart, "dd/MM/yyyy") + "',"
            s += "'" + Format(dateEnd, "dd/MM/yyyy") + "',"
            s += "'IQI', '','-1','-1','-1','-1','-1','-1','-1')"





            Return s
        End Function

    End Class

    Public Class IscrittoDTOHelper

        Private m_IscrittoDTO As IscrittoDTO
        Public Property IscrittoDTO() As IscrittoDTO
            Get
                Return m_IscrittoDTO
            End Get
            Set(ByVal value As IscrittoDTO)
                m_IscrittoDTO = value
            End Set
        End Property




        Private m_Cognome As String
        Public Property Cognome() As String
            Get
                Return m_Cognome
            End Get
            Set(ByVal value As String)
                m_Cognome = value
            End Set
        End Property

        Private m_Nome As String
        Public Property Nome() As String
            Get
                Return m_Nome
            End Get
            Set(ByVal value As String)
                m_Nome = value
            End Set
        End Property

        Public Function IsAddressValid() As Boolean
            If Not String.IsNullOrEmpty(m_IscrittoDTO.Nome_Comune) And Not String.IsNullOrEmpty(m_IscrittoDTO.Indirizzo) And Not String.IsNullOrEmpty(m_IscrittoDTO.Cap) Then
                Return True
            End If
        End Function
    End Class
End Namespace
