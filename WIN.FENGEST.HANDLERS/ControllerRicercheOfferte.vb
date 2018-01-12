Public Class ControllerRicercheOfferte
   Inherits AbstractControllerRicerche


   Protected m_ValidityRangeSelected As Boolean = False
   Protected m_ValidityRange As DataRange = DataRange.Empty

   Protected m_DateSelected As Boolean = False
   Protected m_Data As DateTime

   Protected m_Skill As String = ""
   Protected _IdOfferta As String = ""

   Protected m_IdAzienda As String = "-1"
   Protected m_IdSkill As String = "-1"



   Public Sub SetValidityRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
      m_ValidityRange = New DataRange(Inizio, Fine)
   End Sub

   Public Sub SetData(ByVal Data As DateTime)
      m_Data = Data.Date
   End Sub
   Public Sub SetIdAzienda(ByVal idAzienda As String)
      If idAzienda = "" Then
         m_IdAzienda = "-1"
         Return
      End If
      m_IdAzienda = idAzienda
   End Sub


   Public Sub SetIdSkill(ByVal IdSkill As String)
      If IdSkill = "" Then
         m_IdSkill = "-1"
         Return
      End If
      m_IdSkill = IdSkill
   End Sub

   Public Sub SetSkill(ByVal Skill As String)
      m_Skill = Skill
   End Sub

   Public Sub SetIdOfferta(ByVal Skill As String)
      m_Skill = Skill
   End Sub

   ''' <summary>
   ''' Metodo che imposta i criteri di ricerca 
   ''' </summary>
   ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
   ''' ----"IntervalloDate" (Per includere la ricerca alle offerte con data validita compresa in un intervallo specificato)
   ''' ----"Data" (Per includere la ricerca alle offerte con eseguite ad una certa data)
   '''</param>
   ''' <remarks></remarks>
   Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
      m_ValidityRangeSelected = IIf(ParameterMap("IntervalloDate") Is Nothing, False, ParameterMap("IntervalloDate"))
      m_DateSelected = IIf(ParameterMap("Data") Is Nothing, False, ParameterMap("Data"))
   End Sub


   Public ReadOnly Property GetValidityRange() As String
      Get
         Return m_ValidityRange.Start.ToString() + " - " + m_ValidityRange.Finish.ToString()
      End Get
   End Property


   Public ReadOnly Property GetData() As String
      Get
         Return m_Data
      End Get
   End Property

   Public ReadOnly Property GetIdAzienda() As String
      Get
         Return m_IdAzienda
      End Get
   End Property



   Public ReadOnly Property GetPreferenzaSkill() As String
      Get
         Return m_Skill
      End Get
   End Property

   Public ReadOnly Property GetSearchResult() As IList
      Get
         Return m_Results
      End Get
   End Property






   Public Overrides Function Search() As IList
      'qui creo ed eseguo la query
      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      Dim query As Query = ps.CreateNewQuery("MapperOffertaLavoro")

      query.SetTable("DB_OFFERTA_LAVORO")
      query.SetMaxNumberOfReturnedRecords(m_Top)


      Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


      If m_DateSelected Then
         mainCriteria.AddCriteria(New DateContainedCriteria("DATA_OFFERTA", m_Data, m_Data, ps.DBType))
      End If

      If m_ValidityRangeSelected And Not m_ValidityRange.IsEmpty Then
         mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO", "DATA_FINE", m_ValidityRange.Start, m_ValidityRange.Finish, ps.DBType))
      End If


      If m_IdAzienda <> "" And m_IdAzienda <> "-1" Then
         mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda))
      End If


      If m_IdSkill <> "" And m_IdSkill <> "-1" Then
         Dim subCriteria As AbstractBoolCriteria = Criteria.Equal("ID_ABILITA", m_IdSkill)

         Dim subqry As New SubQueryCriteria("DB_OFFERTA_LAVORO_ITEM", "ID_OFFERTA_LAVORO")
         subqry.AddCriteria(subCriteria)

         mainCriteria.AddCriteria(Criteria.INClause("ID", subqry))
      End If


      Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
      orderCriteria.AddCriteria(Criteria.SortCriteria("DATA_OFFERTA", True))

      query.AddOrderByClause(orderCriteria)

      query.AddWhereClause(mainCriteria)

      m_Results = query.Execute(ps)

      Return m_Results
   End Function

   Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

      If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")

      If TypeOf (m_Results) Is ArrayList Then
         DirectCast(m_Results, ArrayList).Sort(SortFactory.GetItemComparer(PropertyName, Descending, "OfferteLavoro"))

      Else
         DirectCast(m_Results, ArrayList).Sort(SortFactory.GetItemComparer(PropertyName, Descending, "OfferteLavoro"))


      End If
   End Sub


End Class
