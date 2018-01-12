Imports WIN.APPLICATION.ADMINISTRATION

Public Class RevokeDelegaCommand
    Implements ICommand
    Private m_parameters As Hashtable
    Private m_AddDelegaifNotExist As Boolean
    Private m_revokeAll As Boolean
    Private m_inserted As Boolean = False
    ''' <summary>
    ''' Costruttore comando. Questo comando revoca una delega attiva o accettata se esiste
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: DATA_REVOCA, REVOCATA_DA, 
    ''' SETTORE:-- "EDILE" --, ENTE, NOME_UTENTE, COGNOME_UTENTE, DATA_NASCITA_UTENTE,
    '''</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As Hashtable, Optional ByVal AddDelegaifNotExist As Boolean = False, Optional ByVal revokeAll As Boolean = False)
        m_parameters = Parameters
        m_AddDelegaifNotExist = AddDelegaifNotExist
        m_revokeAll = revokeAll
    End Sub


    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe
        Dim controllerSettore As New WIN.APPLICATION.ControllerSettori
        Dim ControllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti

        'Dim ControllerReferente As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti

        Try

            ' controller.CreateNew()
            If m_parameters.Item("DATA_NASCITA_UTENTE") Is Nothing Then m_parameters.Item("DATA_NASCITA_UTENTE") = ""
            m_parameters.Item("DATA_NASCITA_UTENTE") = m_parameters.Item("DATA_NASCITA_UTENTE").ToString.Replace(" 0.00.00", "")

            If m_parameters.Item("NOME_UTENTE") Is Nothing Then m_parameters.Item("NOME_UTENTE") = ""
            If m_parameters.Item("COGNOME_UTENTE") Is Nothing Then m_parameters.Item("COGNOME_UTENTE") = ""
            If m_parameters.Item("FISCALE") Is Nothing Then m_parameters.Item("FISCALE") = ""



            'prendo l'identificativo dell'utente
            Dim nome As String = m_parameters.Item("NOME_UTENTE")
            Dim cognome As String = m_parameters.Item("COGNOME_UTENTE")

            Dim id As String = -1
            id = UtenteRetriever.GetIdUtente(m_parameters.Item("FISCALE"), nome, cognome, m_parameters.Item("DATA_NASCITA_UTENTE"))



            'prendo l'identificativo dell'ente
            Dim idente As String

            If m_parameters.Item("ENTE") IsNot Nothing Then
                idente = EnteRetriever.GetIdEnteForEdili(m_parameters.Item("ENTE"))
            Else
                idente = EnteRetriever.GetIdEnteForEdili("CASSA EDILE")
            End If


            'verifico la causale della revoca
            Dim idCaus As String
            If m_parameters.Item("REVOCATA_DA") Is Nothing Then m_parameters.Item("REVOCATA_DA") = ""
            idCaus = CausaleRetriever.SearchIdCausaleRevocaDelega(m_parameters.Item("REVOCATA_DA"))

            m_parameters.Item("DATA_REVOCA") = m_parameters.Item("DATA_REVOCA").ToString.Replace(" 0.00.00", "")

            'verifico la data revoca
            If m_parameters.Item("DATA_REVOCA") Is Nothing Then
                m_parameters.Item("DATA_REVOCA") = DateTime.Now
            End If
            Dim datarevoca As DateTime = DateTime.Now

            Try
                datarevoca = CDate(m_parameters.Item("DATA_REVOCA"))
            Catch ex As Exception
                datarevoca = DateTime.Now
            End Try




            m_inserted = ControllerDeleghe.RevocaDelegaEdileUtente(id, idente, idCaus, datarevoca, m_AddDelegaifNotExist, m_revokeAll)


            'If m_delegaPagabile Then

            '    If Not controller.VerificaDelegaPagabile(id, controllerSettore.GetIdSettoreByDescrizione(m_parameters.Item("SETTORE")), idente, m_range.Start, m_range.Finish) Then
            '        controller.CreateNew(CDate(m_parameters.Item("DATA")), CDate(m_parameters.Item("DATA")), m_parameters.Item("NOTE"), _
            '                                          id, idRef, idente, controllerSettore.GetIdSettoreByDescrizione(m_parameters.Item("SETTORE")), _
            '                                          ControllerReparto.GetIdByDescrizione(m_parameters.Item("REPARTO")), idCaus, idRef, m_parameters.Item("SEDE_OPERATIVA"))
            '        controller.DataImportazione = DateTime.Now.Date
            '        controller.Save()
            '        m_parameters.Add("Controller", controller)
            '        Dim chain1 As New RevokeDelegaChain(New CancelDelegaChain(New AcceptDelegaChain(New SubscribeDelegaChain)))
            '        chain1.Action(m_parameters)
            '        m_inserted = True
            '        Return
            '    End If
            '    Return

            'End If

            'controller.CreateNew(CDate(m_parameters.Item("DATA")), CDate(m_parameters.Item("DATA")), m_parameters.Item("NOTE"), _
            '                                  id, idRef, idente, controllerSettore.GetIdSettoreByDescrizione(m_parameters.Item("SETTORE")), _
            '                                  ControllerReparto.GetIdByDescrizione(m_parameters.Item("REPARTO")), idCaus, idRef, m_parameters.Item("SEDE_OPERATIVA"))
            'controller.DataImportazione = DateTime.Now.Date
            'controller.Save()
            'm_parameters.Add("Controller", controller)
            'Dim chain As New RevokeDelegaChain(New CancelDelegaChain(New AcceptDelegaChain(New SubscribeDelegaChain)))
            'chain.Action(m_parameters)
            'm_inserted = True

        Catch ex As Exception
            Throw New ImportRevocaDelegaException(ex.Message, m_parameters.Item("NOME_UTENTE"), m_parameters.Item("COGNOME_UTENTE"), m_parameters.Item("ENTE"))
        End Try
    End Sub

    Public ReadOnly Property Inserted() As Boolean
        Get
            Return m_inserted
        End Get
    End Property


End Class
