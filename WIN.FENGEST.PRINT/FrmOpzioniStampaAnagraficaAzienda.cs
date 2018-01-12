using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WIN.GUI.PRINT
{
    public partial class FrmOpzioniStampaAnagraficaAzienda : Form
    {
        bool _IncludiElencoSediOperative = false;
        bool _IncludiCompetenzaUltimoPagamento = false;

        public bool IncludiElencoSediOperative
        {
            get { return _IncludiElencoSediOperative; }
        }

        public bool IncludiCompetenzaUltimoPagamento
        {
            get { return _IncludiCompetenzaUltimoPagamento; }
        }

        public FrmOpzioniStampaAnagraficaAzienda()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            _IncludiElencoSediOperative = checkBoxElencoSediOperative.Checked;
            _IncludiCompetenzaUltimoPagamento = checkBoxCompetenzeUltimoPagamento.Checked;
        }
    }
}