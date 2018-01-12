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
    public partial class FrmReportPrestazioniDTO : Form
    {
        
        private IList _Lista;

        public FrmReportPrestazioniDTO(IList lista)
        {
            InitializeComponent();
            _Lista = lista;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
             ReportGenerator.GeneratorPrestazioniDTO  generator;
            if (_Lista != null)
            {
                generator = new ReportGenerator.GeneratorPrestazioniDTO(_Lista);
                ReportPrestaziniDTO1.SetDataSource(generator.GeneraDataSet());
                generator.SetHeaderInfo(ReportPrestaziniDTO1);
                generator.SetFooterInfo(ReportPrestaziniDTO1);
                crystalReportViewer1.ReportSource = ReportPrestaziniDTO1;
            }
        }
        

    

      
    }
}
