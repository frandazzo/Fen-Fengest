<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPraticaWizard
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
        Me.Wizard1 = New Wizard.Wizard()
        Me.StartPage = New Wizard.WizardPage()
        Me.InfoPage1 = New Wizard.InfoPage()
        Me.ModelPage = New Wizard.WizardPage()
        Me.cmdTag = New System.Windows.Forms.Button()
        Me.cmdModello = New System.Windows.Forms.Button()
        Me.lblModello = New System.Windows.Forms.Label()
        Me.Header4 = New Wizard.Header()
        Me.ComunicationPage = New Wizard.WizardPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Header3 = New Wizard.Header()
        Me.EndPage = New Wizard.WizardPage()
        Me.InfoPage2 = New Wizard.InfoPage()
        Me.Wizard1.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.ModelPage.SuspendLayout()
        Me.ComunicationPage.SuspendLayout()
        Me.EndPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.ComunicationPage)
        Me.Wizard1.Controls.Add(Me.ModelPage)
        Me.Wizard1.Controls.Add(Me.StartPage)
        Me.Wizard1.Controls.Add(Me.EndPage)
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Wizard.WizardPage() {Me.StartPage, Me.ModelPage, Me.ComunicationPage, Me.EndPage})
        Me.Wizard1.Size = New System.Drawing.Size(494, 317)
        Me.Wizard1.TabIndex = 2
        '
        'StartPage
        '
        Me.StartPage.Controls.Add(Me.InfoPage1)
        Me.StartPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPage.IsFinishPage = False
        Me.StartPage.Location = New System.Drawing.Point(0, 0)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Size = New System.Drawing.Size(494, 269)
        Me.StartPage.TabIndex = 1
        '
        'InfoPage1
        '
        Me.InfoPage1.BackColor = System.Drawing.Color.White
        Me.InfoPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.wizard1
        Me.InfoPage1.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage1.Name = "InfoPage1"
        Me.InfoPage1.PageText = "Con questa procedura è possibile generare un documento precompilato per la pratic" & _
    "a selezionata aggiungendo un allegato alla stessa"
        Me.InfoPage1.PageTitle = "Procedura guidata compilazione modelli"
        Me.InfoPage1.Size = New System.Drawing.Size(494, 269)
        Me.InfoPage1.TabIndex = 0
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
        Me.ModelPage.Size = New System.Drawing.Size(494, 269)
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
        Me.Header4.Size = New System.Drawing.Size(494, 62)
        Me.Header4.TabIndex = 0
        Me.Header4.Title = "Selezione modello"
        '
        'ComunicationPage
        '
        Me.ComunicationPage.Controls.Add(Me.Label1)
        Me.ComunicationPage.Controls.Add(Me.txtNote)
        Me.ComunicationPage.Controls.Add(Me.Header3)
        Me.ComunicationPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComunicationPage.IsFinishPage = False
        Me.ComunicationPage.Location = New System.Drawing.Point(0, 0)
        Me.ComunicationPage.Name = "ComunicationPage"
        Me.ComunicationPage.Size = New System.Drawing.Size(494, 269)
        Me.ComunicationPage.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(23, 97)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(442, 150)
        Me.txtNote.TabIndex = 1
        '
        'Header3
        '
        Me.Header3.BackColor = System.Drawing.SystemColors.Control
        Me.Header3.CausesValidation = False
        Me.Header3.Description = "Impostareeventuali note da allegare alla pratica"
        Me.Header3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logoFeneal48x48
        Me.Header3.Location = New System.Drawing.Point(0, 0)
        Me.Header3.Name = "Header3"
        Me.Header3.Size = New System.Drawing.Size(494, 62)
        Me.Header3.TabIndex = 0
        Me.Header3.Title = "Azioni "
        '
        'EndPage
        '
        Me.EndPage.Controls.Add(Me.InfoPage2)
        Me.EndPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndPage.IsFinishPage = True
        Me.EndPage.Location = New System.Drawing.Point(0, 0)
        Me.EndPage.Name = "EndPage"
        Me.EndPage.Size = New System.Drawing.Size(494, 269)
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
        Me.InfoPage2.Size = New System.Drawing.Size(494, 269)
        Me.InfoPage2.TabIndex = 0
        '
        'FrmPraticaWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 317)
        Me.Controls.Add(Me.Wizard1)
        Me.Name = "FrmPraticaWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compila doocumento"
        Me.Wizard1.ResumeLayout(False)
        Me.StartPage.ResumeLayout(False)
        Me.ModelPage.ResumeLayout(False)
        Me.ModelPage.PerformLayout()
        Me.ComunicationPage.ResumeLayout(False)
        Me.ComunicationPage.PerformLayout()
        Me.EndPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Wizard.Wizard
    Friend WithEvents StartPage As Wizard.WizardPage
    Friend WithEvents InfoPage1 As Wizard.InfoPage
    Friend WithEvents ModelPage As Wizard.WizardPage
    Friend WithEvents cmdTag As System.Windows.Forms.Button
    Friend WithEvents cmdModello As System.Windows.Forms.Button
    Friend WithEvents lblModello As System.Windows.Forms.Label
    Friend WithEvents Header4 As Wizard.Header
    Friend WithEvents ComunicationPage As Wizard.WizardPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Header3 As Wizard.Header
    Friend WithEvents EndPage As Wizard.WizardPage
    Friend WithEvents InfoPage2 As Wizard.InfoPage
End Class
