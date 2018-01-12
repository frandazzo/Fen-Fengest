Imports System.ComponentModel

Public Class ControllerCantiere

    Public Function GetCantiereById(id As Int32) As Cantiere
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        Return ps.GetObject("Cantiere", id)

    End Function


    Public Function GetCantieriAllaData(datemin As DateTime, datemax As DateTime) As IBindingList
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        Dim query As Query = ps.CreateNewQuery("MapperCantiere")

        Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
        mainCriteria.AddCriteria(Criteria.DateContained("DataFine", datemin, datemax, ps.DBType))

        query.AddWhereClause(mainCriteria)

        Dim result As IList = query.Execute(ps)

        Dim r As BindingList(Of Cantiere) = New BindingList(Of Cantiere)

        For Each elem As Cantiere In result
            r.Add(elem)
        Next

        Return r

    End Function

    Public Function GetCantieriByAzienda(idAzienda As Int32) As IBindingList
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        Dim query As Query = ps.CreateNewQuery("MapperCantiere")

        Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
        mainCriteria.AddCriteria(Criteria.Equal("Id_Azienda", idAzienda))

        query.AddWhereClause(mainCriteria)

        Dim result As IList = query.Execute(ps)

        Dim r As BindingList(Of Cantiere) = New BindingList(Of Cantiere)

        For Each elem As Cantiere In result
            r.Add(elem)
        Next

        Return r

    End Function

    Public Sub SaveOrUpdateCantiere(pratica As Cantiere)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        If pratica.Key Is Nothing Then
            'nuova pratica
            ps.InsertObject("Cantiere", pratica)

        Else
            'altrimentoi devo verificare i campi che sto modificando
            'recupero l'oggetto dal db
            Dim old As Cantiere = GetCantiereById(pratica.Id)
            'una volta ottenuta la vecchia pratica posso confrontate le proprieta che on posso cambiare
            'e se sono cambiate verifico che si possa fare altirmenti lancio una eccezione
           
            If pratica.IdAzienda <> old.IdAzienda Then
                Throw New InvalidOperationException("L'azienda non può essere cambiata")
            End If
          


            ps.UpdateObject("Cantiere", pratica)


        End If



    End Sub



  


    Public Sub DeleteCantiere(pratica As Cantiere)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        ps.DeleteObject("Cantiere", pratica)


    End Sub

End Class


