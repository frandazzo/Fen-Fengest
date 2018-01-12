Public Class AbstractAziendaMapper
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
        


         Dim Desc As String = IIf(rs.Item("DESCRIZIONE") IsNot Nothing, rs.Item("DESCRIZIONE"), "")
         Dim Di As DateTime = IIf(rs.Item("DATA_INIZIO_COMP") IsNot Nothing, rs.Item("DATA_INIZIO_COMP"), DateTime.MinValue)
         Dim Df As DateTime = IIf(rs.Item("DATA_FINE_COMP") IsNot Nothing, rs.Item("DATA_FINE_COMP"), DateTime.MinValue)
         Dim Con As String = IIf(rs.Item("ID_CONTO") IsNot Nothing, rs.Item("ID_CONTO"), -1)
         Dim Uni As IConfrontoPeriodi.UnitaDiCompetenza = IIf(rs.Item("UNITA_COMP") IsNot Nothing, rs.Item("UNITA_COMP"), 0)
                  Dim competenza As AbstractPeriodo
         If Di = DateTime.MinValue Or Df = DateTime.MinValue Then
            competenza = New PeriodoNullo
         Else
            competenza = New CompositePeriodo(New DataRange(Di, Df), Uni)
         End If
         Dim MapperConti As MapperConto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperConto")
         Dim conto As IConto = MapperConti.FindObjectById(Con)
         If conto Is Nothing Then conto = New ContoNullo
         Item.Key = Key

         Dim VIA As String = IIf(rs.Item("INDIRIZZO") IsNot Nothing, rs.Item("INDIRIZZO"), "")
         Dim CAP As String = IIf(rs.Item("CAP") IsNot Nothing, rs.Item("CAP"), "")
         Dim MapperProvincia As MapperProvincia = PersistenceMapperRegistry.Instance.GetMapperByName("MapperProvincia")
         Dim MapperComune As MapperComune = PersistenceMapperRegistry.Instance.GetMapperByName("MapperComune")

         Dim ID_PROVINCIA As Int32 = IIf(rs.Item("ID_TB_PROVINCIE") IsNot Nothing, rs.Item("ID_TB_PROVINCIE"), -1)
         Dim PROVINCIA As Provincia = IIf(ID_PROVINCIA = -1, New ProvinciaNulla, MapperProvincia.FindObjectById(ID_PROVINCIA))

         Dim ID_COMUNE As Int32 = IIf(rs.Item("ID_TB_COMUNI") IsNot Nothing, rs.Item("ID_TB_COMUNI"), -1)
         Dim COMUNE As Comune = IIf(ID_COMUNE = -1, New ComuneNullo, MapperComune.FindObjectById(ID_COMUNE))

         Dim Azienda As Azienda = DirectCast(Item, Azienda)
         ' (Desc, competenza, conto, Uni, Tip, Sca)
         Azienda.Descrizione = Desc
         Azienda.CompetenzaUltimoPagamento = competenza
         Azienda.Conto = conto
         Azienda.UnitaDiCompetenza = Uni
         Azienda.IndirizzoSedeLegale.Comune = COMUNE
         Azienda.IndirizzoSedeLegale.Provincia = PROVINCIA
         Azienda.IndirizzoSedeLegale.Cap = CAP
         Azienda.IndirizzoSedeLegale.Via = VIA
         Item = Azienda

      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto azienda" & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
      Return New Azienda
   End Function


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Azienda As Azienda = DirectCast(Item, Azienda)
         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = Azienda.Descrizione
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Di"
         If Not TypeOf (Azienda.CompetenzaUltimoPagamento) Is PeriodoNullo Then
            param.Value = Azienda.CompetenzaUltimoPagamento.GetDataRange.Start
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Df"
         If Not TypeOf (Azienda.CompetenzaUltimoPagamento) Is PeriodoNullo Then
            param.Value = Azienda.CompetenzaUltimoPagamento.GetDataRange.Finish
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Con"
         If Azienda.Conto.IdConto > 0 Then
            param.Value = Azienda.Conto.IdConto
         Else
            Throw New Exception("Impossibile caricare il parametro Conto per il comando di inserimento di un oggetto Azienda. L'id del conto non è valido.")
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Uni"
         param.Value = Azienda.UnitaDiCompetenza
         Cmd.Parameters.Add(param)





         param = Cmd.CreateParameter
         param.ParameterName = "@Pro"
         If Azienda.IndirizzoSedeLegale.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If Azienda.IndirizzoSedeLegale.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If Azienda.IndirizzoSedeLegale.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cap"
         If Azienda.IndirizzoSedeLegale.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Cap
         End If
         Cmd.Parameters.Add(param)





      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Azienda As Azienda = DirectCast(Item, Azienda)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = Azienda.Descrizione
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Di"
         If Not TypeOf (Azienda.CompetenzaUltimoPagamento) Is PeriodoNullo Then
            param.Value = Azienda.CompetenzaUltimoPagamento.GetDataRange.Start
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Df"
         If Not TypeOf (Azienda.CompetenzaUltimoPagamento) Is PeriodoNullo Then
            param.Value = Azienda.CompetenzaUltimoPagamento.GetDataRange.Finish
         Else
            param.Value = DBNull.Value
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Con"
         If Azienda.Conto.IdConto > 0 Then
            param.Value = Azienda.Conto.IdConto
         Else
            Throw New Exception("Impossibile caricare il parametro Conto per il comando di inserimento di un oggetto Azienda. L'id del conto non è valido.")
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Uni"
         param.Value = Azienda.UnitaDiCompetenza
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Pro"
         If Azienda.IndirizzoSedeLegale.Provincia.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Provincia.Id
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Com"
         If Azienda.IndirizzoSedeLegale.Comune.Id = -1 Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Comune.Id
         End If
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Ind"
         If Azienda.IndirizzoSedeLegale.Via = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Via
         End If
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cap"
         If Azienda.IndirizzoSedeLegale.Cap = "" Then
            param.Value = DBNull.Value
         Else
            param.Value = Azienda.IndirizzoSedeLegale.Cap
         End If
         Cmd.Parameters.Add(param)



      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Azienda." & vbCrLf & ex.Message)
      End Try
   End Sub


End Class
