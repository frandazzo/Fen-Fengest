using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.DOMAIN.FED_SERVICES;
using System.Collections;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportListaDelegheUtenteView : Form
    {
        private IList _ListaDeleghe;

        public FrmReportListaDelegheUtenteView(IList listaDeleghe)
        {
            InitializeComponent();
            _ListaDeleghe = listaDeleghe;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnagraficaDelega generatorAnagraficaDelega;
            if (_ListaDeleghe != null)
            {
                generatorAnagraficaDelega = new ReportGenerator.GeneratorAnagraficaDelega(_ListaDeleghe);
                ReportListaDelegheUtente1.SetDataSource(generatorAnagraficaDelega.GeneraDataSet());
                generatorAnagraficaDelega.SetHeaderInfo(ReportListaDelegheUtente1);
                generatorAnagraficaDelega.SetFooterInfo(ReportListaDelegheUtente1);
                crystalReportViewer1.ReportSource = ReportListaDelegheUtente1;
            }
        }
    }
}