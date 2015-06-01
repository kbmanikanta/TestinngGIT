using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation.Pages.SearchAgreements;

namespace DocuTrackerTest.SearchAgreementsPage
{
    [TestClass]
    public class Search_Agreements_Executed : DemoTestingProject
    {
        [TestMethod]
        public void SearchAgreementsExecuted()
        {
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GoTo();
            Assert.AreEqual(DocuTrackerAutomation.Pages.SearchAgreements.SearchPage.Title, "Search Agreements - Executed Agreements", "Title did not match");
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelect();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelect1();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelect2();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSearchBox();
        }
    }
}
