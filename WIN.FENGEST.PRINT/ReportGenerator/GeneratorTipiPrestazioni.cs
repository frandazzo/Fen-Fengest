using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.ADMINISTRATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorTipiPrestazioni : ReportInfo, IDSGenerator
    {
        private ControllerTipoPrestazione _controller;
        private IList _listaTipiPrestazioni;
        private DSReport _ds;

        public GeneratorTipiPrestazioni(ControllerTipoPrestazione controller) 
        {
            _controller = controller;
        }

        public GeneratorTipiPrestazioni(IList listaTipiPrestazioni)
        {
            _listaTipiPrestazioni = listaTipiPrestazioni;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaTipiPrestazioni != null)
            {
                foreach (TipoPrestazione prestazione in _listaTipiPrestazioni)
                {
                    AggiungiRiga(_ds, prestazione);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerTipoPrestazione controller)
        {
            if (controller == null)
                return;
            ds.TipoPrestazione.AddTipoPrestazioneRow(controller.DescrizioneTipoPrestazione == null ? "" : controller.DescrizioneTipoPrestazione,
                                                    controller.CodicePrestazione == null ? "" : controller.CodicePrestazione,
                                                    controller.IdTipoPrestazione==null ? 0 : int.Parse(controller.IdTipoPrestazione));
        }

        private void AggiungiRiga(DSReport ds, TipoPrestazione prestazione)
        {
            if (prestazione == null)
                return;
            ds.TipoPrestazione.AddTipoPrestazioneRow(prestazione.Descrizione == null ? "" : prestazione.Descrizione,
                                                        prestazione.CodicePrestazione == null ? "" : prestazione.CodicePrestazione,
                                                        prestazione.Id);
        }

    }
}
