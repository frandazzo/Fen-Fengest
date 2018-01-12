using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.AZIENDE;
using CrystalDecisions.CrystalReports.Engine;
using WIN.APPLICATION.UTENTI;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportAnagraficaAziendaView : Form
    {
        private ControllerAziende _controller;

        bool _IncludiElencoSediOperative = false;
        bool _IncludiCompetenzaUltimoPagamento = false;

        DSReport _DataSet;

        public FrmReportAnagraficaAziendaView(ControllerAziende azienda, bool includiElencoSediOperative, bool includiCompetenzaUltimoPagamento)
        {
            InitializeComponent();
            _controller = azienda;
            _IncludiCompetenzaUltimoPagamento = includiCompetenzaUltimoPagamento;
            _IncludiElencoSediOperative = includiElencoSediOperative;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            ReportGenerator.GeneratorAnagraficaAzienda generatorAnagraficaAzienda = new ReportGenerator.GeneratorAnagraficaAzienda(_controller);
            _DataSet = generatorAnagraficaAzienda.GeneraDataSet();
            ReportAnagraficaAzienda1.SetDataSource(_DataSet);
            generatorAnagraficaAzienda.SetHeaderInfo(ReportAnagraficaAzienda1);
            generatorAnagraficaAzienda.SetFooterInfo(ReportAnagraficaAzienda1);
            crystalReportViewer1.ReportSource = ReportAnagraficaAzienda1;
            SettingVisualizzazioneReport();
        }

        private void SettingVisualizzazioneReport()
        {
            ReportDocument subReportListaSediOperative = ReportAnagraficaAzienda1.Subreports["ReportListaSediOperative.rpt"];
            if (_IncludiElencoSediOperative)
            {
                foreach (SedeOperativa sede in _controller.GetListaSediOperative())
                {
                    _DataSet.SedeOperativa.AddSedeOperativaRow(sede.Descrizione, sede.Indirizzo.Nazione.Descrizione, sede.Indirizzo.Cap,
                                                                sede.Indirizzo.Comune.Descrizione, sede.Indirizzo.Via, sede.Indirizzo.Provincia.Descrizione);
                }
                subReportListaSediOperative.SetDataSource(_DataSet);
                ReportAnagraficaAzienda1.OpenSubreport("ReportListaSediOperative.rpt");
            }
            if (!_IncludiCompetenzaUltimoPagamento)
            {
                TextObject textCompetenzaUltimoPagamento = (TextObject)ReportAnagraficaAzienda1.Section2.ReportObjects["TextCompetenzaUltimoPagamento"];
                FieldObject textCompetenzaUltimoPagamentoValore = (FieldObject)ReportAnagraficaAzienda1.Section2.ReportObjects["TextCompetenzaUltimoPagamentoValore"];
                TextObject textScarto = (TextObject)ReportAnagraficaAzienda1.Section2.ReportObjects["TextScarto"];
                FieldObject textScartoValore = (FieldObject)ReportAnagraficaAzienda1.Section2.ReportObjects["TextScartoValore"];
                textCompetenzaUltimoPagamento.Text = "";
                textCompetenzaUltimoPagamentoValore.Height = 0;
                textScarto.Text = "";
                textScartoValore.Height = 0;
            }
        }
    }
}