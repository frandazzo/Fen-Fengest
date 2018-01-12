<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlloSelezioneCompetenza
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
      Me.Label9 = New System.Windows.Forms.Label
      Me.FrmPS = New WIN.GUI.UTILITY.NiceGroupBox
      Me.txtA = New System.Windows.Forms.TextBox
      Me.cboM = New System.Windows.Forms.ComboBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.FrmPM = New WIN.GUI.UTILITY.NiceGroupBox
      Me.txtAf = New System.Windows.Forms.TextBox
      Me.cboMF = New System.Windows.Forms.ComboBox
      Me.txtAi = New System.Windows.Forms.TextBox
      Me.cboMI = New System.Windows.Forms.ComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.FrmID = New WIN.GUI.UTILITY.NiceGroupBox
      Me.dtpDF = New System.Windows.Forms.DateTimePicker
      Me.dtpDI = New System.Windows.Forms.DateTimePicker
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.FrmDS = New WIN.GUI.UTILITY.NiceGroupBox
      Me.dtpData = New System.Windows.Forms.DateTimePicker
      Me.Label10 = New System.Windows.Forms.Label
      Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.optDS = New System.Windows.Forms.RadioButton
      Me.optPS = New System.Windows.Forms.RadioButton
      Me.optID = New System.Windows.Forms.RadioButton
      Me.optPM = New System.Windows.Forms.RadioButton
      Me.FrmPS.SuspendLayout()
      Me.FrmPM.SuspendLayout()
      Me.FrmID.SuspendLayout()
      Me.FrmDS.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(14, 145)
      Me.Label9.MaximumSize = New System.Drawing.Size(250, 0)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(0, 13)
      Me.Label9.TabIndex = 5
      '
      'FrmPS
      '
      Me.FrmPS.Controls.Add(Me.txtA)
      Me.FrmPS.Controls.Add(Me.cboM)
      Me.FrmPS.Controls.Add(Me.Label7)
      Me.FrmPS.Controls.Add(Me.Label8)
      Me.FrmPS.Location = New System.Drawing.Point(119, 3)
      Me.FrmPS.Name = "FrmPS"
      Me.FrmPS.Size = New System.Drawing.Size(161, 94)
      Me.FrmPS.TabIndex = 2
      Me.FrmPS.Text = "Selezione periodo"
      Me.FrmPS.Title = "Data"
      '
      'txtA
      '
      Me.txtA.Location = New System.Drawing.Point(54, 47)
      Me.txtA.Name = "txtA"
      Me.txtA.Size = New System.Drawing.Size(90, 20)
      Me.txtA.TabIndex = 5
      '
      'cboM
      '
      Me.cboM.FormattingEnabled = True
      Me.cboM.Items.AddRange(New Object() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"})
      Me.cboM.Location = New System.Drawing.Point(54, 17)
      Me.cboM.Name = "cboM"
      Me.cboM.Size = New System.Drawing.Size(90, 21)
      Me.cboM.TabIndex = 4
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Location = New System.Drawing.Point(12, 54)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(32, 13)
      Me.Label7.TabIndex = 1
      Me.Label7.Text = "Anno"
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Location = New System.Drawing.Point(11, 25)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(33, 13)
      Me.Label8.TabIndex = 0
      Me.Label8.Text = "Mese"
      '
      'FrmPM
      '
      Me.FrmPM.Controls.Add(Me.txtAf)
      Me.FrmPM.Controls.Add(Me.cboMF)
      Me.FrmPM.Controls.Add(Me.txtAi)
      Me.FrmPM.Controls.Add(Me.cboMI)
      Me.FrmPM.Controls.Add(Me.Label3)
      Me.FrmPM.Controls.Add(Me.Label4)
      Me.FrmPM.Controls.Add(Me.Label2)
      Me.FrmPM.Controls.Add(Me.Label1)
      Me.FrmPM.Location = New System.Drawing.Point(118, 4)
      Me.FrmPM.Name = "FrmPM"
      Me.FrmPM.Size = New System.Drawing.Size(161, 134)
      Me.FrmPM.TabIndex = 1
      Me.FrmPM.Text = "Selezione periodi mensili"
      Me.FrmPM.Title = "Intervallo"
      '
      'txtAf
      '
      Me.txtAf.Location = New System.Drawing.Point(67, 103)
      Me.txtAf.Name = "txtAf"
      Me.txtAf.Size = New System.Drawing.Size(85, 20)
      Me.txtAf.TabIndex = 7
      '
      'cboMF
      '
      Me.cboMF.FormattingEnabled = True
      Me.cboMF.Items.AddRange(New Object() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"})
      Me.cboMF.Location = New System.Drawing.Point(67, 72)
      Me.cboMF.Name = "cboMF"
      Me.cboMF.Size = New System.Drawing.Size(85, 21)
      Me.cboMF.TabIndex = 6
      '
      'txtAi
      '
      Me.txtAi.Location = New System.Drawing.Point(67, 47)
      Me.txtAi.Name = "txtAi"
      Me.txtAi.Size = New System.Drawing.Size(85, 20)
      Me.txtAi.TabIndex = 5
      '
      'cboMI
      '
      Me.cboMI.FormattingEnabled = True
      Me.cboMI.Items.AddRange(New Object() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"})
      Me.cboMI.Location = New System.Drawing.Point(67, 17)
      Me.cboMI.Name = "cboMI"
      Me.cboMI.Size = New System.Drawing.Size(85, 21)
      Me.cboMI.TabIndex = 4
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(9, 108)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(52, 13)
      Me.Label3.TabIndex = 3
      Me.Label3.Text = "Anno fine"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Location = New System.Drawing.Point(8, 80)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(53, 13)
      Me.Label4.TabIndex = 2
      Me.Label4.Text = "Mese fine"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(3, 54)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(58, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Anno inizio"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(2, 25)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(59, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Mese inizio"
      '
      'FrmID
      '
      Me.FrmID.Controls.Add(Me.dtpDF)
      Me.FrmID.Controls.Add(Me.dtpDI)
      Me.FrmID.Controls.Add(Me.Label6)
      Me.FrmID.Controls.Add(Me.Label5)
      Me.FrmID.Location = New System.Drawing.Point(121, 7)
      Me.FrmID.Name = "FrmID"
      Me.FrmID.Size = New System.Drawing.Size(161, 83)
      Me.FrmID.TabIndex = 6
      Me.FrmID.Text = "Selezione intervallo date"
      Me.FrmID.Title = "Intervallo"
      '
      'dtpDF
      '
      Me.dtpDF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDF.Location = New System.Drawing.Point(54, 46)
      Me.dtpDF.Name = "dtpDF"
      Me.dtpDF.Size = New System.Drawing.Size(97, 20)
      Me.dtpDF.TabIndex = 3
      '
      'dtpDI
      '
      Me.dtpDI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDI.Location = New System.Drawing.Point(54, 19)
      Me.dtpDI.Name = "dtpDI"
      Me.dtpDI.Size = New System.Drawing.Size(98, 20)
      Me.dtpDI.TabIndex = 2
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Location = New System.Drawing.Point(10, 53)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(27, 13)
      Me.Label6.TabIndex = 1
      Me.Label6.Text = "Fine"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Location = New System.Drawing.Point(8, 22)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(31, 13)
      Me.Label5.TabIndex = 0
      Me.Label5.Text = "Inizio"
      '
      'FrmDS
      '
      Me.FrmDS.Controls.Add(Me.dtpData)
      Me.FrmDS.Controls.Add(Me.Label10)
      Me.FrmDS.Location = New System.Drawing.Point(119, 6)
      Me.FrmDS.Name = "FrmDS"
      Me.FrmDS.Size = New System.Drawing.Size(161, 64)
      Me.FrmDS.TabIndex = 4
      Me.FrmDS.Text = "Selezione data"
      Me.FrmDS.Title = "Data"
      '
      'dtpData
      '
      Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpData.Location = New System.Drawing.Point(67, 24)
      Me.dtpData.Name = "dtpData"
      Me.dtpData.Size = New System.Drawing.Size(88, 20)
      Me.dtpData.TabIndex = 24
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Location = New System.Drawing.Point(14, 31)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(30, 13)
      Me.Label10.TabIndex = 23
      Me.Label10.Text = "Data"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.optDS)
      Me.GroupBox1.Controls.Add(Me.optPS)
      Me.GroupBox1.Controls.Add(Me.optID)
      Me.GroupBox1.Controls.Add(Me.optPM)
      Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(106, 135)
      Me.GroupBox1.TabIndex = 0
      Me.GroupBox1.Text = "Tipo selezione"
      Me.GroupBox1.Title = "Periodi"
      '
      'optDS
      '
      Me.optDS.AutoSize = True
      Me.optDS.BackColor = System.Drawing.Color.Transparent
      Me.optDS.Location = New System.Drawing.Point(9, 103)
      Me.optDS.Name = "optDS"
      Me.optDS.Size = New System.Drawing.Size(84, 17)
      Me.optDS.TabIndex = 3
      Me.optDS.Text = "Data singola"
      Me.optDS.UseVisualStyleBackColor = False
      '
      'optPS
      '
      Me.optPS.AutoSize = True
      Me.optPS.BackColor = System.Drawing.Color.Transparent
      Me.optPS.Location = New System.Drawing.Point(9, 48)
      Me.optPS.Name = "optPS"
      Me.optPS.Size = New System.Drawing.Size(82, 17)
      Me.optPS.TabIndex = 2
      Me.optPS.Text = "Per. mensile"
      Me.optPS.UseVisualStyleBackColor = False
      '
      'optID
      '
      Me.optID.AutoSize = True
      Me.optID.BackColor = System.Drawing.Color.Transparent
      Me.optID.Location = New System.Drawing.Point(9, 76)
      Me.optID.Name = "optID"
      Me.optID.Size = New System.Drawing.Size(92, 17)
      Me.optID.TabIndex = 1
      Me.optID.Text = "Intervallo date"
      Me.optID.UseVisualStyleBackColor = False
      '
      'optPM
      '
      Me.optPM.AutoSize = True
      Me.optPM.BackColor = System.Drawing.Color.Transparent
      Me.optPM.Location = New System.Drawing.Point(9, 22)
      Me.optPM.Name = "optPM"
      Me.optPM.Size = New System.Drawing.Size(78, 17)
      Me.optPM.TabIndex = 0
      Me.optPM.Text = "Per. mensili"
      Me.optPM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.optPM.UseVisualStyleBackColor = False
      '
      'ControlloSelezioneCompetenza
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.Controls.Add(Me.FrmPS)
      Me.Controls.Add(Me.FrmPM)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.FrmID)
      Me.Controls.Add(Me.FrmDS)
      Me.Controls.Add(Me.GroupBox1)
      Me.Name = "ControlloSelezioneCompetenza"
      Me.Size = New System.Drawing.Size(288, 171)
      Me.FrmPS.ResumeLayout(False)
      Me.FrmPS.PerformLayout()
      Me.FrmPM.ResumeLayout(False)
      Me.FrmPM.PerformLayout()
      Me.FrmID.ResumeLayout(False)
      Me.FrmID.PerformLayout()
      Me.FrmDS.ResumeLayout(False)
      Me.FrmDS.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents optPM As System.Windows.Forms.RadioButton
   Friend WithEvents optDS As System.Windows.Forms.RadioButton
   Friend WithEvents optPS As System.Windows.Forms.RadioButton
   Friend WithEvents optID As System.Windows.Forms.RadioButton
    Friend WithEvents FrmPS As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents cboM As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FrmDS As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FrmID As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents dtpDF As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMI As System.Windows.Forms.ComboBox
    Friend WithEvents txtAi As System.Windows.Forms.TextBox
    Friend WithEvents cboMF As System.Windows.Forms.ComboBox
    Friend WithEvents txtAf As System.Windows.Forms.TextBox
    Friend WithEvents FrmPM As WIN.GUI.UTILITY.NiceGroupBox

End Class
