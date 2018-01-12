Public Class AbstractPersonMapper
   Inherits AbstractHierarchicalMapper



#Region "Metodi non implementati"
   Protected Overrides Function FindAllStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function InsertStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function UpdateStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function DeleteStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
#End Region

   Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As Hashtable)
      Try
         Dim Nome As String = IIf(rs.Item("NOME") IsNot Nothing, rs.Item("NOME"), "")
         Dim Cognome As String = IIf(rs.Item("COGNOME") IsNot Nothing, rs.Item("COGNOME"), "")
         Item.Key = Key
         Dim persona As AbstractPersona = DirectCast(Item, AbstractPersona)
         persona.Nome = Nome
         persona.Cognome = Cognome
         Item = persona
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto utente" & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New AbstractPersona
   End Function
 

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Utente As AbstractPersona = DirectCast(Item, AbstractPersona)


         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Nom"
         param.Value = Utente.Nome
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Cog"
         param.Value = Utente.Cognome
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         If Utente.DataNascita <> DateTime.MinValue Then
            param.Value = Utente.CompleteName & "(" & Utente.DataNascita.Date.ToString("dd/MM/yyy") & ")"
         Else
            param.Value = Utente.CompleteName
         End If
         Cmd.Parameters.Add(param)




      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Utente." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Utente As AbstractPersona = DirectCast(Item, AbstractPersona)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Nom"
         param.Value = Utente.Nome
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Cog"
         param.Value = Utente.Cognome
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         If Utente.DataNascita <> DateTime.MinValue Then
            param.Value = Utente.CompleteName & "(" & Utente.DataNascita.Date.ToString("dd/MM/yyy") & ")"
         Else
            param.Value = Utente.CompleteName
         End If
         Cmd.Parameters.Add(param)




      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Utente." & vbCrLf & ex.Message)
      End Try
   End Sub


End Class
