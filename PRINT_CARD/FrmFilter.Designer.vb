<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilter
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
        Me.txtCognome = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAzienda = New System.Windows.Forms.TextBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.txtComune = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkAddressOK = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkAzNull = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.numDa = New System.Windows.Forms.NumericUpDown
        Me.NumA = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.numDa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCognome
        '
        Me.txtCognome.Location = New System.Drawing.Point(91, 76)
        Me.txtCognome.Name = "txtCognome"
        Me.txtCognome.Size = New System.Drawing.Size(136, 20)
        Me.txtCognome.TabIndex = 12
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(91, 49)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(136, 20)
        Me.txtNome.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cognome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Azienda"
        '
        'txtAzienda
        '
        Me.txtAzienda.Location = New System.Drawing.Point(91, 103)
        Me.txtAzienda.Name = "txtAzienda"
        Me.txtAzienda.Size = New System.Drawing.Size(193, 20)
        Me.txtAzienda.TabIndex = 13
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(226, 259)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(77, 26)
        Me.cmdOK.TabIndex = 17
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(309, 259)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(84, 26)
        Me.cmdAnnulla.TabIndex = 18
        Me.cmdAnnulla.Text = "&Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'txtComune
        '
        Me.txtComune.Location = New System.Drawing.Point(91, 134)
        Me.txtComune.Name = "txtComune"
        Me.txtComune.Size = New System.Drawing.Size(193, 20)
        Me.txtComune.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(24, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Comune"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Selezionare un possibile filtro per la visualizzazione dei dati"
        '
        'chkAddressOK
        '
        Me.chkAddressOK.AutoSize = True
        Me.chkAddressOK.Location = New System.Drawing.Point(96, 234)
        Me.chkAddressOK.Name = "chkAddressOK"
        Me.chkAddressOK.Size = New System.Drawing.Size(305, 17)
        Me.chkAddressOK.TabIndex = 23
        Me.chkAddressOK.Text = "Solo elementi con indirizzo valido(comune,via cap non nulli)"
        Me.chkAddressOK.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(27, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(349, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "_________________________________________________________"
        '
        'chkAzNull
        '
        Me.chkAzNull.AutoSize = True
        Me.chkAzNull.Location = New System.Drawing.Point(295, 105)
        Me.chkAzNull.Name = "chkAzNull"
        Me.chkAzNull.Size = New System.Drawing.Size(89, 17)
        Me.chkAzNull.TabIndex = 25
        Me.chkAzNull.Text = "Azienda nulla"
        Me.chkAzNull.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Da indice..."
        '
        'numDa
        '
        Me.numDa.Location = New System.Drawing.Point(92, 164)
        Me.numDa.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numDa.Name = "numDa"
        Me.numDa.Size = New System.Drawing.Size(63, 20)
        Me.numDa.TabIndex = 27
        '
        'NumA
        '
        Me.NumA.Location = New System.Drawing.Point(91, 190)
        Me.NumA.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumA.Name = "NumA"
        Me.NumA.Size = New System.Drawing.Size(63, 20)
        Me.NumA.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "A indice..."
        '
        'FrmFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 297)
        Me.Controls.Add(Me.NumA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numDa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkAzNull)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkAddressOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtComune)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtCognome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAzienda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro dati"
        CType(Me.numDa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCognome As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAzienda As System.Windows.Forms.TextBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents txtComune As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkAddressOK As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkAzNull As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numDa As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumA As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
