Public Class StatusDelegaFactory
   Public Shared Function GetStatus(ByVal StatusName As String) As IStatusDelega
      Select Case StatusName
         Case "Sottoscritta"
            Return New StSottoscritta
         Case "Inoltrata"
            Return New StInoltrata
         Case "Accettata"
            Return New StAccettata
         Case "Attivata"
            Return New StAttiva
         Case "Annullata"
            Return New StAnnullata
         Case "Revocata"
            Return New StRevocata
         Case "Nullo"
            Return New StNull
         Case Else
            Throw New Exception("Impossibile creare uno stato per la delega. Nome stato sconosciuto")
      End Select
   End Function
End Class
