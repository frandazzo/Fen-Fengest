using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.REPORTING;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportLavoratoriLiberiView : Form
    {
        private ReportLiberi _controller;

        public FrmReportLavoratoriLiberiView(ReportLiberi controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorReportLavoratoriLiberi generatorReportLavoriLiberi;

            if (_controller != null) 
            {
                generatorReportLavoriLiberi = new ReportGenerator.GeneratorReportLavoratoriLiberi(_controller);
                ReportLavoratoriLiberi1.SetDataSource(generatorReportLavoriLiberi.GeneraDataSet());
                generatorReportLavoriLiberi.SetHeaderInfo(ReportLavoratoriLiberi1);
                generatorReportLavoriLiberi.SetFooterInfo(ReportLavoratoriLiberi1);
                crystalReportViewer1.ReportSource = ReportLavoratoriLiberi1;
            }
        }
    }
}