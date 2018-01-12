Imports System.Drawing
Imports WIN.APPLICATION
Imports WIN.DOMAIN.FEDERATIONARTIFACTS.ImportExport
Imports System.IO
Imports System.Text
Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES.FenealgestImportExport

Public Class ImportInpsManager
    Private m_fileToElaborate As String
    Private m_data As IList
    Private m_logFileDirectory As String
    Private m_logFile As String
    Private m_inpsTrace As InpsTrace



    Private Function DivideSingleDocumentsData() As ArrayList
        'sollvevo l'evento che indica quanti documenti sono stati trovati

        Dim div As New DataDividerIQI




        Dim result As ArrayList = div.GetDocumentListFromRawData(m_data)





        Return result


    End Function


    Private Sub SetFileLogName()
        m_logFile = "BackgruondInpsImporter"
        m_logFile = m_logFile & Now.ToString("ddMMyyyy__hhmm")
        m_logFile = String.Format("{0}\{1}.txt", m_logFileDirectory, m_logFile)

        IO.File.Delete(m_logFile)

        IO.File.AppendAllText(m_logFile, "AVVIO PROCESSO")

    End Sub

    Public Sub New(fileToElaborate As String)


        m_fileToElaborate = fileToElaborate



        RetrieveDataFromFile()


    End Sub



    Public Sub StartProcess()
        'questa funzione parte da un file ben formato con una lista quote associative da tramutare
        ' nella forma canonica di hash table
        'questo file è stato scaricato dal server fenealgest
        'e dovrà essere elaborato nella seguante manierà:
        'sarà importato come quote associative in fenealgest locale
        'sarà esportato al db nazionale
        'verrà inserita una notifica nel database locale di avvenuta elaborazione con i seguenti campi:

        'data elaborazione
        'file di log
        'file elaborato dal server
        'tipo di elaboraizone
        'id dell' IQA creato
        'oggetto dell'elaborazione 
        'risultato su file importato (rinominato o no)


        My.Computer.FileSystem.WriteAllText(m_logFile, "***********************AVVIO ELABORAZIONE INPS***********************" + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(m_logFile, "AVVIO IMPORTAZIONE LOCALE QUOTE INPS***********************" + vbCrLf, True)
        'definisco la classe per l'importazione dei dati
        Dim importer As New BackgroundInpsImporter(m_data, m_logFile)

        'avvio l'importazione
        importer.Import()




        My.Computer.FileSystem.WriteAllText(m_logFile, "***********************" + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(m_logFile, "TERMINE IMPORTAZIONE LOCALE***********************" + vbCrLf, True)




        'invio una mail


        My.Computer.FileSystem.WriteAllText(m_logFile, "Invio mail di notifica***********************" + vbCrLf, True)

        Try
            Dim c As New ControllerSegreteria
            c.LoadById(1)

            Dim sender As String = "Feneal " + c.ComuneLegale
            Dim body As String = "Importazione delle quote inps terminata "
           

            Dim subject As String = m_inpsTrace.Subject

            Dim tos As String() = m_inpsTrace.Mailto.Split(New Char() {","c})

            Dim data As New FenealgestServices.MailData

            data.body = body
            data.sender = sender
            data.subject = subject
            data.tos = tos

            Dim svc As New FenealgestServices.FenealgestwebServices
            svc.SendMailFromFenealgest(data)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(m_logFile, "Errore nell'invio della mail di notifica dell'avvenuta importazione dei file delle quote inps" + vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(m_logFile, ex.Message + vbCrLf, True)
        End Try

        My.Computer.FileSystem.WriteAllText(m_logFile, "Termine invio mail di notifica***********************" + vbCrLf, True)

        'qui devo inviare la mail di notifica

        Try

            My.Computer.FileSystem.WriteAllText(m_logFile, "Avvio scrittura esito importExport Fenealgest" + vbCrLf, True)
            'salvo tutto in un record importExport su fenealgestLocale
            Dim cont As New ControllerImportExport
            Dim elab As New ImportExport

            elab.LogFilePath = m_logFile
            elab.ImportedFile = m_fileToElaborate
            elab.Type = ImportExport.ElaborationType.Inps
            elab.CreatedDocumentId = 0
            elab.Subject = m_inpsTrace.Subject
            elab.Result = ResultType.FileRenamed
            elab.LiberiImportedData = ""

            cont.SaveOrUpdateImportExport(elab)
            My.Computer.FileSystem.WriteAllText(m_logFile, "Termine scrittura esito importExport Fenealgest" + vbCrLf, True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(m_logFile, "Errore nella scrittura dell'esito dell'import export: " + ex.Message + vbCrLf, True)
        End Try


    End Sub

    Private Sub CreateInportExportFailureToFenealgest(ByVal b As StringBuilder, fileRenameResult As ResultType)

        Dim fileName As String = "FenealgestImportExportError.txt"

        fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fileName)
        IO.File.Delete(fileName)
        File.AppendAllText(fileName, b.ToString)


        'oltre alla creazione del file creo anche un record di import export in fenealgest
        Dim cont As New ControllerImportExport
        Dim elab As New ImportExport

        elab.LogFilePath = m_logFile
        elab.ImportedFile = m_fileToElaborate
        elab.Type = ImportExport.ElaborationType.Liberi
        elab.CreatedDocumentId = 0
        elab.Result = fileRenameResult
        elab.Subject = "Errore avvenuto prima dell'inizio del processo. Da sottoporre all'amministratore del sistema"
        elab.LiberiImportedData = ""
        cont.SaveOrUpdateImportExport(elab)

    End Sub
    Private Sub TryRenameFileToElaborsate(ByVal b As StringBuilder)


        'prima di richiamare la CreateInportExportFailureToFenealgest
        'tento di rinominare il file da importare

        Try

            'prendo il nome del file
            RenameFile()


            CreateInportExportFailureToFenealgest(b, ResultType.FileRenamedWithoutHasBeenProcessed)
        Catch ex As Exception
            b.AppendLine(ex.Message)
            CreateInportExportFailureToFenealgest(b, ResultType.FileNotRenamed)

        End Try



    End Sub
    Private Sub RetrieveDataFromFile()
        'qui recupero i dati necessari per far lavorare la classe correttamtne

        'i dati della folder della segreteria
        'i dati presi dalla deserializzazione del file ecc



        'se va in errore qui è un bel problema
        '************************************************************+++++

        'qualunque cosa accada qui creo un file sul desktop
        Dim b As New StringBuilder


        'avvio il recupero della direcotri della segreteria

        b.AppendLine("WIN.IMPORT.GUI*************")
        b.AppendLine("Avvio recupero segreteria")

        Dim cseg As New ControllerSegreteria
        cseg.LoadById("1") 'carico la segreteria
        b.AppendLine("Segreteria caricata")
        b.AppendLine("Recupero directory preferenziale segreteria")
        m_logFileDirectory = cseg.DirectoryPreferenziale 'prendo la cartella di default

        If Not Directory.Exists(m_logFileDirectory) Then
            b.AppendLine("Direcotry segreteria inesistente***************************")
            CreateInportExportFailureToFenealgest(b, ResultType.FileNotRenamed)
            Throw New Exception("Direcotry segretria nulla")
        End If
        b.AppendLine("Directory preferenziale segreteria recuperata e validata")


        b.AppendLine("Inizio creazione del file di log")
        'al termine creo il file di log
        SetFileLogName()

        'verifico il file di log
        If Not File.Exists(m_logFile) Then
            b.AppendLine("File di log inesistente***************************")

            CreateInportExportFailureToFenealgest(b, ResultType.FileNotRenamed)

            Throw New Exception("file di log nullo")
        End If

        'se arrivo a questo punto tutto è stato correttamente creato

        b.AppendLine("File di log correttamente creato")

        '************************************************************+++++
        Try

            'verifico che il file esiste
            If Not IO.File.Exists(m_fileToElaborate) Then
                b.AppendLine("File da elaborarare inesistente***************************" + m_fileToElaborate)
                CreateInportExportFailureToFenealgest(b, ResultType.FileNotRenamed)
                Throw New Exception("File da elaborare inesistente")
            End If

            'deserializzo la traccia
            b.AppendLine("Inizio deserializzazione traccia")
            m_inpsTrace = ObjectXMLSerializer(Of InpsTrace).Load(m_fileToElaborate)
            b.AppendLine("Termine deserializzazione traccia")
            'se la traccia è nulla posso uscire dall'esportazione 
            If m_inpsTrace Is Nothing Then

                TryRenameFileToElaborsate(b)

                'esco dal flusso
                Throw New Exception("Deserializzazione traccia da file non riuscita: traccia nulla!")

            End If

            'adesso rinomino il file per indicare ad un eventuale servizio che non è più disponibilie
            b.AppendLine("Inizio rinomina file")
            RenameFile()
            b.AppendLine("File da importare rinominato correttamente : " + m_fileToElaborate)


        Catch ex As Exception
            b.AppendLine("Deserializzazione traccia da file non riuscita:  " + ex.Message)
            TryRenameFileToElaborsate(b)
            Throw
        End Try




        Try
            'creo i dati dalla traccia
            m_data = m_inpsTrace.ToDetailsHashArrayList
        Catch ex As Exception
            b.AppendLine("Errore nella trasformazione della traccia in elementi hashtable:  " + ex.Message)
            CreateInportExportFailureToFenealgest(b, ResultType.FileRenamedWithoutHasBeenProcessed)
            Throw
        End Try


        'se sono arrivato fino a qui allora è tutto pronto per avviare il processo di elaborazione

        File.AppendAllText(m_logFile, b.ToString)



    End Sub

    Private Sub RenameFile()
        'prendo il nome del file
        Dim filename As String = Path.GetFileName(m_fileToElaborate)


        'prendo la directory di arrivo 
        Dim gg As New ControllerSegreteria
        gg.LoadById("1")

        Dim dir As String = gg.DirectoryPreferenziale

        Dim newFile As String = Path.Combine(dir, "Elaborated_" + filename)

        File.Move(m_fileToElaborate, newFile)
        m_fileToElaborate = newFile

    End Sub



End Class
