Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class DelegheMediator
   Public Shared Sub Save(ByVal Control As BrowserControl)

        Control.StartSaveOperation()

   End Sub
   <Secure(Area:="Deleghe", Alias:="Cancellazione", Macroarea:="Deleghe")> _
   Public Shared Sub Delete(ByVal Control As BrowserControl, ByVal Controller As AbstractController, ByVal Message As String)

      Try
         SecurityManager.Instance.Check()
         If MsgBox(Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione delega") = MsgBoxResult.Yes Then
            DirectCast(Controller, ADMINISTRATION.ControllerDeleghe).RemoveCurrentDelegaFouUtente()
            Controller.Delete()
            MasterControl.Instance.GoPrevious()
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   <Secure(Area:="Deleghe", Alias:="Creazione", Macroarea:="Deleghe")> _
   Public Shared Sub CheDelegaForCreation()
      SecurityManager.Instance.Check()
   End Sub



   Public Shared Sub NewDelega(ByVal Control As BrowserControl)
      CheDelegaForCreation()
      Control.NavigateWithoutHistoryTo("CreateDelega")


   End Sub
   Public Shared Sub Annulla(ByVal Control As BrowserControl, ByVal IdUtente As String, ByVal IdDelega As String, ByVal StatusName As String)
      Try

         If Control.State.StateName = "Creazione" Then
            MasterControl.Instance.GoPrevious()
         Else

            Navigate(Control, IdUtente, IdDelega, StatusName)
            ' Control.Cancel()
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Public Shared Sub Navigate(ByVal Control As BrowserControl, ByVal IdUtente As String, ByVal IdDelega As String, ByVal StatusName As String)
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", IdDelega)
         ParameterList.Add("Status", StatusName)
         ParameterList.Add("IdUtente", IdUtente)
         Control.NavigateTo("ViewDelega", ParameterList, True)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Public Shared Sub Navigate(ByVal Control As BrowserControl, ByVal Id As String, ByVal Link As String)

      Dim ParameterList As Hashtable = New Hashtable
      ParameterList.Add("Id", Id)
      ParameterList.Add("IdUtente", "")
      Control.NavigateTo(Link, ParameterList)

   End Sub
   Public Shared Sub NavigateToSettore(ByVal control As BrowserControl, ByVal NomeSettore As String)
      Try
         Dim controller As New ControllerSettori
         Dim id As Int32 = controller.GetIdSettoreByDescrizione(NomeSettore)
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", id)
         control.NavigateTo("ViewSettore", ParameterList)
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Public Shared Sub NavigateToEnte(ByVal control As BrowserControl, ByVal NomeEnte As String)
      Try
         Dim controller As New WIN.APPLICATION.AZIENDE.ControllerEntiBilaterali
         Dim id As Int32 = controller.GetIdEnteByDescrizione(NomeEnte)
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", id)
         control.NavigateTo("ViewEnte", ParameterList)
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub


   Public Shared Sub SetUpCombo(ByVal Combo As System.Windows.Forms.ComboBox, ByVal Lista As Hashtable)
      Try
         InterfaceMediator.LoadCombo(Combo, Lista, False)
         'Combo.Items.Add("ENTRAMBI")
         Combo.SelectedIndex = 0
      Catch ex As Exception
         Throw New Exception("Impossibile impostare il combobox ." & vbCrLf & ex.Message)
      End Try
   End Sub


   Public Shared Sub PostLoadingActions(ByVal Control As BrowserControl, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe)
      Dim logo As String = "" & Control.State.StateName & "  delega"
      MasterControl.Instance.ParentForm.Text = logo & " " & UCase(Controller.DescrizioneUtente)
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(Controller.DescrizioneUtente)
      Control.lblCurrentFunction.Text = UCase("" & Control.State.StateName & "  -   delega  " & UCase(Controller.StatusDelega) & "   -   " & UCase(Controller.DescrizioneUtente))
   End Sub
   Public Shared Sub NotifyParent(ByVal Control As BrowserControl)
      Dim nomeStato As String = Control.State.StateName
      If nomeStato = "Creazione" Then
         nomeStato = "Sottoscrizione nuova"
      End If
      MasterControl.Instance.ParentForm.Text = "" & nomeStato & "  delega"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & nomeStato & "  delega "
      Control.lblCurrentFunction.Text = UCase("" & nomeStato & " delega")
      Control.SelectToolStripImage()
   End Sub
   Public Shared Sub PostchangeActions(ByVal Control As BrowserControl, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe)
      Try
         Dim logo As String = "" & Control.State.StateName & "  delega"
         MasterControl.Instance.ParentForm.Text = logo & " " & UCase(Controller.DescrizioneUtente)
         MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(Controller.DescrizioneUtente)
         Control.lblCurrentFunction.Text = UCase("" & Control.State.StateName & "  -   delega  " & UCase(Controller.StatusDelega) & "   -   " & UCase(Controller.DescrizioneUtente))
      Catch ex As Exception
         NotifyParent(Control)
      End Try

   End Sub


   Public Shared Sub Ripristina(ByVal Control As BrowserControl, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe, ByVal IdDelega As String, ByVal IdUtente As String)
      Try
         CheckDelegaForRipristino()
         If MsgBox("Attenzione il ripristino dello stato precedente causerà la perdita di alcune informazioni. Procedere?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Ripristino stato precedente") = MsgBoxResult.Yes Then
            Controller.RipristinaStatoPrecedente()
            Controller.Save()
            Navigate(Control, IdUtente, IdDelega, Controller.StatusDelega)
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Public Shared Sub RevocaDelega(ByVal Control As BrowserControl, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe, ByVal IdDelega As String, ByVal IdUtente As String)
      Try
         CheckDelegaForRevoca()
         Dim frm As New DelegheActions
         frm.OpenForRevoca()
         PerformDialogForRevoca(Control, frm, Controller, IdUtente, IdDelega)
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Public Shared Sub AnnullaDelega(ByVal Control As BrowserControl, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe, ByVal IdDelega As String, ByVal IdUtente As String)
      Try
         CheckDelegaForAnnullamento()
         Dim frm As New DelegheActions
         frm.OpenForCancel()
         PerformDialogForAnnullamento(Control, frm, Controller, IdUtente, IdDelega)
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Shared Sub PerformDialogForAnnullamento(ByVal control As BrowserControl, ByVal frm As DelegheActions, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe, ByVal IdUtente As String, ByVal IdDelega As String)
      Dim controllerCausali As New ControllerCausaliRevoca
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         Controller.AnnullaDelega(frm.DataFineCiclo.Date, controllerCausali.GetIdByDescrizione(frm.Causale))
         Controller.Save()
         Dim list As New Hashtable
         list.Add("Id", IdDelega)
         list.Add("IdUtente", IdUtente)
         control.NavigateTo("ViewDelega", list)
         frm.Dispose()
      Else
         frm.Dispose()
      End If
   End Sub
   Private Shared Sub PerformDialogForRevoca(ByVal control As BrowserControl, ByVal frm As DelegheActions, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe, ByVal IdUtente As String, ByVal IdDelega As String)
      Dim controllerCausali As New ControllerCausaliRevoca
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         Controller.RevocaDelega(frm.DataFineCiclo.Date, controllerCausali.GetIdByDescrizione(frm.Causale), Controller.Note)
         Controller.Save()
         Dim list As New Hashtable
         list.Add("Id", IdDelega)
         list.Add("IdUtente", IdUtente)
         control.NavigateTo("ViewDelega", list)
         frm.Dispose()
      Else
         frm.Dispose()
      End If
   End Sub




   Public Shared Sub GetSimpleDescription(ByVal Controller As AbstractController, ByVal PropertyName As String, ByVal Label As System.Windows.Forms.Label, ByVal Id As String)
      Try
         Controller.LoadById(Id)
         Dim myType As Type = Controller.GetType
         Dim myInstance As Object = Controller
         Dim myProperty As Reflection.PropertyInfo = myType.GetProperty(PropertyName)
         Dim result As String = myProperty.GetValue(myInstance, Nothing)
         Label.Text = result
      Catch ex As Exception
         Label.Text = ""
      End Try


   End Sub

   Public Shared Sub OpenDetail(ByVal controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe)
      Dim frm As New FrmDettagliDeleghe(controller)
      frm.ShowDialog()
   End Sub

   <Secure(Area:="Deleghe", Alias:="Aggiornamento", Macroarea:="Deleghe")> _
   Public Shared Sub CheckDelegaEditable()

      SecurityManager.Instance.Check()

   End Sub


   <Secure(Area:="Elaborazioni", Alias:="Inoltro", Macroarea:="Deleghe")> _
      Public Shared Sub CheckDelegaForInoltro()

      SecurityManager.Instance.Check()

   End Sub

   <Secure(Area:="Elaborazioni", Alias:="Accettazione", Macroarea:="Deleghe")> _
   Public Shared Sub CheckDelegaForAccettazione()

      SecurityManager.Instance.Check()

   End Sub


   <Secure(Area:="Elaborazioni", Alias:="Revoca", Macroarea:="Deleghe")> _
 Public Shared Sub CheckDelegaForRevoca()

      SecurityManager.Instance.Check()

   End Sub

   <Secure(Area:="Elaborazioni", Alias:="Annullamento", Macroarea:="Deleghe")> _
Public Shared Sub CheckDelegaForAnnullamento()

      SecurityManager.Instance.Check()

   End Sub


   <Secure(Area:="Elaborazioni", Alias:="Ripristino stato", Macroarea:="Deleghe")> _
Public Shared Sub CheckDelegaForRipristino()

      SecurityManager.Instance.Check()

   End Sub




End Class

