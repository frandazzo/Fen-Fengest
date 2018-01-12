Namespace FINANCIAL_ARTIFACTS
   Public Class ControllerIncassiQuoteVertenza
      Inherits ControllerIncassiQuote
      Private ControllerVertenze As New ADMINISTRATION.ControllerVertenze
      Private ControllerIstituti As New ADMINISTRATION.ControllerIstituti
      Private ControllerConti As New CONTI.ControllerConti
      Private Function Current() As IncassoQuotaVertenza
         Return DirectCast(MyBase.m_current, IncassoQuotaVertenza)
      End Function


#Region "Metodi di gestione del documento"
      Public Overrides ReadOnly Property IdSoggettoEsecutore() As String
         Get
            Return ""
         End Get
      End Property
      Public Overloads Sub SelectItem(ByVal IdVertenza As String)
         If Not IsNumeric(IdVertenza) Then Throw New Exception("L'id vertenza dell'item selezionato non ha un Id utente corretto!")
         m_currentItem = Current.GetItem(ControllerVertenze.GetVertenzaById(IdVertenza))
      End Sub
      Public Overloads Sub SelectCashItem()
         m_currentItem = Current.GetItemCash
      End Sub
      Public Overloads Sub RemoveItem(ByVal IdVertenza As String)
         Try
            If Not IsNumeric(IdVertenza) Then Throw New Exception("L'id vertenza dell'item selezionato non ha un Id utente corretto!")
            Dim vertenza As Vertenza = ControllerVertenze.GetVertenzaById(IdVertenza)
            Current.RemoveItem(vertenza)
         Catch ex As Exception
            Throw New Exception("Impossibile rimuovere l'item. " & vbCrLf & ex.Message)
         End Try
      End Sub

      Public Overrides ReadOnly Property TotaleAttribuito() As Double
         Get
            Return Current.GetItemCash.Importo.Importo - Current.GetTotal.Importo
         End Get
      End Property
      Public ReadOnly Property NomeUtente() As String
         Get
            Return Current.Utente.CompleteName
         End Get
      End Property
      ''' <summary>
      ''' Restituisce l'id della vertenza della prima posizione del documento
      ''' </summary>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public ReadOnly Property IdVertenza_FirstItem() As String
         Get
            Return Me.ListaPosizioniUtenti.Item(0).Vertenza.Id.ToString
         End Get
      End Property
      Public ReadOnly Property IdUtente() As String
         Get
            Return Current.Utente.Id
         End Get
      End Property

      Public Overloads Sub AddItem(ByVal Note As String, ByVal IdVertenza As String, ByVal IdReferente As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            'If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            If Not IsNumeric(IdVertenza) Then Throw New Exception("L'id della vertenza della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            'Dim utente As Utente = GetUtenteById(IdUtente)
            Dim referente As Referente = New ReferenteNullo
            If CInt(IdReferente) > 0 Then
               referente = GetReferenteById(IdReferente)
            End If
            Dim vertenza As Vertenza = ControllerVertenze.GetVertenzaById(IdVertenza)
            Dim utente As Utente = vertenza.Utente
            Current.AddItem(utente, New Moneta(0, Moneta.Valuta.Euro), Note, vertenza, referente)
            SetImporto(vertenza.Quota.Importo)
            SelectItem(vertenza.Id)
            SetImportoItem(vertenza.Quota.Importo)
         Catch ex As Exception
            Throw New Exception("Impossibile aggiungere una nuova posizione." & vbCrLf & ex.Message)
         End Try
      End Sub

#End Region

      Public Overrides ReadOnly Property Importo() As Double
         Get
            Return Current.GetItemCash.Importo.Importo
         End Get
      End Property
      Public Overrides Sub SetImporto(ByVal value As String)
         'If Current.IsPosted Then Throw New Exception("Impossibile impostare l'importo dell'incasso. Documento già registrato.")
         If Not IsNumeric(value) Then Throw New Exception("Il formato dell'importo non è corretto. Inserire un importo corretto.")
         Dim importo As Moneta = New Moneta(value, Current.GetItemCash.Importo.GetValuta)
         Current.GetItemCash.Importo = importo
      End Sub

#Region "Metodi di ricerca dal DB"
      'Protected Function GetIncassiForUtente(ByVal Utente As Utente) As ArrayList
      '   Try
      '      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      '      Dim query As Query = ps.CreateNewQuery("MapperIncassoQuotaVertenza")
      '      Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
      '      mainCriteria.AddCriteria(New AndExp(Criteria.Equal("TIPO_DOCUMENTO", "'IQV'"), Criteria.Equal("ID_UTENTE", Utente.Id)))
      '      'mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", Current.Competenza.GetDataRange.Start, Current.Competenza.GetDataRange.Finish))
      '      query.AddWhereClause(mainCriteria)
      '      Return query.Execute(ps)
      '   Catch ex As Exception
      '      Throw New Exception(ex.Message)
      '   End Try
      'End Function
#End Region

#Region "Metodi CRUD"
      Protected Overrides Sub LoadAll()
         Try
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperIncassoQuotaVertenza")
            Dim mainCriteria As Criteria = Criteria.Equal("TIPO_DOCUMENTO", "'IQV'")
            query.AddWhereClause(mainCriteria)
            DomainObjectList = query.Execute(ps)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub

      Protected Overrides Sub CommitTransaction()
         Try
            Ps.BeginTransaction()

            Dim listaPosizioni As IList = Current.ItemList
            Ps.MarkNew(Current)
            For Each elem As ItemIncassoQuoteVertenza In listaPosizioni
               Ps.MarkNew(elem)
            Next

            Ps.CommitTransaction()
         Catch ex As Exception
            Ps.RollBackTRansaction()
            Throw New Exception(ex.Message)
         End Try

      End Sub
      Public Overloads Sub CreateNew(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                                     ByVal Note As String, ByVal Importo As String, ByVal IdUtente As String)
         Try
            If Not IsNumeric(Importo) Then Throw New Exception("L'importo non ha una formato corretto")
            If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente non ha una formato corretto")
            m_current = New IncassoQuotaVertenza(DataRegistrazione, DataDocumento, Note, New Moneta(Importo, Moneta.Valuta.Euro), controllerUtenti.GetUtenteById(IdUtente), ControllerConti.GetContoById(1))
            Me.m_PagamentoCreato = True
         Catch ex As Exception
            Throw New Exception("Impossibile creare un nuovo incasso quota vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Overrides Function GetCategoryObject() As String
         Return "IncassoQuotaVertenza"
      End Function
#End Region
      Public Overrides ReadOnly Property ListaPosizioniUtenti() As IList
         Get
            Dim newlist As New ArrayList
            For Each elem As ItemIncassoQuoteVertenza In Current.ItemList
               If elem.Utente.IdUtente > 0 Then
                  newlist.Add(elem)
               End If
            Next
            Return newlist
         End Get
      End Property

      Protected Overrides Sub DoUpdate()
         Try
            Current.Post()
            Ps.BeginTransaction()
            Ps.MarkDirty(Current)
            Dim listaPosizioni As IList = Current.ItemList
            For Each elem As ItemIncassoQuoteVertenza In listaPosizioni
               Ps.MarkDirty(elem)
            Next
            Ps.CommitTransaction()
         Catch ex As Exception
            'Ps.RollBackTRansaction()
            Throw New Exception(ex.Message)
         End Try

      End Sub
      Public Overrides Sub Delete()
         Try
            If Not Current.HaItemRistornate Then
               Ps.DeleteObject(GetCategoryObject, m_current)
            Else
               Throw New Exception("L'incasso quote ha delle posizioni ristornate da uno o più documenti di pagamento referente.")
            End If
         Catch ex As Exception
            Throw New Exception("Impossibile eliminare l'incasso." & vbCrLf & ex.Message)
         End Try
      End Sub
   End Class
End Namespace
