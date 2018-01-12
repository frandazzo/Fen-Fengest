Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlCausaleComunicazione
   Private controllerCausali As New ControllerCausaleComunicazione
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
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " causale comunicazione"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " causale comunicazione "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  causale comunicazione")
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


    <Secure(Area:="Causali comunicazione", Alias:="Creazione", Macroarea:="Setup")> _
     Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Causali comunicazione", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub


    <Secure(Area:="Causali comunicazione", Alias:="Cancellazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub


   Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
      Try
            Nested_CheckSecurityForChanging()
         If lstCausali.SelectedIndex = -1 Then
            MsgBox("Non è stata selezionato alcuna causale comunicazione per l'aggiornamento. Selezionare una causale comunicazione.", MsgBoxStyle.Information)
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
            MsgBox("Non è stata selezionata alcuna causale comunicazione per l'eliminazione. Selezionare una causale comunicazione.", MsgBoxStyle.Information)
            Exit Sub
         End If
         If MsgBox("La causale comunicazione sarà eliminata solamente se nel sistema non ci sono altri riferimenti. Sicuro di voler cancellare la causale comunicazione selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione causale comunicazione") = MsgBoxResult.Yes Then
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
         Dim print As PrintFacade = New PrintFacade
         print.PrintReportCausaliComunicazione(controllerCausali)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class
