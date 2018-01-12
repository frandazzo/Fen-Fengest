using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.ADMINISTRATION;
using CrystalDecisions.CrystalReports.Engine;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportVertenzaView : Form
    {

        private ControllerVertenze _controller;
        bool _IncludiElencoEventi = false;
        bool _IncludiIstitutiContrattuali = false;
        DSReport _DataSet;

        public FrmReportVertenzaView(ControllerVertenze controller, bool includiElencoEventi, bool includiIstitutiContrattuali)
        {
            InitializeComponent();
            _controller = controller;
            _IncludiElencoEventi = includiElencoEventi;
            _IncludiIstitutiContrattuali = includiIstitutiContrattuali;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorVertenze generatorVertenze = new ReportGenerator.GeneratorVertenze(_controller);
            _DataSet = generatorVertenze.GeneraDataSet();      
            ReportVertenza1.SetDataSource(_DataSet);
            generatorVertenze.SetHeaderInfo(ReportVertenza1);
            generatorVertenze.SetFooterInfo(ReportVertenza1);
            crystalReportViewer1.ReportSource = ReportVertenza1;

            SettingVisualizzazioneReport();
        }

        private void SettingVisualizzazioneReport()
        {
            ReportDocument subReportListaEventi = ReportVertenza1.Subreports["ReportEventiVertenza.rpt"];
            ReportDocument subReportListaIstitutiContrattuali = ReportVertenza1.Subreports["ReportIstitutiContrattualiVertenza.rpt"];
            if (_IncludiElencoEventi)
            {
                foreach (Evento evento in _controller.GetListaEventi())
                {
                    _DataSet.Evento.AddEventoRow(0, evento.DataDocumento,
                                                    evento.Note == null ? "" : evento.Note,
                                                    evento.TipoEvento == null ? "" : evento.TipoEvento.Descrizione,
                                                    _controller.IdVertenza == null ? 0 : int.Parse(_controller.IdVertenza));
                }
                subReportListaEventi.SetDataSource(_DataSet);
                ReportVertenza1.OpenSubreport("ReportEventiVertenza.rpt");
            }
            if (_IncludiIstitutiContrattuali)
            {
                foreach (string descrizioneIstituto in _controller.GetListaIstituti())
                {
                    _DataSet.Istituto.AddIstitutoRow(descrizioneIstituto == null ? "" : descrizioneIstituto,
                                                        _controller.IdVertenza == null ? 0 : int.Parse(_controller.IdVertenza),
                                                        0);
                }
                subReportListaIstitutiContrattuali.SetDataSource(_DataSet);
                ReportVertenza1.OpenSubreport("ReportIstitutiContrattualiVertenza.rpt");
            }

        }
    }
}