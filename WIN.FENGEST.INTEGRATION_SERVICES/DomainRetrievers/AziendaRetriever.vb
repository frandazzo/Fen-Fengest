Public Class AziendaRetriever

   Private Shared ControllerAzienda As New WIN.APPLICATION.AZIENDE.ControllerAziende


   Public Shared Function GetIdAzienda(ByVal partitaIva As String, ByVal nome As String) As Int32
      Dim idAz As Int32 = -1
      If partitaIva <> "" Then
         idAz = ControllerAzienda.GetIdAziendaByPIVA(partitaIva)
      End If
      If idAz = -1 Then
         idAz = ControllerAzienda.GetIdAzienda(nome, partitaIva)
      End If
      If idAz = -1 Then
         idAz = ControllerAzienda.GetIdAzienda(nome)
      End If

      Return idAz

   End Function


End Class
