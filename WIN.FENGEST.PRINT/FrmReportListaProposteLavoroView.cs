using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION;
using System.Collections;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportListaProposteLavoroView : Form
    {
        private ControllerProposte _controller;
        private IList _proposteLavoro;

        public FrmReportListaProposteLavoroView(IList proposteLavoro)
        {
            InitializeComponent();
            _proposteLavoro = proposteLavoro;
        }

        public FrmReportListaProposteLavoroView(ControllerProposte controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorProposteLavoro generatorProposteLavoro;

            if (_controller != null)
                generatorProposteLavoro = new ReportGenerator.GeneratorProposteLavoro(_controller.GetProposteByUtente(_controller.IdUtente));
            else
                generatorProposteLavoro = new ReportGenerator.GeneratorProposteLavoro(_proposteLavoro);

            ReportListaProposteLavoro1.SetDataSource(generatorProposteLavoro.GeneraDataSet());
            generatorProposteLavoro.SetHeaderInfo(ReportListaProposteLavoro1);
            generatorProposteLavoro.SetFooterInfo(ReportListaProposteLavoro1);
            crystalReportViewer1.ReportSource = ReportListaProposteLavoro1;

        }
    }
}