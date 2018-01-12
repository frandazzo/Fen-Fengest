<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlloListeIDs
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.GridIds = New System.Windows.Forms.DataGridView
      Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.IdSelect = New System.Windows.Forms.DataGridViewButtonColumn
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      CType(Me.GridIds, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(3, 17)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(213, 224)
      Me.TabControl1.TabIndex = 0
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.GridIds)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(205, 198)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Id ammessi"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'GridIds
      '
      Me.GridIds.AllowUserToOrderColumns = True
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      Me.GridIds.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridIds.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
      Me.GridIds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdSelect})
      Me.GridIds.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridIds.Location = New System.Drawing.Point(3, 3)
      Me.GridIds.Name = "GridIds"
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
      Me.GridIds.RowsDefaultCellStyle = DataGridViewCellStyle3
      Me.GridIds.Size = New System.Drawing.Size(199, 192)
      Me.GridIds.TabIndex = 0
      '
      'Id
      '
      Me.Id.HeaderText = "Elenco id"
      Me.Id.Name = "Id"
      '
      'IdSelect
      '
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.IdSelect.DefaultCellStyle = DataGridViewCellStyle2
      Me.IdSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.IdSelect.HeaderText = "..."
      Me.IdSelect.Name = "IdSelect"
      Me.IdSelect.Width = 25
      '
      'ControlloListeIDs
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.Controls.Add(Me.TabControl1)
      Me.Name = "ControlloListeIDs"
      Me.Size = New System.Drawing.Size(230, 254)
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      CType(Me.GridIds, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents GridIds As System.Windows.Forms.DataGridView
   Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IdSelect As System.Windows.Forms.DataGridViewButtonColumn

End Class
