using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_CreateNewISDANegotiationDrafts : DemoTestingProject
    {
        [TestMethod]
        public void ManageAgreementsCreateISDANegotiationDrafts()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateISDANegotiationDrafts();
            Assert.AreEqual(ManagePage.Title, "Create ISDA Negotiation Draft", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewISDADraft();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewDraftVersion();
        }
    }
}
