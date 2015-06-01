using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ArchivendDelete
{
    [TestClass]
    public class ArchivendDelete_ISDAArchive : DemoTestingProject
    {
        [TestMethod]
        public void ISDAArchive()
        {
            DocuTrackerAutomation.Pages.ArchivendDeletePage.ArchivePage.GotoISDAArchive();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ArchivendDeletePage.DeletePage.Title, "Archive Client Agreements", "Title did not match");
        }
    }
}
