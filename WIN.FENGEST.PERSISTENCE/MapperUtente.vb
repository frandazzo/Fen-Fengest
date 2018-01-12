Public Class MapperUtente
   Inherits AbstractPersonMapper




#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_UTENTE"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_UTENTE where Id = @Id"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_UTENTE (ID, NOME, COGNOME, DESCRIZIONE, IMPORTO_QUOTA, " _
      & "VALUTA, ID_CONTO, SESSO, DATA_NASCITA, ID_TB_NAZIONI, " _
        & "ID_TB_PROVINCIE_NASCITA, ID_TB_COMUNI_NASCITA,  ID_TB_PROVINCIE_RESIDENZA, ID_TB_COMUNI_RESIDENZA, " _
        & "MAIL, CELL1, CELL2, CODICE_FISCALE, INDIRIZZO, TEL, CAP, FAX, TEL_UF, CARTELLA_PREFERENZIALE, CreatedBy, CreatedOn, DATA_INTERVISTA,CONIUGE_A_CARICO, CASA_PROPRIETA, STATO_CIVILE, ID_FONDO, ID_REFERENTE, PATH_FOTO, CODICE_CE, CODICE_EC, NOTES, NOME_CONIUGE, COGNOME_CONIUGE, CF_CONIUGE ) values (@Id, @Nom, @Cog, @Desc, @Iqu, @Val, " _
        & "@Con, @Ses, @Dat, @Naz, @RegN, @ComN, @Reg, @Com,  @Mai, @Ce1, @Ce2, @Cf, @Ind, @Tel, @Cap, @Fax, @Tuf, @Carp, @CRby, @CRon, @DatInt, @ConAC, @CasP, @StCiv, @IdFon, @IdRef, @PFot, @CodCE, @CodEC, @Notes, @NomCon, @CogCon, @CFCon)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_UTENTE SET Nome = @Nom, Cognome = @Cog, Descrizione = @Desc, " _
      & "Importo_Quota = @Iqu, Valuta = @Val, ID_CONTO = @Con, Sesso= @Ses, Data_Nascita = @Dat, ID_TB_NAZIONI = @Naz, " _
         & "ID_TB_PROVINCIE_NASCITA = @RegN, ID_TB_COMUNI_NASCITA = @ComN, ID_TB_PROVINCIE_RESIDENZA = @Reg, ID_TB_COMUNI_RESIDENZA = @Com, Mail = @Mai, Cell1 = @Ce1, " _
         & " Cell2 = @Ce2, CODICE_FISCALE = @Cf, INDIRIZZO= @Ind, TEL = @Tel, CAP= @Cap, FAX= @Fax, TEL_UF = @Tuf, CARTELLA_PREFERENZIALE = @Carp, ModifiedBy = @MOby, ModifiedOn = @MOon,  " _
      & " DATA_INTERVISTA = @DatInt, CONIUGE_A_CARICO = @ConAC, CASA_PROPRIETA = @CasP, STATO_CIVILE = @StCiv, ID_FONDO = @IdFon, ID_REFERENTE = @IdRef, PATH_FOTO= @PFot, CODICE_CE=@CodCE, CODICE_EC=@CodEC, NOTES=@Notes, NOME_CONIUGE= @NomCon, COGNOME_CONIUGE = @CogCon, CF_CONIUGE= @CFCon WHERE (Id = @Id )"
   End Function
   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_UTENTE where Id = @Id"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_UTENTE"
   End Function

#End Region



#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), Utente)


   End Function


   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Utente)


   End Function
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Utente
   End Function
   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
      MyBase.BuildObject(Item, Key, rs)


      Dim Importo As Double = IIf(rs.Item("IMPORTO_QUOTA") IsNot Nothing, rs.Item("IMPORTO_QUOTA"), 0.0)
      Dim Valuta As Moneta.Valuta = IIf(rs.Item("VALUTA") IsNot Nothing, rs.Item("VALUTA"), Moneta.Valuta.Euro)
      Dim Con As String = IIf(rs.Item("ID_CONTO") IsNot Nothing, rs.Item("ID_CONTO"), -1)
      Dim MapperConti As MapperConto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperConto")
      Dim conto As IConto = MapperConti.FindObjectById(Con)


      Dim MapperNazione As MapperNazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperNazione")
      Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
      Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

      Dim mapperSegreteria As MapperSegreteria = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSegreteria")




      Dim ID_NAZIONE As Int32 = IIf(rs.Item("ID_TB_NAZIONI") IsNot Nothing, rs.Item("ID_TB_NAZIONI"), -1)
      Dim NAZIONE As Nazione = IIf(ID_NAZIONE = -1, New NazioneNulla, MapperNazione.FindObjectById(ID_NAZIONE))

      Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_TB_PROVINCIE_NASCITA") IsNot Nothing, rs.Item("ID_TB_PROVINCIE_NASCITA"), -1)
      Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

      Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_TB_COMUNI_NASCITA") IsNot Nothing, rs.Item("ID_TB_COMUNI_NASCITA"), -1)
      Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))

      Dim CARTELLA As String = IIf(rs.Item("CARTELLA_PREFERENZIALE") IsNot Nothing, rs.Item("CARTELLA_PREFERENZIALE"), "")
      Dim ID_PROVINCIA_R As Int32 = IIf(rs.Item("ID_TB_PROVINCIE_RESIDENZA") IsNot Nothing, rs.Item("ID_TB_PROVINCIE_RESIDENZA"), -1)
      Dim PROVINCIA_R As Provincia = IIf(ID_PROVINCIA_R = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA_R))

      Dim ID_COMUNE_R As Int32 = IIf(rs.Item("ID_TB_COMUNI_RESIDENZA") IsNot Nothing, rs.Item("ID_TB_COMUNI_RESIDENZA"), -1)
      Dim COMUNE_R As Comune = IIf(ID_COMUNE_R = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE_R))

      Dim DATA_N As Date = IIf(rs.Item("DATA_NASCITA") IsNot Nothing, rs.Item("DATA_NASCITA"), New DateTime(1800, 1, 1))
      Dim SESSO As Int32 = IIf(rs.Item("SESSO") IsNot Nothing, rs.Item("SESSO"), 0)
      Dim CF As String = IIf(rs.Item("CODICE_FISCALE") IsNot Nothing, rs.Item("CODICE_FISCALE"), "")
      Dim VIA As String = IIf(rs.Item("INDIRIZZO") IsNot Nothing, rs.Item("INDIRIZZO"), "")
      Dim CAP As String = IIf(rs.Item("CAP") IsNot Nothing, rs.Item("CAP"), "")
      Dim TEL As String = IIf(rs.Item("TEL") IsNot Nothing, rs.Item("TEL"), "")
      Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
      Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
      Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
      Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
      Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
      Dim PATH_FOTO As String = IIf(rs.Item("PATH_FOTO") IsNot Nothing, rs.Item("PATH_FOTO"), "")


      Dim ID_FONDO As Int32 = IIf(rs.Item("ID_FONDO") IsNot Nothing, rs.Item("ID_FONDO"), -1)
      Dim MapperFondo As MapperFondo = PersistenceMapperRegistry.Instance.GetMapperByName("MapperFondo")
      Dim fondo As Fondo = MapperFondo.FindObjectById(ID_FONDO)





      Dim ID_REFERENTE As Int32 = IIf(rs.Item("ID_REFERENTE") IsNot Nothing, rs.Item("ID_REFERENTE"), -1)
      Dim MapperReferente As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
      Dim Referente As Referente = MapperReferente.FindObjectById(ID_REFERENTE)


      Dim DATA_INTERVISTA As Date = IIf(rs.Item("DATA_INTERVISTA") IsNot Nothing, rs.Item("DATA_INTERVISTA"), New DateTime(1800, 1, 1))
      Dim STATO_CIVILE As String = IIf(rs.Item("STATO_CIVILE") IsNot Nothing, rs.Item("STATO_CIVILE"), "")

      Dim CASA_PROPRIETA As Boolean = IIf(rs.Item("CASA_PROPRIETA") IsNot Nothing, rs.Item("CASA_PROPRIETA"), False)
      Dim CONIUGE_A_CARICO As Boolean = IIf(rs.Item("CONIUGE_A_CARICO") IsNot Nothing, rs.Item("CONIUGE_A_CARICO"), False)


      Dim CODICE_CE As String = IIf(rs.Item("CODICE_CE") IsNot Nothing, rs.Item("CODICE_CE"), "")
      Dim CODICE_EC As String = IIf(rs.Item("CODICE_EC") IsNot Nothing, rs.Item("CODICE_EC"), "")
      Dim NOTES As String = IIf(rs.Item("NOTES") IsNot Nothing, rs.Item("NOTES"), "")
      Dim NOME_CONIUGE As String = IIf(rs.Item("NOME_CONIUGE") IsNot Nothing, rs.Item("NOME_CONIUGE"), "")
      Dim COGNOME_CONIUGE As String = IIf(rs.Item("COGNOME_CONIUGE") IsNot Nothing, rs.Item("COGNOME_CONIUGE"), "")
      Dim CF_CONIUGE As String = IIf(rs.Item("CF_CONIUGE") IsNot Nothing, rs.Item("CF_CONIUGE"), "")





      Dim utente As Utente = DirectCast(Item, Utente)
      utente.QuotaMensile = New Moneta(Importo, Valuta)
      utente.Conto = conto
      Dim list As VirtualLazyList = New LazyLoadDeleghe(utente)
      utente.SetDeleghe(list)

      Dim figli As VirtualLazyList = New LazyLoadFigli(utente)
      utente.SituazioneFamiliare.Figli = figli

      Dim tessere As VirtualLazyList = New LazyLoadTessere(utente)
      utente.Tessere = tessere


      Dim attitudini As VirtualLazyList = New LazyLoadAttitudini(utente)
      utente.Attitudini = attitudini

      Dim preferenze As VirtualLazyList = New LazyLoadPreferenze(utente)
      utente.Preferenze = preferenze

      Dim infos As VirtualLazyList = New LazyLoadInfos(utente)
        utente.Infos = infos

        Dim incarichi As VirtualLazyList = New LazyLoadIncarichi(utente)
        utente.Incarichi = incarichi

      Dim documenti As VirtualLazyList = New LazyLoadArchivioDocumentale(utente)
      utente.ArchivioDocumenti.Documenti = documenti

      utente.Segreteria = mapperSegreteria.FindObjectById(1)
      utente.Nazionalita = NAZIONE
      utente.ProvinciaNascita = PROVINCIA
      utente.ComuneNascita = COMUNE
      utente.Residenza.Comune = COMUNE_R
      utente.Residenza.Provincia = PROVINCIA_R
      utente.DataNascita = DATA_N
      utente.Sesso = SESSO
      utente.CodiceFiscale = CF
      utente.Residenza.Via = VIA
      utente.DirectoryPreferenziale = CARTELLA
      utente.Comunicazione.TelefonoUfficio = TEL_UF
      utente.Comunicazione.TelefonoCasa = TEL
      utente.Comunicazione.Mail = MAIL
      utente.Comunicazione.Cellulare2 = CELL2
      utente.Comunicazione.Cellulare1 = CELL1
      utente.Comunicazione.Fax = FAX
      utente.Residenza.Cap = CAP
      utente.Path_Foto = PATH_FOTO
      utente.Fondo = fondo
      utente.SituazioneFamiliare.ConiugeACarico = CONIUGE_A_CARICO
      utente.SituazioneFamiliare.CasaProprieta = CASA_PROPRIETA
      utente.SituazioneFamiliare.DataIntervista = DATA_INTERVISTA
      If Not Referente Is Nothing Then
         utente.SituazioneFamiliare.Referente = Referente
      End If

      utente.SituazioneFamiliare.StatoCivile = STATO_CIVILE

      utente.Note = NOTES
      utente.Codifica.CodificaCE = CODICE_CE
      utente.Codifica.CodificaEC = CODICE_EC
      utente.SituazioneFamiliare.Coniuge.Nome = NOME_CONIUGE
      utente.SituazioneFamiliare.Coniuge.Cognome = COGNOME_CONIUGE
      utente.SituazioneFamiliare.Coniuge.CodiceFiscale = CF_CONIUGE




     







      Item = utente


      JournalingDataLoader.ReadJournalingParameters(Item, rs)


   End Sub
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadInsertCommandParameters(Item, Cmd)

         Dim Utente As Utente = DirectCast(Item, Utente)
         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Iqu"
         param.Value = Utente.QuotaMensile.Importo
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = CInt(Utente.QuotaMensile.GetValuta)
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Con"
         If Utente.Conto.IdConto > 0 Then
            param.Value = Utente.Conto.IdConto
         Else
            Throw New Exception("Impossibile caricare il parametro Conto per il comando di inserimento di un oggetto Utente. L'id del conto non è valido.")
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ses"
         param.Value = CInt(Utente.Sesso)
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Dat"
         If Utente.DataNascita = Date.MinValue Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.DataNascita.Date
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Naz"
         If Utente.Nazionalita.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Nazionalita.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@RegN"
         If Utente.ProvinciaNascita.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.ProvinciaNascita.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@ComN"
         If Utente.ComuneNascita.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.ComuneNascita.Id
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Reg"
         If Utente.Residenza.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If Utente.Residenza.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Comune.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Utente.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Utente.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Utente.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cf"
         If Utente.CodiceFiscale = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.CodiceFiscale
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If Utente.Residenza.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tel"
         If Utente.Comunicazione.TelefonoCasa = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.TelefonoCasa
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CAP"
         If Utente.Residenza.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Cap
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Utente.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Utente.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Carp"
         If Utente.DirectoryPreferenziale = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.DirectoryPreferenziale
         End If
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@DatInt"
         If Utente.SituazioneFamiliare.DataIntervista = DateTime.MinValue Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.SituazioneFamiliare.DataIntervista
         End If


         Cmd.Parameters.Add(param)
         param = Cmd.CreateParameter
         param.ParameterName = "@ConAC"
         param.Value = Utente.SituazioneFamiliare.ConiugeACarico
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CasP"
         param.Value = Utente.SituazioneFamiliare.CasaProprieta
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@StCiv"
         If Utente.SituazioneFamiliare.StatoCivile = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.SituazioneFamiliare.StatoCivile
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdFon"
         If Utente.Fondo Is Nothing Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Fondo.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdRef"
         If Utente.SituazioneFamiliare.Referente.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.SituazioneFamiliare.Referente.Id
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@PFot"
         param.Value = Utente.Path_Foto
         Cmd.Parameters.Add(param)




         param = Cmd.CreateParameter
         param.ParameterName = "@CodCE"
         param.Value = Utente.Codifica.CodificaCE
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@CodEC"
         param.Value = Utente.Codifica.CodificaEC
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Notes"
         param.Value = Utente.Note
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@NomCon"
         param.Value = Utente.SituazioneFamiliare.Coniuge.Nome
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@CogCon"
         param.Value = Utente.SituazioneFamiliare.Coniuge.Cognome
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CFCon"
         param.Value = Utente.SituazioneFamiliare.Coniuge.CodiceFiscale
         Cmd.Parameters.Add(param)




      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Utente." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         MyBase.LoadUpdateCommandParameters(Item, Cmd)
         Dim Utente As Utente = DirectCast(Item, Utente)
         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Iqu"
         param.Value = Utente.QuotaMensile.Importo
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = CInt(Utente.QuotaMensile.GetValuta)
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Con"
         If Utente.Conto.IdConto > 0 Then
            param.Value = Utente.Conto.IdConto
         Else
            Throw New Exception("Impossibile caricare il parametro Conto per il comando di inserimento di un oggetto Utente. L'id del conto non è valido.")
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Ses"
         param.Value = CInt(Utente.Sesso)
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Dat"
         If Utente.DataNascita = Date.MinValue Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.DataNascita.Date
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Naz"
         If Utente.Nazionalita.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Nazionalita.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@RegN"
         If Utente.ProvinciaNascita.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.ProvinciaNascita.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@ComN"
         If Utente.ComuneNascita.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.ComuneNascita.Id
         End If
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Reg"
         If Utente.Residenza.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If Utente.Residenza.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Comune.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Mai"
         If Utente.Comunicazione.Mail = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Mail
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ce1"
         If Utente.Comunicazione.Cellulare1 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Cellulare1
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ce2"
         If Utente.Comunicazione.Cellulare2 = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Cellulare2
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cf"
         If Utente.CodiceFiscale = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.CodiceFiscale
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If Utente.Residenza.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tel"
         If Utente.Comunicazione.TelefonoCasa = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.TelefonoCasa
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CAP"
         If Utente.Residenza.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Residenza.Cap
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Fax"
         If Utente.Comunicazione.Fax = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.Fax
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tuf"
         If Utente.Comunicazione.TelefonoUfficio = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Comunicazione.TelefonoUfficio
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Carp"
         If Utente.DirectoryPreferenziale = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.DirectoryPreferenziale
         End If
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


         param = Cmd.CreateParameter
         param.ParameterName = "@DatInt"
         If Utente.SituazioneFamiliare.DataIntervista = DateTime.MinValue Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.SituazioneFamiliare.DataIntervista
         End If
         Cmd.Parameters.Add(param)





         param = Cmd.CreateParameter
         param.ParameterName = "@ConAC"
         param.Value = Utente.SituazioneFamiliare.ConiugeACarico
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CasP"
         param.Value = Utente.SituazioneFamiliare.CasaProprieta
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@StCiv"
         If Utente.SituazioneFamiliare.StatoCivile = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.SituazioneFamiliare.StatoCivile
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdFon"
         If Utente.Fondo Is Nothing Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.Fondo.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdRef"
         If Utente.SituazioneFamiliare.Referente.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Utente.SituazioneFamiliare.Referente.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@PFot"
         param.Value = Utente.Path_Foto
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CodCE"
         param.Value = Utente.Codifica.CodificaCE
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@CodEC"
         param.Value = Utente.Codifica.CodificaEC
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@Notes"
         param.Value = Utente.Note
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@NomCon"
         param.Value = Utente.SituazioneFamiliare.Coniuge.Nome
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@CogCon"
         param.Value = Utente.SituazioneFamiliare.Coniuge.Cognome
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@CFCon"
         param.Value = Utente.SituazioneFamiliare.Coniuge.CodiceFiscale
         Cmd.Parameters.Add(param)



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Utente." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub Finalize()
      MyBase.Finalize()
   End Sub
End Class
