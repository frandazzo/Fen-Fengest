Imports System.Windows.Forms
Imports WIN.SECURITY.Core

Public Class ManagerRuoli
   Implements IDisposable

   Private _currentRole As IRole
   Private _associations As IList(Of AssociationData) = New List(Of AssociationData)
   Private _roles As IList(Of WIN.BASEREUSE.Role) = New List(Of WIN.BASEREUSE.Role)
   Private _users As IList(Of WIN.BASEREUSE.User) = New List(Of WIN.BASEREUSE.User)
   Private _profiles As IList(Of WIN.BASEREUSE.Profile) = New List(Of WIN.BASEREUSE.Profile)
   Private _deletedRoles As IList(Of WIN.BASEREUSE.Role) = New List(Of WIN.BASEREUSE.Role)
   Private _cuttedUser As IUser = Nothing


   Dim secureDataAccess As New SecureDataManager





   Private Sub ManagerRuoli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      System.Windows.Forms.Application.EnableVisualStyles()

      LoadAll()


   End Sub

  

   Private Sub LoadAll()


      _roles = secureDataAccess.GetNormalizedRoles



      Dim role As WIN.BASEREUSE.Role = Nothing
      For Each elem As WIN.BASEREUSE.Role In _roles
         If elem.Descrizione = "ADMINISTRATORS" Then
            _roles.Remove(elem)
            Exit For
         End If
      Next





      secureDataAccess.BeginTransaction()
      Try
         LoadRoles()

         If _roles.Count > 0 Then
            LoadRole(_roles.Item(0))
         End If
      Catch ex As Exception

      End Try


    
   End Sub

   Private Sub LoadRoles()
      uxRolesListBox.Items.Clear()
      For Each elem As IRole In _roles
         uxRolesListBox.Items.Add(elem.Description)
      Next
   End Sub


   Private Sub LoadRole(ByVal Role As WIN.BASEREUSE.Role)
      If Role Is Nothing Then Return
      _currentRole = Role


      txtDescrizioneRole.Text = Role.Descrizione

      _users = New List(Of WIN.BASEREUSE.User)
      For Each elem As WIN.BASEREUSE.User In _currentRole.Users
         _users.Add(elem)
      Next


      _profiles = New List(Of WIN.BASEREUSE.Profile)

      For Each elem As WIN.BASEREUSE.Profile In _currentRole.Profiles
         _profiles.Add(elem)
      Next



      uxAssociationsListView.Items.Clear()
      LoadUserAndProfiles()

   End Sub


   Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxRolesListBox.Click
      If uxRolesListBox.SelectedValue IsNot Nothing Then
         _currentRole = CType(uxRolesListBox.SelectedValue, WIN.BASEREUSE.Role)
         LoadRole(_currentRole)
      End If
   End Sub


   Private Sub LoadUserAndProfiles()
      If _currentRole Is Nothing Then Return
      uxAssociationsListView.Items.Clear()
      'carico gli utenti
      For Each User As IUser In _currentRole.Users
         Dim item As Windows.Forms.ListViewItem = New ListViewItem(User.Username, 0, uxAssociationsListView.Groups(0))
         uxAssociationsListView.Items.Add(item)
         'Dim a As AssociationData = New AssociationData()
         'a.Role = _currentRole
         'a.User = User
         'a.ListViewItem = item
         '_associations.Add(a)
      Next

      'carico i profili
      For Each profile As IProfile In _currentRole.Profiles
         Dim item As ListViewItem = New ListViewItem(profile.Description, 1, uxAssociationsListView.Groups(1))
         uxAssociationsListView.Items.Add(item)
         'Dim a As AssociationData = New AssociationData()
         'a.Role = _currentRole
         'a.Profile = profile
         'a.ListViewItem = item
         '_associations.Add(a)
      Next
   End Sub












   Private Sub deleteuserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteuserToolStripMenuItem.Click
      If _currentRole IsNot Nothing Then
         If uxAssociationsListView.SelectedItems.Count = 1 Then
            Dim item As ListViewItem = uxAssociationsListView.SelectedItems(0)
            If item.Group Is uxAssociationsListView.Groups(0) Then
               Dim user As WIN.BASEREUSE.User = GetUserByUserName(item.Text)
               If user IsNot Nothing Then
                  _currentRole.Users.Remove(user)
                  uxAssociationsListView.Items.Remove(item)
                  secureDataAccess.MarkDelete(user)
                  LoadUserAndProfiles()
               End If
            End If
         End If
      End If

   End Sub




   Private Sub addNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addNewUserToolStripMenuItem.Click
      Try
         If _currentRole IsNot Nothing Then
            If uxRolesListBox.SelectedIndex <> -1 Then
               Dim frm As New uxUserForm(_currentRole)
               If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                  Dim user As WIN.BASEREUSE.User
                  user = frm.User
                  secureDataAccess.MarkNew(user)
                  LoadUserAndProfiles()
               End If
               frm.Dispose()
            End If
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

   Private Sub uxAssociationsListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxAssociationsListView.DoubleClick
      'Dim association As AssociationData = FindAssociation(uxAssociationsListView.SelectedItems(0))
      'If association Is Nothing Then Return
      'If association.User IsNot Nothing Then

      '   '    OpenUserPropertiesForm(association);

      'ElseIf (association.Profile IsNot Nothing) Then

      '   '    OpenProfilePropertiesForm(association);
      'End If
      OpenProperty()

   End Sub


   Private Sub OpenProperty()
      Try
         If _currentRole IsNot Nothing Then
            If uxAssociationsListView.SelectedItems.Count = 1 Then
               Dim item As ListViewItem = uxAssociationsListView.SelectedItems(0)
               If item.Group Is uxAssociationsListView.Groups(0) Then
                  OpenUserPropertiesForm(GetUserByUserName(item.Text))
               Else
                  OpenProfilePropertiesForm(GetProfileByDescription(item.Text))
               End If
            End If
         End If
      Catch ex As Exception

      End Try

   End Sub


   Private Function GetProfileByDescription(ByVal description As String) As WIN.BASEREUSE.Profile
      For Each elem As IProfile In _currentRole.Profiles
         If elem.Description = description Then
            Return DirectCast(elem, WIN.BASEREUSE.Profile)
         End If
      Next
      Return Nothing
   End Function




   Private Function GetUserByUserName(ByVal UserName As String) As WIN.BASEREUSE.User
      'Dim users As IList(Of IUser) = _currentRole.Users

      'Dim normList As List(Of WIN.BASEREUSE.User) = New List(Of WIN.BASEREUSE.User)



      For Each elem As IUser In _currentRole.Users
         If elem.Username = UserName Then
            Return DirectCast(elem, WIN.BASEREUSE.User)
         End If
      Next
      Return Nothing
   End Function


   Private Sub OpenProfilePropertiesForm(ByVal profile As IProfile)
      Dim frm As New ManagerProfili(DirectCast(profile, WIN.BASEREUSE.Profile))
      frm.ShowDialog()
      'new uxProfileForm(association.Profile, true).ShowDialog(me);
   End Sub
   Private Sub OpenUserPropertiesForm(ByVal user As IUser)
      Dim frm As New uxUserForm(DirectCast(user, WIN.BASEREUSE.User))
      If frm.ShowDialog() = DialogResult.OK Then
         secureDataAccess.MarkDirty(user)
         LoadUserAndProfiles()
      End If
   End Sub


   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      If _currentRole IsNot Nothing Then
         If uxRolesListBox.SelectedIndex <> -1 Then
            uxRolesListBox.Items.RemoveAt(uxRolesListBox.SelectedIndex)
            secureDataAccess.MarkDelete(_currentRole)
            uxAssociationsListView.Items.Clear()
            _roles.Remove(_currentRole)
            If _roles.Count > 0 Then
               LoadRole(_roles.Item(0))
            End If
         End If

      End If
      'LoadRoles()
      'uxAssociationsGroupBox.Enabled = False
   End Sub



   Private Sub LoadProfiles()

      'prendo tutti i profili
      'Da completare
      Dim profiles As IList(Of WIN.BASEREUSE.Profile) = New List(Of WIN.BASEREUSE.Profile)

      uxAddProfileMenuItem.DropDownItems.Clear()
      For Each profile As WIN.BASEREUSE.Profile In profiles
         Dim item As ToolStripItem = New ToolStripMenuItem(profile.Descrizione)
         AddHandler item.Click, AddressOf item_Click
         item.Tag = profile
         item.Enabled = Not (_currentRole.Profiles.Contains(profile))
         uxAddProfileMenuItem.DropDownItems.Add(item)
      Next
   End Sub

   Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
      Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
      Dim profile As WIN.BASEREUSE.Profile = DirectCast(item.Tag, WIN.BASEREUSE.Profile)
      _currentRole.Profiles.Add(profile)
      profile.Roles.Add(_currentRole)
      LoadUserAndProfiles()
   End Sub



   Private Sub RoleMenu_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RoleMenu.Opening
      'Dim cutted As Boolean
      'If _cuttedUser IsNot Nothing Then
      '   cutted = True
      'End If
      'RoleMenu.Items("pasteUser").Enabled = cutted
      'LoadProfiles()
   End Sub

   Private Sub removeroleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeroleToolStripMenuItem.Click
      If _currentRole IsNot Nothing Then
         If uxRolesListBox.SelectedIndex <> -1 Then
            uxRolesListBox.Items.RemoveAt(uxRolesListBox.SelectedIndex)
            secureDataAccess.MarkDelete(_currentRole)
            uxAssociationsListView.Items.Clear()
            _roles.Remove(_currentRole)
            If _roles.Count > 0 Then
               LoadRole(_roles.Item(0))
            End If
         End If

      End If
   End Sub

   Private Sub uxAssociationsListView_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles uxAssociationsListView.MouseMove
      If uxAssociationsListView.SelectedItems.Count = 0 Then
         uxAssociationsListView.ContextMenuStrip = RoleMenu
      End If
   End Sub



   Private Sub uxAssociationsListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxAssociationsListView.SelectedIndexChanged
      If uxAssociationsListView.SelectedItems.Count > 0 Then
         Dim item As ListViewItem = uxAssociationsListView.SelectedItems(0)

         'if is user
         If item.Group Is uxAssociationsListView.Groups(0) Then
            uxAssociationsListView.ContextMenuStrip = UserMenu
         Else ' Profile
            uxAssociationsListView.ContextMenuStrip = ProfileMenu
         End If
      Else 'nothing selected
         uxAssociationsListView.ContextMenuStrip = RoleMenu
      End If
   End Sub


   Private Sub pasteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      _cuttedUser.Role.Users.Remove(_cuttedUser)
      _currentRole.Users.Add(_cuttedUser)
      _cuttedUser.Role = _currentRole
      _cuttedUser = Nothing
      LoadUserAndProfiles()
   End Sub



   Private Sub uxDeleteProfileMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxDeleteProfileMenuItem.Click
        If _currentRole IsNot Nothing Then
            If uxAssociationsListView.SelectedItems.Count = 1 Then
                Dim item As ListViewItem = uxAssociationsListView.SelectedItems(0)
                If item.Group Is uxAssociationsListView.Groups(1) Then
                    Dim profile As IProfile = GetProfileByDescription(item.Text)
                    If profile IsNot Nothing Then
                        _currentRole.Profiles.Remove(profile)
                        'uxAssociationsListView.Items.Remove(item)
                        ' secureDataAccess.MarkDelete(New RoleProfile(_currentRole, profile))
                        DataAccessServices.SimplePersistenceFacadeInstance().ExecuteScalar(String.Format("Delete from roleprofile where roleID = {0} and profileID = {1}", _currentRole.ID, profile.ID))

                        LoadUserAndProfiles()
                    End If
                End If
            End If
        End If
   End Sub



   Private Sub uxProfilePropertiesMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxProfilePropertiesMenuItem.Click
      OpenProperty()
   End Sub





   Private Sub edituserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edituserToolStripMenuItem.Click
      OpenProperty()
   End Sub

   Private Sub OpenProfilePropertiesForm()
      'Dim association As AssociationData = FindAssociation(uxAssociationsListView.SelectedItems(0))
      'If association Is Nothing Then Return
      'If association.Profile IsNot Nothing Then
      '   OpenProfilePropertiesForm(association)
      'End If
   End Sub

   Private Sub uxRolesListBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxRolesListBox.DoubleClick
      If uxRolesListBox.SelectedValue IsNot Nothing Then
         _currentRole = DirectCast(uxRolesListBox.SelectedValue, WIN.BASEREUSE.Role)
         LoadUserAndProfiles()
      End If
   End Sub

   Private Sub uxRolesListBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles uxRolesListBox.MouseUp
      If uxRolesListBox.SelectedValue IsNot Nothing Then
         If e.Button = MouseButtons.Right Then
            'Me.txtRenameRole.Text = (DirectCast(uxRolesListBox.SelectedValue, Role)).Descrizione
            Me.RolesMenu.Show(uxRolesListBox, e.Location)
         End If
      End If
   End Sub

   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      Try
         secureDataAccess.CommitTransaction()
         'SecureDataAccess.BeginTransaction()
         MsgBox("Riavviare l'applicazione per rendere effettive le modifiche", MsgBoxStyle.Information, "Informazione")
         LoadAll()
      Catch ex As Exception
         LoadAll()
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub addNewRoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addNewRoleToolStripMenuItem.Click
      For Each elem As IRole In _roles
         If elem.Description = UCase("Nuovo ruolo") Then
            MsgBox("Impossibile aggiungere un ruolo nuovo. Ruolo ""Nuovo ruolo"" esistente!", MsgBoxStyle.Exclamation, "Errore")
            Return
         End If
      Next

      Dim role As New WIN.BASEREUSE.Role
      _roles.Add(role)
      role.Descrizione = "Nuovo ruolo"
      secureDataAccess.MarkNew(role)
      uxRolesListBox.Items.Add(role.Descrizione)
   End Sub

   Private Sub txtCambiaDescrizione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCambiaDescrizione.Click
      Try
         If _currentRole Is Nothing Then Return
         If uxRolesListBox.SelectedIndex <> -1 Then


            Dim frm As New ProfileDescriptorForm(_currentRole.Description, "Descrizione ruolo")
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

               Dim rol As WIN.BASEREUSE.Role = GetRoleByName(frm.Descrizione)
               If rol IsNot Nothing Then Throw New Exception("Ruolo esistente")

               _currentRole.Description = frm.Descrizione
               txtDescrizioneRole.Text = _currentRole.Description
               uxRolesListBox.Items(uxRolesListBox.SelectedIndex) = _currentRole.Description
               secureDataAccess.MarkDirty(_currentRole)
            End If
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

















   Public Class AssociationData

      Private _listViewItem As ListViewItem

      Public Property ListViewItem() As ListViewItem
         Get
            Return _listViewItem
         End Get
         Set(ByVal value As ListViewItem)
            _listViewItem = value
         End Set
      End Property


      Private _user As IUser

      Public Property User() As IUser
         Get
            Return _user
         End Get
         Set(ByVal value As IUser)
            _user = value
         End Set
      End Property


      Private _profile As IProfile

      Public Property Profile() As IProfile
         Get
            Return _profile
         End Get
         Set(ByVal value As IProfile)
            _profile = value
         End Set
      End Property


      Private _role As IRole

      Public Property Role() As IRole
         Get
            Return _role
         End Get
         Set(ByVal value As IRole)
            _role = value
         End Set
      End Property

   End Class

   Private Sub uxRolesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxRolesListBox.SelectedIndexChanged
      LoadRole(GetRoleByName(uxRolesListBox.Text))
   End Sub


   Private Function GetRoleByName(ByVal roleName As String) As IRole
      For Each elem As IRole In _roles
         If elem.Description = roleName Then
            Return elem
         End If
      Next
      Return Nothing
   End Function

   Private Sub uxAddProfileMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxAddProfileMenuItem.Click
      Try
         If _currentRole IsNot Nothing Then
            Dim frm As New ProfileListForm
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
               Dim prof As IProfile = frm.SelectedProfile
               If prof Is Nothing Then Return
               CheckProfile(prof)
               _currentRole.Profiles.Add(prof)
               secureDataAccess.MarkNew(New RoleProfile(_currentRole, prof))
               LoadUserAndProfiles()

            End If
            frm.Dispose()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub CheckProfile(ByVal Profile As IProfile)
      For Each elem As IProfile In _currentRole.Profiles
         If elem.Description = Profile.Description Then
            Throw New Exception("Il profilo selezionato appartiene al ruolo")
         End If
      Next
   End Sub

End Class