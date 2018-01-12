using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using WIN.DOMAIN.FED_SERVICES;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorCausaliRevoca : ReportInfo, IDSGenerator
    {
        private ControllerCausaliRevoca _controller;
        private IList _listaCausali;
        private DSReport _ds;

        public GeneratorCausaliRevoca(ControllerCausaliRevoca controller) 
        {
            _controller = controller;
        }

        public GeneratorCausaliRevoca(IList listaCausali)
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
                foreach (CausaleRevocaDelega causale in _listaCausali)
                {
                    AggiungiRiga(_ds, causale);
                }

            }
            return _ds;

        }

        #endregion

        private void AggiungiRiga(DSReport ds, ControllerCausaliRevoca controller)
        {
            ds.CausaleRevoca.AddCausaleRevocaRow(controller.Id,
                                                controller.Descrizione == null ? "" : controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, CausaleRevocaDelega causale)
        {
            ds.CausaleRevoca.AddCausaleRevocaRow(causale.Id,
                                                 causale.Descrizione == null ? "" : causale.Descrizione);
        }
    }
}
