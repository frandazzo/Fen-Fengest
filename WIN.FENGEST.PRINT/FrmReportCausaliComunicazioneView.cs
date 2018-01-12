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
    public partial class FrmReportCausaliComunicazioneView : Form
    {

        private ControllerCausaleComunicazione _controller;

        public FrmReportCausaliComunicazioneView(ControllerCausaleComunicazione controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorCausaliComunicazione generatorCausaliComunicazione;

            if (_controller != null) 
            {
                generatorCausaliComunicazione = new ReportGenerator.GeneratorCausaliComunicazione(_controller.GetAll());
                ReportCausaliComunicazione1.SetDataSource(generatorCausaliComunicazione.GeneraDataSet());
                generatorCausaliComunicazione.SetHeaderInfo(ReportCausaliComunicazione1);
                generatorCausaliComunicazione.SetFooterInfo(ReportCausaliComunicazione1);
                crystalReportViewer1.ReportSource = ReportCausaliComunicazione1;
            }
        }


    }
}