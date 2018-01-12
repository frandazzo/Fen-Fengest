using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.UTENTI;
using CrystalDecisions.CrystalReports.Engine;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnagraficaUtente : ReportInfo, IDSGenerator
    {
        private ControllerUtenti _controller;
        private DSReport _ds;

        bool _IncludiAttitudiniLavorative = false;
        bool _IncludiPreferenzeLavorative = false;

        public bool IncludiAttitudiniLavorative
        {
            get { return _IncludiAttitudiniLavorative; }
            set { _IncludiAttitudiniLavorative = value; }
        }

        public bool IncludiPreferenzeLavorative
        {
            get { return _IncludiPreferenzeLavorative; }
            set { _IncludiPreferenzeLavorative = value; }
        }

        public GeneratorAnagraficaUtente(ControllerUtenti controller) 
        {
            _controller = controller;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            _ds.Utente.AddUtenteRow(_controller.IdUtente,
                _controller.Cognome == null ? "" : _controller.Cognome,
                _controller.Nome == null ? "" : _controller.Nome,
                _controller.Nazionalita == null ? "" : _controller.Nazionalita,
                _controller.ProvinciaNascita == null ? "" : _controller.ProvinciaNascita,
                _controller.ProvinciaResidenza == null ? "" : _controller.ProvinciaResidenza,
                _controller.ViaResidenza == null ? "" : _controller.ViaResidenza,
                _controller.TelefonoCasa == null ? "" : _controller.TelefonoCasa,
                _controller.TelefonoUfficio == null ? "" : _controller.TelefonoUfficio,
                _controller.CapResidenza == null ? "" : _controller.CapResidenza,
                _controller.Sesso == null ? "" : _controller.Sesso,
                _controller.Mail == null ? "" : _controller.Mail,
                _controller.Valuta == null ? "" : _controller.Valuta,
                _controller.ImportoQuota,
                _controller.IdConto,
                _controller.ComuneResidenza == null ? "" : _controller.ComuneResidenza,
                _controller.ComuneNascita == null ? "" : _controller.ComuneNascita,
                _controller.Fax == null ? "" : _controller.Fax,                                   
                _controller.DataNascita,
                _controller.DescrizioneContoUtente == null ? "" : _controller.DescrizioneContoUtente,
                _controller.Cellulare1 == null ? "" : _controller.Cellulare1,
                _controller.Cellulare2 == null ? "" : _controller.Cellulare2,
                _controller.CompleteName == null ? "" : _controller.CompleteName.ToString(),
                _controller.CodiceFiscale == null ? "" : _controller.CodiceFiscale);
          
            return _ds;
        }

    }
}
