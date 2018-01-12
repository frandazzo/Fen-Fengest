Imports System.Windows.Forms
Imports WIN.GUI.UTILITY

Public Class InterfaceMediator
    Public Shared Sub LoadCombo(ByVal Combo As ComboBox, ByVal List As IList, ByVal AddEmptyRow As Boolean)
        Try
            Combo.Items.Clear()
            For Each elem As Object In List
                Combo.Items.Add(elem)
            Next
            If AddEmptyRow Then
                Combo.Items.Add("")
            End If
            If List.Count > 0 Then
                Combo.Sorted = True
                Combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile impostare il combo ." & vbCrLf & ex.Message)
        End Try

    End Sub

    Public Shared Sub LoadUsabilityCombo(ByVal Combo As UsabilityCombo, ByVal List As IList, ByVal AddEmptyRow As Boolean)
        Try
            Combo.ComboBox1.Items.Clear()
            For Each elem As Object In List
                Combo.ComboBox1.Items.Add(elem)
            Next
            If AddEmptyRow Then
                Combo.ComboBox1.Items.Add("")
            End If
            If List.Count > 0 Then
                Combo.ComboBox1.Sorted = True
                Combo.ComboBox1.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile impostare il combo ." & vbCrLf & ex.Message)
        End Try

    End Sub

    Public Shared Sub LoadComboDatasource(ByVal Combo As ComboBox, ByVal List As IList, ByVal AddEmptyRow As Boolean)
        Try
            Dim com As Comune = New ComuneNullo

            If AddEmptyRow Then
                List.Add(com)
            End If
            Combo.DataSource = List


            Combo.SelectedItem = com

        Catch ex As Exception
            Throw New Exception("Impossibile impostare il combo ." & vbCrLf & ex.Message)
        End Try

    End Sub
    Public Shared Sub LoadCheckedListBox(ByVal ListBox As CheckedListBox, ByVal List As ArrayList)
        Try
            ListBox.Items.Clear()
            For Each elem As String In List
                ListBox.Items.Add(elem)
            Next
            If List.Count > 0 Then
                ListBox.Sorted = True
                ListBox.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile impostare la checked list ." & vbCrLf & ex.Message)
        End Try

    End Sub
    Public Shared Sub LoadCombo(ByVal Combo As ComboBox, ByVal List As Hashtable, ByVal AddEmptyRow As Boolean)
        Try
            Combo.Items.Clear()
            Dim en As IDictionaryEnumerator = List.GetEnumerator
            Do While en.MoveNext
                Combo.Items.Add(en.Value)
            Loop
            If AddEmptyRow Then
                Combo.Items.Add("")
            End If
            If List.Count > 0 Then
                Combo.Sorted = True
                Combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile impostare il combo ." & vbCrLf & ex.Message)
        End Try

    End Sub
    Public Shared Sub LoadListBox(ByVal ListBox As ListBox, ByVal List As ArrayList)
        Try
            ListBox.Items.Clear()
            For Each elem As String In List
                ListBox.Items.Add(elem)
            Next
            ListBox.Sorted = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Overloads Shared Sub GetSimpleDescription(ByVal Controller As AbstractController, ByVal PropertyName As String, ByVal Label As System.Windows.Forms.Label, ByVal Id As String)
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
    Public Overloads Shared Sub GetSimpleDescription(ByVal Controller As AbstractController, ByVal PropertyName As String, ByVal Label As System.Windows.Forms.TextBox, ByVal Id As String)
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


End Class
