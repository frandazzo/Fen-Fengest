<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompetenza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompetenza))
        Me.cmdSeleziona = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.ControlloSelezioneCompetenza1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlloSelezioneCompetenza
        Me.SuspendLayout()
        '
        'cmdSeleziona
        '
        Me.cmdSeleziona.Location = New System.Drawing.Point(150, 162)
        Me.cmdSeleziona.Name = "cmdSeleziona"
        Me.cmdSeleziona.Size = New System.Drawing.Size(86, 26)
        Me.cmdSeleziona.TabIndex = 1
        Me.cmdSeleziona.Text = "Seleziona"
        Me.cmdSeleziona.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(246, 162)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(86, 26)
        Me.cmdAnnulla.TabIndex = 2
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'ControlloSelezioneCompetenza1
        '
        Me.ControlloSelezioneCompetenza1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ControlloSelezioneCompetenza1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlloSelezioneCompetenza1.Location = New System.Drawing.Point(0, 0)
        Me.ControlloSelezioneCompetenza1.Name = "ControlloSelezioneCompetenza1"
        Me.ControlloSelezioneCompetenza1.Size = New System.Drawing.Size(348, 192)
        Me.ControlloSelezioneCompetenza1.TabIndex = 0
        '
        'frmCompetenza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(348, 195)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdSeleziona)
        Me.Controls.Add(Me.ControlloSelezioneCompetenza1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompetenza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selezione competenza"
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents ControlloSelezioneCompetenza1 As WIN.GUI.APPLICATION.PRESENTATION.ControlloSelezioneCompetenza
   Friend WithEvents cmdSeleziona As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
End Class
