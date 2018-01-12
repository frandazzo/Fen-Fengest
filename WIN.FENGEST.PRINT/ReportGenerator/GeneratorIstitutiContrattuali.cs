using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.ADMINISTRATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorIstitutiContrattuali : ReportInfo, IDSGenerator
    {
        private ControllerIstituti _controller;
        private IList _listaIstituti;
        private DSReport _ds;

        public GeneratorIstitutiContrattuali(ControllerIstituti controller) 
        {
            _controller = controller;
        }

        public GeneratorIstitutiContrattuali(IList listaIstituti)
        {
            _listaIstituti = listaIstituti;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaIstituti != null)
            {
                foreach (IstitutoContrattuale istituto in _listaIstituti)
                {
                    AggiungiRiga(_ds, istituto);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerIstituti controller)
        {
            if (controller == null)
                return;
            ds.IstitutoContratuale.AddIstitutoContratualeRow(_controller.Id, 
                                                            _controller.Descrizione==null ? "" : _controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, IstitutoContrattuale istituto)
        {
            if (istituto == null)
                return;
            ds.IstitutoContratuale.AddIstitutoContratualeRow(istituto.Id,
                                                            istituto.Descrizione == null ? "" : istituto.Descrizione);

        }
    }
}
