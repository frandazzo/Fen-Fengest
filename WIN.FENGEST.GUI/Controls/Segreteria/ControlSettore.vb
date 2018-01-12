Public Class ControlSettore
   '   Private controller As New ControllerSettori
   '   Private controllerContratti As New ControllerTipoContratto
   '   Private IsWorking As Boolean = False
   '   Public Sub New(ByVal IdSettore As Int32)
   '      InitializeComponent()
   '      Me.m_IdShowedObject = IdSettore
   '      Try
   '         DoLoad()
   '         NotifyParent()
   '      Catch ex As Exception
   '         Throw New Exception(ex.Message)
   '      End Try
   '   End Sub
   '   Public Overrides Sub NotifyParent()
   '      MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " settore"
   '   End Sub



   '#Region "Metodi per Load iniziale"
   '   Protected Overrides Sub PrepareLoading()
   '      SetUpListaContratti()
   '   End Sub

   '   Private Sub SetUpListaContratti()
   '      Dim lista As ArrayList = controller.GetListaTipiContratto
   '      For Each elem As String In lista
   '         lstContratti.Items.Add(elem, False)
   '      Next
   '      lstContratti.Sorted = True
   '   End Sub

   '   Protected Overrides Sub ClearWindow()
   '      'Qui pulisco tutti i campi della maschera
   '      txtSettore.Text = ""
   '      txtTipo.Text = ""
   '   End Sub
   '   Protected Overrides Sub LoadData()
   '      'qui carico ordino il caricamento dei dati e carico le possibili scelte
   '      controller.LoadById(Me.m_IdShowedObject)
   '      Dim list As ArrayList = controller.GetListaContratti
   '      For Each elem As String In list
   '         If lstContratti.Items.Contains(elem) Then
   '            lstContratti.SetItemChecked(lstContratti.Items.IndexOf(elem), True)
   '         End If
   '      Next
   '   End Sub
   '   Protected Overrides Sub GetProperties()
   '      txtSettore.Text = controller.Descrizione
   '      txtTipo.Text = controller.TipoSettore
   '   End Sub
   '#End Region




   '#Region "Metodi per il salvataggio"

   '   Protected Overrides Sub Navigate()
   '      Try
   '         Dim ParameterList As Hashtable = New Hashtable
   '         ParameterList.Add("Id", m_IdShowedObject)
   '         Me.NavigateTo("ViewSettore", ParameterList)
   '      Catch ex As Exception
   '         Throw New Exception(ex.Message)
   '      End Try
   '   End Sub
   '   Protected Overloads Sub Navigate(ByVal ToId As Int32)
   '      Try
   '         Dim ParameterList As Hashtable = New Hashtable
   '         ParameterList.Add("Id", ToId)
   '         Me.NavigateTo("ViewSettore", ParameterList)
   '      Catch ex As Exception
   '         Throw New Exception(ex.Message)
   '      End Try
   '   End Sub
   '   Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
   '      Try
   '         Dim ParameterList As Hashtable = New Hashtable
   '         ParameterList.Add("Id", ToId)
   '         Me.NavigateTo(Link, ParameterList)
   '      Catch ex As Exception
   '         Throw New Exception(ex.Message)
   '      End Try
   '   End Sub
   '   Public Overrides Sub InsertData()
   '      Try
   '         '
   '      Catch ex As Exception
   '         Throw New Exception(ex.Message)
   '      End Try
   '   End Sub
   '#End Region




   '#Region "Metodi per l'aggiornamento"


   '#End Region

   '   Public Overrides Sub UpdateData()
   '      controller.Descrizione = txtSettore.Text
   '      controller.TipoSettore = txtTipo.Text
   '      controller.Save()
   '   End Sub

   'Private Sub txtTipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipo.TextChanged
   '   Me.Change()
   'End Sub

   'Private Sub txtSettore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSettore.TextChanged
   '   Me.Change()
   'End Sub

   'Private Sub lstContratti_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstContratti.ItemCheck
   '   Dim val As Boolean = e.CurrentValue
   '   Try
   '      If IsWorking Then Exit Sub
   '      IsWorking = True
   '      If sender.SelectedItems.Count > 0 Then
   '         If e.NewValue = Windows.Forms.CheckState.Checked Then
   '            controller.AddContratto(controllerContratti.GetIdTipoContrattoByDescrizione(sender.SelectedItem.ToString), True)
   '         Else
   '            controller.AddContratto(controllerContratti.GetIdTipoContrattoByDescrizione(sender.SelectedItem.ToString), False)
   '         End If
   '      End If

   '      IsWorking = False
   '   Catch ex As Exception
   '      IsWorking = False
   '      ErrorHandler.ShowError(ex)
   '      Me.Navigate()
   '   End Try
   'End Sub

   'Private Sub lstContratti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstContratti.MouseDoubleClick
   '   If lstContratti.SelectedItems.Count > 0 Then
   '      Dim desc As String = lstContratti.SelectedItems.Item(0)
   '      Me.Navigate(controllerContratti.GetIdTipoContrattoByDescrizione(desc), "ViewTipoContratto")
   '   End If
   'End Sub
End Class
