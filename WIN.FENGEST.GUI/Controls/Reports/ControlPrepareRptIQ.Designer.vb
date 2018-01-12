<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRptIQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPrepareRptIQ))
        Me.chkIQA = New System.Windows.Forms.CheckBox()
        Me.chkIQI = New System.Windows.Forms.CheckBox()
        Me.chkIQV = New System.Windows.Forms.CheckBox()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker()
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker()
        Me.chkSogg = New System.Windows.Forms.CheckBox()
        Me.chkComp = New System.Windows.Forms.CheckBox()
        Me.chkDoc = New System.Windows.Forms.CheckBox()
        Me.chkReg = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.chkIQP = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.optYes = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optNo = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IdAziendaTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.cmdUt = New System.Windows.Forms.Button()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboContratti = New System.Windows.Forms.ComboBox()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(726, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.Label2)
        Me.DockPanel.Controls.Add(Me.CmdRpt)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(726, 44)
        '
        'chkIQA
        '
        Me.chkIQA.AutoSize = True
        Me.chkIQA.BackColor = System.Drawing.Color.Transparent
        Me.chkIQA.Checked = True
        Me.chkIQA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIQA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkIQA, "Spuntare questa casella se si vogliono visualizzare gli incassi delle quote assoc" & _
        "iative.")
        Me.chkIQA.Location = New System.Drawing.Point(16, 27)
        Me.chkIQA.Name = "chkIQA"
        Me.HelpProvider1.SetShowHelp(Me.chkIQA, True)
        Me.chkIQA.Size = New System.Drawing.Size(145, 17)
        Me.chkIQA.TabIndex = 9
        Me.chkIQA.Text = "Incassi quote associative"
        Me.chkIQA.UseVisualStyleBackColor = False
        '
        'chkIQI
        '
        Me.chkIQI.AutoSize = True
        Me.chkIQI.BackColor = System.Drawing.Color.Transparent
        Me.chkIQI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkIQI, "Spuntare questa casella se si vogliono visualizzare gli incassi delle quote Inps." & _
        "")
        Me.chkIQI.Location = New System.Drawing.Point(186, 27)
        Me.chkIQI.Name = "chkIQI"
        Me.HelpProvider1.SetShowHelp(Me.chkIQI, True)
        Me.chkIQI.Size = New System.Drawing.Size(112, 17)
        Me.chkIQI.TabIndex = 10
        Me.chkIQI.Text = "Incassi quote Inps"
        Me.chkIQI.UseVisualStyleBackColor = False
        '
        'chkIQV
        '
        Me.chkIQV.AutoSize = True
        Me.chkIQV.BackColor = System.Drawing.Color.Transparent
        Me.chkIQV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkIQV, "Spuntare questa casella se si vogliono visualizzare gli incassi delle quote verte" & _
        "nza.")
        Me.chkIQV.Location = New System.Drawing.Point(327, 27)
        Me.chkIQV.Name = "chkIQV"
        Me.HelpProvider1.SetShowHelp(Me.chkIQV, True)
        Me.chkIQV.Size = New System.Drawing.Size(133, 17)
        Me.chkIQV.TabIndex = 11
        Me.chkIQV.Text = "Incassi quote vertenza"
        Me.chkIQV.UseVisualStyleBackColor = False
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.BackColor = System.Drawing.Color.Transparent
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(283, 28)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(253, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "a"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Da"
        '
        'dtpDocA
        '
        Me.dtpDocA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(284, 87)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(142, 20)
        Me.dtpDocA.TabIndex = 64
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(84, 87)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(139, 20)
        Me.dtpDocDa.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 63)
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
        Me.Label4.Location = New System.Drawing.Point(49, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Da"
        '
        'dtpRegA
        '
        Me.dtpRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(284, 57)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(142, 20)
        Me.dtpRegA.TabIndex = 61
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(84, 57)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(139, 20)
        Me.dtpRegDa.TabIndex = 60
        '
        'chkSogg
        '
        Me.chkSogg.AutoSize = True
        Me.chkSogg.BackColor = System.Drawing.Color.Transparent
        Me.chkSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkSogg, "Spuntare questa casella se si vuole che il report visualizzi solo le quote incass" & _
        "ate di uno o più utenti specifici.")
        Me.chkSogg.Location = New System.Drawing.Point(169, 26)
        Me.chkSogg.Name = "chkSogg"
        Me.HelpProvider1.SetShowHelp(Me.chkSogg, True)
        Me.chkSogg.Size = New System.Drawing.Size(101, 17)
        Me.chkSogg.TabIndex = 68
        Me.chkSogg.Text = "Selezione utenti"
        Me.chkSogg.UseVisualStyleBackColor = False
        '
        'chkComp
        '
        Me.chkComp.AutoSize = True
        Me.chkComp.BackColor = System.Drawing.Color.Transparent
        Me.chkComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkComp, "Spuntare questa casella se si vuole selezionare quegli utenti per cui esiste un i" & _
        "ncasso di una quota associativa la cui competenza sia contenuta nel periodo sele" & _
        "zionato")
        Me.chkComp.Location = New System.Drawing.Point(439, 120)
        Me.chkComp.Name = "chkComp"
        Me.HelpProvider1.SetShowHelp(Me.chkComp, True)
        Me.chkComp.Size = New System.Drawing.Size(136, 17)
        Me.chkComp.TabIndex = 65
        Me.chkComp.Text = "Selezione  competenza"
        Me.chkComp.UseVisualStyleBackColor = False
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.chkDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkDoc, resources.GetString("chkDoc.HelpString"))
        Me.chkDoc.Location = New System.Drawing.Point(439, 89)
        Me.chkDoc.Name = "chkDoc"
        Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
        Me.chkDoc.Size = New System.Drawing.Size(120, 17)
        Me.chkDoc.TabIndex = 62
        Me.chkDoc.Text = "Selezione data doc."
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.chkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
        Me.chkReg.Location = New System.Drawing.Point(439, 59)
        Me.chkReg.Name = "chkReg"
        Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
        Me.chkReg.Size = New System.Drawing.Size(117, 17)
        Me.chkReg.TabIndex = 59
        Me.chkReg.Text = "Selezione data reg."
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.chkIQP)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.chkIQV)
        Me.GroupBox1.Controls.Add(Me.chkIQA)
        Me.GroupBox1.Controls.Add(Me.chkIQI)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 459)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.Text = "Selezione tipo quote"
        Me.GroupBox1.Title = "Selezione"
        '
        'chkIQP
        '
        Me.chkIQP.AutoSize = True
        Me.chkIQP.BackColor = System.Drawing.Color.Transparent
        Me.chkIQP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkIQP, "Spuntare questa casella se si vogliono visualizzare gli incassi delle quote verte" & _
        "nza.")
        Me.chkIQP.Location = New System.Drawing.Point(480, 27)
        Me.chkIQP.Name = "chkIQP"
        Me.HelpProvider1.SetShowHelp(Me.chkIQP, True)
        Me.chkIQP.Size = New System.Drawing.Size(144, 17)
        Me.chkIQP.TabIndex = 97
        Me.chkIQP.Text = "Incassi quote previsionali"
        Me.chkIQP.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblDescrizioneReferente)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.IdReferenteTextBox1)
        Me.Panel1.Controls.Add(Me.optYes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.optNo)
        Me.Panel1.Controls.Add(Me.optAll)
        Me.Panel1.Location = New System.Drawing.Point(17, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 112)
        Me.Panel1.TabIndex = 96
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(199, 73)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(14, 13)
        Me.lblDescrizioneReferente.TabIndex = 5
        Me.lblDescrizioneReferente.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Selezione collaboratori"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.IdReferenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale. Se selezionato,il report conterrà tutt" & _
        "i gli incassi delle quote che fanno riferimento a quel collaboratore comunale.")
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(93, 66)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(98, 26)
        Me.IdReferenteTextBox1.TabIndex = 4
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'optYes
        '
        Me.optYes.AutoSize = True
        Me.optYes.BackColor = System.Drawing.Color.Transparent
        Me.optYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.optYes, "Spuntare questa casella se si vuole il report delle quote incassate e già ristorn" & _
        "ate per un collaboratore comunale ")
        Me.optYes.Location = New System.Drawing.Point(31, 31)
        Me.optYes.Name = "optYes"
        Me.HelpProvider1.SetShowHelp(Me.optYes, True)
        Me.optYes.Size = New System.Drawing.Size(112, 17)
        Me.optYes.TabIndex = 0
        Me.optYes.Text = "Posizioni ristornate"
        Me.optYes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id coll."
        '
        'optNo
        '
        Me.optNo.AutoSize = True
        Me.optNo.BackColor = System.Drawing.Color.Transparent
        Me.optNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.optNo, "Spuntare questa casella se si vuole il report delle quote incassate e non ancora " & _
        "ristornate per un collaboratore comunale ")
        Me.optNo.Location = New System.Drawing.Point(152, 31)
        Me.optNo.Name = "optNo"
        Me.HelpProvider1.SetShowHelp(Me.optNo, True)
        Me.optNo.Size = New System.Drawing.Size(133, 17)
        Me.optNo.TabIndex = 1
        Me.optNo.Text = "Posizioni non ristornate"
        Me.optNo.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Checked = True
        Me.optAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.optAll, "Spuntare questa casella se si vuole il report delle quote incassate,già ristornat" & _
        "e o non ancora ristornate per un collaboratore comunale ")
        Me.optAll.Location = New System.Drawing.Point(299, 31)
        Me.optAll.Name = "optAll"
        Me.HelpProvider1.SetShowHelp(Me.optAll, True)
        Me.optAll.Size = New System.Drawing.Size(50, 17)
        Me.optAll.TabIndex = 2
        Me.optAll.TabStop = True
        Me.optAll.Text = "Tutto"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.IdAziendaTextBox2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.ControlSelPeriodiMensili1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cboEnti)
        Me.Panel3.Controls.Add(Me.cmdUt)
        Me.Panel3.Controls.Add(Me.IdAziendaTextBox1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblDescrizioneAzienda)
        Me.Panel3.Controls.Add(Me.dtpDocDa)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cboContratti)
        Me.Panel3.Controls.Add(Me.dtpDocA)
        Me.Panel3.Controls.Add(Me.cboSettori)
        Me.Panel3.Controls.Add(Me.dtpRegA)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lblSettore)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.chkReg)
        Me.Panel3.Controls.Add(Me.dtpRegDa)
        Me.Panel3.Controls.Add(Me.chkDoc)
        Me.Panel3.Controls.Add(Me.chkSogg)
        Me.Panel3.Controls.Add(Me.lblSogg)
        Me.Panel3.Controls.Add(Me.chkComp)
        Me.Panel3.Location = New System.Drawing.Point(17, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(627, 285)
        Me.Panel3.TabIndex = 95
        '
        'IdAziendaTextBox2
        '
        Me.IdAziendaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdAziendaTextBox2.DescriptionOfText = ""
        Me.IdAziendaTextBox2.DescriptionTextWidth = 290
        Me.IdAziendaTextBox2.DescriptionTextXValue = 92
        Me.IdAziendaTextBox2.EnableSerchTextBox = True
        Me.IdAziendaTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAziendaTextBox2.IsDescriptionVisible = True
        Me.IdAziendaTextBox2.Location = New System.Drawing.Point(84, 216)
        Me.IdAziendaTextBox2.Mandatory = False
        Me.IdAziendaTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox2.Name = "IdAziendaTextBox2"
        Me.IdAziendaTextBox2.Size = New System.Drawing.Size(460, 20)
        Me.IdAziendaTextBox2.TabIndex = 97
        Me.IdAziendaTextBox2.TextValue = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Id az. impiego"
        '
        'ControlSelPeriodiMensili1
        '
        Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
        Me.ControlSelPeriodiMensili1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(46, 114)
        Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
        Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(387, 33)
        Me.ControlSelPeriodiMensili1.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Selezione avanzata"
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Identificativo del soggetto esecutore del pagamento delle quote.Esso può essere u" & _
        "n ente bilaterale(nel caso di settore Edile) o un'azienda(nel caso di settore IM" & _
        "PIANTI FISSI)")
        Me.cboEnti.Location = New System.Drawing.Point(84, 185)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(169, 21)
        Me.cboEnti.TabIndex = 85
        '
        'cmdUt
        '
        Me.cmdUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.cmdUt, "Funzione che permette di selezionare gli utenti di cui si vogliono visualizzare l" & _
        "e quote incassate. ")
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(84, 22)
        Me.cmdUt.Name = "cmdUt"
        Me.HelpProvider1.SetShowHelp(Me.cmdUt, True)
        Me.cmdUt.Size = New System.Drawing.Size(79, 25)
        Me.cmdUt.TabIndex = 69
        Me.cmdUt.Text = "Seleziona"
        Me.cmdUt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUt.UseVisualStyleBackColor = True
        '
        'IdAziendaTextBox1
        '
        Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAziendaTextBox1.DescriptionOfText = ""
        Me.IdAziendaTextBox1.DescriptionTextWidth = 150
        Me.IdAziendaTextBox1.DescriptionTextXValue = 92
        Me.IdAziendaTextBox1.EnableSerchTextBox = True
        Me.IdAziendaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAziendaTextBox1.ForeColor = System.Drawing.Color.Black
        Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo del soggetto esecutore del pagamento delle quote.Esso può essere u" & _
        "n ente bilaterale(nel caso di settore Edile) o un'azienda(nel caso di settore IM" & _
        "PIANTI FISSI)")
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(83, 185)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(92, 26)
        Me.IdAziendaTextBox1.TabIndex = 86
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(269, 192)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(14, 13)
        Me.lblDescrizioneAzienda.TabIndex = 83
        Me.lblDescrizioneAzienda.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Id sogg. esec."
        '
        'cboContratti
        '
        Me.cboContratti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContratti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContratti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboContratti, resources.GetString("cboContratti.HelpString"))
        Me.cboContratti.Location = New System.Drawing.Point(83, 247)
        Me.cboContratti.Name = "cboContratti"
        Me.HelpProvider1.SetShowHelp(Me.cboContratti, True)
        Me.cboContratti.Size = New System.Drawing.Size(169, 21)
        Me.cboContratti.TabIndex = 78
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza delle quote incassate.Essi possono essere EDILE e IMPIANTI " & _
        "FISSI. Se selezionato,il report conterrà soltanto le quote incassate di pertinen" & _
        "za di quel settore.")
        Me.cboSettori.Location = New System.Drawing.Point(84, 156)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(169, 21)
        Me.cboSettori.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Contr. app."
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(40, 160)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 80
        Me.lblSettore.Text = "Settore"
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
        Me.HelpProvider1.SetHelpString(Me.CmdRpt, "Funzione che permette di avviare la ricerca degli incassi delle quote che rispond" & _
        "ono ai criteri di selezione impostati")
        Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.Location = New System.Drawing.Point(56, 6)
        Me.CmdRpt.Name = "CmdRpt"
        Me.CmdRpt.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdRpt, True)
        Me.CmdRpt.ShowTooltip = True
        Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
        Me.CmdRpt.TabIndex = 80
        Me.CmdRpt.TextValue = ""
        Me.CmdRpt.TooltipText = "Elabora report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Cerca"
        '
        'ControlPrepareRptIQ
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlPrepareRptIQ"
        Me.Size = New System.Drawing.Size(726, 543)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkIQA As System.Windows.Forms.CheckBox
    Friend WithEvents chkIQI As System.Windows.Forms.CheckBox
    Friend WithEvents chkIQV As System.Windows.Forms.CheckBox
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdUt As System.Windows.Forms.Button
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSogg As System.Windows.Forms.CheckBox
    Friend WithEvents chkComp As System.Windows.Forms.CheckBox
    Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optNo As System.Windows.Forms.RadioButton
    Friend WithEvents optYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboContratti As System.Windows.Forms.ComboBox
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkIQP As System.Windows.Forms.CheckBox

End Class
