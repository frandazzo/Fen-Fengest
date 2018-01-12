Public Class FrmCreateRendiconto

    Private PreecedingRendiconto As Rendiconto


    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        SpinEdit1.Value = DateTime.Now.Year
    End Sub
    Private Sub cmdAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnnulla.Click
        Me.Close()

    End Sub

    Private Function GetRendicontoType() As RendicontoType
        Dim rendicontoType As RendicontoType
        If RadioGroup1.EditValue = "Provinciale" Then
            rendicontoType = FEDERATIONARTIFACTS.RendicontoType.Provinciale
        ElseIf RadioGroup1.EditValue = "Regionale" Then
            rendicontoType = FEDERATIONARTIFACTS.RendicontoType.Regionale
        Else
            rendicontoType = FEDERATIONARTIFACTS.RendicontoType.RLST
        End If
        Return rendicontoType
    End Function
    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOK.Click
        Try


            Dim rendicontoType As RendicontoType = GetRendicontoType()

            If String.IsNullOrEmpty(MemoEdit1.Text) Then
                MessageBox.Show("Inserire una descrizione per il rendiconto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'creo il rendiconto
            Dim controller As New ControllerRendiconto
            Dim rendiconto As Rendiconto = controller.CreateRendiconto(rendicontoType, MemoEdit1.Text, Convert.ToInt32(SpinEdit1.Value), PreecedingRendiconto)
            '  controller.ViewRendiconto(rendiconto)
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        lblRend.Text = "Nessun rendiconto precedente è stato impostato"
        PreecedingRendiconto = Nothing
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Try

            Dim frm As New FrmViewRendiconti(GetRendicontoType, False)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PreecedingRendiconto = frm.CurrentRendiconto
                lblRend.Text = String.Format("Rendiconto {0} dell'anno {1}", PreecedingRendiconto.Tipo.ToString, PreecedingRendiconto.Anno)
            End If
            frm.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdRemovePreceding_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemovePreceding.Click
        lblRend.Text = "Nessun rendiconto precedente è stato impostato"
        PreecedingRendiconto = Nothing

    End Sub
End Class