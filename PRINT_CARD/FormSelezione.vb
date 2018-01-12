Imports WIN.APPLICATION
Imports WIN.GUI.APPLICATION

Imports WIN.DOMAIN.FEDERATIONARTIFACTS
Imports WIN.GUI.APPLICATION.PRESENTATION
Imports DevExpress.XtraPrinting
Imports WIN.GUI.UTILITY

Public Class FormSelezione
    Dim gestore As New Gestore
    Dim lista1 As ArrayList



    Private m_nome As String = ""
    Private m_cognome As String = ""
    Private m_azienda As String = ""
    Private m_comune As String = ""
    Private m_addressOK As Boolean = False
    Private m_aziendeNulle As Boolean = False


    Private Sub FormSelezione_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (federProv = "BOLZANO") Then
                cboSettore.Visible = True

            Else
                cboSettore.Visible = False
            End If

            gestore.LoadAllTesserati(4)
            LoadGriglia()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub LoadGriglia()

        Dim lista As ArrayList = gestore.Lista
        Me.Text = "Record trovati: " & lista.Count

        GridPosizioni.DataSource = lista

    End Sub


    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As Tesserato1 = DirectCast(GridView1.GetRow(handle), Tesserato1)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function


    Private Sub EseguiAggiornamentoCampoAzienda(ByVal testo As String, ByVal lista As IList)
        gestore.EseguiAggiornemtnoAziende(testo, lista)
    End Sub



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim frm11 As New FrmCambiaAziende
            If frm11.ShowDialog = Windows.Forms.DialogResult.OK Then
                If MessageBox.Show("Sicuro di cambiare tutte le aziende con il testo selezionato?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    EseguiAggiornamentoCampoAzienda(frm11.Testo, GetVisuibleRecords)
                    ' gestore.LoadTesseratiByCriteria(m_nome, m_cognome, frm11.Testo, m_comune, m_addressOK, m_aziendeNulle)
                    'GridView1.BeginSort()
                    'GridView1.EndSort()
                    gestore.LoadAllTesserati(4)
                    LoadGriglia()
                End If
            End If
            frm11.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub lnkConfigura_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    'Try
    '    '    Dim frm As New FormConfigurazione
    '    '    frm.ShowDialog()
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    'End Try
    'End Sub

    Private Sub lnkStampa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkStampa.LinkClicked
        Try
            If cboSettore.Visible Then
                settore = cboSettore.Text
            Else
                settore = ""
            End If


            Helper.ShowWaitBox("Creazione file in corso...", My.Resources.Waiting3)

            gestore.Stampa(GetVisuibleRecords())

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub



    Private Sub lnkRipristina_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRipristina.LinkClicked
        Try

            If MessageBox.Show("Sicuro di ripristinare l'azienda per tutte le aziende?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                EseguiRipristinoCampoAzienda()
                gestore.LoadAllTesserati(4)
                LoadGriglia()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub EseguiRipristinoCampoAzienda()
        gestore.EseguiRipristinoCampoAziende()
    End Sub

    Private Sub lnkCreateList_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreateList.LinkClicked
        Try


            Dim frm As New FrmDescrListaLavoro
            frm.ShowDialog()
            Dim descr As String = frm.Descrizione

            If frm.DialogResult = DialogResult.OK Then
                Dim controllerListe As New ControllerListaUtenti
                controllerListe.CreateNew()
                controllerListe.Descrizione = descr

                For Each elem As Tesserato1 In GetVisuibleRecords()
                    controllerListe.AddUtente(elem.IdUtente)
                Next
                controllerListe.Save()
                MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub lnkExport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkExport.LinkClicked
        Try
            'Creo la lista di lavoro
            Dim l As ListaLavoroUtenti

            Dim c As New ControllerListaUtenti

            c.CreateNew()

            For Each elem As Tesserato1 In GetVisuibleRecords()
                c.AddUtente(elem.IdUtente)
            Next

            l = c.Current

            Dim frm As New PRESENTATION.FrmExportLista(l)

            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Dim frm As New FrmExportEtichette(CreaListaTessere, "Tessere", "Tessere_", "@Nome@")

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Helper.ShowWaitBox("Notifica tessere stampate in corso...", My.Resources.Waiting3)
                For Each elem As Tesserato1 In GetVisuibleRecords()
                    gestore.InsertTesseraStampata(elem)
                Next

            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub

    Private Function CreaListaTessere() As IList(Of Hashtable)
        Dim l As New List(Of Hashtable)

        For Each elem As Tesserato1 In GetVisuibleRecords()
            Dim h As New Hashtable
            h.Add("@Nome@", elem.Nome.ToUpper)
            h.Add("@Cognome@", elem.Cognome.ToUpper)
            h.Add("@Azienda@", elem.Azienda.ToUpper)
            h.Add("@Provincia@", "FENEAL " + federProv.ToUpper)
            l.Add(h)

        Next

        Return l
    End Function


    Private Sub lnkImport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkImport.LinkClicked
        Try

            Dim frm As New FrmSelezionaListaLavoro
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If frm.ListaLavoro IsNot Nothing Then
                    Helper.ShowWaitBox("Importazione lista in corso...", My.Resources.Waiting3)
                    LoadLista(frm.ListaLavoro)
                    gestore.LoadAllTesserati(1)
                    LoadGriglia()
                End If
            End If
            frm.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub


    Private Sub LoadLista(ByVal Lista As ListaLavoroUtenti)
        Dim c As New ControllerListaUtenti
        c.SetCurrent(Lista)
        c.StampaTessereLista()
    End Sub


    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ' GridPosizioni.ShowPrintPreview()
        Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
        link.Component = GridPosizioni
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.ShowPreview()
    End Sub
End Class