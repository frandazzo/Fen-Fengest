<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTagSupplementari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTagSupplementari))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTag1 = New System.Windows.Forms.TextBox
        Me.txtTag2 = New System.Windows.Forms.TextBox
        Me.txtTag3 = New System.Windows.Forms.TextBox
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tag 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tag 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tag 3"
        '
        'txtTag1
        '
        Me.HelpProvider1.SetHelpString(Me.txtTag1, "Tag1 impostato nel modello Word della comunicazione")
        Me.txtTag1.Location = New System.Drawing.Point(47, 10)
        Me.txtTag1.Name = "txtTag1"
        Me.HelpProvider1.SetShowHelp(Me.txtTag1, True)
        Me.txtTag1.Size = New System.Drawing.Size(295, 20)
        Me.txtTag1.TabIndex = 3
        '
        'txtTag2
        '
        Me.HelpProvider1.SetHelpString(Me.txtTag2, "Tag2 impostato nel modello Word della comunicazione")
        Me.txtTag2.Location = New System.Drawing.Point(47, 36)
        Me.txtTag2.Name = "txtTag2"
        Me.HelpProvider1.SetShowHelp(Me.txtTag2, True)
        Me.txtTag2.Size = New System.Drawing.Size(295, 20)
        Me.txtTag2.TabIndex = 4
        '
        'txtTag3
        '
        Me.HelpProvider1.SetHelpString(Me.txtTag3, "Tag3 impostato nel modello Word della comunicazione")
        Me.txtTag3.Location = New System.Drawing.Point(47, 63)
        Me.txtTag3.Name = "txtTag3"
        Me.HelpProvider1.SetShowHelp(Me.txtTag3, True)
        Me.txtTag3.Size = New System.Drawing.Size(295, 20)
        Me.txtTag3.TabIndex = 5
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(258, 91)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
        Me.cmdAnnulla.TabIndex = 79
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(157, 91)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(95, 28)
        Me.cmdOk.TabIndex = 78
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmTagSupplementari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(353, 128)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtTag3)
        Me.Controls.Add(Me.txtTag2)
        Me.Controls.Add(Me.txtTag1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTagSupplementari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tag supplementari modello Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtTag1 As System.Windows.Forms.TextBox
   Friend WithEvents txtTag2 As System.Windows.Forms.TextBox
   Friend WithEvents txtTag3 As System.Windows.Forms.TextBox
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
