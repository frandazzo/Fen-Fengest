Imports WIN.DOMAIN.FED_SERVICES
Imports System
Public Class FrmRiepilogoAttivita
   Private m_controller As UTENTI.ControllerUtenti
   Private ds As DelegheTimeSorter
   Private ps As PrestazioniTimeSorter
   Private cs As ComunicazioniTimeSorter
   Private ls As PropostaLavoroTimeSorter
   Private vs As VertenzeTimeSorter

   Private m_anno_deleghe As Int32
   Private m_anno_prestazioni As Int32
   Private m_anno_vertenze As Int32
   Private m_anno_comunicazioni As Int32
   Private m_anno_proposte As Int32


   Private Sub SetDockPanelColor(ByVal Graphics As System.Drawing.Graphics, ByVal titleBarTo As System.Drawing.Color, ByVal DockPanello As Windows.Forms.Panel)
      Dim g As System.Drawing.Graphics = Graphics
      Dim DockPan As Rectangle = New Rectangle(0, 0, DockPanello.Width, DockPanello.Height)

      Dim titleBarFrom As System.Drawing.Color = System.Drawing.Color.White
      Dim titleBarColor As New System.Drawing.Drawing2D.LinearGradientBrush(DockPan, titleBarFrom, titleBarTo, Drawing.Drawing2D.LinearGradientMode.Vertical)

      g.FillRectangle(titleBarColor, DockPan)
      'g.DrawLine(New Pen(System.Drawing.Color.FromArgb(133, 135, 140)), 0, Me.Height - 1, Me.Width, Me.Height - 1)
   End Sub

   Private Sub DockPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DockPanel.Paint
      SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), DockPanel)
      e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
      SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), Panel1)
      e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
      SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), Panel2)
      e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub Panel3_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
      SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), Panel3)
      e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub Panel4_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint
      SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), Panel4)
      e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub



   Public Sub New(ByVal controller As UTENTI.ControllerUtenti)
      InitializeComponent()

      m_controller = controller


      Initialize()


      LoadData()


   End Sub

   Private Sub Initialize()
      InitializeCaption()
      InitializeGrids()


   End Sub

   Private Sub LoadTrees()
      TreeViewAttivitaLoaders.LoadTreeView(ds, TreeViewDeleghe)
      TreeViewAttivitaLoaders.LoadTreeView(vs, TreeViewVertenze)
      TreeViewAttivitaLoaders.LoadTreeView(ls, TreeViewProposte)
      TreeViewAttivitaLoaders.LoadTreeView(cs, TreeViewComunicazioni)
      TreeViewAttivitaLoaders.LoadTreeView(ps, TreeViewPrestazioni)
   End Sub

   Private Sub InitializeGrids()
      GridAttivitaInitializers.InitializeGridDeleghe(datagridviewDeleghe)
      GridAttivitaInitializers.InitializeGridPrestazioni(DataGridViewPrestazioni)

      GridAttivitaInitializers.InitializeGridVertenze(DataGridViewVertenze)
      GridAttivitaInitializers.InitializeGridComunicazioni(DataGridViewComunicazioni)
      GridAttivitaInitializers.InitializeGridProposte(DataGridViewProposte)

   End Sub


   Private Sub InitializeCaption()
      Me.Text += " -- " & m_controller.CompleteName
   End Sub


   Private Sub LoadData()
      LoadGridDeleghe()
      LoadGridPrestazioni()

      LoadGridVertenze()
      LoadGridComunicazioni()
      LoadGridProposte()

      LoadTrees()

   End Sub


   Private Sub LoadGridProposte()

      Dim p As New ControllerProposte
      p.LoadAllByUtente(m_controller.IdUtente)


      ls = New PropostaLavoroTimeSorter(p.LoadedObjects)


      GridsLoader.LoadData(DataGridViewProposte, ls.OrderedList)

   End Sub
   Private Sub LoadGridComunicazioni()

      Dim p As New ControllerComunicazioni
      p.LoadAllByUtente(m_controller.IdUtente)


      cs = New ComunicazioniTimeSorter(p.LoadedObjects)


      GridsLoader.LoadData(DataGridViewComunicazioni, cs.OrderedList)

   End Sub

   Private Sub LoadGridVertenze()

      Dim p As New ADMINISTRATION.ControllerVertenze
      p.LoadAllByUtente(m_controller.IdUtente)


      vs = New VertenzeTimeSorter(p.LoadedObjects)


      GridsLoader.LoadData(DataGridViewVertenze, vs.OrderedList)

   End Sub

   Private Sub LoadGridPrestazioni()

      Dim p As New ADMINISTRATION.ControllerPrestazioni
      p.LoadAllByUtente(m_controller.IdUtente)


      ps = New PrestazioniTimeSorter(p.LoadedObjects)


      GridsLoader.LoadData(DataGridViewPrestazioni, ps.OrderedList)

   End Sub

   Private Sub LoadGridDeleghe()

      ds = New DelegheTimeSorter(m_controller.ElencoDeleghe)


      GridsLoader.LoadData(datagridviewDeleghe, ds.OrderedList)

   End Sub

   Private Sub datagridviewDeleghe_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles datagridviewDeleghe.CellFormatting
      If datagridviewDeleghe.Columns(e.ColumnIndex).Name.Equals("StatoDelega") Then
         If Not e.Value Is Nothing Then
            e.Value = e.Value.StatusName
         End If
      End If

      If datagridviewDeleghe.Columns.Item(e.ColumnIndex).Name = "Id" Then
         e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Underline)
         e.CellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
      End If
   End Sub

   Private Sub DataGridViewPrestazioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewPrestazioni.CellFormatting
      If DataGridViewPrestazioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
         If Not e.Value Is Nothing Then
            e.Value = e.Value.Descrizione
         End If
      End If
      If DataGridViewPrestazioni.Columns.Item(e.ColumnIndex).Name = "Id" Then
         e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Underline)
         e.CellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
      End If
   End Sub

   Private Sub DataGridViewProposte_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewProposte.CellFormatting
      If DataGridViewProposte.Columns(e.ColumnIndex).Name.Equals("Offerta") Then
         If Not e.Value Is Nothing Then
            e.Value = e.Value.AziendaRichiedente.Descrizione
         End If
      End If


      If DataGridViewProposte.Columns.Item(e.ColumnIndex).Name = "Id" Then
         e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Underline)
         e.CellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
      End If
   End Sub


   Private Sub DataGridViewVertenze_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewVertenze.CellFormatting
      If DataGridViewVertenze.Columns.Item(e.ColumnIndex).Name = "Id" Then
         e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Underline)
         e.CellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
      End If
   End Sub

   Private Sub DataGridViewComunicazioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewComunicazioni.CellFormatting
      If DataGridViewComunicazioni.Columns.Item(e.ColumnIndex).Name = "Id" Then
         e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Underline)
         e.CellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
      End If
   End Sub

   Private Sub TreeViewDeleghe_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewDeleghe.AfterSelect
      If e.Node IsNot Nothing Then
         If e.Node.Tag <> 0 Then
            m_anno_deleghe = CType(e.Node.Tag, Int32)
            GridsLoader.LoadData(datagridviewDeleghe, ds.GetServiziPerAnnoDocumento(m_anno_deleghe))
            Return
         End If
      End If
      m_anno_deleghe = 0
      GridsLoader.LoadData(datagridviewDeleghe, ds.OrderedList)
   End Sub

   Private Sub TreeViewPrestazioni_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewPrestazioni.AfterSelect
      If e.Node.Tag <> 0 Then
         If e.Node.Tag IsNot Nothing Then
            m_anno_prestazioni = CType(e.Node.Tag, Int32)
            GridsLoader.LoadData(DataGridViewPrestazioni, ps.GetServiziPerAnnoDocumento(m_anno_prestazioni))
            Return
         End If
      End If
      m_anno_prestazioni = 0
      GridsLoader.LoadData(DataGridViewPrestazioni, ps.OrderedList)
   End Sub

   Private Sub TreeViewProposte_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewProposte.AfterSelect
      If e.Node.Tag <> 0 Then
         If e.Node.Tag IsNot Nothing Then
            m_anno_proposte = CType(e.Node.Tag, Int32)
            GridsLoader.LoadData(DataGridViewProposte, ls.GetServiziPerAnnoDocumento(m_anno_proposte))
            Return
         End If
      End If
      m_anno_proposte = 0
      GridsLoader.LoadData(DataGridViewProposte, ls.OrderedList)
   End Sub

   Private Sub TreeViewVertenze_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewVertenze.AfterSelect
      If e.Node.Tag <> 0 Then
         If e.Node.Tag IsNot Nothing Then
            m_anno_vertenze = CType(e.Node.Tag, Int32)
            GridsLoader.LoadData(DataGridViewVertenze, vs.GetServiziPerAnnoDocumento(m_anno_vertenze))
            Return
         End If
      End If
      m_anno_vertenze = 0
      GridsLoader.LoadData(DataGridViewVertenze, vs.OrderedList)
   End Sub

   Private Sub TreeViewComunicazioni_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeViewComunicazioni.AfterLabelEdit
      If e.Node.Tag <> 0 Then
         If e.Node.Tag IsNot Nothing Then
            m_anno_comunicazioni = CType(e.Node.Tag, Int32)
            GridsLoader.LoadData(DataGridViewComunicazioni, cs.GetServiziPerAnnoDocumento(m_anno_comunicazioni))
            Return
         End If
      End If
      m_anno_comunicazioni = 0
      GridsLoader.LoadData(DataGridViewComunicazioni, cs.OrderedList)
   End Sub

   Private Sub datagridviewDeleghe_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles datagridviewDeleghe.MouseDoubleClick
      Try
         If datagridviewDeleghe.SelectedRows.Count = 1 Then

            Dim h As New Hashtable
            h.Add("Id", datagridviewDeleghe.SelectedRows(0).DataBoundItem.Id)
            h.Add("IdUtente", DataGridViewPrestazioni.SelectedRows(0).DataBoundItem.Utente.Id)


            MasterControl.Instance.NavigateTo("OpenDelega", h)

            Me.Close()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub DataGridViewPrestazioni_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewPrestazioni.MouseDoubleClick
      Try
         If DataGridViewPrestazioni.SelectedRows.Count = 1 Then

            Dim h As New Hashtable
            h.Add("Id", DataGridViewPrestazioni.SelectedRows(0).DataBoundItem.Id)
           


            MasterControl.Instance.NavigateTo("OpenSingolaPrestazione", h)

            Me.Close()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub DataGridViewVertenze_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewVertenze.MouseDoubleClick
      Try
         If DataGridViewVertenze.SelectedRows.Count = 1 Then

            Dim h As New Hashtable
            h.Add("Id", DataGridViewVertenze.SelectedRows(0).DataBoundItem.Id)



            MasterControl.Instance.NavigateTo("OpenSingolaVertenza", h)

            Me.Close()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub DataGridViewComunicazioni_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewComunicazioni.MouseDoubleClick
      Try
         If DataGridViewComunicazioni.SelectedRows.Count = 1 Then

            Dim h As New Hashtable
            h.Add("Id", DataGridViewComunicazioni.SelectedRows(0).DataBoundItem.Id)



            MasterControl.Instance.NavigateTo("OpenSingolaComunicazione", h)

            Me.Close()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub DataGridViewProposte_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewProposte.MouseDoubleClick
      Try
         If DataGridViewProposte.SelectedRows.Count = 1 Then

            Dim h As New Hashtable
            h.Add("Id", DataGridViewProposte.SelectedRows(0).DataBoundItem.Id)



            MasterControl.Instance.NavigateTo("OpenSingolaProposta", h)

            Me.Close()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class