
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class FrmAttitudine
     Protected m_Operation As String = "View"
   Private controllerUtenti As WIN.APPLICATION.UTENTI.ControllerUtenti
   Private controllerAbilita As New ControllerAbilita
   Private controllerLivelloAbilita As New ControllerLivelloAbilita


   Private m_IsItemAdded As Boolean = False
   Private m_IsItemUpdated As Boolean = False
   Public Event KnowHowAdded()
   Public Event KmowHowUpdated()
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
            InterfaceMediator.LoadCombo(Me.cboSkill.ComboBox1, controllerAbilita.GetListaCausali, False)
            InterfaceMediator.LoadCombo(Me.cboLivello.ComboBox1, controllerLivelloAbilita.GetListaCausali, False)
            LoadItem()
            IsLoading = False
         Case "Add"
            ClearWindow()
            InterfaceMediator.LoadCombo(Me.cboSkill.ComboBox1, controllerAbilita.GetListaCausali, False)
            InterfaceMediator.LoadCombo(Me.cboLivello.ComboBox1, controllerLivelloAbilita.GetListaCausali, False)
            Me.cmdAdd.Enabled = True
            Me.cmdOk.Enabled = False
      End Select
   End Sub

 

   Private Sub LoadItem()
      cboSkill.TextValue = controllerUtenti.DescrizioneAbilitaAttitudine
      cboLivello.TextValue = controllerUtenti.LivelloAbilitaAttitudine
      TextBox1.TextValue = controllerUtenti.NoteAttitudine
      Me.cmdAdd.Enabled = False
      Me.cmdOk.Enabled = True
   End Sub
   Private Sub ClearWindow()
      cboSkill.TextValue = ""
      cboLivello.TextValue = ""
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
            controllerUtenti.SetAbilitaAttitudine(cboSkill.TextValue)
            controllerUtenti.SetLivelloAbilitaAttitudine(cboLivello.TextValue)
            controllerUtenti.NoteAttitudine = TextBox1.TextValue
            RaiseEvent KmowHowUpdated()
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
         controllerUtenti.AddAttitudine(cboSkill.TextValue, cboLivello.TextValue, TextBox1.TextValue)
         Me.m_IsItemAdded = True
         RaiseEvent KnowHowAdded()
         Me.Close()
      Catch ex As Exception
         Me.m_IsItemAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

 

   Private Sub cboSkill_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboSkill.SelectedIndexChange
      Change()
   End Sub
End Class