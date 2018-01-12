<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfrontoListeWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfrontoListeWizard))
        Me.Wizard1 = New Wizard.Wizard
        Me.DescriptionPage = New Wizard.WizardPage
        Me.txtDescr2 = New System.Windows.Forms.TextBox
        Me.txtDescr1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Header1 = New Wizard.Header
        Me.StartPage = New Wizard.WizardPage
        Me.InfoPage1 = New Wizard.InfoPage
        Me.EndPage = New Wizard.WizardPage
        Me.InfoPage2 = New Wizard.InfoPage
        Me.ProgressPage = New Wizard.WizardPage
        Me.lblActivity = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Header5 = New Wizard.Header
        Me.SummarizePage = New Wizard.WizardPage
        Me.txtSummarize = New System.Windows.Forms.TextBox
        Me.Header4 = New Wizard.Header
        Me.Definition2Page = New Wizard.WizardPage
        Me.ControlSelezioneComponentiLista2 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelezioneComponentiLista
        Me.Header3 = New Wizard.Header
        Me.Definition1Page = New Wizard.WizardPage
        Me.ControlSelezioneComponentiLista1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelezioneComponentiLista
        Me.Header2 = New Wizard.Header
        Me.Wizard1.SuspendLayout()
        Me.DescriptionPage.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.EndPage.SuspendLayout()
        Me.ProgressPage.SuspendLayout()
        Me.SummarizePage.SuspendLayout()
        Me.Definition2Page.SuspendLayout()
        Me.Definition1Page.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.EndPage)
        Me.Wizard1.Controls.Add(Me.ProgressPage)
        Me.Wizard1.Controls.Add(Me.SummarizePage)
        Me.Wizard1.Controls.Add(Me.Definition2Page)
        Me.Wizard1.Controls.Add(Me.Definition1Page)
        Me.Wizard1.Controls.Add(Me.DescriptionPage)
        Me.Wizard1.Controls.Add(Me.StartPage)
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Wizard.WizardPage() {Me.StartPage, Me.DescriptionPage, Me.Definition1Page, Me.Definition2Page, Me.SummarizePage, Me.ProgressPage, Me.EndPage})
        Me.Wizard1.Size = New System.Drawing.Size(514, 325)
        Me.Wizard1.TabIndex = 0
        '
        'DescriptionPage
        '
        Me.DescriptionPage.Controls.Add(Me.txtDescr2)
        Me.DescriptionPage.Controls.Add(Me.txtDescr1)
        Me.DescriptionPage.Controls.Add(Me.Label3)
        Me.DescriptionPage.Controls.Add(Me.Label2)
        Me.DescriptionPage.Controls.Add(Me.Label1)
        Me.DescriptionPage.Controls.Add(Me.Header1)
        Me.DescriptionPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionPage.IsFinishPage = False
        Me.DescriptionPage.Location = New System.Drawing.Point(0, 0)
        Me.DescriptionPage.Name = "DescriptionPage"
        Me.DescriptionPage.Size = New System.Drawing.Size(514, 277)
        Me.DescriptionPage.TabIndex = 2
        '
        'txtDescr2
        '
        Me.txtDescr2.Location = New System.Drawing.Point(185, 142)
        Me.txtDescr2.Name = "txtDescr2"
        Me.txtDescr2.Size = New System.Drawing.Size(220, 21)
        Me.txtDescr2.TabIndex = 5
        '
        'txtDescr1
        '
        Me.txtDescr1.Location = New System.Drawing.Point(185, 110)
        Me.txtDescr1.Name = "txtDescr1"
        Me.txtDescr1.Size = New System.Drawing.Size(220, 21)
        Me.txtDescr1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Inserire le descrizioni delle liste che dovranno essere confrontate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descrizione lista di confronto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descerizione lista iniziale"
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.SystemColors.Control
        Me.Header1.CausesValidation = False
        Me.Header1.Description = "In questo passaggio vengono fornite le descrizioni delle due liste di lavoro che " & _
            "dovranno essere confrontate."
        Me.Header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(514, 69)
        Me.Header1.TabIndex = 0
        Me.Header1.Title = "Descrizione liste da confrontare"
        '
        'StartPage
        '
        Me.StartPage.Controls.Add(Me.InfoPage1)
        Me.StartPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPage.IsFinishPage = False
        Me.StartPage.Location = New System.Drawing.Point(0, 0)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Size = New System.Drawing.Size(514, 277)
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
        Me.InfoPage1.PageTitle = "Benvenuto nella procedura guidata per il confronto delle liste di lavoro."
        Me.InfoPage1.Size = New System.Drawing.Size(514, 277)
        Me.InfoPage1.TabIndex = 0
        '
        'EndPage
        '
        Me.EndPage.Controls.Add(Me.InfoPage2)
        Me.EndPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndPage.IsFinishPage = True
        Me.EndPage.Location = New System.Drawing.Point(0, 0)
        Me.EndPage.Name = "EndPage"
        Me.EndPage.Size = New System.Drawing.Size(514, 277)
        Me.EndPage.TabIndex = 7
        '
        'InfoPage2
        '
        Me.InfoPage2.BackColor = System.Drawing.Color.White
        Me.InfoPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.wizard1
        Me.InfoPage2.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage2.Name = "InfoPage2"
        Me.InfoPage2.PageText = resources.GetString("InfoPage2.PageText")
        Me.InfoPage2.PageTitle = "Procedura guidata per il confronto liste di lavoro terminate"
        Me.InfoPage2.Size = New System.Drawing.Size(514, 277)
        Me.InfoPage2.TabIndex = 0
        '
        'ProgressPage
        '
        Me.ProgressPage.Controls.Add(Me.lblActivity)
        Me.ProgressPage.Controls.Add(Me.ProgressBar1)
        Me.ProgressPage.Controls.Add(Me.Header5)
        Me.ProgressPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPage.IsFinishPage = False
        Me.ProgressPage.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPage.Name = "ProgressPage"
        Me.ProgressPage.Size = New System.Drawing.Size(514, 277)
        Me.ProgressPage.TabIndex = 6
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Location = New System.Drawing.Point(47, 163)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(23, 13)
        Me.lblActivity.TabIndex = 2
        Me.lblActivity.Text = "...."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(41, 119)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(408, 32)
        Me.ProgressBar1.TabIndex = 1
        '
        'Header5
        '
        Me.Header5.BackColor = System.Drawing.SystemColors.Control
        Me.Header5.CausesValidation = False
        Me.Header5.Description = "Stato di avanzamento attività"
        Me.Header5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header5.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header5.Location = New System.Drawing.Point(0, 0)
        Me.Header5.Name = "Header5"
        Me.Header5.Size = New System.Drawing.Size(514, 68)
        Me.Header5.TabIndex = 0
        Me.Header5.Title = "Avanzamento attività"
        '
        'SummarizePage
        '
        Me.SummarizePage.Controls.Add(Me.txtSummarize)
        Me.SummarizePage.Controls.Add(Me.Header4)
        Me.SummarizePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SummarizePage.IsFinishPage = False
        Me.SummarizePage.Location = New System.Drawing.Point(0, 0)
        Me.SummarizePage.Name = "SummarizePage"
        Me.SummarizePage.Size = New System.Drawing.Size(514, 277)
        Me.SummarizePage.TabIndex = 5
        '
        'txtSummarize
        '
        Me.txtSummarize.Enabled = False
        Me.txtSummarize.Location = New System.Drawing.Point(17, 77)
        Me.txtSummarize.Multiline = True
        Me.txtSummarize.Name = "txtSummarize"
        Me.txtSummarize.Size = New System.Drawing.Size(481, 181)
        Me.txtSummarize.TabIndex = 1
        '
        'Header4
        '
        Me.Header4.BackColor = System.Drawing.SystemColors.Control
        Me.Header4.CausesValidation = False
        Me.Header4.Description = "Visualizzazione del riepilogo delle liste da confrontare e dei rispettivi contenu" & _
            "ti"
        Me.Header4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header4.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header4.Location = New System.Drawing.Point(0, 0)
        Me.Header4.Name = "Header4"
        Me.Header4.Size = New System.Drawing.Size(514, 65)
        Me.Header4.TabIndex = 0
        Me.Header4.Title = "Riepilogo"
        '
        'Definition2Page
        '
        Me.Definition2Page.Controls.Add(Me.ControlSelezioneComponentiLista2)
        Me.Definition2Page.Controls.Add(Me.Header3)
        Me.Definition2Page.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Definition2Page.IsFinishPage = False
        Me.Definition2Page.Location = New System.Drawing.Point(0, 0)
        Me.Definition2Page.Name = "Definition2Page"
        Me.Definition2Page.Size = New System.Drawing.Size(514, 277)
        Me.Definition2Page.TabIndex = 4
        '
        'ControlSelezioneComponentiLista2
        '
        Me.ControlSelezioneComponentiLista2.BackColor = System.Drawing.Color.Gainsboro
        Me.ControlSelezioneComponentiLista2.Location = New System.Drawing.Point(3, 50)
        Me.ControlSelezioneComponentiLista2.Name = "ControlSelezioneComponentiLista2"
        Me.ControlSelezioneComponentiLista2.Size = New System.Drawing.Size(508, 227)
        Me.ControlSelezioneComponentiLista2.TabIndex = 2
        '
        'Header3
        '
        Me.Header3.BackColor = System.Drawing.SystemColors.Control
        Me.Header3.CausesValidation = False
        Me.Header3.Description = "In questo passaggio vengono definiti i contenuti della lista di confronto"
        Me.Header3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header3.Location = New System.Drawing.Point(0, 0)
        Me.Header3.Name = "Header3"
        Me.Header3.Size = New System.Drawing.Size(514, 50)
        Me.Header3.TabIndex = 1
        Me.Header3.Title = "Definizione lista di confronto"
        '
        'Definition1Page
        '
        Me.Definition1Page.Controls.Add(Me.ControlSelezioneComponentiLista1)
        Me.Definition1Page.Controls.Add(Me.Header2)
        Me.Definition1Page.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Definition1Page.IsFinishPage = False
        Me.Definition1Page.Location = New System.Drawing.Point(0, 0)
        Me.Definition1Page.Name = "Definition1Page"
        Me.Definition1Page.Size = New System.Drawing.Size(514, 277)
        Me.Definition1Page.TabIndex = 3
        '
        'ControlSelezioneComponentiLista1
        '
        Me.ControlSelezioneComponentiLista1.BackColor = System.Drawing.Color.Gainsboro
        Me.ControlSelezioneComponentiLista1.Location = New System.Drawing.Point(3, 49)
        Me.ControlSelezioneComponentiLista1.Name = "ControlSelezioneComponentiLista1"
        Me.ControlSelezioneComponentiLista1.Size = New System.Drawing.Size(508, 227)
        Me.ControlSelezioneComponentiLista1.TabIndex = 1
        '
        'Header2
        '
        Me.Header2.BackColor = System.Drawing.SystemColors.Control
        Me.Header2.CausesValidation = False
        Me.Header2.Description = "In questo passaggio vengono definiti i contenuti della lista di lavoro iniziale."
        Me.Header2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header2.Location = New System.Drawing.Point(0, 0)
        Me.Header2.Name = "Header2"
        Me.Header2.Size = New System.Drawing.Size(514, 50)
        Me.Header2.TabIndex = 0
        Me.Header2.Title = "Definizione lista iniziale"
        '
        'FrmConfrontoListeWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 325)
        Me.Controls.Add(Me.Wizard1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfrontoListeWizard"
        Me.Text = "Creazione confronto liste lavoro"
        Me.Wizard1.ResumeLayout(False)
        Me.DescriptionPage.ResumeLayout(False)
        Me.DescriptionPage.PerformLayout()
        Me.StartPage.ResumeLayout(False)
        Me.EndPage.ResumeLayout(False)
        Me.ProgressPage.ResumeLayout(False)
        Me.ProgressPage.PerformLayout()
        Me.SummarizePage.ResumeLayout(False)
        Me.SummarizePage.PerformLayout()
        Me.Definition2Page.ResumeLayout(False)
        Me.Definition1Page.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Wizard.Wizard
    Friend WithEvents SummarizePage As Wizard.WizardPage
    Friend WithEvents Definition2Page As Wizard.WizardPage
    Friend WithEvents Definition1Page As Wizard.WizardPage
    Friend WithEvents DescriptionPage As Wizard.WizardPage
    Friend WithEvents StartPage As Wizard.WizardPage
    Friend WithEvents ProgressPage As Wizard.WizardPage
    Friend WithEvents EndPage As Wizard.WizardPage
    Friend WithEvents InfoPage1 As Wizard.InfoPage
    Friend WithEvents Header1 As Wizard.Header
    Friend WithEvents Header2 As Wizard.Header
    Friend WithEvents Header4 As Wizard.Header
    Friend WithEvents Header3 As Wizard.Header
    Friend WithEvents Header5 As Wizard.Header
    Friend WithEvents InfoPage2 As Wizard.InfoPage
    Friend WithEvents ControlSelezioneComponentiLista1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelezioneComponentiLista
    Friend WithEvents ControlSelezioneComponentiLista2 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelezioneComponentiLista
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtSummarize As System.Windows.Forms.TextBox
    Friend WithEvents txtDescr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescr1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
