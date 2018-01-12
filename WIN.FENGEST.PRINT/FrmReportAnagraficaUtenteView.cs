using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.UTENTI;
using CrystalDecisions.CrystalReports.Engine;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportAnagraficaUtenteView : Form
    {
        private ControllerUtenti _controller;

        bool _IncludiAttitudiniLavorative = false;
        bool _IncludiPreferenzeLavorative = false;
        DSReport _DataSet;

        public FrmReportAnagraficaUtenteView(ControllerUtenti controller, bool includiAttitudiniLavorative, bool includiPreferenzeLavorative)
        {
            InitializeComponent();
            _controller = controller;
            _IncludiAttitudiniLavorative = includiAttitudiniLavorative;
            _IncludiPreferenzeLavorative = includiPreferenzeLavorative;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnagraficaUtente generatorAnagraficaUtente = new ReportGenerator.GeneratorAnagraficaUtente(_controller);
            _DataSet = generatorAnagraficaUtente.GeneraDataSet();      
            ReportAnagraficaUtente1.SetDataSource(_DataSet);
            generatorAnagraficaUtente.SetHeaderInfo(ReportAnagraficaUtente1);
            generatorAnagraficaUtente.SetFooterInfo(ReportAnagraficaUtente1);

            crystalReportViewer1.ReportSource = ReportAnagraficaUtente1;
            SettingVisualizzazioneReport();
        }

        private void SettingVisualizzazioneReport()
        {
            ReportDocument subReportPreferenzeLavorative = ReportAnagraficaUtente1.Subreports["ReportPreferenzeUtente.rpt"];
            ReportDocument subReportAttitudini = ReportAnagraficaUtente1.Subreports["ReportAttitudiniUtente.rpt"];
            if (_IncludiAttitudiniLavorative)
            {
                foreach (KnowHow knowHow in _controller.GetListaAttitudini())
                {
                    _DataSet.Attitudine.AddAttitudineRow(_controller.IdUtente, knowHow.Abilita.Descrizione, knowHow.Livello.ToString());
                }
                subReportAttitudini.SetDataSource(_DataSet);
                ReportAnagraficaUtente1.OpenSubreport("ReportAttitudiniUtente.rpt");
            }
            if (_IncludiPreferenzeLavorative)
            {
                foreach (Preferenza preferenza in _controller.GetListaPreferenze())
                {
                    _DataSet.Preferenza.AddPreferenzaRow(preferenza.Utente.IdUtente, preferenza.Abilita.Descrizione, preferenza.Data, preferenza.Priorita.ToString());
                }
                subReportPreferenzeLavorative.SetDataSource(_DataSet);
                ReportAnagraficaUtente1.OpenSubreport("ReportPreferenzeUtente.rpt");
            }

        }
    }
}