<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRicrcheIQV
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlRicrcheIQV))
      Me.SearcTab = New System.Windows.Forms.TabControl
      Me.TabPage2 = New System.Windows.Forms.TabPage
      Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
      Me.chkUt = New System.Windows.Forms.CheckBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.dtpDocA = New System.Windows.Forms.DateTimePicker
      Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
      Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
      Me.Label9 = New System.Windows.Forms.Label
      Me.chkReg = New System.Windows.Forms.CheckBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.chkDoc = New System.Windows.Forms.CheckBox
      Me.dtpRegA = New System.Windows.Forms.DateTimePicker
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.SearcTab.SuspendLayout()
      Me.TabPage2.SuspendLayout()
      Me.SuspendLayout()
      '
      'SearcTab
      '
      Me.SearcTab.Controls.Add(Me.TabPage2)
      Me.SearcTab.Location = New System.Drawing.Point(3, 3)
      Me.SearcTab.Name = "SearcTab"
      Me.SearcTab.SelectedIndex = 0
      Me.SearcTab.Size = New System.Drawing.Size(521, 153)
      Me.SearcTab.TabIndex = 16
      '
      'TabPage2
      '
      Me.TabPage2.Controls.Add(Me.IdUtenteTextBox1)
      Me.TabPage2.Controls.Add(Me.chkUt)
      Me.TabPage2.Controls.Add(Me.Label10)
      Me.TabPage2.Controls.Add(Me.Label11)
      Me.TabPage2.Controls.Add(Me.dtpDocA)
      Me.TabPage2.Controls.Add(Me.dtpDocDa)
      Me.TabPage2.Controls.Add(Me.dtpRegDa)
      Me.TabPage2.Controls.Add(Me.Label9)
      Me.TabPage2.Controls.Add(Me.chkReg)
      Me.TabPage2.Controls.Add(Me.Label4)
      Me.TabPage2.Controls.Add(Me.chkDoc)
      Me.TabPage2.Controls.Add(Me.dtpRegA)
      Me.TabPage2.Location = New System.Drawing.Point(4, 22)
      Me.TabPage2.Name = "TabPage2"
      Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage2.Size = New System.Drawing.Size(513, 127)
      Me.TabPage2.TabIndex = 0
      Me.TabPage2.Text = "Ricerca vertenze"
      Me.TabPage2.UseVisualStyleBackColor = True
      '
      'IdUtenteTextBox1
      '
      Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdUtenteTextBox1.DescriptionOfText = ""
      Me.IdUtenteTextBox1.DescriptionTextWidth = 150
      Me.IdUtenteTextBox1.DescriptionTextXValue = 92
      Me.IdUtenteTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Funzione che permette di cercare un utente di cui si desidera ricercare le verten" & _
              "ze")
      Me.IdUtenteTextBox1.IsDescriptionVisible = False
      Me.IdUtenteTextBox1.Location = New System.Drawing.Point(129, 10)
      Me.IdUtenteTextBox1.Mandatory = False
      Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
      Me.IdUtenteTextBox1.Size = New System.Drawing.Size(107, 27)
      Me.IdUtenteTextBox1.TabIndex = 67
      Me.IdUtenteTextBox1.TextValue = ""
      '
      'chkUt
      '
      Me.chkUt.AutoSize = True
      Me.HelpProvider1.SetHelpString(Me.chkUt, "Spuntare questa casella se si vuole realizzare un report delle vertenze di un par" & _
              "ticolare utente")
      Me.chkUt.Location = New System.Drawing.Point(18, 15)
      Me.chkUt.Name = "chkUt"
      Me.HelpProvider1.SetShowHelp(Me.chkUt, True)
      Me.chkUt.Size = New System.Drawing.Size(108, 17)
      Me.chkUt.TabIndex = 66
      Me.chkUt.Text = "Selezione  utente"
      Me.chkUt.UseVisualStyleBackColor = True
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.Location = New System.Drawing.Point(330, 88)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(13, 13)
      Me.Label10.TabIndex = 53
      Me.Label10.Text = "a"
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.Location = New System.Drawing.Point(198, 88)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(19, 13)
      Me.Label11.TabIndex = 52
      Me.Label11.Text = "da"
      '
      'dtpDocA
      '
      Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDocA.Location = New System.Drawing.Point(346, 85)
      Me.dtpDocA.Name = "dtpDocA"
      Me.dtpDocA.Size = New System.Drawing.Size(99, 20)
      Me.dtpDocA.TabIndex = 7
      '
      'dtpDocDa
      '
      Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDocDa.Location = New System.Drawing.Point(220, 85)
      Me.dtpDocDa.Name = "dtpDocDa"
      Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
      Me.dtpDocDa.TabIndex = 6
      '
      'dtpRegDa
      '
      Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpRegDa.Location = New System.Drawing.Point(220, 50)
      Me.dtpRegDa.Name = "dtpRegDa"
      Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
      Me.dtpRegDa.TabIndex = 3
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(330, 54)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(13, 13)
      Me.Label9.TabIndex = 49
      Me.Label9.Text = "a"
      '
      'chkReg
      '
      Me.chkReg.AutoSize = True
      Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
      Me.chkReg.Location = New System.Drawing.Point(18, 53)
      Me.chkReg.Name = "chkReg"
      Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
      Me.chkReg.Size = New System.Drawing.Size(141, 17)
      Me.chkReg.TabIndex = 2
      Me.chkReg.Text = "Selezione data reg. vert."
      Me.chkReg.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(198, 54)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(19, 13)
      Me.Label4.TabIndex = 48
      Me.Label4.Text = "da"
      '
      'chkDoc
      '
      Me.chkDoc.AutoSize = True
      Me.HelpProvider1.SetHelpString(Me.chkDoc, "Spuntare questa casella se si vuole realizzare il report delle vertenze la cui da" & _
              "ta documento (data in cui sono state create le vertenze) è compresa tra le date " & _
              "indicate nelle caselle ""da - a""")
      Me.chkDoc.Location = New System.Drawing.Point(18, 88)
      Me.chkDoc.Name = "chkDoc"
      Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
      Me.chkDoc.Size = New System.Drawing.Size(144, 17)
      Me.chkDoc.TabIndex = 5
      Me.chkDoc.Text = "Selezione data doc. vert."
      Me.chkDoc.UseVisualStyleBackColor = True
      '
      'dtpRegA
      '
      Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpRegA.Location = New System.Drawing.Point(346, 50)
      Me.dtpRegA.Name = "dtpRegA"
      Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
      Me.dtpRegA.TabIndex = 4
      '
      'ControlRicrcheIQV
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Transparent
      Me.Controls.Add(Me.SearcTab)
      Me.Name = "ControlRicrcheIQV"
      Me.Size = New System.Drawing.Size(552, 188)
      Me.SearcTab.ResumeLayout(False)
      Me.TabPage2.ResumeLayout(False)
      Me.TabPage2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SearcTab As System.Windows.Forms.TabControl
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents chkUt As System.Windows.Forms.CheckBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents chkReg As System.Windows.Forms.CheckBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
