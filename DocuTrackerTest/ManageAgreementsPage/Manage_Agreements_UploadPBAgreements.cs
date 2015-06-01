using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_UploadPBAgreements : DemoTestingProject
    {
        [TestMethod]
        public void UploadPBAgreements()
        {
            MangeAgreementsPage.UploadPBAgreements();
            Assert.AreEqual(ManagePage.Title, "Upload PB Agreements", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoSelectDropDowns();
        }
    }
}
