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
    public partial class FrmReportListaRepartiView : Form
    {
        private IList _listaReparti;

        public FrmReportListaRepartiView(IList listaReparti)
        {
            InitializeComponent();
            _listaReparti = listaReparti;
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorReparti generatorReparti;

            if (_listaReparti != null)
            {
                generatorReparti = new ReportGenerator.GeneratorReparti(_listaReparti);
                ReportListaReparti1.SetDataSource(generatorReparti.GeneraDataSet());
                generatorReparti.SetHeaderInfo(ReportListaReparti1);
                generatorReparti.SetFooterInfo(ReportListaReparti1);
                crystalReportViewer1.ReportSource = ReportListaReparti1;
            }
        }
    }
}