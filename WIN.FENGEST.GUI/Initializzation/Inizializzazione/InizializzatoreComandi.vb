Public Class InizializzatoreComandi


    Public Sub Inizializza()


        MasterControl.Instance.OpenForm = ""

        'qui aggiungo al main control i comandi che deve usare
        MasterControl.Instance.AddLinkCommand("Home", New OpenHomePageCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewPagamento", New OpenNewPagamentoCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewPagamentoPrevisionale", New OpenNewPagamentoPrevisionaleCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewPagamentoInps", New OpenNewPagamentoInpsCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewPagamentoVertenza", New OpenNewPagamentoVertenzaCommand)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptIQ", New OpenPrepareRptIQ)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptComunicazioni", New OpenPrepareRptComunicazioni)

        MasterControl.Instance.AddLinkCommand("OpenPrepareRptArchivioDocumentale", New OpenPrepareReportArchivio)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptIncarichi", New OpenPrepareReportIncarichi)
        'MasterControl.Instance.AddLinkCommand("OpenPrepareRptIscritti", New OpenPrepareRptIscritti)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptIscrittiDTO", New OpenPrepareRptIscrittiDTO)
        MasterControl.Instance.AddLinkCommand("OpenNewRistorno", New OpenNewRistorno)
        MasterControl.Instance.AddLinkCommand("OpenDocumento", New OpenDocumentoCommand)


        MasterControl.Instance.AddLinkCommand("OpenAnagraficaConto", New OpenAnagraficaContoCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaConto", New OpenNewAnagraficaContoCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaUtente", New OpenNewAnagraficaUtenteCommand)
        MasterControl.Instance.AddLinkCommand("OpenAnagraficaUtente", New OpenAnagraficaUtenteCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaReferente", New OpenNewAnagraficaReferenteCommand)
        MasterControl.Instance.AddLinkCommand("OpenAnagraficaReferente", New OpenAnagraficaReferenteCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaAzienda", New OpenNewAnagraficaAziendaCommand)
        MasterControl.Instance.AddLinkCommand("OpenAnagraficaAzienda", New OpenAnagraficaAziendaCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewDelega", New OpenNewDelegaCommand)
        MasterControl.Instance.AddLinkCommand("OpenDelega", New OpenDelegaCommand)

        MasterControl.Instance.AddLinkCommand("OpenSaldo", New OpenReportSaldiContoCommand)
        MasterControl.Instance.AddLinkCommand("OpenCausaliRevoca", New OpenCausaliRevocaCommand)
        MasterControl.Instance.AddLinkCommand("OpenTipoContratto", New OpenTipoContrattoCommand)
        MasterControl.Instance.AddLinkCommand("OpenSettore", New OpenSettoreCommand)
        MasterControl.Instance.AddLinkCommand("OpenEnte", New OpenEnteCommand)
        MasterControl.Instance.AddLinkCommand("OpenInps", New OpenInpsCommand)
        MasterControl.Instance.AddLinkCommand("OpenDeleghe", New OpenDelegheCommand)
        MasterControl.Instance.AddLinkCommand("OpenTipoPrestazione", New OpenTipoPrestazioneCommand)

        MasterControl.Instance.AddLinkCommand("OpenNewPrestazione", New OpenNewPrestazioneCommand)
        MasterControl.Instance.AddLinkCommand("OpenPrestazione", New OpenPrestazioniCommand)
        MasterControl.Instance.AddLinkCommand("OpenSingolaPrestazione", New OpenPrestazioneCommand)
        MasterControl.Instance.AddLinkCommand("OpenVertenze", New OpenVertenzeCommand)
        MasterControl.Instance.AddLinkCommand("OpenSingolaVertenza", New OpenVertenzaCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewVertenza", New OpenNewVertenzaCommand)
        MasterControl.Instance.AddLinkCommand("OpenIstituti", New OpenIstitutiCommand)
        MasterControl.Instance.AddLinkCommand("OpenReparti", New OpenRepartiCommand)
        MasterControl.Instance.AddLinkCommand("OpenSkills", New OpenSkillCommand)
        MasterControl.Instance.AddLinkCommand("OpenLivelloSkills", New OpenLivelloSkillCommand)
        MasterControl.Instance.AddLinkCommand("OpenOfferte", New OpenOfferteCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewOfferta", New OpenNewOffertaCommand)

        MasterControl.Instance.AddLinkCommand("OpenProposte", New OpenProposteCommand)
        MasterControl.Instance.AddLinkCommand("OpenSingolaProposta", New OpenPropostaCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewProposta", New OpenNewPropostaCommand)
        MasterControl.Instance.AddLinkCommand("OpenAnalisiDomanda", New OpenAnalisiDomandaCommand)
        MasterControl.Instance.AddLinkCommand("OpenAnalisiOfferta", New OpenAnalisiOffertaCommand)
        MasterControl.Instance.AddLinkCommand("OpenTipiComunicazione", New OpenTipoComunicazioneCommand)
        MasterControl.Instance.AddLinkCommand("OpenTipiPratica", New OpenTipiPraticaCommand)
        MasterControl.Instance.AddLinkCommand("OpenCausaliComunicazione", New OpenCausaleComunicazioneCommand)
        MasterControl.Instance.AddLinkCommand("OpenComunicazioni", New OpenComunicazioniCommand)
        MasterControl.Instance.AddLinkCommand("OpenSingolaComunicazione", New OpenComunicazioneCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewComunicazione", New OpenNewComunicazioneCommand)


        MasterControl.Instance.AddLinkCommand("OpenListaLavoro", New OpenListaLivoroCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewListaLavoro", New OpenNewListaLavoroCommand)
        MasterControl.Instance.AddLinkCommand("OpenComunicazioneMassiva", New OpenComunicazioneMassivaCommand)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptLiberi", New OpenPrepareRptLiberi)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptLiberiDTO", New OpenPrepareRptLiberiDTO)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptDeleghe", New OpenPrepareReportDeleghe)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptDelegheQuote", New OpenPrepareReportDelegheQuote)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptPratiche", New OpenPrepareReportPratiche)

        MasterControl.Instance.AddLinkCommand("OpenPrepareReportCantieri", New OpenPrepareReportCantieri)


        MasterControl.Instance.AddLinkCommand("OpenPrepareRptPrestazioni", New OpenPrepareRptPrestazioni)
        MasterControl.Instance.AddLinkCommand("OpenPrepareRptVertenze", New OpenPrepareRptVertenze)

        MasterControl.Instance.AddLinkCommand("OpenInoltroMassivo", New OpenInoltroMassivoDelegheCommand)
        MasterControl.Instance.AddLinkCommand("OpenAccettazioneMassiva", New OpenAccettazioneMassivaCommand)

        MasterControl.Instance.AddLinkCommand("OpenFondo", New OpenFondoCommand)
        MasterControl.Instance.AddLinkCommand("OpenSegreteria", New OpenSegreteriaCommand)
        MasterControl.Instance.AddLinkCommand("OpenTipoDocumentazione", New OpenTipoDocumentazioneCommand)
        MasterControl.Instance.AddLinkCommand("OpenCompilazioneModelli", New OpenCompilazioneModelliCommand)
        MasterControl.Instance.AddLinkCommand("OpenNewAnagraficaAvvocato", New OpenNewAnagraficaAvvocatoCommand)
        MasterControl.Instance.AddLinkCommand("OpenAnagraficaAvvocato", New OpenAnagraficaAvvocatoCommand)

    End Sub
End Class
