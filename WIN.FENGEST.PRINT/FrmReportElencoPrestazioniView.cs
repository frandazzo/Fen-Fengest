using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.ADMINISTRATION;
using WIN.DOMAIN.FED_SERVICES;
using System.Collections.Generic;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportElencoPrestazioniView : Form
    {
        private IList _ListaPrestazioni;
        public FrmReportElencoPrestazioniView(IList listaPrestazioni)
        {
            InitializeComponent();
            _ListaPrestazioni = listaPrestazioni;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorPrestazioni generatorPrestazioni;

            if (_ListaPrestazioni != null)
            {
                generatorPrestazioni = new ReportGenerator.GeneratorPrestazioni(_ListaPrestazioni);
                ReportElencoPrestazioni1.SetDataSource(generatorPrestazioni.GeneraDataSet());
                generatorPrestazioni.SetHeaderInfo(ReportElencoPrestazioni1);
                generatorPrestazioni.SetFooterInfo(ReportElencoPrestazioni1);
                crystalReportViewer1.ReportSource = ReportElencoPrestazioni1;
            }
        }
    }
}