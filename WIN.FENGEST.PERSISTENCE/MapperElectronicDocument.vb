Public Class MapperElectronicDocument
   Inherits AbstractRDBMapper


   Protected m_Table As String = ""
   Protected m_TargetKey As String = ""

   'Public Sub SetTable(ByVal Table As String)
   '   m_Table = Table
   'End Sub

   'Public Sub SetTargetKey(ByVal TargetKey As String)
   '   m_TargetKey = TargetKey
   'End Sub

#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from " + m_Table
   End Function

   Protected Function FindAllByTargetStatement() As String
      Return "Select * from " + m_Table + " where " + m_TargetKey + " = @IdTar"
   End Function


   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from " + m_Table + " where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
        Return "Insert into  " + m_Table + "  (ID, " + m_TargetKey + ", ID_Tipo_Documentazione, DATA, FILE_NAME, NOTES, ID_REFERENTE) values (@Id, @IdTar, @IdTip, @Dat, @Fil, @Not, @idr)"
   End Function

   Protected Overrides Function UpdateStatement() As String
        Return "UPDATE " + m_Table + " SET " + m_TargetKey + " = @IdTar,  ID_Tipo_Documentazione = @IdTip, DATA = @Dat, FILE_NAME = @Fil, NOTES = @Not, ID_REFERENTE=@idr  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from " + m_Table + "  where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from " + m_Table
   End Function

#End Region


   Public Function FindDocumentsByTarget(ByVal target As AbstractPersistenceObject) As IList
      Dim rs As IDataReader = Nothing
      Dim Datalist As IList
      Dim Lista As IList
      Dim connectionExternallyOpened As Boolean = False
      Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
                'DBConnectionManager.Instance.GetCurrentConnection.Close()
            Else
                m_PersistentService.CurrentConnection.Open()
            End If



         Dim cmd As IDbCommand = GetCommand(FindAllByTargetStatement)
         Dim param As IDataParameter = cmd.CreateParameter
         param.ParameterName = "@IdTar"
         param.Value = target.Id
         cmd.Parameters.Add(param)
         rs = cmd.ExecuteReader
         Datalist = Me.LoadDataMatrix(rs)
         rs.Close()
         Lista = LoadAll(Datalist, target)

         If connectionExternallyOpened = False Then
                m_PersistentService.CurrentConnection.Close()
         End If

         'RipristinaRiferimentoCircolareCon(Utente, Lista)
         Return Lista
      Catch ex As Exception
         Throw
      Finally
         ReleaseDBDatareader(rs)
         Datalist = New ArrayList
         If connectionExternallyOpened = False Then
                If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
         End If
      End Try
   End Function


   Protected Overloads Function LoadAll(ByVal rs As IList, ByVal target As AbstractPersistenceObject) As IList
      Dim List As New ArrayList
      For Each elem As Hashtable In rs
         List.Add(Load(elem, target))
      Next
      Return List
   End Function

   Protected Overridable Overloads Function Load(ByVal rs As Hashtable, ByVal target As AbstractPersistenceObject, Optional ByVal FindAllForDeletion As Boolean = False) As AbstractPersistenceObject
      Dim key As Key = CreateKey(rs)
      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
      Dim obj As AbstractPersistenceObject = DoLoad(key, rs, target)
      Cache.AddToCache(obj)
      Return obj
   End Function




   Protected Overridable Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal target As AbstractPersistenceObject) As AbstractPersistenceObject
      'Dim ElectronicDocumentUtente As New ElectronicDocumentUtente()
      'ElectronicDocumentUtente.Target = target
      ''preferenza.Utente = Utente



      'Dim Id_TipoDocumentazione As Int32 = IIf(rs("ID_TIPO_DOCUMENTAZIONE") IsNot Nothing, rs("ID_TIPO_DOCUMENTAZIONE"), -1)
      'Dim MapperTipoDocumentazione As MapperTipoDocumentazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoDocumentazione")
      'Dim tipoDoc As TipoDocumentazione = MapperTipoDocumentazione.FindObjectById(Id_TipoDocumentazione)

      'Dim DATA As DateTime = IIf(rs("DATA") IsNot Nothing, rs("DATA"), DateTime.MinValue)
      'Dim FILE_NAME As String = IIf(rs("FILE_NAME") IsNot Nothing, rs("FILE_NAME"), "")
      'Dim note As String = IIf(rs("NOTES") IsNot Nothing, rs("NOTES"), "")


      'ElectronicDocumentUtente.TipoDocumentazione = tipoDoc
      'ElectronicDocumentUtente.Data = DATA
      'ElectronicDocumentUtente.FullFileName = FILE_NAME
      'ElectronicDocumentUtente.Key = Key
      'ElectronicDocumentUtente.Notes = note
      'Return ElectronicDocumentUtente
      Throw New NotImplementedException
   End Function











#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), ElectronicDocument)

   End Function

    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   ' Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region










   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      'Dim doc As ElectronicDocumentUtente = DirectCast(Item, ElectronicDocumentUtente)

      'Dim param As IDbDataParameter = Cmd.CreateParameter
      'param.ParameterName = "@IdTar"
      'param.Value = doc.Target.Id
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@IdTip"
      'If doc.TipoDocumentazione Is Nothing Then
      '   param.Value = DBNull.Value
      'Else
      '   param.Value = doc.TipoDocumentazione.Id
      'End If
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@Dat"
      'If doc.Data = DateTime.MinValue Then
      '   param.Value = DBNull.Value
      'Else
      '   param.Value = doc.Data
      'End If
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@Fil"
      'param.Value = doc.FullFileName
      'Cmd.Parameters.Add(param)

      'param = Cmd.CreateParameter
      'param.ParameterName = "@Not"
      'param.Value = doc.Notes
      'Cmd.Parameters.Add(param)

   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      'Dim doc As ElectronicDocumentUtente = DirectCast(Item, ElectronicDocumentUtente)

      'Dim param As IDbDataParameter = Cmd.CreateParameter
      'param.ParameterName = "@IdTar"
      'param.Value = doc.Target.Id
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@IdTip"
      'If doc.TipoDocumentazione Is Nothing Then
      '   param.Value = DBNull.Value
      'Else
      '   param.Value = doc.TipoDocumentazione.Id
      'End If
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@Dat"
      'If doc.Data = DateTime.MinValue Then
      '   param.Value = DBNull.Value
      'Else
      '   param.Value = doc.Data
      'End If
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@Fil"
      'param.Value = doc.FullFileName
      'Cmd.Parameters.Add(param)

      'param = Cmd.CreateParameter
      'param.ParameterName = "@Not"
      'param.Value = doc.Notes
      'Cmd.Parameters.Add(param)


      'param = Cmd.CreateParameter
      'param.ParameterName = "@Id"
      'param.Value = doc.Id
      'Cmd.Parameters.Add(param)

   End Sub

   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New NotImplementedException
   End Function
End Class
