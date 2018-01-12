Public Class MapperSedeOperativa
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"


   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_SEDI_OPERATIVE"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_SEDI_OPERATIVE WHERE ID = @Id and ID_AZIENDA = @IdAz"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_SEDI_OPERATIVE (ID,ID_AZIENDA, DESCRIZIONE, ID_PROVINCIA, ID_COMUNE, VIA) VALUES (@Id, @IdAz, @De, @Prov, @Com, @Via)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_SEDI_OPERATIVE SET DESCRIZIONE = @De, ID_PROVINCIA = @Prov, ID_COMUNE = @Com, VIA = @Via Where ID = @Id and Id_Azienda = @IdAz "
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "DELETE FROM DB_SEDI_OPERATIVE  WHERE ID = @Id and ID_AZIENDA = @IdAz"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_SEDI_OPERATIVE where ID_AZIENDA = @IdAz"
   End Function

#End Region







#Region "Metodi per la preparazione dei comandi"


    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function
#End Region

#Region "Metodi per la ricerca"

   Protected Overrides Function CreateKey(ByVal rs As System.Collections.Hashtable) As Key
      Try
         Return New Key(rs("ID"), rs("ID_AZIENDA"))
      Catch ex As Exception
         Throw New Exception("Impossibile creare una chiave per l'oggetto sede operativa. " & vbCrLf & ex.Message)
      End Try
   End Function
#End Region

#Region "Metodi non implementati"
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Throw New Exception("Impossibile utilizzare il metodo di ricerca secondo l'identificati specificato per una posizione di pagamento. Metodo non implementato.")
   End Function

#End Region

   Protected Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try

         Dim sede As SedeOperativa = New SedeOperativa '(, rs("NOTE_DOC"), TipoEvento)
         sede.Descrizione = rs("DESCRIZIONE")
         Dim VIA As String = IIf(rs.Item("VIA") IsNot Nothing, rs.Item("VIA"), "")


         Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
         Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

         Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_PROVINCIA") IsNot Nothing, rs.Item("ID_PROVINCIA"), -1)
         Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

         Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_COMUNE") IsNot Nothing, rs.Item("ID_COMUNE"), -1)
         Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))

         sede.Indirizzo.Comune = COMUNE
         sede.Indirizzo.Provincia = PROVINCIA
         sede.Indirizzo.Via = VIA




         sede.Key = Key
         Return sede
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto sede operativa" & vbCrLf & ex.Message)
      End Try
   End Function



#Region "Metodi per il caricamento dei parametri per i comandi"


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try

         Dim Sede As SedeOperativa = DirectCast(Item, SedeOperativa)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@De"
         param.Value = Sede.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Prov"
         If Sede.Indirizzo.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Sede.Indirizzo.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If Sede.Indirizzo.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Sede.Indirizzo.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Via"
         param.Value = Sede.Indirizzo.Via
         Cmd.Parameters.Add(param)



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto sede operativa." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Sede As SedeOperativa = DirectCast(Item, SedeOperativa)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@De"
         param.Value = Sede.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Prov"
         If Sede.Indirizzo.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Sede.Indirizzo.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If Sede.Indirizzo.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Sede.Indirizzo.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Via"
         param.Value = Sede.Indirizzo.Via
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Item.Key.Value(0)
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdAz"
         param.Value = Item.Key.Value(1)
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto sede operativa." & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region

#Region "Metodi per l'inserimento"


   Protected Overloads Function FindNextKey(ByVal IdAzienda As Int32) As Key
      Dim rs As IDataReader = Nothing
      Dim cmd As IDbCommand
      Try
         'qui devo leggere l'oggetto in un datareader e caricarlo
         cmd = Me.GetCommand(Me.FindNextKeyStatement)

         Dim Param As IDataParameter = cmd.CreateParameter
         Param.ParameterName = "@IdAz"
         Param.Value = IdAzienda
         cmd.Parameters.Add(Param)

         rs = cmd.ExecuteReader
         rs.Read()
         'Assumo che l'id del pagamento sara il 
         'secondo valore nella lista delle chiavi identificative
         'e l'id della posizione sarà il primo
         If IsDBNull(rs(0)) Then
            rs.Close()
            Dim Newkey As Key = New Key(1, IdAzienda)
            Return Newkey
         Else
            Dim Id As Int32 = rs(0) + 1
            rs.Close()
            Dim Updatedkey As Key = New Key(Id, IdAzienda)
            Return Updatedkey
         End If
      Catch ex As Exception
         Throw New Exception("Impossibile trovare una nuova chiave identificativa per l'oggetto. " & vbCrLf & ex.Message)
      Finally
         ReleaseDBDatareader(rs)
      End Try
   End Function
   Public Overrides Function Insert(ByVal item As AbstractPersistenceObject) As Key

      If item.IsValid Then
         Return PerformInsert(item, FindNextKey(DirectCast(item, SedeOperativa).IdAziendaPadre))
      Else
         Dim errors As String = ""
         For Each elem As String In item.ValidationErrors
            errors = errors & elem & vbCrLf
         Next
         Throw New Exception("L'oggetto inserito non è valido. Controllare il valore dei valori immessi" & vbCrLf & errors)
      End If

   End Function
   Protected Overrides Sub LoadDeleteCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As IDbCommand)
      Try
         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Item.Key.Value(0)
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdAz"
         param.Value = Item.Key.Value(1)
         Cmd.Parameters.Add(param)
      Catch ex As Exception
         Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'eliminazione di un oggetto" & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadInsertCommandKeyParameter(ByVal Item As AbstractPersistenceObject, ByVal Cmd As IDbCommand)
      Try
         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Item.Key.Value(0)
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdAz"
         param.Value = Item.Key.Value(1)
         Cmd.Parameters.Add(param)
      Catch ex As Exception
         Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'inserimento di un oggetto" & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region



End Class
