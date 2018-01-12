Public Class FrmEventiPratica
    Private m_lista As IList
    Public Sub New(listaEventi As IList)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_lista = listaEventi
        DataGridView1.DataSource = m_lista

        If m_lista.Count > 0 Then
            TextBox1.Text = DirectCast(DataGridView1.Rows(0).DataBoundItem, PraticaEvent).Notes
            DataGridView1.Rows(0).Selected = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
     
        'System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
        '    Return
        'End If

        'TextBox1.Text = DirectCast(DataGridView1.Rows(e.RowIndex).DataBoundItem, PraticaEvent).Notes
    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        TextBox1.Text = DirectCast(DataGridView1.Rows(e.RowIndex).DataBoundItem, PraticaEvent).Notes
    End Sub
End Class