<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformazioni
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

    Friend WithEvents OKButton As System.Windows.Forms.Button

   'Richiesto da Progettazione Windows Form
   Private components As System.ComponentModel.IContainer

   'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
   'Può essere modificata in Progettazione Windows Form.  
   'Non modificarla nell'editor del codice.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformazioni))
        Me.OKButton = New System.Windows.Forms.Button
        Me.LabelVersion1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelDBVersion = New System.Windows.Forms.Label
        Me.txtConnextionStringparameters = New System.Windows.Forms.TextBox
        Me.MaxCacheSizeLabel = New System.Windows.Forms.Label
        Me.DBTypeLabel = New System.Windows.Forms.Label
        Me.CustomPersistenceAssemblyNameLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(461, 490)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'LabelVersion1
        '
        Me.LabelVersion1.AutoSize = True
        Me.LabelVersion1.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion1.ForeColor = System.Drawing.Color.White
        Me.LabelVersion1.Location = New System.Drawing.Point(20, 242)
        Me.LabelVersion1.Name = "LabelVersion1"
        Me.LabelVersion1.Size = New System.Drawing.Size(94, 13)
        Me.LabelVersion1.TabIndex = 2
        Me.LabelVersion1.Text = "Versione software:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 449)
        Me.Label1.MaximumSize = New System.Drawing.Size(530, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'LabelDBVersion
        '
        Me.LabelDBVersion.AutoSize = True
        Me.LabelDBVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelDBVersion.ForeColor = System.Drawing.Color.White
        Me.LabelDBVersion.Location = New System.Drawing.Point(21, 267)
        Me.LabelDBVersion.Name = "LabelDBVersion"
        Me.LabelDBVersion.Size = New System.Drawing.Size(98, 13)
        Me.LabelDBVersion.TabIndex = 7
        Me.LabelDBVersion.Text = "Versionedatabase: "
        '
        'txtConnextionStringparameters
        '
        Me.txtConnextionStringparameters.BackColor = System.Drawing.Color.White
        Me.txtConnextionStringparameters.Location = New System.Drawing.Point(23, 367)
        Me.txtConnextionStringparameters.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.txtConnextionStringparameters.Multiline = True
        Me.txtConnextionStringparameters.Name = "txtConnextionStringparameters"
        Me.txtConnextionStringparameters.ReadOnly = True
        Me.txtConnextionStringparameters.Size = New System.Drawing.Size(523, 79)
        Me.txtConnextionStringparameters.TabIndex = 8
        Me.txtConnextionStringparameters.TabStop = False
        Me.txtConnextionStringparameters.Text = "Parametri connessione:"
        '
        'MaxCacheSizeLabel
        '
        Me.MaxCacheSizeLabel.AutoSize = True
        Me.MaxCacheSizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.MaxCacheSizeLabel.ForeColor = System.Drawing.Color.White
        Me.MaxCacheSizeLabel.Location = New System.Drawing.Point(21, 313)
        Me.MaxCacheSizeLabel.Name = "MaxCacheSizeLabel"
        Me.MaxCacheSizeLabel.Size = New System.Drawing.Size(58, 13)
        Me.MaxCacheSizeLabel.TabIndex = 9
        Me.MaxCacheSizeLabel.Text = "CacheSize"
        '
        'DBTypeLabel
        '
        Me.DBTypeLabel.AutoSize = True
        Me.DBTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.DBTypeLabel.ForeColor = System.Drawing.Color.White
        Me.DBTypeLabel.Location = New System.Drawing.Point(20, 291)
        Me.DBTypeLabel.Name = "DBTypeLabel"
        Me.DBTypeLabel.Size = New System.Drawing.Size(75, 13)
        Me.DBTypeLabel.TabIndex = 10
        Me.DBTypeLabel.Text = "Tipo database"
        '
        'CustomPersistenceAssemblyNameLabel
        '
        Me.CustomPersistenceAssemblyNameLabel.AutoSize = True
        Me.CustomPersistenceAssemblyNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CustomPersistenceAssemblyNameLabel.ForeColor = System.Drawing.Color.White
        Me.CustomPersistenceAssemblyNameLabel.Location = New System.Drawing.Point(24, 335)
        Me.CustomPersistenceAssemblyNameLabel.MaximumSize = New System.Drawing.Size(500, 0)
        Me.CustomPersistenceAssemblyNameLabel.Name = "CustomPersistenceAssemblyNameLabel"
        Me.CustomPersistenceAssemblyNameLabel.Size = New System.Drawing.Size(74, 17)
        Me.CustomPersistenceAssemblyNameLabel.TabIndex = 11
        Me.CustomPersistenceAssemblyNameLabel.Text = "AsseblyName"
        Me.CustomPersistenceAssemblyNameLabel.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 12)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Copyright © 2009 - 2010  NOESIS Technologies. Tutti i diritti riservati"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.lonNoesis
        Me.PictureBox1.Location = New System.Drawing.Point(335, 526)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 50)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'FrmInformazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.info1
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(562, 583)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustomPersistenceAssemblyNameLabel)
        Me.Controls.Add(Me.DBTypeLabel)
        Me.Controls.Add(Me.MaxCacheSizeLabel)
        Me.Controls.Add(Me.txtConnextionStringparameters)
        Me.Controls.Add(Me.LabelDBVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelVersion1)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformazioni"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Informazioni su FenealGest"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents LabelVersion1 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents LabelDBVersion As System.Windows.Forms.Label
   Friend WithEvents txtConnextionStringparameters As System.Windows.Forms.TextBox
   Friend WithEvents MaxCacheSizeLabel As System.Windows.Forms.Label
   Friend WithEvents DBTypeLabel As System.Windows.Forms.Label
   Friend WithEvents CustomPersistenceAssemblyNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
