using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AuditLogsPage
{
    [TestClass]
    public class AuditLogs_AmmendedISDAAgreements : DemoTestingProject
    {
        [TestMethod]
        public void AmmendedISDAAgreements()
        {
            DocuTrackerAutomation.Pages.AuditLogs.AuditLogsPage.GotoAmmendedISDAAgreements();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Amended Agreements", "Title did not match");
        }
    }
}
