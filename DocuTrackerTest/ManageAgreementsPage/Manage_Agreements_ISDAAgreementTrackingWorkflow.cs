using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.ManageAgreements;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_ISDAAgreementTrackingWorkflow : DemoTestingProject
    {
        [TestMethod]
        public void ManageAgreementsISDATrackingWorkflow()
        {
            MangeAgreementsPage.GoToISDATrackingWorkflow();
            Assert.AreEqual(ManagePage.Title, "ISDA Agreement - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.SelectDropDowns();
            DocuTrackerAutomation.Driver.Refresh();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSearchBox();
        }
    }
}
