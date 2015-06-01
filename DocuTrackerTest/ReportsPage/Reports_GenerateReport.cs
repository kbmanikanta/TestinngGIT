using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ReportsPage
{
    [TestClass]
    public class Reports_GenerateReport : DemoTestingProject
    {
        [TestMethod]
        public void GenerateReport()
        {
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoGenerateReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Create Report", "Title did not match");

            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoCustomReports();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title1, "Step 1", "Title did not match");
            //CASE-1(ALL Agreements)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSteponeReport();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoLoadingTree();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectAgreements();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.AddAgreementstoSearch();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Select Fields for Inclusion in Report", "Title did not match");
            DocuTrackerAutomation.Driver.TurnOnWait3();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectQuestions();

            //CASE-2(ISDA)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSteponeReport1();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoLoadingTree();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectAgreements1();
            DocuTrackerAutomation.Driver.TurnOnWait1();
           DocuTrackerAutomation.Pages.Reports.ReportsPage.AddAgreementstoSearch();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Select Fields for Inclusion in Report", "Title did not match");
            DocuTrackerAutomation.Driver.TurnOnWait2();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectQuestions1();
            //CASE-3(PB)
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSteponeReport2();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoLoadingTree();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectAgreements2();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.AddAgreementstoSearch();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Select Fields for Inclusion in Report", "Title did not match");
            DocuTrackerAutomation.Driver.TurnOnWait2();
            DocuTrackerAutomation.Pages.Reports.ReportsPage.SelectQuestions2();
        }
    }
}
