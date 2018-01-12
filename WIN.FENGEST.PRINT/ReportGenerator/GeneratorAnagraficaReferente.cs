using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using WIN.APPLICATION.FINANCIAL_ARTIFACTS;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnagraficaReferente : ReportInfo, IDSGenerator
    {
        private ControllerReferenti _controller;
        private DSReport _ds;

        public GeneratorAnagraficaReferente(ControllerReferenti controller) 
        {
            _controller = controller;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();
            _ds.Referente.AddReferenteRow(
                _controller.IdReferente, 
                _controller.IdConto, 
                _controller.IdUltimoRistorno,                                           
                _controller.Cognome == null ? "" : _controller.Cognome, 
                _controller.Nome == null ? "" : _controller.Nome, 
                _controller.CompleteName == null ? "" : _controller.CompleteName, 
                _controller.ComponenteStruttura,
                _controller.DescrizioneConto == null ? "" : _controller.DescrizioneConto,
                _controller.PercRistornoDeleghe == null ? "" : _controller.PercRistornoDeleghe,
                _controller.PercRistornoDelegheImpFissi == null ? "" : _controller.PercRistornoDelegheImpFissi,
                _controller.PercRistornoDelegheVertenza == null ? "" : _controller.PercRistornoDelegheVertenza,
                _controller.PercRistornoDelegheInps == null ? "" : _controller.PercRistornoDelegheInps);
            return _ds;
        }

    }
}
