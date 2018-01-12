Imports WIN.APPLICATION
Imports WIN.BASEREUSE

Public Class Applicazione
    Shared Sub Main(ByVal cmdArgs() As String)



        'Dim connectionString As String = ""
        If cmdArgs.Length > 0 Then
            'For argNum As Integer = 0 To UBound(cmdArgs, 1)
            connectionString = cmdArgs(0)
            dbType = cmdArgs(1)
            federProv = cmdArgs(2)
            'Next argNum
        End If



        Dim controllerSegreteria As New ControllerSegreteria



        controllerSegreteria.LoadById(1)

        federProv = controllerSegreteria.ProvinciaLegale

        connectionString = PersistenceInfo.ConnectionString

        dbType = 1






        Try



            'Avvio l'applicazione
            System.Windows.Forms.Application.EnableVisualStyles()

            'inizializzo il componente per la gestione degli elementi geografici
            GeoLocationFacade.InitializeInstance(New GeoPersistenceService())





            Dim frm As New FormSelezione
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Stampa tessere")
        End Try

    End Sub
End Class

