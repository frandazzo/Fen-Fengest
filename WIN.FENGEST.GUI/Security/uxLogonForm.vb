Imports WIN.SECURITY

Public Class uxLogonForm

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub uxLogonButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxLogonButton.Click
        If SecurityManager.Instance.Logon(uxUserTextBox.Text, uxPassTextBox.Text) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
            uxErrorLabel.Text = SecurityManager.Instance.LastError
            uxErrorLabel.Visible = True
        End If
    End Sub

    Private Sub uxCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxCancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub uxUserTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxUserTextBox.Enter
        uxErrorLabel.Visible = False
        uxUserTextBox.SelectAll()
    End Sub

    Private Sub uxPassTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxPassTextBox.Enter
        uxErrorLabel.Visible = False
        uxPassTextBox.SelectAll()
    End Sub

    Private Sub uxLogonForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

      

            Dim ApplicationTitle As String
            Dim controller As New FenealgestSorftwareInfoHandler


            controller.LoadById(1)


            If My.Application.Info.Title <> "" Then
                ApplicationTitle = My.Application.Info.Title
            Else
                ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If


            Me.lblVers.Text = String.Format("Versione software: {0}", Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString)




            Me.lblDB.Text = "Versione database: " & controller.DBVersion.ToString


        Catch ex As Exception
            Throw New Exception("Connessione non disponibile!", ex)
        End Try
    End Sub
End Class