<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPropostaLavoro
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPropostaLavoro))
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.ListBox1 = New System.Windows.Forms.ListBox
      Me.IdOffertaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdOffertaTextBox
      Me.lblAziendaDescrizione = New System.Windows.Forms.Label
      Me.lblOfferta = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.dtpDoc = New System.Windows.Forms.DateTimePicker
      Me.Label6 = New System.Windows.Forms.Label
      Me.dtpData = New System.Windows.Forms.DateTimePicker
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtNote = New System.Windows.Forms.TextBox
      Me.lblDescrizioneUtente = New System.Windows.Forms.Label
      Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
      Me.lblUtente = New System.Windows.Forms.Label
      Me.txtId = New System.Windows.Forms.TextBox
      Me.lblId = New System.Windows.Forms.Label
      Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.cboSkill = New System.Windows.Forms.ComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.MainGroup.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(501, 30)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.lblId)
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Controls.Add(Me.txtId)
      Me.DockPanel.Size = New System.Drawing.Size(501, 44)
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(110, 3)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(279, 38)
      Me.CustomBar1.TabIndex = 47
      '
      'MainGroup
      '
      Me.MainGroup.BackColor = System.Drawing.Color.Silver
      Me.MainGroup.Controls.Add(Me.Label4)
      Me.MainGroup.Controls.Add(Me.ListBox1)
      Me.MainGroup.Controls.Add(Me.IdOffertaTextBox1)
      Me.MainGroup.Controls.Add(Me.lblAziendaDescrizione)
      Me.MainGroup.Controls.Add(Me.lblOfferta)
      Me.MainGroup.Controls.Add(Me.Label1)
      Me.MainGroup.Controls.Add(Me.dtpDoc)
      Me.MainGroup.Controls.Add(Me.Label6)
      Me.MainGroup.Controls.Add(Me.dtpData)
      Me.MainGroup.Controls.Add(Me.Label3)
      Me.MainGroup.Controls.Add(Me.txtNote)
      Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.MainGroup.ForeColor = System.Drawing.Color.Black
      Me.MainGroup.Location = New System.Drawing.Point(25, 111)
      Me.MainGroup.Name = "MainGroup"
      Me.MainGroup.Size = New System.Drawing.Size(385, 267)
      Me.MainGroup.TabIndex = 45
      Me.MainGroup.Text = "Dati principali"
      Me.MainGroup.Title = "Dati proposta"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(4, 164)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(79, 13)
      Me.Label4.TabIndex = 52
      Me.Label4.Text = "Skill  domanda "
      '
      'ListBox1
      '
      Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ListBox1.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.ListBox1, resources.GetString("ListBox1.HelpString"))
      Me.ListBox1.Location = New System.Drawing.Point(85, 160)
      Me.ListBox1.Name = "ListBox1"
      Me.HelpProvider1.SetShowHelp(Me.ListBox1, True)
      Me.ListBox1.Size = New System.Drawing.Size(279, 95)
      Me.ListBox1.TabIndex = 51
      '
      'IdOffertaTextBox1
      '
      Me.IdOffertaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdOffertaTextBox1.DescriptionOfText = ""
      Me.IdOffertaTextBox1.DescriptionTextWidth = 150
      Me.IdOffertaTextBox1.DescriptionTextXValue = 92
      Me.IdOffertaTextBox1.EnableSerchTextBox = True
      Me.IdOffertaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.IdOffertaTextBox1, "Identificativo della domanda di lavoro,da parte di un'azienda,da proporre all'ute" & _
              "nte.")
      Me.IdOffertaTextBox1.IsDescriptionVisible = False
      Me.IdOffertaTextBox1.Location = New System.Drawing.Point(84, 53)
      Me.IdOffertaTextBox1.Mandatory = False
      Me.IdOffertaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdOffertaTextBox1.Name = "IdOffertaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdOffertaTextBox1, True)
      Me.IdOffertaTextBox1.Size = New System.Drawing.Size(96, 24)
      Me.IdOffertaTextBox1.TabIndex = 50
      Me.IdOffertaTextBox1.TextValue = ""
      '
      'lblAziendaDescrizione
      '
      Me.lblAziendaDescrizione.AutoSize = True
      Me.lblAziendaDescrizione.BackColor = System.Drawing.Color.Transparent
      Me.lblAziendaDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAziendaDescrizione.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblAziendaDescrizione.Location = New System.Drawing.Point(181, 62)
      Me.lblAziendaDescrizione.Name = "lblAziendaDescrizione"
      Me.lblAziendaDescrizione.Size = New System.Drawing.Size(11, 13)
      Me.lblAziendaDescrizione.TabIndex = 49
      Me.lblAziendaDescrizione.Text = " "
      '
      'lblOfferta
      '
      Me.lblOfferta.AutoSize = True
      Me.lblOfferta.BackColor = System.Drawing.Color.Transparent
      Me.lblOfferta.Cursor = System.Windows.Forms.Cursors.Hand
      Me.lblOfferta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblOfferta.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblOfferta.Location = New System.Drawing.Point(12, 58)
      Me.lblOfferta.Name = "lblOfferta"
      Me.lblOfferta.Size = New System.Drawing.Size(63, 13)
      Me.lblOfferta.TabIndex = 50
      Me.lblOfferta.Text = "Id domanda"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(207, 29)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(54, 13)
      Me.Label1.TabIndex = 33
      Me.Label1.Text = "Data doc."
      '
      'dtpDoc
      '
      Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpDoc, resources.GetString("dtpDoc.HelpString"))
      Me.dtpDoc.Location = New System.Drawing.Point(268, 25)
      Me.dtpDoc.Name = "dtpDoc"
      Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
      Me.dtpDoc.Size = New System.Drawing.Size(96, 20)
      Me.dtpDoc.TabIndex = 2
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label6.Location = New System.Drawing.Point(26, 27)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(51, 13)
      Me.Label6.TabIndex = 30
      Me.Label6.Text = "Data reg."
      '
      'dtpData
      '
      Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpData, resources.GetString("dtpData.HelpString"))
      Me.dtpData.Location = New System.Drawing.Point(84, 25)
      Me.dtpData.Name = "dtpData"
      Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
      Me.dtpData.Size = New System.Drawing.Size(96, 20)
      Me.dtpData.TabIndex = 1
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(41, 92)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(30, 13)
      Me.Label3.TabIndex = 28
      Me.Label3.Text = "Note"
      '
      'txtNote
      '
      Me.txtNote.AcceptsReturn = True
      Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note sulla proposta di lavoro.")
      Me.txtNote.Location = New System.Drawing.Point(85, 93)
      Me.txtNote.Multiline = True
      Me.txtNote.Name = "txtNote"
      Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
      Me.txtNote.Size = New System.Drawing.Size(279, 61)
      Me.txtNote.TabIndex = 4
      '
      'lblDescrizioneUtente
      '
      Me.lblDescrizioneUtente.AutoSize = True
      Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblDescrizioneUtente.Location = New System.Drawing.Point(160, 33)
      Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
      Me.lblDescrizioneUtente.Size = New System.Drawing.Size(11, 13)
      Me.lblDescrizioneUtente.TabIndex = 0
      Me.lblDescrizioneUtente.Text = " "
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
      Me.IdUtenteTextBox1.Location = New System.Drawing.Point(85, 23)
      Me.IdUtenteTextBox1.Mandatory = False
      Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
      Me.IdUtenteTextBox1.Size = New System.Drawing.Size(91, 23)
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
      Me.lblUtente.Location = New System.Drawing.Point(28, 31)
      Me.lblUtente.Name = "lblUtente"
      Me.lblUtente.Size = New System.Drawing.Size(49, 13)
      Me.lblUtente.TabIndex = 13
      Me.lblUtente.Text = "Id utente"
      '
      'txtId
      '
      Me.txtId.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.txtId, "Identificativo della proposta di lavoro")
      Me.txtId.Location = New System.Drawing.Point(45, 11)
      Me.txtId.Name = "txtId"
      Me.HelpProvider1.SetShowHelp(Me.txtId, True)
      Me.txtId.Size = New System.Drawing.Size(51, 21)
      Me.txtId.TabIndex = 49
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Location = New System.Drawing.Point(22, 17)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(17, 13)
      Me.lblId.TabIndex = 48
      Me.lblId.Text = "Id"
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.Color.Silver
      Me.GroupBox1.Controls.Add(Me.cboSkill)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.IdUtenteTextBox1)
      Me.GroupBox1.Controls.Add(Me.lblUtente)
      Me.GroupBox1.Controls.Add(Me.lblDescrizioneUtente)
      Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox1.ForeColor = System.Drawing.Color.Black
      Me.GroupBox1.Location = New System.Drawing.Point(25, 384)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(385, 102)
      Me.GroupBox1.TabIndex = 50
      Me.GroupBox1.Text = "Dati utente"
      Me.GroupBox1.Title = "Dati utente"
      '
      'cboSkill
      '
      Me.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSkill.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboSkill, "Competenze professionali offerte dall'utente.")
      Me.cboSkill.Location = New System.Drawing.Point(84, 61)
      Me.cboSkill.Name = "cboSkill"
      Me.HelpProvider1.SetShowHelp(Me.cboSkill, True)
      Me.cboSkill.Size = New System.Drawing.Size(153, 21)
      Me.cboSkill.TabIndex = 15
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(35, 69)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(39, 13)
      Me.Label2.TabIndex = 14
      Me.Label2.Text = "Offerta"
      '
      'ControlPropostaLavoro
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.MainGroup)
      Me.Name = "ControlPropostaLavoro"
      Me.Size = New System.Drawing.Size(501, 495)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.MainGroup, 0)
      Me.Controls.SetChildIndex(Me.GroupBox1, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      Me.MainGroup.ResumeLayout(False)
      Me.MainGroup.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblUtente As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblAziendaDescrizione As System.Windows.Forms.Label
    Friend WithEvents lblOfferta As System.Windows.Forms.Label
    Friend WithEvents IdOffertaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdOffertaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents cboSkill As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
