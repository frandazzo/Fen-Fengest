using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WIN.GUI.PRINT
{
    public partial class FrmOpzioniStampaAnagraficaUtente : Form
    {
        bool _IncludiAttitudiniLavorative = false;
        bool _IncludiPreferenzeLavorative = false;

        public bool IncludiAttitudiniLavorative 
        {
            get { return _IncludiAttitudiniLavorative; }
        }

        public bool IncludiPreferenzeLavorative
        {
            get { return _IncludiPreferenzeLavorative; }
        }

        public FrmOpzioniStampaAnagraficaUtente()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            _IncludiAttitudiniLavorative = checkBoxAttitudiniLavorative.Checked;
            _IncludiPreferenzeLavorative = checkBoxPreferenzeLavorative.Checked;
        }

    }
}