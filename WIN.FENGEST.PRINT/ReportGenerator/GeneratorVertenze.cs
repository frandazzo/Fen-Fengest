using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.ADMINISTRATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorVertenze : ReportInfo, IDSGenerator
    {
        private ControllerVertenze _controller;
        private IList _listaVertenze;
        private DSReport _ds;

        public GeneratorVertenze(ControllerVertenze controller) 
        {
            _controller = controller;
        }

        public GeneratorVertenze(IList listaVertenze)
        {
            _listaVertenze = listaVertenze;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaVertenze != null)
            {
                foreach (Vertenza vertenza in _listaVertenze)
                {
                    AggiungiRiga(_ds, vertenza);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerVertenze controller)
        {
            if (controller == null)
                return;
            ds.Vertenza.AddVertenzaRow(_controller.IdVertenza== null ? 0 : int.Parse(_controller.IdVertenza),
                                        _controller.DataDocumento,
                                        _controller.IdUtente,
                                        _controller.DescrizioneUtente == null ? "" : _controller.DescrizioneUtente,
                                        _controller.DescrizioneAzienda == null ? "" : _controller.DescrizioneAzienda,
                                        _controller.DataInizioPeriodo.ToShortDateString() +" - "+_controller.DataFinePeriodo.ToShortDateString(),
                                        _controller.DataRegistrazione,
                                        _controller.DataInizioPeriodo,
                                        _controller.DataFinePeriodo,
                                        _controller.DescrizioneReferente == null ? "" : _controller.DescrizioneReferente,
                                        "",_controller.Importo.ToString());
        }

        private void AggiungiRiga(DSReport ds, Vertenza vertenza)
        {
            if (vertenza == null)
                return;
            ds.Vertenza.AddVertenzaRow(vertenza.Id,
                                        vertenza.DataCreazione,
                                        vertenza.Utente.Id,
                                        vertenza.Utente==null ? "" : vertenza.Utente.CompleteName,
                                        vertenza.Azienda == null ? "" : vertenza.Azienda.Descrizione,
                                        vertenza.PeriodoVertenza.ToString(),
                                        vertenza.DataRegistrazione,
                                        vertenza.PeriodoVertenza.Start,
                                        vertenza.PeriodoVertenza.Finish,
                                        vertenza.Referente==null ? "" : vertenza.Referente.CompleteName,
                                        "",
                                        vertenza.Quota == null ? "" : vertenza.Quota.Importo.ToString());

        }

    }
}
