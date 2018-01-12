<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowserControl
   Inherits WIN.GUI.UTILITY.AbstractBrowserControl

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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblCurrentFunction = New System.Windows.Forms.Label
        Me.CmdExit = New System.Windows.Forms.Button
        Me.DockPanel = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblCurrentFunction)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 30)
        Me.Panel2.TabIndex = 8
        '
        'lblCurrentFunction
        '
        Me.lblCurrentFunction.AutoSize = True
        Me.lblCurrentFunction.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentFunction.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFunction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCurrentFunction.Location = New System.Drawing.Point(8, 4)
        Me.lblCurrentFunction.Name = "lblCurrentFunction"
        Me.lblCurrentFunction.Size = New System.Drawing.Size(16, 14)
        Me.lblCurrentFunction.TabIndex = 1
        Me.lblCurrentFunction.Text = "#"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CmdExit.BackColor = System.Drawing.Color.Transparent
        Me.CmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdExit.FlatAppearance.BorderSize = 0
        Me.CmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdExit.Location = New System.Drawing.Point(722, 12)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(8, 8)
        Me.CmdExit.TabIndex = 0
        Me.CmdExit.UseVisualStyleBackColor = False
        '
        'DockPanel
        '
        Me.DockPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DockPanel.BackColor = System.Drawing.Color.Transparent
        Me.DockPanel.Location = New System.Drawing.Point(0, 30)
        Me.DockPanel.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.Size = New System.Drawing.Size(741, 44)
        Me.DockPanel.TabIndex = 34
        '
        'BrowserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "BrowserControl"
        Me.Size = New System.Drawing.Size(741, 421)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Public WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents lblCurrentFunction As System.Windows.Forms.Label
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Protected WithEvents DockPanel As System.Windows.Forms.Panel

End Class
