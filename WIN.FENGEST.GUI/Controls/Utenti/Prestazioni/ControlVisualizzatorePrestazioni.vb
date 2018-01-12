
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlVisualizzatorePrestazioni
   Private controller As New UTENTI.ControllerUtenti
   Private controllerPrestazioni As New ADMINISTRATION.ControllerPrestazioni
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
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  prestazioni utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  prestazioni utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " prestazioni utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  prestazioni utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  prestazioni  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  prestazioni utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  prestazioni  -  " & UCase(controller.CompleteName))
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
        Me.cmdPrint.Visible = False
        MasterControl.Instance.ParentForm.Text = "Ricerca prestazioni utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca prestazioni utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        '  Me.CmdVis.Visible = True
        Me.lblCurrentFunction.Text = UCase("Ricerca   prestazioni   utente ")
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.TabControl1.Visible = True
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()
        Me.cmdPrint.Visible = True
        ' Me.CmdVis.Visible = False

        Me.NiceGroupBox1.Visible = True
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        Try
            Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Catch ex As NullReferenceException
            Return
        End Try


        lblDescrizioneUtente.Text = controller.CompleteName
        Dim listaVertenze As IList = controllerPrestazioni.GetPrestazioniByUtente(Me.m_IdShowedObject)
        'If listaVertenze.Count > 0 Then
        LoadGrid(listaVertenze)
        'Else
        '   PerformDialog()
        'End If
    End Sub
    Private Sub PerformDialog()
        Select Case MsgBox("Non esistono prestazioni per l'utente selezionato. Si desidera creare una nuova prestazione? " & vbCrLf & _
                                   "Scegliere Sì per registrare una nuova prestazione;" & vbCrLf & _
                                   "Scegliere No per visualizzare l'anagrafica dell'utente selezionato;" & vbCrLf & _
                                   "Segliere Annulla per riprovare una nuova ricerca.", _
                                   MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, _
                                   "Visualizzazione prestazioni")
            Case MsgBoxResult.Cancel
                Me.NavigateWithoutHistoryTo("ViewPrestazioni", True)
            Case MsgBoxResult.Yes
                Me.NavigateWithoutHistoryTo("CreatePrestazione", True)
            Case MsgBoxResult.No
                Me.Navigate(m_IdShowedObject, "ViewUtente")
        End Select
    End Sub


    Private Sub GridDeleghe_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPrestazioni.CellFormatting

        If GridPrestazioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
            If Not e.Value Is Nothing Then
                'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                e.Value = e.Value.Descrizione
            End If
        End If

    End Sub
    Private Sub GridDeleghe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPrestazioni.DoubleClick
        Try
            If GridPrestazioni.SelectedRows.Count = 1 Then
                Dim SelectedId As Int32 = DirectCast(GridPrestazioni.SelectedRows.Item(0).Cells("Id").Value, Int32)
                Me.Navigate(SelectedId, "ViewPrestazione")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With GridPrestazioni

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
                    .Columns("TipoDocumento").Visible = False
                    .Columns("DataRegistrazione").Visible = False
                    .Columns("Utente").Visible = False
                    .Columns("Referente").Visible = False
                    .Columns("FileOutPut").Visible = False

                    .Columns("Id").Visible = True
                    .Columns("Id").DisplayIndex = 0
                    .Columns("Id").ReadOnly = True


                    .Columns("DataDocumento").Visible = True
                    .Columns("DataDocumento").HeaderText = "Data prestazione"
                    .Columns("DataDocumento").DisplayIndex = 1
                    .Columns("DataDocumento").ReadOnly = True

                    .Columns("TipoPrestazione").Visible = True
                    .Columns("TipoPrestazione").HeaderText = "Tipo prestazione"
                    .Columns("TipoPrestazione").DisplayIndex = 2
                    .Columns("TipoPrestazione").ReadOnly = True


                    .Columns("Note").Visible = True
                    .Columns("Note").DisplayIndex = 3
                    .Columns("Note").ReadOnly = True












                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia delle prestazioni per l'utente" & vbCrLf & ex.Message)
        End Try
    End Sub
#End Region






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
            Me.NavigateTo("ViewPrestazioni", ParameterList, True)
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


#End Region






    Private Sub View()
        Try
            Me.m_IdShowedObject = Me.IdUtenteTextBox1.TextValue
            Dim listaPrestazioni As IList = controllerPrestazioni.GetPrestazioniByUtente(Me.m_IdShowedObject)
            If listaPrestazioni.Count > 0 Then
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


    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        View()
    End Sub


   Private Sub cmdPrint_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
      Try
         Dim print As PrintFacade = New PrintFacade
         'print.PrintListaPrestazioni(controllerPrestazioni)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
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
                Me.NavigateWithoutHistoryTo("CreatePrestazione", True)
         Else

            Dim hash As New Hashtable
            hash.Add("IdUtente", IdUtenteTextBox1.TextValue)
                Me.NavigateWithoutHistoryTo("CreatePrestazione", hash, True)
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      End Try
   End Sub


   Private Sub spDuplica_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles spDuplica.DoClik

      Try
         DuplicaPrestazione()
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try


   End Sub


   <Secure(Area:="Elaborazioni", Alias:="Duplica prestazione", Macroarea:="Prestazioni")> _
   Private Sub DuplicaPrestazione()
      SecurityManager.Instance.Check()
      If Me.GridPrestazioni.SelectedRows.Count <> 1 Then
         MsgBox("Selezionare una prestazione", MsgBoxStyle.Information, "Selezione")
         Return
      End If
      Dim idPrestazione As Int32
      Try
         idPrestazione = Me.GridPrestazioni.SelectedRows(0).Cells("Id").Value
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try


      controllerPrestazioni.DuplicaPrestazione(idPrestazione)
      MsgBox("Prestazione duplicata con successo!", MsgBoxStyle.Information, "Informazione")
        Nested_LoadEditorsProperties()



   End Sub



   Private Sub spCreazioneMassiva_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles spCreazioneMassiva.DoClik
      Try
         CreaPrestazioni()
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   <Secure(Area:="Elaborazioni", Alias:="Creazione massiva", Macroarea:="Prestazioni")> _
   Private Sub CreaPrestazioni()

      SecurityManager.Instance.Check()
      If IdUtenteTextBox1.TextValue = "" Then
         MsgBox("Selezionare un utente", MsgBoxStyle.Exclamation, "Messaggio")
         Return
      End If
      Dim frm As New FrmImportaPrestazioni(IdUtenteTextBox1.TextValue)
      frm.ShowDialog()
        Nested_LoadEditorsProperties()
   End Sub

    Private Sub IdUtenteTextBox1_ReturnPressed() Handles IdUtenteTextBox1.ReturnPressed
        View()
    End Sub

    Private Sub ControlVisualizzatorePrestazioni_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdUtenteTextBox1.SetFocus()
    End Sub
End Class