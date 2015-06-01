using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_UnlockISDAAgreements : DemoTestingProject
    {
        [TestMethod]  
        public void UnlockISDAAgreements()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoUnlockISDAAgreements();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "All Locked Agreements", "Title did not match");
        }
    }
}
