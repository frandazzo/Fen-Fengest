<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportLiberi
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
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.GridPosizioni = New System.Windows.Forms.DataGridView
      Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.numIsc = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.lblSogg = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.lblEnte = New System.Windows.Forms.Label
      Me.Label23 = New System.Windows.Forms.Label
      Me.lblCompetenza = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.lblData = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.spview = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.DockPanel.SuspendLayout()
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox2.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(676, 30)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.spview)
      Me.DockPanel.Controls.Add(Me.cmdPrint)
      Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
      Me.DockPanel.Size = New System.Drawing.Size(676, 44)
      '
      'GridPosizioni
      '
      Me.GridPosizioni.AllowUserToAddRows = False
      Me.GridPosizioni.AllowUserToDeleteRows = False
      Me.GridPosizioni.AllowUserToOrderColumns = True
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.NullValue = Nothing
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridPosizioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridPosizioni.BackgroundColor = System.Drawing.Color.WhiteSmoke
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
      Me.GridPosizioni.Location = New System.Drawing.Point(15, 197)
      Me.GridPosizioni.MultiSelect = False
      Me.GridPosizioni.Name = "GridPosizioni"
      Me.GridPosizioni.ReadOnly = True
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridPosizioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      Me.GridPosizioni.RowHeadersVisible = False
      Me.GridPosizioni.RowHeadersWidth = 30
      DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
      Me.GridPosizioni.RowsDefaultCellStyle = DataGridViewCellStyle5
      Me.GridPosizioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridPosizioni.Size = New System.Drawing.Size(541, 407)
      Me.GridPosizioni.TabIndex = 120
      '
      'GroupBox2
      '
      Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
      Me.GroupBox2.Controls.Add(Me.numIsc)
      Me.GroupBox2.Controls.Add(Me.Label3)
      Me.GroupBox2.Controls.Add(Me.lblSogg)
      Me.GroupBox2.Controls.Add(Me.Label20)
      Me.GroupBox2.Controls.Add(Me.lblEnte)
      Me.GroupBox2.Controls.Add(Me.Label23)
      Me.GroupBox2.Controls.Add(Me.lblCompetenza)
      Me.GroupBox2.Controls.Add(Me.Label21)
      Me.GroupBox2.Controls.Add(Me.lblData)
      Me.GroupBox2.Controls.Add(Me.Label2)
      Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox2.ForeColor = System.Drawing.Color.Black
      Me.GroupBox2.Location = New System.Drawing.Point(15, 99)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(619, 92)
      Me.GroupBox2.TabIndex = 119
      Me.GroupBox2.Text = "Dati report"
      Me.GroupBox2.Title = "Dati report"
      '
      'numIsc
      '
      Me.numIsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.numIsc.Location = New System.Drawing.Point(553, 22)
      Me.numIsc.Name = "numIsc"
      Me.numIsc.Size = New System.Drawing.Size(51, 20)
      Me.numIsc.TabIndex = 79
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(467, 27)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(80, 13)
      Me.Label3.TabIndex = 76
      Me.Label3.Text = "Totale posizioni"
      '
      'lblSogg
      '
      Me.lblSogg.AutoSize = True
      Me.lblSogg.Location = New System.Drawing.Point(320, 53)
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
      Me.Label20.Location = New System.Drawing.Point(227, 53)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(87, 13)
      Me.Label20.TabIndex = 91
      Me.Label20.Text = "Azienda impiego:"
      '
      'lblEnte
      '
      Me.lblEnte.AutoSize = True
      Me.lblEnte.Location = New System.Drawing.Point(90, 53)
      Me.lblEnte.MaximumSize = New System.Drawing.Size(120, 0)
      Me.lblEnte.Name = "lblEnte"
      Me.lblEnte.Size = New System.Drawing.Size(33, 13)
      Me.lblEnte.TabIndex = 90
      Me.lblEnte.Text = "Ente"
      '
      'Label23
      '
      Me.Label23.AutoSize = True
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(46, 53)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(32, 13)
      Me.Label23.TabIndex = 89
      Me.Label23.Text = "Ente:"
      '
      'lblCompetenza
      '
      Me.lblCompetenza.AutoSize = True
      Me.lblCompetenza.Location = New System.Drawing.Point(320, 27)
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
      Me.Label21.Location = New System.Drawing.Point(268, 27)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(46, 13)
      Me.Label21.TabIndex = 85
      Me.Label21.Text = "Periodo:"
      '
      'lblData
      '
      Me.lblData.AutoSize = True
      Me.lblData.Location = New System.Drawing.Point(90, 27)
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
      Me.Label2.Location = New System.Drawing.Point(23, 27)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(63, 13)
      Me.Label2.TabIndex = 77
      Me.Label2.Text = "Data report:"
      '
      'Panel1
      '
      Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
      Me.Panel1.Controls.Add(Me.CmdDown)
      Me.Panel1.Controls.Add(Me.cmdUp)
      Me.Panel1.Location = New System.Drawing.Point(562, 197)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(78, 180)
      Me.Panel1.TabIndex = 123
      '
      'CmdDown
      '
      Me.CmdDown.ApplyOutLookStile = True
      Me.CmdDown.BackColor = System.Drawing.Color.Transparent
      Me.CmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDown.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
      Me.CmdDown.Disabled = False
      Me.CmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdDown.ForeColor = System.Drawing.Color.Transparent
      Me.CmdDown.Location = New System.Drawing.Point(12, 90)
      Me.CmdDown.Name = "CmdDown"
      Me.CmdDown.Radius = 48.0!
      Me.CmdDown.ShowTooltip = True
      Me.CmdDown.Size = New System.Drawing.Size(48, 48)
      Me.CmdDown.TabIndex = 110
      Me.CmdDown.TextValue = ""
      Me.CmdDown.TooltipText = "Ordina dal basso"
      '
      'cmdUp
      '
      Me.cmdUp.ApplyOutLookStile = True
      Me.cmdUp.BackColor = System.Drawing.Color.Transparent
      Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdUp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
      Me.cmdUp.Disabled = False
      Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdUp.ForeColor = System.Drawing.Color.Transparent
      Me.cmdUp.Location = New System.Drawing.Point(13, 29)
      Me.cmdUp.Name = "cmdUp"
      Me.cmdUp.Radius = 48.0!
      Me.cmdUp.ShowTooltip = True
      Me.cmdUp.Size = New System.Drawing.Size(48, 48)
      Me.cmdUp.TabIndex = 109
      Me.cmdUp.TextValue = ""
      Me.cmdUp.TooltipText = "Ordina dall'alto"
      '
      'cmdListaLavoro
      '
      Me.cmdListaLavoro.ApplyOutLookStile = True
      Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
      Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_address_book_32x32
      Me.cmdListaLavoro.Disabled = False
      Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdListaLavoro, "Funzione che permette di creare una lista di lavoro composta dai lavoratori che r" & _
              "isultano liberi.")
      Me.cmdListaLavoro.Location = New System.Drawing.Point(15, 7)
      Me.cmdListaLavoro.Name = "cmdListaLavoro"
      Me.cmdListaLavoro.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdListaLavoro, True)
      Me.cmdListaLavoro.ShowTooltip = True
      Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
      Me.cmdListaLavoro.TabIndex = 122
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
      Me.cmdPrint.Location = New System.Drawing.Point(69, 6)
      Me.cmdPrint.Name = "cmdPrint"
      Me.cmdPrint.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdPrint, True)
      Me.cmdPrint.ShowTooltip = True
      Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
      Me.cmdPrint.TabIndex = 121
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
      Me.spview.Location = New System.Drawing.Point(120, 6)
      Me.spview.Name = "spview"
      Me.spview.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.spview, True)
      Me.spview.ShowTooltip = True
      Me.spview.Size = New System.Drawing.Size(32, 32)
      Me.spview.TabIndex = 123
      Me.spview.TextValue = ""
      Me.spview.TooltipText = "Cambia visualizzazione"
      '
      'ReportLiberi
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.GridPosizioni)
      Me.Controls.Add(Me.Panel1)
      Me.Name = "ReportLiberi"
      Me.Size = New System.Drawing.Size(676, 620)
      Me.Controls.SetChildIndex(Me.Panel1, 0)
      Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
      Me.Controls.SetChildIndex(Me.GroupBox2, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.DockPanel.ResumeLayout(False)
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents lblSogg As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents lblEnte As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents lblCompetenza As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents lblData As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents numIsc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents spview As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton

End Class
