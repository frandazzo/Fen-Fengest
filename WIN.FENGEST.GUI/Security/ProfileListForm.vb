Imports WIN.SECURITY.Core

Public Class ProfileListForm
   Public SecureDataAccess As New SecureDataManager
   Dim list As IList(Of IProfile) = New List(Of IProfile)
   Dim m_Profile As IProfile


   Public ReadOnly Property SelectedProfile() As IProfile
      Get
         Return m_Profile
      End Get
   End Property


   Private Sub uxOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxOKButton.Click

      For Each elem As IProfile In list
         If elem.Description = ComboBox1.Text Then
            m_Profile = elem
         End If
      Next


      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

   Private Sub uxCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxCancelButton.Click



      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub ProfileList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      LoadCombo()

   End Sub


   Private Sub LoadCombo()
      list = SecureDataAccess.GetProfiles()
      For Each elem As IProfile In list
         ComboBox1.Items.Add(elem.Description)
      Next
      ComboBox1.Sorted = True

      If list.Count > 0 Then
         ComboBox1.SelectedIndex = 0
      End If
   End Sub

End Class