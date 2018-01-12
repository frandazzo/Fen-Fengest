Public Class MapperPagamentoReferenti
   Inherits AbstractDocumentoContabileMapper
   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub

#Region "Istruzioni Sql"
   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_DOCUMENTO_CONTABILE"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_DOCUMENTO_CONTABILE where Id = @Id and TIPO_DOCUMENTO = 'PGR'"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_DOCUMENTO_CONTABILE (ID, DATA_REGISTRAZIONE, DATA_DOCUMENTO, " _
            & "NOTE_DOC, TIPO_DOCUMENTO, IMPORTO, VALUTA, ID_REFERENTE, CreatedBy, CreatedOn) " _
            & "values (@Id, @Drg, @Ddc, @Not, @Tdc, @Imp, @Val, @Idr, @CRby, @CRon)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_DOCUMENTO_CONTABILE SET DATA_REGISTRAZIONE = @Drg, " _
            & "DATA_DOCUMENTO = @Ddc, NOTE_DOC = @Not, TIPO_DOCUMENTO = @Tdc, " _
            & "IMPORTO = @Imp, " _
            & "VALUTA = @Val, ID_REFERENTE = @Idr, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id =@Id) "
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_DOCUMENTO_CONTABILE where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_DOCUMENTO_CONTABILE"
   End Function
#End Region


   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New PagamentoReferenti
   End Function
   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), PagamentoReferenti)

   End Function
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), PagamentoReferenti)

   End Function

   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)

      Dim Pagamento As PagamentoReferenti = DirectCast(Item, PagamentoReferenti)

      Dim Imp As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
      Dim valuta As Moneta.Valuta = IIf(rs("VALUTA") IsNot Nothing, rs("VALUTA"), Moneta.Valuta.Euro)
      Dim IdRef As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
      'Dim MapperReferente As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
      'Dim Ref As Referente = MapperReferente.FindObjectById(IdRef)

      'Pagamento.Referente = Ref
      Pagamento.Valuta = valuta
      Pagamento.Importo = New Moneta(Imp, valuta)
      Pagamento.SetPosted()
      'devo aggiungere la lista delle posizioni e impostare il documento come registrato.
      Dim list As VirtualLazyList = New LazyLoadPosizioniPagamentoReferenti(Pagamento)
      Pagamento.SetItems(list)
      'Devo adesso aggiungere al pagamento anche la lista virtuale delle
      'Posizioni ristornate
      Dim list1 As VirtualLazyList = New LazyLoadPosizioniRistornate(Pagamento)
      Pagamento.SetItemsRistornate(list1)

      'devo aggiungere un lazyload anche per il referente
      'al fine di evitare un overflow in caso di caricamento
      Pagamento.Referente = New LazyLoadReferente(IdRef)
      Item = Pagamento

      JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Documento As PagamentoReferenti = DirectCast(Item, PagamentoReferenti)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Tdc"
         param.Value = Documento.TipoDocumento
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Imp"
         param.Value = Documento.Importo.Importo
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Documento.Importo.GetValuta
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idr"
         param.Value = Documento.Referente.IdReferente
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Referente." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Documento As PagamentoReferenti = DirectCast(Item, PagamentoReferenti)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Tdc"
         param.Value = Documento.TipoDocumento
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Imp"
         param.Value = Documento.Importo.Importo
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Documento.Importo.GetValuta
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idr"
         param.Value = Documento.Referente.IdReferente
         Cmd.Parameters.Add(param)


         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Referente." & vbCrLf & ex.Message)
      End Try
   End Sub

End Class
