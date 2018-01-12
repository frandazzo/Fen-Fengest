<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportIQA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportIQA))
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.lstActivity = New System.Windows.Forms.ListBox()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.chkUpdateAz = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAddDelega = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optIQP = New System.Windows.Forms.RadioButton()
        Me.optIQA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(12, 64)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(335, 20)
        Me.txtTask.TabIndex = 18
        '
        'lstActivity
        '
        Me.lstActivity.FormattingEnabled = True
        Me.lstActivity.Location = New System.Drawing.Point(12, 102)
        Me.lstActivity.Name = "lstActivity"
        Me.lstActivity.Size = New System.Drawing.Size(517, 186)
        Me.lstActivity.TabIndex = 17
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(423, 70)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(107, 21)
        Me.cmdFile.TabIndex = 16
        Me.cmdFile.Text = "Seleziona file"
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "File da importare"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(12, 97)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(518, 20)
        Me.txtFile.TabIndex = 14
        '
        'cmdLog
        '
        Me.cmdLog.Location = New System.Drawing.Point(422, 15)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(108, 23)
        Me.cmdLog.TabIndex = 13
        Me.cmdLog.Text = "Seleziona percorso"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Enabled = False
        Me.txtLog.Location = New System.Drawing.Point(12, 44)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(517, 20)
        Me.txtLog.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Log file"
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(363, 59)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(85, 26)
        Me.cmdImport.TabIndex = 10
        Me.cmdImport.Text = "Importa"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.Location = New System.Drawing.Point(341, 20)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(98, 17)
        Me.chkCheck.TabIndex = 20
        Me.chkCheck.Text = "Associa delega"
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkUpdate)
        Me.GroupBox1.Controls.Add(Me.lstActivity)
        Me.GroupBox1.Controls.Add(Me.chkUpdateAz)
        Me.GroupBox1.Controls.Add(Me.cmdImport)
        Me.GroupBox1.Controls.Add(Me.txtTask)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 298)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attività"
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Location = New System.Drawing.Point(15, 23)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(171, 17)
        Me.chkUpdate.TabIndex = 22
        Me.chkUpdate.TabStop = False
        Me.chkUpdate.Text = "Aggiorna dati residenziali utenti"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'chkUpdateAz
        '
        Me.chkUpdateAz.AutoSize = True
        Me.chkUpdateAz.Location = New System.Drawing.Point(234, 23)
        Me.chkUpdateAz.Name = "chkUpdateAz"
        Me.chkUpdateAz.Size = New System.Drawing.Size(211, 17)
        Me.chkUpdateAz.TabIndex = 21
        Me.chkUpdateAz.Text = "Aggiorna anagrafiche aziende  esistenti"
        Me.chkUpdateAz.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAddDelega)
        Me.GroupBox2.Controls.Add(Me.chkCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 52)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condizioni"
        '
        'chkAddDelega
        '
        Me.chkAddDelega.AutoSize = True
        Me.chkAddDelega.Location = New System.Drawing.Point(18, 20)
        Me.chkAddDelega.Name = "chkAddDelega"
        Me.chkAddDelega.Size = New System.Drawing.Size(278, 17)
        Me.chkAddDelega.TabIndex = 21
        Me.chkAddDelega.Text = "Aggiungi delega se non è possibile associare la quota"
        Me.chkAddDelega.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFile)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtLog)
        Me.GroupBox3.Controls.Add(Me.cmdFile)
        Me.GroupBox3.Controls.Add(Me.cmdLog)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 124)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "File di input e output"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optIQP)
        Me.GroupBox4.Controls.Add(Me.optIQA)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(551, 52)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Documento da creare"
        '
        'optIQP
        '
        Me.optIQP.AutoSize = True
        Me.optIQP.Location = New System.Drawing.Point(278, 22)
        Me.optIQP.Name = "optIQP"
        Me.optIQP.Size = New System.Drawing.Size(143, 17)
        Me.optIQP.TabIndex = 1
        Me.optIQP.Text = "Incassi quote previsionali"
        Me.optIQP.UseVisualStyleBackColor = True
        '
        'optIQA
        '
        Me.optIQA.AutoSize = True
        Me.optIQA.Checked = True
        Me.optIQA.Location = New System.Drawing.Point(18, 22)
        Me.optIQA.Name = "optIQA"
        Me.optIQA.Size = New System.Drawing.Size(144, 17)
        Me.optIQA.TabIndex = 0
        Me.optIQA.TabStop = True
        Me.optIQA.Text = "Incassi quote associative"
        Me.optIQA.UseVisualStyleBackColor = True
        '
        'FrmImportIQA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 575)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportIQA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importazione quota associativa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents txtTask As System.Windows.Forms.TextBox
   Friend WithEvents lstActivity As System.Windows.Forms.ListBox
   Friend WithEvents cmdFile As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtFile As System.Windows.Forms.TextBox
   Friend WithEvents cmdLog As System.Windows.Forms.Button
   Friend WithEvents txtLog As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmdImport As System.Windows.Forms.Button
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents chkCheck As System.Windows.Forms.CheckBox
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optIQP As System.Windows.Forms.RadioButton
    Friend WithEvents optIQA As System.Windows.Forms.RadioButton
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdateAz As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddDelega As System.Windows.Forms.CheckBox
End Class
