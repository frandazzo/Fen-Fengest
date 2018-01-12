using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIN.GUI.PRINT.ReportGenerator;
using System.Collections;

namespace WIN.GUI.PRINT
{
    public partial class FrmReportIncassiQuoteView : Form
    {
        WIN.APPLICATION.REPORTING.ReportIncassiQuote _controller;
       

        public FrmReportIncassiQuoteView(WIN.APPLICATION.REPORTING.ReportIncassiQuote controller)
        {
            InitializeComponent();
            _controller = controller;
        }

       
        //public FrmReportIncassiQuoteView(WIN.APPLICATION.REPORTING.ReportIncassiQuote controller)
        //{
        //    InitializeComponent();
        //    _controller = controller;
        //}
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //ReportGenerator.GeneratorReportIscritti generatorReportIscritti;

            //if (_controller != null)
            //{
            //    generatorReportIscritti = new ReportGenerator.GeneratorReportIscritti(_controller);
            //    ReportIscritti1.SetDataSource(generatorReportIscritti.GeneraDataSet());
            //    generatorReportIscritti.SetHeaderInfo(ReportIscritti1);
            //    generatorReportIscritti.SetFooterInfo(ReportIscritti1);
            //    crystalReportViewer1.ReportSource = ReportIscritti1;
            //}
           
        }

        private void FrmReportIncassiQuoteView_Load(object sender, EventArgs e)
        {
          
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            GeneratorReportIncassiQuote generatorReportIncassiQuote;
            generatorReportIncassiQuote = new GeneratorReportIncassiQuote(_controller);
            WIN.GUI.PRINT.Report.ReportIncassiQuote ReportIncassiQuote = new WIN.GUI.PRINT.Report.ReportIncassiQuote();
            ReportIncassiQuote.SetDataSource(generatorReportIncassiQuote.GeneraDataSet());
            generatorReportIncassiQuote.SetHeaderInfo(ReportIncassiQuote);
            generatorReportIncassiQuote.SetFooterInfo(ReportIncassiQuote);
            crystalReportViewer1.ReportSource = ReportIncassiQuote;
            return;
        }
    }
}