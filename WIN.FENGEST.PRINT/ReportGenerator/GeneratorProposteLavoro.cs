using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FED_SERVICES;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorProposteLavoro : ReportInfo, IDSGenerator
    {
        private ControllerProposte _controllerProposte;
        private ControllerOfferteLavoro _controllerOfferte;
        private IList _listaProposteLavoro;
        private DSReport _ds;

        public GeneratorProposteLavoro(ControllerProposte controllerProposte)
        {
            _controllerProposte = controllerProposte;
        }

        /// <summary>
        /// generazione proposte lavoro dettaglio
        /// </summary>
        /// <param name="controller"></param>
        public GeneratorProposteLavoro(ControllerProposte controllerProposte,ControllerOfferteLavoro controllerOfferte) 
        {
            _controllerProposte = controllerProposte;
            _controllerOfferte = controllerOfferte;
        }
        /// <summary>
        /// generazione lista proposte lavoro
        /// </summary>
        /// <param name="listaProposteLavoro"></param>
        public GeneratorProposteLavoro(IList listaProposteLavoro)
        {
            _listaProposteLavoro = listaProposteLavoro;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controllerProposte != null)
                AggiungiRiga(_ds, _controllerProposte);
            else if (_listaProposteLavoro != null)
            {
                AddInfoUtente(_ds);
                foreach (PropostaLavoro propostaLavoro in _listaProposteLavoro)
                {
                    AggiungiRiga(_ds, propostaLavoro);
                }
            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerProposte controller)
        {
            if (controller == null)
                return;
            ds.DettaglioProposteLavoro.AddDettaglioProposteLavoroRow(controller.DataRegistrazione,
                                                                     controller.DataDocumento,
                                                                     controller.IdOfferta,
                                                                     controller.Note==null ? "" : controller.Note,
                                                                     controller.IdUtente,
                                                                     controller.NomeUtente ==null ? "" : controller.NomeUtente,
                                                                     controller.DescrizioneAbilita==null ? "" : controller.DescrizioneAbilita);

            if ((controller.GetListaSkill == null) || (controller.GetListaSkill.Count == 0))
                return;
            IList dettagliOfferta = _controllerOfferte.GetListaDettagliOfferta();
            foreach (string dettaglio in dettagliOfferta) 
            {
                ds.SkillRichiestiProposteLavoroDettaglio.AddSkillRichiestiProposteLavoroDettaglioRow(dettaglio);
            }   
        }

        private void AggiungiRiga(DSReport ds, PropostaLavoro propostaLavoro)
        {
            if (propostaLavoro == null)
                return;
            ds.ProposteLavoro.AddProposteLavoroRow(propostaLavoro.DataDocumento,
                                                    ((propostaLavoro.Offerta == null) || (propostaLavoro.Offerta.AziendaRichiedente == null) || 
                                                    (propostaLavoro.Offerta.AziendaRichiedente.Descrizione == null)) ? "" : propostaLavoro.Offerta.AziendaRichiedente.Descrizione,
                                                        propostaLavoro.Abilita.Descrizione);
        }

        private void AddInfoUtente(DSReport ds) 
        {
            _ds.UtenteProposteLavoro.AddUtenteProposteLavoroRow(((PropostaLavoro)_listaProposteLavoro[0]).Utente.IdUtente,
                                                    ((((PropostaLavoro)_listaProposteLavoro[0]).Utente == null) ||
                                                    (((PropostaLavoro)_listaProposteLavoro[0]).Utente.CompleteName == null)) ? "" :
                                                    ((PropostaLavoro)_listaProposteLavoro[0]).Utente.CompleteName);

        }

    }
}
