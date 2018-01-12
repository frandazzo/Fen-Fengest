using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using WIN.DOMAIN.FEDERATIONARTIFACTS;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportIscrittiDTO : Form
    {
        private IList _ListaIscritti;

        public FrmReportIscrittiDTO(IList listaIscritti)
        {
            InitializeComponent();
            _ListaIscritti = listaIscritti;
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorReportIscritti  generator;
            if (_ListaIscritti != null)
            {
                generator = new ReportGenerator.GeneratorReportIscritti(_ListaIscritti);
                ReportIscrittiDTO1.SetDataSource(generator.GeneraDataSet());
                generator.SetHeaderInfo(ReportIscrittiDTO1);
                generator.SetFooterInfo(ReportIscrittiDTO1);
                crystalReportViewer1.ReportSource = ReportIscrittiDTO1;
            }
        }
    }
}
