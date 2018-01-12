


Imports System.Drawing.Drawing2D
Imports WIN.APPLICATION
Imports WIN.GUI.PRINT
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.IO

<SecureContext()> _
Public Class ControlListaLavoro
    Private controller As New ControllerListaUtenti
    Dim m_ClearCache As Boolean = False
    Private m_selectedColumnName As String = ""
    Private WithEvents m_gestore As GestoreConfrontoListe

    Dim frmelab As FrmElaborazioneInCorso


    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub


    Public Sub New(ByVal IdAz As Int32, ByVal ClearCache As Boolean)
        InitializeComponent()
        Me.m_IdShowedObject = IdAz
        m_ClearCache = ClearCache

        DoLoad()
        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        End If
    End Sub




    Public Sub New()
        InitializeComponent()

        DoLoad()
        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        End If
    End Sub
    Public Sub New(ByVal IdLista As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdLista

        DoLoad()
        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        End If
    End Sub




    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Liste lavoro", Alias:="Creazione", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Liste lavoro", Alias:="Aggiornamento", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Liste lavoro", Alias:="Cancellazione", Macroarea:="Comunicazioni")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub





    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  lista lavoro utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  lista lavoro utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " lista lavoro utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  lista lavoro utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  lista lavoro utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))

            cmdSms.Visible = False


        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        GrpSed.Visible = False
        grpRag.Visible = False
        SpNew.Visible = True
        Me.IdListaUtentiTextBox1.TextValue = ""
        Me.IdListaUtentiTextBox1.Visible = True
        Me.IdListaUtentiTextBox1.Enabled = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca lista lavoro utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca lista lavoro utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        ' Me.CmdVis.Visible = True
        Me.CustomBar1.Visible = False
        Me.lblCurrentFunction.Text = UCase("Ricerca lista lavoro utente ")

    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        GrpSed.Visible = True
        grpRag.Visible = True
        SpNew.Visible = False

        Me.IdListaUtentiTextBox1.TextValue = ""
        Me.IdListaUtentiTextBox1.Enabled = False
        Me.IdListaUtentiTextBox1.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()
        'Me.CmdVis.Visible = False

        Me.CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)

        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        Else
            cmdSms.Visible = True
        End If
    End Sub





    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera

        Me.txtDescrizione.Text = ""
        GridUtenti.DataSource = Nothing

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        If m_ClearCache Then
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            m_ClearCache = False
        Else
            controller.LoadById(Me.m_IdShowedObject)
        End If
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtDescrizione.Text = controller.Descrizione
        Me.IdListaUtentiTextBox1.TextValue = controller.IdLista
        'Dim ll As ListaLavoroUtenti = controller.Current
        LoadGridUtenti()
        txtNumero.Text = controller.NumeroUtenti
    End Sub
#End Region

    Protected Overrides Sub Nested_PostUpdateActions()

        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        Else
            cmdSms.Visible = True
        End If
    End Sub

#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdListaUtentiTextBox1.Enabled = False
        Me.IdListaUtentiTextBox1.Visible = False
        Me.lblId.Visible = False
        SpNew.Visible = False
        'Me.CmdVis.Visible = False
        Me.CustomBar1.SetTargetControl(Me)
        Me.CustomBar1.Visible = True
        GrpSed.Visible = True
        grpRag.Visible = True
        controller.CreateNew()
        cmdSms.Visible = False
    End Sub
#End Region




#Region "Metodi per il salvataggio"

    Protected Overrides Sub Navigate()

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.NavigateWithoutHistoryTo("ViewLista", ParameterList, True)

    End Sub



    Protected Overloads Sub Navigate(ByVal ToId As String, Optional ByVal ClearCache As Boolean = False)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        ParameterList.Add("ClearCache", ClearCache)
        Me.NavigateTo("ViewLista", ParameterList, True)

    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Status As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("Status", Status)
            ParameterList.Add("IdLista", Me.m_IdShowedObject)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Nested_InsertData()


        controller.Descrizione = Me.txtDescrizione.Text

        controller.Save()
        MyBase.m_IdShowedObject = controller.IdLista

    End Sub
#End Region



    Public Overrides Sub Nested_UpdateData()

        controller.Descrizione = Me.txtDescrizione.Text

        controller.Save()
    End Sub

    Private Sub View()
        Try
            Navigate(Me.IdListaUtentiTextBox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        'DoPrint()


        Dim a As New FrmPrintAziendeInListaLavoro(GridUtenti.DataSource)
        a.ShowDialog()
        a.Dispose()

        GridUtenti.ShowPrintPreview()
    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            If Me.State.StateName = "Creazione" Then
                MasterControl.Instance.GoPrevious()
            Else
                Navigate(Me.IdListaUtentiTextBox1.TextValue, True)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    'Protected Overrides Sub DoPrint()
    '    Try
    '        Dim print As PrintFacade = New PrintFacade
    '        print.PrintReportListaLavoro(controller)
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub



    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("Lalista lavoro utente sarà eliminata solamente se nel sistema non ci sono altri riferimenti alla lista lavoro utente. Sicuro di voler cancellare la lista lavoro utente selezionata? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione lista lavoro utente") = MsgBoxResult.Yes Then
                controller.Delete()
                Navigate(-1)
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

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



    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewLista", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.IdListaUtentiTextBox1.Enabled = False
        Me.IdListaUtentiTextBox1.Visible = True
        Me.lblId.Visible = True
        If Not My.Settings.EnableSms Then
            cmdSms.Visible = False
        Else
            cmdSms.Visible = True
        End If
    End Sub


    'Public Sub LoadGridUtenti(ByVal Lista As IList)

    '    'Dim loader As New GridLoaderListaLavoro(GridUtenti)
    '    'loader.LoadGrid(Lista)

    '    
    'End Sub


    'Private Sub GridUtenti_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    '    If GridUtenti.Columns(e.ColumnIndex).Name.Equals("Comunicazione") Then
    '        If Not e.Value Is Nothing Then
    '            e.Value = e.Value.Cellulare1 & " - " & e.Value.Cellulare2
    '        End If
    '    End If

    '    If GridUtenti.Columns(e.ColumnIndex).Name.Equals("Residenza") Then
    '        If Not e.Value Is Nothing Then
    '            'GridUtenti.Rows(e.RowIndex).Cells("Indirizzo").Value = e.Value.Via.ToString & " " & e.Value.Cap
    '            e.Value = e.Value.Comune.ToString

    '        End If
    '    End If

    'End Subng

    Private Sub LoadGridUtenti()
        If GridUtenti.DataSource IsNot Nothing Then
            GridUtenti.DataSource = Nothing
        End If

        Dim ll As ListaLavoroUtenti = controller.Current
        GridUtenti.DataSource = ll.GetListaDtosUtenti
    End Sub




    'Private Sub GridUtenti_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    '    Try


    '        'tolgo il glifo da tutte le colonne non selezionate
    '        For Each elem As DataGridViewColumn In GridUtenti.Columns
    '            If e.ColumnIndex <> elem.Index Then
    '                elem.HeaderCell.SortGlyphDirection = SortOrder.None
    '            End If
    '        Next

    '        'SelectToolStripImage nella colonna non c'è glifo
    '        If GridUtenti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
    '            'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '            OrderUp(GridUtenti.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If


    '        'SelectToolStripImage nella colonna c'è glifo ascending
    '        If GridUtenti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
    '            'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '            OrderUp(GridUtenti.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If


    '        'SelectToolStripImage nella colonna c'è glifo descending
    '        If GridUtenti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
    '            ' m_selectedColumnName = 
    '            OrderDown(GridUtenti.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If

    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub



    'Private Sub OrderUp(ByVal colonna As String)
    '    Try
    '        controller.SortItems(colonna)
    '        ' Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridUtenti.Refresh()
    '        GridUtenti.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub OrderDown(ByVal colonna As String)
    '    Try
    '        controller.SortItems(colonna, True)
    '        ' Me.GridPosizioni.DataSource = controller.SearchResult
    '        GridUtenti.Refresh()
    '        GridUtenti.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub



    'Private Sub GridUtenti_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
    '    If TypeOf (e.Exception) Is ArgumentOutOfRangeException Then
    '        '
    '    End If
    'End Sub




    Private Sub txtDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrizione.TextChanged
        Me.StartChangeOperation()
    End Sub





    'Private Sub GridUtenti_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If GridUtenti.SelectedCells.Count = 0 Then Return
    '    If GridUtenti.SelectedRows.Count > 1 Then Return
    '    Try
    '        Select Case GridUtenti.Columns(e.ColumnIndex).Name

    '            Case "CompleteName"
    '                Navigate(GridUtenti.Rows(e.RowIndex).DataBoundItem.Id, "ViewUtente")

    '        End Select

    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub



    Private Sub SpNew_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
        StartCreateOperation()
    End Sub

    Private Sub cmdAddElement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddElement.Click
        Try
            Dim lista As New ArrayList
            Dim frm As New FrmSelezionaId
            frm.SetTipoRicerca(ControlloListeIDs.SearchType.Utenti, lista)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                lista = frm.ControlloListeIDs1.GetListId
                For Each elem As Int32 In lista
                    controller.AddUtente(elem)
                    If controller.UtenteAggiunto Then
                        StartChangeOperation()
                    End If
                Next
                LoadGridUtenti()
                txtNumero.Text = controller.NumeroUtenti
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdRemoveElem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveElem.Click
        If Me.GridView1.SelectedRowsCount <> 1 Then
            MsgBox("Selezionare un elemento da eliminare!", MsgBoxStyle.Exclamation, "Selezione utente")
            Return
        End If


        If GridView1.IsDataRow(GridView1.FocusedRowHandle) Then
            Dim o As Object = GridView1.GetRow(GridView1.FocusedRowHandle)
            Dim i As UtenteDTO = DirectCast(o, UtenteDTO)
            controller.RemoveUtente(i.Id.ToString)
            Me.StartChangeOperation()
            LoadGridUtenti()
            txtNumero.Text = controller.NumeroUtenti
        End If
    End Sub

    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As UtenteDTO = DirectCast(GridView1.GetRow(handle), UtenteDTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub cmdAddLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddLista.Click
        Try
            Dim frm As New FrmSelezionaListaLavoro
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If frm.ListaLavoro IsNot Nothing Then
                    controller.Current.Merge(frm.ListaLavoro)
                    StartChangeOperation()
                    LoadGridUtenti()
                    txtNumero.Text = controller.NumeroUtenti
                End If
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdDelLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelLista.Click
        Try
            Dim frm As New FrmSelezionaListaLavoro
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If frm.ListaLavoro IsNot Nothing Then
                    controller.Current.SubtractCommons(frm.ListaLavoro)
                    StartChangeOperation()
                    LoadGridUtenti()
                    txtNumero.Text = controller.NumeroUtenti
                End If
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdClone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClone.Click
        Try


            If controller.Current Is Nothing Then Return


            'Dim controllerListe As New ControllerListaUtenti
            'controllerListe.SetCurrent(controller.Current.Clone)
            ''  controllerListe.Descrizione = "Clone_" & controller.Current.Descrizione & "_" & Guid.NewGuid.ToString


            'controllerListe.Save()
            Dim created As String = CreateCloneList()
            MsgBox("Lista clonata con successo con il nome: " & created & "!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Function CreateCloneList() As String
        Dim controllerListe1 As New ControllerListaUtenti
        controllerListe1.CreateNew()
        controllerListe1.Descrizione = "Clone_" & Format(DateTime.Now, "dd-MM-yyyy hh-mm-ss")

        For Each elem As UtenteDTO In GetVisuibleRecords()
            controllerListe1.AddUtente(elem.Id)
        Next
        controllerListe1.Save()
        Return controllerListe1.Descrizione
    End Function


    Private Sub cmdCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompare.Click
        Try
            Dim listaConfronto As ListaLavoroUtenti = Nothing
            'Verifico lo stato dell'interfaccia
            If Me.State.StateName = "Aggiornamento" Or Me.State.StateName = "Creazione" Then
                MessageBox.Show("Salvare la lista prima di effettuare il controllo", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'Verifico che sia selezionata una lista corrente
            If controller.Current Is Nothing Then Throw New InvalidOperationException("Lista corrente non selezionata!")


            'Verifico che ci sia l'elemento di confronto
            Dim frm As New FrmSelezionaListaLavoro
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                listaConfronto = frm.ListaLavoro
            End If

            'Verifico la corretta  selezione della lista di confronto
            If listaConfronto Is Nothing Then Throw New InvalidOperationException("Selezionare una lista per il confronto!")


            'Imposto il gestore per l'attuazione del confronto
            m_gestore = New GestoreConfrontoListe
            m_gestore.AddComponenteLista1(controller.Current.Descrizione, ComponenteLista.ComponentType.ListaLavoro, controller.Current)
            m_gestore.AddComponenteLista2(listaConfronto.Descrizione, ComponenteLista.ComponentType.ListaLavoro, listaConfronto)




            'visualizzo lo stato di avanzamento
            frmelab = New FrmElaborazioneInCorso

            frmelab.SetPercentageValue(0)
            frm.TopLevel = True
            frmelab.EnableCancel(False)
            frmelab.Show()


            'Creo il'oggetto confronto
            Dim Confronto As ConfrontoListeUtenti = m_gestore.CreaConfronto()

            'Chiudo il form di avanzamento attività
            frmelab.Close()
            frmelab.Dispose()


            'visualizzo il risultato del  confronto
            '*********************************++
            Dim frmViewConf As New FrmConfrontoListeLavoro(Confronto)
            frmViewConf.Show()


            '*********************************++





        Catch ex As Exception
            ErrorHandler.ShowError(ex)

        End Try
    End Sub


    Private Sub ViewFrmElabState()
        If frmelab Is Nothing Then
            Return
        End If


        If frmelab.Disposing Then
            Return
        End If
    End Sub


    Private Sub m_gestore_BeginExecuteCompare() Handles m_gestore.BeginExecuteCompare
        ViewFrmElabState()

        frmelab.SetPercentageValue(2)

        frmelab.SetActivity("Inizio attività di confronto")
    End Sub

    Private Sub m_gestore_CreateCommons() Handles m_gestore.CreateCommons
        ViewFrmElabState()

        frmelab.SetPercentageValue(90)

        frmelab.SetActivity("Creazione lista elementi comuni")
    End Sub

    Private Sub m_gestore_CreateDiffLista1() Handles m_gestore.CreateDiffLista1
        ViewFrmElabState()

        frmelab.SetPercentageValue(40)
        frmelab.SetActivity("Creazione lista elementi specifici della lista1")
    End Sub

    Private Sub m_gestore_CreateDiffLista2() Handles m_gestore.CreateDiffLista2
        ViewFrmElabState()

        frmelab.SetPercentageValue(60)
        frmelab.SetActivity("Creazione lista elementi specifici della lista2")
    End Sub

    Private Sub m_gestore_EndExecuteCompare() Handles m_gestore.EndExecuteCompare
        ViewFrmElabState()

        frmelab.SetPercentageValue(100)
        frmelab.SetActivity("Termine elaborazione")
    End Sub

    Private Sub m_gestore_MergeLista1() Handles m_gestore.MergeLista1
        ViewFrmElabState()

        frmelab.SetPercentageValue(10)

        frmelab.SetActivity("Unione liste di partenza")

    End Sub

    Private Sub m_gestore_MergeLista2() Handles m_gestore.MergeLista2
        ViewFrmElabState()

        frmelab.SetPercentageValue(20)
        frmelab.SetActivity("Unione liste di confronto")
    End Sub

    Private Sub IdListaUtentiTextBox1_ReturnPressed() Handles IdListaUtentiTextBox1.ReturnPressed
        View()
    End Sub

    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        Try
            MasterControl.Instance.GoToImportCenter()

        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            Dim frm As New FrmExportLista(controller.Current)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdRemIncorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemIncorrect.Click
        Try

            controller.Current.RemoveIfAddressIsNotValid()
            StartChangeOperation()
            LoadGridUtenti()
            txtNumero.Text = controller.NumeroUtenti

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub ControlListaLavoro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If txtDescrizione.Visible Then
            txtDescrizione.Focus()
        Else
            IdListaUtentiTextBox1.SetFocus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If controller.Current Is Nothing Then
            Return
        End If

        'Try

        '    Dim frm As New FrmExportIndex(controller.Current.ListaUtenti.Count)
        '    Dim min As Int32 = 0
        '    Dim max As Int32 = 0

        '    If frm.ShowDialog = DialogResult.OK Then

        '        max = frm.Max
        '        min = frm.Min

        '        frm.Dispose()
        '    Else
        '        frm.Dispose()
        '        Return

        '    End If


        '    'recupero il percorso del programma di export
        '    Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
        '    Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
        '    Dim f As New IO.FileInfo(path)
        '    path = f.DirectoryName + exportProgram




        '    'definisco i parametri di apertura del programma
        '    Dim args As New ProcessStartInfo
        '    args.Arguments = ConstuctArguments(min, max)

        '    'passo il nome del programma da avviare
        '    args.FileName = path

        '    'avvio il programma
        '    Process.Start(args)


        'Catch ex As Exception
        '    ErrorHandler.ShowError(ex)
        'End Try
        Try


            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere costruzione report...", My.Resources.Waiting3)

            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")


            Dim exportProgram As String = "\FenealConnector\WIN.WEBCONNECTOR.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.Parent.FullName + exportProgram

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalità non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If



            'definisco i parametri di apertura del programma
            Dim args As New ProcessStartInfo
            args.Arguments = ConstuctArguments(0, 25000)

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)



        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try


    End Sub



    Private Function ConstuctArguments(ByVal startIndex As Int32, ByVal endIndex As Int32) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"


        Dim chk As String = """chk:no"""
        Dim com As String = """com:3"""




        'creo la stringa dei codici fiscali
        Dim cf As String = CreateFiscalCodesFile(startIndex, endIndex)

        Dim flc As String = """flc:" + cf + """"


        result = usn + " " + usp + " " + pro + " " + chk + " " + com + " " + flc


        Return result
    End Function


    Private Function CreateFiscalCodesFile(ByVal index As Int32, ByVal endIndex As Int32) As String


        Dim file As String = System.IO.Path.GetTempPath + "temp.txt"



        Dim res As String = ""

        Dim i As Int32 = 0

        For Each elem As Utente In controller.Current.ListaUtenti

            If i >= index And i <= endIndex Then
                Dim cf As String = elem.CodiceFiscale.Trim

                'tolgo eventuali spazi
                cf.Replace(" ", "")

                If Not String.IsNullOrEmpty(cf) Then
                    res = res + " " + cf
                End If
            End If


            i = i + 1
        Next

        IO.File.Delete(file)
        IO.File.AppendAllText(file, res)


        Return file
    End Function

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then

            Dim s As UtenteDTO = DirectCast(view.GetRow(view.FocusedRowHandle), UtenteDTO)
            Navigate(s.Id.ToString, "ViewUtente")

            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Dim print As PrintFacade = New PrintFacade()
            'print.PrintReportPrestazioni(controller.Results)
            'GridPosizioni.ShowPrintPreview()





            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridUtenti
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdSms_Click(sender As Object, e As EventArgs) Handles cmdSms.Click
        Try
            SendSms()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    <Secure(Area:="Sms", Alias:="Invio multiplo", Macroarea:="Invio SMS")> _
    Private Sub SendSms()


        SecurityManager.Instance.Check()

        If controller.Current Is Nothing Then
            MessageBox.Show("Lista non creata!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim frm As New FrmMessaggiMultipli(GetVisuibleRecords)
        frm.ShowDialog()
        frm.Dispose()
    End Sub
End Class

