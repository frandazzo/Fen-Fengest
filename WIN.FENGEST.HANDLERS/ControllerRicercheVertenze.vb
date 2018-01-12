Namespace ADMINISTRATION
    Public Enum VertenzaSearchType
        All
        Closed
        Opened

    End Enum

    Public Class ControllerRicercheVertenze
        Inherits AbstractControllerRicerche
        Protected m_SearchResult As New ArrayList
        'Variabili per l'abilitazione alla ricerca
        Protected m_DataRegistrazioneRangeSelected As Boolean = False
        Protected m_DataDocumentoRangeSelected As Boolean = False
        Protected m_ValiditaRangeSelected As Boolean = False
        Protected m_DataEventoRangeSelected As Boolean = False


        Protected m_UtenteSelected As Boolean = False

        Protected m_Vertenzachiusa As VertenzaSearchType = VertenzaSearchType.All
        Protected m_ValiditaRange As DataRange = DataRange.Empty
        Protected m_DataEventoRange As DataRange = DataRange.Empty
        Protected m_DataRegistrazioneRange As DataRange = DataRange.Empty
        Protected m_DataDocumentoRange As DataRange = DataRange.Empty
        Protected m_IdUtente As Int32 = -1

        Protected m_ListaAziendeSelected As Boolean = False
        Protected m_ListaAziende As New ArrayList
        Private m_listaNomiAziende As New ArrayList

        Protected m_ListaUtentiSelected As Boolean = False
        Protected m_ListaUtenti As New ArrayList
        Private m_listaNomiUtenti As New ArrayList



        Protected m_IdReferente As Int32 = -1
        Protected m_NomeReferente As String = ""

        Protected m_IdAvvocato As Int32 = -1
        Protected m_NomeAvvocato As String = ""

        Protected m_IdResponsabile As Int32 = -1
        Protected m_NomeResponsabile As String = ""

        Private m_NumeroRecord As Int32 = 0

        Protected m_NomeTipoEvento As String = ""
        Protected m_IdTipoEvento As Int32 = -1



        Protected m_EnteInoltro As String = ""
        Protected m_Avvocato As String = ""
        Protected m_Intervento As String = ""





        Public ReadOnly Property Intervento() As String
            Get
                Return m_Intervento
            End Get
        End Property

        Public Sub SetIntervento(ByVal Intervento As String)
            m_Intervento = Intervento
        End Sub






        Public ReadOnly Property EnteInoltro() As String
            Get
                Return m_EnteInoltro
            End Get
        End Property

        Public Sub SetEnteInoltro(ByVal EnteInoltro As String)
            m_EnteInoltro = EnteInoltro
        End Sub



        Public ReadOnly Property NomeTipoEvento() As String
            Get
                Return m_NomeTipoEvento
            End Get
        End Property

        Public Sub SetTipoEvento(ByVal NomeTipoEvento As String)
            Try
                m_NomeTipoEvento = NomeTipoEvento
                m_IdTipoEvento = TipoEvento.GetTipoEventoByDescrizione(NomeTipoEvento)
            Catch ex As Exception
                m_NomeTipoEvento = ""
                m_IdTipoEvento = -1
            End Try

        End Sub

        Public ReadOnly Property ListaNomiAziende() As ArrayList
            Get
                Return m_listaNomiAziende
            End Get
        End Property

        Public ReadOnly Property ListaNomiUtenti() As ArrayList
            Get
                Return m_listaNomiUtenti
            End Get
        End Property


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

        Public Sub SetVertenzaChiusa(ByVal chiusa As VertenzaSearchType)
            m_Vertenzachiusa = chiusa
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


        Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            m_SearchResult.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "VertenzeDTO"))

        End Sub

        Public ReadOnly Property SearchResult() As IList
            Get
                Return m_SearchResult
            End Get
        End Property

        Public ReadOnly Property NumeroPosizioni() As String
            Get
                Return m_NumeroRecord
            End Get
        End Property


        Public ReadOnly Property DataDocumentoRange() As String
            Get
                If Me.m_DataDocumentoRangeSelected Then
                    Return m_DataDocumentoRange.ToString()
                Else
                    Return ""
                End If

            End Get
        End Property


        Public ReadOnly Property DataRegistrazioneRange() As String
            Get
                If Me.m_DataRegistrazioneRangeSelected Then
                    Return m_DataRegistrazioneRange.ToString()
                Else
                    Return ""
                End If

            End Get
        End Property


        Public ReadOnly Property DataEventoRange() As String
            Get
                If m_DataEventoRangeSelected Then
                    Return m_DataEventoRange.ToString()
                Else
                    Return ""
                End If

            End Get
        End Property

        Public ReadOnly Property ValiditaRange() As String
            Get
                If m_ValiditaRangeSelected Then
                    Return m_ValiditaRange.ToString()
                Else
                    Return ""
                End If

            End Get
        End Property

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


        Public ReadOnly Property Avvocato() As String
            Get
                Return m_Avvocato
            End Get
        End Property

        Public Sub SetIdAvvocato(ByVal Id As String)
            If Not IsNumeric(Id) Then Id = -1
            m_IdAvvocato = Id
            If Id = -1 Then
                m_Avvocato = ""
                Exit Sub
            End If
            Dim cont As New ControllerAvvocati
            cont.LoadById(Id)
            m_Avvocato = cont.Descrizione
            cont = Nothing
        End Sub


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




        Public Sub SetValiditaRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_ValiditaRange = New DataRange(Inizio, Fine)
        End Sub

        Public Sub SetDataEventoRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_DataEventoRange = New DataRange(Inizio, Fine)
        End Sub

        Public Sub SetDataRegistrazioneRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_DataRegistrazioneRange = New DataRange(Inizio, Fine)
        End Sub
        Public Sub SetDataDocumentoRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_DataDocumentoRange = New DataRange(Inizio, Fine)
        End Sub

        Public Sub SetUtente(ByVal IdUtente As String)
            Dim cont As New WIN.APPLICATION.UTENTI.ControllerUtenti
            If IdUtente = "" Then IdUtente = "-1"
            If Not IsNumeric(IdUtente) Then Throw New ArgumentException("Valore id utente non valido", "IdUtente")
            Dim ut As Utente = cont.GetUtenteById(IdUtente)
            m_IdUtente = ut.Id
            cont = Nothing
        End Sub


        ''' <summary>
        ''' Metodo che imposta i criteri di ricerca per la ricerca delle  vertenze
        ''' </summary>
        ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
        ''' ----"IntervalloRegistrazione" (Per includere la ricerca alle vertenze del tipo selezionato con data registrazione compresa in un intervallo specificato)
        ''' ----"IntervalloDocumento" (Per includere la ricerca alle vertenze del tipo selezionato con data documento compresa in un intervallo specificato)
        ''' ----"Utente" (Per includere la ricerca alle vertenze del tipo selezionato per per l'utente con l' id indicato)
        ''' ----"IntervalloEvento" (Per includere  la ricerca alle vertenze con eventi aventi data evento compresa in un intervallo specificato)
        ''' ----"IntervalloValidita" (Per includere  la ricerca alle vertenze aventi validità a cavallo di  un intervallo specificato)
        ''' ----"ListaAziende" (Per includere  la ricerca alle vertenze riferite alle aziende specificate nella lista)
        ''' ----"ListaUtenti" (Per includere  la ricerca alle vertenze riferite agli utenti specificati nella lista)
        ''' </param>
        ''' <remarks></remarks>
        Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
            m_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
            m_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
            m_UtenteSelected = IIf(ParameterMap("Utente") Is Nothing, False, ParameterMap("Utente"))

            If ParameterMap.Contains("IntervalloEvento") Then
                m_DataEventoRangeSelected = IIf(ParameterMap("IntervalloEvento") Is Nothing, False, ParameterMap("IntervalloEvento"))
            Else
                m_DataEventoRangeSelected = False
            End If


            If ParameterMap.Contains("IntervalloValidita") Then
                m_ValiditaRangeSelected = IIf(ParameterMap("IntervalloValidita") Is Nothing, False, ParameterMap("IntervalloValidita"))
            Else
                m_ValiditaRangeSelected = False
            End If


            If ParameterMap.Contains("ListaAziende") Then
                m_ListaAziendeSelected = IIf(ParameterMap("ListaAziende") Is Nothing, False, ParameterMap("ListaAziende"))
            Else
                m_ListaAziendeSelected = False
            End If



            If ParameterMap.Contains("ListaUtenti") Then
                m_ListaUtentiSelected = IIf(ParameterMap("ListaUtenti") Is Nothing, False, ParameterMap("ListaUtenti"))
            Else
                m_ListaUtentiSelected = False
            End If

        End Sub


        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperVertenza")
            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            If m_Vertenzachiusa = VertenzaSearchType.Closed Then
                mainCriteria.AddCriteria(Criteria.Equal("VertenzaChiusa", "1"))
            ElseIf m_Vertenzachiusa = VertenzaSearchType.Opened Then
                mainCriteria.AddCriteria(Criteria.Equal("VertenzaChiusa", "0"))
            End If

            If m_ListaUtentiSelected Then
                Dim CompositeListaUtenti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                If m_ListaUtenti.Count > 0 Then
                    For Each elem As String In m_ListaUtenti
                        CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
                    Next
                    If m_UtenteSelected Then
                        CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
                    End If
                    mainCriteria.AddCriteria(CompositeListaUtenti)
                Else
                    If m_UtenteSelected Then
                        mainCriteria.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
                    End If
                End If
            Else
                If m_UtenteSelected Then
                    mainCriteria.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
                End If
            End If


            If m_ListaAziendeSelected Then
                Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                If m_ListaAziende.Count > 0 Then
                    For Each elem As String In m_ListaAziende
                        CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_AZIENDA", elem))
                    Next
                    mainCriteria.AddCriteria(CompositeListaSoggetti)
                End If
            End If


            If m_IdReferente <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
            End If


            If m_IdResponsabile <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_RUP", m_IdResponsabile))
            End If


            If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
            End If

            If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
            End If

            If m_ValiditaRangeSelected And Not m_ValiditaRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO", "DATA_FINE", m_ValiditaRange.Start, m_ValiditaRange.Finish, ps.DBType))
            End If




            'If (m_DataEventoRangeSelected And Not m_DataEventoRange.IsEmpty) Or m_EnteInoltro <> "" Or m_IdTipoEvento <> -1 Or m_Avvocato <> "" Or m_Intervento <> "" Then
            '   Dim mainSubCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

            '   If m_DataEventoRangeSelected And Not m_DataEventoRange.IsEmpty Then
            '      mainSubCriteria.AddCriteria(New DateContainedCriteria("DATA_EVENTO", m_DataEventoRange.Start, m_DataEventoRange.Finish, ps.DBType))
            '   End If

            '   If m_EnteInoltro <> "" Then
            '      mainSubCriteria.AddCriteria(Criteria.Matches("ENTE_INOLTRO", m_EnteInoltro, ps.DBType))
            '   End If

            '   If m_Intervento <> "" Then
            '      mainSubCriteria.AddCriteria(Criteria.Matches("INTERVENTO", m_Intervento, ps.DBType))
            '   End If


            '   If m_Avvocato <> "" Then
            '      mainSubCriteria.AddCriteria(Criteria.Matches("AVVOCATO", m_Avvocato, ps.DBType))
            '   End If

            '   If m_IdTipoEvento <> -1 Then
            '      mainSubCriteria.AddCriteria(Criteria.Equal("TIPO_EVENTO", m_IdTipoEvento))
            '   End If


            '   Dim subqry As New SubQueryCriteria("DB_EVENTI", "ID_VERTENZA", True)
            '   subqry.AddCriteria(mainSubCriteria)

            '   mainCriteria.AddCriteria(Criteria.INClause("ID", subqry))

            'End If




            Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
            orderCriteria.AddCriteria(Criteria.SortCriteria("ID_UTENTE", True))



            query.AddWhereClause(mainCriteria)

            query.AddOrderByClause(orderCriteria)

            Dim ss As String = query.CreateQuery(ps)

            'Dim start As DateTime = Now
            'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
            Dim list As IList = query.Execute(ps)

            m_Results = list
            m_SearchResult = list

            m_NumeroRecord = list.Count
            Return list

        End Function



        Public Function SearchDTOs() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperVertenzaDTO")
            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            If m_Vertenzachiusa = VertenzaSearchType.Closed Then
                mainCriteria.AddCriteria(Criteria.Equal("VertenzaChiusa", "1"))
            ElseIf m_Vertenzachiusa = VertenzaSearchType.Opened Then
                mainCriteria.AddCriteria(Criteria.Equal("VertenzaChiusa", "0"))
            End If

            If m_ListaUtentiSelected Then
                Dim CompositeListaUtenti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                If m_ListaUtenti.Count > 0 Then
                    For Each elem As String In m_ListaUtenti
                        CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
                    Next
                    If m_UtenteSelected Then
                        CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
                    End If
                    mainCriteria.AddCriteria(CompositeListaUtenti)
                Else
                    If m_UtenteSelected Then
                        mainCriteria.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
                    End If
                End If
            Else
                If m_UtenteSelected Then
                    mainCriteria.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
                End If
            End If


            If m_ListaAziendeSelected Then
                Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                If m_ListaAziende.Count > 0 Then
                    For Each elem As String In m_ListaAziende
                        CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_AZIENDA", elem))
                    Next
                    mainCriteria.AddCriteria(CompositeListaSoggetti)
                End If
            End If


            If m_IdReferente <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
            End If


            If m_IdResponsabile <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_RUP", m_IdResponsabile))
            End If

            If m_IdAvvocato <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_AVVOCATO", m_IdAvvocato))
            End If


            If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
            End If

            If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
            End If

            If m_ValiditaRangeSelected And Not m_ValiditaRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO", "DATA_FINE", m_ValiditaRange.Start, m_ValiditaRange.Finish, ps.DBType))
            End If




            If (m_DataEventoRangeSelected And Not m_DataEventoRange.IsEmpty) Or m_EnteInoltro <> "" Or m_IdTipoEvento <> -1 Or m_Intervento <> "" Then
                Dim mainSubCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

                If m_DataEventoRangeSelected And Not m_DataEventoRange.IsEmpty Then
                    mainSubCriteria.AddCriteria(New DateContainedCriteria("DATA_EVENTO", m_DataEventoRange.Start, m_DataEventoRange.Finish, ps.DBType))
                End If

                If m_EnteInoltro <> "" Then
                    mainSubCriteria.AddCriteria(Criteria.Matches("ENTE_INOLTRO", m_EnteInoltro, ps.DBType))
                End If

                If m_Intervento <> "" Then
                    mainSubCriteria.AddCriteria(Criteria.Matches("INTERVENTO", m_Intervento, ps.DBType))
                End If


                'If m_Avvocato <> "" Then
                '   mainSubCriteria.AddCriteria(Criteria.Matches("AVVOCATO", m_Avvocato, ps.DBType))
                'End If

                If m_IdTipoEvento <> -1 Then
                    mainSubCriteria.AddCriteria(Criteria.Equal("TIPO_EVENTO", m_IdTipoEvento))
                End If


                Dim subqry As New SubQueryCriteria("DB_EVENTI", "ID_VERTENZA", True)
                subqry.AddCriteria(mainSubCriteria)

                mainCriteria.AddCriteria(Criteria.INClause("ID", subqry))

            End If




            Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
            orderCriteria.AddCriteria(Criteria.SortCriteria("ID_UTENTE", True))



            query.AddWhereClause(mainCriteria)

            query.AddOrderByClause(orderCriteria)

            Dim ss As String = query.CreateQuery(ps)

            'Dim start As DateTime = Now
            'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
            Dim list As IList = query.Execute(ps)

            m_Results = list
            m_SearchResult = list

            m_NumeroRecord = list.Count
            Return list

        End Function


    End Class
End Namespace
