using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.ManageAgreements;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_UploadISDAAgreements : DemoTestingProject
    {
        [TestMethod]
        public void ManageAgreementsUploadISDAAgreements()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GoToUploadISDAAgreemnts();
            Assert.AreEqual(ManagePage.Title, "Upload ISDA Agreements", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.SelectDropDowns();
            DocuTrackerAutomation.Driver.TurnOnWait1();
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.UploadDocuments();
        }
    }
}
