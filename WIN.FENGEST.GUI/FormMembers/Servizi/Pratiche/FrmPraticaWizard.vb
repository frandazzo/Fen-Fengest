Imports Wizard

Public Class FrmPraticaWizard
    Dim wordHandler As OfficeWordHandler
    Dim controllerCompilazione As New ControllerCompilazioneModelli
    Dim con As New ControllerSegreteria

    Private frm1 As FrmElaborazioneInCorso

    Private m_current As Pratica



    Dim tag1 As String = ""
    Dim tag2 As String = ""
    Dim tag3 As String = ""


    Public Sub New(pratica As Pratica)
        InitializeComponent()

        m_current = pratica
    End Sub

    Private Sub Wizard1_CloseFromCancel(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CloseFromCancel
        If MessageBox.Show("Sicuro di voler uscire dalla procedura guidata?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = False
        End If
    End Sub

    Private Sub ModelPage_CloseFromNext(sender As Object, e As PageEventArgs) Handles ModelPage.CloseFromNext
        If Not My.Computer.FileSystem.FileExists(lblModello.Text) Then
            MessageBox.Show("Selezionare un modello", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Page = ModelPage
        End If
    End Sub

    Private Sub EndPage_CloseFromNext(sender As Object, e As PageEventArgs) Handles EndPage.CloseFromNext
        Try
            Wizard1.CancelEnabled = False
            Wizard1.NextEnabled = False
            Wizard1.BackEnabled = False
            Avvia()
            Wizard1.CancelEnabled = True
            Wizard1.NextEnabled = True
            Wizard1.BackEnabled = True



        Catch ex As Exception
            Wizard1.CancelEnabled = True
            Wizard1.NextEnabled = True
            Wizard1.BackEnabled = True


            ErrorHandler.ShowError(ex)

            e.Page = EndPage
        End Try
    End Sub

    Private Function InitializeHashTable(ByVal utente As Utente) As Hashtable
        Dim hash As New Hashtable
        hash.Add("@Tag1@", tag1)
        hash.Add("@Tag2@", tag2)
        hash.Add("@Tag3@", tag3)

        Return controllerCompilazione.CreateTagValuesMap(utente.Id, hash)


    End Function
    Private Function GenerateDocument() As String

        Dim dest As String = m_current.Utente.DirectoryPreferenziale
        Dim suggestedName As String = GetNomeSuggeritoModello()
        Dim modello As String = lblModello.Text 'My.Settings.PathModelli & "\" & cboModello.Text


        Dim c As New ControllerCompilazioneModelli
        Return c.GenerateDocument(m_current.Utente.Id, modello, GetTagTable(), dest, suggestedName)




    End Function

    Private Function GetTagTable() As Hashtable
        Dim hash As Hashtable = InitializeHashTable()
        Return hash
    End Function

    Private Function InitializeHashTable() As Hashtable
        Dim hash As New Hashtable
        hash.Add("@Tag1@", tag1)
        hash.Add("@Tag2@", tag2)
        hash.Add("@Tag3@", tag3)
        Return hash
    End Function

    Private Function GetNomeSuggeritoModello() As String
        Dim n As String = lblModello.Text
        Dim i As New IO.FileInfo(n)
        n = i.Name

        If n.EndsWith(".dot") Then
            n = n.Replace(".dot", "")
            Return n
        End If

        If n.EndsWith(".dotx") Then
            n = n.Replace(".dotx", "")
            Return n
        End If

        Return "DocumentGenerico"
    End Function

    Private Sub Avvia()
        Try
            Dim doc As String = GenerateDocument()

            'una volta generato il documento lo aggiungo alla pratica
            Dim detail As New PraticaDetail
            detail.Notes = txtNote.Text
            detail.FilePath = doc
            detail.Data = DateTime.Now
            m_current.AddDetail(detail)

            Dim c As New ControllerPratiche
            c.SaveOrUpdatePratica(m_current)

            If My.Computer.FileSystem.FileExists(doc) Then
                SimpleFileSystemManager.ViewFile(doc)
            End If



            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try



    End Sub


    Private Sub cmdModello_Click(sender As Object, e As EventArgs) Handles cmdModello.Click
        Try
            Dim frm As New FrmSelezionaModello
            If frm.ShowDialog = DialogResult.OK Then
                lblModello.Text = frm.FileSelezionato
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdTag_Click(sender As Object, e As EventArgs) Handles cmdTag.Click
        If My.Computer.FileSystem.FileExists(lblModello.Text) Then
            Dim frmTags As New FrmTagSupplementari(tag1, tag2, tag3)
            frmTags.ShowDialog()

            tag1 = frmTags.Tag1
            tag2 = frmTags.Tag2
            tag3 = frmTags.Tag3

            frmTags.Dispose()


        Else
            MessageBox.Show("Selezionare un modello corretto!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub lblModello_Click(sender As Object, e As EventArgs) Handles lblModello.Click
        Try
            If My.Computer.FileSystem.FileExists(lblModello.Text) Then
                System.Diagnostics.Process.Start(lblModello.Text)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class