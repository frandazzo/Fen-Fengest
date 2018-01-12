
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports WIN.SECURITY.Exceptions
Imports WIN.APPLICATION.REPORTING

Public Class ControlVisualizzatoreDeleghe
    Private controller As New UTENTI.ControllerUtenti
    Public Sub New()
        InitializeComponent()

        DoLoad()

    End Sub

    Public Sub New(ByVal IdUtente As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdUtente

        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  deleghe utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  deleghe utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " deleghe utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  deleghe utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  deleghe  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  deleghe utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "deleghe  -  " & UCase(controller.CompleteName))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        Me.NiceGroupBox1.Visible = False
        Me.TabControl1.Visible = False
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Visible = True
        Me.IdUtenteTextBox1.Enabled = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca deleghe utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca deleghe utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        ' Me.CmdVis.Visible = True
        Me.cmdPrint.Visible = False
        Me.lblCurrentFunction.Text = UCase("Ricerca   deleghe   utente ")
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.NiceGroupBox1.Visible = True
        Me.TabControl1.Visible = True
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()
        ' Me.CmdVis.Visible = False
        Me.cmdPrint.Visible = True
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()

        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        lblDescrizioneUtente.Text = controller.CompleteName
        Dim listaDeleghe As IList = controller.ElencoDeleghe

        Dim cc As New ControllerRicercheBozzaDelega

        Dim listaDelegheMagazzino As IList
        cc.SetCompetenza(New DateTime(1990, 1, 1), New DateTime(2050, 1, 1))
        cc.SetIdUtente(Me.IdShowedObject)
        listaDelegheMagazzino = cc.Search()


        LoadGrid(listaDeleghe)
        LoadGridMagazzino(listaDelegheMagazzino)

    End Sub
    Private Sub PerformDialog()
        Select Case MsgBox("Non esistono deleghe di adesione per l'utente selezionato. Si desidera creare una nuova delega? " & vbCrLf & _
                                   "Scegliere Sì per sottoscrivere una nuova delga;" & vbCrLf & _
                                   "Scegliere No per visualizzare l'anagrafica dell'utente selezionato;" & vbCrLf & _
                                   "Segliere Annulla per riprovare una nuova ricerca.", _
                                   MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, _
                                   "Visualizzazione deleghe")
            Case MsgBoxResult.Cancel
                Me.NavigateWithoutHistoryTo("ViewDeleghe", True)
            Case MsgBoxResult.Yes
                Me.NavigateWithoutHistoryTo("CreateDelega", True)
            Case MsgBoxResult.No
                Me.Navigate(m_IdShowedObject, "ViewUtente")
        End Select
    End Sub


    Private Sub GridDeleghe_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridDeleghe.CellFormatting
        Try
            If GridDeleghe.Columns(e.ColumnIndex).Name.Equals("StatoDelega") Then
                If Not e.Value Is Nothing Then
                    'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                    e.Value = e.Value.StatusName
                End If
            End If
            If GridDeleghe.Columns(e.ColumnIndex).Name.Equals("Settore") Then
                If Not e.Value Is Nothing Then
                    'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                    e.Value = e.Value.Descrizione
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub GridDeleghe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDeleghe.DoubleClick
        Try
            If GridDeleghe.SelectedRows.Count = 1 Then
                Dim SelectedId As Int32 = DirectCast(GridDeleghe.SelectedRows.Item(0).Cells("IdDelega").Value, Int32)
                Dim StatusDelega As String = GridDeleghe.SelectedRows.Item(0).Cells("StatoDelega").Value.StatusName
                Me.Navigate(SelectedId, StatusDelega, "ViewDelega")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With GridDeleghe

                .DataSource = Lista
                If Lista.Count > 0 Then
                    .AutoGenerateColumns = False

                    .Columns("Key").Visible = False
                    .Columns("Versione").Visible = False
                    .Columns("CreatoDa").Visible = False
                    .Columns("ModificatoDa").Visible = False
                    .Columns("DataCreazione").Visible = False
                    .Columns("DataModifica").Visible = False
                    .Columns("Descrizione").Visible = False
                    .Columns("DataImportazione").Visible = False
                    .Columns("Selected").Visible = False


                    .Columns("Utente").Visible = False
                    '.Columns("ListaEntiInoltro").Visible = False
                    .Columns("IdDelega").Visible = False

                    .Columns("Referente").Visible = False
                    .Columns("DataInoltro").Visible = False
                    .Columns("DataAccettazioneDelega").Visible = False
                    .Columns("DataDecorrenzaDelega").Visible = False
                    .Columns("DataAnnullamentoDelega").Visible = False
                    .Columns("DataRevocaDelega").Visible = False
                    .Columns("PagamentoAttivazione").Visible = False
                    '.Columns("selected").Visible = False
                    '.Columns("Path_Documento").Visible = False

                    '.Columns("EnteAccettante1").Visible = False
                    '.Columns("EnteAccettante2").Visible = False
                    .Columns("EnteInoltro").Visible = True
                    '.Columns("EnteInoltro2").Visible = False
                    .Columns("DelegaDiAnnullamento").Visible = False
                    .Columns("DataRegistrazione").Visible = False
                    .Columns("GetDataRegistrazione").Visible = False
                    .Columns("Note").Visible = False
                    .Columns("NonCancellabile").Visible = False
                    '.Columns("InoltrataEntrambiEntiBilaterali").Visible = False
                    .Columns("TipoDocumento").Visible = False
                    .Columns("CausaleFineCiclo").Visible = False
                    .Columns("StatoPrecedente").Visible = False
                    .Columns("Id").Visible = False
                    .Columns("IsForSettoreEdile").Visible = False
                    .Columns("SedeOperativa").Visible = False
                    .Columns("Reparto").Visible = False
                    .Columns("Responsabile").Visible = False

                    .Columns("DataDocumento").Visible = True
                    .Columns("DataDocumento").HeaderText = "Data documento"
                    .Columns("DataDocumento").ReadOnly = True
                    .Columns("DataDocumento").DisplayIndex = 0

                    .Columns("StatoDelega").Visible = True
                    .Columns("StatoDelega").HeaderText = "Stato delega"
                    .Columns("StatoDelega").ReadOnly = True
                    .Columns("StatoDelega").DisplayIndex = 1


                    .Columns("EnteInoltro").Visible = True
                    .Columns("EnteInoltro").HeaderText = "Ente d'inoltro"
                    .Columns("EnteInoltro").ReadOnly = True
                    .Columns("EnteInoltro").DisplayIndex = 2

                    .Columns("CausaleSottoscrizione").Visible = True
                    .Columns("CausaleSottoscrizione").HeaderText = "Causale"
                    .Columns("CausaleSottoscrizione").ReadOnly = True
                    .Columns("CausaleSottoscrizione").DisplayIndex = 3

                    .Columns("NomeStato").Visible = False

                    .Columns("Settore").Visible = False
                    '.Columns("Settore").HeaderText = "Settore"
                    '.Columns("Settore").ReadOnly = True
                    '.Columns("Settore").DisplayIndex = 2


                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia delle deleghe per l'utente" & vbCrLf & ex.Message)
        End Try
    End Sub
#End Region
    Private Sub LoadGridMagazzino(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With DataGridView1

                .DataSource = Lista
                If Lista.Count > 0 Then
                    .AutoGenerateColumns = False

                    .Columns("Key").Visible = False
                    .Columns("Versione").Visible = False
                    .Columns("CreatoDa").Visible = False
                    .Columns("ModificatoDa").Visible = False
                    .Columns("DataCreazione").Visible = False
                    .Columns("DataModifica").Visible = False
                    .Columns("Descrizione").Visible = False
                    .Columns("NonCancellabile").Visible = False
                    .Columns("Id").Visible = False


                    '.Columns("DataDocumento").Visible = True
                    '.Columns("DataDocumento").HeaderText = "Data documento"
                    '.Columns("DataDocumento").ReadOnly = True
                    '.Columns("DataDocumento").DisplayIndex = 0

                    '.Columns("StatoDelega").Visible = True
                    '.Columns("StatoDelega").HeaderText = "Stato delega"
                    '.Columns("StatoDelega").ReadOnly = True
                    '.Columns("StatoDelega").DisplayIndex = 1


                    '.Columns("EnteInoltro").Visible = True
                    '.Columns("EnteInoltro").HeaderText = "Ente d'inoltro"
                    '.Columns("EnteInoltro").ReadOnly = True
                    '.Columns("EnteInoltro").DisplayIndex = 2

                    '.Columns("CausaleSottoscrizione").Visible = True
                    '.Columns("CausaleSottoscrizione").HeaderText = "Causale"
                    '.Columns("CausaleSottoscrizione").ReadOnly = True
                    '.Columns("CausaleSottoscrizione").DisplayIndex = 3

                    '.Columns("NomeStato").Visible = False

                    '.Columns("Settore").Visible = False
                    ''.Columns("Settore").HeaderText = "Settore"
                    ''.Columns("Settore").ReadOnly = True
                    ''.Columns("Settore").DisplayIndex = 2


                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia delle deleghe in magazzino per l'utente" & vbCrLf & ex.Message)
        End Try
    End Sub





#Region "Metodi per il salvataggio"

    'Protected Overrides Sub Navigate()
    '   Try
    '      Dim ParameterList As Hashtable = New Hashtable
    '      ParameterList.Add("Id", m_IdShowedObject)
    '      Me.NavigateWithoutHistoryTo("ViewDeleghe")
    '   Catch ex As Exception
    '      Throw New Exception(ex.Message)
    '   End Try
    'End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo("ViewDeleghe", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Status As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("Status", Status)
            ParameterList.Add("IdUtente", Me.m_IdShowedObject)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

#End Region





    Private Sub View()
        Try
            Me.m_IdShowedObject = Me.IdUtenteTextBox1.TextValue
            controller.LoadById(Me.m_IdShowedObject)
            Dim listaDeleghe As IList = controller.ElencoDeleghe
            If listaDeleghe.Count > 0 Then
                Navigate(Me.m_IdShowedObject)
            Else
                PerformDialog()
            End If
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub









    'stampa
    Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik

        If controller.ElencoDeleghe Is Nothing Then
            Return
        Else
            Dim print As PrintFacade = New PrintFacade()
            print.PrintDeleghe(controller.ElencoDeleghe)
        End If
    End Sub

    Private Sub SpNew_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
        Try


            Dim id As Int32
            Try
                id = CType(IdUtenteTextBox1.TextValue, Int32)
            Catch ex As InvalidCastException
                id = -1
            Catch ex As OverflowException
                id = -1
            End Try


            If id = -1 Then
                Me.NavigateWithoutHistoryTo("CreateDelega", True)
            Else

                Dim hash As New Hashtable
                hash.Add("IdUtente", IdUtenteTextBox1.TextValue)
                Me.NavigateWithoutHistoryTo("CreateDelega", hash, True)
            End If


        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub



    Private Sub IdUtenteTextBox1_ReturnPressed() Handles IdUtenteTextBox1.ReturnPressed
        View()
    End Sub

    Private Sub ControlVisualizzatoreDeleghe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdUtenteTextBox1.SetFocus()
    End Sub
End Class


