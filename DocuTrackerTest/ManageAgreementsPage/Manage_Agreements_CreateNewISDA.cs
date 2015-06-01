using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.ManageAgreements;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_CreateNewISDA : DemoTestingProject
    {
        [TestMethod]
        public void ManageAgreementsCreateNewISDA()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GoTo();
            Assert.AreEqual(ManagePage.Title, "Create ISDA Master Agreement", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.CreateNewISDAAgreement();
        }
       
    }
}
