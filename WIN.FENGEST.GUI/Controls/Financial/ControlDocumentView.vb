Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlDocumentView
    Private controller As FINANCIAL_ARTIFACTS.AbstractDocumentController
    Private m_tipoDoc As String = ""
    Private m_NomeTipoDoc As String = ""
    Private m_SelectedColumnName As String = ""
    Private WithEvents frm As FrmItemContabile
    Private SearchList As IList
    Dim ControllerIQ As New WIN.APPLICATION.REPORTING.ReportIncassiQuote
    Dim gridloader As AbstractGridLoader

    Delegate Sub GridLoadMaker()
    Dim Grid As System.Windows.Forms.DataGridView
    Dim ControllerForSepThread As AbstractDocumentController
    Dim deleg1 As GridLoadMaker
    Dim controllerDoc As ControllerIncassiQuote
    Dim controllerDocPrev As ControllerIncassiQuotePrevisionali
    Dim controllerPagRef As ControllerPagamentoReferenti
    Dim m_ClearCache As Boolean = False

    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub
    Public Sub New(ByVal Id As Int32, ByVal TipoDocumento As String, ByVal ClearCache As Boolean)
        InitializeComponent()
        Me.m_IdShowedObject = Id
        m_ClearCache = ClearCache
        m_tipoDoc = TipoDocumento
        InizializzaController()
        DoLoad()
    End Sub




#Region "Metodi per la gestione del thread di caricamento secondario"

    Private m_ListaParziale As IList = New ArrayList
    Private m_Lista As IList = New ArrayList
    Private contatore As Int32 = 0
    Delegate Sub GuiRefresh()
    Dim deleg As GuiRefresh
    Delegate Sub StatusBarRefresh()
    Dim deleg2 As StatusBarRefresh

    Private Sub GridPosizioni_DataMemberChanged(sender As Object, e As EventArgs) Handles GridPosizioni.DataMemberChanged

    End Sub
    Private Sub GridPosizioni_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles GridPosizioni.Scroll


        'If m_Lista.Count <> m_ListaParziale.Count Then
        '    Dim thread As New System.Threading.Thread(AddressOf AddItemsToPartialList)

        '    ActivateToolStripStatusBar()
        '    'deleg2 = New StatusBarRefresh(AddressOf ActivateToolStripStatusBar)
        '    'MasterControl.Instance.GetMdi.StatusStrip.Invoke(deleg2)
        '    MasterControl.Instance.GetMdi.StatusStrip.Refresh()
        '    System.Windows.Forms.Application.DoEvents()


        '    thread.Start()


        '    'MasterControl.Instance.GetMdi.ToolStripProgressBar1.Maximum = m_Lista.Count + 1 - m_ListaParziale.Count
        '    'MasterControl.Instance.GetMdi.ToolStripProgressBar1.Value = 0
        '    'Static start As Boolean = False
        '    'Timer1.Start()
        '    Do While thread.IsAlive
        '        Threading.Thread.Sleep(100)
        '        '   'MasterControl.Instance.GetMdi.StatusStrip.Refresh()
        '        System.Windows.Forms.Application.DoEvents()
        '        '   'System.Diagnostics.Debug.WriteLine("Paasaggio ciclo")
        '        '   'If start = False Then

        '        '   '   start = True
        '        '   'End If
        '    Loop
        '    'thread.Join()
        '    'start = False
        '    'Timer1.Stop()
        '    'deleg2 = New StatusBarRefresh(AddressOf DeactivateToolStripStatusBar)
        '    'MasterControl.Instance.GetMdi.StatusStrip.Invoke(deleg2)
        '    DeactivateToolStripStatusBar()
        '    MasterControl.Instance.GetMdi.StatusStrip.Refresh()
        '    System.Windows.Forms.Application.DoEvents()
        'Else
        '    Return
        'End If
    End Sub


    'Private Sub AddFirstItemsToPartialList()
    '    For i As Int32 = contatore To contatore + 50
    '        If contatore > m_Lista.Count - 1 Then
    '            contatore = 0
    '            Exit Sub
    '        End If
    '        m_ListaParziale.Add(m_Lista.Item(i))
    '        deleg = New GuiRefresh(AddressOf GridRefresher)
    '        contatore = contatore + 1
    '    Next
    '    'Me.GridPosizioni.Invoke(deleg)
    '    'System.Windows.Forms.Application.DoEvents()
    'End Sub

    Private Sub ActivateToolStripStatusBar()
        MasterControl.Instance.GetMdi.ToolStripProgressBar1.Visible = True
        MasterControl.Instance.GetMdi.StatusStrip.Refresh()
    End Sub

    Private Sub DeactivateToolStripStatusBar()
        MasterControl.Instance.GetMdi.ToolStripProgressBar1.Visible = False
        MasterControl.Instance.GetMdi.StatusStrip.Refresh()
    End Sub

    Private Sub IncrementToolStripBar()
        'MasterControl.Instance.GetMdi.ToolStripProgressBar1.Step = 10
        MasterControl.Instance.GetMdi.ToolStripProgressBar1.PerformStep()
        MasterControl.Instance.GetMdi.StatusStrip.Refresh()
        Static j As Int32 = 0
        System.Diagnostics.Debug.WriteLine("Aggiornamento progress numero " & j + 1)
        j = j + 1

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        deleg2 = New StatusBarRefresh(AddressOf IncrementToolStripBar)
        MasterControl.Instance.GetMdi.StatusStrip.Invoke(deleg2)
    End Sub

    'Qui scrivo l'algoritmo per caricare la lista con 40 elementi la volta
    'Private Sub AddItemsToPartialList()

    '    'If m_Lista.Count <> m_ListaParziale.Count Then
    '    '   deleg2 = New StatusBarRefresh(AddressOf ActivateToolStripStatusBar)
    '    '   MasterControl.Instance.GetMdi.StatusStrip.Invoke(deleg2)
    '    '   System.Windows.Forms.Application.DoEvents()
    '    'End If
    '    'Timer1.Enabled = True
    '    'Timer1.Start()

    '    'deleg2 = New StatusBarRefresh(AddressOf InitializeProgressBar)
    '    'MasterControl.Instance.GetMdi.Invoke(deleg2)
    '    If contatore = 0 Then Exit Sub
    '    For i As Int32 = contatore To m_Lista.Count - 1
    '        m_ListaParziale.Add(m_Lista.Item(i))
    '        contatore = contatore + 1
    '    Next
    '    deleg = New GuiRefresh(AddressOf GridRefresher)
    '    'System.Windows.Forms.Application.DoEvents()
    '    Me.GridPosizioni.Invoke(deleg)
    '    'System.Windows.Forms.Application.DoEvents()
    '    contatore = 0


    '    ''Timer1.Stop()
    '    'deleg2 = New StatusBarRefresh(AddressOf DeactivateToolStripStatusBar)
    '    'MasterControl.Instance.GetMdi.StatusStrip.Invoke(deleg2)
    '    'System.Windows.Forms.Application.DoEvents()




    'End Sub

    Private Sub InitializeProgressBar()
        'MasterControl.Instance.GetMdi.ToolStripProgressBar1.Maximum = m_Lista.Count + 1 - m_ListaParziale.Count
        'MasterControl.Instance.GetMdi.ToolStripProgressBar1.Value = 0
        MasterControl.Instance.GetMdi.ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
    End Sub

    Private Sub GridRefresher()
        Me.GridPosizioni.DataSource = New ArrayList
        Me.GridPosizioni.DataSource = m_Lista
        Me.GridPosizioni.Refresh()
    End Sub




#End Region















#Region "Costruttori ed inizializzatori"
    Public Sub New(ByVal Id As Int32, ByVal TipoDocumento As String)
        InitializeComponent()
        Me.m_IdShowedObject = Id
        m_tipoDoc = TipoDocumento
        InizializzaController()
        DoLoad()
    End Sub





    Public Sub SetNomeTipoDocumento(ByVal NomeTipoDocumento As String)
        m_NomeTipoDoc = NomeTipoDocumento
    End Sub
    Private Sub InizializzaController()
        controller = ApplicationController.GetDocumentController(m_tipoDoc)
        'Qui adesso imposto i dettagli dei documenti
        'Select Case m_tipoDoc
        '   Case "IQA"
        '      m_NomeTipoDoc = "Incasso quote associative"
        '      cmdVis.Visible = False
        '   Case "PGR"
        '      m_NomeTipoDoc = "Pagamento referenti"
        '      cmdVis.Visible = True
        '   Case Else
        '      Throw New Exception("Tipo documento sconosciuto")
        'End Select
    End Sub
    Public Sub New()
        InitializeComponent()
        DoLoad()
    End Sub
#End Region


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " documento"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " documento "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " documento")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  documento"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(m_tipoDoc)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(m_tipoDoc)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  documento   " & UCase(m_tipoDoc))
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ZoomHS
    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  documento"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(m_tipoDoc)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(m_tipoDoc)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  documento " & UCase(m_tipoDoc))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try
    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        Me.GroupBox1.Visible = False
        GrpRef.Visible = False
        Me.txtId.Visible = False
        Me.lblId.Visible = False
        MasterControl.Instance.ParentForm.Text = "Ricerca documento"
        Me.lblCurrentFunction.Text = UCase("Ricerca   documento ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca documento"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        Me.GridPosizioni.Visible = False
        cmdUp.Visible = False
        CmdDown.Visible = False
        CustomBar1.Visible = False
        Me.GrpSogg.Visible = False
        Me.cmdAdd.Visible = False
        Me.cmdDel.Visible = False
        Me.cmdUp.Visible = False
        Me.CmdDown.Visible = False
        Panel1.Visible = False
        'cmdVis.Visible = False
    End Sub
#End Region



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.GroupBox1.Visible = True
        Me.txtTipo.Text = m_tipoDoc
        Me.txtId.Text = ""
        Me.txtId.Enabled = False

        Me.txtId.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione documento"
        Me.cmdCerca.Visible = False
        Me.GridPosizioni.Visible = True
        Panel1.Visible = True
        cmdUp.Visible = True
        CmdDown.Visible = True
        CustomBar1.SetTargetControl(Me)
        CustomBar1.Visible = True
        DocumentMediatorFactory.GetDocumentMediator(m_tipoDoc).DefineDocumentViewLayout(Me, m_tipoDoc)
        Me.txtTipo.Text = m_NomeTipoDoc
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        'lblCompetenza.Text = ""
        dtpRegistrazione.Value = Today
        Me.txtId.Text = ""
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        If m_ClearCache Then
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            m_ClearCache = False
        Else
            controller.LoadById(Me.m_IdShowedObject)
        End If
    End Sub



    Private Sub ViewGrid()
        'per questioni  di prestazioni devo svuotare le routine load data, gwetProperties
        ''e postloading actions. I loro contenuti saranno eseguiti su un thread a parte.
        'Dim thread As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadDataOnSeparatedThread)

        ''Visualizzo lo stato di attesa
        'MasterControl.Instance.ParentForm.Text = "Attendere ricerca e ricostruzione documento"
        'MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere ricerca e ricostruzione documento"
        'Me.lblCurrentFunction.Text = UCase(" Attendere  ricerca  e  ricostruzione  documento ")
        'MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim

        ''parte il thread secondario
        'thread.Start()


        'Do While thread.IsAlive = True
        '   System.Windows.Forms.Application.DoEvents()
        'Loop

        ' ''Attendo che il thread termini
        'thread.Join()


    End Sub







    Protected Overrides Sub Nested_LoadEditorsProperties()
        Me.SpecialButton1.Visible = True


        dtpRegistrazione.Value = controller.DataRegistrazione
        dtpDoc.Value = controller.DataDocumento
        txtNote.Text = controller.Note
        txtTipo.Text = controller.TipoDocumento
        Me.txtId.Text = controller.IdDocumento

        Select Case m_tipoDoc

            Case "IQA"


                controllerDoc = DirectCast(controller, ControllerIncassiQuote)
                'ControllerForSepThread = controllerDoc
                Me.txtCompetenza.Text = controllerDoc.Competenza
                Me.txtSettore.Text = controllerDoc.DescrizioneSettore
                Me.txtImporto.Text = controllerDoc.Importo
                Dim controllerset As New ControllerSettori
                controllerset.LoadById(controllerDoc.IdSettore)
                If controllerset.IsSettoreEdile Then
                    DisplayDataforSoggettoEdile(controllerDoc.DescrizioneSoggettoEsecutore)
                Else
                    DisplaydataForSoggettoIF(controllerDoc.IdSoggettoEsecutore)
                End If
                gridloader = GridLoaderDocumentFactory.GetGridDocumentLoader("IQA", Me.GridPosizioni)
                Grid = Me.GridPosizioni
                gridloader.SelectionMode = DataGridViewSelectionMode.FullRowSelect


                NotifyWaiting()

                'Poiche questa operazione richiede parecchio tempo la eseguo su un thread a parte

                Dim t As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadView)
                t.Start()

                Do While t.IsAlive
                    System.Windows.Forms.Application.DoEvents()
                Loop

                ' t.Join()
            Case "IQP"


                controllerDocPrev = DirectCast(controller, ControllerIncassiQuotePrevisionali)
                'ControllerForSepThread = controllerDoc
                Me.txtCompetenza.Text = controllerDocPrev.Competenza
                Me.txtSettore.Text = controllerDocPrev.DescrizioneSettore
                Me.txtImporto.Text = controllerDocPrev.Importo
                Dim controllerset As New ControllerSettori
                controllerset.LoadById(controllerDocPrev.IdSettore)
                If controllerset.IsSettoreEdile Then
                    DisplayDataforSoggettoEdile(controllerDocPrev.DescrizioneSoggettoEsecutore)
                Else
                    DisplaydataForSoggettoIF(controllerDocPrev.IdSoggettoEsecutore)
                End If
                gridloader = GridLoaderDocumentFactory.GetGridDocumentLoader("IQP", Me.GridPosizioni)
                Grid = Me.GridPosizioni
                gridloader.SelectionMode = DataGridViewSelectionMode.FullRowSelect


                NotifyWaiting()

                'Poiche questa operazione richiede parecchio tempo la eseguo su un thread a parte

                Dim t As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadViewIQP)
                t.Start()

                Do While t.IsAlive
                    System.Windows.Forms.Application.DoEvents()
                Loop

                ' t.Join()



            Case "PGR"
                controllerPagRef = DirectCast(controller, ControllerPagamentoReferenti)
                Grid = Me.GridPosizioni
                gridloader = GridLoaderDocumentFactory.GetGridDocumentLoader("PGR", Me.GridPosizioni)
                gridloader.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                NotifyWaiting()

                'Poiche questa operazione richiede parecchio tempo la eseguo su un thread a parte

                Dim t As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadViewPagRef)
                t.Start()

                Do While t.IsAlive
                    System.Windows.Forms.Application.DoEvents()
                Loop




                txtImporto.Text = controllerPagRef.Importo
                txtReferente.Text = controllerPagRef.IdReferente
                lblReferente.Text = controllerPagRef.NameReferente



            Case Else
                DocumentMediatorFactory.GetDocumentMediator(m_tipoDoc).GetSpecificDocumentProperties(Me, controller)

        End Select



        'm_Lista = controller.SearchResult
        'AddFirstItemsToPartialList()
        'Dim gridLoader As New GridLoaderRptIQ(Me.GridPosizioni)
        'gridLoader.LoadGrid(m_ListaParziale)
    End Sub


    Public Sub NotifyWaiting()

        MasterControl.Instance.ParentForm.Text = "Attendere ricerca e ricostruzione documento"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere ricerca e ricostruzione documento"
        MasterControl.Instance.Current.SetLabelForCurrentFunction(UCase(" Attendere  ricerca  e  ricostruzione  documento "))
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim


    End Sub


    Private Sub LoadGrid()
        gridloader.LoadGrid(m_ListaParziale)
    End Sub

    Private Sub LoadView()
        'deleg1 = New GridLoadMaker(AddressOf LoadGrid)
        m_Lista = controllerDoc.ListaPosizioniUtenti
        ''carico il datasource della griglia
        'AddFirstItemsToPartialList()
        ''la visualizzo
        'Grid.Invoke(deleg1)
        gridloader.LoadGrid(m_Lista)
    End Sub


    Private Sub LoadViewIQP()
        'deleg1 = New GridLoadMaker(AddressOf LoadGrid)
        m_Lista = controllerDocPrev.ListaPosizioniUtenti
        'carico il datasource della griglia
        'AddFirstItemsToPartialList()
        'la visualizzo
        'Grid.Invoke(deleg1)
        gridloader.LoadGrid(m_Lista)
    End Sub

    Private Sub LoadViewPagRef()
        'deleg1 = New GridLoadMaker(AddressOf LoadGrid)
        controllerPagRef.CreateListaDto()
        m_Lista = controllerPagRef.ListaDTOPosizioni
        'carico il datasource della griglia
        'AddFirstItemsToPartialList()
        'la visualizzo
        'Grid.Invoke(deleg1)
        gridloader.LoadGrid(m_Lista)

    End Sub


    Private Sub DisplaydataForSoggettoIF(ByVal IdSoggetto As String)
        With Me
            Try
                Dim controllerAziende As New AZIENDE.ControllerAziende
                controllerAziende.LoadById(IdSoggetto)
                .lblDescrizioneAzienda.Text = controllerAziende.Descrizione
                .lblCompUltimo.Text = controllerAziende.CompetenzaUltimoPagamento
                .lblContratto.Text = controllerAziende.DescrizioneContratto
                controllerAziende = Nothing
            Catch ex As Exception
                .lblDescrizioneAzienda.Text = ""
                .lblCompUltimo.Text = ""
                .lblContratto.Text = ""
            End Try
        End With
    End Sub
    Private Sub DisplayDataforSoggettoEdile(ByVal DescrizioneSoggetto As String)
        With Me

            Try
                Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
                controllerEnti.LoadById(controllerEnti.GetIdEnteByDescrizione(DescrizioneSoggetto))
                .lblDescrizioneAzienda.Text = controllerEnti.Descrizione
                .lblCompUltimo.Text = controllerEnti.CompetenzaUltimoPagamento
                .lblContratto.Text = ""
            Catch ex As Exception
                .lblDescrizioneAzienda.Text = ""
                .lblCompUltimo.Text = ""
                .lblContratto.Text = ""
            End Try

        End With
    End Sub



#End Region



#Region "Metodi per la navigazione"
    Protected Overloads Sub Navigate(ByVal ToId As Int32)
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        ParameterList.Add("TipoDocumento", m_tipoDoc)
        Me.NavigateTo("ViewDocumento", ParameterList, True)
    End Sub


    Protected Overloads Sub Navigate(ByVal ToId As Int32, ByVal ClearCache As Boolean)
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        ParameterList.Add("TipoDocumento", m_tipoDoc)
        ParameterList.Add("ClearCache", ClearCache)
        Me.NavigateTo("ViewDocumento", ParameterList, True)

    End Sub





    Protected Overloads Sub Navigate(ByVal ToId As Int32, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Overloads Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", Me.m_IdShowedObject)
            ParameterList.Add("TipoDocumento", m_tipoDoc)
            Me.NavigateWithoutHistoryTo("ViewDocumento", ParameterList, True)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region



#Region "Metodi per la formattazione della griglia"
    Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
        'Try
        If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If

        'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
        '    If Not e.Value Is Nothing Then
        '        e.Value = e.Value.ToString
        '    End If
        'End If

        'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
        '    If Not e.Value Is Nothing Then
        '        e.Value = e.Value.ToString
        '    End If
        'End If

        'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Vertenza") Then
        '    If Not e.Value Is Nothing Then
        '        e.Value = e.Value.ToString
        '    End If
        'End If
    End Sub
    Private Function GetImage(ByVal ImageType As String) As System.Drawing.Image
        If ImageType = "0" Then
            Return My.Resources.OK
        Else
            Return My.Resources.WarningHS
        End If
    End Function
#End Region



#Region "Metodi per l'aggiornamento"
    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_UpdateData()
        controller.DataDocumento = dtpDoc.Value
        controller.DataRegistrazione = Me.dtpRegistrazione.Value
        controller.Note = txtNote.Text
        controller.Save()
        Me.GridPosizioni.Refresh()
    End Sub
    Public Overrides Sub Nested_ReLoadProperties()
        '
    End Sub
    Private Sub cmdCompetenza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompetenza.Click
        Dim frm As New frmCompetenza
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            frm.ControlloSelezioneCompetenza1.CalcolaDate()



            Select Case m_tipoDoc
                Case "IQA"
                    DirectCast(controller, ControllerIncassiQuote).SetCompetenza(frm.ControlloSelezioneCompetenza1.MinDate, frm.ControlloSelezioneCompetenza1.MaxDate)
                    Me.txtCompetenza.Text = DirectCast(controller, ControllerIncassiQuote).Competenza
                Case "IQP"
                    DirectCast(controller, ControllerIncassiQuotePrevisionali).SetCompetenza(frm.ControlloSelezioneCompetenza1.MinDate, frm.ControlloSelezioneCompetenza1.MaxDate)
                    Me.txtCompetenza.Text = DirectCast(controller, ControllerIncassiQuotePrevisionali).Competenza
                Case "IQI"
                    DirectCast(controller, ControllerIncassiQuoteInps).SetCompetenza(frm.ControlloSelezioneCompetenza1.MinDate, frm.ControlloSelezioneCompetenza1.MaxDate)
                    Me.txtCompetenza.Text = DirectCast(controller, ControllerIncassiQuoteInps).Competenza
            End Select


        End If
        frm.Dispose()
    End Sub
    Private Sub dtpRegistrazione_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpRegistrazione.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDoc.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub txtCompetenza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompetenza.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub frm_EventAdded() Handles frm.EventAdded
        Me.StartChangeOperation()
    End Sub
    Private Sub frm_EventUpdated() Handles frm.EventUpdated
        Me.StartChangeOperation()
    End Sub

#End Region



#Region "Metodi di ricerca e selezione dei documenti e delle posizioni"
    Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.DoClik
        Try
            Dim frm As New SearchDocumenti
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.m_IdShowedObject = frm.SelectedId
                m_tipoDoc = frm.TipoDoc

                WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere ricostruzione documento...", My.Resources.Waiting3)
                Me.Navigate(Me.m_IdShowedObject)

                WIN.GUI.UTILITY.Helper.HideWaitBox()

            End If
            frm.Dispose()
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub GridPosizioni_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.CellMouseDoubleClick
        Try
            If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
                Select Case m_tipoDoc
                    Case "IQI"
                        Dim cont As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
                        cont.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Utente").Value.IdUtente.ToString, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.Rows(e.RowIndex).Cells("Prestazione").Value.TipoPrestazione.Id.ToString)
                    Case "IQV"
                        Dim cont As ControllerIncassiQuoteVertenza = DirectCast(controller, ControllerIncassiQuoteVertenza)
                        cont.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Vertenza").Value.Id.ToString)
                    Case Else
                        'controller.SelectItemByIds(GridPosizioni.Rows(e.RowIndex).Cells("Key").Value.Value(1), GridPosizioni.Rows(e.RowIndex).Cells("KeyPos").Value)
                        controller.SelectItemByIds(GridPosizioni.Rows(e.RowIndex).Cells("Key").Value.Value(1), GridPosizioni.Rows(e.RowIndex).Cells("Key").Value.Value(0))
                End Select
                Dim mediator As IDocumentViewMediator = DocumentMediatorFactory.GetDocumentMediator(m_tipoDoc)
                'mediator.ViewItemDetail(controller)
                frm = New FrmItemContabile("View", controller, m_tipoDoc)
                frm.ShowDialog()
                frm.Dispose()
                Select Case m_tipoDoc
                    Case "IQI"
                        mediator.RefeshItemsGrid(Me, controller)
                    Case "IQV"
                        mediator.RefeshItemsGrid(Me, controller)
                    Case "IQA"
                        txtImporto.Text = DirectCast(controller, ControllerIncassiQuote).Importo
                    Case "IQP"
                        txtImporto.Text = DirectCast(controller, ControllerIncassiQuotePrevisionali).Importo
                    Case "PGR"
                        txtImporto.Text = DirectCast(controller, ControllerPagamentoReferenti).Importo
                End Select


            End If





        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
#End Region



#Region "Metodi per il riordinamento aggiunta e rimozione  delle posizioni sulla griglia"
    Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
        'qui seleziono tutta la colonna
        GridPosizioni.ClearSelection()
        For Each elem As DataGridViewColumn In GridPosizioni.Columns
            elem.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
        m_SelectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    End Sub
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
        Try
            controller.SortItems(m_SelectedColumnName)
            If m_tipoDoc = "PGR" Then
                DirectCast(controller, ControllerPagamentoReferenti).CreateListaDto()
            End If
            DocumentMediatorFactory.GetDocumentMediator(m_tipoDoc).RefeshItemsGrid(Me, controller)
            If m_SelectedColumnName = "" Then Exit Sub
            GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
        Try
            controller.SortItems(m_SelectedColumnName, True)
            If m_tipoDoc = "PGR" Then
                DirectCast(controller, ControllerPagamentoReferenti).CreateListaDto()
            End If
            DocumentMediatorFactory.GetDocumentMediator(m_tipoDoc).RefeshItemsGrid(Me, controller)
            If m_SelectedColumnName = "" Then Exit Sub
            GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    '****************************************************************
    '****************************************************************
    'DA RIFATTORIZZARE. SPOSTARE NEL MEDIATOR
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.DoClik
        Try
            If GridPosizioni.SelectedRows.Count = 0 Then Throw New Exception("Per eliminare una riga posizionarsi su una cella all'interno della riga da rimuovere")
            If GridPosizioni.SelectedRows.Count > 1 Then Throw New Exception("Per eliminare una riga selezionare una sola cella all'interno della riga da rimuovere")
            If MsgBox("Sicuro di voler eliminare la posizione?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Eliminazione posizione incasso") = MsgBoxResult.Yes Then
                Select Case m_tipoDoc
                    Case "IQA"
                        DirectCast(controller, ControllerIncassiQuote).RemoveItem(GridPosizioni.SelectedRows(0).Cells("Utente").Value.idUtente, GridPosizioni.SelectedRows(0).Cells("GetCompetenza").Value.GetDataRange.Start, GridPosizioni.SelectedRows(0).Cells("GetCompetenza").Value.GetDataRange.Finish)
                        txtImporto.Text = DirectCast(controller, ControllerIncassiQuote).Importo
                        GridPosizioni.DataSource = DirectCast(controller, ControllerIncassiQuote).ListaPosizioniUtenti
                    Case "IQP"
                        DirectCast(controller, ControllerIncassiQuotePrevisionali).RemoveItem(GridPosizioni.SelectedRows(0).Cells("Utente").Value.idUtente, GridPosizioni.SelectedRows(0).Cells("GetCompetenza").Value.GetDataRange.Start, GridPosizioni.SelectedRows(0).Cells("GetCompetenza").Value.GetDataRange.Finish)
                        txtImporto.Text = DirectCast(controller, ControllerIncassiQuotePrevisionali).Importo
                        GridPosizioni.DataSource = DirectCast(controller, ControllerIncassiQuotePrevisionali).ListaPosizioniUtenti
                    Case "IQI"
                        DirectCast(controller, ControllerIncassiQuoteInps).RemoveItem(GridPosizioni.SelectedRows(0).Cells("Utente").Value.idUtente, GridPosizioni.SelectedRows(0).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.SelectedRows(0).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.SelectedRows(0).Cells("Prestazione").Value.Id.ToString)
                        txtImporto.Text = DirectCast(controller, ControllerIncassiQuoteInps).Importo
                        GridPosizioni.DataSource = DirectCast(controller, ControllerIncassiQuoteInps).ListaPosizioniUtenti
                    Case "PGR"
                        DirectCast(controller, ControllerPagamentoReferenti).RemoveItem(GridPosizioni.SelectedRows(0).Cells("Utente").Value.idUtente, GridPosizioni.SelectedRows(0).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.SelectedRows(0).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.SelectedRows(0).Cells("DocumentoPadre").Value.Id, GridPosizioni.SelectedRows(0).Cells("TipoDocumento").Value, GridPosizioni.SelectedRows(0).Cells("Prestazione").Value.Id.ToString)
                        txtImporto.Text = DirectCast(controller, ControllerPagamentoReferenti).Importo
                        GridPosizioni.DataSource = New ArrayList
                        GridPosizioni.DataSource = DirectCast(controller, ControllerPagamentoReferenti).ListaPosizioni
                End Select
                GridPosizioni.Refresh()
                Me.StartChangeOperation()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.DoClik
        Try
            Select Case m_tipoDoc
                Case "IQA", "IQP"
                    frm = New FrmItemContabile("Add", controller, m_tipoDoc)
                    frm.ShowDialog()
                    frm.Dispose()
                    DocumentMediatorFactory.GetDocumentMediator(m_tipoDoc).RefeshItemsGrid(Me, controller)

                Case "IQI"
                    Dim frm As New FrmRicercheIQI()
                    frm.ShowDialog()
                    If frm.DialogResult = DialogResult.OK Then
                        Dim cont As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
                        For Each elem As FrmRicercheIQI.Prest In frm.ListaStutturePrestazioni
                            cont.AddItem(elem.IdUtente, "0", elem.IdReferente, "", cont.DataInizioCompetenza, cont.DataFineCompetenza, elem.IdPrestazione)
                        Next
                        Me.GridPosizioni.DataSource = New ArrayList
                        Me.GridPosizioni.DataSource = cont.ListaPosizioniUtenti
                        Me.GridPosizioni.Refresh()
                        Me.StartChangeOperation()
                    End If
                    frm.Dispose()
                Case "PGR"
                    Try
                        Dim frm As New FrmRicrechePGR(DirectCast(controller, ControllerPagamentoReferenti).IdReferente)
                        frm.ShowDialog()
                        If frm.DialogResult = DialogResult.OK Then
                            DirectCast(controller, ControllerPagamentoReferenti).AddItem(frm.GetItemList)
                            Me.GridPosizioni.DataSource = New ArrayList
                            Me.GridPosizioni.DataSource = controller.ListaPosizioni
                            Me.GridPosizioni.Refresh()
                            txtImporto.Text = DirectCast(controller, ControllerPagamentoReferenti).Importo
                            Me.StartChangeOperation()
                        End If
                        frm.Dispose()
                    Catch ex As Exception
                        ErrorHandler.ShowError(ex)
                    End Try
            End Select

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    '****************************************************************
    '****************************************************************
#End Region


#Region "Metodi per la custombar"


    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            Me.Navigate(Me.m_IdShowedObject, True)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try

            Dim h As New FinancialDocumentPrintHelper
            h.PrintDocument(Me.txtId.Text, m_tipoDoc)

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub


    <Secure(Area:="Documenti", Alias:="Aggiornamento", Macroarea:="Amministrazione")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Documenti", Alias:="Cancellazione", Macroarea:="Amministrazione")> _
     Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub
    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("Il documento sarà eliminato solo se nel sistema non ci sono altri elementi che si riferiscono al documento. Sicuro di vvoler eliminare il documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                controller.Delete()
                MasterControl.Instance.GoPrevious()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            Me.NavigateWithoutHistoryTo(ApplicationController.GetNewDocumentCommand(m_tipoDoc))
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            StartSaveOperation()
            Me.Refresh()
            ' Navigate()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
#End Region


    'Public Overrides Sub ReLoadProperties()
    '   MyBase.ReLoadProperties()
    'End Sub

    Private Sub lblReferente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReferente.DoubleClick
        Try
            Me.Navigate(CInt(Me.txtReferente.Text), "ViewReferente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lblDescrizioneAzienda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescrizioneAzienda.DoubleClick
        Try
            If Me.m_tipoDoc = "IQI" Then
                Me.Navigate(1, "ViewInps")
                Exit Sub
            End If
            If Me.m_tipoDoc = "IQA" Then
                If DirectCast(controller, ControllerIncassiQuote).IsForSettoreEdile Then
                    Me.Navigate(CInt(DirectCast(controller, ControllerIncassiQuote).IdSoggettoEsecutore), "ViewEnte")
                Else
                    Me.Navigate(CInt(DirectCast(controller, ControllerIncassiQuote).IdSoggettoEsecutore), "ViewAzienda")
                End If
            End If

            If Me.m_tipoDoc = "IQP" Then
                If DirectCast(controller, ControllerIncassiQuotePrevisionali).IsForSettoreEdile Then
                    Me.Navigate(CInt(DirectCast(controller, ControllerIncassiQuotePrevisionali).IdSoggettoEsecutore), "ViewEnte")
                Else
                    Me.Navigate(CInt(DirectCast(controller, ControllerIncassiQuotePrevisionali).IdSoggettoEsecutore), "ViewAzienda")
                End If
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub GridPosizioni_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridPosizioni.DataError
        '  e.ThrowException = False
    End Sub

    Private Sub lblDescrUt_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescrUt.DoubleClick
        Try
            Me.Navigate(CInt(DirectCast(controller, ControllerIncassiQuoteVertenza).IdUtente), "ViewUtente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub lblVert_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVert.DoubleClick
        Try
            Dim map As New Hashtable
            map.Add("Id", Me.txtVert.Text)
            NavigateTo("ViewVertenza", map)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub


    Private Sub SpecialButton1_DoClik(Sender As System.Object, e As System.EventArgs) Handles SpecialButton1.DoClik
        Try
            SearchAndShowResult()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub NavigateToReport()
        Dim map As New Hashtable
        map.Add("ReportingService", ControllerIQ)
        NavigateTo("ViewReportIncassiQuote", map)
    End Sub

    Private Sub SetSearchConditions()


        Dim pgr As Boolean = False

        If txtTipo.Text = "IQA" Then
            ControllerIQ.IsIQAIncluded(True)
        ElseIf txtTipo.Text = "IQI" Then
            ControllerIQ.IsIQIIncluded(True)
        ElseIf txtTipo.Text = "IQV" Then
            ControllerIQ.IsIQVIncluded(True)
        ElseIf txtTipo.Text = "IQP" Then
            ControllerIQ.IsIQPIncluded(True)
        Else

            pgr = True
        End If

        If Not pgr Then
            ControllerIQ.SetDocumento(Me.m_IdShowedObject)
        Else
            ControllerIQ.SetDocumentoRistorno(Me.m_IdShowedObject)
        End If


    End Sub



    Private Sub SearchAndShowResult()
        Try




            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)

            'Dim start As DateTime = Now
            'System.Diagnostics.Debug.WriteLine("Inizio ricerca a " & start.ToString)
            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop

            System.Windows.Forms.Application.DoEvents()

            If SearchList.Count = 0 Then
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            Else

                NavigateToReport()

            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try
    End Sub


    Private Sub FillSearchList()
        SearchList = ControllerIQ.Search
    End Sub





End Class