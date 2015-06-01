using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class Archivenddelete_ISDANegotiationDraftUnarchive : DemoTestingProject
    {
        [TestMethod]
        public void ISDANegotiationDraftUnarchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoISDANegotiationDraftUnarchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "UnArchive ISDA Draft Agreements", "Title did not match");
        }
    }
}
