<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchContratti
   Inherits System.Windows.Forms.Form

   'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Richiesto da Progettazione Windows Form
   Private components As System.ComponentModel.IContainer

   'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
   'Può essere modificata in Progettazione Windows Form.  
   'Non modificarla nell'editor del codice.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.cmdCerca = New System.Windows.Forms.Button
      Me.GridContratti = New System.Windows.Forms.DataGridView
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.lblSettore = New System.Windows.Forms.Label
      Me.cboSettori = New System.Windows.Forms.ComboBox
      Me.Contratti = New System.Windows.Forms.DataGridViewTextBoxColumn
      CType(Me.GridContratti, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.SuspendLayout()
      '
      'cmdCerca
      '
      Me.cmdCerca.Location = New System.Drawing.Point(439, 24)
      Me.cmdCerca.Name = "cmdCerca"
      Me.cmdCerca.Size = New System.Drawing.Size(73, 22)
      Me.cmdCerca.TabIndex = 14
      Me.cmdCerca.Text = "Cerca"
      Me.cmdCerca.UseVisualStyleBackColor = True
      '
      'GridContratti
      '
      Me.GridContratti.AllowUserToAddRows = False
      Me.GridContratti.AllowUserToDeleteRows = False
      Me.GridContratti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.GridContratti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GridContratti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Contratti})
      Me.GridContratti.Location = New System.Drawing.Point(22, 132)
      Me.GridContratti.Name = "GridContratti"
      Me.GridContratti.ReadOnly = True
      Me.GridContratti.Size = New System.Drawing.Size(495, 161)
      Me.GridContratti.TabIndex = 13
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(22, 2)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(411, 124)
      Me.TabControl1.TabIndex = 12
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.lblSettore)
      Me.TabPage1.Controls.Add(Me.cboSettori)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(403, 98)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Selezione contratto"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'lblSettore
      '
      Me.lblSettore.AutoSize = True
      Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
      Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSettore.Location = New System.Drawing.Point(24, 25)
      Me.lblSettore.Name = "lblSettore"
      Me.lblSettore.Size = New System.Drawing.Size(41, 13)
      Me.lblSettore.TabIndex = 37
      Me.lblSettore.Text = "Settore"
      '
      'cboSettori
      '
      Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboSettori.FormattingEnabled = True
      Me.cboSettori.Location = New System.Drawing.Point(94, 17)
      Me.cboSettori.Name = "cboSettori"
      Me.cboSettori.Size = New System.Drawing.Size(161, 21)
      Me.cboSettori.TabIndex = 36
      '
      'Contratti
      '
      Me.Contratti.HeaderText = "Contratti"
      Me.Contratti.Name = "Contratti"
      Me.Contratti.ReadOnly = True
      '
      'SearchContratti
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(548, 302)
      Me.Controls.Add(Me.cmdCerca)
      Me.Controls.Add(Me.GridContratti)
      Me.Controls.Add(Me.TabControl1)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "SearchContratti"
      Me.Text = "FrmSearchContratti"
      CType(Me.GridContratti, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
   Friend WithEvents GridContratti As System.Windows.Forms.DataGridView
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
   Friend WithEvents Contratti As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
