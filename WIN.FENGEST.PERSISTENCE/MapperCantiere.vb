Public Class MapperCantiere
    Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_CANTIERE"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_CANTIERE where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_CANTIERE (ID, Descrizione, ID_Azienda, DataFine, Notes, Zona, Provincia, Comune, Importo) values (@Id, @Descr, @IdAz, @Dat,  @Not, @zon, @pro, @com, @imp)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_CANTIERE SET Descrizione = @Descr,  ID_Azienda = @IdAz, DataFine = @Dat,  Notes = @Not, Zona = @zon, Provincia = @pro, Comune = @com, Importo = @imp WHERE (Id =@Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_CANTIERE where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_CANTIERE"
    End Function

#End Region



#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Cantiere)

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim preferenza As New Cantiere
        


        Dim Id_Azienda As Int32 = IIf(rs("Id_Azienda") IsNot Nothing, rs("Id_Azienda"), -1)

        Dim mapperAzienda As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")
        Dim az As Azienda = mapperAzienda.FindObjectById(Id_Azienda)


        Dim DATA As DateTime = IIf(rs("DataFine") IsNot Nothing, rs("DataFine"), DateTime.MinValue)
        Dim Importo As Double = IIf(rs("Importo") IsNot Nothing, rs("Importo"), 0)
        Dim Zona As String = IIf(rs("Zona") IsNot Nothing, rs("Zona"), "")
        Dim Provincia As String = IIf(rs("Provincia") IsNot Nothing, rs("Provincia"), "")
        Dim Comune As String = IIf(rs("Comune") IsNot Nothing, rs("Comune"), "")

        Dim note As String = IIf(rs("Notes") IsNot Nothing, rs("Notes"), "")
        Dim desc As String = IIf(rs("Descrizione") IsNot Nothing, rs("Descrizione"), "")


        preferenza.IdAzienda = Id_Azienda
        preferenza.DataFine = DATA
        preferenza.Descrizione = desc
        preferenza.Key = Key
        preferenza.Notes = note
        preferenza.NomeAzienda = az.Descrizione
        preferenza.Zona = Zona
        preferenza.Provincia = Provincia
        preferenza.Comune = Comune
        preferenza.Importo = Importo
        Return preferenza
    End Function


#End Region










    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Dim preferenza As Cantiere = DirectCast(Item, Cantiere)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Descr"
        param.Value = preferenza.Descrizione
        Cmd.Parameters.Add(param)




        param = Cmd.CreateParameter
        param.ParameterName = "@IdAz"
        param.Value = preferenza.IdAzienda
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Dat"
        If preferenza.DataFine = DateTime.MinValue Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.DataFine
        End If
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Not"
        If preferenza.Notes Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Notes
        End If
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@zon"
        If preferenza.Zona Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Zona
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@pro"
        If preferenza.Provincia Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Provincia
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@com"
        If preferenza.Comune Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Comune
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@imp"
        param.Value = preferenza.Importo
        Cmd.Parameters.Add(param)




    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

        Dim preferenza As Cantiere = DirectCast(Item, Cantiere)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Descr"
        param.Value = preferenza.Descrizione
        Cmd.Parameters.Add(param)




        param = Cmd.CreateParameter
        param.ParameterName = "@IdAz"
        param.Value = preferenza.IdAzienda
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Dat"
        If preferenza.DataFine = DateTime.MinValue Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.DataFine
        End If
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Not"
        If preferenza.Notes Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Notes
        End If
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@zon"
        If preferenza.Zona Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Zona
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@pro"
        If preferenza.Provincia Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Provincia
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@com"
        If preferenza.Comune Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = preferenza.Comune
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@imp"
        param.Value = preferenza.Importo
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Id"
        param.Value = preferenza.Id
        Cmd.Parameters.Add(param)

    End Sub
End Class
