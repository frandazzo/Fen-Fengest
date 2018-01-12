<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDeleghe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDeleghe))
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblReparto = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCausaleSott = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblContratto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAnn = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAtt = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblInol = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSott = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblRevRange = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAnnRange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAttRange = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAccRange = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInRange = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblConsegnata = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdDett = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblDocRange = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblRegRange = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.spview = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdStampaTessere = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpecialButton1 = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.DelegadTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatoDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMailAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzoAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Nazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodice_Fiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausaleSottoscrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReparto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausaleFineCiclo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnteInoltro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataInoltro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataAccettazioneDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDecorrenzaDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataAnnullamentoDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRevocaDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsabile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelegadTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(766, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpecialButton1)
        Me.DockPanel.Controls.Add(Me.cmdStampaTessere)
        Me.DockPanel.Controls.Add(Me.spview)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Size = New System.Drawing.Size(766, 44)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblEnte)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblReparto)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblCausaleSott)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblContratto)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblNum)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblRev)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblAnn)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblAtt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblAcc)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblInol)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lblSott)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lblRevRange)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblAnnRange)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblAttRange)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblAccRange)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblInRange)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblConsegnata)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmdDett)
        Me.GroupBox2.Controls.Add(Me.lblSettore)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lblDocRange)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lblRegRange)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(14, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 247)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati report"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.Location = New System.Drawing.Point(322, 65)
        Me.lblEnte.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(33, 13)
        Me.lblEnte.TabIndex = 144
        Me.lblEnte.Text = "Ente"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(275, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Ente:"
        '
        'lblReparto
        '
        Me.lblReparto.AutoSize = True
        Me.lblReparto.Location = New System.Drawing.Point(535, 74)
        Me.lblReparto.Name = "lblReparto"
        Me.lblReparto.Size = New System.Drawing.Size(52, 13)
        Me.lblReparto.TabIndex = 142
        Me.lblReparto.Text = "Reparto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(477, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 141
        Me.Label16.Text = "Reparto:"
        '
        'lblCausaleSott
        '
        Me.lblCausaleSott.AutoSize = True
        Me.lblCausaleSott.Location = New System.Drawing.Point(532, 55)
        Me.lblCausaleSott.Name = "lblCausaleSott"
        Me.lblCausaleSott.Size = New System.Drawing.Size(52, 13)
        Me.lblCausaleSott.TabIndex = 140
        Me.lblCausaleSott.Text = "Causale"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(468, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Cau. sott.:"
        '
        'lblContratto
        '
        Me.lblContratto.AutoSize = True
        Me.lblContratto.Location = New System.Drawing.Point(532, 28)
        Me.lblContratto.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblContratto.Name = "lblContratto"
        Me.lblContratto.Size = New System.Drawing.Size(59, 13)
        Me.lblContratto.TabIndex = 138
        Me.lblContratto.Text = "Contratto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(472, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Contratto:"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(536, 183)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(28, 13)
        Me.lblNum.TabIndex = 136
        Me.lblNum.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Numero risultati:"
        '
        'lblRev
        '
        Me.lblRev.AutoSize = True
        Me.lblRev.Location = New System.Drawing.Point(322, 200)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(40, 13)
        Me.lblRev.TabIndex = 134
        Me.lblRev.Text = "Si/No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Revocate:"
        '
        'lblAnn
        '
        Me.lblAnn.AutoSize = True
        Me.lblAnn.Location = New System.Drawing.Point(322, 177)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(40, 13)
        Me.lblAnn.TabIndex = 132
        Me.lblAnn.Text = "Si/No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "Annullate:"
        '
        'lblAtt
        '
        Me.lblAtt.AutoSize = True
        Me.lblAtt.Location = New System.Drawing.Point(322, 155)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(40, 13)
        Me.lblAtt.TabIndex = 130
        Me.lblAtt.Text = "Si/No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(261, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Attivate:"
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Location = New System.Drawing.Point(322, 133)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(40, 13)
        Me.lblAcc.TabIndex = 128
        Me.lblAcc.Text = "Si/No"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(251, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Accettate:"
        '
        'lblInol
        '
        Me.lblInol.AutoSize = True
        Me.lblInol.Location = New System.Drawing.Point(322, 111)
        Me.lblInol.Name = "lblInol"
        Me.lblInol.Size = New System.Drawing.Size(40, 13)
        Me.lblInol.TabIndex = 126
        Me.lblInol.Text = "Si/No"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(259, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Inoltrate:"
        '
        'lblSott
        '
        Me.lblSott.AutoSize = True
        Me.lblSott.Location = New System.Drawing.Point(322, 91)
        Me.lblSott.Name = "lblSott"
        Me.lblSott.Size = New System.Drawing.Size(40, 13)
        Me.lblSott.TabIndex = 124
        Me.lblSott.Text = "Si/No"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(244, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 123
        Me.Label21.Text = "Sottoscritte:"
        '
        'lblRevRange
        '
        Me.lblRevRange.AutoSize = True
        Me.lblRevRange.Location = New System.Drawing.Point(89, 205)
        Me.lblRevRange.Name = "lblRevRange"
        Me.lblRevRange.Size = New System.Drawing.Size(44, 13)
        Me.lblRevRange.TabIndex = 122
        Me.lblRevRange.Text = "Range"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Data rev. in:"
        '
        'lblAnnRange
        '
        Me.lblAnnRange.AutoSize = True
        Me.lblAnnRange.Location = New System.Drawing.Point(89, 182)
        Me.lblAnnRange.Name = "lblAnnRange"
        Me.lblAnnRange.Size = New System.Drawing.Size(44, 13)
        Me.lblAnnRange.TabIndex = 120
        Me.lblAnnRange.Text = "Range"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Data ann. in:"
        '
        'lblAttRange
        '
        Me.lblAttRange.AutoSize = True
        Me.lblAttRange.Location = New System.Drawing.Point(89, 158)
        Me.lblAttRange.Name = "lblAttRange"
        Me.lblAttRange.Size = New System.Drawing.Size(44, 13)
        Me.lblAttRange.TabIndex = 118
        Me.lblAttRange.Text = "Range"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Data attiv. in:"
        '
        'lblAccRange
        '
        Me.lblAccRange.AutoSize = True
        Me.lblAccRange.Location = New System.Drawing.Point(89, 134)
        Me.lblAccRange.Name = "lblAccRange"
        Me.lblAccRange.Size = New System.Drawing.Size(44, 13)
        Me.lblAccRange.TabIndex = 116
        Me.lblAccRange.Text = "Range"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Data acc. in:"
        '
        'lblInRange
        '
        Me.lblInRange.AutoSize = True
        Me.lblInRange.Location = New System.Drawing.Point(89, 111)
        Me.lblInRange.Name = "lblInRange"
        Me.lblInRange.Size = New System.Drawing.Size(44, 13)
        Me.lblInRange.TabIndex = 114
        Me.lblInRange.Text = "Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Data inol. in:"
        '
        'lblConsegnata
        '
        Me.lblConsegnata.AutoSize = True
        Me.lblConsegnata.Location = New System.Drawing.Point(533, 138)
        Me.lblConsegnata.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblConsegnata.Name = "lblConsegnata"
        Me.lblConsegnata.Size = New System.Drawing.Size(63, 13)
        Me.lblConsegnata.TabIndex = 112
        Me.lblConsegnata.Text = "Referente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(451, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Consegnata a:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(554, 215)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 13)
        Me.Label30.TabIndex = 110
        Me.Label30.Text = "Visualizza lista aziende"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(442, 217)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(87, 13)
        Me.Label29.TabIndex = 105
        Me.Label29.Text = "Aziende  incluse:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.Location = New System.Drawing.Point(533, 111)
        Me.lblReferente.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(63, 13)
        Me.lblReferente.TabIndex = 96
        Me.lblReferente.Text = "Referente"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(458, 111)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "Collab. com.:"
        '
        'cmdDett
        '
        Me.cmdDett.ApplyOutLookStile = True
        Me.cmdDett.BackColor = System.Drawing.Color.Transparent
        Me.cmdDett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDett.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdDett.Disabled = False
        Me.cmdDett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDett.ForeColor = System.Drawing.Color.Transparent
        Me.cmdDett.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDett.Location = New System.Drawing.Point(538, 214)
        Me.cmdDett.Name = "cmdDett"
        Me.cmdDett.Radius = 19.0!
        Me.cmdDett.ShowTooltip = True
        Me.cmdDett.Size = New System.Drawing.Size(19, 19)
        Me.cmdDett.TabIndex = 104
        Me.cmdDett.TextValue = ""
        Me.cmdDett.TooltipText = "Visualizza lista utenti"
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.Location = New System.Drawing.Point(322, 40)
        Me.lblSettore.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(48, 13)
        Me.lblSettore.TabIndex = 88
        Me.lblSettore.Text = "Settore"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(263, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Settore:"
        '
        'lblDocRange
        '
        Me.lblDocRange.AutoSize = True
        Me.lblDocRange.Location = New System.Drawing.Point(89, 87)
        Me.lblDocRange.Name = "lblDocRange"
        Me.lblDocRange.Size = New System.Drawing.Size(44, 13)
        Me.lblDocRange.TabIndex = 84
        Me.lblDocRange.Text = "Range"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Data doc. in:"
        '
        'lblRegRange
        '
        Me.lblRegRange.AutoSize = True
        Me.lblRegRange.Location = New System.Drawing.Point(89, 54)
        Me.lblRegRange.Name = "lblRegRange"
        Me.lblRegRange.Size = New System.Drawing.Size(44, 13)
        Me.lblRegRange.TabIndex = 82
        Me.lblRegRange.Text = "Range"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Data reg. in:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(89, 28)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(34, 13)
        Me.lblData.TabIndex = 78
        Me.lblData.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Data report:"
        '
        'cmdPrint
        '
        Me.cmdPrint.ApplyOutLookStile = True
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
        Me.cmdPrint.Disabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdPrint, "Funzione che permette di stampare il report.")
        Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrint.Location = New System.Drawing.Point(60, 5)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdPrint, True)
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 119
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'cmdListaLavoro
        '
        Me.cmdListaLavoro.ApplyOutLookStile = True
        Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_address_book_32x32
        Me.cmdListaLavoro.Disabled = False
        Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdListaLavoro, resources.GetString("cmdListaLavoro.HelpString"))
        Me.cmdListaLavoro.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdListaLavoro.Location = New System.Drawing.Point(14, 5)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdListaLavoro, True)
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 120
        Me.cmdListaLavoro.TextValue = ""
        Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro"
        '
        'spview
        '
        Me.spview.ApplyOutLookStile = True
        Me.spview.BackColor = System.Drawing.Color.Transparent
        Me.spview.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
        Me.spview.Disabled = False
        Me.spview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.spview.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.spview, "Funzione che permette di stampare il report.")
        Me.spview.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.spview.Location = New System.Drawing.Point(112, 5)
        Me.spview.Name = "spview"
        Me.spview.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.spview, True)
        Me.spview.ShowTooltip = True
        Me.spview.Size = New System.Drawing.Size(32, 32)
        Me.spview.TabIndex = 121
        Me.spview.TextValue = ""
        Me.spview.TooltipText = "Cambia visualizzazione"
        '
        'cmdStampaTessere
        '
        Me.cmdStampaTessere.ApplyOutLookStile = True
        Me.cmdStampaTessere.BackColor = System.Drawing.Color.Transparent
        Me.cmdStampaTessere.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_address_48x48
        Me.cmdStampaTessere.Disabled = False
        Me.cmdStampaTessere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStampaTessere.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdStampaTessere, "Funzione che permette di stampare il report.")
        Me.cmdStampaTessere.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdStampaTessere.Location = New System.Drawing.Point(153, 5)
        Me.cmdStampaTessere.Name = "cmdStampaTessere"
        Me.cmdStampaTessere.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdStampaTessere, True)
        Me.cmdStampaTessere.ShowTooltip = True
        Me.cmdStampaTessere.Size = New System.Drawing.Size(32, 32)
        Me.cmdStampaTessere.TabIndex = 122
        Me.cmdStampaTessere.TextValue = ""
        Me.cmdStampaTessere.TooltipText = "Stampa tessere"
        '
        'SpecialButton1
        '
        Me.SpecialButton1.ApplyOutLookStile = True
        Me.SpecialButton1.BackColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_address_48x48
        Me.SpecialButton1.Disabled = False
        Me.SpecialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpecialButton1.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpecialButton1, "Funzione che permette di stampare il report.")
        Me.SpecialButton1.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpecialButton1.Location = New System.Drawing.Point(201, 5)
        Me.SpecialButton1.Name = "SpecialButton1"
        Me.SpecialButton1.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpecialButton1, True)
        Me.SpecialButton1.ShowTooltip = True
        Me.SpecialButton1.Size = New System.Drawing.Size(32, 32)
        Me.SpecialButton1.TabIndex = 123
        Me.SpecialButton1.TextValue = ""
        Me.SpecialButton1.TooltipText = "Esporta lista aziende"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.DelegadTOBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(14, 351)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(730, 332)
        Me.GridPosizioni.TabIndex = 122
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DelegadTOBindingSource
        '
        Me.DelegadTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.DelegadTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colSettore, Me.colStatoDelega, Me.colDataDocumento, Me.colMailAzienda, Me.colProvinciaAzienda, Me.colComuneAzienda, Me.colIndirizzoAzienda, Me.colCapAzienda, Me.colNome_Provincia_Nascita, Me.colNome_Comune_Nascita, Me.colNome_Comune, Me.colIndirizzo, Me.colNome_Nazione, Me.colNome_Provincia, Me.colCap, Me.colCodice_Fiscale, Me.colDataNascita, Me.colCognome, Me.colNome, Me.colContratto, Me.colIdContratto, Me.colCellulare1, Me.colCellulare2, Me.colCausaleSottoscrizione, Me.colReparto, Me.colCausaleFineCiclo, Me.colEnteInoltro, Me.colNote, Me.colDataRegistrazione, Me.colIdUtente, Me.colReferente, Me.colIdReferente, Me.colDataInoltro, Me.colDataAccettazioneDelega, Me.colDataDecorrenzaDelega, Me.colDataAnnullamentoDelega, Me.colDataRevocaDelega, Me.colSedeOperativa, Me.colResponsabile, Me.colId})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colUtente
        '
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        'colStatoDelega
        '
        Me.colStatoDelega.FieldName = "StatoDelega"
        Me.colStatoDelega.Name = "colStatoDelega"
        Me.colStatoDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colStatoDelega.Visible = True
        Me.colStatoDelega.VisibleIndex = 2
        '
        'colDataDocumento
        '
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 3
        '
        'colMailAzienda
        '
        Me.colMailAzienda.FieldName = "MailAzienda"
        Me.colMailAzienda.Name = "colMailAzienda"
        '
        'colProvinciaAzienda
        '
        Me.colProvinciaAzienda.FieldName = "ProvinciaAzienda"
        Me.colProvinciaAzienda.Name = "colProvinciaAzienda"
        Me.colProvinciaAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colComuneAzienda
        '
        Me.colComuneAzienda.FieldName = "ComuneAzienda"
        Me.colComuneAzienda.Name = "colComuneAzienda"
        Me.colComuneAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIndirizzoAzienda
        '
        Me.colIndirizzoAzienda.FieldName = "IndirizzoAzienda"
        Me.colIndirizzoAzienda.Name = "colIndirizzoAzienda"
        '
        'colCapAzienda
        '
        Me.colCapAzienda.FieldName = "CapAzienda"
        Me.colCapAzienda.Name = "colCapAzienda"
        '
        'colNome_Provincia_Nascita
        '
        Me.colNome_Provincia_Nascita.FieldName = "Nome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.Name = "colNome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Comune_Nascita
        '
        Me.colNome_Comune_Nascita.FieldName = "Nome_Comune_Nascita"
        Me.colNome_Comune_Nascita.Name = "colNome_Comune_Nascita"
        Me.colNome_Comune_Nascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Comune
        '
        Me.colNome_Comune.FieldName = "Nome_Comune"
        Me.colNome_Comune.Name = "colNome_Comune"
        Me.colNome_Comune.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIndirizzo
        '
        Me.colIndirizzo.FieldName = "Indirizzo"
        Me.colIndirizzo.Name = "colIndirizzo"
        '
        'colNome_Nazione
        '
        Me.colNome_Nazione.FieldName = "Nome_Nazione"
        Me.colNome_Nazione.Name = "colNome_Nazione"
        Me.colNome_Nazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Provincia
        '
        Me.colNome_Provincia.FieldName = "Nome_Provincia"
        Me.colNome_Provincia.Name = "colNome_Provincia"
        Me.colNome_Provincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        '
        'colCodice_Fiscale
        '
        Me.colCodice_Fiscale.FieldName = "Codice_Fiscale"
        Me.colCodice_Fiscale.Name = "colCodice_Fiscale"
        Me.colCodice_Fiscale.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colDataNascita
        '
        Me.colDataNascita.FieldName = "DataNascita"
        Me.colDataNascita.Name = "colDataNascita"
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
        'colContratto
        '
        Me.colContratto.FieldName = "Contratto"
        Me.colContratto.Name = "colContratto"
        Me.colContratto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIdContratto
        '
        Me.colIdContratto.FieldName = "IdContratto"
        Me.colIdContratto.Name = "colIdContratto"
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
        'colCausaleSottoscrizione
        '
        Me.colCausaleSottoscrizione.FieldName = "CausaleSottoscrizione"
        Me.colCausaleSottoscrizione.Name = "colCausaleSottoscrizione"
        Me.colCausaleSottoscrizione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colReparto
        '
        Me.colReparto.FieldName = "Reparto"
        Me.colReparto.Name = "colReparto"
        '
        'colCausaleFineCiclo
        '
        Me.colCausaleFineCiclo.FieldName = "CausaleFineCiclo"
        Me.colCausaleFineCiclo.Name = "colCausaleFineCiclo"
        Me.colCausaleFineCiclo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colEnteInoltro
        '
        Me.colEnteInoltro.FieldName = "EnteInoltro"
        Me.colEnteInoltro.Name = "colEnteInoltro"
        Me.colEnteInoltro.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        '
        'colIdUtente
        '
        Me.colIdUtente.FieldName = "IdUtente"
        Me.colIdUtente.Name = "colIdUtente"
        '
        'colReferente
        '
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        Me.colReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIdReferente
        '
        Me.colIdReferente.FieldName = "IdReferente"
        Me.colIdReferente.Name = "colIdReferente"
        '
        'colDataInoltro
        '
        Me.colDataInoltro.FieldName = "DataInoltro"
        Me.colDataInoltro.Name = "colDataInoltro"
        '
        'colDataAccettazioneDelega
        '
        Me.colDataAccettazioneDelega.FieldName = "DataAccettazioneDelega"
        Me.colDataAccettazioneDelega.Name = "colDataAccettazioneDelega"
        '
        'colDataDecorrenzaDelega
        '
        Me.colDataDecorrenzaDelega.FieldName = "DataDecorrenzaDelega"
        Me.colDataDecorrenzaDelega.Name = "colDataDecorrenzaDelega"
        '
        'colDataAnnullamentoDelega
        '
        Me.colDataAnnullamentoDelega.FieldName = "DataAnnullamentoDelega"
        Me.colDataAnnullamentoDelega.Name = "colDataAnnullamentoDelega"
        '
        'colDataRevocaDelega
        '
        Me.colDataRevocaDelega.FieldName = "DataRevocaDelega"
        Me.colDataRevocaDelega.Name = "colDataRevocaDelega"
        '
        'colSedeOperativa
        '
        Me.colSedeOperativa.FieldName = "SedeOperativa"
        Me.colSedeOperativa.Name = "colSedeOperativa"
        '
        'colResponsabile
        '
        Me.colResponsabile.FieldName = "Responsabile"
        Me.colResponsabile.Name = "colResponsabile"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'ReportDeleghe
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ReportDeleghe"
        Me.Size = New System.Drawing.Size(755, 699)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelegadTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label30 As System.Windows.Forms.Label
   Friend WithEvents Label29 As System.Windows.Forms.Label
   Friend WithEvents lblReferente As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents cmdDett As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents lblDocRange As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents lblRegRange As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents lblData As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents lblRevRange As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents lblAnnRange As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents lblAttRange As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents lblAccRange As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents lblInRange As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents lblConsegnata As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents lblRev As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents lblAnn As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents lblAtt As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents lblAcc As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents lblInol As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents lblSott As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents lblContratto As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents lblReparto As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents lblCausaleSott As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents lblEnte As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents spview As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DelegadTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdStampaTessere As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpecialButton1 As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMailAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzoAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Nazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodice_Fiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleSottoscrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReparto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleFineCiclo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnteInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAccettazioneDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDecorrenzaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAnnullamentoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRevocaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsabile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn

End Class
