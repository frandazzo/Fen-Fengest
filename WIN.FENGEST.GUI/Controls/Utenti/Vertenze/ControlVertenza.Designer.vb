<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVertenza
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
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox
        Me.chkVertenzaChiusa = New System.Windows.Forms.CheckBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
        Me.lblUtente = New System.Windows.Forms.Label
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker
        Me.lblAzienda = New System.Windows.Forms.Label
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label
        Me.dtpData = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAziendaDescrizione = New System.Windows.Forms.Label
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dtpDI = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstIst = New System.Windows.Forms.CheckedListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpDF = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.IdAvvocatoTextbox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAvvocatoTextbox
        Me.lblDescrizioneAvvocato = New System.Windows.Forms.Label
        Me.lblAvvocato = New System.Windows.Forms.Label
        Me.txtImp = New System.Windows.Forms.TextBox
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDescrizioneRUP = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
        Me.lblReferente = New System.Windows.Forms.Label
        Me.lblRup = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblId = New System.Windows.Forms.Label
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridEventi = New System.Windows.Forms.DataGridView
        Me.grpEventi = New WIN.GUI.UTILITY.NiceGroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmdSel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.CmdDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.CmdAdd = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.DockPanel.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridEventi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEventi.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(864, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.txtId)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(864, 44)
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.Silver
        Me.MainGroup.Controls.Add(Me.chkVertenzaChiusa)
        Me.MainGroup.Controls.Add(Me.TabControl2)
        Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainGroup.ForeColor = System.Drawing.Color.Black
        Me.MainGroup.Location = New System.Drawing.Point(16, 74)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(526, 313)
        Me.MainGroup.TabIndex = 1
        Me.MainGroup.Text = "Dati principali"
        Me.MainGroup.Title = "Dati generali"
        '
        'chkVertenzaChiusa
        '
        Me.chkVertenzaChiusa.AutoSize = True
        Me.chkVertenzaChiusa.ForeColor = System.Drawing.Color.Red
        Me.chkVertenzaChiusa.Location = New System.Drawing.Point(387, 25)
        Me.chkVertenzaChiusa.Name = "chkVertenzaChiusa"
        Me.chkVertenzaChiusa.Size = New System.Drawing.Size(117, 17)
        Me.chkVertenzaChiusa.TabIndex = 63
        Me.chkVertenzaChiusa.Text = "Vertenza chiusa"
        Me.chkVertenzaChiusa.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(16, 48)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(492, 260)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.IdAziendaTextBox1)
        Me.TabPage2.Controls.Add(Me.lblUtente)
        Me.TabPage2.Controls.Add(Me.dtpDoc)
        Me.TabPage2.Controls.Add(Me.lblAzienda)
        Me.TabPage2.Controls.Add(Me.IdUtenteTextBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lblDescrizioneUtente)
        Me.TabPage2.Controls.Add(Me.dtpData)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblAziendaDescrizione)
        Me.TabPage2.Controls.Add(Me.txtNote)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(484, 234)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Dati documento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'IdAziendaTextBox1
        '
        Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAziendaTextBox1.DescriptionOfText = ""
        Me.IdAziendaTextBox1.DescriptionTextWidth = 150
        Me.IdAziendaTextBox1.DescriptionTextXValue = 92
        Me.IdAziendaTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo dell'azienda controparte nella vertenza")
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(72, 93)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(91, 25)
        Me.IdAziendaTextBox1.TabIndex = 51
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUtente.Location = New System.Drawing.Point(30, 59)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(39, 13)
        Me.lblUtente.TabIndex = 56
        Me.lblUtente.Text = "Utente"
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data in cui è stata creata la vertenza")
        Me.dtpDoc.Location = New System.Drawing.Point(242, 25)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(96, 20)
        Me.dtpDoc.TabIndex = 57
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblAzienda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAzienda.Location = New System.Drawing.Point(21, 97)
        Me.lblAzienda.Name = "lblAzienda"
        Me.lblAzienda.Size = New System.Drawing.Size(47, 13)
        Me.lblAzienda.TabIndex = 53
        Me.lblAzienda.Text = "Controp."
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente relativo alla vertenza")
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(72, 58)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(91, 23)
        Me.IdUtenteTextBox1.TabIndex = 55
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Note"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Data reg."
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(174, 62)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 54
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data in cui la vertenza è stata registrata nel sistema")
        Me.dtpData.Location = New System.Drawing.Point(73, 24)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(96, 20)
        Me.dtpData.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Data doc."
        '
        'lblAziendaDescrizione
        '
        Me.lblAziendaDescrizione.AutoSize = True
        Me.lblAziendaDescrizione.BackColor = System.Drawing.Color.Transparent
        Me.lblAziendaDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAziendaDescrizione.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAziendaDescrizione.Location = New System.Drawing.Point(176, 99)
        Me.lblAziendaDescrizione.Name = "lblAziendaDescrizione"
        Me.lblAziendaDescrizione.Size = New System.Drawing.Size(0, 13)
        Me.lblAziendaDescrizione.TabIndex = 52
        '
        'txtNote
        '
        Me.txtNote.AcceptsReturn = True
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note.")
        Me.txtNote.Location = New System.Drawing.Point(72, 131)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(356, 71)
        Me.txtNote.TabIndex = 58
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dtpDI)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.lstIst)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.dtpDF)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(484, 234)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Contenzioso"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dtpDI
        '
        Me.dtpDI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDI, "Data di inizio del contenzioso")
        Me.dtpDI.Location = New System.Drawing.Point(84, 12)
        Me.dtpDI.Name = "dtpDI"
        Me.HelpProvider1.SetShowHelp(Me.dtpDI, True)
        Me.dtpDI.Size = New System.Drawing.Size(96, 20)
        Me.dtpDI.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Istituti contrattuali"
        '
        'lstIst
        '
        Me.lstIst.FormattingEnabled = True
        Me.lstIst.Location = New System.Drawing.Point(15, 79)
        Me.lstIst.Name = "lstIst"
        Me.lstIst.Size = New System.Drawing.Size(342, 139)
        Me.lstIst.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(22, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Inizio cont."
        '
        'dtpDF
        '
        Me.dtpDF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDF, "Data di fine del contenzioso")
        Me.dtpDF.Location = New System.Drawing.Point(261, 14)
        Me.dtpDF.Name = "dtpDF"
        Me.HelpProvider1.SetShowHelp(Me.dtpDF, True)
        Me.dtpDF.Size = New System.Drawing.Size(96, 20)
        Me.dtpDF.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(205, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Fine cont."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.IdAvvocatoTextbox1)
        Me.TabPage4.Controls.Add(Me.lblDescrizioneAvvocato)
        Me.TabPage4.Controls.Add(Me.lblAvvocato)
        Me.TabPage4.Controls.Add(Me.txtImp)
        Me.TabPage4.Controls.Add(Me.IdReferenteTextBox1)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.lblDescrizioneRUP)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.lblDescrizioneReferente)
        Me.TabPage4.Controls.Add(Me.IdReferenteTextBox2)
        Me.TabPage4.Controls.Add(Me.lblReferente)
        Me.TabPage4.Controls.Add(Me.lblRup)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(484, 234)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Procedimento"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'IdAvvocatoTextbox1
        '
        Me.IdAvvocatoTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAvvocatoTextbox1.DescriptionOfText = ""
        Me.IdAvvocatoTextbox1.DescriptionTextWidth = 150
        Me.IdAvvocatoTextbox1.DescriptionTextXValue = 92
        Me.IdAvvocatoTextbox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdAvvocatoTextbox1, "Avvocato cui è stato affidato il contenzioso")
        Me.IdAvvocatoTextbox1.IsDescriptionVisible = False
        Me.IdAvvocatoTextbox1.Location = New System.Drawing.Point(185, 33)
        Me.IdAvvocatoTextbox1.Mandatory = False
        Me.IdAvvocatoTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAvvocatoTextbox1.Name = "IdAvvocatoTextbox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAvvocatoTextbox1, True)
        Me.IdAvvocatoTextbox1.Size = New System.Drawing.Size(91, 25)
        Me.IdAvvocatoTextbox1.TabIndex = 77
        Me.IdAvvocatoTextbox1.TextValue = ""
        '
        'lblDescrizioneAvvocato
        '
        Me.lblDescrizioneAvvocato.AutoSize = True
        Me.lblDescrizioneAvvocato.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAvvocato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAvvocato.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneAvvocato.Location = New System.Drawing.Point(289, 37)
        Me.lblDescrizioneAvvocato.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblDescrizioneAvvocato.Name = "lblDescrizioneAvvocato"
        Me.lblDescrizioneAvvocato.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAvvocato.TabIndex = 75
        '
        'lblAvvocato
        '
        Me.lblAvvocato.AutoSize = True
        Me.lblAvvocato.BackColor = System.Drawing.Color.Transparent
        Me.lblAvvocato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAvvocato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvvocato.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAvvocato.Location = New System.Drawing.Point(110, 37)
        Me.lblAvvocato.Name = "lblAvvocato"
        Me.lblAvvocato.Size = New System.Drawing.Size(53, 13)
        Me.lblAvvocato.TabIndex = 76
        Me.lblAvvocato.Text = "Avvocato"
        '
        'txtImp
        '
        Me.HelpProvider1.SetHelpString(Me.txtImp, "Importo concordato tra la federazione e l'utente per l'assistenza nella vertenza." & _
                "")
        Me.txtImp.Location = New System.Drawing.Point(132, 178)
        Me.txtImp.Name = "txtImp"
        Me.HelpProvider1.SetShowHelp(Me.txtImp, True)
        Me.txtImp.Size = New System.Drawing.Size(60, 20)
        Me.txtImp.TabIndex = 63
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale che ha proposto la vertenza alla segret" & _
                "eria provinciale")
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(183, 114)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(93, 27)
        Me.IdReferenteTextBox1.TabIndex = 71
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Importo concordato"
        '
        'lblDescrizioneRUP
        '
        Me.lblDescrizioneRUP.AutoSize = True
        Me.lblDescrizioneRUP.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneRUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneRUP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneRUP.Location = New System.Drawing.Point(291, 76)
        Me.lblDescrizioneRUP.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblDescrizioneRUP.Name = "lblDescrizioneRUP"
        Me.lblDescrizioneRUP.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneRUP.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(198, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Euro"
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(291, 120)
        Me.lblDescrizioneReferente.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 72
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox2, "Identificativo del responsabile unico del procedimento (R.U.P.)")
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(185, 72)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(91, 25)
        Me.IdReferenteTextBox2.TabIndex = 68
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReferente.Location = New System.Drawing.Point(45, 120)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(118, 13)
        Me.lblReferente.TabIndex = 73
        Me.lblReferente.Text = "Collaboratore comunale"
        '
        'lblRup
        '
        Me.lblRup.AutoSize = True
        Me.lblRup.BackColor = System.Drawing.Color.Transparent
        Me.lblRup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRup.Location = New System.Drawing.Point(8, 76)
        Me.lblRup.Name = "lblRup"
        Me.lblRup.Size = New System.Drawing.Size(155, 13)
        Me.lblRup.TabIndex = 70
        Me.lblRup.Text = "Responsabile del procedimento"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(79, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(67, 21)
        Me.txtId.TabIndex = 44
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(13, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(63, 13)
        Me.lblId.TabIndex = 43
        Me.lblId.Text = "Id vertenza"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(167, 0)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(297, 40)
        Me.CustomBar1.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 201)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridEventi)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(466, 175)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Elenco eventi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GridEventi
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridEventi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridEventi.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEventi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEventi.Location = New System.Drawing.Point(3, 3)
        Me.GridEventi.Name = "GridEventi"
        Me.GridEventi.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.GridEventi.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridEventi.Size = New System.Drawing.Size(460, 169)
        Me.GridEventi.TabIndex = 1
        '
        'grpEventi
        '
        Me.grpEventi.BackColor = System.Drawing.Color.Silver
        Me.grpEventi.Controls.Add(Me.Panel1)
        Me.grpEventi.Controls.Add(Me.TabControl1)
        Me.grpEventi.Location = New System.Drawing.Point(16, 393)
        Me.grpEventi.Name = "grpEventi"
        Me.grpEventi.Size = New System.Drawing.Size(605, 233)
        Me.grpEventi.TabIndex = 45
        Me.grpEventi.Title = "Eventi"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
        Me.Panel1.Controls.Add(Me.CmdSel)
        Me.Panel1.Controls.Add(Me.CmdDel)
        Me.Panel1.Controls.Add(Me.CmdAdd)
        Me.Panel1.Location = New System.Drawing.Point(496, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(79, 181)
        Me.Panel1.TabIndex = 9
        '
        'CmdSel
        '
        Me.CmdSel.ApplyOutLookStile = True
        Me.CmdSel.BackColor = System.Drawing.Color.Transparent
        Me.CmdSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdSel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.showsede_48x48
        Me.CmdSel.Disabled = False
        Me.CmdSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSel.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdSel, "Funzione che permette di visualizzare i dettagli dell'evento della vertenza selez" & _
                "ionato dall'elenco eventi.")
        Me.CmdSel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdSel.Location = New System.Drawing.Point(15, 13)
        Me.CmdSel.Name = "CmdSel"
        Me.CmdSel.Radius = 48.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdSel, True)
        Me.CmdSel.ShowTooltip = True
        Me.CmdSel.Size = New System.Drawing.Size(48, 48)
        Me.CmdSel.TabIndex = 0
        Me.CmdSel.TextValue = ""
        Me.CmdSel.TooltipText = "Seleziona evento"
        '
        'CmdDel
        '
        Me.CmdDel.ApplyOutLookStile = True
        Me.CmdDel.BackColor = System.Drawing.Color.Transparent
        Me.CmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.removesede_48x48
        Me.CmdDel.Disabled = False
        Me.CmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDel.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdDel, "Funzione che permette di eliminare l'evento selezionato dall'elenco eventi.")
        Me.CmdDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDel.Location = New System.Drawing.Point(15, 123)
        Me.CmdDel.Name = "CmdDel"
        Me.CmdDel.Radius = 48.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdDel, True)
        Me.CmdDel.ShowTooltip = True
        Me.CmdDel.Size = New System.Drawing.Size(48, 48)
        Me.CmdDel.TabIndex = 2
        Me.CmdDel.TextValue = ""
        Me.CmdDel.TooltipText = "Elimina evento"
        '
        'CmdAdd
        '
        Me.CmdAdd.ApplyOutLookStile = True
        Me.CmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdAdd.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.addsede_48x48
        Me.CmdAdd.Disabled = False
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAdd.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdAdd, "Funzione che permette di aggiungere un nuovo evento alla vertenza.")
        Me.CmdAdd.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdAdd.Location = New System.Drawing.Point(15, 68)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Radius = 48.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdAdd, True)
        Me.CmdAdd.ShowTooltip = True
        Me.CmdAdd.Size = New System.Drawing.Size(48, 48)
        Me.CmdAdd.TabIndex = 1
        Me.CmdAdd.TextValue = ""
        Me.CmdAdd.TooltipText = "Aggiungi evento"
        '
        'ControlVertenza
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.MainGroup)
        Me.Controls.Add(Me.grpEventi)
        Me.Name = "ControlVertenza"
        Me.Size = New System.Drawing.Size(864, 636)
        Me.Controls.SetChildIndex(Me.grpEventi, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridEventi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEventi.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents CmdSel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents CmdDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdAdd As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents grpEventi As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
   Friend WithEvents lstIst As System.Windows.Forms.CheckedListBox
   Friend WithEvents dtpDI As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents dtpDF As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtImp As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblDescrizioneRUP As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblRup As System.Windows.Forms.Label
   Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents lblAziendaDescrizione As System.Windows.Forms.Label
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents lblAzienda As System.Windows.Forms.Label
   Friend WithEvents lblReferente As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents GridEventi As System.Windows.Forms.DataGridView
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents IdAvvocatoTextbox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAvvocatoTextbox
   Friend WithEvents lblDescrizioneAvvocato As System.Windows.Forms.Label
    Friend WithEvents lblAvvocato As System.Windows.Forms.Label
    Friend WithEvents chkVertenzaChiusa As System.Windows.Forms.CheckBox

End Class
