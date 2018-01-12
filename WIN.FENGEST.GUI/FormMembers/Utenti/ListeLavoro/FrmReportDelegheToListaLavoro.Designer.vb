<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportDelegheToListaLavoro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportDelegheToListaLavoro))
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblCons = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label
        Me.chkSelDataRev = New System.Windows.Forms.CheckBox
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
        Me.cboEnti = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCaus = New System.Windows.Forms.ComboBox
        Me.dtpInA = New System.Windows.Forms.DateTimePicker
        Me.cmdUt = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.chkReg = New System.Windows.Forms.CheckBox
        Me.chkInoltrata = New System.Windows.Forms.CheckBox
        Me.cboReparto = New System.Windows.Forms.ComboBox
        Me.dtpRevA = New System.Windows.Forms.DateTimePicker
        Me.chkDoc = New System.Windows.Forms.CheckBox
        Me.chkSottoscritta = New System.Windows.Forms.CheckBox
        Me.dtpRevDa = New System.Windows.Forms.DateTimePicker
        Me.chkSogg = New System.Windows.Forms.CheckBox
        Me.chkAttivata = New System.Windows.Forms.CheckBox
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
        Me.chkSelDataAtt = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.chkAccettata = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkSelDataAnn = New System.Windows.Forms.CheckBox
        Me.lblSettore = New System.Windows.Forms.Label
        Me.chkRevocata = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpAttDa = New System.Windows.Forms.DateTimePicker
        Me.cboContratti = New System.Windows.Forms.ComboBox
        Me.chkAnnullata = New System.Windows.Forms.CheckBox
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboSettori = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpAccDa = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpAttA = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
        Me.dtpAnnA = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpAccA = New System.Windows.Forms.DateTimePicker
        Me.chkSelDataAcc = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkSelDataInoltro = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpInDa = New System.Windows.Forms.DateTimePicker
        Me.dtpAnnDa = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSogg = New System.Windows.Forms.Label
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEnteInoltro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatoDelega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCausaleSottoscrizione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCausaleFineCiclo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataInoltro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataAccettazioneDelega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataDecorrenzaDelega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataAnnullamentoDelega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataRevocaDelega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReparto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResponsabile = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContratto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodice_Fiscale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome_Nazione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome_Provincia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome_Comune = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCellulare1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCellulare2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnulla.Location = New System.Drawing.Point(647, 629)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(91, 25)
        Me.cmdAnnulla.TabIndex = 5
        Me.cmdAnnulla.Text = "&Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Location = New System.Drawing.Point(550, 629)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(91, 25)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "&Crea lista lavoro"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 2)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(750, 621)
        Me.SplitContainer1.SplitterDistance = 454
        Me.SplitContainer1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 454)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoScroll = True
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.lblSogg)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 454)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.Text = "Selezione criteri documenti"
        Me.GroupBox3.Title = "Dati di selezione"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.lblCons)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.lblDescrizioneReferente)
        Me.Panel4.Controls.Add(Me.chkSelDataRev)
        Me.Panel4.Controls.Add(Me.IdReferenteTextBox2)
        Me.Panel4.Controls.Add(Me.cboEnti)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.IdReferenteTextBox1)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.cboCaus)
        Me.Panel4.Controls.Add(Me.dtpInA)
        Me.Panel4.Controls.Add(Me.cmdUt)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.chkReg)
        Me.Panel4.Controls.Add(Me.chkInoltrata)
        Me.Panel4.Controls.Add(Me.cboReparto)
        Me.Panel4.Controls.Add(Me.dtpRevA)
        Me.Panel4.Controls.Add(Me.chkDoc)
        Me.Panel4.Controls.Add(Me.chkSottoscritta)
        Me.Panel4.Controls.Add(Me.dtpRevDa)
        Me.Panel4.Controls.Add(Me.chkSogg)
        Me.Panel4.Controls.Add(Me.chkAttivata)
        Me.Panel4.Controls.Add(Me.dtpRegDa)
        Me.Panel4.Controls.Add(Me.chkSelDataAtt)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.chkAccettata)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.chkSelDataAnn)
        Me.Panel4.Controls.Add(Me.lblSettore)
        Me.Panel4.Controls.Add(Me.chkRevocata)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.dtpAttDa)
        Me.Panel4.Controls.Add(Me.cboContratti)
        Me.Panel4.Controls.Add(Me.chkAnnullata)
        Me.Panel4.Controls.Add(Me.dtpRegA)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.cboSettori)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.dtpDocA)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.dtpAccDa)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.dtpAttA)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.dtpDocDa)
        Me.Panel4.Controls.Add(Me.dtpAnnA)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.dtpAccA)
        Me.Panel4.Controls.Add(Me.chkSelDataAcc)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.chkSelDataInoltro)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.dtpInDa)
        Me.Panel4.Controls.Add(Me.dtpAnnDa)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(16, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(721, 428)
        Me.Panel4.TabIndex = 97
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Anag
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(569, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 42)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Visualizza"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCons
        '
        Me.lblCons.AutoSize = True
        Me.lblCons.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCons.Location = New System.Drawing.Point(284, 396)
        Me.lblCons.Name = "lblCons"
        Me.lblCons.Size = New System.Drawing.Size(0, 13)
        Me.lblCons.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(230, 166)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 13)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Selezione stato delega"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 345)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 13)
        Me.Label23.TabIndex = 94
        Me.Label23.Text = "Selezione collaboratori"
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(284, 371)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 4
        '
        'chkSelDataRev
        '
        Me.chkSelDataRev.AutoSize = True
        Me.chkSelDataRev.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataRev.Location = New System.Drawing.Point(393, 314)
        Me.chkSelDataRev.Name = "chkSelDataRev"
        Me.chkSelDataRev.Size = New System.Drawing.Size(132, 17)
        Me.chkSelDataRev.TabIndex = 94
        Me.chkSelDataRev.Text = "Selezione data revoca"
        Me.chkSelDataRev.UseVisualStyleBackColor = False
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(174, 394)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(110, 20)
        Me.IdReferenteTextBox2.TabIndex = 3
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.cboEnti.Location = New System.Drawing.Point(60, 95)
        Me.cboEnti.Name = "cboEnti"
        Me.cboEnti.Size = New System.Drawing.Size(169, 21)
        Me.cboEnti.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Coolaboratore comunale"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 103)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Ente"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(174, 365)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(110, 24)
        Me.IdReferenteTextBox1.TabIndex = 2
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(267, 320)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Responsabile"
        '
        'cboCaus
        '
        Me.cboCaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaus.FormattingEnabled = True
        Me.cboCaus.Location = New System.Drawing.Point(327, 66)
        Me.cboCaus.Name = "cboCaus"
        Me.cboCaus.Size = New System.Drawing.Size(211, 21)
        Me.cboCaus.TabIndex = 81
        '
        'dtpInA
        '
        Me.dtpInA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInA.Location = New System.Drawing.Point(289, 190)
        Me.dtpInA.Name = "dtpInA"
        Me.dtpInA.Size = New System.Drawing.Size(89, 20)
        Me.dtpInA.TabIndex = 76
        '
        'cmdUt
        '
        Me.cmdUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(60, 126)
        Me.cmdUt.Name = "cmdUt"
        Me.cmdUt.Size = New System.Drawing.Size(79, 25)
        Me.cmdUt.TabIndex = 69
        Me.cmdUt.Text = "Seleziona"
        Me.cmdUt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUt.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(121, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Da"
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.chkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReg.Location = New System.Drawing.Point(350, 11)
        Me.chkReg.Name = "chkReg"
        Me.chkReg.Size = New System.Drawing.Size(117, 17)
        Me.chkReg.TabIndex = 59
        Me.chkReg.Text = "Selezione data reg."
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'chkInoltrata
        '
        Me.chkInoltrata.AutoSize = True
        Me.chkInoltrata.BackColor = System.Drawing.Color.Transparent
        Me.chkInoltrata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInoltrata.Location = New System.Drawing.Point(28, 193)
        Me.chkInoltrata.Name = "chkInoltrata"
        Me.chkInoltrata.Size = New System.Drawing.Size(64, 17)
        Me.chkInoltrata.TabIndex = 64
        Me.chkInoltrata.Text = "Inoltrata"
        Me.chkInoltrata.UseVisualStyleBackColor = False
        '
        'cboReparto
        '
        Me.cboReparto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReparto.FormattingEnabled = True
        Me.cboReparto.Location = New System.Drawing.Point(327, 124)
        Me.cboReparto.Name = "cboReparto"
        Me.cboReparto.Size = New System.Drawing.Size(211, 21)
        Me.cboReparto.TabIndex = 85
        '
        'dtpRevA
        '
        Me.dtpRevA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRevA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRevA.Location = New System.Drawing.Point(289, 314)
        Me.dtpRevA.Name = "dtpRevA"
        Me.dtpRevA.Size = New System.Drawing.Size(89, 20)
        Me.dtpRevA.TabIndex = 96
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.chkDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDoc.Location = New System.Drawing.Point(350, 38)
        Me.chkDoc.Name = "chkDoc"
        Me.chkDoc.Size = New System.Drawing.Size(120, 17)
        Me.chkDoc.TabIndex = 62
        Me.chkDoc.Text = "Selezione data doc."
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'chkSottoscritta
        '
        Me.chkSottoscritta.AutoSize = True
        Me.chkSottoscritta.BackColor = System.Drawing.Color.Transparent
        Me.chkSottoscritta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSottoscritta.Location = New System.Drawing.Point(28, 162)
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
        Me.dtpRevDa.Location = New System.Drawing.Point(156, 314)
        Me.dtpRevDa.Name = "dtpRevDa"
        Me.dtpRevDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpRevDa.TabIndex = 95
        '
        'chkSogg
        '
        Me.chkSogg.AutoSize = True
        Me.chkSogg.BackColor = System.Drawing.Color.Transparent
        Me.chkSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSogg.Location = New System.Drawing.Point(143, 130)
        Me.chkSogg.Name = "chkSogg"
        Me.chkSogg.Size = New System.Drawing.Size(112, 17)
        Me.chkSogg.TabIndex = 68
        Me.chkSogg.Text = "Selezione aziende"
        Me.chkSogg.UseVisualStyleBackColor = False
        '
        'chkAttivata
        '
        Me.chkAttivata.AutoSize = True
        Me.chkAttivata.BackColor = System.Drawing.Color.Transparent
        Me.chkAttivata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAttivata.Location = New System.Drawing.Point(28, 257)
        Me.chkAttivata.Name = "chkAttivata"
        Me.chkAttivata.Size = New System.Drawing.Size(62, 17)
        Me.chkAttivata.TabIndex = 66
        Me.chkAttivata.Text = "Attivata"
        Me.chkAttivata.UseVisualStyleBackColor = False
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(59, 9)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(95, 20)
        Me.dtpRegDa.TabIndex = 60
        '
        'chkSelDataAtt
        '
        Me.chkSelDataAtt.AutoSize = True
        Me.chkSelDataAtt.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataAtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataAtt.Location = New System.Drawing.Point(393, 252)
        Me.chkSelDataAtt.Name = "chkSelDataAtt"
        Me.chkSelDataAtt.Size = New System.Drawing.Size(150, 17)
        Me.chkSelDataAtt.TabIndex = 84
        Me.chkSelDataAtt.Text = "Selezione data attivazione"
        Me.chkSelDataAtt.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(271, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 86
        Me.Label19.Text = "Reparto"
        '
        'chkAccettata
        '
        Me.chkAccettata.AutoSize = True
        Me.chkAccettata.BackColor = System.Drawing.Color.Transparent
        Me.chkAccettata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccettata.Location = New System.Drawing.Point(28, 224)
        Me.chkAccettata.Name = "chkAccettata"
        Me.chkAccettata.Size = New System.Drawing.Size(72, 17)
        Me.chkAccettata.TabIndex = 65
        Me.chkAccettata.Text = "Accettata"
        Me.chkAccettata.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(164, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "a"
        '
        'chkSelDataAnn
        '
        Me.chkSelDataAnn.AutoSize = True
        Me.chkSelDataAnn.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataAnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataAnn.Location = New System.Drawing.Point(393, 283)
        Me.chkSelDataAnn.Name = "chkSelDataAnn"
        Me.chkSelDataAnn.Size = New System.Drawing.Size(162, 17)
        Me.chkSelDataAnn.TabIndex = 87
        Me.chkSelDataAnn.Text = "Selezione data annullamento"
        Me.chkSelDataAnn.UseVisualStyleBackColor = False
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(16, 71)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 80
        Me.lblSettore.Text = "Settore"
        '
        'chkRevocata
        '
        Me.chkRevocata.AutoSize = True
        Me.chkRevocata.BackColor = System.Drawing.Color.Transparent
        Me.chkRevocata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevocata.Location = New System.Drawing.Point(28, 320)
        Me.chkRevocata.Name = "chkRevocata"
        Me.chkRevocata.Size = New System.Drawing.Size(73, 17)
        Me.chkRevocata.TabIndex = 68
        Me.chkRevocata.Text = "Revocata"
        Me.chkRevocata.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Da"
        '
        'dtpAttDa
        '
        Me.dtpAttDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAttDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAttDa.Location = New System.Drawing.Point(156, 252)
        Me.dtpAttDa.Name = "dtpAttDa"
        Me.dtpAttDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpAttDa.TabIndex = 85
        '
        'cboContratti
        '
        Me.cboContratti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContratti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContratti.FormattingEnabled = True
        Me.cboContratti.Location = New System.Drawing.Point(327, 95)
        Me.cboContratti.Name = "cboContratti"
        Me.cboContratti.Size = New System.Drawing.Size(211, 21)
        Me.cboContratti.TabIndex = 83
        '
        'chkAnnullata
        '
        Me.chkAnnullata.AutoSize = True
        Me.chkAnnullata.BackColor = System.Drawing.Color.Transparent
        Me.chkAnnullata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnnullata.Location = New System.Drawing.Point(28, 287)
        Me.chkAnnullata.Name = "chkAnnullata"
        Me.chkAnnullata.Size = New System.Drawing.Size(70, 17)
        Me.chkAnnullata.TabIndex = 67
        Me.chkAnnullata.Text = "Annullata"
        Me.chkAnnullata.UseVisualStyleBackColor = False
        '
        'dtpRegA
        '
        Me.dtpRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(195, 9)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(90, 20)
        Me.dtpRegA.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(267, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "a"
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.cboSettori.Location = New System.Drawing.Point(60, 66)
        Me.cboSettori.Name = "cboSettori"
        Me.cboSettori.Size = New System.Drawing.Size(169, 21)
        Me.cboSettori.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "a"
        '
        'dtpDocA
        '
        Me.dtpDocA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(195, 36)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(90, 20)
        Me.dtpDocA.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(121, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Da"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(271, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Contratto"
        '
        'dtpAccDa
        '
        Me.dtpAccDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAccDa.Location = New System.Drawing.Point(156, 221)
        Me.dtpAccDa.Name = "dtpAccDa"
        Me.dtpAccDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpAccDa.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Da"
        '
        'dtpAttA
        '
        Me.dtpAttA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAttA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAttA.Location = New System.Drawing.Point(289, 252)
        Me.dtpAttA.Name = "dtpAttA"
        Me.dtpAttA.Size = New System.Drawing.Size(89, 20)
        Me.dtpAttA.TabIndex = 86
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(250, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Caus. sottosc."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Da"
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(59, 36)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(95, 20)
        Me.dtpDocDa.TabIndex = 63
        '
        'dtpAnnA
        '
        Me.dtpAnnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAnnA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAnnA.Location = New System.Drawing.Point(289, 283)
        Me.dtpAnnA.Name = "dtpAnnA"
        Me.dtpAnnA.Size = New System.Drawing.Size(89, 20)
        Me.dtpAnnA.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(164, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "a"
        '
        'dtpAccA
        '
        Me.dtpAccA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAccA.Location = New System.Drawing.Point(289, 221)
        Me.dtpAccA.Name = "dtpAccA"
        Me.dtpAccA.Size = New System.Drawing.Size(89, 20)
        Me.dtpAccA.TabIndex = 79
        '
        'chkSelDataAcc
        '
        Me.chkSelDataAcc.AutoSize = True
        Me.chkSelDataAcc.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataAcc.Location = New System.Drawing.Point(393, 221)
        Me.chkSelDataAcc.Name = "chkSelDataAcc"
        Me.chkSelDataAcc.Size = New System.Drawing.Size(160, 17)
        Me.chkSelDataAcc.TabIndex = 77
        Me.chkSelDataAcc.Text = "Selezione data accettazione"
        Me.chkSelDataAcc.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(121, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Da"
        '
        'chkSelDataInoltro
        '
        Me.chkSelDataInoltro.AutoSize = True
        Me.chkSelDataInoltro.BackColor = System.Drawing.Color.Transparent
        Me.chkSelDataInoltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelDataInoltro.Location = New System.Drawing.Point(393, 190)
        Me.chkSelDataInoltro.Name = "chkSelDataInoltro"
        Me.chkSelDataInoltro.Size = New System.Drawing.Size(127, 17)
        Me.chkSelDataInoltro.TabIndex = 74
        Me.chkSelDataInoltro.Text = "Selezione data inoltro"
        Me.chkSelDataInoltro.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Da"
        '
        'dtpInDa
        '
        Me.dtpInDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInDa.Location = New System.Drawing.Point(156, 190)
        Me.dtpInDa.Name = "dtpInDa"
        Me.dtpInDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpInDa.TabIndex = 75
        '
        'dtpAnnDa
        '
        Me.dtpAnnDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAnnDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAnnDa.Location = New System.Drawing.Point(156, 283)
        Me.dtpAnnDa.Name = "dtpAnnDa"
        Me.dtpAnnDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpAnnDa.TabIndex = 88
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(267, 258)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "a"
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
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.GridPosizioni)
        Me.NiceGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(750, 163)
        Me.NiceGroupBox1.TabIndex = 110
        Me.NiceGroupBox1.Title = "Dati selezionati"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPosizioni.Location = New System.Drawing.Point(0, 0)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(750, 163)
        Me.GridPosizioni.TabIndex = 123
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colSettore, Me.colEnteInoltro, Me.colStatoDelega, Me.colCausaleSottoscrizione, Me.colDataDocumento, Me.colCausaleFineCiclo, Me.colDataRegistrazione, Me.colDataInoltro, Me.colDataAccettazioneDelega, Me.colDataDecorrenzaDelega, Me.colDataAnnullamentoDelega, Me.colDataRevocaDelega, Me.colNote, Me.colReparto, Me.colResponsabile, Me.colReferente, Me.colSedeOperativa, Me.colContratto, Me.colCognome, Me.colNome, Me.colCodice_Fiscale, Me.colDataNascita, Me.colNome_Nazione, Me.colNome_Provincia, Me.colNome_Comune, Me.colIndirizzo, Me.colCap, Me.colCellulare1, Me.colCellulare2, Me.colId})
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
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 0
        '
        'colSettore
        '
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        Me.colSettore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSettore.Visible = True
        Me.colSettore.VisibleIndex = 1
        '
        'colEnteInoltro
        '
        Me.colEnteInoltro.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEnteInoltro.AppearanceCell.Options.UseFont = True
        Me.colEnteInoltro.FieldName = "EnteInoltro"
        Me.colEnteInoltro.Name = "colEnteInoltro"
        Me.colEnteInoltro.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colEnteInoltro.Visible = True
        Me.colEnteInoltro.VisibleIndex = 3
        '
        'colStatoDelega
        '
        Me.colStatoDelega.FieldName = "StatoDelega"
        Me.colStatoDelega.Name = "colStatoDelega"
        Me.colStatoDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colStatoDelega.Visible = True
        Me.colStatoDelega.VisibleIndex = 2
        '
        'colCausaleSottoscrizione
        '
        Me.colCausaleSottoscrizione.FieldName = "CausaleSottoscrizione"
        Me.colCausaleSottoscrizione.Name = "colCausaleSottoscrizione"
        Me.colCausaleSottoscrizione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCausaleSottoscrizione.Visible = True
        Me.colCausaleSottoscrizione.VisibleIndex = 4
        '
        'colDataDocumento
        '
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 5
        '
        'colCausaleFineCiclo
        '
        Me.colCausaleFineCiclo.FieldName = "CausaleFineCiclo"
        Me.colCausaleFineCiclo.Name = "colCausaleFineCiclo"
        Me.colCausaleFineCiclo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        Me.colDataRegistrazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDataInoltro
        '
        Me.colDataInoltro.FieldName = "DataInoltro"
        Me.colDataInoltro.Name = "colDataInoltro"
        Me.colDataInoltro.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDataAccettazioneDelega
        '
        Me.colDataAccettazioneDelega.FieldName = "DataAccettazioneDelega"
        Me.colDataAccettazioneDelega.Name = "colDataAccettazioneDelega"
        Me.colDataAccettazioneDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDataDecorrenzaDelega
        '
        Me.colDataDecorrenzaDelega.Caption = "Data attivazione delega"
        Me.colDataDecorrenzaDelega.FieldName = "DataDecorrenzaDelega"
        Me.colDataDecorrenzaDelega.Name = "colDataDecorrenzaDelega"
        Me.colDataDecorrenzaDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDataAnnullamentoDelega
        '
        Me.colDataAnnullamentoDelega.FieldName = "DataAnnullamentoDelega"
        Me.colDataAnnullamentoDelega.Name = "colDataAnnullamentoDelega"
        Me.colDataAnnullamentoDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDataRevocaDelega
        '
        Me.colDataRevocaDelega.FieldName = "DataRevocaDelega"
        Me.colDataRevocaDelega.Name = "colDataRevocaDelega"
        Me.colDataRevocaDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colReparto
        '
        Me.colReparto.FieldName = "Reparto"
        Me.colReparto.Name = "colReparto"
        Me.colReparto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colResponsabile
        '
        Me.colResponsabile.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colResponsabile.AppearanceCell.Options.UseFont = True
        Me.colResponsabile.FieldName = "Responsabile"
        Me.colResponsabile.Name = "colResponsabile"
        Me.colResponsabile.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colReferente
        '
        Me.colReferente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colReferente.AppearanceCell.Options.UseFont = True
        Me.colReferente.Caption = "Collaboratore comunale"
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        Me.colReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colSedeOperativa
        '
        Me.colSedeOperativa.FieldName = "SedeOperativa"
        Me.colSedeOperativa.Name = "colSedeOperativa"
        Me.colSedeOperativa.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colContratto
        '
        Me.colContratto.FieldName = "Contratto"
        Me.colContratto.Name = "colContratto"
        Me.colContratto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCognome
        '
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        '
        'colNome
        '
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        '
        'colCodice_Fiscale
        '
        Me.colCodice_Fiscale.FieldName = "Codice_Fiscale"
        Me.colCodice_Fiscale.Name = "colCodice_Fiscale"
        '
        'colDataNascita
        '
        Me.colDataNascita.FieldName = "DataNascita"
        Me.colDataNascita.Name = "colDataNascita"
        '
        'colNome_Nazione
        '
        Me.colNome_Nazione.Caption = "Nazione di nascita"
        Me.colNome_Nazione.FieldName = "Nome_Nazione"
        Me.colNome_Nazione.Name = "colNome_Nazione"
        Me.colNome_Nazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Provincia
        '
        Me.colNome_Provincia.Caption = "Provincia di residenza"
        Me.colNome_Provincia.FieldName = "Nome_Provincia"
        Me.colNome_Provincia.Name = "colNome_Provincia"
        Me.colNome_Provincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Comune
        '
        Me.colNome_Comune.Caption = "Comune di residenza"
        Me.colNome_Comune.FieldName = "Nome_Comune"
        Me.colNome_Comune.Name = "colNome_Comune"
        Me.colNome_Comune.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIndirizzo
        '
        Me.colIndirizzo.FieldName = "Indirizzo"
        Me.colIndirizzo.Name = "colIndirizzo"
        '
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        '
        'colCellulare1
        '
        Me.colCellulare1.FieldName = "Cellulare1"
        Me.colCellulare1.Name = "colCellulare1"
        '
        'colCellulare2
        '
        Me.colCellulare2.FieldName = "Cellulare2"
        Me.colCellulare2.Name = "colCellulare2"
        '
        'colId
        '
        Me.colId.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colId.AppearanceCell.Options.UseFont = True
        Me.colId.Caption = "Delega"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'FrmReportDelegheToListaLavoro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 665)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportDelegheToListaLavoro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selezione deleghe"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblCons As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chkSelDataRev As System.Windows.Forms.CheckBox
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboCaus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpInA As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdUt As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkInoltrata As System.Windows.Forms.CheckBox
    Friend WithEvents cboReparto As System.Windows.Forms.ComboBox
    Friend WithEvents dtpRevA As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkSottoscritta As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRevDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSogg As System.Windows.Forms.CheckBox
    Friend WithEvents chkAttivata As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSelDataAtt As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents chkAccettata As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkSelDataAnn As System.Windows.Forms.CheckBox
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents chkRevocata As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpAttDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboContratti As System.Windows.Forms.ComboBox
    Friend WithEvents chkAnnullata As System.Windows.Forms.CheckBox
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpAccDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpAttA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAnnA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpAccA As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSelDataAcc As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkSelDataInoltro As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpInDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAnnDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnteInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleSottoscrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleFineCiclo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAccettazioneDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDecorrenzaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAnnullamentoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRevocaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReparto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsabile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodice_Fiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Nazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
End Class
