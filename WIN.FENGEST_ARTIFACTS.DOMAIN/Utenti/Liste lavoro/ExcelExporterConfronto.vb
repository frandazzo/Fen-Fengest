Public Class ExcelExporterConfronto
    Public Event BeginExport()
    Public Event EndExport()
    Public Event BeginExportLista1()
    Public Event ExportingRow(ByVal rowPercentage As Int32, ByRef cancel As Boolean)
    Public Event BeginExportLista2()
    Public Event BeginExportListaComune()
    Public Event EndExportLista1()
    Public Event EndExportLista2()
    Public Event EndExportListaComune()
    Private handler As OfficeExcelHandler

    Dim cancel As Boolean = False

    Private m_confronto As ConfrontoListeUtenti

    Friend Sub New(ByVal confronto As ConfrontoListeUtenti)
        m_confronto = confronto
        handler = New OfficeExcelHandler
    End Sub


    Private Function CreateHeaderArray() As String()
        Dim arr As String() = {"COGNOME_UTENTE", "NOME_UTENTE", "DATA_NASCITA_UTENTE", "FISCALE", _
                              "PROVINCIA_NASCITA", "COMUNE_NASCITA", "PROVINCIA", "COMUNE", "INDIRIZZO", _
                              "CAP", "TELEFONO1", "TELEFONO2", "CODICE_CE_UTENTE", "CODICE_EC_UTENTE", _
                              "NOTE_UTENTE"}

        Return arr
    End Function

    Private Function CreateArrayData(ByVal Utente As Utente) As Object()
        If Utente Is Nothing Then
            Utente = New UtenteNonSpecificato
        End If
        Dim val(14) As Object

        val(0) = Utente.Cognome
        val(1) = Utente.Nome
        val(2) = " " + Utente.DataNascita
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

        RaiseEvent BeginExport()

        RaiseEvent BeginExportLista1()

        If cancel Then
            Return
        End If
        ExportLista(1, "lista iniziale")

        RaiseEvent EndExportLista1()


        RaiseEvent BeginExportLista2()

        If cancel Then
            Return
        End If

        ExportLista(2, "Lista di confronto")

        RaiseEvent EndExportLista2()

        RaiseEvent BeginExportListaComune()

        If cancel Then
            Return
        End If

        ExportLista(3, "Elementi comuni")

        RaiseEvent EndExportListaComune()

        'handler.IsVisible = True



        RaiseEvent EndExport()

    End Sub


    Private Sub ExportLista(ByVal numeorLista As Int32, ByVal nomeWorkbook As String)

        Dim lista As IList = m_confronto.GetListaLavoroByIndex(numeorLista).ListaUtenti




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
            handler.SelectSheetByIndex(numeorLista)
            handler.CurrentSheet.Name = nomeWorkbook


            'Creo le intestazioni
            Dim intestazioneArr As String() = CreateHeaderArray()


            'Inserisco l'intestazione
            handler.FillExcelRow(handler.CurrentSheet, 1, intestazioneArr)



            'Inserisco i dati
            Dim row As Int32 = 2

            For Each elem1 As Utente In lista
                Dim values As Object() = CreateArrayData(elem1)

                handler.FillExcelRow(handler.CurrentSheet, row, values)

                row = row + 1


                RaiseEvent ExportingRow(CInt((100 / lista.Count) * row), cancel)

                If cancel Then
                    handler.Dispose()
                    Exit Sub
                End If

            Next


            ' handler.IsVisible = True



        Catch ex As Exception
            handler.Dispose()
            Throw
        End Try


    End Sub




End Class
