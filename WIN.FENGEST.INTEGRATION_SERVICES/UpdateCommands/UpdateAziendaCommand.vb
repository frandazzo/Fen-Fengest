Public Class UpdateAziendaCommand
    Implements ICommand
    Private m_parameters As Hashtable
    Private m_id As String = "-1"
    ''' <summary>
    ''' Costruttore comando
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: ENTE, PARTITA_IVA, Contratto</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As Hashtable, ByVal IdAzienda As String)
        m_parameters = Parameters
        m_id = IdAzienda
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.AZIENDE.ControllerAziende(True)
        Dim controllerContratti As New ControllerTipoContratto
        Try


            If m_id = "-1" Or m_id = "" Then
                Return
            End If




            controller.LoadById(m_id)
            

            If m_parameters.Item("CODICE_CE_AZIENDA") Is Nothing Then m_parameters.Item("CODICE_CE_AZIENDA") = ""
            If m_parameters.Item("CODICE_EC_AZIENDA") Is Nothing Then m_parameters.Item("CODICE_EC_AZIENDA") = ""
            If m_parameters.Item("NOTE_AZIENDA") Is Nothing Then m_parameters.Item("NOTE_AZIENDA") = ""
            If m_parameters.Item("COMUNE_AZIENDA") Is Nothing Then m_parameters.Item("COMUNE_AZIENDA") = ""
            If m_parameters.Item("INDIRIZZO_AZIENDA") Is Nothing Then m_parameters.Item("INDIRIZZO_AZIENDA") = ""
            If m_parameters.Item("CAP_AZIENDA") Is Nothing Then m_parameters.Item("CAP_AZIENDA") = ""
            If m_parameters.Item("TELEFONO_AZIENDA") Is Nothing Then m_parameters.Item("TELEFONO_AZIENDA") = ""





           

            




            'If m_parameters.Item("PROVINCIA_NASCITA") Is Nothing Then m_parameters.Item("PROVINCIA_NASCITA") = ""
            Dim NomCom As String = m_parameters.Item("COMUNE_AZIENDA").ToString

            controller.ChangeIndirizzoSedeLegaleIfNew(m_parameters.Item("INDIRIZZO_AZIENDA").ToString, GeoLocationFacade.Instance.GetNomeProvinciaByNomeComune(NomCom), NomCom, m_parameters.Item("CAP_AZIENDA").ToString)
            controller.ChangeComunicazioneIfNew(m_parameters.Item("TELEFONO_AZIENDA").ToString, "", "", "", "")


            If m_parameters.Item("CONTRATTO").ToString <> "" Then
                controller.SetContrattoApplicato(controllerContratti.GetIdTipoContrattoByDescrizione(m_parameters.Item("CONTRATTO")))
            End If

            If m_parameters.Item("NOTE_AZIENDA").ToString <> "" Then
                If controller.Note = "" Then
                    controller.Note = m_parameters.Item("NOTE_AZIENDA").ToString
                End If
            End If

            If m_parameters.Item("CODICE_CE_AZIENDA").ToString <> "" Then
                controller.CodiceCE = m_parameters.Item("CODICE_CE_AZIENDA").ToString
            End If
            If m_parameters.Item("CODICE_EC_AZIENDA").ToString <> "" Then
                controller.CodiceEC = m_parameters.Item("CODICE_EC_AZIENDA").ToString
            End If

            'controller.AddSedeOperativa(m_parameters.Item("SedeOperativa"), "", "", "")
            controller.Save()
        Catch ex As Exception

            Dim az As String = ""

            If m_parameters.Contains("AZIENDA_IMPIEGO").ToString Then
                az = m_parameters.Item("AZIENDA_IMPIEGO").ToString
            Else
                If m_parameters.Contains("ENTE").ToString Then
                    az = m_parameters.Item("ENTE").ToString
                End If
            End If


            If String.IsNullOrEmpty(az) Then
                az = ""
            End If

            Throw New ImportAziendaException(ex.Message, az, m_parameters.Item("PARTITA_IVA").ToString)
        End Try
    End Sub
End Class
