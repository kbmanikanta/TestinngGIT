using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.ManageAgreements;

namespace DocuTrackerTest.Client_Tests.ManageAgreementPages
{
    [TestClass]
    public class ManageAgreements_ISDATrackingWorkflow : ClientLogin
    {
        [TestMethod]
        public void ManageAgreementsISDATrackingWorkflow()
        {
            MangeAgreementsPage.GoToISDATrackingWorkflow();
            Assert.AreEqual(ManagePage.Title, "ISDA Agreement - Tracking Workflow", "Title did not match");
            DocuTrackerAutomation.Driver.Refresh();
        }
    }
}
