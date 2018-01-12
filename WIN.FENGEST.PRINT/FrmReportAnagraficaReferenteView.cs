using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.FINANCIAL_ARTIFACTS;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportAnagraficaReferenteView : Form
    {
        private ControllerReferenti _controller;

        public FrmReportAnagraficaReferenteView(ControllerReferenti referente)
        {
            InitializeComponent();
            _controller = referente;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnagraficaReferente generatorAnagraficaReferente = new ReportGenerator.GeneratorAnagraficaReferente(_controller);
            ReportAnagraficaReferente1.SetDataSource(generatorAnagraficaReferente.GeneraDataSet());
            generatorAnagraficaReferente.SetHeaderInfo(ReportAnagraficaReferente1);
            generatorAnagraficaReferente.SetFooterInfo(ReportAnagraficaReferente1);
            crystalReportViewer1.ReportSource = ReportAnagraficaReferente1;
        }
    }
}