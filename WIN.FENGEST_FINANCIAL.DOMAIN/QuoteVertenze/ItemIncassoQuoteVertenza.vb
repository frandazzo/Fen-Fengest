Public Class ItemIncassoQuoteVertenza
   Inherits ItemContabile
   Private m_posizioneUtente As Boolean = False
   Public ReadOnly Property PosizioneUtente() As Boolean
      Get
         Return m_posizioneUtente
      End Get
   End Property
   Public Sub New(ByVal IncassoVertenza As DocumentoContabile, ByVal Importo As Moneta, _
                  ByVal Conto As Conto, ByVal Note As String)

      MyBase.New(IncassoVertenza, Note, Importo, Conto)
      'MyBase.m_DocumentoPadre = IncassoVertenza
      'MyBase.m_note = Note
      'MyBase.m_Importo = Importo
      'MyBase.m_Conto = Conto
      MyBase.m_TipoDocumento = IncassoVertenza.TipoDocumento

   End Sub
   Public Sub New(ByVal Utente As IUtente, ByVal IncassoVertenza As IncassoQuotaVertenza, _
                    ByVal Importo As Moneta, ByVal Referente As Referente, _
                    ByVal Note As String, ByVal Vertenza As IDocumento)



      If Utente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota vertenza con un utente nullo")
      If TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Non è possibile costruire una posizione di incasso quota vertenza senza specificare un utente")
      If Utente.IdUtente <> IncassoVertenza.Utente.Id Then Throw New Exception("Non è possibile costruire una posizione di incasso quota vertenza  specificando un utente diverso rispetto alla testata del documento")
      If Referente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota vertenza con un referente nullo")
      'If TypeOf (Referente) Is ReferenteNullo Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un referente")
      If Vertenza Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota vertenza con una vertenza nulla")
      If Vertenza.GetId = -1 Then Throw New Exception("Non è possibile costruire una posizione di incasso quota vertenza con un tipo vertenza nullo")


      MyBase.m_DocumentoPadre = IncassoVertenza
      MyBase.m_note = Note
      MyBase.m_Importo = Importo
      MyBase.m_Conto = Utente.Conto
      MyBase.DataDocumento = IncassoVertenza.DataDocumento
      MyBase.DataRegistrazione = IncassoVertenza.DataRegistrazione
      MyBase.m_TipoDocumento = IncassoVertenza.TipoDocumento
      m_Utente = Utente
      m_posizioneUtente = True
      m_Referente = Referente
      m_Vertenza = Vertenza
   End Sub

   
   Public Overrides Property Referente() As Referente
      Get
         Return m_Referente
      End Get
      Set(ByVal value As Referente)
         If value Is Nothing Then Throw New Exception("Impossibile impostare il referente per la posiizone incasso quota. Referente Nullo")
         If value.Id = m_Referente.Id Then Exit Property
         If Me.PagamentoReferente.Id = -1 Then
            m_Referente = value
         Else
            Throw New Exception("Impossibile impostare il referente per laposizione. Esiste un ristorno referente associato.")
         End If
      End Set
   End Property


   Protected Overrides Sub DoPost()
      'If Not m_PosizioneUtente Then
      '   m_SoggettoEsecutore.CompetenzaUltimoPagamento = m_Competenza
      'End If
   End Sub
End Class
