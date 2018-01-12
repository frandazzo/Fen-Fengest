using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportIscrittiView : Form
    {
        private WIN.APPLICATION.REPORTING.ReportIscritti _controller;

        public FrmReportIscrittiView(WIN.APPLICATION.REPORTING.ReportIscritti controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorReportIscritti generatorReportIscritti;

            if (_controller != null)
            {
                generatorReportIscritti = new ReportGenerator.GeneratorReportIscritti(_controller);
                ReportIscritti1.SetDataSource(generatorReportIscritti.GeneraDataSet());
                generatorReportIscritti.SetHeaderInfo(ReportIscritti1);
                generatorReportIscritti.SetFooterInfo(ReportIscritti1);
                crystalReportViewer1.ReportSource = ReportIscritti1;
            }
        }
    }
}