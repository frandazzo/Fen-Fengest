<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDocumenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchDocumenti))
        Me.cmdCerca = New System.Windows.Forms.Button
        Me.GridPagamenti = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkDoc = New System.Windows.Forms.CheckBox
        Me.chkReg = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTipo = New System.Windows.Forms.ComboBox
        CType(Me.GridPagamenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCerca
        '
        Me.cmdCerca.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.show_16x16
        Me.cmdCerca.Location = New System.Drawing.Point(502, 35)
        Me.cmdCerca.Name = "cmdCerca"
        Me.cmdCerca.Size = New System.Drawing.Size(63, 24)
        Me.cmdCerca.TabIndex = 11
        Me.cmdCerca.Text = "Cerca"
        Me.cmdCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerca.UseVisualStyleBackColor = True
        '
        'GridPagamenti
        '
        Me.GridPagamenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPagamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPagamenti.Location = New System.Drawing.Point(12, 176)
        Me.GridPagamenti.Name = "GridPagamenti"
        Me.GridPagamenti.Size = New System.Drawing.Size(567, 187)
        Me.GridPagamenti.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(488, 149)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkDoc)
        Me.TabPage1.Controls.Add(Me.chkReg)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.dtpDocA)
        Me.TabPage1.Controls.Add(Me.dtpDocDa)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.dtpRegA)
        Me.TabPage1.Controls.Add(Me.dtpRegDa)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cboTipo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(480, 123)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ricerca documento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.Location = New System.Drawing.Point(14, 82)
        Me.chkDoc.Name = "chkDoc"
        Me.chkDoc.Size = New System.Drawing.Size(120, 17)
        Me.chkDoc.TabIndex = 63
        Me.chkDoc.Text = "Selezione data doc."
        Me.chkDoc.UseVisualStyleBackColor = True
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.Location = New System.Drawing.Point(14, 52)
        Me.chkReg.Name = "chkReg"
        Me.chkReg.Size = New System.Drawing.Size(117, 17)
        Me.chkReg.TabIndex = 62
        Me.chkReg.Text = "Selezione data reg."
        Me.chkReg.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "a"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(160, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "da"
        '
        'dtpDocA
        '
        Me.dtpDocA.Enabled = False
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(349, 79)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocA.TabIndex = 59
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Enabled = False
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(188, 78)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo doc."
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"IQA - Incassi quote associative", "IQI  - Incassi quote Inps", "IQP - Incassi quote previsionali", "IQV - Incassi quote vertenza", "PGR - Pagamento referenti"})
        Me.cboTipo.Location = New System.Drawing.Point(66, 12)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(277, 21)
        Me.cboTipo.TabIndex = 0
        '
        'SearchDocumenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(593, 377)
        Me.Controls.Add(Me.cmdCerca)
        Me.Controls.Add(Me.GridPagamenti)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchDocumenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ricerca documento"
        CType(Me.GridPagamenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
   Friend WithEvents GridPagamenti As System.Windows.Forms.DataGridView
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents chkReg As System.Windows.Forms.CheckBox
End Class
