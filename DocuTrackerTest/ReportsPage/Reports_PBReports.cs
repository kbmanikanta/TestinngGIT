using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ReportsPage
{
    [TestClass]
    public class Reports_PBReports : DemoTestingProject
    {
        [TestMethod]
        public void PBReports()
        {
            //General PB Agreement Information
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision0();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup (All Provisions)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision1();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Debit Balance
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision2();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - limit on Debit Balance
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision3();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Margin Requirements
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision4();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Methodology/Margin Terms
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision5();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Return of Excess Cash/Securities
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision6();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Free Credit Balances
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision7();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Stock Loan Rates
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision8();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Short Positions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision9();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Benchmark Rates
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision10();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Obligation to clear
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision11();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Right of Substitution
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision12();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of Lockup - Right to transfer Securities
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision13();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Scope of lockup - Right to obtain Financing
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision14();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");

            //Scope of Lockup - Minimum Net Equality
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision15();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


        }
    }
}
