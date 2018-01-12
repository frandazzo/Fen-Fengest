<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchUtenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchUtenti))
        Me.cmdCerca = New System.Windows.Forms.Button
        Me.GridUtenti = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.txtCell2 = New System.Windows.Forms.TextBox
        Me.txtCell1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboNazione = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboComNas = New System.Windows.Forms.ComboBox
        Me.cboComune = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCognome = New System.Windows.Forms.TextBox
        Me.cboProvNas = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkReg = New System.Windows.Forms.CheckBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCF = New System.Windows.Forms.TextBox
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.chkNullFisc = New System.Windows.Forms.CheckBox
        Me.chkAddressNotOk = New System.Windows.Forms.CheckBox
        CType(Me.GridUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.NiceGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCerca
        '
        Me.cmdCerca.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.show_16x16
        Me.cmdCerca.Location = New System.Drawing.Point(566, 223)
        Me.cmdCerca.Name = "cmdCerca"
        Me.cmdCerca.Size = New System.Drawing.Size(80, 25)
        Me.cmdCerca.TabIndex = 27
        Me.cmdCerca.Text = "&Cerca"
        Me.cmdCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerca.UseVisualStyleBackColor = True
        '
        'GridUtenti
        '
        Me.GridUtenti.BackgroundColor = System.Drawing.Color.White
        Me.GridUtenti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUtenti.Location = New System.Drawing.Point(7, 22)
        Me.GridUtenti.Name = "GridUtenti"
        Me.GridUtenti.Size = New System.Drawing.Size(549, 160)
        Me.GridUtenti.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(7, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(670, 299)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NiceGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(662, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ricerca utente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.chkAddressNotOk)
        Me.NiceGroupBox1.Controls.Add(Me.chkNullFisc)
        Me.NiceGroupBox1.Controls.Add(Me.txtCell2)
        Me.NiceGroupBox1.Controls.Add(Me.txtCell1)
        Me.NiceGroupBox1.Controls.Add(Me.Label11)
        Me.NiceGroupBox1.Controls.Add(Me.Label10)
        Me.NiceGroupBox1.Controls.Add(Me.Label7)
        Me.NiceGroupBox1.Controls.Add(Me.cboNazione)
        Me.NiceGroupBox1.Controls.Add(Me.Label6)
        Me.NiceGroupBox1.Controls.Add(Me.cboComNas)
        Me.NiceGroupBox1.Controls.Add(Me.cboComune)
        Me.NiceGroupBox1.Controls.Add(Me.cmdCerca)
        Me.NiceGroupBox1.Controls.Add(Me.Label1)
        Me.NiceGroupBox1.Controls.Add(Me.txtCognome)
        Me.NiceGroupBox1.Controls.Add(Me.cboProvNas)
        Me.NiceGroupBox1.Controls.Add(Me.Label3)
        Me.NiceGroupBox1.Controls.Add(Me.Label5)
        Me.NiceGroupBox1.Controls.Add(Me.Label2)
        Me.NiceGroupBox1.Controls.Add(Me.chkReg)
        Me.NiceGroupBox1.Controls.Add(Me.txtNome)
        Me.NiceGroupBox1.Controls.Add(Me.Label9)
        Me.NiceGroupBox1.Controls.Add(Me.Label17)
        Me.NiceGroupBox1.Controls.Add(Me.Label4)
        Me.NiceGroupBox1.Controls.Add(Me.txtCF)
        Me.NiceGroupBox1.Controls.Add(Me.dtpRegA)
        Me.NiceGroupBox1.Controls.Add(Me.Label12)
        Me.NiceGroupBox1.Controls.Add(Me.dtpRegDa)
        Me.NiceGroupBox1.Controls.Add(Me.cboProvincia)
        Me.NiceGroupBox1.Controls.Add(Me.Label8)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(650, 263)
        Me.NiceGroupBox1.TabIndex = 0
        Me.NiceGroupBox1.Title = ""
        '
        'txtCell2
        '
        Me.txtCell2.Location = New System.Drawing.Point(357, 228)
        Me.txtCell2.Name = "txtCell2"
        Me.txtCell2.Size = New System.Drawing.Size(180, 20)
        Me.txtCell2.TabIndex = 26
        '
        'txtCell1
        '
        Me.txtCell1.Location = New System.Drawing.Point(71, 228)
        Me.txtCell1.Name = "txtCell1"
        Me.txtCell1.Size = New System.Drawing.Size(174, 20)
        Me.txtCell1.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Cell2."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Cell1."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(15, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(538, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "__________________________-______________________________________________________" & _
            "________"
        '
        'cboNazione
        '
        Me.cboNazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNazione.FormattingEnabled = True
        Me.cboNazione.Location = New System.Drawing.Point(71, 113)
        Me.cboNazione.Name = "cboNazione"
        Me.cboNazione.Size = New System.Drawing.Size(179, 21)
        Me.cboNazione.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nazionalità"
        '
        'cboComNas
        '
        Me.cboComNas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComNas.FormattingEnabled = True
        Me.cboComNas.Location = New System.Drawing.Point(71, 172)
        Me.cboComNas.Name = "cboComNas"
        Me.cboComNas.Size = New System.Drawing.Size(179, 21)
        Me.cboComNas.TabIndex = 16
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.cboComune.Location = New System.Drawing.Point(357, 147)
        Me.cboComune.Name = "cboComune"
        Me.cboComune.Size = New System.Drawing.Size(179, 21)
        Me.cboComune.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Com. nas."
        '
        'txtCognome
        '
        Me.txtCognome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCognome.Location = New System.Drawing.Point(71, 26)
        Me.txtCognome.Name = "txtCognome"
        Me.txtCognome.Size = New System.Drawing.Size(120, 20)
        Me.txtCognome.TabIndex = 1
        '
        'cboProvNas
        '
        Me.cboProvNas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvNas.FormattingEnabled = True
        Me.cboProvNas.Location = New System.Drawing.Point(71, 142)
        Me.cboProvNas.Name = "cboProvNas"
        Me.cboProvNas.Size = New System.Drawing.Size(179, 21)
        Me.cboProvNas.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cognome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Prov. nas."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.Location = New System.Drawing.Point(71, 66)
        Me.chkReg.Name = "chkReg"
        Me.chkReg.Size = New System.Drawing.Size(119, 17)
        Me.chkReg.TabIndex = 7
        Me.chkReg.Text = "Selezione data nas."
        Me.chkReg.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(246, 26)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(94, 20)
        Me.txtNome.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(401, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "a"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(363, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Cod. fisc."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "da"
        '
        'txtCF
        '
        Me.txtCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCF.Location = New System.Drawing.Point(420, 26)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(117, 20)
        Me.txtCF.TabIndex = 5
        '
        'dtpRegA
        '
        Me.dtpRegA.Enabled = False
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(420, 65)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegA.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(299, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Prov. res."
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Enabled = False
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(246, 63)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegDa.TabIndex = 9
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(357, 117)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(179, 21)
        Me.cboProvincia.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Com. res."
        '
        'Button1
        '
        Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.show_16x16
        Me.Button1.Location = New System.Drawing.Point(565, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Deleghe"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NiceGroupBox2
        '
        Me.NiceGroupBox2.Controls.Add(Me.GridUtenti)
        Me.NiceGroupBox2.Controls.Add(Me.Button1)
        Me.NiceGroupBox2.Location = New System.Drawing.Point(7, 312)
        Me.NiceGroupBox2.Name = "NiceGroupBox2"
        Me.NiceGroupBox2.Size = New System.Drawing.Size(670, 188)
        Me.NiceGroupBox2.TabIndex = 1
        Me.NiceGroupBox2.Title = "Risultati"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(505, 506)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(594, 506)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnnulla.TabIndex = 3
        Me.cmdAnnulla.Text = "&Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'chkNullFisc
        '
        Me.chkNullFisc.AutoSize = True
        Me.chkNullFisc.Location = New System.Drawing.Point(544, 28)
        Me.chkNullFisc.Name = "chkNullFisc"
        Me.chkNullFisc.Size = New System.Drawing.Size(99, 17)
        Me.chkNullFisc.TabIndex = 6
        Me.chkNullFisc.Text = "Solo codici nulli"
        Me.chkNullFisc.UseVisualStyleBackColor = True
        '
        'chkAddressNotOk
        '
        Me.chkAddressNotOk.AutoSize = True
        Me.chkAddressNotOk.Location = New System.Drawing.Point(357, 178)
        Me.chkAddressNotOk.Name = "chkAddressNotOk"
        Me.chkAddressNotOk.Size = New System.Drawing.Size(270, 17)
        Me.chkAddressNotOk.TabIndex = 21
        Me.chkAddressNotOk.Text = "Utenti con indirizzo non valido(comune,via cap nulli)"
        Me.chkAddressNotOk.UseVisualStyleBackColor = True
        '
        'SearchUtenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(689, 541)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.NiceGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchUtenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ricerca utente"
        CType(Me.GridUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.NiceGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCerca As System.Windows.Forms.Button
    Friend WithEvents GridUtenti As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cboComune As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCF As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCognome As System.Windows.Forms.TextBox
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboComNas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboProvNas As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents txtCell2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCell1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboNazione As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkNullFisc As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddressNotOk As System.Windows.Forms.CheckBox
End Class
