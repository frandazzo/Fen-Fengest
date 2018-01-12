<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportData
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboSettore = New System.Windows.Forms.ComboBox
        Me.cboEnte = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.numAnno = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdExp = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtResp = New System.Windows.Forms.TextBox
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.chkDel = New System.Windows.Forms.CheckBox
        Me.chkRic = New System.Windows.Forms.CheckBox
        Me.chkVert = New System.Windows.Forms.CheckBox
        Me.chkPrest = New System.Windows.Forms.CheckBox
        CType(Me.numAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settore"
        '
        'cboSettore
        '
        Me.cboSettore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettore.FormattingEnabled = True
        Me.cboSettore.Items.AddRange(New Object() {"EDILE", "IMPIANTI FISSI", "INPS"})
        Me.cboSettore.Location = New System.Drawing.Point(62, 218)
        Me.cboSettore.Name = "cboSettore"
        Me.cboSettore.Size = New System.Drawing.Size(121, 21)
        Me.cboSettore.TabIndex = 1
        '
        'cboEnte
        '
        Me.cboEnte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnte.FormattingEnabled = True
        Me.cboEnte.Items.AddRange(New Object() {"CASSA EDILE", "EDILCASSA", "CALEC", "CEA", "CEAV", "CEC", "CEDA", "CEDAF", "CEDAM", "CELCOF", "CEMA", "CERT", "CEVA", "CEDAIIER", "FALEA"})
        Me.cboEnte.Location = New System.Drawing.Point(62, 252)
        Me.cboEnte.Name = "cboEnte"
        Me.cboEnte.Size = New System.Drawing.Size(121, 21)
        Me.cboEnte.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Periodo"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Items.AddRange(New Object() {"1", "2"})
        Me.cboPeriodo.Location = New System.Drawing.Point(250, 249)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(78, 21)
        Me.cboPeriodo.TabIndex = 5
        '
        'numAnno
        '
        Me.numAnno.Location = New System.Drawing.Point(250, 218)
        Me.numAnno.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.numAnno.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.numAnno.Name = "numAnno"
        Me.numAnno.Size = New System.Drawing.Size(78, 20)
        Me.numAnno.TabIndex = 6
        Me.numAnno.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Anno"
        '
        'cmdExp
        '
        Me.cmdExp.Location = New System.Drawing.Point(172, 409)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(75, 23)
        Me.cmdExp.TabIndex = 8
        Me.cmdExp.Text = "Esporta"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(263, 409)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Annulla"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(13, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(324, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Parametri esportazione___________________________________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Responsabile"
        '
        'txtResp
        '
        Me.txtResp.Location = New System.Drawing.Point(93, 125)
        Me.txtResp.Name = "txtResp"
        Me.txtResp.Size = New System.Drawing.Size(232, 20)
        Me.txtResp.TabIndex = 12
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(93, 151)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(232, 20)
        Me.txtMail.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mail"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(93, 60)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(122, 20)
        Me.txtPassword.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(93, 34)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(122, 20)
        Me.txtUser.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Username"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Provincia"
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(93, 91)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(167, 21)
        Me.cboProvincia.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(12, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(322, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Credenziali____________________________________________"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(18, 298)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Esporta documenti utente"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkDel
        '
        Me.chkDel.AutoSize = True
        Me.chkDel.Location = New System.Drawing.Point(18, 321)
        Me.chkDel.Name = "chkDel"
        Me.chkDel.Size = New System.Drawing.Size(136, 17)
        Me.chkDel.TabIndex = 24
        Me.chkDel.Text = "Esporta deleghe utente"
        Me.chkDel.UseVisualStyleBackColor = True
        '
        'chkRic
        '
        Me.chkRic.AutoSize = True
        Me.chkRic.Location = New System.Drawing.Point(18, 344)
        Me.chkRic.Name = "chkRic"
        Me.chkRic.Size = New System.Drawing.Size(169, 17)
        Me.chkRic.TabIndex = 25
        Me.chkRic.Text = "Esporta richieste lavoro utente"
        Me.chkRic.UseVisualStyleBackColor = True
        '
        'chkVert
        '
        Me.chkVert.AutoSize = True
        Me.chkVert.Location = New System.Drawing.Point(18, 367)
        Me.chkVert.Name = "chkVert"
        Me.chkVert.Size = New System.Drawing.Size(139, 17)
        Me.chkVert.TabIndex = 26
        Me.chkVert.Text = "Esporta vertenze utente"
        Me.chkVert.UseVisualStyleBackColor = True
        '
        'chkPrest
        '
        Me.chkPrest.AutoSize = True
        Me.chkPrest.Location = New System.Drawing.Point(18, 390)
        Me.chkPrest.Name = "chkPrest"
        Me.chkPrest.Size = New System.Drawing.Size(148, 17)
        Me.chkPrest.TabIndex = 27
        Me.chkPrest.Text = "Esporta prestazioni utente"
        Me.chkPrest.UseVisualStyleBackColor = True
        '
        'FrmExportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(350, 440)
        Me.Controls.Add(Me.chkPrest)
        Me.Controls.Add(Me.chkVert)
        Me.Controls.Add(Me.chkRic)
        Me.Controls.Add(Me.chkDel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtResp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdExp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numAnno)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEnte)
        Me.Controls.Add(Me.cboSettore)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmExportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esportazione dati al database nazionale"
        CType(Me.numAnno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSettore As System.Windows.Forms.ComboBox
    Friend WithEvents cboEnte As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents numAnno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdExp As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResp As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDel As System.Windows.Forms.CheckBox
    Friend WithEvents chkRic As System.Windows.Forms.CheckBox
    Friend WithEvents chkVert As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrest As System.Windows.Forms.CheckBox
End Class
