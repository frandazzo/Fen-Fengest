using System;

using System.Text;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorVertenzeDTO: ReportInfo, IDSGenerator
    {
       
        private IList _listaVertenze;
        private DSReport _ds;


        public GeneratorVertenzeDTO(IList listaVertenze)
        {
            _listaVertenze = listaVertenze;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_listaVertenze != null)
            {
                foreach (VertenzaDTO p in _listaVertenze)
                {
                    AggiungiRiga(_ds, p);
                }

            }
            return _ds;
        }

        

        private void AggiungiRiga(DSReport ds, VertenzaDTO  p)
        {
            ds.VertenzeDTO.AddVertenzeDTORow(p.Id.ToString(), p.DataRegistrazione, p.DataDocumento, p.Utente, p.Responsabile, p.Referente, p.Azienda, p.PeriodoVertenza);
               
                
        }
    }
}
