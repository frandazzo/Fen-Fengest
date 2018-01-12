Public Class FrmPrintAziendeInListaLavoro
    Private Controller1 = New WIN.APPLICATION.REPORTING.ReportIncassiQuote
    Private m_list As IList
    Public Sub New(list As IList)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        cmbAnno.Text = DateTime.Now.Year
        m_list = list
    End Sub

    Private Sub CalculateAziende(anno As String, executeCalulation As Boolean)
        If Not executeCalulation Then
            Return
        End If

        Controller1.IsIQAIncluded(True)
        Controller1.IsIQIIncluded(False)
        Controller1.IsIQVIncluded(False)
        Controller1.IsIQPIncluded(False)

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", False)
        parameterMap.Add("IntervalloDocumento", False)
        parameterMap.Add("ListaSoggetti", False)

        parameterMap.Add("CompetenzaQuote", True)

        Controller1.SetCompetenzaIncassiQuote(New DateTime(Convert.ToInt32(anno) - 1, 10, 1), New DateTime(Convert.ToInt32(anno), 9, 30))


        Controller1.SetSettore("EDILE")

        Controller1.SetNewSerchConditions(parameterMap)


        Dim SearchList As IList = Controller1.Search

        Dim h As New Hashtable
        'ottenuta la lista delle quote metto in una hash table per id lavoratore
        For Each elem As Quota In SearchList
            If Not h.ContainsKey(elem.IdUtente) Then
                If Not String.IsNullOrEmpty(elem.AziendaImpiego) Then
                    h.Add(elem.IdUtente, elem.AziendaImpiego)
                End If
            End If
        Next

        'adesso per ogni utente della lista inserisco nelle note lazienda se cè
        For Each elem As UtenteDTO In m_list
            If h.ContainsKey(elem.Id.ToString) Then
                elem.Note = h(elem.Id.ToString)
            Else
                elem.Note = ""
            End If
        Next
       


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateAziende(cmbAnno.Text, CheckBox3.Checked)
        Me.Close()
    End Sub
End Class