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
    public partial class FrmReportOfferta : Form
    {
        public FrmReportOfferta(ControllerOfferteLavoro controller)
        {
            InitializeComponent();
             _controller = controller;
        }
        
        private ControllerOfferteLavoro _controller;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorOfferta generatorOfferteLavoro;

            if (_controller != null)
            {
                generatorOfferteLavoro = new ReportGenerator.GeneratorOfferta(_controller);

                DSReport d = generatorOfferteLavoro.GeneraDataSet();
                ReportOfferta1.SetDataSource(d);
                generatorOfferteLavoro.SetHeaderInfo(ReportOfferta1);
                generatorOfferteLavoro.SetFooterInfo(ReportOfferta1);
                crystalReportViewer1.ReportSource = ReportOfferta1;
            }
        }

       

    }
}
