Public Class MapperVertenza
   Inherits AbstractDocumentoMapper

#Region "Istruzioni Sql"
   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_VERTENZA"
   End Function
   'Protected Overrides Function FindByKeyStatement() As String
   '   Return "SELECT DB_VERTENZA.*, DB_EVENTI.* " _
   '         & "FROM DB_VERTENZA LEFT JOIN DB_EVENTI ON DB_VERTENZA.ID = DB_EVENTI.ID_VERTENZA " _
   '         & "WHERE (DB_VERTENZA.ID = @Id)"
   'End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "SELECT * FROM DB_VERTENZA WHERE (ID = @Id)"
   End Function
   Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_VERTENZA (ID, DATA_REGISTRAZIONE, DATA_DOCUMENTO, " _
             & "NOTE_DOC, ID_UTENTE, ID_REFERENTE, ID_AZIENDA, DATA_INIZIO, DATA_FINE, ID_RUP, IMPORTO, VALUTA, ISTITUTI_CONTRATTUALI, CreatedBy, CreatedOn, ID_AVVOCATO, VertenzaChiusa) values (@Id,  " _
             & "@Drg, @Ddc, @Not, @Ut, @Ref, @Az, @Di, @Df, @Rup, @Imp, " _
             & "@Val, @Ist, @CRby, @CRon, @Avv, @vc)"
   End Function
   Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_VERTENZA SET DATA_REGISTRAZIONE = @Drg, " _
              & "DATA_DOCUMENTO = @Ddc, NOTE_DOC = @Not, " _
              & "ID_UTENTE = @Ut, ID_REFERENTE = @Ref, ID_AZIENDA = @Az, " _
              & "DATA_INIZIO = @Di, DATA_FINE = @Df, ID_RUP = @Rup, IMPORTO = @Imp, VALUTA = @Val, ISTITUTI_CONTRATTUALI = @Ist " _
              & " , ModifiedBy = @MOby, ModifiedOn = @MOon, ID_AVVOCATO = @Avv, VertenzaChiusa=@vc WHERE (Id =@Id) "
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_VERTENZA where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_VERTENZA"
   End Function
#End Region


   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Vertenza
   End Function

   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), Vertenza)

   End Function


   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Vertenza)

   End Function
   'Protected Overrides Function GetObjectFromStorage(ByVal Key As Key) As AbstractPersistenceObject
   '   Dim rs As IDataReader = Nothing
   '   Dim list As ArrayList
   '   Try
   '      'qui devo leggere l'oggetto in un datareader e caricarlo
   '      If DBConnectionManager.Instance.GetCurrentConnection.State = ConnectionState.Closed Then DBConnectionManager.Instance.GetCurrentConnection.Open()
   '      rs = GetDBRecordData(Key)
   '      list = Me.LoadDataMatrix(rs)
   '      rs.Close()
   '      If list.Count > 0 Then
   '         Dim obj As AbstractPersistenceObject = Me.CreateNewObject
   '         LoadObject(obj, list)
   '         Return obj
   '      End If
   '      Return Nothing
   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   Finally
   '      ReleaseDBDatareader(rs)
   '      list = New ArrayList
   '   End Try
   'End Function
   'Protected Overridable Overloads Function CreateKey(ByVal rs As Hashtable) As Key
   '   Try
   '      Dim id As Int32 = rs.Item("DB_VERTENZA.ID")
   '      Dim k As Key = New Key(id)
   '      Return k
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile creare una chiave dal record dei dati corrente." & vbCrLf & ex.Message)
   '   End Try
   'End Function
   'Protected Overloads Sub LoadObject(ByRef Item As AbstractPersistenceObject, ByVal rs As ArrayList)
   '   Try
   '      Dim key As Key = CreateKey(rs.Item(0))
   '      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then
   '         Item = Cache.GetObjectFromCache(key.ToString)
   '      Else
   '         BuildObject(Item, key, rs)
   '         Cache.AddToCache(Item)
   '      End If

   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   End Try
   'End Sub

   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)


        Dim Vertenza As Vertenza = DirectCast(Item, Vertenza)
        Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
        Dim ID_REFERENTE As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
        Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
        Dim ID_RUP As Int32 = IIf(rs("ID_RUP") IsNot Nothing, rs("ID_RUP"), -1)
        Dim DI As DateTime = IIf(rs("DATA_INIZIO") IsNot Nothing, rs("DATA_INIZIO"), DateTime.MinValue)
        Dim DF As DateTime = IIf(rs("DATA_FINE") IsNot Nothing, rs("DATA_FINE"), DateTime.MinValue)
        Dim IMP As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
        Dim VALUTA As Moneta.Valuta = IIf(rs("VALUTA") IsNot Nothing, rs("VALUTA"), Moneta.Valuta.Euro)
        Dim ISTITUTI_CONTRATTUALI As String = IIf(rs("ISTITUTI_CONTRATTUALI") IsNot Nothing, rs("ISTITUTI_CONTRATTUALI"), "")
        Dim ID_AVVOCATO As Int32 = IIf(rs("ID_AVVOCATO") IsNot Nothing, rs("ID_AVVOCATO"), -1)
        Dim VertenzaChiusa As Boolean = IIf(rs("VertenzaChiusa") IsNot Nothing, rs("VertenzaChiusa"), False)


        Dim MapperUtenti As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
        Dim utente As Utente = MapperUtenti.FindObjectById(ID_UTENTE)

        Dim MapperReferenti As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
        Dim Referente As Referente = MapperReferenti.FindObjectById(ID_REFERENTE)
        If Referente Is Nothing Then Referente = New ReferenteNullo

        Dim Rup As Referente = MapperReferenti.FindObjectById(ID_RUP)
        If Rup Is Nothing Then Rup = New ReferenteNullo

        Dim MapperAzienda As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")
        Dim Azienda As Azienda = MapperAzienda.FindObjectById(ID_AZIENDA)
        Dim mapperEventi As MapperEvento = PersistenceMapperRegistry.Instance.GetMapperByName("MapperEvento")

        Dim MapperAvv As MapperAvvocato = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAvvocato")
        Dim avvocato As Avvocato = MapperAvv.FindObjectById(ID_AVVOCATO)

        Dim periodo As DataRange = New DataRange(DI, DF)
        Dim quota As Moneta = New Moneta(IMP, VALUTA)

        Vertenza.Utente = utente
        Vertenza.Avvocato = avvocato
        Vertenza.Referente = Referente
        Vertenza.Rup = Rup
        Vertenza.Azienda = Azienda
        Vertenza.PeriodoVertenza = periodo
        Vertenza.Quota = quota
        Vertenza.SetListaIstituti(Deserialize(ISTITUTI_CONTRATTUALI))
        Vertenza.VertenzaChiusa = VertenzaChiusa
        Dim virtualList As New LazyLoadEventi(Vertenza)
        Vertenza.SetListaEventi(virtualList)


        Item = Vertenza
        JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Documento As Vertenza = DirectCast(Item, Vertenza)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Ut"
         param.Value = Documento.Utente.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ref"
         If Documento.Referente.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Documento.Referente.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Az"
         param.Value = Documento.Azienda.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Di"
         param.Value = Documento.PeriodoVertenza.Start
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Df"
         param.Value = Documento.PeriodoVertenza.Finish
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Rup"
         If Documento.Rup.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Documento.Rup.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Imp"
         param.Value = Documento.Quota.Importo
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Documento.Quota.GetValuta
         Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ist"
            param.Value = Serialize(Documento.ListaItituti)
            Cmd.Parameters.Add(param)

            JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

            param = Cmd.CreateParameter
            param.ParameterName = "@Avv"
            If Documento.Avvocato Is Nothing Then
                param.Value = DBNull.Value
            Else
                param.Value = Documento.Avvocato.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@vc"
            param.Value = Documento.VertenzaChiusa
            Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto vertenza." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Documento As Vertenza = DirectCast(Item, Vertenza)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Ut"
         param.Value = Documento.Utente.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ref"
         If Documento.Referente.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Documento.Referente.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Az"
         param.Value = Documento.Azienda.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Di"
         param.Value = Documento.PeriodoVertenza.Start
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Df"
         param.Value = Documento.PeriodoVertenza.Finish
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Rup"
         If Documento.Rup.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Documento.Rup.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Imp"
         param.Value = Documento.Quota.Importo
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Documento.Quota.GetValuta
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ist"
         param.Value = Serialize(Documento.ListaItituti)
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@Avv"
         If Documento.Avvocato Is Nothing Then
            param.Value = DBNull.Value
         Else
            param.Value = Documento.Avvocato.Id
         End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@vc"
            param.Value = Documento.VertenzaChiusa
            Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto vertenza." & vbCrLf & ex.Message)
      End Try
   End Sub
   Private Function Serialize(ByVal Elem As ArrayList) As String
      Try
         If Elem.Count = 0 Then Return ""
         Dim sf As New SoapFormatter()
         Dim ms As New System.IO.MemoryStream
         Try
            sf.Serialize(ms, Elem)
            ms.Seek(0, IO.SeekOrigin.Begin)
            Dim sR As New System.IO.StreamReader(ms)
            Dim s As String = sR.ReadToEnd
            Return s
         Catch ex As Exception
            Return ""
         Finally
            ms.Close()
         End Try
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function




   Private Function Deserialize(ByVal Elem As String) As ArrayList
      Try
         Dim list As ArrayList = New ArrayList
         If Elem = "" Then Return list
         Dim sf As New SoapFormatter()
         Dim ms As New System.IO.MemoryStream
         Dim sW As New System.IO.StreamWriter(ms)
         sW.Write(Elem)
         sW.Write(Elem)
         ms.Seek(0, IO.SeekOrigin.Begin)
         Try
            list = CType(sf.Deserialize(ms), ArrayList)
         Catch ex As Exception
            Return New ArrayList
         Finally
            ms.Close()
         End Try
         Return list
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
End Class
