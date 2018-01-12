
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System
Public Class FrmItemOfferta
   'Protected m_startColorVis As System.Drawing.Color = Drawing.Color.Lavender
   'Protected m_EndColorVis As System.Drawing.Color = Drawing.Color.CornflowerBlue
   'Protected m_startColorUp As System.Drawing.Color = Drawing.Color.White
   'Protected m_EndColorUp As System.Drawing.Color = Drawing.Color.CadetBlue
   'Protected m_startColorCreat As System.Drawing.Color = Drawing.Color.White
   'Protected m_EndColorCreat As System.Drawing.Color = Drawing.Color.DarkGray

   Protected m_startColorVis As System.Drawing.Color = System.Drawing.Color.White
   Protected m_EndColorVis As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
   Protected m_startColorUp As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
   Protected m_EndColorUp As System.Drawing.Color = System.Drawing.Color.White
   Protected m_startColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption
   Protected m_EndColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption




   Protected m_GradientMode As LinearGradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
   Protected m_Operation As String = "View"
   Private controllerOfferte As WIN.APPLICATION.ControllerOfferteLavoro
   Private controlleAbilita As New ControllerAbilita
   Private controllerLivello As New ControllerLivelloAbilita

   Private m_IsItemAdded As Boolean = False
   Private m_IsItemUpdated As Boolean = False
   Public Event ItemAdded()
   Public Event ItemUpdated()
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
   Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
      MyBase.OnPaintBackground(e)
        'SetWindowStyle(e.Graphics, m_Operation)
   End Sub
   Public Overridable Sub SetWindowStyle(ByVal Graphics As System.Drawing.Graphics, ByVal Operation As String)
      Select Case Operation
         Case "View"
            DrawBackground(Graphics, m_startColorVis, m_EndColorVis)
         Case "Add"
            DrawBackground(Graphics, m_startColorCreat, m_EndColorCreat)
         Case "Update"
            DrawBackground(Graphics, m_startColorUp, m_EndColorUp)
      End Select
   End Sub
   Protected Sub DrawBackground(ByVal Graphics As System.Drawing.Graphics, ByVal StartColor As System.Drawing.Color, ByVal EndColor As System.Drawing.Color)
      Try
         Dim br As New LinearGradientBrush(Me.ClientRectangle, StartColor, EndColor, m_GradientMode)
         ' paint the background.
         Graphics.FillRectangle(br, Me.ClientRectangle)
         ' orderly destroy the brush.
         br.Dispose()
      Catch ex As Exception

      End Try
      ' start/end color and gradient mode

   End Sub
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="Operation">I valori ammessi sono: "View", "Update", "Add"</param>
   ''' <param name="Controller"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Operation As String, ByVal Controller As WIN.APPLICATION.ControllerOfferteLavoro)
      InitializeComponent()
      m_Operation = Operation
      controllerOfferte = Controller
   End Sub

   Private Sub FrmEventi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      'decido le operazioi da eseguire in base all'operazione

      Select Case m_Operation
         Case "View"
            IsLoading = True
            InterfaceMediator.LoadCombo(Me.cboSkill, controlleAbilita.GetListaCausali, False)
            InterfaceMediator.LoadCombo(Me.cboLevel, controllerLivello.GetListaCausali, False)
            LoadItem()
            IsLoading = False
         Case "Add"
            ClearWindow()
            InterfaceMediator.LoadCombo(Me.cboSkill, controlleAbilita.GetListaCausali, False)
            InterfaceMediator.LoadCombo(Me.cboLevel, controllerLivello.GetListaCausali, False)
            Me.cmdAdd.Enabled = True
            Me.cmdOk.Enabled = False
      End Select
   End Sub

   Private Sub LoadItem()
      cboSkill.Text = controllerOfferte.DescrizioneAbilita
      cboLevel.Text = controllerOfferte.DescrizioneLivelloAbilita
      Me.txtNum.Text = controllerOfferte.NumeroPosti
      Me.cmdAdd.Enabled = False
      Me.cmdOk.Enabled = True
   End Sub
   Private Sub ClearWindow()
      cboSkill.Text = ""
      cboLevel.Text = ""
      Me.txtNum.Text = ""
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

   Private Sub cboSkill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSkill.SelectedIndexChanged
      Change()
   End Sub
   Private Sub cboLevell_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLevel.SelectedIndexChanged
      Change()
   End Sub

   Private Sub txtNun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNum.TextChanged
      Change()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Try
         If m_IsItemUpdated Then
            controllerOfferte.SetAbilita(cboSkill.Text)
            controllerOfferte.SetLivelloAbilita(cboLevel.Text)
            controllerOfferte.NumeroPosti = txtNum.Text
            RaiseEvent ItemUpdated()
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
         controllerOfferte.AddItem(cboSkill.Text, cboLevel.Text, txtNum.Text)
         Me.m_IsItemAdded = True
         RaiseEvent ItemAdded()
         Me.Close()
      Catch ex As Exception
         Me.m_IsItemAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

End Class