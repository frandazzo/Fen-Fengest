<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterControl
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
      Me.components = New System.ComponentModel.Container
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.TreeView1 = New System.Windows.Forms.TreeView
      Me.ControlStackView1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlStackView
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.CachedReportAnagraficaDelegaInoltrata1 = New WIN.GUI.PRINT.Report.CachedReportAnagraficaDelegaInoltrata
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(671, 26)
      '
      'DockPanel
      '
      Me.DockPanel.TabIndex = 2
      '
      'SplitContainer1
      '
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
      Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer1.Name = "SplitContainer1"
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.ControlStackView1)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Size = New System.Drawing.Size(671, 418)
      Me.SplitContainer1.SplitterDistance = 194
      Me.SplitContainer1.TabIndex = 2
      '
      'Panel1
      '
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
      Me.Panel1.Location = New System.Drawing.Point(0, 0)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(194, 23)
      Me.Panel1.TabIndex = 0
      '
      'TreeView1
      '
      Me.TreeView1.BackColor = System.Drawing.SystemColors.Window
      Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.TreeView1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TreeView1.ItemHeight = 19
      Me.TreeView1.Location = New System.Drawing.Point(25, 46)
      Me.TreeView1.Name = "TreeView1"
      Me.TreeView1.Size = New System.Drawing.Size(140, 115)
      Me.TreeView1.TabIndex = 1
      '
      'ControlStackView1
      '
      Me.ControlStackView1.AutoSize = True
      Me.ControlStackView1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.ControlStackView1.Location = New System.Drawing.Point(0, 201)
      Me.ControlStackView1.Name = "ControlStackView1"
      Me.ControlStackView1.Size = New System.Drawing.Size(194, 217)
      Me.ControlStackView1.TabIndex = 2
      '
      'MasterControl
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.SplitContainer1)
      Me.Name = "MasterControl"
      Me.Size = New System.Drawing.Size(671, 418)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents ControlStackView1 As WIN.GUI.APPLICATION.PRESENTATION.ControlStackView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents CachedReportAnagraficaDelegaInoltrata1 As WIN.GUI.PRINT.Report.CachedReportAnagraficaDelegaInoltrata
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
