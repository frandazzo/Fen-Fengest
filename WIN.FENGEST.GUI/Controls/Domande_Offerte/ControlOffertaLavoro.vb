Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports WIN.GUI.UTILITY

<SecureContext()> _
Public Class ControlOffertaLavoro
    Private controller As New WIN.APPLICATION.ControllerOfferteLavoro(True)

    Private WithEvents frm As FrmItemOfferta
    Private m_IdAzienda As Int32 = -1
    Private m_automaticCreation As Boolean = False
    Dim m_ClearCache As Boolean = False

    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Domande lavoro", Alias:="Creazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Domande lavoro", Alias:="Aggiornamento", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Domande lavoro", Alias:="Cancellazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub







    Public Sub New(ByVal IdOfferta As Int32, ByVal ClearCache As Boolean)
        InitializeComponent()
        Me.m_IdShowedObject = IdOfferta
        m_ClearCache = ClearCache

        DoLoad()

    End Sub

    Public Sub New(ByVal IdAzienda As Int32, ByVal dummyField1 As Boolean, ByVal dummyField2 As Boolean)
        InitializeComponent()
        Me.m_IdAzienda = IdAzienda

        m_automaticCreation = True
        DoLoad()
    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " domanda lavoro"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " domanda lavoro "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  domanda   lavoro")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  domanda lavoro"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneAzienda)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneAzienda)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   domanda   lavoro  " & UCase(controller.DescrizioneAzienda))
        If TypeOf (Me.State) Is StView Then

        Else

        End If
    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  domanda lavoro"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneAzienda)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneAzienda)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   domanda   lavoro   " & UCase(controller.DescrizioneAzienda))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.AZIENDE.ControllerAziende, "Descrizione", Me.lblAziendaDescrizione, Me.IdAziendaTextBox1.TextValue)
    End Sub


    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Private Overloads Sub AddCommandToHistory()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.AddCommandToHistory("ViewOfferta", ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtId.Enabled = False
        Me.txtId.Visible = True
        Me.lblId.Visible = True
    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewOfferta", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String, Optional ByVal ClearCache As Boolean = False)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("ClearCache", ClearCache)
            Me.NavigateWithoutHistoryTo("ViewOfferta", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub


    Private Sub lblAzienda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAzienda.DoubleClick
        Try
            Navigate(Me.IdAziendaTextBox1.TextValue, "ViewAzienda")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            If Me.State.StateName = "Creazione" Then
                MasterControl.Instance.GoPrevious()
            Else
                'inserisco il do load per recuperare gli eventi
                Navigate(Me.IdShowedObject, True)
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintReportOfferteLavoro(controller)
        Catch ex As Exception
            'Dim s As String = ex.Message + Environment.NewLine

            's += ex.StackTrace

            'MsgBox(s)
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("La domanda di lavoro sarà eliminata solamente se nel sistema non ci sono altri riferimenti. Sicuro di voler cancellare la domanda di lavoro? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                MasterControl.Instance.GoPrevious()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            'NavigateWithoutHistoryTo("CreateVertenza")
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            StartSaveOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Public Sub New()
        InitializeComponent()

        DoLoad()

    End Sub
    Public Sub New(ByVal IdVertenza As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdVertenza

        DoLoad()

    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.MainGroup.Visible = True
        Me.txtId.Text = ""
        Me.txtId.Visible = True
        Me.lblId.Visible = True
        Me.IdAziendaTextBox1.Enabled = False
        'MasterControl.Instance.ParentForm.Text = "Visualizzazione vertenza"
        CustomBar1.SetTargetControl(Me)

    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        dtpData.Value = Today
        txtNote.Text = ""
        dtpDi.Value = Today
        dtpDf.Value = Today
        Me.txtId.Text = ""
        Me.IdAziendaTextBox1.TextValue = ""
        Me.lblAziendaDescrizione.Text = ""

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        If m_ClearCache Then
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            m_ClearCache = False
        Else
            controller.LoadById(Me.m_IdShowedObject)
        End If
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        dtpData.Value = controller.Data

        dtpDi.Value = controller.DataInizioValidita
        dtpDf.Value = controller.DataFineValidita
        txtNote.Text = controller.Note
        Me.txtId.Text = controller.IdOfferta
        Me.IdAziendaTextBox1.TextValue = controller.IdAzienda
        Me.lblAziendaDescrizione.Text = controller.DescrizioneAzienda


        'adesso carico la lista degli eventi
        LoadGrid(controller.GetItems)
        Me.GridItems.Refresh()
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Public Overrides Sub DoLoad()
        Try
            If Me.m_IdShowedObject = -1 Then
                'Me.PrepareForCreation()
            Else
                MyBase.m_IsLoading = True
                Nested_PrepareLoading()
                Nested_ClearWindowEditors()
                Nested_LoadDataFromDataSource()
                Nested_LoadEditorsProperties()
                Nested_PostLoadingActions()
                MyBase.m_IsLoading = False
            End If
        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw
        End Try
    End Sub
    Protected Overrides Sub Nested_PrepareForCreation()
        CustomBar1.SetTargetControl(Me)
        lblId.Visible = False
        txtId.Visible = False
        controller.CreateNew()
        LoadGrid(controller.GetItems)
        Me.IdAziendaTextBox1.Enabled = True
        If m_automaticCreation Then
            Me.m_automaticCreation = False
            Me.IdAziendaTextBox1.TextValue = m_IdAzienda
            InterfaceMediator.GetSimpleDescription(New AZIENDE.ControllerAziende, "Descrizione", Me.lblAziendaDescrizione, m_IdAzienda)
        End If
    End Sub

#End Region


#Region "Metodi per il salvataggio"
    Public Overrides Sub Nested_InsertData()


        controller.Data = dtpData.Value
        controller.SetValidita(dtpDi.Value, dtpDf.Value)
        controller.Note = txtNote.Text
        controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        controller.Save()
        MyBase.m_IdShowedObject = controller.IdOfferta

    End Sub
#End Region



#Region "Metodi per l'aggiornamento"
    Public Overrides Sub Nested_UpdateData()
        controller.Data = dtpData.Value
        controller.SetValidita(dtpDi.Value, dtpDf.Value)
        controller.Note = txtNote.Text
        controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        controller.Save()
    End Sub

    Private Sub IdAziendaTextBox1_TextBoxChanged() Handles IdAziendaTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpDI_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDi.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDf.ValueChanged
        Me.StartChangeOperation()
    End Sub


    Private Sub frm_ItemAdded() Handles frm.ItemAdded
        Me.StartChangeOperation()
    End Sub

    Private Sub frm_ItemUpdated() Handles frm.ItemUpdated
        Me.StartChangeOperation()
    End Sub
#End Region

    Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
        Try
            If Me.GridItems.SelectedRows.Count = 0 Then Throw New Exception("Nessun item è stato selezionato. Selezionare un item.")
            controller.SelectItem(GridItems.SelectedRows(0).Cells("Abilita").Value.Descrizione, GridItems.SelectedRows(0).Cells("Livello").Value.Descrizione)
            frm = New FrmItemOfferta("View", controller)
            frm.ShowDialog()
            frm.Dispose()
            'GridEventi.Refresh()
            LoadGrid(controller.GetItems)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CmdAdd_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdAdd.DoClik
        Try
            frm = New FrmItemOfferta("Add", controller)
            frm.ShowDialog()
            frm.Dispose()
            If GridItems.DataSource Is Nothing Then
                LoadGrid(controller.GetItems)
            Else
                GridItems.DataSource = New ArrayList
                GridItems.DataSource = controller.GetItems
                GridItems.Refresh()
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CmdDel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdDel.DoClik
        Try
            If Me.GridItems.SelectedRows.Count = 0 Then Throw New Exception("Nessun item è stato selezionato. Selezionare un item.")
            controller.RemoveItem(GridItems.SelectedRows(0).Cells("Abilita").Value.Descrizione, GridItems.SelectedRows(0).Cells("Livello").Value.Descrizione)
            Me.StartChangeOperation()
            GridItems.DataSource = New ArrayList
            GridItems.DataSource = controller.GetItems
            '
            'LoadGrid(controller.GetListaSediOperative)
            GridItems.Refresh()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LoadGrid(ByVal Lista As IList)

        'GridReferenti.DataSource = Lista
        With GridItems
            If Lista.Count > 0 Then
                .DataSource = Lista
                .AutoGenerateColumns = False
                If .Columns.Contains("Key") Then
                    .Columns("Key").Visible = False
                End If

                .Columns("Id").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False

                .Columns("Offerta").Visible = False


                .Columns("Abilita").Visible = True
                .Columns("Abilita").HeaderText = "Abilità"
                .Columns("Abilita").ReadOnly = True
                .Columns("Abilita").DisplayIndex = 1

                .Columns("Livello").Visible = True
                .Columns("Livello").HeaderText = "Livello"
                .Columns("Livello").ReadOnly = True
                .Columns("Livello").DisplayIndex = 2

                .Columns("NumeroPosti").Visible = True
                .Columns("NumeroPosti").HeaderText = "Numero posti"
                .Columns("NumeroPosti").ReadOnly = True
                .Columns("NumeroPosti").DisplayIndex = 3


                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With



    End Sub





    Private Sub GridEventi_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridItems.CellMouseDoubleClick
        Try
            If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
                If Me.GridItems.SelectedRows.Count = 0 Then Throw New Exception("Nessun item è stato selezionato. Selezionare un item.")
                controller.SelectItem(GridItems.SelectedRows(0).Cells("Abilita").Value.Descrizione, GridItems.SelectedRows(0).Cells("Livello").Value.Descrizione)
                frm = New FrmItemOfferta("View", controller)
                frm.ShowDialog()
                frm.Dispose()
                LoadGrid(controller.GetItems)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub GridItems_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridItems.DataError
        'If TypeOf (e.Exception) Is IndexOutOfRangeException Then
        '   Return
        'End If
    End Sub



    Private Sub lblId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblId.Click

    End Sub
End Class

