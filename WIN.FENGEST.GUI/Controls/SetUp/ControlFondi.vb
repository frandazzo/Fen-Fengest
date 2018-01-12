Imports WIN.SECURITY.Exceptions
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class ControlFondi
   Private controllerCausali As New ControllerFondi
   Public Sub New()
      InitializeComponent()

      Me.m_IdShowedObject = 0
      DoLoad()
        Nested_NotifyParent()

    End Sub
    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controllerCausali.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " fondo"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " fondo "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  fondo")
        SelectToolStripImage()
    End Sub

   Private Sub lstCausali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCausali.Click
      If lstCausali.SelectedIndex = -1 Then
         Exit Sub
      End If
      controllerCausali.LoadByDescrizione(lstCausali.SelectedItem.ToString)
   End Sub




#Region "Metodi per Load iniziale"

    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        'Me.CustomBar1.SetTargetControl(Me)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Annulla)
        For Each elem As String In controllerCausali.GetListaCausali()
            lstCausali.Items.Add(elem)
        Next

    End Sub

#End Region


   Private Sub ReLoad()

      lstCausali.Items.Clear()
        Nested_LoadDataFromDataSource()

   End Sub


    <Secure(Area:="Fondi", Alias:="Creazione", Macroarea:="Setup")> _
     Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Fondi", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub


    <Secure(Area:="Fondi", Alias:="Cancellazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub


   Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
      Try
            Nested_CheckSecurityForChanging()
         If lstCausali.SelectedIndex = -1 Then
            MsgBox("Non è stata selezionato alcun fondo per l'aggiornamento. Selezionare un fondo.", MsgBoxStyle.Information)
            Exit Sub
         End If
         controllerCausali.LoadByDescrizione(lstCausali.SelectedItem.ToString)
         Dim frm As FrmCausaliRevoca = New FrmCausaliRevoca(controllerCausali, FrmCausaliRevoca.OperazioneCausali.Update)
         frm.ShowDialog()
         ReLoad()
      Catch ex As AccessDeniedException
         MsgBox("Impossibile aggiornare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
      Try
            Nested_CheckSecurityForDeletion()
         If lstCausali.SelectedIndex = -1 Then
            MsgBox("Non è stata selezionata alcun fondo per l'eliminazione. Selezionare un fondo.", MsgBoxStyle.Information)
            Exit Sub
         End If
         If MsgBox("Il fondo sarà eliminata solamente se nel sistema non ci sono altri riferimenti. Sicuro di voler cancellare il fondo selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione fondo") = MsgBoxResult.Yes Then
            controllerCausali.LoadByDescrizione(lstCausali.SelectedItem.ToString)
            controllerCausali.Delete()
            ReLoad()
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
      Try
            Nested_CheckSecurityForCreation()
         Dim frm As New FrmCausaliRevoca(controllerCausali, FrmCausaliRevoca.OperazioneCausali.Add)
         frm.ShowDialog()
         ReLoad()
      Catch ex As AccessDeniedException
         MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
      '
   End Sub


   Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick
      Try
         'Dim print As PrintFacade = New PrintFacade
         'print.PrintReportCausaliComunicazione(controllerCausali)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class

