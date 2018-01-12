Public Class MapperAzienda
   Inherits AbstractAziendaMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_AZIENDA"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_AZIENDA where Id = @Id"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_AZIENDA (ID, DESCRIZIONE, DATA_INIZIO_COMP, DATA_FINE_COMP, " _
      & "ID_CONTO, UNITA_COMP, ID_TB_PROVINCIE, ID_TB_COMUNI, INDIRIZZO, CAP,  " _
      & "TIPO_CALC, SCARTO,  ID_TIPO_CONTRATTO, P_IVA, CARTELLA_PREFERENZIALE, CreatedBy, CreatedOn, " _
      & " MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE, CODICE_CE, CODICE_EC, NOTES) values (@Id, @Desc, @Di, @Df, @Con, @Uni, @Pro, @Com, @Ind, @Cap, @Tip, @Sca, @IdT, @IPI, " _
      & " @Carp, @CRby, @CRon, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo, @CodCE, @CodEC, @Notes)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_AZIENDA SET Descrizione = @Desc, DATA_INIZIO_COMP = @Di, " _
      & "DATA_FINE_COMP = @Df, ID_CONTO = @Con,  UNITA_COMP = @Uni, ID_TB_PROVINCIE = @Pro, ID_TB_COMUNI = @Com, INDIRIZZO = @Ind, CAP = @Cap," _
      & "TIPO_CALC = @Tip, SCARTO = @Sca, ID_TIPO_CONTRATTO = @IdT, P_IVA = @IPI, CARTELLA_PREFERENZIALE = @Carp, ModifiedBy = @MOby, ModifiedOn = @MOon, " _
      & " Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, Responsabile = @Respo, CODICE_CE = @CodCE, CODICE_EC = @CodEC, NOTES= @Notes  WHERE (Id =@Id )"
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_AZIENDA where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_AZIENDA"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), Azienda)


   End Function



   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Azienda)


   End Function
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Azienda
   End Function
   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)

      Dim Tip As AbstractCalculator.TipoCalcolatore = IIf(rs.Item("TIPO_CALC") IsNot Nothing, rs.Item("TIPO_CALC"), 0)
      Dim Sca As Double = IIf(rs.Item("SCARTO") IsNot Nothing, rs.Item("SCARTO"), 0)
      Dim PI As String = IIf(rs.Item("P_IVA") IsNot Nothing, rs.Item("P_IVA"), "")

      Dim cartella As String = IIf(rs.Item("CARTELLA_PREFERENZIALE") IsNot Nothing, rs.Item("CARTELLA_PREFERENZIALE"), "")

      Dim ID_TIPO_CONTRATTO As Int32 = IIf(rs.Item("ID_TIPO_CONTRATTO") IsNot Nothing, rs.Item("ID_TIPO_CONTRATTO"), -1)
      Dim mapperContratti As MapperTipoContratto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoContratto")
      Dim Contratto As TipoContratto = mapperContratti.FindObjectById(ID_TIPO_CONTRATTO)
      If Contratto Is Nothing Then Contratto = New TipoContrattoNullo

      Dim mapperSegreteria As MapperSegreteria = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSegreteria")





      'Dim TEL As String = IIf(rs.Item("TEL") IsNot Nothing, rs.Item("TEL"), "")
      Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
      Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
      Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
      Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
      Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
      Dim RESPONSABLE As String = IIf(rs.Item("RESPONSABILE") IsNot Nothing, rs.Item("RESPONSABILE"), "")

      Dim CODICE_CE As String = IIf(rs.Item("CODICE_CE") IsNot Nothing, rs.Item("CODICE_CE"), "")
      Dim CODICE_EC As String = IIf(rs.Item("CODICE_EC") IsNot Nothing, rs.Item("CODICE_EC"), "")
      Dim NOTES As String = IIf(rs.Item("NOTES") IsNot Nothing, rs.Item("NOTES"), "")







      Dim azienda As Azienda = DirectCast(Item, Azienda)
      azienda.ContrattoApplicato = Contratto
      azienda.SetCongruityRules(Tip, Sca)
      azienda.PartitaIva = PI
      azienda.DirectoryPreferenziale = cartella
      azienda.Segreteria = MapperSegreteria.FindObjectById(1)


      azienda.Comunicazione = New Comunicazioni
      azienda.Comunicazione.Cellulare1 = CELL1
      azienda.Comunicazione.Cellulare2 = CELL2
      azienda.Comunicazione.Fax = FAX
      azienda.Responsable = RESPONSABLE
      azienda.Comunicazione.TelefonoUfficio = TEL_UF
      azienda.Comunicazione.Mail = MAIL

      azienda.Note = NOTES
      azienda.Codifica.CodificaCE = CODICE_CE
      azienda.Codifica.CodificaEC = CODICE_EC

      Dim virtualList As New LazyLoadSediOperative(azienda)
      azienda.SetSediOperative(virtualList)

      Dim documenti As VirtualLazyList = New LazyLoadArchivioDocumentale(azienda)
      azienda.ArchivioDocumenti.Documenti = documenti


      Item = azienda
      JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub
#End Region

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Azienda As Azienda = DirectCast(Item, Azienda)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = Azienda.CalcolatoreCongruita
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Sca"
         param.Value = Azienda.Scarto
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@IdT"
         If Azienda.ContrattoApplicato.Descrizione = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.ContrattoApplicato.Id
         End If
         Cmd.Parameters.Add(param)
         param = Cmd.CreateParameter
         param.ParameterName = "@IPI"
         If Azienda.PartitaIva = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.PartitaIva
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Carp"
         If Azienda.DirectoryPreferenziale = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.DirectoryPreferenziale
         End If
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)




         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Azienda.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Azienda.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Azienda.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Azienda.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Azienda.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If Azienda.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Responsable
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@CodCE"
         param.Value = Azienda.Codifica.CodificaCE
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CodEC"
         param.Value = Azienda.Codifica.CodificaEC
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Notes"
         param.Value = Azienda.Note
         Cmd.Parameters.Add(param)



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Azienda As Azienda = DirectCast(Item, Azienda)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = Azienda.CalcolatoreCongruita
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Sca"
         param.Value = Azienda.Scarto
         Cmd.Parameters.Add(param)





         param = Cmd.CreateParameter
         param.ParameterName = "@IdT"
         If Azienda.ContrattoApplicato.Descrizione = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.ContrattoApplicato.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IPI"
         If Azienda.PartitaIva = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.PartitaIva
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Carp"
         If Azienda.DirectoryPreferenziale = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.DirectoryPreferenziale
         End If
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)



         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Azienda.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Azienda.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Azienda.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Azienda.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Azienda.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If Azienda.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.Responsable
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@CodCE"
         param.Value = Azienda.Codifica.CodificaCE
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CodEC"
         param.Value = Azienda.Codifica.CodificaEC
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Notes"
         param.Value = Azienda.Note
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
End Class








