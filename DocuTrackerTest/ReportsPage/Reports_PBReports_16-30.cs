using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuTrackerTest.ReportsPage
{
    [TestClass]
    public class Reports_PBReports_16_30 : DemoTestingProject
    {
        [TestMethod]
        public void PBReports16_30()
        {
           
            //Scope of Lockup - Other Fees and Charges
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision16();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Total Return Swaps
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision17();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Events - NAV Decline Provisions (Client Entity)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision18();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Event - Cross Default (All)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision19();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");

            //EOD/Termination Events - Cross Default (Client Entity)
                        DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
                        Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

                        DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
                        Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

                        DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
                        Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

                        DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision20();
                        Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

                        DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
                        Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");



            //EOD/Termination Events - Cross Default (Prime Broker)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision21();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Events - Governmental Actions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision22();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Events- Key Person / IA
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision23();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Events - MAC Provisions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision24();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Reports - Bankruptacy Provisions (Client Entity)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision25();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //EOD/Termination Events - Bankruptcy Provisions (Prime Broker)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision26();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Lockup Termination / Funding Events - All Events (Client Entity Related)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision27();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Lockup Termination / Funding Events - All Events (Prime Broker Related)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision28();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Lockup Termination / Funding Types - Prime Broker CDS Spreads
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision29();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Lockup Termination / Funding Types - LIBOR-OIS
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision30();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");
        }
    }
}
