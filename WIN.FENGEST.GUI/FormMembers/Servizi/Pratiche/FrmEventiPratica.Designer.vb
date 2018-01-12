<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEventiPratica
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeOperatoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraticaEventBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PraticaEventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PraticaEventBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaEventBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaEventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaEventBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn, Me.StateNameDataGridViewTextBoxColumn, Me.NomeOperatoreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PraticaEventBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(487, 140)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 176)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(487, 96)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Note "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Chiudi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateNameDataGridViewTextBoxColumn
        '
        Me.StateNameDataGridViewTextBoxColumn.DataPropertyName = "StateName"
        Me.StateNameDataGridViewTextBoxColumn.HeaderText = "Stato"
        Me.StateNameDataGridViewTextBoxColumn.Name = "StateNameDataGridViewTextBoxColumn"
        Me.StateNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeOperatoreDataGridViewTextBoxColumn
        '
        Me.NomeOperatoreDataGridViewTextBoxColumn.DataPropertyName = "NomeOperatore"
        Me.NomeOperatoreDataGridViewTextBoxColumn.HeaderText = "Operatore"
        Me.NomeOperatoreDataGridViewTextBoxColumn.Name = "NomeOperatoreDataGridViewTextBoxColumn"
        Me.NomeOperatoreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PraticaEventBindingSource2
        '
        Me.PraticaEventBindingSource2.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.PraticaEvent)
        '
        'PraticaEventBindingSource
        '
        Me.PraticaEventBindingSource.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.PraticaEvent)
        '
        'PraticaEventBindingSource1
        '
        Me.PraticaEventBindingSource1.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.PraticaEvent)
        '
        'FrmEventiPratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 323)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEventiPratica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Percorso pratica"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaEventBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaEventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaEventBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PraticaEventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PraticaEventBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeOperatoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PraticaEventBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
