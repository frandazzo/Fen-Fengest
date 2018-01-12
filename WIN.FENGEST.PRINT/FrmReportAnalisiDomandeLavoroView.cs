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
    public partial class FrmReportAnalisiDomandeLavoroView : Form
    {
        ControllerRicercheUtenti _controllerRicercheUtenti;
        string _idOfferta;

        public FrmReportAnalisiDomandeLavoroView(ControllerRicercheUtenti controllerRicercheUtenti, string idOfferta)
        {
            InitializeComponent();
            _controllerRicercheUtenti = controllerRicercheUtenti;
            _idOfferta = idOfferta;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnalisiDomandeLavoro generatorAnalisiDomandeLavoro;

            if (_controllerRicercheUtenti != null)
            {
                generatorAnalisiDomandeLavoro = new ReportGenerator.GeneratorAnalisiDomandeLavoro(_controllerRicercheUtenti, _idOfferta);
                ReportAnalisiDomandeLavoro1.SetDataSource(generatorAnalisiDomandeLavoro.GeneraDataSet());
                generatorAnalisiDomandeLavoro.SetHeaderInfo(ReportAnalisiDomandeLavoro1);
                generatorAnalisiDomandeLavoro.SetFooterInfo(ReportAnalisiDomandeLavoro1);
                crystalReportViewer1.ReportSource = ReportAnalisiDomandeLavoro1;
            }
        }
    }
}