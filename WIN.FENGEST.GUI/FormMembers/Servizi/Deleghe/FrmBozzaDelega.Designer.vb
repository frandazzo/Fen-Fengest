<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBozzaDelega
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
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.chkDuplica = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(90, 180)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Collaboratore"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"CASSA EDILE", "EDILCASSA"})
        Me.cboTipo.Location = New System.Drawing.Point(87, 41)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(147, 21)
        Me.cboTipo.TabIndex = 65
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(87, 12)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(110, 20)
        Me.dtpData.TabIndex = 64
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(228, 219)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(62, 27)
        Me.cmdAnnulla.TabIndex = 63
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(152, 219)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(62, 27)
        Me.cmdOk.TabIndex = 62
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Ente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Data"
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.Color.Black
        Me.lblUtente.Location = New System.Drawing.Point(91, 118)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblUtente.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Utente"
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(87, 81)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(93, 23)
        Me.IdUtenteTextBox1.TabIndex = 73
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 300
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(87, 148)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(93, 23)
        Me.IdReferenteTextBox1.TabIndex = 67
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'chkDuplica
        '
        Me.chkDuplica.AutoSize = True
        Me.chkDuplica.Location = New System.Drawing.Point(22, 194)
        Me.chkDuplica.Name = "chkDuplica"
        Me.chkDuplica.Size = New System.Drawing.Size(184, 17)
        Me.chkDuplica.TabIndex = 74
        Me.chkDuplica.Text = "Duplica per entrambi enti bilaterali"
        Me.chkDuplica.UseVisualStyleBackColor = True
        '
        'FrmBozzaDelega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 258)
        Me.Controls.Add(Me.chkDuplica)
        Me.Controls.Add(Me.IdUtenteTextBox1)
        Me.Controls.Add(Me.lblUtente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDescrizioneReferente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IdReferenteTextBox1)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBozzaDelega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bozza delega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUtente As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents chkDuplica As System.Windows.Forms.CheckBox
End Class
