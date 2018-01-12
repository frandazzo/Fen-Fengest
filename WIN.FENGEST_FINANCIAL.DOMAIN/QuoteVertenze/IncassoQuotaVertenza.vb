Public Class IncassoQuotaVertenza
   Inherits DocumentoContabile
   Private m_Utente As Utente = New UtenteNonSpecificato
   Public Sub New()
      MyBase.m_TipoDocumento = "IQV"
   End Sub
   Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                   ByVal Note As String, ByVal Importo As Moneta, ByVal Utente As Utente, _
                   ByVal ContoCassa As Conto, Optional ByVal PersistentObject As Boolean = False)

      If Utente Is Nothing OrElse TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Impossibile creare un incasso quota vertenza. L'utente o il tipo utente è nullo.")
      Me.m_dataRegistrazione = DataRegistrazione
      Me.m_dataDocumento = DataDocumento
      Me.m_note = Note
      Me.m_Utente = Utente
      Me.m_TipoDocumento = "IQV"

      If Not PersistentObject Then
         m_Items.Add(New ItemIncassoQuoteVertenza(Me, Importo, ContoCassa, Note))
      End If
   End Sub
   Public ReadOnly Property Utente() As Utente
      Get
         Return m_Utente
      End Get
   End Property
   ''' <summary>
   ''' NON UTILIZZARE. Metodo utilizzato solo dal mapper
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <remarks></remarks>
   Public Sub SetUtente(ByVal Utente As Utente)
      If Utente Is Nothing OrElse TypeOf (Utente) Is UtenteNonSpecificato Then Throw New Exception("Inpossibile impostare l'utente per il documento di incasso vertenza. Utente o tipo utente nullo")
      m_Utente = Utente
   End Sub

   Public Overloads Function GetItem(ByVal Vertenza As IDocumento) As ItemContabile
      Try
         For Each elem As ItemIncassoQuoteVertenza In m_Items
            If elem.Vertenza.GetId = Vertenza.GetId Then Return elem
         Next
         Return DomainFactory.GetVertenzaNulla
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione del pagamento" & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Function GetItemCash() As ItemContabile
      Try
         For Each elem As ItemIncassoQuoteVertenza In m_Items
            If Not elem.PosizioneUtente Then Return elem
         Next
         Return DomainFactory.GetVertenzaNulla
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione del pagamento" & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Sub AddItem(ByVal Utente As Utente, ByVal Importo As Moneta, ByVal Note As String, ByVal Vertenza As IDocumento, ByVal Referente As Referente)
      If Not ExistSimilarItemTo(Vertenza) Then
         m_Items.Add(New ItemIncassoQuoteVertenza(Utente, Me, Importo.Negate, Referente, Note, Vertenza))
      Else
         Throw New Exception("Non è possibile aggiungere una nuova posizione al documento perchè la competenza si sovrappone a quella di un'altra posizione per lo stesso utente e con lo stesso tipo di prestazione")
      End If
   End Sub
   Protected Overloads Function ExistSimilarItemTo(ByVal WithVertenza As IDocumento) As Boolean
      Try
         For Each elem As ItemIncassoQuoteVertenza In m_Items
            If WithVertenza.GetId = elem.Vertenza.GetId Then Return True
         Next
      Catch ex As Exception
         Throw New Exception("Impossibile verificare l'esistenza di posizioni documento simili." & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Sub RemoveItem(ByVal Vertenza As IDocumento)
      If Not m_IsPosted Then
         Dim posizione As Integer = Me.GetIndexItemByVertenza(Vertenza)
         If posizione > 0 Then m_Items.RemoveAt(posizione)
      Else
         Throw New Exception("Non è possibile rimuovere la posizione dal documento poichè il documento risulta già registrato.")
      End If

   End Sub
   Protected Overloads Function GetIndexItemByVertenza(ByVal Vertenza As IDocumento) As Int32
      For Each elem As ItemIncassoQuoteVertenza In m_Items
         If elem.Vertenza.GetId = Vertenza.GetId Then Return m_Items.IndexOf(elem)
      Next
      Return -1
   End Function
   Protected Overloads Function ExistSimilarItemTo(ByVal InItemList As ArrayList, ByVal AsItem As ItemIncassoQuoteVertenza, ByVal WithVertenza As IDocumento) As Boolean
      For Each elem As ItemIncassoQuoteVertenza In InItemList
         If Not elem Is AsItem Then
            If elem.Vertenza.TipoDocumento = WithVertenza.TipoDocumento Then
               Return True
            End If
         End If
      Next
   End Function
   Protected Overrides Sub DoValidation()
      'If Not MyBase.IsValid() Then
      '   ValidationErrors.Add("Errori nella validazione del documento")
      'End If
      If Me.GetItemCash.Importo.Importo <= 0 Then
         ValidationErrors.Add("Impossibile registrare un documento di importo nullo")
      End If
   End Sub

   Public Function HaItemRistornate() As Boolean
      For Each elem As ItemIncassoQuoteVertenza In m_Items
         If elem.PagamentoReferente.Id <> -1 And elem.Vertenza.GetId <> -1 Then Return True
      Next
      Return False
   End Function
End Class
