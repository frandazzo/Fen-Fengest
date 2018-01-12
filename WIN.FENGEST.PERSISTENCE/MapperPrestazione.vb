Public Class MapperPrestazione
   Inherits AbstractDocumentoMapper

#Region "Istruzioni Sql"
   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_PRESTAZIONE"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_PRESTAZIONE where Id = @Id"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_PRESTAZIONE (ID, DATA_REGISTRAZIONE, DATA_DOCUMENTO, " _
           & "NOTE_DOC, ID_UTENTE, ID_REFERENTE, FILE_OUTPUT, " _
           & "ID_TIPO_PRESTAZIONE, CreatedBy, CreatedOn) values (@Id, @Drg, @Ddc, @Not, @Ut, @Ref, @Fio, @Tip, @CRby, @CRon)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_PRESTAZIONE SET DATA_REGISTRAZIONE = @Drg, " _
            & "DATA_DOCUMENTO = @Ddc, NOTE_DOC = @Not, " _
            & "ID_UTENTE = @Ut, ID_REFERENTE = @Ref, FILE_OUTPUT = @Fio, " _
            & "ID_TIPO_PRESTAZIONE = @Tip, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id =@Id) "
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_PRESTAZIONE where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_PRESTAZIONE"
   End Function
#End Region


   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Prestazione
   End Function

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Try
         Return DirectCast(MyBase.FindByKey(New Key(Id)), Prestazione)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function

   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
        MyBase.BuildObject(Item, Key, rs)


        Dim DataRegistrazione As DateTime = IIf(rs.Item("DATA_REGISTRAZIONE") IsNot Nothing, rs.Item("DATA_REGISTRAZIONE"), DateTime.MinValue)
        Dim DataDocumento As DateTime = IIf(rs.Item("DATA_DOCUMENTO") IsNot Nothing, rs.Item("DATA_DOCUMENTO"), DateTime.MinValue)
        Dim Note As String = IIf(rs.Item("NOTE_DOC") IsNot Nothing, rs.Item("NOTE_DOC"), "")

        Item.Key = Key
        Dim Prestazione As Prestazione = DirectCast(Item, Prestazione)
        Prestazione.DataRegistrazione = DataRegistrazione
        Prestazione.DataDocumento = DataDocumento
        Prestazione.Note = Note


        Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
        Dim ID_REFERENTE As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
        Dim ID_TIPO_PRESTAZIONE As Int32 = IIf(rs("ID_TIPO_PRESTAZIONE") IsNot Nothing, rs("ID_TIPO_PRESTAZIONE"), -1)
        Dim FILE_OUTPUT As String = IIf(rs("FILE_OUTPUT") IsNot Nothing, rs("FILE_OUTPUT"), "")


        Dim MapperTipoPrestazione As MapperTipoPrestazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoPrestazione")
        Dim TipoPrestazione As TipoPrestazione = MapperTipoPrestazione.FindObjectById(ID_TIPO_PRESTAZIONE)

        Dim MapperUtenti As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
        Dim utente As Utente = MapperUtenti.FindObjectById(ID_UTENTE)

        Dim MapperReferenti As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
        Dim Referente As Referente = MapperReferenti.FindObjectById(ID_REFERENTE)
        If Referente Is Nothing Then Referente = New ReferenteNullo

        Prestazione.Utente = utente
        Prestazione.Referente = Referente
        Prestazione.TipoPrestazione = TipoPrestazione
        Prestazione.SetFileOutput(FILE_OUTPUT)

        Item = Prestazione
        JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
            'MyBase.LoadInsertCommandParameters(Item, Cmd)
            Dim Documento As Prestazione = DirectCast(Item, Prestazione)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Drg"
            param.Value = Documento.DataRegistrazione.Date
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ddc"
            param.Value = Documento.DataDocumento.Date
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Not"
            param.Value = Documento.Note
            Cmd.Parameters.Add(param)




            param = Cmd.CreateParameter
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
            param.ParameterName = "@Fio"
            param.Value = Documento.FileOutPut
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Tip"
            param.Value = Documento.TipoPrestazione.Id
            Cmd.Parameters.Add(param)

            JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto prestazione." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
            'MyBase.LoadInsertCommandParameters(Item, Cmd)

            Dim Documento As Prestazione = DirectCast(Item, Prestazione)
            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Drg"
            param.Value = Documento.DataRegistrazione.Date
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ddc"
            param.Value = Documento.DataDocumento.Date
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Not"
            param.Value = Documento.Note
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
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
            param.ParameterName = "@Fio"
            param.Value = Documento.FileOutPut
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Tip"
            param.Value = Documento.TipoPrestazione.Id
            Cmd.Parameters.Add(param)

            JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto prestazione." & vbCrLf & ex.Message)
      End Try
   End Sub
End Class
