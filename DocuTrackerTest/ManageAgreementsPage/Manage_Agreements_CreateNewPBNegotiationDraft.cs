using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_CreateNewPBNegotiationDraft : DemoTestingProject
    {
        [TestMethod]
        public void CreateNewPBNegotiationDraft()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.CreateNewPBNegotiationDraft();
            Assert.AreEqual(ManagePage.Title, "Create PB Negotiation Draft", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewPBDraft();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewDraftVersion();
        }
    }
}
