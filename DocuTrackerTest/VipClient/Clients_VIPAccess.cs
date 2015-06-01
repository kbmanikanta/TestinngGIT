using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ClientsPage
{
    [TestClass]
    public class Clients_VIPAccess : DemoTestingProject
    {
        [TestMethod]
        public void NewClient()
        {
            DocuTrackerAutomation.Pages.ClientPage.ClientsPage.GotoVIPAccess();
            Assert.AreEqual(DocuTrackerAutomation.Pages.ClientPage.Clientpage.Title, "Clients", "Title did not match");
        }
    }
}
