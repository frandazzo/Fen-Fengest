<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportEtichette
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportEtichette))
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.NumericUpDownEtPartenza = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownRipetizioni = New System.Windows.Forms.NumericUpDown
        Me.ComboBoxModello = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboProduttore = New System.Windows.Forms.ComboBox
        CType(Me.NumericUpDownEtPartenza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownRipetizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(178, 359)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(74, 27)
        Me.cmdOk.TabIndex = 67
        Me.cmdOk.Text = "&Esporta"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(258, 359)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(74, 27)
        Me.cmdAnnulla.TabIndex = 66
        Me.cmdAnnulla.Text = "&Chiudi"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'NumericUpDownEtPartenza
        '
        Me.NumericUpDownEtPartenza.Location = New System.Drawing.Point(91, 23)
        Me.NumericUpDownEtPartenza.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownEtPartenza.Name = "NumericUpDownEtPartenza"
        Me.NumericUpDownEtPartenza.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDownEtPartenza.TabIndex = 73
        Me.NumericUpDownEtPartenza.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDownRipetizioni
        '
        Me.NumericUpDownRipetizioni.Location = New System.Drawing.Point(247, 23)
        Me.NumericUpDownRipetizioni.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownRipetizioni.Name = "NumericUpDownRipetizioni"
        Me.NumericUpDownRipetizioni.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDownRipetizioni.TabIndex = 72
        Me.NumericUpDownRipetizioni.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ComboBoxModello
        '
        Me.ComboBoxModello.DisplayMember = "jhkh"
        Me.ComboBoxModello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxModello.FormattingEnabled = True
        Me.ComboBoxModello.Location = New System.Drawing.Point(76, 44)
        Me.ComboBoxModello.Name = "ComboBoxModello"
        Me.ComboBoxModello.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxModello.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Stampa da ..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Ripeti per ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Modello"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownRipetizioni)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownEtPartenza)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 65)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opzioni di elaborazione"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboProduttore)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxModello)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 257)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selezione modello etichette da stampare"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Info modello"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.non_disponibile
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(76, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 178)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Produttore"
        '
        'cboProduttore
        '
        Me.cboProduttore.DisplayMember = "jhkh"
        Me.cboProduttore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduttore.FormattingEnabled = True
        Me.cboProduttore.Items.AddRange(New Object() {"Buffetti"})
        Me.cboProduttore.Location = New System.Drawing.Point(76, 17)
        Me.cboProduttore.Name = "cboProduttore"
        Me.cboProduttore.Size = New System.Drawing.Size(171, 21)
        Me.cboProduttore.TabIndex = 75
        '
        'FrmExportEtichette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 412)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmExportEtichette"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esporta etichette"
        CType(Me.NumericUpDownEtPartenza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownRipetizioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownEtPartenza As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownRipetizioni As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBoxModello As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboProduttore As System.Windows.Forms.ComboBox
End Class
