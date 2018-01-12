Public Class FrmIncarichi

    Protected m_Operation As String = "View"
    Private controllerUtenti As WIN.APPLICATION.UTENTI.ControllerUtenti
    Private controllerAzienda As New AZIENDE.ControllerAziende
    Private controllerTipo As New ControllerTipoIncarico


    Private m_IsItemAdded As Boolean = False
    Private m_IsItemUpdated As Boolean = False
    Public Event IncaricoAdded()
    Public Event IncaricoUpdate()
    Private IsLoading As Boolean = False

    Public ReadOnly Property IsItemUpdated()
        Get
            Return m_IsItemUpdated
        End Get
    End Property

    Public ReadOnly Property IsItemAdded()
        Get
            Return m_IsItemAdded
        End Get
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Operation">I valori ammessi sono: "View", "Update", "Add"</param>
    ''' <param name="Controller"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Operation As String, ByVal Controller As WIN.APPLICATION.UTENTI.ControllerUtenti)
        InitializeComponent()
        m_Operation = Operation
        controllerUtenti = Controller
    End Sub

 

    Private Sub LoadItem()

        cboTipo.TextValue = controllerUtenti.DescrizioneIncaricoTipoIncarico
        IdAziendaTextBox1.TextValue = controllerUtenti.IdIncaricoAzienda
        IdAziendaTextBox1.DescriptionOfText = controllerUtenti.DescrizioneIncaricoAzienda
        txtNote.TextValue = controllerUtenti.NoteIncarico
        Me.cmdAdd.Enabled = False
        Me.cmdOk.Enabled = True
    End Sub

    Private Sub ClearWindow()
        cboTipo.ComboBox1.Text = ""
        Me.IdAziendaTextBox1.TextValue = ""
        txtNote.TextValue = ""
    End Sub

    Private Sub Change()
        If Not m_Operation = "Add" Then
            If Not IsLoading Then
                m_Operation = "Update"
                m_IsItemUpdated = True
                Me.Invalidate()
            End If
        End If
    End Sub




    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            ' Dim controllerenti As New AZIENDE.ControllerEntiBilaterali

            controllerUtenti.AddIncarico(IdAziendaTextBox1.TextValue, cboTipo.TextValue, txtNote.TextValue)
            Me.m_IsItemAdded = True
            RaiseEvent IncaricoAdded()
            Me.Close()
        Catch ex As Exception
            Me.m_IsItemAdded = False
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





  

   

   


   

   

    Private Sub FrmIncarichi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim list As IList = controllerTipo.GetListaCausali

        Select Case m_Operation
            Case "View"
                IsLoading = True
                InterfaceMediator.LoadCombo(Me.cboTipo.ComboBox1, list, False)
                LoadItem()
                IsLoading = False
            Case "Add"
                ClearWindow()
                InterfaceMediator.LoadCombo(Me.cboTipo.ComboBox1, list, False)
                Me.cmdAdd.Enabled = True
                Me.cmdOk.Enabled = False
        End Select
    End Sub

    Private Sub cboTipo_SelectedIndexChange(e As System.EventArgs) Handles cboTipo.SelectedIndexChange
        Change()
    End Sub

    Private Sub IdAziendaTextBox1_TextBoxChanged() Handles IdAziendaTextBox1.TextBoxChanged
        Change()
    End Sub

    Private Sub txtNote_TextChange(sender As System.Object, e As System.EventArgs) Handles txtNote.TextChange
        Change()
    End Sub

    Private Sub cmdOk_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        Try
            If m_IsItemUpdated Then
                controllerUtenti.SetIncaricoTipoIncarico(cboTipo.TextValue)
                controllerUtenti.SetIncaricoAzienda(IdAziendaTextBox1.TextValue)
                controllerUtenti.NoteIncarico = txtNote.TextValue

                RaiseEvent IncaricoUpdate()
            End If
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class