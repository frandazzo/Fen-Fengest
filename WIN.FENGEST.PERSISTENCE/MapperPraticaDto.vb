Public Class MapperPraticaDto
    Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_PRATICHE_VIEW"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return ""
    End Function

    Protected Overrides Function InsertStatement() As String
        Return ""
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return ""
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return ""
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return ""
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Pratica)

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim tipo As New Pratica
        tipo.PraticaDate = rs.Item("PracticeDate")
        tipo.Notes = rs.Item("PracticeNote")

        Dim state As Int32 = rs.Item("PracticeState")
        tipo.State = PracticeStateFactory.ConstructPracticeState(state)

        Dim MapperUser As MapperUser = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUser")
        Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
        Dim MapperTipoPratica As MapperTipoPratica = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoPratica")


        Dim ID_Owner As Int32 = IIf(rs.Item("Owner") IsNot Nothing, rs.Item("Owner"), -1)
        If ID_Owner <> -1 Then
            tipo.Owner = MapperUser.FindObjectById(ID_Owner)
        End If

        Dim ID_User As Int32 = IIf(rs.Item("UserId") IsNot Nothing, rs.Item("UserId"), -1)
        If ID_User <> -1 Then
            tipo.Utente = MapperUtente.FindObjectById(ID_User)
        End If

        Dim ID_tipo As Int32 = IIf(rs.Item("PracticeTypeId") IsNot Nothing, rs.Item("IntegrationUser"), -1)
        If ID_tipo <> -1 Then
            tipo.TipoPratica = MapperTipoPratica.FindObjectById(ID_tipo)
        End If

        'Dim lazyList As New LazyLoadPraticaEvents(tipo, Me)
        'tipo.Events = lazyList

        'Dim lazyList1 As New LazyLoadPraticaDetails(tipo, Me)
        'tipo.Details = lazyList1

        tipo.Key = Key

        Return tipo
    End Function


#End Region


   


    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
       


    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      

    End Sub


End Class


