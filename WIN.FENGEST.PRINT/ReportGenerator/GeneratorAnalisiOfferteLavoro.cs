using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using WIN.APPLICATION.UTENTI;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnalisiOfferteLavoro : ReportInfo, IDSGenerator
    {
        private ControllerUtenti _controllerUtenti;
        private ControllerRicercheOfferte _controllerRicercheOfferte;
        private IList _listaOfferteLavoro;
        private DSReport _ds;

        public GeneratorAnalisiOfferteLavoro(ControllerUtenti controllerUtenti, ControllerRicercheOfferte controllerRicercheOfferte) 
        {
            _controllerUtenti = controllerUtenti;
            _controllerRicercheOfferte = controllerRicercheOfferte;
        }

        public GeneratorAnalisiOfferteLavoro(IList listaOfferteLavoro)
        {
            _listaOfferteLavoro = listaOfferteLavoro;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();
            if ((_controllerUtenti != null)&&(_controllerRicercheOfferte !=null))
                AggiungiRiga(_ds, _controllerUtenti,_controllerRicercheOfferte);

            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerUtenti controllerUtenti, ControllerRicercheOfferte controllerRicercheOfferte)
        {
            if ((controllerUtenti == null)||(controllerRicercheOfferte == null))
                return;

            if (controllerUtenti.Current() != null)
            {
                ds.AnalisiOfferteLavoro.AddAnalisiOfferteLavoroRow(controllerUtenti.IdUtente,
                                                                    controllerRicercheOfferte.GetPreferenzaSkill,
                                                                    controllerRicercheOfferte.GetData,
                                                                    controllerRicercheOfferte.GetValidityRange);
            }

            foreach (OffertaLavoro offerta in controllerRicercheOfferte.GetSearchResult)
            {
                ds.DettaglioAnalisiOfferteLavoro.AddDettaglioAnalisiOfferteLavoroRow(offerta.Id, 
                                                                                    offerta.Data, 
                                                                                    offerta.AziendaRichiedente.Descrizione,
                                                                                    offerta.Validita.Start.ToShortDateString() + " - " + offerta.Validita.Finish.ToShortDateString(),
                                                                                    offerta.GetNumeroTotalePosti);
            }                                
        }

    }
}
