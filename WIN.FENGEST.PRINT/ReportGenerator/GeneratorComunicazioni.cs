using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using WIN.DOMAIN.FED_SERVICES;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorComunicazioni : ReportInfo, IDSGenerator
    {
        private ControllerComunicazioni _controller;
        private IList _listaComunicazioni;
        private DSReport _ds;

        public GeneratorComunicazioni(ControllerComunicazioni controller) 
        {
            _controller = controller;
        }

        public GeneratorComunicazioni(IList listaComunicazioni)
        {
            _listaComunicazioni = listaComunicazioni;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaComunicazioni != null)
            {
                foreach (Comunicazione comunicazione in _listaComunicazioni)
                {
                    AggiungiRiga(_ds, comunicazione);
                }
            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerComunicazioni controller)
        {
            if (controller == null)
                return;
            ds.DettaglioComunicazioni.AddDettaglioComunicazioniRow(controller.IdComunicazione == null ? 0 : int.Parse(controller.IdComunicazione),
                                                                    controller.Data,
                                                                    controller.DescrizioneCausale == null ? "" : controller.DescrizioneCausale,
                                                                    controller.IdUtente == null ? 0 : int.Parse(controller.IdUtente),
                                                                    controller.DescrizioneTipo == null ? "" : controller.DescrizioneTipo,
                                                                    controller.NomeUtente == null ? "" : controller.NomeUtente,
                                                                    controller.Note == null ? "" : controller.Note);
        }

        private void AggiungiRiga(DSReport ds, Comunicazione comunicazione)
        {
            if (comunicazione == null)
                return;
            ds.Comunicazioni.AddComunicazioniRow(comunicazione.Id, 
                comunicazione.DataDocumento, 
                ((comunicazione.Causale==null)||(comunicazione.Causale.Descrizione==null)) ? "" : comunicazione.Causale.Descrizione,
                ((comunicazione.Tipo == null) || (comunicazione.Tipo.Descrizione == null)) ? "" : comunicazione.Tipo.Descrizione);

        }

    }
}
