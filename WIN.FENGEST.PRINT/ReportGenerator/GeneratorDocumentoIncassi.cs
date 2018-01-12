using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.FINANCIAL_ARTIFACTS;
using WIN.APPLICATION.AZIENDE;
using WIN.DOMAIN.FINANCIAL;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorDocumentoIncassi : ReportInfo, IDSGenerator
    {
        private DSReport _ds;
        AbstractDocumentController _controllerDocument;
        ControllerIncassiQuote _controllerIncassi;

        public GeneratorDocumentoIncassi(AbstractDocumentController controllerDocument,
                                            ControllerIncassiQuote controllerIncassi
                                             )
        {
            _controllerDocument = controllerDocument;
            _controllerIncassi = controllerIncassi;
        }


        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if ((_controllerDocument != null) && (_controllerIncassi!=null))
                AggiungiRiga(_ds);
            return _ds;
        }

        private void AggiungiRiga(DSReport ds)
        {
            ds.HeaderDocumentoIncassi.AddHeaderDocumentoIncassiRow(_controllerDocument.DataRegistrazione,
                                                                    _controllerDocument.DataDocumento.ToShortDateString(),
                                                                    _controllerDocument.TipoDocumento,
                                                                    _controllerIncassi.Importo.ToString(),
                                                                    _controllerIncassi.Competenza,
                                                                    _controllerIncassi.DescrizioneSettore,
                                                                    _controllerDocument.Note,
                                                                    "",
                                                                    "");
           
            foreach (ItemIncassoQuotaAssociativa item in _controllerIncassi.ListaPosizioniUtenti) 
            {
                ds.DettagliDocumentoIncassi.AddDettagliDocumentoIncassiRow(item.Utente.CompleteName,
                    item.Importo.ToString(),
                    item.Note,
                    item.SoggettoEsecutore.Descrizione,
                    item.Referente.CompleteName,
                    item.Competenza.ToString(),
                    item.Tredicesima.ToString(),
                    item.Quattordicesima.ToString(),
                    item.Settore.Descrizione,
                    item.AziendaImpiego.Descrizione,
                    item.SedeOperativaAzienda.Descrizione,
                    item.ContrattoApplicato.Descrizione,
                    item.Importo.ToString(),
                    item.PagamentoReferente.Descrizione,
                    item.QuotaMedia.ToString(),
                    item.QuotaMensileUtente.ToString(),
                    "",
                    item.LivelloInquadramento,
                    item.OreLavorate.ToString(),
                    item.OreMalattia.ToString());
            }
        }


    }
}
