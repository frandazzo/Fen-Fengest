<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRpdDelegheFinalizzate
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboCaus = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkSelDataRev = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpInA = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkInoltrata = New System.Windows.Forms.CheckBox()
        Me.dtpRevA = New System.Windows.Forms.DateTimePicker()
        Me.chkSottoscritta = New System.Windows.Forms.CheckBox()
        Me.dtpRevDa = New System.Windows.Forms.DateTimePicker()
        Me.chkAttivata = New System.Windows.Forms.CheckBox()
        Me.chkSelDataAtt = New System.Windows.Forms.CheckBox()
        Me.chkAccettata = New System.Windows.Forms.CheckBox()
        Me.chkSelDataAnn = New System.Windows.Forms.CheckBox()
        Me.chkRevocata = New System.Windows.Forms.CheckBox()
        Me.dtpAttDa = New System.Windows.Forms.DateTimePicker()
        Me.chkAnnullata = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpAccDa = New System.Windows.Forms.DateTimePicker()
        Me.dtpAttA = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpAnnA = New System.Windows.Forms.DateTimePicker()
        Me.dtpAccA = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAnnDa = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpInDa = New System.Windows.Forms.DateTimePicker()
        Me.chkSelDataInoltro = New System.Windows.Forms.CheckBox()
        Me.chkSelDataAcc = New System.Windows.Forms.CheckBox()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.chkReg = New System.Windows.Forms.CheckBox()
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(750, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.Label20)
        Me.DockPanel.Controls.Add(Me.CmdRpt)
        Me.DockPanel.Size = New System.Drawing.Size(750, 44)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 22)
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
        Me.CmdRpt.Location = New System.Drawing.Point(53, 9)
        Me.CmdRpt.Name = "CmdRpt"
        Me.CmdRpt.Radius = 32.0!
        Me.CmdRpt.ShowTooltip = True
        Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
        Me.CmdRpt.TabIndex = 84
        Me.CmdRpt.TextValue = ""
        Me.CmdRpt.TooltipText = "Elabora report"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.lblSogg)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(24, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(613, 490)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.Text = "Selezione criteri documenti"
        Me.GroupBox3.Title = "Dati di selezione"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ControlSelPeriodiMensili1)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Location = New System.Drawing.Point(16, 394)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 78)
        Me.Panel1.TabIndex = 96
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(238, 13)
        Me.Label23.TabIndex = 94
        Me.Label23.Text = "Selezione competenza quote associative"
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(275, 84)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Coolaboratore comunale"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(155, 77)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(110, 24)
        Me.IdReferenteTextBox1.TabIndex = 2
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cboEnti)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.lblDescrizioneReferente)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.cboCaus)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.IdReferenteTextBox1)
        Me.Panel4.Location = New System.Drawing.Point(16, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(561, 122)
        Me.Panel4.TabIndex = 97
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.cboEnti.Items.AddRange(New Object() {"CASSA EDILE", "EDILCASSA"})
        Me.cboEnti.Location = New System.Drawing.Point(56, 29)
        Me.cboEnti.Name = "cboEnti"
        Me.cboEnti.Size = New System.Drawing.Size(169, 21)
        Me.cboEnti.TabIndex = 88
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 13)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "Selezione "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Ente"
        '
        'cboCaus
        '
        Me.cboCaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaus.FormattingEnabled = True
        Me.cboCaus.Location = New System.Drawing.Point(327, 29)
        Me.cboCaus.Name = "cboCaus"
        Me.cboCaus.Size = New System.Drawing.Size(211, 21)
        Me.cboCaus.TabIndex = 81
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(250, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Caus. sottosc."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.chkSelDataRev)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.dtpInA)
        Me.Panel3.Controls.Add(Me.chkReg)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.dtpRegDa)
        Me.Panel3.Controls.Add(Me.chkInoltrata)
        Me.Panel3.Controls.Add(Me.dtpRevA)
        Me.Panel3.Controls.Add(Me.chkSottoscritta)
        Me.Panel3.Controls.Add(Me.dtpRegA)
        Me.Panel3.Controls.Add(Me.dtpRevDa)
        Me.Panel3.Controls.Add(Me.chkAttivata)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.chkSelDataAtt)
        Me.Panel3.Controls.Add(Me.chkAccettata)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.chkSelDataAnn)
        Me.Panel3.Controls.Add(Me.chkRevocata)
        Me.Panel3.Controls.Add(Me.dtpAttDa)
        Me.Panel3.Controls.Add(Me.chkAnnullata)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.dtpAccDa)
        Me.Panel3.Controls.Add(Me.dtpAttA)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtpAnnA)
        Me.Panel3.Controls.Add(Me.dtpAccA)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dtpAnnDa)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.dtpInDa)
        Me.Panel3.Controls.Add(Me.chkSelDataInoltro)
        Me.Panel3.Controls.Add(Me.chkSelDataAcc)
        Me.Panel3.Location = New System.Drawing.Point(16, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 221)
        Me.Panel3.TabIndex = 95
        '
        'chkSelDataRev
        '
        Me.chkSelDataRev.AutoSize = True
        Me.chkSelDataRev.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataRev.Location = New System.Drawing.Point(378, 185)
        Me.chkSelDataRev.Name = "chkSelDataRev"
        Me.chkSelDataRev.Size = New System.Drawing.Size(132, 17)
        Me.chkSelDataRev.TabIndex = 94
        Me.chkSelDataRev.Text = "Selezione data revoca"
        Me.chkSelDataRev.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 13)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Selezione stato delega"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(252, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "a"
        '
        'dtpInA
        '
        Me.dtpInA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInA.Location = New System.Drawing.Point(274, 61)
        Me.dtpInA.Name = "dtpInA"
        Me.dtpInA.Size = New System.Drawing.Size(89, 20)
        Me.dtpInA.TabIndex = 76
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(106, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Da"
        '
        'chkInoltrata
        '
        Me.chkInoltrata.AutoSize = True
        Me.chkInoltrata.BackColor = System.Drawing.Color.Transparent
        Me.chkInoltrata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInoltrata.Location = New System.Drawing.Point(13, 64)
        Me.chkInoltrata.Name = "chkInoltrata"
        Me.chkInoltrata.Size = New System.Drawing.Size(64, 17)
        Me.chkInoltrata.TabIndex = 64
        Me.chkInoltrata.Text = "Inoltrata"
        Me.chkInoltrata.UseVisualStyleBackColor = False
        '
        'dtpRevA
        '
        Me.dtpRevA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRevA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRevA.Location = New System.Drawing.Point(274, 185)
        Me.dtpRevA.Name = "dtpRevA"
        Me.dtpRevA.Size = New System.Drawing.Size(89, 20)
        Me.dtpRevA.TabIndex = 96
        '
        'chkSottoscritta
        '
        Me.chkSottoscritta.AutoSize = True
        Me.chkSottoscritta.BackColor = System.Drawing.Color.Transparent
        Me.chkSottoscritta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSottoscritta.Location = New System.Drawing.Point(13, 33)
        Me.chkSottoscritta.Name = "chkSottoscritta"
        Me.chkSottoscritta.Size = New System.Drawing.Size(79, 17)
        Me.chkSottoscritta.TabIndex = 63
        Me.chkSottoscritta.Text = "Sottoscritta"
        Me.chkSottoscritta.UseVisualStyleBackColor = False
        '
        'dtpRevDa
        '
        Me.dtpRevDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRevDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRevDa.Location = New System.Drawing.Point(141, 185)
        Me.dtpRevDa.Name = "dtpRevDa"
        Me.dtpRevDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpRevDa.TabIndex = 95
        '
        'chkAttivata
        '
        Me.chkAttivata.AutoSize = True
        Me.chkAttivata.BackColor = System.Drawing.Color.Transparent
        Me.chkAttivata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAttivata.Location = New System.Drawing.Point(13, 128)
        Me.chkAttivata.Name = "chkAttivata"
        Me.chkAttivata.Size = New System.Drawing.Size(62, 17)
        Me.chkAttivata.TabIndex = 66
        Me.chkAttivata.Text = "Attivata"
        Me.chkAttivata.UseVisualStyleBackColor = False
        '
        'chkSelDataAtt
        '
        Me.chkSelDataAtt.AutoSize = True
        Me.chkSelDataAtt.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataAtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataAtt.Location = New System.Drawing.Point(378, 123)
        Me.chkSelDataAtt.Name = "chkSelDataAtt"
        Me.chkSelDataAtt.Size = New System.Drawing.Size(150, 17)
        Me.chkSelDataAtt.TabIndex = 84
        Me.chkSelDataAtt.Text = "Selezione data attivazione"
        Me.chkSelDataAtt.UseVisualStyleBackColor = False
        '
        'chkAccettata
        '
        Me.chkAccettata.AutoSize = True
        Me.chkAccettata.BackColor = System.Drawing.Color.Transparent
        Me.chkAccettata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccettata.Location = New System.Drawing.Point(13, 95)
        Me.chkAccettata.Name = "chkAccettata"
        Me.chkAccettata.Size = New System.Drawing.Size(72, 17)
        Me.chkAccettata.TabIndex = 65
        Me.chkAccettata.Text = "Accettata"
        Me.chkAccettata.UseVisualStyleBackColor = False
        '
        'chkSelDataAnn
        '
        Me.chkSelDataAnn.AutoSize = True
        Me.chkSelDataAnn.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataAnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataAnn.Location = New System.Drawing.Point(378, 154)
        Me.chkSelDataAnn.Name = "chkSelDataAnn"
        Me.chkSelDataAnn.Size = New System.Drawing.Size(162, 17)
        Me.chkSelDataAnn.TabIndex = 87
        Me.chkSelDataAnn.Text = "Selezione data annullamento"
        Me.chkSelDataAnn.UseVisualStyleBackColor = False
        '
        'chkRevocata
        '
        Me.chkRevocata.AutoSize = True
        Me.chkRevocata.BackColor = System.Drawing.Color.Transparent
        Me.chkRevocata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevocata.Location = New System.Drawing.Point(13, 191)
        Me.chkRevocata.Name = "chkRevocata"
        Me.chkRevocata.Size = New System.Drawing.Size(73, 17)
        Me.chkRevocata.TabIndex = 68
        Me.chkRevocata.Text = "Revocata"
        Me.chkRevocata.UseVisualStyleBackColor = False
        '
        'dtpAttDa
        '
        Me.dtpAttDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAttDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAttDa.Location = New System.Drawing.Point(141, 123)
        Me.dtpAttDa.Name = "dtpAttDa"
        Me.dtpAttDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpAttDa.TabIndex = 85
        '
        'chkAnnullata
        '
        Me.chkAnnullata.AutoSize = True
        Me.chkAnnullata.BackColor = System.Drawing.Color.Transparent
        Me.chkAnnullata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnnullata.Location = New System.Drawing.Point(13, 158)
        Me.chkAnnullata.Name = "chkAnnullata"
        Me.chkAnnullata.Size = New System.Drawing.Size(70, 17)
        Me.chkAnnullata.TabIndex = 67
        Me.chkAnnullata.Text = "Annullata"
        Me.chkAnnullata.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(252, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "a"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(252, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "a"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(106, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Da"
        '
        'dtpAccDa
        '
        Me.dtpAccDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAccDa.Location = New System.Drawing.Point(141, 92)
        Me.dtpAccDa.Name = "dtpAccDa"
        Me.dtpAccDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpAccDa.TabIndex = 78
        '
        'dtpAttA
        '
        Me.dtpAttA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAttA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAttA.Location = New System.Drawing.Point(274, 123)
        Me.dtpAttA.Name = "dtpAttA"
        Me.dtpAttA.Size = New System.Drawing.Size(89, 20)
        Me.dtpAttA.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Da"
        '
        'dtpAnnA
        '
        Me.dtpAnnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAnnA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAnnA.Location = New System.Drawing.Point(274, 154)
        Me.dtpAnnA.Name = "dtpAnnA"
        Me.dtpAnnA.Size = New System.Drawing.Size(89, 20)
        Me.dtpAnnA.TabIndex = 89
        '
        'dtpAccA
        '
        Me.dtpAccA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAccA.Location = New System.Drawing.Point(274, 92)
        Me.dtpAccA.Name = "dtpAccA"
        Me.dtpAccA.Size = New System.Drawing.Size(89, 20)
        Me.dtpAccA.TabIndex = 79
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(106, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Da"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Da"
        '
        'dtpAnnDa
        '
        Me.dtpAnnDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAnnDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAnnDa.Location = New System.Drawing.Point(141, 154)
        Me.dtpAnnDa.Name = "dtpAnnDa"
        Me.dtpAnnDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpAnnDa.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "a"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(252, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "a"
        '
        'dtpInDa
        '
        Me.dtpInDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInDa.Location = New System.Drawing.Point(141, 61)
        Me.dtpInDa.Name = "dtpInDa"
        Me.dtpInDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpInDa.TabIndex = 75
        '
        'chkSelDataInoltro
        '
        Me.chkSelDataInoltro.AutoSize = True
        Me.chkSelDataInoltro.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataInoltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataInoltro.Location = New System.Drawing.Point(378, 61)
        Me.chkSelDataInoltro.Name = "chkSelDataInoltro"
        Me.chkSelDataInoltro.Size = New System.Drawing.Size(127, 17)
        Me.chkSelDataInoltro.TabIndex = 74
        Me.chkSelDataInoltro.Text = "Selezione data inoltro"
        Me.chkSelDataInoltro.UseVisualStyleBackColor = False
        '
        'chkSelDataAcc
        '
        Me.chkSelDataAcc.AutoSize = True
        Me.chkSelDataAcc.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataAcc.Location = New System.Drawing.Point(378, 92)
        Me.chkSelDataAcc.Name = "chkSelDataAcc"
        Me.chkSelDataAcc.Size = New System.Drawing.Size(160, 17)
        Me.chkSelDataAcc.TabIndex = 77
        Me.chkSelDataAcc.Text = "Selezione data accettazione"
        Me.chkSelDataAcc.UseVisualStyleBackColor = False
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.BackColor = System.Drawing.Color.Transparent
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(70, 205)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 87
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.chkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReg.Location = New System.Drawing.Point(380, 29)
        Me.chkReg.Name = "chkReg"
        Me.chkReg.Size = New System.Drawing.Size(117, 17)
        Me.chkReg.TabIndex = 59
        Me.chkReg.Text = "Selezione data reg."
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(143, 31)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(95, 20)
        Me.dtpRegDa.TabIndex = 60
        '
        'dtpRegA
        '
        Me.dtpRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(273, 30)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(90, 20)
        Me.dtpRegA.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Da"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(252, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "a"
        '
        'ControlSelPeriodiMensili1
        '
        Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
        Me.ControlSelPeriodiMensili1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(22, 31)
        Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
        Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(387, 33)
        Me.ControlSelPeriodiMensili1.TabIndex = 95
        '
        'ControlPrepareRpdDelegheFinalizzate
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ControlPrepareRpdDelegheFinalizzate"
        Me.Size = New System.Drawing.Size(750, 652)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboCaus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chkSelDataRev As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpInA As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkInoltrata As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRevA As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSottoscritta As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRevDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAttivata As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSelDataAtt As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccettata As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkSelDataAnn As System.Windows.Forms.CheckBox
    Friend WithEvents chkRevocata As System.Windows.Forms.CheckBox
    Friend WithEvents dtpAttDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAnnullata As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpAccDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAttA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpAnnA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAccA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAnnDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpInDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSelDataInoltro As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelDataAcc As System.Windows.Forms.CheckBox
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili

End Class
