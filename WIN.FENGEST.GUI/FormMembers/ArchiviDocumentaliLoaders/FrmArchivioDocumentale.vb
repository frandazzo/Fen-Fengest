Imports WIN.DOMAIN.FEDERATIONARTIFACTS
Imports System.Windows.Forms
Imports System
Public Class FrmArchivioDocumentale
   Private m_Changed As Boolean



   Private m_controller As ControllerArchivioDocumentale
   'Private m_PathDefault As String
   'Private m_Target As String
   Private m_TargetType As TypeOfTargetArchivio
    Private m_TipoSelezionato As TipoDocumentazione
    Private m_annoSelezionato As Int32 = -1
   Private m_TipoSelezionatoAttivita As TipoDocumentazione
   Private nodeAttivitaName As String
   Private m_selectedColumnName As String = ""
   Private m_selectedColumnNameAtt As String = ""


   Public Enum TypeOfTargetArchivio
      Utenti
      Aziende
      Segreteria
   End Enum


   Public Sub New(ByVal controller As ControllerArchivioDocumentale, ByVal TargetType As TypeOfTargetArchivio)

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      m_TargetType = TargetType
      m_controller = controller



      Dim ini As IInitializeFormArchivio = ArchivioInitializerFactory.GetInizializatore(m_TargetType)
      ini.InitializeForm(Me, Label5, m_controller, SplitContainer1, SplitContainer5)

      InitializeGrids(ini)

      LoadData(ini)
   End Sub


   Private Sub LoadData(ByVal ini As IInitializeFormArchivio)
      ini.LoadData(Me, m_controller)
   End Sub



   Friend Sub LoadDirectoryPreferenziale()
      If m_controller.DirectoryPreferenziale = "" Then
         m_controller.DirectoryPreferenziale = m_controller.CreateDirectoryPreferenziale()
         Change()
         MessageBox.Show("E' stata creata una cartella di default", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
      txtCartella.Text = m_controller.DirectoryPreferenziale
   End Sub



   Private Sub InitializeGrids(ByVal ini As IInitializeFormArchivio)
      ini.InitializeGrids(Me)
   End Sub


   Friend Sub InitializeGridAttivita()
      GridInitializers.InitializeGridAttivita(datagridviewAttivita)
   End Sub

   Friend Sub InitializeGridArchivio()
      GridInitializers.InitializeGridArchivioDocumenti(datagridview1)
   End Sub

   Friend Sub LoadDatiArchivio()
      TreeViewsLoader.LoadTreeViewArchivio(m_controller, TreeView1)
      LoadGridArchivio()
   End Sub

   Private Sub LoadGridArchivio()
        If m_TipoSelezionato Is Nothing And m_annoSelezionato = -1 Then
            m_controller.LoadListaDocumenti()
            GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumenti)
            Return
        End If
        If Not m_TipoSelezionato Is Nothing Then
            m_controller.LoadListaDocumentiPerAnnoETipo(m_annoSelezionato, m_TipoSelezionato)
            GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumenti)
            Return
        End If
     
        m_controller.LoadListaDocumentiPerAnno(m_annoSelezionato)
        GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumenti)
   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      'Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Try
         Save()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub Save()
      If m_Changed Then
         m_controller.Save()
         View()
      End If
   End Sub

   Private Sub cmdSeleziona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleziona.Click

      Dim ini As IInitializeFormArchivio = ArchivioInitializerFactory.GetInizializatore(m_TargetType)

      FolderBrowserDialog1.SelectedPath = ini.GetSuggestedPath




      If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
         Return
      End If

      txtCartella.Text = FolderBrowserDialog1.SelectedPath
      m_controller.DirectoryPreferenziale = txtCartella.Text
      Change()
   End Sub



   Private Sub cmdViewPathDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If txtCartella.Text <> "" Then
            SimpleFileSystemManager.ViewPath(txtCartella.Text)
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdClearPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim c As New ControllerSegreteria
         c.LoadById(1)
         txtCartella.Text = c.GetDirectoryPreferenziale(m_controller.Target)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub datagridview1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles datagridview1.CellFormatting
        Try
            If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
                If datagridview1.Columns.Item(e.ColumnIndex).Name = "NomeFile" Then
                    Dim row As DataGridViewRow = datagridview1.Rows.Item(e.RowIndex)
                    If row.DataBoundItem Is Nothing Then
                        Return
                    End If
                    Dim doc As ElectronicDocument = CType(row.DataBoundItem, ElectronicDocument)
                    If Not doc.ExistFile Then
                        e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Italic)
                        e.CellStyle.ForeColor = Color.Red
                        e.Value = " -- " + doc.FullFileName + " --"
                    End If

                ElseIf datagridview1.Columns.Item(e.ColumnIndex).Name = "Collaboratore" Then

                    If e.Value IsNot Nothing Then
                        e.Value = e.Value.CompleteName
                    End If

                End If
            End If
        Catch ex As Exception

        End Try

   End Sub

   Private Sub DockPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DockPanel.Paint
      'SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), DockPanel)
      'e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
      SetViewPanel()
   End Sub

   Private Sub SetViewPanel()
      If m_Changed Then
         ChangePanel()
      Else
         ViewPanel()
      End If
   End Sub

   Private Sub SetViewPanel2()
      If m_Changed Then
         ChangePanel2()
      Else
         ViewPanel2()
      End If
   End Sub


   Private Sub SetDockPanelColor(ByVal Graphics As System.Drawing.Graphics, ByVal titleBarTo As System.Drawing.Color, ByVal DockPanello As Panel)
      Dim g As System.Drawing.Graphics = Graphics
      Dim DockPan As Rectangle = New Rectangle(0, 0, DockPanello.Width, DockPanello.Height)

      Dim titleBarFrom As System.Drawing.Color = System.Drawing.Color.White
      Dim titleBarColor As New System.Drawing.Drawing2D.LinearGradientBrush(DockPan, titleBarFrom, titleBarTo, Drawing.Drawing2D.LinearGradientMode.Vertical)

      g.FillRectangle(titleBarColor, DockPan)
      'g.DrawLine(New Pen(System.Drawing.Color.FromArgb(133, 135, 140)), 0, Me.Height - 1, Me.Width, Me.Height - 1)
   End Sub

   Private Sub DocPanel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DocPanel1.Paint
      SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), DocPanel1)
      e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub DockPanel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DockPanel2.Paint
      'SetDockPanelColor(e.Graphics, System.Drawing.Color.FromArgb(237, 237, 237), DockPanel2)
      'e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
      SetViewPanel2()
   End Sub

   Private Sub datagridview1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datagridview1.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      datagridview1.ClearSelection()
      For Each elem As DataGridViewColumn In datagridview1.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      Try
         datagridview1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
         m_selectedColumnName = datagridview1.Columns(e.ColumnIndex).Name
      Catch ex As Exception
         m_selectedColumnName = ""
      End Try
   End Sub

   Private Sub datagridview1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles datagridview1.MouseDoubleClick

      Try
         If datagridview1.SelectedRows.Count = 1 Then
            m_controller.SelectDocumento(datagridview1.SelectedRows.Item(0).DataBoundItem)
            Dim frm As New FrmDocumentoElettronico(m_controller, FrmDocumentoElettronico.DocumentoAction.Update)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
               'GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumentiOrdinati)
               m_TipoSelezionato = m_controller.Current.TipoDocumentazione
               LoadDatiArchivio()
               Change()
            End If
            frm.Dispose()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub



   Private Sub Change()
      m_Changed = True
      DockPanel.Invalidate()
      DockPanel2.Invalidate()
   End Sub

   Private Sub ChangePanel()
      Dim e As System.Drawing.Graphics = DockPanel.CreateGraphics
      SetDockPanelColor(e, System.Drawing.Color.FromArgb(209, 47, 47), DockPanel)
      e.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub ChangePanel2()
      Dim e As System.Drawing.Graphics = DockPanel2.CreateGraphics
      SetDockPanelColor(e, System.Drawing.Color.FromArgb(209, 47, 47), DockPanel2)
      e.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub View()
      m_Changed = False
      DockPanel.Invalidate()
      DockPanel2.Invalidate()

   End Sub

   Private Sub ViewPanel()
      Dim e As System.Drawing.Graphics = DockPanel.CreateGraphics
      SetDockPanelColor(e, System.Drawing.Color.FromArgb(237, 237, 237), DockPanel)
      e.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub ViewPanel2()
      Dim e As System.Drawing.Graphics = DockPanel2.CreateGraphics
      SetDockPanelColor(e, System.Drawing.Color.FromArgb(237, 237, 237), DockPanel2)
      e.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
   End Sub

   Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

      Me.Close()


   End Sub

   Private Sub CloseAll()
      Try
         If m_Changed Then
            RequestIfCanSave()
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub


   Private Sub RequestIfCanSave()
      If MessageBox.Show("I dati sono stati cambiati. Salvare i cambiamenti?", "Salvataggio dati", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
         Save()
      End If
   End Sub

   Private Sub FrmArchivioDocumentale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      CloseAll()
   End Sub

   Private Sub cmdAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddFile.Click
      Try
         Dim frm As New FrmDocumentoElettronico(m_controller, FrmDocumentoElettronico.DocumentoAction.Insert)
         If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumentiOrdinati)
            m_TipoSelezionato = m_controller.Current.TipoDocumentazione
            LoadDatiArchivio()
            lblNumDocs.Text = "Numero totale documenti trovati: " & m_controller.GetNumeroDocumenti.ToString
            Change()
         End If
         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdRemoveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveFile.Click
      Try
         If datagridview1.SelectedRows.Count = 1 Then

            Dim frm As New FrmDeleteElectronicDocument
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
               m_controller.RemoveDocumento(datagridview1.SelectedRows.Item(0).DataBoundItem, frm.DeleteFile)
               'GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumentiOrdinati)


               If m_TipoSelezionato IsNot Nothing Then
                  If m_controller.NumberOfListaDoc(m_TipoSelezionato) = 0 Then
                     m_TipoSelezionato = Nothing
                  End If
               End If

               lblNumDocs.Text = "Numero totale documenti trovati: " & m_controller.GetNumeroDocumenti.ToString
               LoadDatiArchivio()
               Change()
            End If
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRename.Click
      Try
         If datagridview1.SelectedRows.Count = 1 Then
            m_controller.SelectDocumento(datagridview1.SelectedRows.Item(0).DataBoundItem)
            Dim frm As New FrmRinominaFile(datagridview1.SelectedRows.Item(0).DataBoundItem.FileNameWithoutPath)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
               m_controller.RenameFile(frm.NuovoNome)
               'GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumentiOrdinati)
               datagridview1.Refresh()

               Change()
            End If
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
      Try
         If datagridview1.SelectedRows.Count = 1 Then
            Dim doc As ElectronicDocument = CType(datagridview1.SelectedRows.Item(0).DataBoundItem, ElectronicDocument)
            doc.ViewFile()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdViewPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewPath.Click
      Try
         If datagridview1.SelectedRows.Count = 1 Then
            Dim doc As ElectronicDocument = CType(datagridview1.SelectedRows.Item(0).DataBoundItem, ElectronicDocument)
            doc.ViewPath()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdViewPathDefault_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewPathDefault.Click
      Try
         SimpleFileSystemManager.ViewPath(m_controller.DirectoryPreferenziale)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdSetDefaultFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetDefaultFolder.Click
      Try
         Dim c As New ControllerSegreteria
         c.LoadById(1)
         m_controller.DirectoryPreferenziale = c.GetDirectoryPreferenziale(m_controller.Target)
         txtCartella.Text = m_controller.DirectoryPreferenziale
         Change()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdMoveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveFile.Click
      Try
         Dim frm As New FrmAllegaFile(True)
         frm.Destination = m_controller.DirectoryPreferenziale
         Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog
         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdInfoFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoFile.Click
      Try
         If datagridview1.SelectedRows.Count = 1 Then
            MessageBox.Show(SimpleFileSystemManager.GetFileProperties(datagridview1.SelectedRows.Item(0).DataBoundItem.FullFileName), "Proprietà file", MessageBoxButtons.OK, MessageBoxIcon.Information)
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub FrmArchivioDocumentale_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      ResizeForm()
   End Sub


   Private Sub FrmArchivioDocumentale_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

      ResizeForm()
   End Sub

   Private Sub ResizeForm()
      Try
         'If m_TargetType <> TypeOfTargetArchivio.Segreteria Then
         '   SplitContainer1.SplitterDistance = 115
         'End If
         Dim ini As IInitializeFormArchivio = ArchivioInitializerFactory.GetInizializatore(m_TargetType)

         ini.ResizeForm(Me, SplitContainer1, SplitContainer4)
      Catch ex As Exception

      End Try
   End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        m_TipoSelezionato = Nothing
        m_annoSelezionato = -1
        If e.Node IsNot Nothing Then
            If e.Node.Tag IsNot Nothing Then

                'devo capire se si tratta di un nodo anno o un tipo documentazione
                Try
                    m_annoSelezionato = Convert.ToInt32(e.Node.Tag)
                    LoadGridArchivio()
                    Return
                Catch ex As Exception
                    m_annoSelezionato = -1
                End Try

                If m_annoSelezionato = -1 Then
                    Try
                        m_TipoSelezionato = CType(e.Node.Tag, TipoDocumentazione)
                        'se trovo un tipo vuol dire che un anno è selelzionato
                        m_annoSelezionato = Convert.ToInt32(e.Node.Parent.Tag)
                    Catch ex As Exception
                        m_TipoSelezionato = Nothing
                        m_annoSelezionato = -1
                    End Try

                    LoadGridArchivio()
                    Return
                End If


            End If
        End If
        m_TipoSelezionato = Nothing
        m_annoSelezionato = -1
        LoadGridArchivio()
    End Sub

   Private Sub datagridviewAttivita_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles datagridviewAttivita.CellFormatting
      If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
         If datagridviewAttivita.Columns.Item(e.ColumnIndex).Name = "NomeFile" Then
            Dim row As DataGridViewRow = datagridviewAttivita.Rows.Item(e.RowIndex)
            If row.DataBoundItem Is Nothing Then
               Return
            End If
            Dim doc As ElectronicDocument = CType(row.DataBoundItem, ElectronicDocument)
            If Not doc.ExistFile Then
               e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Italic)
               e.CellStyle.ForeColor = Color.Red
               e.Value = " -- " + doc.FullFileName + " --"
            End If
         End If


         If datagridviewAttivita.Columns.Item(e.ColumnIndex).Name = "Id" Then

            e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Underline)
            e.CellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption


         End If
      End If
   End Sub

   Private Sub cmdViiewFileAttività_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViiewFileAttività.Click
      Try
         If datagridviewAttivita.SelectedRows.Count = 1 Then
            Dim doc As ElectronicDocument = CType(datagridviewAttivita.SelectedRows.Item(0).DataBoundItem, ElectronicDocument)
            doc.ViewFile()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdViewPathAttivita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewPathAttivita.Click
      Try
         If datagridviewAttivita.SelectedRows.Count = 1 Then
            Dim doc As ElectronicDocument = CType(datagridviewAttivita.SelectedRows.Item(0).DataBoundItem, ElectronicDocument)
            doc.ViewPath()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdInfoFileAttivita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoFileAttivita.Click
      Try
         If datagridviewAttivita.SelectedRows.Count = 1 Then
            MessageBox.Show(SimpleFileSystemManager.GetFileProperties(datagridviewAttivita.SelectedRows.Item(0).DataBoundItem.FullFileName), "Proprietà file", MessageBoxButtons.OK, MessageBoxIcon.Information)
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub datagridviewAttivita_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datagridviewAttivita.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      datagridviewAttivita.ClearSelection()
      For Each elem As DataGridViewColumn In datagridviewAttivita.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      Try
         datagridviewAttivita.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
         m_selectedColumnNameAtt = datagridviewAttivita.Columns(e.ColumnIndex).Name
      Catch ex As Exception
         m_selectedColumnNameAtt = ""
      End Try
   End Sub

   Private Sub datagridviewAttivita_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles datagridviewAttivita.MouseDoubleClick
      Try
         If datagridviewAttivita.SelectedRows.Count = 1 Then
            m_controller.SelectDocumentoAttivita(datagridviewAttivita.SelectedRows.Item(0).DataBoundItem)
            Dim frm As New FrmDocumentoElettronico(m_controller, FrmDocumentoElettronico.DocumentoAction.ViewAttivita)
            frm.ShowDialog()
            frm.Dispose()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
      Try
         If datagridviewAttivita.SelectedRows.Count = 1 Then

            Navigate()

         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub Navigate()
      Dim t As TipoDocumentazione = datagridviewAttivita.SelectedRows.Item(0).DataBoundItem.TipoDocumentazione
      Dim id As Int32 = datagridviewAttivita.SelectedRows.Item(0).DataBoundItem.Id
      Dim link As String = ""

      Dim hash As New Hashtable
      hash.Add("Id", id)

      Select Case t.Descrizione
         Case "PRESTAZIONI"
            link = "OpenSingolaPrestazione"
         Case "COMUNICAZIONI"
            link = "OpenSingolaComunicazione"
         Case "VERTENZE"
            link = "OpenSingolaVertenza"
      End Select

      MasterControl.Instance.NavigateTo(link, hash)

      Me.Close()
   End Sub

   Private Sub TreeView2_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterSelect
      If e.Node IsNot Nothing Then
         If e.Node.Tag IsNot Nothing Then
            m_TipoSelezionatoAttivita = CType(e.Node.Tag, TipoDocumentazione)
            nodeAttivitaName = e.Node.Name
            LoadGridAttivita()
            Return
         End If
      End If
      m_TipoSelezionatoAttivita = Nothing
      LoadGridAttivita()
   End Sub

   Friend Sub LoadDatiAttivita()
      'Dim lista As IList = m_controller.GetListaDocumentiAttivita
      m_controller.LoadListaDocumentiAttivitaFromDB()
      'GridsLoader.LoadData(datagridviewAttivita, lista)
      TreeViewsLoader.LoadTreeViewAttivita(m_controller, TreeView2)
      LoadGridAttivita()
   End Sub

   Private Sub LoadGridAttivita()
      If m_TipoSelezionatoAttivita Is Nothing Then
         m_controller.LoadListaDocumentiAttivita()
         GridsLoader.LoadData(datagridviewAttivita, m_controller.GetListaDocumentiAttivita)
         Return
      End If
      m_controller.LoadListaDocumentiAttivitaPerTipo(m_TipoSelezionatoAttivita, TreeView2.SelectedNode.Name)
      GridsLoader.LoadData(datagridviewAttivita, m_controller.GetListaDocumentiAttivita)


   End Sub

   Private Sub LoadGridAArchivioByPattern()

      m_controller.LoadListaDocumentiByPattern(txtSearch.Text)
      GridsLoader.LoadData(datagridview1, m_controller.GetListaDocumenti)


   End Sub

   Private Sub LoadGridAttivitaByPattern()
    
      m_controller.LoadListaDocumentiAttivitaByPattern(txtSearchAtt.Text)
      GridsLoader.LoadData(datagridviewAttivita, m_controller.GetListaDocumentiAttivita)


   End Sub


   Private Sub cmdUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUp.Click
      Try
         m_controller.SortItems(m_selectedColumnName)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.datagridview1.Refresh()
         datagridview1.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDown.Click
      Try
         m_controller.SortItems(m_selectedColumnName, True)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.datagridview1.Refresh()
         datagridview1.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdUpAtt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpAtt.Click
      Try
         m_controller.SortItemsAtt(m_selectedColumnNameAtt)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.datagridviewAttivita.Refresh()
         datagridviewAttivita.Columns(m_selectedColumnNameAtt).HeaderCell.SortGlyphDirection = SortOrder.Descending

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdDownAtt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDownAtt.Click
      Try
         m_controller.SortItemsAtt(m_selectedColumnNameAtt, True)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.datagridviewAttivita.Refresh()
         datagridviewAttivita.Columns(m_selectedColumnNameAtt).HeaderCell.SortGlyphDirection = SortOrder.Descending

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      Try
         LoadGridAArchivioByPattern()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdSearchAtt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearchAtt.Click
      Try
         LoadGridAttivitaByPattern()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class