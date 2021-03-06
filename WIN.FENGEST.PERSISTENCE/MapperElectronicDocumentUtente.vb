Public Class MapperElectronicDocumentUtente
   Inherits MapperElectronicDocument


   Public Sub New()
      m_Table = "DB_DOCUMENTI_UTENTE"
      m_TargetKey = "ID_UTENTE"
   End Sub


    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal target As AbstractPersistenceObject) As AbstractPersistenceObject
        Dim ElectronicDocumentUtente As New ElectronicDocumentUtente()
        ElectronicDocumentUtente.Target = target
        'preferenza.Utente = Utente



        Dim Id_TipoDocumentazione As Int32 = IIf(rs("ID_TIPO_DOCUMENTAZIONE") IsNot Nothing, rs("ID_TIPO_DOCUMENTAZIONE"), -1)
        Dim MapperTipoDocumentazione As MapperTipoDocumentazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoDocumentazione")
        Dim tipoDoc As TipoDocumentazione = MapperTipoDocumentazione.FindObjectById(Id_TipoDocumentazione)


        Dim ID_REFERENTE As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
        Dim referente As Referente = Nothing
        If ID_REFERENTE <> -1 Then
            Dim MapperReferente As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
            referente = MapperReferente.FindObjectById(ID_REFERENTE)
        End If



        Dim DATA As DateTime = IIf(rs("DATA") IsNot Nothing, rs("DATA"), DateTime.MinValue)
        Dim FILE_NAME As String = IIf(rs("FILE_NAME") IsNot Nothing, rs("FILE_NAME"), "")
        Dim note As String = IIf(rs("NOTES") IsNot Nothing, rs("NOTES"), "")


        ElectronicDocumentUtente.TipoDocumentazione = tipoDoc
        ElectronicDocumentUtente.Data = DATA
        ElectronicDocumentUtente.FullFileName = FILE_NAME
        ElectronicDocumentUtente.Key = Key
        ElectronicDocumentUtente.Notes = note
        ElectronicDocumentUtente.Referente = referente
        Return ElectronicDocumentUtente
    End Function




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim doc As ElectronicDocumentUtente = DirectCast(Item, ElectronicDocumentUtente)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdTar"
      param.Value = doc.Target.Id
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdTip"
      If doc.TipoDocumentazione Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = doc.TipoDocumentazione.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If doc.Data = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = doc.Data
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Fil"
      param.Value = doc.FullFileName
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = doc.Notes
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@idr"
        If doc.Referente IsNot Nothing Then
            If doc.Referente.Id > -1 Then
                param.Value = doc.Referente.Id
            Else
                param.Value = DBNull.Value
            End If

        Else
            param.Value = DBNull.Value
        End If
        Cmd.Parameters.Add(param)

   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim doc As ElectronicDocumentUtente = DirectCast(Item, ElectronicDocumentUtente)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdTar"
      param.Value = doc.Target.Id
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdTip"
      If doc.TipoDocumentazione Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = doc.TipoDocumentazione.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If doc.Data = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = doc.Data
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Fil"
      param.Value = doc.FullFileName
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = doc.Notes
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = doc.Id
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@idr"
        If doc.Referente IsNot Nothing Then
            If doc.Referente.Id > -1 Then
                param.Value = doc.Referente.Id
            Else
                param.Value = DBNull.Value
            End If

        Else
            param.Value = DBNull.Value
        End If
        Cmd.Parameters.Add(param)

    End Sub




   




End Class
