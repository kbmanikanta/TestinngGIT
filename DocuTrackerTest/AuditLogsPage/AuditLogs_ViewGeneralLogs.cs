using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AuditLogsPage
{
    [TestClass]
    public class AuditLogs_ViewGeneralLogs : DemoTestingProject
    {
        [TestMethod]
        public void ViewGeneralLogs()
        {
            DocuTrackerAutomation.Pages.AuditLogs.AuditLogsPage.GotoGeneralLogs();
            //Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archived Agreements", "Title did not match");
        }
    }
}
