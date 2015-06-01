using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class ArchivendDelete_PBNegotiationDraftUnarchive : DemoTestingProject
    {
        [TestMethod]
        public void PBNegotiationDraftUnarchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoPBNegotiationDraftUnarchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archived Agreements", "Title did not match");
        }
    }
}
