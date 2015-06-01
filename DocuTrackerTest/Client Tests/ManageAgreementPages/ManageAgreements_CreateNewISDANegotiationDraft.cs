using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DocuTrackerTest.Client_Tests.ManageAgreementPages
{
    [TestClass]
   public class  ManageAgreements_CreateNewISDANegotiationDraft :ClientLogin
    {
        [TestMethod]
        public void ManageAgreementsCreateISDANegotiationDrafts()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateISDANegotiationDrafts();
            Assert.AreEqual(ManagePage.Title, "Create ISDA Negotiation Draft", "Title did not match");

            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewDraftVersion();
        }
    }
}
