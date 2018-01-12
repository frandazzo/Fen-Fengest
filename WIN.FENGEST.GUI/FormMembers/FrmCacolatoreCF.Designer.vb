<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCacolatoreCF
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
      Me.T1 = New System.Windows.Forms.TextBox
      Me.txtCF1 = New WIN.GUI.UTILITY.UsabilityTextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Button1 = New System.Windows.Forms.Button
      Me.cboComune1 = New WIN.GUI.UTILITY.UsabilityCombo
      Me.cboProvincia1 = New WIN.GUI.UTILITY.UsabilityCombo
      Me.SpCf = New System.Windows.Forms.Button
      Me.cboNazionalita1 = New WIN.GUI.UTILITY.UsabilityCombo
      Me.dtpData1 = New WIN.GUI.UTILITY.UsabilityDtPicker
      Me.cboSesso1 = New WIN.GUI.UTILITY.UsabilityCombo
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtNome1 = New WIN.GUI.UTILITY.UsabilityTextBox
      Me.txtCognome1 = New WIN.GUI.UTILITY.UsabilityTextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.cmdOK = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'T1
      '
      Me.T1.Location = New System.Drawing.Point(395, 141)
      Me.T1.Name = "T1"
      Me.T1.Size = New System.Drawing.Size(1, 20)
      Me.T1.TabIndex = 32
      '
      'txtCF1
      '
      Me.txtCF1.BackColor = System.Drawing.Color.Transparent
      Me.txtCF1.IsMultiline = False
      Me.txtCF1.Location = New System.Drawing.Point(76, 170)
      Me.txtCF1.Mandatory = False
      Me.txtCF1.Name = "txtCF1"
      Me.txtCF1.OverridedEnable = True
      Me.txtCF1.Required = False
      Me.txtCF1.Size = New System.Drawing.Size(119, 24)
      Me.txtCF1.TabIndex = 7
      Me.txtCF1.TextHeight = 20
      Me.txtCF1.TextValue = ""
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.ForeColor = System.Drawing.Color.DarkGray
      Me.Label5.Location = New System.Drawing.Point(73, 148)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(361, 13)
      Me.Label5.TabIndex = 30
      Me.Label5.Text = "___________________________________________________________"
      '
      'Button1
      '
      Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_calc_16x161
      Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Button1.Location = New System.Drawing.Point(315, 167)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(114, 25)
      Me.Button1.TabIndex = 9
      Me.Button1.Text = "Calc. Dati F&isc."
      Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.Button1.UseVisualStyleBackColor = True
      '
      'cboComune1
      '
      Me.cboComune1.BackColor = System.Drawing.Color.Transparent
      Me.cboComune1.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown
      Me.cboComune1.Location = New System.Drawing.Point(250, 71)
      Me.cboComune1.Mandatory = False
      Me.cboComune1.Name = "cboComune1"
      Me.cboComune1.OverridedEnable = True
      Me.cboComune1.Required = True
      Me.cboComune1.Size = New System.Drawing.Size(173, 26)
      Me.cboComune1.TabIndex = 6
      Me.cboComune1.TextValue = ""
      '
      'cboProvincia1
      '
      Me.cboProvincia1.BackColor = System.Drawing.Color.Transparent
      Me.cboProvincia1.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown
      Me.cboProvincia1.Location = New System.Drawing.Point(250, 44)
      Me.cboProvincia1.Mandatory = False
      Me.cboProvincia1.Name = "cboProvincia1"
      Me.cboProvincia1.OverridedEnable = True
      Me.cboProvincia1.Required = True
      Me.cboProvincia1.Size = New System.Drawing.Size(173, 26)
      Me.cboProvincia1.TabIndex = 5
      Me.cboProvincia1.TextValue = ""
      '
      'SpCf
      '
      Me.SpCf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.SpCf.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_calc_16x16
      Me.SpCf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.SpCf.Location = New System.Drawing.Point(199, 167)
      Me.SpCf.Name = "SpCf"
      Me.SpCf.Size = New System.Drawing.Size(110, 25)
      Me.SpCf.TabIndex = 8
      Me.SpCf.Text = "Calc. Cod. &Fisc."
      Me.SpCf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.SpCf.UseVisualStyleBackColor = True
      '
      'cboNazionalita1
      '
      Me.cboNazionalita1.BackColor = System.Drawing.Color.Transparent
      Me.cboNazionalita1.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown
      Me.cboNazionalita1.Location = New System.Drawing.Point(250, 15)
      Me.cboNazionalita1.Mandatory = False
      Me.cboNazionalita1.Name = "cboNazionalita1"
      Me.cboNazionalita1.OverridedEnable = True
      Me.cboNazionalita1.Required = True
      Me.cboNazionalita1.Size = New System.Drawing.Size(173, 26)
      Me.cboNazionalita1.TabIndex = 4
      Me.cboNazionalita1.TextValue = ""
      '
      'dtpData1
      '
      Me.dtpData1.BackColor = System.Drawing.Color.Transparent
      Me.dtpData1.DataValue = New DateTime(2009, 1, 1)
      Me.dtpData1.Location = New System.Drawing.Point(76, 100)
      Me.dtpData1.Mandatory = False
      Me.dtpData1.Name = "dtpData1"
      Me.dtpData1.OverridedEnable = True
      Me.dtpData1.Required = True
      Me.dtpData1.Size = New System.Drawing.Size(109, 24)
      Me.dtpData1.TabIndex = 3
      '
      'cboSesso1
      '
      Me.cboSesso1.BackColor = System.Drawing.Color.Transparent
      Me.cboSesso1.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown
      Me.cboSesso1.Location = New System.Drawing.Point(76, 71)
      Me.cboSesso1.Mandatory = False
      Me.cboSesso1.Name = "cboSesso1"
      Me.cboSesso1.OverridedEnable = True
      Me.cboSesso1.Required = True
      Me.cboSesso1.Size = New System.Drawing.Size(109, 26)
      Me.cboSesso1.TabIndex = 2
      Me.cboSesso1.TextValue = ""
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(201, 49)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(43, 13)
      Me.Label7.TabIndex = 20
      Me.Label7.Text = "Pr. nas."
      '
      'txtNome1
      '
      Me.txtNome1.BackColor = System.Drawing.Color.Transparent
      Me.txtNome1.IsMultiline = False
      Me.txtNome1.Location = New System.Drawing.Point(76, 44)
      Me.txtNome1.Mandatory = False
      Me.txtNome1.Name = "txtNome1"
      Me.txtNome1.OverridedEnable = True
      Me.txtNome1.Required = True
      Me.txtNome1.Size = New System.Drawing.Size(109, 24)
      Me.txtNome1.TabIndex = 1
      Me.txtNome1.TextHeight = 20
      Me.txtNome1.TextValue = ""
      '
      'txtCognome1
      '
      Me.txtCognome1.BackColor = System.Drawing.Color.Transparent
      Me.txtCognome1.IsMultiline = False
      Me.txtCognome1.Location = New System.Drawing.Point(76, 16)
      Me.txtCognome1.Mandatory = False
      Me.txtCognome1.Name = "txtCognome1"
      Me.txtCognome1.OverridedEnable = True
      Me.txtCognome1.Required = True
      Me.txtCognome1.Size = New System.Drawing.Size(109, 25)
      Me.txtCognome1.TabIndex = 0
      Me.txtCognome1.TextHeight = 20
      Me.txtCognome1.TextValue = ""
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(190, 78)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(54, 13)
      Me.Label4.TabIndex = 14
      Me.Label4.Text = "Com. nas."
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(35, 24)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(35, 13)
      Me.Label3.TabIndex = 13
      Me.Label3.Text = "Cogn."
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(23, 179)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(51, 13)
      Me.Label17.TabIndex = 16
      Me.Label17.Text = "Cod. fisc."
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(35, 49)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(35, 13)
      Me.Label2.TabIndex = 19
      Me.Label2.Text = "Nome"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(42, 78)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(28, 13)
      Me.Label6.TabIndex = 18
      Me.Label6.Text = "Ses."
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(29, 106)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(41, 13)
      Me.Label1.TabIndex = 17
      Me.Label1.Text = "D. nas."
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(215, 24)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(29, 13)
      Me.Label11.TabIndex = 15
      Me.Label11.Text = "Naz."
      '
      'cmdOK
      '
      Me.cmdOK.Location = New System.Drawing.Point(321, 206)
      Me.cmdOK.Name = "cmdOK"
      Me.cmdOK.Size = New System.Drawing.Size(107, 28)
      Me.cmdOK.TabIndex = 33
      Me.cmdOK.Text = "&Ok"
      Me.cmdOK.UseVisualStyleBackColor = True
      '
      'FrmCacolatoreCF
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ControlLightLight
      Me.ClientSize = New System.Drawing.Size(455, 246)
      Me.Controls.Add(Me.cmdOK)
      Me.Controls.Add(Me.T1)
      Me.Controls.Add(Me.txtCF1)
      Me.Controls.Add(Me.txtCognome1)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label11)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.cboComune1)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.cboProvincia1)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.SpCf)
      Me.Controls.Add(Me.Label17)
      Me.Controls.Add(Me.cboNazionalita1)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.dtpData1)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.cboSesso1)
      Me.Controls.Add(Me.txtNome1)
      Me.Controls.Add(Me.Label7)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmCacolatoreCF"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Calcolatore Codice Fiscale"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents T1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCF1 As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents cboComune1 As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents cboProvincia1 As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents SpCf As System.Windows.Forms.Button
   Friend WithEvents cboNazionalita1 As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents dtpData1 As WIN.GUI.UTILITY.UsabilityDtPicker
   Friend WithEvents cboSesso1 As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtNome1 As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents txtCognome1 As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents cmdOK As System.Windows.Forms.Button
End Class
