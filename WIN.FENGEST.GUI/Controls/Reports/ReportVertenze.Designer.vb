<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportVertenze
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportVertenze))
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblIntervento = New System.Windows.Forms.Label()
        Me.label111 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdDettUt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAvvocato = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTipoEvento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEvRange = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblValRange = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblConsegnata = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.cmdDettAz = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.lblDocRange = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblRegRange = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.VertenzaDTOBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVertenzaChiusa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvvocato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodoVertenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsabile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VertenzaDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(734, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Size = New System.Drawing.Size(734, 44)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblIntervento)
        Me.GroupBox2.Controls.Add(Me.label111)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmdDettUt)
        Me.GroupBox2.Controls.Add(Me.lblNum)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblAvvocato)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblEnte)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblTipoEvento)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblEvRange)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblValRange)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblConsegnata)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.cmdDettAz)
        Me.GroupBox2.Controls.Add(Me.lblDocRange)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lblRegRange)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(687, 183)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati report"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 139)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 148
        Me.Label22.Text = "Coollab.  com.:"
        '
        'lblIntervento
        '
        Me.lblIntervento.AutoSize = True
        Me.lblIntervento.Location = New System.Drawing.Point(348, 124)
        Me.lblIntervento.Name = "lblIntervento"
        Me.lblIntervento.Size = New System.Drawing.Size(65, 13)
        Me.lblIntervento.TabIndex = 147
        Me.lblIntervento.Text = "Intervento"
        '
        'label111
        '
        Me.label111.AutoSize = True
        Me.label111.BackColor = System.Drawing.Color.Transparent
        Me.label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label111.Location = New System.Drawing.Point(282, 124)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(58, 13)
        Me.label111.TabIndex = 146
        Me.label111.Text = "Intervento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Visualizza lista ut."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(501, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Ut.  inclusi:"
        '
        'cmdDettUt
        '
        Me.cmdDettUt.ApplyOutLookStile = True
        Me.cmdDettUt.BackColor = System.Drawing.Color.Transparent
        Me.cmdDettUt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDettUt.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdDettUt.Disabled = False
        Me.cmdDettUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDettUt.ForeColor = System.Drawing.Color.Transparent
        Me.cmdDettUt.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDettUt.Location = New System.Drawing.Point(562, 119)
        Me.cmdDettUt.Name = "cmdDettUt"
        Me.cmdDettUt.Radius = 19.0!
        Me.cmdDettUt.ShowTooltip = True
        Me.cmdDettUt.Size = New System.Drawing.Size(19, 19)
        Me.cmdDettUt.TabIndex = 143
        Me.cmdDettUt.TextValue = ""
        Me.cmdDettUt.TooltipText = "Visualizza lista utenti"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(603, 28)
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
        Me.Label7.Location = New System.Drawing.Point(515, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Numero risultati:"
        '
        'lblAvvocato
        '
        Me.lblAvvocato.AutoSize = True
        Me.lblAvvocato.Location = New System.Drawing.Point(346, 100)
        Me.lblAvvocato.Name = "lblAvvocato"
        Me.lblAvvocato.Size = New System.Drawing.Size(61, 13)
        Me.lblAvvocato.TabIndex = 122
        Me.lblAvvocato.Text = "Avvocato"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Avvocato:"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.Location = New System.Drawing.Point(346, 75)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(72, 13)
        Me.lblEnte.TabIndex = 120
        Me.lblEnte.Text = "Ente inoltro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(277, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Ente inoltro:"
        '
        'lblTipoEvento
        '
        Me.lblTipoEvento.AutoSize = True
        Me.lblTipoEvento.Location = New System.Drawing.Point(348, 51)
        Me.lblTipoEvento.Name = "lblTipoEvento"
        Me.lblTipoEvento.Size = New System.Drawing.Size(75, 13)
        Me.lblTipoEvento.TabIndex = 118
        Me.lblTipoEvento.Text = "Tipo evento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(275, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Tipo evento:"
        '
        'lblEvRange
        '
        Me.lblEvRange.AutoSize = True
        Me.lblEvRange.Location = New System.Drawing.Point(348, 28)
        Me.lblEvRange.Name = "lblEvRange"
        Me.lblEvRange.Size = New System.Drawing.Size(44, 13)
        Me.lblEvRange.TabIndex = 116
        Me.lblEvRange.Text = "Range"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(262, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Data evento in:"
        '
        'lblValRange
        '
        Me.lblValRange.AutoSize = True
        Me.lblValRange.Location = New System.Drawing.Point(89, 98)
        Me.lblValRange.Name = "lblValRange"
        Me.lblValRange.Size = New System.Drawing.Size(44, 13)
        Me.lblValRange.TabIndex = 114
        Me.lblValRange.Text = "Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Validità su:"
        '
        'lblConsegnata
        '
        Me.lblConsegnata.AutoSize = True
        Me.lblConsegnata.Location = New System.Drawing.Point(89, 160)
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
        Me.Label3.Location = New System.Drawing.Point(7, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Responsabile:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(583, 97)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(91, 13)
        Me.Label30.TabIndex = 110
        Me.Label30.Text = "Visualizza lista az."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(493, 99)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 13)
        Me.Label29.TabIndex = 105
        Me.Label29.Text = "Az.  incluse:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.Location = New System.Drawing.Point(89, 139)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(63, 13)
        Me.lblReferente.TabIndex = 96
        Me.lblReferente.Text = "Referente"
        '
        'cmdDettAz
        '
        Me.cmdDettAz.ApplyOutLookStile = True
        Me.cmdDettAz.BackColor = System.Drawing.Color.Transparent
        Me.cmdDettAz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDettAz.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdDettAz.Disabled = False
        Me.cmdDettAz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDettAz.ForeColor = System.Drawing.Color.Transparent
        Me.cmdDettAz.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDettAz.Location = New System.Drawing.Point(567, 96)
        Me.cmdDettAz.Name = "cmdDettAz"
        Me.cmdDettAz.Radius = 16.0!
        Me.cmdDettAz.ShowTooltip = True
        Me.cmdDettAz.Size = New System.Drawing.Size(16, 16)
        Me.cmdDettAz.TabIndex = 104
        Me.cmdDettAz.TextValue = ""
        Me.cmdDettAz.TooltipText = "Visualizza lista utenti"
        '
        'lblDocRange
        '
        Me.lblDocRange.AutoSize = True
        Me.lblDocRange.Location = New System.Drawing.Point(89, 75)
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
        Me.Label19.Location = New System.Drawing.Point(13, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Data doc. in:"
        '
        'lblRegRange
        '
        Me.lblRegRange.AutoSize = True
        Me.lblRegRange.Location = New System.Drawing.Point(89, 51)
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
        Me.Label17.Location = New System.Drawing.Point(16, 51)
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
        Me.Label2.Location = New System.Drawing.Point(18, 28)
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
        Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrint.Location = New System.Drawing.Point(64, 5)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 121
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
        Me.cmdListaLavoro.Location = New System.Drawing.Point(18, 5)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdListaLavoro, True)
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 122
        Me.cmdListaLavoro.TextValue = ""
        Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.VertenzaDTOBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(14, 278)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(688, 328)
        Me.GridPosizioni.TabIndex = 124
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VertenzaDTOBindingSource
        '
        Me.VertenzaDTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.VertenzaDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colAzienda, Me.colDataDocumento, Me.colVertenzaChiusa, Me.colAvvocato, Me.colPeriodoVertenza, Me.colNote, Me.colDataRegistrazione, Me.colReferente, Me.colResponsabile, Me.colId})
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
        Me.colUtente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colUtente.AppearanceCell.Options.UseFont = True
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 0
        '
        'colAzienda
        '
        Me.colAzienda.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAzienda.AppearanceCell.Options.UseFont = True
        Me.colAzienda.FieldName = "Azienda"
        Me.colAzienda.Name = "colAzienda"
        Me.colAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAzienda.Visible = True
        Me.colAzienda.VisibleIndex = 1
        '
        'colDataDocumento
        '
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 2
        '
        'colVertenzaChiusa
        '
        Me.colVertenzaChiusa.FieldName = "VertenzaChiusa"
        Me.colVertenzaChiusa.Name = "colVertenzaChiusa"
        Me.colVertenzaChiusa.Visible = True
        Me.colVertenzaChiusa.VisibleIndex = 3
        '
        'colAvvocato
        '
        Me.colAvvocato.FieldName = "Avvocato"
        Me.colAvvocato.Name = "colAvvocato"
        Me.colAvvocato.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAvvocato.Visible = True
        Me.colAvvocato.VisibleIndex = 4
        '
        'colPeriodoVertenza
        '
        Me.colPeriodoVertenza.FieldName = "PeriodoVertenza"
        Me.colPeriodoVertenza.Name = "colPeriodoVertenza"
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
        Me.colDataRegistrazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colReferente
        '
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        Me.colReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colResponsabile
        '
        Me.colResponsabile.FieldName = "Responsabile"
        Me.colResponsabile.Name = "colResponsabile"
        Me.colResponsabile.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'ReportVertenze
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ReportVertenze"
        Me.Size = New System.Drawing.Size(734, 621)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VertenzaDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents lblNum As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents lblAvvocato As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents lblEnte As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents lblTipoEvento As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents lblEvRange As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents lblValRange As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents lblConsegnata As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label30 As System.Windows.Forms.Label
   Friend WithEvents Label29 As System.Windows.Forms.Label
   Friend WithEvents lblReferente As System.Windows.Forms.Label
   Friend WithEvents cmdDettAz As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents lblDocRange As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents lblRegRange As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents lblData As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cmdDettUt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents lblIntervento As System.Windows.Forms.Label
   Friend WithEvents label111 As System.Windows.Forms.Label
   Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents VertenzaDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVertenzaChiusa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvvocato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodoVertenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsabile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn

End Class
