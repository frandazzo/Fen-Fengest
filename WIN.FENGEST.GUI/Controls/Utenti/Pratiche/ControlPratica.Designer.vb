<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPratica
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdPercorso = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIdPrest = New System.Windows.Forms.TextBox()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.lblId = New System.Windows.Forms.Label()
        Me.IdUtenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblIdPrest = New System.Windows.Forms.Label()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblDurata = New System.Windows.Forms.Label()
        Me.lblDataFine = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboProvincia1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdChiusa = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRigettata = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConfermata = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdIntegrazione = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdControllo = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraticaDetailBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmdVis = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.PraticaDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DockPanel.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.NiceGroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaDetailBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.txtIdPrest)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.IdUtenteTextBox2)
        Me.DockPanel.Controls.Add(Me.lblIdPrest)
        Me.DockPanel.Controls.Add(Me.CmdVis)
        Me.DockPanel.Controls.Add(Me.cmdPercorso)
        '
        'cmdPercorso
        '
        Me.cmdPercorso.Location = New System.Drawing.Point(472, 6)
        Me.cmdPercorso.Name = "cmdPercorso"
        Me.cmdPercorso.Size = New System.Drawing.Size(154, 32)
        Me.cmdPercorso.TabIndex = 35
        Me.cmdPercorso.Text = "Visualizza percorso pratica"
        '
        'txtIdPrest
        '
        Me.txtIdPrest.Enabled = False
        Me.txtIdPrest.Location = New System.Drawing.Point(65, 13)
        Me.txtIdPrest.Name = "txtIdPrest"
        Me.txtIdPrest.Size = New System.Drawing.Size(50, 21)
        Me.txtIdPrest.TabIndex = 68
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(159, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 63
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(10, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(52, 13)
        Me.lblId.TabIndex = 64
        Me.lblId.Text = "Id utente"
        '
        'IdUtenteTextBox2
        '
        Me.IdUtenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox2.DescriptionOfText = ""
        Me.IdUtenteTextBox2.DescriptionTextWidth = 150
        Me.IdUtenteTextBox2.DescriptionTextXValue = 92
        Me.IdUtenteTextBox2.EnableSerchTextBox = True
        Me.IdUtenteTextBox2.IsDescriptionVisible = False
        Me.IdUtenteTextBox2.Location = New System.Drawing.Point(64, 13)
        Me.IdUtenteTextBox2.Mandatory = False
        Me.IdUtenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox2.Name = "IdUtenteTextBox2"
        Me.IdUtenteTextBox2.Size = New System.Drawing.Size(92, 24)
        Me.IdUtenteTextBox2.TabIndex = 65
        Me.IdUtenteTextBox2.TextValue = ""
        '
        'lblIdPrest
        '
        Me.lblIdPrest.AutoSize = True
        Me.lblIdPrest.BackColor = System.Drawing.Color.Transparent
        Me.lblIdPrest.Location = New System.Drawing.Point(34, 17)
        Me.lblIdPrest.Name = "lblIdPrest"
        Me.lblIdPrest.Size = New System.Drawing.Size(17, 13)
        Me.lblIdPrest.TabIndex = 67
        Me.lblIdPrest.Text = "Id"
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.Silver
        Me.MainGroup.Controls.Add(Me.lblDurata)
        Me.MainGroup.Controls.Add(Me.lblDataFine)
        Me.MainGroup.Controls.Add(Me.txtCode)
        Me.MainGroup.Controls.Add(Me.Label11)
        Me.MainGroup.Controls.Add(Me.Label5)
        Me.MainGroup.Controls.Add(Me.cboProvincia1)
        Me.MainGroup.Controls.Add(Me.Label6)
        Me.MainGroup.Controls.Add(Me.dtpData)
        Me.MainGroup.Controls.Add(Me.Label3)
        Me.MainGroup.Controls.Add(Me.Label4)
        Me.MainGroup.Controls.Add(Me.txtNote)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneUtente)
        Me.MainGroup.Controls.Add(Me.cboTipo)
        Me.MainGroup.Controls.Add(Me.IdUtenteTextBox1)
        Me.MainGroup.Controls.Add(Me.lblUtente)
        Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainGroup.ForeColor = System.Drawing.Color.Black
        Me.MainGroup.Location = New System.Drawing.Point(24, 93)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(429, 310)
        Me.MainGroup.TabIndex = 35
        Me.MainGroup.Text = "Dati principali"
        Me.MainGroup.Title = "Dati Pratica"
        '
        'lblDurata
        '
        Me.lblDurata.AutoSize = True
        Me.lblDurata.Location = New System.Drawing.Point(229, 71)
        Me.lblDurata.Name = "lblDurata"
        Me.lblDurata.Size = New System.Drawing.Size(89, 13)
        Me.lblDurata.TabIndex = 40
        Me.lblDurata.Text = "Durata prest.: "
        '
        'lblDataFine
        '
        Me.lblDataFine.AutoSize = True
        Me.lblDataFine.Location = New System.Drawing.Point(229, 33)
        Me.lblDataFine.Name = "lblDataFine"
        Me.lblDataFine.Size = New System.Drawing.Size(67, 13)
        Me.lblDataFine.TabIndex = 39
        Me.lblDataFine.Text = "Data fine: "
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(98, 201)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(304, 20)
        Me.txtCode.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Cod ITAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Prov. APE"
        '
        'cboProvincia1
        '
        Me.cboProvincia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia1.FormattingEnabled = True
        Me.cboProvincia1.Location = New System.Drawing.Point(97, 167)
        Me.cboProvincia1.Name = "cboProvincia1"
        Me.cboProvincia1.Size = New System.Drawing.Size(305, 21)
        Me.cboProvincia1.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Data prest."
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(97, 51)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(101, 20)
        Me.dtpData.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Note"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tipo pratica."
        '
        'txtNote
        '
        Me.txtNote.AcceptsReturn = True
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(97, 245)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(305, 46)
        Me.txtNote.TabIndex = 4
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(203, 98)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(97, 135)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(305, 21)
        Me.cboTipo.TabIndex = 5
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(97, 95)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(102, 25)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUtente.Location = New System.Drawing.Point(19, 98)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 13
        Me.lblUtente.Text = "Id utente"
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.BackColor = System.Drawing.Color.Silver
        Me.NiceGroupBox1.Controls.Add(Me.SimpleButton3)
        Me.NiceGroupBox1.Controls.Add(Me.cmdChiusa)
        Me.NiceGroupBox1.Controls.Add(Me.cmdRigettata)
        Me.NiceGroupBox1.Controls.Add(Me.cmdConfermata)
        Me.NiceGroupBox1.Controls.Add(Me.cmdIntegrazione)
        Me.NiceGroupBox1.Controls.Add(Me.cmdControllo)
        Me.NiceGroupBox1.Controls.Add(Me.Label9)
        Me.NiceGroupBox1.Controls.Add(Me.Label10)
        Me.NiceGroupBox1.Controls.Add(Me.Label8)
        Me.NiceGroupBox1.Controls.Add(Me.Label1)
        Me.NiceGroupBox1.Controls.Add(Me.Label2)
        Me.NiceGroupBox1.Controls.Add(Me.lblState)
        Me.NiceGroupBox1.Controls.Add(Me.TextBox1)
        Me.NiceGroupBox1.Controls.Add(Me.Label7)
        Me.NiceGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiceGroupBox1.ForeColor = System.Drawing.Color.Black
        Me.NiceGroupBox1.Location = New System.Drawing.Point(459, 93)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(282, 452)
        Me.NiceGroupBox1.TabIndex = 36
        Me.NiceGroupBox1.Text = "Dati principali"
        Me.NiceGroupBox1.Title = "Stato pr."
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Edit_UndoHS
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton3.Location = New System.Drawing.Point(13, 415)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(258, 26)
        Me.SimpleButton3.TabIndex = 44
        Me.SimpleButton3.Text = "Ripristina lo stato precedente"
        '
        'cmdChiusa
        '
        Me.cmdChiusa.Location = New System.Drawing.Point(13, 386)
        Me.cmdChiusa.Name = "cmdChiusa"
        Me.cmdChiusa.Size = New System.Drawing.Size(258, 26)
        Me.cmdChiusa.TabIndex = 43
        Me.cmdChiusa.Text = "Chiudi la pratica"
        '
        'cmdRigettata
        '
        Me.cmdRigettata.Location = New System.Drawing.Point(13, 354)
        Me.cmdRigettata.Name = "cmdRigettata"
        Me.cmdRigettata.Size = New System.Drawing.Size(258, 26)
        Me.cmdRigettata.TabIndex = 42
        Me.cmdRigettata.Text = "Rigetta la pratica"
        '
        'cmdConfermata
        '
        Me.cmdConfermata.Location = New System.Drawing.Point(13, 290)
        Me.cmdConfermata.Name = "cmdConfermata"
        Me.cmdConfermata.Size = New System.Drawing.Size(258, 26)
        Me.cmdConfermata.TabIndex = 41
        Me.cmdConfermata.Text = "Conferma documentazione"
        '
        'cmdIntegrazione
        '
        Me.cmdIntegrazione.Location = New System.Drawing.Point(13, 322)
        Me.cmdIntegrazione.Name = "cmdIntegrazione"
        Me.cmdIntegrazione.Size = New System.Drawing.Size(258, 26)
        Me.cmdIntegrazione.TabIndex = 40
        Me.cmdIntegrazione.Text = "Richiedi integrazione"
        '
        'cmdControllo
        '
        Me.cmdControllo.Location = New System.Drawing.Point(13, 255)
        Me.cmdControllo.Name = "cmdControllo"
        Me.cmdControllo.Size = New System.Drawing.Size(258, 29)
        Me.cmdControllo.TabIndex = 39
        Me.cmdControllo.Text = "Invia a controllo documentazione"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(87, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "pippo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "In carico a: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(87, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "pippo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Creata da: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Note aggiuntive"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(19, 24)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(191, 33)
        Me.lblState.TabIndex = 34
        Me.lblState.Text = "Stato pratica"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 143)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 106)
        Me.TextBox1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(199, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 0
        '
        'NiceGroupBox2
        '
        Me.NiceGroupBox2.BackColor = System.Drawing.Color.Silver
        Me.NiceGroupBox2.Controls.Add(Me.SimpleButton8)
        Me.NiceGroupBox2.Controls.Add(Me.SimpleButton2)
        Me.NiceGroupBox2.Controls.Add(Me.SimpleButton1)
        Me.NiceGroupBox2.Controls.Add(Me.DataGridView1)
        Me.NiceGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiceGroupBox2.ForeColor = System.Drawing.Color.Black
        Me.NiceGroupBox2.Location = New System.Drawing.Point(24, 409)
        Me.NiceGroupBox2.Name = "NiceGroupBox2"
        Me.NiceGroupBox2.Size = New System.Drawing.Size(429, 132)
        Me.NiceGroupBox2.TabIndex = 37
        Me.NiceGroupBox2.Text = "Dati principali"
        Me.NiceGroupBox2.Title = "Allegati"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.SimpleButton8.Cursor = System.Windows.Forms.Cursors.Default
        Me.SimpleButton8.Location = New System.Drawing.Point(312, 61)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(107, 26)
        Me.SimpleButton8.TabIndex = 38
        Me.SimpleButton8.Text = "Compila  documento"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(312, 93)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(107, 26)
        Me.SimpleButton2.TabIndex = 37
        Me.SimpleButton2.Text = "Rimuovi allegato"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(312, 26)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(107, 29)
        Me.SimpleButton1.TabIndex = 36
        Me.SimpleButton1.Text = "Aggiungi allegato"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn, Me.FilenameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PraticaDetailBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(7, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(299, 93)
        Me.DataGridView1.TabIndex = 0
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FilenameDataGridViewTextBoxColumn
        '
        Me.FilenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FilenameDataGridViewTextBoxColumn.DataPropertyName = "Filename"
        Me.FilenameDataGridViewTextBoxColumn.HeaderText = "File"
        Me.FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        Me.FilenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PraticaDetailBindingSource1
        '
        Me.PraticaDetailBindingSource1.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.PraticaDetail)
        '
        'CmdVis
        '
        Me.CmdVis.ApplyOutLookStile = True
        Me.CmdVis.BackColor = System.Drawing.Color.Transparent
        Me.CmdVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdVis.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_download_32x32
        Me.CmdVis.Disabled = False
        Me.CmdVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdVis.ForeColor = System.Drawing.Color.Transparent
        Me.CmdVis.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdVis.Location = New System.Drawing.Point(156, 6)
        Me.CmdVis.Name = "CmdVis"
        Me.CmdVis.Radius = 32.0!
        Me.CmdVis.ShowTooltip = True
        Me.CmdVis.Size = New System.Drawing.Size(32, 32)
        Me.CmdVis.TabIndex = 66
        Me.CmdVis.TextValue = ""
        Me.CmdVis.TooltipText = "Visualizza"
        '
        'PraticaDetailBindingSource
        '
        Me.PraticaDetailBindingSource.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.PraticaDetail)
        '
        'ControlPratica
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox2)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.MainGroup)
        Me.Name = "ControlPratica"
        Me.Size = New System.Drawing.Size(741, 548)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.NiceGroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaDetailBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPercorso As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdPrest As System.Windows.Forms.TextBox
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents IdUtenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblIdPrest As System.Windows.Forms.Label
    Friend WithEvents CmdVis As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblUtente As System.Windows.Forms.Label
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PraticaDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdChiusa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRigettata As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConfermata As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIntegrazione As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdControllo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PraticaDetailBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboProvincia1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblDurata As System.Windows.Forms.Label
    Friend WithEvents lblDataFine As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
