Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES.FenealgestImportExport
Imports WIN.TECHNICAL.MIDDLEWARE.XmlSerializzation
Imports System.IO
Imports System.Text

Public Class FrmImportExport
    Dim controller As New ControllerImportExport


    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        GridControl1.DataSource = controller.GetAllImportExports

    End Sub


    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = DirectCast(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub

    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRowCell = True Then
            Dim colName As String = info.Column.Name
            Dim s As ImportExport = DirectCast(view.GetRow(view.FocusedRowHandle), ImportExport)
            GotoView(colName, s)
            ' MessageBox.Show(colName + ". elemento anagrafica: cognome = " + s.Cognome)
        End If
    End Sub

    Private Sub GotoView(ByVal colName As String, ByVal importExport As ImportExport)
        Try
            Select Case colName

                Case "colLogFilePath"
                    Process.Start(importExport.LogFilePath)

                Case "colImportedFile"
                    Process.Start(importExport.ImportedFile)
                Case Else
                    If importExport.Type = FEDERATIONARTIFACTS.ImportExport.ElaborationType.Liberi Then
                        'cliccando due volte invio la richiesta di visulizzazione dei codici fiscali al dbnazionale
                        Dim a As LiberiTrace = ObjectXMLSerializer(Of LiberiTrace).Load(importExport.ImportedFile)

                        'costruisco la riga di comando
                        Dim args As String = ConstuctArguments(a)

                        ShowConnector(args)

                    End If
            End Select
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Function ConstuctArguments(libr As LiberiTrace) As String
        Dim result As String = ""


        Dim credenziali As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()

        Dim usn As String = """usn:" + credenziali.UserName + """"
        Dim usp As String = """usp:" + credenziali.Password + """"
        Dim pro As String = """pro:" + credenziali.Provincia + """"


        Dim chk As String = """chk:no"""
        Dim com As String = """com:3"""




        'creo la stringa dei codici fiscali
        Dim cf As String = CreateFiscalCodesFile(libr)

        Dim flc As String = """flc:" + cf + """"


        result = usn + " " + usp + " " + pro + " " + chk + " " + com + " " + flc


        Return result
    End Function


    Private Function CreateFiscalCodesFile(libr As LiberiTrace) As String


        Dim file As String = System.IO.Path.GetTempPath + "temp1.txt"



        Dim res As String = ""

        Dim i As Int32 = 0

        For Each elem As LiberiTraceDetail In libr.LiberiTraceDetails


            Dim cf As String = elem.FISCALE.Trim

            'tolgo eventuali spazi
            cf.Replace(" ", "")

            If Not String.IsNullOrEmpty(cf) Then
                res = res + " " + cf
            End If



            i = i + 1
        Next

        IO.File.Delete(file)
        IO.File.AppendAllText(file, res)


        Return file
    End Function

    Private Sub ShowConnector(args1 As String)
        Try


            WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere recupero informazioni...", My.Resources.Waiting3)

            'recupero il percorso del programma di export
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")


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
            args.Arguments = args1

            'passo il nome del programma da avviare
            args.FileName = path

            'avvio il programma
            Process.Start(args)



        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            WIN.GUI.UTILITY.Helper.HideWaitBox()
        End Try

    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If e.Column.Name = "colResult" Then
            Dim app As ImportExport = DirectCast(GridView1.GetRow(e.RowHandle), ImportExport)

            e.DisplayText = app.Result.ToString



        End If





    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim list As IList = DirectCast(GridControl1.DataSource, IList)


        Dim iqaTraces As IList(Of IQATrace) = New List(Of IQATrace)
        Dim liberiTraces As IList(Of LiberiTrace) = New List(Of LiberiTrace)

        Dim feneal As Hashtable = New Hashtable
        Dim filca As Hashtable = New Hashtable
        Dim fillea As Hashtable = New Hashtable
        Dim codici0 As Hashtable = New Hashtable

        'popolo la lista con le relative tracce
        PopulateListOfTraces(list, iqaTraces, liberiTraces)

        'adesso devo ciclare sulle tracce iqa ed aggiungere una copia del codice fiscale come chiave
        'alla fine contando le chiavi avro' il num univoco di codici fiscali presenti
        For Each elem As IQATrace In iqaTraces
            For Each data As IqaTraceDetail In elem.IqaTraceDetails
                If Not String.IsNullOrEmpty(data.FISCALE) Then
                    If Not feneal.ContainsKey(data.FISCALE) Then
                        feneal.Add(data.FISCALE, 1)
                    End If
                End If
            Next
        Next

        'faccio la stessa cosa sui non iscritti verificando pero il campo iscritto a e inserendolo nella rispettiva lista

        For Each elem As LiberiTrace In liberiTraces
            For Each data As LiberiTraceDetail In elem.LiberiTraceDetails
                If Not String.IsNullOrEmpty(data.FISCALE) Then
                    If data.ISCRITTO_A.Equals("") Then
                        If Not codici0.ContainsKey(data.FISCALE) Then
                            codici0.Add(data.FISCALE, 1)
                        End If
                    ElseIf data.ISCRITTO_A.Equals("FILCA") Then
                        If Not filca.ContainsKey(data.FISCALE) Then
                            filca.Add(data.FISCALE, 1)
                        End If

                    Else
                        If Not fillea.ContainsKey(data.FISCALE) Then
                            fillea.Add(data.FISCALE, 1)
                        End If

                    End If
                End If
            Next
        Next

        ' a questo punto posso scrivere il report
        Dim numFeneal As Int32 = feneal.Keys.Count
        Dim numFilca As Int32 = filca.Keys.Count
        Dim numFillea As Int32 = fillea.Keys.Count
        Dim numCodici0 As Int32 = codici0.Keys.Count

        Dim somma As Int32 = numFeneal + numFilca + numFillea
        Dim sommaTotale As Int32 = numFeneal + numFilca + numFillea + numCodici0
       

        Dim sb As New StringBuilder
        sb.AppendLine(String.Format("Il numero degli iscritti feneal per le importazioni considerate è {0}", numFeneal))
        sb.AppendLine(String.Format("Il numero degli iscritti filca per le importazioni considerate è {0}", numFilca))
        sb.AppendLine(String.Format("Il numero degli iscritti fillea per le importazioni considerate è {0}", numFillea))
        sb.AppendLine(String.Format("Il numero degi codici 0 per le importazioni considerate è {0}", numCodici0))
        sb.AppendLine("")
        'se sono valorizzati gli iscritti e almeno uno dei due (filca o fillea) non iscritti allora aggiungo una analisi della rappresentatività

        If numFeneal > 0 And (numFilca > 0 Or numFillea > 0) Then

            Dim rappFeneal As Decimal = numFeneal / somma
            sb.AppendLine(String.Format("La rappresentatività della Feneal è del {0}%", Math.Round(rappFeneal * 100, 2)))

            If (numFilca > 0) Then
                Dim rappFilca As Decimal = numFilca / somma
                sb.AppendLine(String.Format("La rappresentatività della Filca è del {0}%", Math.Round(rappFilca * 100, 2)))

            End If

            If (numFillea > 0) Then
                Dim rappFillea As Decimal = numFillea / somma
                sb.AppendLine(String.Format("La rappresentatività della Fillea è del {0}%", Math.Round(rappFillea * 100, 2)))

            End If

        End If

        sb.AppendLine("")

        If numFeneal > 0 And numFilca > 0 And numFillea > 0 And numCodici0 > 0 Then
            Dim sind As Decimal = somma / sommaTotale
            sb.AppendLine(String.Format("Il tasso di sindacalizzazione è del {0}%", Math.Round(sind * 100, 2)))

        End If


        MessageBox.Show(sb.ToString, "Fenealgest", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub PopulateListOfTraces(ListOfTraces As IList, iqaTraces As IList(Of IQATrace), liberiTraces As IList(Of LiberiTrace))
        For Each elem As ImportExport In ListOfTraces
            If elem.Selected = True Then

                If File.Exists(elem.ImportedFile) Then

                    If elem.Type = ImportExport.ElaborationType.IQA Then




                        Dim m_iqaTrace As IQATrace = ObjectXMLSerializer(Of IQATrace).Load(elem.ImportedFile)
                        iqaTraces.Add(m_iqaTrace)



                    ElseIf elem.Type = ImportExport.ElaborationType.Liberi Then



                        Dim m_liberiTrace As LiberiTrace = ObjectXMLSerializer(Of LiberiTrace).Load(elem.ImportedFile)
                        liberiTraces.Add(m_liberiTrace)



                    End If
                End If



            End If


        Next
    End Sub
End Class