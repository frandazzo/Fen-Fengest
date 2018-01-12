Namespace ADMINISTRATION
   Public Class ControllerricerchePrestazioniInps
      Inherits AbstractControllerRicerche

      'Variabili per l'abilitazione alla ricerca
        Protected m_DataRegistrazioneRangeSelected As Boolean = False
        Protected m_DataDocumentoRangeSelected As Boolean = False
        Protected m_ListaUtentiSelected As Boolean = False
        Protected m_ResidenzaSelected As Boolean = False

        Protected m_DataRegistrazioneRange As DateTime
        Protected m_DataDocumentoRange As DateTime
        Protected m_ListaUtenti As New ArrayList
        Private m_listaNomiUtenti As New ArrayList

        Protected m_IdTipoPrestazione As Int32 = -1
        Protected m_NomeTipoPrestazione As String = ""

        Protected m_IdReferente As Int32 = -1
        Protected m_NomeReferente As String = ""

        Protected m_IdComune As Int32 = -1
        Protected m_NomeComune As String = ""
        Protected m_NumeroRecord As Int32

      'Public Sub SetListaUtenti(ByVal Lista As ArrayList)
      '   m_ListaUtenti = Lista
      'End Sub
      Public ReadOnly Property NomeReferente() As String
         Get
            Return m_NomeReferente
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

      Public ReadOnly Property ListaNomiUtenti() As IList
         Get
            Return m_listaNomiUtenti
         End Get
      End Property


        Public Sub SetDataRegistrazioneRange(ByVal Inizio As DateTime)
            m_DataRegistrazioneRange = Inizio
        End Sub
        Public Sub SetDataDocumentoRange(ByVal finoA As DateTime)
            m_DataDocumentoRange = finoA
        End Sub
      Public Sub SetTipoPrestazione(ByVal NomeTipoPrestazione As String)
         If NomeTipoPrestazione = "" Then
            m_IdTipoPrestazione = -1
            m_NomeTipoPrestazione = ""
            Return
         End If

         Dim controllerPrest As New ADMINISTRATION.ControllerTipoPrestazione
         m_IdTipoPrestazione = controllerPrest.GetIdTipoPrestazioneByDescrizione(NomeTipoPrestazione)
         m_NomeTipoPrestazione = NomeTipoPrestazione
      End Sub
      Public Sub SetComune(ByVal NomeComune As String)
            Dim com As Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
         m_IdComune = com.Id
      End Sub


      Public ReadOnly Property NumeroPosizioni() As String
         Get
            Return m_NumeroRecord
         End Get
      End Property


      Public ReadOnly Property NomeComune() As String
         Get
            Return m_NomeComune
         End Get
      End Property
      Public ReadOnly Property NomeTipoPrestazione() As String
         Get
            Return m_NomeTipoPrestazione
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
      Public ReadOnly Property DataRegistrazioneRange() As String
         Get
            If Me.m_DataRegistrazioneRangeSelected Then
               Return Me.m_DataRegistrazioneRange.ToString
            Else
               Return ""
            End If
         End Get
      End Property



      ''' <summary>
      ''' Metodo che imposta i criteri di ricerca per la ricerca delle prestazioni Inps
      ''' </summary>
      ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
      ''' ----"IntervalloRegistrazione" (Per includere la ricerca alle prestazioni del tipo selezionato con data registrazione compresa in un intervallo specificato)
      ''' ----"IntervalloDocumento" (Per includere la ricerca alle prestazioni del tipo selezionato con data documento compresa in un intervallo specificato)
      ''' ----"ListaUtenti" (Per includere la ricerca alle prestazioni del tipo selezionato per per gli utenti con gli id indicati)
      ''' ----"Residenza" (Per includere la ricerca alle prestazioni del tipo selezionato per per gli utenti con  residenza indicata)
      ''' </param>
      ''' <remarks></remarks>
      Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
         m_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
         m_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
         m_ListaUtentiSelected = IIf(ParameterMap("ListaUtenti") Is Nothing, False, ParameterMap("ListaUtenti"))
         m_ResidenzaSelected = IIf(ParameterMap("Residenza") Is Nothing, False, ParameterMap("Residenza"))
      End Sub


      Public Overrides Function Search() As IList
         'qui creo ed eseguo la query
         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperPrestazione")
         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

         Dim SubQry As SubQueryCriteria
         If m_ResidenzaSelected Then
            SubQry = New SubQueryCriteria("DB_UTENTE", "ID")
            If m_IdComune > 0 Then
               SubQry.AddCriteria(Criteria.Equal("ID_TB_COMUNI_RESIDENZA", m_IdComune))
            Else
               SubQry.AddCriteria(Criteria.IsNull("ID_TB_COMUNI_RESIDENZA"))
            End If
            mainCriteria.AddCriteria(Criteria.INClause("ID_UTENTE", SubQry))
         End If

         If m_IdTipoPrestazione <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_PRESTAZIONE", m_IdTipoPrestazione.ToString))
         End If


         'mainCriteria.AddCriteria(Criteria.Equal("ID_TB_COMUNI", m_IdComune))

         'Dim CompositeCriteria As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            If m_DataRegistrazioneRangeSelected Then
                'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Finish, "MM/dd/yyyy") & "#")))
                'mainCriteria.AddCriteria(CompositeCriteria)
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange, New DateTime(3000, 1, 1), ps.DBType))
            End If

            If m_DataDocumentoRangeSelected Then
                'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Finish, "MM/dd/yyyy") & "#")))
                'mainCriteria.AddCriteria(CompositeCriteria)
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", New DateTime(1800, 1, 1), m_DataDocumentoRange, ps.DBType))
            End If


         If m_IdReferente <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
         End If

         If m_ListaUtentiSelected Then
            Dim CompositeListaUtenti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
            If m_ListaUtenti.Count > 0 Then
               For Each elem As String In m_ListaUtenti
                  CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
               Next
               mainCriteria.AddCriteria(CompositeListaUtenti)
            End If
         End If

         query.AddWhereClause(mainCriteria)
         m_Results = query.Execute(ps)
         m_NumeroRecord = m_Results.Count
         Return m_Results
      End Function
      Public Function SearchDTOs() As IList
         'qui creo ed eseguo la query
         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperPrestazioneDTO")
         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

         Dim SubQry As SubQueryCriteria
         If m_ResidenzaSelected Then
            SubQry = New SubQueryCriteria("DB_UTENTE", "ID")
            If m_IdComune > 0 Then
               SubQry.AddCriteria(Criteria.Equal("ID_TB_COMUNI_RESIDENZA", m_IdComune))
            Else
               SubQry.AddCriteria(Criteria.IsNull("ID_TB_COMUNI_RESIDENZA"))
            End If
            mainCriteria.AddCriteria(Criteria.INClause("ID_UTENTE", SubQry))
         End If

         If m_IdTipoPrestazione <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_PRESTAZIONE", m_IdTipoPrestazione.ToString))
         End If


         'mainCriteria.AddCriteria(Criteria.Equal("ID_TB_COMUNI", m_IdComune))

         'Dim CompositeCriteria As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            If m_DataRegistrazioneRangeSelected Then
                'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_REGISTRAZIONE", "#" & Format(m_DataRegistrazioneRange.Finish, "MM/dd/yyyy") & "#")))
                'mainCriteria.AddCriteria(CompositeCriteria)
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange, New DateTime(3000, 1, 1), ps.DBType))
            End If

            If m_DataDocumentoRangeSelected Then
                'CompositeCriteria.AddCriteria(New AndExp(Criteria.GreaterEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Start, "MM/dd/yyyy") & "#"), Criteria.LessEqualThan("DATA_DOCUMENTO", "#" & Format(m_DataDocumentoRange.Finish, "MM/dd/yyyy") & "#")))
                'mainCriteria.AddCriteria(CompositeCriteria)
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", New DateTime(1800, 1, 1), m_DataDocumentoRange, ps.DBType))
            End If


         If m_IdReferente <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente))
         End If

         If m_ListaUtentiSelected Then
            Dim CompositeListaUtenti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
            If m_ListaUtenti.Count > 0 Then
               For Each elem As String In m_ListaUtenti
                  CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
               Next
               mainCriteria.AddCriteria(CompositeListaUtenti)
            End If
         End If

         query.AddWhereClause(mainCriteria)
         m_Results = query.Execute(ps)
         m_NumeroRecord = m_Results.Count
         Return m_Results
      End Function

      Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

         If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
         DirectCast(m_Results, ArrayList).Sort(SortFactory.GetItemComparer(PropertyName, Descending, "PrestazioniDTO"))

      End Sub



   End Class
End Namespace