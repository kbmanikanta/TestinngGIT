using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_ISDAAffiliateEntities : DemoTestingProject
    {
        [TestMethod]
        public void ISDAAffiliateEntities()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoISDAAffiliateEntities();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Affiliate Entities", "Title did not match");
        }
    }
}
