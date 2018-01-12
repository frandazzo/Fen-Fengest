Public Class MapperIncassoQuotaVertenza
   Inherits AbstractDocumentoContabileMapper

   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub
#Region "Istruzioni Sql"
   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_DOCUMENTO_CONTABILE"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_DOCUMENTO_CONTABILE where Id = @Id and TIPO_DOCUMENTO = 'IQV'"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_DOCUMENTO_CONTABILE (ID, DATA_REGISTRAZIONE, DATA_DOCUMENTO, NOTE_DOC, TIPO_DOCUMENTO, ID_UTENTE, CreatedBy, CreatedOn) values (@Id, @Drg, @Ddc, @Not, @Tdc, @Idu, @CRby, @CRon)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_DOCUMENTO_CONTABILE SET DATA_REGISTRAZIONE = @Drg, " _
            & "DATA_DOCUMENTO = @Ddc, NOTE_DOC = @Not, TIPO_DOCUMENTO = @Tdc, ID_UTENTE = @Idu, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id =@Id) "
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_DOCUMENTO_CONTABILE where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_DOCUMENTO_CONTABILE"
   End Function
#End Region


   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New IncassoQuotaVertenza
   End Function
   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), IncassoQuotaVertenza)

   End Function
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), IncassoQuotaVertenza)

   End Function

   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)

      Dim incasso As IncassoQuotaVertenza = DirectCast(Item, IncassoQuotaVertenza)

      Dim ID_UTENTE As Int32 = IIf(Not rs("ID_UTENTE") Is Nothing, rs("ID_UTENTE"), -1)
      Dim mapper As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
      Dim utente = mapper.FindObjectById(ID_UTENTE)
      If utente Is Nothing Then utente = New UtenteNonSpecificato
      incasso.SetUtente(utente)
      incasso.SetPosted()
      'devo aggiungere la lista delle posizioni e impostare il pagamento come registrato.
      Dim list As VirtualLazyList = New LazyLoadPosizioniQuoteVertenza(incasso)
      incasso.SetItems(list)
      Item = incasso
      JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Documento As IncassoQuotaVertenza = DirectCast(Item, IncassoQuotaVertenza)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Tdc"
         param.Value = Documento.TipoDocumento
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idu"
         param.Value = Documento.Utente.Id
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)




      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Documento As IncassoQuotaVertenza = DirectCast(Item, IncassoQuotaVertenza)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Tdc"
         param.Value = Documento.TipoDocumento
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idu"
         param.Value = Documento.Utente.Id
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto." & vbCrLf & ex.Message)
      End Try
   End Sub
End Class
