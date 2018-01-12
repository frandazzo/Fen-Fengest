Imports WIN.SECURITY.Core

Public Class uxUserForm
   Private _role As WIN.BASEREUSE.Role
   Private _user As WIN.BASEREUSE.User

   Public Sub New(ByVal role As IRole)
      InitializeComponent()
      _role = role
      uxInfoLabel.Text = String.Format(uxInfoLabel.Text, role.Description)
   End Sub


   Public Sub New(ByVal user As WIN.BASEREUSE.User)
      InitializeComponent()
      _user = user
      _role = user.Role
      uxUsernameTextBox.Text = user.Username
      uxPasswordTextBox.Text = user.Password
      uxNameTextBox.Text = user.Name
      uxSurnameTextBox.Text = user.SurName
      Me.Text = Me.Text & user.Username
      uxInfoLabel.Text = String.Format(uxInfoLabel.Text, user.Role.Description)
   End Sub



   Public ReadOnly Property User() As IUser
      Get
         Return _user
      End Get
   End Property


   Private Sub uxOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxOKButton.Click

      Try

         Dim user As WIN.BASEREUSE.User = GetUserByUserName(uxUsernameTextBox.Text)
            'If user IsNot Nothing Then
            '   Throw New Exception("Username già esistente")
            'End If



         If uxUsernameTextBox.Text = "" Then
            uxUsernameTextBox.Focus()
            Return
         End If



         If uxPasswordTextBox.Text = "" Then
            uxPasswordTextBox.Focus()
            Return
         End If



         If _user Is Nothing Then
            _user = New WIN.BASEREUSE.User(_role)
         End If


         _user.Username = uxUsernameTextBox.Text
         _user.Password = uxPasswordTextBox.Text
         _user.Name = uxNameTextBox.Text
         _user.SurName = uxSurnameTextBox.Text


         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try



   End Sub

   Private Sub uxUserForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      uxUsernameTextBox.Focus()
   End Sub



   Private Function GetUserByUserName(ByVal UserName As String) As IUser
      For Each elem As IUser In _role.Users
         If elem.Username = UserName Then
            Return elem
         End If
      Next
      Return Nothing
   End Function


End Class