Public Class ControlPrepareRptLib
   Private WithEvents Controller As New WIN.APPLICATION.REPORTING.ReportLiberi
   Dim controllersettori As New ControllerSettori
   Dim controllerContratti As New ControllerTipoContratto
   'Dim controllerReparti As New ControllerReparti
   Dim frm As FrmElaborazioneInCorso
   Dim list As IList = New ArrayList
   Public Sub New()
      InitializeComponent()

      Me.m_IdShowedObject = 0
      DoLoad()

   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Selezione criteri report lavoratori liberi"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report lavoratori liberi "
        Me.lblCurrentFunction.Text = UCase("Selezione criteri report lavoratori liberi ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Selezione criteri report  lavoratori liberi"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.lblDescrizioneAzienda.Text = ""
        Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)
        ' InterfaceMediator.LoadCombo(cboReparto, controllerReparti.GetListaCausali, True)

    End Sub



#End Region



   Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
      Dim cont As New AZIENDE.ControllerAziende
      InterfaceMediator.GetSimpleDescription(cont, "Descrizione", Me.lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
   End Sub

   Public Sub SetSearchConditions()

      Me.ControlSelPeriodiMensili1.CalcolaDate()
      Controller.SetEnte(cboEnti.Text)
      Controller.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
      Controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
      Controller.SetRicercaErrori(chkErr.Checked)

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
      list = Controller.Search
   End Sub

   Private Sub NavigateToReport()
      Dim map As New Hashtable
      map.Add("ReportingService", Controller)
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
      Me.Cursor = Windows.Forms.Cursors.Default
      MasterControl.Instance.ParentForm.Text = "Selezione criteri report iscritti"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Selezione criteri report iscritti "
      Me.lblCurrentFunction.Text = UCase("Selezione criteri report iscritti ")
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
   End Sub

   'Private Sub Controller_ElaborationIncremented(ByVal Percentage As Integer, ByRef Cancel As Boolean) Handles Controller.ElaborationIncremented
   '   frm.SetPercentage(Percentage)
   '   If frm.Annulla Then Cancel = True
   'End Sub
End Class
