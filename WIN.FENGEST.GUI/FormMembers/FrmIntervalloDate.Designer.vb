<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntervalloDate
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
        Me.ControlloselezioneDataRange1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlloselezioneDataRange
        Me.SuspendLayout()
        '
        'ControlloselezioneDataRange1
        '
        Me.ControlloselezioneDataRange1.Location = New System.Drawing.Point(2, 2)
        Me.ControlloselezioneDataRange1.Name = "ControlloselezioneDataRange1"
        Me.ControlloselezioneDataRange1.Size = New System.Drawing.Size(192, 125)
        Me.ControlloselezioneDataRange1.TabIndex = 0
        '
        'FrmIntervalloDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(197, 129)
        Me.Controls.Add(Me.ControlloselezioneDataRange1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIntervalloDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleziona intervallo date"
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents ControlloselezioneDataRange1 As WIN.GUI.APPLICATION.PRESENTATION.ControlloselezioneDataRange
End Class
