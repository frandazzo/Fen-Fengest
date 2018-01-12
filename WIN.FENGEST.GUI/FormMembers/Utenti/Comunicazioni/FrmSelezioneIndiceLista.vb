Public Class FrmSelezioneIndiceLista

    Private m_index As Int32 = -1
    Private m_objectTypeName As String

    Public ReadOnly Property SelectedIndex() As Int32
        Get
            Return m_index
        End Get
    End Property

    Public Sub New(ByVal lista As IList, ByVal typeName As String)

        InitializeComponent()



        m_objectTypeName = typeName

        Me.DialogResult = Windows.Forms.DialogResult.Cancel


        LoadGrid(GenerateLista(lista))
    End Sub


    Private Function GenerateLista(ByVal lista As IList) As IList

        Dim l As New ArrayList
        Dim i As Int32 = 1
        For Each elem As Object In lista
            Dim o As New IndexedObject

            o.Index = i
            o.CurrentObject = elem

            l.Add(o)
            i = i + 1
        Next

        Return l
    End Function



    Private Sub LoadGrid(ByVal Lista As IList)

        With Me.GridLista1

            'Dim bind As New BindingSource
            'bind.DataSource = Lista
            '.DataSource = bind
            .AutoGenerateColumns = True
            .DataSource = Lista
            If Lista.Count > 0 Then

                .Columns("Index").ReadOnly = True
                .Columns("Index").Visible = True
                .Columns("Index").HeaderText = "Indice"



                .Columns("CurrentObject").ReadOnly = True
                .Columns("CurrentObject").Visible = True
                .Columns("CurrentObject").HeaderText = m_objectTypeName

            End If
            .SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            .AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        End With

    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

   
    Private Sub GridLista1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridLista1.CellDoubleClick
        If e.ColumnIndex <> -1 And e.RowIndex <> -1 Then


            m_index = GridLista1.Rows(e.RowIndex).DataBoundItem.Index

            Label1.Text = "Indice selezionato: " & m_index.ToString

        End If
    End Sub
End Class