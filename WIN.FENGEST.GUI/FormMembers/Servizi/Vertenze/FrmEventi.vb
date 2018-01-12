Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System
Public Class FrmEventi
   'Protected m_startColorVis As System.Drawing.Color = Drawing.Color.Lavender
   'Protected m_EndColorVis As System.Drawing.Color = Drawing.Color.CornflowerBlue
   'Protected m_startColorUp As System.Drawing.Color = Drawing.Color.White
   'Protected m_EndColorUp As System.Drawing.Color = Drawing.Color.CadetBlue
   'Protected m_startColorCreat As System.Drawing.Color = Drawing.Color.White
   'Protected m_EndColorCreat As System.Drawing.Color = Drawing.Color.DarkGray

   'Protected m_startColorVis As System.Drawing.Color = System.Drawing.Color.White
   'Protected m_EndColorVis As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
   'Protected m_startColorUp As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
   'Protected m_EndColorUp As System.Drawing.Color = System.Drawing.Color.White
   'Protected m_startColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption
   'Protected m_EndColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption




   Protected m_GradientMode As LinearGradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
   Protected m_Operation As String = "View"
   Private controllerVertenze As WIN.APPLICATION.ADMINISTRATION.ControllerVertenze
   Private m_IsEventoAdded As Boolean = False
   Private m_IsEventoUpdated As Boolean = False
   Public Event EventAdded()
   Public Event EventUpdated()
   Private IsLoading As Boolean = False
   Private m_CartellaUtente As String = ""


   Public ReadOnly Property IsEventoUpdated()
      Get
         Return m_IsEventoUpdated
      End Get
   End Property
   Public ReadOnly Property IsEventoAdded()
      Get
         Return m_IsEventoAdded
      End Get
   End Property
   'Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
   '   MyBase.OnPaintBackground(e)
   '     'SetWindowStyle(e.Graphics, m_Operation)
   'End Sub
   'Public Overridable Sub SetWindowStyle(ByVal Graphics As System.Drawing.Graphics, ByVal Operation As String)
   '   Select Case Operation
   '      Case "View"
   '         DrawBackground(Graphics, m_startColorVis, m_EndColorVis)
   '      Case "Add"
   '         DrawBackground(Graphics, m_startColorCreat, m_EndColorCreat)
   '      Case "Update"
   '         DrawBackground(Graphics, m_startColorUp, m_EndColorUp)
   '   End Select
   'End Sub
   'Protected Sub DrawBackground(ByVal Graphics As System.Drawing.Graphics, ByVal StartColor As System.Drawing.Color, ByVal EndColor As System.Drawing.Color)
   '   Try
   '      Dim br As New LinearGradientBrush(Me.ClientRectangle, StartColor, EndColor, m_GradientMode)
   '      ' paint the background.
   '      Graphics.FillRectangle(br, Me.ClientRectangle)
   '      ' orderly destroy the brush.
   '      br.Dispose()
   '   Catch ex As Exception

   '   End Try
   '   ' start/end color and gradient mode

   'End Sub
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="Operation">I valori ammessi sono: "View", "Update", "Add"</param>
   ''' <param name="Controller"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Operation As String, ByVal Controller As WIN.APPLICATION.ADMINISTRATION.ControllerVertenze, ByVal CartellaUtente As String)
      InitializeComponent()
      m_Operation = Operation
      controllerVertenze = Controller
      m_CartellaUtente = CartellaUtente
   End Sub

   Private Sub FrmEventi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      'decido le operazioi da eseguire in base all'operazione

      Select Case m_Operation
         Case "View"
            IsLoading = True
            InterfaceMediator.LoadCombo(Me.cboTipo, controllerVertenze.GetListaTipiEvento, False)
            LoadEvento()
            IsLoading = False
           
         Case "Add"
            ClearWindow()
            InterfaceMediator.LoadCombo(Me.cboTipo, controllerVertenze.GetListaTipiEvento, False)
            Me.cmdAdd.Enabled = True
            Me.cmdOk.Enabled = False
            
      End Select
   End Sub

   Private Sub LoadEvento()
      cboTipo.Text = controllerVertenze.DescrizioneTipoEvento
      Me.txtIntervento.Text = controllerVertenze.Intervento
      Me.txtNote.Text = controllerVertenze.NoteEvento
      Me.txtEnte.Text = controllerVertenze.EnteInoltro
      ' Me.txtAvvocato.Text = controllerVertenze.Avvocato
      Me.dtpData.Value = controllerVertenze.DataEvento


      If controllerVertenze.PathDocumento = "" Then
         lblDocumento.Text = "Nessun documento"
         lblDocumento.ForeColor = Color.Black
      Else
         lblDocumento.Text = controllerVertenze.PathDocumento
         lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
      End If


      Me.cmdAdd.Enabled = False
      Me.cmdOk.Enabled = True
   End Sub






   Private Sub ClearWindow()
      cboTipo.Text = ""
      Me.txtIntervento.Text = ""
      Me.txtNote.Text = ""
      Me.txtEnte.Text = ""
      'Me.txtAvvocato.Text = ""
      Me.dtpData.Value = Today
      lblDocumento.Text = "Nessun documento"
      lblDocumento.ForeColor = Color.Black
   End Sub



   Private Sub Change()
      If Not m_Operation = "Add" Then
         If Not IsLoading Then
            m_Operation = "Update"
            m_IsEventoUpdated = True
            Me.Invalidate()
         End If
      End If
   End Sub
   Private Sub txtAvvocato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Change()
   End Sub
   Private Sub txtEnte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnte.TextChanged
      Change()
   End Sub
   Private Sub txtIntervento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntervento.TextChanged
      Change()
   End Sub
   Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
      Change()
   End Sub
   Private Sub dtpData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
      Change()
   End Sub
   Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
      Change()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Try
         If m_IsEventoUpdated Then
            controllerVertenze.SetTipoEvento(cboTipo.Text)
            controllerVertenze.NoteEvento = txtNote.Text
            ' controllerVertenze.Avvocato = txtAvvocato.Text
            controllerVertenze.EnteInoltro = txtEnte.Text
            controllerVertenze.DataEvento = dtpData.Value
            controllerVertenze.Intervento = txtIntervento.Text
            controllerVertenze.PathDocumento = lblDocumento.Text
            RaiseEvent EventUpdated()
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
         controllerVertenze.AddEvento(cboTipo.Text, txtIntervento.Text, "", txtEnte.Text, dtpData.Value, txtNote.Text, lblDocumento.Text)
         Me.m_IsEventoAdded = True
         RaiseEvent EventAdded()
         Me.Close()
      Catch ex As Exception
         Me.m_IsEventoAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub lblAvvocato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub

   Private Sub SpDel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpDel.DoClik
      Try
         If MsgBox("Sicuro di voler eliminare il file documento?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione file prestazione") = MsgBoxResult.Yes Then

            If My.Computer.FileSystem.FileExists(controllerVertenze.PathDocumento) Then
               My.Computer.FileSystem.DeleteFile(controllerVertenze.PathDocumento)
            End If
            controllerVertenze.PathDocumento = ""
            lblDocumento.Text = "Nessun documento"
            lblDocumento.ForeColor = Color.Black
            Change()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub SpDelRef_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpDelRef.DoClik
      Try
         If MsgBox("Sicuro di voler eliminare il riferimento al file documento?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione file prestazione") = MsgBoxResult.Yes Then
            controllerVertenze.PathDocumento = ""
            lblDocumento.Text = "Nessun documento"
            lblDocumento.ForeColor = Color.Black
            Change()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub




   Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpView.DoClik
      Try
         If lblDocumento.Text = "" Then Throw New ArgumentException("Nome file vuoto")
         If Not System.IO.File.Exists(lblDocumento.Text) Then Throw New ArgumentException("File inesistente")
         Dim pInfo As New ProcessStartInfo()
         pInfo.FileName = lblDocumento.Text
         pInfo.UseShellExecute = True
         Dim p As Process = Process.Start(pInfo)
      Catch ex As Exception
         MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
      End Try
   End Sub



   Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpAddFile.DoClik
      Try
         Dim frm As New FrmAllegaFile()
         frm.Destination = m_CartellaUtente
         Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog

         If dialog = Windows.Forms.DialogResult.OK Then
            lblDocumento.Text = frm.FileName
            lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Change()
         End If
         frm.Dispose()
      Catch ex As Exception
         MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
      End Try
   End Sub


End Class