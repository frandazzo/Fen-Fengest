<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSelPeriodiMensili
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
        Me.txtAf = New System.Windows.Forms.TextBox
        Me.cboMF = New System.Windows.Forms.ComboBox
        Me.txtAi = New System.Windows.Forms.TextBox
        Me.cboMI = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtAf
        '
        Me.txtAf.Location = New System.Drawing.Point(332, 3)
        Me.txtAf.Name = "txtAf"
        Me.txtAf.Size = New System.Drawing.Size(46, 20)
        Me.txtAf.TabIndex = 15
        '
        'cboMF
        '
        Me.cboMF.FormattingEnabled = True
        Me.cboMF.Items.AddRange(New Object() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"})
        Me.cboMF.Location = New System.Drawing.Point(236, 2)
        Me.cboMF.Name = "cboMF"
        Me.cboMF.Size = New System.Drawing.Size(85, 21)
        Me.cboMF.TabIndex = 14
        '
        'txtAi
        '
        Me.txtAi.Location = New System.Drawing.Point(129, 3)
        Me.txtAi.Name = "txtAi"
        Me.txtAi.Size = New System.Drawing.Size(47, 20)
        Me.txtAi.TabIndex = 13
        '
        'cboMI
        '
        Me.cboMI.FormattingEnabled = True
        Me.cboMI.Items.AddRange(New Object() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"})
        Me.cboMI.Location = New System.Drawing.Point(38, 3)
        Me.cboMI.Name = "cboMI"
        Me.cboMI.Size = New System.Drawing.Size(85, 21)
        Me.cboMI.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Da"
        '
        'ControlSelPeriodiMensili
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtAf)
        Me.Controls.Add(Me.cboMF)
        Me.Controls.Add(Me.txtAi)
        Me.Controls.Add(Me.cboMI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ControlSelPeriodiMensili"
        Me.Size = New System.Drawing.Size(383, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents txtAf As System.Windows.Forms.TextBox
   Friend WithEvents cboMF As System.Windows.Forms.ComboBox
   Friend WithEvents txtAi As System.Windows.Forms.TextBox
   Friend WithEvents cboMI As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
