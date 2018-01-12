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
    public partial class FrmReportProposteLavoroView : Form
    {
        private ControllerProposte _controller;

        public FrmReportProposteLavoroView(ControllerProposte controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorProposteLavoro generatorProposteLavoro;

            if (_controller != null) 
            {
                generatorProposteLavoro = new ReportGenerator.GeneratorProposteLavoro(_controller);
                ReportProposteLavoro1.SetDataSource(generatorProposteLavoro.GeneraDataSet());
                generatorProposteLavoro.SetHeaderInfo(ReportProposteLavoro1);
                generatorProposteLavoro.SetFooterInfo(ReportProposteLavoro1);
                crystalReportViewer1.ReportSource = ReportProposteLavoro1;
            }
        }
    }
}