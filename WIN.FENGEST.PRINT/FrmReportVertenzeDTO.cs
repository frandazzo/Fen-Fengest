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
    public partial class FrmReportVertenzeDTO : Form
    {
        private IList _Lista;

        public FrmReportVertenzeDTO(IList lista)
        {
            InitializeComponent();
            _Lista = lista;
        }
        

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
          ReportGenerator.GeneratorVertenzeDTO   generator;
            if (_Lista != null)
            {
                generator = new ReportGenerator.GeneratorVertenzeDTO(_Lista);
                ReportVertenzeDTO1.SetDataSource(generator.GeneraDataSet());
                generator.SetHeaderInfo(ReportVertenzeDTO1);
                generator.SetFooterInfo(ReportVertenzeDTO1);
                crystalReportViewer1.ReportSource = ReportVertenzeDTO1;
            }
        }
    }
}
