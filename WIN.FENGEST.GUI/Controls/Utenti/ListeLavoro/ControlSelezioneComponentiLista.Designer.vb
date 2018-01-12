<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSelezioneComponentiLista
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstComponenti = New System.Windows.Forms.ListBox
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.cmdRemove = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selezione componenti lista"
        '
        'lstComponenti
        '
        Me.lstComponenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstComponenti.FormattingEnabled = True
        Me.lstComponenti.Location = New System.Drawing.Point(21, 27)
        Me.lstComponenti.Name = "lstComponenti"
        Me.lstComponenti.Size = New System.Drawing.Size(288, 121)
        Me.lstComponenti.TabIndex = 1
        '
        'CmdAdd
        '
        Me.CmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAdd.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.db_add
        Me.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd.Location = New System.Drawing.Point(21, 155)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(138, 109)
        Me.CmdAdd.TabIndex = 2
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.db_remove
        Me.cmdRemove.Location = New System.Drawing.Point(171, 155)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(138, 109)
        Me.cmdRemove.TabIndex = 3
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'ControlSelezioneComponentiLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.lstComponenti)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ControlSelezioneComponentiLista"
        Me.Size = New System.Drawing.Size(324, 275)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstComponenti As System.Windows.Forms.ListBox
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button

End Class
