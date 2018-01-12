<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPagamentoQuoteInps
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPagamentoQuoteInps))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.lblAtt = New System.Windows.Forms.Label
      Me.txtAttribuito = New System.Windows.Forms.TextBox
      Me.lblAttribuito = New System.Windows.Forms.Label
      Me.GrpSogg = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.lblDescrizioneAzienda = New System.Windows.Forms.Label
      Me.lblCompUltimo = New System.Windows.Forms.Label
      Me.lblTot = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.cmdCompetenza = New System.Windows.Forms.Button
      Me.txtCompetenza = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.TextBox1 = New System.Windows.Forms.TextBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.dtpDoc = New System.Windows.Forms.DateTimePicker
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtImporto = New System.Windows.Forms.TextBox
      Me.lblValuta = New System.Windows.Forms.Label
      Me.txtNote = New System.Windows.Forms.TextBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.dtpRegistrazione = New System.Windows.Forms.DateTimePicker
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtTotale = New System.Windows.Forms.TextBox
      Me.lblTotale = New System.Windows.Forms.Label
      Me.GridPosizioni = New System.Windows.Forms.DataGridView
      Me.cmdDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdAdd = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdCrea = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdRed = New System.Windows.Forms.Button
      Me.cmdBlu = New System.Windows.Forms.Button
      Me.cmdGreen = New System.Windows.Forms.Button
      Me.cmdPrest = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.GrpSogg.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      Me.NiceGroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(736, 22)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.CmdCrea)
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Controls.Add(Me.cmdPrest)
      Me.DockPanel.Location = New System.Drawing.Point(0, 22)
      Me.DockPanel.Size = New System.Drawing.Size(736, 44)
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(3, 1)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(296, 40)
      Me.CustomBar1.TabIndex = 57
      '
      'lblAtt
      '
      Me.lblAtt.AutoSize = True
      Me.lblAtt.BackColor = System.Drawing.Color.Transparent
      Me.lblAtt.Location = New System.Drawing.Point(183, 68)
      Me.lblAtt.Name = "lblAtt"
      Me.lblAtt.Size = New System.Drawing.Size(29, 13)
      Me.lblAtt.TabIndex = 64
      Me.lblAtt.Text = "Euro"
      '
      'txtAttribuito
      '
      Me.txtAttribuito.AcceptsTab = True
      Me.txtAttribuito.Enabled = False
      Me.txtAttribuito.Location = New System.Drawing.Point(100, 64)
      Me.txtAttribuito.Name = "txtAttribuito"
      Me.txtAttribuito.Size = New System.Drawing.Size(80, 21)
      Me.txtAttribuito.TabIndex = 63
      '
      'lblAttribuito
      '
      Me.lblAttribuito.AutoSize = True
      Me.lblAttribuito.BackColor = System.Drawing.Color.Transparent
      Me.lblAttribuito.Location = New System.Drawing.Point(45, 68)
      Me.lblAttribuito.Name = "lblAttribuito"
      Me.lblAttribuito.Size = New System.Drawing.Size(52, 13)
      Me.lblAttribuito.TabIndex = 62
      Me.lblAttribuito.Text = "Attribuito"
      '
      'GrpSogg
      '
      Me.GrpSogg.BackColor = System.Drawing.Color.Silver
      Me.GrpSogg.Controls.Add(Me.Label13)
      Me.GrpSogg.Controls.Add(Me.Label9)
      Me.GrpSogg.Controls.Add(Me.lblDescrizioneAzienda)
      Me.GrpSogg.Controls.Add(Me.lblCompUltimo)
      Me.GrpSogg.ForeColor = System.Drawing.SystemColors.ControlText
      Me.GrpSogg.Location = New System.Drawing.Point(437, 200)
      Me.GrpSogg.Name = "GrpSogg"
      Me.GrpSogg.Size = New System.Drawing.Size(267, 101)
      Me.GrpSogg.TabIndex = 0
      Me.GrpSogg.Text = "Dati anagrafici del pagante"
      Me.GrpSogg.Title = "Dati Inps"
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Location = New System.Drawing.Point(12, 26)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(85, 13)
      Me.Label13.TabIndex = 3
      Me.Label13.Text = "Ragione sociale:"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Location = New System.Drawing.Point(12, 60)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(198, 13)
      Me.Label9.TabIndex = 2
      Me.Label9.Text = "La competenza dell'ultimo pagamento è:"
      '
      'lblDescrizioneAzienda
      '
      Me.lblDescrizioneAzienda.AutoSize = True
      Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneAzienda.Cursor = System.Windows.Forms.Cursors.Arrow
      Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(17, 41)
      Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
      Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(32, 13)
      Me.lblDescrizioneAzienda.TabIndex = 0
      Me.lblDescrizioneAzienda.Text = "Inps"
      '
      'lblCompUltimo
      '
      Me.lblCompUltimo.AutoSize = True
      Me.lblCompUltimo.BackColor = System.Drawing.Color.Transparent
      Me.lblCompUltimo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.lblCompUltimo, "Periodo di competenza dell'ultimo pagamento effettuato dall'Inps")
      Me.lblCompUltimo.Location = New System.Drawing.Point(16, 79)
      Me.lblCompUltimo.Name = "lblCompUltimo"
      Me.HelpProvider1.SetShowHelp(Me.lblCompUltimo, True)
      Me.lblCompUltimo.Size = New System.Drawing.Size(82, 13)
      Me.lblCompUltimo.TabIndex = 1
      Me.lblCompUltimo.Text = "Comp. Ultimo"
      '
      'lblTot
      '
      Me.lblTot.AutoSize = True
      Me.lblTot.BackColor = System.Drawing.Color.Transparent
      Me.lblTot.Location = New System.Drawing.Point(183, 35)
      Me.lblTot.Name = "lblTot"
      Me.lblTot.Size = New System.Drawing.Size(29, 13)
      Me.lblTot.TabIndex = 61
      Me.lblTot.Text = "Euro"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(11, 86)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(420, 219)
      Me.TabControl1.TabIndex = 1
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.cmdCompetenza)
      Me.TabPage1.Controls.Add(Me.txtCompetenza)
      Me.TabPage1.Controls.Add(Me.Label4)
      Me.TabPage1.Controls.Add(Me.TextBox1)
      Me.TabPage1.Controls.Add(Me.Label6)
      Me.TabPage1.Controls.Add(Me.dtpDoc)
      Me.TabPage1.Controls.Add(Me.Label5)
      Me.TabPage1.Controls.Add(Me.Label3)
      Me.TabPage1.Controls.Add(Me.txtImporto)
      Me.TabPage1.Controls.Add(Me.lblValuta)
      Me.TabPage1.Controls.Add(Me.txtNote)
      Me.TabPage1.Controls.Add(Me.Label8)
      Me.TabPage1.Controls.Add(Me.dtpRegistrazione)
      Me.TabPage1.Controls.Add(Me.Label1)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(412, 193)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Dati generali"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'cmdCompetenza
      '
      Me.HelpProvider1.SetHelpString(Me.cmdCompetenza, "Funzione che permette di selezionare il periodo di competenza delle quote incassa" & _
              "te.")
      Me.cmdCompetenza.Image = CType(resources.GetObject("cmdCompetenza.Image"), System.Drawing.Image)
      Me.cmdCompetenza.Location = New System.Drawing.Point(219, 151)
      Me.cmdCompetenza.Name = "cmdCompetenza"
      Me.HelpProvider1.SetShowHelp(Me.cmdCompetenza, True)
      Me.cmdCompetenza.Size = New System.Drawing.Size(32, 23)
      Me.cmdCompetenza.TabIndex = 65
      Me.cmdCompetenza.UseVisualStyleBackColor = True
      '
      'txtCompetenza
      '
      Me.txtCompetenza.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.txtCompetenza, "Periodo di competenza delle quote incassate")
      Me.txtCompetenza.Location = New System.Drawing.Point(59, 153)
      Me.txtCompetenza.Name = "txtCompetenza"
      Me.HelpProvider1.SetShowHelp(Me.txtCompetenza, True)
      Me.txtCompetenza.Size = New System.Drawing.Size(156, 21)
      Me.txtCompetenza.TabIndex = 3
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Location = New System.Drawing.Point(11, 157)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(38, 13)
      Me.Label4.TabIndex = 63
      Me.Label4.Text = "Comp."
      '
      'TextBox1
      '
      Me.TextBox1.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.TextBox1, "Tipo di quote incassate")
      Me.TextBox1.Location = New System.Drawing.Point(59, 87)
      Me.TextBox1.Name = "TextBox1"
      Me.HelpProvider1.SetShowHelp(Me.TextBox1, True)
      Me.TextBox1.Size = New System.Drawing.Size(113, 21)
      Me.TextBox1.TabIndex = 3
      Me.TextBox1.Text = "Incasso Quota Inps"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(6, 91)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(51, 13)
      Me.Label6.TabIndex = 36
      Me.Label6.Text = "Tipo doc."
      '
      'dtpDoc
      '
      Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data del documento cui l'incasso quote fa riferimento. ")
      Me.dtpDoc.Location = New System.Drawing.Point(60, 55)
      Me.dtpDoc.Name = "dtpDoc"
      Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
      Me.dtpDoc.Size = New System.Drawing.Size(100, 21)
      Me.dtpDoc.TabIndex = 2
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(3, 61)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(54, 13)
      Me.Label5.TabIndex = 34
      Me.Label5.Text = "Data doc."
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(11, 123)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(45, 13)
      Me.Label3.TabIndex = 14
      Me.Label3.Text = "Importo"
      '
      'txtImporto
      '
      Me.HelpProvider1.SetHelpString(Me.txtImporto, "Importo complessivo delle quote incassate")
      Me.txtImporto.Location = New System.Drawing.Point(59, 119)
      Me.txtImporto.Name = "txtImporto"
      Me.HelpProvider1.SetShowHelp(Me.txtImporto, True)
      Me.txtImporto.Size = New System.Drawing.Size(68, 21)
      Me.txtImporto.TabIndex = 4
      '
      'lblValuta
      '
      Me.lblValuta.AutoSize = True
      Me.lblValuta.Location = New System.Drawing.Point(134, 123)
      Me.lblValuta.Name = "lblValuta"
      Me.lblValuta.Size = New System.Drawing.Size(29, 13)
      Me.lblValuta.TabIndex = 16
      Me.lblValuta.Text = "Euro"
      '
      'txtNote
      '
      Me.txtNote.Location = New System.Drawing.Point(258, 26)
      Me.txtNote.Multiline = True
      Me.txtNote.Name = "txtNote"
      Me.txtNote.Size = New System.Drawing.Size(133, 148)
      Me.txtNote.TabIndex = 5
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(223, 29)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(30, 13)
      Me.Label8.TabIndex = 23
      Me.Label8.Text = "Note"
      '
      'dtpRegistrazione
      '
      Me.dtpRegistrazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpRegistrazione, "Data di registrazione dell'incasso quote nel sistema")
      Me.dtpRegistrazione.Location = New System.Drawing.Point(60, 25)
      Me.dtpRegistrazione.Name = "dtpRegistrazione"
      Me.HelpProvider1.SetShowHelp(Me.dtpRegistrazione, True)
      Me.dtpRegistrazione.Size = New System.Drawing.Size(100, 21)
      Me.dtpRegistrazione.TabIndex = 1
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(4, 29)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(53, 13)
      Me.Label1.TabIndex = 9
      Me.Label1.Text = "Data reg."
      '
      'txtTotale
      '
      Me.txtTotale.Enabled = False
      Me.txtTotale.Location = New System.Drawing.Point(100, 31)
      Me.txtTotale.Name = "txtTotale"
      Me.txtTotale.Size = New System.Drawing.Size(80, 21)
      Me.txtTotale.TabIndex = 60
      '
      'lblTotale
      '
      Me.lblTotale.AutoSize = True
      Me.lblTotale.BackColor = System.Drawing.Color.Transparent
      Me.lblTotale.Location = New System.Drawing.Point(30, 35)
      Me.lblTotale.Name = "lblTotale"
      Me.lblTotale.Size = New System.Drawing.Size(67, 13)
      Me.lblTotale.TabIndex = 59
      Me.lblTotale.Text = "Da attribuire"
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
      Me.GridPosizioni.Location = New System.Drawing.Point(15, 314)
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
      Me.GridPosizioni.Size = New System.Drawing.Size(602, 273)
      Me.GridPosizioni.TabIndex = 70
      '
      'cmdDel
      '
      Me.cmdDel.ApplyOutLookStile = True
      Me.cmdDel.BackColor = System.Drawing.Color.Transparent
      Me.cmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdDel.BackImage = CType(resources.GetObject("cmdDel.BackImage"), System.Drawing.Image)
      Me.cmdDel.Disabled = False
      Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdDel.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdDel, "Funzione che permette di eliminare una nuova posizione di incasso al documento di" & _
              " incasso, ovvero eliminare una nuova quota da incassare per un utente.")
      Me.cmdDel.Location = New System.Drawing.Point(14, 130)
      Me.cmdDel.Name = "cmdDel"
      Me.cmdDel.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdDel, True)
      Me.cmdDel.ShowTooltip = True
      Me.cmdDel.Size = New System.Drawing.Size(48, 48)
      Me.cmdDel.TabIndex = 55
      Me.cmdDel.TextValue = ""
      Me.cmdDel.TooltipText = "Rimuovi posizione"
      '
      'cmdAdd
      '
      Me.cmdAdd.ApplyOutLookStile = True
      Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
      Me.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdAdd.BackImage = CType(resources.GetObject("cmdAdd.BackImage"), System.Drawing.Image)
      Me.cmdAdd.Disabled = False
      Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdAdd.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdAdd, "Funzione che permette di aggiungere una nuova posizione di incasso al documento d" & _
              "i incasso, ovvero aggiungere una nuova quota da incassare per un utente.")
      Me.cmdAdd.Location = New System.Drawing.Point(14, 88)
      Me.cmdAdd.Name = "cmdAdd"
      Me.cmdAdd.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdAdd, True)
      Me.cmdAdd.ShowTooltip = True
      Me.cmdAdd.Size = New System.Drawing.Size(48, 48)
      Me.cmdAdd.TabIndex = 54
      Me.cmdAdd.TextValue = ""
      Me.cmdAdd.TooltipText = "Aggiungi posizione"
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
      Me.HelpProvider1.SetHelpString(Me.CmdCrea, "Funzione che permette di creare un nuovo incasso con le caratteristiche espresse " & _
              "nella maschera Dati generali.")
      Me.CmdCrea.Location = New System.Drawing.Point(347, 8)
      Me.CmdCrea.Name = "CmdCrea"
      Me.CmdCrea.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdCrea, True)
      Me.CmdCrea.ShowTooltip = True
      Me.CmdCrea.Size = New System.Drawing.Size(32, 32)
      Me.CmdCrea.TabIndex = 56
      Me.CmdCrea.TextValue = ""
      Me.CmdCrea.TooltipText = "Crea incasso"
      '
      'Panel1
      '
      Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
      Me.Panel1.Controls.Add(Me.cmdDel)
      Me.Panel1.Controls.Add(Me.cmdUp)
      Me.Panel1.Controls.Add(Me.cmdAdd)
      Me.Panel1.Controls.Add(Me.CmdDown)
      Me.Panel1.Location = New System.Drawing.Point(625, 314)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(79, 180)
      Me.Panel1.TabIndex = 72
      '
      'cmdUp
      '
      Me.cmdUp.ApplyOutLookStile = True
      Me.cmdUp.BackColor = System.Drawing.Color.Transparent
      Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdUp.BackImage = CType(resources.GetObject("cmdUp.BackImage"), System.Drawing.Image)
      Me.cmdUp.Disabled = False
      Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdUp.ForeColor = System.Drawing.Color.Transparent
      Me.cmdUp.Location = New System.Drawing.Point(14, 0)
      Me.cmdUp.Name = "cmdUp"
      Me.cmdUp.Radius = 48.0!
      Me.cmdUp.ShowTooltip = True
      Me.cmdUp.Size = New System.Drawing.Size(48, 48)
      Me.cmdUp.TabIndex = 52
      Me.cmdUp.TextValue = ""
      Me.cmdUp.TooltipText = "Ordina dall'alto"
      '
      'CmdDown
      '
      Me.CmdDown.ApplyOutLookStile = True
      Me.CmdDown.BackColor = System.Drawing.Color.Transparent
      Me.CmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDown.BackImage = CType(resources.GetObject("CmdDown.BackImage"), System.Drawing.Image)
      Me.CmdDown.Disabled = False
      Me.CmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdDown.ForeColor = System.Drawing.Color.Transparent
      Me.CmdDown.Location = New System.Drawing.Point(14, 43)
      Me.CmdDown.Name = "CmdDown"
      Me.CmdDown.Radius = 48.0!
      Me.CmdDown.ShowTooltip = True
      Me.CmdDown.Size = New System.Drawing.Size(48, 48)
      Me.CmdDown.TabIndex = 53
      Me.CmdDown.TextValue = ""
      Me.CmdDown.TooltipText = "Ordina dal basso"
      '
      'cmdRed
      '
      Me.cmdRed.BackColor = System.Drawing.Color.Transparent
      Me.cmdRed.BackgroundImage = CType(resources.GetObject("cmdRed.BackgroundImage"), System.Drawing.Image)
      Me.cmdRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.cmdRed.FlatAppearance.BorderSize = 0
      Me.cmdRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdRed.Location = New System.Drawing.Point(218, 28)
      Me.cmdRed.Name = "cmdRed"
      Me.cmdRed.Size = New System.Drawing.Size(16, 16)
      Me.cmdRed.TabIndex = 67
      Me.cmdRed.UseVisualStyleBackColor = False
      '
      'cmdBlu
      '
      Me.cmdBlu.BackColor = System.Drawing.Color.Transparent
      Me.cmdBlu.BackgroundImage = CType(resources.GetObject("cmdBlu.BackgroundImage"), System.Drawing.Image)
      Me.cmdBlu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.cmdBlu.FlatAppearance.BorderSize = 0
      Me.cmdBlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdBlu.Location = New System.Drawing.Point(218, 50)
      Me.cmdBlu.Name = "cmdBlu"
      Me.cmdBlu.Size = New System.Drawing.Size(16, 16)
      Me.cmdBlu.TabIndex = 66
      Me.cmdBlu.UseVisualStyleBackColor = False
      '
      'cmdGreen
      '
      Me.cmdGreen.BackColor = System.Drawing.Color.Transparent
      Me.cmdGreen.BackgroundImage = CType(resources.GetObject("cmdGreen.BackgroundImage"), System.Drawing.Image)
      Me.cmdGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.cmdGreen.FlatAppearance.BorderSize = 0
      Me.cmdGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdGreen.Location = New System.Drawing.Point(218, 70)
      Me.cmdGreen.Name = "cmdGreen"
      Me.cmdGreen.Size = New System.Drawing.Size(16, 16)
      Me.cmdGreen.TabIndex = 65
      Me.cmdGreen.UseVisualStyleBackColor = False
      '
      'cmdPrest
      '
      Me.cmdPrest.ApplyOutLookStile = True
      Me.cmdPrest.BackColor = System.Drawing.Color.Transparent
      Me.cmdPrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdPrest.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.prestiti_32x32
      Me.cmdPrest.Disabled = False
      Me.cmdPrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdPrest.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdPrest, "Funzione che permette di aprire una nuova istanza di FenealGest in cui parallelame" & _
              "nte è possibile visualizzare le prestazioni Inps di un utente.")
      Me.cmdPrest.Location = New System.Drawing.Point(305, 6)
      Me.cmdPrest.Name = "cmdPrest"
      Me.cmdPrest.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdPrest, True)
      Me.cmdPrest.ShowTooltip = True
      Me.cmdPrest.Size = New System.Drawing.Size(32, 32)
      Me.cmdPrest.TabIndex = 71
      Me.cmdPrest.TextValue = ""
      Me.cmdPrest.TooltipText = "Esplora prestazioni utente"
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.lblTotale)
      Me.NiceGroupBox1.Controls.Add(Me.txtTotale)
      Me.NiceGroupBox1.Controls.Add(Me.cmdRed)
      Me.NiceGroupBox1.Controls.Add(Me.lblTot)
      Me.NiceGroupBox1.Controls.Add(Me.cmdBlu)
      Me.NiceGroupBox1.Controls.Add(Me.lblAttribuito)
      Me.NiceGroupBox1.Controls.Add(Me.cmdGreen)
      Me.NiceGroupBox1.Controls.Add(Me.txtAttribuito)
      Me.NiceGroupBox1.Controls.Add(Me.lblAtt)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(437, 91)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(267, 100)
      Me.NiceGroupBox1.TabIndex = 73
      Me.NiceGroupBox1.Title = "Totalizzazioni"
      '
      'ControlPagamentoQuoteInps
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.GrpSogg)
      Me.Controls.Add(Me.TabControl1)
      Me.Controls.Add(Me.GridPosizioni)
      Me.Name = "ControlPagamentoQuoteInps"
      Me.Size = New System.Drawing.Size(736, 607)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.TabControl1, 0)
      Me.Controls.SetChildIndex(Me.GrpSogg, 0)
      Me.Controls.SetChildIndex(Me.Panel1, 0)
      Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.GrpSogg.ResumeLayout(False)
      Me.GrpSogg.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents cmdAdd As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdRed As System.Windows.Forms.Button
   Friend WithEvents CmdCrea As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdBlu As System.Windows.Forms.Button
    Friend WithEvents cmdGreen As System.Windows.Forms.Button
    Friend WithEvents lblAtt As System.Windows.Forms.Label
    Friend WithEvents txtAttribuito As System.Windows.Forms.TextBox
    Friend WithEvents lblAttribuito As System.Windows.Forms.Label
    Friend WithEvents GrpSogg As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
   Friend WithEvents lblCompUltimo As System.Windows.Forms.Label
   Friend WithEvents lblTot As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Public WithEvents txtImporto As System.Windows.Forms.TextBox
   Friend WithEvents lblValuta As System.Windows.Forms.Label
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents dtpRegistrazione As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtTotale As System.Windows.Forms.TextBox
   Friend WithEvents lblTotale As System.Windows.Forms.Label
   Friend WithEvents cmdCompetenza As System.Windows.Forms.Button
   Friend WithEvents txtCompetenza As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Friend WithEvents cmdPrest As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
