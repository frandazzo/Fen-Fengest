Imports System.Windows.Forms
Imports WIN.SECURITY.Core
Imports WIN.SECURITY
Imports WIN.SECURITY.Attributes

Public Class ManagerProfili

   Private _permissions As List(Of IPermission)
   Private _profile As WIN.BASEREUSE.Profile
   Private _loading As Boolean
   Private _showFullMethodNames As Boolean = False
   Private SecureDataAccess As New SecureDataManager
   Private _profiles As IList(Of IProfile) = New List(Of IProfile)
   Private looked As Boolean = False

   Public Sub New(ByVal Profile As WIN.BASEREUSE.Profile)
      InitializeComponent()
      'SecureDataAccess.BeginTransaction()
      '_profiles = SecureDataAccess.GetProfiles
      SplitContainer1.Panel1Collapsed = True
      looked = True
      Me.ProfileMenu.Enabled = False
      Me.uxPermissionsListBox.Enabled = False
      Me.txtCambiaDescrizione.Visible = False
      Me.cmdSave.Enabled = False
      Me.cmdCancel.Enabled = False
      LoadProfile(Profile)
   End Sub

   Private Sub LoadProfile(ByVal profile As WIN.BASEREUSE.Profile)
      If profile Is Nothing Then Return
      _profile = profile


      txtDescrizione.Text = profile.Descrizione

      _permissions = New List(Of IPermission)(_profile.Permissions)

      LoadTreeView()
      uxPermissionsListBox.Items.Clear()
   End Sub




   Public Sub New()
      InitializeComponent()



      LoadAll()


   End Sub

   Private Sub LoadAll()
      _profiles = SecureDataAccess.GetProfiles
      SplitContainer1.Panel1Collapsed = False

      SecureDataAccess.BeginTransaction()

      LoadProfiles()

      If _profiles.Count > 0 Then
         LoadProfile(_profiles.Item(0))
      End If
   End Sub

   Protected Sub LoadProfiles()
      uxProfilesListBox.Items.Clear()
      For Each elem As IProfile In _profiles
         uxProfilesListBox.Items.Add(elem.Description)
      Next


   End Sub



   Private Sub LoadTreeView()


      uxTreeView.Nodes.Clear()


      For Each elem As KeyValuePair(Of String, Secure) In SecurityManager.Instance.SecureMethods
         Dim macroNode As TreeNode = GetMacroNode(elem.Value.MacroArea)
         CheckAreaNode(macroNode, elem.Value.Area)
      Next







      uxTreeView.CollapseAll()


   End Sub

   Private Sub CheckAreaNode(ByVal macroNode As TreeNode, ByVal area As String)

      If Not (macroNode.Nodes.ContainsKey(area)) Then

         Dim areaNode As TreeNode = New TreeNode()
         areaNode.Text = area
         areaNode.Name = area
         areaNode.Tag = "area"
         macroNode.Nodes.Add(areaNode)
      End If

   End Sub
   Private Function GetMacroNode(ByVal macroarea As String) As TreeNode

      Dim macroNode As TreeNode

      If Not (uxTreeView.Nodes.ContainsKey(macroarea)) Then

         macroNode = New TreeNode()
         macroNode.Text = macroarea
         macroNode.Name = macroarea
         uxTreeView.Nodes.Add(macroNode)

      Else

         macroNode = uxTreeView.Nodes(macroarea)
      End If

      Return macroNode

   End Function






   Private Sub LoadPermissions(ByVal macroarea As String, ByVal area As String)

      _loading = True
      Me.uxPermissionsListBox.Items.Clear()


      For Each secure As KeyValuePair(Of String, SECURITY.Attributes.Secure) In SecurityManager.Instance.SecureMethods
         If secure.Value.MacroArea = macroarea Then
            If secure.Value.Area = area Then
               secure.Value.FullToString = _showFullMethodNames
               Me.uxPermissionsListBox.Items.Add(secure.Value, ProfileHasMethod(secure.Value.FullName))
            End If
         End If

      Next
      _loading = False
   End Sub

   Private Function ProfileHasMethod(ByVal fullName As String) As Boolean

      For Each method As IPermission In _profile.Permissions
         If (method.FullMethodName.Equals(fullName)) Then
            Return True
         End If

      Next
      Return False
   End Function


   Private Function ProfileContainsMethod(ByVal Secure As Secure) As Boolean

      Dim contains As Boolean = False

      For Each permission As IPermission In _profile.Permissions
         If (permission.FullMethodName.Equals(Secure.FullName)) Then
            contains = True
         End If
      Next
      Return contains
   End Function

   Private Sub uxTreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles uxTreeView.AfterSelect
      If (e.Node.Tag IsNot Nothing) Then
         If e.Node.Tag.ToString() = "area" Then

            Dim macroNode As TreeNode = e.Node.Parent
            uxPermissionsListBox.Enabled = True
            LoadPermissions(macroNode.Name, e.Node.Name)

         Else

            uxPermissionsListBox.Items.Clear()
            uxPermissionsListBox.Enabled = False
         End If
      End If
   End Sub

   Private Sub uxPermissionsListBox_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles uxPermissionsListBox.ItemCheck
      If _loading Then Return
      If looked Then

         If e.NewValue = CheckState.Unchecked Then
            e.NewValue = CheckState.Checked
         Else
            e.NewValue = CheckState.Unchecked
         End If
         Return
      End If



      If e.NewValue = CheckState.Checked Then

         Dim Secure As Secure = DirectCast(uxPermissionsListBox.Items(e.Index), Secure)
         Dim Permission As WIN.BASEREUSE.Permission = New WIN.BASEREUSE.Permission()
         Permission.FullMethodName = Secure.FullName
         Permission.Profile = _profile
         _profile.Permissions.Add(Permission)
         SecureDataAccess.MarkNew(Permission)
      Else

         Dim Secure As Secure = DirectCast(uxPermissionsListBox.Items(e.Index), Secure)
         DeletePermission(Secure.FullName)

      End If
   End Sub



   Private Sub DeletePermission(ByVal fullName As String)

      Dim toRemove As IPermission = Nothing

      For Each permission As IPermission In _profile.Permissions
         If permission.FullMethodName.Equals(fullName) Then
            toRemove = permission
         End If
      Next

      If toRemove IsNot Nothing Then
         _profile.Permissions.Remove(toRemove)
         SecureDataAccess.MarkDelete(toRemove)
      End If

   End Sub

   Private Sub uxProfilesListBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles uxProfilesListBox.MouseUp
      'If uxProfilesListBox.Text <> "" Then
      If e.Button = MouseButtons.Right Then
         'Me.txtRenameRole.Text = (DirectCast(uxProfilesListBox.SelectedValue, Role)).Descrizione
         Me.ProfileMenu.Show(uxProfilesListBox, e.Location)
      End If
      'End If
   End Sub

   Private Sub uxProfilesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uxProfilesListBox.SelectedIndexChanged
      LoadProfile(GetProfileByName(uxProfilesListBox.Text))

   End Sub



   Private Function GetProfileByName(ByVal ProfileName As String) As IProfile
      For Each elem As IProfile In _profiles
         If elem.Description = ProfileName Then
            Return elem
         End If
      Next
      Return Nothing
   End Function

   Private Sub uxAddMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxAddMenuItem.Click

      For Each elem As IProfile In _profiles
         If elem.Description = UCase("Nuovo profilo") Then
            MsgBox("Impossibile aggiungere un profilo nuovo. Profilo ""Nuovo profilo"" esistente!", MsgBoxStyle.Exclamation, "Errore")
            Return
         End If
      Next

      Dim profile As New WIN.BASEREUSE.Profile
      _profiles.Add(profile)
      profile.Descrizione = "Nuovo profilo"
      SecureDataAccess.MarkNew(profile)
      uxProfilesListBox.Items.Add(profile.Descrizione)
   End Sub

   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      Try
         SecureDataAccess.CommitTransaction()
         'SecureDataAccess.BeginTransaction()
         MsgBox("Riavviare l'applicazione per rendere effettive le modifiche", MsgBoxStyle.Information, "Informazione")
         LoadAll()
      Catch ex As Exception
         LoadAll()
         ErrorHandler.ShowError(ex)
      End Try
   End Sub



   Private Sub uxDeleteMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxDeleteMenuItem.Click
      If _profile IsNot Nothing Then
         If uxProfilesListBox.SelectedIndex <> -1 Then
            uxProfilesListBox.Items.RemoveAt(uxProfilesListBox.SelectedIndex)
            SecureDataAccess.MarkDelete(_profile)
            uxTreeView.Nodes.Clear()
            uxPermissionsListBox.Items.Clear()
            _profiles.Remove(_profile)
            If _profiles.Count > 0 Then
               LoadProfile(_profiles.Item(0))
            End If
         End If

      End If
   End Sub

   Private Sub txtCambiaDescrizione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCambiaDescrizione.Click
      Try
         If _profile Is Nothing Then Return
         If uxProfilesListBox.SelectedIndex <> -1 Then


            Dim frm As New ProfileDescriptorForm(_profile.Descrizione, "Descriiozne profilo")
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

               Dim prof As WIN.BASEREUSE.Profile = GetProfileByName(frm.Descrizione)
               If prof IsNot Nothing Then Throw New Exception("Profilo esistente")

               _profile.Descrizione = frm.Descrizione
               txtDescrizione.Text = _profile.Descrizione
               uxProfilesListBox.Items(uxProfilesListBox.SelectedIndex) = _profile.Descrizione
               SecureDataAccess.MarkDirty(_profile)
            End If
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      If _profile IsNot Nothing Then
         If uxProfilesListBox.SelectedIndex <> -1 Then
            uxProfilesListBox.Items.RemoveAt(uxProfilesListBox.SelectedIndex)
            SecureDataAccess.MarkDelete(_profile)
            uxTreeView.Nodes.Clear()
            uxPermissionsListBox.Items.Clear()
            _profiles.Remove(_profile)
            If _profiles.Count > 0 Then
               LoadProfile(_profiles.Item(0))
            End If
         End If

      End If
   End Sub
End Class