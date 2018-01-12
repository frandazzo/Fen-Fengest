Imports System.ComponentModel

Public Class ControllerPratiche

    Public Function GetPraticaById(id As Int32) As Pratica
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        Return ps.GetObject("Pratica", id)

    End Function

    Public Function GetPraticheByUtente(idUtente As Int32) As IBindingList
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        Dim query As Query = ps.CreateNewQuery("MapperPratica")

        Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
        mainCriteria.AddCriteria(Criteria.Equal("UserId", idUtente))

        query.AddWhereClause(mainCriteria)

        Dim result As IList = query.Execute(ps)

        Dim r As BindingList(Of Pratica) = New BindingList(Of Pratica)

        For Each elem As Pratica In result
            r.Add(elem)
        Next

        Return r

    End Function

    Public Sub SaveOrUpdatePratica(pratica As Pratica)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        If pratica.Key Is Nothing Then
            'nuova pratica
            ps.InsertObject("Pratica", pratica)

        Else
            'altrimentoi devo verificare i campi che sto modificando
            'recupero l'oggetto dal db
            Dim old As Pratica = GetPraticaById(pratica.Id)
            'una volta ottenuta la vecchia pratica posso confrontate le proprieta che on posso cambiare
            'e se sono cambiate verifico che si possa fare altirmenti lancio una eccezione
            If pratica.Utente Is Nothing Then
                Throw New InvalidOperationException("L'utente non può essere cambiato")
            End If
            If pratica.Utente.Id <> old.Utente.Id Then
                Throw New InvalidOperationException("L'utente non può essere cambiato")
            End If
            If pratica.TipoPratica Is Nothing Then
                Throw New InvalidOperationException("Il tipo pratica non può essere cambiato")
            End If
            If pratica.TipoPratica.Id <> old.TipoPratica.Id Then
                Throw New InvalidOperationException("Il tipo pratica non può essere cambiato")
            End If


            ps.UpdateObject("Pratica", pratica)


        End If



    End Sub


    Public Sub ControlPratica(pratica As Pratica, data As StateData)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        pratica.State.ControlDocumentation(data, pratica)

        ps.UpdateObject("Pratica", pratica)

    End Sub

    Public Sub ConfirmPratica(pratica As Pratica, data As StateData)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        pratica.State.ConfirmDocumentation(data, pratica)

        ps.UpdateObject("Pratica", pratica)

    End Sub

    Public Sub ClosePratica(pratica As Pratica, data As StateData)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        pratica.State.ClosePractice(data, pratica)

        ps.UpdateObject("Pratica", pratica)

    End Sub

    Public Sub RejectPratica(pratica As Pratica, data As StateData)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        pratica.State.RejectPractice(data, pratica)

        ps.UpdateObject("Pratica", pratica)

    End Sub

    Public Sub IntegratePratica(pratica As Pratica, data As StateData)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        pratica.State.IntegrateDocumentation(data, pratica)

        ps.UpdateObject("Pratica", pratica)

    End Sub

   

    Public Sub DeletePratica(pratica As Pratica)
        Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

        ps.DeleteObject("Pratica", pratica)


    End Sub

End Class
