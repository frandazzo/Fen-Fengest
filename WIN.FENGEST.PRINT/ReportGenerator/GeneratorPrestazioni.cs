using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.ADMINISTRATION;
using CrystalDecisions.CrystalReports.Engine;
using WIN.DOMAIN.FED_SERVICES;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorPrestazioni : ReportInfo, IDSGenerator
    {
        private ControllerPrestazioni _controller;
        private IList _listaPrestazioni;
        private DSReport _ds;

        public GeneratorPrestazioni(ControllerPrestazioni controller) 
        {
            _controller = controller;
        }

        public GeneratorPrestazioni(IList listaPrestazioni)
        {
            _listaPrestazioni = listaPrestazioni;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaPrestazioni != null)
            {
                foreach (Prestazione prestazione in _listaPrestazioni)
                {
                    AggiungiRiga(_ds, prestazione);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerPrestazioni controller)
        {
            ds.Prestazione.AddPrestazioneRow(_controller.IdPrestazione,
                                                _controller.IdUtente, 
                                                _controller.DataDocumento,
                                                _controller.DataRegistrazione,
                                                _controller.DescrizioneReferente == null ? "" : _controller.DescrizioneReferente, 
                                                _controller.DescrizioneUtente == null ? "" : _controller.DescrizioneUtente,
                                                _controller.DescrizioneTipoPrestazione == null ? "" : _controller.DescrizioneTipoPrestazione,
                                                _controller.Note == null ? "" : _controller.Note);
        }

        private void AggiungiRiga(DSReport ds, Prestazione prestazione)
        {
            ds.Prestazione.AddPrestazioneRow(prestazione.Id.ToString(), 
                                                prestazione.Utente == null ? 0 : prestazione.Utente.Id, 
                                                prestazione.DataDocumento, 
                                                prestazione.DataRegistrazione,
                                                prestazione.Referente == null ? "" : prestazione.Referente.CompleteName, 
                                                prestazione.Utente == null ? "" : prestazione.Utente.CompleteName,
                                                prestazione.TipoDocumento == null ? "" : prestazione.TipoPrestazione.Descrizione,
                                                prestazione.Note == null ? "" : prestazione.Note);
        }

    }
}
