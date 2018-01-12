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
    public partial class FrmReportListaTipiPrestazioniView : Form
    {
        private IList _listaTipiPrestazioni;

        public FrmReportListaTipiPrestazioniView(IList listaTipiPrestazioni)
        {
            InitializeComponent();
            _listaTipiPrestazioni = listaTipiPrestazioni;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorTipiPrestazioni generatorTipiPrestazioni;

            if (_listaTipiPrestazioni != null)
            {
                generatorTipiPrestazioni = new ReportGenerator.GeneratorTipiPrestazioni(_listaTipiPrestazioni);
                ReportListaTipiPrestazioni1.SetDataSource(generatorTipiPrestazioni.GeneraDataSet());
                generatorTipiPrestazioni.SetHeaderInfo(ReportListaTipiPrestazioni1);
                generatorTipiPrestazioni.SetFooterInfo(ReportListaTipiPrestazioni1);
                crystalReportViewer1.ReportSource = ReportListaTipiPrestazioni1;
            }
        }
    }
}