using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class ArchivendDelete_ClientUnarchive : DemoTestingProject
    {
        [TestMethod]
        public void ClientUnarchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoClientUnarchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archived Clients List", "Title did not match");
        }
    }
}
