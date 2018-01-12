Public Class ItemIncassoQuoteInps
   Inherits ItemIncassoQuotaAssociativa

   Public Sub New(ByVal IncassoInps As DocumentoContabile, ByVal Importo As Moneta, _
                  ByVal Competenza As AbstractPeriodo, ByVal Inps As Inps, _
                  ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, ByVal Note As String)

      MyBase.New(IncassoInps, Importo, Competenza, Inps, Tredicesima, _
                 Quattordicesima, Note)

   End Sub
   Public Sub New(ByVal Utente As IUtente, ByVal IncassoInps As DocumentoContabile, _
                    ByVal Importo As Moneta, ByVal Referente As Referente, ByVal Inps As Inps, _
                    ByVal Note As String, ByVal Competenza As AbstractPeriodo, _
                    ByVal Tredicesima As Boolean, ByVal Quattordicesima As Boolean, ByVal Prestazione As IDocumento)



      If Utente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota Inps con un utente nullo")
      If TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Non è possibile costruire una posizione di incasso quota Inps senza specificare un utente")
      If Referente Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota Inps con un referente nullo")
      'If TypeOf (Referente) Is ReferenteNullo Then Throw New Exception("Non è possibile costruire una posizione di incasso quota associativa senza specificare un referente")
      If Inps Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota Inps con un Soggetto Esecutore nullo")
      If Inps.TipologiaAzienda <> Azienda.TipoAzienda.Inps Then Throw New Exception("Impossibile costruire un oggetto incasso quota Inps con un tipo azienda diverso dall'Inps!")
      If Prestazione Is Nothing Then Throw New Exception("Non è possibile costruire una posizione di incasso quota Inps con una prestazione nulla")
      If Prestazione.GetId = -1 Then Throw New Exception("Non è possibile costruire una posizione di incasso quota Inps con un tipo prestazione nullo")


      MyBase.m_DocumentoPadre = IncassoInps
      MyBase.m_note = Note
      MyBase.m_Importo = Importo
      MyBase.m_Conto = Utente.Conto
      MyBase.DataDocumento = IncassoInps.DataDocumento
      MyBase.DataRegistrazione = IncassoInps.DataRegistrazione
      MyBase.m_TipoDocumento = IncassoInps.TipoDocumento
      MyBase.m_settore = DirectCast(IncassoInps, IncassoQuotaAssociativa).Settore
      m_Utente = Utente
      'If Competenza.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare una posizione di quota Inps con una competenza negativa o vuota")
      m_Competenza = Competenza
      m_PosizioneUtente = True
      m_Referente = Referente
      m_TredicesimaInclusa = Tredicesima
      m_QuattordicesimaInclusa = Quattordicesima
      m_SoggettoEsecutore = Inps
      m_prestazione = Prestazione
      m_SoggettoEsecutore.CheckCongruity(Me)
   End Sub

   'Public Overrides Property Competenza() As AbstractPeriodo
   '   Get
   '      Return m_Competenza
   '   End Get
   '   Set(ByVal value As AbstractPeriodo)


   '      If value.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare o impostare un pagamento con una competenza negativa o vuota")
   '      If Not DirectCast(DocumentoPadre, IncassoQuotaInps).ExistSimilarItemsForUtente(MyBase.m_Utente, Me, value, Me.m_prestazione) Then
   '         m_Competenza = value
   '         If m_PosizioneUtente Then
   '            m_SoggettoEsecutore.CheckCongruity(Me)
   '         End If
   '      Else
   '         Throw New Exception("Impossibile impostare il nuovo valore per la competenza. Essa interseca la competenza di una posizione già esistente per lo stesso utente.")
   '      End If

   '   End Set
   'End Property
   
   Protected Overrides Sub CheckExistenceSimilar(ByVal Value As BASEREUSE.AbstractPeriodo)
      If Not DirectCast(DocumentoPadre, IncassoQuotaInps).ExistSimilarItemsForUtente(MyBase.m_Utente, Me, Value, Me.m_prestazione) Then
         m_Competenza = Value
      Else
         Throw New Exception("Impossibile impostare il nuovo valore per la competenza. Essa interseca la competenza di una posizione già esistente per lo stesso utente.")
      End If
   End Sub

   Protected Overrides Sub DoPost()
      If Not m_PosizioneUtente Then
         m_SoggettoEsecutore.CompetenzaUltimoPagamento = m_Competenza
      End If
   End Sub
   Protected Overrides Sub DoValidation()
      'If Not MyBase.IsValid() Then
      '   ValidationErrors.Add("Errore nella validazione")
      'End If
      If Competenza.GetDataRange.IsEmpty Then
         ValidationErrors.Add("Non è possibile validare una posizione di quota Inps con una competenza negativa o vuota. Posizione dell'utente " & Me.m_Utente.CompleteName & "con id prestazione =" & Me.m_prestazione.GetId)
      End If
   End Sub
End Class
