Imports WIN.SECURITY.Exceptions
Imports WIN.SECURITY

Public MustInherit Class AbstractPraticaState
    Implements IPracticeState



    Protected m_state As PracticeEnum

    Protected Sub ChangeState(state As StateData, practice As Pratica, newState As PracticeEnum)
        If Not IsChangeAuthorized(practice) Then
            Throw New AccessDeniedException("Operazione non consentita per l'utente corrente")
        End If

        ' a questo punto devo aggiungere un nuovo elemento alla lista degli eventi
        Dim evento As New PraticaEvent
        evento.Data = DateTime.Now
        evento.Operatore = SecurityManager.Instance.CurrentUser
        evento.Notes = state.Cause
        evento.State = PracticeStateFactory.ConstructPracticeState(newState)

        practice.Events.Add(evento)

        'cambio lo stato della pratica
        practice.State = evento.State
    End Sub

    Public Overridable Sub ClosePractice(state As StateData, practice As Pratica) Implements IPracticeState.ClosePractice
        ChangeState(state, practice, PracticeEnum.Chiusa)
    End Sub

    Public Overridable Sub ConfirmDocumentation(state As StateData, practice As Pratica) Implements IPracticeState.ConfirmDocumentation
        ChangeState(state, practice, PracticeEnum.Confermata)
    End Sub

    Public Overridable Sub ControlDocumentation(state As StateData, practice As Pratica) Implements IPracticeState.ControlDocumentation
        ChangeState(state, practice, PracticeEnum.Controllo)
    End Sub

    Public Overridable Sub IntegrateDocumentation(state As StateData, practice As Pratica) Implements IPracticeState.IntegrateDocumentation
        ChangeState(state, practice, PracticeEnum.Integrazione)
    End Sub

    Public Overridable Sub RecoveryPrecedingState(practice As Pratica) Implements IPracticeState.RecoveryPrecedingState

        If Not IsChangeAuthorized(practice) Then
            Throw New AccessDeniedException("Operazione non consentita per l'utente corrente")
        End If
        'il recupero dello stato precedente consiste nel cancellare 
        ' l'ultimo stato dalla lista degli eventi della pratica e impostare a tale stato lo stato corrente della pratica

        'se cè un solo evento il nuovo (stato precedente) stato della pratica sarà lo stato aperta

        'se la pratica è aperta non ha senso

        If practice.Events.Count = 1 Then
            'rimuovo l'evento 
            practice.Events.Clear()
            'imposto il nuovo stato
            practice.State = PracticeStateFactory.ConstructPracticeState(PracticeEnum.Aperta)

            Return
        End If

        'rimuovo l'ultimo
        practice.Events.RemoveAt(practice.Events.Count - 1)
        'adesso recupero l'ultimo stato 
        Dim evt As PraticaEvent = practice.Events.Item(practice.Events.Count - 1)
        practice.State = evt.State

    End Sub

    Public Overridable Sub RejectPractice(state As StateData, practice As Pratica) Implements IPracticeState.RejectPractice
        ChangeState(state, practice, PracticeEnum.Rigettata)
    End Sub

    Public Overridable ReadOnly Property State As PracticeEnum Implements IPracticeState.State
        Get
            Return m_state
        End Get
    End Property

    Public Overridable Function StateName() As String Implements IPracticeState.StateName
        Return m_state.ToString
    End Function

    Protected Overridable Function IsChangeAuthorized(pratica As Pratica) As Boolean Implements IPracticeState.IsChangeAuthorized
        'se ci sono restizioni di permesso devo verificare che l'utente loggato abbia la possibilità di modificare lo stato
        'della pratica
        If (Not pratica.TipoPratica.RestrictedPermissions) Then
            Return True
        End If

        'verifico  se c'è l'utente jolly
        'se son oun tale utente poosso fare tutto
        If Not pratica.TipoPratica.JollyUser Is Nothing Then
            If pratica.TipoPratica.JollyUser.Id = SecurityManager.Instance.CurrentUser.ID Then
                Return True
            End If
        End If

        Return DoSecurityCheck(pratica)

    End Function

    Protected MustOverride Function DoSecurityCheck(pratica As Pratica) As Boolean
End Class
