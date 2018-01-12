Public Class MapperEnteBilaterale
   Inherits AbstractAziendaMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_ENTE_BILATERALE"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_ENTE_BILATERALE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      'Return "Insert into DB_ENTE_BILATERALE (ID, DESCRIZIONE, DATA_INIZIO_COMP, DATA_FINE_COMP, ID_CONTO, UNITA_COMP, ID_TB_PROVINCIE, ID_TB_COMUNI, INDIRIZZO, CAP, TIPO_ENTE, CreatedBy, CreatedOn, MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE) values (@Id, @Desc, @Di, @Df, @Con, @Uni, @Pro, @Com, @Ind, @Cap,  @Tip, @CRby, @CRon, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo)"
      Return "Insert into DB_ENTE_BILATERALE (ID, DESCRIZIONE, DATA_INIZIO_COMP, DATA_FINE_COMP, ID_CONTO, UNITA_COMP, TIPO_ENTE, CreatedBy, CreatedOn, MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE) values (@Id, @Desc, @Di, @Df, @Con, @Uni, @Tip, @CRby, @CRon, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_ENTE_BILATERALE SET Descrizione = @Desc, DATA_INIZIO_COMP = @Di, DATA_FINE_COMP = @Df, ID_CONTO = @Con,  UNITA_COMP = @Uni,  TIPO_ENTE = @Tip, ModifiedBy = @MOby, ModifiedOn = @MOon, Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, Responsabile = @Respo  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_ENTE_BILATERALE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_ENTE_BILATERALE"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), EnteBilaterale)


   End Function
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New EnteBilaterale
   End Function
   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)

      'Dim TEL As String = IIf(rs.Item("TEL") IsNot Nothing, rs.Item("TEL"), "")
      Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
      Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
      Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
      Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
      Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
      Dim RESPONSABLE As String = IIf(rs.Item("RESPONSABILE") IsNot Nothing, rs.Item("RESPONSABILE"), "")


      Dim Tip As EnteBilaterale.TipoEnteBilaterale = IIf(rs.Item("TIPO_ENTE") IsNot Nothing, rs.Item("TIPO_ENTE"), 0)
      Dim Ente As EnteBilaterale = DirectCast(Item, EnteBilaterale)
      Ente.TipoEnte = Tip


      Ente.Comunicazione = New Comunicazioni
      Ente.Comunicazione.Cellulare1 = CELL1
      Ente.Comunicazione.Cellulare2 = CELL2
      Ente.Comunicazione.Fax = FAX
      Ente.Responsable = RESPONSABLE
      Ente.Comunicazione.TelefonoUfficio = TEL_UF
      Ente.Comunicazione.Mail = MAIL


      Item = Ente





      JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub
#End Region

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Ente As EnteBilaterale = DirectCast(Item, EnteBilaterale)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = Ente.TipoEnte
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Ente.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Ente.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Ente.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Ente.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Ente.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If Ente.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Responsable
         End If
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Ente As EnteBilaterale = DirectCast(Item, EnteBilaterale)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = Ente.TipoEnte
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Ente.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Ente.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Ente.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Ente.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Ente.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If Ente.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Ente.Responsable
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
