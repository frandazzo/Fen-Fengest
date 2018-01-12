Public Class MapperCustomer
    Inherits AbstractRDBMapper

    Public Sub New()
        m_IsAutoIncrementID = False
    End Sub

#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_UTENTE"
    End Function
    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_UTENTE where Id = @Id"
    End Function
    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_UTENTE (ID,COGNOME, ID_TB_PROVINCIE_RESIDENZA, ID_TB_COMUNI_RESIDENZA, INDIRIZZO, CAP,  " _
        & "CODICE_FISCALE, CreatedBy, CreatedOn, " _
        & " MAIL, CELL1, CELL2, FAX, TEL_UF, NOME, Notes, IMPORTO_QUOTA, VALUTA, ID_CONTO, SESSO, DATA_NASCITA, Descrizione, CARTELLA_PREFERENZIALE) values (@Id, @Desc, @Pro, @Com, @Ind, @Cap, @IPI, " _
        & " @CRby, @CRon, @Mai, @Ce1, @Ce2, @Fax, @Tuf, @Respo, @Notes, 0, 0, 2, 0, '01/01/1900', @descr, @cpref)"
    End Function
    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_UTENTE SET Cognome = @Desc, ID_TB_PROVINCIE_RESIDENZA = @Pro, ID_TB_COMUNI_RESIDENZA = @Com, INDIRIZZO = @Ind, CAP = @Cap," _
        & "CODICE_FISCALE = @IPI, ModifiedBy = @MOby, ModifiedOn = @MOon, " _
        & " Mail = @Mai, Cell1 = @Ce1, Cell2 = @Ce2, Fax = @Fax, Tel_uf = @Tuf, NOME = @Respo, Notes = @Notes, Descrizione = @Comp WHERE (Id =@Id )"
    End Function
    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_UTENTE where Id = @Id"
    End Function
    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_UTENTE"
    End Function

#End Region


    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand
    '    'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '    Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"



    Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), Customer)


    End Function



    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Customer)


    End Function

#End Region

    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            ' MyBase.LoadInsertCommandParameters(Item, Cmd)
            Dim avv As Customer = DirectCast(Item, Customer)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Desc"
            param.Value = avv.Cognome
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Pro"
            If avv.Residenza.Provincia.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Provincia.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Com"
            If avv.Residenza.Comune.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Comune.Id
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ind"
            If avv.Residenza.Via = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Via
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Cap"
            If avv.Residenza.Cap = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Cap
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@IPI"
            If avv.CodiceFiscale = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.CodiceFiscale
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
            If avv.Nome = "" Then
                Throw New InvalidOperationException("Il nome non può essere nullo")
            Else
                param.Value = avv.Nome
            End If
            Cmd.Parameters.Add(param)




            param = Cmd.CreateParameter
            param.ParameterName = "@Notes"
            param.Value = avv.Note
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@descr"
            param.Value = String.Format("{0} {1}(01/01/1900)", avv.Cognome, avv.Nome)
            Cmd.Parameters.Add(param)



            Dim MapperSegreteria As MapperSegreteria = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSegreteria")
            Dim Segreteria As Segreteria = MapperSegreteria.FindObjectById("1")

            param = Cmd.CreateParameter
            param.ParameterName = "@cpref"
            param.Value = Segreteria.DirectoryPreferenzialeUtenti
            Cmd.Parameters.Add(param)


        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Cliente." & vbCrLf & ex.Message)
        End Try
    End Sub
    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try

            Dim avv As Customer = DirectCast(Item, Customer)

            Dim param As IDbDataParameter = Cmd.CreateParameter

            param.ParameterName = "@Desc"
            param.Value = avv.Cognome
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Pro"
            If avv.Residenza.Provincia.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Provincia.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Com"
            If avv.Residenza.Comune.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Comune.Id
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ind"
            If avv.Residenza.Via = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Via
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Cap"
            If avv.Residenza.Cap = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.Residenza.Cap
            End If

            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@IPI"
            If avv.CodiceFiscale = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = avv.CodiceFiscale
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
            If avv.Nome = "" Then
                Throw New InvalidOperationException("Il nome non può essere nullo")
            Else
                param.Value = avv.Nome
            End If
            Cmd.Parameters.Add(param)




            param = Cmd.CreateParameter
            param.ParameterName = "@Notes"
            param.Value = avv.Note
            Cmd.Parameters.Add(param)



            Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
            Dim Utente As Utente = MapperUtente.FindObjectById(avv.Id)


            param = Cmd.CreateParameter
            param.ParameterName = "@Comp"
            param.Value = avv.Cognome & " " & avv.Nome & "(" & Utente.DataNascita.Date.ToString("dd/MM/yyy") & ")"
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = avv.Id
            Cmd.Parameters.Add(param)


        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Cliente." & vbCrLf & ex.Message)
        End Try
    End Sub
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim Desc As String = IIf(rs.Item("COGNOME") IsNot Nothing, rs.Item("COGNOME"), "")



        Dim VIA As String = IIf(rs.Item("INDIRIZZO") IsNot Nothing, rs.Item("INDIRIZZO"), "")
        Dim CAP As String = IIf(rs.Item("CAP") IsNot Nothing, rs.Item("CAP"), "")
        Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
        Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

        Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_TB_PROVINCIE_RESIDENZA") IsNot Nothing, rs.Item("ID_TB_PROVINCIE_RESIDENZA"), -1)
        Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

        Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_TB_COMUNI_RESIDENZA") IsNot Nothing, rs.Item("ID_TB_COMUNI_RESIDENZA"), -1)
        Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))

        Dim PI As String = IIf(rs.Item("CODICE_FISCALE") IsNot Nothing, rs.Item("CODICE_FISCALE"), "")
        Dim TEL_UF As String = IIf(rs.Item("TEL_UF") IsNot Nothing, rs.Item("TEL_UF"), "")
        Dim MAIL As String = IIf(rs.Item("MAIL") IsNot Nothing, rs.Item("MAIL"), "")
        Dim FAX As String = IIf(rs.Item("FAX") IsNot Nothing, rs.Item("FAX"), "")
        Dim CELL1 As String = IIf(rs.Item("CELL1") IsNot Nothing, rs.Item("CELL1"), "")
        Dim CELL2 As String = IIf(rs.Item("CELL2") IsNot Nothing, rs.Item("CELL2"), "")
        Dim RESPONSABLE As String = IIf(rs.Item("NOME") IsNot Nothing, rs.Item("NOME"), "")
        'Dim privato As Boolean = IIf(rs.Item("IS_PRIVATO") IsNot Nothing, rs.Item("IS_PRIVATO"), False)

        'Dim abbonato As Boolean = IIf(rs.Item("Abbonato") IsNot Nothing, rs.Item("Abbonato"), False)
        'Dim marca As String = IIf(rs.Item("Marca") IsNot Nothing, rs.Item("Marca"), "")
        'Dim modello As String = IIf(rs.Item("Modello") IsNot Nothing, rs.Item("Modello"), "")
        'Dim matricola As String = IIf(rs.Item("Matricola") IsNot Nothing, rs.Item("Matricola"), "")



        Dim notes As String = IIf(rs.Item("NOTES") IsNot Nothing, rs.Item("NOTES"), "")


        'Dim ID_Res As Int32 = IIf(rs.Item("ResourceID") IsNot Nothing, rs.Item("ResourceID"), -1)
        Dim MapperResource As MapperResource = PersistenceMapperRegistry.Instance.GetMapperByName("MapperResource")
        Dim resource As Resource = MapperResource.FindObjectById("1")

        Dim avv As Customer = New Customer
        avv.Key = Key

        avv.Cognome = Desc
        avv.Residenza.Comune = COMUNE
        avv.Residenza.Provincia = PROVINCIA
        avv.Residenza.Cap = CAP
        avv.Residenza.Via = VIA

        avv.CodiceFiscale = PI
        avv.Comunicazione = New Comunicazioni
        avv.Comunicazione.Cellulare1 = CELL1
        avv.Comunicazione.Cellulare2 = CELL2
        avv.Comunicazione.Fax = FAX
        avv.Nome = RESPONSABLE
        avv.Comunicazione.TelefonoUfficio = TEL_UF
        avv.Comunicazione.Mail = MAIL
        'avv.Is_Private = privato
        avv.Note = notes
        avv.Resource = resource

        'avv.Marca = marca
        'avv.Modello = modello
        'avv.Matricola = matricola
        'avv.IsAbbonato = abbonato


        JournalingDataLoader.ReadJournalingParameters(avv, rs)

        Return avv
    End Function
End Class
