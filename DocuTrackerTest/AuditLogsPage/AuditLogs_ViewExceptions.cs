using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AuditLogsPage
{
    [TestClass]
    public class AuditLogs_ViewExceptions : DemoTestingProject
    {
        [TestMethod]
        public void ViewExceptions()
        {
            DocuTrackerAutomation.Pages.AuditLogs.AuditLogsPage.GotoExceptions();
            //Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archived Agreements", "Title did not match");
        }
    }
}
