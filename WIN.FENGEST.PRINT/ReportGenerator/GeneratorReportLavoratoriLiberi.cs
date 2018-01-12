using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.REPORTING;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorReportLavoratoriLiberi : ReportInfo, IDSGenerator
    {
        private ReportLiberi _controller;
        private DSReport _ds;
        private IList _nonIscritti = new ArrayList();

        public GeneratorReportLavoratoriLiberi(ReportLiberi controller) 
        {
            _controller = controller;
        }

        public GeneratorReportLavoratoriLiberi(IList nonoIscritti)
        {
            _nonIscritti = nonoIscritti;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
            {

                _ds.HaderReportLavoratoriLiberi.AddHaderReportLavoratoriLiberiRow(
                    DateTime.Now, _controller.NomeEnte, _controller.CompetenzaRange, _controller.NumeroLiberi);


                foreach (DTOLavoratoreLibero lavoratore in _controller.SearchResult)
                {
                    AggiungiRiga(_ds, lavoratore);
                }

            }
            else
            {
                foreach (NonIscrittoDTO  item in _nonIscritti )
                {
                    AggiungiRiga(_ds, item);
                }
            }

            return _ds;
        }

        private void AggiungiRiga(DSReport ds, DTOLavoratoreLibero lavoratore)
        {
            if (lavoratore == null)
                return;

            ds.DettagliReportLavoratoriLIberi.AddDettagliReportLavoratoriLIberiRow(
                            lavoratore.IdUtente ==null ? "0" : lavoratore.IdUtente.ToString(),
                            lavoratore.CompleteName==null ? "" : lavoratore.CompleteName,
                            lavoratore.CodiceFiscale==null ? "" : lavoratore.CodiceFiscale,
                            lavoratore.DataNascita,
                            lavoratore.NomeAzienda == null ? "" : lavoratore.NomeAzienda,
                            lavoratore.LiberoAl, "","","","","","","");
        }


        private void AggiungiRiga(DSReport ds, NonIscrittoDTO nonIscritto)
        {
            if (nonIscritto  == null)
                return;

            DateTime d = ConvertToDate(nonIscritto.Libero_Al);

            ds.DettagliReportLavoratoriLIberi.AddDettagliReportLavoratoriLIberiRow(
                            nonIscritto .Id_Utente.ToString () ,
                            nonIscritto .Nome_Utente ,
                            "",
                            DateTime .MinValue ,
                            nonIscritto .Nome_Azienda ,
                            d , nonIscritto .Nome_Ente , nonIscritto .Livello , nonIscritto .Ha_Delega_Precedente, nonIscritto .Nome_Comune ,nonIscritto.Nome_Provincia ,nonIscritto.Nome_Nazione, nonIscritto.IscrittoA );
        }

        private DateTime ConvertToDate(string p)
        {
            try 
	        {
                return DateTime.Parse(p);
	        }
	        catch (Exception)
	        {
                return DateTime.Now;
	        }
            
        }

    }
}
