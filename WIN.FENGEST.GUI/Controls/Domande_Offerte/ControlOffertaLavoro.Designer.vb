<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlOffertaLavoro
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
      Me.grpEventi = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.CmdSel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdAdd = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.GridItems = New System.Windows.Forms.DataGridView
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.lblAziendaDescrizione = New System.Windows.Forms.Label
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.lblAzienda = New System.Windows.Forms.Label
      Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.dtpDf = New System.Windows.Forms.DateTimePicker
      Me.Label1 = New System.Windows.Forms.Label
      Me.dtpDi = New System.Windows.Forms.DateTimePicker
      Me.Label6 = New System.Windows.Forms.Label
      Me.dtpData = New System.Windows.Forms.DateTimePicker
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtNote = New System.Windows.Forms.TextBox
      Me.txtId = New System.Windows.Forms.TextBox
      Me.lblId = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.grpEventi.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      CType(Me.GridItems, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.MainGroup.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(724, 22)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.lblId)
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Controls.Add(Me.txtId)
      Me.DockPanel.Location = New System.Drawing.Point(0, 23)
      Me.DockPanel.Size = New System.Drawing.Size(724, 44)
      '
      'grpEventi
      '
      Me.grpEventi.BackColor = System.Drawing.Color.Silver
      Me.grpEventi.Controls.Add(Me.Panel1)
      Me.grpEventi.Controls.Add(Me.TabControl1)
      Me.grpEventi.Location = New System.Drawing.Point(11, 310)
      Me.grpEventi.Name = "grpEventi"
      Me.grpEventi.Size = New System.Drawing.Size(605, 255)
      Me.grpEventi.TabIndex = 56
      Me.grpEventi.Title = "Posizioni domanda"
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.Color.Transparent
      Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
      Me.Panel1.Controls.Add(Me.CmdSel)
      Me.Panel1.Controls.Add(Me.CmdAdd)
      Me.Panel1.Controls.Add(Me.CmdDel)
      Me.Panel1.Location = New System.Drawing.Point(507, 54)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(79, 181)
      Me.Panel1.TabIndex = 53
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
      Me.HelpProvider1.SetHelpString(Me.CmdSel, "Funzione che permette di visualizzare i dettagli della posizione selezionata dall" & _
              "a lista")
      Me.CmdSel.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdSel.Location = New System.Drawing.Point(16, 12)
      Me.CmdSel.Name = "CmdSel"
      Me.CmdSel.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdSel, True)
      Me.CmdSel.ShowTooltip = True
      Me.CmdSel.Size = New System.Drawing.Size(48, 48)
      Me.CmdSel.TabIndex = 50
      Me.CmdSel.TextValue = ""
      Me.CmdSel.TooltipText = "Seleziona posizione"
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
      Me.HelpProvider1.SetHelpString(Me.CmdAdd, "Funzione che permette di aggiungere una posizione alla domanda di lavoro, ovvero " & _
              "una competenza richiesta dall'azienda ed un livello di professionalità richiesto" & _
              ".")
      Me.CmdAdd.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdAdd.Location = New System.Drawing.Point(16, 62)
      Me.CmdAdd.Name = "CmdAdd"
      Me.CmdAdd.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdAdd, True)
      Me.CmdAdd.ShowTooltip = True
      Me.CmdAdd.Size = New System.Drawing.Size(48, 48)
      Me.CmdAdd.TabIndex = 51
      Me.CmdAdd.TextValue = ""
      Me.CmdAdd.TooltipText = "Aggiungi posizione"
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
      Me.HelpProvider1.SetHelpString(Me.CmdDel, "Funzione che serve per eliminare una posizione dalla domanda di lavoro, ovvero el" & _
              "iminare una competenza professionale richiesta dall'azienda")
      Me.CmdDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDel.Location = New System.Drawing.Point(16, 112)
      Me.CmdDel.Name = "CmdDel"
      Me.CmdDel.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdDel, True)
      Me.CmdDel.ShowTooltip = True
      Me.CmdDel.Size = New System.Drawing.Size(48, 48)
      Me.CmdDel.TabIndex = 52
      Me.CmdDel.TextValue = ""
      Me.CmdDel.TooltipText = "Elimina posizione"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(7, 32)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(482, 203)
      Me.TabControl1.TabIndex = 8
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.GridItems)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(474, 177)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Posizioni domanda"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'GridItems
      '
      Me.GridItems.AllowUserToAddRows = False
      Me.GridItems.AllowUserToDeleteRows = False
      Me.GridItems.AllowUserToOrderColumns = True
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.NullValue = Nothing
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridItems.BackgroundColor = System.Drawing.Color.White
      Me.GridItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.GridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridItems.DefaultCellStyle = DataGridViewCellStyle3
      Me.GridItems.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridItems.GridColor = System.Drawing.Color.LightGray
      Me.GridItems.Location = New System.Drawing.Point(3, 3)
      Me.GridItems.Name = "GridItems"
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      Me.GridItems.RowHeadersWidth = 30
      Me.GridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridItems.Size = New System.Drawing.Size(468, 171)
      Me.GridItems.TabIndex = 56
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(163, 3)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(279, 40)
      Me.CustomBar1.TabIndex = 53
      '
      'lblAziendaDescrizione
      '
      Me.lblAziendaDescrizione.AutoSize = True
      Me.lblAziendaDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAziendaDescrizione.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblAziendaDescrizione.Location = New System.Drawing.Point(181, 99)
      Me.lblAziendaDescrizione.Name = "lblAziendaDescrizione"
      Me.lblAziendaDescrizione.Size = New System.Drawing.Size(11, 13)
      Me.lblAziendaDescrizione.TabIndex = 46
      Me.lblAziendaDescrizione.Text = " "
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.DescriptionOfText = ""
      Me.IdAziendaTextBox1.DescriptionTextWidth = 150
      Me.IdAziendaTextBox1.DescriptionTextXValue = 92
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.IdAziendaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo dell'azienda che fa la domanda di lavoro")
      Me.IdAziendaTextBox1.IsDescriptionVisible = False
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(83, 93)
      Me.IdAziendaTextBox1.Mandatory = False
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(97, 24)
      Me.IdAziendaTextBox1.TabIndex = 3
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'lblAzienda
      '
      Me.lblAzienda.AutoSize = True
      Me.lblAzienda.Cursor = System.Windows.Forms.Cursors.Hand
      Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAzienda.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblAzienda.Location = New System.Drawing.Point(4, 100)
      Me.lblAzienda.Name = "lblAzienda"
      Me.lblAzienda.Size = New System.Drawing.Size(77, 13)
      Me.lblAzienda.TabIndex = 47
      Me.lblAzienda.Text = "Az. richiedente"
      '
      'MainGroup
      '
      Me.MainGroup.BackColor = System.Drawing.Color.Transparent
      Me.MainGroup.Controls.Add(Me.Label2)
      Me.MainGroup.Controls.Add(Me.dtpDf)
      Me.MainGroup.Controls.Add(Me.lblAziendaDescrizione)
      Me.MainGroup.Controls.Add(Me.Label1)
      Me.MainGroup.Controls.Add(Me.IdAziendaTextBox1)
      Me.MainGroup.Controls.Add(Me.lblAzienda)
      Me.MainGroup.Controls.Add(Me.dtpDi)
      Me.MainGroup.Controls.Add(Me.Label6)
      Me.MainGroup.Controls.Add(Me.dtpData)
      Me.MainGroup.Controls.Add(Me.Label3)
      Me.MainGroup.Controls.Add(Me.txtNote)
      Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.MainGroup.ForeColor = System.Drawing.Color.Black
      Me.MainGroup.Location = New System.Drawing.Point(11, 85)
      Me.MainGroup.Name = "MainGroup"
      Me.MainGroup.Size = New System.Drawing.Size(605, 219)
      Me.MainGroup.TabIndex = 46
      Me.MainGroup.Text = "Dati principali"
      Me.MainGroup.Title = "Anagrafica Domanda"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(213, 59)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(63, 13)
      Me.Label2.TabIndex = 49
      Me.Label2.Text = "Fine validità"
      '
      'dtpDf
      '
      Me.dtpDf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpDf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpDf, "Data di fine validità della domanda di lavoro")
      Me.dtpDf.Location = New System.Drawing.Point(282, 55)
      Me.dtpDf.Name = "dtpDf"
      Me.HelpProvider1.SetShowHelp(Me.dtpDf, True)
      Me.dtpDf.Size = New System.Drawing.Size(96, 20)
      Me.dtpDf.TabIndex = 48
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(11, 59)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(67, 13)
      Me.Label1.TabIndex = 33
      Me.Label1.Text = "Inizio validità"
      '
      'dtpDi
      '
      Me.dtpDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpDi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpDi, "Data di inizio di validità della domanda di lavoro")
      Me.dtpDi.Location = New System.Drawing.Point(82, 55)
      Me.dtpDi.Name = "dtpDi"
      Me.HelpProvider1.SetShowHelp(Me.dtpDi, True)
      Me.dtpDi.Size = New System.Drawing.Size(96, 20)
      Me.dtpDi.TabIndex = 2
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label6.Location = New System.Drawing.Point(48, 28)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(30, 13)
      Me.Label6.TabIndex = 30
      Me.Label6.Text = "Data"
      '
      'dtpData
      '
      Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpData, "Data di registrazione della domanda di lavoro da parte dell'azienda")
      Me.dtpData.Location = New System.Drawing.Point(82, 24)
      Me.dtpData.Name = "dtpData"
      Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
      Me.dtpData.Size = New System.Drawing.Size(96, 20)
      Me.dtpData.TabIndex = 1
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(46, 143)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(30, 13)
      Me.Label3.TabIndex = 28
      Me.Label3.Text = "Note"
      '
      'txtNote
      '
      Me.txtNote.AcceptsReturn = True
      Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note")
      Me.txtNote.Location = New System.Drawing.Point(82, 143)
      Me.txtNote.Multiline = True
      Me.txtNote.Name = "txtNote"
      Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
      Me.txtNote.Size = New System.Drawing.Size(417, 62)
      Me.txtNote.TabIndex = 4
      '
      'txtId
      '
      Me.txtId.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.txtId, "Identificativo della domanda di lavoro da parte dell'azienda")
      Me.txtId.Location = New System.Drawing.Point(78, 15)
      Me.txtId.Name = "txtId"
      Me.HelpProvider1.SetShowHelp(Me.txtId, True)
      Me.txtId.Size = New System.Drawing.Size(75, 21)
      Me.txtId.TabIndex = 55
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Location = New System.Drawing.Point(8, 19)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(64, 13)
      Me.lblId.TabIndex = 54
      Me.lblId.Text = "Id domanda"
      '
      'ControlOffertaLavoro
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.grpEventi)
      Me.Controls.Add(Me.MainGroup)
      Me.Name = "ControlOffertaLavoro"
      Me.Size = New System.Drawing.Size(724, 617)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.MainGroup, 0)
      Me.Controls.SetChildIndex(Me.grpEventi, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      Me.grpEventi.ResumeLayout(False)
      Me.Panel1.ResumeLayout(False)
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      CType(Me.GridItems, System.ComponentModel.ISupportInitialize).EndInit()
      Me.MainGroup.ResumeLayout(False)
      Me.MainGroup.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents grpEventi As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GridItems As System.Windows.Forms.DataGridView
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents lblAziendaDescrizione As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents lblAzienda As System.Windows.Forms.Label
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents dtpDi As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents CmdSel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdAdd As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
