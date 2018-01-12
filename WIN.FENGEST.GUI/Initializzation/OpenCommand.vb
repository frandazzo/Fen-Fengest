Public MustInherit Class OpenCommand
   Inherits AbstractOpenCommand

   Public Overloads Overrides Sub Execute()
      If MyBase.m_IdObjectToOpen = -1 Then
         'apri per la ricerca 
         Open()
      Else
         'Apri in visualizzazione
         'Try
         Open(MyBase.m_IdObjectToOpen)
         'Catch ex As Exception
         '   Open()
         'End Try

      End If
   End Sub
    Public Overrides Sub SetCommandParameters(ByVal WitParameter1 As System.Collections.Hashtable)
        If WitParameter1.Contains("Id") Then
            MyBase.m_IdObjectToOpen = WitParameter1.Item("Id")
        End If
    End Sub
   ' 

   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Try
         id = WithParameter.Item("Id")
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id)
   End Sub

   Protected Overloads Overrides Sub ExecuteInOtherWindow(ByVal Window As Object)
      '
   End Sub

   Protected Overloads Overrides Sub ExecuteInOtherWindow(ByVal Window As Object, ByVal WithParameter1 As System.Collections.Hashtable)
      '
   End Sub

   Protected Overridable Sub SetTargetControlReceviers(ByVal Control As BrowserControl)

   End Sub
   Protected Overridable Overloads Function CreateTargetControl() As BrowserControl
      Dim control As BrowserControl = DoCreateTargetControl()
      SetTargetControlReceviers(control)
      Return control
   End Function
   Protected Overridable Overloads Function CreateTargetControl(ByVal Id As Int32) As BrowserControl

        'MyBase.m_IdObjectToOpen = Id
      Dim control As BrowserControl = DoCreateTargetControl(Id)
      SetTargetControlReceviers(control)
      Return control


   End Function
   Protected MustOverride Function DoCreateTargetControl() As BrowserControl
   Protected MustOverride Function DoCreateTargetControl(ByVal Id As Int32) As BrowserControl


   Protected Sub Forward(ByVal LinkTo As BrowserControl)
      'MasterControl.Instance.ContainerControl.Controls.Clear()
      'MasterControl.Instance.ContainerControl.Controls.Add(LinkTo)
      MasterControl.Instance.AddControl(LinkTo)
      MasterControl.Instance.SetSizeContainedControl(LinkTo)
      'LinkTo.Dock = DockStyle.Fill
      'LinkTo.Location = New Point(0, 0)
      'LinkTo.Size = New Size(MasterControl.Instance.Size.Width, MasterControl.Instance.Size.Height)
      'LinkTo.Height = MasterControl.Instance.Height - MasterControl.Instance.Panel2.Height
   End Sub
   Protected Sub Forward(ByVal Window As System.Windows.Forms.Form, ByVal LinkTo As BrowserControl)
      Window.Controls.Add(LinkTo)
      LinkTo.Dock = DockStyle.Fill
   End Sub

   Protected Overridable Overloads Sub Open(ByVal Id As Int32)

      Dim control As BrowserControl = CreateTargetControl(Id)
      Forward(control)
   End Sub
   Protected Overridable Overloads Sub Open()
      Dim control As BrowserControl = CreateTargetControl()
      Forward(control)
   End Sub
   Protected Overridable Function ObjectToOpenName() As String
      Return "NullObjectToOpen"
   End Function
End Class
