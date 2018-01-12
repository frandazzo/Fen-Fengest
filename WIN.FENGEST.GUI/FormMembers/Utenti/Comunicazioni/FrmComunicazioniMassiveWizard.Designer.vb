<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComunicazioniMassiveWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComunicazioniMassiveWizard))
        Me.Wizard1 = New Wizard.Wizard()
        Me.ComunicationPage = New Wizard.WizardPage()
        Me.chkLabels = New System.Windows.Forms.CheckBox()
        Me.chkSaveCom = New System.Windows.Forms.CheckBox()
        Me.chkSaveFile = New System.Windows.Forms.CheckBox()
        Me.cboCausale = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Header3 = New Wizard.Header()
        Me.ModelPage = New Wizard.WizardPage()
        Me.cmdTag = New System.Windows.Forms.Button()
        Me.cmdModello = New System.Windows.Forms.Button()
        Me.lblModello = New System.Windows.Forms.Label()
        Me.Header4 = New Wizard.Header()
        Me.PrinterPage = New Wizard.WizardPage()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrinter = New System.Windows.Forms.Button()
        Me.Header5 = New Wizard.Header()
        Me.EndPage = New Wizard.WizardPage()
        Me.InfoPage2 = New Wizard.InfoPage()
        Me.IndexPage = New Wizard.WizardPage()
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFinish = New System.Windows.Forms.CheckBox()
        Me.chkStart = New System.Windows.Forms.CheckBox()
        Me.Header2 = New Wizard.Header()
        Me.ListPage = New Wizard.WizardPage()
        Me.lblDescrizione = New System.Windows.Forms.Label()
        Me.IdListaUtentiTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Header1 = New Wizard.Header()
        Me.StartPage = New Wizard.WizardPage()
        Me.InfoPage1 = New Wizard.InfoPage()
        Me.Wizard1.SuspendLayout()
        Me.ComunicationPage.SuspendLayout()
        Me.ModelPage.SuspendLayout()
        Me.PrinterPage.SuspendLayout()
        Me.EndPage.SuspendLayout()
        Me.IndexPage.SuspendLayout()
        Me.ListPage.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.ComunicationPage)
        Me.Wizard1.Controls.Add(Me.IndexPage)
        Me.Wizard1.Controls.Add(Me.ListPage)
        Me.Wizard1.Controls.Add(Me.StartPage)
        Me.Wizard1.Controls.Add(Me.EndPage)
        Me.Wizard1.Controls.Add(Me.PrinterPage)
        Me.Wizard1.Controls.Add(Me.ModelPage)
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Wizard.WizardPage() {Me.StartPage, Me.ListPage, Me.IndexPage, Me.ComunicationPage, Me.ModelPage, Me.PrinterPage, Me.EndPage})
        Me.Wizard1.Size = New System.Drawing.Size(446, 309)
        Me.Wizard1.TabIndex = 0
        '
        'ComunicationPage
        '
        Me.ComunicationPage.Controls.Add(Me.chkLabels)
        Me.ComunicationPage.Controls.Add(Me.chkSaveCom)
        Me.ComunicationPage.Controls.Add(Me.chkSaveFile)
        Me.ComunicationPage.Controls.Add(Me.cboCausale)
        Me.ComunicationPage.Controls.Add(Me.Label6)
        Me.ComunicationPage.Controls.Add(Me.cboTipo)
        Me.ComunicationPage.Controls.Add(Me.Label5)
        Me.ComunicationPage.Controls.Add(Me.Header3)
        Me.ComunicationPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComunicationPage.IsFinishPage = False
        Me.ComunicationPage.Location = New System.Drawing.Point(0, 0)
        Me.ComunicationPage.Name = "ComunicationPage"
        Me.ComunicationPage.Size = New System.Drawing.Size(446, 261)
        Me.ComunicationPage.TabIndex = 4
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
        Me.chkSaveCom.Location = New System.Drawing.Point(50, 84)
        Me.chkSaveCom.Name = "chkSaveCom"
        Me.chkSaveCom.Size = New System.Drawing.Size(122, 17)
        Me.chkSaveCom.TabIndex = 154
        Me.chkSaveCom.Text = "Salva comuncazione"
        Me.chkSaveCom.UseVisualStyleBackColor = False
        '
        'chkSaveFile
        '
        Me.chkSaveFile.AutoSize = True
        Me.chkSaveFile.BackColor = System.Drawing.Color.Transparent
        Me.chkSaveFile.Location = New System.Drawing.Point(50, 203)
        Me.chkSaveFile.Name = "chkSaveFile"
        Me.chkSaveFile.Size = New System.Drawing.Size(207, 17)
        Me.chkSaveFile.TabIndex = 153
        Me.chkSaveFile.Text = "Allega file stampati alla comunicazione"
        Me.chkSaveFile.UseVisualStyleBackColor = False
        '
        'cboCausale
        '
        Me.cboCausale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausale.FormattingEnabled = True
        Me.cboCausale.Location = New System.Drawing.Point(140, 145)
        Me.cboCausale.Name = "cboCausale"
        Me.cboCausale.Size = New System.Drawing.Size(182, 21)
        Me.cboCausale.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Caus. com."
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(140, 115)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(182, 21)
        Me.cboTipo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo com."
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
        Me.Header3.Size = New System.Drawing.Size(446, 62)
        Me.Header3.TabIndex = 0
        Me.Header3.Title = "Creazione comunicazione utente"
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
        Me.ModelPage.Size = New System.Drawing.Size(446, 261)
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
        Me.Header4.Size = New System.Drawing.Size(446, 62)
        Me.Header4.TabIndex = 0
        Me.Header4.Title = "Selezione modello"
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
        Me.PrinterPage.Size = New System.Drawing.Size(446, 261)
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
        Me.Header5.Size = New System.Drawing.Size(446, 66)
        Me.Header5.TabIndex = 0
        Me.Header5.Title = "Selezione stampante"
        '
        'EndPage
        '
        Me.EndPage.Controls.Add(Me.InfoPage2)
        Me.EndPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndPage.IsFinishPage = True
        Me.EndPage.Location = New System.Drawing.Point(0, 0)
        Me.EndPage.Name = "EndPage"
        Me.EndPage.Size = New System.Drawing.Size(446, 261)
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
        Me.InfoPage2.Size = New System.Drawing.Size(446, 261)
        Me.InfoPage2.TabIndex = 0
        '
        'IndexPage
        '
        Me.IndexPage.Controls.Add(Me.lblFinish)
        Me.IndexPage.Controls.Add(Me.lblStart)
        Me.IndexPage.Controls.Add(Me.Label1)
        Me.IndexPage.Controls.Add(Me.chkFinish)
        Me.IndexPage.Controls.Add(Me.chkStart)
        Me.IndexPage.Controls.Add(Me.Header2)
        Me.IndexPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IndexPage.IsFinishPage = False
        Me.IndexPage.Location = New System.Drawing.Point(0, 0)
        Me.IndexPage.Name = "IndexPage"
        Me.IndexPage.Size = New System.Drawing.Size(446, 261)
        Me.IndexPage.TabIndex = 3
        '
        'lblFinish
        '
        Me.lblFinish.AutoSize = True
        Me.lblFinish.Location = New System.Drawing.Point(86, 200)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(19, 13)
        Me.lblFinish.TabIndex = 5
        Me.lblFinish.Text = "..."
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(87, 143)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(19, 13)
        Me.lblStart.TabIndex = 4
        Me.lblStart.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 77)
        Me.Label1.MaximumSize = New System.Drawing.Size(400, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Indicare, se desiderato, gli indici di inizio e fine lista al fine di filtrare gl" & _
    "i elementi della lista di lavoro per cui stampare una comunicazione"
        '
        'chkFinish
        '
        Me.chkFinish.AutoSize = True
        Me.chkFinish.Location = New System.Drawing.Point(53, 172)
        Me.chkFinish.Name = "chkFinish"
        Me.chkFinish.Size = New System.Drawing.Size(98, 17)
        Me.chkFinish.TabIndex = 2
        Me.chkFinish.Text = "Indice fine lista"
        Me.chkFinish.UseVisualStyleBackColor = True
        '
        'chkStart
        '
        Me.chkStart.AutoSize = True
        Me.chkStart.Location = New System.Drawing.Point(54, 117)
        Me.chkStart.Name = "chkStart"
        Me.chkStart.Size = New System.Drawing.Size(103, 17)
        Me.chkStart.TabIndex = 1
        Me.chkStart.Text = "Indice inizio lista"
        Me.chkStart.UseVisualStyleBackColor = True
        '
        'Header2
        '
        Me.Header2.BackColor = System.Drawing.SystemColors.Control
        Me.Header2.CausesValidation = False
        Me.Header2.Description = "Indicazione indici di selezione"
        Me.Header2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header2.Location = New System.Drawing.Point(0, 0)
        Me.Header2.Name = "Header2"
        Me.Header2.Size = New System.Drawing.Size(446, 64)
        Me.Header2.TabIndex = 0
        Me.Header2.Title = "Selezione indici"
        '
        'ListPage
        '
        Me.ListPage.Controls.Add(Me.lblDescrizione)
        Me.ListPage.Controls.Add(Me.IdListaUtentiTextBox1)
        Me.ListPage.Controls.Add(Me.lblId)
        Me.ListPage.Controls.Add(Me.Header1)
        Me.ListPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPage.IsFinishPage = False
        Me.ListPage.Location = New System.Drawing.Point(0, 0)
        Me.ListPage.Name = "ListPage"
        Me.ListPage.Size = New System.Drawing.Size(446, 261)
        Me.ListPage.TabIndex = 2
        '
        'lblDescrizione
        '
        Me.lblDescrizione.AutoSize = True
        Me.lblDescrizione.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizione.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizione.Location = New System.Drawing.Point(161, 118)
        Me.lblDescrizione.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizione.TabIndex = 135
        '
        'IdListaUtentiTextBox1
        '
        Me.IdListaUtentiTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdListaUtentiTextBox1.DescriptionOfText = ""
        Me.IdListaUtentiTextBox1.DescriptionTextWidth = 150
        Me.IdListaUtentiTextBox1.DescriptionTextXValue = 92
        Me.IdListaUtentiTextBox1.EnableSerchTextBox = True
        Me.IdListaUtentiTextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdListaUtentiTextBox1.IsDescriptionVisible = False
        Me.IdListaUtentiTextBox1.Location = New System.Drawing.Point(51, 110)
        Me.IdListaUtentiTextBox1.Mandatory = True
        Me.IdListaUtentiTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdListaUtentiTextBox1.Name = "IdListaUtentiTextBox1"
        Me.IdListaUtentiTextBox1.Size = New System.Drawing.Size(96, 25)
        Me.IdListaUtentiTextBox1.TabIndex = 132
        Me.IdListaUtentiTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(48, 84)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(339, 13)
        Me.lblId.TabIndex = 131
        Me.lblId.Text = "Selezionare la lista utenti per la creazione delle comunicazioni massive"
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.SystemColors.Control
        Me.Header1.CausesValidation = False
        Me.Header1.Description = "Selezionare la lista di lavoro degli utenti per cui si desidera stampare la comun" & _
    "icazione"
        Me.Header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(446, 63)
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
        Me.StartPage.Size = New System.Drawing.Size(446, 261)
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
        Me.InfoPage1.PageTitle = "Procedura guidata comunicazioni massive"
        Me.InfoPage1.Size = New System.Drawing.Size(446, 261)
        Me.InfoPage1.TabIndex = 0
        '
        'FrmComunicazioniMassiveWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 309)
        Me.Controls.Add(Me.Wizard1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmComunicazioniMassiveWizard"
        Me.Text = "Procedura guidata comunicazioni massive"
        Me.Wizard1.ResumeLayout(False)
        Me.ComunicationPage.ResumeLayout(False)
        Me.ComunicationPage.PerformLayout()
        Me.ModelPage.ResumeLayout(False)
        Me.ModelPage.PerformLayout()
        Me.PrinterPage.ResumeLayout(False)
        Me.PrinterPage.PerformLayout()
        Me.EndPage.ResumeLayout(False)
        Me.IndexPage.ResumeLayout(False)
        Me.IndexPage.PerformLayout()
        Me.ListPage.ResumeLayout(False)
        Me.ListPage.PerformLayout()
        Me.StartPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Wizard.Wizard
    Friend WithEvents ListPage As Wizard.WizardPage
    Friend WithEvents Header1 As Wizard.Header
    Friend WithEvents StartPage As Wizard.WizardPage
    Friend WithEvents InfoPage1 As Wizard.InfoPage
    Friend WithEvents IndexPage As Wizard.WizardPage
    Friend WithEvents ComunicationPage As Wizard.WizardPage
    Friend WithEvents ModelPage As Wizard.WizardPage
    Friend WithEvents EndPage As Wizard.WizardPage
    Friend WithEvents IdListaUtentiTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkFinish As System.Windows.Forms.CheckBox
    Friend WithEvents chkStart As System.Windows.Forms.CheckBox
    Friend WithEvents Header2 As Wizard.Header
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents lblFinish As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Header3 As Wizard.Header
    Friend WithEvents cboCausale As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkSaveCom As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveFile As System.Windows.Forms.CheckBox
    Friend WithEvents Header4 As Wizard.Header
    Friend WithEvents cmdModello As System.Windows.Forms.Button
    Friend WithEvents lblModello As System.Windows.Forms.Label
    Friend WithEvents cmdTag As System.Windows.Forms.Button
    Friend WithEvents InfoPage2 As Wizard.InfoPage
    Friend WithEvents PrinterPage As Wizard.WizardPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdPrinter As System.Windows.Forms.Button
    Friend WithEvents Header5 As Wizard.Header
    Friend WithEvents lblPrint As System.Windows.Forms.Label
    Friend WithEvents chkLabels As System.Windows.Forms.CheckBox
End Class
