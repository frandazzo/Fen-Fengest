<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStampaPermessi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStampaPermessi))
        Me.Wizard1 = New Wizard.Wizard()
        Me.ComunicationPage = New Wizard.WizardPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.rdbAz = New System.Windows.Forms.RadioButton()
        Me.rdbUt = New System.Windows.Forms.RadioButton()
        Me.chkLabels = New System.Windows.Forms.CheckBox()
        Me.chkSaveCom = New System.Windows.Forms.CheckBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Header3 = New Wizard.Header()
        Me.StartPage = New Wizard.WizardPage()
        Me.InfoPage1 = New Wizard.InfoPage()
        Me.EndPage = New Wizard.WizardPage()
        Me.InfoPage2 = New Wizard.InfoPage()
        Me.PrinterPage = New Wizard.WizardPage()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrinter = New System.Windows.Forms.Button()
        Me.Header5 = New Wizard.Header()
        Me.ModelPage = New Wizard.WizardPage()
        Me.cmdTag = New System.Windows.Forms.Button()
        Me.cmdModello = New System.Windows.Forms.Button()
        Me.lblModello = New System.Windows.Forms.Label()
        Me.Header4 = New Wizard.Header()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Wizard1.SuspendLayout()
        Me.ComunicationPage.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.EndPage.SuspendLayout()
        Me.PrinterPage.SuspendLayout()
        Me.ModelPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.ComunicationPage)
        Me.Wizard1.Controls.Add(Me.StartPage)
        Me.Wizard1.Controls.Add(Me.EndPage)
        Me.Wizard1.Controls.Add(Me.PrinterPage)
        Me.Wizard1.Controls.Add(Me.ModelPage)
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Wizard.WizardPage() {Me.StartPage, Me.ComunicationPage, Me.ModelPage, Me.PrinterPage, Me.EndPage})
        Me.Wizard1.Size = New System.Drawing.Size(564, 304)
        Me.Wizard1.TabIndex = 1
        '
        'ComunicationPage
        '
        Me.ComunicationPage.Controls.Add(Me.CheckBox1)
        Me.ComunicationPage.Controls.Add(Me.Label1)
        Me.ComunicationPage.Controls.Add(Me.IdReferenteTextBox1)
        Me.ComunicationPage.Controls.Add(Me.rdbAz)
        Me.ComunicationPage.Controls.Add(Me.rdbUt)
        Me.ComunicationPage.Controls.Add(Me.chkLabels)
        Me.ComunicationPage.Controls.Add(Me.chkSaveCom)
        Me.ComunicationPage.Controls.Add(Me.cboTipo)
        Me.ComunicationPage.Controls.Add(Me.Label5)
        Me.ComunicationPage.Controls.Add(Me.Header3)
        Me.ComunicationPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComunicationPage.IsFinishPage = False
        Me.ComunicationPage.Location = New System.Drawing.Point(0, 0)
        Me.ComunicationPage.Name = "ComunicationPage"
        Me.ComunicationPage.Size = New System.Drawing.Size(564, 256)
        Me.ComunicationPage.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Collaboratore"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(148, 191)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(139, 23)
        Me.IdReferenteTextBox1.TabIndex = 158
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'rdbAz
        '
        Me.rdbAz.AutoSize = True
        Me.rdbAz.Checked = True
        Me.rdbAz.Location = New System.Drawing.Point(55, 74)
        Me.rdbAz.Name = "rdbAz"
        Me.rdbAz.Size = New System.Drawing.Size(136, 17)
        Me.rdbAz.TabIndex = 157
        Me.rdbAz.TabStop = True
        Me.rdbAz.Text = "Comunicazione azienda"
        Me.rdbAz.UseVisualStyleBackColor = True
        '
        'rdbUt
        '
        Me.rdbUt.AutoSize = True
        Me.rdbUt.Location = New System.Drawing.Point(210, 74)
        Me.rdbUt.Name = "rdbUt"
        Me.rdbUt.Size = New System.Drawing.Size(131, 17)
        Me.rdbUt.TabIndex = 156
        Me.rdbUt.Text = "Comunicazione utente"
        Me.rdbUt.UseVisualStyleBackColor = True
        '
        'chkLabels
        '
        Me.chkLabels.AutoSize = True
        Me.chkLabels.Location = New System.Drawing.Point(50, 233)
        Me.chkLabels.Name = "chkLabels"
        Me.chkLabels.Size = New System.Drawing.Size(227, 17)
        Me.chkLabels.TabIndex = 155
        Me.chkLabels.Text = "Crea etichette al termine dell'elaborazione"
        Me.chkLabels.UseVisualStyleBackColor = True
        '
        'chkSaveCom
        '
        Me.chkSaveCom.AutoSize = True
        Me.chkSaveCom.BackColor = System.Drawing.Color.Transparent
        Me.chkSaveCom.Checked = True
        Me.chkSaveCom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveCom.Location = New System.Drawing.Point(55, 114)
        Me.chkSaveCom.Name = "chkSaveCom"
        Me.chkSaveCom.Size = New System.Drawing.Size(316, 17)
        Me.chkSaveCom.TabIndex = 154
        Me.chkSaveCom.Text = "Salva come documento nell'archivio documentale dell'azienda"
        Me.chkSaveCom.UseVisualStyleBackColor = False
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(148, 148)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(182, 21)
        Me.cboTipo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo doc."
        '
        'Header3
        '
        Me.Header3.BackColor = System.Drawing.SystemColors.Control
        Me.Header3.CausesValidation = False
        Me.Header3.Description = "Impostare i paramtri per l'eventuale modalità di creazione della comunicazione as" & _
    "sociata all'utente"
        Me.Header3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header3.Location = New System.Drawing.Point(0, 0)
        Me.Header3.Name = "Header3"
        Me.Header3.Size = New System.Drawing.Size(564, 62)
        Me.Header3.TabIndex = 0
        Me.Header3.Title = "Creazione comunicazione utente"
        '
        'StartPage
        '
        Me.StartPage.Controls.Add(Me.InfoPage1)
        Me.StartPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPage.IsFinishPage = False
        Me.StartPage.Location = New System.Drawing.Point(0, 0)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Size = New System.Drawing.Size(564, 256)
        Me.StartPage.TabIndex = 1
        '
        'InfoPage1
        '
        Me.InfoPage1.BackColor = System.Drawing.Color.White
        Me.InfoPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.wizard1
        Me.InfoPage1.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage1.Name = "InfoPage1"
        Me.InfoPage1.PageText = "Questa procedura consente la stampa immediata delle comunicazioni tra la federazi" & _
    "one provinciale, i membri degli organismi sindacali e le relative imprese di app" & _
    "artenenza."
        Me.InfoPage1.PageTitle = "Procedura guidata per le comunicazioni dei permessi sindacali"
        Me.InfoPage1.Size = New System.Drawing.Size(564, 256)
        Me.InfoPage1.TabIndex = 0
        '
        'EndPage
        '
        Me.EndPage.Controls.Add(Me.InfoPage2)
        Me.EndPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndPage.IsFinishPage = True
        Me.EndPage.Location = New System.Drawing.Point(0, 0)
        Me.EndPage.Name = "EndPage"
        Me.EndPage.Size = New System.Drawing.Size(564, 256)
        Me.EndPage.TabIndex = 6
        '
        'InfoPage2
        '
        Me.InfoPage2.BackColor = System.Drawing.Color.White
        Me.InfoPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.wizard1
        Me.InfoPage2.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage2.Name = "InfoPage2"
        Me.InfoPage2.PageText = " Premere ""Termina"" per avviare la procedura."
        Me.InfoPage2.PageTitle = "Procedura guidata comunicazioni dei permessi sindacali"
        Me.InfoPage2.Size = New System.Drawing.Size(564, 256)
        Me.InfoPage2.TabIndex = 0
        '
        'PrinterPage
        '
        Me.PrinterPage.Controls.Add(Me.lblPrint)
        Me.PrinterPage.Controls.Add(Me.Label2)
        Me.PrinterPage.Controls.Add(Me.cmdPrinter)
        Me.PrinterPage.Controls.Add(Me.Header5)
        Me.PrinterPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrinterPage.IsFinishPage = False
        Me.PrinterPage.Location = New System.Drawing.Point(0, 0)
        Me.PrinterPage.Name = "PrinterPage"
        Me.PrinterPage.Size = New System.Drawing.Size(564, 256)
        Me.PrinterPage.TabIndex = 7
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Location = New System.Drawing.Point(47, 165)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(159, 13)
        Me.lblPrint.TabIndex = 3
        Me.lblPrint.Text = "Nessuna stampante selezionata"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleziona stampante"
        '
        'cmdPrinter
        '
        Me.cmdPrinter.Location = New System.Drawing.Point(28, 116)
        Me.cmdPrinter.Name = "cmdPrinter"
        Me.cmdPrinter.Size = New System.Drawing.Size(155, 35)
        Me.cmdPrinter.TabIndex = 1
        Me.cmdPrinter.Text = "Stampante"
        Me.cmdPrinter.UseVisualStyleBackColor = True
        '
        'Header5
        '
        Me.Header5.BackColor = System.Drawing.SystemColors.Control
        Me.Header5.CausesValidation = False
        Me.Header5.Description = "Selezionare la stampante su cui eseguire la stampa"
        Me.Header5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header5.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header5.Location = New System.Drawing.Point(0, 0)
        Me.Header5.Name = "Header5"
        Me.Header5.Size = New System.Drawing.Size(564, 66)
        Me.Header5.TabIndex = 0
        Me.Header5.Title = "Selezione stampante"
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
        Me.ModelPage.Size = New System.Drawing.Size(564, 256)
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
        Me.Header4.Size = New System.Drawing.Size(564, 62)
        Me.Header4.TabIndex = 0
        Me.Header4.Title = "Selezione modello"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(399, 75)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox1.TabIndex = 160
        Me.CheckBox1.Text = "Stampa immediata"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmStampaPermessi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 304)
        Me.Controls.Add(Me.Wizard1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStampaPermessi"
        Me.Text = "Procedura guidata gestione comunicazioni permessi"
        Me.Wizard1.ResumeLayout(False)
        Me.ComunicationPage.ResumeLayout(False)
        Me.ComunicationPage.PerformLayout()
        Me.StartPage.ResumeLayout(False)
        Me.EndPage.ResumeLayout(False)
        Me.PrinterPage.ResumeLayout(False)
        Me.PrinterPage.PerformLayout()
        Me.ModelPage.ResumeLayout(False)
        Me.ModelPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Wizard.Wizard
    Friend WithEvents ComunicationPage As Wizard.WizardPage
    Friend WithEvents rdbAz As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUt As System.Windows.Forms.RadioButton
    Friend WithEvents chkLabels As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveCom As System.Windows.Forms.CheckBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Header3 As Wizard.Header
    Friend WithEvents StartPage As Wizard.WizardPage
    Friend WithEvents InfoPage1 As Wizard.InfoPage
    Friend WithEvents ModelPage As Wizard.WizardPage
    Friend WithEvents cmdTag As System.Windows.Forms.Button
    Friend WithEvents cmdModello As System.Windows.Forms.Button
    Friend WithEvents lblModello As System.Windows.Forms.Label
    Friend WithEvents Header4 As Wizard.Header
    Friend WithEvents PrinterPage As Wizard.WizardPage
    Friend WithEvents lblPrint As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdPrinter As System.Windows.Forms.Button
    Friend WithEvents Header5 As Wizard.Header
    Friend WithEvents EndPage As Wizard.WizardPage
    Friend WithEvents InfoPage2 As Wizard.InfoPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
