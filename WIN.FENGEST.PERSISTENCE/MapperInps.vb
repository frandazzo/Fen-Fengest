Public Class MapperInps
   Inherits AbstractAziendaMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_INPS"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_INPS where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_INPS (ID, DESCRIZIONE, DATA_INIZIO_COMP, DATA_FINE_COMP, ID_CONTO, UNITA_COMP, CreatedBy, CreatedOn, MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE) values (@Id, @Desc, @Di, @Df, @Con, @Uni, @CRby, @CRon, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_INPS SET Descrizione = @Desc, DATA_INIZIO_COMP = @Di, DATA_FINE_COMP = @Df, ID_CONTO = @Con, UNITA_COMP = @Uni, ModifiedBy = @MOby, ModifiedOn = @MOon, Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, Responsabile = @Respo   WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_INPS where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_INPS"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Inps)


   End Function
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Inps
   End Function
   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)
      JournalingDataLoader.ReadJournalingParameters(Item, rs)


      'Dim TEL As String = IIf(rs.Item("TEL") IsNot Nothing, rs.Item("TEL"), "")
      Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
      Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
      Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
      Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
      Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
      Dim RESPONSABLE As String = IIf(rs.Item("RESPONSABILE") IsNot Nothing, rs.Item("RESPONSABILE"), "")

      Dim ente As Inps = DirectCast(Item, Inps)

      ente.Comunicazione = New Comunicazioni
      ente.Comunicazione.Cellulare1 = CELL1
      ente.Comunicazione.Cellulare2 = CELL2
      ente.Comunicazione.Fax = FAX
      ente.Responsable = RESPONSABLE
      ente.Comunicazione.TelefonoUfficio = TEL_UF
      ente.Comunicazione.Mail = MAIL



   End Sub
#End Region

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)


         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)


         Dim ente As Inps = DirectCast(Item, Inps)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If ente.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If ente.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If ente.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If ente.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If ente.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If ente.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Responsable
         End If
         Cmd.Parameters.Add(param)





      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

         Dim ente As Inps = DirectCast(Item, Inps)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If ente.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If ente.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If ente.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If ente.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If ente.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If ente.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = ente.Responsable
         End If
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
End Class
