using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_CounterpartiesList : DemoTestingProject
    {
        [TestMethod]
        public void CounterpartiesList()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoCounterpartiesList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Total List of Counterparties", "Title did not match");
        }
    }
}
