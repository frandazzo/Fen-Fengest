<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlHomePage
   Inherits GUI.APPLICATION.PRESENTATION.BrowserControl

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(3312, 22)
      '
      'DockPanel
      '
      Me.DockPanel.Location = New System.Drawing.Point(0, 22)
      Me.DockPanel.Size = New System.Drawing.Size(3312, 44)
      '
      'WebBrowser1
      '
      Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
      Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
      Me.WebBrowser1.Name = "WebBrowser1"
      Me.WebBrowser1.Size = New System.Drawing.Size(716, 543)
      Me.WebBrowser1.TabIndex = 38
      Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
      '
      'ControlHomePage
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.BackColor = System.Drawing.Color.LightGray
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.Controls.Add(Me.WebBrowser1)
      Me.Name = "ControlHomePage"
      Me.Size = New System.Drawing.Size(716, 543)
      Me.Controls.SetChildIndex(Me.WebBrowser1, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
