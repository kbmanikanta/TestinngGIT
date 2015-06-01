using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_ISDANegotiationDraftWorkflow : DemoTestingProject
    {
        [TestMethod]
        public void ISDANegotiationDraftWorkflow()
        {
            MangeAgreementsPage.GotoISDANegotiationDraftWorkflow();
            Assert.AreEqual(ManagePage.Title, "ISDA Negotiation Draft - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.SelectDropDowns();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSearchBox();
        }
    }
}
