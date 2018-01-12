Public Class ReportComunicazioni
   

    Protected m_DataRangeSelected As Boolean = False
    Private m_listaUtenti As New ArrayList

    Protected m_IdTipo As Int32 = -1
    Protected m_IdCausale As Int32 = -1
   

    Protected m_ListaUtentiSelected As Boolean = False
    Protected m_DataRange As DataRange = DataRange.Empty

    Public Sub SetListaUtenti(ByVal Lista As ArrayList)
        m_ListaUtenti = Lista
    End Sub

    Public Sub SetTipo(ByVal idTipo As Int32)

        m_IdTipo = idTipo

    End Sub

    Public Sub SetCausale(ByVal idCausale As Int32)

        m_IdCausale = idCausale

    End Sub

    Public Sub SetDataRangeSelected(include As Boolean)
        m_DataRangeSelected = include
    End Sub
    Public Sub SetListUtentiSelected(include As Boolean)
        m_ListaUtentiSelected = include
    End Sub
    Public Sub SetDataRange(ByVal Inizio As DateTime, ByVal Fine As DateTime)
        m_DataRange = New DataRange(Inizio, Fine)
    End Sub



    Private m_result As IList
    Public ReadOnly Property Result As IList
        Get
            Return m_result
        End Get
    End Property

    Public Function Search() As IList
        'qui creo ed eseguo la query
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        Dim query As Query = ps.CreateNewQuery("MapperComunicazione")
        Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
       
        'Dim subStateDelegaCriteriaAdded As Boolean = False

        If m_DataRangeSelected And Not m_DataRange.IsEmpty Then
            mainCriteria.AddCriteria(New DateContainedCriteria("Data_Comunicazione", m_DataRange.Start, m_DataRange.Finish, ps.DBType))
        End If

        If m_IdTipo <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO", m_IdTipo))
        End If

        If m_IdCausale <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_CAUSALE", m_IdCausale))
        End If



        If m_ListaUtentiSelected Then
            Dim CompositeListaUtenti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
            If m_listaUtenti.Count > 0 Then
                For Each elem As String In m_listaUtenti
                    CompositeListaUtenti.AddCriteria(Criteria.Equal("ID_UTENTE", elem))
                Next
                mainCriteria.AddCriteria(CompositeListaUtenti)
            End If
        End If


       


        Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
        orderCriteria.AddCriteria(Criteria.SortCriteria("Data_Comunicazione", True))



        query.AddWhereClause(mainCriteria)

        query.AddOrderByClause(orderCriteria)

        m_result = query.Execute(ps)
        
        Return Result



    End Function

   

End Class
