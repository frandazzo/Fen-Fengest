using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION;
using WIN.APPLICATION.UTENTI;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportAnalisiOfferteLavoroView : Form
    {
        ControllerUtenti _controllerUtenti;
        ControllerRicercheOfferte _controllerRicercheOfferte;

        public FrmReportAnalisiOfferteLavoroView(ControllerUtenti controllerUtenti, ControllerRicercheOfferte controllerRicercheOfferte)
        {
            InitializeComponent();
            _controllerUtenti = controllerUtenti;
            _controllerRicercheOfferte = controllerRicercheOfferte;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnalisiOfferteLavoro generatorOfferteLavoro;

            if (_controllerUtenti != null) 
            {
                generatorOfferteLavoro = new ReportGenerator.GeneratorAnalisiOfferteLavoro(_controllerUtenti, _controllerRicercheOfferte);
                ReportAnalisiOfferteLavoro1.SetDataSource(generatorOfferteLavoro.GeneraDataSet());
                generatorOfferteLavoro.SetHeaderInfo(ReportAnalisiOfferteLavoro1);
                generatorOfferteLavoro.SetFooterInfo(ReportAnalisiOfferteLavoro1);
                crystalReportViewer1.ReportSource = ReportAnalisiOfferteLavoro1;
            }
        }
    }
}