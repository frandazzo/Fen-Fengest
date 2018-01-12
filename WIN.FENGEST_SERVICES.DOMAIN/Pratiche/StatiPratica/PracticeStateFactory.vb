Public Class PracticeStateFactory

    Public Shared Function ConstructPracticeState(pratciceState As PracticeEnum) As IPracticeState


       
        Select Case pratciceState

            Case PracticeEnum.Aperta
                Return New Aperta
            Case PracticeEnum.Chiusa
                Return New Chiusa
            Case PracticeEnum.Confermata
                Return New Confermata
            Case PracticeEnum.Controllo
                Return New Controllo
            Case PracticeEnum.Integrazione
                Return New Integrazione
            Case PracticeEnum.Rigettata
                Return New Rigettata
            Case Else
                Return New Aperta
        End Select


    End Function
    Public Shared Function ConstructPracticeState(state As Int32) As IPracticeState


        Dim pratciceState As PracticeEnum = DirectCast([Enum].Parse(GetType(PracticeEnum), state), PracticeEnum)

        Select Case pratciceState

            Case PracticeEnum.Aperta
                Return New Aperta
            Case PracticeEnum.Chiusa
                Return New Chiusa
            Case PracticeEnum.Confermata
                Return New Confermata
            Case PracticeEnum.Controllo
                Return New Controllo
            Case PracticeEnum.Integrazione
                Return New Integrazione
            Case PracticeEnum.Rigettata
                Return New Rigettata
            Case Else
                Return New Aperta
        End Select


    End Function

End Class
