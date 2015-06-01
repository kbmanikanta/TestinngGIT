using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.Client_Tests.ManageAgreementPages
{
    [TestClass]
   public  class ManageAgreements_CreateNewPBNegotiationDraft : ClientLogin
    {
   [TestMethod]
        public void CreateNewPBNegotiationDraft()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.CreateNewPBNegotiationDraft();
            Assert.AreEqual(ManagePage.Title, "Create PB Negotiation Draft", "Title did not match");

            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewDraftVersion();
        }
    }
}
