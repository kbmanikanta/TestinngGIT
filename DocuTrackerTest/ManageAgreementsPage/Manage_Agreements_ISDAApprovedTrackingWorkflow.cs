using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.ManageAgreements;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_ISDAApprovedTrackingWorkflow : DemoTestingProject
    {
        [TestMethod]
        public void ManageAgreementsISDAApprovedTrackingWorkflow()
        {
            MangeAgreementsPage.GoToISDAApprovedTrackingWorkflow();
            Assert.AreEqual(ManagePage.Title, "ISDA Approved Agreement - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.SelectDropDowns();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSearchBox();
        }
    }
}
