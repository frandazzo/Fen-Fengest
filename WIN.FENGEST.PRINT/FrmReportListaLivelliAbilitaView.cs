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
    public partial class FrmReportListaLivelliAbilitaView : Form
    {
        private IList _listaLivelliAbilita;

        public FrmReportListaLivelliAbilitaView(IList listaLivelliAbilita)
        {
            InitializeComponent();
            _listaLivelliAbilita = listaLivelliAbilita;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorLivelliAbilita generatorLivelliAbilita;

            if (_listaLivelliAbilita != null)
            {
                generatorLivelliAbilita = new ReportGenerator.GeneratorLivelliAbilita(_listaLivelliAbilita);
                ReportListaLivelliAbilita1.SetDataSource(generatorLivelliAbilita.GeneraDataSet());
                generatorLivelliAbilita.SetHeaderInfo(ReportListaLivelliAbilita1);
                generatorLivelliAbilita.SetFooterInfo(ReportListaLivelliAbilita1);
                crystalReportViewer1.ReportSource = ReportListaLivelliAbilita1;
            }
        }
    }
}