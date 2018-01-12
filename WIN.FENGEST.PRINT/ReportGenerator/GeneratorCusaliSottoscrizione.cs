using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using WIN.DOMAIN.FED_SERVICES;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    class GeneratorCusaliSottoscrizione : ReportInfo, IDSGenerator
    {
        private ControllerCausaliSottoscrizione _controller;
        private IList _listaCausali;
        private DSReport _ds;

        public GeneratorCusaliSottoscrizione(ControllerCausaliSottoscrizione controller) 
        {
            _controller = controller;
        }

        public GeneratorCusaliSottoscrizione(IList listaCausali)
        {
            _listaCausali = listaCausali;
        }

        #region IDSGenerator Membri di

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaCausali != null)
            {
                foreach (CausaleSottoscrizioneDelega causale in _listaCausali)
                {
                    AggiungiRiga(_ds, causale);
                }

            }
            return _ds;

        }

        #endregion

        private void AggiungiRiga(DSReport ds, ControllerCausaliSottoscrizione controller)
        {
            ds.CausaleSottoscrizione.AddCausaleSottoscrizioneRow(controller.Id, 
                                                                controller.Descrizione == null ? "" : controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, CausaleSottoscrizioneDelega causale)
        {
            ds.CausaleSottoscrizione.AddCausaleSottoscrizioneRow(causale.Id, 
                                                                causale.Descrizione == null ? "" : causale.Descrizione);
        }

    }
}
