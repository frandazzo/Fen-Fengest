Public Class StAnnullata
   Implements IStatusDelega


   Public ReadOnly Property StatusName() As String Implements IStatusDelega.StatusName
      Get
         Return "Annullata"
      End Get
   End Property

   Public Shared Function Instance() As StAnnullata
      Return New StAnnullata
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta


   End Sub
   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva


   End Sub
   Public Sub Inoltra(ByVal DataInoltro As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Inoltra


   End Sub
   Public Sub Rifiuta(ByVal Delega As Delega) Implements IStatusDelega.Rifiuta


   End Sub
   Public Sub Revoca(ByVal Delega As Delega, ByVal Causale As CausaleRevocaDelega, ByVal DataRevoca As DateTime, ByVal Note As String) Implements IStatusDelega.Revoca


   End Sub
   Public Sub Annulla(ByVal Delega As Delega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As Delega) Implements IStatusDelega.Annulla
      '

   End Sub

   Public ReadOnly Property ReadyForPayment() As Boolean Implements IStatusDelega.ReadyForPayment
      Get
         Return False
      End Get
   End Property
   Public ReadOnly Property IsAccepted() As Boolean Implements IStatusDelega.IsAccepted
      Get
         Return False
      End Get
   End Property

   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente
      If TypeOf (Delega.DelegaDiAnnullamento) Is DelegaNulla Then
         'posso ripristinare solo le deleghe con stato precedente "Sottoscritta" o "Inoltrata"
         'Se lo stato precedente era attivo o accettato eseguo il ripristino 
         'previa verifica ce non ci siano altre deleghe attive
         Delega.DataAnnullamentoDelega = DateTime.MinValue
         Select Case Delega.StatoPrecedente.StatusName
            Case "Sottoscritta"
               Delega.StatoDelega = StSottoscritta.Instance
               Delega.StatoPrecedente = New StNull
               Delega.CausaleFineCiclo = New CausaleNulla
            Case "Inoltrata"
               Delega.StatoDelega = StInoltrata.Instance
               Delega.StatoPrecedente = New StSottoscritta
               Delega.CausaleFineCiclo = New CausaleNulla
            Case "Accettata"
               If Not Delega.Utente.CheckExistenceActiveDelegaFor(Delega.EnteInoltro) Then
                  Delega.StatoDelega = StAccettata.Instance
                  Delega.StatoPrecedente = New StInoltrata
                  Delega.CausaleFineCiclo = New CausaleNulla
               Else
                  Throw New Exception("Impossibile ripristinare la delega. Esistono altre deleghe attive o accettate.")
               End If
            Case "Attivata"
               If Not Delega.Utente.CheckExistenceActiveDelegaFor(Delega.EnteInoltro) Then
                  Delega.CausaleFineCiclo = New CausaleNulla
                  Delega.StatoDelega = StAttiva.Instance
                  If Delega.PagamentoAttivazione.GetId = -1 Then
                     Delega.StatoPrecedente = New StAccettata
                  Else
                     Delega.StatoPrecedente = New StAttiva
                  End If
               Else
                  Throw New Exception("Impossibile ripristinare la delega. Esistono altre deleghe attive o accettate.")
               End If
            Case "Annullata"
               Throw New Exception("Impossibile ripristinare lo stato precedente una delega annullata  con stato precedente annullato. ")
            Case "Revocata"
               Throw New Exception("Impossibile ripristinare lo stato precedente una delega  annullata con stato precedente revocato. ")
            Case Else
               Throw New Exception("Impossibile ripristinare lo stato precedente per la delega. Nome stato precedente sconosciuto")
         End Select

      ElseIf Delega.DelegaDiAnnullamento.NomeStato = "Inoltrata" Then
         Delega.DelegaDiAnnullamento = New DelegaNulla
         Delega.DataAnnullamentoDelega = DateTime.MinValue
         Select Case Delega.StatoPrecedente.StatusName
            Case "Sottoscritta"
               Delega.StatoDelega = StSottoscritta.Instance
               Delega.StatoPrecedente = New StNull
            Case "Inoltrata"
               Delega.StatoDelega = StInoltrata.Instance
               Delega.StatoPrecedente = New StSottoscritta
            Case "Accettata"
               Delega.StatoDelega = StAccettata.Instance
               Delega.StatoPrecedente = New StInoltrata
            Case "Attivata"
               Delega.StatoDelega = StAttiva.Instance
               If Delega.PagamentoAttivazione.GetId = -1 Then
                  Delega.StatoPrecedente = New StAccettata
               Else
                  Delega.StatoPrecedente = New StAttiva
               End If
            Case "Annullata"
               Throw New Exception("Impossibile ripristinare lo stato precedente una delega annullata  con stato precedente annullato. ")
            Case "Revocata"
               Throw New Exception("Impossibile ripristinare lo stato precedente una delega  annullata con stato precedente revocato. ")
            Case Else
               Throw New Exception("Impossibile ripristinare lo stato precedente per la delega. Nome stato precedente sconosciuto")
         End Select
         Delega.CausaleFineCiclo = New CausaleNulla
      Else
         Throw New Exception("Impossibile ripristinare lo stato precedente.")
      End If
   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla

   End Sub
End Class
