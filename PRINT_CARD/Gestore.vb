Public Class Gestore
    'Dim ConnString As String = My.Settings.TesseramentoConnectionString
    Public Lista As New ListaTesserati
    Public RepSettings As ReportSettings
    Public Sub LoadAllTesserati(ByVal Criterio As Int16)

        Dim Connection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
        Connection.Open()
        Lista = New ListaTesserati
        Dim strQry As String = ""
        Select Case Criterio
            Case 1
                strQry = "Select * from db_Tesseramento order by cognome"
            Case 2
                strQry = "Select * from db_Tesseramento order by nome"
            Case 3
                strQry = "Select * from db_Tesseramento order by Impresa"
            Case 4
                strQry = "Select * from db_Tesseramento "
        End Select

        Dim cmd As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand(strQry, Connection)
        Dim rs As System.Data.IDataReader
        rs = cmd.ExecuteReader
        While rs.Read

            'Tesserato.Nome = rs("Nome")
            'Tesserato.Cognome = rs("Cognome")
            'Tesserato.Azienda = rs("Impresa")
            'Tesserato.IdUtente = rs("IdUtente")
            'Tesserato.StampataDa = rs("STAMPATA_DA")

            'Tesserato.Provincia = IIf(rs("PROVINCIA") Is DBNull.Value, "", rs("PROVINCIA"))
            'Tesserato.Comune = IIf(rs("COMUNE") Is DBNull.Value, "", rs("COMUNE"))
            'Tesserato.Via = IIf(rs("VIA") Is DBNull.Value, "", rs("VIA"))
            'Tesserato.Cap = IIf(rs("CAP") Is DBNull.Value, "", rs("CAP"))
            'Tesserato.AziendaOld = IIf(rs("AZIENDA_OLD") Is DBNull.Value, "", rs("AZIENDA_OLD"))
            Dim Tesserato As New Tesserato1
            LoadDatiTesserato(Tesserato, rs)
            If CanAddTesserato(Tesserato) Then
                Lista.Add(Tesserato)
            End If
        End While
        rs.Close()
        Connection = Nothing

    End Sub
    Public Sub LoadTesseratiByCriteria(ByVal Nome As String, ByVal Cognome As String, ByVal azienda As String, ByVal comune As String, ByVal addressOk As Boolean, ByVal AziendaNulla As Boolean)

        Dim azText As String = "(Impresa like @Imp or @Imp = '-1') and "


        Dim Connection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
        Connection.Open()
        Lista = New ListaTesserati
        If Nome <> "" Then
            Nome = Nome & "%"
        Else
            Nome = "-1"
        End If
        If Cognome <> "" Then
            Cognome = Cognome & "%"
        Else
            Cognome = "-1"
        End If


        If AziendaNulla Then
            azText = "(impresa = '') and "

        Else
            If azienda <> "" Then
                azienda = azienda & "%"
            Else
                azienda = "-1"
            End If
        End If




        If comune <> "" Then
            comune = comune & "%"
        Else
            comune = "-1"
        End If

        Dim addOk As String = ""


        If addressOk Then
            addOk = " and (comune <> '' and cap <> '' and via <> '')"
        End If



        Dim strQry As String = "Select * from db_tesseramento where " & _
        "(Nome like @Nom or @Nom = '-1') and " & _
        "(Cognome like @Cog or @Cog = '-1') and " & _
        "" & azText & _
        "(Comune like @Com or @Com = '-1') " & addOk


        Dim cmd As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand(strQry, Connection)
        Dim param As System.Data.IDataParameter = cmd.CreateParameter
        param.ParameterName = "@Nom"
        param.Value = Nome
        cmd.Parameters.Add(param)
        'cmd.Parameters.AddWithValue("@Nom", Nome)

        param = cmd.CreateParameter
        param.ParameterName = "@Cog"
        param.Value = Cognome
        cmd.Parameters.Add(param)
        'cmd.Parameters.AddWithValue(, Cognome)


        If Not AziendaNulla Then
            param = cmd.CreateParameter
            param.ParameterName = "@Imp"
            param.Value = azienda
            cmd.Parameters.Add(param)
        End If



        param = cmd.CreateParameter
        param.ParameterName = "@Com"
        param.Value = comune
        cmd.Parameters.Add(param)

        'cmd.Parameters.AddWithValue(, )
        Dim rs As System.Data.IDataReader
        rs = cmd.ExecuteReader
        While rs.Read
            Dim Tesserato As New Tesserato1
            LoadDatiTesserato(Tesserato, rs)
            If CanAddTesserato(Tesserato) Then
                Lista.Add(Tesserato)
            End If

        End While
        rs.Close()
        Connection = Nothing

    End Sub


    Private Function CanAddTesserato(ByVal Tesserato As Tesserato1) As Boolean

        If initial_index = 0 And final_index = 0 Then
            Return True
        End If


        If final_index = 0 Then
            Return Tesserato.Indice >= initial_index
        End If

        If initial_index = 0 Then
            Return Tesserato.Indice <= final_index
        End If


        If Tesserato.Indice >= initial_index And Tesserato.Indice <= final_index Then
            Return True

        End If

        Return False
    End Function



    Private Sub LoadDatiTesserato(ByVal Tesserato As Tesserato1, ByVal rs As System.Data.IDataReader)
        Tesserato.Nome = rs("Nome")
        Tesserato.Cognome = rs("Cognome")
        Tesserato.Azienda = rs("Impresa")
        Tesserato.IdUtente = rs("IdUtente")
        Tesserato.StampataDa = rs("STAMPATA_DA")

        Tesserato.Provincia = IIf(rs("PROVINCIA") Is DBNull.Value, "", rs("PROVINCIA"))
        Tesserato.Indice = rs("INDICE")
        Tesserato.Comune = IIf(rs("COMUNE") Is DBNull.Value, "", rs("COMUNE"))
        Tesserato.Via = IIf(rs("VIA") Is DBNull.Value, "", rs("VIA"))
        Tesserato.Cap = IIf(rs("CAP") Is DBNull.Value, "", rs("CAP"))
        Tesserato.AziendaOld = IIf(rs("AZIENDA_OLD") Is DBNull.Value, "", rs("AZIENDA_OLD"))
    End Sub


    Public Sub Stampa(ByVal listaTesserati As IList)

        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        s = IO.Path.Combine(s, "StampaTessere.pdf")

        'If federProv = "BARI" Then
        '    'aggiungo il comune al campoa azienda

        '    For Each elem As Tesserato In listaTesserati
        '        Dim az As String = elem.Azienda

        '        elem.Azienda = String.Format("{0} - {1}", az, elem.Comune)


        '    Next


        'End If

        'If federProv = "MILANO" Then
        '    'alla provincia aggiungo milano - lodi - pavia

        '    For Each elem As Tesserato In listaTesserati
        '        elem.ProvinciaSindacale = "MILANO - LODI- PAVIA"

        '    Next


        'End If


        'If federProv = "BOLZANO" Then
        '    Dim rep As New XtraReport3
        '    rep.DataSource = CreateListaTerneTesserati(listaTesserati)
        '    rep.ExportToPdf(s)
        'Else

        '    Dim rep As New XtraReport1
        '    rep.DataSource = listaTesserati
        '    rep.ExportToPdf(s)
        'End If


        PRINT_CARD_CORE_VB.PrintCardFacade.StampaTessere(s, federProv, settore, listaTesserati)


        For Each elem As Tesserato1 In listaTesserati
            InsertTesseraStampata(elem)
        Next

        MsgBox("File creato correttamente!", MsgBoxStyle.Information, "Informazione")

        Process.Start(s)



    End Sub


    Public Sub EseguiAggiornemtnoAziende(ByVal Testo As String, ByVal lista As IList)
        For Each elem As Tesserato1 In lista
            Try
                EseguiAggiornemtnoCampoAziende(Testo, elem.IdUtente)
            Catch ex As Exception
                'non fa nulla
            End Try
        Next
    End Sub




    Public Sub EseguiAggiornemtnoCampoAziende(ByVal Testo As String, ByVal idUtente As String)
        Dim cnn As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
        Dim statement As String = String.Format("Update db_tesseramento set impresa = '" & Testo & "' where idutente = '" & idUtente & "'")
        Try
            cnn.Open()
            Dim cmd As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand(statement, cnn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            '
        Finally
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Dispose()
        End Try
    End Sub


    Public Sub EseguiRipristinoCampoAziende()
        Dim cnn As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
        Dim statement As String = "Update db_tesseramento set impresa =  Azienda_Old"
        Try
            cnn.Open()
            Dim cmd As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand(statement, cnn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            '
        Finally
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Dispose()
        End Try
    End Sub

    Public Sub InsertTesseraStampata(ByVal Tesserato As Tesserato1)
        If Tesserato.IdUtente = 0 Then Return
        Dim cnn As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
        Dim statement As String = String.Format("Insert into DB_Stampa_Tessere (Id, Id_Utente, Data_Stampa, Stampata_da) values ({0},{1}, '{2}', '{3}')", GetMaxStampaTessereId, Tesserato.IdUtente, Format(DateTime.Now, "dd/MM/yyyy"), Replace(Tesserato.StampataDa, "'", "''"))
        Try
            cnn.Open()
            Dim cmd As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand(statement, cnn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            '
        Finally
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Dispose()
        End Try
    End Sub


    Private Function GetMaxStampaTessereId() As Int32
        Dim rs As System.Data.IDataReader = Nothing
        Dim cmd As System.Data.IDbCommand
        Dim cnn As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
        Dim statement As String = "Select max(Id) from DB_Stampa_Tessere"
        Try
            cnn.Open()
            'qui devo leggere l'oggetto in un datareader e caricarlo
            cmd = New System.Data.SqlClient.SqlCommand(statement, cnn)
            rs = cmd.ExecuteReader
            rs.Read()
            If IsDBNull(rs(0)) Then
                rs.Close()
                Return 1
            Else
                Dim Id As Int32 = rs(0) + 1
                rs.Close()
                Return Id
            End If
        Catch ex As Exception
            '
        Finally
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Dispose()
        End Try
    End Function




    Private Sub NormalizzaLista()

        If System.Math.Abs(System.Math.IEEERemainder(Lista.Count, 2)) = 1 Then
            Dim tess As New Tesserato1
            Lista.Add(tess)
        ElseIf System.Math.IEEERemainder(Lista.Count, 2) = 0 Then
            'ok
        Else
            Throw New Exception("Funzione modulo per la lista non riuscita")
        End If

    End Sub

    Private Function CreateTerna(ByVal listaTesserati As IList, ByVal counter As Integer) As TernaTesserati

        Dim Tesserato1 As Tesserato1 = GetTesserato(counter, listaTesserati)
        Dim Tesserato2 As Tesserato1 = GetTesserato(counter + 1, listaTesserati)
        Dim Tesserato3 As Tesserato1 = GetTesserato(counter + 2, listaTesserati)

        'se il tesserato1 è nullo (il nome o il cognome sono nulli)
        ' allora ritorno una terna nulla
        'cio' istruira la funzione chiamante a terminare il ciclo se già non è terminato
        If Tesserato1 Is Nothing Then
            Return Nothing
        End If

        Return New TernaTesserati(Tesserato1, Tesserato2, Tesserato3)


    End Function
    Private Function CreateListaTerneTesserati(ByVal listaTesserati As IList) As IList

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

    Private Function GetTesserato(counter As Integer, listaTesserati As Collections.IList) As Tesserato1

        Try
            If listaTesserati(counter) IsNot Nothing Then
                Return listaTesserati(counter)
            End If
            Return New Tesserato1
        Catch ex As Exception
            Return New Tesserato1
        End Try
    End Function


End Class
