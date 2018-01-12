using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using WIN.APPLICATION;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorOfferteLavoro : ReportInfo, IDSGenerator
    {
        private ControllerOfferteLavoro _controller;
        private IList _listaOfferteLavoro;
        private DSReport _ds;

        /// <summary>
        /// usato x generare il dettaglio dell'offerta selezionata dalla lista
        /// </summary>
        /// <param name="controller"></param>
        public GeneratorOfferteLavoro(ControllerOfferteLavoro controller) 
        {
            _controller = controller;
        }

        /// <summary>
        /// usato x generare la lista delle offerte di lavoro
        /// </summary>
        /// <param name="listaOfferteLavoro"></param>
        public GeneratorOfferteLavoro(IList listaOfferteLavoro)
        {
            _listaOfferteLavoro = listaOfferteLavoro;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
            else if (_listaOfferteLavoro != null)
            {
                foreach (OffertaLavoro offertaLavoro in _listaOfferteLavoro)
                {
                    AggiungiRiga(_ds, offertaLavoro);
                }

            }
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerOfferteLavoro controller)
        {
            if (controller == null)
                return;
            ds.OfferteLavoro.AddOfferteLavoroRow(controller.Data, 
                                                    controller.DescrizioneAzienda==null ? "" : controller.DescrizioneAzienda, 
                                                    controller.DataInizioValidita, 
                                                    controller.DataFineValidita, 
                                                    controller.Note==null ? "" : controller.Note);
            IList items = controller.GetItems();

            foreach (OffertaLavoroItem item in items)
            {
                ds.PosizioniOfferteLavoro.AddPosizioniOfferteLavoroRow(item.Abilita.Descrizione,item.Livello.Descrizione, item.NumeroPosti.ToString());
            }
        }

        private void AggiungiRiga(DSReport ds, OffertaLavoro offertaLavoro)
        {
            if (offertaLavoro == null)
                return;
            ds.DettaglioAnalisiOfferteLavoro.AddDettaglioAnalisiOfferteLavoroRow(offertaLavoro.Id, 
                                                                                offertaLavoro.Data, 
                                                                                offertaLavoro.AziendaRichiedente.Descrizione, 
                                                                                offertaLavoro.Validita.Start.ToShortDateString() + " - " + offertaLavoro.Validita.Finish.ToShortDateString(), 
                                                                                offertaLavoro.GetNumeroTotalePosti);
        }




    }
}
