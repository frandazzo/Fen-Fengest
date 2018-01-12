<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWizardInps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWizardInps))
        Me.Wizard1 = New Wizard.Wizard()
        Me.ModelPage = New Wizard.WizardPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblPathComuni = New System.Windows.Forms.Label()
        Me.cmdModello = New System.Windows.Forms.Button()
        Me.Header4 = New Wizard.Header()
        Me.ListPage = New Wizard.WizardPage()
        Me.optPath = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblPercorso = New System.Windows.Forms.Label()
        Me.optFile = New System.Windows.Forms.RadioButton()
        Me.Header1 = New Wizard.Header()
        Me.StartPage = New Wizard.WizardPage()
        Me.InfoPage1 = New Wizard.InfoPage()
        Me.EndPage = New Wizard.WizardPage()
        Me.InfoPage2 = New Wizard.InfoPage()
        Me.ComunicationPage = New Wizard.WizardPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkSave = New System.Windows.Forms.CheckBox()
        Me.Header3 = New Wizard.Header()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblAnal = New System.Windows.Forms.Label()
        Me.Wizard1.SuspendLayout()
        Me.ModelPage.SuspendLayout()
        Me.ListPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.EndPage.SuspendLayout()
        Me.ComunicationPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.ModelPage)
        Me.Wizard1.Controls.Add(Me.ListPage)
        Me.Wizard1.Controls.Add(Me.StartPage)
        Me.Wizard1.Controls.Add(Me.EndPage)
        Me.Wizard1.Controls.Add(Me.ComunicationPage)
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Wizard.WizardPage() {Me.StartPage, Me.ListPage, Me.ModelPage, Me.ComunicationPage, Me.EndPage})
        Me.Wizard1.Size = New System.Drawing.Size(504, 356)
        Me.Wizard1.TabIndex = 2
        '
        'ModelPage
        '
        Me.ModelPage.Controls.Add(Me.lblAnal)
        Me.ModelPage.Controls.Add(Me.Label4)
        Me.ModelPage.Controls.Add(Me.Button2)
        Me.ModelPage.Controls.Add(Me.lblPathComuni)
        Me.ModelPage.Controls.Add(Me.cmdModello)
        Me.ModelPage.Controls.Add(Me.Header4)
        Me.ModelPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModelPage.IsFinishPage = False
        Me.ModelPage.Location = New System.Drawing.Point(0, 0)
        Me.ModelPage.Name = "ModelPage"
        Me.ModelPage.Size = New System.Drawing.Size(504, 308)
        Me.ModelPage.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 230)
        Me.Label4.MaximumSize = New System.Drawing.Size(180, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Visualizza file analizzati"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(252, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 51)
        Me.Button2.TabIndex = 156
        Me.Button2.Text = "Rimuovi percorso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblPathComuni
        '
        Me.lblPathComuni.AutoSize = True
        Me.lblPathComuni.BackColor = System.Drawing.Color.Transparent
        Me.lblPathComuni.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPathComuni.Location = New System.Drawing.Point(42, 178)
        Me.lblPathComuni.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblPathComuni.Name = "lblPathComuni"
        Me.lblPathComuni.Size = New System.Drawing.Size(144, 13)
        Me.lblPathComuni.TabIndex = 155
        Me.lblPathComuni.Text = "nessun path selezionato"
        '
        'cmdModello
        '
        Me.cmdModello.Location = New System.Drawing.Point(27, 94)
        Me.cmdModello.Name = "cmdModello"
        Me.cmdModello.Size = New System.Drawing.Size(178, 51)
        Me.cmdModello.TabIndex = 152
        Me.cmdModello.Text = "Seleziona percorso file dalle camere comunali"
        Me.cmdModello.UseVisualStyleBackColor = True
        '
        'Header4
        '
        Me.Header4.BackColor = System.Drawing.SystemColors.Control
        Me.Header4.CausesValidation = False
        Me.Header4.Description = "Selezionare e aggiungere i vari file excel proveninenti dalle camere comunali con" & _
    " i dati delle prestazioni effettuate ed il riferimento al collaboratore che le h" & _
    "a create"
        Me.Header4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header4.Image = CType(resources.GetObject("Header4.Image"), System.Drawing.Image)
        Me.Header4.Location = New System.Drawing.Point(0, 0)
        Me.Header4.Name = "Header4"
        Me.Header4.Size = New System.Drawing.Size(504, 62)
        Me.Header4.TabIndex = 0
        Me.Header4.Title = "Selezione file da incrociare"
        '
        'ListPage
        '
        Me.ListPage.Controls.Add(Me.optPath)
        Me.ListPage.Controls.Add(Me.GroupBox2)
        Me.ListPage.Controls.Add(Me.GroupBox1)
        Me.ListPage.Controls.Add(Me.optFile)
        Me.ListPage.Controls.Add(Me.Header1)
        Me.ListPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPage.IsFinishPage = False
        Me.ListPage.Location = New System.Drawing.Point(0, 0)
        Me.ListPage.Name = "ListPage"
        Me.ListPage.Size = New System.Drawing.Size(504, 308)
        Me.ListPage.TabIndex = 2
        '
        'optPath
        '
        Me.optPath.AutoSize = True
        Me.optPath.Location = New System.Drawing.Point(35, 102)
        Me.optPath.Name = "optPath"
        Me.optPath.Size = New System.Drawing.Size(254, 17)
        Me.optPath.TabIndex = 158
        Me.optPath.Text = "Seleziona percorso quote Inps da template Inps"
        Me.optPath.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.lblPath)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 149)
        Me.GroupBox2.TabIndex = 157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selezione percorso"
        Me.GroupBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 121)
        Me.Label2.MaximumSize = New System.Drawing.Size(180, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Visualizza file analizzati"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 32)
        Me.Button3.TabIndex = 153
        Me.Button3.Text = "&Seleziona percorso"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BackColor = System.Drawing.Color.Transparent
        Me.lblPath.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(6, 82)
        Me.lblPath.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(144, 13)
        Me.lblPath.TabIndex = 154
        Me.lblPath.Text = "nessun path selezionato"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblPercorso)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 149)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selezione file"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 32)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "&Seleziona il file "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblPercorso
        '
        Me.lblPercorso.AutoSize = True
        Me.lblPercorso.BackColor = System.Drawing.Color.Transparent
        Me.lblPercorso.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercorso.Location = New System.Drawing.Point(6, 82)
        Me.lblPercorso.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblPercorso.Name = "lblPercorso"
        Me.lblPercorso.Size = New System.Drawing.Size(135, 13)
        Me.lblPercorso.TabIndex = 154
        Me.lblPercorso.Text = "nessun file selezionato"
        '
        'optFile
        '
        Me.optFile.AutoSize = True
        Me.optFile.Checked = True
        Me.optFile.Location = New System.Drawing.Point(35, 79)
        Me.optFile.Name = "optFile"
        Me.optFile.Size = New System.Drawing.Size(258, 17)
        Me.optFile.TabIndex = 155
        Me.optFile.TabStop = True
        Me.optFile.Text = "Seleziona file quote Inps da template Fenealgest"
        Me.optFile.UseVisualStyleBackColor = True
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.SystemColors.Control
        Me.Header1.CausesValidation = False
        Me.Header1.Description = "Selezionare il file Excel contenente tutti i dati delle quote provenienti dall'In" & _
    "ps"
        Me.Header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header1.Image = CType(resources.GetObject("Header1.Image"), System.Drawing.Image)
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(504, 63)
        Me.Header1.TabIndex = 0
        Me.Header1.Title = "Selezione file principale"
        '
        'StartPage
        '
        Me.StartPage.Controls.Add(Me.InfoPage1)
        Me.StartPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPage.IsFinishPage = False
        Me.StartPage.Location = New System.Drawing.Point(0, 0)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Size = New System.Drawing.Size(504, 308)
        Me.StartPage.TabIndex = 1
        '
        'InfoPage1
        '
        Me.InfoPage1.BackColor = System.Drawing.Color.White
        Me.InfoPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage1.Image = CType(resources.GetObject("InfoPage1.Image"), System.Drawing.Image)
        Me.InfoPage1.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage1.Name = "InfoPage1"
        Me.InfoPage1.PageText = resources.GetString("InfoPage1.PageText")
        Me.InfoPage1.PageTitle = "Procedura guidata importazione quote Inps"
        Me.InfoPage1.Size = New System.Drawing.Size(504, 308)
        Me.InfoPage1.TabIndex = 0
        '
        'EndPage
        '
        Me.EndPage.Controls.Add(Me.InfoPage2)
        Me.EndPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndPage.IsFinishPage = True
        Me.EndPage.Location = New System.Drawing.Point(0, 0)
        Me.EndPage.Name = "EndPage"
        Me.EndPage.Size = New System.Drawing.Size(504, 308)
        Me.EndPage.TabIndex = 6
        '
        'InfoPage2
        '
        Me.InfoPage2.BackColor = System.Drawing.Color.White
        Me.InfoPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPage2.Image = CType(resources.GetObject("InfoPage2.Image"), System.Drawing.Image)
        Me.InfoPage2.Location = New System.Drawing.Point(0, 0)
        Me.InfoPage2.Name = "InfoPage2"
        Me.InfoPage2.PageText = "Termine procedura guidata"
        Me.InfoPage2.PageTitle = "Procedura guidata importazione quote inps"
        Me.InfoPage2.Size = New System.Drawing.Size(504, 308)
        Me.InfoPage2.TabIndex = 0
        '
        'ComunicationPage
        '
        Me.ComunicationPage.Controls.Add(Me.Label1)
        Me.ComunicationPage.Controls.Add(Me.Label3)
        Me.ComunicationPage.Controls.Add(Me.chkSave)
        Me.ComunicationPage.Controls.Add(Me.Header3)
        Me.ComunicationPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComunicationPage.IsFinishPage = False
        Me.ComunicationPage.Location = New System.Drawing.Point(0, 0)
        Me.ComunicationPage.Name = "ComunicationPage"
        Me.ComunicationPage.Size = New System.Drawing.Size(504, 308)
        Me.ComunicationPage.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 151)
        Me.Label1.MaximumSize = New System.Drawing.Size(260, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 26)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Visualizza elementi non trovati nel file principale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 115)
        Me.Label3.MaximumSize = New System.Drawing.Size(260, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Visualizza dati raccolti"
        '
        'chkSave
        '
        Me.chkSave.AutoSize = True
        Me.chkSave.Checked = True
        Me.chkSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSave.Location = New System.Drawing.Point(51, 198)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.Size = New System.Drawing.Size(230, 17)
        Me.chkSave.TabIndex = 161
        Me.chkSave.Text = "Importa al termine della procedura guidata"
        Me.chkSave.UseVisualStyleBackColor = True
        '
        'Header3
        '
        Me.Header3.BackColor = System.Drawing.SystemColors.Control
        Me.Header3.CausesValidation = False
        Me.Header3.Description = "Impostare i paramtri per definire le azioni che verranno eseguite dal sistema  do" & _
    "po la generazione e compilazione del modello"
        Me.Header3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header3.Image = CType(resources.GetObject("Header3.Image"), System.Drawing.Image)
        Me.Header3.Location = New System.Drawing.Point(0, 0)
        Me.Header3.Name = "Header3"
        Me.Header3.Size = New System.Drawing.Size(504, 62)
        Me.Header3.TabIndex = 0
        Me.Header3.Title = "Visualizzazione risultato incrocio dati"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblAnal
        '
        Me.lblAnal.AutoSize = True
        Me.lblAnal.Location = New System.Drawing.Point(50, 275)
        Me.lblAnal.Name = "lblAnal"
        Me.lblAnal.Size = New System.Drawing.Size(113, 13)
        Me.lblAnal.TabIndex = 158
        Me.lblAnal.Text = "Analisi incrocio dati...."
        '
        'FrmWizardInps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 356)
        Me.Controls.Add(Me.Wizard1)
        Me.Name = "FrmWizardInps"
        Me.Text = "Procedura guidata incasso quote inps"
        Me.Wizard1.ResumeLayout(False)
        Me.ModelPage.ResumeLayout(False)
        Me.ModelPage.PerformLayout()
        Me.ListPage.ResumeLayout(False)
        Me.ListPage.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StartPage.ResumeLayout(False)
        Me.EndPage.ResumeLayout(False)
        Me.ComunicationPage.ResumeLayout(False)
        Me.ComunicationPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Wizard.Wizard
    Friend WithEvents ModelPage As Wizard.WizardPage
    Friend WithEvents cmdModello As System.Windows.Forms.Button
    Friend WithEvents Header4 As Wizard.Header
    Friend WithEvents ListPage As Wizard.WizardPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Header1 As Wizard.Header
    Friend WithEvents StartPage As Wizard.WizardPage
    Friend WithEvents InfoPage1 As Wizard.InfoPage
    Friend WithEvents ComunicationPage As Wizard.WizardPage
    Friend WithEvents Header3 As Wizard.Header
    Friend WithEvents EndPage As Wizard.WizardPage
    Friend WithEvents InfoPage2 As Wizard.InfoPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkSave As System.Windows.Forms.CheckBox
    Friend WithEvents lblPercorso As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optFile As System.Windows.Forms.RadioButton
    Friend WithEvents optPath As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblPathComuni As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAnal As System.Windows.Forms.Label
End Class
