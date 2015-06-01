using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_CreateCounterparty : DemoTestingProject
    {
        [TestMethod]
        public void CreateCounterparty()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoCreateCounterparty();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Create Counterparty", "Title did not match");
        }
    }
}
