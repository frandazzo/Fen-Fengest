Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES

Public Class BackgroundInpsImporter

    Private m_data As ArrayList
    Protected m_LogPath As String = ""




    Protected InsertIQI As InsertIQICommand
    Protected Errors As Int32 = 0
    Protected Inserted As Int32 = 0
    Protected DocumentErrors As Int32 = 0
    Protected DocumentInserted As Int32 = 0
    Dim m_RowReference As Int32



    Public ReturnedDocumentId As Int32


    Private Function DivideSingleDocumentsData() As ArrayList
        'sollvevo l'evento che indica quanti documenti sono stati trovati

        Dim div As New DataDividerIQI




        Dim result As ArrayList = div.GetDocumentListFromRawData(m_data)





        Return result


    End Function



    Public Sub New(data As ArrayList, ByVal LogFilePath As String)

        m_data = data
        m_LogPath = LogFilePath
       


    End Sub


    Public Sub Import()




        m_RowReference = 0

        Dim docs As ArrayList = DivideSingleDocumentsData()

        'Adesso bisogna ciclare sui dati per inserrli attraverso i comandi
        Dim i As Int32 = 0

        For Each elem As ArrayList In docs
            i = i + 1

            Dim startElement As Int32
            Try
                My.Computer.FileSystem.WriteAllText(m_LogPath, "***********************" + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(m_LogPath, "Log documento " + i.ToString + ": " + DirectCast(elem(0), Hashtable).Item("FILE_NAME") + vbCrLf, True)

                startElement = m_RowReference + 1
                DocumentInserted = 0
                DocumentErrors = 0
                InsertDocumentData(elem)
                My.Computer.FileSystem.WriteAllText(m_LogPath, "Termine log documento " + i.ToString + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(m_LogPath, "***********************" + vbCrLf, True)

                Inserted = Inserted + elem.Count - DocumentErrors
            Catch ex As Exception

                My.Computer.FileSystem.WriteAllText(m_LogPath, String.Format("Errore nel salvataggio del documento di riga (da/a): {0}/{1}; {2}{3}{3}", startElement, m_RowReference, ex.Message, vbCrLf), True)
                My.Computer.FileSystem.WriteAllText(m_LogPath, "Termine log documento " + i.ToString + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(m_LogPath, "***********************" + vbCrLf, True)

            End Try


        Next
      




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
            My.Computer.FileSystem.WriteAllText(m_LogPath, "Riga numero:" & m_RowReference & "; " & ex.Message & vbCrLf & vbCrLf, True)
            'Errors = Errors + 1
            'Throw
        End Try
    End Sub

    Private Function InsertDocumentData(singleDocument_Data As ArrayList) As Int32
        'Adesso bisogna ciclare sui dati per inserli attraverso i comandi


        For Each elem As Hashtable In singleDocument_Data

            Try
                WriteRequiredData(elem)
            Catch ex As Exception
            End Try

        Next

        InsertElement(singleDocument_Data)
        DocumentInserted = singleDocument_Data.Count - DocumentErrors

    End Function

    Protected Overridable Sub InsertElement(singleDocument_Data As ArrayList)
        InsertIQI = New InsertIQICommand(singleDocument_Data, m_LogPath)
        InsertIQI.Execute()
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
        'RecordData.Item("DATA_INIZIO") = RecordData.Item("DATA_INIZIO").ToString().Replace(" 0.00.00", "")

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
   
End Class
