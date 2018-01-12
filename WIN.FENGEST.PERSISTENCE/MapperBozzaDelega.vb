Public Class MapperBozzaDelega
    Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_BOZZA"
    End Function
   
    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_BOZZA where Id = @Id"
    End Function
    Protected Overrides Function InsertStatement() As String

        Return "Insert into DB_BOZZA (ID, DATA,  ID_UTENTE, ENTE, " _
                                      & "ID_REFERENTE) values " _
                                      & "(@Id, @dat, @idu, @ent, @idr)"
    End Function
    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_BOZZA SET DATA = @dat,  " _
                                   & "ID_UTENTE = @idu, ENTE = @ent, " _
                                   & "ID_REFERENTE = @idr   WHERE ( Id = @Id )"
    End Function
    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_BOZZA where Id = @Id"
    End Function
    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_BOZZA"
    End Function

#End Region

#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"




    Private Function CreateDelega(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As BozzaDelega
        Dim DATA As DateTime = IIf(rs("DATA") IsNot Nothing, rs("DATA"), DateTime.MinValue)

        Dim ID_REFERENTE As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
        Dim ID_RESPONSABILE As Int32 = IIf(rs("ID_RESPONSABILE") IsNot Nothing, rs("ID_RESPONSABILE"), -1)
        Dim ENTE As String = IIf(rs("ENTE") IsNot Nothing, rs("ENTE"), "")
        Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)

        Dim MapperReferenti As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
        Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")


        Dim Utente As Utente = MapperUtente.FindObjectById(ID_UTENTE)
        Dim REFERENTE As Referente = MapperReferenti.FindObjectById(ID_REFERENTE)

        Dim delega As BozzaDelega = New BozzaDelega
        delega.Key = Key
        delega.Utente = Utente
        delega.Referente = REFERENTE
        delega.Data = DATA
        delega.Ente = ENTE

        Return delega
    End Function

    ''' <summary>
    ''' Mai usare questo metodo. Non rispetta i riferimenti circolari.
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
        Return DirectCast(MyBase.FindByKey(New Key(Id)), BozzaDelega)
    End Function
   #End Region

    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            'inserisco sempre una delega sottoscritta. la modifica può implicare un cambiamento di stato
            Dim Delega As BozzaDelega = DirectCast(Item, BozzaDelega)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@dat"
            param.Value = Delega.Data
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@idu"
            param.Value = Delega.Utente.IdUtente
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@ent"
            param.Value = Delega.Ente
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@idr"
            If Not Delega.Referente Is Nothing Then
                If Delega.Referente.Id <> -1 Then
                    param.Value = Delega.Referente.Id
                Else
                    param.Value = DBNull.Value
                End If
            Else
                param.Value = DBNull.Value
            End If

            Cmd.Parameters.Add(param)

            

        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Bozza Delega." & vbCrLf & ex.Message)
        End Try
    End Sub
    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            'inserisco sempre una delega sottoscritta. la modifica può implicare un cambiamento di stato
            Dim Delega As BozzaDelega = DirectCast(Item, BozzaDelega)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@dat"
            param.Value = Delega.Data
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@idu"
            param.Value = Delega.Utente.IdUtente
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@ent"
            param.Value = Delega.Ente
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@idr"
            If Not Delega.Referente Is Nothing Then
                If Delega.Referente.Id <> -1 Then
                    param.Value = Delega.Referente.Id
                Else
                    param.Value = DBNull.Value
                End If
            Else
                param.Value = DBNull.Value
            End If

            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = Delega.Id
            Cmd.Parameters.Add(param)


        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Bozza Delega." & vbCrLf & ex.Message)
        End Try
    End Sub

  


    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Return CreateDelega(Key, rs)
    End Function
End Class

