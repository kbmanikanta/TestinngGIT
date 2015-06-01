using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_PBAgreementTrackingWorkflow : DemoTestingProject
    {
        [TestMethod]
        public void PBAgreementTrackingWorkflow()
        {
            MangeAgreementsPage.PBAgreementTrackingWorkflow();
            Assert.AreEqual(ManagePage.Title, "PB Agreement - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSelectDropDowns();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSearchBox();
        }
    }
}
