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
    public partial class FrmReportOfferteLavoroView : Form
    {
        private ControllerOfferteLavoro _controller;

        public FrmReportOfferteLavoroView(ControllerOfferteLavoro controller)
        {
            InitializeComponent();
            _controller = controller;
        }

     

        private void FrmReportOfferteLavoroView_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorOfferteLavoro generatorOfferteLavoro;

            if (_controller != null) 
            {
                generatorOfferteLavoro = new ReportGenerator.GeneratorOfferteLavoro(_controller);

                DSReport d = generatorOfferteLavoro.GeneraDataSet();
                ReportOfferteLavoro2.SetDataSource(d);
                generatorOfferteLavoro.SetHeaderInfo(ReportOfferteLavoro2);
                generatorOfferteLavoro.SetFooterInfo(ReportOfferteLavoro2);
                crystalReportViewer1.ReportSource = ReportOfferteLavoro2;
            }
        }
    }
}