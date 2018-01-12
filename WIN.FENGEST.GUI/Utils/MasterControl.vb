Imports WIN.SECURITY
Imports WIN.SECURITY.Attributes
Imports System.Windows
Imports WIN.SECURITY.Exceptions
Imports WIN.GUI.UTILITY
Imports System

<SecureContext()> _
Public Class MasterControl
    Private Shared m_Instance As MasterControl
    Private m_Current As BrowserControl
    Private m_Container As System.Windows.Forms.SplitterPanel
    Private m_OpenForm As String
    Friend WithEvents docMenu As System.Windows.Forms.ContextMenuStrip
    Dim selectedNode As String = ""
    Dim ImList As System.Windows.Forms.ImageList

    Public ReadOnly Property Current() As BrowserControl
        Get
            Return m_Current
        End Get
    End Property

    Public WriteOnly Property OpenForm() As String
        Set(ByVal value As String)
            m_OpenForm = value
        End Set
    End Property
    Shared Function Instance() As MasterControl
        If m_Instance Is Nothing Then
            m_Instance = New MasterControl
        End If
        Return m_Instance
    End Function

    Public Sub AddControl(ByVal Control As BrowserControl)
        If m_Container.Controls.Count > 0 Then
            m_Container.Controls(0).Dispose()
            m_Container.Controls.Clear()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End If
        m_Container.Controls.Add(Control)
        m_Current = Control
    End Sub
    Public Sub SetSizeContainedControl(ByVal Control As BrowserControl)
        Control.Location = New Point(0, 0)
        Control.Size = New Size(m_Container.Size.Width - 10, m_Container.Size.Height - 5)

    End Sub

    Private Sub MasterControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'creo l'imagelist
        Me.ImList = New System.Windows.Forms.ImageList
        ImList.ColorDepth = Windows.Forms.ColorDepth.Depth32Bit
        ImList.ImageSize = New Size(16, 16)
        ImList.Images.Add(My.Resources.logo_feneal_gru16)
        ImList.Images.Add(My.Resources.CreatePeople2)
        ImList.Images.Add(My.Resources.msenv_dll__12_)
        ImList.Images.Add(My.Resources.searchPeoplePaint)
        ImList.Images.Add(My.Resources.Aziende2)
        ImList.Images.Add(My.Resources.Aziende)
        ImList.Images.Add(My.Resources.NewReferente)
        ImList.Images.Add(My.Resources.Referente)
        ImList.Images.Add(My.Resources.Attivita)
        ImList.Images.Add(My.Resources.Aziende1)
        ImList.Images.Add(My.Resources.Certificato)
        ImList.Images.Add(My.Resources.IncassoQuote)
        ImList.Images.Add(My.Resources.Spunte)
        ImList.Images.Add(My.Resources.Report)
        ImList.Images.Add(My.Resources.wmp_dll__12_)
        ImList.Images.Add(My.Resources.sapi_cpl__5_)
        ImList.Images.Add(My.Resources.hxds_dll__10_)
        ImList.Images.Add(My.Resources.createPeople4)
        ImList.Images.Add(My.Resources.createPeople3)
        ImList.Images.Add(My.Resources.Nuovenote)
        ImList.Images.Add(My.Resources.Note)
        ImList.Images.Add(My.Resources.Vertenza)
        ImList.Images.Add(My.Resources.VisVertenza)
        ImList.Images.Add(My.Resources.Control_ColorDialogPaint)
        ImList.Images.Add(My.Resources.Attività)
        ImList.Images.Add(My.Resources.ActualSizeHS)
        ImList.Images.Add(My.Resources.importIqa)
        ImList.Images.Add(My.Resources.wgawizard_dll)
        ImList.Images.Add(My.Resources.OrganizerHS)
        ImList.Images.Add(My.Resources.RadialChartHS)
        ImList.Images.Add(My.Resources.OpenFolderPaint)
        ImList.Images.Add(My.Resources.Folder)
        ImList.Images.Add(My.Resources.create_16x16)
        ImList.Images.Add(My.Resources.show_16x16)
        ImList.Images.Add(My.Resources.report_16x16)
        'creo il contextMenistrip
        docMenu = New System.Windows.Forms.ContextMenuStrip()
        Dim openLabel As New System.Windows.Forms.ToolStripMenuItem()
        openLabel.Text = "Apri in un'altra finestra"
        docMenu.Items.AddRange(New System.Windows.Forms.ToolStripMenuItem() _
            {openLabel})

        m_Container = Me.SplitContainer1.Panel2
        Me.Panel2.Visible = False

        'se voglio aprire l'applicazione con diverse opzion è 
        'qui che posso agire
        TreeView1.Font = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TreeView1.Location = New System.Drawing.Point(0, SplitContainer1.Location.Y + Panel1.Height)
        TreeView1.Width = SplitContainer1.Panel1.Width - 1
        TreeView1.Height = ControlStackView1.Location.Y - TreeView1.Location.Y
        TreeView1.ImageList = ImList

        OpenSelectedForm()
        InizializzaTreeViewSegreteria()

    End Sub
    Public Function GetMdi() As MDIForm
        Return DirectCast(Me.ParentForm, WIN.GUI.APPLICATION.PRESENTATION.MDIForm)
    End Function
    Public Sub GoNxet()
        Try
            If CheckBeforeNavigate() Then
                If Not HistoryOfCommands.Instance.MaxReached Then
                    HistoryOfCommands.Instance.GoNext()
                    Dim command As IOpenCommand = HistoryOfCommands.Instance.GetCurrentCommand
                    command.Execute()
                End If
            End If
        Catch ex As Exception

            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Public Sub GoPrevious()
        Try
            If CheckBeforeNavigate() Then
                HistoryOfCommands.Instance.GoBack()
                Dim command As IOpenCommand = HistoryOfCommands.Instance.GetCurrentCommand
                command.Execute()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    '''' <summary>
    '''' Questo metodo consente di aggiungere un link command allo storico dei comandi
    '''' </summary>
    '''' <param name="Command"></param>
    '''' <remarks></remarks>
    'Public Sub AddToHistory(ByVal Command As IOpenCommand)
    '   Try
    '      Dim parent As MDIForm = DirectCast(Me.ParentForm, MDIForm)
    '      parent.AddCommandToHistory(Command)
    '   Catch ex As Exception
    '      Throw New Exception(ex.Message)
    '   End Try

    'End Sub
    Public ReadOnly Property ContainerControl() As Windows.Forms.SplitterPanel
        Get
            Return m_Container
        End Get
    End Property
    Public Sub OpenSelectedForm()
        Try
            If m_OpenForm <> "" Then
                MyBase.NavigateTo(m_OpenForm)
                MasterControl.Instance.ParentForm.Text = "FenealGest"
            Else
                MyBase.NavigateTo("Home")
                'MasterControl.Instance.ParentForm.Text = "Feneal home page"
            End If
        Catch ex As Exception
            MyBase.NavigateTo("Home")
            MasterControl.Instance.ParentForm.Text = "FenealGest home page"
        End Try

    End Sub
    Private Sub InizializzaTreeViewIncontri()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()

        TreeView1.Nodes.Add("Incontri", "Incontri", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)




        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        'TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub

    Private Sub InizializzaTreeViewPrestazioni()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()

        TreeView1.Nodes.Add("Utenti", "Utenti", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes.Add("CreateUtente", "Crea anagrafica utente", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("ViewUtente", "Visualizza anagrafica utente", 33, 33)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu





        TreeView1.Nodes.Add("Prestazioni", "Prestazioni", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(1).Nodes.Add("CreatePrestazione", "Crea prestazione", 32, 32)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewPrestazione", "Visualizza prestazioni", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("Referenti", "Collaboratori", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(2).Nodes.Add("CreateReferente", "Crea anagrafica collaboratore comunale", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewReferente", "Visualizza anagrafica collaboratore comunale", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("CreateAvvocato", "Crea anagrafica avvocato", 32, 32)
        TreeView1.Nodes(2).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewAvvocato", "Visualizza anagrafica avocato", 33, 33)
        TreeView1.Nodes(2).Nodes(3).ContextMenuStrip = docMenu







        TreeView1.Nodes.Add("Reports", "Reportistica", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)


        TreeView1.Nodes(3).Nodes.Add("ViewReportPrestazioni", "Report prestazioni", 33, 33)
        TreeView1.Nodes(3).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(3).Nodes.Add("ViewReport", "Report incassi quote", 33, 33)
        TreeView1.Nodes(3).Nodes(1).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("SetUp", "Set Up", 30, 30)
        node = TreeView1.Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(4).Nodes.Add("ViewTipoPrestazioni", "Visualizza tipi prestazioni", 33, 33)
        TreeView1.Nodes(4).Nodes(0).ContextMenuStrip = docMenu


        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)


        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        'TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub

    Private Sub InizializzaTreeViewVertenze()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()

        TreeView1.Nodes.Add("Utenti", "Utenti", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes.Add("CreateUtente", "Crea anagrafica utente", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("ViewUtente", "Visualizza anagrafica utente", 33, 33)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("Vertenze", "Vertenze", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(1).Nodes.Add("CreateVertenze", "Crea vertenza utente", 32, 32)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewVertenze", "Visualizza vertenza utente", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("Referenti", "Collaboratori", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(2).Nodes.Add("CreateReferente", "Crea anagrafica collaboratore comunale", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewReferente", "Visualizza anagrafica collaboratore comunale", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("CreateAvvocato", "Crea anagrafica avvocato", 32, 32)
        TreeView1.Nodes(2).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewAvvocato", "Visualizza anagrafica avocato", 33, 33)
        TreeView1.Nodes(2).Nodes(3).ContextMenuStrip = docMenu





        TreeView1.Nodes.Add("Reports", "Reportistica", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)


        TreeView1.Nodes(3).Nodes.Add("ViewReportVertenze", "Report vertenze", 33, 33)
        TreeView1.Nodes(3).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(3).Nodes.Add("ViewReport", "Report incassi quote", 33, 33)
        TreeView1.Nodes(3).Nodes(1).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("SetUp", "Set Up", 30, 30)
        node = TreeView1.Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(4).Nodes.Add("ViewIstituti", "Visualizza istituti contrattuali", 33, 33)
        TreeView1.Nodes(4).Nodes(0).ContextMenuStrip = docMenu


        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)


        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        ' TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub

    Private Sub InizializzaTreeViewComunicazioni()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()

        TreeView1.Nodes.Add("Utenti", "Utenti", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes.Add("CreateUtente", "Crea anagrafica utente", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("ViewUtente", "Visualizza anagrafica utente", 33, 33)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("ListeLavoro", "Liste lavoro", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(1).Nodes.Add("CreaListaLavoro", "Crea lista lavoro utenti", 32, 32)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewListaLavoro", "Visualizza lista lavoro utenti", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("Comunicazioni", "Comunicazioni", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)


        TreeView1.Nodes(2).Nodes.Add("CreateComunicazione", "Crea comunicazione utente", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewComunicazioni", "Visualizza comunicazioni utente", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu
        'TreeView1.Nodes(2).Nodes.Add("CreaComunicazioniMassive", "Comunicazioni utenti massive", 33, 33)
        'TreeView1.Nodes(2).Nodes(2).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("ImportDati", "Importazione dati", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(3).Nodes.Add("ImportLiberi", "Import lavoratori liberi", 26, 26)
        TreeView1.Nodes(3).Nodes(0).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("RptLiberi", "Reportistica", 30, 30)
        node = TreeView1.Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(4).Nodes.Add("ViewRptLiberi", "Report lavoratori liberi", 33, 33)
        TreeView1.Nodes(4).Nodes(0).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("SetUp", "Set Up", 30, 30)
        node = TreeView1.Nodes(5)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(5).Nodes.Add("ViewCausaliComunicazione", "Causali comunicazione", 33, 33)
        TreeView1.Nodes(5).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(5).Nodes.Add("ViewTipiComunicazione", "Tipi comunicazione", 33, 33)
        TreeView1.Nodes(5).Nodes(1).ContextMenuStrip = docMenu


        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)


        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        'TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub


    Private Sub InizializzaTreeViewDeleghe()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()

        TreeView1.Nodes.Add("Utenti", "Utenti", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes.Add("CreateUtente", "Crea anagrafica utente", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("ViewUtente", "Visualizza anagrafica utente", 33, 33)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("Aziende", "Aziende", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(1).Nodes.Add("CreateAzienda", "Crea anagrafica azienda", 32, 32)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewAzienda", "Visualizza anagrafica azienda", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("Deleghe", "Deleghe", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(2).Nodes.Add("CreateDelega", "Crea delega", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewDelega", "Visualizza delega di adesione", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes(2).Nodes.Add("ViewInoltroMassivo", "Inoltro massivo", 33, 33)
        TreeView1.Nodes(2).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewAccettazioneMassiva", "Accettazione massiva", 33, 33)
        TreeView1.Nodes(2).Nodes(3).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("ImportDati", "Importazione dati", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(3).Nodes.Add("ImportDeleghe", "Centro importazioni", 26, 26)

        TreeView1.Nodes.Add("Reports", "Reportistica", 30, 30)
        node = TreeView1.Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)


        TreeView1.Nodes(4).Nodes.Add("ViewReportDeleghe", "Report deleghe", 33, 33)
        TreeView1.Nodes(4).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(4).Nodes.Add("ViewRptLiberi", "Report lavoratori liberi", 33, 33)
        TreeView1.Nodes(4).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(4).Nodes.Add("ViewReportIscritti", "Report iscritti", 33, 33)
        TreeView1.Nodes(4).Nodes(2).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("SetUp", "Set Up", 30, 30)
        node = TreeView1.Nodes(5)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(5).Nodes.Add("ViewCausaliRevoca", "Definizione causali deleghe", 33, 33)
        TreeView1.Nodes(5).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(5).Nodes.Add("ViewReparti", "Definizione reparti aziende", 33, 33)
        TreeView1.Nodes(5).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)



        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        'TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub


    Private Sub InizializzaTreeViewDomandeOfferte()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()

        TreeView1.Nodes.Add("Utenti", "Utenti", 30, 30)

        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)


        TreeView1.Nodes(0).Nodes.Add("CreateUtente", "Crea anagrafica utente", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("ViewUtente", "Visualizza anagrafica utente", 33, 33)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("Aziende", "Aziende", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(1).Nodes.Add("CreateAzienda", "Crea anagrafica azienda", 32, 32)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewAzienda", "Visualizza anagrafica azienda", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("Offerte", "Domande lavoro", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(2).Nodes.Add("CreateOfferta", "Crea domanda di lavoro", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewOfferte", "Visualizza domande di lavoro", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("Proposte", "Proposte lavoro", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(3).Nodes.Add("CreateProposta", "Crea proposta di lavoro", 32, 32)
        TreeView1.Nodes(3).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(3).Nodes.Add("ViewProposte", "Visualizza proposte di lavoro", 33, 33)
        TreeView1.Nodes(3).Nodes(1).ContextMenuStrip = docMenu





        TreeView1.Nodes.Add("Reports", "Ricerche domande offerte lavoro", 30, 30)
        node = TreeView1.Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(4).Nodes.Add("ViewAnalisiDomanda", "Ricerca offerte lavoro", 33, 33)
        TreeView1.Nodes(4).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(4).Nodes.Add("ViewAnalisiOfferta", "Ricerca domande lavoro", 33, 33)
        TreeView1.Nodes(4).Nodes(1).ContextMenuStrip = docMenu




        TreeView1.Nodes.Add("SetUp", "Set Up", 30, 30)
        node = TreeView1.Nodes(5)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(5).Nodes.Add("ViewSkills", "Skills", 33, 33)
        TreeView1.Nodes(5).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(5).Nodes.Add("ViewSkillLevel", "Livelli skill", 33, 33)
        TreeView1.Nodes(5).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)



        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        'TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub


    Private Sub InizializzaTreeViewServizi()

        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Add("Servizi", "Servizi e deleghe", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes.Add("Deleghe di adesione", "Deleghe di adesione", 30, 30)
        node = TreeView1.Nodes(0).Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes(0).Nodes.Add("CreateDelega", "Sottoscrizione nuova delega", 32, 32)
        TreeView1.Nodes(0).Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("ViewDelega", "Visualizza delega di adesione", 33, 33)
        TreeView1.Nodes(0).Nodes(0).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("ViewCausaliRevoca", "Definizione causali deleghe", 33, 33)
        TreeView1.Nodes(0).Nodes(0).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("ViewReparti", "Definizione reparti aziende", 33, 33)
        TreeView1.Nodes(0).Nodes(0).Nodes(3).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("ViewReportIscritti", "Report iscritti", 33, 33)
        TreeView1.Nodes(0).Nodes(0).Nodes(4).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("ImportDeleghe", "Importazione deleghe", 26, 26)


        TreeView1.Nodes(0).Nodes.Add("Prestazioni", "Prestazioni", 30, 30)

        node = TreeView1.Nodes(0).Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes(1).Nodes.Add("CreatePrestazione", "Crea prestazione", 32, 32)
        TreeView1.Nodes(0).Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("ViewPrestazione", "Visualizza prestazioni", 33, 33)
        TreeView1.Nodes(0).Nodes(1).Nodes(1).ContextMenuStrip = docMenu
        'TreeView1.Nodes(0).Nodes(1).Nodes.Add("CreatePrestazioniOfferte", "Crea prestazione utente generica", 19, 19)
        'TreeView1.Nodes(0).Nodes(1).Nodes(2).ContextMenuStrip = docMenu
        'TreeView1.Nodes(0).Nodes(1).Nodes.Add("ViewPrestazioniOfferte", "Visualizza prestazioni utente generiche", 20, 20)
        'TreeView1.Nodes(0).Nodes(1).Nodes(3).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("ViewTipoPrestazioni", "Visualizza tipi prestazioni", 33, 33)
        TreeView1.Nodes(0).Nodes(1).Nodes(2).ContextMenuStrip = docMenu


        TreeView1.Nodes(0).Nodes.Add("Vertenze", "Vertenze", 30, 30)

        node = TreeView1.Nodes(0).Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes(2).Nodes.Add("CreateVertenze", "Crea vertenza utente", 32, 32)
        TreeView1.Nodes(0).Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("ViewVertenze", "Visualizza vertenza utente", 33, 33)
        TreeView1.Nodes(0).Nodes(2).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("ViewIstituti", "Visualizza istituti contrattuali", 33, 33)
        TreeView1.Nodes(0).Nodes(2).Nodes(2).ContextMenuStrip = docMenu

        TreeView1.Nodes(0).Nodes.Add("OfferteLavoro", "Domande/Offerte di lavoro", 30, 30)

        node = TreeView1.Nodes(0).Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)



        TreeView1.Nodes(0).Nodes(3).Nodes.Add("ViewSkills", "Skills", 33, 33)
        TreeView1.Nodes(0).Nodes(3).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("ViewSkillLevel", "Livelli skill", 33, 33)
        TreeView1.Nodes(0).Nodes(3).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("CreateOfferta", "Crea offerta di lavoro", 32, 32)
        TreeView1.Nodes(0).Nodes(3).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("ViewOfferte", "Visualizza offerte di lavoro", 33, 33)
        TreeView1.Nodes(0).Nodes(3).Nodes(3).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("CreateProposta", "Crea proposta di lavoro", 32, 32)
        TreeView1.Nodes(0).Nodes(3).Nodes(4).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("ViewProposte", "Visualizza proposte di lavoro", 33, 33)
        TreeView1.Nodes(0).Nodes(3).Nodes(5).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("ViewAnalisiDomanda", "Analisi domande lavoro", 33, 33)
        TreeView1.Nodes(0).Nodes(3).Nodes(6).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("ViewAnalisiOfferta", "Analisi offerte lavoro", 33, 33)
        TreeView1.Nodes(0).Nodes(3).Nodes(7).ContextMenuStrip = docMenu



        TreeView1.Nodes(0).Nodes.Add("AzioniProselitismo", "Azioni di proselitismo", 30, 30)

        node = TreeView1.Nodes(0).Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes(4).Nodes.Add("ImportLiberi", "Centro importazioni", 26, 26)
        TreeView1.Nodes(0).Nodes(4).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("CreaListaLavoro", "Crea lista lavoro utenti", 32, 32)
        TreeView1.Nodes(0).Nodes(4).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes(0).Nodes(4).Nodes.Add("ViewListaLavoro", "Visualizza lista lavoro utenti", 33, 33)
        TreeView1.Nodes(0).Nodes(4).Nodes(2).ContextMenuStrip = docMenu

        TreeView1.Nodes(0).Nodes(4).Nodes.Add("ViewCausaliComunicazione", "Causali comunicazione", 33, 33)
        TreeView1.Nodes(0).Nodes(4).Nodes(3).ContextMenuStrip = docMenu

        TreeView1.Nodes(0).Nodes(4).Nodes.Add("ViewTipiComunicazione", "Tipi comunicazione", 33, 33)
        TreeView1.Nodes(0).Nodes(4).Nodes(4).ContextMenuStrip = docMenu


        TreeView1.Nodes(0).Nodes(4).Nodes.Add("CreateComunicazione", "Crea comunicazione utente", 32, 32)
        TreeView1.Nodes(0).Nodes(4).Nodes(5).ContextMenuStrip = docMenu

        TreeView1.Nodes(0).Nodes(4).Nodes.Add("ViewComunicazioni", "Visualizza comunicazioni utente", 33, 33)
        TreeView1.Nodes(0).Nodes(4).Nodes(6).ContextMenuStrip = docMenu



        TreeView1.Nodes(0).Nodes(4).Nodes.Add("CreaComunicazioniMassive", "Comunicazioni utenti massive", 32, 32)
        TreeView1.Nodes(0).Nodes(4).Nodes(7).ContextMenuStrip = docMenu

        'TreeView1.Nodes(0).Nodes(4).Nodes.Add("CreaListaLavoro", "Crea lista lavoro utenti", 22, 22)
        'TreeView1.Nodes(0).Nodes(4).Nodes(9).ContextMenuStrip = docMenu









        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
        ' TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub
    Private Sub InizializzaTreeViewFinanza()
        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Add("Financial", "Documenti", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(0).Nodes.Add("CreatePagamento", "Creazione incasso quote associative", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("CreatePagamentoInps", "Creazione incasso quote Inps", 32, 32)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("CreatePagamentoVertenza", "Creazione incasso quota vertenza", 32, 32)
        TreeView1.Nodes(0).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("CreateRistorno", "Creazione ristorno collaboratore comunale", 32, 32)
        TreeView1.Nodes(0).Nodes(3).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("CreatePagamentoPrevisionale", "Creazione incasso quote previsionali", 32, 32)
        TreeView1.Nodes(0).Nodes(4).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("Reports", "Reportistica", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)


        TreeView1.Nodes(1).Nodes.Add("ViewDocumento", "Visualizza documenti", 33, 33)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewReport", "Report incassi quote", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("Referenti", "Collaboratori", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(2).Nodes.Add("CreateReferente", "Crea anagrafica collaboratore comunale", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewReferente", "Visualizza anagrafica collaboratore comunale", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("CreateAvvocato", "Crea anagrafica avvocato", 32, 32)
        TreeView1.Nodes(2).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewAvvocato", "Visualizza anagrafica avocato", 33, 33)
        TreeView1.Nodes(2).Nodes(3).ContextMenuStrip = docMenu


        TreeView1.Nodes.Add("FinancialImports", "Importazione dati", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(3).Nodes.Add("ImportIQA", "Centro importazioni", 26, 26)
        TreeView1.Nodes(3).Nodes(0).ContextMenuStrip = docMenu

        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)


        TreeView1.EndUpdate()
        TreeView1.CollapseAll()
    End Sub
    Private Sub InizializzaTreeViewSegreteria()
        Dim node As System.Windows.Forms.TreeNode
        TreeView1.Nodes.Clear()
        TreeView1.BeginUpdate()
        'TreeView1.Nodes.Add("Segreteria", "Gestione anagrafiche", 0, 0)
        'node = TreeView1.Nodes(0)
        'node.NodeFont = New System.Drawing.Font("Tahoma", 11, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes.Add("Utenti", "Utenti", 30, 30)
        node = TreeView1.Nodes(0)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(0).Nodes.Add("CreateUtente", "Crea anagrafica utente", 32, 32)
        TreeView1.Nodes(0).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(0).Nodes.Add("ViewUtente", "Visualizza anagrafica utente", 33, 33)
        TreeView1.Nodes(0).Nodes(1).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("Aziende", "Aziende", 30, 30)
        node = TreeView1.Nodes(1)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(1).Nodes.Add("CreateAzienda", "Crea anagrafica azienda", 32, 32)
        TreeView1.Nodes(1).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewAzienda", "Visualizza anagrafica azienda", 33, 33)
        TreeView1.Nodes(1).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(1).Nodes.Add("ViewTipoContratto", "Visualizza contratti", 33, 33)
        TreeView1.Nodes(1).Nodes(2).ContextMenuStrip = docMenu






        TreeView1.Nodes.Add("Referenti", "Collaboratori", 30, 30)
        node = TreeView1.Nodes(2)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(2).Nodes.Add("CreateReferente", "Crea anagrafica collaboratore comunale", 32, 32)
        TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewReferente", "Visualizza anagrafica collaboratore comunale", 33, 33)
        TreeView1.Nodes(2).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("CreateAvvocato", "Crea anagrafica avvocato", 32, 32)
        TreeView1.Nodes(2).Nodes(2).ContextMenuStrip = docMenu
        TreeView1.Nodes(2).Nodes.Add("ViewAvvocato", "Visualizza anagrafica avocato", 33, 33)
        TreeView1.Nodes(2).Nodes(3).ContextMenuStrip = docMenu


        TreeView1.Nodes.Add("Enti", "Enti", 30, 30)
        node = TreeView1.Nodes(3)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        TreeView1.Nodes(3).Nodes.Add("ViewEnteCE", "Visualizza anagrafica Cassa Edile", 33, 33)
        TreeView1.Nodes(3).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.Nodes(3).Nodes.Add("ViewEnteEC", "Visualizza anagrafica EdilCassa", 33, 33)
        TreeView1.Nodes(3).Nodes(1).ContextMenuStrip = docMenu
        TreeView1.Nodes(3).Nodes.Add("ViewInps", "Visualizza anagrafica Inps", 33, 33)
        TreeView1.Nodes(3).Nodes(2).ContextMenuStrip = docMenu



        TreeView1.Nodes.Add("SetUp", "Setup", 30, 30)
        node = TreeView1.Nodes(4)
        node.NodeFont = New System.Drawing.Font("Tahoma", 8.25, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        TreeView1.Nodes(4).Nodes.Add("ViewTipoDocumentazione", "Tipi documentazione", 33, 33)
        TreeView1.Nodes(4).Nodes.Add("ViewFondo", "Visualizza fondi", 33, 33)



        TreeView1.Nodes.Add("ViewSegreteria", "Visualizza Segreteria", 33, 33)
        TreeView1.Nodes.Add("ViewCompilaDocumentazione", "Compila documenti", 33, 33)





        'TreeView1.Nodes(4).Nodes(1).ContextMenuStrip = docMenu

        'TreeView1.Nodes.Add("Contratti", "Anagrafiche contratti", 0)
        'TreeView1.Nodes(2).Nodes.Add("ViewTipoContratto", "Visualizza contratti", 10, 10)
        'node = TreeView1.Nodes(2)
        'node.NodeFont = New System.Drawing.Font("Tahoma", 11, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)

        'TreeView1.Nodes(2).Nodes(0).ContextMenuStrip = docMenu
        TreeView1.EndUpdate()
        TreeView1.CollapseAll()

    End Sub
    'Private Sub cmdAziende_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAziende.Click
    '   InizializzaTreeViewAziende()
    'End Sub
    'Private Sub cmdUtenti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUtenti.Click
    '   InizializzaTreeViewUtenti()
    'End Sub
    'Private Sub cmdRassegnaStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRassegnaStampa.Click
    '   TreeView1.Nodes.Clear()
    '   TreeView1.BeginUpdate()
    '   TreeView1.Nodes.Add("GestioneRassegna", "Rassegna stampa")
    '   TreeView1.EndUpdate()
    '   TreeView1.ExpandAll()
    'End Sub



    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        selectedNode = DirectCast(sender, System.Windows.Forms.TreeView).SelectedNode.Name



    End Sub


    Public Overrides Sub PrintControl()
        Try
            m_Current.PrintControl()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Public Overrides Sub UndoControl()
        Try
            m_Current.UndoControl()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Public Overrides Sub StartSaveOperation()
        Try
            m_Current.StartSaveOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Public Sub NewElem()
        Try
            m_Current.StartCreateOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Public Sub GetObjectInfo()
        Try
            m_Current.GetInfo()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Public Sub RemoveElem()
        Try
            m_Current.StartDeleteOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Public Function CheckBeforeNavigate() As Boolean
        If m_Current.State.StateName = "Aggiornamento" Or m_Current.State.StateName = "Creazione" Then
            Dim i As MsgBoxResult = MsgBox("Si desidera salvare i dati?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "FenealGest")
            If i = MsgBoxResult.Yes Then
                m_Current.StartSaveOperation()
            ElseIf i = MsgBoxResult.Cancel Then
                Return False
            End If
        End If
        Return True
    End Function

    Public Function CheckBeforeExitProgram() As MsgBoxResult
        Dim i As MsgBoxResult = MsgBoxResult.No
        If m_Current.State.StateName = "Aggiornamento" Or m_Current.State.StateName = "Creazione" Then
            i = MsgBox("Si desidera salvare i dati prima di chiudere l'applicazione?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "FenealGest")
            If i = MsgBoxResult.Yes Then
                m_Current.StartSaveOperation()
            End If
        End If
        Return i
    End Function

    Private Sub TreeView1_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeCollapse
        CollassaTreeView(e.Node, True)
    End Sub


    Private Sub CollassaTreeView(ByVal Nodo As System.Windows.Forms.TreeNode, ByVal Collassa As Boolean)



        Dim index As Int32
        If Collassa Then
            index = 31
        Else
            index = 30
        End If

        If Nodo IsNot Nothing Then
            Select Case Nodo.Name
                Case "Servizi", "Financial", "Reports", "FinancialImports", "Utenti", "Aziende", "ImportDati", "SetUp", "Deleghe", "Vertenze", "Prestazioni", "Proposte", "Offerte", "Comunicazioni", "ListeLavoro", "Referenti", "Enti", "Incontri"

                    Nodo.SelectedImageIndex = index
                    Nodo.ImageIndex = index


                Case Else
                    '
            End Select
        End If


    End Sub

    Private Sub TreeView1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        CollassaTreeView(e.Node, False)
    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick

        'per prima cosa devo verificare che il controllo figlio non sia nello stato di aggiornamento
        'Nel caso lo fosse richiedo il salvataggio dei dati.
        Try
            'If DirectCast(Me.ParentForm, MDIForm).IsThreadBusy Then
            '   MsgBox("Attendere qualche secondo affinchè l'applicazione inizializzi le variabili d'ambiente.", MsgBoxStyle.Information, "Inizializzazione in corso...")
            '   Exit Sub
            'End If

            If CheckBeforeNavigate() Then
                If sender.selectednode IsNot Nothing Then


                    Select Case sender.SelectedNode.Name
                        Case "CreatePagamento"
                            Me.NavigateWithoutHistoryTo("OpenNewPagamento")
                        Case "CreatePagamentoPrevisionale"
                            Me.NavigateWithoutHistoryTo("OpenNewPagamentoPrevisionale")
                        Case "CreatePagamentoInps"
                            Me.NavigateWithoutHistoryTo("OpenNewPagamentoInps")
                        Case "CreatePagamentoVertenza"
                            Me.NavigateWithoutHistoryTo("OpenNewPagamentoVertenza")
                        Case "CreateRistorno"
                            Me.NavigateWithoutHistoryTo("OpenNewRistorno")
                        Case "ViewDocumento"
                            Me.NavigateTo("OpenDocumento")
                        Case "ViewConto"
                            Me.NavigateTo("OpenAnagraficaConto")
                        Case "CreateConto"
                            Me.NavigateWithoutHistoryTo("OpenNewAnagraficaConto")
                        Case "ViewUtente"
                            Me.NavigateTo("OpenAnagraficaUtente")
                        Case "CreateUtente"
                            Me.NavigateWithoutHistoryTo("OpenNewAnagraficaUtente")
                        Case "ViewReferente"
                            Me.NavigateTo("OpenAnagraficaReferente")
                        Case "CreateReferente"
                            Me.NavigateWithoutHistoryTo("OpenNewAnagraficaReferente")
                        Case "ViewAzienda"
                            Me.NavigateTo("OpenAnagraficaAzienda")
                        Case "CreateAzienda"
                            Me.NavigateWithoutHistoryTo("OpenNewAnagraficaAzienda")
                        Case "CreateDelega"
                            Me.NavigateWithoutHistoryTo("OpenNewDelega")
                        Case "ViewDelega"
                            Me.NavigateTo("OpenDeleghe")
                        Case "ViewTipoPrestazioni"
                            Me.NavigateTo("OpenTipoPrestazione")
                        Case "ViewInps"
                            Me.NavigateTo("OpenInps")
                        Case "ViewCausaliRevoca"
                            Me.NavigateTo("OpenCausaliRevoca")
                        Case "ViewTipoContratto"
                            Me.NavigateTo("OpenTipoContratto")
                        Case "ViewSettoreEd"
                            Dim hash As New Hashtable
                            hash.Add("Id", 1)
                            Me.NavigateTo("OpenSettore", hash)
                        Case "ViewSettoreIf"
                            Dim hash As New Hashtable
                            hash.Add("Id", 2)
                            Me.NavigateTo("OpenSettore", hash)
                        Case "ViewEnteCE"
                            Dim hash As New Hashtable
                            hash.Add("Id", 1)
                            Me.NavigateTo("OpenEnte", hash)
                        Case "ViewEnteEC"
                            Dim hash As New Hashtable
                            hash.Add("Id", 2)
                            Me.NavigateTo("OpenEnte", hash)
                        Case "ViewPrestazione"
                            Me.NavigateTo("OpenPrestazione")
                        Case "CreatePrestazione"
                            Me.NavigateWithoutHistoryTo("OpenNewPrestazione")
                        Case "ViewVertenze"
                            Me.NavigateTo("OpenVertenze")
                        Case "CreateVertenze"
                            Me.NavigateWithoutHistoryTo("OpenNewVertenza")
                        Case "ViewIstituti"
                            Me.NavigateTo("OpenIstituti")
                        Case "ViewReparti"
                            Me.NavigateTo("OpenReparti")
                        Case "ViewReport"
                            Me.NavigateTo("OpenPrepareRptIQ")
                        Case "ViewReportIscritti"
                            Me.NavigateTo("OpenPrepareRptIscrittiDTO")
                        Case "ImportIQA"

                            GoToImportCenter()
                        Case "ImportDeleghe"
                            GoToImportCenter()

                        Case "ImportLiberi"

                            GoToImportCenter()
                        Case "ViewSkills"
                            Me.NavigateTo("OpenSkills")
                        Case "ViewSkillLevel"
                            Me.NavigateTo("OpenLivelloSkills")
                        Case "ViewOfferte"
                            Me.NavigateTo("OpenOfferte")
                        Case "CreateOfferta"
                            Me.NavigateWithoutHistoryTo("OpenNewOfferta")
                        Case "ViewProposte"
                            Me.NavigateTo("OpenProposte")
                        Case "CreateProposta"
                            Me.NavigateWithoutHistoryTo("OpenNewProposta")
                        Case "ViewAnalisiDomanda"
                            Me.NavigateTo("OpenAnalisiDomanda")
                        Case "ViewAnalisiOfferta"
                            Me.NavigateTo("OpenAnalisiOfferta")
                        Case "ViewCausaliComunicazione"
                            Me.NavigateTo("OpenCausaliComunicazione")
                        Case "ViewTipiComunicazione"
                            Me.NavigateTo("OpenTipiComunicazione")
                        Case "ViewComunicazioni"
                            Me.NavigateTo("OpenComunicazioni")
                        Case "CreateComunicazione"
                            Me.NavigateWithoutHistoryTo("OpenNewComunicazione")
                        Case "ViewListaLavoro"
                            Me.NavigateTo("OpenListaLavoro")
                        Case "CreaListaLavoro"
                            Me.NavigateWithoutHistoryTo("OpenNewListaLavoro")
                        Case "CreaComunicazioniMassive"
                            Me.NavigateWithoutHistoryTo("OpenComunicazioneMassiva")
                        Case "ViewRptLiberi"
                            Me.NavigateTo("OpenPrepareRptLiberiDTO")
                        Case "ViewReportDeleghe"
                            Me.NavigateTo("OpenPrepareRptDeleghe")
                        Case "ViewReportPrestazioni"
                            Me.NavigateTo("OpenPrepareRptPrestazioni")
                        Case "ViewReportVertenze"
                            Me.NavigateTo("OpenPrepareRptVertenze")

                        Case "ViewInoltroMassivo"
                            Me.NavigateTo("OpenInoltroMassivo")
                        Case "ViewAccettazioneMassiva"
                            Me.NavigateTo("OpenAccettazioneMassiva")
                        Case "ViewFondo"
                            Me.NavigateTo("OpenFondo")
                        Case "ViewSegreteria"
                            Me.NavigateTo("OpenSegreteria")
                        Case "ViewTipoDocumentazione"
                            Me.NavigateTo("OpenTipoDocumentazione")
                        Case "ViewCompilaDocumentazione"
                            'Me.NavigateTo("OpenCompilazioneModelli")

                            ' NavigateTo("ViewCompilazioneModelli")
                            Dim frm As New FrmCompilazioneModello()
                            frm.Show()

                        Case "ViewAvvocato"
                            Me.NavigateTo("OpenAnagraficaAvvocato")
                        Case "CreateAvvocato"
                            Me.NavigateWithoutHistoryTo("OpenNewAnagraficaAvvocato")
                    End Select
                    'TreeView1.CollapseAll()
                    'TreeView1.ExpandAll()
                End If
            End If

        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try


    End Sub

    '<Secure(Area:="Import", Alias:="Deleghe", Macroarea:="Importazione dati")> _
    'Public Sub GoToImportDeleghe()
    '    SecurityManager.Instance.Check()
    '    Dim path As String = GetAppImportDeleghePathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password})
    '    Shell(path, AppWinStyle.NormalFocus)
    'End Sub


    <Secure(Area:="Import", Alias:="Centro importazioni", Macroarea:="Importazione dati")> _
    Public Sub GoToImportCenter()
        SecurityManager.Instance.Check()
        Dim path As String = GetAppImportCenterPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password})
        Shell(path, AppWinStyle.NormalFocus)
    End Sub






    <Secure(Area:="Strumenti", Alias:="Utilty", Macroarea:="Generatore modelli")> _
    Public Sub GoToGeneratoreModelli()
        SecurityManager.Instance.Check()
        Dim con As New ControllerSegreteria
        con.LoadById("1")

        Dim path As String = GetGeneratoreModelliPathWithParameter(New String() {con.CartellaModelli})
        Shell(path, AppWinStyle.NormalFocus)
    End Sub





    Public Overloads Function GetGeneratoreModelliPathWithParameter(ByVal Parameter() As String) As String
        Dim path As String = My.Application.Info.DirectoryPath & "\TemplateGenerator\TemplateGenerator.GUI.exe" '& FileShortName
        If Parameter.Length > 0 Then
            For argNum As Integer = 0 To UBound(Parameter, 1)
                path = path & " " & Parameter(argNum)
            Next argNum
        End If
        Return path
    End Function



    '<Secure(Area:="Import", Alias:="Incassi quote associative", Macroarea:="Importazione dati")> _
    'Public Sub GoToImportIQA()
    '    SecurityManager.Instance.Check()
    '    Dim path As String = GetAppImportIQAPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password})
    '    Shell(path, AppWinStyle.NormalFocus)
    'End Sub
    '<Secure(Area:="Import", Alias:="Lavoratori liberi", Macroarea:="Importazione dati")> _
    'Public Sub GoToImportLiberi()
    '    SecurityManager.Instance.Check()
    '    Dim path As String = GetAppImportLiberiPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password})
    '    Shell(path, AppWinStyle.NormalFocus)
    'End Sub

    Public Overloads Function GetAppPathWithParameter(ByVal Parameter() As String) As String
        Dim path As String = My.Application.Info.DirectoryPath & "\WIN.FENGEST.GUI.exe"
        If Parameter.Length > 0 Then
            For argNum As Integer = 0 To UBound(Parameter, 1)
                path = path & " " & Parameter(argNum)
            Next argNum
        End If
        Return path
    End Function

    Public Overloads Function GetAppImportCenterPathWithParameter(ByVal Parameter() As String) As String
        Dim path As String = My.Application.Info.DirectoryPath & "\WIN.FENGEST.IMPORT.GUI.exe" '& FileShortName
        If Parameter.Length > 0 Then
            For argNum As Integer = 0 To UBound(Parameter, 1)
                path = path & " " & Parameter(argNum)
            Next argNum
        End If
        Return path
    End Function
    'Public Overloads Function GetAppImportIQAPathWithParameter(ByVal Parameter() As String) As String
    '    Dim path As String = My.Application.Info.DirectoryPath & "\WIN.FENGEST_IMPORT_IQA.GUI.exe" '& FileShortName
    '    If Parameter.Length > 0 Then
    '        For argNum As Integer = 0 To UBound(Parameter, 1)
    '            path = path & " " & Parameter(argNum)
    '        Next argNum
    '    End If
    '    Return path
    'End Function

    'Public Overloads Function GetAppImportLiberiPathWithParameter(ByVal Parameter() As String) As String
    '    Dim path As String = My.Application.Info.DirectoryPath & "\WIN.FENGEST_IMPORT_LIBERI.GUI.exe" '& FileShortName
    '    If Parameter.Length > 0 Then
    '        For argNum As Integer = 0 To UBound(Parameter, 1)
    '            path = path & " " & Parameter(argNum)
    '        Next argNum
    '    End If
    '    Return path
    'End Function



    'Private Sub ApriInUnaltraFinestraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriInUnaltraFinestraToolStripMenuItem.Click
    '   '
    'End Sub

    Private Sub docMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles docMenu.Click
        Select Case selectedNode
            Case "CreatePagamento"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewPagamento"}), AppWinStyle.NormalFocus)
            Case "CreateRistorno"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewRistorno"}), AppWinStyle.NormalFocus)
            Case "ViewDocumento"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenDocumento"}), AppWinStyle.NormalFocus)
            Case "ViewConto"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenAnagraficaConto"}), AppWinStyle.NormalFocus)
            Case "CreateConto"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewAnagraficaConto"}), AppWinStyle.NormalFocus)
            Case "ViewUtente"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenAnagraficaUtente"}), AppWinStyle.NormalFocus)
            Case "CreateUtente"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewAnagraficaUtente"}), AppWinStyle.NormalFocus)
            Case "ViewReferente"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenAnagraficaReferente"}), AppWinStyle.NormalFocus)
            Case "CreateReferente"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewAnagraficaReferente"}), AppWinStyle.NormalFocus)
            Case "ViewAzienda"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenAnagraficaAzienda"}), AppWinStyle.NormalFocus)
            Case "CreateAzienda"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewAnagraficaAzienda"}), AppWinStyle.NormalFocus)
            Case "CreateDelega"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenNewDelega"}), AppWinStyle.NormalFocus)
            Case "ViewInps"
                Shell(GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password, "OpenInps"}), AppWinStyle.NormalFocus)
            Case "ViewSaldo"
                '"OpenSaldo"
            Case "ViewCausaliRevoca"
                '"OpenCausaliRevoca"
            Case "ViewTipoContratto"
                '"OpenTipoContratto"
            Case "ViewSettoreEd"
                'Dim hash As New Hashtable
                'hash.Add("Id", 1)
                '"OpenSettore", hash
            Case "ViewSettoreIf"
                'Dim hash As New Hashtable
                'hash.Add("Id", 2)
                '"OpenSettore", hash
            Case "ViewEnteCE"
                'Dim hash As New Hashtable
                'hash.Add("Id", 1)
                '"OpenEnte", hash
            Case "ViewEnteEC"
                'Dim hash As New Hashtable
                'hash.Add("Id", 2)
                '"OpenEnte", hash
        End Select
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SplitContainer1.Panel1Collapsed = True
        ResizeContainer()
    End Sub

    Public Sub ResizeContainer()
        If m_Container IsNot Nothing Then
            If m_Container.Controls.Count > 0 Then
                Dim Control As BrowserControl = m_Container.Controls.Item(0)
                Control.Location = New Point(0, 0)
                Control.Size = New Size(m_Container.Size.Width - 10, m_Container.Size.Height - 5)
            End If
        End If
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        Static FirstMoving As Boolean = True
        Try
            TreeView1.Width = sender.Panel1.Width - 1
            Me.ResizeContainer()

            If FirstMoving Then
                FirstMoving = False
                Me.SplitContainer1.SplitterDistance = My.Settings.LarghezzaPanel
            Else
                My.Settings.LarghezzaPanel = Me.SplitContainer1.SplitterDistance
                My.Settings.Save()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub MasterControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        TreeView1.Height = ControlStackView1.Location.Y - TreeView1.Location.Y
        If m_Container IsNot Nothing Then
            If m_Container.Controls.Count > 0 Then
                Dim Control As BrowserControl = m_Container.Controls.Item(0)
                Control.Location = New Point(0, 0)
                Control.Size = New Size(m_Container.Size.Width - 10, m_Container.Size.Height - 5)
            End If
        End If

    End Sub




    Private Sub MasterControl_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        TreeView1.Height = ControlStackView1.Location.Y - TreeView1.Location.Y
    End Sub

    Private Sub ControlStackView1_DoClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ControlStackView1.DoClick
        Select Case e.ClickedItem.Text
            Case " Appuntamenti E Incontri"
                InizializzaTreeViewIncontri()
            Case " Comunicazioni"
                InizializzaTreeViewComunicazioni()
            Case " Deleghe"
                InizializzaTreeViewDeleghe()
            Case " Domande Offerte Lavoro"
                InizializzaTreeViewDomandeOfferte()
            Case " Amministrazione"
                InizializzaTreeViewFinanza()
            Case " Prestazioni"
                InizializzaTreeViewPrestazioni()
            Case " Vertenze"
                InizializzaTreeViewVertenze()
            Case " Segreteria"
                InizializzaTreeViewSegreteria()

        End Select

    End Sub


    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As System.Drawing.Graphics = e.Graphics
        Dim rect As System.Drawing.Rectangle = DirectCast(sender, System.Windows.Forms.Panel).ClientRectangle


        'Dim gradientColor1 As System.Drawing.Color = System.Drawing.Color.FromArgb(89, 135, 214)
        'Dim gradientColor2 As System.Drawing.Color = System.Drawing.Color.FromArgb(12, 64, 154)
        Dim gradientColor1 As System.Drawing.Color = System.Drawing.SystemColors.GradientInactiveCaption
        Dim gradientColor2 As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight

        Dim grb As New System.Drawing.Drawing2D.LinearGradientBrush(rect, gradientColor1, gradientColor2, Drawing.Drawing2D.LinearGradientMode.Vertical)
        g.FillRectangle(grb, rect)
        grb.Dispose()
        g.Dispose()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        'Dim g As System.Drawing.Graphics = e.Graphics
        'Dim rect As System.Drawing.Rectangle = DirectCast(sender, System.Windows.Forms.Panel).ClientRectangle


        'Dim gradientColor1 As System.Drawing.Color = System.Drawing.Color.FromArgb(89, 135, 214)
        'Dim gradientColor2 As System.Drawing.Color = System.Drawing.Color.FromArgb(12, 64, 154)


        'Dim grb As New System.Drawing.Drawing2D.LinearGradientBrush(rect, gradientColor1, gradientColor2, Drawing.Drawing2D.LinearGradientMode.Vertical)
        'g.FillRectangle(grb, rect)
        'grb.Dispose()
        'g.Dispose()
    End Sub








    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim fromColor As System.Drawing.Color = System.Drawing.Color.White
        Dim toColor As System.Drawing.Color = System.Drawing.Color.FromArgb(237, 237, 237)

        Dim containerRectangle As RectangleF = Me.Panel1.ClientRectangle
        Dim rectangleBrush As New System.Drawing.Drawing2D.LinearGradientBrush(containerRectangle, fromColor, toColor, Drawing.Drawing2D.LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(rectangleBrush, containerRectangle)
    End Sub
End Class
