Namespace UTENTI
   Public Class ControllerRicercheUtenti
        Inherits AbstractControllerRicerche


        Protected m_DataNascitaRangeSelected As Boolean = False
        Protected m_DataNascitaRange As DataRange = DataRange.Empty

        Protected m_Nome As String = ""
        Protected m_Cognome As String = ""
        Protected m_CF As String = ""
        Protected m_Provincia As String = "-1"
        Protected m_Comune As String = "-1"
        Protected m_ProvinciaNascita As String = "-1"
        Protected m_ComuneNascita As String = "-1"
        Protected m_Nazione As String = "-1"
        Protected m_Cell1 As String = ""
        Protected m_Cell2 As String = ""

        Protected m_IdSkillPreferenza As String = "-1"
        Protected m_SkillPreferenza As String = ""
        Protected m_onlyCfNull As Boolean = False
        Protected m_AddressNull As Boolean = False


        Public Sub Setm_AddressNull(ByVal AddressNull As Boolean)
            m_AddressNull = AddressNull
        End Sub

        Public Sub SetOnlyFiscalCodeNull(ByVal onlyNull As Boolean)
            m_onlyCfNull = onlyNull
        End Sub

        Public Sub SetDataNascitaRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_DataNascitaRange = New DataRange(Inizio, Fine)
        End Sub
        Public Sub SetNome(ByVal Nome As String)
            m_Nome = Nome
        End Sub
        Public Sub SetCognome(ByVal Cognome As String)
            m_Cognome = Cognome
        End Sub
        Public Sub SetCodiceFiscale(ByVal CodiceFiscale As String)
            m_CF = CodiceFiscale
        End Sub

        Public Sub SetCell1(ByVal Cell1 As String)
            m_Cell1 = Cell1
        End Sub

        Public Sub SetCell2(ByVal Cell2 As String)
            m_Cell2 = Cell2
        End Sub

        Public Sub SetIdSkillPreferenza(ByVal IdSkillPreferenza As String)
            If IdSkillPreferenza = "" Then
                m_IdSkillPreferenza = "-1"
                Return
            End If
            m_IdSkillPreferenza = IdSkillPreferenza
        End Sub

        Public Sub SetSkillPreferenza(ByVal SkillPreferenza As String)
            m_SkillPreferenza = SkillPreferenza
        End Sub


        Public ReadOnly Property GetSkillPreferenza() As String
            Get
                Return m_SkillPreferenza
            End Get
        End Property

        Public ReadOnly Property GetSearchResult() As IList
            Get
                Return m_Results
            End Get
        End Property

        ''' <summary>
        ''' Metodo che imposta i criteri di ricerca per i documenti
        ''' </summary>
        ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
        ''' ----"IntervalloDate" (Per includere la ricerca agli utenti con data nascita compresa in un intervallo specificato)
        '''</param>
        ''' <remarks></remarks>
        Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
            m_DataNascitaRangeSelected = IIf(ParameterMap("IntervalloDate") Is Nothing, False, ParameterMap("IntervalloDate"))
        End Sub

        Public Sub SetProvincia(ByVal NomeProvincia As String)
            Dim Provincia As Provincia = GeoLocationFacade.Instance.GetGeoHandler.GetProvinciaByName(NomeProvincia)
            m_Provincia = Provincia.Id
        End Sub

        Public Sub SetNazione(ByVal NomeNazione As String)
            Dim Nazione As Nazione = GeoLocationFacade.Instance.GetGeoHandler.GetNazioneByName(NomeNazione)
            m_Nazione = Nazione.Id
        End Sub

        Public Sub SetComune(ByVal NomeComune As String)
            Dim Comune As Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
            m_Comune = Comune.Id
        End Sub
        Public Sub SetProvinciaNascita(ByVal NomeProvincia As String)
            Dim Provincia As Provincia = GeoLocationFacade.Instance.GetGeoHandler.GetProvinciaByName(NomeProvincia)
            m_ProvinciaNascita = Provincia.Id
        End Sub

        Public Sub SetComuneNascita(ByVal NomeComune As String)
            Dim Comune As Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
            m_ComuneNascita = Comune.Id
        End Sub
        Public Function SearchByFiscalCodes(fiscalCode As String) As IList
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperUtente")

            query.SetTable("DB_Utente")


            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            mainCriteria.AddCriteria(Criteria.MatchesEqual("CODICE_FISCALE", fiscalCode, ps.DBType))

            query.AddWhereClause(mainCriteria)

            Return query.Execute(ps)


        End Function


        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperUtente")

            query.SetTable("DB_Utente")
            query.SetMaxNumberOfReturnedRecords(m_Top)


            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

            If m_Nome <> "" Then
                mainCriteria.AddCriteria(Criteria.Matches("NOME", m_Nome, ps.DBType))
            End If

            If m_Cell1 <> "" Then
                mainCriteria.AddCriteria(Criteria.Matches("CELL1", m_Cell1, ps.DBType))
            End If

            If m_Cell2 <> "" Then
                mainCriteria.AddCriteria(Criteria.Matches("CELL2", m_Cell2, ps.DBType))
            End If

            If m_Nazione <> "-1" Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_TB_NAZIONI", m_Nazione))
            End If


            If m_DataNascitaRangeSelected And Not m_DataNascitaRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_NASCITA", m_DataNascitaRange.Start, m_DataNascitaRange.Finish, ps.DBType))
            End If


            If m_Cognome <> "" Then
                mainCriteria.AddCriteria(Criteria.Matches("COGNOME", m_Cognome, ps.DBType))
            End If

            If m_onlyCfNull Then
                Dim smallCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                smallCriteria.AddCriteria(Criteria.Equal("CODICE_FISCALE", "''"))
                smallCriteria.AddCriteria(Criteria.IsNull("CODICE_FISCALE"))
                mainCriteria.AddCriteria(smallCriteria)
            Else
                If m_CF <> "" Then
                    mainCriteria.AddCriteria(Criteria.Matches("CODICE_FISCALE", m_CF, ps.DBType))
                End If
            End If


            If m_AddressNull Then
                Dim smallCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
                smallCriteria.AddCriteria(Criteria.IsNull("ID_TB_COMUNI_RESIDENZA"))
                smallCriteria.AddCriteria(Criteria.Equal("INDIRIZZO", "''"))
                smallCriteria.AddCriteria(Criteria.IsNull("INDIRIZZO"))
                smallCriteria.AddCriteria(Criteria.IsNull("CAP"))
                smallCriteria.AddCriteria(Criteria.Equal("CAP", "''"))
                mainCriteria.AddCriteria(smallCriteria)
            Else
                If m_Provincia <> "-1" Then
                    mainCriteria.AddCriteria(Criteria.Equal("ID_TB_PROVINCIE_RESIDENZA", m_Provincia))
                End If

                If m_Comune <> "-1" Then
                    mainCriteria.AddCriteria(Criteria.Equal("ID_TB_COMUNI_RESIDENZA", m_Comune))
                End If
            End If





            If m_ProvinciaNascita <> "-1" Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_TB_PROVINCIE_NASCITA", m_ProvinciaNascita))
            End If

            If m_ComuneNascita <> "-1" Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_TB_COMUNI_NASCITA", m_ComuneNascita))
            End If


            If m_IdSkillPreferenza <> "" And m_IdSkillPreferenza <> "-1" Then
                Dim subCriteria As AbstractBoolCriteria = Criteria.Equal("ID_ABILITA", m_IdSkillPreferenza)

                Dim subqry As New SubQueryCriteria("DB_PREFERENZE", "ID_UTENTE")
                subqry.AddCriteria(subCriteria)

                mainCriteria.AddCriteria(Criteria.INClause("ID", subqry))
            End If

            Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
            orderCriteria.AddCriteria(Criteria.SortCriteria("COGNOME", True))



            query.AddOrderByClause(orderCriteria)

            query.AddWhereClause(mainCriteria)

            m_Results = query.Execute(ps)

            Return m_Results
        End Function




        Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            DirectCast(m_Results, ArrayList).Sort(SortFactory.GetItemComparer(PropertyName, Descending, "Utenti"))

        End Sub
    End Class
End Namespace