Public Class PrintCardFacade
    Public Shared Function StampaTessere(filename As String, prov As String, sett As String, ByVal listaTesserati As IList) As String
        provincia = prov.ToUpper

        sector = sett



        '***************************************
        '***************************************
        '***************************************
        'CODICE PER FENEAL




        If provincia = "BARI" Then
            'aggiungo il comune al campoa azienda

            For Each elem As Tesserato In listaTesserati
                Dim az As String = elem.Azienda

                elem.Azienda = String.Format("{0} - {1}", az, elem.Comune)


            Next


        End If

        If provincia = "MILANO" Then
            'alla provincia aggiungo milano - lodi - pavia

            For Each elem As Tesserato In listaTesserati
                elem.ProvinciaSindacale = "MILANO - LODI- PAVIA"

            Next


        End If


        If provincia = "BOLZANO" Then
            Dim rep As New XtraReport3
            rep.DataSource = CreateListaTerneTesserati(listaTesserati)
            rep.ExportToPdf(filename)
        Else

            Dim rep As New XtraReport1
            rep.DataSource = listaTesserati
            rep.ExportToPdf(filename)
        End If





        Return filename
    End Function

    Public Shared Function StampaTessereUil(filename As String, prov As String, sett As String, ByVal listaTesserati As IList) As String
        provincia = prov.ToUpper
        uil = True

        If (sett Is Nothing) Then
            sector = sett
        Else

            'devo verificare che nel settore non ci sia il #
            'questo implica che voglio incominciare la stampa dal primo o dal secondo o dal terzo elemento
            If (Not sett.Contains("#")) Then
                sector = sett
            Else

                'devo recuperare il vero valore del settore e della posizione da cui iniziare che puo
                'essere 1 2 oppure 3
                Dim c As New Char()

                Dim s As String() = sett.Split(New Char() {"#"c})

                sector = s(0)
                Dim position As String = s(1)

                'se position è uguale a due inserisco un tesserato nullo se è 3 ne inserisco 2 (in cima alla lista)
                If (position.Equals("2")) Then
                    listaTesserati.Insert(0, New Tesserato)
                End If

                If (position.Equals("3")) Then
                    listaTesserati.Insert(0, New Tesserato)
                    listaTesserati.Insert(0, New Tesserato)
                End If

            End If


        End If





        '***************************************
        '***************************************
        '***************************************
        'CODICE PER UIL

        Dim rep As New XtraReport3
        rep.DataSource = CreateListaTerneTesserati(listaTesserati)
        rep.ExportToPdf(filename)



        Return filename
    End Function



    'Private Shared Sub NormalizzaLista()

    '    If System.Math.Abs(System.Math.IEEERemainder(Lista.Count, 2)) = 1 Then
    '        Dim tess As New Tesserato
    '        Lista.Add(tess)
    '    ElseIf System.Math.IEEERemainder(Lista.Count, 2) = 0 Then
    '        'ok
    '    Else
    '        Throw New Exception("Funzione modulo per la lista non riuscita")
    '    End If

    'End Sub

    Private Shared Function CreateTerna(ByVal listaTesserati As IList, ByVal counter As Integer) As TernaTesserati

        Dim Tesserato1 As Tesserato = GetTesserato(counter, listaTesserati)
        Dim Tesserato2 As Tesserato = GetTesserato(counter + 1, listaTesserati)
        Dim Tesserato3 As Tesserato = GetTesserato(counter + 2, listaTesserati)

        'se il tesserato1 è nullo (il nome o il cognome sono nulli)
        ' allora ritorno una terna nulla
        'cio' istruira la funzione chiamante a terminare il ciclo se già non è terminato
        If Tesserato1 Is Nothing Then
            Return Nothing
        End If

        Return New TernaTesserati(Tesserato1, Tesserato2, Tesserato3)


    End Function
    Private Shared Function CreateListaTerneTesserati(ByVal listaTesserati As IList) As IList

        Dim result As New ArrayList




        For index As Int32 = 0 To listaTesserati.Count Step 3
            Dim gr As TernaTesserati = CreateTerna(listaTesserati, index)
            If gr Is Nothing Then
                Exit For
            End If
            result.Add(gr)
        Next


        Return result

    End Function

    Private Shared Function GetTesserato(counter As Integer, listaTesserati As Collections.IList) As Tesserato

        Try
            If listaTesserati(counter) IsNot Nothing Then
                Return listaTesserati(counter)
            End If
            Return New Tesserato
        Catch ex As Exception
            Return New Tesserato
        End Try
    End Function
End Class
