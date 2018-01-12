Imports WIN.APPLICATION.REPORTING
Imports WIN.DOMAIN.FED_SERVICES
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraPrinting

Public Class FrmMagazzinoDeleghe
    Dim controller As New ControllerRicercheBozzaDelega
    Dim controllerBozza As New ControllerBozzaDelega

    Dim list As IBindingList = New BindingList(Of BozzaDelega)


    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        GridControl1.DataSource = list
    End Sub



    Public Sub SetSearchConditions()
        ControlSelPeriodiMensili1.CalcolaDate()
        controller.SetCompetenza(ControlSelPeriodiMensili1.MinDate, ControlSelPeriodiMensili1.MaxDate)

        controller.SetIdReferente(IdReferenteTextBox1.TextValue)

        controller.SetIdUtente(IdUtenteTextBox1.TextValue)

    End Sub


    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        Try

            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)
            System.Windows.Forms.Application.DoEvents()

            Me.SetSearchConditions()

            list = controller.SearchAsBindingList


            If list.Count > 0 Then
                GridControl1.DataSource = list
            Else
                GridControl1.DataSource = New BindingList(Of BozzaDelega)
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            End If
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        Catch ex As Exception

            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If e.Column.FieldName = "Utente" Then

            Dim app As BozzaDelega = DirectCast(GridView1.GetRow(e.RowHandle), BozzaDelega)
            If Not app Is Nothing Then
                e.DisplayText = app.Utente.CompleteName
            Else
                e.DisplayText = ""
            End If

        ElseIf e.Column.FieldName = "Referente" Then

            Dim app As BozzaDelega = DirectCast(GridView1.GetRow(e.RowHandle), BozzaDelega)
            If Not app Is Nothing Then
                If Not app.Referente Is Nothing Then
                    e.DisplayText = app.Referente.CompleteName
                Else
                    e.DisplayText = ""
                End If
            End If

        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim frm As New FrmBozzaDelega(FrmBozzaDelega.BozzaDelegaAction.Insert, Nothing)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                list.Add(frm.currentBozzaDelega)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Try
            DoDelete()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub DoDelete()
        Dim info As Object = GridView1.GetRow(GridView1.FocusedRowHandle)
        If Not info Is Nothing Then
            Dim info1 As BozzaDelega = CType(info, BozzaDelega)
            If Not info1 Is Nothing Then
                If MessageBox.Show("Sicuro di voler eliminare la bozza delega?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    EliminaBozza(info1)
                Else
                    MessageBox.Show("Selezionare una bozza delega da eliminare!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If

    End Sub



    Private Sub EliminaBozza(bozza As BozzaDelega)
        Try

            controllerBozza.LoadById(bozza.Id)
            controllerBozza.Delete()
            list.Remove(bozza)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As BozzaDelega = DirectCast(view.GetRow(view.FocusedRowHandle), BozzaDelega)

            ViewBozza(s)
        End If
    End Sub


    Private Sub ViewBozza(Bozza As BozzaDelega)
        Try
            Dim frm As New FrmBozzaDelega(FrmBozzaDelega.BozzaDelegaAction.Update, Bozza)
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        Try
            'Dim print As PrintFacade = New PrintFacade
            'print.PrintReportIscrittiDTO(controller.Results)
            'GridPosizioni.ShowPrintPreview()
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridControl1
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Try
            Dim frm As New FrmGeneraDeleghe

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If MessageBox.Show("Sta per inizialre l'importazione delle deleghe. Procedere?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                    WIN.GUI.UTILITY.Helper.ShowWaitBox("Elaborazione in corso...", My.Resources.Waiting3)
                    'a questo punto può iniziare l'importazione
                    controllerBozza.GeneraDeleghe(frm.Ente, frm.Period)
                    MessageBox.Show("Importazione terminata con successo!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try
    End Sub
End Class