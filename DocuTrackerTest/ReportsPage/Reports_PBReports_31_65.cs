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
    public class Reports_PBReports_31_65 : DemoTestingProject
    {
        [TestMethod]
        public void PBReports31_65()
        {
            //Lockup Termination / Funding Types - Prime Broker Ratings
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision31();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements1();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - All(before/during Notice Period)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision32();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - All(before Notice Period)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision33();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - All(during Notice Period)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision34();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Fundability
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision35();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Corporate Bonds
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision36();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Loan Positions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision37();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - High Yield Positions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision38();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Convertible Bonds
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision39();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - LMV/SMV
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision40();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Pricing
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision41();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Minimum Debit Balance
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision42();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Size of position in portfolio
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision43();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Portfolio Limits - Size of positon/trading volume
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision44();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //portfolio limits - mimimum position requirements
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision45();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //portfolio limits - illiquid positions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision46();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //portfolio limits - Non-us positions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision47();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //portfolio limits - Em positions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision48();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //portfolio limits - other limits
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision49();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Notification Obligations (Client Entity)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision50();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Notice Information (Client Entity)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision51();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Notification Obligations (Prime Broker)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision52();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Notice Information (Prime Broker)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision53();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Transfer Timing (Client Entity)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision54();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Prime Broker Right to Transfer Collateral /Agreement
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision55();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Right to Excess Cash/Securities (Client Entity)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision56();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Rehypothetication Rights
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision57();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Delivary Obligations
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision58();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Cure Periods
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision59();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Dispute Mechanism
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision60();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Set off/Netting Provisions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision61();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Limitation of Liability
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision62();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //ERISA Provisions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision63();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Any Guatantees?
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision64();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Fish or Cut Bait Provisions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoPBPredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "PB Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectProvision65();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GetAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");
        }

    }
}
