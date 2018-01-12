<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlloselezioneDataRange
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.dtpI = New System.Windows.Forms.DateTimePicker
        Me.dtpF = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtpI
        '
        Me.dtpI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpI.Location = New System.Drawing.Point(59, 18)
        Me.dtpI.Name = "dtpI"
        Me.dtpI.Size = New System.Drawing.Size(118, 20)
        Me.dtpI.TabIndex = 0
        '
        'dtpF
        '
        Me.dtpF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpF.Location = New System.Drawing.Point(59, 48)
        Me.dtpF.Name = "dtpF"
        Me.dtpF.Size = New System.Drawing.Size(118, 20)
        Me.dtpF.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Da"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "A"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(38, 91)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(56, 27)
        Me.CmdOk.TabIndex = 4
        Me.CmdOk.Text = "Ok"
        Me.CmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(100, 91)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(63, 27)
        Me.cmdAnnulla.TabIndex = 5
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'ControlloselezioneDataRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpF)
        Me.Controls.Add(Me.dtpI)
        Me.Name = "ControlloselezioneDataRange"
        Me.Size = New System.Drawing.Size(202, 134)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents dtpI As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpF As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents CmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button

End Class
