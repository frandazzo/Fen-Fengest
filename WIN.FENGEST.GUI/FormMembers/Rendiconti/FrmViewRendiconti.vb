Imports DevExpress.XtraEditors.Repository
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmViewRendiconti
    Dim WithEvents buttonEdit As RepositoryItemButtonEdit
    Dim WithEvents buttonView As RepositoryItemButtonEdit
    Private m_tipo As RendicontoType
    Private m_viewAll As Boolean
    Private controllerRendiconto As ControllerRendiconto
    Public CurrentRendiconto As Rendiconto

    Public Sub New(tipo As RendicontoType, Optional viewAll As Boolean = True)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_tipo = tipo

        m_viewAll = viewAll

    End Sub


    Private Sub FrmViewRendiconti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If m_viewAll Then
            GridControl1.ForceInitialize()

            buttonEdit = New RepositoryItemButtonEdit()
            buttonEdit.Buttons.Item(0).Kind = ButtonPredefines.Delete
            buttonEdit.TextEditStyle = TextEditStyles.HideTextEditor


            buttonView = New RepositoryItemButtonEdit()
            buttonView.Buttons.Item(0).Kind = ButtonPredefines.OK

            buttonView.TextEditStyle = TextEditStyles.HideTextEditor



            Dim unbColumn As GridColumn = GridView1.Columns.AddField("Elimina")
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.String
            unbColumn.VisibleIndex = GridView1.Columns.Count
            unbColumn.ColumnEdit = buttonEdit

            Dim unbColumn1 As GridColumn = GridView1.Columns.AddField("Visualizza rendiconto")
            unbColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String
            unbColumn1.VisibleIndex = GridView1.Columns.Count
            unbColumn1.ColumnEdit = buttonView


        End If


        'GridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways



        controllerRendiconto = New ControllerRendiconto()
        GridControl1.DataSource = controllerRendiconto.GetAllRendiconti(m_tipo)


        'Dim rendiconto As New Rendiconto
        'rendiconto.DataCreazione = DateTime.Now
        'rendiconto.Tipo = m_tipo
        'rendiconto.Descrizione = "rendiconto di prova"
        'rendiconto.FilePath = "c://aaa.xml"

        'Dim rendiconto2 As New Rendiconto
        'rendiconto2.DataCreazione = DateTime.Now.AddDays(-10)
        'rendiconto2.Tipo = m_tipo
        'rendiconto2.Descrizione = "rendiconto di prova2"
        'rendiconto2.FilePath = "c://aaa.xml2"


        'Dim list As IBindingList = New BindingList(Of Rendiconto)
        'list.Add(rendiconto)
        'list.Add(rendiconto2)


        'GridControl1.DataSource = list

    End Sub

    Private Sub buttonEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit.ButtonClick
        'Dim ed As DevExpress.XtraEditors.ButtonEdit = DirectCast(GridView1.ActiveEditor, DevExpress.XtraEditors.ButtonEdit)
        'If (ed Is Nothing) Then
        '    Return
        'End If

        Try
            If MessageBox.Show("Sicuro di procedere alla cancellazione del rendiconto?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim rendiconto As Rendiconto = DirectCast(GridView1.GetRow(GridView1.FocusedRowHandle), Rendiconto)

                controllerRendiconto = New ControllerRendiconto()
                controllerRendiconto.DeleteRendiconto(rendiconto)

                GridView1.DeleteRow(GridView1.FocusedRowHandle)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try



    End Sub

    Private Sub buttonView_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonView.ButtonClick
        ' If MessageBox.Show("Sicuro di procedere alla visualizzazione del rendiconto?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        Try
            Dim rendiconto As Rendiconto = DirectCast(GridView1.GetRow(GridView1.FocusedRowHandle), Rendiconto)

            controllerRendiconto = New ControllerRendiconto()
            controllerRendiconto.ViewRendiconto(rendiconto)


            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

        'End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridView1.DoubleClick
        CurrentRendiconto = Nothing
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As Rendiconto = DirectCast(view.GetRow(view.FocusedRowHandle), Rendiconto)
            If m_viewAll Then 'se visualizzo tutti i pulsanti allora sono in modifica di un singolo record
                ViewRendiconti(s)
            Else
                'altrimenti devo tenere memorizzato il riferimento al rendoconto corrente che servirà a crearne uno nuovo 
                'con i saldi ripresi da questultimo
                CurrentRendiconto = s
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If


        End If
    End Sub

    Private Sub ViewRendiconti(s As Rendiconto)
        Try
            Dim frm As New FrmViewRendiconto(s)
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

End Class