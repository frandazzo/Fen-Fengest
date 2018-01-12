<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSaldoConto
   Inherits GUI.APPLICATION.PRESENTATION.BrowserControl

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
      Me.IdContoTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdContoTextBox
      Me.lblconto = New System.Windows.Forms.Label
      Me.lblNomeConto = New System.Windows.Forms.Label
        Me.box = New WIN.GUI.UTILITY.NiceGroupBox
        Me.optS = New System.Windows.Forms.RadioButton
        Me.optI = New System.Windows.Forms.RadioButton
        Me.cmdSaldo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Intervallo = New WIN.GUI.UTILITY.NiceGroupBox
      Me.DtpA = New System.Windows.Forms.DateTimePicker
      Me.Label3 = New System.Windows.Forms.Label
      Me.dtpDa = New System.Windows.Forms.DateTimePicker
      Me.Label2 = New System.Windows.Forms.Label
        Me.Singolo = New WIN.GUI.UTILITY.NiceGroupBox
        Me.dtpFino = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.box.SuspendLayout()
        Me.Intervallo.SuspendLayout()
        Me.Singolo.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdContoTextBox1
        '
        Me.IdContoTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdContoTextBox1.Location = New System.Drawing.Point(149, 17)
        Me.IdContoTextBox1.Name = "IdContoTextBox1"
        Me.IdContoTextBox1.Size = New System.Drawing.Size(167, 23)
        Me.IdContoTextBox1.TabIndex = 0
        Me.IdContoTextBox1.TextValue = ""
        '
        'lblconto
        '
        Me.lblconto.AutoSize = True
        Me.lblconto.BackColor = System.Drawing.Color.Transparent
        Me.lblconto.ForeColor = System.Drawing.Color.Black
        Me.lblconto.Location = New System.Drawing.Point(33, 27)
        Me.lblconto.Name = "lblconto"
        Me.lblconto.Size = New System.Drawing.Size(83, 13)
        Me.lblconto.TabIndex = 1
        Me.lblconto.Text = "Seleziona conto"
        '
        'lblNomeConto
        '
        Me.lblNomeConto.AutoSize = True
        Me.lblNomeConto.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeConto.ForeColor = System.Drawing.Color.White
        Me.lblNomeConto.Location = New System.Drawing.Point(328, 25)
        Me.lblNomeConto.Name = "lblNomeConto"
        Me.lblNomeConto.Size = New System.Drawing.Size(0, 13)
        Me.lblNomeConto.TabIndex = 2
        '
        'box
        '
        Me.box.BackColor = System.Drawing.Color.Transparent
        Me.box.Controls.Add(Me.optS)
        Me.box.Controls.Add(Me.optI)
        Me.box.ForeColor = System.Drawing.Color.Black
        Me.box.Location = New System.Drawing.Point(37, 57)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(342, 55)
        Me.box.TabIndex = 3
        Me.box.TabStop = False
        Me.box.Text = "Tipo richiesta"
        '
        'optS
        '
        Me.optS.AutoSize = True
        Me.optS.Location = New System.Drawing.Point(198, 19)
        Me.optS.Name = "optS"
        Me.optS.Size = New System.Drawing.Size(109, 17)
        Me.optS.TabIndex = 1
        Me.optS.Text = "Seleziona fino a .."
        Me.optS.UseVisualStyleBackColor = True
        '
        'optI
        '
        Me.optI.AutoSize = True
        Me.optI.Checked = True
        Me.optI.Location = New System.Drawing.Point(34, 19)
        Me.optI.Name = "optI"
        Me.optI.Size = New System.Drawing.Size(110, 17)
        Me.optI.TabIndex = 0
        Me.optI.TabStop = True
        Me.optI.Text = "Seleziona da .. a.."
        Me.optI.UseVisualStyleBackColor = True
        '
        'cmdSaldo
        '
        Me.cmdSaldo.Location = New System.Drawing.Point(287, 180)
        Me.cmdSaldo.Name = "cmdSaldo"
        Me.cmdSaldo.Size = New System.Drawing.Size(118, 29)
        Me.cmdSaldo.TabIndex = 4
        Me.cmdSaldo.Text = "Calcola saldo conto"
        Me.cmdSaldo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(77, 189)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(188, 20)
        Me.txtSaldo.TabIndex = 6
        '
        'Intervallo
        '
        Me.Intervallo.BackColor = System.Drawing.Color.Transparent
        Me.Intervallo.Controls.Add(Me.DtpA)
        Me.Intervallo.Controls.Add(Me.Label3)
        Me.Intervallo.Controls.Add(Me.dtpDa)
        Me.Intervallo.Controls.Add(Me.Label2)
        Me.Intervallo.ForeColor = System.Drawing.Color.Black
        Me.Intervallo.Location = New System.Drawing.Point(39, 118)
        Me.Intervallo.Name = "Intervallo"
        Me.Intervallo.Size = New System.Drawing.Size(340, 48)
        Me.Intervallo.TabIndex = 7
        Me.Intervallo.TabStop = False
        Me.Intervallo.Text = "Intervallo date"
        '
        'DtpA
        '
        Me.DtpA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpA.Location = New System.Drawing.Point(237, 18)
        Me.DtpA.Name = "DtpA"
        Me.DtpA.Size = New System.Drawing.Size(97, 20)
        Me.DtpA.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "a"
        '
        'dtpDa
        '
        Me.dtpDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDa.Location = New System.Drawing.Point(67, 18)
        Me.dtpDa.Name = "dtpDa"
        Me.dtpDa.Size = New System.Drawing.Size(97, 20)
        Me.dtpDa.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Da"
        '
        'Singolo
        '
        Me.Singolo.BackColor = System.Drawing.Color.Transparent
        Me.Singolo.Controls.Add(Me.dtpFino)
        Me.Singolo.Controls.Add(Me.Label4)
        Me.Singolo.ForeColor = System.Drawing.Color.Black
        Me.Singolo.Location = New System.Drawing.Point(37, 118)
        Me.Singolo.Name = "Singolo"
        Me.Singolo.Size = New System.Drawing.Size(340, 48)
        Me.Singolo.TabIndex = 8
        Me.Singolo.TabStop = False
        Me.Singolo.Text = "Fino a "
        '
        'dtpFino
        '
        Me.dtpFino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFino.Location = New System.Drawing.Point(66, 19)
        Me.dtpFino.Name = "dtpFino"
        Me.dtpFino.Size = New System.Drawing.Size(97, 20)
        Me.dtpFino.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fino a "
        '
        'ControlSaldoConto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.Singolo)
        Me.Controls.Add(Me.Intervallo)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSaldo)
        Me.Controls.Add(Me.box)
        Me.Controls.Add(Me.lblNomeConto)
        Me.Controls.Add(Me.lblconto)
        Me.Controls.Add(Me.IdContoTextBox1)
        Me.Name = "ControlSaldoConto"
        Me.Size = New System.Drawing.Size(432, 238)
        Me.box.ResumeLayout(False)
        Me.box.PerformLayout()
        Me.Intervallo.ResumeLayout(False)
        Me.Intervallo.PerformLayout()
        Me.Singolo.ResumeLayout(False)
        Me.Singolo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdContoTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdContoTextBox
    Friend WithEvents lblconto As System.Windows.Forms.Label
    Friend WithEvents lblNomeConto As System.Windows.Forms.Label
    Friend WithEvents box As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents optS As System.Windows.Forms.RadioButton
   Friend WithEvents optI As System.Windows.Forms.RadioButton
   Friend WithEvents cmdSaldo As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Intervallo As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents dtpDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Singolo As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents dtpFino As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
