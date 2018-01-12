Imports WIN.APPLICATION.REPORTING

Public Class ControlPrepareRptdocumenti


    Dim controller As New ReportArchivioDocumenti

    Dim frm As FrmElaborazioneInCorso
    Dim list As IList = New ArrayList
    Public Sub New()
        InitializeComponent()

        Me.m_IdShowedObject = 0
        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        Dim logo As String = "Selezione criteri report archivio documenti"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report archivio documenti"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()

        Dim c As New ControllerTipoDocumentazione()

        InterfaceMediator.LoadCombo(Me.cboTipo, c.GetListaCausali, True)

    End Sub



#End Region





    Public Sub SetSearchConditions()
        ControlSelPeriodiMensili1.CalcolaDate()
        controller.SetCompetenza(ControlSelPeriodiMensili1.MinDate, ControlSelPeriodiMensili1.MaxDate)

        If rptUtenti.Checked Then
            controller.SetTipoRicerca("Utente")
        Else
            controller.SetTipoRicerca("Azienda")
        End If


        controller.SetNomeTipoDocumento(cboTipo.SelectedItem)

        controller.SetIdReferente(IdReferenteTextBox1.TextValue)




    End Sub
    Private Sub CmdRpt_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdRpt.DoClik
        Try
            'frm = New FrmElaborazioneInCorso
            'frm.Show()
            SetGUIPreProcessReport()
            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)
            System.Windows.Forms.Application.DoEvents()

            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop




            'frm.Dispose()
            SetGUIPostProcessReport()
            System.Windows.Forms.Application.DoEvents()

            If list.Count > 0 Then
                NavigateToReport()
            Else
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            End If
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        Catch ex As Exception
            SetGUIPostProcessReport()
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub FillSearchList()
        list = controller.Search
    End Sub

    Private Sub NavigateToReport()
        Dim map As New Hashtable
        map.Add("ReportingService", controller)
        Me.NavigateTo("ViewReport", map)
    End Sub
    Private Sub SetGUIPreProcessReport()

        MasterControl.Instance.ParentForm.Text = "Attendere l'elaborazione del report "
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere l'elaborazione del report "
        Me.lblCurrentFunction.Text = UCase("Attendere   l'elaborazione   del   report ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
    End Sub

    Private Sub SetGUIPostProcessReport()
        Dim logo As String = "Selezione criteri report archivio documenti"
        Me.Cursor = Windows.Forms.Cursors.Default
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub







    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneReferente, IdReferenteTextBox1.TextValue)
    End Sub
End Class
