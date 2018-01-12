<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlCompilazioneModelli1
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlCompilazioneModelli1))
      Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.cmdModello = New System.Windows.Forms.Button
      Me.lblModello = New System.Windows.Forms.Label
      Me.lblAzienda = New System.Windows.Forms.Label
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.lblNew = New System.Windows.Forms.Label
      Me.lblO = New System.Windows.Forms.Label
      Me.lblbrower = New System.Windows.Forms.Label
      Me.optSegreteria = New System.Windows.Forms.RadioButton
      Me.optAzienda = New System.Windows.Forms.RadioButton
      Me.optUtente = New System.Windows.Forms.RadioButton
      Me.lblDescrizioneUtente = New System.Windows.Forms.Label
      Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.cmdSend = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Label2 = New System.Windows.Forms.Label
      Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdTags = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(596, 30)
      '
      'DockPanel
      '
      Me.DockPanel.Size = New System.Drawing.Size(596, 44)
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.Color.Silver
      Me.GroupBox1.Controls.Add(Me.cmdModello)
      Me.GroupBox1.Controls.Add(Me.lblModello)
      Me.GroupBox1.Controls.Add(Me.lblAzienda)
      Me.GroupBox1.Controls.Add(Me.IdAziendaTextBox1)
      Me.GroupBox1.Controls.Add(Me.lblNew)
      Me.GroupBox1.Controls.Add(Me.lblO)
      Me.GroupBox1.Controls.Add(Me.lblbrower)
      Me.GroupBox1.Controls.Add(Me.optSegreteria)
      Me.GroupBox1.Controls.Add(Me.optAzienda)
      Me.GroupBox1.Controls.Add(Me.optUtente)
      Me.GroupBox1.Controls.Add(Me.lblDescrizioneUtente)
      Me.GroupBox1.Controls.Add(Me.IdUtenteTextBox1)
      Me.GroupBox1.Controls.Add(Me.Label3)
      Me.GroupBox1.Controls.Add(Me.cmdSend)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.cmdPrint)
      Me.GroupBox1.Controls.Add(Me.cmdTags)
      Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox1.ForeColor = System.Drawing.Color.Black
      Me.GroupBox1.Location = New System.Drawing.Point(11, 41)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(515, 436)
      Me.GroupBox1.TabIndex = 129
      Me.GroupBox1.Text = "Selezione input "
      Me.GroupBox1.Title = "Generazione documentazione precompilata"
      '
      'cmdModello
      '
      Me.cmdModello.Location = New System.Drawing.Point(21, 171)
      Me.cmdModello.Name = "cmdModello"
      Me.cmdModello.Size = New System.Drawing.Size(116, 27)
      Me.cmdModello.TabIndex = 147
      Me.cmdModello.Text = "&Seleziona modello"
      Me.cmdModello.UseVisualStyleBackColor = True
      '
      'lblModello
      '
      Me.lblModello.AutoSize = True
      Me.lblModello.BackColor = System.Drawing.Color.Transparent
      Me.lblModello.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblModello.Location = New System.Drawing.Point(152, 177)
      Me.lblModello.MaximumSize = New System.Drawing.Size(260, 0)
      Me.lblModello.Name = "lblModello"
      Me.lblModello.Size = New System.Drawing.Size(0, 13)
      Me.lblModello.TabIndex = 146
      '
      'lblAzienda
      '
      Me.lblAzienda.AutoSize = True
      Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
      Me.lblAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAzienda.Location = New System.Drawing.Point(197, 322)
      Me.lblAzienda.Name = "lblAzienda"
      Me.lblAzienda.Size = New System.Drawing.Size(0, 13)
      Me.lblAzienda.TabIndex = 145
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(83, 307)
      Me.IdAziendaTextBox1.Mandatory = True
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(103, 27)
      Me.IdAziendaTextBox1.TabIndex = 144
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'lblNew
      '
      Me.lblNew.AutoSize = True
      Me.lblNew.BackColor = System.Drawing.Color.Transparent
      Me.lblNew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNew.Location = New System.Drawing.Point(34, 404)
      Me.lblNew.Name = "lblNew"
      Me.lblNew.Size = New System.Drawing.Size(142, 13)
      Me.lblNew.TabIndex = 143
      Me.lblNew.Text = "genera nuovo documento..."
      '
      'lblO
      '
      Me.lblO.AutoSize = True
      Me.lblO.BackColor = System.Drawing.Color.Transparent
      Me.lblO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblO.Location = New System.Drawing.Point(34, 385)
      Me.lblO.Name = "lblO"
      Me.lblO.Size = New System.Drawing.Size(41, 13)
      Me.lblO.TabIndex = 142
      Me.lblO.Text = "oppure"
      '
      'lblbrower
      '
      Me.lblbrower.AutoSize = True
      Me.lblbrower.BackColor = System.Drawing.Color.Transparent
      Me.lblbrower.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblbrower.Location = New System.Drawing.Point(34, 362)
      Me.lblbrower.Name = "lblbrower"
      Me.lblbrower.Size = New System.Drawing.Size(82, 13)
      Me.lblbrower.TabIndex = 141
      Me.lblbrower.Text = "Naviga verso..."
      '
      'optSegreteria
      '
      Me.optSegreteria.AutoSize = True
      Me.optSegreteria.BackColor = System.Drawing.Color.Transparent
      Me.optSegreteria.Location = New System.Drawing.Point(35, 251)
      Me.optSegreteria.Name = "optSegreteria"
      Me.optSegreteria.Size = New System.Drawing.Size(315, 17)
      Me.optSegreteria.TabIndex = 140
      Me.optSegreteria.TabStop = True
      Me.optSegreteria.Text = "Inviare il documento all'archivio documentale della segreteria"
      Me.optSegreteria.UseVisualStyleBackColor = False
      '
      'optAzienda
      '
      Me.optAzienda.AutoSize = True
      Me.optAzienda.BackColor = System.Drawing.Color.Transparent
      Me.optAzienda.Location = New System.Drawing.Point(35, 279)
      Me.optAzienda.Name = "optAzienda"
      Me.optAzienda.Size = New System.Drawing.Size(303, 17)
      Me.optAzienda.TabIndex = 139
      Me.optAzienda.TabStop = True
      Me.optAzienda.Text = "Inviare il documento all'archivio documentale di un'azienda"
      Me.optAzienda.UseVisualStyleBackColor = False
      '
      'optUtente
      '
      Me.optUtente.AutoSize = True
      Me.optUtente.BackColor = System.Drawing.Color.Transparent
      Me.optUtente.Location = New System.Drawing.Point(35, 222)
      Me.optUtente.Name = "optUtente"
      Me.optUtente.Size = New System.Drawing.Size(294, 17)
      Me.optUtente.TabIndex = 138
      Me.optUtente.TabStop = True
      Me.optUtente.Text = "Inviare il documento all'archivio documentale dell' utente"
      Me.optUtente.UseVisualStyleBackColor = False
      '
      'lblDescrizioneUtente
      '
      Me.lblDescrizioneUtente.AutoSize = True
      Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneUtente.Location = New System.Drawing.Point(197, 135)
      Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
      Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneUtente.TabIndex = 137
      '
      'IdUtenteTextBox1
      '
      Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdUtenteTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente per cui si vuole compilare un modello")
      Me.IdUtenteTextBox1.Location = New System.Drawing.Point(85, 130)
      Me.IdUtenteTextBox1.Mandatory = True
      Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
      Me.IdUtenteTextBox1.Size = New System.Drawing.Size(104, 27)
      Me.IdUtenteTextBox1.TabIndex = 136
      Me.IdUtenteTextBox1.TextValue = ""
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(25, 136)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(52, 13)
      Me.Label3.TabIndex = 135
      Me.Label3.Text = "Id utente"
      '
      'cmdSend
      '
      Me.cmdSend.ApplyOutLookStile = True
      Me.cmdSend.BackColor = System.Drawing.Color.Transparent
      Me.cmdSend.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.USERS_FOLDER
      Me.cmdSend.Disabled = False
      Me.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdSend.ForeColor = System.Drawing.Color.Transparent
      Me.cmdSend.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdSend.Location = New System.Drawing.Point(449, 369)
      Me.cmdSend.Name = "cmdSend"
      Me.cmdSend.Radius = 45.0!
      Me.cmdSend.ShowTooltip = True
      Me.cmdSend.Size = New System.Drawing.Size(45, 45)
      Me.cmdSend.TabIndex = 134
      Me.cmdSend.TextValue = ""
      Me.cmdSend.TooltipText = "Genera documento e aggiungi all'archivio documentale"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(18, 31)
      Me.Label2.MaximumSize = New System.Drawing.Size(450, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(439, 65)
      Me.Label2.TabIndex = 132
      Me.Label2.Text = resources.GetString("Label2.Text")
      '
      'cmdPrint
      '
      Me.cmdPrint.ApplyOutLookStile = True
      Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
      Me.cmdPrint.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.word_icon_32x32
      Me.cmdPrint.Disabled = False
      Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdPrint.ForeColor = System.Drawing.Color.Transparent
      Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdPrint.Location = New System.Drawing.Point(402, 380)
      Me.cmdPrint.Name = "cmdPrint"
      Me.cmdPrint.Radius = 32.0!
      Me.cmdPrint.ShowTooltip = True
      Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
      Me.cmdPrint.TabIndex = 126
      Me.cmdPrint.TextValue = ""
      Me.cmdPrint.TooltipText = "Genera documento"
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
      Me.cmdTags.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdTags.Location = New System.Drawing.Point(425, 166)
      Me.cmdTags.Name = "cmdTags"
      Me.cmdTags.Radius = 32.0!
      Me.cmdTags.ShowTooltip = True
      Me.cmdTags.Size = New System.Drawing.Size(32, 32)
      Me.cmdTags.TabIndex = 131
      Me.cmdTags.TextValue = ""
      Me.cmdTags.TooltipText = "Inserisci tag supplementari modello Word"
      '
      'ControlCompilazioneModelli1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox1)
      Me.Name = "ControlCompilazioneModelli1"
      Me.Size = New System.Drawing.Size(596, 503)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.GroupBox1, 0)
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdTags As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cmdSend As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents optAzienda As System.Windows.Forms.RadioButton
   Friend WithEvents optUtente As System.Windows.Forms.RadioButton
   Friend WithEvents optSegreteria As System.Windows.Forms.RadioButton
   Friend WithEvents lblbrower As System.Windows.Forms.Label
   Friend WithEvents lblNew As System.Windows.Forms.Label
   Friend WithEvents lblO As System.Windows.Forms.Label
   Friend WithEvents lblAzienda As System.Windows.Forms.Label
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents cmdModello As System.Windows.Forms.Button
   Friend WithEvents lblModello As System.Windows.Forms.Label

End Class
