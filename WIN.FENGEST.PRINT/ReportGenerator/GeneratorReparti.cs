using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorReparti : ReportInfo, IDSGenerator
    {
        private ControllerReparti _controller;
        private IList _listaReparti;
        private DSReport _ds;

        public GeneratorReparti(ControllerReparti controller) 
        {
            _controller = controller;
        }

        public GeneratorReparti(IList listaReparti)
        {
            _listaReparti = listaReparti;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaReparti != null)
            {
                foreach (RepartoAzienda reparto in _listaReparti)
                {
                    AggiungiRiga(_ds, reparto);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerReparti controller)
        {
            if (controller == null)
                return;
            ds.Reparto.AddRepartoRow(_controller.Id, 
                                     _controller.Descrizione==null ? "" : _controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, RepartoAzienda reparto)
        {
            if (reparto == null)
                return;
            ds.Reparto.AddRepartoRow(reparto.Id,
                                     reparto.Descrizione == null ? "" : reparto.Descrizione);

        }
    }
}
