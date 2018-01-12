Imports System.Windows.Forms
Imports WIN.APPLICATION
Imports System.Text
Imports System.IO
Imports WIN.DOMAIN.FEDERATIONARTIFACTS.ImportExport
Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES.FenealgestImportExport
Imports System.Reflection

Public Class ImportExportIQAManager

    Private m_fileToElaborate As String
    Private m_data As IList
    Private m_logFileDirectory As String
    Private m_logFile As String
    Private importedDocumentId As Int32
    Private m_iqaTrace As IQATrace


    Private Sub SetFileLogName()
        m_logFile = "BackgruondIQAImporter"
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


        My.Computer.FileSystem.WriteAllText(m_logFile, "***********************AVVIO ELABORAZIONE***********************" + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(m_logFile, "AVVIO IMPORTAZIONE LOCALE***********************" + vbCrLf, True)
        'definisco la classe per l'importazione dei dati
        Dim importer As New BackgroundIQAImporter(m_data, m_logFile, True, False, True)

        'avvio l'importazione
        importer.Import()

        'verifico se un documento  è stato effettivamente creato
        importedDocumentId = importer.ReturnedDocumentId


        My.Computer.FileSystem.WriteAllText(m_logFile, "***********************" + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(m_logFile, "TERMINE IMPORTAZIONE LOCALE***********************" + vbCrLf, True)

        'adesso se trovo nella directory corrente un file che si chiama OnlyLocal.txt
        'non procedo
        Dim assemblyPath As String = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")
        Dim path1 As String = Path.GetDirectoryName(assemblyPath)
        Dim stoppingFile = Path.Combine(path1, "OnlyLocal.txt")
        If File.Exists(stoppingFile) Then
            My.Computer.FileSystem.WriteAllText(m_logFile, "Esiste il file onlyLocal.txt. Non verrà esportato nulla al database nazionale!!!" + vbCrLf, True)


            Try

                My.Computer.FileSystem.WriteAllText(m_logFile, "Avvio scrittura esito importExport Fenealgest" + vbCrLf, True)
                'salvo tutto in un record importExport su fenealgestLocale
                Dim cont As New ControllerImportExport
                Dim elab As New ImportExport

                elab.LogFilePath = m_logFile
                elab.ImportedFile = m_fileToElaborate
                elab.Type = ImportExport.ElaborationType.IQA
                elab.CreatedDocumentId = importedDocumentId
                elab.Subject = m_iqaTrace.Subject
                elab.Result = ResultType.FileRenamed
                elab.LiberiImportedData = ""

                cont.SaveOrUpdateImportExport(elab)
                My.Computer.FileSystem.WriteAllText(m_logFile, "Termine scrittura esito importExport Fenealgest" + vbCrLf, True)
            Catch ex As Exception
                My.Computer.FileSystem.WriteAllText(m_logFile, "Errore nella scrittura dell'esito dell'import export: " + ex.Message + vbCrLf, True)
            End Try




            Return
        Else
            My.Computer.FileSystem.WriteAllText(m_logFile, "Non esiste il file onlyLocal.txt. Si procede con l'esportazione al database nazionale!!!" + vbCrLf, True)
        End If

        'esporto solamente se ho effettivamente creato una documento di quote associative
        If importedDocumentId > 0 Then
            My.Computer.FileSystem.WriteAllText(m_logFile, "E' stato creato il cocumento IQA con ID = " + importedDocumentId.ToString + vbCrLf, True)


            My.Computer.FileSystem.WriteAllText(m_logFile, "AVVIO PROCESSO ESPORTAZIONE***********************" + vbCrLf, True)
            'aquesto punto se un documento è staot creato posso avviare l'esportaizone
            Dim exporter As New BackgroundExporter(m_data, m_iqaTrace.Anno, m_iqaTrace.Period, m_iqaTrace.Entity, m_logFile, m_iqaTrace.Provincia, m_iqaTrace.Subject, m_iqaTrace.Mailto)

            'avvio l'esportazione
            exporter.Export()
        Else
            My.Computer.FileSystem.WriteAllText(m_logFile, "Nessun documento è stato importato pertanto non si procederà all'esportaizone al db nazionale" + vbCrLf, True)

        End If

        Try

            My.Computer.FileSystem.WriteAllText(m_logFile, "Avvio scrittura esito importExport Fenealgest" + vbCrLf, True)
            'salvo tutto in un record importExport su fenealgestLocale
            Dim cont As New ControllerImportExport
            Dim elab As New ImportExport

            elab.LogFilePath = m_logFile
            elab.ImportedFile = m_fileToElaborate
            elab.Type = ImportExport.ElaborationType.IQA
            elab.CreatedDocumentId = importedDocumentId
            elab.Subject = m_iqaTrace.Subject
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
        elab.Type = ImportExport.ElaborationType.IQA
        elab.CreatedDocumentId = importedDocumentId
        elab.Result = fileRenameResult
        elab.Subject = "Errore avvenuto prima dell'inizio del processo. Da sottoporre all'amministratore del sistema"
        elab.LiberiImportedData = ""
        cont.SaveOrUpdateImportExport(elab)

    End Sub
    Private Sub TryRenameFileToElaborsate(ByVal b As StringBuilder)


        'prima di richiamare la CreateInportExportFailureToFenealgest
        'tento di rinominare il file da importare

        Try

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

            If Not IO.File.Exists(m_fileToElaborate) Then
                b.AppendLine("File da elaborare inesistente")
                CreateInportExportFailureToFenealgest(b, ResultType.FileNotRenamed)

                Throw New Exception("FileToElaborate not exist")
            End If

            b.AppendLine("Inizio deserializzazione traccia")
            'deserializzo la traccia
            m_iqaTrace = ObjectXMLSerializer(Of IQATrace).Load(m_fileToElaborate)
            b.AppendLine("Termine deserializzazione traccia")
            'se la traccia è nulla posso uscire dall'esportazione 
            If m_iqaTrace Is Nothing Then

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
            m_data = m_iqaTrace.ToDetailsHashArrayList
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
        Dim gg As New ControllerSegreteria
        gg.LoadById("1")

        Dim dir As String = gg.DirectoryPreferenziale

        Dim newFile As String = Path.Combine(dir, "Elaborated_" + filename)

        File.Move(m_fileToElaborate, newFile)
        m_fileToElaborate = newFile

    End Sub





End Class
