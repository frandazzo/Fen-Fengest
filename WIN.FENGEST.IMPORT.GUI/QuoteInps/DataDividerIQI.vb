Public Class DataDividerIQI

  
    Dim sa As New Hashtable


    Public Function GetDocumentListFromRawData(data As ArrayList) As ArrayList


        If data.Count = 0 Then
            Throw New Exception("Nessuna riga da importare nel file")

        End If

        DivideByFileName(data)
        'una volta suddivisi posso creale la lista dei documenti
        Dim result As New ArrayList

        

        Dim enumerator As IDictionaryEnumerator = sa.GetEnumerator
        While enumerator.MoveNext
            result.Add(enumerator.Current.Value)
        End While



        Return result


    End Function

    Private Shared Sub ValidateData(ByVal h As Hashtable)

        If h.Item("QUOTA") Is Nothing Then
            Throw New Exception("Quota non impostata")
        End If

    End Sub
    Private Sub DivideByFileName(data As ArrayList)


        'cicloc su tutti i dati e creo un elemento con chiave il comune e oggetto la lista degòi elementi per quel comune comune per ogni



        'Return data


        Try
            For Each elem As Hashtable In data
                Dim com As String = elem.Item("FILE_NAME")
                If String.IsNullOrEmpty(com) Then
                    com = "Filename non specificato"
                End If
                If Not sa.ContainsKey(com) Then
                    sa.Add(com, New ArrayList)
                End If
                DirectCast(sa.Item(com), ArrayList).Add(elem)
            Next


        Catch ex As Exception
            Throw New Exception("Alcune righe nel file non sono corrette: " + ex.Message + vbCr + "L'importazione verrà interrotta. Correggere il file prima di proseguire")
        End Try








    End Sub

End Class

