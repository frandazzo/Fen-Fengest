<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchOfferte
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchOfferte))
      Me.cmdCerca = New System.Windows.Forms.Button
      Me.GridOfferte = New System.Windows.Forms.DataGridView
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.chkDomanda = New System.Windows.Forms.ComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.chkDoc = New System.Windows.Forms.CheckBox
      Me.chkReg = New System.Windows.Forms.CheckBox
      Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.dtpRegA = New System.Windows.Forms.DateTimePicker
      Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
      CType(Me.GridOfferte, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.SuspendLayout()
      '
      'cmdCerca
      '
      Me.cmdCerca.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.show_16x16
      Me.cmdCerca.Location = New System.Drawing.Point(506, 33)
      Me.cmdCerca.Name = "cmdCerca"
      Me.cmdCerca.Size = New System.Drawing.Size(63, 24)
      Me.cmdCerca.TabIndex = 14
      Me.cmdCerca.Text = "Cerca"
      Me.cmdCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdCerca.UseVisualStyleBackColor = True
      '
      'GridOfferte
      '
      Me.GridOfferte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GridOfferte.Location = New System.Drawing.Point(12, 235)
      Me.GridOfferte.Name = "GridOfferte"
      Me.GridOfferte.Size = New System.Drawing.Size(557, 210)
      Me.GridOfferte.TabIndex = 13
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(12, 14)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(488, 202)
      Me.TabControl1.TabIndex = 12
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.chkDomanda)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Controls.Add(Me.IdAziendaTextBox1)
      Me.TabPage1.Controls.Add(Me.Label1)
      Me.TabPage1.Controls.Add(Me.chkDoc)
      Me.TabPage1.Controls.Add(Me.chkReg)
      Me.TabPage1.Controls.Add(Me.dtpDocDa)
      Me.TabPage1.Controls.Add(Me.Label9)
      Me.TabPage1.Controls.Add(Me.Label4)
      Me.TabPage1.Controls.Add(Me.dtpRegA)
      Me.TabPage1.Controls.Add(Me.dtpRegDa)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(480, 176)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Ricerca domande"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'chkDomanda
      '
      Me.chkDomanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.chkDomanda.FormattingEnabled = True
      Me.chkDomanda.Location = New System.Drawing.Point(82, 131)
      Me.chkDomanda.Name = "chkDomanda"
      Me.chkDomanda.Size = New System.Drawing.Size(210, 21)
      Me.chkDomanda.TabIndex = 67
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(19, 139)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(39, 13)
      Me.Label2.TabIndex = 66
      Me.Label2.Text = "Offerta"
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(82, 81)
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(110, 37)
      Me.IdAziendaTextBox1.TabIndex = 65
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(11, 90)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(56, 13)
      Me.Label1.TabIndex = 64
      Me.Label1.Text = "Id azienda"
      '
      'chkDoc
      '
      Me.chkDoc.AutoSize = True
      Me.chkDoc.Location = New System.Drawing.Point(14, 17)
      Me.chkDoc.Name = "chkDoc"
      Me.chkDoc.Size = New System.Drawing.Size(96, 17)
      Me.chkDoc.TabIndex = 63
      Me.chkDoc.Text = "Selezione data"
      Me.chkDoc.UseVisualStyleBackColor = True
      '
      'chkReg
      '
      Me.chkReg.AutoSize = True
      Me.chkReg.Location = New System.Drawing.Point(14, 52)
      Me.chkReg.Name = "chkReg"
      Me.chkReg.Size = New System.Drawing.Size(138, 17)
      Me.chkReg.TabIndex = 62
      Me.chkReg.Text = "Selezione range validità"
      Me.chkReg.UseVisualStyleBackColor = True
      '
      'dtpDocDa
      '
      Me.dtpDocDa.Enabled = False
      Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDocDa.Location = New System.Drawing.Point(188, 13)
      Me.dtpDocDa.Name = "dtpDocDa"
      Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
      Me.dtpDocDa.TabIndex = 58
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(330, 56)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(13, 13)
      Me.Label9.TabIndex = 57
      Me.Label9.Text = "a"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(160, 55)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(19, 13)
      Me.Label4.TabIndex = 56
      Me.Label4.Text = "da"
      '
      'dtpRegA
      '
      Me.dtpRegA.Enabled = False
      Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpRegA.Location = New System.Drawing.Point(349, 49)
      Me.dtpRegA.Name = "dtpRegA"
      Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
      Me.dtpRegA.TabIndex = 55
      '
      'dtpRegDa
      '
      Me.dtpRegDa.Enabled = False
      Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpRegDa.Location = New System.Drawing.Point(188, 48)
      Me.dtpRegDa.Name = "dtpRegDa"
      Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
      Me.dtpRegDa.TabIndex = 54
      '
      'SearchOfferte
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(581, 457)
      Me.Controls.Add(Me.cmdCerca)
      Me.Controls.Add(Me.GridOfferte)
      Me.Controls.Add(Me.TabControl1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "SearchOfferte"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ricerca domande di lavoro"
      CType(Me.GridOfferte, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
   Friend WithEvents GridOfferte As System.Windows.Forms.DataGridView
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents chkReg As System.Windows.Forms.CheckBox
   Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents chkDomanda As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
