<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCausaliRevoca
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCausaliRevoca))
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtDescr = New System.Windows.Forms.TextBox
      Me.Button19 = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.SpecialButton1 = New System.Windows.Forms.Button
      Me.SpecialButton2 = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(12, 13)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(62, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Descrizione"
      Me.Label1.UseWaitCursor = True
      '
      'txtDescr
      '
      Me.txtDescr.Location = New System.Drawing.Point(80, 13)
      Me.txtDescr.Multiline = True
      Me.txtDescr.Name = "txtDescr"
      Me.txtDescr.Size = New System.Drawing.Size(225, 99)
      Me.txtDescr.TabIndex = 3
      '
      'Button19
      '
      Me.Button19.ApplyOutLookStile = True
      Me.Button19.BackColor = System.Drawing.Color.Transparent
      Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.Button19.BackImage = Nothing
      Me.Button19.Disabled = False
      Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button19.ForeColor = System.Drawing.Color.Transparent
      Me.Button19.Location = New System.Drawing.Point(340, 8)
      Me.Button19.Name = "Button19"
      Me.Button19.Radius = 54.0!
      Me.Button19.ShowTooltip = True
      Me.Button19.Size = New System.Drawing.Size(54, 54)
      Me.Button19.TabIndex = 4
      Me.Button19.TextValue = ""
      Me.Button19.TooltipText = "Salva"
      '
      'SpecialButton1
      '
      Me.SpecialButton1.Location = New System.Drawing.Point(79, 119)
      Me.SpecialButton1.Name = "SpecialButton1"
      Me.SpecialButton1.Size = New System.Drawing.Size(106, 23)
      Me.SpecialButton1.TabIndex = 6
      Me.SpecialButton1.Text = "Salva"
      Me.SpecialButton1.UseVisualStyleBackColor = True
      '
      'SpecialButton2
      '
      Me.SpecialButton2.Location = New System.Drawing.Point(193, 119)
      Me.SpecialButton2.Name = "SpecialButton2"
      Me.SpecialButton2.Size = New System.Drawing.Size(113, 23)
      Me.SpecialButton2.TabIndex = 7
      Me.SpecialButton2.Text = "Annulla"
      Me.SpecialButton2.UseVisualStyleBackColor = True
      '
      'FrmCausaliRevoca
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(318, 152)
      Me.Controls.Add(Me.SpecialButton2)
      Me.Controls.Add(Me.SpecialButton1)
      Me.Controls.Add(Me.Button19)
      Me.Controls.Add(Me.txtDescr)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmCausaliRevoca"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Causali "
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents Button19 As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpecialButton1 As System.Windows.Forms.Button
    Friend WithEvents SpecialButton2 As System.Windows.Forms.Button
End Class
