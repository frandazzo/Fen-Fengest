<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelegheActions
    Inherits System.Windows.Forms.Form

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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Inoltro = New WIN.GUI.UTILITY.NiceGroupBox
        Me.dtpInoltro = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Revoca = New WIN.GUI.UTILITY.NiceGroupBox
        Me.cboCausali = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpDatarevoca = New System.Windows.Forms.DateTimePicker
        Me.lblRevoca = New System.Windows.Forms.Label
        Me.Accettazione = New WIN.GUI.UTILITY.NiceGroupBox
        Me.dtpAccettazione = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Inoltro.SuspendLayout()
        Me.Revoca.SuspendLayout()
        Me.Accettazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(116, 117)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(189, 117)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annulla"
        '
        'Inoltro
        '
        Me.Inoltro.Controls.Add(Me.dtpInoltro)
        Me.Inoltro.Controls.Add(Me.Label1)
        Me.Inoltro.Location = New System.Drawing.Point(11, 12)
        Me.Inoltro.Name = "Inoltro"
        Me.Inoltro.Size = New System.Drawing.Size(244, 66)
        Me.Inoltro.TabIndex = 1
        Me.Inoltro.Text = "Inoltro delega"
        Me.Inoltro.Title = "Inoltro"
        '
        'dtpInoltro
        '
        Me.dtpInoltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInoltro.Location = New System.Drawing.Point(104, 31)
        Me.dtpInoltro.Name = "dtpInoltro"
        Me.dtpInoltro.Size = New System.Drawing.Size(97, 20)
        Me.dtpInoltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data inoltro"
        '
        'Revoca
        '
        Me.Revoca.Controls.Add(Me.cboCausali)
        Me.Revoca.Controls.Add(Me.Label3)
        Me.Revoca.Controls.Add(Me.dtpDatarevoca)
        Me.Revoca.Controls.Add(Me.lblRevoca)
        Me.Revoca.Location = New System.Drawing.Point(11, 12)
        Me.Revoca.Name = "Revoca"
        Me.Revoca.Size = New System.Drawing.Size(244, 97)
        Me.Revoca.TabIndex = 2
        Me.Revoca.Text = "Revoca delega"
        Me.Revoca.Title = "Revoca"
        '
        'cboCausali
        '
        Me.cboCausali.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausali, "Causale di revoca della delega.Le causali possono essere impostate dal Menu Strum" & _
                "enti->Setup->Segreteria->Causali deleghe.")
        Me.cboCausali.Location = New System.Drawing.Point(73, 61)
        Me.cboCausali.Name = "cboCausali"
        Me.HelpProvider1.SetShowHelp(Me.cboCausali, True)
        Me.cboCausali.Size = New System.Drawing.Size(158, 21)
        Me.cboCausali.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Causale"
        '
        'dtpDatarevoca
        '
        Me.dtpDatarevoca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDatarevoca, "Data di revoca della delega. ")
        Me.dtpDatarevoca.Location = New System.Drawing.Point(73, 30)
        Me.dtpDatarevoca.Name = "dtpDatarevoca"
        Me.HelpProvider1.SetShowHelp(Me.dtpDatarevoca, True)
        Me.dtpDatarevoca.Size = New System.Drawing.Size(158, 20)
        Me.dtpDatarevoca.TabIndex = 3
        '
        'lblRevoca
        '
        Me.lblRevoca.AutoSize = True
        Me.lblRevoca.BackColor = System.Drawing.Color.Transparent
        Me.lblRevoca.Location = New System.Drawing.Point(4, 33)
        Me.lblRevoca.Name = "lblRevoca"
        Me.lblRevoca.Size = New System.Drawing.Size(66, 13)
        Me.lblRevoca.TabIndex = 2
        Me.lblRevoca.Text = "Data revoca"
        '
        'Accettazione
        '
        Me.Accettazione.Controls.Add(Me.dtpAccettazione)
        Me.Accettazione.Controls.Add(Me.Label2)
        Me.Accettazione.Location = New System.Drawing.Point(12, 12)
        Me.Accettazione.Name = "Accettazione"
        Me.Accettazione.Size = New System.Drawing.Size(243, 66)
        Me.Accettazione.TabIndex = 2
        Me.Accettazione.Text = "Accettazione"
        Me.Accettazione.Title = "Accettazione"
        '
        'dtpAccettazione
        '
        Me.dtpAccettazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAccettazione.Location = New System.Drawing.Point(112, 32)
        Me.dtpAccettazione.Name = "dtpAccettazione"
        Me.dtpAccettazione.Size = New System.Drawing.Size(93, 20)
        Me.dtpAccettazione.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Data accettazione"
        '
        'DelegheActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(267, 145)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Revoca)
        Me.Controls.Add(Me.Inoltro)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Accettazione)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DelegheActions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DelegheActions"
        Me.Inoltro.ResumeLayout(False)
        Me.Inoltro.PerformLayout()
        Me.Revoca.ResumeLayout(False)
        Me.Revoca.PerformLayout()
        Me.Accettazione.ResumeLayout(False)
        Me.Accettazione.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Inoltro As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents dtpInoltro As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Accettazione As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents dtpAccettazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Revoca As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents dtpDatarevoca As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblRevoca As System.Windows.Forms.Label
   Friend WithEvents cboCausali As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
