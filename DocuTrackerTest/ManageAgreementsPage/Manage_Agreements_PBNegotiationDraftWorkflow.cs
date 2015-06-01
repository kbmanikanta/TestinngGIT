using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_PBNegotiationDraftWorkflow : DemoTestingProject
    {
        [TestMethod]
        public void PBNegotiationDraftWorkflow()
        {
            MangeAgreementsPage.PBNegotiationDraftWorkflow();
            Assert.AreEqual(ManagePage.Title, "PB Negotiation Draft - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSelectDropDowns();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSearchBox();
        }
    }
}
