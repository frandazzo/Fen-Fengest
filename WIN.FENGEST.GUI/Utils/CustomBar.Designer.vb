<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomBar
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
      Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
      Me.CmdNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdAnnulla = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdSave = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdDelete = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdStampa = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdInformation = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.FlowLayoutPanel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'FlowLayoutPanel1
      '
      Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
      Me.FlowLayoutPanel1.Controls.Add(Me.CmdNew)
      Me.FlowLayoutPanel1.Controls.Add(Me.CmdAnnulla)
      Me.FlowLayoutPanel1.Controls.Add(Me.CmdSave)
      Me.FlowLayoutPanel1.Controls.Add(Me.CmdDelete)
      Me.FlowLayoutPanel1.Controls.Add(Me.CmdStampa)
      Me.FlowLayoutPanel1.Controls.Add(Me.CmdInformation)
      Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
      Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
      Me.FlowLayoutPanel1.Size = New System.Drawing.Size(288, 37)
      Me.FlowLayoutPanel1.TabIndex = 0
      '
      'CmdNew
      '
      Me.CmdNew.ApplyOutLookStile = True
      Me.CmdNew.BackColor = System.Drawing.Color.Transparent
      Me.CmdNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdNew.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_new_32x32
      Me.CmdNew.Disabled = False
      Me.CmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdNew.ForeColor = System.Drawing.Color.Transparent
      Me.CmdNew.Location = New System.Drawing.Point(10, 3)
      Me.CmdNew.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CmdNew.Name = "CmdNew"
      Me.CmdNew.Radius = 32.0!
      Me.CmdNew.ShowTooltip = True
      Me.CmdNew.Size = New System.Drawing.Size(32, 32)
      Me.CmdNew.TabIndex = 0
      Me.CmdNew.TextValue = ""
      Me.CmdNew.TooltipText = "Nuovo"
      '
      'CmdAnnulla
      '
      Me.CmdAnnulla.ApplyOutLookStile = True
      Me.CmdAnnulla.BackColor = System.Drawing.Color.Transparent
      Me.CmdAnnulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdAnnulla.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.undo_32x32_active
      Me.CmdAnnulla.Disabled = False
      Me.CmdAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdAnnulla.ForeColor = System.Drawing.Color.Transparent
      Me.CmdAnnulla.Location = New System.Drawing.Point(51, 3)
      Me.CmdAnnulla.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
      Me.CmdAnnulla.Name = "CmdAnnulla"
      Me.CmdAnnulla.Radius = 32.0!
      Me.CmdAnnulla.ShowTooltip = True
      Me.CmdAnnulla.Size = New System.Drawing.Size(32, 32)
      Me.CmdAnnulla.TabIndex = 1
      Me.CmdAnnulla.TextValue = ""
      Me.CmdAnnulla.TooltipText = "Annulla"
      '
      'CmdSave
      '
      Me.CmdSave.ApplyOutLookStile = True
      Me.CmdSave.BackColor = System.Drawing.Color.Transparent
      Me.CmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdSave.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.save_32x32_active
      Me.CmdSave.Disabled = False
      Me.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdSave.ForeColor = System.Drawing.Color.Transparent
      Me.CmdSave.Location = New System.Drawing.Point(96, 3)
      Me.CmdSave.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
      Me.CmdSave.Name = "CmdSave"
      Me.CmdSave.Radius = 32.0!
      Me.CmdSave.ShowTooltip = True
      Me.CmdSave.Size = New System.Drawing.Size(32, 32)
      Me.CmdSave.TabIndex = 2
      Me.CmdSave.TextValue = ""
      Me.CmdSave.TooltipText = "Salva"
      '
      'CmdDelete
      '
      Me.CmdDelete.ApplyOutLookStile = True
      Me.CmdDelete.BackColor = System.Drawing.Color.Transparent
      Me.CmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDelete.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.delete_32x32_active
      Me.CmdDelete.Disabled = False
      Me.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdDelete.ForeColor = System.Drawing.Color.Transparent
      Me.CmdDelete.Location = New System.Drawing.Point(145, 3)
      Me.CmdDelete.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
      Me.CmdDelete.Name = "CmdDelete"
      Me.CmdDelete.Radius = 32.0!
      Me.CmdDelete.ShowTooltip = True
      Me.CmdDelete.Size = New System.Drawing.Size(32, 32)
      Me.CmdDelete.TabIndex = 3
      Me.CmdDelete.TextValue = ""
      Me.CmdDelete.TooltipText = "Elimina"
      '
      'CmdStampa
      '
      Me.CmdStampa.ApplyOutLookStile = True
      Me.CmdStampa.BackColor = System.Drawing.Color.Transparent
      Me.CmdStampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdStampa.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
      Me.CmdStampa.Disabled = False
      Me.CmdStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdStampa.ForeColor = System.Drawing.Color.Transparent
      Me.CmdStampa.Location = New System.Drawing.Point(192, 3)
      Me.CmdStampa.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
      Me.CmdStampa.Name = "CmdStampa"
      Me.CmdStampa.Radius = 32.0!
      Me.CmdStampa.ShowTooltip = True
      Me.CmdStampa.Size = New System.Drawing.Size(32, 32)
      Me.CmdStampa.TabIndex = 4
      Me.CmdStampa.TextValue = ""
      Me.CmdStampa.TooltipText = "Stampa"
      '
      'CmdInformation
      '
      Me.CmdInformation.ApplyOutLookStile = True
      Me.CmdInformation.BackColor = System.Drawing.Color.Transparent
      Me.CmdInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdInformation.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.info_32x32_active
      Me.CmdInformation.Disabled = False
      Me.CmdInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdInformation.ForeColor = System.Drawing.Color.Transparent
      Me.CmdInformation.Location = New System.Drawing.Point(241, 3)
      Me.CmdInformation.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
      Me.CmdInformation.Name = "CmdInformation"
      Me.CmdInformation.Radius = 32.0!
      Me.CmdInformation.ShowTooltip = True
      Me.CmdInformation.Size = New System.Drawing.Size(32, 32)
      Me.CmdInformation.TabIndex = 5
      Me.CmdInformation.TextValue = ""
      Me.CmdInformation.TooltipText = "Informazioni"
      '
      'CustomBar
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Transparent
      Me.Controls.Add(Me.FlowLayoutPanel1)
      Me.Name = "CustomBar"
      Me.Size = New System.Drawing.Size(296, 42)
      Me.FlowLayoutPanel1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents CmdNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdAnnulla As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdSave As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdDelete As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdStampa As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdInformation As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

End Class
