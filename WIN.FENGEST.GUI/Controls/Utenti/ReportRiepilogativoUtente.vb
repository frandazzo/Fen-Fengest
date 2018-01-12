Imports System.Windows.Forms
Public Class ReportRiepilogativoUtente

    Private m_idAziendaImpiego As String = ""
    Private m_AziendaImpiego As String = ""
    Private m_IdSoggetto As String = ""
    Private m_iscritto As Boolean = False

    Public ReadOnly Property Iscritto() As Boolean
        Get
            Return m_iscritto
        End Get
    End Property


    Public ReadOnly Property IdAziendaImpiego() As String
        Get
            Return m_idAziendaImpiego
        End Get
    End Property


    Public ReadOnly Property AziendaImpiego() As String
        Get
            Return m_AziendaImpiego
        End Get
    End Property

    Public ReadOnly Property IdSoggetto() As String
        Get
            Return m_IdSoggetto
        End Get
    End Property


    Public Sub SetEticheteRiepiloghi(ByVal lblAziendaImpiego As Label, ByVal lblSettore As Label, ByVal lblPeriodo As Label, ByVal lblSoggetto As Label, ByVal idOggetto As String)
        Dim ControllerIQA As New WIN.APPLICATION.REPORTING.ReportIncassiQuote
        Dim quota As Quota

        m_idAziendaImpiego = ""
        m_IdSoggetto = ""



        SetSearchCondition(ControllerIQA, idOggetto)
        ControllerIQA.Search()
        ControllerIQA.SortItems("DataDocumento", True)

        If ControllerIQA.SearchResult.Count = 0 Then
            lblAziendaImpiego.Text = "Nessun versamento effettuato"
            lblSettore.Text = "Nessun versamento effettuato"
            lblPeriodo.Text = "Nessun versamento effettuato"
            lblSoggetto.Text = "Nessun versamento effettuato"

        Else
            quota = ControllerIQA.SearchResult(0)
            lblAziendaImpiego.Text = quota.AziendaImpiego
            m_AziendaImpiego = quota.AziendaImpiego
            lblSettore.Text = quota.Settore
            lblPeriodo.Text = quota.Competenza.ToString
            lblSoggetto.Text = quota.SoggettoEsecutore
            m_idAziendaImpiego = quota.IdAziendaImpiego
            m_IdSoggetto = quota.IdSoggettoEsecutore


        End If
    End Sub




    Private Sub SetSearchCondition(ByVal ControllerIQA As WIN.APPLICATION.REPORTING.ReportIncassiQuote, ByVal idOggetto As String)
        ControllerIQA.IsIQAIncluded(True)
        ControllerIQA.IsIQIIncluded(False)
        ControllerIQA.IsIQVIncluded(False)


        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", False)
        parameterMap.Add("IntervalloDocumento", False)
        parameterMap.Add("ListaSoggetti", True)
        parameterMap.Add("CompetenzaQuote", False)






        Dim listaUtenti As New ArrayList
        listaUtenti.Add(idOggetto)
        ControllerIQA.SetListaUtenti(listaUtenti)
        ControllerIQA.SetSettore("")
        ControllerIQA.SetEnte("")
        ControllerIQA.SetContratto("")
        ControllerIQA.SetAzienda("")
        ControllerIQA.SetEnte("")
        ControllerIQA.SetReferenteId("")
        ControllerIQA.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)

        ControllerIQA.SetNewSerchConditions(parameterMap)


    End Sub










    Public Sub SetEticheteIscrizione(ByVal lblIscrizione As Label, ByVal PictureBox3 As PictureBox, ByVal idOggetto As String)

        Dim ControllerIscritti As New WIN.APPLICATION.REPORTING.ReportIscritti
        SetSearchConditionIscritti(ControllerIscritti, True, idOggetto)
        ControllerIscritti.SearchDTOs()


        If ControllerIscritti.SearchResult.Count > 0 Then
            lblIscrizione.Text = "ISCRITTO nell'anno in corso"
            PictureBox3.BackgroundImage = My.Resources.HEINS_QUANTUM_FOLDERS_ADRESSES
            m_iscritto = True
        Else
            ControllerIscritti = New WIN.APPLICATION.REPORTING.ReportIscritti
            SetSearchConditionIscritti(ControllerIscritti, False, idOggetto)
            ControllerIscritti.SearchDTOs()
            If ControllerIscritti.SearchResult.Count > 0 Then
                lblIscrizione.Text = "ISCRITTO nell'anno in corso. Delega non verificata"
                PictureBox3.BackgroundImage = My.Resources.HEINS_QUANTUM_FOLDERS_CAUTION
                m_iscritto = True
            Else
                lblIscrizione.Text = "NON ISCRITTO nell'anno in corso"
                PictureBox3.BackgroundImage = My.Resources.HEINS_QUANTUM_FOLDERS_STOP
                m_iscritto = False
            End If

        End If
    End Sub



    Private Sub SetSearchConditionIscritti(ByVal ControllerIscritti As WIN.APPLICATION.REPORTING.ReportIscritti, ByVal verificaDelega As Boolean, ByVal IdOggetto As String)



        Dim parameterMap As New Hashtable
        parameterMap.Add("ListaSoggetti", True)


        Dim listaUtenti As New ArrayList
        listaUtenti.Add(IdOggetto)
        ControllerIscritti.SetListaUtenti(listaUtenti)
        ControllerIscritti.SetVerificaDelega(verificaDelega)
        ControllerIscritti.SetCompetenza(DateTime.Now.AddYears(-1), DateTime.Now)
        ControllerIscritti.SetSettore("")
        ControllerIscritti.SetContratto("")
        ControllerIscritti.SetAzienda("")
        ControllerIscritti.SetReferente("")
        ControllerIscritti.SetNewSerchConditions(parameterMap)


    End Sub
End Class
