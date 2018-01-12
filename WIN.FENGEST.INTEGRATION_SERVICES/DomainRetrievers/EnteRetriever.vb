Public Class EnteRetriever
   Public Shared Function GetIdEnteForEdili(ByVal nome) As Int32
      Dim idEnte As Int32
      If nome = "CASSA EDILE" Then
         idente = 1
      ElseIf nome = "EDILCASSA" Then
         idEnte = 2
      Else
         Throw New Exception("Ente non definito: utilizzare le descrizioni --CASSA EDILE oppure EDILCASSA--)")
      End If

      Return idEnte
   End Function


   Public Shared Function IsCassaEdile(ByVal nome) As Boolean

      If nome = "CASSA EDILE" Then
         Return True
      End If
      Return False



   End Function
End Class
