Public Class ReportPratiche
    Protected m_AperteSelected As Boolean = False
    Protected m_ControlloSelected As Boolean = False
    Protected m_ConfermaSelected As Boolean = False
    Protected m_IntegraSelected As Boolean = False
    Protected m_RigettateSelected As Boolean = False
    Protected m_ChiuseSelected As Boolean = False

    Protected m_DataRangeSelected As Boolean = False
    Private m_listaUtenti As New ArrayList

    Protected m_IdTipoPratica As Int32 = -1
    Protected m_IdInCaricoA As Int32 = -1
    Protected m_IdProp As Int32 = -1


    Protected m_ListaUtentiSelected As Boolean = False
    Protected m_DataRange As DataRange = DataRange.Empty

    Public Sub SetListaUtenti(ByVal Lista As ArrayList)
        m_ListaUtenti = Lista  
    End Sub

    Public Sub SetTipoPratica(ByVal idTipoPratica As Int32)

        m_IdTipoPratica = idTipoPratica

    End Sub

    Public Sub SetInCaricoA(ByVal idUser As Int32)

        m_IdInCaricoA = idUser

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

    Public Sub SetAperteSelected(ByVal include As Boolean)
        m_AperteSelected = include
    End Sub
    Public Sub SetControlloSelected(ByVal include As Boolean)
        m_ControlloSelected = include
    End Sub
    Public Sub SetConfermaSelected(ByVal include As Boolean)
        m_ConfermaSelected = include
    End Sub
    Public Sub SetIntegraSelected(ByVal include As Boolean)
        m_IntegraSelected = include
    End Sub
    Public Sub SetRigettateSelected(ByVal include As Boolean)
        m_RigettateSelected = include
    End Sub
    Public Sub SetChiuseSelected(ByVal include As Boolean)
        m_ChiuseSelected = include
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
        Dim query As Query = ps.CreateNewQuery("MapperPratica")
        Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
        Dim stateCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
        Dim stateCriteriaAdded As Boolean = False
        'Dim subStateDelegaCriteriaAdded As Boolean = False

        If m_DataRangeSelected And Not m_DataRange.IsEmpty Then
            mainCriteria.AddCriteria(New DateContainedCriteria("PracticeDate", m_DataRange.Start, m_DataRange.Finish, ps.DBType))
        End If

        If m_IdTipoPratica <> -1 Then
            mainCriteria.AddCriteria(Criteria.Equal("PracticeTypeId", m_IdTipoPratica))
        End If

       

       

        If m_ListaUtentiSelected Then
            Dim CompositeListaUtenti As AbstractBoolCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
            If m_listaUtenti.Count > 0 Then
                For Each elem As String In m_listaUtenti
                    CompositeListaUtenti.AddCriteria(Criteria.Equal("UserId", elem))
                Next
                mainCriteria.AddCriteria(CompositeListaUtenti)
            End If
        End If


        Dim subDataRangeCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)
        Dim subStateDelegaCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.OrOp)

        If m_AperteSelected Then
            stateCriteria.AddCriteria(Criteria.Equal("PracticeState", "0"))
            stateCriteriaAdded = True
        End If

        If m_ControlloSelected Then
            stateCriteria.AddCriteria(Criteria.Equal("PracticeState", "2"))
            stateCriteriaAdded = True
        End If

        If m_ConfermaSelected Then
            stateCriteria.AddCriteria(Criteria.Equal("PracticeState", "1"))
            stateCriteriaAdded = True
        End If

        If m_IntegraSelected Then
            stateCriteria.AddCriteria(Criteria.Equal("PracticeState", "3"))
            stateCriteriaAdded = True
        End If

        If m_RigettateSelected Then
            stateCriteria.AddCriteria(Criteria.Equal("PracticeState", "5"))
            stateCriteriaAdded = True
        End If

        If m_ChiuseSelected Then
            stateCriteria.AddCriteria(Criteria.Equal("PracticeState", "4"))
            stateCriteriaAdded = True
        End If

        If stateCriteriaAdded Then
            mainCriteria.AddCriteria(stateCriteria)
        End If



        Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
        orderCriteria.AddCriteria(Criteria.SortCriteria("PracticeDate", True))



        query.AddWhereClause(mainCriteria)

        query.AddOrderByClause(orderCriteria)

        Dim result As IList = query.Execute(ps)
        Dim filteredresult As IList = New ArrayList


        If m_IdInCaricoA <> -1 Then

          
            For Each elem As Pratica In result
                'imposto questa variabile a true se aggiungo l'elemento alla lista dei rsiultait
                'questo mi serve nel caso un risultato non rientri nel filtro e quindi eseguire la veirfica sull'owner
                Dim added As Boolean = False

                Select Case elem.State.State

                    Case PracticeEnum.Aperta
                        If elem.Owner.Id = m_IdInCaricoA Then
                            filteredresult.Add(elem)
                            added = True
                        End If
                    Case PracticeEnum.Chiusa
                        If Not elem.TipoPratica.ClosedPracticeuser Is Nothing Then
                            If elem.TipoPratica.ClosedPracticeuser.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        Else
                            If elem.Owner.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        End If
                    Case PracticeEnum.Confermata
                        If Not elem.TipoPratica.DocumentationVerifiedUser Is Nothing Then
                            If elem.TipoPratica.DocumentationVerifiedUser.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        Else
                            If elem.Owner.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        End If
                    Case PracticeEnum.Controllo
                        If Not elem.TipoPratica.ControlUser Is Nothing Then
                            If elem.TipoPratica.ControlUser.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        Else
                            If elem.Owner.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        End If
                    Case PracticeEnum.Integrazione
                        If Not elem.TipoPratica.IntegrationUser Is Nothing Then
                            If elem.TipoPratica.IntegrationUser.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        Else
                            If elem.Owner.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        End If
                    Case PracticeEnum.Rigettata
                        If Not elem.TipoPratica.RejectedPractice Is Nothing Then
                            If elem.TipoPratica.RejectedPractice.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        Else
                            If elem.Owner.Id = m_IdInCaricoA Then
                                filteredresult.Add(elem)
                                added = True
                            End If
                        End If
                End Select


                If Not added Then
                    If m_IdProp <> -1 Then
                        If elem.Owner.Id = m_IdProp Then
                            filteredresult.Add(elem)
                        End If
                    End If
                End If



            Next
            m_result = filteredresult
            Return filteredresult
        Else
            m_result = result
            Return result
        End If



      
    End Function

    Sub SetProprietario(idUser As Int32)
        m_IdProp = idUser
    End Sub


End Class
