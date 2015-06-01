using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AuditLogsPage
{
    [TestClass]
    public class AuditLogs_ViewAuditLogs : DemoTestingProject
    {
        [TestMethod]
        public void ViewAuditLogs()
        {
            DocuTrackerAutomation.Pages.AuditLogs.AuditLogsPage.GotoViewAuditLogs();
            //Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archived Agreements", "Title did not match");
        }
    }
}
