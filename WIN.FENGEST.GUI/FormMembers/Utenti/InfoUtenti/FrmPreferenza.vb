
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class FrmPreferenza
      Protected m_Operation As String = "View"
   Private controllerUtenti As WIN.APPLICATION.UTENTI.ControllerUtenti
   Private controlleAbilita As New ControllerAbilita


   Private m_IsItemAdded As Boolean = False
   Private m_IsItemUpdated As Boolean = False
   Public Event PreferenzaAdded()
   Public Event PreferenzaUpdated()
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

      Select Case m_Operation
         Case "View"
            IsLoading = True
            InterfaceMediator.LoadCombo(Me.cboSkill.ComboBox1, controlleAbilita.GetListaCausali, False)
            LoadComboPriorita()

            LoadItem()
            IsLoading = False
         Case "Add"
            ClearWindow()
            InterfaceMediator.LoadCombo(Me.cboSkill.ComboBox1, controlleAbilita.GetListaCausali, False)
            LoadComboPriorita()
            Me.cmdAdd.Enabled = True
            Me.cmdOk.Enabled = False
      End Select
   End Sub

   Private Sub LoadComboPriorita()
      cboPriorita.ComboBox1.DataSource = controllerUtenti.GetListaPriorita
   End Sub

   Private Sub LoadItem()
      cboSkill.TextValue = controllerUtenti.DescrizioneAbilitaPreferenza
      dtpData.DataValue = controllerUtenti.DataPreferenza
      cboPriorita.TextValue = controllerUtenti.PrioritaPreferenza
      TextBox1.TextValue = controllerUtenti.NotePreferenza
      Me.cmdAdd.Enabled = False
      Me.cmdOk.Enabled = True
   End Sub
   Private Sub ClearWindow()
      cboSkill.Text = ""
      dtpData.DataValue = DateTime.Today
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
            controllerUtenti.SetAbilitaPreferenza(cboSkill.TextValue)
            controllerUtenti.DataPreferenza = dtpData.DataValue
            controllerUtenti.SetPrioritaPreferenza(cboPriorita.TextValue)
            controllerUtenti.NotePreferenza = TextBox1.TextValue
            RaiseEvent PreferenzaUpdated()
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
         controllerUtenti.AddPreferenza(cboSkill.TextValue, cboPriorita.TextValue, dtpData.DataValue, TextBox1.TextValue)
         Me.m_IsItemAdded = True
         RaiseEvent PreferenzaAdded()
         Me.Close()
      Catch ex As Exception
         Me.m_IsItemAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub



   Private Sub dtpData_ValueChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChange
      Change()
   End Sub

   Private Sub cboSkill_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboSkill.SelectedIndexChange
      Change()
   End Sub

   Private Sub cboPriorita_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboPriorita.SelectedIndexChange
      Change()
   End Sub

   Private Sub TextBox1_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChange
      Change()
   End Sub
End Class