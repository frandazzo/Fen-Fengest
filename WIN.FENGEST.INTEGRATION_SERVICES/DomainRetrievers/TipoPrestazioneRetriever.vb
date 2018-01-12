Public Class TipoPrestazioneRetriever
    Private Shared ControllerTipoPrestazioni As New WIN.APPLICATION.ADMINISTRATION.ControllerTipoPrestazione


    Public Shared Function GetIdTipoPrestazione(ByVal nome As String) As Int32



        If String.IsNullOrEmpty(nome) Then

            nome = "NON SPECIFICATA"

        End If



        Dim l As IList = ControllerTipoPrestazioni.GetAll()

        For Each elem As TipoPrestazione In l
            If elem.Descrizione.Equals(nome.ToUpper) Then
                Return elem.Id

            End If
        Next
        Return -1
    End Function
End Class
