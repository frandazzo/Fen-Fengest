Public Class LavoratoriAziendaExcelExporter
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

    Private m_listaIscritti As IList
    Private m_listaNonIscrittiCE As IList
    Private m_listaNonIscrittiEC As IList

    Public Sub New(ByVal listaIscritti As IList, ByVal listaLiberiCE As IList, ByVal listaLiberiEC As IList)
        m_listaIscritti = listaIscritti
        m_listaNonIscrittiCE = listaLiberiCE
        m_listaNonIscrittiEC = listaLiberiEC
        handler = New OfficeExcelHandler
    End Sub


    Private Function CreateHeaderArray() As String()
        Dim arr As String() = {"COGNOME_UTENTE", "NOME_UTENTE", "FISCALE", _
                              "NAZIONALITA", "PROVINCIA_RESIDENZA", "COMUNE_RESIDENZA", _
                              "COMPETENZA", "SETTORE", "AZIENDA", "CONTRATTO", "LIVELLO", "CELL1", "CELL2"}

        Return arr
    End Function

    Private Function CreateHeaderArrayLiberi() As String()
        Dim arr As String() = {"UTENTE", "FISCALE", _
                              "NAZIONALITA", "PROVINCIA_RESIDENZA", "COMUNE_RESIDENZA", _
                              "ENTE", "ISCRITTO_A", "LIVELLO", _
                              "LIBERO_AL", "CELL1", "CELL2"}

        Return arr
    End Function

    Private Function CreateArrayDataNonIscritti(ByVal Utente As NonIscrittoDTO) As Object()
        If Utente Is Nothing Then
            Utente = New NonIscrittoDTO
        End If
        Dim val(10) As Object

        val(0) = Utente.Nome_Utente
        val(1) = Utente.Codice_Fiscale
        val(2) = Utente.Nome_Nazione
        val(3) = Utente.Nome_Provincia
        val(4) = Utente.Nome_Comune
        val(5) = Utente.Nome_Ente
        val(6) = Utente.IscrittoA
        val(7) = Utente.Livello
        val(8) = " " + Utente.Libero_Al
        val(9) = Utente.Cell1
        val(10) = Utente.Cell2
     
        Return val

    End Function

    Private Function CreateArrayDataIscritti(ByVal Utente As IscrittoDTO) As Object()
        If Utente Is Nothing Then
            Utente = New IscrittoDTO
        End If
        Dim val(12) As Object

        val(0) = Utente.Cognome
        val(1) = Utente.Nome
        val(2) = Utente.Codice_Fiscale
        val(3) = Utente.Nome_Nazione
        val(4) = Utente.Nome_Provincia
        val(5) = Utente.Nome_Comune
        val(6) = Utente.Competenza
        val(7) = Utente.Settore
        val(8) = Utente.AziendaImpiego
        val(9) = Utente.Contratto
        val(10) = Utente.Livello
        val(11) = Utente.Cell1
        val(12) = Utente.Cell2




        Return val

    End Function


    



    Public Sub Export()

        RaiseEvent BeginExport()

        RaiseEvent BeginExportLista1()

        If cancel Then
            Return
        End If
        ExportListaIscritti(m_listaIscritti, "lista iscritti")

        RaiseEvent EndExportLista1()


        RaiseEvent BeginExportLista2()

        If cancel Then
            Return
        End If

        ExportListaLiberi(1, "Lista liberi CE")

        RaiseEvent EndExportLista2()

        RaiseEvent BeginExportListaComune()

        If cancel Then
            Return
        End If

        ExportListaLiberi(2, "Lista liberi EC")

        RaiseEvent EndExportListaComune()

        ' handler.IsVisible = True


        RaiseEvent EndExport()



    End Sub
    Public Sub CloseExporter()
        If handler IsNot Nothing Then
            handler.KillAllExcelProcesses()
        End If
    End Sub

    Public Sub SaveAs(ByVal filename As String)
        handler.SaveAs(filename)
    End Sub


    Private Sub ExportListaIscritti(ByVal lista As IList, ByVal nomeWorkbook As String)






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
            Dim intestazioneArr As String() = CreateHeaderArray()


            'Inserisco l'intestazione
       
            handler.FillExcelRow(handler.CurrentSheet, 1, intestazioneArr)

          


            'Inserisco i dati
            Dim row As Int32 = 2

            For Each elem1 As IscrittoDTO In lista
                Dim values As Object() = CreateArrayDataIscritti(elem1)

              
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


    Private Sub ExportListaLiberi(ByVal nemeroLista As Int32, ByVal nomeWorkbook As String)


        Dim lista As IList
        If nemeroLista = 1 Then
            lista = m_listaNonIscrittiCE
        Else
            lista = m_listaNonIscrittiEC
        End If



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

          

            handler.SelectSheetByIndex(nemeroLista + 1)


         

            handler.CurrentSheet.Name = nomeWorkbook


            'Creo le intestazioni
            Dim intestazioneArr As String() = CreateHeaderArrayLiberi()


        
            'Inserisco l'intestazione
            handler.FillExcelRow(handler.CurrentSheet, 1, intestazioneArr)

        

            'Inserisco i dati
            Dim row As Int32 = 2

            For Each elem1 As NonIscrittoDTO In lista
                Dim values As Object() = CreateArrayDataNonIscritti(elem1)

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

