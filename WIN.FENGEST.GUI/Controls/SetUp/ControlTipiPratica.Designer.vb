<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTipiPratica
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
        Me.components = New System.ComponentModel.Container()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbochiusa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cborig = New System.Windows.Forms.ComboBox()
        Me.chkrestr = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboconfirm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbointegr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbocontrol = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbojolly = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TipoPraticaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DockPanel.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TipoPraticaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.txtId)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(35, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(53, 21)
        Me.txtId.TabIndex = 53
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(13, 15)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 52
        Me.lblId.Text = "Id"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(99, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(293, 40)
        Me.CustomBar1.TabIndex = 51
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.LightGray
        Me.MainGroup.Controls.Add(Me.Label7)
        Me.MainGroup.Controls.Add(Me.cbochiusa)
        Me.MainGroup.Controls.Add(Me.Label6)
        Me.MainGroup.Controls.Add(Me.cborig)
        Me.MainGroup.Controls.Add(Me.chkrestr)
        Me.MainGroup.Controls.Add(Me.Label5)
        Me.MainGroup.Controls.Add(Me.cboconfirm)
        Me.MainGroup.Controls.Add(Me.Label2)
        Me.MainGroup.Controls.Add(Me.cbointegr)
        Me.MainGroup.Controls.Add(Me.Label1)
        Me.MainGroup.Controls.Add(Me.cbocontrol)
        Me.MainGroup.Controls.Add(Me.Label4)
        Me.MainGroup.Controls.Add(Me.cbojolly)
        Me.MainGroup.Controls.Add(Me.Label3)
        Me.MainGroup.Controls.Add(Me.txtDescr)
        Me.MainGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainGroup.Location = New System.Drawing.Point(11, 93)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(414, 290)
        Me.MainGroup.TabIndex = 35
        Me.MainGroup.Title = "Tipo pratica selezionato"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Ut. prat. chiusa"
        '
        'cbochiusa
        '
        Me.cbochiusa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbochiusa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbochiusa.FormattingEnabled = True
        Me.cbochiusa.Location = New System.Drawing.Point(163, 256)
        Me.cbochiusa.Name = "cbochiusa"
        Me.cbochiusa.Size = New System.Drawing.Size(235, 21)
        Me.cbochiusa.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Ut. prat. rigettata"
        '
        'cborig
        '
        Me.cborig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborig.FormattingEnabled = True
        Me.cborig.Location = New System.Drawing.Point(163, 220)
        Me.cborig.Name = "cborig"
        Me.cborig.Size = New System.Drawing.Size(235, 21)
        Me.cborig.TabIndex = 44
        '
        'chkrestr
        '
        Me.chkrestr.AutoSize = True
        Me.chkrestr.Location = New System.Drawing.Point(292, 34)
        Me.chkrestr.Name = "chkrestr"
        Me.chkrestr.Size = New System.Drawing.Size(106, 17)
        Me.chkrestr.TabIndex = 43
        Me.chkrestr.Text = "Permessi ristretti"
        Me.chkrestr.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Ut. conferma doc"
        '
        'cboconfirm
        '
        Me.cboconfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboconfirm.FormattingEnabled = True
        Me.cboconfirm.Location = New System.Drawing.Point(162, 181)
        Me.cboconfirm.Name = "cboconfirm"
        Me.cboconfirm.Size = New System.Drawing.Size(235, 21)
        Me.cboconfirm.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Ut. integraz. doc"
        '
        'cbointegr
        '
        Me.cbointegr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbointegr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbointegr.FormattingEnabled = True
        Me.cbointegr.Location = New System.Drawing.Point(162, 143)
        Me.cbointegr.Name = "cbointegr"
        Me.cbointegr.Size = New System.Drawing.Size(235, 21)
        Me.cbointegr.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Ut. controllo doc"
        '
        'cbocontrol
        '
        Me.cbocontrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocontrol.FormattingEnabled = True
        Me.cbocontrol.Location = New System.Drawing.Point(162, 106)
        Me.cbocontrol.Name = "cbocontrol"
        Me.cbocontrol.Size = New System.Drawing.Size(235, 21)
        Me.cbocontrol.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Utente jolly"
        '
        'cbojolly
        '
        Me.cbojolly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojolly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbojolly.FormattingEnabled = True
        Me.cbojolly.Location = New System.Drawing.Point(162, 68)
        Me.cbojolly.Name = "cbojolly"
        Me.cbojolly.Size = New System.Drawing.Size(235, 21)
        Me.cbojolly.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(21, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Descrizione"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(92, 32)
        Me.txtDescr.Multiline = True
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(194, 21)
        Me.txtDescr.TabIndex = 29
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.Panel1)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(431, 93)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(218, 290)
        Me.NiceGroupBox1.TabIndex = 39
        Me.NiceGroupBox1.Title = "Riepilogo tipi pratica"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 265)
        Me.Panel1.TabIndex = 36
        '
        'TipoPraticaBindingSource
        '
        Me.TipoPraticaBindingSource.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.TipoPratica)
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(208, 265)
        Me.ListBox1.TabIndex = 0
        '
        'ControlTipiPratica
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.MainGroup)
        Me.Name = "ControlTipiPratica"
        Me.Size = New System.Drawing.Size(741, 383)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TipoPraticaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkrestr As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboconfirm As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbointegr As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbocontrol As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbojolly As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cborig As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbochiusa As System.Windows.Forms.ComboBox
    Friend WithEvents TipoPraticaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
