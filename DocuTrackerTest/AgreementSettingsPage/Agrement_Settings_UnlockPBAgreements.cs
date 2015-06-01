using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agrement_Settings_UnlockPBAgreements : DemoTestingProject
    {
        [TestMethod]
        public void UnlockPBAgreements()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoUnlockPBAgreements();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "All Locked Agreements", "Title did not match");
        }
    }
}
