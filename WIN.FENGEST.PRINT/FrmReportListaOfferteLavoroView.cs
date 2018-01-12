using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION;
using System.Collections;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportListaOfferteLavoroView : Form
    {

        private IList _listaOfferte;

        public FrmReportListaOfferteLavoroView(IList listaOfferte)
        {
            InitializeComponent();
            _listaOfferte = listaOfferte;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorOfferteLavoro generatorOfferteLavoro;

            if (_listaOfferte != null) 
            {
                generatorOfferteLavoro = new ReportGenerator.GeneratorOfferteLavoro(_listaOfferte);
                ReportListaOfferteLavoro1.SetDataSource(generatorOfferteLavoro.GeneraDataSet());
                generatorOfferteLavoro.SetHeaderInfo(ReportListaOfferteLavoro1);
                generatorOfferteLavoro.SetFooterInfo(ReportListaOfferteLavoro1);
                crystalReportViewer1.ReportSource = ReportListaOfferteLavoro1;
            }
        }
    }
}