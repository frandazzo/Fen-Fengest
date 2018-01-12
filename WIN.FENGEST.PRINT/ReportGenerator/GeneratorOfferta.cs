using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorOfferta : ReportInfo, IDSGenerator
    {
    private ControllerOfferteLavoro _controller;
       
        private DSReport _ds;

        /// <summary>
        /// usato x generare il dettaglio dell'offerta selezionata dalla lista
        /// </summary>
        /// <param name="controller"></param>
        public GeneratorOfferta(ControllerOfferteLavoro controller) 
        {
            _controller = controller;
        }

       

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRiga(_ds, _controller);
           
            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerOfferteLavoro controller)
        {
            if (controller == null)
                return;
            ds.Offerta.AddOffertaRow (controller.Data.ToShortDateString(), 
                                                    controller.DescrizioneAzienda, 
                                                    controller.DataInizioValidita.ToShortDateString(), 
                                                    controller.DataFineValidita.ToShortDateString(), 
                                                    controller.Note);
            IList items = controller.GetItems();

            foreach (OffertaLavoroItem item in items)
            {
                ds.PosizioneOfferta.AddPosizioneOffertaRow(item.Abilita.Descrizione,item.Livello.Descrizione, item.NumeroPosti.ToString());
            }
        }

      

    }
}
