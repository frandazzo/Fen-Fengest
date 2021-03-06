﻿Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Public Class ReportComunicazioni
    Private controller As WIN.APPLICATION.ReportComunicazioni


    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        controller = DirectCast(ReportingService, WIN.APPLICATION.ReportComunicazioni)
        Me.IdShowedObject = 0
        DoLoad()

    End Sub





    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report Comunicazioni"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report Comunicazioni"
        Me.lblCurrentFunction.Text = UCase("Report  Comunicazioni")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report Comunicazioni"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()


        GridPosizioni.DataSource = controller.Result





    End Sub


    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

    End Sub




    Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            'Dim print As PrintFacade = New PrintFacade()
            'print.PrintReportPrestazioni(controller.Results)
            'GridPosizioni.ShowPrintPreview()
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridPosizioni
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
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
                Dim a As Comunicazione = DirectCast(GridView1.GetRow(handle), Comunicazione)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub cmdListaLavoro_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdListaLavoro.DoClik
        Try


            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.CreateNew()
                controllerListe.Descrizione = descr

                For Each elem As Comunicazione In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.Utente.Id)
                Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub




    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As Comunicazione = DirectCast(view.GetRow(view.FocusedRowHandle), Comunicazione)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal Comunicazione As Comunicazione)
        Select Case colName

            Case "colNomeTipoComunicazione"
                NavigateTo("ViewTipoComunicazione")
            Case "colId"
                Navigate(Comunicazione.Id, "ViewComunicazione")
            Case "colNomeUtente"
                Navigate(Comunicazione.Utente.Id, "ViewUtente")
            Case "colNomeCausale"
                NavigateTo("ViewCausale")

        End Select
    End Sub
End Class
