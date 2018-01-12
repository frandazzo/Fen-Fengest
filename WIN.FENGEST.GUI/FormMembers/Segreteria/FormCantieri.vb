Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FormCantieri
    Private m_idAz As Int32
    Private m_NomeAzienda As String
    Private controller As New ControllerCantiere

    Public Sub New(idAzienda As Int32, nomeAzienda As String)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_idAz = idAzienda
        m_NomeAzienda = nomeAzienda
        LoadData()
    End Sub

    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As Cantiere = DirectCast(GridView1.GetRow(handle), Cantiere)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub GridView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub


    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As Cantiere = DirectCast(view.GetRow(view.FocusedRowHandle), Cantiere)
            ' GotoView(colName, s)

            Dim frm As New FormCantiere(s)
            If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then

                'devo ricaricare la griglia
                LoadData()


            End If
            frm.Dispose()



        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Try
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridControl1
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub LoadData()

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = controller.GetCantieriByAzienda(m_idAz)

    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim frm As New FormCantiere(m_idAz, m_NomeAzienda)
        If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            'devo ricaricare la griglia
            LoadData()


        End If
        frm.Dispose()

    End Sub

    Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click

        Dim selectedCantiere As Cantiere = RetrieveSelected()
        If (selectedCantiere Is Nothing) Then

            MessageBox.Show("Selezionare un cantiere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        controller.DeleteCantiere(selectedCantiere)

        LoadData()


    End Sub

    Private Function RetrieveSelected() As Cantiere
        Dim s As Cantiere = DirectCast(GridView1.GetRow(GridView1.FocusedRowHandle), Cantiere)
        Return s
    End Function

End Class