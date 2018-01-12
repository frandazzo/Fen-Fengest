<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGeneraDeleghe
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
        Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ControlSelPeriodiMensili1
        '
        Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(39, 12)
        Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
        Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(383, 29)
        Me.ControlSelPeriodiMensili1.TabIndex = 1
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"CASSA EDILE", "EDILCASSA"})
        Me.cboTipo.Location = New System.Drawing.Point(76, 47)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(147, 21)
        Me.cboTipo.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Ente"
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(375, 80)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(62, 27)
        Me.cmdAnnulla.TabIndex = 69
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(299, 80)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(62, 27)
        Me.cmdOk.TabIndex = 68
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmGeneraDeleghe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 119)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ControlSelPeriodiMensili1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGeneraDeleghe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera deleghe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
End Class
