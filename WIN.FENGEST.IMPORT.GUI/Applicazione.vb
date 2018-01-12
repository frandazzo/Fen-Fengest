Imports WIN.SECURITY
Imports WIN.GUI.APPLICATION.PRESENTATION
Imports System.Windows.Forms
Imports WIN.BASEREUSE
Imports WIN.APPLICATION
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.IO

Public Class Applicazione

    Public Shared Function CertificateValidationCallBack(sender As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean



        Return True


    End Function
    Shared Sub main(ByVal cmdArgs() As String)

        Dim parameter As String = ""
        Dim parameterUserName As String = ""
        Dim parameterPassword As String = ""

        ServicePointManager.ServerCertificateValidationCallback = AddressOf CertificateValidationCallBack


        'se ci sono più parametri i primi due devono essere username e password
        'gli altri parametri seguono
        If cmdArgs.Length > 0 Then

            parameterUserName = cmdArgs(0)
            parameterPassword = cmdArgs(1)
            'parameter = cmdArgs(2)
        End If







        System.Windows.Forms.Application.EnableVisualStyles()

        'inizializzo il componente per la gestione degli elementi geografici
        GeoLocationFacade.InitializeInstance(New GeoPersistenceService())



        SecurityManager.Instance.AddAssembly(GetType(Applicazione).Assembly)
        'SecurityManager.Instance.AddAssembly(GetType(FrmImportLiberi).Assembly)

        SecurityManager.Instance.SecureDataAccess = New WIN.APPLICATION.SecureDataManager



        If cmdArgs.Length = 0 Then
            Dim log As New uxLogonForm
            log.ShowDialog()


            If log.DialogResult = DialogResult.Cancel Then
                Exit Sub
            End If

        ElseIf cmdArgs.Length = 2 Then

            If Not SecurityManager.Instance.Logon(parameterUserName, parameterPassword) Then
                Exit Sub
            End If


        ElseIf cmdArgs.Length = 4 Then

            Dim command As String = cmdArgs(2)
            Dim file As String = cmdArgs(3)


            'creo un file di testo con i parametri di input

            Dim fname As String = "WIN_IMPORT_GUI.txt"
            'recupero la cartella dove c'è il file scaricato
            Dim f As New FileInfo(file)

            fname = IO.Path.Combine(f.DirectoryName, fname)

            'IO.File.AppendAllText(fname, String.Format("Avvio programma WIN.IMPOT.GUI alle {0}: parametro command = {1}; parametro file = {2}", DateTime.Now.ToLongDateString, command, file))


            'avvio l'importazione in background
            If command = "iqa" Then
                Try
                    'avvio l'import iqa
                    Dim i As New ImportExportIQAManager(file)
                    i.StartProcess()
                    Return
                Catch ex As Exception
                    IO.File.AppendAllText(fname, String.Format("Errore nell'importer iqa: {0}, {1}", DateTime.Now.ToLongDateString, ex.Message))
                    Return
                End Try

            ElseIf command = "liberi" Then
                Try
                    'avvio il command liberi
                    Dim i As New ImportExportLiberiManager(file)
                    i.StartProcess()
                    Return
                Catch ex As Exception
                    IO.File.AppendAllText(fname, String.Format("Errore nell'importer libeir: {0}, {1}", DateTime.Now.ToLongDateString, ex.Message))
                    Return
                End Try

            Else 'inps
                Try
                    'avvio il command liberi
                    Dim i As New ImportInpsManager(file)
                    i.StartProcess()
                    Return
                Catch ex As Exception
                    IO.File.AppendAllText(fname, String.Format("Errore nell'importer inps: {0}, {1}", DateTime.Now.ToLongDateString, ex.Message))
                    Return
                End Try

            End If
        End If


        Dim frm As New Form1
        frm.ShowDialog()
    End Sub
End Class
