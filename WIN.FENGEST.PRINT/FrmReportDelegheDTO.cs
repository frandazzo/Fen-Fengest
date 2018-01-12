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
    public partial class FrmReportDelegheDTO : Form
    {
        private IList _ListaDeleghe;

        public FrmReportDelegheDTO(IList listaDeleghe)
        {
            InitializeComponent();
            _ListaDeleghe = listaDeleghe;
        }

    

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorDelegheDTO generatorAnagraficaDelega;
            if (_ListaDeleghe != null)
            {
                generatorAnagraficaDelega = new ReportGenerator.GeneratorDelegheDTO(_ListaDeleghe);
                ReportDelegheDTO1.SetDataSource(generatorAnagraficaDelega.GeneraDataSet());
                generatorAnagraficaDelega.SetHeaderInfo(ReportDelegheDTO1);
                generatorAnagraficaDelega.SetFooterInfo(ReportDelegheDTO1);
                crystalReportViewer1.ReportSource = ReportDelegheDTO1;
            }
        }
    }
}
