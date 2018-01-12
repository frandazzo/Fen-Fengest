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
    public partial class FrmReportListaVertenzeView : Form
    {
        private IList _listaVertenze;

        public FrmReportListaVertenzeView(IList listaVertenze)
        {
            InitializeComponent();
            _listaVertenze = listaVertenze;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorVertenze generatorVertenze;

            if (_listaVertenze != null)
            {
                generatorVertenze = new ReportGenerator.GeneratorVertenze(_listaVertenze);
                ReportListaVertenze1.SetDataSource(generatorVertenze.GeneraDataSet());
                generatorVertenze.SetHeaderInfo(ReportListaVertenze1);
                generatorVertenze.SetFooterInfo(ReportListaVertenze1);
                crystalReportViewer1.ReportSource = ReportListaVertenze1;
            }
        }
    }
}