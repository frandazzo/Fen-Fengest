using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportNonIscrittiDTO : Form
    {
        private IList _ListaNonIscritti;

        public FrmReportNonIscrittiDTO(IList listaNonIscritti)
        {
            InitializeComponent();
            _ListaNonIscritti = listaNonIscritti;
        }


       

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorReportLavoratoriLiberi   generator;
            if (_ListaNonIscritti != null)
            {
                generator = new ReportGenerator.GeneratorReportLavoratoriLiberi(_ListaNonIscritti);
                ReportNonIscrittiDTO1.SetDataSource(generator.GeneraDataSet());
                generator.SetHeaderInfo(ReportNonIscrittiDTO1);
                generator.SetFooterInfo(ReportNonIscrittiDTO1);
                crystalReportViewer1.ReportSource = ReportNonIscrittiDTO1;
            }
        }
    }
}
