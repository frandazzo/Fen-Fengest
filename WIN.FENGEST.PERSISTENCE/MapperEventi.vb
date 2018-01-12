Public Class MapperEvento
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"


   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_EVENTI"
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_EVENTI WHERE ID = @Id and ID_VERTENZA = @Idv"
   End Function
   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_EVENTI (ID,ID_VERTENZA, DATA_EVENTO, NOTE_DOC, TIPO_EVENTO, ENTE_INOLTRO, " _
           & "INTERVENTO, AVVOCATO, PATH_DOCUMENTO) VALUES (@Id, @Idv, @De, @Not, @Te, @Ei, @Int, @Avv, @PDoc)"
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_EVENTI SET DATA_EVENTO = @De, NOTE_DOC = @Not, TIPO_EVENTO = @Te, ENTE_INOLTRO = @Ei, " _
           & "INTERVENTO = @Int, AVVOCATO = @Avv, PATH_DOCUMENTO = @PDoc Where ID = @Id and Id_Vertenza = @Idv "
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "DELETE FROM DB_EVENTI  WHERE ID = @Id and ID_VERTENZA = @Idv"
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_EVENTI where ID_VERTENZA = @Idv"
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
         Return New Key(rs("ID"), rs("ID_VERTENZA"))
      Catch ex As Exception
         Throw New Exception("Impossibile creare una chiave per l'oggetto evento. " & vbCrLf & ex.Message)
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
         Dim TipoEvento As New TipoEvento
         Dim tipo As TipoEvento.TipologiaEvento = IIf(rs("TIPO_EVENTO") Is Nothing, DOMAIN.FED_SERVICES.TipoEvento.TipologiaEvento.TipoNullo, rs("TIPO_EVENTO"))

         TipoEvento.EnteInoltro = IIf(rs("ENTE_INOLTRO") Is Nothing, "", rs("ENTE_INOLTRO"))
         TipoEvento.Avvocato = IIf(rs("AVVOCATO") Is Nothing, "", rs("AVVOCATO"))
         TipoEvento.InterventoRichiesto = IIf(rs("INTERVENTO") Is Nothing, "", rs("INTERVENTO"))
         TipoEvento.Tipo = tipo

         Dim evento As Evento = New Evento(rs("DATA_EVENTO"), rs("NOTE_DOC"), TipoEvento)
         evento.Path_Documento = rs("PATH_DOCUMENTO")
         evento.Key = Key

         Return evento
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto evento" & vbCrLf & ex.Message)
      End Try
   End Function



#Region "Metodi per il caricamento dei parametri per i comandi"


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try

         Dim Evento As Evento = DirectCast(Item, Evento)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@De"
         param.Value = Evento.DataRegistrazione.Date
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Not"
         param.Value = Evento.Note
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Te"
         param.Value = Evento.TipoEvento.Tipo
         Cmd.Parameters.Add(param)




         param = Cmd.CreateParameter
         param.ParameterName = "@Ei"
         param.Value = Evento.TipoEvento.EnteInoltro
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Int"
         param.Value = Evento.TipoEvento.InterventoRichiesto
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Avv"
         param.Value = Evento.TipoEvento.Avvocato
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@PDoc"
         param.Value = Evento.Path_Documento
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto evento." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Evento As Evento = DirectCast(Item, Evento)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@De"
         param.Value = Evento.DataRegistrazione.Date
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Not"
         param.Value = Evento.Note
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Te"
         param.Value = Evento.TipoEvento.Tipo
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ei"
         param.Value = Evento.TipoEvento.EnteInoltro
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Int"
         param.Value = Evento.TipoEvento.InterventoRichiesto
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Avv"
         param.Value = Evento.TipoEvento.Avvocato
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@PDoc"
         param.Value = Evento.Path_Documento
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Evento.Key.Value(0)
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Idv"
         param.Value = Evento.Key.Value(1)
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto evento." & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region

#Region "Metodi per l'inserimento"


   Protected Overloads Function FindNextKey(ByVal IdVertenza As Int32) As Key
      Dim rs As IDataReader = Nothing
      Dim cmd As IDbCommand
      Try
         'qui devo leggere l'oggetto in un datareader e caricarlo
         cmd = Me.GetCommand(Me.FindNextKeyStatement)

         Dim Param As IDataParameter = cmd.CreateParameter
         Param.ParameterName = "@Idv"
         Param.Value = IdVertenza
         cmd.Parameters.Add(Param)

         rs = cmd.ExecuteReader
         rs.Read()
         'Assumo che l'id del pagamento sara il 
         'secondo valore nella lista delle chiavi identificative
         'e l'id della posizione sarà il primo
         If IsDBNull(rs(0)) Then
            rs.Close()
            Dim Newkey As Key = New Key(1, IdVertenza)
            Return Newkey
         Else
            Dim Id As Int32 = rs(0) + 1
            rs.Close()
            Dim Updatedkey As Key = New Key(Id, IdVertenza)
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
         Return PerformInsert(item, FindNextKey(DirectCast(item, Evento).DocumentoPadre.GetId))
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
         param.ParameterName = "@Idv"
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
         param.ParameterName = "@Idv"
         param.Value = Item.Key.Value(1)
         Cmd.Parameters.Add(param)
      Catch ex As Exception
         Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'inserimento di un oggetto" & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region




End Class
