using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.GUI.PRINT.Report;
using WIN.DOMAIN.FINANCIAL;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorReportIscritti : ReportInfo, IDSGenerator
    {
        private WIN.APPLICATION.REPORTING.ReportIscritti _controller;
        private IList _listaIscritti = new ArrayList();
        private DSReport _ds;

        public GeneratorReportIscritti(WIN.APPLICATION.REPORTING.ReportIscritti controller) 
        {
            _controller = controller;
        }


        public GeneratorReportIscritti(IList listaIscritti)
        {
            if (listaIscritti == null)
                return;
            _listaIscritti = listaIscritti;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();
            if (_controller != null)
            {
                AggiungiHeader(_ds, _controller);
                AggiungiItems(_ds, _controller);
                return _ds;
            }
            AggiungiItems(_ds);
                return _ds;
        }

        private void AggiungiHeader(DSReport ds, WIN.APPLICATION.REPORTING.ReportIscritti controller)
        {
            if (controller == null)
                return;
            ds.HaderReportIscritti.AddHaderReportIscrittiRow(DateTime.Now, controller.CompetenzaRange == null ? "" : controller.CompetenzaRange,
                                                                controller.NomeSettore == null ? "" : controller.NomeSettore, 
                                                                controller.NomeContratto == null ? "" : controller.NomeContratto,
                                                                controller.NomeAzienda == null ? "" : controller.NomeAzienda, 
                                                                controller.VerificaDelega == null ? "" : controller.VerificaDelega,
                                                                controller.NumeroIscritti == null ? "" : controller.NumeroIscritti, 
                                                                controller.NumeroIscrittiNuovi == null ? "" : controller.NumeroIscrittiNuovi,
                                                                controller.NumeroIscrittiConRevocaCGL == null ? "" : controller.NumeroIscrittiConRevocaCGL, 
                                                                controller.NumeroIscrittiConRevocaCISL == null ? "" : controller.NumeroIscrittiConRevocaCISL);
        }

        private void AggiungiItems(DSReport ds)
        {
 
            foreach(IscrittoDTO item in _listaIscritti )
            {
                ds.ItemReportIscritti.AddItemReportIscrittiRow(item.Utente == null ? "" : item.Utente,
                                                                 item.Competenza == null ? "" : item.Competenza,
                                                                 item.Settore == null ? "" : item.Settore,
                                                                 item.AziendaImpiego == null ? "" : item.AziendaImpiego,
                                                                 item.Contratto == null ? "" : item.Contratto,
                                                                 item.Livello == null ? "" : item.Livello, item.Causale, item.TipoPrestazione, item.Nome_Comune ,item.Nome_Provincia , item .Nome_Nazione, item.Indirizzo , item.Cell1 ,item.Cell2,item.Nome ,item.Cognome ,item.DataNascita.ToShortDateString()  ,item.Cap ,item.Codice_Fiscale   );
            }

        }

        private void AggiungiItems(DSReport ds, WIN.APPLICATION.REPORTING.ReportIscritti controller)
        {
            if (controller == null)
                return;
            foreach (DTOItemContabile item in controller.SearchResult)
            {
                ds.ItemReportIscritti.AddItemReportIscrittiRow(item.Utente == null ? "" : item.Utente.CompleteName,
                                                                 item.Competenza == null ? "" : item.Competenza.ToString(),
                                                                 item.Settore == null ? "" : item.Settore.Descrizione,
                                                                 item.AziendaImpiego == null ? "" : item.AziendaImpiego.Descrizione,
                                                                 item.ContrattoApplicato.Descrizione == null ? "" : item.ContrattoApplicato.Descrizione,
                                                                 item.LivelloInquadramento == null ? "" : item.LivelloInquadramento, "", "","","","","","","","","","","","");
            }

        }
    }
}
