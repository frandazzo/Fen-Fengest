Public Class ReportToListaLavoroConverter

    Public Function CreaListaDaReportIQ(ByVal lista As IList)
        Dim controller As New ControllerListaUtenti
        controller.CreateNew()

        For Each elem As Quota In lista
            controller.AddUtente(elem.IdUtente)
        Next


        Return controller.Current
    End Function

    Public Function CreaListaDaReportDeleghe(ByVal lista As IList)
        Dim controller As New ControllerListaUtenti
        controller.CreateNew()

        For Each elem As DelegadTO In lista
            controller.AddUtente(elem.IdUtente)
        Next


        Return controller.Current
    End Function


    Public Function CreaListaDaReportIscritti(ByVal lista As IList)
        Dim controller As New ControllerListaUtenti
        controller.CreateNew()

        For Each elem As IscrittoDTO In lista
            controller.AddUtente(elem.Id_Utente)
        Next


        Return controller.Current
    End Function

    Public Function CreaListaDaReportNonIscritti(ByVal lista As IList)
        Dim controller As New ControllerListaUtenti
        controller.CreateNew()

        For Each elem As NonIscrittoDTO In lista
            controller.AddUtente(elem.Id_Utente)
        Next


        Return controller.Current


    End Function


End Class
