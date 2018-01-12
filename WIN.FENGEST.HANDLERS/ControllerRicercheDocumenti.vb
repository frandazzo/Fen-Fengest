Namespace FINANCIAL_ARTIFACTS
    Public Class ControllerRicercheDocumenti
        Inherits AbstractControllerRicerche

        'Variabili per l'abilitazione alla ricerca
        Protected m_DataRegistrazioneRangeSelected As Boolean = False
        Protected m_DataDocumentoRangeSelected As Boolean = False





        Protected m_DataRegistrazioneRange As DataRange = DataRange.Empty
        Protected m_DataDocumentoRange As DataRange = DataRange.Empty
        Protected m_TipoDoc As String = "IQA"


        Public Sub SetTipoDocumento(ByVal TipoDocumento As String)
            m_TipoDoc = TipoDocumento
        End Sub

        Public Sub SetDataRegistrazioneRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_DataRegistrazioneRange = New DataRange(Inizio, Fine)
        End Sub
        Public Sub SetDataDocumentoRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            m_DataDocumentoRange = New DataRange(Inizio, Fine)
        End Sub

        ''' <summary>
        ''' Metodo che imposta i criteri di ricerca per i documenti
        ''' </summary>
        ''' <param name="ParameterMap">Le chiavi ammesse per includere i criteri di filtro sono:
        ''' ----"IntervalloRegistrazione" (Per includere la ricerca ai documenti del tipo selezionato con data registrazione compresa in un intervallo specificato)
        ''' ----"IntervalloDocumento" (Per includere la ricerca ai documenti del tipo selezionato con data documento compresa in un intervallo specificato)
        '''</param>
        ''' <remarks></remarks>
        Public Sub SetNewSerchConditions(ByVal ParameterMap As Hashtable)
            m_DataRegistrazioneRangeSelected = IIf(ParameterMap("IntervalloRegistrazione") Is Nothing, False, ParameterMap("IntervalloRegistrazione"))
            m_DataDocumentoRangeSelected = IIf(ParameterMap("IntervalloDocumento") Is Nothing, False, ParameterMap("IntervalloDocumento"))
        End Sub

        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery(SelectMapperName(m_TipoDoc))
            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            If m_DataRegistrazioneRangeSelected And Not m_DataRegistrazioneRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_REGISTRAZIONE", m_DataRegistrazioneRange.Start, m_DataRegistrazioneRange.Finish, ps.DBType))
            End If

            If m_DataDocumentoRangeSelected And Not m_DataDocumentoRange.IsEmpty Then
                mainCriteria.AddCriteria(New DateContainedCriteria("DATA_DOCUMENTO", m_DataDocumentoRange.Start, m_DataDocumentoRange.Finish, ps.DBType))
            End If


            mainCriteria.AddCriteria(Criteria.Matches("TIPO_DOCUMENTO", m_TipoDoc, ps.DBType))


            query.AddWhereClause(mainCriteria)

            Return query.Execute(ps)
        End Function

        Private Function SelectMapperName(ByVal TipoDocumento As String) As String
            Select Case TipoDocumento
                Case "IQA"
                    Return "MapperIncassoQuotaAssociativa"
                Case "IQP"
                    Return "MapperIncassoQuotaPrevisionale"
                Case "IQI"
                    Return "MapperIncassoQuotaInps"
                Case "IQV"
                    Return "MapperIncassoQuotaVertenza"
                Case "PGR"
                    Return "MapperPagamentoReferenti"
                Case Else
                    Throw New ArgumentException("Tipo Documento errato")
            End Select
        End Function
    End Class
End Namespace