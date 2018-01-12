Imports System.Windows.Forms
Public Class SearchDocumenti
    Implements IFrmSearch
    Private SearchController As New FINANCIAL_ARTIFACTS.AbstractDocumentController
    Dim controllerRicerche As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerRicercheDocumenti
    Public TipoDoc As String = ""
    Private m_SelectedId As Int32 = -1
    Private m_SelectedDescription As String = ""

    Public ReadOnly Property SelectedDescription() As String Implements IFrmSearch.SelectedDescription
        Get
            Return m_SelectedDescription
        End Get
    End Property
    Public ReadOnly Property SelectedId() As Int32 Implements IFrmSearch.SelectedId
        Get
            Return m_SelectedId
        End Get
    End Property
    Public Sub New()
        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.cboTipo.SelectedIndex = 0
    End Sub

    Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.Click
        Try
            Dim lista As New ArrayList
            'lista = ApplicationController.GetDocumentController(cboTipo.Text).GetAll
            Dim map As New Hashtable
            map.Add("IntervalloDocumento", Me.chkDoc.Checked)
            map.Add("IntervalloRegistrazione", Me.chkReg.Checked)
            controllerRicerche.SetNewSerchConditions(map)
            controllerRicerche.SetDataDocumentoRange(Me.dtpDocDa.Value.Date, Me.dtpDocA.Value.Date)
            controllerRicerche.SetDataRegistrazioneRange(Me.dtpRegDa.Value.Date, Me.dtpRegA.Value.Date)
            controllerRicerche.SetTipoDocumento(Me.cboTipo.Text.Substring(0, 3))
            controllerRicerche.SetMaxNumberOfReturnedRecords(My.Settings.MaxReturnedRecordNumber)
            lista = controllerRicerche.Search
            If lista.Count = 0 Then
                MsgBox("Non è stato trovato alcun elemento che soddisfa i requisiti richiesti!", MsgBoxStyle.Information, "Nessun elemento trovato")
                'Exit Sub
            End If
            LoadGrid(lista)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub LoadGrid(ByVal Lista As ArrayList)
        Try
            With GridPagamenti
                .Columns.Clear()
                .DataSource = Nothing

                .DataSource = Lista

                If Lista.Count > 0 Then


                    .Columns("Key").Visible = False
                    .Columns("Versione").Visible = False
                    .Columns("CreatoDa").Visible = False
                    .Columns("ModificatoDa").Visible = False
                    .Columns("DataCreazione").Visible = False
                    .Columns("DataModifica").Visible = False
                    .Columns("Descrizione").Visible = False
                    .Columns("IsPosted").Visible = False
                    .Columns("Id").Visible = False
                    .Columns("DataRegistrazione").Visible = False


                    .Columns("DataDocumento").Visible = True
                    .Columns("DataDocumento").HeaderText = "Data documento"
                    .Columns("DataDocumento").ReadOnly = True
                    .Columns("DataDocumento").DisplayIndex = 0

                    .Columns("TipoDocumento").Visible = False
                    .Columns("NonCancellabile").Visible = False



                    If cboTipo.Text.StartsWith("IQA") Then
                        If Not .Columns("Settore") Is Nothing Then

                            .Columns("Settore").Visible = True
                            .Columns("Settore").ReadOnly = True
                            .Columns("Settore").DisplayIndex = 1

                        End If

                    Else
                        If Not .Columns("Note") Is Nothing Then
                            .Columns("Note").Visible = True
                            .Columns("Note").ReadOnly = True
                            .Columns("Note").DisplayIndex = 1

                        End If
                    End If


                    If .Columns.Contains("SoggettoEsecutore") Then
                        .Columns("SoggettoEsecutore").Visible = True
                        .Columns("SoggettoEsecutore").ReadOnly = True
                        .Columns("SoggettoEsecutore").DisplayIndex = 2
                    End If
                    If .Columns.Contains("Competenza") Then
                        .Columns("Competenza").Visible = True
                        .Columns("Competenza").ReadOnly = True
                        .Columns("Competenza").DisplayIndex = 3
                    End If
                    If .Columns.Contains("CompetenzaUltimoIncasso") Then
                        .Columns("CompetenzaUltimoIncasso").Visible = False
                    End If



                    If .Columns.Contains("Importo") Then
                        .Columns("Importo").Visible = True
                        .Columns("Importo").ReadOnly = True
                        .Columns("Importo").DisplayIndex = 4
                    End If
                    If .Columns.Contains("Valuta") Then
                        .Columns("Valuta").Visible = True
                        .Columns("Valuta").ReadOnly = True
                        .Columns("Valuta").DisplayIndex = 5
                    End If
                    If .Columns.Contains("Referente") Then
                        .Columns("Referente").Visible = True
                        .Columns("Referente").ReadOnly = True
                        .Columns("Referente").DisplayIndex = 6
                    End If

                    If .Columns.Contains("Utente") Then
                        .Columns("Utente").Visible = True
                        .Columns("Utente").ReadOnly = True
                        .Columns("Utente").DisplayIndex = 7
                    End If
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                End If

            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la lista dei documenti selezionati" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub GridPagamenti_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPagamenti.CellFormatting



        If GridPagamenti.Columns(e.ColumnIndex).Name.Equals("SoggettoEsecutore") Then

            'If GridPagamenti.Rows(e.RowIndex).DataBoundItem.TipoDocumento = "IQV" Then

            '    e.Value = GridPagamenti.Rows(e.RowIndex).DataBoundItem.Utente.ToString



            'Else
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Descrizione
            End If
            'End If


        End If

        If GridPagamenti.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.CompleteName
            End If
        End If


        If GridPagamenti.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.CompleteName
            End If
        End If

        If GridPagamenti.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If
        If GridPagamenti.Columns(e.ColumnIndex).Name.Equals("Settore") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Descrizione
            End If
        End If


    End Sub
    Private Sub GridPagamenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridPagamenti.MouseDoubleClick

        Seleziona()

    End Sub


    Private Sub Seleziona()
        If GridPagamenti.SelectedRows.Count = 1 Then
            m_SelectedId = DirectCast(GridPagamenti.SelectedRows.Item(0).Cells("Id").Value, Int32)
            TipoDoc = cboTipo.Text.Substring(0, 3)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Selezionare un documento!")
        End If
    End Sub

    Private Sub chkReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReg.CheckedChanged
        If chkReg.Checked Then
            dtpRegDa.Enabled = True
            dtpRegA.Enabled = True
        Else
            dtpRegDa.Enabled = False
            dtpRegA.Enabled = False
        End If
    End Sub

    Private Sub chkDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
        If chkDoc.Checked Then
            dtpDocDa.Enabled = True
            dtpDocA.Enabled = True
        Else
            dtpDocDa.Enabled = False
            dtpDocA.Enabled = False
        End If
    End Sub


End Class