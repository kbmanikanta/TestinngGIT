using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AgreementSettingsPage
{
    [TestClass]
    public class Agreement_Settings_PBDocumentTypesforUploading : DemoTestingProject
    {
        [TestMethod]
        public void PBDocumentTypesforUploading()
        {
            DocuTrackerAutomation.Pages.AgreementSettingspage.AgreementsPage.GotoPBDocumentTypesforUploading();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AgreementSettingspage.Settings.Title, "PB Agreement Document Types", "Title did not match");
        }
    }
}
