Public Class MapperIncaricoDTO
    Inherits AbstractRDBMapper

    Public Sub New()
        Me.UseDefaultCacheMechanism = False
        Me.Cache = New PersistentObjectCache(0)
    End Sub
#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_INCARICHI_VIEW"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Throw New NotImplementedException
    End Function

    Protected Overrides Function InsertStatement() As String
        Throw New NotImplementedException
    End Function

    Protected Overrides Function UpdateStatement() As String
        Throw New NotImplementedException
    End Function

    Protected Overrides Function DeleteStatement() As String
        Throw New NotImplementedException
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Throw New NotImplementedException
    End Function

#End Region




    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), IncaricoDTO)

    End Function




    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim incarico As New IncaricoDTO




        Dim Id_Utente As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
        Dim Id_Azienda As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
        Dim note As String = IIf(rs("NOTES") IsNot Nothing, rs("NOTES"), "")
        Dim nome As String = IIf(rs("NOME") IsNot Nothing, rs("NOME"), "")
        Dim cognome As String = IIf(rs("COGNOME") IsNot Nothing, rs("COGNOME"), "")
        Dim mail As String = IIf(rs("MAIL") IsNot Nothing, rs("MAIL"), "")
        Dim cell1 As String = IIf(rs("CELL1") IsNot Nothing, rs("CELL1"), "")
        Dim cell2 As String = IIf(rs("CELL2") IsNot Nothing, rs("CELL2"), "")
        Dim cf As String = IIf(rs("CODICE_FISCALE") IsNot Nothing, rs("CODICE_FISCALE"), "")
        Dim indirizzo As String = IIf(rs("INDIRIZZO") IsNot Nothing, rs("INDIRIZZO"), "")
        Dim tel As String = IIf(rs("TEL") IsNot Nothing, rs("TEL"), "")
        Dim cap As String = IIf(rs("CAP") IsNot Nothing, rs("CAP"), "")
        Dim comune_residenza As String = IIf(rs("COMUNE_RESIDENZA") IsNot Nothing, rs("COMUNE_RESIDENZA"), "")
        Dim provincia_residenza As String = IIf(rs("PROVINCIA_RESIDENZA") IsNot Nothing, rs("PROVINCIA_RESIDENZA"), "")

        Dim azienda As String = IIf(rs("AZIENDA") IsNot Nothing, rs("AZIENDA"), "")
        Dim comune_AZIENDA As String = IIf(rs("COMUNE_AZIENDA") IsNot Nothing, rs("COMUNE_AZIENDA"), "")
        Dim provincia_AZIENDA As String = IIf(rs("PROVINCIA_AZIENDA") IsNot Nothing, rs("PROVINCIA_AZIENDA"), "")
        Dim indirizzo_AZIENDA As String = IIf(rs("INDIRIZZO_AZIENDA") IsNot Nothing, rs("INDIRIZZO_AZIENDA"), "")
        Dim cap_AZIENDA As String = IIf(rs("CAP_AZIENDA") IsNot Nothing, rs("CAP_AZIENDA"), "")

        Dim incarico1 As String = IIf(rs("INCARICO") IsNot Nothing, rs("INCARICO"), "")



        incarico.IdUtente = Id_Utente
        incarico.Nome = nome
        incarico.Cognome = cognome
        incarico.Mail = mail
        incarico.Cell1 = cell1
        incarico.Cell2 = cell2
        incarico.CodiceFiscale = cf
        incarico.IndirizzoAzienda = indirizzo
        incarico.Tel = tel
        incarico.Cap = cap
        incarico.ProvinciaResidenza = provincia_residenza
        incarico.ComuneResidenza = comune_residenza




        incarico.IdAzienda = Id_Azienda
        incarico.Azienda = azienda
        incarico.ProvinciaAzienda = provincia_AZIENDA
        incarico.ComuneAzienda = comune_AZIENDA
        incarico.IndirizzoAzienda = indirizzo_AZIENDA
        incarico.CapAzienda = cap_AZIENDA



        incarico.TipoIncarico = incarico1
        incarico.Notes = note

        incarico.Key = Key

        Return incarico
    End Function


    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Dim tipo As Incarico = DirectCast(Item, Incarico)

        Throw New NotImplementedException

    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Throw New NotImplementedException
    End Sub


End Class
