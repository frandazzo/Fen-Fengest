Public Class InsertDelegaCommand
    Implements ICommand
    Private m_parameters As Hashtable
    Private m_delegaPagabile As Boolean
    Private m_range As DataRange
    Private m_inserted As Boolean = False
    ''' <summary>
    ''' Costruttore comando. Questo comando crea una delega e la pone nello stato di accettata se
    ''' la data di annullamento o la data revoca sono nulle. 
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: DATA, DATA_ACCETTAZIONE, DATA_ANNULLAMENTO, DATA_REVOCA, REVOCATA_A, 
    ''' SETTORE:-- "IMPIANTI FISSI", "EDILE" --, ENTE, NOME_UTENTE, COGNOME_UTENTE, DATA_NASCITA_UTENTE,
    ''' REPARTO, SEDE_OPERATIVA, NOTE, NOME_REFERENTE, COGNOME_REFERENTE</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As Hashtable, Optional ByVal VerificaDelegaPagabile As Boolean = False, Optional ByVal range As DataRange = Nothing)
        m_parameters = Parameters
        m_delegaPagabile = VerificaDelegaPagabile
        m_range = range
    End Sub


    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe
        Dim controllerSettore As New WIN.APPLICATION.ControllerSettori
        Dim ControllerReparto As New WIN.APPLICATION.ControllerReparti
        Dim ControllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti
        Dim ControllerAzienda As New WIN.APPLICATION.AZIENDE.ControllerAziende
        Dim ControllerReferente As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti

        Try
            If m_parameters.Item("NOTE") Is Nothing Then m_parameters.Item("NOTE") = ""
            ' controller.CreateNew()
            If m_parameters.Item("DATA_NASCITA_UTENTE") Is Nothing Then m_parameters.Item("DATA_NASCITA_UTENTE") = ""
            m_parameters.Item("DATA_NASCITA_UTENTE") = m_parameters.Item("DATA_NASCITA_UTENTE").ToString.Replace(" 0.00.00", "")

            If m_parameters.Item("NOME_UTENTE") Is Nothing Then m_parameters.Item("NOME_UTENTE") = ""
            If m_parameters.Item("COGNOME_UTENTE") Is Nothing Then m_parameters.Item("COGNOME_UTENTE") = ""
            If m_parameters.Item("FISCALE") Is Nothing Then m_parameters.Item("FISCALE") = ""
            If m_parameters.Item("PARTITA_IVA") Is Nothing Then m_parameters.Item("PARTITA_IVA") = ""


            Dim nome As String = m_parameters.Item("NOME_UTENTE")
            Dim cognome As String = m_parameters.Item("COGNOME_UTENTE")

            Dim id As String = -1

            id = UtenteRetriever.GetIdUtente(m_parameters.Item("FISCALE"), nome, cognome, m_parameters.Item("DATA_NASCITA_UTENTE"))

           

            If m_parameters.Item("NOME_REFERENTE") Is Nothing Then m_parameters.Item("NOME_REFERENTE") = ""
            If m_parameters.Item("COGNOME_REFERENTE") Is Nothing Then m_parameters.Item("COGNOME_REFERENTE") = ""
            Dim idRef As String
            idRef = ControllerReferente.GetIdReferente(m_parameters.Item("NOME_REFERENTE"), m_parameters.Item("COGNOME_REFERENTE"))

            Dim idente As String

            If m_parameters.Item("SETTORE") = "IMPIANTI FISSI" Then
                idente = AziendaRetriever.GetIdAzienda(m_parameters.Item("PARTITA_IVA"), m_parameters.Item("ENTE"))
            ElseIf m_parameters.Item("SETTORE") = "EDILE" Then
                idente = EnteRetriever.GetIdEnteForEdili(m_parameters.Item("ENTE"))
            Else
                idente = EnteRetriever.GetIdEnteForEdili("CASSA EDILE")
            End If

            Dim idCaus As String
            If m_parameters.Item("REVOCATA_A") Is Nothing Then m_parameters.Item("REVOCATA_A") = ""

            idCaus = CausaleRetriever.GetIdCausaleRevocaDelega(m_parameters.Item("REVOCATA_A"))

            If m_parameters.Item("SEDE_OPERATIVA") Is Nothing Then m_parameters.Item("SEDE_OPERATIVA") = ""


            m_parameters.Item("DATA") = m_parameters.Item("DATA").ToString.Replace(" 0.00.00", "")
          


            If m_delegaPagabile Then

                If Not controller.VerificaDelegaPagabile(id, controllerSettore.GetIdSettoreByDescrizione(m_parameters.Item("SETTORE")), idente, m_range.Start, m_range.Finish) Then
                    controller.CreateNew(DateTime.Parse(m_parameters.Item("DATA")), DateTime.Parse(m_parameters.Item("DATA")), m_parameters.Item("NOTE"), _
                                                      id, idRef, idente, controllerSettore.GetIdSettoreByDescrizione(m_parameters.Item("SETTORE")), _
                                                      ControllerReparto.GetIdByDescrizione(m_parameters.Item("REPARTO")), idCaus, idRef, m_parameters.Item("SEDE_OPERATIVA"))
                    controller.DataImportazione = DateTime.Now.Date
                    controller.Save()
                    m_parameters.Add("Controller", controller)
                    Dim chain1 As New RevokeDelegaChain(New CancelDelegaChain(New AcceptDelegaChain(New SubscribeDelegaChain)))
                    chain1.Action(m_parameters)
                    m_inserted = True
                    Return
                End If
                Return

            End If

            controller.CreateNew(DateTime.Parse(m_parameters.Item("DATA")), DateTime.Parse(m_parameters.Item("DATA")), m_parameters.Item("NOTE"), _
                                              id, idRef, idente, controllerSettore.GetIdSettoreByDescrizione(m_parameters.Item("SETTORE")), _
                                              ControllerReparto.GetIdByDescrizione(m_parameters.Item("REPARTO")), idCaus, idRef, m_parameters.Item("SEDE_OPERATIVA"))
            controller.DataImportazione = DateTime.Now.Date
            controller.Save()
            m_parameters.Add("Controller", controller)
            Dim chain As New RevokeDelegaChain(New CancelDelegaChain(New AcceptDelegaChain(New SubscribeDelegaChain)))
            chain.Action(m_parameters)
            m_inserted = True
           
        Catch ex As Exception
            Throw New ImportDelegaException(ex.Message, m_parameters.Item("NOME_UTENTE"), m_parameters.Item("COGNOME_UTENTE"), m_parameters.Item("ENTE"))
        End Try
    End Sub

    Public ReadOnly Property Inserted() As Boolean
        Get
            Return m_inserted
        End Get
    End Property


End Class
