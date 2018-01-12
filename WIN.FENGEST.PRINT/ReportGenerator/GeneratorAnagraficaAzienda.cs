using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using WIN.APPLICATION.AZIENDE;

namespace WIN.GUI.PRINT.ReportGenerator
{
    public class GeneratorAnagraficaAzienda : ReportInfo, IDSGenerator
    {
        private ControllerAziende _controller;
        private DSReport _ds;


        public GeneratorAnagraficaAzienda(ControllerAziende controller) 
        {
            _controller = controller;
        }

        public DSReport GeneraDataSet()
        {
            _ds = new DSReport();
            _ds.Azienda.AddAziendaRow(_controller.IdAzienda, 
                                      _controller.IdConto, 
                                      _controller.IdSettoreContratto,
                                      _controller.Descrizione == null ? "" : _controller.Descrizione, 
                                      _controller.PartitaIva == null ? "" : _controller.PartitaIva,
                                      _controller.DescrizioneConto== null ? "" : _controller.DescrizioneConto , 
                                      _controller.DescrizioneContratto== null ? "" : _controller.DescrizioneContratto,
                                      _controller.ValutaConto== null ? "" : _controller.ValutaConto, 
                                      _controller.ProvinciaLegale== null ? "" : _controller.ProvinciaLegale,
                                      _controller.ViaLegale== null ? "" : _controller.ViaLegale, 
                                      _controller.CapLegale== null ? "" : _controller.CapLegale,
                                      _controller.ComuneLegale== null ? "" : _controller.ComuneLegale, 
                                      _controller.Scarto== null ? "" : _controller.Scarto,
                                      _controller.CompetenzaUltimoPagamento== null ? "" : _controller.CompetenzaUltimoPagamento);
            return _ds;
        }

    }
}
