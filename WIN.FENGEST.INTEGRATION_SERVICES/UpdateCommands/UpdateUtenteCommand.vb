Public Class UpdateUtenteCommand
    Implements ICommand
    Private m_parameters As Hashtable
    Private m_Id As String = "-1"
    Private m_changeComunicazione As Boolean

    Public Sub New(ByVal parameters As Hashtable, ByVal idUtente As String, Optional changeComunicazione As Boolean = False)
        m_Id = idUtente
        m_parameters = parameters
        m_changeComunicazione = changeComunicazione
    End Sub


    Public Sub Execute() Implements BASEREUSE.ICommand.Execute
        Dim controller As New WIN.APPLICATION.UTENTI.ControllerUtenti(True)
        Try

            If m_Id = "-1" Or m_Id = "" Then
                Return
            End If

            controller.LoadById(m_Id)


            If m_parameters.Item("COMUNE_NASCITA") Is Nothing Then m_parameters.Item("COMUNE_NASCITA") = ""
            'se esiste il comune lo inserisco o come comune o come nazione

            If GeoLocationFacade.Instance.ExistNazione(m_parameters.Item("COMUNE_NASCITA")) Then
                controller.SetNazionalita(m_parameters.Item("COMUNE_NASCITA"))
                controller.SetComuneNascita("")
                controller.SetProvinciaNascita("")
            End If


            If GeoLocationFacade.Instance.ExistComune(m_parameters.Item("COMUNE_NASCITA")) Then
                controller.SetComuneNascita(m_parameters.Item("COMUNE_NASCITA"))

                controller.SetProvinciaNascita(GeoLocationFacade.Instance.GetNomeProvinciaByNomeComune(m_parameters.Item("COMUNE_NASCITA")))
                If controller.Nazionalita = "" Then
                    controller.SetNazionalita("ITALIA")
                End If
            End If








            If m_parameters.Item("INDIRIZZO") Is Nothing Then m_parameters.Item("INDIRIZZO") = ""
            If m_parameters.Item("CAP") Is Nothing Then m_parameters.Item("CAP") = ""
            If m_parameters.Item("PROVINCIA") Is Nothing Then m_parameters.Item("PROVINCIA") = ""
            If m_parameters.Item("COMUNE") Is Nothing Then m_parameters.Item("COMUNE") = ""

          

            If m_parameters.Item("CODICE_CE_UTENTE") Is Nothing Then m_parameters.Item("CODICE_CE_UTENTE") = ""
            If m_parameters.Item("CODICE_EC_UTENTE") Is Nothing Then m_parameters.Item("CODICE_EC_UTENTE") = ""
            If m_parameters.Item("NOTE_UTENTE") Is Nothing Then m_parameters.Item("NOTE_UTENTE") = ""




            controller.CodificaCE = m_parameters.Item("CODICE_CE_UTENTE").ToString
            controller.CodificaEC = m_parameters.Item("CODICE_EC_UTENTE").ToString


            Dim NomCom As String
            NomCom = m_parameters.Item("COMUNE")
            m_parameters.Item("PROVINCIA") = GeoLocationFacade.Instance.GetNomeProvinciaByNomeComune(NomCom)

            controller.ChangeResidenzaIfNew(m_parameters.Item("INDIRIZZO"), m_parameters.Item("PROVINCIA"), m_parameters.Item("COMUNE"), m_parameters.Item("CAP").ToString)

            If m_changeComunicazione Then
                If m_parameters.Item("TELEFONO1") Is Nothing Then m_parameters.Item("TELEFONO1") = ""
                If m_parameters.Item("TELEFONO2") Is Nothing Then m_parameters.Item("TELEFONO2") = ""
                controller.ChangeComunicazioneIfNew("", "", "", "", m_parameters.Item("TELEFONO1").ToString, m_parameters.Item("TELEFONO2").ToString)
            End If


            '


            If m_parameters.Item("NOTE_UTENTE") <> "" Then
                If controller.Note = "" Then
                    controller.Note = m_parameters.Item("NOTE_UTENTE")
                End If
            End If



            controller.Save()
        Catch ex As Exception
            Throw New ImportUtenteException(ex.Message, m_parameters.Item("NOME_UTENTE"), m_parameters.Item("COGNOME_UTENTE"), m_parameters.Item("DATA_NASCITA_UTENTE").ToString)
        End Try
    End Sub
End Class
