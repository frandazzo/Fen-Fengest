using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.UTENTI;
using WIN.APPLICATION.FINANCIAL_ARTIFACTS;
using WIN.APPLICATION.AZIENDE;
using WIN.APPLICATION.ADMINISTRATION;
using WIN.DOMAIN.FED_SERVICES;
using System.Windows.Forms;
using System.Collections;
using WIN.APPLICATION;
using WIN.GUI.PRINT.ReportGenerator;
using WIN.GUI.PRINT.Report;
using CrystalDecisions.Shared;
using System.IO;
using WIN.APPLICATION.REPORTING;


namespace WIN.GUI.PRINT
{
    public class PrintFacade
    {
        public void PrintUtente(ControllerUtenti controller)
        {
            FrmOpzioniStampaAnagraficaUtente frm = new FrmOpzioniStampaAnagraficaUtente();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FrmReportAnagraficaUtenteView reportView = new FrmReportAnagraficaUtenteView(controller,frm.IncludiAttitudiniLavorative,frm.IncludiPreferenzeLavorative);
                reportView.Show();
            }
            else { frm.Close(); }
        }

        public void PrintReferente(ControllerReferenti controller)
        {
           FrmReportAnagraficaReferenteView reportView = new FrmReportAnagraficaReferenteView(controller);
           reportView.Show();
        }

        public void PrintAzienda(ControllerAziende controller) 
        {
            FrmOpzioniStampaAnagraficaAzienda frm = new FrmOpzioniStampaAnagraficaAzienda();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FrmReportAnagraficaAziendaView reportView = new FrmReportAnagraficaAziendaView(controller, frm.IncludiElencoSediOperative, frm.IncludiCompetenzaUltimoPagamento);
                reportView.Show();
            }
            else { frm.Close(); }
        }

        public void PrintDelega(ControllerDeleghe controller) 
        {
            Form reportView;

            if(controller.StatusDelega == "Attivata")
                reportView = new FrmReportAnagraficaDelegaAttivataView(controller);
            else if(controller.StatusDelega =="Accettata")
                reportView = new FrmReportAnagraficaDelegaAccettataView(controller);
            else if (controller.StatusDelega == "Annullata")
                reportView = new FrmReportAnagraficaDelegaAnnullataView(controller);
            else if (controller.StatusDelega == "Inoltrata")
                reportView = new FrmReportAnagraficaDelegaInoltrataView(controller);
            else //revocata
                reportView = new FrmReportAnagraficaDelegaRevocataView(controller);

            reportView.Show();
        }

        public void PrintDeleghe(IList listaDeleghe) 
        {
            FrmReportListaDelegheUtenteView reportView = new FrmReportListaDelegheUtenteView(listaDeleghe);
            reportView.Show();

        }

        public void PrintReportDeleghe(IList listaDeleghe)
        {
            FrmReportDelegheDTO reportView = new FrmReportDelegheDTO(listaDeleghe);
            reportView.Show();

        }


        public void PrintReportPrestazioni(IList lista)
        {
            FrmReportPrestazioniDTO reportView = new FrmReportPrestazioniDTO(lista);
            reportView.Show();

        }

        public void PrintReportVertenze(IList lista)
        {
            FrmReportVertenzeDTO reportView = new FrmReportVertenzeDTO(lista);
            reportView.Show();

        }

        public void PrintPrestazione(ControllerPrestazioni controller) 
        {
            FrmReportPrestazioneView reportPrestazioneView;
            FrmReportElencoPrestazioniView reportElencoPrestazioniView;
            FrmOpzioniStampaPrestazioni frm = new FrmOpzioniStampaPrestazioni();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (frm.StampaDettagliPrestazioneSelezionata) 
                {
                    reportPrestazioneView = new FrmReportPrestazioneView(controller);
                    reportPrestazioneView.Show();
                }
                if (frm.StampaElencoPrestazioni)
                {
                    reportElencoPrestazioniView = new FrmReportElencoPrestazioniView(controller.GetPrestazioniByUtente(controller.IdUtente.ToString()));
                    reportElencoPrestazioniView.Show();
                }

            }
            else { frm.Close(); }
        }

        public void PrintElencoPrestazioni(ControllerTipoPrestazione controller) 
        {
            FrmReportElencoPrestazioniView reportView = new FrmReportElencoPrestazioniView(controller.GetAll());
            reportView.Show();

        }

        public void PrintListaAbilita(ControllerAbilita controller)
        {
            FrmReportListaAbilitaView reportView = new FrmReportListaAbilitaView(controller.GetAll());
            reportView.Show();
        }

        public void PrintListaLivelloAbilita(ControllerLivelloAbilita controller)
        {
            FrmReportListaLivelliAbilitaView reportView = new FrmReportListaLivelliAbilitaView(controller.GetAll());
            reportView.Show();
        }

        public void PrintListaIstitutiContrattuali(ControllerIstituti controller)
        {
            FrmReportListaIstitutiContrattualiView reportView = new FrmReportListaIstitutiContrattualiView(controller.GetAll());
            reportView.Show();
        }





        public void PrintListaTipiContratti(ControllerTipoContratto controller) 
        {
            FrmReportListaTipiContrattoView reportView = new FrmReportListaTipiContrattoView(controller.GetAll());
            reportView.Show();
        }

        public void PrintListaCausaliSottoscrizione(ControllerCausaliSottoscrizione controller)
        {
            FrmReportListaCausaliSottoscrizioneView reportView = new FrmReportListaCausaliSottoscrizioneView(controller.GetAll());
            reportView.Show();
        }

        public void PrintListaCausaliRevoca(ControllerCausaliRevoca controller)
        {
            FrmReportListaCausaliRevocaDelegaView reportView = new FrmReportListaCausaliRevocaDelegaView(controller.GetAll());
            reportView.Show();
        }

        public void PrintListaTipiPrestazioni(ControllerTipoPrestazione controller)
        {
            FrmReportListaTipiPrestazioniView reportView = new FrmReportListaTipiPrestazioniView(controller.GetAll());
            reportView.Show();
        }

        public void PrintVertenze(ControllerVertenze controller) 
        {
            FrmOpzioniStampaVertenza frm = new FrmOpzioniStampaVertenza();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FrmReportVertenzaView reportPrestazioneView = new FrmReportVertenzaView(controller, frm.IncludiElencoEventi,frm.IncludiIstitutiContrattuali);
                reportPrestazioneView.Show();
            }
        }

        public void PrintListaVertenze(ControllerVertenze controller) 
        {
            FrmReportListaVertenzeView reportView = new FrmReportListaVertenzeView(controller.GetAll());
            reportView.Show();
        }

        public void PrintListaReparti(ControllerReparti controller) 
        {
            FrmReportListaRepartiView reportView = new FrmReportListaRepartiView(controller.GetAll());
            reportView.Show();
        }

        public void PrintReportIscritti(WIN.APPLICATION.REPORTING.ReportIscritti controller)
        {
            FrmReportIscrittiView reportView = new FrmReportIscrittiView(controller);
            reportView.Show();
        }
        public void PrintReportIscrittiDTO(IList iscritti)
        {
            FrmReportIscrittiDTO reportView = new FrmReportIscrittiDTO(iscritti);
            reportView.Show();
        }
        public void PrintReportNonIscrittiDTO(IList nonIscritti)
        {
            FrmReportNonIscrittiDTO reportView = new FrmReportNonIscrittiDTO(nonIscritti);
            reportView.Show();
        }

        public void PrintReportIncassiQuote(WIN.APPLICATION.REPORTING.ReportIncassiQuote controller)
        {
            if (controller != null)
            {
                //GeneratorReportIncassiQuote generatorReportIncassiQuote = new GeneratorReportIncassiQuote(controller);
                //WIN.GUI.PRINT.Report.ReportIncassiQuote ReportIncassiQuote = new WIN.GUI.PRINT.Report.ReportIncassiQuote();
                //ReportIncassiQuote.SetDataSource(generatorReportIncassiQuote.GeneraDataSet());
                //generatorReportIncassiQuote.SetHeaderInfo(ReportIncassiQuote);
                //generatorReportIncassiQuote.SetFooterInfo(ReportIncassiQuote);

                //ExcelFormatOptions option = CrystalDecisions.Shared.ExportOptions.CreateExcelFormatOptions();
                //string fileTmp = System.IO.Path.GetTempFileName();
                //string fileTmpXls = fileTmp.Replace(".tmp", ".xls");
                //ReportIncassiQuote.ExportToDisk(ExportFormatType.Excel, fileTmpXls);
                //System.Diagnostics.Process.Start(fileTmpXls);
                FrmReportIncassiQuoteView reportView = new FrmReportIncassiQuoteView(controller);
                reportView.Show();
                
            }

        }

       


        public void PrintReportListaProposteLavoro(IList listaProposteLavoro)
        {
            FrmReportListaProposteLavoroView reportView = new FrmReportListaProposteLavoroView(listaProposteLavoro);
            reportView.Show();
        }

        public void PrintReportAnalisiDomandeLavoro(ControllerRicercheUtenti controllerRicercheUtenti, string idOfferta)
        {
            FrmReportAnalisiDomandeLavoroView reportView = new FrmReportAnalisiDomandeLavoroView(controllerRicercheUtenti, idOfferta);
            reportView.Show();
        }

        public void PrintReportAnalisiOfferteLavoro(ControllerRicercheOfferte controllerRicerche, ControllerUtenti controllerUtenti)
        {
            FrmReportAnalisiOfferteLavoroView reportView = new FrmReportAnalisiOfferteLavoroView(controllerUtenti, controllerRicerche);
            reportView.Show();
        }

        public void PrintReportListaOfferteLavoro(IList listaOfferteLavoro)
        {
            FrmReportListaOfferteLavoroView reportView = new FrmReportListaOfferteLavoroView(listaOfferteLavoro);
            reportView.Show();
        }

        public void PrintReportOfferteLavoro(ControllerOfferteLavoro controller)
        {
            //FrmReportOfferteLavoroView reportView = new FrmReportOfferteLavoroView(controller);
            //reportView.Show();

            FrmReportOfferta reportView = new FrmReportOfferta(controller);
            reportView.Show();
        }

        public void PrintReportTipiComunicazione(ControllerTipoComunicazione controller) 
        {
            FrmReportTipiComunicazioneView reportView = new FrmReportTipiComunicazioneView(controller);
            reportView.Show();
        }

        public void PrintReportComunicazioni(ControllerComunicazioni controller)
        {
            FrmReportComunicazioneView reportView = new FrmReportComunicazioneView(controller);
            reportView.Show();
        }

        public void PrintReportListaComunicazioni(IList listaComunicazioni) 
        {
            FrmReportListaComunicazioniView reportView = new FrmReportListaComunicazioniView(listaComunicazioni);
            reportView.Show();
        }

        public void PrintReportCausaliComunicazione(ControllerCausaleComunicazione controller)
        {
            FrmReportCausaliComunicazioneView reportView = new FrmReportCausaliComunicazioneView(controller);
            reportView.Show();
        }


        public void PrintReportListaLavoro(ControllerListaUtenti controller)
        {
            FrmReportListaLavoroView reportView = new FrmReportListaLavoroView(controller);
            reportView.Show();
        }

        public void PrintReportDocumentoInacassi(AbstractDocumentController controllerDocument, 
                                                ControllerIncassiQuote controllerIncassi) 
        {
            if ((controllerDocument!=null)&&(controllerIncassi!=null))
            {
                GeneratorDocumentoIncassi generatorReportIncassiQuote = new GeneratorDocumentoIncassi(controllerDocument, controllerIncassi);
                WIN.GUI.PRINT.Report.ReportDocumentiIncassi ReportIncassiQuote = new WIN.GUI.PRINT.Report.ReportDocumentiIncassi();
                ReportIncassiQuote.SetDataSource(generatorReportIncassiQuote.GeneraDataSet());
                generatorReportIncassiQuote.SetHeaderInfo(ReportIncassiQuote);
                generatorReportIncassiQuote.SetFooterInfo(ReportIncassiQuote);
                ExcelFormatOptions option = CrystalDecisions.Shared.ExportOptions.CreateExcelFormatOptions();
                string fileTmp = System.IO.Path.GetTempFileName();
                string fileTmpXls = fileTmp.Replace(".tmp", ".xls");
                ReportIncassiQuote.ExportToDisk(ExportFormatType.Excel, fileTmpXls);
                System.Diagnostics.Process.Start(fileTmpXls);

            }


        }



        public void PrintReportLavoratoriLiberi(ReportLiberi controller)
        {
            FrmReportLavoratoriLiberiView reportView = new FrmReportLavoratoriLiberiView(controller);
            reportView.Show();
        }

        public void PrintReportEnti(ControllerEntiBilaterali controller)
        {
            FrmReportAnagraficaEntiView reportView = new FrmReportAnagraficaEntiView(controller);
            reportView.Show();
        }

        public void PrintReportEnti(ControllerInps controller)
        {
            FrmReportAnagraficaEntiView reportView = new FrmReportAnagraficaEntiView(controller);
            reportView.Show();
        }

    }
}
