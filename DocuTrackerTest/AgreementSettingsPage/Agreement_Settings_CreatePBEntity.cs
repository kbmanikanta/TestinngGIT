using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_CreatePBEntity : DemoTestingProject
    {
        [TestMethod]
        public void CreatePBEntity()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoCreatePBEntity();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "Create PB Entity", "Title did not match");
        }
    }
}
