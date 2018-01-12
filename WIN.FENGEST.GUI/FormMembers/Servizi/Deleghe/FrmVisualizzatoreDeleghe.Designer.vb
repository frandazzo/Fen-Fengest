<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisualizzatoreDeleghe
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.GridDeleghe = New System.Windows.Forms.DataGridView
      Me.lblDescrizioneUtente = New System.Windows.Forms.Label
      Me.NiceGroupBox1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      CType(Me.GridDeleghe, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.Label1)
      Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
      Me.NiceGroupBox1.Controls.Add(Me.lblDescrizioneUtente)
      Me.NiceGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.NiceGroupBox1.Location = New System.Drawing.Point(0, 0)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(716, 309)
      Me.NiceGroupBox1.TabIndex = 36
      Me.NiceGroupBox1.Title = "Deleghe"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(14, 31)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(49, 13)
      Me.Label1.TabIndex = 14
      Me.Label1.Text = "Utente:"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.ItemSize = New System.Drawing.Size(71, 18)
      Me.TabControl1.Location = New System.Drawing.Point(12, 54)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(688, 236)
      Me.TabControl1.TabIndex = 12
      '
      'TabPage1
      '
      Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
      Me.TabPage1.Controls.Add(Me.GridDeleghe)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(680, 210)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Lista deleghe"
      '
      'GridDeleghe
      '
      Me.GridDeleghe.AllowUserToAddRows = False
      Me.GridDeleghe.AllowUserToDeleteRows = False
      Me.GridDeleghe.AllowUserToOrderColumns = True
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.NullValue = Nothing
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridDeleghe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridDeleghe.BackgroundColor = System.Drawing.Color.WhiteSmoke
      Me.GridDeleghe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.GridDeleghe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridDeleghe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridDeleghe.DefaultCellStyle = DataGridViewCellStyle3
      Me.GridDeleghe.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridDeleghe.GridColor = System.Drawing.Color.LightGray
      Me.GridDeleghe.Location = New System.Drawing.Point(3, 3)
      Me.GridDeleghe.Name = "GridDeleghe"
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridDeleghe.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      Me.GridDeleghe.RowHeadersWidth = 30
      Me.GridDeleghe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridDeleghe.Size = New System.Drawing.Size(674, 204)
      Me.GridDeleghe.TabIndex = 11
      '
      'lblDescrizioneUtente
      '
      Me.lblDescrizioneUtente.AutoSize = True
      Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneUtente.Location = New System.Drawing.Point(62, 32)
      Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
      Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneUtente.TabIndex = 13
      '
      'FrmVisualizzatoreDeleghe
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(716, 309)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
      Me.Name = "FrmVisualizzatoreDeleghe"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Deleghe utente"
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      CType(Me.GridDeleghe, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents GridDeleghe As System.Windows.Forms.DataGridView
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
End Class
