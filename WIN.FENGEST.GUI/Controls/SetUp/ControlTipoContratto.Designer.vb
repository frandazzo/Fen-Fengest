<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTipoContratto
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
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtNome = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboSettori = New System.Windows.Forms.ComboBox
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.CmdSel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.dtpEcoA = New System.Windows.Forms.DateTimePicker
      Me.dtpNormA = New System.Windows.Forms.DateTimePicker
      Me.dtpEcoDa = New System.Windows.Forms.DateTimePicker
      Me.dtpNormDa = New System.Windows.Forms.DateTimePicker
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.TextBox1 = New System.Windows.Forms.TextBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.DataGridView1 = New System.Windows.Forms.DataGridView
      Me.Livello = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.Retribuzione = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtId = New System.Windows.Forms.TextBox
      Me.lstContratti = New System.Windows.Forms.ListBox
      Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.PictureBox2 = New System.Windows.Forms.PictureBox
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.GroupBox4 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.DockPanel.SuspendLayout()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox4.SuspendLayout()
      Me.GroupBox3.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(689, 22)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Controls.Add(Me.txtId)
      Me.DockPanel.Controls.Add(Me.Label10)
      Me.DockPanel.Location = New System.Drawing.Point(0, 23)
      Me.DockPanel.Size = New System.Drawing.Size(689, 44)
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(10, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(50, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Contratto"
      '
      'txtNome
      '
      Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNome.Location = New System.Drawing.Point(65, 37)
      Me.txtNome.Name = "txtNome"
      Me.txtNome.Size = New System.Drawing.Size(216, 20)
      Me.txtNome.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(303, 40)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(41, 13)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Settore"
      '
      'cboSettori
      '
      Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSettori.FormattingEnabled = True
      Me.cboSettori.Location = New System.Drawing.Point(348, 37)
      Me.cboSettori.Name = "cboSettori"
      Me.cboSettori.Size = New System.Drawing.Size(162, 21)
      Me.cboSettori.TabIndex = 10
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(225, 2)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(296, 40)
      Me.CustomBar1.TabIndex = 12
      '
      'CmdSel
      '
      Me.CmdSel.ApplyOutLookStile = True
      Me.CmdSel.BackColor = System.Drawing.Color.Transparent
      Me.CmdSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdSel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.txt_2_48x48
      Me.CmdSel.Disabled = False
      Me.CmdSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdSel.ForeColor = System.Drawing.Color.Transparent
      Me.CmdSel.Location = New System.Drawing.Point(445, 35)
      Me.CmdSel.Name = "CmdSel"
      Me.CmdSel.Radius = 48.0!
      Me.CmdSel.ShowTooltip = False
      Me.CmdSel.Size = New System.Drawing.Size(48, 48)
      Me.CmdSel.TabIndex = 19
      Me.CmdSel.TextValue = ""
      Me.ToolTip1.SetToolTip(Me.CmdSel, "Seleziona")
      Me.CmdSel.TooltipText = ""
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(252, 81)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(13, 13)
      Me.Label7.TabIndex = 20
      Me.Label7.Text = "a"
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(252, 37)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(13, 13)
      Me.Label8.TabIndex = 19
      Me.Label8.Text = "a"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(117, 81)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(23, 13)
      Me.Label6.TabIndex = 18
      Me.Label6.Text = "Da "
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(117, 36)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(23, 13)
      Me.Label5.TabIndex = 17
      Me.Label5.Text = "Da "
      '
      'dtpEcoA
      '
      Me.dtpEcoA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpEcoA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpEcoA.Location = New System.Drawing.Point(267, 77)
      Me.dtpEcoA.Name = "dtpEcoA"
      Me.dtpEcoA.Size = New System.Drawing.Size(97, 21)
      Me.dtpEcoA.TabIndex = 16
      '
      'dtpNormA
      '
      Me.dtpNormA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpNormA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpNormA.Location = New System.Drawing.Point(267, 33)
      Me.dtpNormA.Name = "dtpNormA"
      Me.dtpNormA.Size = New System.Drawing.Size(97, 21)
      Me.dtpNormA.TabIndex = 11
      '
      'dtpEcoDa
      '
      Me.dtpEcoDa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpEcoDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpEcoDa.Location = New System.Drawing.Point(145, 77)
      Me.dtpEcoDa.Name = "dtpEcoDa"
      Me.dtpEcoDa.Size = New System.Drawing.Size(97, 21)
      Me.dtpEcoDa.TabIndex = 15
      '
      'dtpNormDa
      '
      Me.dtpNormDa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpNormDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpNormDa.Location = New System.Drawing.Point(145, 33)
      Me.dtpNormDa.Name = "dtpNormDa"
      Me.dtpNormDa.Size = New System.Drawing.Size(97, 21)
      Me.dtpNormDa.TabIndex = 10
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(26, 37)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(66, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Normativa"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(23, 81)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(67, 13)
      Me.Label4.TabIndex = 9
      Me.Label4.Text = "Economica"
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(489, 37)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(72, 21)
      Me.TextBox1.TabIndex = 2
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(373, 41)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(114, 13)
      Me.Label9.TabIndex = 1
      Me.Label9.Text = "Perc. quota delega (%)"
      '
      'DataGridView1
      '
      Me.DataGridView1.AllowUserToOrderColumns = True
      Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Livello, Me.Retribuzione})
      Me.DataGridView1.Location = New System.Drawing.Point(13, 37)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.Size = New System.Drawing.Size(351, 114)
      Me.DataGridView1.TabIndex = 0
      '
      'Livello
      '
      Me.Livello.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.Livello.HeaderText = "Livello inquadramento"
      Me.Livello.Name = "Livello"
      '
      'Retribuzione
      '
      Me.Retribuzione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.Retribuzione.HeaderText = "Retribuzione (Euro)"
      Me.Retribuzione.Name = "Retribuzione"
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Location = New System.Drawing.Point(8, 16)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(65, 13)
      Me.Label10.TabIndex = 16
      Me.Label10.Text = "Id contratto"
      '
      'txtId
      '
      Me.txtId.Enabled = False
      Me.txtId.Location = New System.Drawing.Point(76, 12)
      Me.txtId.Name = "txtId"
      Me.txtId.Size = New System.Drawing.Size(143, 21)
      Me.txtId.TabIndex = 17
      '
      'lstContratti
      '
      Me.lstContratti.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lstContratti.FormattingEnabled = True
      Me.lstContratti.HorizontalScrollbar = True
      Me.lstContratti.Location = New System.Drawing.Point(13, 35)
      Me.lstContratti.Name = "lstContratti"
      Me.lstContratti.Size = New System.Drawing.Size(426, 95)
      Me.lstContratti.Sorted = True
      Me.lstContratti.TabIndex = 18
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.txtNome)
      Me.GroupBox1.Controls.Add(Me.cboSettori)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Location = New System.Drawing.Point(11, 258)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(583, 71)
      Me.GroupBox1.TabIndex = 35
      Me.GroupBox1.Title = "Dati Generali"
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.PictureBox2)
      Me.GroupBox2.Controls.Add(Me.PictureBox1)
      Me.GroupBox2.Controls.Add(Me.Label3)
      Me.GroupBox2.Controls.Add(Me.Label7)
      Me.GroupBox2.Controls.Add(Me.Label4)
      Me.GroupBox2.Controls.Add(Me.dtpNormDa)
      Me.GroupBox2.Controls.Add(Me.Label8)
      Me.GroupBox2.Controls.Add(Me.dtpEcoDa)
      Me.GroupBox2.Controls.Add(Me.dtpNormA)
      Me.GroupBox2.Controls.Add(Me.Label6)
      Me.GroupBox2.Controls.Add(Me.dtpEcoA)
      Me.GroupBox2.Controls.Add(Me.Label5)
      Me.GroupBox2.Location = New System.Drawing.Point(11, 350)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(583, 115)
      Me.GroupBox2.TabIndex = 36
      Me.GroupBox2.Title = "Validità"
      '
      'PictureBox2
      '
      Me.PictureBox2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.orange_arrow
      Me.PictureBox2.Location = New System.Drawing.Point(98, 81)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(9, 16)
      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.PictureBox2.TabIndex = 22
      Me.PictureBox2.TabStop = False
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.orange_arrow
      Me.PictureBox1.Location = New System.Drawing.Point(98, 37)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(9, 16)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.PictureBox1.TabIndex = 21
      Me.PictureBox1.TabStop = False
      '
      'GroupBox4
      '
      Me.GroupBox4.Controls.Add(Me.lstContratti)
      Me.GroupBox4.Controls.Add(Me.CmdSel)
      Me.GroupBox4.Location = New System.Drawing.Point(11, 82)
      Me.GroupBox4.Name = "GroupBox4"
      Me.GroupBox4.Size = New System.Drawing.Size(583, 156)
      Me.GroupBox4.TabIndex = 37
      Me.GroupBox4.Title = "Seleziona Contratti"
      '
      'GroupBox3
      '
      Me.GroupBox3.Controls.Add(Me.DataGridView1)
      Me.GroupBox3.Controls.Add(Me.Label9)
      Me.GroupBox3.Controls.Add(Me.TextBox1)
      Me.GroupBox3.Location = New System.Drawing.Point(11, 487)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(583, 180)
      Me.GroupBox3.TabIndex = 38
      Me.GroupBox3.Title = "Livelli di Inquadramento"
      Me.GroupBox3.Visible = False
      '
      'ControlTipoContratto
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.GroupBox4)
      Me.Controls.Add(Me.GroupBox3)
      Me.Controls.Add(Me.GroupBox2)
      Me.Name = "ControlTipoContratto"
      Me.Size = New System.Drawing.Size(689, 680)
      Me.Controls.SetChildIndex(Me.GroupBox2, 0)
      Me.Controls.SetChildIndex(Me.GroupBox3, 0)
      Me.Controls.SetChildIndex(Me.GroupBox4, 0)
      Me.Controls.SetChildIndex(Me.GroupBox1, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox4.ResumeLayout(False)
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNome As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents dtpEcoA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpNormA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpEcoDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpNormDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Livello As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Retribuzione As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents CmdSel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Private WithEvents lstContratti As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox

End Class
