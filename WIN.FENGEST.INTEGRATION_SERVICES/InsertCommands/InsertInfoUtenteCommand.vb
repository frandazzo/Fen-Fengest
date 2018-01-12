Public Class InsertInfoUtenteCommand
    Implements ICommand
    Private m_parameters As Hashtable
    ''' <summary>
    ''' Costruttore comando. Questo comando crea una delega e la pone nello stato di accettata se
    ''' la data di annullamento o la data revoca sono nulle. 
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: DATA, DATA_IMPORTAZIONE, 
    ''' ENTE: -- "CASSA EDILE", "EDILCASSA" -- ,
    ''' NOME_UTENTE, COGNOME_UTENTE, DATA_NASCITA_UTENTE, LIVELLO,
    ''' AZIENDA_IMPIEGO, PARTITA_IVA
    ''' </param>
    ''' <remarks></remarks>


    Private m_overwrite As Boolean
    Public Sub New(ByVal Parameters As Hashtable, ByVal overwrite As Boolean)
        m_parameters = Parameters
        m_overwrite = overwrite
    End Sub
    Public Sub Execute() Implements ICommand.Execute
        Dim ControllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti(True)
        Dim ControllerAzienda As New WIN.APPLICATION.AZIENDE.ControllerAziende

        Try


            If m_parameters.Item("DATA_NASCITA_UTENTE") Is Nothing Then m_parameters.Item("DATA_NASCITA_UTENTE") = ""
            'tolgo eventuali orari in formato invariant culture derivanti da file excel o xml
            m_parameters.Item("DATA_NASCITA_UTENTE") = m_parameters.Item("DATA_NASCITA_UTENTE").ToString().Replace(" 0.00.00", "")



            If m_parameters.Item("DATA") Is Nothing Then m_parameters.Item("DATA") = ""
            'tolgo eventuali orari in formato invariant culture derivanti da file excel o xml
            m_parameters.Item("DATA") = m_parameters.Item("DATA").ToString().Replace(" 0.00.00", "")


            If m_parameters.Item("NOME_UTENTE") Is Nothing Then m_parameters.Item("NOME_UTENTE") = ""
            If m_parameters.Item("COGNOME_UTENTE") Is Nothing Then m_parameters.Item("COGNOME_UTENTE") = ""
            If m_parameters.Item("LIVELLO") Is Nothing Then m_parameters.Item("LIVELLO") = ""
            If m_parameters.Item("FISCALE") Is Nothing Then m_parameters.Item("FISCALE") = ""
            If m_parameters.Item("PARTITA_IVA") Is Nothing Then m_parameters.Item("PARTITA_IVA") = ""
            If m_parameters.Item("ISCRITTO_A") Is Nothing Then m_parameters.Item("ISCRITTO_A") = ""



            Dim nome As String = m_parameters.Item("NOME_UTENTE")
            Dim cognome As String = m_parameters.Item("COGNOME_UTENTE")

            'Dim id As String


            'id = ControllerUtente.GetIdUtente(m_parameters.Item("FISCALE"))

            'If id = -1 Then

            '   If IsDate(m_parameters.Item("DATA_NASCITA_UTENTE")) Then

            '      id = ControllerUtente.GetIdUtente(nome, cognome, CDate(m_parameters.Item("DATA_NASCITA_UTENTE")))

            '      If id = -1 Then
            '         id = ControllerUtente.GetIdUtente(nome, cognome)
            '      End If

            '   Else
            '      id = ControllerUtente.GetIdUtente(nome, cognome)
            '   End If

            'End If

            Dim id As String = -1

            id = UtenteRetriever.GetIdUtente(m_parameters.Item("FISCALE"), nome, cognome, m_parameters.Item("DATA_NASCITA_UTENTE"))


            If id = -1 Then
                Throw New Exception("Utente non trovato")
            End If



            If Not IsDate(m_parameters.Item("DATA")) Then
                Throw New Exception("Data non trovata o non valida")
            End If



            Dim idente As String = EnteRetriever.GetIdEnteForEdili(m_parameters.Item("ENTE"))
            'If m_parameters.Item("ENTE") = "CASSA EDILE" Then
            '   idente = 1
            'ElseIf m_parameters.Item("ENTE") = "EDILCASSA" Then
            '   idente = 2
            'Else
            '   Throw New Exception("Ente non definito: utilizzare le descrizioni --CASSA EDILE oppure EDILCASSA--)")
            'End If


            Dim nomeAz As String = m_parameters.Item("AZIENDA_IMPIEGO")
            Dim part As String = m_parameters.Item("PARTITA_IVA").ToString

            Dim idAz As Int32 = -1
            'If part <> "" Then
            '   idAz = ControllerAzienda.GetIdAziendaByPIVA(part)
            'End If
            'If idAz = -1 Then
            '   idAz = ControllerAzienda.GetIdAzienda(nomeAz, part)
            'End If
            'If idAz = -1 Then
            '   idAz = ControllerAzienda.GetIdAzienda(nomeAz)
            'End If
            idAz = AziendaRetriever.GetIdAzienda(part, nomeAz)

            If idAz = -1 Then
                Throw New Exception("Azienda di impiego non valida")
            End If


            ControllerUtente.LoadById(id)

            ControllerUtente.AddInfo(idAz, idente, CDate(m_parameters.Item("DATA")), m_parameters.Item("LIVELLO").ToString, DateTime.Now, m_parameters.Item("ISCRITTO_A"), m_overwrite)

            ControllerUtente.Save()

        Catch ex As Exception
            Throw New ImportInfoUtenteException(ex.Message, m_parameters.Item("NOME_UTENTE"), m_parameters.Item("COGNOME_UTENTE"), m_parameters.Item("ENTE"))
        End Try
    End Sub
End Class
