using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class ArchivendDelete_PBNegotiationDraftArchive : DemoTestingProject
    {
        [TestMethod]
        public void PBNegotiationDraftArchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoPBNegotiationDraftArchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archive Client Draft Agreements", "Title did not match");
        }
    }
}
