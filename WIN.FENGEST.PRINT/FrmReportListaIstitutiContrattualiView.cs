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
    public partial class FrmReportListaIstitutiContrattualiView : Form
    {

        private IList _listaIstitutiContrattuali;

        public FrmReportListaIstitutiContrattualiView(IList listaIstitutiContrattuali)
        {
            InitializeComponent();
            _listaIstitutiContrattuali = listaIstitutiContrattuali;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorIstitutiContrattuali generatorIstitutiContrattuali;

            if (_listaIstitutiContrattuali != null)
            {
                generatorIstitutiContrattuali = new ReportGenerator.GeneratorIstitutiContrattuali(_listaIstitutiContrattuali);
                ReportListaIstitutiContrattuali1.SetDataSource(generatorIstitutiContrattuali.GeneraDataSet());
                generatorIstitutiContrattuali.SetHeaderInfo(ReportListaIstitutiContrattuali1);
                generatorIstitutiContrattuali.SetFooterInfo(ReportListaIstitutiContrattuali1);
                crystalReportViewer1.ReportSource = ReportListaIstitutiContrattuali1;
            }
        }
    }
}