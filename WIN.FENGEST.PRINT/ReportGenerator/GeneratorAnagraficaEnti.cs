using System;
using System.Collections.Generic;
using System.Text;
using WIN.APPLICATION.AZIENDE;
using WIN.APPLICATION;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnagraficaEnti : ReportInfo, IDSGenerator
    {
        private DSReport _ds;
        private ControllerEntiBilaterali _controllerEntiBilaterali;
        private ControllerInps _controllerImps;


        public GeneratorAnagraficaEnti(ControllerEntiBilaterali controller) 
        {
            _controllerEntiBilaterali = controller;
        }

        public GeneratorAnagraficaEnti(ControllerInps controller)
        {
            _controllerImps = controller;
        }


        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();

            if (_controllerEntiBilaterali != null)
                AggiungiRiga(_ds, _controllerEntiBilaterali);
            else if (_controllerImps != null)
                AggiungiRiga(_ds, _controllerImps);

            return _ds;
        }

        private void AggiungiRiga(DSReport ds,ControllerInps controller) 
        {
            _ds.AnagraficaEnte.AddAnagraficaEnteRow(controller.Descrizione == null ? "" : controller.Descrizione,
                controller.CompetenzaUltimoPagamento==null? "" : controller.CompetenzaUltimoPagamento);
        }

        private void AggiungiRiga(DSReport ds,ControllerEntiBilaterali controller) 
        {
            _ds.AnagraficaEnte.AddAnagraficaEnteRow(controller.Descrizione == null ? "" : controller.Descrizione,
                controller.CompetenzaUltimoPagamento == null ? "" : controller.CompetenzaUltimoPagamento);
        }
    }
}
