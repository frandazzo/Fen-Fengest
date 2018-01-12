using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WIN.GUI.PRINT
{
    public partial class FrmOpzioniStampaPrestazioni : Form
    {
        bool _StampaElencoPrestazioni = false;
        bool _StampaDettagliPrestazioneSelezionata = false;

        public bool StampaElencoPrestazioni
        {
            get { return _StampaElencoPrestazioni; }
        }

        public bool StampaDettagliPrestazioneSelezionata
        {
            get { return _StampaDettagliPrestazioneSelezionata; }
        }

        public FrmOpzioniStampaPrestazioni()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            _StampaElencoPrestazioni = checkBoxStampaElenco.Checked;
            _StampaDettagliPrestazioneSelezionata = checkBoxDettagliPrestazione.Checked;
        }
    }
}