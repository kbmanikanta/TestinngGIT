using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_PBApprovedTrackingWorkflow : DemoTestingProject
    {
        [TestMethod]
        public void PBApprovedTrackingWorkflow()
        {
            MangeAgreementsPage.PBApprovedTrackingWorkflow();
            Assert.AreEqual(ManagePage.Title, "PB Approved Agreement - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSelectDropDowns();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSearchBox();
        }
    }
}
