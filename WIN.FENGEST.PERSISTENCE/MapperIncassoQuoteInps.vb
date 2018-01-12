Public Class MapperIncassoQuotaInps
   Inherits AbstractDocumentoContabileMapper
   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub

#Region "Istruzioni Sql"
   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_DOCUMENTO_CONTABILE"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_DOCUMENTO_CONTABILE where Id = @Id and TIPO_DOCUMENTO = 'IQI'"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_DOCUMENTO_CONTABILE (ID, DATA_REGISTRAZIONE, DATA_DOCUMENTO, NOTE_DOC, TIPO_DOCUMENTO, DATA_INIZIO_COMP, DATA_FINE_COMP, IMPORTO, VALUTA, CreatedBy, CreatedOn) values (@Id, @Drg, @Ddc, @Not, @Tdc, @Di, @Df, @Imp, @Val, @CRby, @CRon)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_DOCUMENTO_CONTABILE SET DATA_REGISTRAZIONE = @Drg, " _
            & "DATA_DOCUMENTO = @Ddc, NOTE_DOC = @Not, TIPO_DOCUMENTO = @Tdc, " _
            & "DATA_INIZIO_COMP = @Di, DATA_FINE_COMP = @Df, IMPORTO = @Imp, " _
            & "VALUTA = @Val, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id =@Id) "
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_DOCUMENTO_CONTABILE where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_DOCUMENTO_CONTABILE"
   End Function
#End Region


   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New IncassoQuotaInps
   End Function
   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), IncassoQuotaInps)

   End Function
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), IncassoQuotaInps)

   End Function

   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)

      Dim incasso As IncassoQuotaInps = DirectCast(Item, IncassoQuotaInps)

      Dim Di As DateTime = IIf(rs("DATA_INIZIO_COMP") IsNot Nothing, rs("DATA_INIZIO_COMP"), DateTime.MinValue)
      Dim Df As DateTime = IIf(rs("DATA_FINE_COMP") IsNot Nothing, rs("DATA_FINE_COMP"), DateTime.MinValue)
      Dim Imp As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
      Dim valuta As Moneta.Valuta = IIf(rs("VALUTA") IsNot Nothing, rs("VALUTA"), Moneta.Valuta.Euro)

      Dim mapperInps As MapperInps = PersistenceMapperRegistry.Instance.GetMapperByName("MapperInps")
      Dim inps As Inps = mapperInps.FindObjectById(1)
      Dim competenza As AbstractPeriodo
      If Di = DateTime.MinValue Or Df = DateTime.MinValue Then
         competenza = New PeriodoNullo
      Else
         competenza = New CompositePeriodo(New DataRange(Di, Df), IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera)
      End If
      incasso.SetPosted()
      incasso.Competenza = competenza
      incasso.SetSoggettoEsecutore(inps)
      incasso.SetValuta(valuta)
      incasso.SetImporto(New Moneta(Imp, valuta))

      'devo aggiungere la lista delle posizioni e impostare il pagamento come registrato.
      Dim list As VirtualLazyList = New LazyLoadPosizioniPagamento(incasso)
      incasso.SetItems(list)
      Item = incasso

      JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Documento As IncassoQuotaInps = DirectCast(Item, IncassoQuotaInps)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Tdc"
         param.Value = Documento.TipoDocumento
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Di"
         If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
            param.Value = Documento.Competenza.GetDataRange.Start
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Df"
         If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
            param.Value = Documento.Competenza.GetDataRange.Finish
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Imp"
         param.Value = Documento.Importo.Importo
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Documento.Importo.GetValuta
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Documento As IncassoQuotaInps = DirectCast(Item, IncassoQuotaInps)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Tdc"
         param.Value = Documento.TipoDocumento
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Di"
         If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
            param.Value = Documento.Competenza.GetDataRange.Start
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Df"
         If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
            param.Value = Documento.Competenza.GetDataRange.Finish
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Imp"
         param.Value = Documento.Importo.Importo
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Documento.Importo.GetValuta
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto." & vbCrLf & ex.Message)
      End Try
   End Sub

End Class
