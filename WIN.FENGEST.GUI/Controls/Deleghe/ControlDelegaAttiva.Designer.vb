<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDelegaAttiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDelegaAttiva))
        Me.txtIdDelega = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblAzienda = New System.Windows.Forms.Label()
        Me.dtpInoltro = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.dtpAccettazione = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPagamento = New System.Windows.Forms.TextBox()
        Me.lblPagamento = New System.Windows.Forms.Label()
        Me.dtpAttivazione = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblDescrizioneResponsabile = New System.Windows.Forms.Label()
        Me.lblResponsabile = New System.Windows.Forms.Label()
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.lblSedeOperativa = New System.Windows.Forms.Label()
        Me.cboReparto = New System.Windows.Forms.ComboBox()
        Me.lblReparto = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Maingroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.cboCausaliSott = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SpCmdRevoca = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpAnnulla = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Maingroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(865, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.txtIdDelega)
        Me.DockPanel.Controls.Add(Me.SpCmdRevoca)
        Me.DockPanel.Controls.Add(Me.SpAnnulla)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(865, 44)
        '
        'txtIdDelega
        '
        Me.HelpProvider1.SetHelpString(Me.txtIdDelega, "Identificativo della delega")
        Me.txtIdDelega.Location = New System.Drawing.Point(67, 11)
        Me.txtIdDelega.Name = "txtIdDelega"
        Me.HelpProvider1.SetShowHelp(Me.txtIdDelega, True)
        Me.txtIdDelega.Size = New System.Drawing.Size(65, 21)
        Me.txtIdDelega.TabIndex = 41
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(5, 16)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 13)
        Me.lblId.TabIndex = 40
        Me.lblId.Text = "Id. delega"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.BackColor = System.Drawing.Color.Transparent
        Me.lblEnte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEnte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnte.Location = New System.Drawing.Point(13, 158)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(43, 13)
        Me.lblEnte.TabIndex = 79
        Me.lblEnte.Text = "Ente in."
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale verso cui è stata inoltrata la delega sottoscritta dall'utente. G" & _
        "li enti bilaterali sono EdilCassa e CassaEdile")
        Me.cboEnti.Location = New System.Drawing.Point(68, 155)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(121, 21)
        Me.cboEnti.TabIndex = 7
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza della delega.I settori sono EDILE e IMPIANTI FISSI")
        Me.cboSettori.Location = New System.Drawing.Point(67, 88)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(186, 21)
        Me.cboSettori.TabIndex = 6
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data documento della delega.Si ricordi che la data documento è la data in cui il " & _
        "funzionario ha fatto sottoscrivere la delega.")
        Me.dtpDoc.Location = New System.Drawing.Point(291, 27)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(97, 20)
        Me.dtpDoc.TabIndex = 2
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data di registrazione della delega. Si ricordi che la data di registrazione è la " & _
        "data in cui il funzionario registra la sottoscrizione della delega.")
        Me.dtpData.Location = New System.Drawing.Point(67, 28)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(97, 20)
        Me.dtpData.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note legate alla sottoscrizione della delega.")
        Me.txtNote.Location = New System.Drawing.Point(67, 253)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(311, 62)
        Me.txtNote.TabIndex = 5
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(158, 158)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(184, 30)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 0
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(169, 124)
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
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(68, 156)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(96, 24)
        Me.IdAziendaTextBox1.TabIndex = 8
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzienda.ForeColor = System.Drawing.Color.Black
        Me.lblAzienda.Location = New System.Drawing.Point(23, 157)
        Me.lblAzienda.Name = "lblAzienda"
        Me.lblAzienda.Size = New System.Drawing.Size(36, 13)
        Me.lblAzienda.TabIndex = 60
        Me.lblAzienda.Text = "Az. in."
        '
        'dtpInoltro
        '
        Me.dtpInoltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpInoltro, resources.GetString("dtpInoltro.HelpString"))
        Me.dtpInoltro.Location = New System.Drawing.Point(66, 23)
        Me.dtpInoltro.Name = "dtpInoltro"
        Me.HelpProvider1.SetShowHelp(Me.dtpInoltro, True)
        Me.dtpInoltro.Size = New System.Drawing.Size(115, 21)
        Me.dtpInoltro.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Inoltro"
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
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(80, 24)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(94, 23)
        Me.IdReferenteTextBox1.TabIndex = 16
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
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(66, 119)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(92, 26)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.Color.Black
        Me.lblReferente.Location = New System.Drawing.Point(32, 31)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(27, 13)
        Me.lblReferente.TabIndex = 54
        Me.lblReferente.Text = "Coll."
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.Color.Black
        Me.lblUtente.Location = New System.Drawing.Point(10, 124)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 53
        Me.lblUtente.Text = "Id utente"
        '
        'dtpAccettazione
        '
        Me.dtpAccettazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpAccettazione, resources.GetString("dtpAccettazione.HelpString"))
        Me.dtpAccettazione.Location = New System.Drawing.Point(66, 51)
        Me.dtpAccettazione.Name = "dtpAccettazione"
        Me.HelpProvider1.SetShowHelp(Me.dtpAccettazione, True)
        Me.dtpAccettazione.Size = New System.Drawing.Size(115, 21)
        Me.dtpAccettazione.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Accett."
        '
        'txtPagamento
        '
        Me.HelpProvider1.SetHelpString(Me.txtPagamento, "Documento di incasso della quota relativa a quella delega. L'incasso della quota " & _
        "relativa a quella delega ha impostato lo stato della stessa su Attivata")
        Me.txtPagamento.Location = New System.Drawing.Point(272, 78)
        Me.txtPagamento.Name = "txtPagamento"
        Me.HelpProvider1.SetShowHelp(Me.txtPagamento, True)
        Me.txtPagamento.Size = New System.Drawing.Size(77, 21)
        Me.txtPagamento.TabIndex = 11
        '
        'lblPagamento
        '
        Me.lblPagamento.AutoSize = True
        Me.lblPagamento.BackColor = System.Drawing.Color.Transparent
        Me.lblPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagamento.ForeColor = System.Drawing.Color.Black
        Me.lblPagamento.Location = New System.Drawing.Point(214, 83)
        Me.lblPagamento.Name = "lblPagamento"
        Me.lblPagamento.Size = New System.Drawing.Size(48, 13)
        Me.lblPagamento.TabIndex = 34
        Me.lblPagamento.Text = "Doc. att."
        '
        'dtpAttivazione
        '
        Me.dtpAttivazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpAttivazione, resources.GetString("dtpAttivazione.HelpString"))
        Me.dtpAttivazione.Location = New System.Drawing.Point(66, 79)
        Me.dtpAttivazione.Name = "dtpAttivazione"
        Me.HelpProvider1.SetShowHelp(Me.dtpAttivazione, True)
        Me.dtpAttivazione.Size = New System.Drawing.Size(115, 21)
        Me.dtpAttivazione.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Attiv."
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(140, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(296, 40)
        Me.CustomBar1.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.IdReferenteTextBox2)
        Me.GroupBox2.Controls.Add(Me.lblDescrizioneResponsabile)
        Me.GroupBox2.Controls.Add(Me.lblResponsabile)
        Me.GroupBox2.Controls.Add(Me.lblDescrizioneReferente)
        Me.GroupBox2.Controls.Add(Me.IdReferenteTextBox1)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 530)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 96)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.Title = "Dati collaboratore comunale"
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox2, "Identificativo del funzionario della segreteria provinciale  che è responsabile d" & _
        "ella delega")
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(79, 56)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(95, 25)
        Me.IdReferenteTextBox2.TabIndex = 57
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'lblDescrizioneResponsabile
        '
        Me.lblDescrizioneResponsabile.AutoSize = True
        Me.lblDescrizioneResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneResponsabile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneResponsabile.Location = New System.Drawing.Point(184, 60)
        Me.lblDescrizioneResponsabile.Name = "lblDescrizioneResponsabile"
        Me.lblDescrizioneResponsabile.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneResponsabile.TabIndex = 56
        '
        'lblResponsabile
        '
        Me.lblResponsabile.AutoSize = True
        Me.lblResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblResponsabile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblResponsabile.Location = New System.Drawing.Point(2, 60)
        Me.lblResponsabile.Name = "lblResponsabile"
        Me.lblResponsabile.Size = New System.Drawing.Size(71, 13)
        Me.lblResponsabile.TabIndex = 55
        Me.lblResponsabile.Text = "Responsabile"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.txtPagamento)
        Me.GroupBox3.Controls.Add(Me.lblPagamento)
        Me.GroupBox3.Controls.Add(Me.dtpAttivazione)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.dtpInoltro)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dtpAccettazione)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(11, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Title = "Inoltro, Accettazione e Attiviazione"
        '
        'cboSede
        '
        Me.cboSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSede, "Sede operativa dell'azienda presso cui il lavoratore è impiegato.Essa è indicata " & _
        "solo nel caso di delega del settore IMPIANTI FISSI")
        Me.cboSede.Location = New System.Drawing.Point(67, 221)
        Me.cboSede.Name = "cboSede"
        Me.HelpProvider1.SetShowHelp(Me.cboSede, True)
        Me.cboSede.Size = New System.Drawing.Size(177, 21)
        Me.cboSede.TabIndex = 84
        '
        'lblSedeOperativa
        '
        Me.lblSedeOperativa.AutoSize = True
        Me.lblSedeOperativa.BackColor = System.Drawing.Color.Transparent
        Me.lblSedeOperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSedeOperativa.Location = New System.Drawing.Point(11, 224)
        Me.lblSedeOperativa.Name = "lblSedeOperativa"
        Me.lblSedeOperativa.Size = New System.Drawing.Size(50, 13)
        Me.lblSedeOperativa.TabIndex = 83
        Me.lblSedeOperativa.Text = "Sede op."
        '
        'cboReparto
        '
        Me.cboReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReparto.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboReparto, "Reparto dell'azienda in cui lavora l'utente. Esso è indicato soltanto nel caso di" & _
        " delega del settore IMPIANTI FISSI")
        Me.cboReparto.Location = New System.Drawing.Point(67, 191)
        Me.cboReparto.Name = "cboReparto"
        Me.HelpProvider1.SetShowHelp(Me.cboReparto, True)
        Me.cboReparto.Size = New System.Drawing.Size(177, 21)
        Me.cboReparto.TabIndex = 12
        '
        'lblReparto
        '
        Me.lblReparto.AutoSize = True
        Me.lblReparto.BackColor = System.Drawing.Color.Transparent
        Me.lblReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReparto.Location = New System.Drawing.Point(13, 195)
        Me.lblReparto.Name = "lblReparto"
        Me.lblReparto.Size = New System.Drawing.Size(45, 13)
        Me.lblReparto.TabIndex = 82
        Me.lblReparto.Text = "Reparto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Settore"
        '
        'Maingroup
        '
        Me.Maingroup.BackColor = System.Drawing.Color.Silver
        Me.Maingroup.Controls.Add(Me.cboSede)
        Me.Maingroup.Controls.Add(Me.lblSedeOperativa)
        Me.Maingroup.Controls.Add(Me.cboCausaliSott)
        Me.Maingroup.Controls.Add(Me.cboReparto)
        Me.Maingroup.Controls.Add(Me.Label1)
        Me.Maingroup.Controls.Add(Me.lblReparto)
        Me.Maingroup.Controls.Add(Me.Label20)
        Me.Maingroup.Controls.Add(Me.Label21)
        Me.Maingroup.Controls.Add(Me.dtpDoc)
        Me.Maingroup.Controls.Add(Me.dtpData)
        Me.Maingroup.Controls.Add(Me.Label12)
        Me.Maingroup.Controls.Add(Me.IdUtenteTextBox1)
        Me.Maingroup.Controls.Add(Me.lblEnte)
        Me.Maingroup.Controls.Add(Me.lblDescrizioneUtente)
        Me.Maingroup.Controls.Add(Me.cboEnti)
        Me.Maingroup.Controls.Add(Me.lblDescrizioneAzienda)
        Me.Maingroup.Controls.Add(Me.lblUtente)
        Me.Maingroup.Controls.Add(Me.txtNote)
        Me.Maingroup.Controls.Add(Me.IdAziendaTextBox1)
        Me.Maingroup.Controls.Add(Me.cboSettori)
        Me.Maingroup.Controls.Add(Me.Label3)
        Me.Maingroup.Controls.Add(Me.lblAzienda)
        Me.Maingroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maingroup.ForeColor = System.Drawing.Color.Black
        Me.Maingroup.Location = New System.Drawing.Point(11, 72)
        Me.Maingroup.Name = "Maingroup"
        Me.Maingroup.Size = New System.Drawing.Size(425, 331)
        Me.Maingroup.TabIndex = 1
        Me.Maingroup.Text = "Dati principali"
        Me.Maingroup.Title = "Dati Generali"
        '
        'cboCausaliSott
        '
        Me.cboCausaliSott.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCausaliSott.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausaliSott.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausaliSott, "Causale di sottoscrizione della delega. Le causali possono essere impostate dal M" & _
        "enu Strumenti->Setup->Segreteria->Causali deleghe.")
        Me.cboCausaliSott.Location = New System.Drawing.Point(67, 57)
        Me.cboCausaliSott.Name = "cboCausaliSott"
        Me.HelpProvider1.SetShowHelp(Me.cboCausaliSott, True)
        Me.cboCausaliSott.Size = New System.Drawing.Size(186, 21)
        Me.cboCausaliSott.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Caus. sott."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(9, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Data reg."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(234, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Data doc."
        '
        'SpCmdRevoca
        '
        Me.SpCmdRevoca.ApplyOutLookStile = True
        Me.SpCmdRevoca.BackColor = System.Drawing.Color.Transparent
        Me.SpCmdRevoca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdRevoca.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.trashcan_full_32x32
        Me.SpCmdRevoca.Disabled = False
        Me.SpCmdRevoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpCmdRevoca.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpCmdRevoca, resources.GetString("SpCmdRevoca.HelpString"))
        Me.SpCmdRevoca.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdRevoca.Location = New System.Drawing.Point(483, 7)
        Me.SpCmdRevoca.Name = "SpCmdRevoca"
        Me.SpCmdRevoca.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpCmdRevoca, True)
        Me.SpCmdRevoca.ShowTooltip = True
        Me.SpCmdRevoca.Size = New System.Drawing.Size(32, 32)
        Me.SpCmdRevoca.TabIndex = 5
        Me.SpCmdRevoca.TextValue = ""
        Me.SpCmdRevoca.TooltipText = "Revoca delega"
        '
        'SpAnnulla
        '
        Me.SpAnnulla.ApplyOutLookStile = True
        Me.SpAnnulla.BackColor = System.Drawing.Color.Transparent
        Me.SpAnnulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpAnnulla.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.trashcan_empty_32x32
        Me.SpAnnulla.Disabled = False
        Me.SpAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpAnnulla.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpAnnulla, resources.GetString("SpAnnulla.HelpString"))
        Me.SpAnnulla.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpAnnulla.Location = New System.Drawing.Point(442, 7)
        Me.SpAnnulla.Name = "SpAnnulla"
        Me.SpAnnulla.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpAnnulla, True)
        Me.SpAnnulla.ShowTooltip = True
        Me.SpAnnulla.Size = New System.Drawing.Size(32, 32)
        Me.SpAnnulla.TabIndex = 4
        Me.SpAnnulla.TextValue = ""
        Me.SpAnnulla.TooltipText = "Annulla  delega"
        '
        'ControlDelegaAttiva
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Maingroup)
        Me.Name = "ControlDelegaAttiva"
        Me.Size = New System.Drawing.Size(865, 638)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Maingroup, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Maingroup.ResumeLayout(False)
        Me.Maingroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdDelega As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtPagamento As System.Windows.Forms.TextBox
    Friend WithEvents lblPagamento As System.Windows.Forms.Label
    Friend WithEvents dtpAttivazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents lblAzienda As System.Windows.Forms.Label
    Friend WithEvents dtpInoltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents lblUtente As System.Windows.Forms.Label
    Friend WithEvents dtpAccettazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents lblEnte As System.Windows.Forms.Label
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents SpCmdRevoca As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpAnnulla As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Maingroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents cboCausaliSott As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboReparto As System.Windows.Forms.ComboBox
   Friend WithEvents lblReparto As System.Windows.Forms.Label
   Friend WithEvents cboSede As System.Windows.Forms.ComboBox
   Friend WithEvents lblSedeOperativa As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblDescrizioneResponsabile As System.Windows.Forms.Label
    Friend WithEvents lblResponsabile As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
