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
    public partial class FrmReportListaLavoroView : Form
    {

        private ControllerListaUtenti _controllerListaUtenti;

        public FrmReportListaLavoroView(ControllerListaUtenti controllerListaUtenti)
        {
            InitializeComponent();
            _controllerListaUtenti = controllerListaUtenti;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorListeLavoro generatorListeLavoro;

            if (_controllerListaUtenti != null)
            {
                generatorListeLavoro = new ReportGenerator.GeneratorListeLavoro(_controllerListaUtenti);
                ReportListaLavoro1.SetDataSource(generatorListeLavoro.GeneraDataSet());
                generatorListeLavoro.SetHeaderInfo(ReportListaLavoro1);
                generatorListeLavoro.SetFooterInfo(ReportListaLavoro1);
                crystalReportViewer1.ReportSource = ReportListaLavoro1;
            }
        }
    }
}