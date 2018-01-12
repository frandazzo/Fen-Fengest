<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSettore
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSettore = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.lstContratti = New System.Windows.Forms.CheckedListBox
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.DockPanel.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(462, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.txtTipo)
        Me.DockPanel.Controls.Add(Me.Label2)
        Me.DockPanel.Size = New System.Drawing.Size(462, 44)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settore"
        '
        'txtSettore
        '
        Me.txtSettore.Enabled = False
        Me.txtSettore.Location = New System.Drawing.Point(87, 33)
        Me.txtSettore.Name = "txtSettore"
        Me.txtSettore.Size = New System.Drawing.Size(152, 21)
        Me.txtSettore.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo settore"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtTipo, "Settore di interesse. I due settori di pertinenza della federazione sono EDILE e " & _
                "IMPIANTI FISSI. Ad ogni settore sono associati dei contratti di lavoro.")
        Me.txtTipo.Location = New System.Drawing.Point(75, 12)
        Me.txtTipo.Name = "txtTipo"
        Me.HelpProvider1.SetShowHelp(Me.txtTipo, True)
        Me.txtTipo.Size = New System.Drawing.Size(152, 21)
        Me.txtTipo.TabIndex = 3
        '
        'lstContratti
        '
        Me.lstContratti.FormattingEnabled = True
        Me.lstContratti.Location = New System.Drawing.Point(15, 32)
        Me.lstContratti.MultiColumn = True
        Me.lstContratti.Name = "lstContratti"
        Me.lstContratti.Size = New System.Drawing.Size(413, 212)
        Me.lstContratti.TabIndex = 5
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NiceGroupBox1.Controls.Add(Me.lstContratti)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 95)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(440, 260)
        Me.NiceGroupBox1.TabIndex = 35
        Me.NiceGroupBox1.Title = "Contratti Associati"
        '
        'ControlSettore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.txtSettore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Name = "ControlSettore"
        Me.Size = New System.Drawing.Size(462, 372)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtSettore, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtSettore As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents lstContratti As System.Windows.Forms.CheckedListBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
