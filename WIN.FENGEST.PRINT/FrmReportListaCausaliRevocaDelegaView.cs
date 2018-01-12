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
    public partial class FrmReportListaCausaliRevocaDelegaView : Form
    {
        private IList _ListaCausaliRevoca;
        public FrmReportListaCausaliRevocaDelegaView(IList listaCausaliRevoca)
        {
            InitializeComponent();
            _ListaCausaliRevoca = listaCausaliRevoca;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorCausaliRevoca generatorCausaliRevoca;

            if (_ListaCausaliRevoca != null)
            {
                generatorCausaliRevoca = new ReportGenerator.GeneratorCausaliRevoca(_ListaCausaliRevoca);
                ReportListaCausaliRevocaDelega1.SetDataSource(generatorCausaliRevoca.GeneraDataSet());
                generatorCausaliRevoca.SetHeaderInfo(ReportListaCausaliRevocaDelega1);
                generatorCausaliRevoca.SetFooterInfo(ReportListaCausaliRevocaDelega1);
                crystalReportViewer1.ReportSource = ReportListaCausaliRevocaDelega1;
            }
        }
    }
}