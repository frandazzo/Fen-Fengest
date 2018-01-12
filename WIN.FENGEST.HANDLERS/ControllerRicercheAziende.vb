Namespace AZIENDE
   Public Class ControllerRicercheAziende
      Inherits AbstractControllerRicerche
      Private controllerContratti As New ControllerTipoContratto



      Protected m_RagSoc As String = ""
      Protected m_Provincia As String = "-1"
      Protected m_Comune As String = "-1"
      Protected m_Contratto As String = "-1"


      Public Sub SetRagioneSociale(ByVal RagioneSociale As String)
         m_RagSoc = RagioneSociale
      End Sub

      Public Sub SetContratto(ByVal NomeContratto As String)
         m_Contratto = controllerContratti.GetIdTipoContrattoByDescrizione(NomeContratto)
      End Sub

      Public Sub SetProvincia(ByVal NomeProvincia As String)
            Dim Provincia As Provincia = GeoLocationFacade.Instance.GetGeoHandler.GetProvinciaByName(NomeProvincia)
            m_Provincia = Provincia.Id
        End Sub

        Public Sub SetComune(ByVal NomeComune As String)
            Dim Comune As Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
            m_Comune = Comune.Id
        End Sub

      Public Overrides Function Search() As IList
         'qui creo ed eseguo la query
         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperAzienda")

         query.SetTable("DB_Azienda")
         query.SetMaxNumberOfReturnedRecords(m_Top)

         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

         If m_RagSoc <> "" Then
            mainCriteria.AddCriteria(Criteria.Matches("DESCRIZIONE", m_RagSoc, ps.DBType))
         End If

         If m_Contratto <> "-1" Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_TIPO_CONTRATTO", m_Contratto))
         End If

         If m_Provincia <> "-1" Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_TB_PROVINCIE", m_Provincia))
         End If

         If m_Comune <> "-1" Then
            mainCriteria.AddCriteria(Criteria.Equal("ID_TB_COMUNI", m_Comune))
         End If

         Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
         orderCriteria.AddCriteria(Criteria.SortCriteria("DESCRIZIONE", True))

         query.AddWhereClause(mainCriteria)
         query.AddOrderByClause(orderCriteria)


         Return query.Execute(ps)
      End Function
   End Class
End Namespace