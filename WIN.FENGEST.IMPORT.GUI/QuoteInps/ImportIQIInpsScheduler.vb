Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES
Public Class ImportIQIInpsScheduler
    Public Event DocumentsFound(ByVal NumberOfDocuments As Int32)
    Public Event BeginDocumentWriting()
    Public Event WritingDocument(idDocument As Int32)
    Public Event EndImport(ByVal Errors As Int32, ByVal Inserted As Int32)
    Public Event NotifyDocumentError(errorData As String)

    Public Event BeginParsePath()
    Public Event EndParsePath(NumberOfFilesFound As Integer)
    Public Event BeginParseFile(filename As String, number As Integer)
    Public Event EndParseFile(filename As String, exception As Exception)




    Public Event BeginParse()
    Public Event EndParse(ByVal NumberOfRecords As Int32)
    Public Event BeginRetrieving()
    Public Event RetrievingRecord(ByVal IdRecord As Int32)
    Public Event BeginWriting()
    Public Event BeginWritingIQA()
    Public Event EndWritingIQA()
    Public Event WritingRecord(ByVal IdRecord As Int32)
    Public Event AddingRecord(ByVal IdRecord As Int32)

    Public Event EndWriting(ByVal Errors As Int32, ByVal Inserted As Int32)
    Public Event EndRetrieving(ByVal NumberOfRecords As Int32)
    Protected m_FileName As String = ""
    Protected m_LogPath As String = ""
    Protected FileLogName = "ImportIQIInps"
    Protected WithEvents m_DataRetriver As MultipleFileDataRetriever
    Protected ListOfCommands As New Hashtable
    Protected Data As ArrayList
    Protected Errors As Int32 = 0
    Protected Inserted As Int32 = 0
    Protected WithEvents InsertIQI As InsertIQICommand


    Protected m_DocumentsFound As Int32
    Dim m_RowReference As Int32

    Protected DocumentErrors As Int32 = 0
    Protected DocumentInserted As Int32 = 0




    Public Sub New(ByVal PathToScan As String, ByVal LogFilePath As String)
        m_DataRetriver = New MultipleFileDataRetriever(PathToScan, DataInfoRetrieverFactory.RetrieverType.Inps)
        m_LogPath = LogFilePath


    End Sub

    Private Sub InsertDocumentData(singleDocument_Data As ArrayList)
        'Adesso bisogna ciclare sui dati per inserli attraverso i comandi
        Dim i As Int32 = 0
        RaiseEvent BeginWriting()
        For Each elem As Hashtable In singleDocument_Data
            i = i + 1
            Try
                WriteRequiredData(elem)
            Catch ex As Exception
            End Try
            RaiseEvent WritingRecord(i)
        Next

        Me.WriteIq(singleDocument_Data)
        DocumentInserted = singleDocument_Data.Count - DocumentErrors

        RaiseEvent EndWriting(DocumentErrors, DocumentInserted)
    End Sub


    Private Function DivideSingleDocumentsData() As ArrayList
        'sollvevo l'evento che indica quanti documenti sono stati trovati

        Dim div As New DataDividerIQI




        Dim result As ArrayList = div.GetDocumentListFromRawData(Data)

        m_DocumentsFound = result.Count

        RaiseEvent DocumentsFound(m_DocumentsFound)

        Return result


    End Function




    Public Sub StartImport()


        m_DataRetriver.ValidateAndParsePath()
        m_DataRetriver.StartImport()
        Data = HashTableFromInpsTemplateConverter.ConvertToIQITemplateHashList(m_DataRetriver.Importresult)

        If Data.Count = 0 Then
            Throw New Exception("Nulla da importare")
        End If

        FileLogName = FileLogName & Now.ToString("ddMMyyyy__hhmm")
        FileLogName = String.Format("{0}\{1}.txt", m_LogPath, FileLogName)

        m_RowReference = 0

        Dim docs As ArrayList = DivideSingleDocumentsData()

        'Adesso bisogna ciclare sui dati per inserrli attraverso i comandi
        Dim i As Int32 = 0

        For Each elem As ArrayList In docs
            i = i + 1
            RaiseEvent BeginDocumentWriting()
            Dim startElement As Int32
            Try
                My.Computer.FileSystem.WriteAllText(FileLogName, "***********************" + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(FileLogName, "Log documento " + i.ToString + ": " + DirectCast(elem(0), Hashtable).Item("FILE_NAME") + vbCrLf, True)

                startElement = m_RowReference + 1
                DocumentInserted = 0
                DocumentErrors = 0
                InsertDocumentData(elem)
                My.Computer.FileSystem.WriteAllText(FileLogName, "Termine log documento " + i.ToString + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(FileLogName, "***********************" + vbCrLf, True)
                RaiseEvent WritingDocument(i)
                Inserted = Inserted + elem.Count - DocumentErrors
            Catch ex As Exception
                RaiseEvent NotifyDocumentError("Errore nel salvataggio del documento " + i.ToString + ": " + ex.Message + vbCrLf)
                My.Computer.FileSystem.WriteAllText(FileLogName, String.Format("Errore nel salvataggio del documento di riga (da/a): {0}/{1}; {2}{3}{3}", startElement, m_RowReference, ex.Message, vbCrLf), True)
                My.Computer.FileSystem.WriteAllText(FileLogName, "Termine log documento " + i.ToString + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(FileLogName, "***********************" + vbCrLf, True)

            End Try


        Next


        'RaiseEvent EndImport(Errors, Inserted)

    End Sub
    Protected Sub WriteRequiredData(ByVal RecordData As Hashtable)

        Dim CheckReferente As New ExsistReferenteChecKer

        Dim CheckUtente As New ExistUserForIQAChecker

        Dim ControllerPrestazioni As New WIN.APPLICATION.ADMINISTRATION.ControllerPrestazioni()

        Dim InsertReferente As New InsertReferenteCommand(RecordData)

        Dim InsertUtente As New InsertUtentiCommand(RecordData)

        Dim InsertTipoPrestazione As New InsertTipoPrestazioneCommand(RecordData)




        Try

            m_RowReference = m_RowReference + 1


            If Not CheckReferente.Exist(RecordData) Then
                InsertReferente.Execute()
            End If




            'inserimento utenti
            If Not CheckUtente.Exist(RecordData) Then
                InsertUtente.Execute()

            End If



             'inserisco la  prestazione e il tipo prestazione
            InsertTipoPrestazione.Execute()

            'creo la prestazione legata alla quota
            CreaPrestazioneUtente(RecordData, ControllerPrestazioni)

            'Inserted = Inserted + 1
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(FileLogName, "Riga numero:" & m_RowReference & "; " & ex.Message & vbCrLf & vbCrLf, True)
            'Errors = Errors + 1
            'Throw
        End Try
    End Sub


    Private Shared Sub CreaPrestazioneUtente(ByVal RecordData As Hashtable, ByVal ControllerPrestazioni As WIN.APPLICATION.ADMINISTRATION.ControllerPrestazioni)
        'recupero i dati dell'utente
        Dim nomeUt As String = RecordData.Item("NOME_UTENTE")
        Dim CognomeUt As String = RecordData.Item("COGNOME_UTENTE")
        Dim fiscale As String = RecordData.Item("FISCALE")
        If Not RecordData.Item("DATA_NASCITA_UTENTE") Is Nothing Then
            RecordData.Item("DATA_NASCITA_UTENTE") = RecordData.Item("DATA_NASCITA_UTENTE").ToString().Replace(" 0.00.00", "")
        Else
            RecordData.Item("DATA_NASCITA_UTENTE") = ""
        End If

        'reupero gli atri dati per la prestazione
        If Not RecordData.Item("DATA_INIZIO") Is Nothing Then
            RecordData.Item("DATA_INIZIO") = RecordData.Item("DATA_INIZIO").ToString().Replace(" 0.00.00", "")
        Else
            RecordData.Item("DATA_INIZIO") = DateTime.Now.ToShortDateString
        End If

        Dim data As DateTime = RecordData.Item("DATA_INIZIO")
        Dim nomeRef As String = RecordData.Item("NOME_REFERENTE")
        Dim CognomeRef As String = RecordData.Item("COGNOME_REFERENTE")
        'adesso devo inserire la prestazione inps
        'Per fare questo ho biosgno dell'id dell'utente
        Dim idUtente As String = -1
        idUtente = UtenteRetriever.GetIdUtente(fiscale, nomeUt, CognomeUt, RecordData.Item("DATA_NASCITA_UTENTE"))


        'una volta recuperato l'id dell'utente posso anche verificare se appartiene al settore edile ed impostare il campo settore
        'nella hash table
        If DelegheEdiliCounterRetriever.GetNumeroDelegheEdili(idUtente) > 0 Then
            If Not RecordData.ContainsKey("SETTORE") Then
                RecordData.Add("SETTORE", "EDILE")
            End If
            RecordData.Item("SETTORE") = "EDILE"
        End If


        'ho bisogno dell'id del referente
        Dim idReferente As String = -1
        idReferente = ReferenteRetriever.GetIdReferente(nomeRef, CognomeRef)

        Dim idTipoPrestazione As Int32 = TipoPrestazioneRetriever.GetIdTipoPrestazione(RecordData.Item("TIPO_PRESTAZIONE"))

        Dim idPrest As Int32 = -1

        If Not String.IsNullOrEmpty(RecordData.Item("DOMANDA")) Then
            'se c'è un domanda verfico che non ci sia una prestaszione avente il numero della domanda tra le note
            'se esite una tale prestazione allora leghero' la quota a questa prestazione
            'altrimenti ne creo una nuova

            'eseguo la ricerca
            idPrest = ControllerPrestazioni.GetIdPrestazioniUtentePatternNote(idUtente, RecordData.Item("DOMANDA").ToString)

            If idPrest = -1 Then
                'creo la prestazione
                ControllerPrestazioni.CreateNew(data.Date, DateTime.Now.Date, "Domanda Inps num. " + RecordData.Item("DOMANDA").ToString, idUtente, idReferente, idTipoPrestazione)

                idPrest = ControllerPrestazioni.IdPrestazione
            End If
        Else


            'creo la prestazione
            ControllerPrestazioni.CreateNew(data.Date, DateTime.Now.Date, "", idUtente, idReferente, idTipoPrestazione)

            idPrest = ControllerPrestazioni.IdPrestazione

        End If



        'aggiungo l'id della prestazione creata all'hash table in modo che alla creazione della quota inps
        'ho il riferimento alla prestazione
        If Not RecordData.ContainsKey("ID_PRESTAZIONE") Then
            RecordData.Add("ID_PRESTAZIONE", idPrest)
        End If
        RecordData.Item("ID_PRESTAZIONE") = idPrest

    End Sub


    Protected Sub WriteIq(singleDocument_Data As ArrayList)

        RaiseEvent BeginWritingIQA()
        InsertElement(singleDocument_Data)
        RaiseEvent EndWritingIQA()


    End Sub

    Protected Overridable Sub InsertElement(singleDocument_Data As ArrayList)
        InsertIQI = New InsertIQICommand(singleDocument_Data, FileLogName)
        InsertIQI.Execute()
    End Sub


    Protected Sub m_DataRetriver_BeginParse() Handles m_DataRetriver.BeginParse
        RaiseEvent BeginParse()
    End Sub

    Private Sub m_DataRetriver_BeginParseFile(filename As String, number As Integer) Handles m_DataRetriver.BeginParseFile
        RaiseEvent BeginParseFile(filename, number)
    End Sub

    Private Sub m_DataRetriver_BeginParsePath() Handles m_DataRetriver.BeginParsePath
        RaiseEvent BeginParsePath()
    End Sub

    Protected Sub m_DataRetriver_BeginRetrieving() Handles m_DataRetriver.BeginRetrieving
        RaiseEvent BeginRetrieving()
    End Sub

    Private Sub m_DataRetriver_EndCreatingRecord(sheet As Object, hash As System.Collections.Hashtable) Handles m_DataRetriver.EndCreatingRecord
        hash.Add("TIPO_PRESTAZIONE", sheet.Cells(6, 7).Value)
    End Sub

    Protected Sub m_DataRetriver_EndParse(ByVal NumberOfRecords As Integer, ByVal NumberOfFields As Integer) Handles m_DataRetriver.EndParse
        RaiseEvent EndParse(NumberOfRecords)
    End Sub

    Private Sub m_DataRetriver_EndParseFile(filename As String, exception As System.Exception) Handles m_DataRetriver.EndParseFile
        RaiseEvent EndParseFile(filename, exception)
    End Sub

    Private Sub m_DataRetriver_EndParsePath(NumberOfFilesFound As Integer) Handles m_DataRetriver.EndParsePath
        RaiseEvent EndParsePath(NumberOfFilesFound)
    End Sub

    Protected Sub m_DataRetriver_EndRetrieving(ByVal NumberOfRecords As Integer) Handles m_DataRetriver.EndRetrieving
        RaiseEvent EndRetrieving(NumberOfRecords)
    End Sub

    Protected Sub m_DataRetriver_RetrievingRecord(ByVal IdRecord As Integer) Handles m_DataRetriver.RetrievingRecord
        RaiseEvent RetrievingRecord(IdRecord)
    End Sub

    Protected Sub InsertIQA_AddingRacord(ByVal num As Integer) Handles InsertIQI.AddingRecord
        RaiseEvent AddingRecord(num)
    End Sub

    Protected Sub InsertIQA_AddingRecordError(ByVal num As Integer) Handles InsertIQI.AddingRecordError
        Errors = Errors + 1
        DocumentErrors = DocumentErrors + 1
    End Sub
End Class
