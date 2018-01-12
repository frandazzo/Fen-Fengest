Public Class ItemIncassoQuotaPrevisionale
    Inherits ItemIncassoQuotaAssociativa









#Region "Costruttori"""
    Public Sub New()

    End Sub
    ''' <summary>
    ''' Il costruttore dell'item del pagamento potrà essere usato solo dalla classe documento contabile e 
    ''' specificamente dal metodo AddItem per 
    ''' mantenere la sincronizzazione a causa del riferimento circolare. Il metodo è public per
    ''' consentire ad un mapper di poter instanziare l'oggetto 
    ''' </summary>
    ''' <param name="IncassoQuote"></param>
    ''' <param name="Importo"></param>
    ''' <param name="Competenza"></param>
    ''' <param name="SoggettoEsecutore"></param>
    ''' <param name="Quattordicesima"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal IncassoQuote As DocumentoContabile, ByVal Importo As Moneta, _
                   ByVal Competenza As AbstractPeriodo, ByVal SoggettoEsecutore As Azienda, _
                   ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, ByVal Note As String)

        MyBase.New(IncassoQuote, Importo, Competenza, SoggettoEsecutore, Tredicesima, Quattordicesima, Note)

        
    End Sub
    ''' <summary>
    ''' Il costruttore dell'item del pagamento potrà essere usato solo dalla classe pagamento e 
    ''' specificamente dal metodo AddItem per 
    ''' mantenere la sincronizzazione a causa del riferimento circolare. Il metodo è public per
    ''' consentire ad un mapper di poter instanziare l'oggetto
    ''' </summary>
    ''' <param name="Utente"></param>
    ''' <param name="IncassoQuote"></param>
    ''' <param name="Importo"></param>
    ''' <param name="Referente"></param>
    ''' <param name="Note"></param>
    ''' <param name="Competenza"></param>
    ''' <param name="Tredicesima"></param>
    ''' <param name="Quattordicesima"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Utente As IUtente, ByVal IncassoQuote As DocumentoContabile, _
                   ByVal Importo As Moneta, ByVal Referente As Referente, ByVal SoggettoEsecutore As Azienda, _
                   ByVal Note As String, ByVal Competenza As AbstractPeriodo, _
                   ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, Optional ByVal NotCheckPaybility As Boolean = False, Optional ByVal SedeOperativa As SedeOperativa = Nothing)

        MyBase.New(IncassoQuote, Note, Importo, Utente.Conto)

        If Utente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa con un utente nullo")
        If TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un utente")
        If Referente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativaa con un referente nullo")
        'If TypeOf (Referente) Is ReferenteNullo Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un referente")
        If SoggettoEsecutore Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativaa con un Soggetto Esecutore nullo")
        If TypeOf (SoggettoEsecutore) Is AziendaNonSpecificata Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un Soggetto Esecutore")



        MyBase.m_TipoDocumento = IncassoQuote.TipoDocumento
        MyBase.m_settore = DirectCast(IncassoQuote, IncassoQuotaPrevisionale).Settore
        m_Utente = Utente
        If Competenza.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare una posizione di pagamento con una competenza negativa o vuota")
        m_Competenza = Competenza
        m_PosizioneUtente = True
        m_Referente = Referente
        m_TredicesimaInclusa = Tredicesima
        m_QuattordicesimaInclusa = Quattordicesima
        m_SoggettoEsecutore = SoggettoEsecutore
        If MyBase.m_settore.TipologiaSettore = FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
            MyBase.AziendaImpiego = SoggettoEsecutore
            If SedeOperativa Is Nothing Then
                MyBase.SetSedeOperativa(Utente.GetActiveDelegaFor(SoggettoEsecutore, Competenza.GetDataRange.Finish).SedeOperativa)
            Else
                MyBase.SetSedeOperativa(SedeOperativa)
            End If
            'MyBase.ContrattoApplicato = SoggettoEsecutore.ContrattoApplicato
        End If
        
    End Sub
#End Region




    '*************************************
    '*************************************

 


#Region "Metodo per la gestione della transazione relativa alla registraiozne della posizione"

    ''' <summary>
    ''' '''non fa nulla
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overrides Sub DoPost()
        'If m_PosizioneUtente Then
        '    ' m_Utente.ActivateDelega(Me.SoggettoEsecutore, MyBase.m_DocumentoPadre)
        '    'm_Utente.ChangeSedeOperativa(Me.SoggettoEsecutore, Me.Competenza.GetDataRange.Finish, Me.SedeOperativaAzienda)
        'Else
        '    ' m_SoggettoEsecutore.CompetenzaUltimoPagamento = m_Competenza
        'End If
    End Sub

#End Region
End Class
