
Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports WIN.APPLICATION.REPORTING
Imports System.Reflection
Imports System.IO

Public Class ReportIncarichi
    Private controller As REPORTING.ReportIncarichi

    Private m_Lista As IList

    Private fileLayout As String = ""
    Private Sub RestoreReportLayoutPath()
        fileLayout = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "")

        Dim f As FileInfo = New FileInfo(fileLayout)


        fileLayout = f.DirectoryName

        fileLayout += "\\LayoutSavings\\reportIncarichi.xml"

        Dim d As DirectoryInfo = New DirectoryInfo(f.DirectoryName + "\\LayoutSavings")
        If Not d.Exists Then
            Try
                Directory.CreateDirectory(f.DirectoryName + "\\LayoutSavings")
            Catch ex As Exception
                'se cè qualche problema soprassiedo
            End Try


        End If

        'verifico la presenza del file
        f = New FileInfo(fileLayout)

        Try

            If (f.Exists) Then
                GridPosizioni.ForceInitialize()
                'Restore the previously saved layout
                GridPosizioni.MainView.RestoreLayoutFromXml(fileLayout)
            End If




        Catch ex As Exception
            'non fa nulla
        End Try
    End Sub
    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, REPORTING.ReportIncarichi)
        Me.IdShowedObject = 0
        DoLoad()
        RestoreReportLayoutPath()
    End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report incarichi"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report incarichi"
        Me.lblCurrentFunction.Text = UCase("Report incarichi")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report incarichi"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub

    Protected Overrides Sub Nested_PrepareLoading()
        m_Lista = controller.SearchResult

        GridPosizioni.DataSource = m_Lista


        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")



        lblTipo.Text = controller.NomeTipoIncarico



        lblAzienda.Text = controller.NomeAzienda
    End Sub





    Private Sub cmdPrint_DoClik(Sender As System.Object, e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridPosizioni
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdListaLavoro_DoClik(Sender As System.Object, e As System.EventArgs) Handles cmdListaLavoro.DoClik



        Try


            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.CreateNew()
                controllerListe.Descrizione = descr

                For Each elem As IncaricoDTO In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.IdUtente)
                Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As IncaricoDTO = DirectCast(GridView1.GetRow(handle), IncaricoDTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub GridView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub


    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As IncaricoDTO = DirectCast(view.GetRow(view.FocusedRowHandle), IncaricoDTO)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal IncaricoDTO As IncaricoDTO)
        Select Case colName
            Case "colIdUtente", "colCognome", "colNome"
                Navigate(IncaricoDTO.IdUtente, "ViewUtente")
            Case "colIdAzienda", "colAzienda"
                If Not String.IsNullOrEmpty(IncaricoDTO.IdAzienda) Then
                    Navigate(IncaricoDTO.IdAzienda, "ViewAzienda")
                End If
        End Select
    End Sub



    Private Sub SpecialButton1_DoClik(Sender As System.Object, e As System.EventArgs) Handles SpecialButton1.DoClik
        Try
            Dim l As New ArrayList
            For Each elem As IncaricoDTO In GetVisuibleRecords()
                l.Add(elem)
            Next

            Dim frm As New FrmStampaPermessi(l)
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub GridView1_HideCustomizationForm(sender As System.Object, e As System.EventArgs) Handles GridView1.HideCustomizationForm
        Try
            GridPosizioni.MainView.SaveLayoutToXml(fileLayout)
        Catch ex As Exception

        End Try
    End Sub
End Class
