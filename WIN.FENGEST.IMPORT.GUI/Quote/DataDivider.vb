Public Class DataDivider

    Private m_EdilCassaList As New ArrayList
    Private m_CassaEdileList As New ArrayList
    Private m_UdefinedSectorsList As New ArrayList
    Private m_IFList As New Hashtable



    Public Function GetDocumentListFromRawData(data As ArrayList) As ArrayList


        If data.Count = 0 Then
            Throw New Exception("Nessuna riga da importare nel file")

        End If

        DivideBySector(data)
        'una volta suddivisi posso creale la lista dei documenti
        Dim result As New ArrayList

        If m_CassaEdileList.Count > 0 Then
            result.Add(m_CassaEdileList)
        End If

        If m_EdilCassaList.Count > 0 Then
            result.Add(m_EdilCassaList)
        End If

        Dim enumerator As IDictionaryEnumerator = m_IFList.GetEnumerator
        While enumerator.MoveNext
            result.Add(enumerator.Current.Value)
        End While



        Return result


    End Function

    Private Shared Sub ValidateData(ByVal h As Hashtable)

        If h.Item("SETTORE") Is Nothing Then
            Throw New Exception("Settore non impostato")
        End If
        If h.Item("SETTORE").ToString = "" Then
            Throw New Exception("Settore non impostato")
        End If

        If h.Item("ENTE") Is Nothing Then
            Throw New Exception("Ente non impostato")
        End If
        If h.Item("ENTE").ToString = "" Then
            Throw New Exception("Ente non impostato")
        End If

        If h.Item("SETTORE").ToString <> "EDILE" And h.Item("SETTORE").ToString <> "IMPIANTI FISSI" Then
            Throw New Exception("Settore non impostato correttamente: " + h.Item("SETTORE").ToString)
        End If

        If h.Item("SETTORE").ToString = "EDILE" Then
            If h.Item("ENTE").ToString.Trim <> "CASSA EDILE" And h.Item("ENTE").ToString.Trim <> "EDILCASSA" Then
                Throw New Exception("Ente non impostato correttamente per il settore edile: " + h.Item("ENTE").ToString)
            End If
        End If

    End Sub
    Private Sub DivideBySector(data As ArrayList)
        m_EdilCassaList = New ArrayList
        m_CassaEdileList = New ArrayList
        m_UdefinedSectorsList = New ArrayList
        m_IFList = New Hashtable

        Try
            For Each h As Hashtable In data

                'ogni riga deve passare la validazione dei campi
                'SETTORE ed ENTE: il campa settore può assumere solo due valori: EDILE o IMPIANTI FISSI
                'il campo ente può assumere solo due valori se il settore è edile (EDILCASSA e CASSA EDILE)
                'altrimenti qualunque valore è ammesso
                'Per entrambi i campi non sono ammessi valori vuoti o nulli. Se anche un solo campo ha valori vuoti o nulli 
                'l'0intera importazione deve terminare
                ValidateData(h)


                h.Item("ENTE") = h.Item("ENTE").ToString.Trim




                If h.Item("SETTORE") = "EDILE" Then
                    If h.Item("ENTE") = "EDILCASSA" Then
                        m_EdilCassaList.Add(h)
                    Else
                        m_CassaEdileList.Add(h)
                    End If

                Else
                    'per gli impianti fissi creo una hash table che ha per chiave il nome dell'azienda e per 
                    'oggetto una lista di tutti gli elementi che vi appartengono
                    Dim ente As String = h.Item("ENTE")

                    If m_IFList.ContainsKey(ente) Then
                        Dim l As ArrayList = DirectCast(m_IFList.Item(ente), ArrayList)
                        l.Add(h)
                    Else
                        Dim l As New ArrayList
                        l.Add(h)
                        m_IFList.Add(ente, l)
                    End If
                End If
            Next








        Catch ex As Exception
            Throw New Exception("Alcune righe nel file non sono corrette: " + ex.Message + vbCr + "L'importazione verrà interrotta. Correggere il file prima di proseguire")
        End Try








    End Sub

End Class
