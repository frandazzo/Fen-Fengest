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
    public partial class FrmReportAnagraficaDelegaAccettataView : Form
    {
        private ControllerDeleghe _controller;

        public FrmReportAnagraficaDelegaAccettataView(ControllerDeleghe delega)
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
                ReportAnagraficaDelegaAccettata1.SetDataSource(generatorAnagraficaDelega.GeneraDataSet());
                generatorAnagraficaDelega.SetHeaderInfo(ReportAnagraficaDelegaAccettata1);
                generatorAnagraficaDelega.SetFooterInfo(ReportAnagraficaDelegaAccettata1);
                crystalReportViewer1.ReportSource = ReportAnagraficaDelegaAccettata1;
            }
        }
    }
}