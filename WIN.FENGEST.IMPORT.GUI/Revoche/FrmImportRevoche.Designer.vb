<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportRevoche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportRevoche))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAddDelega = New System.Windows.Forms.CheckBox()
        Me.chkRavokeAll = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.lstActivity = New System.Windows.Forms.ListBox()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File di input/output"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Log file"
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
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(13, 111)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(517, 23)
        Me.txtFile.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAddDelega)
        Me.GroupBox1.Controls.Add(Me.chkRavokeAll)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 52)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condizioni"
        '
        'chkAddDelega
        '
        Me.chkAddDelega.AutoSize = True
        Me.chkAddDelega.Location = New System.Drawing.Point(291, 19)
        Me.chkAddDelega.Name = "chkAddDelega"
        Me.chkAddDelega.Size = New System.Drawing.Size(167, 17)
        Me.chkAddDelega.TabIndex = 21
        Me.chkAddDelega.Text = "Aggiungi delega se non esiste"
        Me.chkAddDelega.UseVisualStyleBackColor = True
        '
        'chkRavokeAll
        '
        Me.chkRavokeAll.AutoSize = True
        Me.chkRavokeAll.Location = New System.Drawing.Point(15, 19)
        Me.chkRavokeAll.Name = "chkRavokeAll"
        Me.chkRavokeAll.Size = New System.Drawing.Size(247, 17)
        Me.chkRavokeAll.TabIndex = 20
        Me.chkRavokeAll.Text = "Revoca tutte le deleghe non attive o accettate"
        Me.chkRavokeAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkUpdate)
        Me.GroupBox3.Controls.Add(Me.lstActivity)
        Me.GroupBox3.Controls.Add(Me.cmdImport)
        Me.GroupBox3.Controls.Add(Me.txtTask)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 273)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Attività"
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Location = New System.Drawing.Point(15, 23)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(201, 17)
        Me.chkUpdate.TabIndex = 22
        Me.chkUpdate.TabStop = False
        Me.chkUpdate.Text = "Aggiorna anagrafiche utente esistenti"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'lstActivity
        '
        Me.lstActivity.FormattingEnabled = True
        Me.lstActivity.Location = New System.Drawing.Point(12, 102)
        Me.lstActivity.Name = "lstActivity"
        Me.lstActivity.Size = New System.Drawing.Size(517, 160)
        Me.lstActivity.TabIndex = 17
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(363, 57)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(85, 26)
        Me.cmdImport.TabIndex = 10
        Me.cmdImport.Text = "Importa"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(12, 62)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(335, 20)
        Me.txtTask.TabIndex = 18
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmImportRevoche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 515)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportRevoche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importazione disdette edili"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents cmdLog As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAddDelega As System.Windows.Forms.CheckBox
    Friend WithEvents chkRavokeAll As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents lstActivity As System.Windows.Forms.ListBox
    Friend WithEvents cmdImport As System.Windows.Forms.Button
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
