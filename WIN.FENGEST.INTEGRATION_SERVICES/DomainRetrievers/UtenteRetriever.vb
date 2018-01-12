Public Class UtenteRetriever
   Private Shared ControllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti


   Public Shared Function GetIdUtente(ByVal fiscale As String, ByVal nome As String, ByVal cognome As String, ByVal dataNascita As String) As Int32
      


      Dim id As String = -1

      If fiscale <> "" Then
         id = ControllerUtente.GetIdUtente(fiscale)
      End If


      If id = -1 Then

         If IsDate(dataNascita) Then


            id = ControllerUtente.GetIdUtente(nome, cognome, CDate(dataNascita))

            If id = -1 Then
               id = ControllerUtente.GetIdUtente(nome, cognome, New DateTime(1900, 1, 1))
            End If



         Else
            id = ControllerUtente.GetIdUtente(nome, cognome, New DateTime(1900, 1, 1))
         End If

      End If


      Return id
   End Function

End Class
