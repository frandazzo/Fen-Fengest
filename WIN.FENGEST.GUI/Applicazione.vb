Imports WIN.SECURITY
Imports System.Security.Cryptography.X509Certificates
Imports System.Net

Public Class Applicazione
    Shared Sub main(ByVal cmdArgs() As String)
        Dim mdi As New MDIForm
        Dim parameter As String = ""
        Dim parameterUserName As String = ""
        Dim parameterPassword As String = ""

        Dim iniL As New InizializzatoreL
        Dim IniSec As New InizializzatoreSicurezza
        Dim comIni As New InizializzatoreComandi
        Dim iniGeo As New InizializzazioneGeoHandler

        Try
            ServicePointManager.ServerCertificateValidationCallback = AddressOf CertificateValidationCallBack
            System.Windows.Forms.Application.EnableVisualStyles()
            'Inizializzo l'applicazione
            iniL.Inizializza()
            IniSec.Inizilaizza()
            comIni.Inizializza()
            iniGeo.Inizializza()

            'Eseguo il login
            If cmdArgs.Length = 0 Then

                Dim log As New uxLogonForm
                log.ShowDialog()

                If log.DialogResult = DialogResult.Cancel Then
                    Exit Sub
                End If

            Else

                parameterUserName = cmdArgs(0)
                parameterPassword = cmdArgs(1)

                If Not SecurityManager.Instance.Logon(parameterUserName, parameterPassword) Then
                    Exit Sub
                End If

                'If cmdArgs.Length = 3 Then
                '    Dim id As Int32 = 0
                '    Try

                '        id = Convert.ToInt32(cmdArgs(2))
                '        mdi.idUtente = id
                '        mdi.openFromCardReader = True
                '    Catch ex As Exception
                '        MessageBox.Show(ex.Message + ":" + cmdArgs(2))

                '        Return
                '    End Try
                'End If

            End If



            mdi.ShowDialog()



        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Public Shared Function CertificateValidationCallBack(sender As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean



        Return True


    End Function






End Class
