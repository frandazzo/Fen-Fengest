using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION;
using WIN.DOMAIN.FEDERATIONARTIFACTS;
using System.Collections;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorListeLavoro : ReportInfo, IDSGenerator
    {
        DSReport _ds;
        ControllerListaUtenti _controller;

        public GeneratorListeLavoro(ControllerListaUtenti controller)
        {
            _controller = controller;
        }

        #region IDSGenerator Membri di

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controller != null)
                AggiungiRighe(_ds, _controller);
            return _ds;

        }

        #endregion

        private void AggiungiRighe(DSReport ds, ControllerListaUtenti controller)
        {
            _ds.HeaderListaLavoro.AddHeaderListaLavoroRow(controller.Descrizione);
            IList listaUtenti = controller.GetListaUtenti();

            foreach(Utente utente in listaUtenti)
            {
                _ds.DettagliListaLavoro.AddDettagliListaLavoroRow(utente.IdUtente,
                                                                    utente.CompleteName == null ? "" : utente.CompleteName,
                                                                    utente.CodiceFiscale == null ? "" : utente.CodiceFiscale,
                                                                    utente.DataNascita, utente.Comunicazione.Cellulare1, utente.Comunicazione.Cellulare2,
                                                                    utente.Cognome, utente.Nome, utente.Nazionalita.Descrizione,
                                                                    utente.ComuneNascita.Descrizione, utente.ProvinciaNascita.Sigla,
                                                                    utente.Residenza.Provincia.Sigla, utente.Residenza.Comune.Descrizione,
                                                                    utente.Residenza.Via, utente.Residenza.Cap, utente.Codifica.CodificaCE, utente.Codifica.CodificaEC);

                                                                    

            }

        }

    }
}
