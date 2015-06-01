using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_ReopenApprovedISDA : DemoTestingProject
    {
        [TestMethod]
        public void ReopenApprovedISDA()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoReopenApprovedISDA();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Approved Agreements", "Title did not match");
        }
    }
}
