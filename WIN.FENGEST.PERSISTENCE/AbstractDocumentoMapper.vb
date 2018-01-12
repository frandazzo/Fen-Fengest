Public Class AbstractDocumentoMapper
   Inherits AbstractHierarchicalMapper





   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As Hashtable)
      Try
         Dim DataRegistrazione As DateTime = IIf(rs.Item("DATA_REGISTRAZIONE") IsNot Nothing, rs.Item("DATA_REGISTRAZIONE"), DateTime.MinValue)
         Dim DataDocumento As DateTime = IIf(rs.Item("DATA_DOCUMENTO") IsNot Nothing, rs.Item("DATA_DOCUMENTO"), DateTime.MinValue)
         Dim Note As String = IIf(rs.Item("NOTE_DOC") IsNot Nothing, rs.Item("NOTE_DOC"), "")

         Item.Key = Key
         Dim Documento As AbstractDocumento = DirectCast(Item, AbstractDocumento)
         Documento.DataRegistrazione = DataRegistrazione
         Documento.DataDocumento = DataDocumento
         Documento.Note = Note
         Item = Documento
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto documento astratto" & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function



   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Documento As AbstractDocumento = DirectCast(Item, AbstractDocumento)


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



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto documento astratto." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Documento As AbstractDocumento = DirectCast(Item, AbstractDocumento)


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



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Documento astratto." & vbCrLf & ex.Message)
      End Try
   End Sub






End Class

