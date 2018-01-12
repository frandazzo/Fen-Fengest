Public Class GeoPersistenceService
   Implements BASEREUSE.IGeoLocationLoader






   Public Function GetComuneById(ByVal id As Integer) As Comune Implements BASEREUSE.IGeoLocationLoader.GetComuneById
      Return DataAccessServices.Instance.PersistenceFacade.GetObject("Comune", id)
   End Function

   Public Function GetNazioni() As System.Collections.IList Implements BASEREUSE.IGeoLocationLoader.GetNazioni
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Nazione")
   End Function

   Public Function GetProvincie() As System.Collections.IList Implements BASEREUSE.IGeoLocationLoader.GetProvincie
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Provincia")
   End Function

   Public Function GetRegioni() As System.Collections.IList Implements BASEREUSE.IGeoLocationLoader.GetRegioni
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Regione")
   End Function

   Public Function GetComuneByName(ByVal name As String) As BASEREUSE.Comune Implements BASEREUSE.IGeoLocationLoader.GetComuneByName
      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      Dim query As Query = ps.CreateNewQuery("MapperComune")
      query.SetTable("TB_COMUNI")
      Dim crit As AbstractBoolCriteria = Criteria.Equal("Descrizione", "'" & Replace(name, "'", "''") & "'")
      query.AddWhereClause(crit)
      Dim l As IList = query.Execute(ps)
        If l.Count > 0 Then
            'questa impostazione è necessaria per quei comuni 
            'che sono passati da una provincia all'altra
            Return l.Item(l.Count - 1)
        End If
      Return Nothing
   End Function

   Public Function GetComuneByFiscalCode(ByVal code As String) As System.Collections.IList Implements BASEREUSE.IGeoLocationLoader.GetComuneByFiscalCode
      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      Dim query As Query = ps.CreateNewQuery("MapperComune")
      query.SetTable("TB_COMUNI")
      Dim crit As AbstractBoolCriteria = Criteria.Equal("CODICE_FISCALE", "'" & Replace(code, "'", "''") & "'")
      query.AddWhereClause(crit)
      Dim l As IList = query.Execute(ps)
      Return l
   End Function

   Public Function GetProvinciaById(ByVal id As Integer) As BASEREUSE.Provincia Implements BASEREUSE.IGeoLocationLoader.GetProvinciaById
      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      Dim query As Query = ps.CreateNewQuery("MapperProvincia")
      query.SetTable("TB_PROVINCIE")
      Dim crit As AbstractBoolCriteria = Criteria.Equal("ID", id)
      query.AddWhereClause(crit)
      Dim l As IList = query.Execute(ps)
      If l.Count > 0 Then
         Return l(0)
      End If
      Return New ProvinciaNulla
   End Function

   Public Function GetNazionByFiscalCode(ByVal code As String) As BASEREUSE.Nazione Implements BASEREUSE.IGeoLocationLoader.GetNazionByFiscalCode
      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      Dim query As Query = ps.CreateNewQuery("MapperNazione")
      query.SetTable("TB_NAZIONI")
      Dim crit As AbstractBoolCriteria = Criteria.Equal("CODICE_CF", "'" & Replace(code, "'", "''") & "'")
      query.AddWhereClause(crit)
      Dim l As IList = query.Execute(ps)
      If l.Count > 0 Then
         Return l(0)
      End If
      Return New NazioneNulla
   End Function
End Class
