<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlReparti
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

    'NOTA: la procedura che segue � richiesta da Progettazione Windows Form
    'Pu� essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
        Me.lstCausali = New System.Windows.Forms.ListBox
        Me.CmdSel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.DockPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(4, 3)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 17
        '
        'lstCausali
        '
        Me.lstCausali.FormattingEnabled = True
        Me.lstCausali.Location = New System.Drawing.Point(11, 92)
        Me.lstCausali.Name = "lstCausali"
        Me.lstCausali.Size = New System.Drawing.Size(185, 160)
        Me.lstCausali.TabIndex = 15
        '
        'CmdSel
        '
        Me.CmdSel.ApplyOutLookStile = True
        Me.CmdSel.BackColor = System.Drawing.Color.Transparent
        Me.CmdSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdSel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_48x48
        Me.CmdSel.Disabled = False
        Me.CmdSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSel.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdSel, "Funzione che permette di visualizzare la descrizione del reparto selezionata. Ess" & _
                "a pu� essere modificata e poi salvata.")
        Me.CmdSel.Location = New System.Drawing.Point(202, 92)
        Me.CmdSel.Name = "CmdSel"
        Me.CmdSel.Radius = 48.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdSel, True)
        Me.CmdSel.ShowTooltip = True
        Me.CmdSel.Size = New System.Drawing.Size(48, 48)
        Me.CmdSel.TabIndex = 16
        Me.CmdSel.TextValue = ""
        Me.CmdSel.TooltipText = "Seleziona"
        '
        'ControlReparti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.CmdSel)
        Me.Controls.Add(Me.lstCausali)
        Me.Name = "ControlReparti"
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.lstCausali, 0)
        Me.Controls.SetChildIndex(Me.CmdSel, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents CmdSel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents lstCausali As System.Windows.Forms.ListBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
