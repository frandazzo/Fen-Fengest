<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportaPrestazioni
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
      Me.cmdSelectPath = New System.Windows.Forms.Button
      Me.lblPath = New System.Windows.Forms.Label
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtUtente = New System.Windows.Forms.TextBox
      Me.lblUtente = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboExt = New System.Windows.Forms.ComboBox
      Me.cmdCerca = New System.Windows.Forms.Button
      Me.lblPathLog = New System.Windows.Forms.Label
      Me.cmdSelectPathLog = New System.Windows.Forms.Button
      Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
      Me.DataGridView1 = New System.Windows.Forms.DataGridView
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.NiceGroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.optSposta = New System.Windows.Forms.RadioButton
      Me.optCopia = New System.Windows.Forms.RadioButton
      Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn
      Me.File = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.Tipo = New System.Windows.Forms.DataGridViewComboBoxColumn
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.NiceGroupBox1.SuspendLayout()
      Me.NiceGroupBox2.SuspendLayout()
      Me.NiceGroupBox3.SuspendLayout()
      Me.SuspendLayout()
      '
      'cmdSelectPath
      '
      Me.cmdSelectPath.Location = New System.Drawing.Point(499, 66)
      Me.cmdSelectPath.Name = "cmdSelectPath"
      Me.cmdSelectPath.Size = New System.Drawing.Size(126, 27)
      Me.cmdSelectPath.TabIndex = 0
      Me.cmdSelectPath.Text = "Seleziona percorso"
      Me.cmdSelectPath.UseVisualStyleBackColor = True
      '
      'lblPath
      '
      Me.lblPath.AutoSize = True
      Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPath.ForeColor = System.Drawing.SystemColors.ActiveCaption
      Me.lblPath.Location = New System.Drawing.Point(29, 80)
      Me.lblPath.MaximumSize = New System.Drawing.Size(450, 0)
      Me.lblPath.Name = "lblPath"
      Me.lblPath.Size = New System.Drawing.Size(170, 13)
      Me.lblPath.TabIndex = 1
      Me.lblPath.Text = "Nessun percorso selezionato"
      '
      'cmdOk
      '
      Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmdOk.Enabled = False
      Me.cmdOk.Location = New System.Drawing.Point(480, 551)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(89, 27)
      Me.cmdOk.TabIndex = 32
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmdAnnulla.Location = New System.Drawing.Point(575, 551)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
      Me.cmdAnnulla.TabIndex = 31
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(31, 21)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(49, 13)
      Me.Label2.TabIndex = 33
      Me.Label2.Text = "Id utente"
      '
      'txtUtente
      '
      Me.txtUtente.Enabled = False
      Me.txtUtente.Location = New System.Drawing.Point(91, 13)
      Me.txtUtente.Name = "txtUtente"
      Me.txtUtente.Size = New System.Drawing.Size(87, 20)
      Me.txtUtente.TabIndex = 34
      '
      'lblUtente
      '
      Me.lblUtente.AutoSize = True
      Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblUtente.Location = New System.Drawing.Point(190, 21)
      Me.lblUtente.Name = "lblUtente"
      Me.lblUtente.Size = New System.Drawing.Size(45, 13)
      Me.lblUtente.TabIndex = 35
      Me.lblUtente.Text = "Utente"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(29, 39)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(75, 13)
      Me.Label3.TabIndex = 36
      Me.Label3.Text = "Estensione file"
      '
      'cboExt
      '
      Me.cboExt.FormattingEnabled = True
      Me.cboExt.Items.AddRange(New Object() {"pdf", "doc", "xls", "jpeg"})
      Me.cboExt.Location = New System.Drawing.Point(110, 31)
      Me.cboExt.Name = "cboExt"
      Me.cboExt.Size = New System.Drawing.Size(141, 21)
      Me.cboExt.TabIndex = 37
      '
      'cmdCerca
      '
      Me.cmdCerca.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x321
      Me.cmdCerca.Location = New System.Drawing.Point(499, 24)
      Me.cmdCerca.Name = "cmdCerca"
      Me.cmdCerca.Size = New System.Drawing.Size(126, 39)
      Me.cmdCerca.TabIndex = 38
      Me.cmdCerca.Text = "Visualizza file"
      Me.cmdCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdCerca.UseVisualStyleBackColor = True
      '
      'lblPathLog
      '
      Me.lblPathLog.AutoSize = True
      Me.lblPathLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPathLog.ForeColor = System.Drawing.SystemColors.ActiveCaption
      Me.lblPathLog.Location = New System.Drawing.Point(29, 40)
      Me.lblPathLog.MaximumSize = New System.Drawing.Size(450, 0)
      Me.lblPathLog.Name = "lblPathLog"
      Me.lblPathLog.Size = New System.Drawing.Size(170, 13)
      Me.lblPathLog.TabIndex = 40
      Me.lblPathLog.Text = "Nessun percorso selezionato"
      '
      'cmdSelectPathLog
      '
      Me.cmdSelectPathLog.Location = New System.Drawing.Point(499, 32)
      Me.cmdSelectPathLog.Name = "cmdSelectPathLog"
      Me.cmdSelectPathLog.Size = New System.Drawing.Size(126, 28)
      Me.cmdSelectPathLog.TabIndex = 39
      Me.cmdSelectPathLog.Text = "Seleziona percorso"
      Me.cmdSelectPathLog.UseVisualStyleBackColor = True
      '
      'DataGridView1
      '
      Me.DataGridView1.AllowUserToAddRows = False
      Me.DataGridView1.AllowUserToDeleteRows = False
      Me.DataGridView1.AllowUserToOrderColumns = True
      Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.File, Me.Tipo})
      Me.DataGridView1.Location = New System.Drawing.Point(19, 372)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.RowHeadersVisible = False
      Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.DataGridView1.Size = New System.Drawing.Size(642, 168)
      Me.DataGridView1.TabIndex = 41
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.Label3)
      Me.NiceGroupBox1.Controls.Add(Me.cboExt)
      Me.NiceGroupBox1.Controls.Add(Me.cmdSelectPath)
      Me.NiceGroupBox1.Controls.Add(Me.lblPath)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(19, 50)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(642, 112)
      Me.NiceGroupBox1.TabIndex = 42
      Me.NiceGroupBox1.Title = "Selezione file prestazioni"
      '
      'NiceGroupBox2
      '
      Me.NiceGroupBox2.Controls.Add(Me.cmdSelectPathLog)
      Me.NiceGroupBox2.Controls.Add(Me.lblPathLog)
      Me.NiceGroupBox2.Location = New System.Drawing.Point(19, 175)
      Me.NiceGroupBox2.Name = "NiceGroupBox2"
      Me.NiceGroupBox2.Size = New System.Drawing.Size(641, 75)
      Me.NiceGroupBox2.TabIndex = 43
      Me.NiceGroupBox2.Title = "Log elaborazione"
      '
      'NiceGroupBox3
      '
      Me.NiceGroupBox3.Controls.Add(Me.optCopia)
      Me.NiceGroupBox3.Controls.Add(Me.optSposta)
      Me.NiceGroupBox3.Controls.Add(Me.cmdCerca)
      Me.NiceGroupBox3.Location = New System.Drawing.Point(19, 266)
      Me.NiceGroupBox3.Name = "NiceGroupBox3"
      Me.NiceGroupBox3.Size = New System.Drawing.Size(641, 73)
      Me.NiceGroupBox3.TabIndex = 44
      Me.NiceGroupBox3.Title = "Opzioni di elaborazione"
      '
      'optSposta
      '
      Me.optSposta.AutoSize = True
      Me.optSposta.Checked = True
      Me.optSposta.Location = New System.Drawing.Point(18, 35)
      Me.optSposta.Name = "optSposta"
      Me.optSposta.Size = New System.Drawing.Size(145, 17)
      Me.optSposta.TabIndex = 0
      Me.optSposta.TabStop = True
      Me.optSposta.Text = "Sposta in directory utente"
      Me.optSposta.UseVisualStyleBackColor = True
      '
      'optCopia
      '
      Me.optCopia.AutoSize = True
      Me.optCopia.Location = New System.Drawing.Point(203, 35)
      Me.optCopia.Name = "optCopia"
      Me.optCopia.Size = New System.Drawing.Size(139, 17)
      Me.optCopia.TabIndex = 1
      Me.optCopia.TabStop = True
      Me.optCopia.Text = "Copia in directory utente"
      Me.optCopia.UseVisualStyleBackColor = True
      '
      'Sel
      '
      Me.Sel.FillWeight = 10.0!
      Me.Sel.HeaderText = "Seleziona"
      Me.Sel.Name = "Sel"
      Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
      Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
      '
      'File
      '
      Me.File.FillWeight = 70.0!
      Me.File.HeaderText = "File"
      Me.File.Name = "File"
      Me.File.ReadOnly = True
      '
      'Tipo
      '
      Me.Tipo.FillWeight = 20.0!
      Me.Tipo.HeaderText = "Tipo prestazione"
      Me.Tipo.Name = "Tipo"
      '
      'FrmImportaPrestazioni
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(691, 590)
      Me.Controls.Add(Me.NiceGroupBox3)
      Me.Controls.Add(Me.NiceGroupBox2)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Controls.Add(Me.DataGridView1)
      Me.Controls.Add(Me.lblUtente)
      Me.Controls.Add(Me.txtUtente)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
      Me.Name = "FrmImportaPrestazioni"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Crea prestazioni"
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.NiceGroupBox2.ResumeLayout(False)
      Me.NiceGroupBox2.PerformLayout()
      Me.NiceGroupBox3.ResumeLayout(False)
      Me.NiceGroupBox3.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmdSelectPath As System.Windows.Forms.Button
   Friend WithEvents lblPath As System.Windows.Forms.Label
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtUtente As System.Windows.Forms.TextBox
   Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboExt As System.Windows.Forms.ComboBox
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
   Friend WithEvents lblPathLog As System.Windows.Forms.Label
   Friend WithEvents cmdSelectPathLog As System.Windows.Forms.Button
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents NiceGroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents optSposta As System.Windows.Forms.RadioButton
   Friend WithEvents optCopia As System.Windows.Forms.RadioButton
   Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents File As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Tipo As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
