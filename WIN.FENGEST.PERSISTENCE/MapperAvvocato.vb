Public Class MapperAvvocato
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_AVVOCATO"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_AVVOCATO where Id = @Id"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_AVVOCATO (ID, DESCRIZIONE, ID_TB_PROVINCIE, ID_TB_COMUNI, INDIRIZZO, CAP,  " _
      & "P_IVA, CreatedBy, CreatedOn, " _
      & " MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE) values (@Id, @Desc, @Pro, @Com, @Ind, @Cap, @IPI, " _
      & " @CRby, @CRon, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_AVVOCATO SET Descrizione = @Desc, ID_TB_PROVINCIE = @Pro, ID_TB_COMUNI = @Com, INDIRIZZO = @Ind, CAP = @Cap," _
      & "P_IVA = @IPI, ModifiedBy = @MOby, ModifiedOn = @MOon, " _
      & " Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, Responsabile = @Respo  WHERE (Id =@Id )"
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_AVVOCATO where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_AVVOCATO"
   End Function

#End Region


    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand
    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), Avvocato)


   End Function



   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Avvocato)


   End Function

#End Region

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         ' MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim avv As Avvocato = DirectCast(Item, Avvocato)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = avv.Descrizione
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Pro"
         If avv.IndirizzoSedeLegale.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If avv.IndirizzoSedeLegale.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If avv.IndirizzoSedeLegale.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cap"
         If avv.IndirizzoSedeLegale.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Cap
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@IPI"
         If avv.PartitaIva = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.PartitaIva
         End If
         Cmd.Parameters.Add(param)



         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)




         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If avv.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If avv.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If avv.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If avv.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If avv.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If avv.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Responsable
         End If
         Cmd.Parameters.Add(param)




      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try

         Dim avv As Avvocato = DirectCast(Item, Avvocato)

         Dim param As IDbDataParameter = Cmd.CreateParameter

         param.ParameterName = "@Desc"
         param.Value = avv.Descrizione
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Pro"
         If avv.IndirizzoSedeLegale.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If avv.IndirizzoSedeLegale.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If avv.IndirizzoSedeLegale.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cap"
         If avv.IndirizzoSedeLegale.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.IndirizzoSedeLegale.Cap
         End If

         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@IPI"
         If avv.PartitaIva = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.PartitaIva
         End If
         Cmd.Parameters.Add(param)



         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)



         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If avv.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If avv.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If avv.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If avv.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If avv.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If avv.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = avv.Responsable
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = avv.Id
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim Desc As String = IIf(rs.Item("DESCRIZIONE") IsNot Nothing, rs.Item("DESCRIZIONE"), "")



      Dim VIA As String = IIf(rs.Item("INDIRIZZO") IsNot Nothing, rs.Item("INDIRIZZO"), "")
      Dim CAP As String = IIf(rs.Item("CAP") IsNot Nothing, rs.Item("CAP"), "")
      Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
      Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

      Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_TB_PROVINCIE") IsNot Nothing, rs.Item("ID_TB_PROVINCIE"), -1)
      Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

      Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_TB_COMUNI") IsNot Nothing, rs.Item("ID_TB_COMUNI"), -1)
      Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))

      Dim PI As String = IIf(rs.Item("P_IVA") IsNot Nothing, rs.Item("P_IVA"), "")
      Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
      Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
      Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
      Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
      Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
      Dim RESPONSABLE As String = IIf(rs.Item("RESPONSABILE") IsNot Nothing, rs.Item("RESPONSABILE"), "")

      Dim avv As Avvocato = New Avvocato
      avv.Key = Key

      avv.Descrizione = Desc
      avv.IndirizzoSedeLegale.Comune = COMUNE
      avv.IndirizzoSedeLegale.Provincia = PROVINCIA
      avv.IndirizzoSedeLegale.Cap = CAP
      avv.IndirizzoSedeLegale.Via = VIA

      avv.PartitaIva = PI
      avv.Comunicazione = New Comunicazioni
      avv.Comunicazione.Cellulare1 = CELL1
      avv.Comunicazione.Cellulare2 = CELL2
      avv.Comunicazione.Fax = FAX
      avv.Responsable = RESPONSABLE
      avv.Comunicazione.TelefonoUfficio = TEL_UF
      avv.Comunicazione.Mail = MAIL


      JournalingDataLoader.ReadJournalingParameters(avv, rs)

      Return avv
   End Function
End Class








