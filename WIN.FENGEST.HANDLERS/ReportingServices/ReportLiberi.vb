
Namespace REPORTING
    Public Class ReportLiberi
        Inherits AbstractControllerRicerche
        Public Event ElaborationIncremented(ByVal Percentage As Int32, ByRef Cancel As Boolean)
        'Variabili per l'abilitazione alla ricerca


        Protected m_Competenza As DataRange = DataRange.Empty
        Protected m_IdContratto As Int32 = -1
        Protected m_NomeContratto As String = ""
        Protected m_IdAzienda As Int32 = -1
        Protected m_IdUtente As String = "-1"
        Protected m_NomeAzienda As String = ""
        Protected m_IdEnte As Int32 = -1
        Protected m_NomeEnte As String = ""
        Protected m_SearchResult As New ArrayList
        Protected m_Incongruenze As Boolean = False

        Protected m_withValidation As Boolean = False


        Protected m_Ente As EnteBilaterale
        Protected m_Provincia As String = "-1"
        Protected m_Comune As String = "-1"
        Protected m_Nazione As String = "-1"
        Protected m_Iscritto_A As String = "-"



        Private SearcherUtenti As New UTENTI.ControllerRicercheUtenti


        Private m_NumeroLiberi As Int32 = 0


#Region "Proprietà risultati report"

        Public ReadOnly Property NumeroLiberi() As String
            Get
                Return m_NumeroLiberi
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

        Public Sub SetIdUtente(ByVal IdUtente As String)
            m_IdUtente = IdUtente
        End Sub


        Public Sub SetIscrittoA(ByVal IscrittiA As String)
            m_Iscritto_A = IscrittiA
        End Sub


        Public Function SetRicercaErrori(ByVal RicercaErrori As Boolean) As Boolean
            m_Incongruenze = RicercaErrori
        End Function

        Public Function SetValidazioneLiberi(ByVal validazione As Boolean) As Boolean
            m_withValidation = validazione
        End Function

        Public Sub SortDTOItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "NonIscrittiDTO"))

        End Sub

        Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "DTOLavoratoreLibero"))

        End Sub


#Region "Metodi per impostare i criteri di ricerca"

        Public Sub SetEnte(ByVal Descrizione As String)
            Dim cont As New AZIENDE.ControllerEntiBilaterali
            If Descrizione = "" Then
                m_IdEnte = 1 'CassaEdile
                m_NomeEnte = "CassaEdile"
                m_Ente = cont.GetEnteById(1)
                Exit Sub
            End If
            m_NomeEnte = Descrizione
            m_Ente = cont.GetEnteByDescrizione(Descrizione)
            m_IdEnte = m_Ente.Id
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
        Public Sub SetCompetenza(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            Dim range As DataRange = New DataRange(Inizio, Fine)
            m_Competenza = range
            'Me.m_PeriodiMensili = New CompositePeriodo(range, IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
            'Me.m_PeriodiGiornalieri = New CompositePeriodo(range, IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera)
        End Sub

#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"

        Public ReadOnly Property NomeEnte() As String
            Get
                Return m_NomeEnte
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

#Region "Metodi per l'elaborazione del report"

        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query

            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperUtente")





            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            Dim subqry As SubQueryCriteria
            Dim secondaryCriteria As CompositeCriteria
            'Dim orderCriteria As AbstractBoolCriteria

            If m_IdEnte <> -1 Then
                secondaryCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

                If m_IdAzienda <> -1 Then
                    secondaryCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
                End If

                'secondaryCriteria.AddCriteria(Criteria.Equal("ID_ENTE", m_IdEnte))

                If Not m_Competenza.IsEmpty Then
                    secondaryCriteria.AddCriteria(New DateContainedCriteria("LIBERO_AL", m_Competenza.Start, m_Competenza.Finish, ps.DBType))
                End If

                subqry = New SubQueryCriteria("DB_INFOS", "ID_UTENTE", True)
                subqry.AddCriteria(secondaryCriteria)

                'orderCriteria = New OrderByCriteria
                'orderCriteria.AddCriteria(Criteria.SortCriteria("LIBERO_AL", False))
                'subqry.AddCriteria(orderCriteria)

                mainCriteria.AddCriteria(Criteria.INClause("ID", subqry))

            Else
                Throw New InvalidOperationException("Ente non impostato")
            End If


            query.AddWhereClause(mainCriteria)


            m_SearchResult = GetDtoListFromItems(query.Execute(ps))
            Return m_SearchResult























        End Function



        Private Function CreateTable() As String
            Dim s As String = ""

            If m_Incongruenze Then
                s = "fn_LavoratoriINonIscrittiIncongruenze1( "
                s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "', "
                s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "', "
                s += " -1," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdUtente + ")"
            ElseIf m_withValidation Then
                s = "fn_LavoratoriINonIscrittiValidati1( "
                s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "', "
                s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "', "
                s += m_Ente.Id.ToString + "," + m_IdAzienda.ToString + "," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdUtente + ",'" + m_Iscritto_A + "')"


            Else
                s = "fn_LavoratoriNonIscrittiDaValidare1( "
                s += "'" + Format(m_Competenza.Start, "dd/MM/yyyy") + "', "
                s += "'" + Format(m_Competenza.Finish, "dd/MM/yyyy") + "', "
                s += m_Ente.Id.ToString + "," + m_IdAzienda.ToString + "," + m_Comune.ToString + "," + m_Provincia.ToString + "," + m_Nazione.ToString + "," + m_IdUtente + ",'" + m_Iscritto_A + "')"


            End If







            Return s
        End Function


        Private Sub ValidateInput()
            If Not m_Incongruenze Then
                If m_NomeAzienda = "" And m_Nazione = "100" And m_Provincia = "-1" And m_Comune = "-1" Then
                    Throw New InvalidOperationException("Inserire dei criteri di selezione più restrittivi")
                End If
            End If
        End Sub


        Public Function SearchDTOs() As IList
            'qui creo ed eseguo la query
            ValidateInput()
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperNonIscrittoDTO")
            Dim table As String = CreateTable()
            query.SetTable(table)

            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            If m_Incongruenze Then
                If m_IdAzienda <> -1 Then

                    mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA_IMPIEGO", m_IdAzienda))

                End If

                'Else

                '   If m_IdEnte <> -1 Then

                '      mainCriteria.AddCriteria(Criteria.Equal("ID_ENTE", m_IdEnte))

                '   End If

                '   If m_IdAzienda <> -1 Then

                '      mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA_IMPIEGO", m_IdAzienda))

                '   End If


            End If

            'Dim subqry As SubQueryCriteria
            'Dim secondaryCriteria As CompositeCriteria
            ''Dim orderCriteria As AbstractBoolCriteria

            'If m_IdEnte <> -1 Then
            '   secondaryCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

            '   If m_IdAzienda <> -1 Then
            '      secondaryCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
            '   End If

            '   'secondaryCriteria.AddCriteria(Criteria.Equal("ID_ENTE", m_IdEnte))

            '   If Not m_Competenza.IsEmpty Then
            '      secondaryCriteria.AddCriteria(New DateContainedCriteria("LIBERO_AL", m_Competenza.Start, m_Competenza.Finish, ps.DBType))
            '   End If

            '   subqry = New SubQueryCriteria("DB_INFOS", "ID_UTENTE", True)
            '   subqry.AddCriteria(secondaryCriteria)

            '   'orderCriteria = New OrderByCriteria
            '   'orderCriteria.AddCriteria(Criteria.SortCriteria("LIBERO_AL", False))
            '   'subqry.AddCriteria(orderCriteria)

            '   mainCriteria.AddCriteria(Criteria.INClause("ID", subqry))

            'Else
            '   Throw New InvalidOperationException("Ente non impostato")
            'End If


            query.AddWhereClause(mainCriteria)


            m_SearchResult = query.Execute(ps)

            Me.m_NumeroLiberi = m_SearchResult.Count

            Return m_SearchResult


        End Function





        Private Function GetDtoListFromItems(ByVal Items As IList) As IList
            Dim cancel As Boolean = False
            m_SearchResult = New ArrayList
            Dim i As Int32 = 0
            Dim map As New Hashtable
            For Each elem As Utente In Items
                If cancel Then Throw New Exception("Elaborazione terminata dall'utente")
                Dim dto As DTOLavoratoreLibero = CreateDTO(elem)
                FilterSearchResults(dto, map)
                i = i + 1
                RaiseEvent ElaborationIncremented(CInt(i / Items.Count * 100), cancel)
            Next
            map = Nothing
            Return m_SearchResult
        End Function


        Private Function CreateDTO(ByVal Utente As Utente)
            Dim info As Info = Utente.GetLastInfoInRange(m_Competenza, m_Ente)
            If info Is Nothing Then
                Return Nothing
            End If
            If m_Incongruenze Then
                If Utente.HasPositiveDeleghe(info.LiberoAl, m_Ente.Id) Then
                    Return New DTOLavoratoreLibero(Utente, info.LiberoAl, info.AziendaImpiego)
                End If
            Else
                If Utente.IsFree(info.LiberoAl, m_Ente) Then
                    Return New DTOLavoratoreLibero(Utente, info.LiberoAl, info.AziendaImpiego)
                End If
            End If
            Return Nothing
        End Function


        Private Function IsFree(ByVal Utente As Utente, ByVal info As Info) As Boolean
            'per prima cosa verifico il numero di deleghe
            'se è nullo allora il lavoratore è libero

            'altrimenti il lavoratore è libero solo se la delega 
            '(per l'ente specificato) precedente
            'la data libero al è nello stato "revocata" o "annullata"




        End Function


        ''' <summary>
        ''' Metodo che filtra i risultati ottenuti dalla query: Per semplificare la query
        ''' si sono prese tutte le posizioni di incasso quota associativa che soddisfano
        ''' i requisiti immessi. Si filtrerà per utente in modo che ci sia una sola posizione per 
        ''' utente. 
        ''' </summary>
        ''' <param name="Dto"></param>
        ''' <remarks></remarks>
        Private Sub FilterSearchResults(ByVal Dto As DTOLavoratoreLibero, ByVal Map As Hashtable)
            ' Dim map As New Hashtable
            If Dto Is Nothing Then
                Return
            End If
            Dim id As Int32 = Dto.IdUtente
            If Not Map.Contains(id.ToString) Then
                AddToSearchResult(Dto)
                Map.Add(id.ToString, "")
            End If
        End Sub

        Private Sub AddToSearchResult(ByVal Dto As DTOLavoratoreLibero)

            Me.m_NumeroLiberi = Me.m_NumeroLiberi + 1
            m_SearchResult.Add(Dto)


        End Sub



#End Region
    End Class
End Namespace

