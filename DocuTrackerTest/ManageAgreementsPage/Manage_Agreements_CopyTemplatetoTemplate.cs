using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_CopyTemplatetoTemplate : DemoTestingProject
    {
        [TestMethod]
        public void CopyTemplatetoTemplate()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.CopyTemplatetoTemplate();
            Assert.AreEqual(ManagePage.Title1, "\"Copy Template to Template Agreement", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCopyTemplatePage();
        }
    }
}
