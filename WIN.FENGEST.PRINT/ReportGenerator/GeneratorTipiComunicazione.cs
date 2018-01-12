using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorTipiComunicazione : ReportInfo, IDSGenerator
    {
        private ControllerTipoComunicazione _controller;
        private IList _listaTipiComunicazione;
        private DSReport _ds;

        public GeneratorTipiComunicazione(ControllerTipoComunicazione controller) 
        {
            _controller = controller;
        }

        public GeneratorTipiComunicazione(IList listaTipiComunicazione)
        {
            _listaTipiComunicazione = listaTipiComunicazione;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaTipiComunicazione != null)
            {
                foreach (TipoComunicazione tipoComunicazione in _listaTipiComunicazione)
                {
                    AggiungiRiga(_ds, tipoComunicazione);
                }
            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerTipoComunicazione controller)
        {
            if (controller == null)
                return;
            ds.TipiComunicazione.AddTipiComunicazioneRow(controller.Descrizione == null ? "" : controller.Descrizione);                                                  
        }

        private void AggiungiRiga(DSReport ds, TipoComunicazione tipoComunicazione)
        {
            if (tipoComunicazione == null)
                return;
            ds.TipiComunicazione.AddTipiComunicazioneRow(tipoComunicazione.Descrizione == null ? "" : tipoComunicazione.Descrizione);                                                
        }
    }
}
