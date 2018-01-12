Public Class ExcelExporterListaAziende

    Public Event BeginExportLista()

    Public Event ExportingRow(ByVal rowPercentage As Int32, ByRef cancel As Boolean)

    Public Event EndExportLista()


    Private handler As OfficeExcelHandler

    Dim cancel As Boolean = False

    Private m_lista As IList

    Private m_onlyAddressOk As Boolean = False





    Public Sub New(ByVal lista As IList, ByVal onlyAddressOk As Boolean)


        m_onlyAddressOk = onlyAddressOk
        m_lista = lista
        handler = New OfficeExcelHandler
    End Sub

    Private Function CreateLabelHeaderArray() As String()
        Dim arr As String() = {"RAGIONE SOCIALE", "PROVINCIA", "COMUNE", "INDIRIZZO", _
                              "CAP"}

        Return arr
    End Function


  

    Private Function CreateLabelArrayData(ByVal Azienda As Azienda) As Object()
        If Azienda Is Nothing Then
            Azienda = New AziendaNonSpecificata
        End If
        Dim val(5) As Object

        val(0) = Azienda.Descrizione
        val(1) = Azienda.IndirizzoSedeLegale.Provincia.Sigla

        val(2) = Azienda.IndirizzoSedeLegale.Comune.Descrizione
        val(3) = Azienda.IndirizzoSedeLegale.Via
        val(4) = Azienda.IndirizzoSedeLegale.Cap




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




        ExportLista("Aziende")

        RaiseEvent EndExportLista()


    End Sub


    Private Sub ExportLista(ByVal nomeWorkbook As String)

        If String.IsNullOrEmpty(nomeWorkbook) Then
            nomeWorkbook = "Lista"
        End If

        If nomeWorkbook.Length > 20 Then
            nomeWorkbook = nomeWorkbook.Substring(0, 19)
        End If

        Dim lista As IList = m_lista




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



            intestazioneArr = CreateLabelHeaderArray()




            'Inserisco l'intestazione
            handler.FillExcelRow(handler.CurrentSheet, 1, intestazioneArr)



            'Inserisco i dati
            Dim row As Int32 = 2

            For Each elem1 As Azienda In lista
                Dim continua As Boolean = True

                If m_onlyAddressOk Then
                    If elem1.IndirizzoSedeLegale.IsIndirizzoValido Then
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


    Private Sub FillRow(ByVal elem1 As Azienda, ByVal row As Int32)
        Dim values As Object()


        values = CreateLabelArrayData(elem1)



        handler.FillExcelRow(handler.CurrentSheet, row, values)

    End Sub


End Class
