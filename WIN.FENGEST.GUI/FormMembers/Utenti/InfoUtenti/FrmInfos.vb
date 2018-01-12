Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class FrmInfos
    Protected m_Operation As String = "View"
    Private controllerUtenti As WIN.APPLICATION.UTENTI.ControllerUtenti
    Private controllerAzienda As New AZIENDE.ControllerAziende
    Private controllerEnti As New AZIENDE.ControllerEntiBilaterali


    Private m_IsItemAdded As Boolean = False
    Private m_IsItemUpdated As Boolean = False
    Public Event InfoAdded()
    Public Event InfoUpdate()
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

    Private Sub FrmPreferenza_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'decido le operazioi da eseguire in base all'operazione
        Dim hash As Hashtable = controllerEnti.GetListaEnti
        Dim list As New ArrayList
        list.Add(hash.Item(1))
        list.Add(hash.Item(2))
        cboIscritto.ComboBox1.Items.Add("")
        cboIscritto.ComboBox1.Items.Add("FILCA")
        cboIscritto.ComboBox1.Items.Add("FILLEA")


        Select Case m_Operation
            Case "View"
                IsLoading = True
                InterfaceMediator.LoadCombo(Me.cboEnti.ComboBox1, list, False)
                LoadItem()
                IsLoading = False
            Case "Add"
                ClearWindow()
                InterfaceMediator.LoadCombo(Me.cboEnti.ComboBox1, list, False)
                Me.cmdAdd.Enabled = True
                Me.cmdOk.Enabled = False
        End Select
    End Sub

    Private Sub LoadItem()
        cboIscritto.TextValue = controllerUtenti.IscrittoAInfo
        cboEnti.TextValue = controllerUtenti.DescrizioneInfoEnte
        IdAziendaTextBox1.TextValue = controllerUtenti.IdInfoAzienda
        IdAziendaTextBox1.DescriptionOfText = controllerUtenti.DescrizioneInfoAzienda
        dtpData.DataValue = controllerUtenti.LiberoAlInfo
        txtLivello.TextValue = controllerUtenti.LivelloInfo
        Me.cmdAdd.Enabled = False
        Me.cmdOk.Enabled = True
    End Sub

    Private Sub ClearWindow()
        cboIscritto.TextValue = ""
        cboEnti.TextValue = ""
        dtpData.DataValue = DateTime.Today
        Me.IdAziendaTextBox1.TextValue = ""
        txtLivello.TextValue = ""
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



    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            If m_IsItemUpdated Then
                controllerUtenti.SetInfoEnte(cboEnti.TextValue)
                controllerUtenti.SetInfoAzienda(IdAziendaTextBox1.TextValue)
                controllerUtenti.LiberoAlInfo = dtpData.DataValue
                controllerUtenti.LivelloInfo = txtLivello.TextValue
                controllerUtenti.IscrittoAInfo = cboIscritto.TextValue
                RaiseEvent InfoUpdate()
            End If
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim controllerenti As New AZIENDE.ControllerEntiBilaterali

            controllerUtenti.AddInfo(IdAziendaTextBox1.TextValue, controllerenti.GetIdEnteByDescrizione(cboEnti.TextValue), dtpData.DataValue, txtLivello.TextValue, DateTime.Now, cboIscritto.TextValue)
            Me.m_IsItemAdded = True
            RaiseEvent InfoAdded()
            Me.Close()
        Catch ex As Exception
            Me.m_IsItemAdded = False
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Private Sub dtpData_ValueChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChange
        Change()
    End Sub

    Private Sub cboEnti_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboEnti.SelectedIndexChange
        Change()
    End Sub

    Private Sub IdAziendaTextBox1_TextBoxChanged() Handles IdAziendaTextBox1.TextBoxChanged
        Change()
    End Sub


    Private Sub txtLivello_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLivello.TextChange
        Change()
    End Sub

    Private Sub UsabilityCombo1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboIscritto.SelectedIndexChange
        Change()
    End Sub
End Class