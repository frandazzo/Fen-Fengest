<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecialButton
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
      Me.components = New System.ComponentModel.Container
      Me.Button1 = New System.Windows.Forms.Button
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.ToolTipLabel = New System.Windows.Forms.Label
      Me.SuspendLayout()
      '
      'Button1
      '
      Me.Button1.BackColor = System.Drawing.Color.Transparent
      Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Button1.FlatAppearance.BorderSize = 0
      Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
      Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
      Me.Button1.ForeColor = System.Drawing.Color.Black
      Me.Button1.Location = New System.Drawing.Point(0, 0)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(166, 116)
      Me.Button1.TabIndex = 0
      Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.Button1.UseVisualStyleBackColor = False
      '
      'ToolTip1
      '
      Me.ToolTip1.ShowAlways = True
      '
      'ToolTipLabel
      '
      Me.ToolTipLabel.AutoSize = True
      Me.ToolTipLabel.Location = New System.Drawing.Point(3, 37)
      Me.ToolTipLabel.Name = "ToolTipLabel"
      Me.ToolTipLabel.Size = New System.Drawing.Size(11, 13)
      Me.ToolTipLabel.TabIndex = 1
      Me.ToolTipLabel.Text = "*"
      Me.ToolTipLabel.Visible = False
      '
      'SpecialButton
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Transparent
      Me.Controls.Add(Me.ToolTipLabel)
      Me.Controls.Add(Me.Button1)
      Me.ForeColor = System.Drawing.Color.Transparent
      Me.Name = "SpecialButton"
      Me.Size = New System.Drawing.Size(166, 119)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents ToolTipLabel As System.Windows.Forms.Label

End Class
