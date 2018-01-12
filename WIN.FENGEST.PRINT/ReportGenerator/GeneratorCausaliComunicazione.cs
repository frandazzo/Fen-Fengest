using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorCausaliComunicazione : ReportInfo, IDSGenerator
    {
        private ControllerCausaleComunicazione _controller;
        private IList _listaCausaliComunicazione;
        private DSReport _ds;

        public GeneratorCausaliComunicazione(ControllerCausaleComunicazione controller) 
        {
            _controller = controller;
        }

        public GeneratorCausaliComunicazione(IList listaCausaliComunicazione)
        {
            _listaCausaliComunicazione = listaCausaliComunicazione;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaCausaliComunicazione != null)
            {
                foreach (CausaleComunicazione causaleComunicazione in _listaCausaliComunicazione)
                {
                    AggiungiRiga(_ds, causaleComunicazione);
                }
            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerCausaleComunicazione controller)
        {
            if (controller == null)
                return;
            _ds.CausaliComunicazione.AddCausaliComunicazioneRow(controller.Descrizione == null ? "" : controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, CausaleComunicazione causaleComunicazione)
        {
            if (causaleComunicazione == null)
                return;
            _ds.CausaliComunicazione.AddCausaliComunicazioneRow(causaleComunicazione.Descrizione == null ? "" : causaleComunicazione.Descrizione);
        }

    }
}
