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
    public partial class FrmReportListaAbilitaView : Form
    {

        private IList _listaAbilita;

        public FrmReportListaAbilitaView(IList listaAbilita)
        {
            InitializeComponent();
            _listaAbilita = listaAbilita;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAbilita generatorAbilita;

            if (_listaAbilita != null)
            {
                generatorAbilita = new ReportGenerator.GeneratorAbilita(_listaAbilita);
                ReportListaAbilita.SetDataSource(generatorAbilita.GeneraDataSet());
                generatorAbilita.SetHeaderInfo(ReportListaAbilita);
                generatorAbilita.SetFooterInfo(ReportListaAbilita);
                crystalReportViewer1.ReportSource = ReportListaAbilita;
            }
        }
    }
}