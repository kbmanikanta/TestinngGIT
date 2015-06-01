using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ReportsPage
{
    [TestClass]
    public class Reports_SavedReports : DemoTestingProject
    {
        [TestMethod]
        public void SavedReports()
        {
            DocuTrackerAutomation.Pages.Reports.ReportsPage.GotoSavedReport();
            Assert.AreEqual(DocuTrackerAutomation.Pages.Reports.ReportPage.Title, "Client Reports", "Title did not match");
           
        }
    }
}
