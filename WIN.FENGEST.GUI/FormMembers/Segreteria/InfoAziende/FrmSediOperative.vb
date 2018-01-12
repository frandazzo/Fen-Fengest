Imports System.Drawing
Imports System
Imports System.Drawing.Drawing2D
Public Class FrmSediOperative
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
   Private m_controller As WIN.APPLICATION.AZIENDE.ControllerAziende
   Private m_IsSedeAdded As Boolean = False
   Private m_IsSedeUpdated As Boolean = False
   Public Event SedeAdded()
   Public Event SedeUpdated()
   Private IsLoading As Boolean = False


   Public ReadOnly Property IsSedeUpdated()
      Get
         Return m_IsSedeUpdated
      End Get
   End Property
   Public ReadOnly Property IsSedeAdded()
      Get
         Return m_IsSedeAdded
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
   Public Sub New(ByVal Operation As String, ByVal Controller As WIN.APPLICATION.AZIENDE.ControllerAziende)
      InitializeComponent()
      m_Operation = Operation
      m_controller = Controller
   End Sub

   Private Sub FrmSedi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      'decido le operazioi da eseguire in base all'operazione

      Select Case m_Operation
         Case "View"
            IsLoading = True
            ' InterfaceMediator.LoadCombo(Me.cboTipo, controllerVertenze.GetListaTipiEvento, False)
                InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
                InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia("MATERA"), True)
                LoadSede()
                IsLoading = False
            Case "Add"
                ClearWindow()
                InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
                InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia("MATERA"), True)
                Me.cboProvincia.Text = My.Settings.ProvinciaDefault
                Me.cboComune.Text = My.Settings.ComuneDefault
                'InterfaceMediator.LoadCombo(Me.cboTipo, controllerVertenze.GetListaTipiEvento, False)
                Me.cmdAdd.Enabled = True
                Me.cmdOk.Enabled = False
        End Select
    End Sub




    Private Sub LoadSede()
        cboProvincia.Text = m_controller.DescrizioneProvinciaSedeOperativa
        cboComune.Text = m_controller.DescrizioneComuneSedeOperativa
        Me.txtCap.Text = m_controller.CAPSedeOperativa
        Me.txtDescrizione.Text = m_controller.DescrizioneSedeOperativa
        Me.txtVia.Text = m_controller.ViaSedeOperativa
        Me.cmdAdd.Enabled = False
        Me.cmdOk.Enabled = True
    End Sub
    Private Sub ClearWindow()
        cboProvincia.Text = ""
        cboComune.Text = ""
        Me.txtCap.Text = ""
        Me.txtDescrizione.Text = ""
        Me.txtVia.Text = ""
    End Sub



    Private Sub Change()
        If Not m_Operation = "Add" Then
            If Not IsLoading Then
                m_Operation = "Update"
                m_IsSedeUpdated = True
                Me.Invalidate()
            End If
        End If
    End Sub
    Private Sub txtDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrizione.TextChanged
        Change()
    End Sub
    Private Sub txtIntervento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCap.TextChanged
        Change()
    End Sub
    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        Change()
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
      cboComune.SelectedIndex = 0
   End Sub
   Private Sub cboComune_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboComune.SelectedIndexChanged
      Change()
   End Sub
   Private Sub txtVia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVia.TextChanged
      Change()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Try
         If m_IsSedeUpdated Then
            m_controller.DescrizioneSedeOperativa = txtDescrizione.Text
            m_controller.SetComuneSedeOperativa(cboComune.Text)
            m_controller.SetProvinciaSedeOperativa(cboProvincia.Text)
            m_controller.ViaSedeOperativa = Me.txtVia.Text
            RaiseEvent SedeUpdated()
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
         m_controller.AddSedeOperativa(txtDescrizione.Text, cboProvincia.Text, cboComune.Text, txtVia.Text)
         Me.m_IsSedeAdded = True
         RaiseEvent SedeAdded()
         Me.Close()
      Catch ex As Exception
         Me.m_IsSedeAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class
