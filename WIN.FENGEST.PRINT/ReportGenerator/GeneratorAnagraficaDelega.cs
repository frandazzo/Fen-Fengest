using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using WIN.APPLICATION.ADMINISTRATION;
using WIN.DOMAIN.FED_SERVICES;
using WIN.BASEREUSE;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnagraficaDelega : ReportInfo, IDSGenerator
    {
        private ControllerDeleghe _controller;
        private IList _listaDeleghe;
        private DSReport _ds;


        public GeneratorAnagraficaDelega(ControllerDeleghe controller) 
        {
            _controller = controller;
        }

        public GeneratorAnagraficaDelega(IList listaDeleghe)
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
            ds.Delega.AddDelegaRow(controller.IdDelega, 
                                    controller.IdUtente, 
                                    controller.IdResponsabile == null ? "" : controller.IdResponsabile,
                                    controller.IdReferente == null ? "" : controller.IdReferente,
                                    controller.IdEnteInoltro,
                                    controller.Note == null ? "" : controller.Note,
                                    controller.PeriodoValidita == null ? "" : controller.PeriodoValidita,
                                    controller.Reparto == null ? "" : controller.Reparto,
                                    controller.StatusDelega == null ? "" : controller.StatusDelega,
                                    controller.DescrizioneUtente == null ? "" : controller.DescrizioneUtente,
                                    controller.DescrizioneReferente == null ? "" : controller.DescrizioneReferente,
                                    controller.DescrizioneResponsabile == null ? "" : controller.DescrizioneResponsabile,
                                    controller.DescrizioneEnteInoltro == null ? "" : controller.DescrizioneEnteInoltro,
                                    controller.DescrizioneSettore == null ? "" : controller.DescrizioneSettore,
                                    controller.DataAttivazione, 
                                    controller.DataAccettazione,
                                    controller.DataInoltro, 
                                    controller.DataDocumento, 
                                    controller.DataAnnullamento, 
                                    controller.DataRegistrazione, 
                                    controller.DataRevoca,
                                    controller.CausaleSottoscrizione == null ? "" : controller.CausaleSottoscrizione,
                                    controller.DescrizioneCausaleFineCiclo == null ? "" : controller.DescrizioneCausaleFineCiclo,
                                    controller.Cellulare1Utente ,
                                    controller.Cellulare2Utente);

        }

        private void AggiungiRiga(DSReport ds, Delega delega) 
        {
            DataRange dataRange = delega.GetPeriodoValidita();
            string periodoValidita = dataRange.Start.ToShortDateString() + " - " + dataRange.Finish.ToShortDateString();
            ds.Delega.AddDelegaRow(delega.IdDelega,
                                    delega.Utente == null ? 0 : delega.Utente.IdUtente, 
                                    delega.Responsabile == null ? "" : delega.Responsabile.Id.ToString(), 
                                    delega.Referente == null ? "" : delega.Referente.Id.ToString(), 
                                    delega.EnteInoltro == null ? 0 : delega.EnteInoltro.Id,
                                    delega.Note == null ? "" : delega.Note, 
                                    periodoValidita, 
                                    delega.Referente ==null ? "" : delega.Reparto.Descrizione, 
                                    delega.StatoDelega == null ? "" : delega.StatoDelega.StatusName, 
                                    delega.Utente == null ? "" : delega.Utente.CompleteName,
                                    delega.Referente == null ? "" : delega.Referente.CompleteName, 
                                    delega.Responsabile == null ? "" : delega.Responsabile.CompleteName, 
                                    delega.EnteInoltro == null ? "" : delega.EnteInoltro.Descrizione, 
                                    delega.Settore == null ? "" : delega.Settore.Descrizione,
                                    delega.DataCreazione, 
                                    delega.DataAccettazioneDelega, 
                                    delega.DataInoltro, 
                                    delega.DataDocumento, 
                                    delega.DataAnnullamentoDelega,
                                    delega.DataRegistrazione, 
                                    delega.DataRevocaDelega, 
                                    delega.CausaleSottoscrizione == null ? "" : delega.CausaleSottoscrizione.Descrizione,
                                    delega.CausaleFineCiclo == null ? "" : delega.CausaleFineCiclo.Descrizione,
                                    delega.Cellulare1Utente ,
                                    delega.Cellulare2Utente );
        }

    }
}
