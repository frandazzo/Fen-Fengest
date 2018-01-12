Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports System.IO

<SecureContext()> _
Public Class MDIForm

    Public openFromCardReader As Boolean = False
    Public idUtente As Int32 = -1



    Private Sub MDIForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TargetPanel.Left = 0
        Me.TargetPanel.Top = Me.MenuStrip.Height + Me.ToolStrip.Height
        Me.TargetPanel.Width = Me.Width
        Me.TargetPanel.Height = Me.Height - (Me.MenuStrip.Height + Me.ToolStrip.Height + (Me.Height - Me.StatusStrip.Top))
        '

        Me.TargetPanel.Controls.Add(MasterControl.Instance)
        MasterControl.Instance.Visible = True
        MasterControl.Instance.Dock = DockStyle.Fill
        'Me.WindowState = FormWindowState.Maximized
        Me.Width = 1000
        Me.Height = 600


        Me.ToolStripProgressBar1.Margin = New System.Windows.Forms.Padding(Me.Width - Me.ToolStripProgressBar1.Width - 20, 3, 1, 3)

        Me.ToolStripCoonectedUserLabel2.Text = "Utente connesso: " & SecurityManager.Instance.CurrentUser.Username

        WindowState = FormWindowState.Maximized

        If SecurityManager.Instance.CurrentUser.Username = "Admin" Then
            CambiaPasswordMenuItem.Visible = True
        Else
            CambiaPasswordMenuItem.Visible = False

        End If

        Dim controllerSEg As New ControllerSegreteria
        Try
            controllerSEg.LoadById("1")

            Dim seg As Segreteria = controllerSEg.Current

            Dim p As Provincia = seg.IndirizzoSedeLegale.Provincia

            Dim reg As Regione = GeoLocationFacade.Instance.GetGeoHandler.GetRegioneById(seg.IndirizzoSedeLegale.Provincia.IdRegione)

            Dim asy As New AsyncNotifier
            asy.NotifyUsage(seg.IndirizzoSedeLegale.Provincia.Descrizione, reg.Descrizione)

        Catch ex As Exception

        End Try


        If openFromCardReader Then
            If idUtente > 0 Then
                'apro l'anagrafica all'id selezionato
                Dim h As New Hashtable
                h.Add("Id", idUtente)
                MasterControl.Instance.NavigateTo("OpenAnagraficaUtente", h)
                openFromCardReader = False
                idUtente = -1
            End If
        End If
        'Me.BackgroundWorker1.RunWorkerAsync()
    End Sub




    Private Sub MDIForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.TargetPanel.Left = 0
        Me.TargetPanel.Top = Me.MenuStrip.Height + Me.ToolStrip.Height
        Me.TargetPanel.Width = Me.Width
        Me.TargetPanel.Height = Me.Height - (Me.MenuStrip.Height + Me.ToolStrip.Height + (Me.Height - Me.StatusStrip.Top))
        Me.ToolStripProgressBar1.Margin = New System.Windows.Forms.Padding(Me.Width - Me.ToolStripProgressBar1.Width - 20, 3, 1, 3)
    End Sub

    Private Sub GoHome()
        If MasterControl.Instance.CheckBeforeNavigate() Then
            MasterControl.Instance.OpenSelectedForm()
        End If
    End Sub
    Private Sub HomeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripButton.Click
        GoHome()
    End Sub

    Private Sub GotoPrev()
        Try
            MasterControl.Instance.GoPrevious()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub BackToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripButton.Click
        GotoPrev()
    End Sub

    Private Sub GotoNest()
        Try
            MasterControl.Instance.GoNxet()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ForwardToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripButton.Click
        GotoNest()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        MasterControl.Instance.StartSaveOperation()
    End Sub


    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterControl.Instance.StartChangeOperation()
    End Sub

    Private Sub NewProgramInstance()
        Shell(MasterControl.Instance.GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password}), AppWinStyle.NormalFocus)
    End Sub

    Private Sub NewInsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewInsToolStripButton.Click
        NewProgramInstance()
    End Sub

    Private Sub AlberoFunzioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlberoFunzioniToolStripMenuItem.Click
        If AlberoFunzioniToolStripMenuItem.Checked Then
            MasterControl.Instance.SplitContainer1.Panel1Collapsed = False
        Else
            MasterControl.Instance.SplitContainer1.Panel1Collapsed = True
        End If
        MasterControl.Instance.ResizeContainer()

    End Sub

    Private Sub ViewMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMenu.Click
        If MasterControl.Instance.SplitContainer1.Panel1Collapsed = True Then
            Me.AlberoFunzioniToolStripMenuItem.Checked = False
        Else
            Me.AlberoFunzioniToolStripMenuItem.Checked = True
        End If
    End Sub

    '<STAThread()> _
    'Shared Sub main(ByVal cmdArgs() As String)
    '   Dim mdi As New MDIForm
    '   Dim parameter As String = ""
    '   If cmdArgs.Length > 0 Then
    '      For argNum As Integer = 0 To UBound(cmdArgs, 1)
    '         parameter = cmdArgs(0)
    '      Next argNum
    '   End If

    '   Dim Factory As IOpenCommandFactory = GetOpenCommandFactory()


    '   MasterControl.Instance.OpenForm = parameter
    '   'qui aggiungo al main control i comandi che deve usare
    '   MasterControl.Instance.AddLinkCommand("Home", Factory.GetOpenCommand("Home"))
    '   MasterControl.Instance.AddLinkCommand("OpenNewPagamento", Factory.GetOpenCommand("OpenNewPagamento"))


    '   MasterControl.Instance.AddLinkCommand("OpenNewRistorno", Factory.GetOpenCommand("OpenNewRistorno"))
    '   MasterControl.Instance.AddLinkCommand("OpenDocumento", Factory.GetOpenCommand("OpenDocumento"))

    '   MasterControl.Instance.AddLinkCommand("OpenAnagraficaConto", Factory.GetOpenCommand("OpenAnagraficaConto"))
    '   MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaConto", Factory.GetOpenCommand("OpenNewAnagraficaConto"))
    '   MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaUtente", Factory.GetOpenCommand("OpenNewAnagraficaUtente"))
    '   MasterControl.Instance.AddLinkCommand("OpenAnagraficaUtente", Factory.GetOpenCommand("OpenAnagraficaUtente"))

    '   MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaReferente", Factory.GetOpenCommand("OpenNewAnagraficaReferente"))
    '   MasterControl.Instance.AddLinkCommand("OpenAnagraficaReferente", Factory.GetOpenCommand("OpenAnagraficaReferente"))

    '   MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaAzienda", Factory.GetOpenCommand("OpenNewAnagraficaAzienda"))
    '   MasterControl.Instance.AddLinkCommand("OpenAnagraficaAzienda", Factory.GetOpenCommand("OpenAnagraficaAzienda"))

    '   MasterControl.Instance.AddLinkCommand("OpenNewDelega", Factory.GetOpenCommand("OpenNewDelega"))
    '   MasterControl.Instance.AddLinkCommand("OpenDelega", Factory.GetOpenCommand("OpenDelega"))

    '   MasterControl.Instance.AddLinkCommand("OpenSaldo", Factory.GetOpenCommand("OpenSaldo"))
    '   MasterControl.Instance.AddLinkCommand("OpenCausaliRevoca", Factory.GetOpenCommand("OpenCausaliRevoca"))
    '   MasterControl.Instance.AddLinkCommand("OpenTipoContratto", Factory.GetOpenCommand("OpenTipoContratto"))
    '   MasterControl.Instance.AddLinkCommand("OpenSettore", Factory.GetOpenCommand("OpenSettore"))
    '   MasterControl.Instance.AddLinkCommand("OpenEnte", Factory.GetOpenCommand("OpenEnte"))
    '   MasterControl.Instance.AddLinkCommand("OpenInps", Factory.GetOpenCommand("OpenInps"))

    '   System.Windows.Forms.Application.EnableVisualStyles()
    '   System.Windows.Forms.Application.Run(New MDIForm)
    'End Sub

    'Private Shared Function GetOpenCommandFactory() As IOpenCommandFactory
    '   Dim asm As Reflection.Assembly
    '   Try
    '      Dim path As String = My.Application.Info.DirectoryPath
    '      asm = System.Reflection.Assembly.LoadFrom(path & "\WIN.GUI.APPLICATION.dll")
    '      Dim OpCmdFct As IOpenCommandFactory = asm.CreateInstance("WIN.GUI.APPLICATION.OpenCommandFactory")
    '      asm = Nothing
    '      Return OpCmdFct
    '   Catch ex As Exception
    '      Throw New Exception("Impossibile ottenere la factory per i comandi di apertura" & vbCrLf & ex.Message)
    '   End Try
    'End Function

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim frm As New FrmOpzioni
        frm.ShowDialog()
    End Sub




    'Public ReadOnly Property IsThreadBusy() As Boolean
    '   Get
    '      Return Me.BackgroundWorker1.IsBusy
    '      'Return t.IsAlive
    '   End Get
    'End Property






    Private Sub CausaliDelegheToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CausaliDelegheToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenCausaliRevoca")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub TipiPrestaziooneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipiPrestaziooneToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenTipoPrestazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub IstitutiContrattualiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IstitutiContrattualiToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenIstituti")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub TipiComunicazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenTipiComunicazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CausaliComunicazioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenCausaliComunicazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub RepartiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepartiToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenReparti")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub SkillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkillToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenSkills")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub LivelloSkillToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivelloSkillToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenLivelloSkills")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub TipiComunicazioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipiComunicazioneToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenTipiComunicazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CausaliComunicazioneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CausaliComunicazioneToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenCausaliComunicazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Private Sub DocumentiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenDocumento")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub AziendeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AziendeToolStripMenuItem2.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAnagraficaAzienda")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CassaEdileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassaEdileToolStripMenuItem.Click
        Try
            Dim hash As New Hashtable
            hash.Add("Id", 1)
            MasterControl.Instance.NavigateTo("OpenEnte", hash)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub EdilcassaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EdilcassaToolStripMenuItem.Click
        Try
            Dim hash As New Hashtable
            hash.Add("Id", 2)
            MasterControl.Instance.NavigateTo("OpenEnte", hash)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ContrattiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContrattiToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenTipoContratto")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub InpsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InpsToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenInps")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub OfferteLavoroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfferteLavoroToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenOfferte")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub SelezionaUtenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelezionaUtenteToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAnagraficaUtente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub VertenzeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VertenzeToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenVertenze")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub PrestazioniToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrestazioniToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrestazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProposToolStripMenuItem.Click

        Try
            MasterControl.Instance.NavigateTo("OpenProposte")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ComunicazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComunicazioniToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenComunicazioni")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub DelegheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelegheToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenDeleghe")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub TargetPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TargetPanel.Paint

    End Sub

    Private Sub RicercaOfferteLavoroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RicercaOfferteLavoroToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAnalisiDomanda")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub RicercaDomandeLavoroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RicercaDomandeLavoroToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAnalisiOfferta")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportIncassiQuoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportIncassiQuoteToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptIQ")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportPrestazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportPrestazioniToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptPrestazioni")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportVertenzeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportVertenzeToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptVertenze")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportDelegheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDelegheToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptDeleghe")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportLavoratoriLiberiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptLiberi")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportIscrittiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptIscritti")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    <Secure(Area:="Ruoli", Alias:="Gestione", Macroarea:="Sicurezza")> _
    Private Sub RuoliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuoliToolStripMenuItem.Click
        Try
            CheckPermissonForRoleManagement()
            Dim frm As New ManagerRuoli
            frm.ShowDialog()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub


    Public Sub CheckPermissonForRoleManagement()
        SecurityManager.Instance.Check()
    End Sub

    Public Sub CheckPermisson()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Profili", Alias:="Gestione", Macroarea:="Sicurezza")> _
    Private Sub ProfiliEPermessiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfiliEPermessiToolStripMenuItem.Click
        Try
            CheckPermisson()
            Dim frm As New ManagerProfili
            frm.ShowDialog()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New FrmInformazioni
        frm.ShowDialog()
        frm.Dispose()
    End Sub


    <Secure(Area:="Procedure guidate", Alias:="Comunicazioni massive", Macroarea:="Comunicazioni")> _
   Private Sub ComunicazioniMassiveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComunicazioniMassiveToolStripMenuItem1.Click
        Try
            CheckPermisson()
            'MasterControl.Instance.NavigateTo("OpenComunicazioneMassiva")
            Dim frm As New FrmComunicazioniMassiveWizard()

            frm.Show()

        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try


    End Sub

    Private Sub ListeLavoroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeLavoroToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenListaLavoro")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub InoltroMassivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InoltroMassivoToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenInoltroMassivo")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub AccettazioneMassivaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccettazioneMassivaToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAccettazioneMassiva")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub FondiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FondiToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenFondo")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub


    Private Sub PrintSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetupToolStripMenuItem.Click
        Dim frm As New FrmSelectPrinter
        frm.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        MasterControl.Instance.StartSaveOperation()
    End Sub


    Private Sub ContentsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Try

            Dim path As String = GetHelpFilePath()

            'Help.ShowHelp(Me, path)


            Dim process As New Process
            Dim info As New ProcessStartInfo

            info.FileName = path
            Diagnostics.Process.Start(info)
            process.Dispose()






        Catch ex As Exception
            ErrorHandler.ShowError(ex)

        End Try
    End Sub

    Private Function GetHelpFilePath() As String
        Dim path As String
        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        path = asm.CodeBase()
        path = path.Replace("file:///", "")
        Dim j As System.IO.FileInfo = New System.IO.FileInfo(path)
        path = j.DirectoryName()
        path = path + "\HelpResources\Manuale FenealNet.chm"
        Return path
    End Function


    Private Sub IndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexToolStripMenuItem.Click
        Try

            Dim path As String = GetHelpFilePath()

            Help.ShowHelpIndex(Me, path)

        Catch ex As Exception
            ErrorHandler.ShowError(ex)

        End Try
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        Try
            Dim path As String = GetHelpFilePath()

            Help.ShowHelp(Me, path)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)

        End Try
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        GotoPrev()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        MasterControl.Instance.PrintControl()
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        MasterControl.Instance.PrintControl()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start(My.Settings.FenealgestWEB)
        Catch ex As Exception
            ' The error message
            MsgBox("Impossibile aprire il link.", MsgBoxStyle.Exclamation, "Errore")
        End Try
    End Sub

    Private Sub SegreteriaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SegreteriaToolStripMenuItem2.Click
        Try
            MasterControl.Instance.NavigateTo("OpenSegreteria")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub TipiDocumentazioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipiDocumentazioneToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenTipoDocumentazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub VisualizzaDelegaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizzaDelegaToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenDeleghe")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ArchivioDocumentaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenSegreteria")
            CType(MasterControl.Instance.Current, ControlSegreteria).OpenArchivio()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try

    End Sub

    Private Sub ReportLavoratoriLiberiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportLavoratoriLiberiToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptLiberiDTO")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportIscrittiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportIscrittiToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptIscrittiDTO")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CompilazioneDocumentazioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompilazioneDocumentazioneToolStripMenuItem.Click

        Try
            ' NavigateTo("ViewCompilazioneModelli")
            Dim frm As New FrmCompilazioneModello()
            frm.Show()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            ' NavigateTo("ViewCompilazioneModelli")
            Dim frm As New FrmCompilazioneModello()
            frm.Show()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenCompilazioneModelli")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAnagraficaReferente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CompilazioneModelliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompilazioneModelliToolStripMenuItem.Click
        Try
            ' NavigateTo("ViewCompilazioneModelli")
            Dim frm As New FrmCompilazioneModello()
            frm.Show()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub ArchivioDocumentaleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivioDocumentaleToolStripMenuItem1.Click
        Try
            MasterControl.Instance.NavigateTo("OpenSegreteria")
            CType(MasterControl.Instance.Current, ControlSegreteria).OpenArchivio()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub DocumentiFinanziariToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.NavigateTo("OpenDocumento")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub AvvocatiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvvocatiToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenAnagraficaAvvocato")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub MDIForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MasterControl.Instance.CheckBeforeExitProgram = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub NuovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovoToolStripMenuItem.Click
        MasterControl.Instance.NewElem()

    End Sub

    Private Sub IngrandisciFinestraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngrandisciFinestraToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RiduciFinestraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RiduciFinestraToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MasterControl.Instance.RemoveElem()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        GoHome()
    End Sub

    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformazioniToolStripMenuItem.Click
        MasterControl.Instance.GetObjectInfo()
    End Sub

    Private Sub NuovaIstanzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovaIstanzaToolStripMenuItem.Click
        NewProgramInstance()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        MasterControl.Instance.UndoControl()
    End Sub

    Private Sub AvantiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvantiToolStripMenuItem.Click
        GotoNest()
    End Sub


    Private Sub GeneratoreModelliToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratoreModelliToolStripMenuItem1.Click
        Try
            MasterControl.Instance.GoToGeneratoreModelli()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CalcolatoreCodiceFiscaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcolatoreCodiceFiscaleToolStripMenuItem.Click
        Try
            Dim frm As New FrmCacolatoreCF
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    <Secure(Area:="Procedure guidate", Alias:="Incrocio liste utenti", Macroarea:="Reportistica")> _
    Private Sub IncrocioListeLavoroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncrocioListeLavoroToolStripMenuItem.Click
        Try
            CheckPermissonForRoleManagement()
            Dim frm As New FrmConfrontoListeWizard()
            frm.ShowDialog()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        Try
            MasterControl.Instance.GoToImportCenter()

        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub Novit‡DelllaNuovaVersioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novit‡DelllaNuovaVersioneToolStripMenuItem.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath + "\Novita\WhatsNew.doc")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub TeleassistenzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeleassistenzaToolStripMenuItem.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath + "\HelpResources\Teleassistenza.exe")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub EsportazioneDatiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsportazioneDatiToolStripMenuItem.Click
        'Try

        '    Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")

        '    Dim file As String = "\Export\WIN.WEBCONNECTOR.exe"


        '    Dim f As New FileInfo(path)

        '    path = f.DirectoryName + file

        '    'Dim p As String = IO.Path.Combine(path, file)


        '    Dim args As New ProcessStartInfo
        '    args.Arguments = ConstuctArguments()

        '    'passo il nome del programma da avviare
        '    args.FileName = path

        '    'avvio il programma
        '    Process.Start(args)




        'Catch ex As Exception
        '    ErrorHandler.ShowError(ex)
        'End Try
        ApriDBNazionale()
    End Sub


   



    Private Function ConstuctArguments() As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"


        Dim com As String = """com:1"""

        result = usn + " " + usp + " " + pro + " " + com


        Return result
    End Function

    Private Sub CercaNelWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CercaNelWebToolStripMenuItem.Click
        Try

           

            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
            'Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
            'Dim f As New IO.FileInfo(path)
            'path = f.DirectoryName + exportProgram

            Dim exportProgram As String = "\FenealConnector\WIN.WEBCONNECTOR.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.Parent.FullName + exportProgram

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalit‡ non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If



            'definisco i parametri di apertura del programma
            Dim args As New ProcessStartInfo
            args.Arguments = ConstuctArgumentsForSearch()

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)







        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Function ConstuctArgumentsForSearch() As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"
        Dim chk As String = """chk:no"""

        Dim com As String = """com:4"""

        result = usn + " " + usp + " " + pro + " " + com + " " + chk


        Return result
    End Function

   

    Private Sub BilancioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HelpOnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpOnlineToolStripMenuItem.Click
        Process.Start("http://www.fenealgest.it/manual")
    End Sub

    Private Sub BilancioRLSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VisualizzaDocumentiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizzaDocumentiToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenDocumento")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub Contabilit‡ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contabilit‡ToolStripMenuItem.Click
        'Try

        '    Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")

        '    Dim file1 As String = "\RENDICONTO FENEAL\GestAmm.exe"


        '    Dim f As New FileInfo(path)

        '    ' path = f.DirectoryName + file

        '    path = f.Directory.Parent.FullName + file1

        '    If Not File.Exists(path) Then
        '        MessageBox.Show("Funzionalit‡ non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Return
        '    End If



        '    Dim args As New ProcessStartInfo


        '    'passo il nome del programma da avviare
        '    args.FileName = path

        '    'avvio il programma
        '    Process.Start(args)




        'Catch ex As Exception
        '    ErrorHandler.ShowError(ex)
        'End Try
    End Sub

    Private Sub Contabilit‡RLSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try

        '    Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")

        '    Dim file1 As String = "\RENDICONTO RLST\GestAmm.exe"


        '    Dim f As New FileInfo(path)

        '    'path = f.DirectoryName + file

        '    path = f.Directory.Parent.FullName + file1

        '    If Not File.Exists(path) Then
        '        MessageBox.Show("Funzionalit‡ non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Return
        '    End If



        '    Dim args As New ProcessStartInfo


        '    'passo il nome del programma da avviare
        '    args.FileName = path

        '    'avvio il programma
        '    Process.Start(args)




        'Catch ex As Exception
        '    ErrorHandler.ShowError(ex)
        'End Try
    End Sub

    Private Sub CreaIncassoQuotaAssociativaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaIncassoQuotaAssociativaToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateWithoutHistoryTo("OpenNewPagamento")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CreaIncassoQuotaInpsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaIncassoQuotaInpsToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateWithoutHistoryTo("OpenNewPagamentoInps")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CreaIncassoQuotaVertenzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaIncassoQuotaVertenzaToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateWithoutHistoryTo("OpenNewPagamentoVertenza")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CreaIncassoQuotaPrevisionaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaIncassoQuotaPrevisionaleToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateWithoutHistoryTo("OpenNewPagamentoPrevisionale")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub CreaRistornoCollaboratoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaRistornoCollaboratoreToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateWithoutHistoryTo("OpenNewRistorno")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MasterControl.Instance.GoToImportCenter()

        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        ApriDBNazionale()
    End Sub
    Private Sub ApriDBNazionale()
        Try

            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")

            'Dim file As String = "\Export\WIN.WEBCONNECTOR.exe"
            Dim file1 As String = "\FenealConnector\WIN.WEBCONNECTOR.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.Parent.FullName + file1

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalit‡ non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If





            Dim args As New ProcessStartInfo
            args.Arguments = ConstuctArguments()

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)




        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Try
            MasterControl.Instance.GoToImportCenter()

        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub CambiaPasswordAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiaPasswordMenuItem.Click
        Try
            CambiaPasswordAdmin()


        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub


    '<Secure(Area:="Cabio password Admin", Alias:="Gestione", Macroarea:="Sicurezza")> _
    Private Sub CambiaPasswordAdmin()
        ' SecurityManager.Instance.Check()

        Dim frm As New FrmCambiaPassword
        frm.ShowDialog()

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
            'Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
            'Dim f As New IO.FileInfo(path)
            'path = f.DirectoryName + exportProgram

            Dim exportProgram As String = "\WIN.SCHEDULING_APPLICATION.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.FullName + exportProgram

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalit‡ non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If



            'definisco i parametri di apertura del programma
            Dim args As New ProcessStartInfo
            args.Arguments = SecurityManager.Instance.CurrentUser.Username & " " & SecurityManager.Instance.CurrentUser.Password

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)







        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel4.Click
        Try

            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")

            'Dim file As String = "\Export\WIN.WEBCONNECTOR.exe"
            Dim file1 As String = "\RSUElection\WIN.FENGEST_RSU.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.Parent.FullName + file1

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalit‡ non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If





            Dim args As New ProcessStartInfo
            args.Arguments = ConstuctArguments()

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)




        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub ReportArchivioDocumentiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportArchivioDocumentiToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptArchivioDocumentale")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportIncarichiSindacaliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportIncarichiSindacaliToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptIncarichi")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub MagazzinoDelegheToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MagazzinoDelegheToolStripMenuItem.Click
        Try
            Dim frm As New FrmMagazzinoDeleghe()
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Errore")
        End Try
    End Sub

    Private Sub ListaElaborazioniAutomaticheToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaElaborazioniAutomaticheToolStripMenuItem.Click
        Dim frm As New FrmImportExport

        frm.ShowDialog()


        frm.Dispose()

    End Sub

    Private Sub CreaNuovoRendicontoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreaNuovoRendicontoToolStripMenuItem.Click
        Try
            CreaNuovoRendiconto()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    <Secure(Area:="Rendiconti", Alias:="Crea rendiconto", Macroarea:="Contabilita")> _
    Private Sub CreaNuovoRendiconto()
        SecurityManager.Instance.Check()
        Dim frm As New FrmCreateRendiconto
        frm.ShowDialog()
        frm.Dispose()

    End Sub

    Private Sub VisualizzaRendicontiProvincialiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VisualizzaRendicontiProvincialiToolStripMenuItem.Click
        Try
            ViewRendicontiProvinciali()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    <Secure(Area:="Rendiconti", Alias:="Visualizza rendiconti provinciali", Macroarea:="Contabilita")> _
    Private Sub ViewRendicontiProvinciali()
        SecurityManager.Instance.Check()

        Dim frm As New FrmViewRendiconti(RendicontoType.Provinciale)
        frm.ShowDialog()
        frm.Dispose()
    End Sub


    <Secure(Area:="Rendiconti", Alias:="Visualizza rendiconti regionali", Macroarea:="Contabilita")> _
    Private Sub ViewRendicontiRegionali()
        SecurityManager.Instance.Check()
        Dim frm As New FrmViewRendiconti(RendicontoType.Regionale)
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    <Secure(Area:="Rendiconti", Alias:="Visualizza rendiconti RLST", Macroarea:="Contabilita")> _
    Private Sub ViewRendicontiRLST()
        SecurityManager.Instance.Check()
        Dim frm As New FrmViewRendiconti(RendicontoType.RLST)
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub VisualizzaRendicontiRegionaliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VisualizzaRendicontiRegionaliToolStripMenuItem.Click
        Try
            ViewRendicontiRegionali()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub VisualizzaRendicontiRLSTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VisualizzaRendicontiRLSTToolStripMenuItem.Click
        Try
            ViewRendicontiRLST()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try

            Dim params As New Hashtable
            params.Add("Id", SecurityManager.Instance.CurrentUser.ID)

            MasterControl.Instance.NavigateTo("OpenPrepareRptPratiche", params)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportPraticheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPraticheToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptPratiche")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub TipiPraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiPraticaToolStripMenuItem.Click

        Try
            MasterControl.Instance.NavigateTo("OpenTipiPratica")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportComunicazioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportComunicazioniToolStripMenuItem.Click
        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptComunicazioni")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportCantieriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportCantieriToolStripMenuItem.Click

        Try
            MasterControl.Instance.NavigateTo("OpenPrepareReportCantieri")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub ReportConfrontoDelegheQuoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportConfrontoDelegheQuoteToolStripMenuItem.Click

        Try
            MasterControl.Instance.NavigateTo("OpenPrepareRptDelegheQuote")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalit‡ richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try

    End Sub
End Class