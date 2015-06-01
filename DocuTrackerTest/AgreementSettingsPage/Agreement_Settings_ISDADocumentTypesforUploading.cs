using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_ISDADocumentTypesforUploading : DemoTestingProject
    {
        [TestMethod]
        public void ISDADocumentTypes()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoISDADocumentTypesforUploading();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "ISDA Master Agreement Document Types", "Title did not match");
        }
    }
}
