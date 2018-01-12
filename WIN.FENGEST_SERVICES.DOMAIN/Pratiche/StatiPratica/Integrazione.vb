Public Class Integrazione
    Inherits AbstractPraticaState


    Protected Overrides Function DoSecurityCheck(pratica As Pratica) As Boolean
        'se la pratica è in controllo  solo il suo owner puo' modificarla se il tipo pratica non ha un 
        'utente per il controllo definito

        If pratica.TipoPratica.IntegrationUser Is Nothing Then 'se è nullo verifico di essere l'owner
            If SecurityManager.Instance.CurrentUser.ID = pratica.Owner.Id Then
                Return True
            End If
            Return False
        End If

        If pratica.TipoPratica.IntegrationUser.Id = SecurityManager.Instance.CurrentUser.ID Then
            Return True
        End If

        'negli altri casi è falso
        Return False
    End Function




    Public Sub New()
        m_state = PracticeEnum.Integrazione
    End Sub



    Public Overrides Sub ClosePractice(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    Public Overrides Sub ConfirmDocumentation(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    'Public Overrides Sub ControlDocumentation(state As StateData, practice As Pratica)

    'End Sub

    Public Overrides Sub IntegrateDocumentation(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    'Public Overrides Sub RecoveryPrecedingState(practice As Pratica)

    'End Sub

    Public Overrides Sub RejectPractice(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub



End Class
