Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlReparti
   Private controllerCausali As New ControllerReparti
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
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " reparti"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " reparti "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  reparti")
        SelectToolStripImage()
    End Sub




#Region "Metodi per Load iniziale"

    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        'Me.CustomBar1.SetTargetControl(Me)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Annulla)
        Try
            For Each elem As String In controllerCausali.GetListaCausali()
                lstCausali.Items.Add(elem)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region


   Private Sub ReLoad()
      Try
         lstCausali.Items.Clear()
            Nested_LoadDataFromDataSource()
      Catch ex As Exception
         Throw (New Exception(ex.Message))
      End Try
   End Sub



    <Secure(Area:="Reparti", Alias:="Creazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Reparti", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub


    <Secure(Area:="Reparti", Alias:="Cancellazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub


   Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
      Try
            Nested_CheckSecurityForChanging()
         If lstCausali.SelectedIndex = -1 Then
            MsgBox("Non � stato selezionato alcun reparto per l'aggiornamento. Selezionare un reparto.", MsgBoxStyle.Information)
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
            MsgBox("Non � stato selezionato alcun reparto per l'eliminazione. Selezionare un reparto.", MsgBoxStyle.Information)
            Exit Sub
         End If
         If MsgBox("Il reparto sar� eliminato solamente se nel sistema non ci sono altri riferimenti al reparto. Sicuro di voler cancellare il reparto selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
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
         Dim frm As New FrmCausaliRevoca(New ControllerReparti, FrmCausaliRevoca.OperazioneCausali.Add)
         frm.ShowDialog()
         ReLoad()
      Catch ex As AccessDeniedException
         MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
      Try
         'Save()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick
      Try
         Dim print As PrintFacade = New PrintFacade
         print.PrintListaReparti(controllerCausali)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub lstCausali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCausali.Click
      If lstCausali.SelectedIndex = -1 Then
         Exit Sub
      End If
      controllerCausali.LoadByDescrizione(lstCausali.SelectedItem.ToString)
   End Sub
End Class
