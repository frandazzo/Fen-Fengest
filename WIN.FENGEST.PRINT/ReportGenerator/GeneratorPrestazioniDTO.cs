using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorPrestazioniDTO: ReportInfo, IDSGenerator
    {
       
        private IList _listaPrestazioni;
        private DSReport _ds;


        public GeneratorPrestazioniDTO(IList listaPrestazioni)
        {
            _listaPrestazioni = listaPrestazioni;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_listaPrestazioni != null)
            {
                foreach (PrestazioneDTO p in _listaPrestazioni)
                {
                    AggiungiRiga(_ds, p);
                }

            }
            return _ds;
        }

        

        private void AggiungiRiga(DSReport ds, PrestazioneDTO  p)
        {
            ds.PrestazioniDTO.AddPrestazioniDTORow(p.Id.ToString(), p.DataRegistrazione, p.DataDocumento, p.Utente, p.TipoPrestazione, p.Referente);
               
                
        }
    }
}


