Namespace FINANCIAL_ARTIFACTS
   Public Class ControllerPagamentoReferenti

      Inherits AbstractDocumentController
      Private controllerReferenti As New FINANCIAL_ARTIFACTS.ControllerReferenti
      Private controllerUtenti As New UTENTI.ControllerUtenti
      Private controllerPrestazioni As New ADMINISTRATION.ControllerPrestazioni
      Private m_Referente As Referente
      'Private m_ControllerRicerche As ControllerRicercheItems
      Private m_ListaPosizioni As IList = New ArrayList
      Private m_ListaDtoPosizioni As IList = New ArrayList
      Private m_CurrentDTO As DTOItemContabile
      ' Private m_currentItem As ItemContabile
      Public Event AddItemError(ByVal MsgError As String, ByVal Cancel As Boolean)
      Public Event ItemAddedd(ByVal number As Int32)


      Public Sub New()
         Ps.BeginTransaction()
      End Sub
      Private Function Current() As PagamentoReferenti
         Return DirectCast(MyBase.m_current, PagamentoReferenti)
      End Function
      Protected Overrides Sub LoadAll()
         Try
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperPagamentoReferenti")
            Dim mainCriteria As Criteria = Criteria.Equal("TIPO_DOCUMENTO", "'PGR'")
            query.AddWhereClause(mainCriteria)
            DomainObjectList = query.Execute(ps)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      ''' <summary>
      ''' Metodo che recupera da una lista di itemcontabili l'oggetto le cui caratteristiche
      ''' sono descritte dalle chiavi e dai valori presenti nella hashtable WithParameter
      ''' </summary>
      ''' <param name="WithParameter">Le chivi sono: "TipoDocumento", "IdUtente","IdPrestazione", "IdDocPadre",
      ''' "DataInizio", "DataFine", "IdVertenza"</param>
      ''' <param name="InList"></param>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public Function GetItem(ByVal WithParameter As Hashtable, ByVal InList As IList) As Object
         Dim Tipo As String = WithParameter.Item("TipoDocumento")
         Dim IdUtente As String = WithParameter.Item("IdUtente")
         Dim IdPrestazione As String = WithParameter.Item("IdPrestazione")
         Dim IdVertenza As String = WithParameter.Item("IdVertenza")
         Dim IdDocumentoPadre As String = WithParameter.Item("IdDocPadre")
         Dim DataInizio As DateTime = WithParameter.Item("DataInizio")
         Dim dataFine As DateTime = WithParameter.Item("DataFine")
         For Each elem As ItemContabile In InList

            Select Case Tipo
               Case "IQA"
                  If elem.Utente.IdUtente = IdUtente Then
                     If elem.DocumentoPadre.Id = IdDocumentoPadre Then
                        If elem.Competenza.GetDataRange.Start = DataInizio And elem.Competenza.GetDataRange.Finish = dataFine Then
                           Return elem
                        End If
                     End If
                  End If
               Case "IQI"
                  If elem.Utente.IdUtente = IdUtente Then
                     If elem.DocumentoPadre.Id = IdDocumentoPadre Then
                        If DirectCast(elem.Prestazione, Prestazione).TipoPrestazione.Id.ToString = IdPrestazione Then
                           If elem.Competenza.GetDataRange.Start = DataInizio And elem.Competenza.GetDataRange.Finish = dataFine Then
                              Return elem
                           End If
                        End If
                     End If
                  End If
               Case "IQV"
                  If elem.Utente.IdUtente = IdUtente Then
                     If elem.DocumentoPadre.Id = IdDocumentoPadre Then
                        If DirectCast(elem.Vertenza, Vertenza).Id.ToString = IdVertenza Then
                           Return elem
                        End If
                     End If
                  End If
               Case Else
                  Throw New Exception("Impossibile ottenere l'item richiesto. Tipo documento sconosciuto")
            End Select
         Next
         Return Nothing
      End Function
      Public Overrides Sub SelectItemByIds(ByVal IdDocumento As String, ByVal IdItem As String)
         If Not IsNumeric(IdDocumento) Then Throw New Exception("Impossibile selezionare la posizione del documento. Il formato dell'id documento non è corretto.")
         If Not IsNumeric(IdItem) Then Throw New Exception("Impossibile selezionare la posizione del documento. Il formato dell'id dell'item non è corretto.")
         Try
            For Each elem As ItemContabile In Current.ItemsRistornate
               If elem.Key.Value(1) = IdDocumento And elem.Key.Value(0) = IdItem Then
                  m_currentItem = elem
                  SelectDTOByIds(IdDocumento, IdItem)
                  Exit Sub
               End If
            Next
            Throw New Exception("Impossibile selezionare la posizione del documento. Gli id immessi non si riferiscono a nessuna posizione.")
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub

      Private Sub SelectDTOByIds(ByVal IdDocumento As String, ByVal IdItem As String)
         For Each elem As DTOItemContabile In m_ListaDtoPosizioni
            If elem.Key.Value(1) = IdDocumento And elem.Key.Value(0) = IdItem Then
               m_CurrentDTO = elem
               Exit Sub
            End If
         Next
      End Sub

#Region "Proprietà Documento Testata"
      ''' <summary>
      ''' Proprietà che restituisce l'importo del documento
      ''' </summary>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public ReadOnly Property Importo() As Double
         Get
            Return Current.Importo.Importo
         End Get
      End Property
      Public ReadOnly Property Valuta() As String
         Get
            Return Moneta.GetTipoValutaToString(Current.Importo.GetValuta)
         End Get
      End Property
      ''' <summary>
      ''' Proprieta che restituisce la lista delle posizioni  ristornate
      ''' </summary>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public Overrides ReadOnly Property ListaPosizioni() As System.Collections.IList
         Get
            Return Current.ItemsRistornate
         End Get
      End Property
      ''' <summary>
      ''' Proprietà che restituisce la lista dei DTO degli oggetti ristornati. Metodo 
      ''' Helper per la visualizzazione sulla griglia
      ''' </summary>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public ReadOnly Property ListaDTOPosizioni() As System.Collections.IList
         Get
            Return m_ListaDtoPosizioni
         End Get
      End Property
#End Region


#Region "Metodi obsoleti"
      '''' <summary>
      '''' Obsoleta. Vedi importo.
      '''' </summary>
      '''' <value></value>
      '''' <returns></returns>
      '''' <remarks></remarks>
      'Public ReadOnly Property ImportoDaRistornare() As Double
      '   Get
      '      Return Current.GetImportoPagamentoReferente.Importo
      '   End Get
      'End Property
      '''' <summary>
      '''' Obsoleto. Vedi Lista posizioni
      '''' </summary>
      '''' <value></value>
      '''' <returns></returns>
      '''' <remarks></remarks>
      'Public ReadOnly Property ListaPosizioniRistornate() As IList
      '   Get
      '      Return Current.ItemsRistornate
      '   End Get
      'End Property

      '''' <summary>
      '''' Obsoleta. Recupera la lista delle posizioni che saranno ristornate
      '''' </summary>
      '''' <param name="IdReferente"></param>
      '''' <returns></returns>
      '''' <remarks></remarks>
      'Public Overloads Function GetItemListDaRistornare(ByVal IdReferente As String) As IList
      '   If IsNumeric(IdReferente) Then Throw New Exception("Impossibile ricercare il referente. Id non corretto. Inserire un id corretto.")
      '   Return Ps.GetMapperByName("MapperItemDocumentoContabile").FindItemsIQANotPaidToReferente(m_Referente)
      'End Function

#End Region



#Region "Proprietà referente"
      Public ReadOnly Property NameReferente() As String
         Get
            Return Current.Referente.CompleteName
         End Get
      End Property
      Private Function GetReferenteById(ByVal IdReferente As Int32) As Referente
         Try
            m_Referente = controllerReferenti.GetReferenteById(IdReferente)
            Return m_Referente
         Catch ex As Exception
            Throw New Exception("Imposibile ottenere il referente con id " & IdReferente & vbCrLf & ex.Message)
         End Try
      End Function
      ''' <summary>
      ''' Proprietà che specifica se il referente è un componente di struttura
      ''' </summary>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public ReadOnly Property ReferenteInterno() As Boolean
         Get
            Return m_Referente.ComponenteStruttura
         End Get
      End Property
      Public Sub SetReferente(ByVal IdReferente As String)
         If IsNumeric(IdReferente) Then Throw New Exception("Impossibile ricercare il referente. Id non corretto. Inserire un id corretto.")
         GetReferenteById(IdReferente)
      End Sub
      Public ReadOnly Property IdReferente() As String
         Get
            Return Current.Referente.IdReferente
         End Get
      End Property
#End Region



#Region "Metodi per la gestione del pagamento"

      'Metodi SelectIem, AddItem, RemoveItem, SetListaPosizioni

      ''' <summary>
      ''' Metodo che aggiunge una o più posizioni da ristornare alla lista. Se il documento è già registrato 
      ''' registra la posizione come nuova. Nel caso la posizione sia già presente o ristornata l'eccezione viene notificata
      ''' al client tramite l'evento "AddItemError" il quale può decidere di annullare la transazione completa.
      ''' </summary>
      ''' <param name="ItemList"></param>
      ''' <remarks></remarks>
      Public Sub AddItem(ByVal ItemList As IList)
         Dim i As Int32 = 0
         For Each elem As ItemContabile In ItemList
            If Not Current.AddItemDaRistornare(elem) Then
               Dim cancel As Boolean = False
               RaiseEvent AddItemError("Impossibile aggiungere la posizione", cancel)
               If cancel Then Exit Sub
            End If
            i = i + 1
            RaiseEvent ItemAddedd(i)
         Next
         CreateListaDto()
      End Sub
      ''' <summary>
      ''' Metodo che rimuove l'item da ristornare dalla lista. se il documento è già registrato
      ''' marca la posizione come rimossa
      ''' </summary>
      ''' <remarks></remarks>
      Public Overloads Sub RemoveItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdIncasso As String, ByVal TipoDocumento As String)
         If Not IsNumeric(IdUtente) Then Throw New Exception("L'item selezionato non ha un Id utente corretto!")
         Dim incasso As DocumentoContabile = GetIncassoById(IdIncasso, TipoDocumento)
         Dim utente As Utente = GetUtenteById(IdUtente)
         Dim Comp As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
         'recupero la posizione per marcarla come rimossa nel caso il documento sia registrato
         If Current.IsPosted Then
            m_currentItem = Current.GetItemDaRistornare(utente, Comp, incasso)
            Current.RemoveItemDaRistornare(utente, Comp, incasso)
            Ps.MarkDirty(m_currentItem)
         Else
            Current.RemoveItemDaRistornare(utente, Comp, incasso)
         End If
         CreateListaDto()
      End Sub

      Public Overloads Sub RemoveItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdIncasso As String, ByVal TipoDocumento As String, ByVal IdPrestazione As String)
         If Not IsNumeric(IdUtente) Then Throw New Exception("L'item selezionato non ha un Id utente corretto!")
         Dim incasso As DocumentoContabile = GetIncassoById(IdIncasso, TipoDocumento)
         Dim utente As Utente = GetUtenteById(IdUtente)
         Dim prestazione As Prestazione = Me.GetPrestazioneById(IdPrestazione)
         Select Case TipoDocumento
            Case "IQA"
               'recupero la posizione per marcarla come rimossa nel caso il documento sia registrato
               Dim Comp As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
               If Current.IsPosted Then
                  m_currentItem = Current.GetItemDaRistornare(utente, Comp, incasso)
                  Current.RemoveItemDaRistornare(utente, Comp, incasso)
                  Ps.MarkDirty(m_currentItem)
               Else
                  Current.RemoveItemDaRistornare(utente, Comp, incasso)
               End If
            Case "IQI"
               'recupero la posizione per marcarla come rimossa nel caso il documento sia registrato
               Dim Comp As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
               If Current.IsPosted Then
                  m_currentItem = Current.GetItemDaRistornare(Utente, Comp, incasso, prestazione)
                  Current.RemoveItemDaRistornare(Utente, Comp, incasso, prestazione)
                  Ps.MarkDirty(m_currentItem)
               Else
                  Current.RemoveItemDaRistornare(Utente, Comp, incasso, prestazione)
               End If
            Case "IQV"
               Dim Comp As AbstractPeriodo = New PeriodoNullo
               If Current.IsPosted Then
                  m_currentItem = Current.GetItemDaRistornare(utente, Comp, incasso, prestazione)
                  Current.RemoveItemDaRistornare(utente, Comp, incasso, prestazione)
                  Ps.MarkDirty(m_currentItem)
               Else
                  Current.RemoveItemDaRistornare(utente, Comp, incasso, prestazione)
               End If
         End Select
         CreateListaDto()
      End Sub



      '''' <summary>
      '''' Metodo per la selezione degli Items.
      '''' </summary>
      '''' <param name="IdUtente"></param>
      '''' <param name="DataInizio"></param>
      '''' <param name="DataFine"></param>
      '''' <param name="IdIncasso"></param>
      '''' <param name="TipoDocumento">Valori ammessi: "IQA".</param>
      '''' <remarks></remarks>
      'Public Overloads Sub SelectItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdIncasso As String, ByVal TipoDocumento As String)
      '   If Not IsNumeric(IdUtente) Then Throw New Exception("L'item selezionato non ha un Id utente corretto!")
      '   Dim incasso As DocumentoContabile = GetIncassoById(IdIncasso, TipoDocumento)
      '   Dim utente As Utente = GetUtenteById(IdUtente)
      '   Dim Comp As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
      '   m_currentItem = Current.GetItemDaRistornare(utente, Comp, incasso)
      'End Sub
      ''' <summary>
      ''' Metodo per la selezione degli Items.
      ''' </summary>
      ''' <param name="IdUtente"></param>
      ''' <param name="DataInizio"></param>
      ''' <param name="DataFine"></param>
      ''' <param name="IdIncasso"></param>
      ''' <param name="TipoDocumento">Valori ammessi: "IQA", "IQI", "IQV"</param>
      ''' <param name="IdPrestazione"></param>
      ''' <remarks></remarks>
      Public Overloads Sub SelectItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdIncasso As String, ByVal TipoDocumento As String, ByVal IdPrestazione As String)
         If Not IsNumeric(IdUtente) Then Throw New Exception("L'item selezionato non ha un Id utente corretto!")
         Dim incasso As DocumentoContabile = GetIncassoById(IdIncasso, TipoDocumento)
         Dim utente As Utente = GetUtenteById(IdUtente)
         Dim prestazione As Prestazione = GetPrestazioneById(IdPrestazione)
         Dim Comp As AbstractPeriodo = New PeriodoNullo
         Select Case TipoDocumento
            Case "IQA"
               Comp = New CompositePeriodo(New DataRange(DataInizio, DataFine), IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
               m_currentItem = Current.GetItemDaRistornare(utente, Comp, incasso)
            Case "IQI"
               Comp = New CompositePeriodo(New DataRange(DataInizio, DataFine), IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera)
               m_currentItem = Current.GetItemDaRistornare(utente, Comp, incasso, prestazione)
            Case "IQV"
               m_currentItem = Current.GetItemDaRistornare(IdIncasso)
               SelectCurrentDTO(IdIncasso)
               Exit Sub
         End Select
         SelectCurrentDTO(utente, Comp, incasso, prestazione)
      End Sub
      Private Overloads Sub SelectCurrentDTO(ByVal IdDocumentoPadre As String)
         For Each elem As DTOItemContabile In m_ListaDtoPosizioni
            If elem.DocumentoPadre.Id = IdDocumentoPadre Then
               m_CurrentDTO = elem
            End If
         Next
      End Sub
      Private Overloads Sub SelectCurrentDTO(ByVal Utente As Utente, ByVal Competenza As AbstractPeriodo, ByVal Incasso As DocumentoContabile, ByVal prestazione As Prestazione)
         For Each elem As DTOItemContabile In m_ListaDtoPosizioni
            If elem.Utente.IdUtente = Utente.Id And elem.Competenza.Equals(Competenza) And elem.DocumentoPadre.Id = Incasso.Id And elem.Prestazione.GetId = prestazione.Id Then
               m_CurrentDTO = elem
            End If
         Next
      End Sub

      Private Function GetIncassoById(ByVal IdIncasso As String, ByVal TipoDocumento As String) As DocumentoContabile
         Dim controllerIncassi As FINANCIAL_ARTIFACTS.AbstractDocumentController = AbstractDocumentController.GetDocumentController(TipoDocumento)
         Return controllerIncassi.GetDocumentoById(IdIncasso)
      End Function
      Private Function GetUtenteById(ByVal IdUtente As Int32) As Utente
         Try
            Return controllerUtenti.GetUtenteById(IdUtente)
         Catch ex As Exception
            Throw New Exception("Impossibile recuperare l'utente" & vbCrLf & ex.Message)
         End Try
      End Function
      Private Function GetPrestazioneById(ByVal IdPrestazione As String) As Prestazione
         Try
            If IsNumeric(IdPrestazione) Then
               Return controllerPrestazioni.GetPrestazioneById(IdPrestazione)
            End If
            Return New PrestazioneNulla
         Catch ex As Exception
            Throw New Exception("Impossibile recuperare l'utente" & vbCrLf & ex.Message)
         End Try
      End Function
      ''' <summary>
      ''' Metodo per modificare l'importo di una posizione ristornata o ristornabile
      ''' </summary>
      ''' <param name="Value"></param>
      ''' <remarks></remarks>
      Public Sub SetImportoItem(ByVal Value As String)
         If Not IsNumeric(Value) Then Throw New Exception("Impossibile impostare l'importo per la posizione. Importo non valido")
         Dim mon As New Moneta(Value, Moneta.Valuta.Euro)
         If m_currentItem.RistornoIsLessEqualThanImporto(mon) Then
            m_currentItem.SetImportoRistorno(mon, Current)
            SetImportoCurrentDTO(Value)
         Else
            Throw New Exception("L'importo del ristorno non può essere maggiore della quota stessa.")
         End If
      End Sub
      ''' <summary>
      ''' Metodo utilizzato per valorizzare correttamente il DTOCorrente
      ''' </summary>
      ''' <param name="Value"></param>
      ''' <remarks></remarks>
      Public Sub SetImportoCurrentDTO(ByVal Value As String)
         Dim mon As New Moneta(Value, Moneta.Valuta.Euro)
         m_CurrentDTO.ImportoRistorno = mon
      End Sub


      Public Sub CreateListaDto()
         Me.m_ListaDtoPosizioni = New ArrayList
         For Each elem As ItemContabile In Current.ItemsRistornate
            m_ListaDtoPosizioni.Add(elem.ToDto)
         Next
         'DirectCast(Me.m_ListaDtoPosizioni.Item(0), DTOItemContabile).ImportoRistorno = New Moneta(1, Moneta.Valuta.Euro)
      End Sub
      ''' <summary>
      ''' Metodo che imposta la lista delle posizioni iniziali da ristornare
      ''' </summary>
      ''' <param name="ListaPosizioni"></param>
      ''' <remarks></remarks>
      Public Sub SetListaPosizioniDaRistornare(ByVal ListaPosizioni As IList)
         If ListaPosizioni Is Nothing Then Throw New Exception("Impossibile impostare la lista delle posizioni ristornabili. Lista nulla.")
         If m_current Is Nothing Then Throw New Exception("Impossibile impostare la lista delle posizioni ristornabili. Pagamento corrente nullo. Creare un pagamento referente")
         m_ListaPosizioni = ListaPosizioni
         If m_ListaPosizioni.Count = 0 Then Throw New Exception("Non ci sono posizioni da pagare.")
         Current.SetItemListDaRistornare(m_ListaPosizioni)
      End Sub
      ''' <summary>
      ''' Imposta l'importo pspecificato per tutte le posizioni
      ''' </summary>
      ''' <param name="Value"></param>
      ''' <remarks></remarks>
      Public Sub SetImportoForAll(ByVal Value As String)
         If Not IsNumeric(Value) Then Throw New Exception("Impossibile impostare l'importo per la posizione. Importo non valido")
         Dim mon As New Moneta(Value, Moneta.Valuta.Euro)
         For Each elem As ItemIncassoQuotaAssociativa In Current.ItemsRistornate
            If elem.RistornoIsLessEqualThanImporto(mon) Then
               elem.SetImportoRistorno(mon, Current)
            Else
               Throw New Exception("L'importo del ristorno non può essere maggiore della quota stessa.")
            End If
         Next


      End Sub


      Public Overrides Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)
         Try
            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            Current.ItemsRistornate.Sort(SortFactory.GetItemComparer(PropertyName, Descending))
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Overloads Sub SortItems(ByVal PropertyName As String, ByVal Lista As ArrayList, Optional ByVal Descending As Boolean = False)
         Try
            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            Lista.Sort(SortFactory.GetItemComparer(PropertyName, Descending))
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Overloads Sub SortItems(ByVal PropertyName As String, ByVal Lista As IList, Optional ByVal Descending As Boolean = False)
         Try
            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            DirectCast(Lista, VirtualLazyList).Sort(SortFactory.GetItemComparer(PropertyName, Descending))
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
#End Region






#Region "Metodi CRUD"
      ''' <summary>
      ''' Metodo non implementato
      ''' </summary>
      ''' <remarks></remarks>
      Public Overrides Sub CreateNew()
         m_current = New PagamentoReferenti
      End Sub
      ''' <summary>
      ''' Crea un'istanza dell'oggetto pagamento  senza salvare
      ''' </summary>
      ''' <param name="DataRegistrazione"></param>
      ''' <param name="DataDocumento"></param>
      ''' <param name="Note"></param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                                     ByVal Note As String, ByVal IdReferente As String)
         Try
            If Not IsNumeric(IdReferente) Then Throw New Exception("Impossibile ricercare il referente. Id non corretto. Inserire un id corretto.")
            Dim referente As Referente = GetReferenteById(IdReferente)
            If m_Referente.ComponenteStruttura Then Throw New Exception("Il referente appartiene alla struttura. Non è possibile effettuare un ristorno")
            m_current = New PagamentoReferenti(DataRegistrazione, DataDocumento, Note, referente)
            'Dim list As IList = GetItemListDaRistornare(IdReferente)
            'If list.Count = 0 Then Throw New Exception("Non ci sono posizioni da pagare.")
            'Current.SetItemListDaRistornare(List)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Protected Overrides Sub CommitTransaction()
         Try
            Ps.BeginTransaction()
            Ps.MarkNew(Current)
            'registro adesso le variazioni a tutti gli alri oggetti modificati
            For Each elem As ItemContabile In Current.ItemsRistornate
               Ps.MarkDirty(elem)
            Next
            Ps.MarkDirty(Current.Referente)
            Ps.CommitTransaction()
            Ps.BeginTransaction()
         Catch ex As Exception
            Ps.RollBackTRansaction()
            Ps.BeginTransaction()
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Overrides Function GetCategoryObject() As String
         Return "PagamentoReferenti"
      End Function
      Protected Overrides Sub DoUpdate()
         Try
            Current.Post()
            'Ps.BeginTransaction()
            Ps.MarkDirty(Current)
            Dim listaPosizioni As IList = Current.ItemsRistornate
            For Each elem As ItemContabile In listaPosizioni
               Ps.MarkDirty(elem)
            Next
            Ps.CommitTransaction()
            Ps.BeginTransaction()
         Catch ex As Exception
            'Ps.RollBackTRansaction()
            Throw New Exception(ex.Message)
         End Try

      End Sub
#End Region

      Public Overrides Sub Delete()
         Try
            Ps.BeginTransaction()
            Ps.MarkRemoved(Current)
            Dim listaPosizioni As IList = Current.ItemsRistornate
            For Each elem As ItemContabile In listaPosizioni
               elem.ClearRistorno()
               Ps.MarkDirty(elem)
            Next
            Ps.CommitTransaction()
            Ps.BeginTransaction()
         Catch ex As Exception
            Throw New Exception("Impossibile eliminare l'incasso." & vbCrLf & ex.Message)
         End Try
      End Sub




   End Class
End Namespace