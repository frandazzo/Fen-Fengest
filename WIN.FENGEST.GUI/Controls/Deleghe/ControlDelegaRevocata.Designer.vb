<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDelegaRevocata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDelegaRevocata))
        Me.txtIdDelega = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtValidita = New System.Windows.Forms.TextBox()
        Me.cboCausali = New System.Windows.Forms.ComboBox()
        Me.txtStato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblAzienda = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.GroupBox4 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblDescrizioneResponsabile = New System.Windows.Forms.Label()
        Me.lblResponsabile = New System.Windows.Forms.Label()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.lblSedeOperativa = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpReg = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SpRipristina = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpVisDett = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(525, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.txtIdDelega)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.SpRipristina)
        Me.DockPanel.Controls.Add(Me.SpVisDett)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(525, 44)
        '
        'txtIdDelega
        '
        Me.txtIdDelega.ForeColor = System.Drawing.Color.Black
        Me.HelpProvider1.SetHelpString(Me.txtIdDelega, "Identificativo della delega")
        Me.txtIdDelega.Location = New System.Drawing.Point(70, 12)
        Me.txtIdDelega.Name = "txtIdDelega"
        Me.HelpProvider1.SetShowHelp(Me.txtIdDelega, True)
        Me.txtIdDelega.Size = New System.Drawing.Size(64, 21)
        Me.txtIdDelega.TabIndex = 32
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(8, 16)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 13)
        Me.lblId.TabIndex = 31
        Me.lblId.Text = "Id. delega"
        '
        'txtValidita
        '
        Me.txtValidita.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtValidita, "eriodo di validità della delega")
        Me.txtValidita.Location = New System.Drawing.Point(78, 113)
        Me.txtValidita.Name = "txtValidita"
        Me.HelpProvider1.SetShowHelp(Me.txtValidita, True)
        Me.txtValidita.Size = New System.Drawing.Size(154, 21)
        Me.txtValidita.TabIndex = 45
        '
        'cboCausali
        '
        Me.cboCausali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCausali.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausali, "Causale di revoca della delega.Le causali possono essere impostate dal Menu Strum" & _
        "enti->Setup->Segreteria->Causali deleghe.")
        Me.cboCausali.Location = New System.Drawing.Point(78, 84)
        Me.cboCausali.Name = "cboCausali"
        Me.HelpProvider1.SetShowHelp(Me.cboCausali, True)
        Me.cboCausali.Size = New System.Drawing.Size(154, 21)
        Me.cboCausali.TabIndex = 3
        '
        'txtStato
        '
        Me.HelpProvider1.SetHelpString(Me.txtStato, "Stato in cui si trovava la delega al momento della revoca.")
        Me.txtStato.Location = New System.Drawing.Point(78, 55)
        Me.txtStato.Name = "txtStato"
        Me.HelpProvider1.SetShowHelp(Me.txtStato, True)
        Me.txtStato.Size = New System.Drawing.Size(154, 21)
        Me.txtStato.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Data rev."
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data in cui la delega è stata revocata")
        Me.dtpData.Location = New System.Drawing.Point(78, 27)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(101, 21)
        Me.dtpData.TabIndex = 1
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.BackColor = System.Drawing.Color.Transparent
        Me.lblEnte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEnte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnte.Location = New System.Drawing.Point(18, 136)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(43, 13)
        Me.lblEnte.TabIndex = 37
        Me.lblEnte.Text = "Ente in."
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale verso cui è stata inoltrata la delega sottoscritta dall'utente. G" & _
        "li enti bilaterali sono EdilCassa e CassaEdile")
        Me.cboEnti.Location = New System.Drawing.Point(69, 132)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(154, 21)
        Me.cboEnti.TabIndex = 2
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza della delega.I settori sono EDILE e IMPIANTI FISSI")
        Me.cboSettori.Location = New System.Drawing.Point(67, 61)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(177, 21)
        Me.cboSettori.TabIndex = 1
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data documento della delega.Si ricordi che la data documento è la data in cui il " & _
        "funzionario ha fatto sottoscrivere la delega.")
        Me.dtpDoc.Location = New System.Drawing.Point(284, 31)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(112, 20)
        Me.dtpDoc.TabIndex = 2
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note legate alla sottoscrizione della delega.")
        Me.txtNote.Location = New System.Drawing.Point(70, 197)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(326, 74)
        Me.txtNote.TabIndex = 29
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(172, 137)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(177, 37)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 0
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(167, 98)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
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
        Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo dell'azienda di impiego del lavoratore. Essa viene inserita nel ca" & _
        "so di delega del settore IMPIANTI FISSI")
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(67, 132)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(92, 24)
        Me.IdAziendaTextBox1.TabIndex = 23
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblAzienda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAzienda.Location = New System.Drawing.Point(28, 136)
        Me.lblAzienda.Name = "lblAzienda"
        Me.lblAzienda.Size = New System.Drawing.Size(36, 13)
        Me.lblAzienda.TabIndex = 22
        Me.lblAzienda.Text = "Az. in."
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, resources.GetString("IdReferenteTextBox1.HelpString"))
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(75, 29)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(93, 24)
        Me.IdReferenteTextBox1.TabIndex = 19
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente")
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(66, 92)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(94, 24)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReferente.Location = New System.Drawing.Point(31, 39)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(27, 13)
        Me.lblReferente.TabIndex = 15
        Me.lblReferente.Text = "Coll."
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUtente.Location = New System.Drawing.Point(9, 98)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 13
        Me.lblUtente.Text = "Id utente"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(135, 2)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.txtValidita)
        Me.GroupBox4.Controls.Add(Me.cboCausali)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtStato)
        Me.GroupBox4.Controls.Add(Me.dtpData)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(11, 485)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(453, 148)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.Title = "Dati Revoca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(26, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Causale"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(7, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Per. validità"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(10, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Stato prec."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.IdReferenteTextBox2)
        Me.GroupBox1.Controls.Add(Me.lblDescrizioneResponsabile)
        Me.GroupBox1.Controls.Add(Me.lblResponsabile)
        Me.GroupBox1.Controls.Add(Me.IdReferenteTextBox1)
        Me.GroupBox1.Controls.Add(Me.lblReferente)
        Me.GroupBox1.Controls.Add(Me.lblDescrizioneReferente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.Title = "Dati collaboratore comunale"
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.Enabled = False
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox2, "Identificativo del funzionario della segreteria provinciale  che è responsabile d" & _
        "ella delega")
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(75, 66)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(93, 24)
        Me.IdReferenteTextBox2.TabIndex = 63
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'lblDescrizioneResponsabile
        '
        Me.lblDescrizioneResponsabile.AutoSize = True
        Me.lblDescrizioneResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneResponsabile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneResponsabile.Location = New System.Drawing.Point(176, 70)
        Me.lblDescrizioneResponsabile.Name = "lblDescrizioneResponsabile"
        Me.lblDescrizioneResponsabile.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneResponsabile.TabIndex = 62
        '
        'lblResponsabile
        '
        Me.lblResponsabile.AutoSize = True
        Me.lblResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblResponsabile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblResponsabile.Location = New System.Drawing.Point(0, 72)
        Me.lblResponsabile.Name = "lblResponsabile"
        Me.lblResponsabile.Size = New System.Drawing.Size(71, 13)
        Me.lblResponsabile.TabIndex = 61
        Me.lblResponsabile.Text = "Responsabile"
        '
        'cboSede
        '
        Me.cboSede.Enabled = False
        Me.cboSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSede, "Sede operativa dell'azienda presso cui il lavoratore è impiegato.Essa è indicata " & _
        "solo nel caso di delega del settore IMPIANTI FISSI")
        Me.cboSede.Location = New System.Drawing.Point(70, 163)
        Me.cboSede.Name = "cboSede"
        Me.HelpProvider1.SetShowHelp(Me.cboSede, True)
        Me.cboSede.Size = New System.Drawing.Size(153, 21)
        Me.cboSede.TabIndex = 86
        '
        'lblSedeOperativa
        '
        Me.lblSedeOperativa.AutoSize = True
        Me.lblSedeOperativa.BackColor = System.Drawing.Color.Transparent
        Me.lblSedeOperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSedeOperativa.Location = New System.Drawing.Point(15, 170)
        Me.lblSedeOperativa.Name = "lblSedeOperativa"
        Me.lblSedeOperativa.Size = New System.Drawing.Size(50, 13)
        Me.lblSedeOperativa.TabIndex = 85
        Me.lblSedeOperativa.Text = "Sede op."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Settore"
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.Silver
        Me.MainGroup.Controls.Add(Me.lblDescrizioneAzienda)
        Me.MainGroup.Controls.Add(Me.cboSede)
        Me.MainGroup.Controls.Add(Me.lblSedeOperativa)
        Me.MainGroup.Controls.Add(Me.Label20)
        Me.MainGroup.Controls.Add(Me.Label19)
        Me.MainGroup.Controls.Add(Me.cboEnti)
        Me.MainGroup.Controls.Add(Me.IdAziendaTextBox1)
        Me.MainGroup.Controls.Add(Me.Label15)
        Me.MainGroup.Controls.Add(Me.lblEnte)
        Me.MainGroup.Controls.Add(Me.dtpReg)
        Me.MainGroup.Controls.Add(Me.lblAzienda)
        Me.MainGroup.Controls.Add(Me.cboSettori)
        Me.MainGroup.Controls.Add(Me.Label21)
        Me.MainGroup.Controls.Add(Me.txtNote)
        Me.MainGroup.Controls.Add(Me.dtpDoc)
        Me.MainGroup.Controls.Add(Me.IdUtenteTextBox1)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneUtente)
        Me.MainGroup.Controls.Add(Me.lblUtente)
        Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainGroup.ForeColor = System.Drawing.Color.Black
        Me.MainGroup.Location = New System.Drawing.Point(11, 82)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(451, 288)
        Me.MainGroup.TabIndex = 1
        Me.MainGroup.Text = "Dati principali"
        Me.MainGroup.Title = "Dati Generali"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(12, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 74
        Me.Label20.Text = "Data reg."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 196)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Note"
        '
        'dtpReg
        '
        Me.dtpReg.Enabled = False
        Me.dtpReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpReg, "Data di registrazione della delega. Si ricordi che la data di registrazione è la " & _
        "data in cui il funzionario registra la sottoscrizione della delega.")
        Me.dtpReg.Location = New System.Drawing.Point(67, 31)
        Me.dtpReg.Name = "dtpReg"
        Me.HelpProvider1.SetShowHelp(Me.dtpReg, True)
        Me.dtpReg.Size = New System.Drawing.Size(112, 20)
        Me.dtpReg.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(227, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Data doc."
        '
        'SpRipristina
        '
        Me.SpRipristina.ApplyOutLookStile = True
        Me.SpRipristina.BackColor = System.Drawing.Color.Transparent
        Me.SpRipristina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpRipristina.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_development_32x32
        Me.SpRipristina.Disabled = False
        Me.SpRipristina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpRipristina.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpRipristina, "Funzione che permette di ripristinare lo stato precedente della delega. Questa fu" & _
        "nzione serve per proteggere il sistema da eventuali errori di immissione da part" & _
        "e del funzionario della federazione.")
        Me.SpRipristina.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpRipristina.Location = New System.Drawing.Point(432, 7)
        Me.SpRipristina.Name = "SpRipristina"
        Me.SpRipristina.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpRipristina, True)
        Me.SpRipristina.ShowTooltip = True
        Me.SpRipristina.Size = New System.Drawing.Size(32, 32)
        Me.SpRipristina.TabIndex = 6
        Me.SpRipristina.TextValue = ""
        Me.SpRipristina.TooltipText = "Ripristina stato precedente"
        '
        'SpVisDett
        '
        Me.SpVisDett.ApplyOutLookStile = True
        Me.SpVisDett.BackColor = System.Drawing.Color.Transparent
        Me.SpVisDett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpVisDett.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_find_32x32
        Me.SpVisDett.Disabled = False
        Me.SpVisDett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpVisDett.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpVisDett, "Funzione che visualizza i dettagli sull'iter che la delega revocata ha seguito.")
        Me.SpVisDett.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpVisDett.Location = New System.Drawing.Point(471, 7)
        Me.SpVisDett.Name = "SpVisDett"
        Me.SpVisDett.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpVisDett, True)
        Me.SpVisDett.ShowTooltip = True
        Me.SpVisDett.Size = New System.Drawing.Size(32, 32)
        Me.SpVisDett.TabIndex = 5
        Me.SpVisDett.TextValue = ""
        Me.SpVisDett.TooltipText = "Visualizza dettagli"
        '
        'ControlDelegaRevocata
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MainGroup)
        Me.Name = "ControlDelegaRevocata"
        Me.Size = New System.Drawing.Size(525, 650)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents txtIdDelega As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents txtStato As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblEnte As System.Windows.Forms.Label
   Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
   Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
   Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents lblAzienda As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents lblReferente As System.Windows.Forms.Label
   Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents cboCausali As System.Windows.Forms.ComboBox
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents SpRipristina As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpVisDett As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents txtValidita As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents dtpReg As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents cboSede As System.Windows.Forms.ComboBox
   Friend WithEvents lblSedeOperativa As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblDescrizioneResponsabile As System.Windows.Forms.Label
    Friend WithEvents lblResponsabile As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
