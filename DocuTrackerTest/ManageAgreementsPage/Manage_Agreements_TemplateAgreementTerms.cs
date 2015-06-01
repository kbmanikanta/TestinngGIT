using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_TemplateAgreementTerms : DemoTestingProject
    {
        [TestMethod]
        public void TemplateAgreementTerms()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.TemplateAgreementTerms();
            Assert.AreEqual(ManagePage.Title, "Template Agreement", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoTemplatePage();
        }
    }
}
