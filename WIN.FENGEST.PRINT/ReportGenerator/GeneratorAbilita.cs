using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAbilita : ReportInfo, IDSGenerator
    {
        private ControllerAbilita _controller;
        private IList _listaAbilita;
        private DSReport _ds;

        public GeneratorAbilita(ControllerAbilita controller) 
        {
            _controller = controller;
        }

        public GeneratorAbilita(IList listaAbilita)
        {
            _listaAbilita = listaAbilita;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaAbilita != null)
            {
                foreach (Abilita abilita in _listaAbilita)
                {
                    AggiungiRiga(_ds, abilita);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerAbilita controller)
        {
            if (controller == null)
                return;
            ds.Abilita.AddAbilitaRow(controller.Id,
                                    controller.Descrizione== null ? "" : controller.Descrizione);
        }

        private void AggiungiRiga(DSReport ds, Abilita abilita)
        {
            if (abilita == null)
                return;
            ds.Abilita.AddAbilitaRow(abilita.Id,
                                    abilita.Descrizione == null ? "" : abilita.Descrizione);

        }

    }
}
