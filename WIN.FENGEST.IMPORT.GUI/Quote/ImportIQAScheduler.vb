Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES
Imports WIN.BASEREUSE

Public Class ImportIQAScheduler

    Public Event DocumentsFound(ByVal NumberOfDocuments As Int32)
    Public Event BeginDocumentWriting()
    Public Event WritingDocument(idDocument As Int32)
    Public Event EndImport(ByVal Errors As Int32, ByVal Inserted As Int32)
    Public Event NotifyDocumentError(errorData As String)

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
    Protected FileLogName = "ImportIQA"
    Protected WithEvents m_DataRetriver As DataRetrieverIQA
    Protected ListOfCommands As New Hashtable
    Protected Data As ArrayList
    Protected Errors As Int32 = 0
    Protected Inserted As Int32 = 0
    Protected WithEvents InsertIQA As InsertIQACommand
    Protected WithEvents InsertIQP As InsertIQPCommand
    Protected m_checkPaybility As Boolean = False
    Protected m_updateUt As Boolean = False
    Protected m_updateAz As Boolean = False
    Protected m_addDelega As Boolean = False
    Protected m_DocumentsFound As Int32
    Dim m_RowReference As Int32

    Protected DocumentErrors As Int32 = 0
    Protected DocumentInserted As Int32 = 0



    Public Property CheckPaybility() As Boolean
        Get
            Return m_checkPaybility
        End Get
        Set(ByVal value As Boolean)
            m_checkPaybility = value
        End Set
    End Property

    Public Sub New(ByVal Filename As String, ByVal LogFilePath As String, ByVal updateUtenti As Boolean, ByVal updateAziende As Boolean, ByVal addDelega As Boolean)
        m_DataRetriver = New DataRetrieverIQA(Filename)
        m_LogPath = LogFilePath
        m_updateUt = updateUtenti
        m_updateAz = updateAziende
        m_addDelega = addDelega


    End Sub

    Private Sub InsertDocumentData(singleDocument_Data As ArrayList)
        'Adesso bisogna ciclare sui dati per inserrli attraverso i comandi
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

        Dim div As New DataDivider


     

        Dim result As ArrayList = div.GetDocumentListFromRawData(Data)

        m_DocumentsFound = result.Count

        RaiseEvent DocumentsFound(m_DocumentsFound)

        Return result


    End Function




    Public Sub StartImport()
        m_DataRetriver.OpenExcel()
        m_DataRetriver.ParseData()
        Data = m_DataRetriver.RetrieveData()
        m_DataRetriver.Dispose()
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
                My.Computer.FileSystem.WriteAllText(FileLogName, "Log documento " + i.ToString + vbCrLf, True)

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
        Dim CheckContratto As New ExsistContractChecker
        Dim CheckReferente As New ExsistReferenteChecKer
        Dim CheckAzienda As New ExsistAziendaChecker
        Dim CheckAziendaImpiego As New ExistAzindaImpiegoChecker
        Dim CheckUtente As New ExistUserForIQAChecker


        Dim InsertContratto As New InsertContrattoCommand(RecordData)
        Dim InsertReferente As New InsertReferenteCommand(RecordData)
        Dim InsertAzienda As New InsertAziendeCommand(RecordData)
        Dim InsertAziendaImpiego As New InsertAziendeCommand(RecordData, True)
        Dim InsertUtente As New InsertUtentiCommand(RecordData)
        'Dim InsertIQA As New InsertIQACommand(Data)

        Try

            m_RowReference = m_RowReference + 1

            If Not CheckContratto.Exist(RecordData) Then
                InsertContratto.Execute()
            End If
            If Not CheckReferente.Exist(RecordData) Then
                InsertReferente.Execute()
            End If

            'Inserimento aziende settore edile
            If Not RecordData.Item("SETTORE") = "EDILE" Then
                If Not CheckAzienda.Exist(RecordData) Then
                    InsertAzienda.Execute()
                Else
                    If m_updateAz Then
                        'solo in caso di aggiornamento notfico un eventuale errore ma non 
                        'esco dal ciclo perchè l'oggetto risulta cmq esistente
                        Try
                            Dim chkAz As New UpdateAziendaCommand(RecordData, CheckAzienda.GetId)
                            chkAz.Execute()
                        Catch ex1 As ImportAziendaException
                            My.Computer.FileSystem.WriteAllText(FileLogName, "Errore di aggiornamento: " & ex1.Message & vbCrLf & vbCrLf, True)
                        End Try
                    End If
                End If
            End If
            'inserimento aziende settore impianti fissi
            If RecordData.Item("SETTORE") = "EDILE" Then
                If Not CheckAziendaImpiego.Exist(RecordData) Then
                    InsertAziendaImpiego.Execute()
                Else
                    If m_updateAz Then
                        'solo in caso di aggiornamento notfico un eventuale errore ma non 
                        'esco dal ciclo perchè l'oggetto risulta cmq esistente
                        Try
                            Dim chkAz As New UpdateAziendaCommand(RecordData, CheckAziendaImpiego.GetId)
                            chkAz.Execute()
                        Catch ex1 As ImportAziendaException
                            My.Computer.FileSystem.WriteAllText(FileLogName, "Errore di aggiornamento: " & ex1.Message & vbCrLf & vbCrLf, True)
                        End Try
                    End If
                End If
            End If


            'inserimento utenti
            If Not CheckUtente.Exist(RecordData) Then
                InsertUtente.Execute()
            Else
                'solo in caso di aggiornamento notfico un eventuale errore ma non 
                'esco dal ciclo perchè l'oggetto risulta cmq esistente
                If m_updateUt Then
                    Try
                        Dim chkUt As New UpdateUtenteCommand(RecordData, CheckUtente.GetId)
                        chkUt.Execute()
                    Catch ex2 As ImportUtenteException
                        My.Computer.FileSystem.WriteAllText(FileLogName, "Errore di aggiornamento: " & ex2.Message & vbCrLf & vbCrLf, True)
                    End Try
                End If
            End If



            'inserisco la delega per l'utente nel caso la quota non è pagabile
            If m_addDelega Then

                Try


                    RecordData.Item("DATA_INIZIO") = RecordData.Item("DATA_INIZIO").ToString.Replace(" 0.00.00", "")
                    RecordData.Item("DATA_FINE") = RecordData.Item("DATA_FINE").ToString.Replace(" 0.00.00", "")


                    Dim insertDelega As New InsertDelegaCommand(CreaHash(RecordData), True, New DataRange(RecordData.Item("DATA_INIZIO"), RecordData.Item("DATA_FINE")))
                    insertDelega.Execute()

                    If insertDelega.Inserted Then
                        Dim nomeUtente As String = RecordData.Item("COGNOME_UTENTE") + " " + RecordData.Item("NOME_UTENTE")
                        My.Computer.FileSystem.WriteAllText(m_LogPath + "\DelegheInserite.txt", "Delega automaticamente inserita per l'utente " + nomeUtente + Environment.NewLine, True)
                    End If




                Catch ex As ImportDelegaException
                    My.Computer.FileSystem.WriteAllText(FileLogName, "Errore nella creazione della delega: " & ex.Message & vbCrLf & vbCrLf, True)
                End Try






            End If




            'Inserted = Inserted + 1
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(FileLogName, "Riga numero:" & m_RowReference & "; " & ex.Message & vbCrLf & vbCrLf, True)
            'Errors = Errors + 1
            'Throw
        End Try
    End Sub



    Private Function CreaHash(ByVal Hashtable As Hashtable) As Hashtable
        'in questa funzione devo ricreare una hash table come quando importo le deleghe
        Dim result As New Hashtable

        Dim accettazione As DateTime

        Try
            accettazione = DirectCast(Hashtable.Item("DATA_INIZIO"), DateTime).AddDays(-1)
        Catch ex As Exception
            accettazione = DateTime.Now.Date
        End Try


        result.Add("NOTE", "Delega automaticamente generata attraverso la registrazione dell'incasso quota associativa del " + DateTime.Now.ToString)
        result.Add("DATA_NASCITA_UTENTE", Hashtable.Item("DATA_NASCITA_UTENTE"))
        result.Add("NOME_UTENTE", Hashtable.Item("NOME_UTENTE"))
        result.Add("COGNOME_UTENTE", Hashtable.Item("COGNOME_UTENTE"))
        result.Add("FISCALE", Hashtable.Item("FISCALE"))
        result.Add("PARTITA_IVA", Hashtable.Item("PARTITA_IVA"))
        result.Add("NOME_REFERENTE", Hashtable.Item("NOME_REFERENTE"))
        result.Add("COGNOME_REFERENTE", Hashtable.Item("COGNOME_REFERENTE"))
        result.Add("SETTORE", Hashtable.Item("SETTORE"))
        result.Add("ENTE", Hashtable.Item("ENTE"))
        result.Add("REVOCATA_A", "")
        result.Add("SEDE_OPERATIVA", "")
        result.Add("DATA", accettazione)
        result.Add("REPARTO", "")
        result.Add("DATA_ACCETTAZIONE", accettazione)

        result.Add("DATA_ANNULLAMENTO", "")
        result.Add("DATA_REVOCA", "")





        Return result
    End Function


    Protected Sub WriteIq(singleDocument_Data As ArrayList)

        RaiseEvent BeginWritingIQA()
        InsertElement(singleDocument_Data)
        RaiseEvent EndWritingIQA()


    End Sub

    Protected Overridable Sub InsertElement(singleDocument_Data As ArrayList)
        InsertIQA = New InsertIQACommand(singleDocument_Data, FileLogName, m_checkPaybility)
        InsertIQA.Execute()
    End Sub


    Protected Sub m_DataRetriver_BeginParse() Handles m_DataRetriver.BeginParse
        RaiseEvent BeginParse()
    End Sub

    Protected Sub m_DataRetriver_BeginRetrieving() Handles m_DataRetriver.BeginRetrieving
        RaiseEvent BeginRetrieving()
    End Sub

    Protected Sub m_DataRetriver_EndParse(ByVal NumberOfRecords As Integer, ByVal NumberOfFields As Integer) Handles m_DataRetriver.EndParse
        RaiseEvent EndParse(NumberOfRecords)
    End Sub

    Protected Sub m_DataRetriver_EndRetrieving(ByVal NumberOfRecords As Integer) Handles m_DataRetriver.EndRetrieving
        RaiseEvent EndRetrieving(NumberOfRecords)
    End Sub

    Protected Sub m_DataRetriver_RetrievingRecord(ByVal IdRecord As Integer) Handles m_DataRetriver.RetrievingRecord
        RaiseEvent RetrievingRecord(IdRecord)
    End Sub

    Protected Sub InsertIQA_AddingRacord(ByVal num As Integer) Handles InsertIQA.AddingRecord
        RaiseEvent AddingRecord(num)
    End Sub

    Protected Sub InsertIQA_AddingRecordError(ByVal num As Integer) Handles InsertIQA.AddingRecordError
        Errors = Errors + 1
        DocumentErrors = DocumentErrors + 1
    End Sub
End Class
