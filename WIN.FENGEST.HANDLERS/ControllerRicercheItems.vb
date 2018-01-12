Namespace FINANCIAL_ARTIFACTS


   Public Class ControllerRicercheItems
      Inherits AbstractControllerRicerche

      'Variabili per l'abilitazione alla ricerca
      'Protected m_IncludiQuoteAssociative As Boolean
      Protected m_DataRegistrazioneRangeSelected As Boolean = False
      Protected m_DataDocumentoRangeSelected As Boolean = False
      Protected m_ListaSoggettiEsecutoriSelected As Boolean = False
      Protected m_CompetenzaQuoteSelected As Boolean = False



      Protected m_CompetenzaIncassiQuote As DataRange = DataRange.Empty
      Protected m_DataRegistrazioneRange As DataRange = DataRange.Empty
      Protected m_DataDocumentoRange As DataRange = DataRange.Empty
      Protected m_ListaSoggettiEsecutori As New ArrayList
      Protected m_IdReferente As Int32 = -1
      Protected m_TipoDoc As String = "IQA"

      Public Sub SetListaSoggettiEsecutori(ByVal Lista As ArrayList)
         m_ListaSoggettiEsecutori = Lista
      End Sub
      Public ReadOnly Property CompetenzaIncassiQuote() As String
         Get
            Return m_CompetenzaIncassiQuote.ToString
         End Get
      End Property
      Public Sub SetDataRegistrazioneRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataRegistrazioneRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetDataDocumentoRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_DataDocumentoRange = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetCompetenzaIncassiQuote(ByVal Inizio As DateTime, ByVal Fine As DateTime)
         m_CompetenzaIncassiQuote = New DataRange(Inizio, Fine)
      End Sub
      Public Sub SetTipoDocumento(ByVal TipoDocumento As String)
         m_TipoDoc = TipoDocumento
      End Sub
      ''' <summary>
      ''' Metodo che imposta i criteri di ricerca per le posizioni di incasso
      ''' </summary>
      ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
      ''' ----"IntervalloRegistrazione" (Per includere la ricerca ai documenti del tipo selezionato con data registrazione compresa in un intervallo specificato)
      ''' ----"IntervalloDocumento" (Per includere la ricerca ai documenti del tipo selezionato con data documento compresa in un intervallo specificato)
      ''' ----"ListaSoggetti" (Per includere la ricerca ai documenti del tipo selezionato per i soggettiesecutori con gli id indicati)
      ''' ----"CompetenzeQuote" (Per includere la ricerca ai documenti del tipo selezionato con le competenze sovrapposte a quella indicata)</param>
      ''' <remarks></remarks>
      Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
         'm_IncludiQuoteAssociative = IIf(ParameterMap("QuoteAssociative") Is Nothing, False, ParameterMap("QuoteAssociative"))
         m_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
         m_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
         m_ListaSoggettiEsecutoriSelected = IIf(ParameterMap("ListaSoggetti") Is Nothing, False, ParameterMap("ListaSoggetti"))
         m_CompetenzaQuoteSelected = IIf(ParameterMap("CompetenzaQuote") Is Nothing, False, ParameterMap("CompetenzaQuote"))
      End Sub
      Public Sub SetReferenteId(ByVal Id As Int32)
         m_IdReferente = Id
      End Sub

      Public Overrides Function Search() As IList
         'qui creo ed eseguo la query
         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperItemDocumentoContabile")
         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
         mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente.ToString))
         mainCriteria.AddCriteria(New AndExp(Criteria.Equal("TIPO_DOCUMENTO_CONTABILE", "'" & m_TipoDoc & "'"), Criteria.IsNull("ID_PAGAMENTO_REFERENTE")))

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

         If m_TipoDoc = "IQA" Then
            If m_ListaSoggettiEsecutoriSelected Then
               Dim CompositeListaSoggetti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
               If m_ListaSoggettiEsecutori.Count > 0 Then
                  For Each elem As String In m_ListaSoggettiEsecutori
                     CompositeListaSoggetti.AddCriteria(Criteria.Equal("ID_AZIENDA", elem))
                  Next
                  mainCriteria.AddCriteria(CompositeListaSoggetti)
               End If
            End If
         End If

         If m_CompetenzaQuoteSelected And Not m_CompetenzaIncassiQuote.IsEmpty Then
            mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", m_CompetenzaIncassiQuote.Start, m_CompetenzaIncassiQuote.Finish, ps.DBType))
         End If

         query.AddWhereClause(mainCriteria)

         Return New VirtualLazyList(query.Execute(ps))
      End Function
   End Class
End Namespace