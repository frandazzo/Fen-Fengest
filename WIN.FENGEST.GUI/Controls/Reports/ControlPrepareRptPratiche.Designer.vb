<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRptPratiche
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
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.chkUt = New System.Windows.Forms.CheckBox()
        Me.cmdUt = New System.Windows.Forms.Button()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.cboTipoPratica = New System.Windows.Forms.ComboBox()
        Me.chkReg = New System.Windows.Forms.CheckBox()
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.chkInoltrata = New System.Windows.Forms.CheckBox()
        Me.chkSottoscritta = New System.Windows.Forms.CheckBox()
        Me.chkAttivata = New System.Windows.Forms.CheckBox()
        Me.chkAccettata = New System.Windows.Forms.CheckBox()
        Me.chkRevocata = New System.Windows.Forms.CheckBox()
        Me.chkAnnullata = New System.Windows.Forms.CheckBox()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProp = New System.Windows.Forms.ComboBox()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(724, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.Label20)
        Me.DockPanel.Controls.Add(Me.CmdRpt)
        Me.DockPanel.Size = New System.Drawing.Size(724, 44)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.lblSogg)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(11, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(613, 280)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.Text = "Selezione criteri documenti"
        Me.GroupBox3.Title = "Dati di selezione"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.cboProp)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.cboUser)
        Me.Panel4.Controls.Add(Me.chkUt)
        Me.Panel4.Controls.Add(Me.cmdUt)
        Me.Panel4.Controls.Add(Me.lblSettore)
        Me.Panel4.Controls.Add(Me.cboTipoPratica)
        Me.Panel4.Controls.Add(Me.chkReg)
        Me.Panel4.Controls.Add(Me.dtpRegA)
        Me.Panel4.Controls.Add(Me.dtpRegDa)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(16, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(561, 160)
        Me.Panel4.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "In carico a:"
        '
        'cboUser
        '
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(91, 96)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(300, 21)
        Me.cboUser.TabIndex = 83
        '
        'chkUt
        '
        Me.chkUt.AutoSize = True
        Me.chkUt.BackColor = System.Drawing.Color.Transparent
        Me.chkUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUt.Location = New System.Drawing.Point(174, 132)
        Me.chkUt.Name = "chkUt"
        Me.chkUt.Size = New System.Drawing.Size(122, 17)
        Me.chkUt.TabIndex = 81
        Me.chkUt.Text = "Selezione lista utenti"
        Me.chkUt.UseVisualStyleBackColor = False
        '
        'cmdUt
        '
        Me.cmdUt.Enabled = False
        Me.cmdUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(89, 126)
        Me.cmdUt.Name = "cmdUt"
        Me.cmdUt.Size = New System.Drawing.Size(77, 26)
        Me.cmdUt.TabIndex = 82
        Me.cmdUt.Text = "Seleziona"
        Me.cmdUt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUt.UseVisualStyleBackColor = True
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(14, 51)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(66, 13)
        Me.lblSettore.TabIndex = 80
        Me.lblSettore.Text = "Tipo pratica:"
        '
        'cboTipoPratica
        '
        Me.cboTipoPratica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPratica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPratica.FormattingEnabled = True
        Me.cboTipoPratica.Location = New System.Drawing.Point(91, 43)
        Me.cboTipoPratica.Name = "cboTipoPratica"
        Me.cboTipoPratica.Size = New System.Drawing.Size(300, 21)
        Me.cboTipoPratica.TabIndex = 79
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.chkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReg.Location = New System.Drawing.Point(378, 11)
        Me.chkReg.Name = "chkReg"
        Me.chkReg.Size = New System.Drawing.Size(96, 17)
        Me.chkReg.TabIndex = 59
        Me.chkReg.Text = "Selezione data"
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'dtpRegA
        '
        Me.dtpRegA.Enabled = False
        Me.dtpRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(223, 9)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(90, 20)
        Me.dtpRegA.TabIndex = 61
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Enabled = False
        Me.dtpRegDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(87, 9)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(95, 20)
        Me.dtpRegDa.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Da"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.chkInoltrata)
        Me.Panel3.Controls.Add(Me.chkSottoscritta)
        Me.Panel3.Controls.Add(Me.chkAttivata)
        Me.Panel3.Controls.Add(Me.chkAccettata)
        Me.Panel3.Controls.Add(Me.chkRevocata)
        Me.Panel3.Controls.Add(Me.chkAnnullata)
        Me.Panel3.Location = New System.Drawing.Point(16, 199)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 70)
        Me.Panel3.TabIndex = 95
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(137, 13)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Selezione stato pratica"
        '
        'chkInoltrata
        '
        Me.chkInoltrata.AutoSize = True
        Me.chkInoltrata.BackColor = System.Drawing.Color.Transparent
        Me.chkInoltrata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInoltrata.Location = New System.Drawing.Point(89, 33)
        Me.chkInoltrata.Name = "chkInoltrata"
        Me.chkInoltrata.Size = New System.Drawing.Size(91, 17)
        Me.chkInoltrata.TabIndex = 64
        Me.chkInoltrata.Text = "Controllo doc."
        Me.chkInoltrata.UseVisualStyleBackColor = False
        '
        'chkSottoscritta
        '
        Me.chkSottoscritta.AutoSize = True
        Me.chkSottoscritta.BackColor = System.Drawing.Color.Transparent
        Me.chkSottoscritta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSottoscritta.Location = New System.Drawing.Point(13, 33)
        Me.chkSottoscritta.Name = "chkSottoscritta"
        Me.chkSottoscritta.Size = New System.Drawing.Size(57, 17)
        Me.chkSottoscritta.TabIndex = 63
        Me.chkSottoscritta.Text = "Aperta"
        Me.chkSottoscritta.UseVisualStyleBackColor = False
        '
        'chkAttivata
        '
        Me.chkAttivata.AutoSize = True
        Me.chkAttivata.BackColor = System.Drawing.Color.Transparent
        Me.chkAttivata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAttivata.Location = New System.Drawing.Point(289, 33)
        Me.chkAttivata.Name = "chkAttivata"
        Me.chkAttivata.Size = New System.Drawing.Size(91, 17)
        Me.chkAttivata.TabIndex = 66
        Me.chkAttivata.Text = "Integraz. doc."
        Me.chkAttivata.UseVisualStyleBackColor = False
        '
        'chkAccettata
        '
        Me.chkAccettata.AutoSize = True
        Me.chkAccettata.BackColor = System.Drawing.Color.Transparent
        Me.chkAccettata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccettata.Location = New System.Drawing.Point(191, 33)
        Me.chkAccettata.Name = "chkAccettata"
        Me.chkAccettata.Size = New System.Drawing.Size(80, 17)
        Me.chkAccettata.TabIndex = 65
        Me.chkAccettata.Text = "Confermata"
        Me.chkAccettata.UseVisualStyleBackColor = False
        '
        'chkRevocata
        '
        Me.chkRevocata.AutoSize = True
        Me.chkRevocata.BackColor = System.Drawing.Color.Transparent
        Me.chkRevocata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevocata.Location = New System.Drawing.Point(484, 33)
        Me.chkRevocata.Name = "chkRevocata"
        Me.chkRevocata.Size = New System.Drawing.Size(58, 17)
        Me.chkRevocata.TabIndex = 68
        Me.chkRevocata.Text = "Chiusa"
        Me.chkRevocata.UseVisualStyleBackColor = False
        '
        'chkAnnullata
        '
        Me.chkAnnullata.AutoSize = True
        Me.chkAnnullata.BackColor = System.Drawing.Color.Transparent
        Me.chkAnnullata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnnullata.Location = New System.Drawing.Point(398, 33)
        Me.chkAnnullata.Name = "chkAnnullata"
        Me.chkAnnullata.Size = New System.Drawing.Size(69, 17)
        Me.chkAnnullata.TabIndex = 67
        Me.chkAnnullata.Text = "Rigettata"
        Me.chkAnnullata.UseVisualStyleBackColor = False
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.BackColor = System.Drawing.Color.Transparent
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(70, 158)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 87
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Cerca"
        '
        'CmdRpt
        '
        Me.CmdRpt.ApplyOutLookStile = True
        Me.CmdRpt.BackColor = System.Drawing.Color.Transparent
        Me.CmdRpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x32
        Me.CmdRpt.Disabled = False
        Me.CmdRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRpt.ForeColor = System.Drawing.Color.Transparent
        Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.Location = New System.Drawing.Point(56, 6)
        Me.CmdRpt.Name = "CmdRpt"
        Me.CmdRpt.Radius = 32.0!
        Me.CmdRpt.ShowTooltip = True
        Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
        Me.CmdRpt.TabIndex = 84
        Me.CmdRpt.TextValue = ""
        Me.CmdRpt.TooltipText = "Elabora report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Proprietario:"
        '
        'cboProp
        '
        Me.cboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProp.FormattingEnabled = True
        Me.cboProp.Location = New System.Drawing.Point(91, 69)
        Me.cboProp.Name = "cboProp"
        Me.cboProp.Size = New System.Drawing.Size(300, 21)
        Me.cboProp.TabIndex = 85
        '
        'ControlPrepareRptPratiche
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ControlPrepareRptPratiche"
        Me.Size = New System.Drawing.Size(724, 362)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents cboTipoPratica As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkInoltrata As System.Windows.Forms.CheckBox
    Friend WithEvents chkSottoscritta As System.Windows.Forms.CheckBox
    Friend WithEvents chkAttivata As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccettata As System.Windows.Forms.CheckBox
    Friend WithEvents chkRevocata As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnnullata As System.Windows.Forms.CheckBox
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents chkUt As System.Windows.Forms.CheckBox
    Friend WithEvents cmdUt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboProp As System.Windows.Forms.ComboBox

End Class
