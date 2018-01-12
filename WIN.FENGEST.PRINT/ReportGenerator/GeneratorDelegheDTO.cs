using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorDelegheDTO: ReportInfo, IDSGenerator
    {
       
        private IList _listaDeleghe;
        private DSReport _ds;


        public GeneratorDelegheDTO(IList listaDeleghe)
        {
            _listaDeleghe = listaDeleghe;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_listaDeleghe != null)
            {
                foreach (DelegadTO delega in _listaDeleghe)
                {
                    AggiungiRiga(_ds, delega);
                }

            }
            return _ds;
        }

        

        private void AggiungiRiga(DSReport ds, DelegadTO delega)
        {
            ds.DelegheDTO.AddDelegheDTORow(delega.Id.ToString(),
                delega.DataDocumento.ToShortDateString(), delega.Utente, delega.Settore, delega.EnteInoltro,
                delega.StatoDelega, delega.Referente, delega.Responsabile, delega.CausaleSottoscrizione,
                delega.Reparto, delega.DataRegistrazione.ToShortDateString(), delega.DataInoltro == DateTime.MinValue ? "" : delega.DataInoltro.ToShortDateString(), delega.DataAccettazioneDelega == DateTime.MinValue ? "" : delega.DataAccettazioneDelega.ToShortDateString(),
                delega.DataDecorrenzaDelega == DateTime.MinValue ? "" : delega.DataDecorrenzaDelega.ToShortDateString(), delega.DataAnnullamentoDelega == DateTime.MinValue ? "" : delega.DataAnnullamentoDelega.ToShortDateString(), delega.DataRevocaDelega == DateTime.MinValue ? "" : delega.DataRevocaDelega.ToShortDateString(),delega.Cellulare1 , delega.Cellulare2, delega.Nome ,delega.Cognome ,delega.DataNascita.ToShortDateString()  ,delega.Indirizzo ,delega.Nome_Nazione ,delega.Nome_Comune ,delega.Nome_Provincia, delega.Cap ,delega.Codice_Fiscale   );
                
        }
    }
}
