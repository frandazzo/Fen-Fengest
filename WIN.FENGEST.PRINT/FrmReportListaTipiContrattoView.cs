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
    public partial class FrmReportListaTipiContrattoView : Form
    {
        IList _ListaTipiContratto;

        public FrmReportListaTipiContrattoView(IList listaTipiContratto)
        {
            InitializeComponent();
            _ListaTipiContratto = listaTipiContratto;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorTipiContratto generatorContratti;

            if (_ListaTipiContratto != null)
            {
                generatorContratti = new ReportGenerator.GeneratorTipiContratto(_ListaTipiContratto);
                ReportListaTipiContratto1.SetDataSource(generatorContratti.GeneraDataSet());
                generatorContratti.SetHeaderInfo(ReportListaTipiContratto1);
                generatorContratti.SetFooterInfo(ReportListaTipiContratto1);
                crystalReportViewer1.ReportSource = ReportListaTipiContratto1;
            }
        }
    }
}