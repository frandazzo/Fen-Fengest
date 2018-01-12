Public Class MapperReferente
   Inherits AbstractPersonMapper




#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_REFERENTE"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_REFERENTE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_REFERENTE (ID, NOME, COGNOME, DESCRIZIONE,ID_CONTO, " _
            & "COMPONENTE, PERC_RISTORNO_DEL, ID_PAGAMENTO_REFERENTE, " _
            & "PERC_RISTORNO_DEL_IF, PERC_RISTORNO_DEL_IN, PERC_RISTORNO_DEL_VE, " _
            & "CreatedBy, CreatedOn, Camera_Comunale, " _
            & "ID_TB_PROVINCIE, ID_TB_COMUNI, INDIRIZZO, CAP, " _
            & "MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE) values (@Id, @Nom, @Cog, @Desc, @Idc, " _
            & "@Com, @Prd, @Idpr, @If, @In, @Ve, @CRby, @CRon, " _
            & "@CamCom, @Pro, @Comu, @Ind, @Cap, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_REFERENTE SET Nome = @Nom, Cognome = @Cog, Descrizione = @Desc, " _
           & "ID_CONTO = @Idc, COMPONENTE = @Com, PERC_RISTORNO_DEL = @Prd, " _
           & "ID_PAGAMENTO_REFERENTE = @Idpr, " _
           & "PERC_RISTORNO_DEL_IF = @If, PERC_RISTORNO_DEL_IN = @In, " _
           & "PERC_RISTORNO_DEL_VE = @Ve, ModifiedBy = @MOby, ModifiedOn = @MOon,  " _
           & "Camera_Comunale = @CamCom, ID_TB_PROVINCIE = @Pro, ID_TB_COMUNI = @Comu, INDIRIZZO = @Ind, CAP = @Cap, " _
           & "Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, Responsabile = @Respo WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_REFERENTE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_REFERENTE"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Try
         Return DirectCast(MyBase.FindByKey(New Key(Id)), Referente)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try

   End Function


   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Referente
   End Function
   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)

      Dim referente As Referente = DirectCast(Item, Referente)
      Dim PercDel As Double = IIf(rs.Item("PERC_RISTORNO_DEL") IsNot Nothing, rs.Item("PERC_RISTORNO_DEL"), 0.0)
      Dim PercDelIf As Double = IIf(rs.Item("PERC_RISTORNO_DEL_IF") IsNot Nothing, rs.Item("PERC_RISTORNO_DEL_IF"), 0.0)
      Dim PercDelIn As Double = IIf(rs.Item("PERC_RISTORNO_DEL_IN") IsNot Nothing, rs.Item("PERC_RISTORNO_DEL_IN"), 0.0)
      Dim PercDelVe As Double = IIf(rs.Item("PERC_RISTORNO_DEL_VE") IsNot Nothing, rs.Item("PERC_RISTORNO_DEL_VE"), 0.0)



      Dim Con As String = IIf(rs.Item("ID_CONTO") IsNot Nothing, rs.Item("ID_CONTO"), -1)
      Dim IdPgr As Int32 = IIf(rs("ID_PAGAMENTO_REFERENTE") IsNot Nothing, rs("ID_PAGAMENTO_REFERENTE"), -1)

      Dim MapperConti As MapperConto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperConto")
      Dim MapperPagamentoReferenti As MapperPagamentoReferenti = PersistenceMapperRegistry.Instance.GetMapperByName("MapperPagamentoReferenti")

      Dim PagamentoReferenti As DocumentoContabile = IIf(IdPgr > -1, MapperPagamentoReferenti.FindObjectById(IdPgr), New DocumentoNullo)
      If PagamentoReferenti Is Nothing Then PagamentoReferenti = New DocumentoNullo



      Dim conto As IConto = MapperConti.FindObjectById(Con)
      Dim Com As String = IIf(rs.Item("COMPONENTE") IsNot Nothing, rs.Item("COMPONENTE"), False)
      Dim Cam As String = IIf(rs.Item("CAMERA_COMUNALE") IsNot Nothing, rs.Item("CAMERA_COMUNALE"), False)


      'Dim TEL As String = IIf(rs.Item("TEL") IsNot Nothing, rs.Item("TEL"), "")
      Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
      Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
      Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
      Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
      Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
      Dim RESPONSABLE As String = IIf(rs.Item("RESPONSABILE") IsNot Nothing, rs.Item("RESPONSABILE"), "")




      Dim VIA As String = IIf(rs.Item("INDIRIZZO") IsNot Nothing, rs.Item("INDIRIZZO"), "")
      Dim CAP As String = IIf(rs.Item("CAP") IsNot Nothing, rs.Item("CAP"), "")
      Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
      Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

      Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_TB_PROVINCIE") IsNot Nothing, rs.Item("ID_TB_PROVINCIE"), -1)
      Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

      Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_TB_COMUNI") IsNot Nothing, rs.Item("ID_TB_COMUNI"), -1)
      Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))



      referente.Conto = conto
      referente.ComponenteStruttura = Com
      referente.PercRistornoDeleghe = PercDel
      referente.PercRistornoDelegheImpFissi = PercDelIf
      referente.PercRistornoInps = PercDelIn
      referente.PercRistornoVertenze = PercDelVe
      referente.UltimoRistorno = PagamentoReferenti

      referente.IndirizzoSedeLegale = New Indirizzo
      referente.IndirizzoSedeLegale.Comune = COMUNE
      referente.IndirizzoSedeLegale.Provincia = PROVINCIA
      referente.IndirizzoSedeLegale.Cap = CAP
      referente.IndirizzoSedeLegale.Via = VIA

      referente.IsCameraComunale = Cam
      referente.ComunicazioneSedeLegale = New Comunicazioni
      referente.ComunicazioneSedeLegale.Cellulare1 = CELL1
      referente.ComunicazioneSedeLegale.Cellulare2 = CELL2
      referente.ComunicazioneSedeLegale.Fax = FAX
      referente.Responsable = RESPONSABLE
      referente.ComunicazioneSedeLegale.TelefonoUfficio = TEL_UF
      referente.ComunicazioneSedeLegale.Mail = MAIL

      Item = referente
      JournalingDataLoader.ReadJournalingParameters(Item, rs)
   End Sub


#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)
         Dim Referente As Referente = DirectCast(Item, Referente)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Idc"
         param.Value = Referente.Conto.IdConto
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         param.Value = Referente.ComponenteStruttura
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Prd"
         param.Value = Referente.PercRistornoDeleghe
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idpr"
         If TypeOf (Referente.UltimoRistorno) Is DocumentoNullo Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.UltimoRistorno.GetId
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@If"
         param.Value = Referente.PercRistornoDelegheImpFissi
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@In"
         param.Value = Referente.PercRistornoInps
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ve"
         param.Value = Referente.PercRistornoVertenze
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)


         '***************************************************
         '***************************************************

         param = Cmd.CreateParameter
         param.ParameterName = "@CamCom"
         param.Value = Referente.IsCameraComunale
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Pro"
         If Referente.IndirizzoSedeLegale.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Comu"
         If Referente.IndirizzoSedeLegale.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If Referente.IndirizzoSedeLegale.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cap"
         If Referente.IndirizzoSedeLegale.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Cap
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Referente.ComunicazioneSedeLegale.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Referente.ComunicazioneSedeLegale.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Referente.ComunicazioneSedeLegale.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Referente.ComunicazioneSedeLegale.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Referente.ComunicazioneSedeLegale.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If Referente.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.Responsable
         End If
         Cmd.Parameters.Add(param)




      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Referente." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Referente As Referente = DirectCast(Item, Referente)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Idc"
         param.Value = Referente.Conto.IdConto
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         param.Value = Referente.ComponenteStruttura
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Prd"
         param.Value = Referente.PercRistornoDeleghe
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idpr"
         If TypeOf (Referente.UltimoRistorno) Is DocumentoNullo Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.UltimoRistorno.GetId
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@If"
         param.Value = Referente.PercRistornoDelegheImpFissi
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@In"
         param.Value = Referente.PercRistornoInps
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ve"
         param.Value = Referente.PercRistornoVertenze
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


         param = Cmd.CreateParameter
         param.ParameterName = "@CamCom"
         param.Value = Referente.IsCameraComunale
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Pro"
         If Referente.IndirizzoSedeLegale.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Comu"
         If Referente.IndirizzoSedeLegale.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If Referente.IndirizzoSedeLegale.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cap"
         If Referente.IndirizzoSedeLegale.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.IndirizzoSedeLegale.Cap
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Referente.ComunicazioneSedeLegale.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Referente.ComunicazioneSedeLegale.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Referente.ComunicazioneSedeLegale.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Cellulare2
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Referente.ComunicazioneSedeLegale.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Referente.ComunicazioneSedeLegale.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.ComunicazioneSedeLegale.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Respo"
         If Referente.Responsable = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Referente.Responsable
         End If
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Referente." & vbCrLf & ex.Message)
      End Try
   End Sub



   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      'Try
      '   Dim Referente As New Referente(rs.Item("NOME"), rs.Item("COGNOME"))
      '   Referente.Key = Key
      '   Return Referente
      'Catch ex As Exception
      '   Throw New Exception("Impossibile caricare l'oggetto Referente con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      'End Try
      Throw New Exception("Not implemented method")
   End Function
End Class
