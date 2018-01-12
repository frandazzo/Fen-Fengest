using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using WIN.APPLICATION;


namespace WIN.GUI.PRINT.ReportGenerator
{
    public class ReportInfo
    {
        ControllerSegreteria controller = new ControllerSegreteria();

        public void SetHeaderInfo(ReportClass report) 
        {
            controller.LoadById("1");

            ReportObjects obj = report.ReportDefinition.Sections[0].ReportObjects;
            TextObject txtBoxHeaderTextPersonalizzato = (TextObject)obj["HeaderTextPersonalizzato"];
            //txtBoxHeaderTextPersonalizzato.Text = ReportSettings.Default.ReportTitlePersonalizzato;
            txtBoxHeaderTextPersonalizzato.Text = controller.Sottotitolo3;


            ReportObjects obj1 = report.ReportDefinition.Sections[0].ReportObjects;
            TextObject txtBoxHeaderTextTitle = (TextObject)obj1["HeaderTextTitle"];
            //txtBoxHeaderTextTitle.Text = ReportSettings.Default.ReportTitle;
            txtBoxHeaderTextTitle.Text = controller.Intestazione; 

            ReportObjects obj2 = report.ReportDefinition.Sections[0].ReportObjects;
            TextObject txtBoxHeaderTextSubTitle = (TextObject)obj2["HeaderTextSubTitle"];
//            txtBoxHeaderTextSubTitle.Text = ReportSettings.Default.ReportSubTitle;
            txtBoxHeaderTextSubTitle.Text = controller.Sottotitolo1;

            ReportObjects obj3 = report.ReportDefinition.Sections[0].ReportObjects;
            TextObject txtBoxHeaderTextSubTitle2 = (TextObject)obj3["HeaderTextSubTitle2"];
            //txtBoxHeaderTextSubTitle2.Text = ReportSettings.Default.ReportSubTittle2;
            txtBoxHeaderTextSubTitle2.Text = controller.Sottotitolo2; 

        }

        public void SetFooterInfo(ReportClass report) 
        {
            
            controller.LoadById("1");

            ReportObjects obj1 = report.ReportDefinition.Sections[4].ReportObjects;
            TextObject txtBoxFooter = (TextObject)obj1["FooterText"];

            txtBoxFooter.Text = controller.ViaLegale + " - " +
                                controller.ComuneLegale  + " - " +
                                controller.TelefonoUfficio +  controller.Fax + " - " +
                                controller.IndirizzoWEB  + " - " +
                                controller.Mail;
            txtBoxFooter.Width = 11000;

        }

    }
}
