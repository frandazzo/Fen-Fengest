<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPagamentoQuotePrevisionali
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.lblTotale = New System.Windows.Forms.Label
        Me.txtAttribuito = New System.Windows.Forms.TextBox
        Me.lblTot = New System.Windows.Forms.Label
        Me.cmdRed = New System.Windows.Forms.Button
        Me.lblAtt = New System.Windows.Forms.Label
        Me.lblAttribuito = New System.Windows.Forms.Label
        Me.txtTotale = New System.Windows.Forms.TextBox
        Me.cmdBlu = New System.Windows.Forms.Button
        Me.cmdGreen = New System.Windows.Forms.Button
        Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.CmdCrea = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.cmdAdd = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
        Me.GrpSogg = New WIN.GUI.UTILITY.NiceGroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label
        Me.lblCompUltimo = New System.Windows.Forms.Label
        Me.GridPosizioni = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CboEnti = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboSettori = New System.Windows.Forms.ComboBox
        Me.lblComp = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtImporto = New System.Windows.Forms.TextBox
        Me.lblValuta = New System.Windows.Forms.Label
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpRegistrazione = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ControlloSelezioneCompetenza1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlloSelezioneCompetenza
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DockPanel.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpSogg.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(635, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.CmdCrea)
        Me.DockPanel.Size = New System.Drawing.Size(635, 44)
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.lblTotale)
        Me.NiceGroupBox1.Controls.Add(Me.txtAttribuito)
        Me.NiceGroupBox1.Controls.Add(Me.lblTot)
        Me.NiceGroupBox1.Controls.Add(Me.cmdRed)
        Me.NiceGroupBox1.Controls.Add(Me.lblAtt)
        Me.NiceGroupBox1.Controls.Add(Me.lblAttribuito)
        Me.NiceGroupBox1.Controls.Add(Me.txtTotale)
        Me.NiceGroupBox1.Controls.Add(Me.cmdBlu)
        Me.NiceGroupBox1.Controls.Add(Me.cmdGreen)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(338, 109)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(236, 100)
        Me.NiceGroupBox1.TabIndex = 57
        Me.NiceGroupBox1.Title = "Totalizzazioni"
        '
        'lblTotale
        '
        Me.lblTotale.AutoSize = True
        Me.lblTotale.BackColor = System.Drawing.Color.Transparent
        Me.lblTotale.Location = New System.Drawing.Point(7, 37)
        Me.lblTotale.Name = "lblTotale"
        Me.lblTotale.Size = New System.Drawing.Size(67, 13)
        Me.lblTotale.TabIndex = 32
        Me.lblTotale.Text = "Da attribuire"
        '
        'txtAttribuito
        '
        Me.txtAttribuito.AcceptsTab = True
        Me.txtAttribuito.Enabled = False
        Me.txtAttribuito.Location = New System.Drawing.Point(78, 66)
        Me.txtAttribuito.Name = "txtAttribuito"
        Me.txtAttribuito.Size = New System.Drawing.Size(78, 21)
        Me.txtAttribuito.TabIndex = 41
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.Color.Transparent
        Me.lblTot.Location = New System.Drawing.Point(162, 37)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(29, 13)
        Me.lblTot.TabIndex = 39
        Me.lblTot.Text = "Euro"
        '
        'cmdRed
        '
        Me.cmdRed.BackColor = System.Drawing.Color.Transparent
        Me.cmdRed.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Flag_grayHS1
        Me.cmdRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRed.FlatAppearance.BorderSize = 0
        Me.cmdRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRed.Location = New System.Drawing.Point(208, 29)
        Me.cmdRed.Name = "cmdRed"
        Me.cmdRed.Size = New System.Drawing.Size(16, 16)
        Me.cmdRed.TabIndex = 48
        Me.cmdRed.UseVisualStyleBackColor = False
        '
        'lblAtt
        '
        Me.lblAtt.AutoSize = True
        Me.lblAtt.BackColor = System.Drawing.Color.Transparent
        Me.lblAtt.Location = New System.Drawing.Point(162, 70)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(29, 13)
        Me.lblAtt.TabIndex = 42
        Me.lblAtt.Text = "Euro"
        '
        'lblAttribuito
        '
        Me.lblAttribuito.AutoSize = True
        Me.lblAttribuito.BackColor = System.Drawing.Color.Transparent
        Me.lblAttribuito.Location = New System.Drawing.Point(23, 70)
        Me.lblAttribuito.Name = "lblAttribuito"
        Me.lblAttribuito.Size = New System.Drawing.Size(52, 13)
        Me.lblAttribuito.TabIndex = 40
        Me.lblAttribuito.Text = "Attribuito"
        '
        'txtTotale
        '
        Me.txtTotale.Location = New System.Drawing.Point(78, 33)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.Size = New System.Drawing.Size(78, 21)
        Me.txtTotale.TabIndex = 33
        '
        'cmdBlu
        '
        Me.cmdBlu.BackColor = System.Drawing.Color.Transparent
        Me.cmdBlu.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Flag_blueHS
        Me.cmdBlu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBlu.FlatAppearance.BorderSize = 0
        Me.cmdBlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBlu.Location = New System.Drawing.Point(208, 51)
        Me.cmdBlu.Name = "cmdBlu"
        Me.cmdBlu.Size = New System.Drawing.Size(16, 16)
        Me.cmdBlu.TabIndex = 47
        Me.cmdBlu.UseVisualStyleBackColor = False
        '
        'cmdGreen
        '
        Me.cmdGreen.BackColor = System.Drawing.Color.Transparent
        Me.cmdGreen.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Flag_grayHS
        Me.cmdGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGreen.FlatAppearance.BorderSize = 0
        Me.cmdGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGreen.Location = New System.Drawing.Point(208, 73)
        Me.cmdGreen.Name = "cmdGreen"
        Me.cmdGreen.Size = New System.Drawing.Size(16, 16)
        Me.cmdGreen.TabIndex = 46
        Me.cmdGreen.UseVisualStyleBackColor = False
        '
        'cmdUp
        '
        Me.cmdUp.ApplyOutLookStile = True
        Me.cmdUp.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.cmdUp.BackColor = System.Drawing.Color.Transparent
        Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdUp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
        Me.cmdUp.Disabled = False
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.ForeColor = System.Drawing.Color.Transparent
        Me.cmdUp.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdUp.Location = New System.Drawing.Point(14, 1)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Radius = 48.0!
        Me.cmdUp.ShowTooltip = True
        Me.cmdUp.Size = New System.Drawing.Size(48, 48)
        Me.cmdUp.TabIndex = 2
        Me.cmdUp.TextValue = ""
        Me.cmdUp.TooltipText = "Ordina dall'alto"
        '
        'CmdCrea
        '
        Me.CmdCrea.ApplyOutLookStile = True
        Me.CmdCrea.BackColor = System.Drawing.Color.Transparent
        Me.CmdCrea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdCrea.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_calc_32x32
        Me.CmdCrea.Disabled = False
        Me.CmdCrea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCrea.ForeColor = System.Drawing.Color.Transparent
        Me.CmdCrea.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdCrea.Location = New System.Drawing.Point(319, 7)
        Me.CmdCrea.Name = "CmdCrea"
        Me.CmdCrea.Radius = 32.0!
        Me.CmdCrea.ShowTooltip = True
        Me.CmdCrea.Size = New System.Drawing.Size(32, 32)
        Me.CmdCrea.TabIndex = 52
        Me.CmdCrea.TextValue = ""
        Me.CmdCrea.TooltipText = "Crea incasso"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
        Me.Panel1.Controls.Add(Me.cmdUp)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.CmdDown)
        Me.Panel1.Location = New System.Drawing.Point(495, 366)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(79, 180)
        Me.Panel1.TabIndex = 56
        '
        'cmdDel
        '
        Me.cmdDel.ApplyOutLookStile = True
        Me.cmdDel.BackColor = System.Drawing.Color.Transparent
        Me.cmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.removesede_48x48
        Me.cmdDel.Disabled = False
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDel.ForeColor = System.Drawing.Color.Transparent
        Me.cmdDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDel.Location = New System.Drawing.Point(15, 131)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Radius = 48.0!
        Me.cmdDel.ShowTooltip = True
        Me.cmdDel.Size = New System.Drawing.Size(48, 48)
        Me.cmdDel.TabIndex = 5
        Me.cmdDel.TextValue = ""
        Me.cmdDel.TooltipText = "Rimuovi posizione"
        '
        'cmdAdd
        '
        Me.cmdAdd.ApplyOutLookStile = True
        Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAdd.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.addsede_48x48
        Me.cmdAdd.Disabled = False
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAdd.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAdd.Location = New System.Drawing.Point(16, 90)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Radius = 48.0!
        Me.cmdAdd.ShowTooltip = True
        Me.cmdAdd.Size = New System.Drawing.Size(48, 48)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.TextValue = ""
        Me.cmdAdd.TooltipText = "Aggiungi posizione"
        '
        'CmdDown
        '
        Me.CmdDown.ApplyOutLookStile = True
        Me.CmdDown.BackColor = System.Drawing.Color.Transparent
        Me.CmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDown.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
        Me.CmdDown.Disabled = False
        Me.CmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDown.ForeColor = System.Drawing.Color.Transparent
        Me.CmdDown.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDown.Location = New System.Drawing.Point(15, 43)
        Me.CmdDown.Name = "CmdDown"
        Me.CmdDown.Radius = 48.0!
        Me.CmdDown.ShowTooltip = True
        Me.CmdDown.Size = New System.Drawing.Size(48, 48)
        Me.CmdDown.TabIndex = 3
        Me.CmdDown.TextValue = ""
        Me.CmdDown.TooltipText = "Ordina dal basso"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(19, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 53
        '
        'GrpSogg
        '
        Me.GrpSogg.BackColor = System.Drawing.Color.Silver
        Me.GrpSogg.Controls.Add(Me.Label13)
        Me.GrpSogg.Controls.Add(Me.Label9)
        Me.GrpSogg.Controls.Add(Me.lblDescrizioneAzienda)
        Me.GrpSogg.Controls.Add(Me.lblCompUltimo)
        Me.GrpSogg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpSogg.Location = New System.Drawing.Point(338, 226)
        Me.GrpSogg.Name = "GrpSogg"
        Me.GrpSogg.Size = New System.Drawing.Size(236, 128)
        Me.GrpSogg.TabIndex = 54
        Me.GrpSogg.Text = "Dati anagrafici del pagante"
        Me.GrpSogg.Title = "Dati soggetto pagante"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(14, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Ragione sociale:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(14, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "La competenza dell'ultimo pagamento è:"
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(16, 43)
        Me.lblDescrizioneAzienda.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(119, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
        Me.lblDescrizioneAzienda.Text = "Descrizione azienda"
        '
        'lblCompUltimo
        '
        Me.lblCompUltimo.AutoSize = True
        Me.lblCompUltimo.BackColor = System.Drawing.Color.Transparent
        Me.lblCompUltimo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompUltimo.Location = New System.Drawing.Point(16, 98)
        Me.lblCompUltimo.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblCompUltimo.Name = "lblCompUltimo"
        Me.lblCompUltimo.Size = New System.Drawing.Size(82, 13)
        Me.lblCompUltimo.TabIndex = 1
        Me.lblCompUltimo.Text = "Comp. Ultimo"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.AllowUserToAddRows = False
        Me.GridPosizioni.AllowUserToDeleteRows = False
        Me.GridPosizioni.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPosizioni.BackgroundColor = System.Drawing.Color.White
        Me.GridPosizioni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridPosizioni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridPosizioni.GridColor = System.Drawing.Color.LightGray
        Me.GridPosizioni.Location = New System.Drawing.Point(19, 366)
        Me.GridPosizioni.Name = "GridPosizioni"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridPosizioni.RowHeadersWidth = 30
        Me.GridPosizioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridPosizioni.Size = New System.Drawing.Size(470, 275)
        Me.GridPosizioni.TabIndex = 55
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(19, 87)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(309, 266)
        Me.TabControl1.TabIndex = 51
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CboEnti)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cboSettori)
        Me.TabPage1.Controls.Add(Me.lblComp)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dtpDoc)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtImporto)
        Me.TabPage1.Controls.Add(Me.lblValuta)
        Me.TabPage1.Controls.Add(Me.IdAziendaTextBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dtpRegistrazione)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(301, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dati generali"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CboEnti
        '
        Me.CboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEnti.FormattingEnabled = True
        Me.CboEnti.Location = New System.Drawing.Point(76, 147)
        Me.CboEnti.Name = "CboEnti"
        Me.CboEnti.Size = New System.Drawing.Size(146, 21)
        Me.CboEnti.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Settore"
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.FormattingEnabled = True
        Me.cboSettori.Location = New System.Drawing.Point(77, 112)
        Me.cboSettori.Name = "cboSettori"
        Me.cboSettori.Size = New System.Drawing.Size(145, 21)
        Me.cboSettori.TabIndex = 4
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.Location = New System.Drawing.Point(81, 207)
        Me.lblComp.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(42, 13)
        Me.lblComp.TabIndex = 41
        Me.lblComp.Text = "*****"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(77, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 21)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Incasso Quota Previsionale"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tipo doc."
        '
        'dtpDoc
        '
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDoc.Location = New System.Drawing.Point(77, 46)
        Me.dtpDoc.Name = "dtpDoc"
        Me.dtpDoc.Size = New System.Drawing.Size(103, 21)
        Me.dtpDoc.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Data doc."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Importo"
        '
        'txtImporto
        '
        Me.txtImporto.Location = New System.Drawing.Point(75, 181)
        Me.txtImporto.Name = "txtImporto"
        Me.txtImporto.Size = New System.Drawing.Size(72, 21)
        Me.txtImporto.TabIndex = 7
        '
        'lblValuta
        '
        Me.lblValuta.AutoSize = True
        Me.lblValuta.Location = New System.Drawing.Point(157, 184)
        Me.lblValuta.Name = "lblValuta"
        Me.lblValuta.Size = New System.Drawing.Size(29, 13)
        Me.lblValuta.TabIndex = 16
        Me.lblValuta.Text = "Euro"
        '
        'IdAziendaTextBox1
        '
        Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAziendaTextBox1.DescriptionOfText = ""
        Me.IdAziendaTextBox1.DescriptionTextWidth = 150
        Me.IdAziendaTextBox1.DescriptionTextXValue = 92
        Me.IdAziendaTextBox1.EnableSerchTextBox = True
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(75, 147)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(105, 24)
        Me.IdAziendaTextBox1.TabIndex = 6
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Id Pagante"
        '
        'dtpRegistrazione
        '
        Me.dtpRegistrazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegistrazione.Location = New System.Drawing.Point(77, 16)
        Me.dtpRegistrazione.Name = "dtpRegistrazione"
        Me.dtpRegistrazione.Size = New System.Drawing.Size(103, 21)
        Me.dtpRegistrazione.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Data reg."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ControlloSelezioneCompetenza1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(301, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Competenza incasso"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ControlloSelezioneCompetenza1
        '
        Me.ControlloSelezioneCompetenza1.Location = New System.Drawing.Point(1, 29)
        Me.ControlloSelezioneCompetenza1.Name = "ControlloSelezioneCompetenza1"
        Me.ControlloSelezioneCompetenza1.Size = New System.Drawing.Size(304, 188)
        Me.ControlloSelezioneCompetenza1.TabIndex = 27
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtNote)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(301, 240)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Note"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(15, 33)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(252, 196)
        Me.txtNote.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Note"
        '
        'ControlPagamentoQuotePrevisionali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrpSogg)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Name = "ControlPagamentoQuotePrevisionali"
        Me.Size = New System.Drawing.Size(601, 660)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.Controls.SetChildIndex(Me.GrpSogg, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpSogg.ResumeLayout(False)
        Me.GrpSogg.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblTotale As System.Windows.Forms.Label
    Friend WithEvents txtAttribuito As System.Windows.Forms.TextBox
    Friend WithEvents lblTot As System.Windows.Forms.Label
    Friend WithEvents cmdRed As System.Windows.Forms.Button
    Friend WithEvents lblAtt As System.Windows.Forms.Label
    Friend WithEvents lblAttribuito As System.Windows.Forms.Label
    Friend WithEvents txtTotale As System.Windows.Forms.TextBox
    Friend WithEvents cmdBlu As System.Windows.Forms.Button
    Friend WithEvents cmdGreen As System.Windows.Forms.Button
    Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdCrea As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdAdd As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents GrpSogg As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents lblCompUltimo As System.Windows.Forms.Label
    Public WithEvents GridPosizioni As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtImporto As System.Windows.Forms.TextBox
    Friend WithEvents lblValuta As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpRegistrazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ControlloSelezioneCompetenza1 As WIN.GUI.APPLICATION.PRESENTATION.ControlloSelezioneCompetenza
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
