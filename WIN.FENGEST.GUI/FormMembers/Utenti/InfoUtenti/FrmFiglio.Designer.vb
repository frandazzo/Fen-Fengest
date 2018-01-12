<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiglio
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.txtNome = New WIN.GUI.UTILITY.UsabilityTextBox
        Me.txtCognome = New WIN.GUI.UTILITY.UsabilityTextBox
        Me.dtpData = New WIN.GUI.UTILITY.UsabilityDtPicker
        Me.txtScuola = New WIN.GUI.UTILITY.UsabilityTextBox
        Me.txtAnno = New WIN.GUI.UTILITY.UsabilityTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCF = New WIN.GUI.UTILITY.UsabilityTextBox
        Me.SpCf = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(17, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cogn."
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(102, 200)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(69, 27)
        Me.cmdOk.TabIndex = 13
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(254, 199)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(65, 28)
        Me.cmdAnnulla.TabIndex = 15
        Me.cmdAnnulla.Text = "&Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.HelpProvider1.SetHelpString(Me.cmdAdd, "Funzione che permette di aggiungere le informazioni sul figlio del lavoratore")
        Me.cmdAdd.Location = New System.Drawing.Point(177, 200)
        Me.cmdAdd.Name = "cmdAdd"
        Me.HelpProvider1.SetShowHelp(Me.cmdAdd, True)
        Me.cmdAdd.Size = New System.Drawing.Size(71, 27)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "A&ggiungi"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data n."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Scuola"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.txtNome, "Nome del figlio")
        Me.txtNome.IsMultiline = False
        Me.txtNome.Location = New System.Drawing.Point(58, 9)
        Me.txtNome.Mandatory = False
        Me.txtNome.Name = "txtNome"
        Me.txtNome.OverridedEnable = True
        Me.txtNome.Required = True
        Me.HelpProvider1.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(150, 22)
        Me.txtNome.TabIndex = 1
        Me.txtNome.TextHeight = 20
        Me.txtNome.TextValue = ""
        '
        'txtCognome
        '
        Me.txtCognome.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.txtCognome, "Cogome del figlio")
        Me.txtCognome.IsMultiline = False
        Me.txtCognome.Location = New System.Drawing.Point(58, 37)
        Me.txtCognome.Mandatory = False
        Me.txtCognome.Name = "txtCognome"
        Me.txtCognome.OverridedEnable = True
        Me.txtCognome.Required = True
        Me.HelpProvider1.SetShowHelp(Me.txtCognome, True)
        Me.txtCognome.Size = New System.Drawing.Size(150, 23)
        Me.txtCognome.TabIndex = 3
        Me.txtCognome.TextHeight = 20
        Me.txtCognome.TextValue = ""
        '
        'dtpData
        '
        Me.dtpData.BackColor = System.Drawing.Color.Transparent
        Me.dtpData.DataValue = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data nascita del figlio")
        Me.dtpData.Location = New System.Drawing.Point(58, 66)
        Me.dtpData.Mandatory = False
        Me.dtpData.Name = "dtpData"
        Me.dtpData.OverridedEnable = True
        Me.dtpData.Required = True
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(128, 25)
        Me.dtpData.TabIndex = 5
        '
        'txtScuola
        '
        Me.txtScuola.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpKeyword(Me.txtScuola, "Scuola di frequentazione del figlio")
        Me.txtScuola.IsMultiline = False
        Me.txtScuola.Location = New System.Drawing.Point(58, 126)
        Me.txtScuola.Mandatory = False
        Me.txtScuola.Name = "txtScuola"
        Me.txtScuola.OverridedEnable = True
        Me.txtScuola.Required = False
        Me.HelpProvider1.SetShowHelp(Me.txtScuola, True)
        Me.txtScuola.Size = New System.Drawing.Size(213, 24)
        Me.txtScuola.TabIndex = 10
        Me.txtScuola.TextHeight = 20
        Me.txtScuola.TextValue = ""
        '
        'txtAnno
        '
        Me.txtAnno.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpKeyword(Me.txtAnno, "Anno di frequentazione")
        Me.txtAnno.IsMultiline = False
        Me.txtAnno.Location = New System.Drawing.Point(58, 153)
        Me.txtAnno.Mandatory = False
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.OverridedEnable = True
        Me.txtAnno.Required = False
        Me.HelpProvider1.SetShowHelp(Me.txtAnno, True)
        Me.txtAnno.Size = New System.Drawing.Size(104, 24)
        Me.txtAnno.TabIndex = 12
        Me.txtAnno.TextHeight = 20
        Me.txtAnno.TextValue = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.Label6, "Codice fiscale del figlio")
        Me.Label6.Location = New System.Drawing.Point(17, 102)
        Me.Label6.Name = "Label6"
        Me.HelpProvider1.SetShowHelp(Me.Label6, True)
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "C.F."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(5, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "An. freq."
        '
        'txtCF
        '
        Me.txtCF.BackColor = System.Drawing.Color.Transparent
        Me.txtCF.IsMultiline = False
        Me.txtCF.Location = New System.Drawing.Point(58, 97)
        Me.txtCF.Mandatory = False
        Me.txtCF.Name = "txtCF"
        Me.txtCF.OverridedEnable = True
        Me.txtCF.Required = False
        Me.txtCF.Size = New System.Drawing.Size(150, 23)
        Me.txtCF.TabIndex = 7
        Me.txtCF.TextHeight = 20
        Me.txtCF.TextValue = ""
        '
        'SpCf
        '
        Me.SpCf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SpCf.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_calc_16x16
        Me.SpCf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SpCf.Location = New System.Drawing.Point(214, 95)
        Me.SpCf.Name = "SpCf"
        Me.SpCf.Size = New System.Drawing.Size(110, 25)
        Me.SpCf.TabIndex = 8
        Me.SpCf.Text = "Calc. Cod. &Fisc."
        Me.SpCf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SpCf.UseVisualStyleBackColor = True
        '
        'FrmFiglio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(335, 239)
        Me.Controls.Add(Me.SpCf)
        Me.Controls.Add(Me.txtCF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAnno)
        Me.Controls.Add(Me.txtScuola)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.txtCognome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmFiglio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dati figlio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtNome As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents txtCognome As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents dtpData As WIN.GUI.UTILITY.UsabilityDtPicker
   Friend WithEvents txtScuola As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents txtAnno As WIN.GUI.UTILITY.UsabilityTextBox
   Friend WithEvents txtCF As WIN.GUI.UTILITY.UsabilityTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SpCf As System.Windows.Forms.Button
End Class
