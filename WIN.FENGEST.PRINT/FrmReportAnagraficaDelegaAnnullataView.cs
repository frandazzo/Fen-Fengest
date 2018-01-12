using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.ADMINISTRATION;
using WIN.DOMAIN.FED_SERVICES;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportAnagraficaDelegaAnnullataView : Form
    {
        private ControllerDeleghe _controller;

        public FrmReportAnagraficaDelegaAnnullataView(ControllerDeleghe delega)
        {
            InitializeComponent();
            _controller = delega;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnagraficaDelega generatorAnagraficaDelega;
            if (_controller != null)
            {
                generatorAnagraficaDelega = new ReportGenerator.GeneratorAnagraficaDelega(_controller);
                ReportAnagraficaDelegaAnnullata1.SetDataSource(generatorAnagraficaDelega.GeneraDataSet());
                generatorAnagraficaDelega.SetHeaderInfo(ReportAnagraficaDelegaAnnullata1);
                generatorAnagraficaDelega.SetFooterInfo(ReportAnagraficaDelegaAnnullata1);
                crystalReportViewer1.ReportSource = ReportAnagraficaDelegaAnnullata1;
            }
        }
    }
}