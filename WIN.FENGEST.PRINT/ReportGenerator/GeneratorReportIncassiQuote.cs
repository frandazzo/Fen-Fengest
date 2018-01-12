using System;
using System.Collections.Generic;
using System.Text;
using WIN.DOMAIN.FINANCIAL;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorReportIncassiQuote : ReportInfo, IDSGenerator
    {
        private WIN.APPLICATION.REPORTING.ReportIncassiQuote _controller;
        private DSReport _ds;
      

        public GeneratorReportIncassiQuote(WIN.APPLICATION.REPORTING.ReportIncassiQuote controller) 
        {
            _controller = controller;
        }

        public DSReport GeneraDataSet()
        {
          
            _ds = new DSReport();
            AggiungiHeader(_ds, _controller);
            AggiungiItems(_ds, _controller);
            return _ds;
           
           

        }

       

        private void AggiungiHeader(DSReport ds, WIN.APPLICATION.REPORTING.ReportIncassiQuote controller)
        {
            if (controller == null)
                return;

            string nomeEnteOrAzienda = "";
            if((controller.IsSettoreEdile)&&(controller.NomeEnte!=null))
               nomeEnteOrAzienda = controller.NomeEnte;
            else if((!controller.IsSettoreEdile)&&(controller.NomeAzienda!=null))
               nomeEnteOrAzienda = controller.NomeAzienda;

            ds.HaderReportIncassiQuote.AddHaderReportIncassiQuoteRow(DateTime.Now.ToShortDateString(), controller.TipiDocInclusi == null ? "" : controller.TipiDocInclusi,
                                                                controller.DataRegistrazioneRange == null ? "" : controller.DataRegistrazioneRange,
                                                                controller.DataDocumentoRange == null ? "" : controller.DataDocumentoRange,
                                                                controller.CompetenzaRange == null ? "" : controller.CompetenzaRange,
                                                                controller.NomeSettore == null ? "" : controller.NomeSettore,
                                                                controller.NomeContratto == null ? "" : controller.NomeContratto,
                                                                nomeEnteOrAzienda,
                                                                controller.TipoRistorno == null ? "" : controller.TipoRistorno,
                                                                controller.NomeReferente == null ? "" : controller.NomeReferente,
                                                                controller.IncassoPonderato == null ? "" : controller.IncassoPonderato,
                                                                controller.IncassoRistornoPonderato == null ? "" : controller.IncassoRistornoPonderato,
                                                                controller.OreLavoratePonderate == null ? "" : controller.OreLavoratePonderate,
                                                                controller.OreMalattiaPonderate == null ? "" : controller.OreMalattiaPonderate);
        }

        private void AggiungiItems(DSReport ds, WIN.APPLICATION.REPORTING.ReportIncassiQuote controller)
        {
            if ((controller == null)||(controller.SearchResult == null))
                return;
            foreach (Quota item in controller.SearchResult)
            {
                ds.ItemReportIncassiQuote.AddItemReportIncassiQuoteRow(item.DocumentoPadre == null ? 0 : Convert.ToInt32(item.DocumentoPadre), 
                                                                        item.TipoDocumento,
                                                                        item.DataRegistrazione.ToShortDateString(),
                                                                        item.DataDocumento.ToShortDateString(),
                                                                        item.Utente == null ? "" : item.Utente,
                                                                        item.Competenza == null ? "" : item.Competenza.ToString(),
                                                                        item.ImportoRistorno.ToString() + " Euro" ,
                                                                        item.Importo.ToString() + " Euro",
                                                                        item.PagamentoReferente.ToString(),
                                                                        (item.SoggettoEsecutore == null) ? "" : item.SoggettoEsecutore,
                                                                        (item.Referente == null) ? "" : item.Referente,
                                                                        (item.Settore == null)  ? "" : item.Settore,
                                                                        "",
                                                                        (item.AziendaImpiego==null)  ? "" : item.AziendaImpiego ,
                                                                        (item.ContrattoApplicato==null)  ? "" : item.ContrattoApplicato,
                                                                        item.LivelloInquadramento==null ? "" : item.LivelloInquadramento,
                                                                        item.OreLavorate.ToString(),
                                                                        item.OreMalattia.ToString(),
                                                                        item.Tredicesima,
                                                                        item.Quattordicesima,
                                                                        item.IdVertenza.ToString(),
                                                                        item.IdPrestazione.ToString(),
                                                                        (item.TipoPrestazione == null) ? "" : item.TipoPrestazione,item.CodiceFiscale );
            }

        }
    }
}
