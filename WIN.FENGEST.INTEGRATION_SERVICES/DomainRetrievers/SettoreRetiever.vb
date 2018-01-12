Public Class SettoreRetiever
   Public Shared Function GetIdSettore(ByVal nome) As Int32
      Dim idEnte As Int32
      If nome = "IMPIANTI FISSI" Then
         idEnte = 1
      ElseIf nome = "EDILE" Then
         idEnte = 2
      Else
         Throw New Exception("Settore non definito: utilizzare le descrizioni --EDILE oppure IMPIANTI FISSI--)")
      End If

      Return idEnte
   End Function


   Public Shared Function IsImpiantiFissi(ByVal nome) As Boolean

      If nome = "IMPIANTI FISSI" Then
         Return True
      End If
      Return False



   End Function
End Class
