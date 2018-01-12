<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlComunicazione
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlComunicazione))
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox
      Me.cboTipo = New System.Windows.Forms.ComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboCausale = New System.Windows.Forms.ComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtNote = New System.Windows.Forms.TextBox
      Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
      Me.lblUtente = New System.Windows.Forms.Label
      Me.lblDescrizioneUtente = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.dtpData = New System.Windows.Forms.DateTimePicker
      Me.cmdCreateDocument = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdTags = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.SpDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Label5 = New System.Windows.Forms.Label
      Me.SpAddFile = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.SpDelRef = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.lblDocumento = New System.Windows.Forms.Label
      Me.SpView = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.txtId = New System.Windows.Forms.TextBox
      Me.lblId = New System.Windows.Forms.Label
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Button1 = New System.Windows.Forms.Button
      Me.cmdModello = New System.Windows.Forms.Button
      Me.lblModello = New System.Windows.Forms.Label
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.DockPanel.SuspendLayout()
      Me.MainGroup.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(583, 26)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Controls.Add(Me.txtId)
      Me.DockPanel.Controls.Add(Me.lblId)
      Me.DockPanel.Location = New System.Drawing.Point(0, 26)
      Me.DockPanel.Size = New System.Drawing.Size(583, 44)
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(95, 3)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(296, 40)
      Me.CustomBar1.TabIndex = 52
      '
      'MainGroup
      '
      Me.MainGroup.BackColor = System.Drawing.Color.Silver
      Me.MainGroup.Controls.Add(Me.cboTipo)
      Me.MainGroup.Controls.Add(Me.Label4)
      Me.MainGroup.Controls.Add(Me.cboCausale)
      Me.MainGroup.Controls.Add(Me.Label2)
      Me.MainGroup.Controls.Add(Me.Label3)
      Me.MainGroup.Controls.Add(Me.txtNote)
      Me.MainGroup.Controls.Add(Me.IdUtenteTextBox1)
      Me.MainGroup.Controls.Add(Me.lblUtente)
      Me.MainGroup.Controls.Add(Me.lblDescrizioneUtente)
      Me.MainGroup.Controls.Add(Me.Label6)
      Me.MainGroup.Controls.Add(Me.dtpData)
      Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.MainGroup.ForeColor = System.Drawing.Color.Black
      Me.MainGroup.Location = New System.Drawing.Point(11, 86)
      Me.MainGroup.Name = "MainGroup"
      Me.MainGroup.Size = New System.Drawing.Size(479, 285)
      Me.MainGroup.TabIndex = 51
      Me.MainGroup.Text = "Dati principali"
      Me.MainGroup.Title = "Comunicazione"
      '
      'cboTipo
      '
      Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipo.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipo di comunicazione inviata. I tipi di comunicazione possono essere impostati d" & _
              "al menu Strumenti->Setup->Utenti->Tipi comunicazione")
      Me.cboTipo.Location = New System.Drawing.Point(76, 127)
      Me.cboTipo.Name = "cboTipo"
      Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
      Me.cboTipo.Size = New System.Drawing.Size(194, 21)
      Me.cboTipo.TabIndex = 69
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(17, 135)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(53, 13)
      Me.Label4.TabIndex = 68
      Me.Label4.Text = "Tipo com."
      '
      'cboCausale
      '
      Me.cboCausale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCausale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCausale.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboCausale, "Causale della comunicazione inviata. Le causali delle comunicazione possono esser" & _
              "e impostati dal menu Strumenti->Setup->Utenti->Causali comunicazione.")
      Me.cboCausale.Location = New System.Drawing.Point(76, 97)
      Me.cboCausale.Name = "cboCausale"
      Me.HelpProvider1.SetShowHelp(Me.cboCausale, True)
      Me.cboCausale.Size = New System.Drawing.Size(194, 21)
      Me.cboCausale.TabIndex = 67
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(25, 102)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(45, 13)
      Me.Label2.TabIndex = 66
      Me.Label2.Text = "Causale"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(40, 164)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(30, 13)
      Me.Label3.TabIndex = 60
      Me.Label3.Text = "Note"
      '
      'txtNote
      '
      Me.txtNote.AcceptsReturn = True
      Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note")
      Me.txtNote.Location = New System.Drawing.Point(76, 161)
      Me.txtNote.Multiline = True
      Me.txtNote.Name = "txtNote"
      Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
      Me.txtNote.Size = New System.Drawing.Size(383, 113)
      Me.txtNote.TabIndex = 59
      '
      'IdUtenteTextBox1
      '
      Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdUtenteTextBox1.EnableSerchTextBox = True
      Me.IdUtenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente a cui inviare la comunicazione")
      Me.IdUtenteTextBox1.Location = New System.Drawing.Point(75, 65)
      Me.IdUtenteTextBox1.Mandatory = True
      Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
      Me.IdUtenteTextBox1.Size = New System.Drawing.Size(90, 25)
      Me.IdUtenteTextBox1.TabIndex = 54
      Me.IdUtenteTextBox1.TextValue = ""
      '
      'lblUtente
      '
      Me.lblUtente.AutoSize = True
      Me.lblUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblUtente.Cursor = System.Windows.Forms.Cursors.Hand
      Me.lblUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblUtente.Location = New System.Drawing.Point(18, 70)
      Me.lblUtente.Name = "lblUtente"
      Me.lblUtente.Size = New System.Drawing.Size(52, 13)
      Me.lblUtente.TabIndex = 55
      Me.lblUtente.Text = "Id utente"
      '
      'lblDescrizioneUtente
      '
      Me.lblDescrizioneUtente.AutoSize = True
      Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
      Me.lblDescrizioneUtente.Location = New System.Drawing.Point(171, 70)
      Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
      Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneUtente.TabIndex = 53
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label6.Location = New System.Drawing.Point(40, 43)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(30, 13)
      Me.Label6.TabIndex = 30
      Me.Label6.Text = "Data"
      '
      'dtpData
      '
      Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpData, "Data in cui si registra la comunicazione all'utente")
      Me.dtpData.Location = New System.Drawing.Point(76, 36)
      Me.dtpData.Name = "dtpData"
      Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
      Me.dtpData.Size = New System.Drawing.Size(106, 20)
      Me.dtpData.TabIndex = 1
      '
      'cmdCreateDocument
      '
      Me.cmdCreateDocument.ApplyOutLookStile = True
      Me.cmdCreateDocument.BackColor = System.Drawing.Color.Transparent
      Me.cmdCreateDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdCreateDocument.BackImage = CType(resources.GetObject("cmdCreateDocument.BackImage"), System.Drawing.Image)
      Me.cmdCreateDocument.Disabled = False
      Me.cmdCreateDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdCreateDocument.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdCreateDocument, "Funzione che permette di creare un documento word per la comunicazione, utilizzan" & _
              "do il modello selezionato.")
      Me.cmdCreateDocument.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdCreateDocument.Location = New System.Drawing.Point(438, 33)
      Me.cmdCreateDocument.Name = "cmdCreateDocument"
      Me.cmdCreateDocument.Radius = 30.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdCreateDocument, True)
      Me.cmdCreateDocument.ShowTooltip = True
      Me.cmdCreateDocument.Size = New System.Drawing.Size(30, 30)
      Me.cmdCreateDocument.TabIndex = 70
      Me.cmdCreateDocument.TextValue = ""
      Me.cmdCreateDocument.TooltipText = "Crea documento e allega alla comunicazione"
      '
      'cmdTags
      '
      Me.cmdTags.ApplyOutLookStile = True
      Me.cmdTags.BackColor = System.Drawing.Color.Transparent
      Me.cmdTags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdTags.BackImage = CType(resources.GetObject("cmdTags.BackImage"), System.Drawing.Image)
      Me.cmdTags.Disabled = False
      Me.cmdTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdTags.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdTags, "Funzione che permette di inserire dei tag supplementari al documento word da crea" & _
              "re.")
      Me.cmdTags.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdTags.Location = New System.Drawing.Point(399, 32)
      Me.cmdTags.Name = "cmdTags"
      Me.cmdTags.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdTags, True)
      Me.cmdTags.ShowTooltip = True
      Me.cmdTags.Size = New System.Drawing.Size(32, 32)
      Me.cmdTags.TabIndex = 65
      Me.cmdTags.TextValue = ""
      Me.cmdTags.TooltipText = "Inserisci tag supplementari modello Word"
      '
      'SpDel
      '
      Me.SpDel.ApplyOutLookStile = True
      Me.SpDel.BackColor = System.Drawing.Color.Transparent
      Me.SpDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_32x32
      Me.SpDel.Disabled = False
      Me.SpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpDel.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpDel, "Funzione che permette di eliminare il file allegato alla comunicazione dalla memo" & _
              "ria del sistema.")
      Me.SpDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpDel.Location = New System.Drawing.Point(126, 102)
      Me.SpDel.Name = "SpDel"
      Me.SpDel.Radius = 37.0!
      Me.HelpProvider1.SetShowHelp(Me.SpDel, True)
      Me.SpDel.ShowTooltip = True
      Me.SpDel.Size = New System.Drawing.Size(37, 37)
      Me.SpDel.TabIndex = 60
      Me.SpDel.TextValue = ""
      Me.SpDel.TooltipText = "Elimina file"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(17, 162)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(65, 13)
      Me.Label5.TabIndex = 72
      Me.Label5.Text = "Documento:"
      '
      'SpAddFile
      '
      Me.SpAddFile.ApplyOutLookStile = True
      Me.SpAddFile.BackColor = System.Drawing.Color.Transparent
      Me.SpAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpAddFile.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_add_32x32
      Me.SpAddFile.Disabled = False
      Me.SpAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpAddFile.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpAddFile, "Funzione che permette di allegare un file alla comunicazione.")
      Me.SpAddFile.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpAddFile.Location = New System.Drawing.Point(53, 102)
      Me.SpAddFile.Name = "SpAddFile"
      Me.SpAddFile.Radius = 37.0!
      Me.HelpProvider1.SetShowHelp(Me.SpAddFile, True)
      Me.SpAddFile.ShowTooltip = True
      Me.SpAddFile.Size = New System.Drawing.Size(37, 37)
      Me.SpAddFile.TabIndex = 57
      Me.SpAddFile.TextValue = ""
      Me.SpAddFile.TooltipText = "Allega file"
      '
      'SpDelRef
      '
      Me.SpDelRef.ApplyOutLookStile = True
      Me.SpDelRef.BackColor = System.Drawing.Color.Transparent
      Me.SpDelRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpDelRef.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_feneal_32x32
      Me.SpDelRef.Disabled = False
      Me.SpDelRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpDelRef.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpDelRef, "Funzione che permette di eliminare il file allegato alla comunicazione.Eliminare " & _
              "il riferimento al file non comporta l'eliminazione del file stesso dalla memoria" & _
              " del sistema.")
      Me.SpDelRef.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpDelRef.Location = New System.Drawing.Point(91, 102)
      Me.SpDelRef.Name = "SpDelRef"
      Me.SpDelRef.Radius = 37.0!
      Me.HelpProvider1.SetShowHelp(Me.SpDelRef, True)
      Me.SpDelRef.ShowTooltip = True
      Me.SpDelRef.Size = New System.Drawing.Size(37, 37)
      Me.SpDelRef.TabIndex = 59
      Me.SpDelRef.TextValue = ""
      Me.SpDelRef.TooltipText = "Elimina riferimento"
      '
      'lblDocumento
      '
      Me.lblDocumento.AutoEllipsis = True
      Me.lblDocumento.AutoSize = True
      Me.lblDocumento.BackColor = System.Drawing.Color.Transparent
      Me.lblDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDocumento.Location = New System.Drawing.Point(88, 162)
      Me.lblDocumento.MaximumSize = New System.Drawing.Size(320, 0)
      Me.lblDocumento.Name = "lblDocumento"
      Me.lblDocumento.Size = New System.Drawing.Size(114, 13)
      Me.lblDocumento.TabIndex = 0
      Me.lblDocumento.Text = "Nessun documento"
      '
      'SpView
      '
      Me.SpView.ApplyOutLookStile = True
      Me.SpView.BackColor = System.Drawing.Color.Transparent
      Me.SpView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpView.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_open_32x32
      Me.SpView.Disabled = False
      Me.SpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpView.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpView, "Funzione che permette di aprire il file allegato alla comunicazione.")
      Me.SpView.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpView.Location = New System.Drawing.Point(16, 102)
      Me.SpView.Name = "SpView"
      Me.SpView.Radius = 37.0!
      Me.HelpProvider1.SetShowHelp(Me.SpView, True)
      Me.SpView.ShowTooltip = True
      Me.SpView.Size = New System.Drawing.Size(37, 37)
      Me.SpView.TabIndex = 58
      Me.SpView.TextValue = ""
      Me.SpView.TooltipText = "Apri file"
      '
      'txtId
      '
      Me.txtId.Enabled = False
      Me.txtId.Location = New System.Drawing.Point(39, 14)
      Me.txtId.Name = "txtId"
      Me.txtId.Size = New System.Drawing.Size(42, 21)
      Me.txtId.TabIndex = 54
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Location = New System.Drawing.Point(16, 18)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(17, 13)
      Me.lblId.TabIndex = 53
      Me.lblId.Text = "Id"
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.Color.Silver
      Me.GroupBox1.Controls.Add(Me.Button1)
      Me.GroupBox1.Controls.Add(Me.cmdModello)
      Me.GroupBox1.Controls.Add(Me.lblModello)
      Me.GroupBox1.Controls.Add(Me.PictureBox1)
      Me.GroupBox1.Controls.Add(Me.cmdCreateDocument)
      Me.GroupBox1.Controls.Add(Me.SpDelRef)
      Me.GroupBox1.Controls.Add(Me.cmdTags)
      Me.GroupBox1.Controls.Add(Me.SpDel)
      Me.GroupBox1.Controls.Add(Me.SpView)
      Me.GroupBox1.Controls.Add(Me.Label5)
      Me.GroupBox1.Controls.Add(Me.lblDocumento)
      Me.GroupBox1.Controls.Add(Me.SpAddFile)
      Me.GroupBox1.ForeColor = System.Drawing.Color.Black
      Me.GroupBox1.Location = New System.Drawing.Point(11, 378)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(479, 195)
      Me.GroupBox1.TabIndex = 52
      Me.GroupBox1.Title = "Allegato"
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(12, 56)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(116, 27)
      Me.Button1.TabIndex = 78
      Me.Button1.Text = "&Deseleziona modello"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'cmdModello
      '
      Me.cmdModello.Location = New System.Drawing.Point(12, 25)
      Me.cmdModello.Name = "cmdModello"
      Me.cmdModello.Size = New System.Drawing.Size(116, 27)
      Me.cmdModello.TabIndex = 77
      Me.cmdModello.Text = "&Seleziona modello"
      Me.cmdModello.UseVisualStyleBackColor = True
      '
      'lblModello
      '
      Me.lblModello.AutoSize = True
      Me.lblModello.BackColor = System.Drawing.Color.Transparent
      Me.lblModello.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblModello.Location = New System.Drawing.Point(144, 35)
      Me.lblModello.MaximumSize = New System.Drawing.Size(260, 0)
      Me.lblModello.Name = "lblModello"
      Me.lblModello.Size = New System.Drawing.Size(0, 13)
      Me.lblModello.TabIndex = 76
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Location = New System.Drawing.Point(427, 102)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox1.TabIndex = 75
      Me.PictureBox1.TabStop = False
      '
      'ControlComunicazione
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.MainGroup)
      Me.Name = "ControlComunicazione"
      Me.Size = New System.Drawing.Size(583, 586)
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
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents lblDocumento As System.Windows.Forms.Label
   Friend WithEvents SpAddFile As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpView As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpDelRef As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdTags As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboCausale As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdCreateDocument As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblModello As System.Windows.Forms.Label
   Friend WithEvents cmdModello As System.Windows.Forms.Button
   Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
