using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorTipiContratto : ReportInfo, IDSGenerator
    {
        private ControllerTipoContratto _controller;
        private IList _listaTipiContratto;
        private DSReport _ds;

        public GeneratorTipiContratto(ControllerTipoContratto controller) 
        {
            _controller = controller;
        }

        public GeneratorTipiContratto(IList listaTipiContratto)
        {
            _listaTipiContratto = listaTipiContratto;
        }

        #region IDSGenerator Membri di

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaTipiContratto != null)
            {
                foreach (TipoContratto contratto in _listaTipiContratto)
                {
                    AggiungiRiga(_ds, contratto);
                }
            }
            return _ds;
        }

        #endregion

        private void AggiungiRiga(DSReport ds, ControllerTipoContratto controller)
        {
            ds.TipoContratto.AddTipoContrattoRow(controller.Descrizione == null ? "" : controller.Descrizione,
                controller.DescrizioneSettore == null ? "" : controller.DescrizioneSettore);
        }

        private void AggiungiRiga(DSReport ds, TipoContratto tipoContratto)
        {
            ds.TipoContratto.AddTipoContrattoRow(tipoContratto.Descrizione == null ? "" : tipoContratto.Descrizione,
                                        tipoContratto.SettoreSpecifico == null ? "" : tipoContratto.SettoreSpecifico.Descrizione);
        }

    }
}
