<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlComunicazioneMassiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlComunicazioneMassiva))
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.chkSaveCom = New System.Windows.Forms.CheckBox
        Me.cmdAvviaProc = New System.Windows.Forms.Button
        Me.chkSaveFile = New System.Windows.Forms.CheckBox
        Me.cmdModello = New System.Windows.Forms.Button
        Me.lblModello = New System.Windows.Forms.Label
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.IdListaUtentiTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox
        Me.lblId = New System.Windows.Forms.Label
        Me.cmdTags = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.cboCausale = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(589, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel.Size = New System.Drawing.Size(589, 44)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.chkSaveCom)
        Me.GroupBox1.Controls.Add(Me.cmdAvviaProc)
        Me.GroupBox1.Controls.Add(Me.chkSaveFile)
        Me.GroupBox1.Controls.Add(Me.cmdModello)
        Me.GroupBox1.Controls.Add(Me.lblModello)
        Me.GroupBox1.Controls.Add(Me.lblDescrizione)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.IdListaUtentiTextBox1)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.cmdTags)
        Me.GroupBox1.Controls.Add(Me.cboCausale)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboTipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 478)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.Text = "Selezione input "
        Me.GroupBox1.Title = "Comunicazioni"
        '
        'chkSaveCom
        '
        Me.chkSaveCom.AutoSize = True
        Me.chkSaveCom.BackColor = System.Drawing.Color.Transparent
        Me.chkSaveCom.Checked = True
        Me.chkSaveCom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveCom.Location = New System.Drawing.Point(30, 325)
        Me.chkSaveCom.Name = "chkSaveCom"
        Me.chkSaveCom.Size = New System.Drawing.Size(122, 17)
        Me.chkSaveCom.TabIndex = 152
        Me.chkSaveCom.Text = "Salva comuncazione"
        Me.chkSaveCom.UseVisualStyleBackColor = False
        '
        'cmdAvviaProc
        '
        Me.cmdAvviaProc.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.word_icon_32x32
        Me.cmdAvviaProc.Location = New System.Drawing.Point(398, 295)
        Me.cmdAvviaProc.Name = "cmdAvviaProc"
        Me.cmdAvviaProc.Size = New System.Drawing.Size(100, 46)
        Me.cmdAvviaProc.TabIndex = 151
        Me.cmdAvviaProc.Text = "Avvia"
        Me.cmdAvviaProc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAvviaProc.UseVisualStyleBackColor = True
        '
        'chkSaveFile
        '
        Me.chkSaveFile.AutoSize = True
        Me.chkSaveFile.BackColor = System.Drawing.Color.Transparent
        Me.chkSaveFile.Location = New System.Drawing.Point(30, 355)
        Me.chkSaveFile.Name = "chkSaveFile"
        Me.chkSaveFile.Size = New System.Drawing.Size(207, 17)
        Me.chkSaveFile.TabIndex = 150
        Me.chkSaveFile.Text = "Allega file stampati alla comunicazione"
        Me.chkSaveFile.UseVisualStyleBackColor = False
        '
        'cmdModello
        '
        Me.cmdModello.Location = New System.Drawing.Point(13, 240)
        Me.cmdModello.Name = "cmdModello"
        Me.cmdModello.Size = New System.Drawing.Size(128, 32)
        Me.cmdModello.TabIndex = 149
        Me.cmdModello.Text = "&Seleziona modello"
        Me.cmdModello.UseVisualStyleBackColor = True
        '
        'lblModello
        '
        Me.lblModello.AutoSize = True
        Me.lblModello.BackColor = System.Drawing.Color.Transparent
        Me.lblModello.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModello.Location = New System.Drawing.Point(160, 250)
        Me.lblModello.MaximumSize = New System.Drawing.Size(260, 0)
        Me.lblModello.Name = "lblModello"
        Me.lblModello.Size = New System.Drawing.Size(0, 13)
        Me.lblModello.TabIndex = 148
        '
        'lblDescrizione
        '
        Me.lblDescrizione.AutoSize = True
        Me.lblDescrizione.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizione.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizione.Location = New System.Drawing.Point(186, 139)
        Me.lblDescrizione.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizione.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 31)
        Me.Label2.MaximumSize = New System.Drawing.Size(450, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 78)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'IdListaUtentiTextBox1
        '
        Me.IdListaUtentiTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdListaUtentiTextBox1.DescriptionOfText = ""
        Me.IdListaUtentiTextBox1.DescriptionTextWidth = 150
        Me.IdListaUtentiTextBox1.DescriptionTextXValue = 92
        Me.IdListaUtentiTextBox1.EnableSerchTextBox = True
        Me.IdListaUtentiTextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.IdListaUtentiTextBox1, "Identificativo della lista di lavoro ( lista di utenti utile,per esempio, per le " & _
                "comunicazioni).Si pensi alla comunicazione di una vertenza per tutti i dipendent" & _
                "i di un'azienda!")
        Me.IdListaUtentiTextBox1.IsDescriptionVisible = False
        Me.IdListaUtentiTextBox1.Location = New System.Drawing.Point(75, 132)
        Me.IdListaUtentiTextBox1.Mandatory = True
        Me.IdListaUtentiTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdListaUtentiTextBox1.Name = "IdListaUtentiTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdListaUtentiTextBox1, True)
        Me.IdListaUtentiTextBox1.Size = New System.Drawing.Size(96, 25)
        Me.IdListaUtentiTextBox1.TabIndex = 130
        Me.IdListaUtentiTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(11, 139)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(60, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Lista utenti"
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
        Me.cmdTags.Location = New System.Drawing.Point(466, 240)
        Me.cmdTags.Name = "cmdTags"
        Me.cmdTags.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdTags, True)
        Me.cmdTags.ShowTooltip = True
        Me.cmdTags.Size = New System.Drawing.Size(32, 32)
        Me.cmdTags.TabIndex = 131
        Me.cmdTags.TextValue = ""
        Me.cmdTags.TooltipText = "Inserisci tag supplementari modello Word"
        '
        'cboCausale
        '
        Me.cboCausale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausale.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausale, "Causale della comunicazione inviata. Le causali delle comunicazione possono esser" & _
                "e impostati dal menu Strumenti->Setup->Utenti->Causali comunicazione.")
        Me.cboCausale.Location = New System.Drawing.Point(75, 204)
        Me.cboCausale.Name = "cboCausale"
        Me.HelpProvider1.SetShowHelp(Me.cboCausale, True)
        Me.cboCausale.Size = New System.Drawing.Size(182, 21)
        Me.cboCausale.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Caus. com."
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipo di comunicazione inviata. I tipi di comunicazione possono essere impostati d" & _
                "al menu Strumenti->Setup->Utenti->Tipi comunicazione")
        Me.cboTipo.Location = New System.Drawing.Point(75, 174)
        Me.cboTipo.Name = "cboTipo"
        Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
        Me.cboTipo.Size = New System.Drawing.Size(182, 21)
        Me.cboTipo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo com."
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ControlComunicazioneMassiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlComunicazioneMassiva"
        Me.Size = New System.Drawing.Size(589, 533)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboCausale As System.Windows.Forms.ComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents IdListaUtentiTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox
   Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents cmdTags As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
   Friend WithEvents cmdModello As System.Windows.Forms.Button
    Friend WithEvents lblModello As System.Windows.Forms.Label
    Friend WithEvents chkSaveFile As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAvviaProc As System.Windows.Forms.Button
    Friend WithEvents chkSaveCom As System.Windows.Forms.CheckBox

End Class
