<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRptVertenze
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPrepareRptVertenze))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker()
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkReg = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkDoc = New System.Windows.Forms.CheckBox()
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dtpEvA = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEnte = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEvDa = New System.Windows.Forms.DateTimePicker()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.chkDataEv = New System.Windows.Forms.CheckBox()
        Me.lblIntervento = New System.Windows.Forms.Label()
        Me.txtIntervento = New System.Windows.Forms.TextBox()
        Me.lblInoltro = New System.Windows.Forms.Label()
        Me.dtpValA = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IdAvvocatoTextbox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAvvocatoTextbox()
        Me.lblDescrizioneAvvocato = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCons = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkVal = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdUt = New System.Windows.Forms.Button()
        Me.chkUtenti = New System.Windows.Forms.CheckBox()
        Me.cmdAz = New System.Windows.Forms.Button()
        Me.chkSogg = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpValDa = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(608, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.Label20)
        Me.DockPanel.Controls.Add(Me.CmdRpt)
        Me.DockPanel.Size = New System.Drawing.Size(608, 44)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(314, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "a"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(180, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "da"
        '
        'dtpDocA
        '
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(330, 50)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocA.TabIndex = 5
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(204, 50)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocDa.TabIndex = 4
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(204, 25)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegDa.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(314, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "a"
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
        Me.chkReg.Location = New System.Drawing.Point(22, 28)
        Me.chkReg.Name = "chkReg"
        Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
        Me.chkReg.Size = New System.Drawing.Size(141, 17)
        Me.chkReg.TabIndex = 0
        Me.chkReg.Text = "Selezione data reg. vert."
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(180, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "da"
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkDoc, "Spuntare questa casella se si vuole il report delle vertenze la cui data document" & _
        "o(data in cui è stata creata la vertenza) sia compresa nell'intervallo temporale" & _
        " delle date ""da-a""")
        Me.chkDoc.Location = New System.Drawing.Point(22, 53)
        Me.chkDoc.Name = "chkDoc"
        Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
        Me.chkDoc.Size = New System.Drawing.Size(144, 17)
        Me.chkDoc.TabIndex = 3
        Me.chkDoc.Text = "Selezione data doc. vert."
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'dtpRegA
        '
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(330, 25)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegA.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.dtpValA)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.chkVal)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpValDa)
        Me.GroupBox3.Controls.Add(Me.dtpDocA)
        Me.GroupBox3.Controls.Add(Me.dtpRegA)
        Me.GroupBox3.Controls.Add(Me.chkDoc)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.chkReg)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dtpDocDa)
        Me.GroupBox3.Controls.Add(Me.dtpRegDa)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(11, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(557, 510)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.Text = "Selezione criteri ricerca iscritti"
        Me.GroupBox3.Title = "Dati di selezione"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.dtpEvA)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtEnte)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.dtpEvDa)
        Me.Panel4.Controls.Add(Me.cboTipo)
        Me.Panel4.Controls.Add(Me.chkDataEv)
        Me.Panel4.Controls.Add(Me.lblIntervento)
        Me.Panel4.Controls.Add(Me.txtIntervento)
        Me.Panel4.Controls.Add(Me.lblInoltro)
        Me.Panel4.Location = New System.Drawing.Point(14, 324)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(502, 170)
        Me.Panel4.TabIndex = 97
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Stato"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Indifferente", "Chiuse", "Aperte"})
        Me.ComboBox1.Location = New System.Drawing.Point(80, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox1.TabIndex = 95
        '
        'dtpEvA
        '
        Me.dtpEvA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEvA.Location = New System.Drawing.Point(322, 25)
        Me.dtpEvA.Name = "dtpEvA"
        Me.dtpEvA.Size = New System.Drawing.Size(99, 20)
        Me.dtpEvA.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Selezione eventi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(306, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "a"
        '
        'txtEnte
        '
        Me.txtEnte.Location = New System.Drawing.Point(80, 107)
        Me.txtEnte.Name = "txtEnte"
        Me.txtEnte.Size = New System.Drawing.Size(196, 20)
        Me.txtEnte.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(174, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "da"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(15, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TipoEvento"
        '
        'dtpEvDa
        '
        Me.dtpEvDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEvDa.Location = New System.Drawing.Point(196, 25)
        Me.dtpEvDa.Name = "dtpEvDa"
        Me.dtpEvDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpEvDa.TabIndex = 1
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipo di evento che avviene nel ciclo di vita di una vertenza.Se selezionato,il re" & _
        "port conterrà soltanto le vertenze di quel tipo.")
        Me.cboTipo.Location = New System.Drawing.Point(80, 55)
        Me.cboTipo.Name = "cboTipo"
        Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
        Me.cboTipo.Size = New System.Drawing.Size(196, 21)
        Me.cboTipo.TabIndex = 3
        '
        'chkDataEv
        '
        Me.chkDataEv.AutoSize = True
        Me.chkDataEv.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkDataEv, "Spuntare questa casella se si vuole il report delle vertenze per le quali esista " & _
        "un evento, del tipo eventualmente specificato,in data compresa nell'intervallo t" & _
        "emporale ""da-a""")
        Me.chkDataEv.Location = New System.Drawing.Point(28, 30)
        Me.chkDataEv.Name = "chkDataEv"
        Me.HelpProvider1.SetShowHelp(Me.chkDataEv, True)
        Me.chkDataEv.Size = New System.Drawing.Size(132, 17)
        Me.chkDataEv.TabIndex = 0
        Me.chkDataEv.Text = "Selezione data evento"
        Me.chkDataEv.UseVisualStyleBackColor = False
        '
        'lblIntervento
        '
        Me.lblIntervento.AutoSize = True
        Me.lblIntervento.BackColor = System.Drawing.Color.Transparent
        Me.lblIntervento.Location = New System.Drawing.Point(22, 85)
        Me.lblIntervento.Name = "lblIntervento"
        Me.lblIntervento.Size = New System.Drawing.Size(55, 13)
        Me.lblIntervento.TabIndex = 18
        Me.lblIntervento.Text = "Intervento"
        '
        'txtIntervento
        '
        Me.HelpProvider1.SetHelpString(Me.txtIntervento, "Tipo di intervento effettuato nel corso della vertenza.Se selezionato,il report c" & _
        "onterrà soltanto le vertenze che contengono quel tipo di intervento nel loro cic" & _
        "lo di vita.")
        Me.txtIntervento.Location = New System.Drawing.Point(80, 81)
        Me.txtIntervento.Name = "txtIntervento"
        Me.HelpProvider1.SetShowHelp(Me.txtIntervento, True)
        Me.txtIntervento.Size = New System.Drawing.Size(196, 20)
        Me.txtIntervento.TabIndex = 4
        '
        'lblInoltro
        '
        Me.lblInoltro.AutoSize = True
        Me.lblInoltro.BackColor = System.Drawing.Color.Transparent
        Me.lblInoltro.Location = New System.Drawing.Point(17, 110)
        Me.lblInoltro.Name = "lblInoltro"
        Me.lblInoltro.Size = New System.Drawing.Size(60, 13)
        Me.lblInoltro.TabIndex = 22
        Me.lblInoltro.Text = "Ente inoltro"
        '
        'dtpValA
        '
        Me.dtpValA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValA.Location = New System.Drawing.Point(330, 76)
        Me.dtpValA.Name = "dtpValA"
        Me.dtpValA.Size = New System.Drawing.Size(99, 20)
        Me.dtpValA.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.IdAvvocatoTextbox1)
        Me.Panel1.Controls.Add(Me.lblDescrizioneAvvocato)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblCons)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblDescrizioneReferente)
        Me.Panel1.Controls.Add(Me.IdReferenteTextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.IdReferenteTextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(14, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 120)
        Me.Panel1.TabIndex = 96
        '
        'IdAvvocatoTextbox1
        '
        Me.IdAvvocatoTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAvvocatoTextbox1.DescriptionOfText = ""
        Me.IdAvvocatoTextbox1.DescriptionTextWidth = 150
        Me.IdAvvocatoTextbox1.DescriptionTextXValue = 92
        Me.IdAvvocatoTextbox1.EnableSerchTextBox = True
        Me.IdAvvocatoTextbox1.IsDescriptionVisible = False
        Me.IdAvvocatoTextbox1.Location = New System.Drawing.Point(121, 25)
        Me.IdAvvocatoTextbox1.Mandatory = False
        Me.IdAvvocatoTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAvvocatoTextbox1.Name = "IdAvvocatoTextbox1"
        Me.IdAvvocatoTextbox1.Size = New System.Drawing.Size(89, 22)
        Me.IdAvvocatoTextbox1.TabIndex = 98
        Me.IdAvvocatoTextbox1.TextValue = ""
        '
        'lblDescrizioneAvvocato
        '
        Me.lblDescrizioneAvvocato.AutoSize = True
        Me.lblDescrizioneAvvocato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAvvocato.Location = New System.Drawing.Point(230, 31)
        Me.lblDescrizioneAvvocato.Name = "lblDescrizioneAvvocato"
        Me.lblDescrizioneAvvocato.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAvvocato.TabIndex = 97
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Avvocato"
        '
        'lblCons
        '
        Me.lblCons.AutoSize = True
        Me.lblCons.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCons.Location = New System.Drawing.Point(230, 90)
        Me.lblCons.Name = "lblCons"
        Me.lblCons.Size = New System.Drawing.Size(0, 13)
        Me.lblCons.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 13)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Selezione collaboratori"
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(230, 65)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 4
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpKeyword(Me.IdReferenteTextBox2, "Identificativo del responsabile unico del procedimento.Se inserito,il report visu" & _
        "alizzerà soltanto le prestazioni Inps che sono state seguite dal R.u.p. ")
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(121, 86)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(94, 24)
        Me.IdReferenteTextBox2.TabIndex = 3
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Collab. com"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale.Se inserito,il report visualizzerà solt" & _
        "anto le vertenze che sono state seguite dal collaboratore comunale.")
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(121, 57)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(94, 21)
        Me.IdReferenteTextBox1.TabIndex = 2
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Responsabile proc."
        '
        'chkVal
        '
        Me.chkVal.AutoSize = True
        Me.chkVal.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkVal, "Spuntare questa casella se si vuole il report delle vertenze il cui periodo di va" & _
        "lidità sia compreso nell'intervallo temporale ""da-a""")
        Me.chkVal.Location = New System.Drawing.Point(22, 79)
        Me.chkVal.Name = "chkVal"
        Me.HelpProvider1.SetShowHelp(Me.chkVal, True)
        Me.chkVal.Size = New System.Drawing.Size(132, 17)
        Me.chkVal.TabIndex = 6
        Me.chkVal.Text = "Selezione validità vert."
        Me.chkVal.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cmdUt)
        Me.Panel3.Controls.Add(Me.chkUtenti)
        Me.Panel3.Controls.Add(Me.cmdAz)
        Me.Panel3.Controls.Add(Me.chkSogg)
        Me.Panel3.Location = New System.Drawing.Point(14, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(502, 72)
        Me.Panel3.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Selezione aziende - utenti"
        '
        'cmdUt
        '
        Me.cmdUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.cmdUt, "Funzione che permette di selezionare gli utenti")
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(388, 25)
        Me.cmdUt.Name = "cmdUt"
        Me.HelpProvider1.SetShowHelp(Me.cmdUt, True)
        Me.cmdUt.Size = New System.Drawing.Size(79, 25)
        Me.cmdUt.TabIndex = 3
        Me.cmdUt.Text = "Seleziona"
        Me.cmdUt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUt.UseVisualStyleBackColor = True
        '
        'chkUtenti
        '
        Me.chkUtenti.AutoSize = True
        Me.chkUtenti.BackColor = System.Drawing.Color.Transparent
        Me.chkUtenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkUtenti, "Spuntare questa casella se si vuole il report delle vertenze che coinvolgono dete" & _
        "rminati utenti.")
        Me.chkUtenti.Location = New System.Drawing.Point(268, 31)
        Me.chkUtenti.Name = "chkUtenti"
        Me.HelpProvider1.SetShowHelp(Me.chkUtenti, True)
        Me.chkUtenti.Size = New System.Drawing.Size(101, 17)
        Me.chkUtenti.TabIndex = 2
        Me.chkUtenti.Text = "Selezione utenti"
        Me.chkUtenti.UseVisualStyleBackColor = False
        '
        'cmdAz
        '
        Me.cmdAz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.cmdAz, "Funzione che permette di selezionare le aziende.")
        Me.cmdAz.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdAz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAz.Location = New System.Drawing.Point(136, 25)
        Me.cmdAz.Name = "cmdAz"
        Me.HelpProvider1.SetShowHelp(Me.cmdAz, True)
        Me.cmdAz.Size = New System.Drawing.Size(79, 25)
        Me.cmdAz.TabIndex = 1
        Me.cmdAz.Text = "Seleziona"
        Me.cmdAz.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAz.UseVisualStyleBackColor = True
        '
        'chkSogg
        '
        Me.chkSogg.AutoSize = True
        Me.chkSogg.BackColor = System.Drawing.Color.Transparent
        Me.chkSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkSogg, "Spuntare questa casella se si vuole il report delle vertenze che coinvolgono dete" & _
        "rminate aziende.")
        Me.chkSogg.Location = New System.Drawing.Point(16, 33)
        Me.chkSogg.Name = "chkSogg"
        Me.HelpProvider1.SetShowHelp(Me.chkSogg, True)
        Me.chkSogg.Size = New System.Drawing.Size(112, 17)
        Me.chkSogg.TabIndex = 0
        Me.chkSogg.Text = "Selezione aziende"
        Me.chkSogg.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(314, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(180, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "da"
        '
        'dtpValDa
        '
        Me.dtpValDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValDa.Location = New System.Drawing.Point(204, 76)
        Me.dtpValDa.Name = "dtpValDa"
        Me.dtpValDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpValDa.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 19)
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
        Me.CmdRpt.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x321
        Me.CmdRpt.Disabled = False
        Me.CmdRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRpt.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdRpt, "Funzione che permette di avviare la ricerca delle vertenze che rispondono ai crit" & _
        "eri di selezione impostati")
        Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.Location = New System.Drawing.Point(55, 7)
        Me.CmdRpt.Name = "CmdRpt"
        Me.CmdRpt.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdRpt, True)
        Me.CmdRpt.ShowTooltip = True
        Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
        Me.CmdRpt.TabIndex = 84
        Me.CmdRpt.TextValue = ""
        Me.CmdRpt.TooltipText = "Elabora report"
        '
        'ControlPrepareRptVertenze
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ControlPrepareRptVertenze"
        Me.Size = New System.Drawing.Size(608, 603)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents chkSogg As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAz As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents chkUtenti As System.Windows.Forms.CheckBox
    Friend WithEvents cmdUt As System.Windows.Forms.Button
    Friend WithEvents dtpValA As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkVal As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpValDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCons As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkDataEv As System.Windows.Forms.CheckBox
    Friend WithEvents txtEnte As System.Windows.Forms.TextBox
    Friend WithEvents lblInoltro As System.Windows.Forms.Label
    Friend WithEvents txtIntervento As System.Windows.Forms.TextBox
    Friend WithEvents lblIntervento As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpEvA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpEvDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents IdAvvocatoTextbox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAvvocatoTextbox
    Friend WithEvents lblDescrizioneAvvocato As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
