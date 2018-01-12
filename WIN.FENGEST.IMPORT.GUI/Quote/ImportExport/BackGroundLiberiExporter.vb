Imports System.IO
Imports WIN.APPLICATION

Public Class BackGroundLiberiExporter
    Private m_data As ArrayList
    Private m_subject As String
    Private m_mailto As String
    Private m_logFile As String

    Dim Controller As New WIN.APPLICATION.REPORTING.ReportIscritti


    Public Sub New(data As ArrayList, logFile As String, subject As String, mailto As String)
        m_data = data

        m_logFile = logFile


        m_subject = subject
        m_mailto = mailto

    End Sub



    Private Function CreateFiscalCodesList() As String
        Try

            Dim fileName As String = Path.GetTempPath

            fileName = Path.Combine(fileName, "xxx.txt")

            If File.Exists(fileName) Then
                File.Delete(fileName)
            End If

            'qui scrivo i codici fiscali
            Dim res As String = ""

            For Each elem As Hashtable In m_data
                Dim cf As String = elem.Item("FISCALE").ToString().Trim

                'tolgo eventuali spazi
                cf.Replace(" ", "")

                If Not String.IsNullOrEmpty(cf) Then
                    res = res + " " + cf
                End If
            Next


            File.AppendAllText(fileName, res)

            Return fileName

        Catch ex As Exception
            Log("Errore nella creazione del file temporaneo con la lista dei codici fiscali da ricercare: " + ex.Message)
            Throw
        End Try
    End Function
    Private Function GetCredenzialiDBNazionale() As Credenziali
        Throw New System.NotImplementedException()
    End Function
    Public Sub Export()
        Try

            'devo creare un file temporaneo con la lista dei codici fiscali
            'come fenealgest
            Log("Inizio creazione dei codici fiscali su file temporaneo ")
            Dim filename As String = CreateFiscalCodesList()
            Log("Creazione dei codici fiscali su file temporaneo completata")

            'ottengo le credenziali per il dbnazionale
            Dim c As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()
            Log("Credenziali db nazionale ottenute")

            'avvio il programma di export
            Log("Avvio programma per la ricerca sul db nazionale")
            SendToConnectionProgram(filename, c)
            Log("Termine chiamata programma per la ricerca sul db nazionale")

        Catch ex As Exception
            Log("Processo di invio mail per dei lavoratori liberi terminato con errori prima dell'avvio del programma di connessione al dbnazionale: " + ex.Message)
        End Try






    End Sub



    Private Sub Log(message As String)
        If File.Exists(m_logFile) Then
            My.Computer.FileSystem.WriteAllText(m_logFile, message + vbCrLf, True)
        End If
    End Sub





    Private Sub SendToConnectionProgram(filenameWithFiscalCodes As String, c As Credenziali)


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
        args.Arguments = ConstuctArguments(filenameWithFiscalCodes, c)
        Log("WIN.WEBCONNECTOR avviato con i seguenti parametri: " + args.Arguments)
        'passo il nome del programma da avviare
        args.FileName = path

        'avvio il programma
        Process.Start(args)

    End Sub

    Private Function ConstuctArguments(ByVal fiscalCodesFile As String, credenziali As Credenziali) As String
        Dim result As String = ""




        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"

        Dim mai As String = """mai:" + m_mailto + """"
        Dim mas As String = """mas:" + m_subject + """"


        Dim chk As String = """chk:no"""
        Dim com As String = """com:6"""

        Dim flc As String = """flc:" + fiscalCodesFile + """"


        result = usn + " " + usp + " " + pro + " " + chk + " " + com + " " + flc + " " + mai + " " + mas


        Return result
    End Function

End Class
