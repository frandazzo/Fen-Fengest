<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchConti
    Inherits System.Windows.Forms.Form

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
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.TabPage2 = New System.Windows.Forms.TabPage
      Me.GridConti = New System.Windows.Forms.DataGridView
      Me.cmdCerca = New System.Windows.Forms.Button
      Me.TabControl1.SuspendLayout()
      CType(Me.GridConti, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Controls.Add(Me.TabPage2)
      Me.TabControl1.Location = New System.Drawing.Point(12, 12)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(411, 124)
      Me.TabControl1.TabIndex = 0
      '
      'TabPage1
      '
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(403, 98)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "TabPage1"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'TabPage2
      '
      Me.TabPage2.Location = New System.Drawing.Point(4, 22)
      Me.TabPage2.Name = "TabPage2"
      Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage2.Size = New System.Drawing.Size(403, 98)
      Me.TabPage2.TabIndex = 1
      Me.TabPage2.Text = "TabPage2"
      Me.TabPage2.UseVisualStyleBackColor = True
      '
      'GridConti
      '
      Me.GridConti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.GridConti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GridConti.Location = New System.Drawing.Point(12, 142)
      Me.GridConti.Name = "GridConti"
      Me.GridConti.Size = New System.Drawing.Size(487, 122)
      Me.GridConti.TabIndex = 1
      '
      'cmdCerca
      '
      Me.cmdCerca.Location = New System.Drawing.Point(429, 34)
      Me.cmdCerca.Name = "cmdCerca"
      Me.cmdCerca.Size = New System.Drawing.Size(73, 22)
      Me.cmdCerca.TabIndex = 2
      Me.cmdCerca.Text = "Cerca"
      Me.cmdCerca.UseVisualStyleBackColor = True
      '
      'SearchConti
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(511, 274)
      Me.Controls.Add(Me.cmdCerca)
      Me.Controls.Add(Me.GridConti)
      Me.Controls.Add(Me.TabControl1)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "SearchConti"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ricerca conti"
      Me.TabControl1.ResumeLayout(False)
      CType(Me.GridConti, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents GridConti As System.Windows.Forms.DataGridView
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
End Class
