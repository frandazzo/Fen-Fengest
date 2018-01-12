<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportLiberi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportLiberi))
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.lstActivity = New System.Windows.Forms.ListBox()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOverWriteLib = New System.Windows.Forms.CheckBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.chkUpdateAz = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(458, 99)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(72, 24)
        Me.cmdImport.TabIndex = 0
        Me.cmdImport.Text = "Importa"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Log file"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtLog
        '
        Me.txtLog.Enabled = False
        Me.txtLog.Location = New System.Drawing.Point(13, 48)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(517, 24)
        Me.txtLog.TabIndex = 2
        '
        'cmdLog
        '
        Me.cmdLog.Location = New System.Drawing.Point(420, 19)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(110, 23)
        Me.cmdLog.TabIndex = 3
        Me.cmdLog.Text = "Seleziona percorso"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(13, 111)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(517, 23)
        Me.txtFile.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "File da importare"
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(420, 81)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(110, 24)
        Me.cmdFile.TabIndex = 6
        Me.cmdFile.Text = "Seleziona file"
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'lstActivity
        '
        Me.lstActivity.FormattingEnabled = True
        Me.lstActivity.Location = New System.Drawing.Point(17, 130)
        Me.lstActivity.Name = "lstActivity"
        Me.lstActivity.Size = New System.Drawing.Size(513, 186)
        Me.lstActivity.TabIndex = 7
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(17, 102)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(423, 20)
        Me.txtTask.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOverWriteLib)
        Me.GroupBox1.Controls.Add(Me.chkUpdate)
        Me.GroupBox1.Controls.Add(Me.chkUpdateAz)
        Me.GroupBox1.Controls.Add(Me.txtTask)
        Me.GroupBox1.Controls.Add(Me.lstActivity)
        Me.GroupBox1.Controls.Add(Me.cmdImport)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 332)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attività"
        '
        'chkOverWriteLib
        '
        Me.chkOverWriteLib.AutoSize = True
        Me.chkOverWriteLib.Location = New System.Drawing.Point(17, 67)
        Me.chkOverWriteLib.Name = "chkOverWriteLib"
        Me.chkOverWriteLib.Size = New System.Drawing.Size(184, 17)
        Me.chkOverWriteLib.TabIndex = 15
        Me.chkOverWriteLib.TabStop = False
        Me.chkOverWriteLib.Text = "Sovrascrivi record libero esistente"
        Me.chkOverWriteLib.UseVisualStyleBackColor = True
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Location = New System.Drawing.Point(17, 32)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(190, 17)
        Me.chkUpdate.TabIndex = 14
        Me.chkUpdate.TabStop = False
        Me.chkUpdate.Text = "Aggiorna residenze utente esistenti"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'chkUpdateAz
        '
        Me.chkUpdateAz.AutoSize = True
        Me.chkUpdateAz.Location = New System.Drawing.Point(236, 32)
        Me.chkUpdateAz.Name = "chkUpdateAz"
        Me.chkUpdateAz.Size = New System.Drawing.Size(211, 17)
        Me.chkUpdateAz.TabIndex = 13
        Me.chkUpdateAz.Text = "Aggiorna anagrafiche aziende  esistenti"
        Me.chkUpdateAz.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLog)
        Me.GroupBox2.Controls.Add(Me.cmdLog)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmdFile)
        Me.GroupBox2.Controls.Add(Me.txtFile)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 154)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File di input/output"
        '
        'FrmImportLiberi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportLiberi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importazione dati lavoratori liberi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdImport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents cmdLog As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Friend WithEvents lstActivity As System.Windows.Forms.ListBox
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdateAz As System.Windows.Forms.CheckBox
    Friend WithEvents chkOverWriteLib As System.Windows.Forms.CheckBox

End Class
