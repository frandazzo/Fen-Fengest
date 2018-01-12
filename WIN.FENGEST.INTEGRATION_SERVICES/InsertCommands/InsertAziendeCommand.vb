Imports WIN.BASEREUSE

Public Class InsertAziendeCommand
    Implements ICommand
    Private m_parameters As Hashtable
    Private m_impiego As Boolean = False
    ''' <summary>
    ''' Costruttore comando
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: ENTE, PARTITA_IVA, Contratto</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As Hashtable, Optional ByVal Impiego As Boolean = False)
        m_parameters = Parameters
        m_impiego = Impiego
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.AZIENDE.ControllerAziende(True)
        Dim controllerContratti As New ControllerTipoContratto
        Try
            controller.CreateNew()
            If m_impiego Then
                controller.Descrizione = m_parameters.Item("AZIENDA_IMPIEGO")
            Else
                controller.Descrizione = m_parameters.Item("ENTE")
            End If
            If m_parameters.Item("PARTITA_IVA") Is Nothing Then m_parameters.Item("PARTITA_IVA") = ""
            controller.PartitaIva = m_parameters.Item("PARTITA_IVA").ToString

            If m_parameters.Item("CODICE_CE_AZIENDA") Is Nothing Then m_parameters.Item("CODICE_CE_AZIENDA") = ""
            If m_parameters.Item("CODICE_EC_AZIENDA") Is Nothing Then m_parameters.Item("CODICE_EC_AZIENDA") = ""
            If m_parameters.Item("NOTE_AZIENDA") Is Nothing Then m_parameters.Item("NOTE_AZIENDA") = ""
            If m_parameters.Item("COMUNE_AZIENDA") Is Nothing Then m_parameters.Item("COMUNE_AZIENDA") = ""
            If m_parameters.Item("INDIRIZZO_AZIENDA") Is Nothing Then m_parameters.Item("INDIRIZZO_AZIENDA") = ""
            If m_parameters.Item("CAP_AZIENDA") Is Nothing Then m_parameters.Item("CAP_AZIENDA") = ""
            If m_parameters.Item("TELEFONO_AZIENDA") Is Nothing Then m_parameters.Item("TELEFONO_AZIENDA") = ""



            controller.Note = m_parameters.Item("NOTE_AZIENDA")
            controller.CodiceCE = m_parameters.Item("CODICE_CE_AZIENDA")
            controller.CodiceEC = m_parameters.Item("CODICE_EC_AZIENDA")



            'If m_parameters.Item("PROVINCIA_NASCITA") Is Nothing Then m_parameters.Item("PROVINCIA_NASCITA") = ""
            Dim NomCom As String = m_parameters.Item("COMUNE_AZIENDA")


            controller.SetIndirizzoSedeLegale(m_parameters.Item("INDIRIZZO_AZIENDA"), GeoLocationFacade.Instance.GetNomeProvinciaByNomeComune(NomCom), NomCom, m_parameters.Item("CAP_AZIENDA"))
            controller.SetComunicazione(m_parameters.Item("TELEFONO_AZIENDA"), "", "", "", "")

            controller.SetContrattoApplicato(controllerContratti.GetIdTipoContrattoByDescrizione(m_parameters.Item("CONTRATTO")))
            'controller.AddSedeOperativa(m_parameters.Item("SedeOperativa"), "", "", "")
            controller.Save()
        Catch ex As Exception
            Throw New ImportAziendaException(ex.Message, m_parameters.Item("ENTE"), m_parameters.Item("PARTITA_IVA"))
        End Try
    End Sub
End Class
