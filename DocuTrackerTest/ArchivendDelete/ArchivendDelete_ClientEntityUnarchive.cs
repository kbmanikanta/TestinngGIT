using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class ArchivendDelete_ClientEntityUnarchive : DemoTestingProject
    {
        [TestMethod]
        public void ClientEntityUnarchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoClientEntityUnarchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archived Client Entities", "Title did not match");
        }
    }
}
