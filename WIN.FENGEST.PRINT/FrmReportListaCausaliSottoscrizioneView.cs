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
    public partial class FrmReportListaCausaliSottoscrizioneView : Form
    {
        private IList _ListaCausaliSottoscrizione;
        public FrmReportListaCausaliSottoscrizioneView(IList listaCausaliSottoscrizione)
        {
            InitializeComponent();
            _ListaCausaliSottoscrizione = listaCausaliSottoscrizione;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorCusaliSottoscrizione generatorCusaliSottoscrizione;

            if (_ListaCausaliSottoscrizione != null)
            {
                generatorCusaliSottoscrizione = new ReportGenerator.GeneratorCusaliSottoscrizione(_ListaCausaliSottoscrizione);
                ReportListaCausaliSottoscrizione1.SetDataSource(generatorCusaliSottoscrizione.GeneraDataSet());
                generatorCusaliSottoscrizione.SetHeaderInfo(ReportListaCausaliSottoscrizione1);
                generatorCusaliSottoscrizione.SetFooterInfo(ReportListaCausaliSottoscrizione1);
                crystalReportViewer1.ReportSource = ReportListaCausaliSottoscrizione1;
            }
        }
    }
}