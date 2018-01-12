Public NotInheritable Class FrmInformazioni



    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Imposta il titolo del form.
        Dim ApplicationTitle As String

        Dim controller As New FenealgestSorftwareInfoHandler

        controller.LoadById(1)





        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Informazioni su {0}", ApplicationTitle)
        ' Inizializza tutto il testo visualizzato nella finestra di dialogo Informazioni su.
        ' TODO: Personalizzare le informazioni sull'assembly dell'applicazione nel riquadro "Applicazione" 
        '    della finestra delle proprietà del progetto (accessibile dal menu "Progetto").
        'Me.LabelProductName1.Text = My.Application.Info.ProductName
        Me.LabelVersion1.Text = String.Format("Versione software: {0}", Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString)
        ' Me.LabelCopyright1.Text = My.Application.Info.Copyright




        Me.DBTypeLabel.Text = "Tipo database: " & PersistenceInfo.ServiceName
        Me.LabelDBVersion.Text = "Versione database: " & controller.DBVersion.ToString
        Me.MaxCacheSizeLabel.Text = "Massima dimensione della cache: " & PersistenceInfo.MaxCacheSize
        Me.CustomPersistenceAssemblyNameLabel.Text = "Assembly servizio di persistenza: " & PersistenceInfo.CustomPersistentServiceAssembly

        Dim arr As String() = PersistenceInfo.ConnectionStringParameters
        txtConnextionStringparameters.Text += Environment.NewLine
        If arr.Length > 0 Then
            For i As Int16 = 0 To arr.Length - 1
                Dim elem As String = arr(i)
                elem = elem.Trim
                If Not elem.StartsWith("Password") Then
                    txtConnextionStringparameters.Text += Environment.NewLine & elem
                End If
            Next
        End If


    End Sub

   Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
      Me.Close()
   End Sub




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("http://www.tecnoesis.it")
    End Sub
End Class
