Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES

Public Class IscrittiExporter


    Private m_Iscritti As IList
    Private m_header As ExportHeader

    Private m_Cancelled As Boolean = False

    Public Event BeginExport()
    Public Event EndExport()
    Public Event Exporting(ByVal percentage As Int32, ByVal cancel As Boolean)



    Public ReadOnly Property Cancelled() As Boolean
        Get
            Return m_Cancelled
        End Get
    End Property


    Public Sub New(ByVal iscritti As IList, ByVal header As ExportHeader)
        m_Iscritti = iscritti
        m_header = header
    End Sub




    Public Function CreateTrace(ByVal expDeleghe As Boolean, ByVal expDocs As Boolean, ByVal expRichieste As Boolean, ByVal expVertenze As Boolean, ByVal expPrestazioni As Boolean) As ExportTrace
        Dim t As New ExportTrace
        Dim cancel As Boolean = False
        m_Cancelled = False
        'qui creo la traccia di esportazione
        RaiseEvent BeginExport()

        'dati esportazione
        t.ExportDate = DateTime.Now
        t.ExportType = ExprtType.ProgramExport
        'dati responsabile
        t.ExporterMail = m_header.Mail
        t.ExporterName = m_header.Responsible
        'dati di settore
        t.Sector = m_header.Sector
        'dati periodo

        Dim p As SubscriptionPeriod = m_header.CalculatePeriod()
        t.InitialDate = p.InitialDate
        t.EndDate = p.EndDate
        t.Period = p.PeriodNumber
        t.Year = p.Year
        t.PeriodType = p.PeriodType
        'credenziali
        t.UserName = m_header.Username
        t.Province = m_header.Province
        t.Password = m_header.Password
        'struttura

        t.Struttura = "FENEAL"



        'definisco un contatore
        Dim i As Int32 = 0


        'qui ciclo su tutti i lavoratori e ne 
        'costuisco il worker dto
        For Each elem As IscrittoDTO In m_Iscritti
            AddWorker(t, CreateWorkerDTO(elem, i + 1, expDeleghe, expDocs, expRichieste, expVertenze, expPrestazioni))
            RaiseEvent Exporting(Convert.ToInt32(100 / m_Iscritti.Count * i), cancel)
            If cancel Then
                Return Nothing
                m_Cancelled = True
            End If
            i = i + 1
        Next




        RaiseEvent EndExport()

        Return t
    End Function


    Private Sub AddWorker(ByVal exportTrace As ExportTrace, ByVal worker As WorkerDTO)
        If worker Is Nothing Then
            Return
        End If
        If exportTrace.Workers Is Nothing Then
            exportTrace.Workers = New WorkerDTO() {}
        End If

        Array.Resize(Of WorkerDTO)(exportTrace.Workers, exportTrace.Workers.Length + 1)
        exportTrace.Workers(exportTrace.Workers.Length - 1) = worker

    End Sub


    Private Function CreateWorkerDTO(ByVal worker As IscrittoDTO, ByVal counter As Int32, ByVal expDeleghe As Boolean, ByVal expDocs As Boolean, ByVal expRichieste As Boolean, ByVal expVertenze As Boolean, ByVal expPrestazioni As Boolean)
        Dim dto As New WorkerDTO
        Dim dtoSub As New SubscriptionDTO

        'verifico i dati utente recuperati con il report
        If (worker.Codice_Fiscale Is Nothing) Then
            worker.Codice_Fiscale = ""
        End If
        If (worker.Nome_Comune_Nascita Is Nothing) Then
            worker.Nome_Comune_Nascita = ""
        End If
        If (worker.Nome_Comune Is Nothing) Then
            worker.Nome_Comune = ""
        End If
        If (worker.Indirizzo Is Nothing) Then
            worker.Indirizzo = ""
        End If
        If (worker.Cap Is Nothing) Then
            worker.Cap = ""
        End If
        If (worker.Cell1 Is Nothing) Then
            worker.Cell1 = ""
        End If
      
        '//verifico i dati iscrizione provenienti dal report
        If (worker.AziendaImpiego Is Nothing) Then
            worker.AziendaImpiego = ""
        End If

        If (worker.Contratto Is Nothing) Then
            worker.Contratto = ""
        End If

        If (worker.Livello Is Nothing) Then
            worker.Livello = ""
        End If
      

        'dati lavoratore
        dto.BirthDate = worker.DataNascita
        dto.Fiscalcode = worker.Codice_Fiscale
        dto.Surname = worker.Cognome
        dto.Name = worker.Nome
        dto.BirthPlace = worker.Nome_Comune_Nascita
        dto.LivingPlace = worker.Nome_Comune
        dto.Address = worker.Indirizzo
        dto.Cap = worker.Cap
        dto.Phone = worker.Cell1
        dto.RowNumber = counter

        'dati di iscrizione
        dtoSub.Sector = m_header.Sector
        dtoSub.Entity = m_header.Entity
        dtoSub.EmployCompany = worker.AziendaImpiego
        dtoSub.FiscalCode = RetrievePartitaIva(worker.Id_Azienda_Impiego.ToString())
        dtoSub.Contract = worker.Contratto
        dtoSub.Level = worker.Livello
        dtoSub.Quota = worker.Importo  ' da completare


        Dim p As SubscriptionPeriod = m_header.CalculatePeriod()
        dtoSub.InitialDate = p.InitialDate
        dtoSub.EndDate = p.EndDate
        dtoSub.Semester = p.PeriodNumber
        dtoSub.Year = p.Year
        dtoSub.PeriodType = p.PeriodType

        dtoSub.Province = m_header.Province


        Dim pr As Provincia = GeoLocationFacade.Instance.GetGeoHandler().GetProvinciaByName(m_header.Province)
        Dim reg As Regione = GeoLocationFacade.Instance.GetGeoHandler().GetRegioneById(pr.IdRegione.ToString())

        dtoSub.Region = reg.ToString()


        dto.Subscription = dtoSub


        'a questo punto posso recuperare i documenti del lavoratore

        RetrieveDocuments(dto, worker.Id_Utente, expDeleghe, expDocs, expRichieste, expVertenze, expPrestazioni)






        Return dto



    End Function

    Private Function RetrievePartitaIva(ByVal id_Azienda As String) As String

        Dim c As New AZIENDE.ControllerAziende

        If id_Azienda = "0" Then
            Return ""
        End If


        Try

            c.LoadById(id_Azienda)

            Return c.PartitaIva

        Catch ex As Exception
            Return ""
        End Try


    End Function

    Public Sub RetrieveDocuments(ByVal dto As WorkerDTO, ByVal idUtente As Int32, ByVal expDeleghe As Boolean, ByVal expDocs As Boolean, ByVal expRichieste As Boolean, ByVal expVertenze As Boolean, ByVal expPrestazioni As Boolean)


        Try

            'per prima cosa rupero l'oggetto dalla base dati
            Dim c As New WIN.APPLICATION.UTENTI.ControllerUtenti

            c.LoadById(idUtente)


            Dim u As Utente = c.Current


            dto.Documents = New DocumentDTO() {}


            'a questo punto ho tutti i dati necessari
            If (expDeleghe) Then
                AddDeleghe(dto, u)
            End If


            'Archivio documenti
            If (expDocs) Then
                AddDocumenti(dto, u)
            End If


            'Richieste di lavoro
            If (expRichieste) Then
                AddRichieste(dto, u)
            End If


            'Vertenze
            If (expVertenze) Then
                AddVertenze(dto, u)
            End If


            'Prestazioni
            If (expPrestazioni) Then
                AddPrestazioni(dto, u)
            End If





        Catch ex As Exception

            'se va in errore non fa nulla



        End Try

    End Sub


    Private Sub AddDeleghe(ByVal dto As WorkerDTO, ByVal Utente As Utente)

        If Utente.Deleghe.Count > 0 Then

            For Each elem As Delega In Utente.Deleghe

                Dim doc As New DocumentDTO

                doc.DocumentDate = elem.DataDocumento
                doc.DocumentType = "Delega"
                doc.Province = dto.Subscription.Province
                doc.Region = dto.Subscription.Region
                doc.State = elem.StatoDelega.StatusName.ToString
                doc.Notes = "Settore: " + elem.Settore.Descrizione + " - Ente: " + elem.EnteInoltro.Descrizione


                'lo aggiungo all'array
                Array.Resize(Of DocumentDTO)(dto.Documents, dto.Documents.Length + 1)
                dto.Documents(dto.Documents.Length - 1) = doc

            Next

        End If

    End Sub

    Private Sub AddDocumenti(ByVal dto As WorkerDTO, ByVal Utente As Utente)

        If Utente.ArchivioDocumenti.Documenti.Count > 0 Then

            For Each elem As ElectronicDocument In Utente.ArchivioDocumenti.Documenti

                Dim doc As New DocumentDTO

                doc.DocumentDate = elem.Data
                doc.DocumentType = "Archivio documentale"
                doc.Province = dto.Subscription.Province
                doc.Region = dto.Subscription.Region
                doc.State = elem.TipoDocumentazione.Descrizione
                doc.Notes = ""


                'lo aggiungo all'array
                Array.Resize(Of DocumentDTO)(dto.Documents, dto.Documents.Length + 1)
                dto.Documents(dto.Documents.Length - 1) = doc

            Next

        End If

    End Sub

    Private Sub AddRichieste(ByVal dto As WorkerDTO, ByVal Utente As Utente)

        If Utente.Preferenze.Count > 0 Then

            For Each elem As Preferenza In Utente.Preferenze

                Dim doc As New DocumentDTO

                doc.DocumentDate = elem.Data
                doc.DocumentType = "Richiesta lavoro"
                doc.Province = dto.Subscription.Province
                doc.Region = dto.Subscription.Region
                doc.State = ""
                doc.Notes = elem.Abilita.Descrizione


                'lo aggiungo all'array
                Array.Resize(Of DocumentDTO)(dto.Documents, dto.Documents.Length + 1)
                dto.Documents(dto.Documents.Length - 1) = doc

            Next

        End If

    End Sub








    Private Sub AddPrestazioni(ByVal dto As WorkerDTO, ByVal Utente As Utente)

        Dim c As New WIN.APPLICATION.ADMINISTRATION.ControllerPrestazioni
        c.LoadAllByUtente(Utente.Id)



        If c.LoadedObjects.Count > 0 Then

            For Each elem As Prestazione In c.LoadedObjects

                Dim doc As New DocumentDTO

                doc.DocumentDate = elem.DataDocumento
                doc.DocumentType = "Prestazione"
                doc.Province = dto.Subscription.Province
                doc.Region = dto.Subscription.Region
                doc.State = ""
                doc.Notes = "Tipo prestazione: " + elem.TipoPrestazione.Descrizione


                'lo aggiungo all'array
                Array.Resize(Of DocumentDTO)(dto.Documents, dto.Documents.Length + 1)
                dto.Documents(dto.Documents.Length - 1) = doc

            Next

        End If

    End Sub


    Private Sub AddVertenze(ByVal dto As WorkerDTO, ByVal Utente As Utente)

        Dim c As New WIN.APPLICATION.ADMINISTRATION.ControllerVertenze
        c.LoadAllByUtente(Utente.Id)



        If c.LoadedObjects.Count > 0 Then

            For Each elem As Vertenza In c.LoadedObjects

                Dim doc As New DocumentDTO

                doc.DocumentDate = elem.DataDocumento
                doc.DocumentType = "Vertenza"
                doc.Province = dto.Subscription.Province
                doc.Region = dto.Subscription.Region
                doc.State = "Controparte: " + elem.Azienda.Descrizione
                Dim notes As String = ""
                If elem.ListaItituti.Count > 0 Then
                    notes = "Istituti contrattuali: "
                    For Each elem1 As IstitutoContrattuale In elem.ListaItituti
                        notes = notes + elem1.Descrizione + "; "
                    Next

                End If
                doc.Notes = notes


                'lo aggiungo all'array
                Array.Resize(Of DocumentDTO)(dto.Documents, dto.Documents.Length + 1)
                dto.Documents(dto.Documents.Length - 1) = doc

            Next

        End If

    End Sub





End Class
