using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AuditLogsPage
{
    [TestClass]
    public class AuditLogs_AmendedPBAgreements : DemoTestingProject
    {
        [TestMethod]
        public void AmendedPBAgreements()
        {
            DocuTrackerAutomation.Pages.AuditLogs.AuditLogsPage.GotoAmmendedPBAgreements();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Amended Agreements", "Title did not match");
        }
    }
}
