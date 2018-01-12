Public Class IncassoQuotaInps
   Inherits IncassoQuotaAssociativa
   Public Sub New()
      MyBase.m_TipoDocumento = "IQI"
   End Sub
   Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                   ByVal PeriodoCompetenza As AbstractPeriodo, ByVal Note As String, _
                   ByVal Valuta As Moneta.Valuta, ByVal Importo As Double, ByVal Inps As Azienda, _
                   Optional ByVal PersistentObject As Boolean = False)

      Me.m_dataRegistrazione = DataRegistrazione
      Me.m_dataDocumento = DataDocumento
      Me.m_note = Note
      Me.m_TipoDocumento = "IQI"

      If PeriodoCompetenza Is Nothing Then Throw New Exception("Impossibile costruire un oggetto incasso quota Inps con un periodo di competenza nullo!")
      If PeriodoCompetenza.GetDataRange.IsEmpty Then Throw New Exception("Non è possibile creare un incasso quota Inps con una competenza negativa o vuota")
      If Inps Is Nothing Then Throw New Exception("Impossibile costruire un oggetto incasso quota Inps con un oggetto Inps nullo!")
      If Inps.TipologiaAzienda <> Azienda.TipoAzienda.Inps Then Throw New Exception("Impossibile costruire un oggetto incasso quota Inps con un tipo azienda diverso dall'Inps!")

      m_SoggEsecutore = Inps
      m_Valuta = Valuta
      m_importo = New Moneta(Importo, m_Valuta)
      m_competenzaUltimoPagamento = Inps.CompetenzaUltimoPagamento
      m_competenza = PeriodoCompetenza

      If Not PersistentObject Then
         m_Items.Add(New ItemIncassoQuoteInps(Me, New Moneta(Importo, m_Valuta), m_competenza, Inps, False, False, Note))
      End If
   End Sub
   'Protected Function ExistItemWithIntersectedCompetenza(ByVal InItemList As ArrayList, ByVal WithCompetenza As AbstractPeriodo) As Boolean
   '   For Each elem As ItemIncassoQuoteInps In InItemList
   '      If elem.Competenza.Overlaps(WithCompetenza) Then Return True
   '   Next
   '   Return False
   'End Function
   Protected Overloads Function GetIndexItemByUtente(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal TipoPrestazione As ITipoPrestazione) As Integer
      For Each elem As ItemIncassoQuotaAssociativa In m_Items
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.Utente.IdUtente = Utente.IdUtente And Competenza.Equals(elem.Competenza) And TipoPrestazione.TipoDocumento = elem.Prestazione.TipoDocumento Then Return m_Items.IndexOf(elem)
         End If
      Next
      Return -1
   End Function
   Public Function GetFirstAivablePeriod(ByVal InItemList As ArrayList, ByVal WithPrestazione As IDocumento) As AbstractPeriodo
      Dim per As AbstractPeriodo = New CompositePeriodo(Today.Month, Today.Year, Today.Month, Today.Year, 0)
      Dim found As Boolean = False
      Do Until found
         'per = per.GetNextPeriod(-1)
         Dim ok As Boolean = True
         For Each elem As ItemIncassoQuoteInps In InItemList
            If WithPrestazione.TipoDocumento = elem.Prestazione.TipoDocumento Then
               If elem.Competenza.Overlaps(per) Then
                  ok = False
               End If
            End If
         Next
         If ok Then
            found = True
         Else
            per = per.GetPreviousPeriod(-1)
         End If
      Loop
      Return per
   End Function

#Region "Metodi per ottenere, aggiungere e rimuovere una posizione "
   Public Overloads Function GetItem(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal TipoPrestazione As ITipoPrestazione) As ItemIncassoQuoteInps
      Try
         Dim i As Integer = Me.GetIndexItemByUtente(Utente, Competenza, TipoPrestazione)
         Return m_Items.Item(i)
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione del pagamento relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Sub AddItem(ByVal Utente As IUtente, ByVal Importo As Double, ByVal Competenza As AbstractPeriodo, ByVal Referente As Referente, ByVal Note As String, ByVal Prestazione As IDocumento)
      Dim list As ArrayList = GetItemListByUtente(Utente)
        If Not ExistSimilarItemTo(list, Competenza, Prestazione) Then
            m_Items.Add(New ItemIncassoQuoteInps(Utente, Me, New Moneta(Importo, m_Valuta).Negate, Referente, SoggettoEsecutore, Note, Competenza, False, False, Prestazione))
            'm_Items.Add(New ItemIncassoQuoteInps(Utente, Me, New Moneta(Importo, m_Valuta).Negate, Referente, SoggettoEsecutore, Note, GetFirstAivablePeriod(list, Prestazione), False, False, Prestazione))
        Else
            Throw New ArgumentException("L'item si sovrappone ad un elemento esistente", "Competenza")
        End If
   End Sub
   Public Overloads Sub RemoveItem(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal TipoPrestazione As ITipoPrestazione)
      'If Not m_IsPosted Then
      Dim posizione As Integer = Me.GetIndexItemByUtente(Utente, Competenza, TipoPrestazione)
      If posizione > 0 Then m_Items.RemoveAt(posizione)
      If m_IsPosted Then Importo = Importo.Subtract(Me.GetTotal)
      'Else
      'Throw New Exception("Non è possibile rimuovere la posizione dal documento poichè il documento risulta già registrato.")
      'End If

   End Sub
#End Region


#Region "Metodi di verifica esistenza posizioni analoghe"
   Public Overloads Function ExistSimilarItemsForUtente(ByVal Utente As IUtente, ByVal Item As ItemIncassoQuoteInps, ByVal Competenza As AbstractPeriodo, ByVal Prestazione As IDocumento) As Boolean
      If Utente.IdUtente = -1 Then Return False
      Return ExistSimilarItemTo(GetItemListByUtente(Utente), Item, Competenza, Prestazione)
   End Function
   ''' <summary>
   ''' Metodo che verifica l'esistenza d posizioni simili durante la creazione di una nuova posizione
   ''' </summary>
   ''' <param name="InItemList"></param>
   ''' <param name="WithCompetenza"></param>
   ''' <param name="WithPrestazione"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Protected Overloads Function ExistSimilarItemTo(ByVal InItemList As ArrayList, ByVal WithCompetenza As AbstractPeriodo, ByVal WithPrestazione As IDocumento) As Boolean
      Try
         For Each elem As ItemIncassoQuoteInps In InItemList
            If elem.Competenza.Overlaps(WithCompetenza) And WithPrestazione.TipoDocumento = elem.Prestazione.TipoDocumento Then Return True
         Next
      Catch ex As Exception
         Throw New Exception("Impossibile verificare l'esistenza di posizioni documento simili." & vbCrLf & ex.Message)
      End Try

   End Function
   ''' <summary>
   ''' Metodo che verifica l'esistenza d posizioni simili durante la modifica della posizione
   ''' </summary>
   ''' <param name="InItemList"></param>
   ''' <param name="AsItem"></param>
   ''' <param name="WithCompetenza"></param>
   ''' <param name="WithPrestazione"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Protected Overloads Function ExistSimilarItemTo(ByVal InItemList As ArrayList, ByVal AsItem As ItemIncassoQuoteInps, ByVal WithCompetenza As AbstractPeriodo, ByVal WithPrestazione As IDocumento) As Boolean
      For Each elem As ItemIncassoQuoteInps In InItemList
         If Not elem Is AsItem Then
            If elem.Competenza.Overlaps(WithCompetenza) And elem.Prestazione.TipoDocumento = WithPrestazione.TipoDocumento Then
               Return True
            End If
         End If
      Next
   End Function
#End Region
End Class
