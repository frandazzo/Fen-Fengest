Namespace FINANCIAL_ARTIFACTS
   Public Class ControllerIncassiQuoteInps
      Inherits ControllerIncassiQuote
      Private ControllerPrestazioni As New ADMINISTRATION.ControllerPrestazioni
      Private ControllerTipoPrestazioni As New ADMINISTRATION.ControllerTipoPrestazione
      Private Function Current() As IncassoQuotaInps
         Return DirectCast(MyBase.m_current, IncassoQuotaInps)
      End Function



      Public Sub New()
         Ps.BeginTransaction()
      End Sub


#Region "Metodi di gestione del documento"
      Public Overloads Sub SelectItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdTipoPrestazione As String)
         If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente dell'item selezionato non ha un Id utente corretto!")
         If Not IsNumeric(IdTipoPrestazione) Then Throw New Exception("L'id prestazione dell'item selezionato non ha un Id utente corretto!")
         m_currentItem = Current.GetItem(GetUtenteById(IdUtente), New CompositePeriodo(New DataRange(DataInizio, DataFine), Current.SoggettoEsecutore.UnitaDiCompetenza), ControllerTipoPrestazioni.GetTipoPrestazioneById(IdTipoPrestazione))
      End Sub
      'Public Overloads Sub RemoveItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdTipoPrestazione As String)
      '   Try
      '      If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
      '      If Not IsNumeric(IdTipoPrestazione) Then Throw New Exception("L'id della prestazione della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
      '      Dim utente As Utente = GetUtenteById(IdUtente)
      '      Dim competenza As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), Current.SoggettoEsecutore.UnitaDiCompetenza)
      '      Dim tipo As TipoPrestazione = ControllerTipoPrestazioni.GetTipoPrestazioneById(IdTipoPrestazione)
      '      If Not Current.GetItem(utente, competenza, tipo).PagamentoReferente.Id.ToString = "-1" Then
      '         Throw New Exception("Impossibile rimuovere l'item selezionato. Esiste un pagamento referenti cui la posizione è stata ristornata")
      '      End If
      '      If Current.IsPosted Then
      '         Ps.MarkRemoved(Current.GetItem(utente, competenza, tipo))
      '      End If
      '      Current.RemoveItem(utente, competenza, tipo)
      '   Catch ex As Exception
      '      Throw New Exception("Impossibile rimuovere l'item. " & vbCrLf & ex.Message)
      '   End Try
      'End Sub
      Public Overloads Sub AddItem(ByVal IdUtente As String, ByVal Importo As String, ByVal IdReferente As String, ByVal Note As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdPrestazione As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            If Not IsNumeric(IdPrestazione) Then Throw New Exception("L'id della prestazione della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            Dim utente As Utente = GetUtenteById(IdUtente)
            Dim referente As Referente = New ReferenteNullo
            If CInt(IdReferente) > 0 Then
               referente = GetReferenteById(IdReferente)
            End If
            Dim prestazione As Prestazione = ControllerPrestazioni.GetPrestazioneById(IdPrestazione)
            Dim competenza As AbstractPeriodo = Me.CreateCompetenza(Current.SoggettoEsecutore, DataInizio, DataFine)
            Try
               Current.AddItem(utente, Importo, competenza, referente, Note, prestazione)
            Catch ex As ArgumentException
               competenza = Current.GetFirstAivablePeriod(Current.GetItemListByUtente(utente), prestazione)
               Current.AddItem(utente, Importo, competenza, referente, Note, prestazione)
            End Try
            If Current.IsPosted Then
               Ps.MarkNew(Current.GetItem(utente, competenza, ControllerPrestazioni.GetPrestazioneById(IdPrestazione).TipoPrestazione))
            End If
         Catch ex As Exception
            Throw New Exception("Impossibile aggiungere una nuova posizione." & vbCrLf & ex.Message)
         End Try
      End Sub
      'Public Overloads Sub AddItem(ByVal IdTipoPrestazione As String, ByVal IdUtente As String, ByVal Importo As String, ByVal IdReferente As String, ByVal Note As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
      '   Try
      '      If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
      '      If Not IsNumeric(IdTipoPrestazione) Then Throw New Exception("L'id della prestazione della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
      '      If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
      '      If Not IsNumeric(Importo) Then Throw New Exception("L'importo della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
      '      Dim utente As Utente = GetUtenteById(IdUtente)
      '      Dim referente As Referente = New ReferenteNullo
      '      If CInt(IdReferente) > 0 Then
      '         referente = GetReferenteById(IdReferente)
      '      End If
      '      Dim competenza As AbstractPeriodo = Me.CreateCompetenza(Current.SoggettoEsecutore, DataInizio, DataFine)
      '      Dim prestazione As Prestazione = CreateNewPrestazione(IdTipoPrestazione, IdUtente, IdReferente)
      '      Current.AddItem(utente, Importo, competenza, referente, Note, Prestazione)
      '   Catch ex As Exception
      '      Throw New Exception("Impossibile aggiungere una nuova posizione." & vbCrLf & ex.Message)
      '   End Try
      'End Sub

      Private Function CreateNewPrestazione(ByVal IdTipoPrestazione As String, ByVal IdUtente As String, ByVal IdReferente As String) As Prestazione
         Try
            ControllerPrestazioni.CreateNew()
            ControllerPrestazioni.DataRegistrazione = Current.DataRegistrazione
            ControllerPrestazioni.DataDocumento = Current.DataDocumento
            ControllerPrestazioni.Note = "Prestazione generata dal sistema per l'incasso delle quote in data " & Current.DataDocumento
            ControllerPrestazioni.SetTipoPrestazione(IdTipoPrestazione)
            ControllerPrestazioni.SetReferente(IdReferente)
            ControllerPrestazioni.SetUtente(IdUtente)
            Return DirectCast(ControllerPrestazioni.GetCurrent, Prestazione)
         Catch ex As Exception
            Throw New Exception("Impossibile creare una nuova prestazione" & vbCrLf & ex.Message)
         End Try

      End Function
#End Region



#Region "Metodi di ricerca dal DB"
      Public Overrides Function EsistonoIncassiSovrapposti() As Boolean
         Try
            Dim pagamenti As ArrayList = GetIncassiForSoggetto()
            If pagamenti.Count = 0 Then Return False
            Return True
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
      Protected Overloads Function GetIncassiForSoggetto() As ArrayList
         Try
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperIncassoQuotaInps")
            Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            mainCriteria.AddCriteria(Criteria.Equal("TIPO_DOCUMENTO", "'IQI'"))
            mainCriteria.AddCriteria(New DateRangeIntersectsCriteria("DATA_INIZIO_COMP", "DATA_FINE_COMP", Current.Competenza.GetDataRange.Start, Current.Competenza.GetDataRange.Finish, ps.DBType))
            query.AddWhereClause(mainCriteria)
            Return query.Execute(ps)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
#End Region

#Region "Metodi CRUD"
      Protected Overrides Sub LoadAll()
         Try
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperIncassoQuotaInps")
            Dim mainCriteria As Criteria = Criteria.Equal("TIPO_DOCUMENTO", "'IQI'")
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
            For Each elem As ItemIncassoQuoteInps In listaPosizioni
               If elem.PosizioneUtente Then
                  Try
                     elem.Prestazione.GetId()
                     'se ho una posizione nuova la chiave è nulla
                  Catch ex As Exception
                     'aggingo la posizione
                     Ps.MarkNew(elem.Prestazione)
                  End Try
               End If
            Next

            Ps.MarkNew(Current)
            For Each elem As ItemIncassoQuoteInps In listaPosizioni
               Ps.MarkNew(elem)
            Next
            'ATTenzione devo aggiornare l'INPS
            'coreggere
            Ps.MarkDirty(Current.GetItemWithSoggEsecutore.SoggettoEsecutore)



            Ps.CommitTransaction()
            Ps.BeginTransaction()
         Catch ex As Exception
            Ps.RollBackTRansaction()

            Throw New Exception(ex.Message)
         End Try

      End Sub
      ''' <summary>
      ''' Crea una nuova istanza dell'oggetto Incasso quota Inps
      ''' </summary>
      ''' <param name="DataRegistrazione"></param>
      ''' <param name="DataDocumento"></param>
      ''' <param name="Importo"></param>
      ''' <param name="Note"></param>
      ''' <param name="DataInizio"></param>
      ''' <param name="DataFine"></param>
      ''' <param name="Tredicesima"></param>
      ''' <param name="Quattordicesima"></param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                                           ByVal Importo As String, _
                                           ByVal Note As String, _
                                           ByVal DataInizio As DateTime, _
                                           ByVal DataFine As DateTime, _
                                           Optional ByVal Tredicesima As Boolean = False, _
                                           Optional ByVal Quattordicesima As Boolean = False)
         Try

            Dim soggetto As Inps = ControllerInps.GetInps
            If DataInizio = DateTime.MinValue Or DataInizio = DateTime.MaxValue Then Throw New Exception("Inserire una competenza corretta per l'incasso.")
            If DataFine = DateTime.MinValue Or DataFine = DateTime.MaxValue Then Throw New Exception("Inserire una competenza corretta per l'incasso.")
            Dim competenza As AbstractPeriodo = CreateCompetenza(soggetto, DataInizio, DataFine)
            'una volta impostata la competenza posso creare il documento
            m_current = New IncassoQuotaInps(DataRegistrazione, DataDocumento, competenza, Note, soggetto.Conto.Valuta, Importo, soggetto)
            Me.m_PagamentoCreato = True
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Overrides Function GetCategoryObject() As String
         Return "IncassoQuotaInps"
      End Function
#End Region
      Public Overloads Sub RemoveItem(ByVal IdUtente As String, ByVal DataInizio As DateTime, ByVal DataFine As DateTime, ByVal IdPrestazione As String)
         Try
            If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente della posizione selezionata non ha un formato corretto. Inserire un id corretto.")
            Dim utente As Utente = GetUtenteById(IdUtente)
            Dim prestazione As Prestazione = ControllerPrestazioni.GetPrestazioneById(IdPrestazione)
            Dim competenza As AbstractPeriodo = New CompositePeriodo(New DataRange(DataInizio, DataFine), Current.SoggettoEsecutore.UnitaDiCompetenza)
            If Not Current.GetItem(utente, competenza, prestazione.TipoPrestazione).PagamentoReferente.Id = -1 Then
               Throw New Exception("Impossibile rimuovere l'item selezionato. Esiste un pagamento referenti cui la posizione è stata ristornata")
            End If

            If Current.IsPosted Then
               Ps.MarkRemoved(Current.GetItem(utente, competenza, prestazione.TipoPrestazione))
            End If
            Current.RemoveItem(utente, competenza, prestazione.TipoPrestazione)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub


   End Class
End Namespace