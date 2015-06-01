using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ReportsPage
{
    [TestClass]
    public class Reports_ISDAReports : DemoTestingProject
    {
        [TestMethod]
        public void ISDAReports()
        {
            //Client Entity NAV Triggers
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions0();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //CounterParty NAV Triggers
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions1();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Key Person Client Entity
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions2();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Key Person Counterparty
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions3();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //////All Client Entity Termination Events
            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            ////Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            ////Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions4();
            ////Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements1();
            ////Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //////All Counterparty Termination Events
            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            ////Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            ////Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions5();
            ////Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            ////DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements1();
            ////Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Cross-Default for Client Entity
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions6();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Cross Default for Counterparty
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions7();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Cure peroids
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions8();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Calculation Agent Summary
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions9();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Calculation Agent Full provision
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions10();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Dispute Mechanism
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions11();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Fish or Cut Bait
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions12();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Rating Triggers
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions13();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //CDS Spreads
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions14();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Elective/Optional Termination Rights
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions15();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");


            //Renegotiate/FallBack Provisions
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoISDAReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCreatePredefinedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "ISDA Master Agreement Predefined Reports", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoAnswerISDAProvisions16();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Select Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSelectAgreements1();
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to return to home page");

        }
    }
}
