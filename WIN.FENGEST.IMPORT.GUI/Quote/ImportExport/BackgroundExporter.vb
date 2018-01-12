Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES
Imports WIN.APPLICATION
Imports System.IO

Public Class BackgroundExporter

    Private m_data As ArrayList
    Private m_year As Int32
    Private m_period As Int32
    Private m_entity As String
    Private m_provincia As String
    Private m_subject As String
    Private m_mailto As String
    Private m_logFile As String
    Dim Controller As New WIN.APPLICATION.REPORTING.ReportIscritti


    Public Sub New(data As ArrayList, year As Int32, period As Int32, entity As String, logFile As String, provincia As String, subject As String, mailto As String)
        m_data = data
        m_period = period
        m_year = year
        m_entity = entity
        m_logFile = logFile

        m_provincia = provincia
        m_subject = subject
        m_mailto = mailto

    End Sub



    Public Sub Export()
        Try

            Log("Inizio recupero dati da inviare dal fenealgest locale")
            'recupero la lista degli iscritti
            Dim subscriptions As IList = ExecuteQuery()
            Log("Dati recuperati corretamente dal fenealgest locale")


            Log("Inizio creazione traccia di export")
            'creo la exportTrace che dovrà essere inviata al server
            Dim exp As ExportTrace = CreateTrace(subscriptions)
            Log("Termine creazione traccia di export")


            'avvio il programma di export
            Log("Avvio del programma di export")
            SendToExportProgram(exp)


        Catch ex As Exception
            Log("Processo di esportazione terminato con errori prima dell'avvio del programma di esportazione: " + ex.Message)
        End Try
       





    End Sub

    Private Function ExecuteQuery() As Collections.IList

        'per prima cosa ottengo dal primo elemento dei dati
        'l'ente, e la data di inizio e fine per il report
        Try

     
            Dim firstRow = DirectCast(m_data(0), Hashtable)
            Dim startDate As DateTime = firstRow.Item("DATA_INIZIO")
            Dim endtDate As DateTime = firstRow.Item("DATA_FINE")
            Dim entity As String = firstRow.Item("ENTE")

            'a questo punto ho tutto pronto per fare un query

            Dim Controller As New WIN.APPLICATION.REPORTING.ReportIscritti
            Controller.SetCompetenza(startDate, endtDate)
            Controller.SetSettore("EDILE")
            Controller.SetEnte(entity)


            Return Controller.SearchDTOs


         Catch ex As Exception
            Log("Errore nella ricerca degli iscritti")
            Throw
        End Try

    End Function

    Private Sub Log(message As String)
        If File.Exists(m_logFile) Then
            My.Computer.FileSystem.WriteAllText(m_logFile, message + vbCrLf, True)
        End If
    End Sub

    Private Function CreateTrace(subscriptions As IList) As ExportTrace

        'recupero le credenziali del dbnazionale
        Dim c As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()
        'valido gli input
        Dim h As New ExportHeader("Servizio fenealgest", "EDILE", m_entity, m_mailto, m_year, m_period, c.UserName, c.Password, c.Provincia)


        Try
            'eseguo la vreifica
            h.CheckValidity()
        Catch ex As Exception
            Log("Errore nella validazione dell'header della exportTrace: " + ex.Message)
            Throw
        End Try

        Try
            'creo la classe che recupera i dati per creare la traccia
            Dim exporter As New IscrittiExporter(subscriptions, h)
            Return exporter.CreateTrace(False, False, False, False, False)

        Catch ex1 As Exception
            Log("Errore nella creazione dell'header della exportTrace: " + ex1.Message)
            Throw
        End Try

    End Function




    Private Sub SendToExportProgram(ByVal export As ExportTrace)
        'in questa funzione preparo i parametri per l'avvio del programma

        'per prima cosa salvo la traccia su un fiule xml
        Dim tempDir As String = IO.Path.GetTempPath

        Dim fileName As String = IO.Path.Combine(tempDir, "export.xml")

        'salvo il file che farò riprendere all'altro programma
        WIN.TECHNICAL.MIDDLEWARE.XmlSerializzation.ObjectXMLSerializer(Of ExportTrace).Save(export, fileName)


        'recupero il percorso del programma di export
        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
        'Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
        'Dim f As New IO.FileInfo(path)
        'path = f.DirectoryName + exportProgram
        Dim exportProgram As String = "\WebConnector\WIN.WEBCONNECTOR.exe"


        Dim f As New FileInfo(path)

        'path = f.DirectoryName + file

        path = f.Directory.FullName + exportProgram

        If Not File.Exists(path) Then
            'qui loggo il fatto che il programma per esportare i dati non è installato
            Log("WIN.WEBCONNECTOR non è installato al percorso: " + path)
            Return
        End If




        'definisco i parametri di apertura del programma
        Dim args As New ProcessStartInfo
        args.Arguments = ConstuctArguments(fileName)
        Log("WIN.WEBCONNECTOR avviato con i seguenti parametri: " + args.Arguments)
        'passo il nome del programma da avviare
        args.FileName = path

        'avvio il programma
        Process.Start(args)

    End Sub

    Private Function ConstuctArguments(ByVal traceFile As String) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()



        Dim chk As String = """chk:no"""
        Dim log As String = """log:" + m_logFile + """"
        Dim fil As String = """fil:" + traceFile + """"
        Dim ent As String = """ent:" + m_entity + """"
        Dim com As String = """com:5"""

        result = chk + " " + com + " " + fil + " " + log + " " + ent


        Return result
    End Function

End Class
