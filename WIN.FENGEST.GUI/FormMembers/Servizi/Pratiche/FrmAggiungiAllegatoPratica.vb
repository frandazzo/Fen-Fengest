Public Class FrmAggiungiAllegatoPratica
    Private m_current As Pratica
    Private m_currentDocument As PraticaDetail
    Public Sub New(pratica As Pratica, detail As PraticaDetail)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_current = pratica
        m_currentDocument = detail

        If m_currentDocument Is Nothing Then
            lblAllegato.Text = "Nessun allegato"
        Else
            lblAllegato.Text = m_currentDocument.Filename
            TextBox1.Text = m_currentDocument.Notes
            TextBox1.Enabled = False
        End If



    End Sub




    Private Sub cmdAnnulla_Click(sender As Object, e As EventArgs) Handles cmdAnnulla.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        'se ho visualizzato un dociumento chiudi e basta
        If Not m_currentDocument Is Nothing Then
            Me.Close()
        Else
            'altrimenti creo l'allegato alla pratica se esiste l'allegato
            'verificando che esista l'allegato
            If lblAllegato.Text = "Nessun allegato" Then
                MessageBox.Show("Inserire un allegato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            SaveDocument()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If
    End Sub

    Public Sub SaveDocument()
        Try
            Dim detail As New PraticaDetail
            detail.Data = DateTime.Now
            detail.FilePath = lblAllegato.Text
            detail.Notes = TextBox1.Text

            'aggiungo il dettaglio alla pratica
           
            m_current.AddDetail(detail)

            Dim c As New ControllerPratiche
            c.SaveOrUpdatePratica(m_current)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try

    End Sub

    Private Sub lblAllegato_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAllegato.LinkClicked
        Try

            'se sono in modalità di visualizzazione visualizzo il file
            If Not m_currentDocument Is Nothing Then
                Process.Start(m_currentDocument.FilePath)
            Else
                'altrimenti visulaizzo l'elemento per aggiungere un allegaTO
                Dim frm As New FrmAllegaFile()
                frm.Destination = m_current.Utente.DirectoryPreferenziale
                Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog

                If dialog = Windows.Forms.DialogResult.OK Then
                    lblAllegato.Text = frm.FileName
                End If
                frm.Dispose()
            End If




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub
End Class