using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.ManageAgreements;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_BenchmarkISDATerms : DemoTestingProject
    {
        [TestMethod]
        public void ManageAgreementsBenchmarkISDATerms()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.Goto();
            Assert.AreEqual(ManagePage.Title, "Benchmark ISDA Master Agreement", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoBenchmarkPage();

        }
    }
}
