<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompilazioneModello
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompilazioneModello))
        Me.Wizard1 = New Wizard.Wizard()
        Me.ListPage = New Wizard.WizardPage()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Header1 = New Wizard.Header()
        Me.StartPage = New Wizard.WizardPage()
        Me.InfoPage1 = New Wizard.InfoPage()
        Me.EndPage = New Wizard.WizardPage()
        Me.InfoPage2 = New Wizard.InfoPage()
        Me.ComunicationPage = New Wizard.WizardPage()
        Me.chkNoArchive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.optSegreteria = New System.Windows.Forms.RadioButton()
        Me.optAzienda = New System.Windows.Forms.RadioButton()
        Me.optUtente = New System.Windows.Forms.RadioButton()
        Me.Header3 = New Wizard.Header()
        Me.ModelPage = New Wizard.WizardPage()
        Me.cmdTag = New System.Windows.Forms.Button()
        Me.cmdModello = New System.Windows.Forms.Button()
        Me.lblModello = New System.Windows.Forms.Label()
        Me.Header4 = New Wizard.Header()
        Me.Wizard1.SuspendLayout()
        Me.ListPage.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.EndPage.SuspendLayout()
        Me.ComunicationPage.SuspendLayout()
        Me.ModelPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.ComunicationPage)
        Me.Wizard1.Controls.Add(Me.ModelPage)
        Me.Wizard1.Controls.Add(Me.ListPage)
        Me.Wizard1.Controls.Add(Me.StartPage)
        Me.Wizard1.Controls.Add(Me.EndPage)
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Wizard.WizardPage() {Me.StartPage, Me.ListPage, Me.ModelPage, Me.ComunicationPage, Me.EndPage})
        Me.Wizard1.Size = New System.Drawing.Size(458, 320)
        Me.Wizard1.TabIndex = 1
        '
        'ListPage
        '
        Me.ListPage.Controls.Add(Me.IdUtenteTextBox1)
        Me.ListPage.Controls.Add(Me.lblId)
        Me.ListPage.Controls.Add(Me.Header1)
        Me.ListPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPage.IsFinishPage = False
        Me.ListPage.Location = New System.Drawing.Point(0, 0)
        Me.ListPage.Name = "ListPage"
        Me.ListPage.Size = New System.Drawing.Size(458, 272)
        Me.ListPage.TabIndex = 2
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.IsDescriptionVisible = True
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(52, 111)
        Me.IdUtenteTextBox1.Mandatory = True
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(374, 28)
        Me.IdUtenteTextBox1.TabIndex = 136
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(48, 84)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(261, 13)
        Me.lblId.TabIndex = 131
        Me.lblId.Text = "Selezionare la l'utente per la compilazione del modello"
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.SystemColors.Control
        Me.Header1.CausesValidation = False
        Me.Header1.Description = "Selezionare l'utente per cui si desidera compilare o stampare il modello"
        Me.Header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(458, 63)
        Me.Header1.TabIndex = 0
        Me.Header1.Title = "Selezione lista di lavoro"
        '
        'StartPage
        '
        Me.StartPage.Controls.Add(Me.InfoPage1)
        Me.StartPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPage.IsFinishPage = False
        Me.StartPage.Location = New System.Drawing.Point(0, 0)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Size = New System.Drawing.Size(458, 272)
        Me.StartPage.TabIndex = 1
        '
        'InfoPage1
        '
        Me.InfoPage1.BackColor = System.Drawing.Color.White
        Me.InfoPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.wizard1
        Me.InfoPage1.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage1.Name = "InfoPage1"
        Me.InfoPage1.PageText = resources.GetString("InfoPage1.PageText")
        Me.InfoPage1.PageTitle = "Procedura guidata compilazione modelli"
        Me.InfoPage1.Size = New System.Drawing.Size(458, 272)
        Me.InfoPage1.TabIndex = 0
        '
        'EndPage
        '
        Me.EndPage.Controls.Add(Me.InfoPage2)
        Me.EndPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndPage.IsFinishPage = True
        Me.EndPage.Location = New System.Drawing.Point(0, 0)
        Me.EndPage.Name = "EndPage"
        Me.EndPage.Size = New System.Drawing.Size(458, 272)
        Me.EndPage.TabIndex = 6
        '
        'InfoPage2
        '
        Me.InfoPage2.BackColor = System.Drawing.Color.White
        Me.InfoPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.wizard1
        Me.InfoPage2.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage2.Name = "InfoPage2"
        Me.InfoPage2.PageText = "Questa procedura guidata ha consentito di impostare la modalità di stampa delle c" & _
    "omunicazioni massive all'utenza. Premere ""Termina"" per avviare la procedura."
        Me.InfoPage2.PageTitle = "Procedura guidata comunicazioni massive"
        Me.InfoPage2.Size = New System.Drawing.Size(458, 272)
        Me.InfoPage2.TabIndex = 0
        '
        'ComunicationPage
        '
        Me.ComunicationPage.Controls.Add(Me.chkNoArchive)
        Me.ComunicationPage.Controls.Add(Me.Label1)
        Me.ComunicationPage.Controls.Add(Me.IdAziendaTextBox1)
        Me.ComunicationPage.Controls.Add(Me.optSegreteria)
        Me.ComunicationPage.Controls.Add(Me.optAzienda)
        Me.ComunicationPage.Controls.Add(Me.optUtente)
        Me.ComunicationPage.Controls.Add(Me.Header3)
        Me.ComunicationPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComunicationPage.IsFinishPage = False
        Me.ComunicationPage.Location = New System.Drawing.Point(0, 0)
        Me.ComunicationPage.Name = "ComunicationPage"
        Me.ComunicationPage.Size = New System.Drawing.Size(458, 272)
        Me.ComunicationPage.TabIndex = 4
        '
        'chkNoArchive
        '
        Me.chkNoArchive.AutoSize = True
        Me.chkNoArchive.Checked = True
        Me.chkNoArchive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoArchive.Location = New System.Drawing.Point(51, 238)
        Me.chkNoArchive.Name = "chkNoArchive"
        Me.chkNoArchive.Size = New System.Drawing.Size(101, 17)
        Me.chkNoArchive.TabIndex = 161
        Me.chkNoArchive.Text = "Nessun archivio"
        Me.chkNoArchive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Selezionare l'archivio documentale a cui inviare il file generato"
        '
        'IdAziendaTextBox1
        '
        Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAziendaTextBox1.DescriptionOfText = ""
        Me.IdAziendaTextBox1.DescriptionTextWidth = 150
        Me.IdAziendaTextBox1.DescriptionTextXValue = 92
        Me.IdAziendaTextBox1.EnableSerchTextBox = False
        Me.IdAziendaTextBox1.IsDescriptionVisible = True
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(99, 192)
        Me.IdAziendaTextBox1.Mandatory = True
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(320, 27)
        Me.IdAziendaTextBox1.TabIndex = 159
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'optSegreteria
        '
        Me.optSegreteria.AutoSize = True
        Me.optSegreteria.BackColor = System.Drawing.Color.Transparent
        Me.optSegreteria.Enabled = False
        Me.optSegreteria.Location = New System.Drawing.Point(51, 136)
        Me.optSegreteria.Name = "optSegreteria"
        Me.optSegreteria.Size = New System.Drawing.Size(315, 17)
        Me.optSegreteria.TabIndex = 158
        Me.optSegreteria.TabStop = True
        Me.optSegreteria.Text = "Inviare il documento all'archivio documentale della segreteria"
        Me.optSegreteria.UseVisualStyleBackColor = False
        '
        'optAzienda
        '
        Me.optAzienda.AutoSize = True
        Me.optAzienda.BackColor = System.Drawing.Color.Transparent
        Me.optAzienda.Enabled = False
        Me.optAzienda.Location = New System.Drawing.Point(51, 164)
        Me.optAzienda.Name = "optAzienda"
        Me.optAzienda.Size = New System.Drawing.Size(303, 17)
        Me.optAzienda.TabIndex = 157
        Me.optAzienda.TabStop = True
        Me.optAzienda.Text = "Inviare il documento all'archivio documentale di un'azienda"
        Me.optAzienda.UseVisualStyleBackColor = False
        '
        'optUtente
        '
        Me.optUtente.AutoSize = True
        Me.optUtente.BackColor = System.Drawing.Color.Transparent
        Me.optUtente.Enabled = False
        Me.optUtente.Location = New System.Drawing.Point(51, 107)
        Me.optUtente.Name = "optUtente"
        Me.optUtente.Size = New System.Drawing.Size(294, 17)
        Me.optUtente.TabIndex = 156
        Me.optUtente.TabStop = True
        Me.optUtente.Text = "Inviare il documento all'archivio documentale dell' utente"
        Me.optUtente.UseVisualStyleBackColor = False
        '
        'Header3
        '
        Me.Header3.BackColor = System.Drawing.SystemColors.Control
        Me.Header3.CausesValidation = False
        Me.Header3.Description = "Impostare i paramtri per definire le azioni che verranno eseguite dal sistema  do" & _
    "po la generazione e compilazione del modello"
        Me.Header3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header3.Location = New System.Drawing.Point(0, 0)
        Me.Header3.Name = "Header3"
        Me.Header3.Size = New System.Drawing.Size(458, 62)
        Me.Header3.TabIndex = 0
        Me.Header3.Title = "Azioni "
        '
        'ModelPage
        '
        Me.ModelPage.Controls.Add(Me.cmdTag)
        Me.ModelPage.Controls.Add(Me.cmdModello)
        Me.ModelPage.Controls.Add(Me.lblModello)
        Me.ModelPage.Controls.Add(Me.Header4)
        Me.ModelPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModelPage.IsFinishPage = False
        Me.ModelPage.Location = New System.Drawing.Point(0, 0)
        Me.ModelPage.Name = "ModelPage"
        Me.ModelPage.Size = New System.Drawing.Size(458, 272)
        Me.ModelPage.TabIndex = 5
        '
        'cmdTag
        '
        Me.cmdTag.Location = New System.Drawing.Point(12, 211)
        Me.cmdTag.Name = "cmdTag"
        Me.cmdTag.Size = New System.Drawing.Size(128, 28)
        Me.cmdTag.TabIndex = 153
        Me.cmdTag.Text = "&Aggiungi tag"
        Me.cmdTag.UseVisualStyleBackColor = True
        '
        'cmdModello
        '
        Me.cmdModello.Location = New System.Drawing.Point(12, 81)
        Me.cmdModello.Name = "cmdModello"
        Me.cmdModello.Size = New System.Drawing.Size(128, 32)
        Me.cmdModello.TabIndex = 152
        Me.cmdModello.Text = "&Seleziona modello"
        Me.cmdModello.UseVisualStyleBackColor = True
        '
        'lblModello
        '
        Me.lblModello.AutoSize = True
        Me.lblModello.BackColor = System.Drawing.Color.Transparent
        Me.lblModello.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModello.Location = New System.Drawing.Point(49, 135)
        Me.lblModello.MaximumSize = New System.Drawing.Size(260, 0)
        Me.lblModello.Name = "lblModello"
        Me.lblModello.Size = New System.Drawing.Size(0, 13)
        Me.lblModello.TabIndex = 151
        '
        'Header4
        '
        Me.Header4.BackColor = System.Drawing.SystemColors.Control
        Me.Header4.CausesValidation = False
        Me.Header4.Description = "Selezionare il modello word da compilare e stampare per ogni utente nella lista s" & _
    "elezionata"
        Me.Header4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header4.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header4.Location = New System.Drawing.Point(0, 0)
        Me.Header4.Name = "Header4"
        Me.Header4.Size = New System.Drawing.Size(458, 62)
        Me.Header4.TabIndex = 0
        Me.Header4.Title = "Selezione modello"
        '
        'FrmCompilazioneModello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 320)
        Me.Controls.Add(Me.Wizard1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCompilazioneModello"
        Me.Text = "Compilazione modelli"
        Me.Wizard1.ResumeLayout(False)
        Me.ListPage.ResumeLayout(False)
        Me.ListPage.PerformLayout()
        Me.StartPage.ResumeLayout(False)
        Me.EndPage.ResumeLayout(False)
        Me.ComunicationPage.ResumeLayout(False)
        Me.ComunicationPage.PerformLayout()
        Me.ModelPage.ResumeLayout(False)
        Me.ModelPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Wizard.Wizard
    Friend WithEvents StartPage As Wizard.WizardPage
    Friend WithEvents InfoPage1 As Wizard.InfoPage
    Friend WithEvents EndPage As Wizard.WizardPage
    Friend WithEvents InfoPage2 As Wizard.InfoPage
    Friend WithEvents ModelPage As Wizard.WizardPage
    Friend WithEvents cmdTag As System.Windows.Forms.Button
    Friend WithEvents cmdModello As System.Windows.Forms.Button
    Friend WithEvents lblModello As System.Windows.Forms.Label
    Friend WithEvents Header4 As Wizard.Header
    Friend WithEvents ComunicationPage As Wizard.WizardPage
    Friend WithEvents Header3 As Wizard.Header
    Friend WithEvents ListPage As Wizard.WizardPage
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Header1 As Wizard.Header
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents optSegreteria As System.Windows.Forms.RadioButton
    Friend WithEvents optAzienda As System.Windows.Forms.RadioButton
    Friend WithEvents optUtente As System.Windows.Forms.RadioButton
    Friend WithEvents chkNoArchive As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
