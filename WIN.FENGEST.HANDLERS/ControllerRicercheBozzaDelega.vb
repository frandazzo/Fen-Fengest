Imports System.ComponentModel

Namespace REPORTING
    Public Class ControllerRicercheBozzaDelega
        Inherits AbstractControllerRicerche

        'Variabili per l'abilitazione alla ricerca



        Protected m_IdReferente As Int32 = -1
        Protected m_IdUtente As Int32 = -1
        Protected m_ente As String = ""

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


        Public Sub SetIdUtente(ByVal IdUtente As String)
            If IsNumeric(IdUtente) Then
                m_IdUtente = IdUtente
            Else
                m_IdUtente = -1
            End If
        End Sub





        Public Sub SetCompetenza(ByVal Inizio As DateTime, ByVal Fine As DateTime)
            Dim range As DataRange = New DataRange(Inizio, Fine)
            m_Competenza = range
        End Sub


#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"






#End Region

#Region "Metodi per l'elaborazione del report"

        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query

            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperBozzaDelega")




            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            If m_IdReferente <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_REFERENTE", m_IdReferente.ToString))
            End If
            If m_IdUtente <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_UTENTE", m_IdUtente.ToString))
            End If
            If m_ente <> "" Then
                mainCriteria.AddCriteria(Criteria.MatchesEqual("ENTE", m_ente, ps.DBType))
            End If

            mainCriteria.AddCriteria(New DateContainedCriteria("DATA", m_Competenza.Start, m_Competenza.Finish.AddDays(1), ps.DBType))



            query.AddWhereClause(mainCriteria)


            m_SearchResult = query.Execute(ps)
            Return m_SearchResult

        End Function
        Public Function SearchAsBindingList() As IBindingList
            'qui creo ed eseguo la query


            Search()

            Dim lll As New BindingList(Of BozzaDelega)

            For Each elem As BozzaDelega In m_SearchResult
                lll.Add(elem)
            Next


            Return lll

        End Function

#End Region

        Sub SetEnte(ente As String)
            m_ente = ente
        End Sub

    End Class
End Namespace

