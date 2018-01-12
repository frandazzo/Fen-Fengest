Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlTipoComunicazione
   Private controller As New ControllerTipoComunicazione
   Public Sub New()
      InitializeComponent()

      Me.m_IdShowedObject = 0
      DoLoad()
        Nested_NotifyParent()

    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " tipo comunicazione"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " tipo comunicazione "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  tipo comunicazione")
        SelectToolStripImage()
    End Sub

   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub
   Private Sub lstCausali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCausali.Click
      If lstCausali.SelectedIndex = -1 Then
         Exit Sub
      End If
      controller.LoadByDescrizione(lstCausali.SelectedItem.ToString)
   End Sub

#Region "Metodi per Load iniziale"

    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        'Me.CustomBar1.SetTargetControl(Me)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Annulla)
        For Each elem As String In controller.GetListaCausali()
            lstCausali.Items.Add(elem)
        Next

    End Sub

#End Region


   Private Sub ReLoad()

      lstCausali.Items.Clear()
        Nested_LoadDataFromDataSource()

   End Sub



    <Secure(Area:="Causali tipi comunicazione", Alias:="Creazione", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Causali tipi comunicazione", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub


    <Secure(Area:="Causali tipi comunicazione", Alias:="Cancellazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub



   Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
      Try
            Nested_CheckSecurityForChanging()
         If lstCausali.SelectedIndex = -1 Then
            MsgBox("Non è stato selezionato alcun tipo comunicazione per l'aggiornamento. Selezionare un tipo comunicazione.", MsgBoxStyle.Information)
            Exit Sub
         End If
         controller.LoadByDescrizione(lstCausali.SelectedItem.ToString)
         Dim frm As FrmCausaliRevoca = New FrmCausaliRevoca(controller, FrmCausaliRevoca.OperazioneCausali.Update)
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
            MsgBox("Non è stata selezionato alcun tipo comunicazione per l'eliminazione. Selezionare un tipo comunicazione.", MsgBoxStyle.Information)
            Exit Sub
         End If
         If MsgBox("Il tipo comunicazione sarà eliminato solamente se nel sistema non ci sono altri riferimenti. Sicuro di voler cancellare il tipo comunicazione selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione causale comunicazione") = MsgBoxResult.Yes Then
            controller.LoadByDescrizione(lstCausali.SelectedItem.ToString)
            controller.Delete()
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
         Dim frm As New FrmCausaliRevoca(controller, FrmCausaliRevoca.OperazioneCausali.Add)
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
         print.PrintReportTipiComunicazione(controller)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class
