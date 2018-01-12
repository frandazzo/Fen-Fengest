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
    public partial class FrmReportTipiComunicazioneView : Form
    {

        private ControllerTipoComunicazione _controller;

        public FrmReportTipiComunicazioneView(ControllerTipoComunicazione controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorTipiComunicazione generatorTipiComunicazione;

            if (_controller != null) 
            {
                generatorTipiComunicazione = new ReportGenerator.GeneratorTipiComunicazione(_controller.GetAll());
                ReportTipiComunicazione1.SetDataSource(generatorTipiComunicazione.GeneraDataSet());
                generatorTipiComunicazione.SetHeaderInfo(ReportTipiComunicazione1);
                generatorTipiComunicazione.SetFooterInfo(ReportTipiComunicazione1);
                crystalReportViewer1.ReportSource = ReportTipiComunicazione1;
            }
        }
    }

}