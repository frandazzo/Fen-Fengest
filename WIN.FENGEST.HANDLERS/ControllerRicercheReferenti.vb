Namespace FINANCIAL_ARTIFACTS
   Public Class ControllerRicercheReferenti
      Inherits AbstractControllerRicerche

      Protected m_Nome As String = ""
      Protected m_Cognome As String = ""
      


      Public Sub SetNome(ByVal Nome As String)
         m_Nome = Nome
      End Sub
      Public Sub SetCognome(ByVal Cognome As String)
         m_Cognome = Cognome
      End Sub
     
      Public Overrides Function Search() As IList
         'qui creo ed eseguo la query
         Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
         Dim query As Query = ps.CreateNewQuery("MapperReferente")
         Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)

         If m_Nome <> "" Then
            mainCriteria.AddCriteria(Criteria.Matches("NOME", m_Nome, ps.DBType))
         End If

         If m_Cognome <> "" Then
            mainCriteria.AddCriteria(Criteria.Matches("COGNOME", m_Cognome, ps.DBType))
         End If

         query.AddWhereClause(mainCriteria)

         Return query.Execute(ps)
      End Function
   End Class
End Namespace