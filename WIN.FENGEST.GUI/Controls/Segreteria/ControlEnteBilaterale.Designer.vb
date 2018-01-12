<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlEnteBilaterale
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
      Me.txtFax = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtMail = New System.Windows.Forms.TextBox
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtCell2 = New System.Windows.Forms.TextBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.txtCell1 = New System.Windows.Forms.TextBox
      Me.txtResp = New System.Windows.Forms.TextBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtTelUf = New System.Windows.Forms.TextBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.NiceGroupBox1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(729, 30)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Size = New System.Drawing.Size(729, 44)
      '
      'txtNome
      '
      Me.txtNome.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.txtNome, "Denominazione dell'ente bilaterale. Gli enti bilaterali sono CASSA EDILE ed EDILC" & _
              "ASSA")
      Me.txtNome.Location = New System.Drawing.Point(65, 19)
      Me.txtNome.Name = "txtNome"
      Me.HelpProvider1.SetShowHelp(Me.txtNome, True)
      Me.txtNome.Size = New System.Drawing.Size(267, 21)
      Me.txtNome.TabIndex = 0
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(28, 27)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(29, 13)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Ente"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.HelpProvider1.SetHelpString(Me.Label1, "Periodo di competenza dell'ultimo pagamento che l'ente bilaterale ha effettuato a" & _
              " favore della federazione")
      Me.Label1.Location = New System.Drawing.Point(36, 274)
      Me.Label1.Name = "Label1"
      Me.HelpProvider1.SetShowHelp(Me.Label1, True)
      Me.Label1.Size = New System.Drawing.Size(198, 13)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "La competenza dell'ultimo pagamento è:"
      '
      'lblUltimaCompetenza
      '
      Me.lblUltimaCompetenza.AutoSize = True
      Me.lblUltimaCompetenza.Location = New System.Drawing.Point(53, 298)
      Me.lblUltimaCompetenza.Name = "lblUltimaCompetenza"
      Me.lblUltimaCompetenza.Size = New System.Drawing.Size(0, 13)
      Me.lblUltimaCompetenza.TabIndex = 0
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(7, 1)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(295, 40)
      Me.CustomBar1.TabIndex = 7
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
      Me.NiceGroupBox1.Controls.Add(Me.lblUltimaCompetenza)
      Me.NiceGroupBox1.Controls.Add(Me.Label1)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 87)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(646, 330)
      Me.NiceGroupBox1.TabIndex = 0
      Me.NiceGroupBox1.Title = "Ente bilaterale"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(14, 28)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(573, 229)
      Me.TabControl1.TabIndex = 2
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.txtFax)
      Me.TabPage1.Controls.Add(Me.Label3)
      Me.TabPage1.Controls.Add(Me.txtMail)
      Me.TabPage1.Controls.Add(Me.Label19)
      Me.TabPage1.Controls.Add(Me.txtNome)
      Me.TabPage1.Controls.Add(Me.Label16)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Controls.Add(Me.txtCell2)
      Me.TabPage1.Controls.Add(Me.Label18)
      Me.TabPage1.Controls.Add(Me.Label15)
      Me.TabPage1.Controls.Add(Me.txtCell1)
      Me.TabPage1.Controls.Add(Me.txtResp)
      Me.TabPage1.Controls.Add(Me.Label14)
      Me.TabPage1.Controls.Add(Me.txtTelUf)
      Me.TabPage1.Controls.Add(Me.Label13)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(565, 203)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Dati anagrafici"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'txtFax
      '
      Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtFax, "Numero di fax su cui la federazione può contattare il responsabile.")
      Me.txtFax.Location = New System.Drawing.Point(66, 164)
      Me.txtFax.Name = "txtFax"
      Me.HelpProvider1.SetShowHelp(Me.txtFax, True)
      Me.txtFax.Size = New System.Drawing.Size(196, 20)
      Me.txtFax.TabIndex = 5
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(14, 69)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(46, 13)
      Me.Label3.TabIndex = 1
      Me.Label3.Text = "Contatti"
      '
      'txtMail
      '
      Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtMail, "Indirizzo di posta elettronica del responsabile con cui la federazione può intera" & _
              "gire.")
      Me.txtMail.Location = New System.Drawing.Point(312, 104)
      Me.txtMail.Name = "txtMail"
      Me.HelpProvider1.SetShowHelp(Me.txtMail, True)
      Me.txtMail.Size = New System.Drawing.Size(196, 20)
      Me.txtMail.TabIndex = 2
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(31, 167)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(24, 13)
      Me.Label19.TabIndex = 25
      Me.Label19.Text = "Fax"
      '
      'Label16
      '
      Me.Label16.AutoSize = True
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(275, 107)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(26, 13)
      Me.Label16.TabIndex = 21
      Me.Label16.Text = "Mail"
      '
      'txtCell2
      '
      Me.txtCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtCell2, "Numero di cellulare del responsabile con cui la federazione può interagire")
      Me.txtCell2.Location = New System.Drawing.Point(312, 164)
      Me.txtCell2.Name = "txtCell2"
      Me.HelpProvider1.SetShowHelp(Me.txtCell2, True)
      Me.txtCell2.Size = New System.Drawing.Size(196, 20)
      Me.txtCell2.TabIndex = 6
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(19, 109)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(35, 13)
      Me.Label18.TabIndex = 24
      Me.Label18.Text = "Resp."
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(268, 167)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(33, 13)
      Me.Label15.TabIndex = 22
      Me.Label15.Text = "Cell.2"
      '
      'txtCell1
      '
      Me.txtCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtCell1, "Numero di cellulare del responsabile con cui la federazione può interagire.")
      Me.txtCell1.Location = New System.Drawing.Point(312, 135)
      Me.txtCell1.Name = "txtCell1"
      Me.HelpProvider1.SetShowHelp(Me.txtCell1, True)
      Me.txtCell1.Size = New System.Drawing.Size(196, 20)
      Me.txtCell1.TabIndex = 4
      '
      'txtResp
      '
      Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtResp, "Responsabile dell'ente bilaterale con cui la federazione può interagire.")
      Me.txtResp.Location = New System.Drawing.Point(65, 104)
      Me.txtResp.Name = "txtResp"
      Me.HelpProvider1.SetShowHelp(Me.txtResp, True)
      Me.txtResp.Size = New System.Drawing.Size(196, 20)
      Me.txtResp.TabIndex = 1
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(268, 138)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(33, 13)
      Me.Label14.TabIndex = 26
      Me.Label14.Text = "Cell.1"
      '
      'txtTelUf
      '
      Me.txtTelUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtTelUf, "Numero di telefono del responsabile con cui la federazione può interagire")
      Me.txtTelUf.Location = New System.Drawing.Point(66, 135)
      Me.txtTelUf.Name = "txtTelUf"
      Me.HelpProvider1.SetShowHelp(Me.txtTelUf, True)
      Me.txtTelUf.Size = New System.Drawing.Size(196, 20)
      Me.txtTelUf.TabIndex = 3
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(30, 138)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(25, 13)
      Me.Label13.TabIndex = 23
      Me.Label13.Text = "Tel."
      '
      'ControlEnteBilaterale
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Name = "ControlEnteBilaterale"
      Me.Size = New System.Drawing.Size(729, 560)
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
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtMail As System.Windows.Forms.TextBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtCell2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCell1 As System.Windows.Forms.TextBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtTelUf As System.Windows.Forms.TextBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtResp As System.Windows.Forms.TextBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
