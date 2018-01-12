using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportComunicazioneView : Form
    {

        private ControllerComunicazioni _controller;

        public FrmReportComunicazioneView(ControllerComunicazioni controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorComunicazioni generatorComunicazioni;

            if (_controller != null) 
            {
                generatorComunicazioni = new ReportGenerator.GeneratorComunicazioni(_controller);
                ReportComunicazione1.SetDataSource(generatorComunicazioni.GeneraDataSet());
                generatorComunicazioni.SetHeaderInfo(ReportComunicazione1);
                generatorComunicazioni.SetFooterInfo(ReportComunicazione1);
                crystalReportViewer1.ReportSource = ReportComunicazione1;
            }
        }
    }
}