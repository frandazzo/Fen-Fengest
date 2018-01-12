Public Class MapperDelega
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_DELEGA"
   End Function
   Protected Function FindAllByUserStatement() As String
      Return "Select * from DB_DELEGA where Id_Utente = @Id"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_DELEGA where Id = @Id and Id_Utente = @IdU"
   End Function
   Protected Overrides Function InsertStatement() As String
      ', DATA_DOCUMENTO 
      ' @Ddc, @Not,
      Return "Insert into DB_DELEGA (ID, DATA_SOTTOSCRIZIONE, DATA_DOCUMENTO, NOTE_DEL, ID_UTENTE, ID_AZIENDA, " _
                                    & "ID_REFERENTE, DATA_INOLTRO, DATA_ACCETTAZIONE, " _
                                    & "DATA_ANNULLAMENTO, " _
                                    & "STATO_DELEGA, DATA_ATTIVAZIONE, ID_PAGAMENTO, " _
                                    & "ID_SETTORE, " _
                                    & "STATO_DELEGA_PRECEDENTE, ID_DELEGA_ANNULLAMENTO, " _
                                    & "DATA_REVOCA, ID_CAUSALE, ID_CAUSALE_SOTT, ID_REPARTO, NOME_SEDE_OPERATIVA, ID_RESPONSABILE, DATA_IMPORTAZIONE, CreatedBy, CreatedOn) values " _
                                    & "(@Id, @Dso, @Ddc, @Not, @Ut, @Az, @Ref, @Din,  " _
                                    & "@Dac, @Dan, @Std, @Dat, @Pag, " _
                                    & "@Ids, @Sdp, @IdDa, @Dr, @Cau, @Cas, @Rep, @Sed, @Resp, @Dimp, @CRby, @CRon)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_DELEGA SET DATA_SOTTOSCRIZIONE = @Dso, DATA_DOCUMENTO = @Ddc, NOTE_DEL = @Not, " _
                                 & "ID_UTENTE = @Ut, ID_AZIENDA = @Az, " _
                                 & "ID_REFERENTE = @Ref,  DATA_INOLTRO = @Din, DATA_ACCETTAZIONE = @Dac, " _
                                 & "DATA_ANNULLAMENTO = @Dan, " _
                                 & "STATO_DELEGA = @Std, DATA_ATTIVAZIONE = @Dat, " _
                                 & "ID_PAGAMENTO = @Pag, ID_SETTORE = @Ids, " _
                                 & "STATO_DELEGA_PRECEDENTE = @Sdp, ID_DELEGA_ANNULLAMENTO = @IdDa, " _
                                 & "DATA_REVOCA = @Dr, ID_CAUSALE = @Cau, ID_CAUSALE_SOTT = @Cas, ID_REPARTO = @Rep, NOME_SEDE_OPERATIVA = @Sed, ID_RESPONSABILE = @Resp , DATA_IMPORTAZIONE = @Dimp, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE ( Id = @Id )"
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_DELEGA where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_DELEGA"
   End Function

#End Region

#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"
   Protected Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal Utente As Utente, Optional ByVal FindAllForDeletion As Boolean = False) As AbstractPersistenceObject
      Try
         'se ricerco tutti gli oggetti per cancellarli non passero un utente specificato alla funzione
         If FindAllForDeletion Or Utente Is Nothing Then
            Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
            Dim MapperUtenti As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
            Utente = MapperUtenti.FindObjectById(ID_UTENTE)
         End If

         Dim delega As Delega = CreateDelega(Key, rs, Utente)

         Return delega
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto delega" & vbCrLf & ex.Message)
      End Try
   End Function



   Private Function CreateDelega(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal Utente As Utente) As Delega
      Dim DATA_IMPORTAZIONE As DateTime = IIf(rs("DATA_IMPORTAZIONE") IsNot Nothing, rs("DATA_IMPORTAZIONE"), DateTime.MinValue)
      Dim DATA_REVOCA As DateTime = IIf(rs("DATA_REVOCA") IsNot Nothing, rs("DATA_REVOCA"), DateTime.MinValue)
      Dim DATA_SOTTOSCRIZIONE As DateTime = IIf(rs("DATA_SOTTOSCRIZIONE") IsNot Nothing, rs("DATA_SOTTOSCRIZIONE"), DateTime.MinValue)
      Dim DATA_DOCUMENTO As DateTime = IIf(rs("DATA_DOCUMENTO") IsNot Nothing, rs("DATA_DOCUMENTO"), DateTime.MinValue)
      Dim DATA_INOLTRO As DateTime = IIf(rs("DATA_INOLTRO") IsNot Nothing, rs("DATA_INOLTRO"), DateTime.MinValue)
      Dim DATA_ACCETTAZIONE As DateTime = IIf(rs("DATA_ACCETTAZIONE") IsNot Nothing, rs("DATA_ACCETTAZIONE"), DateTime.MinValue)
      Dim DATA_ANNULLAMENTO As DateTime = IIf(rs("DATA_ANNULLAMENTO") IsNot Nothing, rs("DATA_ANNULLAMENTO"), DateTime.MinValue)
      Dim DATA_ATTIVAZIONE As DateTime = IIf(rs("DATA_ATTIVAZIONE") IsNot Nothing, rs("DATA_ATTIVAZIONE"), DateTime.MinValue)
      Dim NOTE As String = IIf(rs("NOTE_DEL") IsNot Nothing, rs("NOTE_DEL"), "")

      Dim STATO_DELEGA As String = IIf(rs("STATO_DELEGA") IsNot Nothing, rs("STATO_DELEGA"), "Sottoscritta")

      Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
      'Dim ID_AZIENDA2 As Int32 = IIf(rs("ID_AZIENDA2") IsNot Nothing, rs("ID_AZIENDA2"), -1)
      Dim ID_DELEGA_ANNULLAMENTO As Int32 = IIf(rs("ID_DELEGA_ANNULLAMENTO") IsNot Nothing, rs("ID_DELEGA_ANNULLAMENTO"), -1)
      Dim STATO_DELEGA_PRECEDENTE As String = IIf(rs("STATO_DELEGA_PRECEDENTE") IsNot Nothing, rs("STATO_DELEGA_PRECEDENTE"), "Nullo")


      Dim ID_CAUSALE As Int32 = IIf(rs("ID_CAUSALE") IsNot Nothing, rs("ID_CAUSALE"), -1)
      Dim ID_REFERENTE As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
      Dim ID_RESPONSABILE As Int32 = IIf(rs("ID_RESPONSABILE") IsNot Nothing, rs("ID_RESPONSABILE"), -1)
      Dim NOME_SEDE As String = IIf(rs("NOME_SEDE_OPERATIVA") IsNot Nothing, rs("NOME_SEDE_OPERATIVA"), "")
      'Dim ID_AZIENDA_ACCETTANTE As Int32 = IIf(rs("ID_AZIENDA_ACCETTANTE") IsNot Nothing, rs("ID_AZIENDA_ACCETTANTE"), -1)
      'Dim ID_AZIENDA_ACCETTANTE2 As Int32 = IIf(rs("ID_AZIENDA_ACCETTANTE2") IsNot Nothing, rs("ID_AZIENDA_ACCETTANTE2"), -1)
      Dim ID_SETTORE As Int32 = IIf(rs("ID_SETTORE") IsNot Nothing, rs("ID_SETTORE"), -1)
      Dim ID_PAGAMENTO As Int32 = IIf(rs("ID_PAGAMENTO") IsNot Nothing, rs("ID_PAGAMENTO"), -1)
      Dim ID_CAUSALE_SOTT As Int32 = IIf(rs("ID_CAUSALE_SOTT") IsNot Nothing, rs("ID_CAUSALE_SOTT"), -1)
      Dim ID_REPARTO As Int32 = IIf(rs("ID_REPARTO") IsNot Nothing, rs("ID_REPARTO"), -1)
      Dim MapperSettore As MapperSettore = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSettore")

      Dim MapperEnte As MapperEnteBilaterale = PersistenceMapperRegistry.Instance.GetMapperByName("MapperEnteBilaterale")
      Dim MapperAziende As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")
      Dim MapperReferenti As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
      Dim MapperPagamenti As MapperIncassoQuotaAssociativa = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncassoQuotaAssociativa")
      Dim MapperCausali As MapperCausaleRevocaDelega = PersistenceMapperRegistry.Instance.GetMapperByName("MapperCausaleRevocaDelega")

      Dim Mapperreparto As MapperRepartoAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperRepartoAzienda")
      Dim MapperCausaleSott As MapperCausaleSottoscrizioneDelega = PersistenceMapperRegistry.Instance.GetMapperByName("MapperCausaleSottoscrizioneDelega")



      Dim SETTORE As Settore = MapperSettore.FindObjectById(ID_SETTORE)
      Dim CAUSALE As CausaleRevocaDelega = MapperCausali.FindObjectById(ID_CAUSALE)
      If CAUSALE Is Nothing Then CAUSALE = New CausaleNulla
      Dim CAUSALE_SOTT As CausaleSottoscrizioneDelega = MapperCausaleSott.FindObjectById(ID_CAUSALE_SOTT)
      Dim REPARTO As RepartoAzienda = Mapperreparto.FindObjectById(ID_REPARTO)
      If REPARTO Is Nothing Then REPARTO = New RepartoNullo

      Dim AZIENDA As Azienda = Nothing
      Dim sede As SedeOperativa = New SedeOperativaNulla
      'Dim AZIENDA2 As Azienda = Nothing
      'Dim AZIENDA_ACCETTANTE As Azienda = Nothing
      'Dim AZIENDA_ACCETTANTE2 As Azienda = Nothing
      Select Case SETTORE.TipologiaSettore
         Case DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.Edili
            AZIENDA = MapperEnte.FindObjectById(ID_AZIENDA)
            'AZIENDA2 = MapperEnte.FindObjectById(ID_AZIENDA2)
            'AZIENDA_ACCETTANTE = MapperEnte.FindObjectById(ID_AZIENDA_ACCETTANTE)
            'AZIENDA_ACCETTANTE2 = MapperEnte.FindObjectById(ID_AZIENDA_ACCETTANTE2)
            'If AZIENDA_ACCETTANTE Is Nothing Then AZIENDA_ACCETTANTE = New AziendaNonSpecificata
            'If AZIENDA_ACCETTANTE2 Is Nothing Then AZIENDA_ACCETTANTE2 = New AziendaNonSpecificata
            'If AZIENDA Is Nothing Then AZIENDA = New AziendaNonSpecificata
            'If AZIENDA2 Is Nothing Then AZIENDA2 = New AziendaNonSpecificata
         Case DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi
            AZIENDA = MapperAziende.FindObjectById(ID_AZIENDA)
            sede = AZIENDA.GetSedeOperativaByDescrizione(NOME_SEDE)
            'AZIENDA2 = MapperAziende.FindObjectById(ID_AZIENDA2)
            'AZIENDA_ACCETTANTE = MapperAziende.FindObjectById(ID_AZIENDA_ACCETTANTE)
            'AZIENDA_ACCETTANTE2 = MapperAziende.FindObjectById(ID_AZIENDA_ACCETTANTE2)
            'If AZIENDA_ACCETTANTE Is Nothing Then AZIENDA_ACCETTANTE = New AziendaNonSpecificata
            'If AZIENDA_ACCETTANTE2 Is Nothing Then AZIENDA_ACCETTANTE2 = New AziendaNonSpecificata
            'If AZIENDA Is Nothing Then AZIENDA = New AziendaNonSpecificata
            'If AZIENDA2 Is Nothing Then AZIENDA2 = New AziendaNonSpecificata
      End Select

      Dim REFERENTE As Referente = MapperReferenti.FindObjectById(ID_REFERENTE)
      Dim RESPONSABILE As Referente = MapperReferenti.FindObjectById(ID_RESPONSABILE)
      If RESPONSABILE Is Nothing Then RESPONSABILE = New ReferenteNullo
      If REFERENTE Is Nothing Then REFERENTE = New ReferenteNullo
      Dim PAGAMENTO As DocumentoContabile = MapperPagamenti.FindObjectById(ID_PAGAMENTO)
      If PAGAMENTO Is Nothing Then PAGAMENTO = New DocumentoNullo

      Dim delega As Delega = New Delega(DATA_SOTTOSCRIZIONE, DATA_DOCUMENTO, NOTE, Utente, REFERENTE, AZIENDA, New StSottoscritta, SETTORE, CAUSALE_SOTT, REPARTO, True)
      delega.Key = Key
      delega.DataImportazione = DATA_IMPORTAZIONE
      delega.StatoPrecedente = StatusDelegaFactory.GetStatus(STATO_DELEGA_PRECEDENTE)
      delega.SetIdDelegaAnnullamento(ID_DELEGA_ANNULLAMENTO)
      delega.Responsabile = RESPONSABILE
      If Not sede Is Nothing Then
         delega.SedeOperativa = sede
      End If
      Select Case STATO_DELEGA
         Case "Sottoscritta"
         Case "Inoltrata"
            delega.DataInoltro = DATA_INOLTRO
            delega.StatoDelega = New StInoltrata
            'If Not AZIENDA_ACCETTANTE.Id = -1 Then
            '   delega.EnteAccettante1 = AZIENDA_ACCETTANTE
            'End If
            'If Not AZIENDA_ACCETTANTE2.Id = -1 Then
            '   delega.EnteAccettante2 = AZIENDA_ACCETTANTE2
            'End If
         Case "Accettata"
            delega.DataInoltro = DATA_INOLTRO
            delega.DataAccettazioneDelega = DATA_ACCETTAZIONE
            'If Not AZIENDA_ACCETTANTE.Id = -1 Then
            '   delega.EnteAccettante1 = AZIENDA_ACCETTANTE
            'End If
            'If Not AZIENDA_ACCETTANTE2.Id = -1 Then
            '   delega.EnteAccettante2 = AZIENDA_ACCETTANTE2
            'End If
            delega.StatoDelega = New StAccettata


         Case "Attivata"
            delega.DataInoltro = DATA_INOLTRO
            delega.DataAccettazioneDelega = DATA_ACCETTAZIONE
            'If Not AZIENDA_ACCETTANTE.Id = -1 Then
            '   delega.EnteAccettante1 = AZIENDA_ACCETTANTE
            'End If
            'If Not AZIENDA_ACCETTANTE2.Id = -1 Then
            '   delega.EnteAccettante2 = AZIENDA_ACCETTANTE2
            'End If
            delega.DataDecorrenzaDelega = DATA_ATTIVAZIONE
            If Not PAGAMENTO.Id = -1 Then
               delega.PagamentoAttivazione = PAGAMENTO
            End If
            delega.StatoDelega = New StAttiva


         Case "Annullata"
            delega.DataInoltro = DATA_INOLTRO
            delega.DataAccettazioneDelega = DATA_ACCETTAZIONE
            delega.DataAnnullamentoDelega = DATA_ANNULLAMENTO
            delega.StatoDelega = New StAnnullata

            delega.DataInoltro = DATA_INOLTRO
            delega.DataAccettazioneDelega = DATA_ACCETTAZIONE
            'If Not AZIENDA_ACCETTANTE.Id = -1 Then
            '   delega.EnteAccettante1 = AZIENDA_ACCETTANTE
            'End If
            'If Not AZIENDA_ACCETTANTE2.Id = -1 Then
            '   delega.EnteAccettante2 = AZIENDA_ACCETTANTE2
            'End If
            delega.DataDecorrenzaDelega = DATA_ATTIVAZIONE
            If Not PAGAMENTO.Id = -1 Then
               delega.PagamentoAttivazione = PAGAMENTO
            End If
            delega.CausaleFineCiclo = CAUSALE
         Case "Revocata"
            delega.StatoDelega = New StRevocata
            delega.DataRevocaDelega = DATA_REVOCA

            delega.DataInoltro = DATA_INOLTRO
            delega.DataAccettazioneDelega = DATA_ACCETTAZIONE
            'If Not AZIENDA_ACCETTANTE.Id = -1 Then
            '   delega.EnteAccettante1 = AZIENDA_ACCETTANTE
            'End If
            'If Not AZIENDA_ACCETTANTE2.Id = -1 Then
            '   delega.EnteAccettante2 = AZIENDA_ACCETTANTE2
            'End If
            delega.DataDecorrenzaDelega = DATA_ATTIVAZIONE
            If Not PAGAMENTO.Id = -1 Then
               delega.PagamentoAttivazione = PAGAMENTO
            End If
            delega.CausaleFineCiclo = CAUSALE



         Case Else
            Throw New Exception("Impossibile caricare l'oggetto delega. Stato delega sconosciuto. (" & STATO_DELEGA & ")")
      End Select
      JournalingDataLoader.ReadJournalingParameters(delega, rs)
      Return delega
   End Function

   ''' <summary>
   ''' Mai usare questo metodo. Non rispetta i riferimenti circolari.
   ''' </summary>
   ''' <param name="Id"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Return DirectCast(MyBase.FindByKey(New Key(Id)), Delega)
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand
    '   ' Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function
   Protected Overrides Function GetObjectFromStorage(ByVal Key As Key) As AbstractPersistenceObject
      Dim rs As IDataReader = Nothing
      Dim dataHash As Hashtable
      Try
         'qui devo leggere l'oggetto in un datareader e caricarlo
            If m_PersistentService.CurrentConnection.State = ConnectionState.Closed Then m_PersistentService.CurrentConnection.Open()
         rs = GetDBRecordData(Key)
         If rs.Read Then
            dataHash = LoadHashTableDataFromDatareader(rs)
            rs.Close()
            Dim obj As AbstractPersistenceObject = Load(dataHash, New UtenteNonSpecificato, True)
            Return obj
         End If
         Return Nothing
      Catch ex As Exception
         Throw
      Finally
         ReleaseDBDatareader(rs)
         dataHash = New Hashtable
      End Try
   End Function
#End Region

#Region "Metodi per recuperare molti  oggetti della tabella"
   Public Overrides Function FindAll() As System.Collections.IList
      Dim rs As IDataReader = Nothing
      Dim DataList As ArrayList
      Dim ObjectList As IList
      Try
         rs = GetDBRecordData()
         DataList = LoadDataMatrix(rs)
         rs.Close()
         ObjectList = Me.LoadAll(DataList, New UtenteNonSpecificato, True)
         Return ObjectList
      Catch ex As Exception
         Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti presenti nella tabella. " & vbCrLf & ex.Message)
      Finally
         ReleaseDBDatareader(rs)
         'libero la memoria
         DataList = New ArrayList
      End Try
   End Function
   Public Function FindDelegheByUtente(ByVal Utente As Utente) As ArrayList
      Dim rs As IDataReader = Nothing
      Dim Datalist As IList
      Dim Lista As IList
      Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            m_PersistentService.CurrentConnection.Open()
            Dim cmd As IDbCommand = GetCommand(FindAllByUserStatement)
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = Utente.IdUtente
            cmd.Parameters.Add(param)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            Lista = LoadAll(Datalist, Utente)
            m_PersistentService.CurrentConnection.Close()
         'RipristinaRiferimentoCircolareCon(Utente, Lista)
         Return Lista
      Catch ex As Exception
         Throw
      Finally
         ReleaseDBDatareader(rs)
         Datalist = New ArrayList
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
      End Try
   End Function
#End Region

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         'inserisco sempre una delega sottoscritta. la modifica può implicare un cambiamento di stato
         Dim Delega As Delega = DirectCast(Item, Delega)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Dso"
         param.Value = Delega.GetDataRegistrazione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ddc"
         param.Value = Delega.DataDocumento
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Not"
         param.Value = Delega.Note
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ut"
         param.Value = Delega.Utente.IdUtente
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Az"
         Dim az As Azienda = Delega.EnteInoltro
         param.Value = az.IdAzienda
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ref"
         If Delega.Referente.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.Referente.Key.LongValue
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Din"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Dac"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Dan"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Std"
         param.Value = Delega.StatoDelega.StatusName
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Dat"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Pag"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Ids"
         param.Value = Delega.Settore.Id
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Sdp"
         param.Value = Delega.StatoPrecedente.StatusName
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@IdDa"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Dr"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Cau"
         param.Value = DBNull.Value
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Cas"
         param.Value = Delega.CausaleSottoscrizione.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Rep"
         If Delega.Reparto.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.Reparto.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Sed"
         If Delega.SedeOperativa.Descrizione = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.SedeOperativa.Descrizione
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Resp"
         If Delega.Responsabile.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.Responsabile.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Dimp"
         If Delega.DataImportazione = DateTime.MinValue Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.DataImportazione
         End If
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         'la modifica della delaga può implicare un cambiamento di stato
         Dim Delega As Delega = DirectCast(Item, Delega)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Dso"
         param.Value = Delega.GetDataRegistrazione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ddc"
         param.Value = Delega.DataDocumento
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Not"
         param.Value = Delega.Note
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ut"
         param.Value = Delega.Utente.IdUtente
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Az"
         Dim az As Azienda = Delega.EnteInoltro
         param.Value = az.IdAzienda
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ref"
         If Delega.Referente.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.Referente.Key.LongValue
         End If
         Cmd.Parameters.Add(param)

         'fino qui la delega ha sempre valori validi
         'adesso a seconda dello stato della delega devo scegliere come valorizzare i parametri

         Select Case Delega.StatoDelega.StatusName
            Case "Sottoscritta"
               param = Cmd.CreateParameter
               param.ParameterName = "@Din"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dac"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dan"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Std"
               param.Value = Delega.StatoDelega.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dat"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Pag"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Ids"
               param.Value = Delega.Settore.Id
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Sdp"
               param.Value = Delega.StatoPrecedente.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@IdDa"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dr"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Cau"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Cas"
               param.Value = Delega.CausaleSottoscrizione.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Rep"
               If Delega.Reparto.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.Reparto.Id
               End If
               Cmd.Parameters.Add(param)
            Case "Inoltrata"

               param = Cmd.CreateParameter
               param.ParameterName = "@Din"
               param.Value = Delega.DataInoltro
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dac"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dan"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Std"
               param.Value = Delega.StatoDelega.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dat"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Pag"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Ids"
               param.Value = Delega.Settore.Id
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Sdp"
               param.Value = Delega.StatoPrecedente.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@IdDa"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dr"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Cau"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Cas"
               param.Value = Delega.CausaleSottoscrizione.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Rep"
               If Delega.Reparto.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.Reparto.Id
               End If
               Cmd.Parameters.Add(param)

            Case "Accettata"


               param = Cmd.CreateParameter
               param.ParameterName = "@Din"
               param.Value = Delega.DataInoltro
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dac"
               param.Value = Delega.DataAccettazioneDelega
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dan"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Std"
               param.Value = Delega.StatoDelega.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dat"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Pag"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Ids"
               param.Value = Delega.Settore.Id
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Sdp"
               param.Value = Delega.StatoPrecedente.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@IdDa"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dr"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Cau"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Cas"
               param.Value = Delega.CausaleSottoscrizione.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Rep"
               If Delega.Reparto.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.Reparto.Id
               End If
               Cmd.Parameters.Add(param)


            Case "Attivata"

               param = Cmd.CreateParameter
               param.ParameterName = "@Din"
               param.Value = Delega.DataInoltro
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dac"
               param.Value = Delega.DataAccettazioneDelega
               Cmd.Parameters.Add(param)




               param = Cmd.CreateParameter
               param.ParameterName = "@Dan"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Std"
               param.Value = Delega.StatoDelega.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dat"
               param.Value = Delega.DataDecorrenzaDelega
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Pag"
               param.Value = Delega.PagamentoAttivazione.GetId
               Cmd.Parameters.Add(param)




               param = Cmd.CreateParameter
               param.ParameterName = "@Ids"
               param.Value = Delega.Settore.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Sdp"
               param.Value = Delega.StatoPrecedente.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@IdDa"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dr"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Cau"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Cas"
               param.Value = Delega.CausaleSottoscrizione.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Rep"
               If Delega.Reparto.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.Reparto.Id
               End If
               Cmd.Parameters.Add(param)



            Case "Annullata"
               param = Cmd.CreateParameter
               param.ParameterName = "@Din"
               If Delega.DataInoltro = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataInoltro
               End If
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dac"
               If Delega.DataAccettazioneDelega = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataAccettazioneDelega
               End If
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dan"
               If Delega.DataAnnullamentoDelega = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataAnnullamentoDelega
               End If
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Std"
               param.Value = Delega.StatoDelega.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dat"
               If Delega.DataDecorrenzaDelega = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataDecorrenzaDelega
               End If
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Pag"
               If Not Delega.PagamentoAttivazione Is Nothing Then
                  param.Value = Delega.PagamentoAttivazione.GetId
               Else
                  param.Value = DBNull.Value
               End If
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Ids"
               param.Value = Delega.Settore.Id
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Sdp"
               param.Value = Delega.StatoPrecedente.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@IdDa"
               param.Value = Delega.DelegaDiAnnullamento.IdDelega
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dr"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Cau"
               If Delega.CausaleFineCiclo.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.CausaleFineCiclo.Id
               End If
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Cas"
               param.Value = Delega.CausaleSottoscrizione.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Rep"
               If Delega.Reparto.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.Reparto.Id
               End If
               Cmd.Parameters.Add(param)


            Case "Revocata"
               param = Cmd.CreateParameter
               param.ParameterName = "@Din"
               If Delega.DataInoltro = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataInoltro
               End If
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dac"
               If Delega.DataAccettazioneDelega = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataAccettazioneDelega
               End If
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dan"
               If Delega.DataAnnullamentoDelega = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataAnnullamentoDelega
               End If
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Std"
               param.Value = Delega.StatoDelega.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Dat"
               If Delega.DataDecorrenzaDelega = DateTime.MinValue Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.DataDecorrenzaDelega
               End If
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Pag"
               If Not Delega.PagamentoAttivazione Is Nothing Then
                  param.Value = Delega.PagamentoAttivazione.GetId
               Else
                  param.Value = DBNull.Value
               End If
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Ids"
               param.Value = Delega.Settore.Id
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@Sdp"
               param.Value = Delega.StatoPrecedente.StatusName
               Cmd.Parameters.Add(param)


               param = Cmd.CreateParameter
               param.ParameterName = "@IdDa"
               param.Value = DBNull.Value
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Dr"
               param.Value = Delega.DataRevocaDelega
               Cmd.Parameters.Add(param)



               param = Cmd.CreateParameter
               param.ParameterName = "@Cau"
               If Delega.CausaleFineCiclo.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.CausaleFineCiclo.Id
               End If
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Cas"
               param.Value = Delega.CausaleSottoscrizione.Id
               Cmd.Parameters.Add(param)

               param = Cmd.CreateParameter
               param.ParameterName = "@Rep"
               If Delega.Reparto.Id = -1 Then
                  param.Value = DBNull.Value
               Else
                  param.Value = Delega.Reparto.Id
               End If
               Cmd.Parameters.Add(param)


            Case Else
               Throw New Exception("Stato delega sconosciuto. (" & Delega.StatoDelega.StatusName & ")")
         End Select

         param = Cmd.CreateParameter
         param.ParameterName = "@Sed"
         If Delega.SedeOperativa.Descrizione = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.SedeOperativa.Descrizione
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Resp"
         If Delega.Responsabile.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.Responsabile.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Dimp"
         If Delega.DataImportazione = DateTime.MinValue Then
            param.Value = DBNull.Value
         Else
            param.Value = Delega.DataImportazione
         End If
         Cmd.Parameters.Add(param)


         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Delega.Id
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Delega." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overloads Function LoadAll(ByVal rs As ArrayList, ByVal Utente As Utente, Optional ByVal FindAllForDeletion As Boolean = False) As ArrayList
      Dim List As New ArrayList
      Try
         For Each elem As Hashtable In rs
            List.Add(Load(elem, Utente, FindAllForDeletion))
         Next
         Return List
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
   Protected Overloads Function Load(ByVal rs As Hashtable, ByVal Utente As Utente, Optional ByVal FindAllForDeletion As Boolean = False) As AbstractPersistenceObject
      Dim key As Key = CreateKey(rs)
      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
      Dim obj As AbstractPersistenceObject = DoLoad(key, rs, Utente, FindAllForDeletion)
      Cache.AddToCache(obj)
      Return obj
   End Function

   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Return DoLoad(Key, rs, Nothing)
   End Function
End Class
