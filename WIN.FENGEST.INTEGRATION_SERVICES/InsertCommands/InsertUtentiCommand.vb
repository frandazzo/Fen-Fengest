Public Class InsertUtentiCommand
    Implements ICommand
    Private m_parameters As Hashtable
    ''' <summary>
    ''' Costruttore comando
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: NOME_UTENTE,FISCALE,  COGNOME_UTENTE, DATA_NASCTA_UTENTE,  
    ''' COMUNE_NASCITA,PROVINCIA_NASCITA,  INDIRIZZO, COMUNE, PROVINCIA, TELEFONO1, TELEFONO2</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As Hashtable)
        m_parameters = Parameters
    End Sub
    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.UTENTI.ControllerUtenti(True)
        Try

           

            m_parameters.Item("DATA_NASCITA_UTENTE") = m_parameters.Item("DATA_NASCITA_UTENTE").ToString.Replace(" 0.00.00", "")

            controller.CreateNew()
            If m_parameters.Item("NOME_UTENTE") Is Nothing Then m_parameters.Item("NOME_UTENTE") = ""
            controller.Nome = m_parameters.Item("NOME_UTENTE")
            If m_parameters.Item("FISCALE") Is Nothing Then m_parameters.Item("FISCALE") = ""
            controller.CodiceFiscale = m_parameters.Item("FISCALE")
            If m_parameters.Item("COGNOME_UTENTE") Is Nothing Then m_parameters.Item("COGNOME_UTENTE") = ""
            controller.Cognome = m_parameters.Item("COGNOME_UTENTE")
            If m_parameters.Item("DATA_NASCITA_UTENTE") Is Nothing Then m_parameters.Item("DATA_NASCITA_UTENTE") = ""

            If IsDate(m_parameters.Item("DATA_NASCITA_UTENTE")) Then
                controller.DataNascita = DateTime.Parse(m_parameters.Item("DATA_NASCITA_UTENTE"))
            End If

            If m_parameters.Item("COMUNE_NASCITA") Is Nothing Then m_parameters.Item("COMUNE_NASCITA") = ""
            controller.SetNazionalita(m_parameters.Item("COMUNE_NASCITA"))
            controller.SetComuneNascita(m_parameters.Item("COMUNE_NASCITA"))
            'If m_parameters.Item("PROVINCIA_NASCITA") Is Nothing Then m_parameters.Item("PROVINCIA_NASCITA") = ""
            Dim NomCom As String = controller.ComuneNascita
            If controller.Nazionalita = "" Then
                controller.SetNazionalita("ITALIA")
            End If
            controller.SetProvinciaNascita(GeoLocationFacade.Instance.GetNomeProvinciaByNomeComune(NomCom))



            'adesso verifico se devo creare un utente mettendogli un cf fittizio
            'Nuova Caledonia (isole E Dipendenze)
            If m_parameters.ContainsKey("CALCOLACFFITTIZIO") Then
                'procedo se non esiste codice fiscale
                If String.IsNullOrEmpty(controller.CodiceFiscale) Then

                    'poiche' il cf è nullo procedo al calcolo
                    'per decisione con la feneal nazionale a tutti verra data la nazionalità della nuova caledonia
                    controller.SetNazionalita("Nuova Caledonia (isole E Dipendenze)")
                    controller.SetComuneNascita("")
                    controller.SetProvinciaNascita("")

                    'adesso calcolo i l codice fiscale
                    controller.CodiceFiscale = GeoLocationFacade.Instance.CalcolaCodiceFiscale(controller.Nome, controller.Cognome, "MASCHIO", controller.DataNascita, "", "Nuova Caledonia (isole E Dipendenze)")


                End If
            End If




            If m_parameters.Item("INDIRIZZO") Is Nothing Then m_parameters.Item("INDIRIZZO") = ""
            If m_parameters.Item("CAP") Is Nothing Then m_parameters.Item("CAP") = ""
            If m_parameters.Item("PROVINCIA") Is Nothing Then m_parameters.Item("PROVINCIA") = ""
            If m_parameters.Item("COMUNE") Is Nothing Then m_parameters.Item("COMUNE") = ""
            If m_parameters.Item("TELEFONO1") Is Nothing Then m_parameters.Item("TELEFONO1") = ""
            If m_parameters.Item("TELEFONO2") Is Nothing Then m_parameters.Item("TELEFONO2") = ""

            If m_parameters.Item("CODICE_CE_UTENTE") Is Nothing Then m_parameters.Item("CODICE_CE_UTENTE") = ""
            If m_parameters.Item("CODICE_EC_UTENTE") Is Nothing Then m_parameters.Item("CODICE_EC_UTENTE") = ""
            If m_parameters.Item("NOTE_UTENTE") Is Nothing Then m_parameters.Item("NOTE_UTENTE") = ""



            controller.Note = m_parameters.Item("NOTE_UTENTE").ToString
            controller.CodificaCE = m_parameters.Item("CODICE_CE_UTENTE").ToString
            controller.CodificaEC = m_parameters.Item("CODICE_EC_UTENTE").ToString



            NomCom = m_parameters.Item("COMUNE")
            m_parameters.Item("PROVINCIA") = GeoLocationFacade.Instance.GetNomeProvinciaByNomeComune(NomCom)

            controller.SetResidenza(m_parameters.Item("INDIRIZZO"), m_parameters.Item("PROVINCIA"), m_parameters.Item("COMUNE"), m_parameters.Item("CAP"))
            controller.SetComunicazione("", "", "", "", m_parameters.Item("TELEFONO1").ToString, m_parameters.Item("TELEFONO2").ToString)
            controller.Save()
        Catch ex As Exception
            Throw New ImportUtenteException(ex.Message, m_parameters.Item("NOME_UTENTE"), m_parameters.Item("COGNOME_UTENTE"), m_parameters.Item("DATA_NASCITA_UTENTE").ToString)
        End Try
    End Sub
End Class
