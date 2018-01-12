<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlInps
    Inherits GUI.APPLICATION.PRESENTATION.BrowserControl

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.txtNome = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.lblUltimaCompetenza = New System.Windows.Forms.Label
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.txtCell2 = New System.Windows.Forms.TextBox
      Me.Contatti = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtFax = New System.Windows.Forms.TextBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtMail = New System.Windows.Forms.TextBox
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.txtCell1 = New System.Windows.Forms.TextBox
      Me.txtResp = New System.Windows.Forms.TextBox
      Me.txtTelUf = New System.Windows.Forms.TextBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.DockPanel.SuspendLayout()
      Me.NiceGroupBox1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(707, 30)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Size = New System.Drawing.Size(707, 44)
      '
      'txtNome
      '
      Me.txtNome.Enabled = False
      Me.txtNome.Location = New System.Drawing.Point(53, 19)
      Me.txtNome.Name = "txtNome"
      Me.txtNome.Size = New System.Drawing.Size(370, 21)
      Me.txtNome.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(18, 22)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(29, 13)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Ente"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(47, 262)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(198, 13)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "La competenza dell'ultimo pagamento è:"
      '
      'lblUltimaCompetenza
      '
      Me.lblUltimaCompetenza.AutoSize = True
      Me.lblUltimaCompetenza.Location = New System.Drawing.Point(57, 286)
      Me.lblUltimaCompetenza.Name = "lblUltimaCompetenza"
      Me.lblUltimaCompetenza.Size = New System.Drawing.Size(0, 13)
      Me.lblUltimaCompetenza.TabIndex = 0
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(6, 2)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
      Me.CustomBar1.TabIndex = 6
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
      Me.NiceGroupBox1.Controls.Add(Me.lblUltimaCompetenza)
      Me.NiceGroupBox1.Controls.Add(Me.Label1)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 87)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(632, 343)
      Me.NiceGroupBox1.TabIndex = 0
      Me.NiceGroupBox1.Title = "Inps"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(23, 33)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(564, 218)
      Me.TabControl1.TabIndex = 28
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.txtCell2)
      Me.TabPage1.Controls.Add(Me.Contatti)
      Me.TabPage1.Controls.Add(Me.Label13)
      Me.TabPage1.Controls.Add(Me.txtNome)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Controls.Add(Me.txtFax)
      Me.TabPage1.Controls.Add(Me.Label15)
      Me.TabPage1.Controls.Add(Me.Label14)
      Me.TabPage1.Controls.Add(Me.txtMail)
      Me.TabPage1.Controls.Add(Me.Label16)
      Me.TabPage1.Controls.Add(Me.Label19)
      Me.TabPage1.Controls.Add(Me.txtCell1)
      Me.TabPage1.Controls.Add(Me.txtResp)
      Me.TabPage1.Controls.Add(Me.txtTelUf)
      Me.TabPage1.Controls.Add(Me.Label18)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(556, 192)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Dati anagrafici"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'txtCell2
      '
      Me.txtCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCell2.Location = New System.Drawing.Point(337, 153)
      Me.txtCell2.Name = "txtCell2"
      Me.txtCell2.Size = New System.Drawing.Size(196, 20)
      Me.txtCell2.TabIndex = 6
      '
      'Contatti
      '
      Me.Contatti.AutoSize = True
      Me.Contatti.Location = New System.Drawing.Point(17, 63)
      Me.Contatti.Name = "Contatti"
      Me.Contatti.Size = New System.Drawing.Size(46, 13)
      Me.Contatti.TabIndex = 27
      Me.Contatti.Text = "Contatti"
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(17, 126)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(25, 13)
      Me.Label13.TabIndex = 23
      Me.Label13.Text = "Tel."
      '
      'txtFax
      '
      Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFax.Location = New System.Drawing.Point(53, 153)
      Me.txtFax.Name = "txtFax"
      Me.txtFax.Size = New System.Drawing.Size(196, 20)
      Me.txtFax.TabIndex = 5
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(293, 156)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(33, 13)
      Me.Label15.TabIndex = 22
      Me.Label15.Text = "Cell.2"
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(293, 126)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(33, 13)
      Me.Label14.TabIndex = 26
      Me.Label14.Text = "Cell.1"
      '
      'txtMail
      '
      Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMail.Location = New System.Drawing.Point(337, 92)
      Me.txtMail.Name = "txtMail"
      Me.txtMail.Size = New System.Drawing.Size(196, 20)
      Me.txtMail.TabIndex = 2
      '
      'Label16
      '
      Me.Label16.AutoSize = True
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(300, 95)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(26, 13)
      Me.Label16.TabIndex = 21
      Me.Label16.Text = "Mail"
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(18, 156)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(24, 13)
      Me.Label19.TabIndex = 25
      Me.Label19.Text = "Fax"
      '
      'txtCell1
      '
      Me.txtCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCell1.Location = New System.Drawing.Point(337, 123)
      Me.txtCell1.Name = "txtCell1"
      Me.txtCell1.Size = New System.Drawing.Size(196, 20)
      Me.txtCell1.TabIndex = 4
      '
      'txtResp
      '
      Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtResp.Location = New System.Drawing.Point(53, 92)
      Me.txtResp.Name = "txtResp"
      Me.txtResp.Size = New System.Drawing.Size(196, 20)
      Me.txtResp.TabIndex = 0
      '
      'txtTelUf
      '
      Me.txtTelUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTelUf.Location = New System.Drawing.Point(53, 123)
      Me.txtTelUf.Name = "txtTelUf"
      Me.txtTelUf.Size = New System.Drawing.Size(196, 20)
      Me.txtTelUf.TabIndex = 3
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(7, 99)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(35, 13)
      Me.Label18.TabIndex = 24
      Me.Label18.Text = "Resp."
      '
      'ControlInps
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Name = "ControlInps"
      Me.Size = New System.Drawing.Size(707, 569)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblUltimaCompetenza As System.Windows.Forms.Label
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents txtFax As System.Windows.Forms.TextBox
   Friend WithEvents txtMail As System.Windows.Forms.TextBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtResp As System.Windows.Forms.TextBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtCell2 As System.Windows.Forms.TextBox
   Friend WithEvents txtTelUf As System.Windows.Forms.TextBox
   Friend WithEvents txtCell1 As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents Contatti As System.Windows.Forms.Label

End Class
