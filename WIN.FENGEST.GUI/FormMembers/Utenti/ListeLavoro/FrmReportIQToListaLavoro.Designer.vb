<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportIQToListaLavoro
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportIQToListaLavoro))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.chkIQP = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label
        Me.IdAziendaTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.optYes = New System.Windows.Forms.RadioButton
        Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.optNo = New System.Windows.Forms.RadioButton
        Me.cboEnti = New System.Windows.Forms.ComboBox
        Me.optAll = New System.Windows.Forms.RadioButton
        Me.cmdUt = New System.Windows.Forms.Button
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboContratti = New System.Windows.Forms.ComboBox
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker
        Me.cboSettori = New System.Windows.Forms.ComboBox
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSettore = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkReg = New System.Windows.Forms.CheckBox
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
        Me.chkDoc = New System.Windows.Forms.CheckBox
        Me.chkSogg = New System.Windows.Forms.CheckBox
        Me.lblSogg = New System.Windows.Forms.Label
        Me.chkComp = New System.Windows.Forms.CheckBox
        Me.chkIQV = New System.Windows.Forms.CheckBox
        Me.chkIQA = New System.Windows.Forms.CheckBox
        Me.chkIQI = New System.Windows.Forms.CheckBox
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSoggettoEsecutore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAziendaImpiego = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompetenza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodiceFiscale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContrattoApplicato = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocumentoPadre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImportoRistorno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLivelloInquadramento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOreLavorate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOreMalattia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamentoReferente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuattordicesima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoPrestazione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTredicesima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.NiceGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(696, 610)
        Me.SplitContainer1.SplitterDistance = 403
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 403)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoScroll = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.chkIQP)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.chkIQV)
        Me.GroupBox1.Controls.Add(Me.chkIQA)
        Me.GroupBox1.Controls.Add(Me.chkIQI)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 403)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.Text = "Selezione tipo quote"
        Me.GroupBox1.Title = "Selezione"
        '
        'chkIQP
        '
        Me.chkIQP.AutoSize = True
        Me.chkIQP.BackColor = System.Drawing.Color.Transparent
        Me.chkIQP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIQP.Location = New System.Drawing.Point(480, 27)
        Me.chkIQP.Name = "chkIQP"
        Me.chkIQP.Size = New System.Drawing.Size(144, 17)
        Me.chkIQP.TabIndex = 97
        Me.chkIQP.Text = "Incassi quote previsionali"
        Me.chkIQP.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.lblDescrizioneReferente)
        Me.Panel3.Controls.Add(Me.IdAziendaTextBox2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.IdReferenteTextBox1)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.optYes)
        Me.Panel3.Controls.Add(Me.ControlSelPeriodiMensili1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.optNo)
        Me.Panel3.Controls.Add(Me.cboEnti)
        Me.Panel3.Controls.Add(Me.optAll)
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
        Me.Panel3.Location = New System.Drawing.Point(11, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(676, 346)
        Me.Panel3.TabIndex = 95
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Anag
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(508, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 42)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "&Visualizza"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(215, 318)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(14, 13)
        Me.lblDescrizioneReferente.TabIndex = 5
        Me.lblDescrizioneReferente.Text = "*"
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
        Me.IdAziendaTextBox2.Location = New System.Drawing.Point(84, 197)
        Me.IdAziendaTextBox2.Mandatory = False
        Me.IdAziendaTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox2.Name = "IdAziendaTextBox2"
        Me.IdAziendaTextBox2.Size = New System.Drawing.Size(460, 20)
        Me.IdAziendaTextBox2.TabIndex = 97
        Me.IdAziendaTextBox2.TextValue = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 261)
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
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(109, 311)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(98, 26)
        Me.IdReferenteTextBox1.TabIndex = 4
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Id az. impiego"
        '
        'optYes
        '
        Me.optYes.AutoSize = True
        Me.optYes.BackColor = System.Drawing.Color.Transparent
        Me.optYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optYes.Location = New System.Drawing.Point(47, 282)
        Me.optYes.Name = "optYes"
        Me.optYes.Size = New System.Drawing.Size(112, 17)
        Me.optYes.TabIndex = 0
        Me.optYes.Text = "Posizioni ristornate"
        Me.optYes.UseVisualStyleBackColor = False
        '
        'ControlSelPeriodiMensili1
        '
        Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
        Me.ControlSelPeriodiMensili1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(46, 95)
        Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
        Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(387, 33)
        Me.ControlSelPeriodiMensili1.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id coll."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Selezione avanzata"
        '
        'optNo
        '
        Me.optNo.AutoSize = True
        Me.optNo.BackColor = System.Drawing.Color.Transparent
        Me.optNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNo.Location = New System.Drawing.Point(168, 282)
        Me.optNo.Name = "optNo"
        Me.optNo.Size = New System.Drawing.Size(133, 17)
        Me.optNo.TabIndex = 1
        Me.optNo.Text = "Posizioni non ristornate"
        Me.optNo.UseVisualStyleBackColor = False
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.cboEnti.Location = New System.Drawing.Point(84, 166)
        Me.cboEnti.Name = "cboEnti"
        Me.cboEnti.Size = New System.Drawing.Size(169, 21)
        Me.cboEnti.TabIndex = 85
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Checked = True
        Me.optAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll.Location = New System.Drawing.Point(315, 282)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(50, 17)
        Me.optAll.TabIndex = 2
        Me.optAll.TabStop = True
        Me.optAll.Text = "Tutto"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'cmdUt
        '
        Me.cmdUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(144, 7)
        Me.cmdUt.Name = "cmdUt"
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
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(83, 166)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(92, 26)
        Me.IdAziendaTextBox1.TabIndex = 86
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "a"
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(269, 173)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(14, 13)
        Me.lblDescrizioneAzienda.TabIndex = 83
        Me.lblDescrizioneAzienda.Text = "*"
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(84, 68)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(139, 20)
        Me.dtpDocDa.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Id sogg. esec."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Da"
        '
        'cboContratti
        '
        Me.cboContratti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContratti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContratti.FormattingEnabled = True
        Me.cboContratti.Location = New System.Drawing.Point(83, 228)
        Me.cboContratti.Name = "cboContratti"
        Me.cboContratti.Size = New System.Drawing.Size(169, 21)
        Me.cboContratti.TabIndex = 78
        '
        'dtpDocA
        '
        Me.dtpDocA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(284, 68)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(142, 20)
        Me.dtpDocA.TabIndex = 64
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.cboSettori.Location = New System.Drawing.Point(84, 137)
        Me.cboSettori.Name = "cboSettori"
        Me.cboSettori.Size = New System.Drawing.Size(169, 21)
        Me.cboSettori.TabIndex = 79
        '
        'dtpRegA
        '
        Me.dtpRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(284, 38)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(142, 20)
        Me.dtpRegA.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Contr. app."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Da"
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(40, 141)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 80
        Me.lblSettore.Text = "Settore"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(253, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "a"
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.chkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReg.Location = New System.Drawing.Point(439, 40)
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
        Me.dtpRegDa.Location = New System.Drawing.Point(84, 38)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(139, 20)
        Me.dtpRegDa.TabIndex = 60
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.chkDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDoc.Location = New System.Drawing.Point(439, 70)
        Me.chkDoc.Name = "chkDoc"
        Me.chkDoc.Size = New System.Drawing.Size(120, 17)
        Me.chkDoc.TabIndex = 62
        Me.chkDoc.Text = "Selezione data doc."
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'chkSogg
        '
        Me.chkSogg.AutoSize = True
        Me.chkSogg.BackColor = System.Drawing.Color.Transparent
        Me.chkSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSogg.Location = New System.Drawing.Point(229, 11)
        Me.chkSogg.Name = "chkSogg"
        Me.chkSogg.Size = New System.Drawing.Size(101, 17)
        Me.chkSogg.TabIndex = 68
        Me.chkSogg.Text = "Selezione utenti"
        Me.chkSogg.UseVisualStyleBackColor = False
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.BackColor = System.Drawing.Color.Transparent
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(343, 13)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 76
        '
        'chkComp
        '
        Me.chkComp.AutoSize = True
        Me.chkComp.BackColor = System.Drawing.Color.Transparent
        Me.chkComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComp.Location = New System.Drawing.Point(439, 101)
        Me.chkComp.Name = "chkComp"
        Me.chkComp.Size = New System.Drawing.Size(136, 17)
        Me.chkComp.TabIndex = 65
        Me.chkComp.Text = "Selezione  competenza"
        Me.chkComp.UseVisualStyleBackColor = False
        '
        'chkIQV
        '
        Me.chkIQV.AutoSize = True
        Me.chkIQV.BackColor = System.Drawing.Color.Transparent
        Me.chkIQV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIQV.Location = New System.Drawing.Point(327, 27)
        Me.chkIQV.Name = "chkIQV"
        Me.chkIQV.Size = New System.Drawing.Size(133, 17)
        Me.chkIQV.TabIndex = 11
        Me.chkIQV.Text = "Incassi quote vertenza"
        Me.chkIQV.UseVisualStyleBackColor = False
        '
        'chkIQA
        '
        Me.chkIQA.AutoSize = True
        Me.chkIQA.BackColor = System.Drawing.Color.Transparent
        Me.chkIQA.Checked = True
        Me.chkIQA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIQA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIQA.Location = New System.Drawing.Point(16, 27)
        Me.chkIQA.Name = "chkIQA"
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
        Me.chkIQI.Location = New System.Drawing.Point(186, 27)
        Me.chkIQI.Name = "chkIQI"
        Me.chkIQI.Size = New System.Drawing.Size(112, 17)
        Me.chkIQI.TabIndex = 10
        Me.chkIQI.Text = "Incassi quote Inps"
        Me.chkIQI.UseVisualStyleBackColor = False
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.GridPosizioni)
        Me.NiceGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(696, 203)
        Me.NiceGroupBox1.TabIndex = 110
        Me.NiceGroupBox1.Title = "Dati selezionati"
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Location = New System.Drawing.Point(483, 616)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(91, 25)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "&Crea lista lavoro"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnulla.Location = New System.Drawing.Point(580, 616)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(91, 25)
        Me.cmdAnnulla.TabIndex = 2
        Me.cmdAnnulla.Text = "&Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPosizioni.Location = New System.Drawing.Point(0, 0)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(696, 203)
        Me.GridPosizioni.TabIndex = 111
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colTipoDocumento, Me.colSoggettoEsecutore, Me.colAziendaImpiego, Me.colImporto, Me.colSettore, Me.colCompetenza, Me.colCodiceFiscale, Me.colContrattoApplicato, Me.colDataRegistrazione, Me.colDocumentoPadre, Me.colImportoRistorno, Me.colLivelloInquadramento, Me.colNote, Me.colOreLavorate, Me.colOreMalattia, Me.colPagamentoReferente, Me.colQuattordicesima, Me.colReferente, Me.colSedeOperativa, Me.colTipoPrestazione, Me.colTredicesima})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colUtente
        '
        Me.colUtente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colUtente.AppearanceCell.Options.UseFont = True
        Me.colUtente.Caption = "Utente"
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 0
        '
        'colTipoDocumento
        '
        Me.colTipoDocumento.Caption = "Tipo documento"
        Me.colTipoDocumento.FieldName = "TipoDocumento"
        Me.colTipoDocumento.Name = "colTipoDocumento"
        Me.colTipoDocumento.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colTipoDocumento.Visible = True
        Me.colTipoDocumento.VisibleIndex = 1
        '
        'colSoggettoEsecutore
        '
        Me.colSoggettoEsecutore.Caption = "Soggetto  Esecutore"
        Me.colSoggettoEsecutore.FieldName = "SoggettoEsecutore"
        Me.colSoggettoEsecutore.Name = "colSoggettoEsecutore"
        Me.colSoggettoEsecutore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSoggettoEsecutore.Visible = True
        Me.colSoggettoEsecutore.VisibleIndex = 2
        '
        'colAziendaImpiego
        '
        Me.colAziendaImpiego.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAziendaImpiego.AppearanceCell.Options.UseFont = True
        Me.colAziendaImpiego.Caption = "Azienda di impiego"
        Me.colAziendaImpiego.FieldName = "AziendaImpiego"
        Me.colAziendaImpiego.Name = "colAziendaImpiego"
        Me.colAziendaImpiego.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAziendaImpiego.Visible = True
        Me.colAziendaImpiego.VisibleIndex = 3
        '
        'colImporto
        '
        Me.colImporto.DisplayFormat.FormatString = "c"
        Me.colImporto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporto.FieldName = "Importo"
        Me.colImporto.Name = "colImporto"
        Me.colImporto.Visible = True
        Me.colImporto.VisibleIndex = 4
        '
        'colSettore
        '
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        Me.colSettore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCompetenza
        '
        Me.colCompetenza.FieldName = "Competenza"
        Me.colCompetenza.Name = "colCompetenza"
        '
        'colCodiceFiscale
        '
        Me.colCodiceFiscale.FieldName = "CodiceFiscale"
        Me.colCodiceFiscale.Name = "colCodiceFiscale"
        '
        'colContrattoApplicato
        '
        Me.colContrattoApplicato.FieldName = "ContrattoApplicato"
        Me.colContrattoApplicato.Name = "colContrattoApplicato"
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        Me.colDataRegistrazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDocumentoPadre
        '
        Me.colDocumentoPadre.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDocumentoPadre.AppearanceCell.Options.UseFont = True
        Me.colDocumentoPadre.FieldName = "DocumentoPadre"
        Me.colDocumentoPadre.Name = "colDocumentoPadre"
        Me.colDocumentoPadre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colImportoRistorno
        '
        Me.colImportoRistorno.DisplayFormat.FormatString = "c"
        Me.colImportoRistorno.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImportoRistorno.FieldName = "ImportoRistorno"
        Me.colImportoRistorno.Name = "colImportoRistorno"
        '
        'colLivelloInquadramento
        '
        Me.colLivelloInquadramento.FieldName = "LivelloInquadramento"
        Me.colLivelloInquadramento.Name = "colLivelloInquadramento"
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colOreLavorate
        '
        Me.colOreLavorate.FieldName = "OreLavorate"
        Me.colOreLavorate.Name = "colOreLavorate"
        '
        'colOreMalattia
        '
        Me.colOreMalattia.FieldName = "OreMalattia"
        Me.colOreMalattia.Name = "colOreMalattia"
        '
        'colPagamentoReferente
        '
        Me.colPagamentoReferente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPagamentoReferente.AppearanceCell.Options.UseFont = True
        Me.colPagamentoReferente.FieldName = "PagamentoReferente"
        Me.colPagamentoReferente.Name = "colPagamentoReferente"
        Me.colPagamentoReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colQuattordicesima
        '
        Me.colQuattordicesima.FieldName = "Quattordicesima"
        Me.colQuattordicesima.Name = "colQuattordicesima"
        '
        'colReferente
        '
        Me.colReferente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colReferente.AppearanceCell.Options.UseFont = True
        Me.colReferente.Caption = "Collaboratore"
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        '
        'colSedeOperativa
        '
        Me.colSedeOperativa.FieldName = "SedeOperativa"
        Me.colSedeOperativa.Name = "colSedeOperativa"
        '
        'colTipoPrestazione
        '
        Me.colTipoPrestazione.FieldName = "TipoPrestazione"
        Me.colTipoPrestazione.Name = "colTipoPrestazione"
        '
        'colTredicesima
        '
        Me.colTredicesima.FieldName = "Tredicesima"
        Me.colTredicesima.Name = "colTredicesima"
        '
        'FrmReportIQToListaLavoro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 649)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportIQToListaLavoro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selezione incassi quote"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents chkIQP As System.Windows.Forms.CheckBox
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents optYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optNo As System.Windows.Forms.RadioButton
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents IdAziendaTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents cmdUt As System.Windows.Forms.Button
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboContratti As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkSogg As System.Windows.Forms.CheckBox
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents chkComp As System.Windows.Forms.CheckBox
    Friend WithEvents chkIQV As System.Windows.Forms.CheckBox
    Friend WithEvents chkIQA As System.Windows.Forms.CheckBox
    Friend WithEvents chkIQI As System.Windows.Forms.CheckBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoggettoEsecutore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAziendaImpiego As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompetenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodiceFiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrattoApplicato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportoRistorno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLivelloInquadramento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreLavorate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreMalattia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamentoReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuattordicesima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPrestazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTredicesima As DevExpress.XtraGrid.Columns.GridColumn
End Class
