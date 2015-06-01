using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_PBCounterpartiesList : DemoTestingProject
    {
        [TestMethod]
        public void PBCounterpartiesList()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoPBCounterpartiesList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Total List of Counterparties", "Title did not match");
        }
    }
}
