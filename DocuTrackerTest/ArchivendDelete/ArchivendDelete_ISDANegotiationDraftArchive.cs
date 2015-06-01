using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class ArchivendDelete_ISDANegotiationDraftArchive : DemoTestingProject
    {
        [TestMethod]
        public void ISDANegotiationDraftArchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoISDANegotiationDraftArchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archive ISDA Draft Agreements", "Title did not match");
        }
    }
}
