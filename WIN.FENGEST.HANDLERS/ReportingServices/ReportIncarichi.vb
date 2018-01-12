Imports WIN.APPLICATION.AZIENDE

Namespace REPORTING


    Public Class ReportIncarichi
        Inherits AbstractControllerRicerche

        'Variabili per l'abilitazione alla ricerca

        Protected m_IdTipoIncarico As Int32 = -1
        Protected m_NomeTipoIncarico As String = ""

        Protected m_IdAzienda As Int32 = -1
        Protected m_NomeAzienda As String = ""

        Protected m_SearchResult As New ArrayList






#Region "Proprietà risultati report"

        Public ReadOnly Property SearchResult() As IList
            Get
                Return m_SearchResult
            End Get
        End Property

#End Region


#Region "Metodi per impostare i criteri di ricerca"

        Public Sub SetIdAzienda(ByVal IdAzienda As String)
            If IsNumeric(IdAzienda) Then
                m_IdAzienda = IdAzienda
                Dim az As New ControllerAziende
                az.LoadById(IdAzienda)
                m_NomeAzienda = az.Descrizione
            Else
                m_IdAzienda = -1
                m_NomeAzienda = ""
            End If
        End Sub

        Public Sub SetNomeAzienda(ByVal NomeAzienda As String)
            m_NomeAzienda = NomeAzienda
        End Sub


        'Public Sub SetIdTipoIncarico(ByVal IdTipoIncarico As String)
        '    m_IdTipoIncarico = IdTipoIncarico
        'End Sub

        Public Sub SetNomeTipoIncarico(ByVal NomeTipoIncarico As String)
            If Not String.IsNullOrEmpty(NomeTipoIncarico) Then
                m_NomeTipoIncarico = NomeTipoIncarico

                Dim cc As New ControllerTipoIncarico
                Dim t As TipoIncarico = cc.GetCausaleIncarico(NomeTipoIncarico)

                m_IdTipoIncarico = t.Id

            Else
                m_NomeTipoIncarico = ""
                m_IdTipoIncarico = -1
            End If



        End Sub

#End Region

#Region "Proprietà per visualizzare i  criteri di selezione"

        Public ReadOnly Property NomeAzienda() As String
            Get
                Return m_NomeAzienda
            End Get
        End Property


        Public ReadOnly Property NomeTipoIncarico() As String
            Get
                Return m_NomeTipoIncarico
            End Get
        End Property

#End Region

#Region "Metodi per l'elaborazione del report"

        Public Overrides Function Search() As IList
            'qui creo ed eseguo la query

            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperIncaricoDTO")


            query.SetTable("DB_INCARICHI_VIEW")




            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


            If m_IdAzienda <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_AZIENDA", m_IdAzienda.ToString))
            End If
            If m_IdTipoIncarico <> -1 Then
                mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO", m_IdTipoIncarico.ToString))
            End If





            query.AddWhereClause(mainCriteria)


            m_SearchResult = query.Execute(ps)
            Return m_SearchResult

        End Function


#End Region
    End Class
End Namespace