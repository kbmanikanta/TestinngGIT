using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_ISDAAffiliate : DemoTestingProject
    {
        [TestMethod]
        public void Affiliate()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoAffiliate();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Register Affiliate", "Title did not match");
        }
    }
}
