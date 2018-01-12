<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportIscrittiDTO
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
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.lblVerifica = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblContratto = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblCompetenza = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.NumRevCisl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numIsc = New System.Windows.Forms.TextBox()
        Me.numRevCGL = New System.Windows.Forms.TextBox()
        Me.numNew = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdPrintCard = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.spview = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpecialButton1 = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.spExport = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.IscrittoDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeEnte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAziendaImpiego = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompetenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLivello = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodice_Fiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Nazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCell1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCell2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoPrestazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.spReportCompleto = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IscrittoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(697, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.spReportCompleto)
        Me.DockPanel.Controls.Add(Me.SpecialButton1)
        Me.DockPanel.Controls.Add(Me.spExport)
        Me.DockPanel.Controls.Add(Me.cmdPrintCard)
        Me.DockPanel.Controls.Add(Me.spview)
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Location = New System.Drawing.Point(1, 26)
        Me.DockPanel.Size = New System.Drawing.Size(697, 44)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblEnte)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.lblVerifica)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblSogg)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblContratto)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.lblSettore)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lblCompetenza)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 110)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati selezione report"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.Location = New System.Drawing.Point(262, 53)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(11, 13)
        Me.lblEnte.TabIndex = 99
        Me.lblEnte.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Ente:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(23, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "Coollab.:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.Location = New System.Drawing.Point(77, 76)
        Me.lblReferente.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(63, 13)
        Me.lblReferente.TabIndex = 96
        Me.lblReferente.Text = "Referente"
        '
        'lblVerifica
        '
        Me.lblVerifica.AutoSize = True
        Me.lblVerifica.Location = New System.Drawing.Point(486, 27)
        Me.lblVerifica.Name = "lblVerifica"
        Me.lblVerifica.Size = New System.Drawing.Size(40, 13)
        Me.lblVerifica.TabIndex = 94
        Me.lblVerifica.Text = "Si/No"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(400, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 93
        Me.Label17.Text = "Verifica delega:"
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.Location = New System.Drawing.Point(303, 76)
        Me.lblSogg.MaximumSize = New System.Drawing.Size(120, 0)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(58, 13)
        Me.lblSogg.TabIndex = 92
        Me.lblSogg.Text = "Soggetto"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(214, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "Azienda impiego:"
        '
        'lblContratto
        '
        Me.lblContratto.AutoSize = True
        Me.lblContratto.Location = New System.Drawing.Point(481, 53)
        Me.lblContratto.Name = "lblContratto"
        Me.lblContratto.Size = New System.Drawing.Size(59, 13)
        Me.lblContratto.TabIndex = 90
        Me.lblContratto.Text = "Contratto"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(402, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 13)
        Me.Label23.TabIndex = 89
        Me.Label23.Text = "Contratto app.:"
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.Location = New System.Drawing.Point(75, 53)
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
        Me.Label25.Location = New System.Drawing.Point(27, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Settore:"
        '
        'lblCompetenza
        '
        Me.lblCompetenza.AutoSize = True
        Me.lblCompetenza.Location = New System.Drawing.Point(263, 27)
        Me.lblCompetenza.Name = "lblCompetenza"
        Me.lblCompetenza.Size = New System.Drawing.Size(76, 13)
        Me.lblCompetenza.TabIndex = 86
        Me.lblCompetenza.Text = "Competenza"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(215, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Periodo:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(75, 27)
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
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Data report:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.NumRevCisl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.numIsc)
        Me.GroupBox1.Controls.Add(Me.numRevCGL)
        Me.GroupBox1.Controls.Add(Me.numNew)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(15, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 62)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.Text = "Risultati report"
        Me.GroupBox1.Title = "Risultati"
        '
        'NumRevCisl
        '
        Me.NumRevCisl.AcceptsTab = True
        Me.NumRevCisl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumRevCisl.Location = New System.Drawing.Point(365, 31)
        Me.NumRevCisl.Name = "NumRevCisl"
        Me.NumRevCisl.Size = New System.Drawing.Size(51, 20)
        Me.NumRevCisl.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Tot. rev. Filca"
        '
        'numIsc
        '
        Me.numIsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numIsc.Location = New System.Drawing.Point(73, 31)
        Me.numIsc.Name = "numIsc"
        Me.numIsc.Size = New System.Drawing.Size(51, 20)
        Me.numIsc.TabIndex = 79
        '
        'numRevCGL
        '
        Me.numRevCGL.AcceptsTab = True
        Me.numRevCGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numRevCGL.Location = New System.Drawing.Point(222, 31)
        Me.numRevCGL.Name = "numRevCGL"
        Me.numRevCGL.Size = New System.Drawing.Size(51, 20)
        Me.numRevCGL.TabIndex = 80
        '
        'numNew
        '
        Me.numNew.AcceptsReturn = True
        Me.numNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNew.Location = New System.Drawing.Point(545, 31)
        Me.numNew.Name = "numNew"
        Me.numNew.Size = New System.Drawing.Size(51, 20)
        Me.numNew.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Tot.  nuovi iscritti"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Tot. rev. Fillea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Totale iscritti"
        '
        'cmdPrintCard
        '
        Me.cmdPrintCard.ApplyOutLookStile = True
        Me.cmdPrintCard.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrintCard.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_address_48x48
        Me.cmdPrintCard.Disabled = False
        Me.cmdPrintCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrintCard.ForeColor = System.Drawing.Color.Transparent
        Me.cmdPrintCard.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrintCard.Location = New System.Drawing.Point(164, 6)
        Me.cmdPrintCard.Name = "cmdPrintCard"
        Me.cmdPrintCard.Radius = 48.0!
        Me.cmdPrintCard.ShowTooltip = True
        Me.cmdPrintCard.Size = New System.Drawing.Size(41, 32)
        Me.cmdPrintCard.TabIndex = 115
        Me.cmdPrintCard.TextValue = ""
        Me.cmdPrintCard.TooltipText = "Stampa tessere utenti"
        '
        'cmdListaLavoro
        '
        Me.cmdListaLavoro.ApplyOutLookStile = True
        Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_address_book_32x32
        Me.cmdListaLavoro.Disabled = False
        Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdListaLavoro, "Funzione che permette di creare una lista di lavoro composta dagli utenti iscritt" & _
        "i che compaiono nel report.")
        Me.cmdListaLavoro.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdListaLavoro.Location = New System.Drawing.Point(14, 6)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdListaLavoro, True)
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 116
        Me.cmdListaLavoro.TextValue = ""
        Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro"
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
        Me.cmdPrint.Location = New System.Drawing.Point(68, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdPrint, True)
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 114
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
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
        Me.spview.Location = New System.Drawing.Point(119, 6)
        Me.spview.Name = "spview"
        Me.spview.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.spview, True)
        Me.spview.ShowTooltip = True
        Me.spview.Size = New System.Drawing.Size(32, 32)
        Me.spview.TabIndex = 119
        Me.spview.TextValue = ""
        Me.spview.TooltipText = "Cambia visualizzazione"
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
        Me.SpecialButton1.Location = New System.Drawing.Point(265, 6)
        Me.SpecialButton1.Name = "SpecialButton1"
        Me.SpecialButton1.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpecialButton1, True)
        Me.SpecialButton1.ShowTooltip = True
        Me.SpecialButton1.Size = New System.Drawing.Size(32, 32)
        Me.SpecialButton1.TabIndex = 124
        Me.SpecialButton1.TextValue = ""
        Me.SpecialButton1.TooltipText = "Esporta lista aziende"
        '
        'spExport
        '
        Me.spExport.ApplyOutLookStile = True
        Me.spExport.BackColor = System.Drawing.Color.Transparent
        Me.spExport.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.CF
        Me.spExport.Disabled = False
        Me.spExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.spExport.ForeColor = System.Drawing.Color.Transparent
        Me.spExport.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.spExport.Location = New System.Drawing.Point(213, 6)
        Me.spExport.Name = "spExport"
        Me.spExport.Radius = 48.0!
        Me.spExport.ShowTooltip = True
        Me.spExport.Size = New System.Drawing.Size(35, 32)
        Me.spExport.TabIndex = 120
        Me.spExport.TextValue = ""
        Me.spExport.TooltipText = "Esporta dati al database regionale"
        Me.spExport.Visible = False
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.IscrittoDTOBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(15, 271)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(659, 380)
        Me.GridPosizioni.TabIndex = 114
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'IscrittoDTOBindingSource
        '
        Me.IscrittoDTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.IscrittoDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colSettore, Me.colNomeEnte, Me.colAziendaImpiego, Me.colCompetenza, Me.colContratto, Me.colLivello, Me.colNome, Me.colCognome, Me.colCodice_Fiscale, Me.colDataNascita, Me.colNome_Nazione, Me.colNome_Provincia_Nascita, Me.colNome_Comune_Nascita, Me.colNome_Provincia, Me.colNome_Comune, Me.colIndirizzo, Me.colCap, Me.colCell1, Me.colCell2, Me.colTipoDoc, Me.colTipoPrestazione, Me.colImporto, Me.colCausale})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsSelection.MultiSelect = True
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
        'colNomeEnte
        '
        Me.colNomeEnte.FieldName = "NomeEnte"
        Me.colNomeEnte.Name = "colNomeEnte"
        Me.colNomeEnte.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNomeEnte.Visible = True
        Me.colNomeEnte.VisibleIndex = 3
        '
        'colAziendaImpiego
        '
        Me.colAziendaImpiego.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAziendaImpiego.AppearanceCell.Options.UseFont = True
        Me.colAziendaImpiego.FieldName = "AziendaImpiego"
        Me.colAziendaImpiego.Name = "colAziendaImpiego"
        Me.colAziendaImpiego.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAziendaImpiego.Visible = True
        Me.colAziendaImpiego.VisibleIndex = 2
        '
        'colCompetenza
        '
        Me.colCompetenza.FieldName = "Competenza"
        Me.colCompetenza.Name = "colCompetenza"
        Me.colCompetenza.Visible = True
        Me.colCompetenza.VisibleIndex = 4
        '
        'colContratto
        '
        Me.colContratto.FieldName = "Contratto"
        Me.colContratto.Name = "colContratto"
        Me.colContratto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colContratto.Visible = True
        Me.colContratto.VisibleIndex = 5
        '
        'colLivello
        '
        Me.colLivello.FieldName = "Livello"
        Me.colLivello.Name = "colLivello"
        Me.colLivello.Visible = True
        Me.colLivello.VisibleIndex = 6
        '
        'colNome
        '
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        '
        'colCognome
        '
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
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
        Me.colNome_Nazione.FieldName = "Nome_Nazione"
        Me.colNome_Nazione.Name = "colNome_Nazione"
        Me.colNome_Nazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        'colNome_Provincia
        '
        Me.colNome_Provincia.FieldName = "Nome_Provincia"
        Me.colNome_Provincia.Name = "colNome_Provincia"
        Me.colNome_Provincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        '
        'colCell1
        '
        Me.colCell1.FieldName = "Cell1"
        Me.colCell1.Name = "colCell1"
        '
        'colCell2
        '
        Me.colCell2.FieldName = "Cell2"
        Me.colCell2.Name = "colCell2"
        '
        'colTipoDoc
        '
        Me.colTipoDoc.FieldName = "TipoDoc"
        Me.colTipoDoc.Name = "colTipoDoc"
        Me.colTipoDoc.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colTipoPrestazione
        '
        Me.colTipoPrestazione.FieldName = "TipoPrestazione"
        Me.colTipoPrestazione.Name = "colTipoPrestazione"
        Me.colTipoPrestazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colImporto
        '
        Me.colImporto.FieldName = "Importo"
        Me.colImporto.Name = "colImporto"
        '
        'colCausale
        '
        Me.colCausale.FieldName = "Causale"
        Me.colCausale.Name = "colCausale"
        '
        'spReportCompleto
        '
        Me.spReportCompleto.ApplyOutLookStile = True
        Me.spReportCompleto.BackColor = System.Drawing.Color.Transparent
        Me.spReportCompleto.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.USERS_FOLDER
        Me.spReportCompleto.Disabled = False
        Me.spReportCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.spReportCompleto.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.spReportCompleto, "Funzione che permette di stampare il report.")
        Me.spReportCompleto.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.spReportCompleto.Location = New System.Drawing.Point(332, 6)
        Me.spReportCompleto.Name = "spReportCompleto"
        Me.spReportCompleto.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.spReportCompleto, True)
        Me.spReportCompleto.ShowTooltip = True
        Me.spReportCompleto.Size = New System.Drawing.Size(32, 32)
        Me.spReportCompleto.TabIndex = 125
        Me.spReportCompleto.TextValue = ""
        Me.spReportCompleto.TooltipText = "Esporta iscritti e non iscritti per azienda"
        '
        'ReportIscrittiDTO
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReportIscrittiDTO"
        Me.Size = New System.Drawing.Size(697, 663)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IscrittoDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblContratto As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblCompetenza As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents numIsc As System.Windows.Forms.TextBox
    Friend WithEvents numRevCGL As System.Windows.Forms.TextBox
    Friend WithEvents numNew As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblVerifica As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NumRevCisl As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdPrintCard As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents spview As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents spExport As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents lblEnte As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents IscrittoDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeEnte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAziendaImpiego As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompetenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLivello As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodice_Fiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Nazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCell1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCell2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPrestazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpecialButton1 As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents spReportCompleto As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton

End Class
