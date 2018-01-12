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
    public partial class FrmReportAnagraficaDelegaRevocataView : Form
    {
        private ControllerDeleghe _controller;

        public FrmReportAnagraficaDelegaRevocataView(ControllerDeleghe delega)
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
                ReportAnagraficaDelegaRevocata1.SetDataSource(generatorAnagraficaDelega.GeneraDataSet());
                generatorAnagraficaDelega.SetHeaderInfo(ReportAnagraficaDelegaRevocata1);
                generatorAnagraficaDelega.SetFooterInfo(ReportAnagraficaDelegaRevocata1);
                crystalReportViewer1.ReportSource = ReportAnagraficaDelegaRevocata1;
            }
        }
    }
}