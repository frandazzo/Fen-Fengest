using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorLivelliAbilita : ReportInfo, IDSGenerator
    {
        private ControllerLivelloAbilita _controller;
        private IList _listaLivelloAbilita;
        private DSReport _ds;

        public GeneratorLivelliAbilita(ControllerLivelloAbilita controller) 
        {
            _controller = controller;
        }

        public GeneratorLivelliAbilita(IList listaLivelloAbilita)
        {
            _listaLivelloAbilita = listaLivelloAbilita;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaLivelloAbilita != null)
            {
                foreach (LivelloAbilita livelloAbilita in _listaLivelloAbilita)
                {
                    AggiungiRiga(_ds, livelloAbilita);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerLivelloAbilita controller)
        {
            if (controller == null)
                return;
            ds.LivelloAbilita.AddLivelloAbilitaRow(controller.Id.ToString(),
                                    controller.Descrizione== null ? "" : controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, LivelloAbilita livelloAbilita)
        {
            if (_listaLivelloAbilita == null)
                return;
            ds.LivelloAbilita.AddLivelloAbilitaRow(livelloAbilita.Id.ToString(),
                                    livelloAbilita.Descrizione == null ? "" : livelloAbilita.Descrizione);

        }
    }
}
