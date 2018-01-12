using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.APPLICATION.AZIENDE;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportAnagraficaEntiView : Form
    {
        public FrmReportAnagraficaEntiView()
        {
            InitializeComponent();
        }

        private ControllerEntiBilaterali _controllerEntiBilaterali;
        private ControllerInps _controllerInps;

        public FrmReportAnagraficaEntiView(ControllerEntiBilaterali controller)
        {
            InitializeComponent();
            _controllerEntiBilaterali = controller;
        }

        public FrmReportAnagraficaEntiView(ControllerInps controller)
        {
            InitializeComponent();
            _controllerInps = controller;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportGenerator.GeneratorAnagraficaEnti generatorAnagraficaEnti;

            if (_controllerEntiBilaterali != null)
                generatorAnagraficaEnti = new ReportGenerator.GeneratorAnagraficaEnti(_controllerEntiBilaterali);
            else 
                generatorAnagraficaEnti = new ReportGenerator.GeneratorAnagraficaEnti(_controllerInps);
            
            if((_controllerEntiBilaterali!=null)||(_controllerInps!=null))
            {
                ReportAnagraficaEnti1.SetDataSource(generatorAnagraficaEnti.GeneraDataSet());
                generatorAnagraficaEnti.SetHeaderInfo(ReportAnagraficaEnti1);
                generatorAnagraficaEnti.SetFooterInfo(ReportAnagraficaEnti1);
                crystalReportViewer1.ReportSource = ReportAnagraficaEnti1;
            }
        }
    }
}