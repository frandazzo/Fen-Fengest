using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.ADMINISTRATION;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportPrestazioneView : Form
    {
        private ControllerPrestazioni _controller;

        public FrmReportPrestazioneView(ControllerPrestazioni controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorPrestazioni generatorPrestazioni;

            if (_controller != null) 
            {
                generatorPrestazioni = new ReportGenerator.GeneratorPrestazioni(_controller);
                ReportPrestazione1.SetDataSource(generatorPrestazioni.GeneraDataSet());
                generatorPrestazioni.SetHeaderInfo(ReportPrestazione1);
                generatorPrestazioni.SetFooterInfo(ReportPrestazione1);
                crystalReportViewer1.ReportSource = ReportPrestazione1;
            }
        }
    }
}