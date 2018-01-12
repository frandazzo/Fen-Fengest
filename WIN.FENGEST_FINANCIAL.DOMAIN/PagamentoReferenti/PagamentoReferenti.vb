Public Class PagamentoReferenti
   Inherits DocumentoContabile
   Protected m_ItemsRistornate As New VirtualLazyList
   Protected m_importo As Moneta
   Protected m_Referente As IReferente = New ReferenteNullo
   Protected m_hashCache As Hashtable = New Hashtable

#Region "Proprietà testata documento"


   Public Property Valuta() As Moneta.Valuta
      Get
         Return m_Valuta
      End Get
      Set(ByVal value As Moneta.Valuta)
         If Not m_IsPosted Then
            m_Valuta = value
         End If
      End Set
   End Property
   Public Property Importo() As Moneta
      Get
         Return m_importo
      End Get
      Set(ByVal value As Moneta)
         m_importo = value
      End Set
   End Property
   Public Property Referente() As IReferente
      Get
         Return m_Referente
      End Get
      Set(ByVal value As IReferente)
         If value Is Nothing Then Throw New Exception("Impossibile creare un pagamento referente. Referente nullo")
         If TypeOf (value) Is ReferenteNullo Then Throw New Exception("Impossibile creare un pagamento referente. Tipo referente nullo")
         m_Referente = value
      End Set
   End Property
   Public ReadOnly Property ItemsRistornate() As VirtualLazyList
      Get
         Return m_ItemsRistornate
      End Get
   End Property

#End Region


#Region "Costruttori"
   Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, ByVal Note As String, ByVal Referente As Referente)
      MyBase.New(DataRegistrazione, DataDocumento, Note)
      If Referente Is Nothing Then Throw New Exception("Impossibile creare un pagamento referente. Referente nullo")
      If TypeOf (Referente) Is ReferenteNullo Then Throw New Exception("Impossibile creare un pagamento referente. Tipo referente nullo")
      m_Referente = Referente
      MyBase.m_TipoDocumento = "PGR"
   End Sub
   Public Sub New()
      MyBase.m_TipoDocumento = "PGR"
   End Sub
#End Region





   ''' <summary>
   ''' Metodo che imposta le posizioni di incasso da ristornare
   ''' </summary>
   ''' <param name="List"></param>
   ''' <remarks></remarks>
   Public Sub SetItemListDaRistornare(ByVal List As IList)
      Try
         If TypeOf (m_Referente) Is ReferenteNullo Then Throw New Exception("Non è possibile inizializzare il pagamento. Referente di tipo nullo.")
         If List Is Nothing Then Throw New Exception("Lista posizioni da ristornare nulla.")
         Me.m_ItemsRistornate = List
         'Riga commentata col refactoring del 24/08/2007
         'CreateItems()
         SetImportiRistorno()
      Catch ex As Exception
         Throw New Exception("Impossibile impostare la lista delle posizioni da ristornare." & vbCrLf & ex.Message)
      End Try
   End Sub
   ''' <summary>
   ''' Metodo che imposta gli importi di ristorno per tutte l posizioni da ristornare
   ''' </summary>
   ''' <remarks></remarks>
   Private Overloads Sub SetImportiRistorno()
      Try
         For Each elem As ItemContabile In m_ItemsRistornate
            If elem.Referente.IdReferente <> m_Referente.IdReferente Then Throw New Exception("Si tenta di valorizza posizioni di incasso per una lista di posizioni con referente diverso da quello corrente")
            elem.SetImportoRistorno(Me)
         Next
      Catch ex As Exception
         Throw New Exception("Impossibile impostare gli importi di ristorno. " & vbCrLf & ex.Message)
      End Try
   End Sub
   ''' <summary>
   ''' Metodo che imposta massivamente gli importi di ristorno per tutte le posizioni
   ''' </summary>
   ''' <param name="Value"></param>
   ''' <remarks></remarks>
   Private Overloads Sub SetImportiRistorno(ByVal Value As Moneta)
      Try
         For Each elem As ItemContabile In m_ItemsRistornate
            If elem.Referente.IdReferente <> m_Referente.IdReferente Then Throw New Exception("Si tenta di valorizza posizioni di incasso per una lista di posizioni con referente diverso da quello corrente")
            elem.SetImportoRistorno(Value, Me)
         Next
      Catch ex As Exception
         Throw New Exception("Impossibile impostare gli importi di ristorno. " & vbCrLf & ex.Message)
      End Try
   End Sub


#Region "Metodi da rifattorizzare"


   'Private Sub CreateItems()
   '   Try
   '      For Each elem As ItemIncassoQuotaAssociativa In m_ItemsRistornate
   '         Dim conto As Conto = elem.SoggettoEsecutore.Conto
   '         If elem.Referente.IdReferente <> m_Referente.IdReferente Then Throw New Exception("Si tente di costruire posizioni di pagamento referente per una lista di posizioni con referente diverso da quello corrente")
   '         AddItems(conto, elem.GetImportoRistorno, Me)
   '      Next
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile creare gli items per il pagamento referenti. " & vbCrLf & ex.Message)
   '   End Try
   'End Sub
   'Private Overloads Sub AddItems(ByVal Conto As Conto, ByVal ImportoRistorno As Moneta, ByVal Pagamento As DocumentoContabile)
   '   Try

   '      If Conto Is Nothing Then Throw New Exception("Conto nullo")
   '      If TypeOf (Conto) Is ContoNullo Then Throw New Exception("Tipo Conto nullo ")
   '      If ImportoRistorno Is Nothing Then Throw New Exception("Importo nullo")
   '      If Pagamento Is Nothing Then Throw New Exception("Pagamento nullo")
   '      If TypeOf Pagamento Is DocumentoNullo Then Throw New Exception("Tipo documento nullo")

   '      AddCashItem(Conto, ImportoRistorno, Pagamento)
   '      AddPayItem(ImportoRistorno, Pagamento)


   '   Catch ex As Exception
   '      Throw New Exception("Impossibile aggiungere una nuova posizione al documento di pagamento. " & vbCrLf & ex.Message)
   '   End Try



   'End Sub
   'Private Sub AddCashItem(ByVal Conto As Conto, ByVal ImportoRistorno As Moneta, ByVal Pagamento As DocumentoContabile)
   '   Dim item As ItemPagamentoReferenti = GetItemByIdConto(Conto.IdConto)
   '   If item Is Nothing Then
   '      m_Items.Add(New ItemPagamentoReferenti(Me, ImportoRistorno.Negate, Conto, "Posizione registrata sul conto " & Conto.Descrizione & " relativa al pagamento del referente " & m_Referente.CompleteName, New ReferenteNullo))
   '   Else
   '      Dim moneta As Moneta = item.Importo.Add(ImportoRistorno.Negate)
   '      item.Importo = moneta
   '   End If
   'End Sub
   'Private Sub AddPayItem(ByVal ImportoRistorno As Moneta, ByVal Pagamento As PagamentoReferenti)
   '   Dim item As ItemPagamentoReferenti = GetItemByIdConto(m_Referente.Conto.IdConto)
   '   If item Is Nothing Then
   '      Dim itemPag As ItemPagamentoReferenti = New ItemPagamentoReferenti(Me, ImportoRistorno, Referente.Conto, "Posizione registrata sul conto " & m_Referente.Conto.Descrizione & " relativa al pagamento del referente " & m_Referente.CompleteName, m_Referente)
   '      itemPag.Referente = Pagamento.Referente
   '      m_Items.Add(itemPag)
   '   Else
   '      Dim moneta As Moneta = item.Importo.Add(ImportoRistorno)
   '      item.Importo = moneta
   '   End If
   'End Sub
   'Public Function GetItemByIdConto(ByVal IdConto As Int32) As ItemPagamentoReferenti
   '   Try
   '      If Not IsNumeric(IdConto) Then Throw New Exception("Identificativo di un formato errato.")
   '      For Each elem As ItemPagamentoReferenti In MyBase.m_Items
   '         If elem.Conto.Id = IdConto Then Return elem
   '      Next
   '      Return Nothing
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile ottenere la posizione relativa al conto di id = " & IdConto & vbCrLf & ex.Message)
   '   End Try
   'End Function
   'Private Sub AzzeraImporti()
   '   For Each elem As ItemPagamentoReferenti In m_Items
   '      elem.Importo = New Moneta(0, elem.Importo.GetValuta)
   '   Next
   'End Sub
#End Region



   Protected Overrides Function CanPost() As Boolean
      If MyBase.CanPost() Then
         If Not Me.GetImportoPagamentoReferente.IsGreaterThan(New Moneta(0.0, Moneta.Valuta.Euro)) Then
            Throw New Exception("Non si può registrare un pagamento ai referenti con importo nullo. Disattivare la posizione")
         End If
      Else
         Return False
      End If
      Return True
   End Function
   Protected Overrides Sub PrePostActions()
      Try
         'Riga commentata col refactoring del 24/08/2007
         'AzzeraImporti()
         UpdateItemsDaRistornare()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Protected Overrides Sub PostPostActions()
      'm_importo = GetImportoPagamentoReferente()
      m_Valuta = m_importo.GetValuta
   End Sub
   Private Sub UpdateItemsDaRistornare()
      For Each elem As ItemContabile In m_ItemsRistornate
         elem.SetPagamentoReferente(Me)
      Next
   End Sub


   ''' <summary>
   ''' Metodo che ottiene l'importo del pagamento
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function GetImportoPagamentoReferente() As Moneta
      Return m_importo
   End Function
   ''' <summary>
   ''' Metodo che calcola l'importo del documento come somma degli imorti di ristorno di tutte le posizioni
   ''' di incasso
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub CalculateImporto()
      Dim moneta As Moneta = New Moneta(0, Me.m_Valuta)
      For Each elem As ItemContabile In Me.m_ItemsRistornate
         moneta = elem.ImportoRistorno.Add(moneta)
      Next
      m_importo = moneta
   End Sub

   ''' <summary>
   ''' NON UTILIZZARE. METODO UTILIZZATO DAL MAPPER PER LA MATERIALIZZAZIONE DELL'OGGETTO
   ''' </summary>
   ''' <param name="Lista"></param>
   ''' <remarks></remarks>
   Public Sub SetItemsRistornate(ByVal Lista As IList)
      m_ItemsRistornate = Lista
   End Sub


   ''' <summary>
   ''' Metodo per recuperare univocamente una posizione documento di incasso quota associativa da ristornare
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="Documento"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overloads Function GetItemDaRistornare(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal Documento As DocumentoContabile) As ItemContabile
      Try
         Dim i As Integer = Me.GetIndexItemByUtente(Utente, Competenza, Documento.Id)
         Return m_ItemsRistornate.Item(i)
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione da ristornare relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Function
   ''' <summary>
   ''' Metodo che ricerca le posizioni di incasso quota vertenza da ristornare
   ''' </summary>
   ''' <param name="IdDocumentoPadre"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overloads Function GetItemDaRistornare(IdDocumentoPadre as int32) As ItemContabile
      Try
         Dim i As Integer = Me.GetIndexItemByUtente(IdDocumentoPadre)
         Return m_ItemsRistornate.Item(i)
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione da ristornare relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Function
   ''' <summary>
   '''  Metodo che ricerca le posizioni di incasso quota associativa e quota Inps da ristornare
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="Documento"></param>
   ''' <param name="Prestazione"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overloads Function GetItemDaRistornare(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal Documento As DocumentoContabile, ByVal Prestazione As IDocumento) As ItemContabile
      Try
         Dim i As Integer = Me.GetIndexItemByUtente(Utente, Competenza, Documento.Id, Prestazione.GetId)
         Return m_ItemsRistornate.Item(i)
      Catch ex As Exception
         Throw New Exception("Errore nella ricerca della posizione da ristornare relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Function



   ''' <summary>
   ''' Metodo che rimuove l'item contabile di tipo quota asssociativa dalla lista delle item ristornate
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="Documento"></param>
   ''' <remarks></remarks>
   Public Overloads Sub RemoveItemDaRistornare(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal Documento As DocumentoContabile)
      Try
         Dim sb As New System.Text.StringBuilder
         sb.Append(Utente.ToString)
         sb.Append(Competenza.ToString)
         sb.Append(Documento.ToString)
         sb.Append("-1")

         If m_hashCache.ContainsKey(sb.ToString) Then
            m_hashCache.Remove(sb.ToString)
         End If


         Dim i As Integer = Me.GetIndexItemByUtente(Utente, Competenza, Documento.Id)
         DirectCast(m_ItemsRistornate.Item(i), ItemContabile).ClearRistorno()
         m_ItemsRistornate.RemoveAt(i)
         Me.CalculateImporto()
      Catch ex As Exception
         Throw New Exception("Impossibile rimuovere la posizione. Errore nella ricerca della posizione da ristornare relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Sub
   ''' <summary>
   ''' Metodo che rimuove l'item contabile di tipo quota asssociativa e quota Inps dalla lista delle item ristornate
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="Documento"></param>
   ''' <param name="Prestazione"></param>
   ''' <remarks></remarks>
   Public Overloads Sub RemoveItemDaRistornare(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal Documento As DocumentoContabile, ByVal Prestazione As IDocumento)
      Try
         Dim sb As New System.Text.StringBuilder
         sb.Append(Utente.ToString)
         sb.Append(Competenza.ToString)
         sb.Append(Documento.ToString)
         sb.Append(Prestazione.GetId.ToString)

         If m_hashCache.ContainsKey(sb.ToString) Then
            m_hashCache.Remove(sb.ToString)
         End If






         Dim i As Integer = Me.GetIndexItemByUtente(Utente, Competenza, Documento.Id, Prestazione.GetId)
         DirectCast(m_ItemsRistornate.Item(i), ItemContabile).ClearRistorno()
         m_ItemsRistornate.RemoveAt(i)
         Me.CalculateImporto()
      Catch ex As Exception
         Throw New Exception("Impossibile rimuovere la posizione. Errore nella ricerca della posizione da ristornare relativa alla competenza indicata" & vbCrLf & ex.Message)
      End Try
   End Sub


   Public Function AddItemDaRistornare(ByVal Item As ItemContabile) As Boolean
      Dim sb As New System.Text.StringBuilder
      sb.Append(Item.Utente.ToString)
      sb.Append(Item.Competenza.ToString)
      sb.Append(Item.DocumentoPadre.ToString)
      sb.Append(Item.Prestazione.GetId.ToString)

      If m_hashCache.ContainsKey(sb.ToString) Then
         Return False
      Else
         m_ItemsRistornate.Add(Item)
         Item.SetImportoRistorno(Me)
         m_hashCache.Add(sb.ToString, 1)
         Return True
      End If

      'If Item.PagamentoReferente.Id <> -1 Then Throw New Exception("Impossibile aggiungere la posizione da ristornare. Posizione gia ristornata")
      'Dim i As Integer = Me.GetIndexItemByUtente(Item.Utente, Item.Competenza, Item.DocumentoPadre.Id, Item.Prestazione.GetId)
      'If i = -1 Then
      '   m_ItemsRistornate.Add(Item)
      '   Item.SetImportoRistorno(Me)
      '   Return True
      'Else
      '   Return False
      'End If

   End Function



   ''' <summary>
   ''' Metodo che recupera l'indice della posizione dell'item contabile di tipo quota vertenza
   ''' nella lista delle item ristornate
   ''' </summary>
   ''' <param name="IdDocumentoPadre"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Overloads Function GetIndexItemByUtente(ByVal IdDocumentoPadre As Int32) As Integer
      For Each elem As ItemContabile In m_ItemsRistornate
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.DocumentoPadre.Id = IdDocumentoPadre Then Return m_ItemsRistornate.IndexOf(elem)
         End If
      Next
      Return -1
   End Function
   ''' <summary>
   ''' Metodo che recupera l'indice della posizione dell'item contabile di tipo quota associativa
   ''' nella lista delle item ristornate
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="IdDocumentoPadre"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Overloads Function GetIndexItemByUtente(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal IdDocumentoPadre As Int32) As Integer
      For Each elem As ItemContabile In m_ItemsRistornate
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.Utente.IdUtente = Utente.IdUtente And Competenza.Equals(elem.Competenza) And elem.DocumentoPadre.Id = IdDocumentoPadre Then Return m_ItemsRistornate.IndexOf(elem)
         End If
      Next
      Return -1
   End Function
   ''' <summary>
   ''' Metodo che recupera l'indice della posizione dell'item contabile di tipo quota associativa
   ''' e quota Inps nella lista delle item ristornate
   ''' </summary>
   ''' <param name="Utente"></param>
   ''' <param name="Competenza"></param>
   ''' <param name="IdDocumentoPadre"></param>
   ''' <param name="IdPrestazione"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Overloads Function GetIndexItemByUtente(ByVal Utente As IUtente, ByVal Competenza As AbstractPeriodo, ByVal IdDocumentoPadre As Int32, ByVal IdPrestazione As Int32) As Integer
      For Each elem As ItemContabile In m_ItemsRistornate
         If Not TypeOf (elem.Utente) Is UtenteNonSpecificato Then
            If elem.Prestazione.GetId = IdPrestazione And elem.Utente.IdUtente = Utente.IdUtente And Competenza.GetDataRange.Equals(elem.Competenza.GetDataRange) And elem.DocumentoPadre.Id = IdDocumentoPadre Then Return m_ItemsRistornate.IndexOf(elem)
         End If
      Next
      Return -1
   End Function

   Public Overrides Sub Post()
      PrePostActions()
      If CanPost() Then

         If Me.IsValid Then
            m_Referente.UltimoRistorno = Me
            PostPostActions()
            m_IsPosted = True
         Else
            Dim errors As String = ""
            For Each elem As String In Me.ValidationErrors
               errors = errors & elem & vbCrLf
            Next
            Throw New Exception("L'oggetto non è valido. Controllare il valore dei valori immessi" & vbCrLf & errors)
         End If

      Else
         Throw New Exception("Impossibile registrare il documento. Totale documento diverso da 0.")
      End If
   End Sub



   Protected Overrides Sub DoValidation()
      'If Not MyBase.IsValid() Then
      '   ValidationErrors.Add("Errore nella validazione")
      'End If
      If m_ItemsRistornate.Count = 0 Then
         ValidationErrors.Add("Impossibile salvare. Non ci sono posizioni da ristornare.")
      End If

   End Sub
End Class
