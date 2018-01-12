Imports System.IO
Imports System.Windows.Forms

Public Class ControlCompilazioneModelli1
   Dim controllerUtente As New UTENTI.ControllerUtenti
   Dim controllerAzienda As New AZIENDE.ControllerAziende
   Dim controllerSegreteria As New ControllerSegreteria
   Dim con As New ControllerSegreteria


   Dim tag1 As String = ""
   Dim tag2 As String = ""
   Dim tag3 As String = ""

   Private Sub SetMainButtonsState()
      If optAzienda.Checked Or optUtente.Checked Or optSegreteria.Checked Then
         cmdPrint.Disabled = False
         cmdSend.Disabled = False
      Else
         cmdPrint.Disabled = False
         cmdSend.Disabled = True


      End If
   End Sub

   Private Sub ViewLabels(ByVal view As Boolean)

      lblO.Visible = view
      lblbrower.Visible = view
      lblNew.Visible = view

   End Sub

   Private Sub SetOptionEnablling(ByVal enable As Boolean)

      optAzienda.Enabled = enable
      optSegreteria.Enabled = enable
      optUtente.Enabled = enable
      IdUtenteTextBox1.EnableSerchTextBox = enable
      IdAziendaTextBox1.EnableSerchTextBox = enable

   End Sub

   Private Sub SetAziendaInfoVisible(ByVal visible As Boolean)

      IdAziendaTextBox1.Visible = visible
      lblAzienda.Visible = visible

   End Sub

   Private Sub Initialize()
      optAzienda.Checked = False
      optSegreteria.Checked = False
      optUtente.Checked = False
      DockPanel.Visible = False
      SetMainButtonsState()
      SetLabelBrowserState()
      ViewLabels(False)
      SetAziendaInfoVisible(False)
   End Sub

   Private Sub SetLabelBrowserState()
      If optUtente.Checked Then
         lblbrower.Text = "Naviga verso l'utente selezionato..."
         Return
      End If
      If optAzienda.Checked Then
         lblbrower.Text = "Naviga verso l'azienda selezionata..."
         Return
      End If
      If optSegreteria.Checked Then
         lblbrower.Text = "Naviga verso l'anagrafica della segreteria..."
         Return
      End If
      lblbrower.Text = ""
   End Sub


   Private Sub optUtente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optUtente.CheckedChanged
      SetMainButtonsState()
      SetLabelBrowserState()
      SetAziendaInfoVisible(False)
   End Sub

   Private Sub optAzienda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAzienda.CheckedChanged
      SetMainButtonsState()
      SetLabelBrowserState()
      SetAziendaInfoVisible(True)
   End Sub

   Private Sub optSegreteria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSegreteria.CheckedChanged
      SetMainButtonsState()
      SetLabelBrowserState()
      SetAziendaInfoVisible(False)
   End Sub

   Private Sub ControlCompilazioneModelli1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Initialize()
      SetHeading()
      'Dim listaModelli As IList = GetListaModelli()
      'InterfaceMediator.LoadCombo(cboModello, listaModelli, False)
        con.LoadById("1")

   End Sub


   'Public Function GetListaModelli() As IList
   '   Dim list As IList(Of String) = My.Computer.FileSystem.GetFiles(My.Settings.PathModelli)
   '   Dim list1 As New ArrayList
   '   For Each elem As String In list
   '      Dim info As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(elem)
   '      If (info.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
   '         If info.Extension = ".dot" Or info.Extension = ".dotx" Then
   '            list1.Add(info.Name)
   '         End If
   '      End If
   '   Next
   '   Return list1
   'End Function


   Private Sub SetHeading()
      MasterControl.Instance.ParentForm.Text = "Compilazione modelli precompilati"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Compilazione modelli precompilati"
      Me.lblCurrentFunction.Text = UCase("Compilazione modelli precompilati")
      SelectToolStripImage()
   End Sub

   Private Sub cmdSend_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdSend.DoClik
      Try
         If optAzienda.Checked Or optUtente.Checked Or optSegreteria.Checked Then
            Process()
            ViewLabels(True)
            SetOptionEnablling(False)
            cmdSend.Disabled = True
            'lblbrower.Visible = True
         Else
            MsgBox("Selezionare una opzione di invio!", MsgBoxStyle.Exclamation, "Messaggio")
            Return

         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

   Private Sub lblNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNew.Click
      Initialize()
      SetOptionEnablling(True)
   End Sub

   Private Sub Process()

      CheckInput(False)
      Dim doc As String = GenerateDocument()
      AddToArchive(doc)

      If My.Computer.FileSystem.FileExists(doc) Then
         SimpleFileSystemManager.ViewFile(doc)
      End If

   End Sub

   Private Function GenerateDocument() As String

      Dim dest As String = GetCartellaDestinazione()
      Dim suggestedName As String = GetNomeSuggeritoModello()
      Dim modello As String = lblModello.Text 'My.Settings.PathModelli & "\" & cboModello.Text


      Dim c As New ControllerCompilazioneModelli
      Return c.GenerateDocument(IdUtenteTextBox1.TextValue, modello, GetTagTable(), dest, suggestedName)




   End Function

   Private Function GetNomeSuggeritoModello() As String
      Dim n As String = lblModello.Text
      Dim i As New IO.FileInfo(n)
      n = i.Name

      If n.EndsWith(".dot") Then
         n = n.Replace(".dot", "")
         Return n
      End If

      If n.EndsWith(".dotx") Then
         n = n.Replace(".dotx", "")
         Return n
      End If

      Return "DocumentGenerico"
   End Function

   Private Function GetCartellaDestinazione() As String

      Dim dest As String




      If optAzienda.Checked Then
         dest = controllerAzienda.DirectoryPreferenziale
         If Not My.Computer.FileSystem.DirectoryExists(dest) Then
            dest = con.DirectoryPreferenzialeAziende
         End If
         Return dest
      End If


      If optUtente.Checked Then
         dest = controllerUtente.CartellaPreferenziale
         If Not My.Computer.FileSystem.DirectoryExists(dest) Then
            dest = con.DirectoryPreferenzialeUtenti
         End If
         Return dest
      End If


      Return con.DirectoryPreferenziale
   End Function


   Private Sub AddToArchive(ByVal document As String)

      Dim c As ControllerArchivioDocumentale = Nothing
      If optAzienda.Checked Then
         c = New ControllerArchivioDocumentale(controllerAzienda.Current)
      End If
      If optUtente.Checked Then
         c = New ControllerArchivioDocumentale(controllerUtente.Current)
      End If
      If optSegreteria.Checked Then
         c = New ControllerArchivioDocumentale(con.Current)
      End If

      Dim frm As New FrmDocumentoElettronico(document, c, FrmDocumentoElettronico.DocumentoAction.Insert)
      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
         c.Save()

      Else
         If MsgBox("Operazione annullata dall'utente. Il file generato nella cartella preferenziale deve essere cancellato?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Domanda") = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteFile(document)
         End If
      End If


   End Sub

   Private Sub CheckInput(ByVal onlyPrint As Boolean)

      CheckCampoModello()
      CheckCampoUtente()

      If Not onlyPrint Then
         If optAzienda.Checked Then
            CheckCampoAzienda()
         End If
      End If




   End Sub

   Private Sub CheckCampoModello()

      If lblModello.Text = "" Then
         Throw New ArgumentException("Modello non corretto")
      End If

   End Sub

   Private Sub CheckCampoUtente()
      Try
         controllerUtente.LoadById(IdUtenteTextBox1.TextValue)
      Catch ex As Exception
         Throw New ArgumentException("Id utente non corretto")
      End Try
   End Sub

   Private Sub CheckCampoAzienda()
      Try
         controllerAzienda.LoadById(IdAziendaTextBox1.TextValue)
      Catch ex As Exception
         Throw New ArgumentException("Id azienda non corretto")
      End Try
   End Sub

   Private Sub lblbrower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbrower.Click
      Try
         Dim hash As New Hashtable

         If optUtente.Checked Then
            hash.Add("Id", IdUtenteTextBox1.TextValue)
            Me.NavigateTo("ViewUtente", hash)
            Return
         End If

         If optAzienda.Checked Then
            hash.Add("Id", IdAziendaTextBox1.TextValue)
            Me.NavigateTo("ViewAzienda", hash)
            Return
         End If


         If optSegreteria.Checked Then
            Me.NavigateTo("ViewSegreteria")
            Return
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try


   End Sub

   Private Sub Label3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.DoubleClick
      Try
         Dim hash As New Hashtable
         hash.Add("Id", IdUtenteTextBox1.TextValue)
         NavigateTo("ViewUtente", hash)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
      InterfaceMediator.GetSimpleDescription(controllerUtente, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
   End Sub

   Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
      InterfaceMediator.GetSimpleDescription(controllerAzienda, "Descrizione", Me.lblAzienda, Me.IdAziendaTextBox1.TextValue)
   End Sub

   Private Sub cmdPrint_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
      Try
         CheckInput(True)
         GenearateAndActivateDocument()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub GenearateAndActivateDocument()
      Dim c As New ControllerCompilazioneModelli
      c.GenerateAndActivateTempDocument(IdUtenteTextBox1.TextValue, lblModello.Text, GetTagTable())
   End Sub

   Private Sub cmdTags_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdTags.DoClik
      Dim frmTags As New FrmTagSupplementari(tag1, tag2, tag3)
      frmTags.ShowDialog()

      tag1 = frmTags.Tag1
      tag2 = frmTags.Tag2
      tag3 = frmTags.Tag3

      frmTags.Dispose()
   End Sub


   'Private Function GetModello() As String
   '   'Dim modello As String = My.Settings.PathModelli & "\" & cboModello.Text
   '   'If Not My.Computer.FileSystem.FileExists(modello) Then
   '   '   modello = ""
   '   'End If
   '   'Return modello
   '   Return lblModello.Text
   'End Function

   Private Function GetTagTable() As Hashtable
      Dim hash As Hashtable = InitializeHashTable()
      Return hash
   End Function

   Private Function InitializeHashTable() As Hashtable
      Dim hash As New Hashtable
      hash.Add("@Tag1@", tag1)
      hash.Add("@Tag2@", tag2)
      hash.Add("@Tag3@", tag3)
      Return hash
   End Function

   Private Sub cmdModello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModello.Click
      Try
         Dim frm As New FrmSelezionaModello
         If frm.ShowDialog = DialogResult.OK Then
            lblModello.Text = frm.FileSelezionato
         End If
         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub lblModello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblModello.Click

   End Sub

  
End Class
