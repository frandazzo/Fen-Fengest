Public Class CausaleRetriever
   Public Shared Function GetIdCausaleRevocaDelega(ByVal nome) As Int32
      Dim idCaus As Int32

      If nome = "FILLEA" Then
         idCaus = 2
      ElseIf nome = "FILCA" Then
         idCaus = 3
      Else
         idCaus = 1
      End If

      Return idCaus
    End Function

    Public Shared Function SearchIdCausaleRevocaDelega(ByVal nome As String) As Int32
        Dim idCaus As Int32 = -1
        If String.IsNullOrEmpty(nome) Then
            Return -1
        End If
        Dim controllercausali As New ControllerCausaliRevoca()
        Dim l As IList = controllercausali.GetAll

        For Each item As CausaleRevocaDelega In l
            If item.Descrizione.ToLower.Contains(nome.ToLower) Then
                Return item.Id
            End If
        Next

        Return idCaus
    End Function
End Class
