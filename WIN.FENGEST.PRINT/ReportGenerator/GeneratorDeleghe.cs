using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.ADMINISTRATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorDeleghe : ReportInfo, IDSGenerator
    {
        private ControllerDeleghe _controller;
        private IList _listaDeleghe;
        private DSReport _ds;

        public GeneratorDeleghe(ControllerDeleghe controller) 
        {
            _controller = controller;
        }

        public GeneratorDeleghe(IList listaDeleghe)
        {
            _listaDeleghe = listaDeleghe;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaDeleghe != null)
            {
                foreach (Delega delega in _listaDeleghe)
                {
                    AggiungiRiga(_ds, delega);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerDeleghe controller)
        {
            ds.Delega.AddDelegaRow(_controller.IdDelega,
                                   _controller.IdUtente, 
                                   _controller.IdResponsabile,
                                   _controller.IdReferente,
                                   _controller.IdEnteInoltro,
                                   _controller.Note == null ? "" : _controller.Note,
                                   _controller.PeriodoValidita == null ? "" : _controller.PeriodoValidita,
                                   _controller.Reparto == null ? "" : _controller.Reparto,
                                   _controller.StatusDelega == null ? "" : _controller.StatusDelega,
                                   _controller.DescrizioneUtente == null ? "" : _controller.DescrizioneUtente,
                                   _controller.DescrizioneReferente == null ? "" : _controller.DescrizioneReferente,
                                   _controller.DescrizioneResponsabile == null ? "" : _controller.DescrizioneResponsabile,
                                   _controller.DescrizioneEnteInoltro == null ? "" : _controller.DescrizioneEnteInoltro,
                                   _controller.DescrizioneSettore == null ? "" : _controller.DescrizioneSettore,
                                   _controller.DataAttivazione,
                                   _controller.DataAccettazione,
                                   _controller.DataInoltro,
                                   _controller.DataDocumento,
                                   _controller.DataAnnullamento,
                                   _controller.DataRegistrazione,
                                   _controller.DataRevoca,
                                   _controller.CausaleSottoscrizione == null ? "" : _controller.CausaleSottoscrizione,
                                   _controller.DescrizioneCausaleFineCiclo == null ? "" : _controller.DescrizioneCausaleFineCiclo,
                                   controller.Cellulare1Utente ,
                                    controller.Cellulare2Utente);
        }

        private void AggiungiRiga(DSReport ds, Delega delega)
        {
            ds.Delega.AddDelegaRow( delega.IdDelega,
                                    delega.Utente == null ? 0 : delega.Utente.Id,
                                    delega.Responsabile == null ? "" : delega.Responsabile.Id.ToString(),
                                    delega.Referente == null ? "" : delega.Referente.Id.ToString(),
                                    delega.EnteInoltro == null ? 0 : delega.EnteInoltro.Id,
                                    delega.Note == null ? "" : delega.Note,
                                    delega.GetPeriodoValidita().ToString() == null ? "" : delega.GetPeriodoValidita().ToString(),
                                    delega.Reparto == null ? "" : delega.Reparto.Descrizione,
                                    delega.StatoDelega == null ? "" : delega.StatoDelega.ToString(),
                                    delega.Utente == null ? "" : delega.Utente.Descrizione,
                                  delega.Referente == null ? "" : delega.Referente.Descrizione,
                                   delega.Responsabile == null ? "" : delega.Responsabile.Descrizione,
                                   delega.EnteInoltro == null ? "" : delega.EnteInoltro.Descrizione,
                                   delega.Settore == null ? "" : delega.Settore.Descrizione,
                                   delega.PagamentoAttivazione.DataRegistrazione,
                                   delega.DataAccettazioneDelega,
                                   delega.DataInoltro,
                                   delega.DataDocumento,
                                   delega.DataAnnullamentoDelega,
                                   delega.DataRegistrazione,
                                   delega.DataRevocaDelega,
                                   delega.CausaleSottoscrizione == null ? "" : delega.CausaleSottoscrizione.Descrizione,
                                   delega.CausaleFineCiclo == null ? "" : delega.CausaleFineCiclo.Descrizione,"","");
        }
    }
}
