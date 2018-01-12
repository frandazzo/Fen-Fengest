Public Class Pratica
    Inherits AbstractPersistenceObject


    Private m_date As DateTime
    Private m_Notes As String
    Private m_TipoPratica As TipoPratica
    Private m_Utente As Utente
    Private m_Owner As User
    Private m_State As IPracticeState = PracticeStateFactory.ConstructPracticeState(PracticeEnum.Aperta)

    Private m_Events As IList = New ArrayList
    Private m_Details As IList = New ArrayList
    Private m_code As String
    Public Property Code() As String
        Get
            Return m_code
        End Get
        Set(ByVal value As String)
            m_code = value
        End Set
    End Property


    Private m_city As String
    Public Property City() As String
        Get
            Return m_city
        End Get
        Set(ByVal value As String)
            m_city = value
        End Set
    End Property



    Public ReadOnly Property DataFine As DateTime
        Get
            If (m_State.State <> PracticeEnum.Chiusa) Then
                Return DateTime.MinValue
            End If

            'se la pratica è chiusa restituisco la data di chiusura
            Dim a As PraticaEvent = RetrieveCloseEvent()
            Return a.Data
        End Get
    End Property

    Public ReadOnly Property DurataPratica As Integer
        Get

            Return DaysIn(m_date, DataFine)
        End Get
    End Property

    Public Property Details() As IList
        Get
            Return m_Details
        End Get
        Set(ByVal value As IList)
            m_Details = value
        End Set
    End Property

    Public ReadOnly Property NomeUtente As String
        Get
            Return m_Utente.CompleteName
        End Get
    End Property
    Public ReadOnly Property NomeTipoPratica As String
        Get
            Return m_TipoPratica.Descrizione
        End Get
    End Property

    Public Sub AddDetail(detail As PraticaDetail)

        'prima di aggiungere un nuovo documento verifico che sia possibile modificare i contenuti della pratica
        If m_State.IsChangeAuthorized(Me) Then
            m_Details.Add(detail)
        End If


    End Sub

    Public Sub RemoveDetail(detail As PraticaDetail)

        'prima di aggiungere un nuovo documento verifico che sia possibile modificare i contenuti della pratica
        If m_State.IsChangeAuthorized(Me) Then
            For Each elem As PraticaDetail In m_Details
                If elem.Equals(detail) Then
                    m_Details.Remove(elem)
                    Return
                End If
            Next
        End If

    End Sub


    Public Property Events() As IList
        Get
            Return m_Events
        End Get
        Set(ByVal value As IList)
            m_Events = value
        End Set
    End Property

    Public ReadOnly Property GetStateNote() As String
        Get
            If Me.m_Events.Count = 0 Then
                Return ""
            End If

            Return DirectCast(m_Events.Item(m_Events.Count - 1), PraticaEvent).Notes

        End Get
    End Property
    Public ReadOnly Property GetStateOperator() As String
        Get
            If Me.m_Events.Count = 0 Then
                If m_Owner.Username = "Admin" Then
                    Return "Admin"
                End If
                Return String.Format("{0} {1}", m_Owner.Name, m_Owner.SurName)
            End If

            'Dim user As User = DirectCast(m_Events.Item(m_Events.Count - 1), PraticaEvent).Operatore
            'If user.Username = "Admin" Then
            '    Return "Admin"
            'End If
            'Return String.Format("{0} {1}", user.Name, user.SurName)

            'a secondaa dello stato recupero l'owner
            Dim stateOperator As User = Nothing
            Select Case m_State.State


                Case PracticeEnum.Chiusa
                    If Not TipoPratica.ClosedPracticeuser Is Nothing Then
                        stateOperator = TipoPratica.ClosedPracticeuser
                    Else
                        stateOperator = m_Owner
                    End If
                Case PracticeEnum.Confermata
                    If Not TipoPratica.DocumentationVerifiedUser Is Nothing Then
                        stateOperator = TipoPratica.DocumentationVerifiedUser
                    Else
                        stateOperator = m_Owner

                    End If
                Case PracticeEnum.Controllo
                    If Not TipoPratica.ControlUser Is Nothing Then
                        stateOperator = TipoPratica.ControlUser
                    Else
                        stateOperator = m_Owner
                    End If
                Case PracticeEnum.Integrazione
                    If Not TipoPratica.IntegrationUser Is Nothing Then
                        stateOperator = TipoPratica.IntegrationUser
                    Else
                        stateOperator = m_Owner
                    End If
                Case PracticeEnum.Rigettata
                    If Not TipoPratica.RejectedPractice Is Nothing Then
                        stateOperator = TipoPratica.RejectedPractice
                    Else
                        stateOperator = m_Owner
                    End If
            End Select

            If stateOperator.Username = "Admin" Then
                Return "Admin"
            End If
            Return String.Format("{0} {1}", stateOperator.Name, stateOperator.SurName)

        End Get
    End Property
    Public ReadOnly Property GetOwnerOperator() As String
        Get
            If m_Owner.Username = "Admin" Then
                Return "Admin"
            End If

            Return String.Format("{0} {1}", m_Owner.Name, m_Owner.SurName)
        End Get
    End Property



    Public Property State() As IPracticeState
        Get
            Return m_State
        End Get
        Set(ByVal value As IPracticeState)
            m_State = value
        End Set
    End Property

    Public ReadOnly Property StateName() As String
        Get
            Return m_State.StateName
        End Get

    End Property


    Public Property Owner() As User
        Get
            Return m_Owner
        End Get
        Set(ByVal value As User)
            m_Owner = value
        End Set
    End Property



    Public Property PraticaDate() As DateTime
        Get
            Return m_date
        End Get
        Set(ByVal value As DateTime)
            m_date = value
        End Set
    End Property



    Public Property Notes() As String
        Get
            Return m_Notes
        End Get
        Set(ByVal value As String)
            m_Notes = value
        End Set
    End Property




    Public Property TipoPratica() As TipoPratica
        Get
            Return m_TipoPratica
        End Get
        Set(ByVal value As TipoPratica)
            m_TipoPratica = value
        End Set
    End Property



    Public Property Utente() As Utente
        Get
            Return m_Utente
        End Get
        Set(ByVal value As Utente)
            m_Utente = value
        End Set
    End Property

    Protected Overrides Sub DoValidation()

        If m_Utente Is Nothing Then
            Me.ValidationErrors.Add("Utente nullo")
        End If

        If m_Owner Is Nothing Then
            Me.ValidationErrors.Add("Proprietario nullo")
        End If

        If m_TipoPratica Is Nothing Then
            Me.ValidationErrors.Add("Tipo pratica nullo")
        End If

        If m_State Is Nothing Then
            Me.ValidationErrors.Add("Stato pratica nullo")
        End If
    End Sub

    Private Function RetrieveCloseEvent() As PraticaEvent
        For Each elem As PraticaEvent In m_Events
            If (elem.State.State = PracticeEnum.Chiusa) Then
                Return elem
            End If
        Next
        Return Nothing
    End Function

    Private Function DaysIn(StartDate As DateTime, EndDate As DateTime) As Integer
        If (EndDate.Equals(DateTime.MinValue)) Then
            EndDate = DateTime.Now
        End If
        Return (EndDate - StartDate).TotalDays
    End Function

End Class
