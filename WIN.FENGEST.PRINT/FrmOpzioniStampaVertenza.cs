using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WIN.GUI.PRINT
{
    public partial class FrmOpzioniStampaVertenza : Form
    {
        bool _IncludiElencoEventi = false;
        bool _IncludiIstitutiContrattuali = false;


        public bool IncludiElencoEventi
        {
            get { return _IncludiElencoEventi; }
        }

        public bool IncludiIstitutiContrattuali
        {
            get { return _IncludiIstitutiContrattuali; }
        }

        public FrmOpzioniStampaVertenza()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            _IncludiElencoEventi = checkBoxIncludiElencoEventi.Checked;
            _IncludiIstitutiContrattuali = checkBoxIncludiIstitutiContrattuali.Checked;
        }
    }
}