Imports WIN.SECURITY.Exceptions

Public Class Aperta
    Inherits AbstractPraticaState

    Protected Overrides Function DoSecurityCheck(pratica As Pratica) As Boolean
        'se la pratica è aperta solo il suo owner puo' modificarla
        'quindi si tratta di verificare che l'utente corrente sia l'owner della pratica
        If SecurityManager.Instance.CurrentUser.ID = pratica.Owner.Id Then
            Return True
        End If


        'negli altri casi è falso
        Return False
    End Function

    Public Sub New()
        m_state = PracticeEnum.Aperta
    End Sub

 

    Public Overrides Sub ClosePractice(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    Public Overrides Sub ConfirmDocumentation(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    'Public Overrides Sub ControlDocumentation(state As StateData, practice As Pratica)
    'il controllo è permesso dallo stato di aperta
    'End Sub

    Public Overrides Sub IntegrateDocumentation(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    Public Overrides Sub RecoveryPrecedingState(practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub

    Public Overrides Sub RejectPractice(state As StateData, practice As Pratica)
        Throw New InvalidOperationException("Operazione non valida")
    End Sub



End Class
