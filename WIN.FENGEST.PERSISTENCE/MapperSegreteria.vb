Public Class MapperSegreteria
    Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_SEGRETERIA"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_SEGRETERIA where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_SEGRETERIA (ID, DESCRIZIONE, " _
             & "ID_TB_PROVINCIE, ID_TB_COMUNI, INDIRIZZO, CAP,  " _
             & "P_IVA, CARTELLA_PREFERENZIALE, " _
             & " MAIL, CELL1, CELL2, FAX, TEL_UF, RESPONSABILE, INDIRIZZO_WEB, CreatedBy, CreatedOn, INTESTAZIONE, SOTTOTITOLO1, SOTTOTITOLO2, SOTTOTITOLO3, CARTELLA_PREFERENZIALE_UTENTI, CARTELLA_PREFERENZIALE_AZIENDE, CARTELLA_MODELLI, CARTELLA_ETICHETTE,DB_NAZIONALE_UTENTE,DB_NAZIONALE_PASSWORD ) values (@Id, @Desc, @Pro, @Com, @Ind, @Cap, @IPI, " _
             & " @Carp, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo, @web, @CRby, @CRon, @i, @i1, @i2, @i3, @Cpu, @Cpa, @CMod, @CEt,@dbnu,@dbnp)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_SEGRETERIA SET Descrizione = @Desc,  " _
        & "ID_TB_PROVINCIE = @Pro, ID_TB_COMUNI = @Com, INDIRIZZO = @Ind, CAP = @Cap, " _
        & "P_IVA = @IPI, CARTELLA_PREFERENZIALE = @Carp,  " _
        & "Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, Responsabile = @Respo, INDIRIZZO_WEB = @web, ModifiedBy = @MOby, ModifiedOn = @MOon, INTESTAZIONE= @i, SOTTOTITOLO1 = @i1, SOTTOTITOLO2 = @i2, SOTTOTITOLO3 = @i3, CARTELLA_PREFERENZIALE_UTENTI = @Cpu, CARTELLA_PREFERENZIALE_AZIENDE = @Cpa, CARTELLA_MODELLI = @CMod, CARTELLA_ETICHETTE = @CEt, DB_NAZIONALE_UTENTE = @dbnu, DB_NAZIONALE_PASSWORD = @dbnp  WHERE (Id =@Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_SEGRETERIA where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_SEGRETERIA"
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"
    Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), Segreteria)

    End Function


    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Segreteria)


    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Try
            'Dim conto As New Conto(, rs.Item("VALUTA"), DirectCast(rs.Item("TIPO_CONTO"), Conto.TipoConto))
            'conto.Key = Key
            'Dim VirtualList As LazyLoadPosizioniConto = New LazyLoadPosizioniConto(conto)
            'conto.SetItemList(VirtualList)
            'Return conto



            Dim Desc As String = IIf(rs.Item("DESCRIZIONE") IsNot Nothing, rs.Item("DESCRIZIONE"), "")

            Dim VIA As String = IIf(rs.Item("INDIRIZZO") IsNot Nothing, rs.Item("INDIRIZZO"), "")
            Dim CAP As String = IIf(rs.Item("CAP") IsNot Nothing, rs.Item("CAP"), "")
            Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
            Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

            Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_TB_PROVINCIE") IsNot Nothing, rs.Item("ID_TB_PROVINCIE"), -1)
            Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

            Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_TB_COMUNI") IsNot Nothing, rs.Item("ID_TB_COMUNI"), -1)
            Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))


            Dim PIVA As String = IIf(rs.Item("P_IVA") IsNot Nothing, rs.Item("P_IVA"), "")
            Dim CarP As String = IIf(rs.Item("CARTELLA_PREFERENZIALE") IsNot Nothing, rs.Item("CARTELLA_PREFERENZIALE"), "")
            Dim CarPU As String = IIf(rs.Item("CARTELLA_PREFERENZIALE_UTENTI") IsNot Nothing, rs.Item("CARTELLA_PREFERENZIALE_UTENTI"), "")

            Dim CarPA As String = IIf(rs.Item("CARTELLA_PREFERENZIALE_AZIENDE") IsNot Nothing, rs.Item("CARTELLA_PREFERENZIALE_AZIENDE"), "")




            Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
            Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
            Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
            Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
            Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
            Dim RESPONSABLE As String = IIf(rs.Item("RESPONSABILE") IsNot Nothing, rs.Item("RESPONSABILE"), "")
            Dim WEB As String = IIf(rs.Item("INDIRIZZO_WEB") IsNot Nothing, rs.Item("INDIRIZZO_WEB"), "")

            Dim CARTELLA_MODELLI As String = IIf(rs.Item("CARTELLA_MODELLI") IsNot Nothing, rs.Item("CARTELLA_MODELLI"), "")
            Dim CARTELLA_ETICHETTE As String = IIf(rs.Item("CARTELLA_ETICHETTE") IsNot Nothing, rs.Item("CARTELLA_ETICHETTE"), "")


            Dim INTESTAZIONE As String = IIf(rs.Item("INTESTAZIONE") IsNot Nothing, rs.Item("INTESTAZIONE"), "")
            Dim SOTTOTITOLO1 As String = IIf(rs.Item("SOTTOTITOLO1") IsNot Nothing, rs.Item("SOTTOTITOLO1"), "")
            Dim SOTTOTITOLO2 As String = IIf(rs.Item("SOTTOTITOLO2") IsNot Nothing, rs.Item("SOTTOTITOLO2"), "")
            Dim SOTTOTITOLO3 As String = IIf(rs.Item("SOTTOTITOLO3") IsNot Nothing, rs.Item("SOTTOTITOLO3"), "")


            Dim DB_NAZIONALE_UTENTE As String = IIf(rs.Item("DB_NAZIONALE_UTENTE") IsNot Nothing, rs.Item("DB_NAZIONALE_UTENTE"), "")
            Dim DB_NAZIONALE_PASSWORD As String = IIf(rs.Item("DB_NAZIONALE_PASSWORD") IsNot Nothing, rs.Item("DB_NAZIONALE_PASSWORD"), "")


            Dim Segreteria As New Segreteria
            Segreteria.Descrizione = Desc
            Segreteria.IndirizzoSedeLegale.Comune = COMUNE
            Segreteria.IndirizzoSedeLegale.Provincia = PROVINCIA
            Segreteria.IndirizzoSedeLegale.Cap = CAP
            Segreteria.IndirizzoSedeLegale.Via = VIA
            Segreteria.IndirizzoSedeLegale.IndirizzoWeb = WEB
            Segreteria.Partita_IVA = PIVA
            Segreteria.DirectoryPreferenziale = CarP

            Segreteria.Comunicazione = New Comunicazioni
            Segreteria.Comunicazione.Cellulare1 = CELL1
            Segreteria.Comunicazione.Cellulare2 = CELL2
            Segreteria.Comunicazione.Fax = FAX
            Segreteria.Responsable = RESPONSABLE
            Segreteria.Comunicazione.TelefonoUfficio = TEL_UF
            Segreteria.Comunicazione.Mail = MAIL

            Segreteria.Intestazione = INTESTAZIONE
            Segreteria.Sottotitolo1 = SOTTOTITOLO1
            Segreteria.Sottotitolo2 = SOTTOTITOLO2
            Segreteria.Sottotitolo3 = SOTTOTITOLO3

            Segreteria.DirectoryPreferenzialeAziende = CarPA
            Segreteria.DirectoryPreferenzialeUtenti = CarPU
            Segreteria.CartellaEtichette = CARTELLA_ETICHETTE
            Segreteria.CartellaModelli = CARTELLA_MODELLI

            Segreteria.PasswordNazionale = DB_NAZIONALE_PASSWORD
            Segreteria.UtenteNazionale = DB_NAZIONALE_UTENTE


            Dim documenti As VirtualLazyList = New LazyLoadArchivioDocumentale(Segreteria)
            Segreteria.ArchivioDocumenti.Documenti = documenti


            Segreteria.Key = Key

            JournalingDataLoader.ReadJournalingParameters(Segreteria, rs)





            Return Segreteria
        Catch ex As Exception
            Throw New Exception("Impossibile caricare l'oggetto conto con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
        End Try
    End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '    'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '    Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            Dim Azienda As Segreteria = DirectCast(Item, Segreteria)
            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Desc"
            param.Value = Azienda.Descrizione
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Pro"
            If Azienda.IndirizzoSedeLegale.Provincia.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Provincia.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Com"
            If Azienda.IndirizzoSedeLegale.Comune.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Comune.Id
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ind"
            If Azienda.IndirizzoSedeLegale.Via = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Via
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Cap"
            If Azienda.IndirizzoSedeLegale.Cap = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Cap
            End If
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@IPI"
            If Azienda.Partita_IVA = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Partita_IVA
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
            param.ParameterName = "@web"
            If Azienda.IndirizzoSedeLegale.IndirizzoWeb = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.IndirizzoWeb
            End If
            Cmd.Parameters.Add(param)




            JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

            param = Cmd.CreateParameter
            param.ParameterName = "@i"
            If Azienda.Intestazione = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Intestazione
            End If
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@i1"
            If Azienda.Sottotitolo1 = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Sottotitolo1
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@i2"
            If Azienda.Sottotitolo2 = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Sottotitolo2
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@i3"
            If Azienda.Sottotitolo3 = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Sottotitolo3
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Cpu"
            If Azienda.DirectoryPreferenzialeUtenti = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.DirectoryPreferenzialeUtenti
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Cpa"
            If Azienda.DirectoryPreferenzialeAziende = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.DirectoryPreferenzialeAziende
            End If
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@CMod"
            If Azienda.CartellaModelli = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.CartellaModelli
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@CEt"
            If Azienda.CartellaEtichette = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.CartellaEtichette
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@dbnu"
            If Azienda.UtenteNazionale = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.UtenteNazionale
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@dbnp"
            If Azienda.PasswordNazionale = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.PasswordNazionale
            End If
            Cmd.Parameters.Add(param)


        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto conto." & vbCrLf & ex.Message)
        End Try
    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            Dim Azienda As Segreteria = DirectCast(Item, Segreteria)
            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Desc"
            param.Value = Azienda.Descrizione
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Pro"
            If Azienda.IndirizzoSedeLegale.Provincia.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Provincia.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Com"
            If Azienda.IndirizzoSedeLegale.Comune.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Comune.Id
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ind"
            If Azienda.IndirizzoSedeLegale.Via = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Via
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Cap"
            If Azienda.IndirizzoSedeLegale.Cap = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.Cap
            End If
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@IPI"
            If Azienda.Partita_IVA = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Partita_IVA
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
            param.ParameterName = "@web"
            If Azienda.IndirizzoSedeLegale.IndirizzoWeb = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.IndirizzoSedeLegale.IndirizzoWeb
            End If
            Cmd.Parameters.Add(param)

            JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

            param = Cmd.CreateParameter
            param.ParameterName = "@i"
            If Azienda.Intestazione = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Intestazione
            End If
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@i1"
            If Azienda.Sottotitolo1 = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Sottotitolo1
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@i2"
            If Azienda.Sottotitolo2 = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Sottotitolo2
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@i3"
            If Azienda.Sottotitolo3 = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.Sottotitolo3
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Cpu"
            If Azienda.DirectoryPreferenzialeUtenti = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.DirectoryPreferenzialeUtenti
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Cpa"
            If Azienda.DirectoryPreferenzialeAziende = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.DirectoryPreferenzialeAziende
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = Azienda.Id
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@CMod"
            If Azienda.CartellaModelli = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.CartellaModelli
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@CEt"
            If Azienda.CartellaEtichette = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.CartellaEtichette
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@dbnu"
            If Azienda.UtenteNazionale = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.UtenteNazionale
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@dbnp"
            If Azienda.PasswordNazionale = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = Azienda.PasswordNazionale
            End If
            Cmd.Parameters.Add(param)


        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto conto." & vbCrLf & ex.Message)
        End Try
    End Sub



End Class
