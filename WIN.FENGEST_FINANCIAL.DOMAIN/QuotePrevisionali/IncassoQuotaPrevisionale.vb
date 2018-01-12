Public Class IncassoQuotaPrevisionale
    Inherits IncassoQuotaAssociativa
    
    Public Overrides Sub AddItem(ByVal Utente As IUtente, ByVal Importo As Double, ByVal Competenza As AbstractPeriodo, ByVal Referente As Referente, ByVal Note As String, Optional ByVal NotCheckPaybility As Boolean = False)
        If Not ExistSimilarItemTo(GetItemListByUtente(Utente), Competenza) Then
            m_Items.Add(New ItemIncassoQuotaPrevisionale(Utente, Me, New Moneta(Importo, m_Valuta).Negate, Referente, SoggettoEsecutore, Note, Competenza, False, False, NotCheckPaybility))
        Else
            Throw New Exception("Non è possibile aggiungere una nuova posizione al documento perchè la competenza si sovrappone a quella di un'altra posizione per lo stesso utente ")
        End If
        'Se  aggiungo una posizione cambio il totale .
        ' l'importo è necessario per pareggiare è il totale.
        'uso la proprietà importo per paggiornare la posizione di contropartita
        'If m_IsPosted Then

        Me.Importo = Me.Importo.Add(New Moneta(Importo, m_Valuta))
    End Sub


#Region "Costruttori"

    Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, ByVal SoggettoEsecutore As Azienda, _
                    ByVal PeriodoCompetenza As AbstractPeriodo, ByVal Note As String, _
                    ByVal Valuta As Moneta.Valuta, ByVal Importo As Double, ByVal Settore As Settore, _
                    Optional ByVal AddDefaultItem As Boolean = False)

        MyBase.DataRegistrazione = DataRegistrazione
        MyBase.DataDocumento = DataDocumento
        MyBase.Note = Note


        If SoggettoEsecutore Is Nothing Then Throw New Exception("Impossibile costruire un oggetto pagamento con un soggetto esecutore nullo!")
        If TypeOf (SoggettoEsecutore) Is AziendaNonSpecificata Then Throw New Exception("Impossibile costruire un oggetto pagamento con un soggetto esecutore di tipo nullo!")
        If PeriodoCompetenza Is Nothing Then Throw New Exception("Impossibile costruire un oggetto pagamento con un periodo di competenza nullo!")
        If PeriodoCompetenza.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare un pagamento con una competenza negativa o vuota")
        If Settore Is Nothing Then Throw New Exception("Impossibile crearee l'incasso delle quote associative. Settore nullo")
        If Settore.Id = -1 Then Throw New Exception("Impossibile creare l'incasso delle quote associative. Tipo settore nullo")
        m_settore = Settore

        MyBase.m_TipoDocumento = "IQP"
        m_Valuta = Valuta
        m_importo = New Moneta(Importo, m_Valuta)
        If m_settore.EnteCoerenteConSettore(SoggettoEsecutore) Then
            m_SoggEsecutore = SoggettoEsecutore
        Else
            Throw New Exception("Impossibile creare un incasso quota associativa. Soggetto esecutore non appartenete al settore specifico.")
        End If

        'm_competenzaUltimoPagamento = SoggettoEsecutore.CompetenzaUltimoPagamento
        m_competenza = PeriodoCompetenza

        If Not AddDefaultItem Then
            m_Items.Add(New ItemIncassoQuotaPrevisionale(Me, New Moneta(Importo, m_Valuta), m_competenza, m_SoggEsecutore, False, False, Note))
        End If
    End Sub
    Public Sub New()
        MyBase.New()
        MyBase.m_TipoDocumento = "IQP"
    End Sub

#End Region





End Class
