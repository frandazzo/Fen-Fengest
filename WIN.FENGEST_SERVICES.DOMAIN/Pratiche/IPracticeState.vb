Public Interface IPracticeState

    Sub ControlDocumentation(state As StateData, practice As Pratica)
    Sub IntegrateDocumentation(state As StateData, practice As Pratica)
    Sub RejectPractice(state As StateData, practice As Pratica)
    Sub ClosePractice(state As StateData, practice As Pratica)
    Sub ConfirmDocumentation(state As StateData, practice As Pratica)
    Sub RecoveryPrecedingState(practice As Pratica)
    Function StateName() As String
    ReadOnly Property State As PracticeEnum
    Function IsChangeAuthorized(pratica As Pratica) As Boolean

End Interface
