Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.IO

Public Class ReportCantieri


    Private m_Lista As IList

    Private fileLayout As String = ""

    Private ControllerIscritti As New WIN.APPLICATION.REPORTING.ReportIscritti
    Private ControllerNonIscrittiCassaEdile As New WIN.APPLICATION.REPORTING.ReportLiberi



    Public Sub New(ByVal ReportingService As Object)

        InitializeComponent()
        m_Lista = DirectCast(ReportingService, IList)
        Me.IdShowedObject = 0
        DoLoad()

    End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", ToId)
        Me.NavigateTo(Link, ParameterList)

    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report cantieri"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report cantieri"
        Me.lblCurrentFunction.Text = UCase("Report cantieri")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report cantieri"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub

    Protected Overrides Sub Nested_PrepareLoading()

        GridControl1.DataSource = m_Lista

    End Sub





    Private Sub cmdPrint_DoClik(Sender As System.Object, e As System.EventArgs) Handles cmdPrint.DoClik
        Try
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridControl1
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As Cantiere = DirectCast(GridView1.GetRow(handle), Cantiere)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub GridView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub


    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As Cantiere = DirectCast(view.GetRow(view.FocusedRowHandle), Cantiere)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal IncaricoDTO As Cantiere)
        Select Case colName
            Case "colNomeAzienda"
                'Navigate(Cantiere.IdUtente, "ViewUtente")
                GetDatiAzienda(IncaricoDTO.NomeAzienda)
            Case "colIdAzienda"
                If Not String.IsNullOrEmpty(IncaricoDTO.IdAzienda) Then
                    Navigate(IncaricoDTO.IdAzienda, "ViewAzienda")
                End If
        End Select
    End Sub

    Private Sub GetDatiAzienda(azienda As String)


        Try

            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")
            'Dim exportProgram As String = "\Export\WIN.WEBCONNECTOR.exe"
            'Dim f As New IO.FileInfo(path)
            'path = f.DirectoryName + exportProgram
            Dim exportProgram As String = "\FenealConnector\WIN.WEBCONNECTOR.exe"


            Dim f As New FileInfo(path)

            'path = f.DirectoryName + file

            path = f.Directory.Parent.FullName + exportProgram

            If Not File.Exists(path) Then
                MessageBox.Show("Funzionalità non installata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If




            'definisco i parametri di apertura del programma
            Dim args As New ProcessStartInfo


            args.Arguments = ConstuctArguments(azienda)



            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try


    End Sub

    Private Function ConstuctArguments(ByVal azienda As String) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"
        Dim chk As String = """chk:no"""

        Dim fil As String = """azi:" + azienda + """"
        Dim com As String = """com:7"""

        result = usn + " " + usp + " " + pro + " " + fil + " " + com + " " + chk


        Return result
    End Function

    Private Sub cmdReportZona_Click(sender As Object, e As EventArgs) Handles cmdReportZona.Click


        Try

            'recupero la lista delle aziend e prese una sola volta
            Dim a As New Hashtable
            For Each elem As Cantiere In m_Lista
                If Not a.ContainsKey(elem.IdAzienda) Then
                    a.Add(elem.IdAzienda, elem.NomeAzienda)
                End If
            Next

            'adesso per ogni azienda valorizzo loggetto report cantiere
            Dim data As New ArrayList

            'devo inserire nella lista tutti gli oggetti report cantiere che calcolo
            Dim enu As IEnumerator = a.GetEnumerator
            While enu.MoveNext
                Dim dentry As DictionaryEntry = CType(enu.Current, DictionaryEntry)
                Dim idAz As Int32 = dentry.Key
                Dim nomAz As String = dentry.Value

                'calcolo il numero degli iscritti
                Dim numIscr As Int32 = CalculateIscritti(idAz)
                Dim numNonIscr As Int32 = CalculateNonIscritti(idAz)

                Dim aa As New ReportZona
                aa.NumLiberi = numNonIscr
                aa.NumIscritti = numIscr
                aa.IdAzienda = idAz
                aa.NomeAzienda = nomAz

                data.Add(aa)
            End While


            'a questo punto posso normalizzare i dati ceando per ogni cantiere lapposito reportzone

            Dim result As New ArrayList

            For Each elem As Cantiere In m_Lista
                Dim aa As New ReportZona
                aa.Provincia = elem.Provincia
                aa.Zona = elem.Zona
                aa.IdAzienda = elem.IdAzienda
                aa.NomeAzienda = elem.NomeAzienda
                aa.Citta = elem.Comune

                aa.NumIscritti = CalculateIscrittiFromData(data, elem.IdAzienda)
                aa.NumLiberi = CalculateNonIscrittiFromData(data, elem.IdAzienda)
                result.Add(aa)
            Next

            Dim frm As New FrmReportZone(result)
            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Function CalculateIscritti(idAz As Integer) As Integer
        ControllerIscritti.SetVerificaDelega(False)
        ControllerIscritti.SetCompetenza(DateTime.Now.AddMonths(-12).Date, DateTime.Now.Date)
        ControllerIscritti.SetSettore("EDILE")
        ControllerIscritti.SetContratto("")
        ControllerIscritti.SetAzienda(idAz)
        ControllerIscritti.SetReferente("")
        ControllerIscritti.SetQuotePrevisionali(False)

        Dim l As IList = ControllerIscritti.SearchDTOs()
        Return l.Count
    End Function
    Private Function CalculateNonIscritti(idAz As Integer) As Integer
        ControllerNonIscrittiCassaEdile.SetEnte("CASSA EDILE")
        ControllerNonIscrittiCassaEdile.SetCompetenza(DateTime.Now.AddMonths(-2).Date, DateTime.Now.Date)
        ControllerNonIscrittiCassaEdile.SetAzienda(idAz)
        ControllerNonIscrittiCassaEdile.SetRicercaErrori(False)

        Dim l As IList = ControllerNonIscrittiCassaEdile.SearchDTOs()
        Return l.Count
    End Function

    Private Function CalculateIscrittiFromData(data As ArrayList, idAz As Integer) As Integer
        For Each elem As ReportZona In data
            If elem.IdAzienda = idAz Then
                Return elem.NumIscritti
            End If
        Next
        Return 0
    End Function

    Private Function CalculateNonIscrittiFromData(data As ArrayList, idAz As Integer) As Integer
        For Each elem As ReportZona In data
            If elem.IdAzienda = idAz Then
                Return elem.NumLiberi
            End If
        Next
        Return 0
    End Function

End Class
