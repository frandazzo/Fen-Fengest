Namespace REPORTING


    Public Class ReportArchivioDocumenti
        Inherits AbstractControllerRicerche

        'Variabili per l'abilitazione alla ricerca

        Protected m_TipoReport As String = "Utente"

        Protected m_IdTipoDocumento As Int32 = -1
        Protected m_NomeTipoDocumento As String = ""

        Protected m_IdReferente As Int32 = -1
        Protected m_NomeReferente As String = ""

        Protected m_Competenza As DataRange = DataRange.Empty

        Protected m_SearchResult As New ArrayList






#Region "Proprietà risultati report"

        Public ReadOnly Property SearchResult() As IList
            Get
                Return m_SearchResult
            End Get
        End Property

#End Region

      
#Region "Metodi per impostare i criteri di ricerca"

        Public Sub SetIdReferente(ByVal IdReferente As String)
            If IsNumeric(IdReferente) Then
                m_IdReferente = IdReferente
            Else
                m_IdReferente = -1
            End If
        End Sub

        Public Sub SetNomeReferente(ByVal NomeReferente As String)
            m_NomeReferente = NomeReferente
        End Sub


        Public Sub SetIdTipoDocumento(ByVal IdTipoDocumento As String)
            m_IdTipoDocumento = IdTipoDocumento
        End Sub

        Public Sub SetNomeTipoDocumento(ByVal NomeTipoDocumento As String)
            If Not String.IsNullOrEmpty(NomeTipoDocumento) Then
                m_NomeTipoDocumento = NomeTipoDocumento

                Dim cc As New ControllerTipoDocumentazione
                Dim t As TipoDocumentazione = cc.GetCausaleDocumentazione(NomeTipoDocumento)

                m_IdTipoDocumento = t.Id

            Else
                m_NomeTipoDocumento = ""
                m_IdTipoDocumento = -1
            End If

         

        End Sub

        Public Sub SetCompetenza(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            Dim range As DataRange = New DataRange(Inizio, Fine)
            m_Competenza = range
        End Sub

        Public Sub SetTipoRicerca(tipo As String)
            If tipo = "Utente" Then
                m_TipoReport = tipo
            Else
                m_TipoReport = "Azienda"
            End If
        End Sub

#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"

        Public ReadOnly Property NomeReferente() As String
            Get
                Return m_NomeReferente
            End Get
        End Property

     
        Public ReadOnly Property NomeTipoDocumento() As String
            Get
                Return m_NomeTipoDocumento
            End Get
        End Property
        Public ReadOnly Property CompetenzaRange() As String
            Get
                Return Me.m_Competenza.ToString
            End Get
        End Property
        Public ReadOnly Property TipoReport() As String
            Get
                Return m_TipoReport
            End Get
        End Property
#End Region

#Region "Metodi per l'elaborazione del report"

        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query

            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperElectronicDocumentDTO")

            If m_TipoReport = "Utente" Then
                query.SetTable("DB_DOCUMENTI_UTENTE_VIEW")
            Else
                query.SetTable("DB_DOCUMENTI_AZIENDA_VIEW")
            End If



            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
           

            If m_IdReferente <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ExecutorId", m_IdReferente.ToString))
            End If
            If m_IdTipoDocumento <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("DocumentTypeId", m_IdTipoDocumento.ToString))
            End If


            mainCriteria.AddCriteria(New DateContainedCriteria("DATA", m_Competenza.Start, m_Competenza.Finish, ps.DBType))



            query.AddWhereClause(mainCriteria)


            m_SearchResult = query.Execute(ps)
            Return m_SearchResult

        End Function


#End Region
    End Class
End Namespace

