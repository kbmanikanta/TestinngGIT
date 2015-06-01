using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_ReopenApprovedPB : DemoTestingProject
    {
        [TestMethod]
        public void ReopenApprovedPB()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoReopenApprovedPB();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Approved Agreements", "Title did not match");
        }
    }
}
