using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_BenchmarkPBTerms : DemoTestingProject
    {
        [TestMethod]
        public void BenchmarkPBTerms()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.BenchmarkPBTerms();
            Assert.AreEqual(ManagePage.Title, "Benchmark PB Agreement", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoBenchmarkPage();
        }
    }
}
