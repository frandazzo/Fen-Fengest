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
    public partial class FrmReportListaComunicazioniView : Form
    {
        IList _listaComunicazioni;

        public FrmReportListaComunicazioniView(IList listaComunicazioni)
        {
            InitializeComponent();
            _listaComunicazioni = listaComunicazioni;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorComunicazioni generatorComunicazioni;

            if (_listaComunicazioni != null)
            {
                generatorComunicazioni = new ReportGenerator.GeneratorComunicazioni(_listaComunicazioni);
                ReportListaComunicazioni1.SetDataSource(generatorComunicazioni.GeneraDataSet());
                generatorComunicazioni.SetHeaderInfo(ReportListaComunicazioni1);
                generatorComunicazioni.SetFooterInfo(ReportListaComunicazioni1);
                crystalReportViewer1.ReportSource = ReportListaComunicazioni1;
            }
        }


    }
}