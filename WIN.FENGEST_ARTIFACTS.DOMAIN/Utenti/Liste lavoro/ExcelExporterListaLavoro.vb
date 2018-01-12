Public Class ExcelExporterListaLavoro
    
    Public Event BeginExportLista()

    Public Event ExportingRow(ByVal rowPercentage As Int32, ByRef cancel As Boolean)

    Public Event EndExportLista()


    Private handler As OfficeExcelHandler

    Dim cancel As Boolean = False

    Private m_lista As ListaLavoroUtenti

    Private m_onlyAddressOk As Boolean = False


    Private m_asLabel As Boolean = False


    Friend Sub New(ByVal lista As ListaLavoroUtenti, ByVal onlyAddressOk As Boolean, ByVal asLabel As Boolean)

        m_asLabel = asLabel
        m_onlyAddressOk = onlyAddressOk
        m_lista = lista
        handler = New OfficeExcelHandler
    End Sub

    Private Function CreateLabelHeaderArray() As String()
        Dim arr As String() = {"COGNOME_UTENTE", "NOME_UTENTE", "PROVINCIA", "COMUNE", "INDIRIZZO", _
                              "CAP"}

        Return arr
    End Function


    Private Function CreateHeaderArray() As String()
        Dim arr As String() = {"COGNOME_UTENTE", "NOME_UTENTE", "DATA_NASCITA_UTENTE", "FISCALE", _
                              "PROVINCIA_NASCITA", "COMUNE_NASCITA", "PROVINCIA", "COMUNE", "INDIRIZZO", _
                              "CAP", "TELEFONO1", "TELEFONO2", "CODICE_CE_UTENTE", "CODICE_EC_UTENTE", _
                              "NOTE_UTENTE"}

        Return arr
    End Function

    Private Function CreateLabelArrayData(ByVal Utente As Utente) As Object()
        If Utente Is Nothing Then
            Utente = New UtenteNonSpecificato
        End If
        Dim val(5) As Object

        val(0) = Utente.Cognome
        val(1) = Utente.Nome

        val(2) = Utente.Residenza.Provincia.Sigla
       
        val(3) = Utente.Residenza.Comune.Descrizione
        val(4) = Utente.Residenza.Via
        val(5) = Utente.Residenza.Cap




        Return val

    End Function



    Private Function CreateArrayData(ByVal Utente As Utente) As Object()
        If Utente Is Nothing Then
            Utente = New UtenteNonSpecificato
        End If
        Dim val(14) As Object

        val(0) = Utente.Cognome
        val(1) = Utente.Nome
        val(2) = " " + Utente.DataNascita.ToShortDateString

        val(3) = Utente.CodiceFiscale
        val(4) = Utente.ProvinciaNascita.Sigla
        If Utente.ComuneNascita.Id = -1 Then
            val(5) = Utente.Nazionalita.Descrizione
        Else
            val(5) = Utente.ComuneNascita.Descrizione
        End If

        val(6) = Utente.Residenza.Provincia.Sigla
        val(7) = Utente.Residenza.Comune.Descrizione
        val(8) = Utente.Residenza.Via
        val(9) = Utente.Residenza.Cap
        val(10) = Utente.Comunicazione.Cellulare1
        val(11) = Utente.Comunicazione.Cellulare2
        val(12) = Utente.Codifica.CodificaCE
        val(13) = Utente.Codifica.CodificaEC
        val(14) = Utente.Note



        Return val

    End Function


    Public Sub CloseExporter()
        If handler IsNot Nothing Then
            handler.KillAllExcelProcesses()
        End If
    End Sub

    Public Sub SaveAs(ByVal filename As String)
        handler.SaveAs(filename)
    End Sub

    Public Sub Export()

    
        RaiseEvent BeginExportLista()

        If cancel Then
            Return
        End If




        ExportLista(m_lista.Descrizione)

        RaiseEvent EndExportLista()


    End Sub


    Private Sub ExportLista(ByVal nomeWorkbook As String)

        If String.IsNullOrEmpty(nomeWorkbook) Then
            nomeWorkbook = "Lista"
        End If

        If nomeWorkbook.Length > 20 Then
            nomeWorkbook = nomeWorkbook.Substring(0, 19)
        End If

        Dim lista As IList = m_lista.ListaUtenti




        Try



            If handler.ExcelInstance Is Nothing Then
                'creo una nuova istanza di excel
                handler.OpenExcelApplication(True)
            End If

            If handler.CurrentWorkbook Is Nothing Then
                'Aggiungo un nuovo documento ad excel 
                handler.AddDocumentToExcel("")
            End If

            'lo attivo
            handler.ActivateWorkBook()




            'seleziono lo sheet di interesse
            handler.SelectSheetByIndex(1)
            handler.CurrentSheet.Name = nomeWorkbook


            'Creo le intestazioni
            Dim intestazioneArr As String()


            If m_asLabel Then
                intestazioneArr = CreateLabelHeaderArray()
            Else
                intestazioneArr = CreateHeaderArray()
            End If



            'Inserisco l'intestazione
            handler.FillExcelRow(handler.CurrentSheet, 1, intestazioneArr)



            'Inserisco i dati
            Dim row As Int32 = 2

            For Each elem1 As Utente In lista
                Dim continua As Boolean = True

                If m_onlyAddressOk Then
                    If elem1.Residenza.IsIndirizzoValido Then
                        'riempio la riga e proseguo con l'evento solo se li'indirizzo è valido
                        FillRow(elem1, row)

                        row = row + 1

                        RaiseEvent ExportingRow(CInt((100 / lista.Count) * row), cancel)

                        If cancel Then
                            handler.Dispose()
                            Exit Sub
                        End If
                    End If

                Else

                    'riempio la riga e proseguo con l'evento
                    FillRow(elem1, row)


                    row = row + 1

                    RaiseEvent ExportingRow(CInt((100 / lista.Count) * row), cancel)

                    If cancel Then
                        handler.Dispose()
                        Exit Sub
                    End If

                End If




            Next


            ' handler.IsVisible = True



        Catch ex As Exception
            handler.Dispose()
            Throw
        End Try


    End Sub


    Private Sub FillRow(ByVal elem1 As Utente, ByVal row As Int32)
        Dim values As Object()

        If m_asLabel Then
            values = CreateLabelArrayData(elem1)
        Else
            values = CreateArrayData(elem1)
        End If


        handler.FillExcelRow(handler.CurrentSheet, row, values)

    End Sub


End Class
