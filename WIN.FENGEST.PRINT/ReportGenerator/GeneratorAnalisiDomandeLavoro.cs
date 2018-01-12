using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.UTENTI;
using WIN.APPLICATION;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnalisiDomandeLavoro : ReportInfo, IDSGenerator
    {
        private DSReport _ds;
        ControllerRicercheUtenti _controllerRicercheUtenti;
        string _idOfferta;

        public GeneratorAnalisiDomandeLavoro(ControllerRicercheUtenti controllerRicercheUtenti, string idOfferta) 
        {
            _controllerRicercheUtenti = controllerRicercheUtenti;
            _idOfferta = idOfferta;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();
            if ((_controllerRicercheUtenti != null) && (_controllerRicercheUtenti.GetSearchResult != null))
                AggiungiRiga(_ds, _controllerRicercheUtenti);

            return _ds;
        }

        private void AggiungiRiga(DSReport ds, ControllerRicercheUtenti controllerRicercheUtenti)
        {
            ds.AnalisiDomandeLavoro.AddAnalisiDomandeLavoroRow(int.Parse(_idOfferta),controllerRicercheUtenti.GetSkillPreferenza);

            foreach (Utente utente in controllerRicercheUtenti.GetSearchResult)
            {
                ds.UtentiAnalisiDomandeLavoro.AddUtentiAnalisiDomandeLavoroRow(utente.IdUtente, 
                    utente.Nome == null ? "" : utente.Nome, 
                    utente.Cognome == null ? "" :utente.Cognome);
            } 
            
                   
        }

    }
}
