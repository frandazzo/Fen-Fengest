using System;
using System.Collections.Generic;
using System.Text;

namespace WIN.GUI.PRINT
{
    public static class SettingsManager
    {




        #region Set

        public static void SetReportTitle(string reportTitle) 
        {
            ReportSettings.Default.ReportTitle = reportTitle;
        }

        public static void SetReportSubTitle(string subTitle)
        {
            ReportSettings.Default.ReportSubTitle = subTitle;
        }

        public static void SetReportSubTittle2(string subTittle2)
        {
            ReportSettings.Default.ReportSubTittle2 = subTittle2;
        }

        public static void SetReportTitlePersonalizzato(string reportTitlePersonalizzato)
        {
            ReportSettings.Default.ReportTitlePersonalizzato = reportTitlePersonalizzato;
        }

        public static void SetReportFooterTextVia(string reportFooterTextVia)
        {
            ReportSettings.Default.ReportFooterTextVia = reportFooterTextVia;
        }

        public static void SetReportFooterTextTelFax(string reportFooterTextTelFax)
        {
            ReportSettings.Default.ReportFooterTextTelFax = reportFooterTextTelFax;
        }

        public static void SetReportFooterTextSitoWeb(string reportFooterTextSitoWeb)
        {
            ReportSettings.Default.ReportFooterTextSitoWeb = reportFooterTextSitoWeb;
        }

        public static void SetReportFooterTextMail(string reportFooterTextMail)
        {
            ReportSettings.Default.ReportFooterTextMail = reportFooterTextMail;
        }

        public static void SetReportFooterTextCitta(string reportFooterTextCitta)
        {
            ReportSettings.Default.ReportFooterTextCitta = reportFooterTextCitta;
        }

        #endregion

        #region Get

        public static string GetReportTitle() 
        {
            return ReportSettings.Default.ReportTitle;
        }

        public static string GetReportSubTitle()
        {
            return ReportSettings.Default.ReportSubTitle;
        }

        public static string GetReportSubTittle2()
        {
            return ReportSettings.Default.ReportSubTittle2;
        }

        public static string GetReportTitlePersonalizzato()
        {
            return ReportSettings.Default.ReportTitlePersonalizzato;
        }

        public static string GetReportFooterTextVia()
        {
            return ReportSettings.Default.ReportFooterTextVia;
        }

        public static string GetReportFooterTextTelFax()
        {
            return ReportSettings.Default.ReportFooterTextTelFax;
        }

        public static string GetReportFooterTextSitoWeb()
        {
            return ReportSettings.Default.ReportFooterTextSitoWeb;
        }

        public static string GetReportFooterTextMail()
        {
            return ReportSettings.Default.ReportFooterTextMail;
        }

        public static string GetReportFooterTextCitta()
        {
            return ReportSettings.Default.ReportFooterTextCitta;
        }



        #endregion

    }
}
